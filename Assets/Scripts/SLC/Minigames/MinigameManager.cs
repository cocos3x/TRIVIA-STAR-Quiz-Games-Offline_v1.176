using UnityEngine;

namespace SLC.Minigames
{
    public class MinigameManager : MonoSingleton<SLC.Minigames.MinigameManager>
    {
        // Fields
        public int numVideosRequired;
        public int numCoinContinuesUsed;
        private SLC.Minigames.MinigamePlayerData currentPlayerData;
        private SLC.Minigames.MinigameRankData currentRankData;
        private twelvegigs.storage.JsonDictionary currentKnobsData;
        private decimal checkpointReward;
        private decimal hintCost;
        private decimal continueCost;
        private decimal continueIncrement;
        private int currentPlayerLevel;
        public System.Action OnContinueMinigame;
        public System.Action OnRestartMinigame;
        public System.Action OnCheckpointRankUpContinue;
        public System.Action OnPauseClicked;
        public System.Action<System.Collections.Generic.Dictionary<string, object>> OnInjectTracking;
        public System.Action<bool> TogglePopupWindow;
        private int _session_startLevel;
        private int _session_adsWatched;
        private float _session_startTime;
        private decimal _session_continuePurchased;
        private bool QAHACK_freeContinues;
        
        // Properties
        private string[] gameSceneNames { get; }
        private int currentMinigameIndex { get; }
        public string CurrentMinigameScene { get; }
        public string CurrentMinigameId { get; }
        public string CurrentMinigameName { get; }
        public SLC.Minigames.MinigamePlayerData GetCurrentPlayerData { get; }
        public SLC.Minigames.MinigameRankData GetRankData { get; }
        public twelvegigs.storage.JsonDictionary GetCurrentKnobsData { get; }
        public SLC.Minigames.MinigameLevelRank GetCurrentRank { get; }
        public SLC.Minigames.MinigameLevelRank GetNextRank { get; }
        public int GetPlayerLevelInCurrentRank { get; }
        public int GetNextCheckpointLevel { get; }
        public int GetLevelsToNextCheckpoint { get; }
        public int GetMaximumPlayerLevel { get; }
        public decimal GetCurrentCheckpointReward { get; }
        public decimal GetCurrentHintCost { get; }
        public decimal GetCurrentContinueCost { get; }
        public int GetCurrentPlayerLevel { get; }
        public bool QAHACK_FreeContinues { get; set; }
        
