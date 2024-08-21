using System;
using System.Runtime.InteropServices;

namespace UnityTSGame
{
    public enum SQLite3Result
    {
        OK = 0,/* Successful result */
        ERROR = 1,/* sql error or missing database */
        INTERNAL = 2,/* Internal logic error in sqlite */
        PERM = 3,/* Access permission denied */
        ABORT = 4,/* Callback routine requested an abort */
        BUSY = 5,/* The database file is locked */
        LOCKED = 6,/* A table in the database is locked */
        NOMEM = 7,/* A malloc() Failed */
        READONLY = 8,/* Attempt to write a readonly database */
        INTERRUPT = 9,/* Operation terminated by sqlite3_interrupt()*/
        IOERR = 10,/* Some kind of disk I/O error occurred */
        CORRUPT = 11,/* The database disk image is malformed */
        NOTFOUND = 12,/* UnkNown opcode in sqlite3_file_control() */
        FULL = 13,/* Insertion Failed because database is full */
        CANTOPEN = 14,/* Unable to open the database file */
        PROTOCOL = 15,/* Database lock protocol error */
        EMPTY = 16,/* Database is empty */
        SCHEMA = 17,/* The database schema changed */
        TOOBIG = 18,/* String or BLOB exceeds size limit */
        CONSTRAINT = 19,/* Abort due to constraint violation */
        MISMATCH = 20,/* Data type mismatch */
        MISUSE = 21,/* Library used incorrectly */
        NOLFS = 22,/* Uses OS features not supported on host */
        AUTH = 23,/* Authorization denied */
        FORMAT = 24,/* Auxiliary database format error */
        RANGE = 25,/* 2nd parameter to sqlite3_bind out of range */
        NOTADB = 26,/* File opened that is not a database file */
        ROW = 100,/* sqlite3_step() has another row ready */
        DONE = 101,/* sqlite3_step() has finished executing */
    }

    public class SQLite3
    {

#if UNITY_EDITOR
        private const string DLL_NAME = "sqlite3";
#elif UNITY_STANDALONE
        private const string DLL_NAME = "sqlite3";
#elif UNITY_WSA // define directive for Universal Windows Platform.
		private const string DLL_NAME = "sqlite3";
#elif UNITY_ANDROID
		private const string DLL_NAME = "sqlite3";
#elif UNITY_IOS
		private const string DLL_NAME = "__Internal";
#endif

        public static string bfgame_database_key_word = "ckN*Qmx@mS3Z$5p!ItK!0Lo0SqSvp74$";

        public static SQLite3Result Open(string filename, ref IntPtr pdb)
        {
            return (SQLite3Result)sqlite3_open(filename, ref pdb);
        }

        public static SQLite3Result Key(IntPtr db, string zKey, int nByte)
        {
            return (SQLite3Result)sqlite3_key(db, zKey, nByte);
        }

        public static SQLite3Result Prepare2(IntPtr db, string zSql, int nByte, ref IntPtr ppStmt, ref IntPtr pzTail)
        {
            return (SQLite3Result)sqlite3_prepare_v2(db, zSql, nByte, ref ppStmt, ref pzTail);
        }

        public static IntPtr Prepare2(IntPtr db, string zSql)
        {
            IntPtr stmt = IntPtr.Zero;
            IntPtr pTail = IntPtr.Zero;
            sqlite3_prepare_v2(db, zSql, zSql.Length, ref stmt, ref pTail);
            return stmt;
        }

        public static SQLite3Result Step(IntPtr pStmt)
        {
            return (SQLite3Result)sqlite3_step(pStmt);
        }

        public static SQLite3Result Reset(IntPtr pStmt)
        {
            return (SQLite3Result)sqlite3_reset(pStmt);
        }

        public static SQLite3Result Finalize(IntPtr pStmt)
        {
            return (SQLite3Result)sqlite3_finalize(pStmt);
        }

        public static SQLite3Result Close(IntPtr db)
        {
            return (SQLite3Result)sqlite3_close(db);
        }

        public static SQLite3Result EnableLoadExtension(IntPtr db, int onoff)
        {
            return (SQLite3Result)sqlite3_enable_load_extension(db, onoff);
        }

        public static IntPtr ColumnBlob(IntPtr pStmt, int iCol)
        {
            return sqlite3_column_blob(pStmt, iCol);
        }

        public static int ColumnInt(IntPtr pStmt, int iCol)
        {
            return sqlite3_column_int(pStmt, iCol);
        }

        public static long ColumnInt64(IntPtr pStmt, int iCol)
        {
            return sqlite3_column_int64(pStmt, iCol);
        }

        public static double ColumnDouble(IntPtr pStmt, int iCol)
        {
            return sqlite3_column_double(pStmt, iCol);
        }

