using UnityEngine;

namespace WordForest
{
    public class ChestLocData
    {
        // Fields
        public int GameLevel;
        public System.Collections.Generic.List<WordForest.ChestData> ChestsData;
        
        // Methods
        public string Serialize()
        {
            twelvegigs.sweepstakes.Distribution val_5;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  329567920, value:  13152256);
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            List.Enumerator<T> val_3 = GetEnumerator();
            label_6:
            if(MoveNext() == false)
            {
                goto label_3;
            }
            
            string val_6 = val_5.Serialize();
            Add(item:  val_5);
            goto label_6;
            label_3:
            Dispose();
            string val_7 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  80883712);
            Add(key:  329575184, value:  80883712);
            string val_8 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  78753792);
        }
        public ChestLocData()
        {
            this.GameLevel = 0;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.ChestsData = null;
        }
        public ChestLocData(string serialized)
        {
            string val_10;
            string val_2 = serialized;
            mem[1152921513526616120] = 0;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            mem[1152921513526616124] = null;
            val_2 = new System.Object();
            object val_3 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  val_2);
            string val_4 = val_2.Item[329567920];
            mem[1152921513526616120] = System.Int32.Parse(s:  val_2);
            string val_6 = val_2.Item[329575184];
            object val_7 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  val_2);
            List.Enumerator<T> val_8 = GetEnumerator();
            label_10:
            if(MoveNext() == false)
            {
                goto label_8;
            }
            
            WordForest.ChestData val_11 = new WordForest.ChestData(serialized:  val_10);
            Add(item:  408838144);
            goto label_10;
            label_8:
            Dispose();
        }
    
    }

}
