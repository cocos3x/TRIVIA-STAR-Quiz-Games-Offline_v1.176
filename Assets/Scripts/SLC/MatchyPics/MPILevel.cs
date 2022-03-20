using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPILevel : EventProgression
    {
        // Fields
        public const string LEVEL_PROGRESS_KEY = "mpi_level_progress_v2";
        public const string LEVEL_START_KEY = "mpi_level_start_v2";
        public int LevelIndex;
        public SLC.MatchyPics.MPILevelDefinition LevelDefinition;
        public SLC.MatchyPics.MPIMovementMechanic MovementMechanic;
        public SLC.MatchyPics.MPIBombMechanic BombMechanic;
        public int ChestReward;
        public System.Collections.Generic.List<SLC.MatchyPics.MPITileData> LevelTiles;
        public int Points;
        public int timeRemaining;
        public int totalTime;
        public int totalStars;
        public int collectedChestRewards;
        public int directionIndex;
        public int imageSetIndex;
        public int hintsUsed;
        public int shufflesUsed;
        public int imageChangesUsed;
        public int freeHintsUsed;
        public int collectionItems;
        public int collectedCollectionItems;
        
        // Properties
        public bool IsNew { get; }
        
        // Methods
        public bool get_IsNew()
        {
            bool val_1 = UnityEngine.PlayerPrefs.HasKey(key:  775997600);
            val_1 = val_1 ^ 1;
            return (bool)val_1;
        }
        public override void LoadFromJSON()
        {
            var val_55;
            SLC.MatchyPics.MPILevel val_81;
            float val_82;
            float val_83;
            var val_84;
            var val_85;
            var val_86;
            if((UnityEngine.PlayerPrefs.HasKey(key:  775997600)) == false)
            {
                    return;
            }
            
            string val_2 = UnityEngine.PlayerPrefs.GetString(key:  775997600);
            string val_3 = 776109712 + 775997600;
            UnityEngine.Debug.Log(message:  776109712);
            string val_4 = UnityEngine.PlayerPrefs.GetString(key:  775997600);
            val_81 = this;
            object val_5 = MiniJSON.Json.Deserialize(json:  775997600);
            if("mpi_level_progress_v2" != 0)
            {
                    if(null == null)
            {
                goto label_38;
            }
            
            }
            
            val_82 = 1;
            label_38:
            val_83 = 1152921510392296080;
            if((0.ContainsKey(key:  -1987496192)) != false)
            {
                    string val_7 = 0.Item[-1987496192];
                val_84 = 0;
                bool val_9 = System.Int32.TryParse(s:  null, result: out  int val_8 = 776124456);
            }
            
            if(0 != mem[1152921513972918072])
            {
                    return;
            }
            
            val_85 = "timeRemaining";
            if((0.ContainsKey(key:  776109840)) != false)
            {
                    string val_11 = 0.Item[776109840];
                val_84 = 0;
                bool val_13 = System.Int32.TryParse(s:  null, result: out  int val_12 = 776136532);
            }
            
            if(this.timeRemaining <= 0)
            {
                goto label_17;
            }
            
            if((0.ContainsKey(key:  776109936)) != false)
            {
                    string val_15 = 0.Item[776109936];
                val_84 = 0;
                bool val_17 = System.Int32.TryParse(s:  null, result: out  int val_16 = 776136536);
            }
            
            if((0.ContainsKey(key:  776110032)) != false)
            {
                    string val_19 = 0.Item[776110032];
                val_84 = 0;
                object val_20 = UnityEngine.JsonUtility.FromJson<System.Object>(json:  null);
                mem[1152921513972918076] = val_84;
            }
            
            if((0.ContainsKey(key:  776111168)) == false)
            {
                goto label_27;
            }
            
            System.Type val_22 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(438231040)});
            string val_23 = 0.Item[776111168];
            object val_24 = System.Enum.Parse(enumType:  438231040, value:  null);
            val_84 = null;
            if(null != 0)
            {
                goto label_36;
            }
            
            goto label_36;
            label_17:
            bool val_25 = this.ContainsKey(key:  776109840);
            return;
            label_36:
            mem[1152921513972918084] = ;
            val_85 = "timeRemaining";
            label_27:
            if((0.ContainsKey(key:  776111264)) != false)
            {
                    System.Type val_27 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(438177792)});
                string val_28 = 0.Item[776111264];
                object val_29 = System.Enum.Parse(enumType:  438177792, value:  null);
                val_84 = null;
                mem[1152921513972918080] = ;
                val_85 = "timeRemaining";
            }
            
            if((0.ContainsKey(key:  776111376)) != false)
            {
                    string val_31 = 0.Item[776111376];
                val_84 = 0;
                bool val_33 = System.Int32.TryParse(s:  null, result: out  int val_32 = 776136528);
            }
            
            if((0.ContainsKey(key:  776109840)) != false)
            {
                    string val_35 = 0.Item[776109840];
                val_84 = 0;
                bool val_37 = System.Int32.TryParse(s:  null, result: out  int val_36 = 776136532);
            }
            
            if((0.ContainsKey(key:  776111456)) != false)
            {
                    string val_39 = 0.Item[776111456];
                val_84 = 0;
                bool val_41 = System.Int32.TryParse(s:  null, result: out  int val_40 = 776136544);
            }
            
            if((0.ContainsKey(key:  776111568)) != false)
            {
                    string val_43 = 0.Item[776111568];
                val_84 = 0;
                bool val_45 = System.Int32.TryParse(s:  null, result: out  int val_44 = 776136548);
            }
            
            if((0.ContainsKey(key:  776111664)) != false)
            {
                    string val_47 = 0.Item[776111664];
                val_84 = 0;
                bool val_49 = System.Int32.TryParse(s:  null, result: out  int val_48 = 776136552);
            }
            
            if((0.ContainsKey(key:  776111760)) == false)
            {
                goto label_85;
            }
            
            string val_51 = 0.Item[776111760];
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_52 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            mem[1152921513972918092] = null;
            val_85 = 0;
            List.Enumerator<T> val_53 = GetEnumerator();
            label_84:
            if(MoveNext() == false)
            {
                goto label_79;
            }
            
            SLC.MatchyPics.MPITileData val_56 = new SLC.MatchyPics.MPITileData();
            val_86 = 0;
            if(val_55 != 0)
            {
                    val_81 = this;
                if(((val_55 + 100 + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    val_55 = 0;
            }
            
                val_86 = val_55;
            }
            
            Deserialize(obj:  0);
            Add(item:  438976512);
            goto label_84;
            label_79:
            val_84 = 0;
            Dispose();
            val_82 = val_82;
            val_83 = 1152921510392296080;
            label_85:
            if((0.ContainsKey(key:  776111856)) != false)
            {
                    string val_58 = 0.Item[776111856];
                val_84 = 0;
                bool val_60 = System.Int32.TryParse(s:  null, result: out  int val_59 = 776136556);
            }
            
            if((0.ContainsKey(key:  776111952)) != false)
            {
                    string val_62 = 0.Item[776111952];
                val_84 = 0;
                bool val_64 = System.Int32.TryParse(s:  null, result: out  int val_63 = 776136560);
            }
            
            if((0.ContainsKey(key:  776112048)) != false)
            {
                    string val_66 = 0.Item[776112048];
                val_84 = 0;
                bool val_68 = System.Int32.TryParse(s:  null, result: out  int val_67 = 776136564);
            }
            
            if((0.ContainsKey(key:  776112160)) != false)
            {
                    string val_70 = 0.Item[776112160];
                val_84 = 0;
                bool val_72 = System.Int32.TryParse(s:  null, result: out  int val_71 = 776136568);
            }
            
            if((0.ContainsKey(key:  776112256)) != false)
            {
                    string val_74 = 0.Item[776112256];
                val_84 = 0;
                bool val_76 = System.Int32.TryParse(s:  null, result: out  int val_75 = 776136572);
            }
            
            if((0.ContainsKey(key:  776112368)) == false)
            {
                    return;
            }
            
            string val_78 = 0.Item[776112368];
            bool val_80 = System.Int32.TryParse(s:  null, result: out  int val_79 = 776136576);
        }
        public override void SaveToJSON()
        {
            this.SaveToPrefs(saveStart:  false);
        }
        public void SaveStartToJSON()
        {
            this.SaveToPrefs(saveStart:  true);
        }
        public static void Restart()
        {
            if((UnityEngine.PlayerPrefs.HasKey(key:  776448496)) != false)
            {
                    string val_2 = UnityEngine.PlayerPrefs.GetString(key:  776448496);
                UnityEngine.PlayerPrefs.SetString(key:  775997600, value:  776448496);
                bool val_3 = PrefsSerializationManager.SavePlayerPrefs();
                return;
            }
            
            UnityEngine.PlayerPrefs.DeleteKey(key:  775997600);
            UnityEngine.PlayerPrefs.DeleteKey(key:  776448496);
        }
        public override void Delete()
        {
            UnityEngine.PlayerPrefs.DeleteKey(key:  775997600);
            UnityEngine.PlayerPrefs.DeleteKey(key:  776448496);
        }
        private void SaveToPrefs(bool saveStart = False)
        {
            twelvegigs.sweepstakes.Distribution val_6;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  -1987496192, value:  13152256);
            string val_2 = UnityEngine.JsonUtility.ToJson(obj:  this.LevelDefinition);
            Add(key:  776110032, value:  this.LevelDefinition);
            Add(key:  776111264, value:  13152256);
            Add(key:  776111168, value:  13152256);
            Add(key:  776111376, value:  13152256);
            Add(key:  776109840, value:  13152256);
            Add(key:  776109936, value:  13152256);
            Add(key:  776111456, value:  13152256);
            Add(key:  776111568, value:  13152256);
            Add(key:  776111664, value:  13152256);
            Add(key:  776111856, value:  13152256);
            Add(key:  776111952, value:  13152256);
            Add(key:  776112048, value:  13152256);
            Add(key:  776112160, value:  13152256);
            Add(key:  776112256, value:  13152256);
            Add(key:  776112368, value:  13152256);
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            List.Enumerator<T> val_4 = GetEnumerator();
            label_21:
            if(MoveNext() == false)
            {
                goto label_18;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_7 = val_6.Serialize();
            Add(item:  val_6);
            goto label_21;
            label_18:
            Dispose();
            Add(key:  776111760, value:  80883712);
            string val_8 = MiniJSON.Json.Serialize(obj:  78753792);
            UnityEngine.PlayerPrefs.SetString(key:  775997600, value:  78753792);
            if(saveStart != false)
            {
                    UnityEngine.PlayerPrefs.SetString(key:  776448496, value:  78753792);
            }
            
            bool val_9 = PrefsSerializationManager.SavePlayerPrefs();
        }
        public MPILevel()
        {
            this.timeRemaining = 0;
            this.totalTime = 0;
            this.directionIndex = 0;
        }
    
    }

}
