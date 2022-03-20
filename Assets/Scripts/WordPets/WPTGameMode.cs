using UnityEngine;

namespace WordPets
{
    public class WPTGameMode
    {
        // Fields
        public const string EVENT_FREE_POWERUP_FTUX = "Free Powerup FTUX";
        protected WordPets.WPTLevelData currentLeveldata;
        protected WordPets.WPTLevelData backupLevelData;
        protected WordPets.WPTGameUIController uiController;
        protected System.Collections.Generic.List<WordPets.WordPetType> petsCapturedList;
        protected System.Collections.Generic.List<WordPets.WordPetType> petsEscapedList;
        protected System.Collections.Generic.List<WordPets.WordPetType> petsSpawnList;
        protected System.Collections.Generic.List<WordPets.WordPetType> backUpPetSpawnList;
        
        // Properties
        public WordPets.WPTLevelData BackupLevelData { get; }
        public int PetsCaptured { get; }
        public System.Collections.Generic.List<WordPets.WordPetType> PetsCapturedList { get; }
        public System.Collections.Generic.List<WordPets.WordPetType> PetsEscapedList { get; }
        public System.Collections.Generic.List<WordPets.WordPetType> PetsSpawnList { get; }
        protected virtual string PrefKeyPetsCaptured { get; }
        protected virtual string PrefKeyPetsEscaped { get; }
        protected virtual string PrefKeyPetsSpawn { get; }
        protected virtual string PrefKeyLevelData { get; }
        protected virtual string PrefKeyPetsSpawnB { get; }
        protected virtual string PrefKeyLevelDataB { get; }
        
