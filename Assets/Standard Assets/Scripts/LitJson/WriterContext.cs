using UnityEngine;

namespace LitJson
{
    internal class WriterContext
    {
        // Fields
        public int Count;
        public bool InArray;
        public bool InObject;
        public bool ExpectingValue;
        public int Padding;
        
        // Methods
        public WriterContext()
        {
        
        }
    
    }

}
