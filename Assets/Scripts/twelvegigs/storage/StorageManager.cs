using UnityEngine;

namespace twelvegigs.storage
{
    public class StorageManager
    {
        // Fields
        private string resourcesPath;
        private twelvegigs.storage.KnobsModel knobsModel;
        private System.Collections.Generic.Dictionary<string, object> rawKnobsResponse;
        private System.Collections.Generic.Dictionary<string, object> sortedKnobsDisplay;
        
        // Methods
        public StorageManager(string resourcesPath)
        {
            string val_2 = resourcesPath;
            this.resourcesPath = "";
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.rawKnobsResponse = null;
            val_2 = new System.Object();
            this.resourcesPath = val_2;
        }
        public void initialize()
        {
            this.knobsModel = new System.Object();
        }
        public void OnDataUpdate(System.Collections.Generic.Dictionary<string, object> response)
        {
            this.OnResponseUpdateData(response:  response);
        }
        private void OnResponseUpdateData(System.Collections.Generic.Dictionary<string, object> response)
        {
            string val_15;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            float val_24;
            var val_25;
            var val_26;
            var val_27;
            val_18 = response;
            if(val_18 == 0)
            {
                    return;
            }
            
            val_19 = "meta";
            if((val_18.ContainsKey(key:  -1824035680)) == false)
            {
                    return;
            }
            
            object val_2 = val_18.Item[-1824035680];
            val_20 = 1152921504683257856;
            if(val_18 == 0)
            {
                goto label_3;
            }
            
            val_21 = val_18;
            val_22 = null;
            if(val_21 == 0)
            {
                goto label_5;
            }
            
            val_23 = val_21;
            goto label_6;
            label_3:
            val_22 = null;
            goto label_7;
            label_5:
            label_7:
            val_23 = 0;
            label_6:
            val_24 = "versions";
            if(mem[1179403825] == 0)
            {
                goto label_8;
            }
            
            var val_19 = 0;
            label_10:
            val_21 = 0;
            val_20 = mem[mem[1179403735] + 0];
            val_20 = mem[1179403735] + 0;
            if(val_20 == val_22)
            {
                goto label_9;
            }
            
            val_19 = val_19 + 1;
            val_21 = (uint)val_19 & 65535;
            if(val_21 < mem[1179403825])
            {
                goto label_10;
            }
            
            label_8:
            val_25 = val_23;
            goto label_11;
            label_9:
            var val_3 = mem[1179403735] + 0;
            val_23 = val_23 + (((mem[1179403735] + 0) + 4) << 3);
            val_25 = val_23 + 220;
            label_11:
            if(val_23 == 0)
            {
                    return;
            }
            
            object val_4 = val_18.Item[-1824035680];
            if(val_18 == 0)
            {
                goto label_13;
            }
            
            val_21 = val_18;
            val_20 = 1152921504683257856;
            val_26 = null;
            if(val_21 == 0)
            {
                goto label_15;
            }
            
            val_24 = val_21;
            goto label_16;
            label_13:
            val_26 = null;
            goto label_17;
            label_15:
            label_17:
            val_24 = 0;
            label_16:
            val_19 = "versions";
            if(mem[1179403825] == 0)
            {
                goto label_18;
            }
            
            var val_20 = 0;
            label_20:
            val_21 = 0;
            val_20 = mem[mem[1179403735] + 0];
            val_20 = mem[1179403735] + 0;
            if(val_20 == val_26)
            {
                goto label_19;
            }
            
            val_20 = val_20 + 1;
            val_21 = (uint)val_20 & 65535;
            if(val_21 < mem[1179403825])
            {
                goto label_20;
            }
            
            label_18:
            val_27 = val_24;
            goto label_21;
            label_19:
            var val_5 = mem[1179403735] + 0;
            val_24 = val_24 + (((mem[1179403735] + 0) + 4) << 3);
            val_27 = val_24 + 188;
            label_21:
            mem[1152921514336732800] = val_18;
            if((val_18.ContainsKey(key:  1658600960)) == false)
            {
                    return;
            }
            
            object val_7 = val_18.Item[1658600960];
            val_24 = 1152921504685600768;
            val_21 = 0;
            Dictionary.Enumerator<TKey, TValue> val_8 = GetEnumerator();
            val_18 = 1152921510367989680;
            val_20 = "knobs";
            val_19 = 1152921510385700560;
            label_40:
            label_30:
            if(0.MoveNext() == false)
            {
                goto label_29;
            }
            
            if((System.String.op_Equality(a:  null, b:  -309557360)) == false)
            {
                goto label_30;
            }
            
            Dictionary.KeyCollection<TKey, TValue> val_12 = 0.Keys;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_13 = GetEnumerator();
            label_37:
            if(MoveNext() == false)
            {
                goto label_35;
            }
            
            string val_16 = 0.Item[val_15];
            string val_17 = MiniJSON.Json.Serialize(obj:  0);
            UnityEngine.PlayerPrefs.SetString(key:  val_15, value:  null);
            goto label_37;
            label_35:
            var val_18 = 0 + 1;
            mem2[0] = 227;
            Dispose();
            if(val_18 == 1)
            {
                goto label_40;
            }
            
            if((1139939096 + ((0 + 1)) << 2) == 227)
            {
                    val_18 = val_18 >> 31;
                val_18 = ~(val_18 >> 31);
                val_18 = val_18 + val_18;
            }
            
            goto label_40;
            label_29:
            0.Dispose();
        }
        public object EncodeInitialVersions()
        {
            var val_3;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            System.Collections.Generic.Dictionary<TKey, TValue> val_4 = null;
            if((mem[null + 178]) == 0)
            {
                goto label_2;
            }
            