        // Methods
        private string[] get_gameSceneNames()
        {
            AppConfigs val_1 = WordApp.getConfig();
            if(83886592 != 0)
            {
                    return 83886592.MiniGamesScenes;
            }
            
            return 83886592.MiniGamesScenes;
        }
        private int get_currentMinigameIndex()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static Bootstrapper MonoSingleton<Bootstrapper>::get_Instance()) != 0)
            {
                    return CurrentMinigame;
            }
            
            return CurrentMinigame;
        }
        public string get_CurrentMinigameScene()
        {
            AppConfigs val_1 = App.Configuration;
            MiniGame val_3 = 83886592.GetMiniGameByIndex(index:  this.currentMinigameIndex);
            if(83886592 != 0)
            {
                    return;
            }
        
        }
        public string get_CurrentMinigameId()
        {
            AppConfigs val_1 = App.Configuration;
            MiniGame val_3 = 83886592.GetMiniGameByIndex(index:  this.currentMinigameIndex);
            if(83886592 != 0)
            {
                    return;
            }
        
        }
        public string get_CurrentMinigameName()
        {
            AppConfigs val_1 = App.Configuration;
            MiniGame val_3 = 83886592.GetMiniGameByIndex(index:  this.currentMinigameIndex);
            if(83886592 != 0)
            {
                    return;
            }
        
        }
        public SLC.Minigames.MinigamePlayerData get_GetCurrentPlayerData()
        {
        
        }
        public SLC.Minigames.MinigameRankData get_GetRankData()
        {
        
        }
        public twelvegigs.storage.JsonDictionary get_GetCurrentKnobsData()
        {
        
        }
        public SLC.Minigames.MinigameLevelRank get_GetCurrentRank()
        {
            if(true <= this.currentPlayerData.rankIndex)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (this.currentPlayerData.rankIndex << 2);
        }
        public SLC.Minigames.MinigameLevelRank get_GetNextRank()
        {
            int val_3 = UnityEngine.Mathf.Min(a:  this.currentPlayerData.rankIndex + 1, b:  this.currentRankData.ranks - 1);
            if(val_3 <= val_3)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + (val_3 << 2);
        }
        public int get_GetPlayerLevelInCurrentRank()
        {
            SLC.Minigames.MinigameLevelRank val_1 = this.GetCurrentRank;
            this = this.currentPlayerLevel - this;
            return (int)this;
        }
        public int get_GetNextCheckpointLevel()
        {
            SLC.Minigames.MinigameLevelRank val_1 = this.GetCurrentRank;
            System.Predicate<System.Int32> val_2 = new System.Predicate<System.Int32>(object:  899027152, method:  new IntPtr(899001104));
            if(this.checkpointReward != 0)
            {
                    return this.checkpointReward.Find(match:  8040448);
            }
            
            return this.checkpointReward.Find(match:  8040448);
        }
        public int get_GetLevelsToNextCheckpoint()
        {
            int val_2 = this.currentPlayerData.checkpointLevel;
            val_2 = this.GetNextCheckpointLevel - val_2;
            return (int)val_2;
        }
        public int get_GetMaximumPlayerLevel()
        {
            object val_1 = System.Linq.Enumerable.Last<System.Object>(source:  this.currentRankData.ranks);
            object val_2 = System.Linq.Enumerable.Last<System.Object>(source:  this.currentRankData.ranks);
            int val_3 = System.Linq.Enumerable.Last<System.Int32>(source:  1152921513528679312);
            val_3 = val_3 + this.currentRankData.ranks;
            return (int)val_3;
        }
        public decimal get_GetCurrentCheckpointReward()
        {
            return new System.Decimal() {flags = 899405136, hi = R1 + 32};
        }
        public decimal get_GetCurrentHintCost()
        {
            return new System.Decimal() {flags = 899517136, hi = R1 + 48};
        }
        public decimal get_GetCurrentContinueCost()
        {
            var val_1 = R1 + 80;
            decimal val_2 = System.Decimal.op_Implicit(value:  899617084);
            decimal val_3 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 899617068, hi = mem[(R1 + 80) + (0)], lo = mem[(R1 + 80) + (4)], mid = mem[(R1 + 80) + (8)]}, d2:  new System.Decimal() {flags = mem[(R1 + 80) + (12)]});
            decimal val_4 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = 899629136, hi = R1 + 64, lo = R1 + 68, mid = R1 + 72}, d2:  new System.Decimal() {flags = R1 + 76});
            return new System.Decimal() {flags = val_4.flags, hi = val_4.hi, lo = val_4.lo, mid = val_4.mid};
        }
        public int get_GetCurrentPlayerLevel()
        {
            return (int)this.currentPlayerLevel;
        }
        private void Start()
        {
            var val_13;
            var val_14;
            this.currentPlayerData = new SLC.Minigames.MinigamePlayerData();
            this.currentRankData = new SLC.Minigames.MinigameRankData();
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Boolean> val_4 = new System.Action<System.Boolean>(object:  899857360, method:  new IntPtr(899830160));
            System.Delegate val_5 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigamesUIController MonoSingleton<SLC.Minigames.MinigamesUIController>::get_Instance().__il2cppRuntimeField_10, b:  7401472);
            val_13 = public static SLC.Minigames.MinigamesUIController MonoSingleton<SLC.Minigames.MinigamesUIController>::get_Instance().__il2cppRuntimeField_10;
            if(val_13 != 0)
            {
                    if(val_13 == null)
            {
                goto label_6;
            }
            
            }
            
            val_13 = 0;
            label_6:
            public static SLC.Minigames.MinigamesUIController MonoSingleton<SLC.Minigames.MinigamesUIController>::get_Instance().__il2cppRuntimeField_10 = val_13;
            string val_7 = currentMinigameIndex.ToString();
            typeof(System.Object[]).__il2cppRuntimeField_10 = ;
            UnityEngine.Debug.LogFormat(format:  899831184, args:  472754880);
            System.Action<twelvegigs.storage.JsonDictionary> val_8 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  899857360, method:  new IntPtr(899831312));
            val_14 = null;
            val_14 = null;
            SLC.Minigames.MinigamesKnobsManager.defaultKnobData = null;
            twelvegigs.storage.JsonDictionary val_9 = SLC.Minigames.MinigamesKnobsManager.GetKnobs();
            this.UpdateGameplayDataFromKnobs(allMinigamesKnobs:  447234048);
            string val_10 = this.CurrentMinigameScene;
            UnityEngine.AsyncOperation val_11 = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName:  899857360, mode:  1);
            this.LoadCurrentPlayerData();
            this._session_startLevel = this.currentPlayerLevel;
            this._session_adsWatched = 0;
            float val_12 = UnityEngine.Time.unscaledTime;
            this._session_startTime = 0f;
        }
        private void ToggleExclusivePopup(bool showingPopup)
        {
            if(this.TogglePopupWindow == 0)
            {
                    return;
            }
            
            this.TogglePopupWindow.Invoke(obj:  showingPopup);
        }
        private void UpdateGameplayDataFromKnobs(twelvegigs.storage.JsonDictionary allMinigamesKnobs)
        {
            System.Collections.IDictionary val_12;
            int val_19;
            int val_20;
            int val_21;
            int val_22;
            SLC.Minigames.MinigameManager val_34;
            SLC.Minigames.MinigameLevelRank val_35;
            object val_36;
            var val_37;
            var val_38;
            twelvegigs.storage.JsonDictionary val_39;
            var val_40;
            System.Collections.Generic.List<ZooTile> val_41;
            twelvegigs.storage.JsonDictionary val_42;
            int val_43;
            int val_44;
            int val_45;
            twelvegigs.storage.JsonDictionary val_46;
            val_34 = this;
            AppConfigs val_1 = App.Configuration;
            string val_2 = this.CurrentMinigameId;
            val_35 = 0;
            MiniGame val_3 = 83886592.GetMiniGameById(id:  null);
            val_36 = mem[83886620];
            if((allMinigamesKnobs.Contains(key:  val_36)) == false)
            {
                goto label_7;
            }
            
            if(allMinigamesKnobs == 0)
            {
                goto label_8;
            }
            
            twelvegigs.storage.JsonDictionary val_5 = allMinigamesKnobs.getJsonDictionary(key:  val_36);
            this.currentKnobsData = allMinigamesKnobs;
            goto label_9;
            label_7:
            val_37 = ". Using Default Level data.";
            val_38 = "MinigameManager could not find econ data for minigame ";
            goto label_10;
            label_8:
            twelvegigs.storage.JsonDictionary val_6 = 0.getJsonDictionary(key:  val_36);
            this.currentKnobsData = 0;
            label_9:
            twelvegigs.storage.JsonDictionary val_7 = allMinigamesKnobs.getJsonDictionary(key:  val_36);
            twelvegigs.storage.JsonDictionary val_8 = allMinigamesKnobs.getJsonDictionary(key:  -1125333760);
            if((allMinigamesKnobs.Contains(key:  900069952)) == false)
            {
                goto label_13;
            }
            
            this.currentRankData.ranks.Clear();
            val_39 = allMinigamesKnobs;
            if(val_39 == 0)
            {
                    val_39 = allMinigamesKnobs;
            }
            
            System.Collections.Generic.List<System.Object> val_10 = val_39.getList(key:  900069952);
            List.Enumerator<T> val_11 = GetEnumerator();
            goto label_18;
            label_27:
            twelvegigs.storage.JsonDictionary val_13 = new twelvegigs.storage.JsonDictionary(parsedDictionary:  val_12);
            val_40 = null;
            val_40 = null;
            decimal val_15 = getDecimal(key:  458731520, defaultValue:  new System.Decimal() {flags = 900087440, hi = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_8, mid = System.Decimal.Powers10.__il2cppRuntimeField_C});
            string val_16 = getString(key:  1679334848, defaultValue:  1098586544);
            System.Collections.Generic.List<System.Object> val_17 = getList(key:  900087520);
            val_41 = null;
            val_41 = new System.Collections.Generic.List<ZooTile>(collection:  458731520);
            val_35 = null;
            val_35 = new SLC.Minigames.MinigameLevelRank(level:  getInt(key:  -1988561632, defaultValue:  0), percentage:  new System.Decimal() {flags = val_21, hi = val_22, lo = val_19, mid = val_20}, name:  null, checkpoints:  val_41);
            this.currentRankData.ranks.Add(item:  446484480);
            val_34 = val_34;
            label_18:
            if(MoveNext() == true)
            {
                goto label_27;
            }
            
            Dispose();
            label_13:
            val_42 = allMinigamesKnobs;
            if(val_42 == 0)
            {
                    val_42 = allMinigamesKnobs;
            }
            
            if((val_42.Contains(key:  900088640)) != false)
            {
                    val_43 = mem[1152921514096894816];
                if(val_42 == 0)
            {
                    val_43 = val_43;
                val_42 = allMinigamesKnobs;
            }
            
                decimal val_26 = getDecimal(key:  val_42, defaultValue:  new System.Decimal() {flags = 900088640, hi = val_43, lo = val_41, mid = this.currentRankData.ranks});
            }
            
            val_36 = val_36;
            if(val_42 == 0)
            {
                    val_42 = allMinigamesKnobs;
            }
            
            if((val_42.Contains(key:  900088720)) != false)
            {
                    val_44 = mem[1152921514096894832];
                if(val_42 == 0)
            {
                    val_44 = val_44;
                val_42 = allMinigamesKnobs;
            }
            
                decimal val_28 = getDecimal(key:  val_42, defaultValue:  new System.Decimal() {flags = 900088720, hi = val_44, lo = val_41, mid = val_36});
                val_36 = val_36;
            }
            
            if(val_42 == 0)
            {
                    val_42 = allMinigamesKnobs;
            }
            
            if((val_42.Contains(key:  900088800)) != false)
            {
                    val_45 = mem[1152921514096894848];
                if(val_42 == 0)
            {
                    val_45 = val_45;
                val_42 = allMinigamesKnobs;
            }
            
                decimal val_30 = getDecimal(key:  val_42, defaultValue:  new System.Decimal() {flags = 900088800, hi = val_45, lo = val_41, mid = val_36});
                val_36 = val_36;
            }
            
            if(val_42 == 0)
            {
                    val_42 = allMinigamesKnobs;
            }
            
            if((val_42.Contains(key:  900088880)) != false)
            {
                    val_42 = mem[1152921514096894864];
                val_46 = val_42;
                if(val_42 == 0)
            {
                    val_46 = allMinigamesKnobs;
            }
            
                decimal val_32 = getDecimal(key:  val_46, defaultValue:  new System.Decimal() {flags = 900088880, hi = val_42});
                val_36 = val_36;
            }
            
            val_37 = " level data from knobs.";
            val_38 = "MinigameManager loaded ";
            label_10:
            string val_33 = 900089088 + val_36 + 900088960;
            UnityEngine.Debug.LogWarning(message:  900089088);
        }
        public void LoadCurrentPlayerData()
        {
            SLC.Minigames.MinigamePlayerData val_2;
            SLC.Minigames.MinigamePlayerData val_1 = this.LoadPlayerDataFrom_Prefs();
            val_2 = this;
            this.currentPlayerData = this;
            if(this.currentRankData == 0)
            {
                    val_2 = this.currentPlayerData;
            }
            
            if(this <= this.currentPlayerData.rankIndex)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + (this.currentPlayerData.rankIndex << 2);
            int val_3 = this.currentPlayerData.checkpointLevel;
            val_3 = val_3 + ((0 + (this.currentPlayerData.rankIndex) << 2) + 16 + 8);
            this.currentPlayerLevel = val_3;
        }
        public void SaveCurrentPlayerData()
        {
            this.SavePlayerDataTo_Prefs();
        }
        private SLC.Minigames.MinigamePlayerData LoadPlayerDataFrom_Prefs()
        {
            bool val_4;
            var val_5;
            val_4 = static_value_021FCAB5;
            if(val_4 != true)
            {
                    val_4 = true;
            }
            
            string val_1 = this.CurrentMinigameId;
            val_5 = 0;
            string val_2 = UnityEngine.PlayerPrefs.GetString(key:  1, defaultValue:  -2040381152);
            object val_3 = MiniJSON.Json.Deserialize(json:  1);
            if(val_4 != 0)
            {
                    if(((-2065588224 + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    val_4 = 0;
            }
            
                val_5 = val_4;
            }
            
            this.currentPlayerData.Decode(jasonObject:  0, sourceModel:  0);
        }
        public static SLC.Minigames.MinigamePlayerData LoadMiniGameData(string minigameId)
        {
            var val_4;
            SLC.Minigames.MinigamePlayerData val_1 = new SLC.Minigames.MinigamePlayerData();
            val_4 = 0;
            string val_2 = UnityEngine.PlayerPrefs.GetString(key:  minigameId, defaultValue:  -2040381152);
            object val_3 = MiniJSON.Json.Deserialize(json:  minigameId);
            if(minigameId != null)
            {
                    if(((System.String.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    minigameId = 0;
            }
            
                val_4 = minigameId;
            }
            
            Decode(jasonObject:  0, sourceModel:  0);
        }
        private void SavePlayerDataTo_Prefs()
        {
            string val_1 = this.CurrentMinigameId;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = this.currentPlayerData.Encode(destination:  0);
            string val_3 = MiniJSON.Json.Serialize(obj:  this.currentPlayerData);
            UnityEngine.PlayerPrefs.SetString(key:  900755136, value:  this.currentPlayerData);
        }
        public bool HandleLevelComplete()
        {
            SLC.Minigames.MinigameManager val_11;
            var val_12;
            SLC.Minigames.MinigamePlayerData val_13;
            var val_14;
            SLC.Minigames.MinigamePlayerData val_15;
            int val_16;
            SLC.Minigames.MinigamePlayerData val_17;
            object val_1 = new System.Object();
            typeof(MinigameManager.<>c__DisplayClass64_0).__il2cppRuntimeField_8 = this;
            int val_11 = this.currentPlayerLevel;
            val_11 = val_11 + 1;
            this.currentPlayerLevel = val_11;
            SLC.Minigames.MinigameLevelRank val_2 = this.GetCurrentRank;
            val_11 = this;
            if(val_1 != 0)
            {
                    val_12 = val_1;
                typeof(MinigameManager.<>c__DisplayClass64_0).__il2cppRuntimeField_C = val_11;
            }
            else
            {
                    val_12 = 12;
                mem[12] = val_11;
                val_11 = mem[12];
            }
            
            val_13 = mem[1152921514097690720];
            System.Predicate<System.Int32> val_3 = new System.Predicate<System.Int32>(object:  446644224, method:  new IntPtr(900847232));
            int val_4 = val_13.FindLastIndex(match:  8040448);
            val_14 = 0;
            if(val_4 == 1)
            {
                    return (bool)val_14;
            }
            
            val_13 = mem[1152921514097690720];
            if((mem[1152921514097690720] + 12) <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_12 = mem[1152921514097690720] + 8;
            val_12 = val_12 + (val_4 << 2);
            if(this.currentPlayerData.checkpointLevel >= ((mem[1152921514097690720] + 8 + (val_4) << 2) + 16))
            {
                    return (bool)val_14;
            }
            
            val_15 = this.currentPlayerData;
            if(val_15 != 0)
            {
                    val_16 = this.currentPlayerData.checkpointsReached;
            }
            else
            {
                    val_15 = 16;
                val_16 = 2621443;
            }
            
            mem[16] = 2621444;
            System.Predicate<ZooTile> val_5 = new System.Predicate<ZooTile>(object:  446644224, method:  new IntPtr(900865664));
            if((this.currentPlayerData.rankIndex < (this.currentRankData.ranks.FindLastIndex(match:  8040448))) || (this.currentPlayerLevel >= this.GetMaximumPlayerLevel))
            {
                goto label_19;
            }
            
            val_13 = this.currentPlayerData;
            if((mem[1152921514097690720] + 12) <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_13 = mem[1152921514097690720] + 8;
            val_13 = val_13 + (val_4 << 2);
            this.currentPlayerData.checkpointLevel = (mem[1152921514097690720] + 8 + (val_4) << 2) + 16;
            this.SavePlayerDataTo_Prefs();
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowCheckpoint();
            goto label_28;
            label_19:
            val_13 = this.currentPlayerLevel;
            if(val_13 >= this.GetMaximumPlayerLevel)
            {
                goto label_29;
            }
            
            val_17 = this.currentPlayerData;
            if(val_17 == 0)
            {
                goto label_30;
            }
            
            val_13 = this.currentPlayerData.rankIndex;
            goto label_31;
            label_29:
            this.currentPlayerLevel = mem[1152921514097690696];
            goto label_34;
            label_30:
            val_17 = 8;
            val_13 = 0;
            label_31:
            mem[8] = 1;
            label_34:
            this.currentPlayerData.checkpointLevel = 0;
            this.SavePlayerDataTo_Prefs();
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowRankup();
            label_28:
            val_14 = 1;
            return (bool)val_14;
        }
        public bool HandleLevelFailed()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowContinue();
            return false;
        }
        public void HandleGameContinue()
        {
            if(this.OnContinueMinigame == 0)
            {
                    return;
            }
            
            this.OnContinueMinigame.Invoke();
        }
        public void HandleGameRestart()
        {
            this.LoadCurrentPlayerData();
            this._session_startLevel = this.currentPlayerLevel;
            this._session_adsWatched = 0;
            float val_1 = UnityEngine.Time.unscaledTime;
            this._session_startTime = 0f;
            if(this.OnRestartMinigame == 0)
            {
                    return;
            }
            
            this.OnRestartMinigame.Invoke();
        }
        public void HandleCheckpointRankUpContinue()
        {
            if(this.OnCheckpointRankUpContinue == 0)
            {
                    return;
            }
            
            this.OnCheckpointRankUpContinue.Invoke();
        }
        public void HandleHomeClicked(bool redirectToGameplay = False)
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static Bootstrapper MonoSingleton<Bootstrapper>::get_Instance().__il2cppRuntimeField_20) != 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_3 = R7.CurrentMinigameScene;
            R7.HandleLeaveMinigame(redirectToGameplay:  R4, currentGame:  R7);
        }
        public UnityEngine.Texture GetMainGameAdvert()
        {
            AppConfigs val_1 = WordApp.getConfig();
            string val_2 = System.String.Format(format:  901614464, arg0:  2621443);
            return UnityEngine.Resources.Load<System.Object>(path:  901614464);
        }
        public string GetMainGameName()
        {
            AppConfigs val_1 = WordApp.getConfig();
            if(0 != 0)
            {
                    return;
            }
        
        }
        public void HandlePauseClicked()
        {
            if(this.OnPauseClicked == 0)
            {
                    return;
            }
            
            this.OnPauseClicked.Invoke();
        }
        private void OnApplicationPause(bool pauseStatus)
        {
            if(pauseStatus == true)
            {
                    return;
            }
            
            WGGenericNotificationsManager.CancelPostAdNotification();
        }
        private void OnDestroy()
        {
            null = null;
            SLC.Minigames.MinigamesKnobsManager.defaultKnobData = 0;
        }
        public void AdWatched()
        {
            int val_1 = this._session_adsWatched;
            val_1 = val_1 + 1;
            this._session_adsWatched = val_1;
        }
        public void Cointinue(decimal cost)
        {
            int val_2;
            int val_3;
            val_2 = cost.lo;
            val_3 = cost.mid;
            val_3 = cost.mid;
            val_2 = val_2;
            decimal val_1 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = 902307728, hi = this._session_continuePurchased, lo = R6, mid = R7}, d2:  new System.Decimal() {flags = 35637950, hi = cost.flags, lo = cost.hi, mid = val_2});
        }
        public void StartMinigameSession()
        {
            this._session_startLevel = this.currentPlayerLevel;
            this._session_adsWatched = 0;
            float val_1 = UnityEngine.Time.unscaledTime;
            this._session_startTime = 0f;
        }
        public void TrackMinigameSessionEnd()
        {
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            bool val_30;
            var val_31;
            Player val_1 = App.Player;
            val_24 = 2621448;
            if(val_24 != 0)
            {
                    val_25 = 35143844;
            }
            else
            {
                    val_24 = 28;
                val_25 = 52;
            }
            
            mem[28] = 53;
            Player val_2 = App.Player;
            decimal val_3 = System.Decimal.op_Implicit(value:  902536888);
            decimal val_4 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 902536872, hi = this.checkpointReward, lo = SL, mid = R7}, d2:  new System.Decimal() {flags = ???});
            decimal val_5 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = 902536848, hi = 23, lo = 35143848, mid = 23}, d2:  new System.Decimal() {flags = 35143852});
            Player val_6 = App.Player;
            val_26 = 2621448;
            if(val_26 != 0)
            {
                    val_27 = this;
                val_28 = 23;
                val_29 = mem[1152921514099330640];
            }
            else
            {
                    val_27 = this;
                val_26 = 48;
                val_29 = mem[1152921514099330640];
                val_28 = 1835037;
            }
            
            mem[48] = val_28 + val_29;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_8 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_30 = 0;
            if((-1919087520) != 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_30 = 0;
                int val_12 = DeeplinkedWhichMinigame;
                if(val_12 == val_12.currentMinigameIndex)
            {
                    twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_30 = DeeplinkConsumed ^ 1;
            }
            
            }
            
            Add(key:  902523888, value:  8945664);
            twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            DeeplinkConsumed = true;
            string val_17 = CurrentMinigameName;
            Add(key:  902524000, value:  -1919087520);
            SLC.Minigames.MinigameLevelRank val_18 = this.GetCurrentRank;
            Add(key:  902524096, value:  mem[1152921514099330540]);
            Add(key:  902524192, value:  13152256);
            SLC.Minigames.MinigameLevelRank val_19 = this.GetCurrentRank;
            int val_23 = mem[1152921514099330520];
            val_23 = val_23 + this.currentPlayerData.checkpointLevel;
            Add(key:  902524304, value:  13152256);
            Add(key:  902524416, value:  13152256);
            Add(key:  902524512, value:  10170368);
            float val_20 = UnityEngine.Time.unscaledTime;
            float val_24 = mem[1152921514099330644];
            val_24 = 0 - val_24;
            Add(key:  902524624, value:  15282176);
            decimal val_21 = System.Decimal.op_Implicit(value:  902536872);
            decimal val_22 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 902536848, hi = this.checkpointReward, lo = R6, mid = R8}, d2:  new System.Decimal() {flags = ???});
            Add(key:  902524736, value:  10170368);
            if(mem[1152921514099330628] != 0)
            {
                    mem[1152921514099330628].Invoke(obj:  78753792);
            }
            
            var val_25 = 23266870;
            val_25 = 12358668 + val_25;
            if(val_25 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_31 = null;
            val_31 = null;
            App.trackerManager.track(eventName:  902524832, data:  78753792);
        }
        public void QAHACK_IncrementCheckpoint()
        {
            this.currentPlayerData.checkpointLevel = this.GetNextCheckpointLevel;
            this.SavePlayerDataTo_Prefs();
            this.HandleGameRestart();
        }
        public void QAHACK_DecrementCheckpoint()
        {
            SLC.Minigames.MinigameLevelRank val_1 = this.GetCurrentRank;
            System.Predicate<System.Int32> val_2 = new System.Predicate<System.Int32>(object:  902791376, method:  new IntPtr(902765328));
            this.currentPlayerData.checkpointLevel = this.checkpointReward.FindLast(match:  8040448);
            this.SavePlayerDataTo_Prefs();
            this.HandleGameRestart();
        }
        public void QAHACK_IncrementRank()
        {
            SLC.Minigames.MinigamePlayerData val_1;
            int val_2;
            val_1 = this.currentPlayerData;
            if(val_1 != 0)
            {
                    val_2 = this.currentPlayerData.rankIndex;
            }
            else
            {
                    val_1 = 8;
                val_2 = 0;
            }
            
            mem[8] = 1;
            this.currentPlayerData.checkpointLevel = 0;
            this.SavePlayerDataTo_Prefs();
            this.HandleGameRestart();
        }
        public void QAHACK_DecrementRank()
        {
            this.currentPlayerData.rankIndex = UnityEngine.Mathf.Max(a:  0, b:  this.currentPlayerData.rankIndex - 1);
            this.currentPlayerData.checkpointLevel = 0;
            this.SavePlayerDataTo_Prefs();
            this.HandleGameRestart();
        }
        public bool get_QAHACK_FreeContinues()
        {
            return (bool)this.QAHACK_freeContinues;
        }
        public void set_QAHACK_FreeContinues(bool value)
        {
            this.QAHACK_freeContinues = value;
        }
        public MinigameManager()
        {
            this.numVideosRequired = 1;
            this.currentPlayerData = new SLC.Minigames.MinigamePlayerData();
            this.currentRankData = new SLC.Minigames.MinigameRankData();
            this.currentKnobsData = new twelvegigs.storage.JsonDictionary();
            decimal val_4 = new System.Decimal(value:  2);
            decimal val_5 = new System.Decimal(value:  120);
            decimal val_6 = new System.Decimal(value:  25);
             = new System.Decimal(value:  25);
        }
        private bool <get_GetNextCheckpointLevel>b__28_0(int x)
        {
            if(this.currentPlayerData.checkpointLevel < x)
            {
                    0 = 1;
            }
            
            return true;
        }
        private bool <QAHACK_DecrementCheckpoint>b__80_0(int x)
        {
            if(this.currentPlayerData.checkpointLevel > x)
            {
                    0 = 1;
            }
            
            return true;
        }
    
    }

}
