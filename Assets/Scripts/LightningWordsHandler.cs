using UnityEngine;
public class LightningWordsHandler : WGEventHandler
{
    // Fields
    private static LightningWordsHandler <Instance>k__BackingField;
    public const string LIGHTNING_WORDS_EVENT_ID = "LightningWords";
    private LightningWordsEventProgress eventProgress;
    private LightningWordsLevelProgress levelProgress;
    private LightningWordsLevelProgress trackLevelProgress;
    private const string ECONOMY = "economy";
    private const string REW = "rew";
    private const string R_N_LW = "r_n_lw";
    private const string A_C = "a_c";
    private const string DUR = "dur";
    private const string MPL = "mpl";
    private const string COINS = "coins";
    private const string BONUS_WHEEL = "bonus_wheel";
    private const string BONUS_SPIN = "bonus_spin";
    private const string PROGRESS = "progress";
    private const string REWARDED = "rewarded";
    private const GameEventRewardType DEFAULT_REWARD_TYPE = 1;
    private const int DEFAULT_REWARD_VALUE = 200;
    
    // Properties
    public static LightningWordsHandler Instance { get; set; }
    
    // Methods
    public static LightningWordsHandler get_Instance()
    {
    
    }
    private static void set_Instance(LightningWordsHandler value)
    {
        LightningWordsHandler.DEFAULT_REWARD_VALUE = value;
    }
    public override void Init(GameEventV2 eventV2)
    {
        LightningWordsHandler.DEFAULT_REWARD_VALUE = this;
        mem[1152921511875494360] = eventV2;
        this.ParseEventData(data:  eventV2.eventData);
        bool val_1 = this.IsEventNewCycle();
        if(val_1 == true)
        {
                val_1 = this;
            this.ResetLightningWordsEventProgress();
        }
        
        this.eventProgress.timestamp = this.eventProgress;
        if(this.eventProgress == 0)
        {
            
        }
    
    }
    public override void OnDataUpdated(GameEventV2 eventV2)
    {
        var val_7 = 35632142;
        if(true == 0)
        {
                return;
        }
        
        if((System.String.op_Inequality(a:  872415232, b:  -1321166448)) != false)
        {
                string val_2 = eventV2.ToString();
            string val_3 = -1322383584(-1322383584) + eventV2;
            UnityEngine.Debug.LogError(message:  -1322383584);
            return;
        }
        
        this.ParseEventData(data:  eventV2.eventData);
        bool val_4 = this.IsEventNewCycle();
        if(val_4 == true)
        {
                val_4 = this;
            this.ResetLightningWordsEventProgress();
        }
        
        this.eventProgress.timestamp = this.eventProgress;
        if(this != 0)
        {
                return;
        }
        
        bool val_5 = this.InExpireInterval();
        if(val_5 == true)
        {
                return;
        }
        
        float val_6 = this.GetEventProgress();
        if(val_5 < 0)
        {
                return;
        }
        
        this.ShowLightningWordsPopup();
    }
    public override void OnGameSceneBegan()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                return;
        }
        
        if(this.InExpireInterval() == true)
        {
                return;
        }
        
        if(this != 0)
        {
                return;
        }
        
        WordRegion val_4 = WordRegion.instance;
        System.Action<twelvegigs.storage.JsonDictionary> val_5 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1320950480, method:  new IntPtr(2973966192));
        0.addOnWordFoundAction(callback:  7401472);
        if(this.levelProgress.lightningRemainingTime >= 0)
        {
                this.levelProgress.lightningRemainingTime = this;
            this.ResumeLightningCountDownTimer();
        }
        
        if(this.GetLightningCountDown() >= 1)
        {
                if((System.String.IsNullOrEmpty(value:  this.levelProgress.currentLightningWord)) == true)
        {
                return;
        }
        
            if(this.levelProgress.IsCurrentModeEqualsModeWithTile() == false)
        {
                return;
        }
        
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ApplyLightningEffects(wordIndex:  this.levelProgress.currentLightningWordIndex);
            return;
        }
        
        this.levelProgress.ReleaseCurrentLightningWord();
    }
    public override void OnLevelComplete(int levelsProgressed = 1)
    {
        LightningWordsEventProgress val_2;
        int val_3;
        if(this != 0)
        {
                return;
        }
        
        if(this.levelProgress.firstLightningWordTimeRemaining <= 1)
        {
                val_2 = this.eventProgress;
            if(val_2 != 0)
        {
                val_3 = this.eventProgress.missedLevels;
        }
        else
        {
                val_2 = 16;
            val_3 = 2621443;
        }
        
            mem[16] = 2621444;
        }
        
        if(this.eventProgress.resetLevelProgress != true)
        {
                this.trackLevelProgress = this.levelProgress;
            this.levelProgress = new LightningWordsLevelProgress();
        }
        
        this.eventProgress.resetLevelProgress = false;
    }
    public override void OnEventEnded()
    {
        LightningWordsHandler.DEFAULT_REWARD_VALUE = 0;
        if(this.eventProgress == 0)
        {
            
        }
    
    }
    public override bool EventCompleted()
    {
        if(this.eventProgress != 0)
        {
                return (bool)this.eventProgress.rewarded;
        }
        
        return (bool)this.eventProgress.rewarded;
    }
    public override int LastProgressTimestamp()
    {
        if(this.eventProgress != 0)
        {
                return (int)this.eventProgress.lastProgressTimestamp;
        }
        
        return (int)this.eventProgress.lastProgressTimestamp;
    }
    public override void UpdateProgress()
    {
        this.eventProgress.lastProgressTimestamp = ServerHandler.UnixServerTime;
        this.UpdateProgress();
    }
    public override bool IsRewardReadyToCollect()
    {
        var val_2;
        float val_1 = this.GetEventProgress();
        val_2 = 0;
        if()
        {
                return (bool)val_2;
        }
        
        val_2 = this.eventProgress.rewarded >> 5;
        return (bool)val_2;
    }
    public override void MarkEventRewarded()
    {
        var val_9;
        GameEventRewardType val_10;
        val_9 = null;
        val_9 = null;
        val_10 = LightningWordsEcon.rewardType;
        if(val_10 != 1)
        {
            goto label_3;
        }
        
        label_31:
        this.eventProgress.rewarded = true;
        this.UpdateProgressionToServer();
        return;
        label_3:
        val_9 = null;
        val_10 = LightningWordsEcon.rewardType;
        if(val_10 != 3)
        {
            goto label_8;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = GetWindow<System.Object>();
        if((2119322896 == 0) || (enabled == false))
        {
            goto label_31;
        }
        
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_10 = 0;
        goto label_31;
        label_8:
        val_10 = LightningWordsEcon.rewardType;
        if(val_10 != 4)
        {
            goto label_31;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_6 = GetWindow<System.Object>();
        if((2119322896 == 0) || (enabled == false))
        {
            goto label_31;
        }
        
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_44 = 0;
        goto label_31;
    }
    public override void OnSubmitWordWithHints(string word)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                return;
        }
        
        if(this != 0)
        {
                return;
        }
        
        this.OnWordFound(word:  word);
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        var val_1;
        if(this != 0)
        {
                return;
        }
        
        this.ShowLightningWordsPopup();
        var val_1 = 26245491;
        val_1 = 9380300 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 45;
    }
    public override void OnGameButtonPressed(bool connected)
    {
        var val_1;
        if(this != 0)
        {
                return;
        }
        
        this.ShowLightningWordsPopup();
        var val_1 = 26245247;
        val_1 = 9380544 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 46;
    }
    public override string GetMainMenuButtonText()
    {
        typeof(System.String[]).__il2cppRuntimeField_10 = "<size=43>";
        string val_1 = Localization.Localize(key:  -1319592768, defaultValue:  -1319592880, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_14 = "lightning_words_upper";
        typeof(System.String[]).__il2cppRuntimeField_18 = " ";
        string val_2 = this.GetEventProgressText(spaced:  false);
        typeof(System.String[]).__il2cppRuntimeField_1C = this;
        typeof(System.String[]).__il2cppRuntimeField_20 = "</size>";
        return +477709520;
    }
    public override string GetGameButtonText()
    {
        return this.GetEventProgressText(spaced:  false);
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -1319592768, defaultValue:  -1319592880, useSingularKey:  false);
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        TheLibraryMainScreen val_1 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        string val_2 = this.GetEventProgressText(spaced:  false);
        float val_3 = this.GetEventProgress();
        if(loader == 0)
        {
            
        }
    
    }
    public override void AppendLevelCompleteData(ref System.Collections.Generic.Dictionary<string, object> currentData)
    {
        if(this != 0)
        {
                return;
        }
        
        if(this.trackLevelProgress == 0)
        {
                return;
        }
        
        if(typeof(LightningWordsHandler).__il2cppRuntimeField_2A0 >= 1)
        {
                this.trackLevelProgress = this.trackLevelProgress.firstLightningWordTimeRemaining;
        }
        
        if(this.trackLevelProgress < 0)
        {
                return;
        }
        
        35632153 = currentData;
        35632153.Add(key:  -1319127232, value:  13152256);
        currentData.Add(key:  -1319123024, value:  13152256);
    }
    public override bool IsChallengeCompleted()
    {
        goto typeof(LightningWordsHandler).__il2cppRuntimeField_29C;
    }
    private void ParseEventData(System.Collections.Generic.Dictionary<string, object> data)
    {
        var val_27;
        string val_28;
        string val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        if(data == 0)
        {
                return;
        }
        
        val_27 = 1152921510392296080;
        if((data.ContainsKey(key:  -1554533760)) != false)
        {
                object val_2 = data.Item[-1554533760];
            if(data != 0)
        {
                val_28 = data;
            val_29 = "rew";
            if((val_28.ContainsKey(key:  -1605526400)) != false)
        {
                object val_4 = val_28.Item[-1605526400];
            val_30 = 0;
            if(val_28 != 0)
        {
                if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_28 = 0;
        }
        
            val_30 = val_28;
        }
        
            this.ParseRewards(rewardData:  0);
        }
        
            if((val_28.ContainsKey(key:  -1318882592)) != false)
        {
                object val_6 = val_28.Item[-1318882592];
            string val_7 = val_28.ToString();
            val_29 = val_28;
            val_31 = null;
            val_31 = null;
            bool val_9 = System.Int32.TryParse(s:  val_29, result: out  int val_8 = 377212936);
        }
        
            if((val_28.ContainsKey(key:  -1318882512)) != false)
        {
                object val_11 = val_28.Item[-1318882512];
            string val_12 = val_28.ToString();
            val_29 = val_28;
            val_32 = null;
            val_32 = null;
            bool val_14 = System.Single.TryParse(s:  val_29, result: out  float val_13 = 2.034127E-25f);
        }
        
            if((val_28.ContainsKey(key:  -1318882432)) != false)
        {
                object val_16 = val_28.Item[-1318882432];
            string val_17 = val_28.ToString();
            val_29 = val_28;
            val_33 = null;
            val_33 = null;
            bool val_19 = System.Int32.TryParse(s:  val_29, result: out  int val_18 = 377212944);
        }
        
            if((val_28.ContainsKey(key:  -1386015152)) != false)
        {
                object val_21 = val_28.Item[-1386015152];
            string val_22 = val_28.ToString();
            val_28 = val_28;
            val_34 = null;
            val_34 = null;
            bool val_24 = System.Int32.TryParse(s:  val_28, result: out  int val_23 = 377212948);
        }
        
        }
        
        }
        
        if((data.ContainsKey(key:  -1545439648)) == false)
        {
                return;
        }
        
        object val_26 = data.Item[-1545439648];
        if(data == 0)
        {
                return;
        }
    
    }
    private void ParseRewards(System.Collections.Generic.Dictionary<string, object> rewardData)
    {
        GameEventRewardType val_12;
        int val_13;
        var val_14;
        Dictionary.Enumerator<TKey, TValue> val_1 = GetEnumerator();
        label_10:
        if(0.MoveNext() == false)
        {
            goto label_2;
        }
        
        bool val_5 = System.Int32.TryParse(s:  R7, result: out  int val_4 = -1318750036);
        if((0 < 1) || (0 != 1))
        {
            goto label_10;
        }
        
        string val_6 = 0.Trim();
        string val_7 = 0.ToLower();
        if((System.String.Compare(strA:  null, strB:  -1987496016)) == 0)
        {
            goto label_8;
        }
        
        if((System.String.Compare(strA:  null, strB:  -1318762160)) == 0)
        {
            goto label_9;
        }
        
        if((System.String.Compare(strA:  null, strB:  -1318762064)) != 0)
        {
            goto label_10;
        }
        
        val_12 = 4;
        goto label_13;
        label_2:
        val_13 = 0;
        val_12 = 0;
        goto label_12;
        label_8:
        val_12 = 1;
        goto label_13;
        label_9:
        val_12 = 3;
        label_13:
        val_13 = 0;
        label_12:
        0.Dispose();
        val_14 = null;
        if(val_12 != 0)
        {
                val_14 = null;
        }
        else
        {
                val_13 = 200;
            val_12 = 1;
        }
        
        LightningWordsEcon.rewardType = ;
        LightningWordsEcon.reward = ;
    }
    private void ParseProgress(System.Collections.Generic.Dictionary<string, object> progress)
    {
        if((progress.ContainsKey(key:  -1472372400)) == false)
        {
                return;
        }
        
        object val_2 = progress.Item[-1472372400];
        string val_3 = progress.ToString();
        bool val_5 = System.Boolean.TryParse(value:  progress, result: out  bool val_4 = true);
        this.eventProgress.rewarded = false;
    }
    private void OnWordFound(string word)
    {
        System.DateTime val_12;
        LightningWordsLevelProgress val_14;
        string val_15;
        LightningWordsLevelProgress val_16;
        var val_17;
        val_14 = 35632157;
        if(this.InExpireInterval() == true)
        {
                return;
        }
        
        val_14 = this.levelProgress;
        val_15 = word;
        if(((System.String.op_Equality(a:  this.levelProgress.currentLightningWord, b:  val_15)) != false) && (this.levelProgress.IsCurrentModeEqualsModeWithTile() != false))
        {
                int val_4 = this.GetLightningCountDown();
            val_14 = this.levelProgress;
            if(this.levelProgress.firstLightningWordTimeRemaining <= 1)
        {
                val_16 = this.levelProgress;
            val_15 = 0;
            int val_5 = UnityEngine.Mathf.Max(a:  val_4, b:  0);
            val_14 = val_5;
            this.levelProgress.firstLightningWordTimeRemaining = val_14;
        }
        
            if(val_4 >= 0)
        {
                val_5 = this;
            this.HandleLightningWordFound(word:  null);
        }
        
            this.levelProgress.ReleaseCurrentLightningWord();
        }
        
        if(this.IsLightningWordReady() == false)
        {
                return;
        }
        
        this.ResetLightningWordJustFoundStatus();
        this.eventProgress.missedLevels = 0;
        val_14 = 0;
        System.DateTime val_7 = DateTimeCheat.Now;
        val_16 = 1152921504984055808;
        val_17 = null;
        val_17 = null;
        int val_14 = LightningWordsEcon.duration;
        val_14 = val_14 + 1;
        System.DateTime val_10 = AddSeconds(value:  null);
        this.levelProgress.lightningEndTime = val_12;
        this.ShowLightningWord();
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PlayLightningSFX();
    }
    private void ShowLightningWord()
    {
        int val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_7 = this.levelProgress.currentLightningWordIndex;
        if(val_7 == 1)
        {
                val_7 = this.GenerateNewLightningWordIndex();
        }
        
        val_8 = 1152921504901095424;
        val_9 = 1152921511875801968;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_10 = public static LightningWordsUIController MonoSingleton<LightningWordsUIController>::get_Instance();
        ApplyLightningEffects(wordIndex:  val_7);
        val_11 = null;
        if(this.eventProgress.isFTUX != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowFTUX();
            this.eventProgress.isFTUX = false;
            val_11 = this.eventProgress;
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            R8.ShowLightningStrikeFlyout();
        }
    
    }
    private void HandleLightningWordFound(string word)
    {
        LightningWordsLevelProgress val_4;
        var val_5;
        LightningWordsEventProgress val_6;
        LightningWordsEventProgress val_7;
        val_4 = this.levelProgress;
        if(val_4 != 0)
        {
            
        }
        else
        {
                val_4 = 8;
            val_5 = 0;
        }
        
        mem[8] = 1;
        val_6 = this.eventProgress;
        if(val_6 != 0)
        {
            
        }
        else
        {
                val_6 = 8;
            val_7 = mem[8];
        }
        
        mem[8] = 2;
        this.eventProgress.isLightningWordJustFound = true;
        if(this.IsLevelCompleted() != false)
        {
                this.trackLevelProgress = this.levelProgress;
            val_7 = this.eventProgress;
            this.levelProgress = new LightningWordsLevelProgress();
            this.eventProgress.resetLevelProgress = true;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UpdateEventButton();
    }
    private int GenerateNewLightningWordIndex()
    {
        var val_10;
        var val_11;
        WordRegion val_1 = WordRegion.instance;
        if(0 == 0)
        {
                val_10 = "LightningWordsHandler:GenerateNewLightingWordIndex(): no WordRegion instance, will fail";
        }
        else
        {
                WordRegion val_3 = WordRegion.instance;
            if(0 != 0)
        {
                var val_10 = 0;
            null = new RandomSet();
            if(0 >= 1)
        {
                do
        {
            if(0 <= val_10)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_9 = 0;
            val_9 = val_9 + 0;
            if(((0 + 0) + 16 + 32) == 0)
        {
                add(item:  0, weight:  null);
        }
        
            val_10 = val_10 + 1;
        }
        while(val_10 < 0);
        
        }
        
            this.levelProgress.currentLightningWordIndex = roll(unweighted:  false);
            if(0 <= this.levelProgress.currentLightningWordIndex)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_11 = 0;
            val_11 = val_11 + (this.levelProgress.currentLightningWordIndex << 2);
            this.levelProgress.currentLightningWord = (0 + (this.levelProgress.currentLightningWordIndex) << 2) + 16 + 12;
            GameplayMode val_6 = PlayingLevel.CurrentGameplayMode;
            this.levelProgress.currentMode = 0;
            val_11 = 0;
            if(this.levelProgress.currentMode == 4)
        {
                twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_8 = (public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8).ToString();
        }
        
            this.levelProgress.currentModeSecondaryId = null;
            if(this.levelProgress != 0)
        {
                return (int)this.levelProgress.currentLightningWordIndex;
        }
        
            return (int)this.levelProgress.currentLightningWordIndex;
        }
        
            val_10 = "LightningWordsHandler:GenerateNewLightingWordIndex(): no WordRegion instance lines, will fail";
        }
        
        UnityEngine.Debug.LogError(message:  -1317964144);
        return 0;
    }
    private bool IsLightningWordReady()
    {
        var val_5;
        var val_6;
        if(this.IsLevelCompleted() != true)
        {
                if(this.eventProgress.missedLevels == 2)
        {
                val_5 = null;
            val_5 = null;
            val_6 = 1;
        }
        
            float val_2 = this.GetEventProgress();
            float val_3 = this.GetLevelProgress();
            val_6 = 0;
            val_6 = 0;
            bool val_4 = System.String.IsNullOrEmpty(value:  this.levelProgress.currentLightningWord);
            if(val_4 == false)
        {
                return (bool)val_6;
        }
        
            return val_4.IsSuperLucky();
        }
        
        val_6 = 0;
        return (bool)val_6;
    }
    private bool IsSuperLucky()
    {
        var val_2 = null;
        float val_2 = 100f;
        val_2 = LightningWordsEcon.appearingChance * val_2;
        if((UnityEngine.Random.Range(min:  0, max:  100)) < val_2)
        {
                0 = 1;
        }
        
        return true;
    }
    private bool IsLevelCompleted()
    {
        var val_5;
        WordRegion val_1 = WordRegion.instance;
        List.Enumerator<T> val_2 = GetEnumerator();
        label_7:
        if(MoveNext() == false)
        {
            goto label_5;
        }
        
        if((val_4 + 32) != 0)
        {
            goto label_7;
        }
        
        val_5 = 0;
        goto label_8;
        label_5:
        val_5 = 1;
        label_8:
        Dispose();
        return (bool)val_5;
    }
    private float GetLevelProgress()
    {
        null = null;
        float val_1 = (float)LightningWordsEcon.maxNumPerLvl;
        val_1 = (float)this.levelProgress / val_1;
        return (float)val_1;
    }
    private void UpdateProgressionToServer()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1470901296, value:  13152256);
        Add(key:  -1317334256, value:  13152256);
        Add(key:  -1317330064, value:  13152256);
        Add(key:  -1472372400, value:  8945664);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PutUpdate(eventID:  -1317301872, data:  78753792);
    }
    private void ResetLightningWordsEventProgress()
    {
        this.levelProgress = new LightningWordsLevelProgress();
        typeof(LightningWordsEventProgress).__il2cppRuntimeField_1B = 0;
        typeof(LightningWordsEventProgress).__il2cppRuntimeField_19 = 0;
        typeof(LightningWordsEventProgress).__il2cppRuntimeField_15 = 0;
        typeof(LightningWordsEventProgress).__il2cppRuntimeField_8 = 0;
        typeof(LightningWordsEventProgress).__il2cppRuntimeField_C = 0;
        typeof(LightningWordsEventProgress).__il2cppRuntimeField_10 = 0;
        typeof(LightningWordsEventProgress).__il2cppRuntimeField_14 = 1;
        this.eventProgress = new System.Object();
    }
    private bool IsEventNewCycle()
    {
        var val_1 = R6 + 8;
        val_1 = this.eventProgress.timestamp - val_1;
        if(R6 != 0)
        {
                val_1 = 1;
        }
        
        return true;
    }
    public void ShowLightningWordsPopup()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public void ShowInternetRequiredPopup()
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        string val_3 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_4 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_5 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_6 = null;
        val_6 = null;
        0.SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
    }
    public bool InExpireInterval()
    {
        ulong val_4;
        bool val_11;
        var val_12;
        ulong val_13;
        var val_15;
        val_11 = static_value_021FB429;
        if(val_11 != true)
        {
                val_11 = true;
        }
        
        val_12 = R6;
        if(R6 == 0)
        {
                if(val_12 == 0)
        {
            goto label_2;
        }
        
        }
        
        val_13 = mem[R6 + 40];
        val_13 = R6 + 40;
        if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = R6 + 32}, d2:  new System.DateTime() {dateData = val_13})) != false)
        {
                System.DateTime val_3 = DateTimeCheat.UtcNow;
            bool val_6 = System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_4}, t2:  new System.DateTime() {dateData = 1152921511880065296});
        }
        else
        {
                System.DateTime val_7 = DateTimeCheat.UtcNow;
            val_13 = mem[R6 + 44 + 32];
            val_13 = R6 + 44 + 32;
            val_15 = 0;
            if((System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_4}, t2:  new System.DateTime() {dateData = val_13})) == false)
        {
                return (bool)val_15;
        }
        
            System.DateTime val_9 = DateTimeCheat.UtcNow;
        }
        
        val_15 = System.DateTime.op_LessThanOrEqual(t1:  new System.DateTime() {dateData = val_4}, t2:  new System.DateTime() {dateData = 1152921511880065296});
        return (bool)val_15;
        label_2:
    }
    public float GetEventProgress()
    {
        null = null;
        float val_1 = (float)LightningWordsEcon.requiredNumWords;
        val_1 = (float)this.eventProgress / val_1;
        return (float)val_1;
    }
    public string GetEventProgressText(bool spaced = False)
    {
        var val_4;
        if(spaced == true)
        {
                "/" = " / ";
        }
        
        LightningWordsEventProgress val_1 = this.eventProgress + 8;
        string val_2 = val_1.ToString();
        val_4 = null;
        val_4 = null;
        string val_3 = val_1 + -1316508080(-1316508080) + 13152256;
    }
    public void PauseLightningCountDownTimer()
    {
        if(this.levelProgress.paused == true)
        {
                return;
        }
        
        mem2[0] = 1;
        int val_1 = R4.GetLightningCountDown();
        val_1 = val_1 + 1;
        mem2[0] = val_1;
        if((R4 + 20) == 0)
        {
            
        }
    
    }
    public void ResumeLightningCountDownTimer()
    {
        System.DateTime val_6;
        if(this.levelProgress.paused == false)
        {
                return;
        }
        
        this.levelProgress.paused = false;
        System.DateTime val_1 = DateTimeCheat.Now;
        System.DateTime val_4 = AddSeconds(value:  null);
        this.levelProgress.lightningEndTime = val_6;
        this.levelProgress.lightningRemainingTime = 0;
    }
    public bool IsLightningWordJustFound()
    {
        if(this.eventProgress != 0)
        {
                return (bool)this.eventProgress.isLightningWordJustFound;
        }
        
        return (bool)this.eventProgress.isLightningWordJustFound;
    }
    public void ResetLightningWordJustFoundStatus()
    {
        this.eventProgress.isLightningWordJustFound = false;
        mem2[0] = false;
        this.levelProgress.lightningEndTime = false;
    }
    public bool IsLightningCountDownTimerPaused()
    {
        if(this.levelProgress != 0)
        {
                return (bool)this.levelProgress.paused;
        }
        
        return (bool)this.levelProgress.paused;
    }
    public int GetLightningCountDown()
    {
        var val_5;
        System.DateTime val_1 = DateTimeCheat.Now;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511881059920}, d2:  new System.DateTime() {dateData = this.levelProgress.lightningEndTime});
        double val_7 = val_5.TotalSeconds;
        if(System.DateTime.__il2cppRuntimeField_cctor_finished == 0)
        {
                2979245664 = 2979245664;
        }
        
        return (int)S0;
    }
    public string GetEventRemainingTime()
    {
        var val_5;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511881176016}, d2:  new System.DateTime() {dateData = 1152921511881188064});
        int val_8 = UnityEngine.Mathf.Max(a:  val_5.Days, b:  0);
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        int val_10 = UnityEngine.Mathf.Max(a:  val_5.Hours, b:  0);
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        int val_12 = UnityEngine.Mathf.Max(a:  val_5.Minutes, b:  0);
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        int val_14 = UnityEngine.Mathf.Max(a:  val_5.Seconds, b:  0);
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        string val_15 = System.String.Format(format:  -1515309312, args:  472754880);
    }
    public bool IsLightningWordPeriod()
    {
        if((System.DateTime.op_Inequality(d1:  new System.DateTime() {dateData = this.levelProgress.lightningEndTime}, d2:  new System.DateTime())) == false)
        {
                return true;
        }
        
        if(this.GetLightningCountDown() > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public bool IsCoinSpentDuringLightningWord()
    {
        if(this.levelProgress.isCoinSpent != true)
        {
                bool val_2 = true;
            val_2 = val_2 ^ (this.GetLightningCountDown() >> 31);
            this.levelProgress.isCoinSpent = val_2;
        }
        
        if(this.levelProgress != 0)
        {
                return (bool)this.levelProgress.isCoinSpent;
        }
        
        return (bool)this.levelProgress.isCoinSpent;
    }
    public string GetCurrentLightningWord()
    {
        if(this.levelProgress != 0)
        {
                return;
        }
    
    }
    public void Hack_ResetLightningWordsEventProgress()
    {
        this.ResetLightningWordsEventProgress();
        if(this.eventProgress == 0)
        {
            
        }
    
    }
    public LightningWordsHandler()
    {
        typeof(LightningWordsEventProgress).__il2cppRuntimeField_1B = 0;
        typeof(LightningWordsEventProgress).__il2cppRuntimeField_19 = 0;
        typeof(LightningWordsEventProgress).__il2cppRuntimeField_15 = 0;
        typeof(LightningWordsEventProgress).__il2cppRuntimeField_8 = 0;
        typeof(LightningWordsEventProgress).__il2cppRuntimeField_C = 0;
        typeof(LightningWordsEventProgress).__il2cppRuntimeField_10 = 0;
        typeof(LightningWordsEventProgress).__il2cppRuntimeField_14 = 1;
        this.eventProgress = new System.Object();
        this.levelProgress = new LightningWordsLevelProgress();
    }

}
