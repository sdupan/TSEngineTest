using System;
using System.Collections.Generic;
using System.Threading;
using System.Collections.Concurrent;

namespace UnityTSGame
{
    public class JSSnapshotData
    {
        public long autoId;
        public long time;
        public int protoId;
        public byte[] datas;

        public JSSnapshotData()
        {
            autoId = 0;
            time = 0;
            protoId = 0;
            datas = null;
        }
    }

    public class JSOPData
    {
        public int result;
        public List<JSSnapshotData> snapshot;
        public string stringData;

        public JSOPData()
        {
            result = 0;
            snapshot = null;
            stringData = null;
        }
    }

    public class SQLite_OP_Data
    {
        public int id;
        public string sql;
        public int opType;          // 1-读KV 2-读Proto 3-写Proto 4-执行
        public JSOPData opData;

        public SQLite_OP_Data()
        {
            id = 0;
            sql = null;
            opType = 0;
            opData = new JSOPData();
        }
    }

    public class SQLHandler
    {
        public Action<int, int, JSOPData> opEndAction;
        protected IntPtr sqlite3Handle;
        protected Thread workThread;
        protected ConcurrentQueue<SQLite_OP_Data> queue;
        protected SynchronizationContext mainThreadContext;

        public SQLHandler()
        {
            sqlite3Handle = IntPtr.Zero;
            workThread = null;
            queue = new ConcurrentQueue<SQLite_OP_Data>();
            mainThreadContext = SynchronizationContext.Current;
        }

        public SQLite3Result Open(string path)
        {
            var res = SQLite3.Open(path, ref sqlite3Handle);
            if (res == SQLite3Result.OK)
            {
                workThread = new Thread(new ThreadStart(Sqlite3Thread))
                {
                    IsBackground = true
                };
                workThread.Start();
            }

            return res;
        }

        public void Destroy()
        {
            if (sqlite3Handle != IntPtr.Zero)
            {
                SQLite3.Close(sqlite3Handle);
                sqlite3Handle = IntPtr.Zero;
            }

            workThread = null;
            opEndAction = null;
        }

        public void AddOperation(SQLite_OP_Data data)
        {
            queue.Enqueue(data);
        }

        public SQLite3Result Key(string key)
        {
            if(sqlite3Handle == IntPtr.Zero)
            {
                return SQLite3Result.INTERNAL;
            }

            return SQLite3.Key(sqlite3Handle, key, key.Length);
        }

        public SQLite3Result CheckTable(string sql)
        {
            if(sqlite3Handle == IntPtr.Zero)
            {
                return SQLite3Result.INTERNAL;
            }

            return SQLite3.Exec(sqlite3Handle, sql);
        }
        
        public IntPtr Prepare2(string sql)
        {
            if(sqlite3Handle == IntPtr.Zero)
            {
                return IntPtr.Zero;
            }

            return SQLite3.Prepare2(sqlite3Handle, sql);
        }

        public SQLite3Result Step(IntPtr stmt)
        {
            if(sqlite3Handle == IntPtr.Zero)
            {
                return SQLite3Result.INTERNAL;
            }

            return SQLite3.Step(stmt);
        }

        public SQLite3Result Finalize(IntPtr stmt)
        {
            if(sqlite3Handle == IntPtr.Zero)
            {
                return SQLite3Result.INTERNAL;
            }

            return SQLite3.Finalize(stmt);
        }

        protected void ThreadOperationEnd(int id, int opType, JSOPData opData)
        {
            if(JSManager.JSEnvDisposed()) {
                return;
            }
            
            opEndAction?.Invoke(id, opType, opData);
        }

        protected JSOPData ReadKV(SQLite_OP_Data op)
        {
            JSOPData opData = new()
            {
                result = -1
            };

            var stmt = SQLite3.Prepare2(sqlite3Handle, op.sql);
            var res = SQLite3.Step(stmt);
            if (res == SQLite3Result.ROW)
            {
                opData.result = 0;
                opData.stringData = SQLite3.ColumnString(stmt, 0);
            }

            SQLite3.Finalize(stmt);
            return opData;
        }

        protected JSOPData ReadProto(SQLite_OP_Data op)
        {
            JSOPData opData = new()
            {
                result = -1,
                snapshot = new List<JSSnapshotData>(),
            };

            var stmt = SQLite3.Prepare2(sqlite3Handle, op.sql);
            var res = SQLite3.Step(stmt);
            while (res == SQLite3Result.ROW)
            {
                var data = new JSSnapshotData
                {
                    autoId = SQLite3.ColumnInt64(stmt, 0),
                    time = SQLite3.ColumnInt64(stmt, 1),
                    protoId = SQLite3.ColumnInt(stmt, 2),
                    datas = SQLite3.ColumnByteArray(stmt, 3)
                };
                opData.result = 0;
                opData.snapshot.Add(data);
                res = SQLite3.Step(stmt);
            }

            SQLite3.Finalize(stmt);
            return opData;
        }

        protected JSOPData WriteProto(SQLite_OP_Data op)
        {
            SQLite3.Exec(sqlite3Handle, "begin;");
            var stmt = SQLite3.Prepare2(sqlite3Handle, op.sql);
            for (var i = 0; i < op.opData.snapshot.Count; i++)
            {
                SQLite3.BindInt64(stmt, 1, op.opData.snapshot[i].time);
                SQLite3.BindInt(stmt, 2, op.opData.snapshot[i].protoId);
                SQLite3.BindBlob(stmt, 3, op.opData.snapshot[i].datas, op.opData.snapshot[i].datas.Length, IntPtr.Zero);
                SQLite3.Step(stmt);
                SQLite3.Reset(stmt);
            }

            SQLite3.Finalize(stmt);
            var res = SQLite3.Exec(sqlite3Handle, "commit;");

            JSOPData opData = new()
            {
                result = res == SQLite3Result.OK ? 0 : -1
            };

            return opData;
        }

        protected JSOPData Execute(SQLite_OP_Data op)
        {
            var res = SQLite3.Exec(sqlite3Handle, op.sql);
            JSOPData opData = new()
            {
                result = res == SQLite3Result.OK ? 0 : -1
            };

            return opData;
        }

        protected void Sqlite3Thread()
        {
            JSOPData opData = null;
            SQLite_OP_Data handleData = null;
            bool succ = false;
            while (sqlite3Handle != IntPtr.Zero)
            {
                succ = queue.TryDequeue(out handleData);
                if(succ && handleData != null)
                {
                    switch (handleData.opType)
                    {
                        case 1:
                            opData = ReadKV(handleData);
                            break;
                        case 2:
                            opData = ReadProto(handleData);
                            break;
                        case 3:
                            opData = WriteProto(handleData);
                            break;
                        case 4:
                            opData = Execute(handleData);
                            break;
                        default:
                            break;
                    }
                    
                    try
                    {
                        mainThreadContext.Send((state) => {
                            ThreadOperationEnd(handleData.id, handleData.opType, opData);
                        }, null);
                    }
                    catch(Exception e)
                    {
                        UnityEngine.Debug.Log(e);
                    }

                    handleData = null;
                }
                else {
                    handleData = null;
                    Thread.Sleep(1);
                }
            }
        }
    }
}