        public static IntPtr ColumnText(IntPtr pStmt, int iCol)
        {
            return sqlite3_column_text(pStmt, iCol);
        }

        public static IntPtr ColumnText16(IntPtr pStmt, int iCol)
        {
            return sqlite3_column_text16(pStmt, iCol);
        }

        public static int ColumnBytes(IntPtr pStmt, int iCol)
        {
            return sqlite3_column_bytes(pStmt, iCol);
        }

        public static int ColumnBytes16(IntPtr pStmt, int iCol)
        {
            return sqlite3_column_bytes16(pStmt, iCol);
        }

        public static int ColumnType(IntPtr pStmt, int iCol)
        {
            return sqlite3_column_type(pStmt, iCol);
        }

        public static int ColumnCount(IntPtr pStmt)
        {
            return sqlite3_column_count(pStmt);
        }

        public static string ColumnName(IntPtr pStmt, int iCol)
        {
            var pName = sqlite3_column_name(pStmt, iCol);
            return Marshal.PtrToStringUTF8(pName);
        }

        public static IntPtr ColumnName16(IntPtr pStmt, int iCol)
        {
            return sqlite3_column_name16(pStmt, iCol);
        }

        public static string ColumnString(IntPtr pStmt, int iCol)
        {
            IntPtr strPtr = sqlite3_column_text(pStmt, iCol);
            int size = sqlite3_column_bytes(pStmt, iCol);
            return Marshal.PtrToStringUTF8(strPtr, size);
        }

        public static byte[] ColumnByteArray(IntPtr pStmt, int iCol)
        {
            IntPtr strPtr = sqlite3_column_text(pStmt, iCol);
            int size = sqlite3_column_bytes(pStmt, iCol);
            var data = new byte[size];
            Marshal.Copy(strPtr, data, 0, size);
            return data;
        }

        public static SQLite3Result BindBlob(IntPtr pStmt, int iCol, byte[] val, int n, IntPtr free)
        {
            return (SQLite3Result)sqlite3_bind_blob(pStmt, iCol, val, n, free);
        }

        public static SQLite3Result BindInt(IntPtr pStmt, int iCol, int val)
        {
            return (SQLite3Result)sqlite3_bind_int(pStmt, iCol, val);
        }

        public static SQLite3Result BindInt64(IntPtr pStmt, int iCol, long val)
        {
            return (SQLite3Result)sqlite3_bind_int64(pStmt, iCol, val);
        }

        public static SQLite3Result BindDouble(IntPtr pStmt, int iCol, double val)
        {
            return (SQLite3Result)sqlite3_bind_double(pStmt, iCol, val);
        }

        public static SQLite3Result BindText(IntPtr pStmt, int iCol, string val, int n, IntPtr free)
        {
            return (SQLite3Result)sqlite3_bind_text(pStmt, iCol, val, n, free);
        }

        public static SQLite3Result BindNull(IntPtr pStmt, int iCol)
        {
            return (SQLite3Result)sqlite3_bind_null(pStmt, iCol);
        }

        public static SQLite3Result BindString(IntPtr pStmt, int iCol, string val)
        {
            var pFree = IntPtr.Zero;
            return (SQLite3Result)sqlite3_bind_text(pStmt, iCol, val, val.Length, pFree);
        }

        public static SQLite3Result BindParemeterIndex(IntPtr pStmt, string name)
        {
            return (SQLite3Result)sqlite3_bind_parameter_index(pStmt, name);
        }

        public static string ColumnErrMsg16(IntPtr db)
        {
            IntPtr strPtr = sqlite3_errmsg16(db);
            return Marshal.PtrToStringUni(strPtr);
        }

        public static long LastInsertRowId(IntPtr db)
        {
            return sqlite3_last_insert_rowid(db);
        }

        public static IntPtr GetTable(IntPtr db, string cmd, ref IntPtr dbResult, ref int nRow, ref int nColumn, ref string errmsg)
        {
            return sqlite3_get_table(db, cmd, ref dbResult, ref nRow, ref nColumn, ref errmsg);
        }

        public static IntPtr FreeTable(IntPtr dbResult)
        {
            return sqlite3_free_table(dbResult);
        }

        public static SQLite3Result BusyTimeOut(IntPtr db, int ms)
        {
            return (SQLite3Result)sqlite3_busy_timeout(db, ms);
        }

        public static int TotalChanges(IntPtr db)
        {
            return sqlite3_total_changes(db);
        }

        public static long TotalChanges64(IntPtr db)
        {
            return sqlite3_total_changes64(db);
        }

        public static SQLite3Result Exec(IntPtr db, string zSql)
        {
            var err = IntPtr.Zero;
            return (SQLite3Result)sqlite3_exec(db, zSql, IntPtr.Zero, IntPtr.Zero, ref err);
        }

