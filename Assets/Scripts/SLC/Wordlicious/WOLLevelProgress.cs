using UnityEngine;

namespace SLC.Wordlicious
{
    public class WOLLevelProgress : EventProgression
    {
        // Fields
        private const string LEVEL_PROGRESS_PREF_KEY = "wol_level_status";
        private const string GRID_TILES_KEY = "grid_tiles";
        private const string WORD_REGION_LETTERS_KEY = "word_region_letters";
        private const string PLAYER_LEVEL_KEY = "player_level";
        private const string LEVEL_CODE_KEY = "level_code";
        private const string TRACKING_LEVEL_COMPLETE_KEY = "tracking_level_complete";
        private System.Collections.Generic.List<string> <gridTiles>k__BackingField;
        private System.Collections.Generic.List<string> <wordRegionLetters>k__BackingField;
        private string <levelCode>k__BackingField;
        public SLC.Wordlicious.WOLTrackingLevelComplete trackingLevelComplete;
        
        // Properties
        public System.Collections.Generic.List<string> gridTiles { get; set; }
        public System.Collections.Generic.List<string> wordRegionLetters { get; set; }
        public string levelCode { get; set; }
        
        // Methods
        public System.Collections.Generic.List<string> get_gridTiles()
        {
        
        }
        private void set_gridTiles(System.Collections.Generic.List<string> value)
        {
            this.<gridTiles>k__BackingField = value;
        }
        public System.Collections.Generic.List<string> get_wordRegionLetters()
        {
        
        }
        private void set_wordRegionLetters(System.Collections.Generic.List<string> value)
        {
            this.<wordRegionLetters>k__BackingField = value;
        }
        public string get_levelCode()
        {
        
        }
        public void set_levelCode(string value)
        {
            this.<levelCode>k__BackingField = value;
        }
        public WOLLevelProgress()
        {
            this.ResetGridTiles();
            this.ResetWordRegionLetters();
            this.ResetTracking();
        }
        private void ResetTracking()
        {
            this.trackingLevelComplete = new SLC.Wordlicious.WOLTrackingLevelComplete();
        }
        public void ResetGridTiles()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.<gridTiles>k__BackingField = null;
        }
        public void SaveGridTile(string tileInfo)
        {
            this.<gridTiles>k__BackingField.Add(item:  tileInfo);
        }
        public void ResetWordRegionLetters()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.<wordRegionLetters>k__BackingField = null;
        }
        public override void LoadFromJSON()
        {
            string val_16;
            var val_24;
            float val_25;
            int val_26;
            var val_27;
            var val_28;
            var val_29;
            if((UnityEngine.PlayerPrefs.HasKey(key:  711414160)) == false)
            {
                    return;
            }
            
            val_24 = 0;
            string val_2 = UnityEngine.PlayerPrefs.GetString(key:  711414160);
            object val_3 = MiniJSON.Json.Deserialize(json:  711414160);
            val_25 = 1152921504685600768;
            if("wol_level_status" != 0)
            {
                    if(null == null)
            {
                goto label_26;
            }
            
            }
            
            label_26:
            if((val_24.ContainsKey(key:  -1930530640)) != false)
            {
                    string val_5 = val_24.Item[-1930530640];
                bool val_7 = System.Int32.TryParse(s:  null, result: out  int val_6 = 711443048);
            }
            
            val_26 = System.String.alignConst;
            if((val_24.ContainsKey(key:  711414272)) != false)
            {
                    string val_9 = val_24.Item[711414272];
                val_26 = val_24;
            }
            
            Player val_10 = App.Player;
            if(val_24 != 0)
            {
                    return;
            }
            
            if((System.String.op_Inequality(a:  this.<levelCode>k__BackingField, b:  null)) != false)
            {
                    return;
            }
            
            if((val_24.ContainsKey(key:  711418464)) == false)
            {
                goto label_63;
            }
            
            string val_13 = val_24.Item[711418464];
            val_27 = 0;
            List.Enumerator<T> val_14 = GetEnumerator();
            label_30:
            if(MoveNext() == false)
            {
                goto label_27;
            }
            
            this.<gridTiles>k__BackingField.Add(item:  val_16);
            goto label_30;
            label_27:
            Dispose();
            val_25 = 1152921504685600768;
            val_24 = val_24;
            label_63:
            if((val_24.ContainsKey(key:  711422656)) == false)
            {
                goto label_60;
            }
            
            string val_18 = val_24.Item[711422656];
            val_28 = 0;
            List.Enumerator<T> val_19 = GetEnumerator();
            label_43:
            if(MoveNext() == false)
            {
                goto label_40;
            }
            
            this.<wordRegionLetters>k__BackingField.Add(item:  val_16);
            goto label_43;
            label_40:
            Dispose();
            val_24 = val_24;
            label_60:
            if((val_24.ContainsKey(key:  711426864)) == false)
            {
                    return;
            }
            
            string val_22 = val_24.Item[711426864];
            val_29 = 0;
            object val_23 = MiniJSON.Json.Deserialize(json:  null);
            if(val_24 != 0)
            {
                    if(((mem[1179403747] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_25)
            {
                    val_24 = 0;
            }
            
                val_29 = val_24;
            }
            
            this.trackingLevelComplete.Load(info:  0);
        }
        public override void SaveToJSON()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  711418464, value:  this.<gridTiles>k__BackingField);
            Add(key:  711422656, value:  this.<wordRegionLetters>k__BackingField);
            Player val_2 = App.Player;
            Add(key:  -1930530640, value:  13152256);
            Add(key:  711414272, value:  this.<levelCode>k__BackingField);
            Add(key:  711426864, value:  this.trackingLevelComplete);
            string val_3 = MiniJSON.Json.Serialize(obj:  78753792);
            UnityEngine.PlayerPrefs.SetString(key:  711414160, value:  78753792);
            bool val_4 = PrefsSerializationManager.SavePlayerPrefs();
        }
        public override void Delete()
        {
            UnityEngine.PlayerPrefs.DeleteKey(key:  711414160);
        }
    
    }

}
