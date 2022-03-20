using UnityEngine;

namespace SnakesAndLaddersEvent
{
    public class MovingDiceRollProgress
    {
        // Fields
        private const string LINEWORD_INDEX = "word_index";
        private const string CELL_INDEX = "cell_index";
        private const string LAST_LEVEL = "last_level";
        private const string IS_COLLECTED = "collected";
        private const string IS_MISSED = "missed";
        public int LinewordIndex;
        public int CellIndex;
        public int LastLevel;
        public bool IsCollected;
        public bool IsMissed;
        
        // Methods
        public MovingDiceRollProgress()
        {
        
        }
        public MovingDiceRollProgress(string data)
        {
            bool val_22;
            object val_1 = MiniJSON.Json.Deserialize(json:  data);
            if((0.ContainsKey(key:  681018000)) != false)
            {
                    string val_3 = 0.Item[681018000];
                bool val_5 = System.Int32.TryParse(s:  null, result: out  this.LinewordIndex);
            }
            
            if((0.ContainsKey(key:  681018096)) != false)
            {
                    string val_7 = 0.Item[681018096];
                bool val_9 = System.Int32.TryParse(s:  null, result: out  this.CellIndex);
            }
            
            if((0.ContainsKey(key:  681018192)) != false)
            {
                    string val_11 = 0.Item[681018192];
                bool val_13 = System.Int32.TryParse(s:  null, result: out  this.LastLevel);
            }
            
            if((0.ContainsKey(key:  -1584759760)) != false)
            {
                    string val_15 = 0.Item[-1584759760];
                val_22 = this.IsCollected;
                bool val_17 = System.Boolean.TryParse(value:  null, result: out  val_22);
            }
            
            if((0.ContainsKey(key:  681018288)) == false)
            {
                    return;
            }
            
            string val_19 = 0.Item[681018288];
            bool val_21 = System.Boolean.TryParse(value:  null, result: out  this.IsMissed);
        }
        public override string ToString()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  681018000, value:  13152256);
            Add(key:  681018096, value:  13152256);
            Add(key:  681018192, value:  13152256);
            Add(key:  -1584759760, value:  8945664);
            Add(key:  681018288, value:  8945664);
            string val_2 = MiniJSON.Json.Serialize(obj:  78753792);
        }
    
    }

}