        [DllImport(DLL_NAME)]
        private static extern int sqlite3_open(string filename, ref IntPtr pdb);

        [DllImport(DLL_NAME)]
        private static extern int sqlite3_key(IntPtr pdb, string zKey, int nByte);

        [DllImport(DLL_NAME)]
        private static extern int sqlite3_prepare_v2(IntPtr db, string zSql, int nByte, ref IntPtr ppStmt, ref IntPtr pzTail);

        [DllImport(DLL_NAME)]
        private static extern int sqlite3_step(IntPtr pStmt);

        [DllImport(DLL_NAME)]
        private static extern int sqlite3_reset(IntPtr pStmt);

        [DllImport(DLL_NAME)]
        private extern static int sqlite3_finalize(IntPtr pStmt);

        [DllImport(DLL_NAME)]
        private extern static int sqlite3_close(IntPtr db);

        [DllImport(DLL_NAME)]
        private extern static int sqlite3_enable_load_extension(IntPtr db, int onoff);

        [DllImport(DLL_NAME)]
        private extern static IntPtr sqlite3_column_blob(IntPtr pStmt, int iCol);

        [DllImport(DLL_NAME)]
        private extern static int sqlite3_column_int(IntPtr pStmt, int iCol);

        [DllImport(DLL_NAME)]
        private extern static long sqlite3_column_int64(IntPtr pStmt, int iCol);

        [DllImport(DLL_NAME)]
        private extern static double sqlite3_column_double(IntPtr pStmt, int iCol);

        [DllImport(DLL_NAME)]
        private extern static IntPtr sqlite3_column_text(IntPtr pStmt, int iCol); //返回的字符串为UTF-8编码格式
        
        [DllImport(DLL_NAME)]
        private extern static IntPtr sqlite3_column_text16(IntPtr pStmt, int iCol); //返回的字符串为UTF-16编码格式

        [DllImport(DLL_NAME)]
        private extern static int sqlite3_column_bytes(IntPtr pStmt, int iCol); //返回UTF-8编码格式的字符串的长度
        
        [DllImport(DLL_NAME)]
        private extern static int sqlite3_column_bytes16(IntPtr pStmt, int iCol); //返回UTF-16编码格式的字符串的长度

        [DllImport(DLL_NAME)]
        private extern static int sqlite3_column_type(IntPtr pStmt, int iCol);

        [DllImport(DLL_NAME)]
        private extern static int sqlite3_column_count(IntPtr pStmt);

        [DllImport(DLL_NAME)]
        private extern static IntPtr sqlite3_column_name(IntPtr pStmt, int iCol);

        [DllImport(DLL_NAME)]
        private extern static IntPtr sqlite3_column_name16(IntPtr pStmt, int iCol);

        [DllImport(DLL_NAME)]
        private extern static int sqlite3_bind_blob(IntPtr pStmt, int iCol, byte[] val, int n, IntPtr free);

        [DllImport(DLL_NAME)]
        private extern static int sqlite3_bind_int(IntPtr pStmt, int iCol, int val);

        [DllImport(DLL_NAME)]
        private extern static int sqlite3_bind_int64(IntPtr pStmt, int iCol, long val);

        [DllImport(DLL_NAME)]
        private extern static int sqlite3_bind_double(IntPtr pStmt, int iCol, double val);

        [DllImport(DLL_NAME)]
        private extern static int sqlite3_bind_text(IntPtr pStmt, int iCol, string val, int n, IntPtr free);
        
        [DllImport(DLL_NAME)]
        private extern static int sqlite3_bind_null(IntPtr pStmt, int iCol);

        [DllImport(DLL_NAME)]
        private extern static int sqlite3_bind_parameter_index(IntPtr pStmt, string name);

        [DllImport(DLL_NAME)]
        private extern static IntPtr sqlite3_errmsg16(IntPtr db); //返回的字符串为UTF-16编码格式

        [DllImport(DLL_NAME)]
        private extern static long sqlite3_last_insert_rowid(IntPtr db);

        [DllImport(DLL_NAME)]
        private extern static IntPtr sqlite3_get_table(IntPtr db, string zSql, ref IntPtr dbResult, ref int nRow, ref int nColumn, ref string errmsg);

        [DllImport(DLL_NAME)]
        private extern static IntPtr sqlite3_free_table(IntPtr dbResult);

        [DllImport(DLL_NAME)]
        private extern static int sqlite3_busy_timeout(IntPtr db, int ms);

        [DllImport(DLL_NAME)]
        private extern static int sqlite3_total_changes(IntPtr db);

        [DllImport(DLL_NAME)]
        private extern static long sqlite3_total_changes64(IntPtr db);

        [DllImport(DLL_NAME)]
        private extern static int sqlite3_exec(IntPtr db, string zSql, IntPtr callback, IntPtr firstArg, ref IntPtr errmsg);
    }
}