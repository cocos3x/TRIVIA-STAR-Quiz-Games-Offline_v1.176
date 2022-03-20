using UnityEngine;

namespace SnakesAndLaddersEvent
{
    public class Board
    {
        // Fields
        private const string NUMBER_SPACE = "num";
        private const string IS_SEEN = "seen";
        public readonly SnakesAndLaddersEvent.BoardDefinition Definition;
        public int CurrentNumberSpace;
        public bool IsSeen;
        
        // Methods
        public Board(SnakesAndLaddersEvent.BoardDefinition definition)
        {
            SnakesAndLaddersEvent.BoardDefinition val_1 = definition;
            val_1 = new System.Object();
            this.Definition = val_1;
            this.CurrentNumberSpace = 0;
            this.IsSeen = 0;
        }
        public float GetPercentProgress()
        {
            float val_1 = (float)this.Definition.MaxSpaceCount;
            val_1 = (float)this.CurrentNumberSpace / val_1;
            return (float)val_1;
        }
        public bool IsFinished()
        {
            float val_2 = (float)this.Definition.MaxSpaceCount;
            val_2 = (float)this.CurrentNumberSpace / val_2;
            return (bool)val_2.Equals(obj:  val_2);
        }
        public int GetIndex()
        {
            null = null;
            System.Predicate<ZooTile> val_1 = new System.Predicate<ZooTile>(object:  679884976, method:  new IntPtr(679857904));
            if(SnakesAndLaddersEvent.Econ.BoardDefinitions != 0)
            {
                    return SnakesAndLaddersEvent.Econ.BoardDefinitions.FindIndex(match:  8040448);
            }
            
            return SnakesAndLaddersEvent.Econ.BoardDefinitions.FindIndex(match:  8040448);
        }
        public void LoadProgress(string data)
        {
            var val_10;
            object val_1 = MiniJSON.Json.Deserialize(json:  data);
            val_10 = "num";
            if((0.ContainsKey(key:  679977072)) != false)
            {
                    string val_3 = 0.Item[679977072];
                val_10 = 0;
                bool val_5 = System.Int32.TryParse(s:  null, result: out  this.CurrentNumberSpace);
            }
            
            if((0.ContainsKey(key:  679977152)) == false)
            {
                    return;
            }
            
            string val_7 = 0.Item[679977152];
            bool val_9 = System.Boolean.TryParse(value:  null, result: out  this.IsSeen);
        }
        public override string ToString()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  679977072, value:  13152256);
            Add(key:  679977152, value:  8945664);
            string val_2 = MiniJSON.Json.Serialize(obj:  78753792);
        }
        private bool <GetIndex>b__8_0(SnakesAndLaddersEvent.BoardDefinition x)
        {
            int val_1 = this.Definition.MaxSpaceCount;
            val_1 = x.MaxSpaceCount - val_1;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
    
    }

}
