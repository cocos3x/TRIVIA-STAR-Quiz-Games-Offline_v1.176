using UnityEngine;

namespace WordForest
{
    public class ChestData
    {
        // Fields
        public int WordIndex;
        public int CellIndex;
        private int collected;
        
        // Properties
        public bool Collected { get; set; }
        
        // Methods
        public bool get_Collected()
        {
            int val_1 = this.collected;
            val_1 = val_1 - 1;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        public void set_Collected(bool value)
        {
            if(value == true)
            {
                    0 = 1;
            }
            
            this.collected = 1;
        }
        public string Serialize()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(value:  329134704);
        }
        public ChestData()
        {
            this.collected = 0;
        }
        public ChestData(int wordIndex, int cellIndex, bool isCollected)
        {
            this.collected = 0;
            this.WordIndex = wordIndex;
            if(isCollected == true)
            {
                    0 = 1;
            }
            
            this.CellIndex = cellIndex;
            this.collected = 1;
        }
        public ChestData(string serialized)
        {
            this.collected = 0;
            object val_1 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  serialized);
            if(serialized != null)
            {
                    this.WordIndex = serialized.m_stringLength;
                this.CellIndex = serialized.m_firstChar;
            }
            else
            {
                    this.WordIndex = 0;
                this.CellIndex = 0;
            }
            
            this.collected = 0;
        }
    
    }

}