        // Methods
        public WordPets.WPTLevelData get_BackupLevelData()
        {
        
        }
        public int get_PetsCaptured()
        {
            if(this.petsCapturedList != 0)
            {
                    return (int)true;
            }
            
            return (int)true;
        }
        public System.Collections.Generic.List<WordPets.WordPetType> get_PetsCapturedList()
        {
        
        }
        public System.Collections.Generic.List<WordPets.WordPetType> get_PetsEscapedList()
        {
        
        }
        public System.Collections.Generic.List<WordPets.WordPetType> get_PetsSpawnList()
        {
        
        }
        protected virtual string get_PrefKeyPetsCaptured()
        {
            System.Type val_1 = this.GetType();
            string val_2 = this.ToString();
            string val_3 = this.ToLowerInvariant();
            return System.String.Format(format:  143120224, arg0:  143144320);
        }
        protected virtual string get_PrefKeyPetsEscaped()
        {
            System.Type val_1 = this.GetType();
            string val_2 = this.ToString();
            string val_3 = this.ToLowerInvariant();
            return System.String.Format(format:  143232320, arg0:  143256416);
        }
        protected virtual string get_PrefKeyPetsSpawn()
        {
            System.Type val_1 = this.GetType();
            string val_2 = this.ToString();
            string val_3 = this.ToLowerInvariant();
            return System.String.Format(format:  143344416, arg0:  143368512);
        }
        protected virtual string get_PrefKeyLevelData()
        {
            System.Type val_1 = this.GetType();
            string val_2 = this.ToString();
            string val_3 = this.ToLowerInvariant();
            return System.String.Format(format:  143456512, arg0:  143480608);
        }
        protected virtual string get_PrefKeyPetsSpawnB()
        {
            System.Type val_1 = this.GetType();
            string val_2 = this.ToString();
            string val_3 = this.ToLowerInvariant();
            return System.String.Format(format:  143568608, arg0:  143592704);
        }
        protected virtual string get_PrefKeyLevelDataB()
        {
            System.Type val_1 = this.GetType();
            string val_2 = this.ToString();
            string val_3 = this.ToLowerInvariant();
            return System.String.Format(format:  143680704, arg0:  143704800);
        }
        public virtual void StartLevel()
        {
            var val_20;
            WordPets.WPTLevelData val_21;
            var val_22;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.uiController = public static WordPets.WPTGameUIController MonoSingleton<WordPets.WPTGameUIController>::get_Instance();
            if((UnityEngine.PlayerPrefs.HasKey(key:  143830112)) != false)
            {
                    val_20 = 0;
                string val_3 = UnityEngine.PlayerPrefs.GetString(key:  143830112, defaultValue:  null);
                if((System.String.IsNullOrEmpty(value:  143830112)) != true)
            {
                    string val_5 = UnityEngine.PlayerPrefs.GetString(key:  143830112);
                object val_6 = MiniJSON.Json.Deserialize(json:  143830112);
                if(this != 0)
            {
                    if(((WordPets.WPTGameMode.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    this = 0;
            }
            
                val_20 = this;
            }
            
                WordPets.WPTLevelData val_7 = null;
                val_21 = val_7;
                val_22 = 0;
                val_7 = new WordPets.WPTLevelData(data:  0);
                this.currentLeveldata = val_21;
                string val_8 = UnityEngine.PlayerPrefs.GetString(key:  143830112);
                object val_9 = MiniJSON.Json.Deserialize(json:  143830112);
                if(this != 0)
            {
                    if(((WordPets.WPTGameMode.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    this = 0;
            }
            
                val_22 = this;
            }
            
                this.backupLevelData = new WordPets.WPTLevelData(data:  0);
                System.Collections.Generic.List<WordPets.WordPetType> val_11 = this.GetWordPetTypeListFromPref(prefkey:  143830112);
                this.petsCapturedList = this;
                System.Collections.Generic.List<WordPets.WordPetType> val_12 = this.GetWordPetTypeListFromPref(prefkey:  143830112);
                this.petsEscapedList = this;
                System.Collections.Generic.List<WordPets.WordPetType> val_13 = this.GetWordPetTypeListFromPref(prefkey:  143830112);
                this.petsSpawnList = this;
                System.Collections.Generic.List<WordPets.WordPetType> val_14 = this.GetWordPetTypeListFromPref(prefkey:  143830112);
                this.backUpPetSpawnList = this;
            }
            
            }
            
            if(this.currentLeveldata != 0)
            {
                    GameBehavior val_15 = App.getBehavior;
                if((this.currentLeveldata.<level>k__BackingField) == 0)
            {
                    return;
            }
            
            }
            
            WordPets.WPTDataParser val_16 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            GameBehavior val_17 = App.getBehavior;
            WordPets.WPTLevelData val_18 = GetLevelData(level:  0);
            this.currentLeveldata = public static WordPets.WPTDataParser MonoSingletonSelfGenerating<WordPets.WPTDataParser>::get_Instance();
            this.backupLevelData = new WordPets.WPTLevelData(copyData:  -801937664);
            this.petsCapturedList.Clear();
            this.petsEscapedList.Clear();
            this.FillSpawnList();
        }
        public virtual void EndLevel()
        {
            WordPets.WPTGameUIController.HintsUsed = 0;
            WordPets.WPTGameUIController.NewColumnsUsed = 0;
            WordPets.WPTGameUIController.ShufflesUsed = 0;
            UnityEngine.PlayerPrefs.DeleteKey(key:  143954400);
            UnityEngine.PlayerPrefs.DeleteKey(key:  143954400);
            UnityEngine.PlayerPrefs.DeleteKey(key:  143954400);
            UnityEngine.PlayerPrefs.DeleteKey(key:  143954400);
        }
        public virtual void NextLevel()
        {
        
        }
        public virtual void RestartLevel()
        {
            WordPets.WPTGameUIController.HintsUsed = 0;
            WordPets.WPTGameUIController.NewColumnsUsed = 0;
            WordPets.WPTGameUIController.ShufflesUsed = 0;
            this.currentLeveldata = new WordPets.WPTLevelData(copyData:  this.backupLevelData);
            InitializeLetterData(useEasyLetters:  WordPets.WPTGameUIController.UseEasyLetters);
            this.petsCapturedList.Clear();
            this.petsEscapedList.Clear();
            this.FillSpawnList();
            goto typeof(WordPets.WPTGameMode).__il2cppRuntimeField_12C;
        }
        public virtual void SaveGame()
        {
            string val_1 = this.currentLeveldata.ToJSON();
            string val_2 = this.backupLevelData.ToJSON();
            UnityEngine.PlayerPrefs.SetString(key:  144339552, value:  this.currentLeveldata);
            UnityEngine.PlayerPrefs.SetString(key:  144339552, value:  this.backupLevelData);
            string val_3 = MiniJSON.Json.Serialize(obj:  this.petsCapturedList);
            string val_4 = MiniJSON.Json.Serialize(obj:  this.petsEscapedList);
            string val_5 = MiniJSON.Json.Serialize(obj:  this.petsSpawnList);
            string val_6 = MiniJSON.Json.Serialize(obj:  this.backUpPetSpawnList);
            UnityEngine.PlayerPrefs.SetString(key:  144339552, value:  this.petsCapturedList);
            UnityEngine.PlayerPrefs.SetString(key:  144339552, value:  this.petsEscapedList);
            UnityEngine.PlayerPrefs.SetString(key:  144339552, value:  this.petsSpawnList);
            UnityEngine.PlayerPrefs.SetString(key:  144339552, value:  this.backUpPetSpawnList);
            Player val_7 = App.Player;
            0.SaveState();
        }
        public void AddPetCaptured(WordPets.WordPetType newPet)
        {
            this.petsCapturedList.Add(item:  newPet);
        }
        public void AddPetEscaped(WordPets.WordPetType newPet)
        {
            this.petsEscapedList.Add(item:  newPet);
        }
        public WordPets.WordPet GetNextPet()
        {
            var val_3;
            if(true >= 1)
            {
                    twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                if((public static WordPets.WPTShelterController MonoSingleton<WordPets.WPTShelterController>::get_Instance()) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                WordPets.WordPet val_2 = GetPet(petType:  2621443);
                val_3 = public static WordPets.WPTShelterController MonoSingleton<WordPets.WPTShelterController>::get_Instance();
                this.petsSpawnList.RemoveAt(index:  0);
                return;
            }
            
            val_3 = 0;
        }
        public void BringBackPets()
        {
            var val_3 = 0;
            goto label_1;
            label_6:
            if(true <= val_3)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + 0;
            this.petsSpawnList.Insert(index:  0, item:  (0 + 0) + 16);
            val_3 = 1;
            label_1:
            if(val_3 < this.petsSpawnList)
            {
                goto label_6;
            }
            
            this.petsEscapedList.Clear();
            this.uiController.BringBackPets();
            WordPets.WPTGameEcon val_1 = WordPets.WPTGameEcon.Instance;
            bool val_2 = CurrencyController.DebitBalance(value:  new System.Decimal() {flags = "Balloon Pet Return", lo = (0 + 0) + 16, mid = 144847520}, source:  "Balloon Pet Return", externalParams:  0, animated:  false);
        }
        public void OnRefreshHintClicked()
        {
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            decimal val_29;
            string val_30;
            Player val_1 = App.Player;
            WordPets.WPTGameEcon val_2 = WordPets.WPTGameEcon.Instance;
            decimal val_3 = PowerupCostRefresh;
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal())) != false)
            {
                    var val_19 = 23957281;
                val_19 = 11668780 + val_19;
                if(val_19 == 0)
            {
                    mem2[0] = 1;
            }
            
                val_20 = null;
                val_20 = null;
                PurchaseProxy.currentPurchasePoint = 84;
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                object val_6 = ShowUGUIMonolith<System.Object>(showNext:  true);
                Init(outOfCredits:  true, onCloseAction:  0);
                return;
            }
            
            WordPets.WPTPlayer val_7 = WordPets.WPTPlayer.Instance;
            if(0 != 0)
            {
                    val_21 = 0;
                val_22 = 1;
            }
            else
            {
                    val_21 = 316;
                val_22 = 1;
            }
            
            mem[316] = 2;
            WordPets.WPTPlayer val_8 = WordPets.WPTPlayer.Instance;
            if(0 != 0)
            {
                    val_23 = 0;
                val_24 = 16;
            }
            else
            {
                    val_23 = 304;
                val_24 = 16;
            }
            
            mem[304] = 17;
            WordPets.WPTPlayer val_9 = WordPets.WPTPlayer.Instance;
            if(0 != 0)
            {
                    val_25 = 0;
                val_26 = 1030672;
            }
            else
            {
                    val_25 = 296;
                val_26 = 1030672;
            }
            
            mem[296] = 1030673;
            this.uiController.DoRefreshHint();
            WordPets.WPTGameEcon val_10 = WordPets.WPTGameEcon.Instance;
            decimal val_11 = PowerupCostRefresh;
            val_27 = null;
            val_27 = null;
            val_29 = System.Decimal.Zero;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_29, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
            {
                    WordPets.WPTGameEcon val_13 = WordPets.WPTGameEcon.Instance;
                decimal val_14 = PowerupCostRefresh;
                val_29 = 0;
                val_30 = "Shuffle Powerup";
                bool val_15 = CurrencyController.DebitBalance(value:  new System.Decimal(), source:  val_30, externalParams:  val_29, animated:  false);
            }
            else
            {
                    Player val_16 = App.Player;
                0.TrackNonCoinReward(source:  145005824, subSource:  null, rewardType:  145005712, rewardAmount:  0, additionalParams:  0);
            }
            
            NotificationCenter val_17 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  0, aName:  -302451824);
            twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  9, oneshot:  true, pitch:  null, vol:  null);
        }
        public bool OnHintClicked(int[] playerSelectedCharCount, out string hintedWord)
        {
            var val_23;
            string val_24;
            float val_25;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_26;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            val_23 = this;
            hintedWord = 0;
            Player val_1 = App.Player;
            val_24 = 52;
            val_25 = 7.286752E-44f;
            val_26 = 256;
            WordPets.WPTGameEcon val_2 = WordPets.WPTGameEcon.Instance;
            decimal val_3 = PowerupCostWordHint;
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal())) != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                object val_6 = ShowUGUIMonolith<System.Object>(showNext:  true);
                val_28 = 0;
                Init(outOfCredits:  true, onCloseAction:  0);
                return (bool)val_28;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Int32[] val_8 = this.GetCharCount(includeSpiderWebTiles:  false);
            string val_9 = TryWordHint(charCountPlayerSelected:  playerSelectedCharCount, charCountEntirePool:  145188032);
            val_25 = public static WPTWordList MonoSingleton<WPTWordList>::get_Instance();
            bool val_10 = System.String.IsNullOrEmpty(value:  145162912);
            val_23 = val_10;
            if(val_10 != true)
            {
                    WordPets.WPTPlayer val_11 = WordPets.WPTPlayer.Instance;
                if(0 != 0)
            {
                    val_29 = 0;
                val_30 = 1919184449;
            }
            else
            {
                    val_29 = 320;
                val_30 = 1919184449;
            }
            
                mem[320] = 1919184450;
                WordPets.WPTPlayer val_12 = WordPets.WPTPlayer.Instance;
                if(0 != 0)
            {
                    val_31 = 0;
                val_32 = 8;
            }
            else
            {
                    val_31 = 308;
                val_32 = 8;
            }
            
                mem[308] = 9;
                WordPets.WPTPlayer val_13 = WordPets.WPTPlayer.Instance;
                if(0 != 0)
            {
                    val_33 = 0;
                val_34 = 1030672;
            }
            else
            {
                    val_33 = 296;
                val_34 = 1030672;
            }
            
                mem[296] = 1030673;
                WordPets.WPTGameEcon val_14 = WordPets.WPTGameEcon.Instance;
                decimal val_15 = PowerupCostWordHint;
                val_35 = null;
                val_35 = null;
                if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero})) != false)
            {
                    WordPets.WPTGameEcon val_17 = WordPets.WPTGameEcon.Instance;
                decimal val_18 = PowerupCostWordHint;
                val_26 = 0;
                val_24 = "Hint Powerup";
                bool val_19 = CurrencyController.DebitBalance(value:  new System.Decimal(), source:  val_24, externalParams:  val_26, animated:  false);
            }
            else
            {
                    val_24 = 0;
                Player val_20 = App.Player;
                0.TrackNonCoinReward(source:  145005824, subSource:  null, rewardType:  145163936, rewardAmount:  val_24, additionalParams:  val_24);
            }
            
                NotificationCenter val_21 = NotificationCenter.DefaultCenter;
                0.PostNotification(aSender:  0, aName:  -302451824);
            }
            
            val_28 = val_23 ^ 1;
            hintedWord = val_25;
            return (bool)val_28;
        }
        public void OnAddColumnClicked()
        {
            decimal val_17;
            string val_18;
            var val_20;
            var val_21;
            Player val_1 = App.Player;
            WordPets.WPTGameEcon val_2 = WordPets.WPTGameEcon.Instance;
            decimal val_3 = PowerupCostAddColumn;
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal())) != false)
            {
                    var val_17 = 23954113;
                val_17 = 11671948 + val_17;
                if(val_17 == 0)
            {
                    mem2[0] = 1;
            }
            
                val_20 = null;
                val_20 = null;
                PurchaseProxy.currentPurchasePoint = 83;
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                object val_6 = ShowUGUIMonolith<System.Object>(showNext:  true);
                Init(outOfCredits:  true, onCloseAction:  0);
                return;
            }
            
            if(this.uiController.DoAddColumnHint() == false)
            {
                    return;
            }
            
            WordPets.WPTGameEcon val_8 = WordPets.WPTGameEcon.Instance;
            decimal val_9 = PowerupCostAddColumn;
            val_21 = null;
            val_21 = null;
            val_17 = System.Decimal.Zero;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_17, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
            {
                    WordPets.WPTGameEcon val_11 = WordPets.WPTGameEcon.Instance;
                decimal val_12 = PowerupCostAddColumn;
                val_17 = 0;
                val_18 = "New Column Powerup";
                bool val_13 = CurrencyController.DebitBalance(value:  new System.Decimal(), source:  val_18, externalParams:  val_17, animated:  false);
            }
            else
            {
                    Player val_14 = App.Player;
                0.TrackNonCoinReward(source:  145005824, subSource:  null, rewardType:  145321008, rewardAmount:  0, additionalParams:  0);
            }
            
            NotificationCenter val_15 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  0, aName:  -302451824);
            twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  9, oneshot:  true, pitch:  null, vol:  null);
        }
        public int[] GetCharCount(bool includeSpiderWebTiles = False)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            val_5 = this;
            val_6 = 0;
            goto label_2;
            label_28:
            if(null <= val_6)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + 0;
            val_5 = mem[(0 + 0) + 16];
            val_5 = (0 + 0) + 16;
            int val_1 = val_5.GetLetterHeight();
            if(val_1 < 1)
            {
                goto label_5;
            }
            
            val_5 = val_1;
            var val_11 = 0;
            label_26:
            if(val_1 <= val_6)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + 0;
            if(((0 + 0) + 16 + 16 + 12) <= val_11)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_7 = (0 + 0) + 16 + 16 + 8;
            val_7 = val_7 + 0;
            val_8 = 0;
            val_7 = 1;
            if(val_8.HasCrate != true)
            {
                    if(val_8.HasSpiderWeb != false)
            {
                    if(includeSpiderWebTiles == false)
            {
                goto label_18;
            }
            
            }
            
                if(includeSpiderWebTiles <= val_6)
            {
                    var val_8 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_8 = val_8 + 0;
                if(((0 + 0) + 16 + 16 + 12) <= val_11)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_9 = (0 + 0) + 16 + 16 + 8;
                val_9 = val_9 + 0;
                val_8 = (((0 + 0) + 16 + 16 + 8 + 0) + 16) - 97;
                var val_10 = (null + ((((0 + 0) + 16 + 16 + 8 + 0) + 16 - 97)) << 2) + 16;
                val_10 = val_10 + 1;
                mem2[0] = val_10;
            }
            
            label_18:
            val_11 = val_11 + 1;
            if(val_5 != val_11)
            {
                goto label_26;
            }
            
            label_5:
            val_6 = 1;
            label_2:
            if(val_6 < (null + (val_8 << 2)))
            {
                goto label_28;
            }
        
        }
        protected void FillSpawnList()
        {
            WordPets.WPTLevelData val_4;
            var val_5;
            val_4 = this.currentLeveldata;
            if(this.currentLeveldata != 0)
            {
                goto label_1;
            }
            
            val_4 = this.currentLeveldata;
            if(val_4 == 0)
            {
                goto label_2;
            }
            
            label_1:
            val_5 = (this.currentLeveldata.<petsExtra>k__BackingField) + (this.currentLeveldata.<totalInitialPets>k__BackingField);
            this.petsSpawnList.Clear();
            if(val_5 >= 1)
            {
                    do
            {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                WordPets.WordPet val_2 = GetRandomPet();
                this.petsSpawnList.Add(item:  public static WordPets.WPTShelterController MonoSingleton<WordPets.WPTShelterController>::get_Instance().__il2cppRuntimeField_14);
                val_5 = val_5 - 1;
            }
            while(this.petsSpawnList != 0);
            
            }
            
            this.backUpPetSpawnList.Clear();
            this.backUpPetSpawnList.AddRange(collection:  this.petsSpawnList);
            return;
            label_2:
        }
        public static int GetLowerCharIndex(char character)
        {
            character = character - 97;
            return (int)character;
        }
        protected System.Collections.Generic.List<WordPets.WordPetType> GetWordPetTypeListFromPref(string prefkey)
        {
            string val_10;
            var val_11;
            var val_12;
            System.Collections.Generic.List<WordPets.WordPetType> val_1 = new System.Collections.Generic.List<WordPets.WordPetType>();
            val_10 = 0;
            if((UnityEngine.PlayerPrefs.HasKey(key:  prefkey)) != false)
            {
                    string val_3 = UnityEngine.PlayerPrefs.GetString(key:  prefkey, defaultValue:  null);
                val_10 = prefkey;
            }
            
            if((System.String.IsNullOrEmpty(value:  val_10)) == true)
            {
                    return;
            }
            
            object val_5 = MiniJSON.Json.Deserialize(json:  val_10);
            val_12 = 0;
            goto label_6;
            label_18:
            System.Type val_6 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(402341888)});
            if(0 <= val_12)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_10 = 0;
            val_10 = val_10 + 0;
            object val_7 = System.Enum.Parse(enumType:  402341888, value:  (0 + 0) + 16);
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            val_10 = ;
            System.Type val_8 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(402341888)});
            val_11 = null;
            if((System.Enum.IsDefined(enumType:  402341888, value:  402341888)) != false)
            {
                    Add(item:  val_10);
            }
            
            val_12 = 1;
            label_6:
            if(val_12 < 0)
            {
                goto label_18;
            }
        
        }
        public WPTGameMode()
        {
            this.petsCapturedList = new System.Collections.Generic.List<WordPets.WordPetType>();
            this.petsEscapedList = new System.Collections.Generic.List<WordPets.WordPetType>();
            this.petsSpawnList = new System.Collections.Generic.List<WordPets.WordPetType>();
            this.backUpPetSpawnList = new System.Collections.Generic.List<WordPets.WordPetType>();
        }
    
    }

}