            var val_3 = 0;
            label_4:
            if((mem[null + 88] + 0) == null)
            {
                goto label_3;
            }
            
            val_3 = val_3 + 1;
            if(((uint)val_3 & 65535) < (mem[null + 178]))
            {
                goto label_4;
            }
            
            label_2:
            val_3 = null;
            return;
            label_3:
            var val_2 = (mem[null + 88]) + 0;
            val_4 = val_4 + (((mem[null + 88] + 0) + 4) << 3);
        }
        public twelvegigs.storage.KnobsModel getKnobs()
        {
        
        }
        public string getRawKnobsResponse()
        {
            string val_9;
            var val_14;
            var val_15;
            var val_16;
            if(this.sortedKnobsDisplay != 0)
            {
                goto label_1;
            }
            
            twelvegigs.storage.JsonDictionary val_1 = this.knobsModel.getWordGameplayKnobs();
            val_14 = 0;
            val_14 = val_14 + 1;
            val_15 = this.knobsModel;
            System.Collections.Generic.IEnumerable<TResult> val_3 = System.Linq.Enumerable.Cast<System.Object>(source:  this.knobsModel);
            System.Collections.Generic.List<ZooTile> val_4 = new System.Collections.Generic.List<ZooTile>(collection:  this.knobsModel);
            if(null != 0)
            {
                    Sort();
                System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
                this.sortedKnobsDisplay = null;
            }
            else
            {
                    Sort();
                System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_6 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
                this.sortedKnobsDisplay = null;
            }
            
            List.Enumerator<T> val_7 = GetEnumerator();
            label_20:
            if(MoveNext() == false)
            {
                goto label_11;
            }
            
            twelvegigs.storage.JsonDictionary val_10 = this.knobsModel.getWordGameplayKnobs();
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_16 = this.knobsModel;
            this.sortedKnobsDisplay.Add(key:  val_9, value:  this.knobsModel);
            goto label_20;
            label_11:
            Dispose();
            label_1:
            string val_12 = PrettyPrint.printJSON(obj:  this.sortedKnobsDisplay, types:  false, singleLineOutput:  false);
        }
    
    }

}
