using UnityEngine;

namespace LitJson
{
    public interface IJsonWrapper : IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary
    {
        // Properties
        public abstract bool IsArray { get; }
        public abstract bool IsBoolean { get; }
        public abstract bool IsDouble { get; }
        public abstract bool IsInt { get; }
        public abstract bool IsLong { get; }
        public abstract bool IsObject { get; }
        public abstract bool IsString { get; }
        
        // Methods
        public abstract bool get_IsArray(); // 0
        public abstract bool get_IsBoolean(); // 0
        public abstract bool get_IsDouble(); // 0
        public abstract bool get_IsInt(); // 0
        public abstract bool get_IsLong(); // 0
        public abstract bool get_IsObject(); // 0
        public abstract bool get_IsString(); // 0
        public abstract bool GetBoolean(); // 0
        public abstract double GetDouble(); // 0
        public abstract int GetInt(); // 0
        public abstract LitJson.JsonType GetJsonType(); // 0
        public abstract long GetLong(); // 0
        public abstract string GetString(); // 0
        public abstract void SetBoolean(bool val); // 0
        public abstract void SetDouble(double val); // 0
        public abstract void SetInt(int val); // 0
        public abstract void SetJsonType(LitJson.JsonType type); // 0
        public abstract void SetLong(long val); // 0
        public abstract void SetString(string val); // 0
        public abstract string ToJson(); // 0
        public abstract void ToJson(LitJson.JsonWriter writer); // 0
    
    }

}
