using UnityEngine;

namespace LitJson
{
    public class JsonMockWrapper : IJsonWrapper, IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary
    {
        // Properties
        public bool IsArray { get; }
        public bool IsBoolean { get; }
        public bool IsDouble { get; }
        public bool IsInt { get; }
        public bool IsLong { get; }
        public bool IsObject { get; }
        public bool IsString { get; }
        private bool System.Collections.IList.IsFixedSize { get; }
        private bool System.Collections.IList.IsReadOnly { get; }
        private object System.Collections.IList.Item { get; set; }
        private int System.Collections.ICollection.Count { get; }
        private bool System.Collections.ICollection.IsSynchronized { get; }
        private object System.Collections.ICollection.SyncRoot { get; }
        private bool System.Collections.IDictionary.IsFixedSize { get; }
        private bool System.Collections.IDictionary.IsReadOnly { get; }
        private System.Collections.ICollection System.Collections.IDictionary.Keys { get; }
        private System.Collections.ICollection System.Collections.IDictionary.Values { get; }
        private object System.Collections.IDictionary.Item { get; set; }
        private object System.Collections.Specialized.IOrderedDictionary.Item { get; set; }
        
        // Methods
        public bool get_IsArray()
        {
            return false;
        }
        public bool get_IsBoolean()
        {
            return false;
        }
        public bool get_IsDouble()
        {
            return false;
        }
        public bool get_IsInt()
        {
            return false;
        }
        public bool get_IsLong()
        {
            return false;
        }
        public bool get_IsObject()
        {
            return false;
        }
        public bool get_IsString()
        {
            return false;
        }
        public bool GetBoolean()
        {
            return false;
        }
        public double GetDouble()
        {
            return (double)D0;
        }
        public int GetInt()
        {
            return 0;
        }
        public LitJson.JsonType GetJsonType()
        {
        
        }
        public long GetLong()
        {
            return 0;
        }
        public string GetString()
        {
        
        }
        public void SetBoolean(bool val)
        {
        
        }
        public void SetDouble(double val)
        {
        
        }
        public void SetInt(int val)
        {
        
        }
        public void SetJsonType(LitJson.JsonType type)
        {
        
        }
        public void SetLong(long val)
        {
        
        }
        public void SetString(string val)
        {
        
        }
        public string ToJson()
        {
        
        }
        public void ToJson(LitJson.JsonWriter writer)
        {
        
        }
        private bool System.Collections.IList.get_IsFixedSize()
        {
            return true;
        }
        private bool System.Collections.IList.get_IsReadOnly()
        {
            return true;
        }
        private object System.Collections.IList.get_Item(int index)
        {
        
        }
        private void System.Collections.IList.set_Item(int index, object value)
        {
        
        }
        private int System.Collections.IList.Add(object value)
        {
            return 0;
        }
        private void System.Collections.IList.Clear()
        {
        
        }
        private bool System.Collections.IList.Contains(object value)
        {
            return false;
        }
        private int System.Collections.IList.IndexOf(object value)
        {
            return 0;
        }
        private void System.Collections.IList.Insert(int i, object v)
        {
        
        }
        private void System.Collections.IList.Remove(object value)
        {
        
        }
        private void System.Collections.IList.RemoveAt(int index)
        {
        
        }
        private int System.Collections.ICollection.get_Count()
        {
            return 0;
        }
        private bool System.Collections.ICollection.get_IsSynchronized()
        {
            return false;
        }
        private object System.Collections.ICollection.get_SyncRoot()
        {
        
        }
        private void System.Collections.ICollection.CopyTo(System.Array array, int index)
        {
        
        }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
        
        }
        private bool System.Collections.IDictionary.get_IsFixedSize()
        {
            return true;
        }
        private bool System.Collections.IDictionary.get_IsReadOnly()
        {
            return true;
        }
        private System.Collections.ICollection System.Collections.IDictionary.get_Keys()
        {
        
        }
        private System.Collections.ICollection System.Collections.IDictionary.get_Values()
        {
        
        }
        private object System.Collections.IDictionary.get_Item(object key)
        {
        
        }
        private void System.Collections.IDictionary.set_Item(object key, object value)
        {
        
        }
        private void System.Collections.IDictionary.Add(object k, object v)
        {
        
        }
        private void System.Collections.IDictionary.Clear()
        {
        
        }
        private bool System.Collections.IDictionary.Contains(object key)
        {
            return false;
        }
        private void System.Collections.IDictionary.Remove(object key)
        {
        
        }
        private System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
        {
        
        }
        private object System.Collections.Specialized.IOrderedDictionary.get_Item(int idx)
        {
        
        }
        private void System.Collections.Specialized.IOrderedDictionary.set_Item(int idx, object value)
        {
        
        }
        private System.Collections.IDictionaryEnumerator System.Collections.Specialized.IOrderedDictionary.GetEnumerator()
        {
        
        }
        private void System.Collections.Specialized.IOrderedDictionary.Insert(int i, object k, object v)
        {
        
        }
        private void System.Collections.Specialized.IOrderedDictionary.RemoveAt(int i)
        {
        
        }
        public JsonMockWrapper()
        {
        
        }
    
    }

}
