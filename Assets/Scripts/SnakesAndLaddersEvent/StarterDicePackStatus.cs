using UnityEngine;

namespace SnakesAndLaddersEvent
{
    public class StarterDicePackStatus
    {
        // Fields
        private const string IS_SHOWN = "shown";
        private const string IS_PURCHASED = "purchased";
        private const string START_TIME = "time";
        public bool IsShown;
        public bool IsPurchased;
        public System.DateTime StartTime;
        
        // Methods
        public StarterDicePackStatus()
        {
            mem[1152921513877139300] = 0;
            this.StartTime = 0;
            this.IsShown = 0;
            this.IsPurchased = false;
        }
        public StarterDicePackStatus(string data)
        {
            bool val_13;
            object val_1 = MiniJSON.Json.Deserialize(json:  data);
            if((0.ContainsKey(key:  -1159100144)) != false)
            {
                    string val_3 = 0.Item[-1159100144];
                val_13 = this.IsShown;
                bool val_5 = System.Boolean.TryParse(value:  null, result: out  val_13);
            }
            
            if((0.ContainsKey(key:  -1700598896)) != false)
            {
                    string val_7 = 0.Item[-1700598896];
                val_13 = this.IsPurchased;
                bool val_9 = System.Boolean.TryParse(value:  null, result: out  val_13);
            }
            
            if((0.ContainsKey(key:  1956820704)) == false)
            {
                    return;
            }
            
            string val_11 = 0.Item[1956820704];
            bool val_12 = System.DateTime.TryParse(s:  null, result: out  new System.DateTime() {dateData = this.StartTime});
        }
        public System.TimeSpan GetTimeLeft()
        {
            var val_4;
            var val_4 = R1;
            val_4 = val_4 + 16;
            val_4 = null;
            val_4 = null;
            System.DateTime val_1 = AddMinutes(value:  null);
            System.DateTime val_2 = DateTimeCheat.Now;
            System.TimeSpan val_3 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513877371472}, d2:  new System.DateTime());
            return new System.TimeSpan() {_ticks = val_3._ticks};
        }
        public bool IsOutOfTime()
        {
            var val_3;
            bool val_1 = System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = this.StartTime}, d2:  new System.DateTime());
            if(val_1 == true)
            {
                    return true;
            }
            
            System.TimeSpan val_2 = GetTimeLeft();
            double val_5 = val_3.TotalSeconds;
            if(val_1 <= false)
            {
                    0 = 1;
            }
            
            return true;
        }
        public override string ToString()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  -1159100144, value:  8945664);
            Add(key:  -1700598896, value:  8945664);
            string val_2 = this.StartTime.ToString();
            Add(key:  1956820704, value:  this.StartTime);
            string val_3 = MiniJSON.Json.Serialize(obj:  78753792);
        }
    
    }

}
