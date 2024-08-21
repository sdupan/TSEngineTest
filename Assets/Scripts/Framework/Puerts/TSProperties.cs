using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;
#if UNITY_EDITOR
using System.Reflection;
using UnityEditor;
#endif

[DisallowMultipleComponent]
public class TSProperties : MonoBehaviour
{
    private ResultPair[] _pairs = null;
    public ResultPair[] Pairs
    {
        get
        {
            if (_pairs == null)
                _pairs = GenPairs();
            return _pairs;
        }
    }

    void Awake()
    {
        this.enabled = false;
    }
    public ResultPair[] GenPairs()
    {
        var pairsArray = new IEnumerable<IPair>[] {
            ObjectPairs,
            StringPairs,
            NumberPairs,
            BooleanPairs,
            ObjectArrayPairs,
            GameObjectArrayPairs
        };
        var list = (from pairs in pairsArray
                    where pairs != null
                    from pair in pairs
                    where pair != null
                    select pair).ToList();
        list.Sort((v1, v2) => v1.getIndex < v2.getIndex ? -1 : v1.getIndex > v2.getIndex ? 1 : 0);
        return list.Select(o => new ResultPair(o)).ToArray();
    }

    #region 序列化字段
    [SerializeField]
    private String[] StringPairs;
    [SerializeField]
    private Number[] NumberPairs;
    [SerializeField]
    private Boolean[] BooleanPairs;
    [SerializeField]
    private Object[] ObjectPairs;
    [SerializeField]
    private ObjectArray[] ObjectArrayPairs;
    [SerializeField]
    private GameObjectArray[] GameObjectArrayPairs;
    #endregion

    public class ResultPair
    {
        public string key;
        public object value;
        internal ResultPair(IPair pair)
        {
            this.key = pair.getKey;
            this.value = pair.getValue;
        }
    }
    public interface IPair
    {
        int getIndex { get; }
        string getKey { get; }
        object getValue { get; }
    }

    #region 序列化数据类
    public class Pair<T> : IPair
    {
        public int index;
        public string key;
        public T value;

        public int getIndex { get { return this.index; } }
        public string getKey { get { return this.key; } }
        public object getValue { get { return this.value; } }
    }
    [System.Serializable]
    public class String : Pair<System.String> { }
    [System.Serializable]
    public class Number : Pair<System.Double> { }
    [System.Serializable]
    public class Boolean : Pair<System.Boolean> { }
    [System.Serializable]
    public class Object : Pair<UnityEngine.Object> { }
    [Options("Array/Object")]
    [System.Serializable]
    public class ObjectArray : Pair<UnityEngine.Object[]> { }
    [Options("Array/GameObject")]
    [System.Serializable]
    public class GameObjectArray : Pair<UnityEngine.GameObject[]> { }
    #endregion

    //Options 路径设置
    [AttributeUsageAttribute(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class OptionsAttribute : Attribute
    {
        public string path { get; private set; }
        public OptionsAttribute(string path)
        {
            this.path = path;
        }
    }
}