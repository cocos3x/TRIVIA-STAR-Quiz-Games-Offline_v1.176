using UnityEngine;
public class TRVMainController : MonoSingleton<TRVMainController>
{
    // Fields
    private static TRVMainController.TRVMainControllerEntry _entryType;
    private const int REROLL_FTUX_LEVEL = 10;
    public static bool QAHACK_HURRY;
    public static bool QAHACK_CORRECT;
    private const string rerollUsedKey = "rerollUsed";
    private const string lastLowGemKey = "lastLowGem";
    public const string noAnswerSelectedCharacter = "!";
    private TRVQuizProgress currentGame;
    private int numCategoriesSelection;
    public System.Action OnQuizBegin;
    public System.Action<TRVQuizProgress> OnQuestionBegin;
    public System.Action<bool, TRVQuizProgress> OnQuizComplete;
    public System.Func<TRVQuizProgress> GetNewQuizFromFeature;
    public System.Func<QuestionData> GetExternalFeatureQuestion;
    public System.Func<bool> ShowLevelComplete;
    public System.Func<bool> ShowLevelFailed;
    public System.Func<bool> PlayingChallenge;
    public System.Action<bool> OnQuestionAnswered;
    private bool <rerolled>k__BackingField;
    
    // Properties
    public static TRVMainController.TRVMainControllerEntry entryType { get; set; }
    public static int currentMultiplier { get; set; }
    public static int getRerollFTUXLEVEL { get; }
    public TRVQuizProgress getCurrentGame { get; }
    public int getQuizLength { get; }
    public System.DateTime freeLifeAvailableAt { get; }
    public bool freeLifeAvailable { get; }
    public bool IsPlayingChallenge { get; }
    public bool rerolled { get; set; }
    private bool spentGemsLastQuiz { get; set; }
    public bool eventEntryType { get; }
    
    // Methods
    public static TRVMainController.TRVMainControllerEntry get_entryType()
    {
        null = null;
    }
    public static void set_entryType(TRVMainController.TRVMainControllerEntry value)
    {
        null = null;
        TRVMainController.noAnswerSelectedCharacter = value;
    }
    public static int get_currentMultiplier()
    {
        Player val_1 = App.Player;
        WordForest.WFOGameEcon val_2 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  mem[1152921512476916256])) == false)
        {
                return 0;
        }
        
        return CPlayerPrefs.GetInt(key:  -494920304, defaultValue:  0);
    }
    public static void set_currentMultiplier(int value)
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        CPlayerPrefs.SetInt(key:  -494920304, val:  UnityEngine.Mathf.Min(a:  value, b:  mem[1152921512476916292] + 12));
    }
    public static int get_getRerollFTUXLEVEL()
    {
        return 10;
    }
    public TRVQuizProgress get_getCurrentGame()
    {
    
    }
    public int get_getQuizLength()
    {
        if(this.currentGame != 0)
        {
                return (int)this.currentGame.quizLength;
        }
        
        return (int)this.currentGame.quizLength;
    }
    public System.DateTime get_freeLifeAvailableAt()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_2 = freeLifeCoolDownMinutes;
        System.DateTime val_4 = this.AddMinutes(value:  null);
        return new System.DateTime() {dateData = val_4.dateData};
    }
    public bool get_freeLifeAvailable()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        return public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.freeLifeAvailable;
    }
    public bool get_IsPlayingChallenge()
    {
        var val_3;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_3 = 1;
        if(IsPlaying() == true)
        {
                return (bool)val_3;
        }
        
        val_3 = 0;
        if(this.PlayingChallenge == 0)
        {
                return (bool)val_3;
        }
        
        return this.PlayingChallenge.Invoke();
    }
    public bool get_rerolled()
    {
        return (bool)this.<rerolled>k__BackingField;
    }
    public void set_rerolled(bool value)
    {
        this.<rerolled>k__BackingField = value;
    }
    private bool get_spentGemsLastQuiz()
    {
        return CPlayerPrefs.GetBool(key:  -493774608, defaultValue:  false);
    }
    private void set_spentGemsLastQuiz(bool value)
    {
        CPlayerPrefs.SetBool(key:  -493774608, value:  value);
    }
    public bool get_eventEntryType()
    {
        var val_1;
        var val_1 = 24811462;
        val_1 = 10818276 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        string val_2 = TRVMainController.noAnswerSelectedCharacter;
        val_2 = val_2 - 2;
        val_2 = val_2 >> 5;
        return (bool)val_2;
    }
    private void Start()
    {
        var val_2;
        var val_2 = 24811242;
        val_2 = 10818496 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        if(TRVMainController.noAnswerSelectedCharacter <= 3)
        {
                var val_1 = 10818592 + (10818592 + (TRVMainController.noAnswerSelectedCharacter) << 2);
            if(TRVMainController.noAnswerSelectedCharacter == 3)
        {
                val_2 = 360701952;
            val_2 = 1507328;
            val_2 = 1507328;
            val_2 = val_2 & (((val_2) << (32-as. 
            
        
        
        
        
        
           
        )) | ((val_2) << as. 
            
        
        
        
        
        
           
        ));
        }
        
        }
        
        this.Init(currentlySelectedCategores:  0, fromReroll:  false);
    }
    public void Init(System.Collections.Generic.List<string> currentlySelectedCategores, bool fromReroll = False)
    {
        var val_33;
        float val_48;
        System.Collections.Generic.List<System.String> val_49;
        var val_50;
        int val_51;
        com.adjust.sdk.JSONNode val_52;
        TRVQuizProgress val_53;
        var val_54;
        System.Func<TRVCategorySelectionInfo, System.Boolean> val_56;
        val_48 = this;
        val_49 = currentlySelectedCategores;
        if(fromReroll == false)
        {
                CheckLowGems();
        }
        
        if(val_49 == 0)
        {
            goto label_1;
        }
        
        label_52:
        var val_48 = 24829438;
        val_48 = 10800300 + val_48;
        if(val_48 == 0)
        {
                mem2[0] = 1;
        }
        
        val_50 = null;
        val_50 = null;
        if(TRVMainController.noAnswerSelectedCharacter == null)
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowAvailablePopups(fromMinimize:  false, entry:  1098586544);
        }
        
        if(val_49 == 0)
        {
            goto label_11;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        mem2[0] = 0;
        public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.SaveProgress();
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_51 = mem[public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28 + 28];
        val_51 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28 + 28;
        Player val_4 = App.Player;
        if(val_51 != 0)
        {
            goto label_21;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28 + 20.AddRange(collection:  val_49);
        goto label_27;
        label_1:
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CPlayerPrefs.SetBool(key:  -493322432, value:  false);
        goto label_52;
        label_21:
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        mem2[0] = val_49;
        public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.SaveProgress();
        label_27:
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Player val_13 = App.Player;
        mem2[0] = 0;
        public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.SaveProgress();
        CPlayerPrefs.SetBool(key:  -493322432, value:  true);
        label_11:
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_17 = CheckDataIsOld(currentlySelectedCategories:  public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28 + 16);
        val_52 = 0;
        if(val_17 != false)
        {
                val_17.GetNewCategories(currentlySelectedCategories:  val_49);
            val_52 = 1;
        }
        
        var val_49 = 24827779;
        val_49 = 10801960 + val_49;
        if(val_49 == 0)
        {
                mem2[0] = 1;
        }
        
        if(TRVCrazyCategoriesEventHandler.EVENT_TRACKING_ID != null)
        {
                bool val_18 = System.String.IsNullOrEmpty(value:  TRVCrazyCategoriesEventHandler.EVENT_TRACKING_ID + 16);
            val_18 = val_52 | val_18;
            if(val_18 == true)
        {
                twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            TRVCrazyCategoriesEventHandler.RollBonusCategory(chosenCategories:  public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28 + 16);
        }
        
        }
        
        CompanyDevices val_20 = CompanyDevices.Instance;
        val_53 = 0;
        if(0.CompanyDevice() != false)
        {
                var val_50 = 4;
            val_49 = 1152921512370650272;
            do
        {
            twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_51 = val_50 - 4;
            System.Collections.Generic.List<System.String> val_23 = HackCategories;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if((System.String.IsNullOrEmpty(value:  public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_8 + 16)) != true)
        {
                twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_26 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<System.String> val_27 = HackCategories;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_52 = mem[public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_8 + 16];
            val_52 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_8 + 16;
            public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28 + 16.set_Item(index:  val_51, value:  val_52);
        }
        
            val_50 = val_50 + 1;
        }
        while(val_50 != 7);
        
        }
        
        this.currentGame = val_53;
        if(this.GetNewQuizFromFeature != 0)
        {
                TRVQuizProgress val_28 = this.GetNewQuizFromFeature.Invoke();
            this.currentGame = this.GetNewQuizFromFeature;
            if(this.GetNewQuizFromFeature != 0)
        {
                this.SetupAndAnimateNewQuiz();
            this.TrackLevelStart();
            if(this.OnQuizBegin == 0)
        {
                return;
        }
        
            this.OnQuizBegin.Invoke();
            return;
        }
        
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_29 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        twelvegigs.Autopilot.AutopilotManager val_30 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        List.Enumerator<T> val_31 = GetEnumerator();
        val_48 = 1152921510891363008;
        val_53 = 1152921504687730688;
        val_49 = 1152921511884344944;
        label_120:
        if(MoveNext() == false)
        {
            goto label_117;
        }
        
        TRVCategorySelectionInfo val_34 = new TRVCategorySelectionInfo();
        typeof(TRVCategorySelectionInfo).__il2cppRuntimeField_8 = val_33;
        typeof(TRVCategorySelectionInfo).__il2cppRuntimeField_C = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  356761600);
        goto label_120;
        label_117:
        Dispose();
        twelvegigs.Autopilot.AutopilotManager val_36 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<TRVCategorySelectionInfo> val_37 = GetEventsRegisteredCategories(categories:  80883712);
        val_51 = public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance();
        val_54 = null;
        val_54 = null;
        val_56 = TRVMainController.<>c.<>9__47_0;
        if(val_56 == 0)
        {
                val_56 = null;
            val_56 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  TRVMainController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3801656224));
            TRVMainController.<>c.<>9__47_0 = val_56;
        }
        
        if((System.Linq.Enumerable.Any<MessageTypeSubscribers>(source:  -2101040096, predicate:  7720960)) == false)
        {
            goto label_129;
        }
        
        UnityEngine.Debug.LogError(message:  -493310048);
        GetNewCategories(currentlySelectedCategories:  val_49);
        val_51 = null;
        val_51 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        twelvegigs.Autopilot.AutopilotManager val_41 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        List.Enumerator<T> val_42 = GetEnumerator();
        label_140:
        if(MoveNext() == false)
        {
            goto label_137;
        }
        
        TRVCategorySelectionInfo val_44 = new TRVCategorySelectionInfo();
        typeof(TRVCategorySelectionInfo).__il2cppRuntimeField_8 = val_33;
        typeof(TRVCategorySelectionInfo).__il2cppRuntimeField_C = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  356761600);
        goto label_140;
        label_137:
        Dispose();
        label_129:
        GameBehavior val_46 = App.getBehavior;
        val_52 = val_52;
        0.Init(selectedCategorys:  80883712, animate:  true, canReroll:  true);
    }
    public void InitQOTD()
    {
        this.CheckLowGems();
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        TRVCategorySelectionInfo val_2 = GetRandomSubCategory();
        this.OnCategorySelected(selectedSubCat:  -718511200, selectedPrimaryCat:  -541405920);
    }
    public void InitSpecialCategories()
    {
        this.CheckLowGems();
        TRVCategorySelectionInfo val_1 = TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID.GetEventSubCategory();
        string val_2 = TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID.GetEventPrimaryCategory();
        this.OnCategorySelected(selectedSubCat:  TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID, selectedPrimaryCat:  TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID);
    }
    private void InitPromoCategories()
    {
        this.CheckLowGems();
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        TRVCategorySelectionInfo val_2 = GetCurrentlyShownSubCategory();
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_4 = GetPrimaryCategory();
        this.OnCategorySelected(selectedSubCat:  -581136352, selectedPrimaryCat:  -581136352);
    }
    public void InitSpecialCategories(TRVCategorySelectionInfo categorySelectionInfo, string primaryCategoryName)
    {
        this.CheckLowGems();
        this.OnCategorySelected(selectedSubCat:  categorySelectionInfo, selectedPrimaryCat:  primaryCategoryName);
    }
    private void GetNewCategories(System.Collections.Generic.List<string> currentlySelectedCategories)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<System.String> val_3 = GetNewCategories(currentlySelectedCategories:  currentlySelectedCategories);
        mem2[0] = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance();
        public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.SaveProgress();
    }
    private void CheckLowGems()
    {
        ulong val_16;
        ulong val_18;
        bool val_25;
        var val_26;
        var val_28;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(VideoAdsAllowed == false)
        {
                return;
        }
        
        WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        bool val_4 = rewardVideoCapReached;
        if(val_4 == true)
        {
                return;
        }
        
        if(val_4.spentGemsLastQuiz == false)
        {
                return;
        }
        
        val_25 = 1152921504892043264;
        Player val_6 = App.Player;
        WordForest.WFOGameEcon val_7 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if(0 >= mem[1152921512476916332])
        {
                return;
        }
        
        val_26 = null;
        val_26 = null;
        string val_8 = System.DateTime.MinValue.ToString();
        string val_9 = CPlayerPrefs.GetString(key:  -492599808, defaultValue:  -492587760);
        if((System.DateTime.TryParse(s:  -492599808, result: out  new System.DateTime() {dateData = 1152921512704193816})) == false)
        {
                return;
        }
        
        System.DateTime val_11 = Date;
        System.DateTime val_12 = DateTimeCheat.UtcNow;
        System.DateTime val_15 = Date;
        if((System.DateTime.op_Inequality(d1:  new System.DateTime() {dateData = val_18}, d2:  new System.DateTime() {dateData = val_16})) == false)
        {
                return;
        }
        
        GameBehavior val_21 = App.getBehavior;
        if(0 != 0)
        {
                val_28 = null;
            val_28 = null;
            val_25 = mem[1179403827];
            if(((mem[1179403747] + (WGRewardedVideoPopup.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_28)
        {
                0 = 0;
        }
        
        }
        
        0.InitAsLowGems(lowGems:  true);
        System.DateTime val_23 = DateTimeCheat.UtcNow;
        string val_24 = val_18.ToString();
        CPlayerPrefs.SetString(key:  -492599808, val:  -492587760);
        spentGemsLastQuiz = false;
    }
    public void CheckShouldShowLowGems()
    {
        if(this.currentGame == 0)
        {
                return;
        }
        
        if(this.currentGame.removeTwoHintUsed == false)
        {
                this.currentGame.removeTwoHintUsed = this.currentGame.rerollQuestionUsed;
            goto label_1;
        }
        
        label_3:
        this.currentGame.spentGemsLastQuiz = true;
        return;
        label_1:
        if((this.currentGame.extraLivesUsedThisQuiz > 0) || ((this.<rerolled>k__BackingField) == true))
        {
            goto label_3;
        }
        
        this.<rerolled>k__BackingField.spentGemsLastQuiz = false;
    }
    private bool CheckCanReroll()
    {
        return true;
    }
    private bool CheckDataIsOld(System.Collections.Generic.List<string> currentlySelectedCategories)
    {
        ZooTile val_3;
        UnityEngine.Material val_6;
        var val_20;
        var val_21;
        var val_23;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        List.Enumerator<T> val_1 = GetEnumerator();
        val_21 = 0;
        label_36:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        val_23 = null;
        val_23 = null;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_21:
        if(MoveNext() == false)
        {
            goto label_6;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_8 = getAvailableSubCategories;
        if((public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance()) == 0)
        {
            goto label_15;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_10 = getAvailableSubCategories;
        if((ContainsKey(key:  val_6)) == false)
        {
            goto label_15;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_13 = getAvailableSubCategories;
        string val_14 = Item[val_6];
        if((Contains(item:  val_3)) == false)
        {
            goto label_21;
        }
        
        val_25 = val_21 + 1;
        val_20 = 1;
        val_26 = 0;
        mem2[0] = 163;
        goto label_59;
        label_15:
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_27 = 1;
        if((-581136352) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_27 = (IsActivePromo(subCategoryName:  val_3)) ^ 1;
        }
        
        val_25 = val_21 + 1;
        if(val_27 == true)
        {
                val_27 = 1;
        }
        
        val_26 = 0;
        mem2[0] = 201;
        goto label_31;
        label_6:
        val_25 = val_21 + 1;
        val_26 = 0;
        mem2[0] = 163;
        label_31:
        val_20 = 0;
        label_59:
        Dispose();
        if(val_25 == 1)
        {
            goto label_33;
        }
        
        var val_20 = -492239544 + ((val_21 + 1)) << 2;
        if(val_20 == 201)
        {
            goto label_34;
        }
        
        val_20 = val_20 - 163;
        if(val_25 > 1)
        {
                0 = 1;
        }
        
        val_20 = val_20 >> 5;
        val_20 = 1 & val_20;
        val_21 = val_25 - val_20;
        goto label_35;
        label_33:
        val_21 = 0;
        label_35:
        if(val_20 != 0)
        {
            goto label_36;
        }
        
        goto label_37;
        label_2:
        val_28 = 1;
        val_29 = 199;
        goto label_60;
        label_37:
        val_28 = 1;
        val_29 = 201;
        label_60:
        val_25 = val_21 + 1;
        mem2[0] = val_29;
        goto label_61;
        label_34:
        val_28 = 1;
        label_61:
        Dispose();
        if(val_25 != 1)
        {
                var val_21 = -492239544 + ((val_21 + 1)) << 2;
            val_21 = val_21 - 201;
            val_21 = val_21 >> 5;
            val_30 = val_28 & val_21;
            return (bool)val_30;
        }
        
        val_30 = 0;
        return (bool)val_30;
    }
    public bool RetrieveLevelDataFromFeature()
    {
        if(this.GetNewQuizFromFeature == 0)
        {
                return false;
        }
        
        TRVQuizProgress val_1 = this.GetNewQuizFromFeature.Invoke();
        if(this.GetNewQuizFromFeature == 0)
        {
                1 = 0;
        }
        
        return (bool)1;
    }
    public void OnCategorySelected(TRVCategorySelectionInfo selectedSubCat, string selectedPrimaryCat = "")
    {
        TRVQuizProgress val_25;
        var val_26;
        TRVQuizProgress val_27;
        string val_28;
        this.currentGame = 0;
        if(this.eventEntryType == false)
        {
            goto label_6;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2101040096) == 0)
        {
            goto label_6;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        TRVSubCategoryData val_6 = LoadSubCategoryData(subcategory:  selectedSubCat.categoryName, primaryCategory:  selectedPrimaryCat);
        val_25 = public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance();
        TRVQuizProgress val_7 = GetEventQuiz(data:  -1484293744);
        goto label_14;
        label_6:
        var val_25 = 24804974;
        val_25 = 10824764 + val_25;
        if(val_25 == 0)
        {
                mem2[0] = 1;
        }
        
        val_26 = null;
        val_26 = null;
        if(TRVMainController.noAnswerSelectedCharacter != 3)
        {
                twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((IsActivePromo(subCategoryName:  selectedSubCat.categoryName)) == false)
        {
            goto label_68;
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_25 = public static TRVPromoCategoriesHandler MonoSingleton<TRVPromoCategoriesHandler>::get_Instance();
        TRVQuizProgress val_11 = LoadQuiz(subCategory:  selectedSubCat.categoryName, primaryCategory:  selectedPrimaryCat);
        label_14:
        val_27 = val_25;
        this.currentGame = val_25;
        label_68:
        if(val_27 != 0)
        {
            goto label_30;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        TRVSubCategoryData val_13 = LoadSubCategoryData(subcategory:  selectedSubCat.categoryName, primaryCategory:  selectedPrimaryCat);
        TRVQuizProgress val_14 = null;
        val_27 = val_14;
        val_14 = new TRVQuizProgress(quizCategoryData:  -1484293744);
        this.currentGame = val_27;
        if(val_27 == 0)
        {
            goto label_34;
        }
        
        label_30:
        typeof(TRVQuizProgress).__il2cppRuntimeField_8 = selectedSubCat.categoryName;
        if(selectedSubCat.categoryName > null)
        {
                if(selectedSubCat.categoryName == null)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            string val_15 = 2621443.EventType;
            val_28 = 2621443;
        }
        else
        {
                val_28 = "";
        }
        
        this.currentGame.associatedEventID = val_28;
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_17 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        mem2[0] = null;
        public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.SaveProgress();
        twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(IsPlaying() != true)
        {
                twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnGameSceneBegan();
        }
        
        if((CPlayerPrefs.GetBool(key:  -493322432, defaultValue:  false)) != false)
        {
                this.<rerolled>k__BackingField = true;
            CPlayerPrefs.SetBool(key:  -493322432, value:  false);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(IsPlaying() != false)
        {
                this.CheckQOTDQuestionSet();
            this.StartNextQuestion();
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_24 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnEventCategorySelected(category:  selectedSubCat);
            this.SetupAndAnimateNewQuiz();
        }
        
        this.TrackLevelStart();
        if(this.OnQuizBegin == 0)
        {
                return;
        }
        
        this.OnQuizBegin.Invoke();
        return;
        label_34:
    }
    public void SetupAndAnimateNewQuiz()
    {
        this.currentGame.currentGameplayState = new TRVGameplayState();
        bool val_2 = this.SetupQuestionFromLevelData(progress:  this.currentGame);
        GameBehavior val_3 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public void StartNextQuestion()
    {
        TRVQuizProgress val_8;
        var val_9;
        var val_10;
        this.currentGame.currentGameplayState = new TRVGameplayState();
        bool val_2 = this.SetupQuestionFromLevelData(progress:  this.currentGame);
        val_8 = 10827916 + 24801822;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = null;
        val_9 = null;
        val_10 = 0;
        if(TRVMainController.noAnswerSelectedCharacter == null)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_8 = this.currentGame;
            WGWindow val_4 = OnTRVQuestionStart(progress:  val_8);
            val_10 = public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance();
        }
        
        if((-2101040096) != 0)
        {
                System.Action val_6 = new System.Action(object:  -491635040, method:  new IntPtr(3803303136));
            public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance().__il2cppRuntimeField_14 = null;
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        StartGameplay(incData:  this.currentGame);
    }
    public void StartNextQOTDQuestion()
    {
        this.CheckQOTDQuestionSet();
        this.StartNextQuestion();
    }
    public void StartQuiz()
    {
        var val_3;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        this.currentGame.currentGameplayState.quizStartTime = new System.DateTime();
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UpdateGameState(incData:  this.currentGame);
        if(this.OnQuestionBegin != 0)
        {
                this.OnQuestionBegin.Invoke(obj:  this.currentGame);
        }
        
        val_3 = null;
        val_3 = null;
        if(TRVMainController.QAHACK_CORRECT == false)
        {
                return;
        }
        
        this.OnAnswerClicked(selectedAnswer:  this.currentGame.currentQuestionData.<answer>k__BackingField);
    }
    private bool SetupQuestionFromLevelData(TRVQuizProgress progress)
    {
        TRVQuizProgress val_9;
        var val_10;
        QuestionData val_11;
        TRVQuizProgress val_12;
        int val_13;
        QuestionData val_14;
        string val_15;
        QuestionData val_16;
        var val_17;
        TRVGameplayState val_18;
        TRVGameplayState val_19;
        if(true < 1)
        {
            goto label_3;
        }
        
        val_9 = this.currentGame;
        if(this.currentGame != 0)
        {
            goto label_4;
        }
        
        val_9 = this.currentGame;
        if(val_9 == 0)
        {
            goto label_5;
        }
        
        label_4:
        System.Collections.Generic.List<TRVQuestionHistory> val_9 = this.currentGame.previousQuestions;
        val_9 = val_9 - 1;
        if(val_9 <= val_9)
        {
                var val_10 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_10 = val_10 + (val_9 << 2);
        val_10 = (0 + ((this.currentGame.previousQuestions - 1)) << 2) + 16.extraLifeUsed;
        goto label_10;
        label_3:
        val_10 = 0;
        label_10:
        if(this.GetExternalFeatureQuestion == 0)
        {
            goto label_12;
        }
        
        QuestionData val_2 = this.GetExternalFeatureQuestion.Invoke();
        if(this.GetExternalFeatureQuestion == 0)
        {
            goto label_12;
        }
        
        val_11 = this.GetExternalFeatureQuestion;
        if(val_10 != 0)
        {
            goto label_13;
        }
        
        val_12 = this.currentGame;
        if(val_12 == 0)
        {
            goto label_14;
        }
        
        val_13 = this.currentGame.quizProgressIndex;
        goto label_15;
        label_12:
        this.currentGame.AdvanceQuiz(extraLifeQuestion:  false);
        val_14 = this.currentGame.currentQuestionData;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_15 = progress.quizCategory;
        UnityEngine.Sprite val_4 = GetQuestionImageFromID(subCategory:  val_15, questionID:  this.currentGame.currentQuestionData.<questionID>k__BackingField);
        this.currentGame.currentQuestionData.imageSp = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance();
        val_16 = this.currentGame.currentQuestionData;
        progress.currentQuestionData = val_16;
        if(progress.currentGameplayState == 0)
        {
                val_16 = progress.currentQuestionData;
        }
        
        progress.currentGameplayState.activeButtons.AddRange(collection:  progress.currentQuestionData.<incorrectAnswers>k__BackingField);
        val_11 = progress.currentQuestionData;
        progress.currentGameplayState.activeButtons.Add(item:  progress.currentQuestionData.<answer>k__BackingField);
        val_17 = 1152921504892043264;
        val_18 = progress.currentGameplayState;
        goto label_32;
        label_14:
        val_12 = 32;
        val_13 = 35615780;
        label_15:
        mem[32] = 35615781;
        label_13:
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Sprite val_6 = GetQuestionImageFromID(subCategory:  mem[32], questionID:  35615780);
        mem2[0] = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance();
        TRVGameplayState val_7 = null;
        val_19 = val_7;
        val_7 = new TRVGameplayState();
        if(progress != 0)
        {
                val_14 = progress;
            progress.currentGameplayState = val_19;
            mem2[0] = val_11;
        }
        else
        {
                val_14 = 16;
            mem[16] = val_19;
            mem[20] = val_11;
            val_19 = mem[16];
        }
        
        AddRange(collection:  -1484293744);
        Add(item:  361127936);
        val_17 = 1152921504892043264;
        val_18 = mem[16];
        label_32:
        WordForest.WFOGameEcon val_8 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        typeof(TRVGameplayState).__il2cppRuntimeField_C = mem[1152921512476916168];
        return true;
        label_5:
    }
    private void CheckQOTDQuestionSet()
    {
        var val_12;
        System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Collections.Generic.List<QuestionData>>, System.Int32> val_14;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        TRVCategorySelectionInfo val_2 = GetRandomSubCategory();
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        TRVSubCategoryProgress val_4 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.GetSubCatProgress(subCategory:  public static TRVQuestionOfTheDayManager MonoSingleton<TRVQuestionOfTheDayManager>::get_Instance().__il2cppRuntimeField_8);
        val_12 = null;
        val_12 = null;
        val_14 = TRVMainController.<>c.<>9__64_0;
        if(val_14 == 0)
        {
                val_14 = null;
            val_14 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>, System.Int32>(object:  TRVMainController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3804073696));
            TRVMainController.<>c.<>9__64_0 = val_14;
        }
        
        if((public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.totalQuestionsSeen) != (System.Linq.Enumerable.Sum<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>>(source:  this.currentGame.<myData>k__BackingField.questionData, selector:  7720960)))
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        TRVSubCategoryProgress val_9 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.GetSubCatProgress(subCategory:  public static TRVQuestionOfTheDayManager MonoSingleton<TRVQuestionOfTheDayManager>::get_Instance().__il2cppRuntimeField_8);
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_10 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        mem2[0] = null;
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.SaveProgress();
    }
    public void OnAnswerClicked(string selectedAnswer)
    {
        ulong val_10;
        var val_13;
        string val_41;
        var val_42;
        System.DateTime val_43;
        var val_44;
        var val_46;
        var val_47;
        TRVQuizProgress val_48;
        var val_50;
        TRVQuizProgress val_51;
        var val_52;
        var val_53;
        TRVQuizProgress val_54;
        var val_55;
        TRVQuizProgress val_56;
        var val_57;
        var val_58;
        var val_60;
        var val_62;
        TRVQuizProgress val_63;
        val_41 = selectedAnswer;
        val_42 = 1152921504616751104;
        val_43 = this.currentGame.currentGameplayState.quizStartTime;
        if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = val_43}, d2:  new System.DateTime() {dateData = System.DateTime.MinValue})) == true)
        {
                return;
        }
        
        if(this.currentGame.currentGameplayState.hasSelectedAnswer == true)
        {
                return;
        }
        
        this.currentGame.currentGameplayState.activeButtons.Clear();
        this.currentGame.currentGameplayState.selectedAnswer = val_41;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((ShowingWindow<WordHuntPopup>()) == true)
        {
            goto label_17;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((ShowingWindow<WordHuntPopup>()) == false)
        {
            goto label_21;
        }
        
        label_17:
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CloseCurrentWindow();
        label_21:
        bool val_8 = System.String.op_Equality(a:  val_41, b:  this.currentGame.currentQuestionData.<answer>k__BackingField);
        if(val_8 == false)
        {
            goto label_27;
        }
        
        System.DateTime val_9 = DateTimeCheat.UtcNow;
        System.TimeSpan val_12 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512706178656}, d2:  new System.DateTime() {dateData = val_10});
        double val_15 = val_13.TotalSeconds;
        uint val_40 = 0;
        val_40 = this.currentGame.currentGameplayState.quizDuration - val_40;
        this.currentGame.currentGameplayState.pointsEarned = UnityEngine.Mathf.CeilToInt(f:  UnityEngine.Mathf.Min(a:  UnityEngine.Mathf.Max(a:  null, b:  null), b:  null));
        if((TRVCategoryRankController.CanRankUpCategory(subCategory:  this.currentGame.quizCategory)) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            TRVSubCategoryProgress val_21 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.GetSubCatProgress(subCategory:  this.currentGame.quizCategory);
            typeof(TRVCategoryRankProgress).__il2cppRuntimeField_8 = this.currentGame.quizCategory;
            typeof(TRVCategoryRankProgress).__il2cppRuntimeField_C = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28 + 24;
            float val_23 = TRVCategoryRankController.GetCategoryProcess(subcategoryProgress:  public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28);
            typeof(TRVCategoryRankProgress).__il2cppRuntimeField_10 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28;
            TRVCategoryRankController.ProcessCategoryRank(categoryName:  this.currentGame.quizCategory, subcategoryProgress:  public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28);
            float val_24 = TRVCategoryRankController.GetCategoryProcess(subcategoryProgress:  public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28);
            typeof(TRVCategoryRankProgress).__il2cppRuntimeField_14 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28;
            this.currentGame.categoryRankProgress = new TRVCategoryRankProgress();
        }
        
        twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_44 = 0;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -490694560, clipIndex:  0);
        twelvegigs.Autopilot.AutopilotManager val_26 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_46 = mem[public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28 + 52];
        val_46 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28 + 52;
        goto label_62;
        label_27:
        if((System.String.op_Inequality(a:  val_41, b:  1372269104)) == false)
        {
            goto label_68;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_28 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_44 = 0;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -490694448, clipIndex:  0);
        goto label_68;
        label_62:
        mem[52] = 7;
        label_68:
        var val_41 = 24803784;
        val_41 = 10831408 + val_41;
        if(val_41 == 0)
        {
                mem2[0] = 1;
        }
        
        if(WGTimelineTracker._instance != 0)
        {
                System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_30 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            val_42 = 1152921510535002416;
            Add(key:  1624646480, value:  this.currentGame.currentQuestionData.<questionID>k__BackingField);
            Add(key:  -490682048, value:  this.currentGame.quizCategory);
            val_10 = this.currentGame.currentQuestionData.<difficulty>k__BackingField;
            Add(key:  -490677856, value:  13152256);
            Add(key:  -490669568, value:  this.currentGame.currentQuestionData.<question>k__BackingField);
            if(null != 0)
        {
                Add(key:  -490661280, value:  this.currentGame.currentQuestionData.<answer>k__BackingField);
        }
        else
        {
                Add(key:  -490661280, value:  this.currentGame.currentQuestionData.<answer>k__BackingField);
        }
        
            Add(key:  -490661200, value:  val_41);
            if(val_41 == 0)
        {
                mem2[0] = 1;
        }
        
            if(WGTimelineTracker._instance != 0)
        {
                val_47 = null;
        }
        
            val_47 = null;
            if(((WGTimelineTracker.__il2cppRuntimeField_typeHierarchy + (TRVTimelineTracker.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_47)
        {
                WGTimelineTracker._instance = 0;
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_31 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_48 = this.currentGame;
        val_41 = val_8;
        UpdateGameState(incData:  val_48);
        if((public static TRVGameplayUI MonoSingleton<TRVGameplayUI>::get_Instance()) < 1)
        {
            goto label_97;
        }
        
        val_50 = this.currentGame;
        if(this.currentGame != 0)
        {
            goto label_98;
        }
        
        val_51 = this.currentGame;
        if(val_51 == 0)
        {
            goto label_137;
        }
        
        label_98:
        System.Collections.Generic.List<TRVQuestionHistory> val_42 = this.currentGame.previousQuestions;
        val_42 = val_42 - 1;
        if(val_51 <= val_42)
        {
                var val_43 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_43 = val_43 + (val_42 << 2);
        val_52 = 0;
        if(((0 + ((this.currentGame.previousQuestions - 1)) << 2) + 16.extraLifeUsed) == false)
        {
            goto label_104;
        }
        
        val_53 = this.currentGame;
        if(this.currentGame != 0)
        {
            goto label_105;
        }
        
        val_54 = this.currentGame;
        if(val_54 == 0)
        {
            goto label_137;
        }
        
        label_105:
        System.Collections.Generic.List<TRVQuestionHistory> val_44 = this.currentGame.previousQuestions;
        val_44 = val_44 - 1;
        if(val_54 <= val_44)
        {
                var val_45 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_45 = val_45 + (val_44 << 2);
        val_55 = ((0 + ((this.currentGame.previousQuestions - 1)) << 2) + 16.answeredCorrectly) ^ 1;
        label_104:
        if(val_55 == true)
        {
                val_48 = 1;
        }
        
        goto label_111;
        label_97:
        val_48 = 0;
        label_111:
        val_56 = this.currentGame;
        if(this.currentGame != 0)
        {
            goto label_112;
        }
        
        val_56 = this.currentGame;
        if(val_56 == 0)
        {
            goto label_137;
        }
        
        label_112:
        TRVQuestionHistory val_34 = null;
        val_44 = 0;
        val_42 = val_34;
        val_34 = new TRVQuestionHistory(prevState:  this.currentGame.currentGameplayState, qd:  this.currentGame.currentQuestionData);
        if(val_42 != 0)
        {
                val_57 = val_42;
        }
        else
        {
                val_57 = val_42;
        }
        
        TRVQuestionHistory.__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_FFFFFFFFFFFFFFFF = (TRVQuestionHistory.__il2cppRuntimeField_byval_arg + val_48);
        if(val_48 != 0)
        {
                val_58 = null;
            val_10 = val_41;
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            UnityEngine.Debug.LogErrorFormat(format:  -490632432, args:  472754880);
            if(val_41 != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_36 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_60 = mem[public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28 + 52];
            val_60 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28 + 52;
            mem[52] = 6;
        }
        
            twelvegigs.Autopilot.AutopilotManager val_37 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_48 = mem[public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28 + 48];
            val_48 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28 + 48;
            mem[48] = 1835036;
        }
        
        this.currentGame.previousQuestions.Add(item:  361181184);
        TRVQuizProgress val_46 = this.currentGame;
        val_62 = val_46;
        if(val_46 != 0)
        {
            goto label_136;
        }
        
        val_63 = this.currentGame;
        if(val_63 == 0)
        {
            goto label_137;
        }
        
        label_136:
        val_43 = this.currentGame.previousQuestions;
        val_46 = val_46 - 1;
        if(val_63 <= val_46)
        {
                var val_47 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_47 = val_47 + (val_46 << 2);
        mem2[0] = 0;
        System.Collections.IEnumerator val_38 = this.displayAnswerResult(correct:  val_41);
        UnityEngine.Coroutine val_39 = this.StartCoroutine(routine:  -490590848);
        if(this.OnQuestionAnswered == 0)
        {
                return;
        }
        
        this.OnQuestionAnswered.Invoke(obj:  val_41);
        return;
        label_137:
    }
    private System.Collections.IEnumerator displayAnswerResult(bool correct)
    {
        typeof(TRVMainController.<displayAnswerResult>d__66).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(TRVMainController.<displayAnswerResult>d__66).__il2cppRuntimeField_14 = this;
        }
        else
        {
                mem[20] = this;
        }
        
        typeof(TRVMainController.<displayAnswerResult>d__66).__il2cppRuntimeField_10 = correct;
    }
    public bool PurchaseExtraLife(bool updateGems = True, bool addExtraLife = False)
    {
        var val_9;
        var val_10;
        string val_11;
        TRVQuizProgress val_12;
        val_9 = 1152921504892043264;
        Player val_1 = App.Player;
        WordForest.WFOGameEcon val_2 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        val_10 = 0;
        if(0 < mem[1152921512476916172])
        {
                return (bool)val_10;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.currentGame.associatedEventID)) != false)
        {
                val_11 = "Extra Life";
        }
        else
        {
                val_11 = this.currentGame.associatedEventID;
        }
        
        Player val_4 = App.Player;
        WordForest.WFOGameEcon val_5 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        val_9 = public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>();
        0.AddGems(amount:  0 - mem[1152921512476916172], source:  mem[this.currentGame.associatedEventID], subsource:  null);
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.AddFreeLife(addExtraLife:  addExtraLife);
        val_12 = this.currentGame;
        if(this.currentGame != 0)
        {
            goto label_18;
        }
        
        val_12 = this.currentGame;
        if(val_12 == 0)
        {
            goto label_19;
        }
        
        label_18:
        System.Collections.Generic.List<TRVQuestionHistory> val_9 = this.currentGame.previousQuestions;
        val_9 = val_9 - 1;
        if(val_12 <= val_9)
        {
                var val_10 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_10 = val_10 + (val_9 << 2);
        val_10 = 1;
        mem2[0] = val_10;
        if(updateGems == false)
        {
                return (bool)val_10;
        }
        
        NotificationCenter val_8 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -490190720, aName:  -1618809792);
        return (bool)val_10;
        label_19:
    }
    public void OnExtraLifeClicked()
    {
        TRVQuizProgress val_5;
        var val_6;
        var val_7;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.UseFreeLife(usedAtTime:  new System.DateTime());
        TRVQuizProgress val_5 = this.currentGame;
        val_5 = val_5;
        if(val_5 != 0)
        {
            goto label_7;
        }
        
        val_5 = this.currentGame;
        if(val_5 == 0)
        {
            goto label_8;
        }
        
        label_7:
        val_5 = val_5 - 1;
        if(val_5 <= val_5)
        {
                var val_6 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_6 = val_6 + (val_5 << 2);
        val_6 = mem[(0 + ((this.currentGame - 1)) << 2) + 16];
        val_6 = (0 + ((this.currentGame - 1)) << 2) + 16;
        if(val_6 != 0)
        {
                val_7 = mem[(0 + ((this.currentGame - 1)) << 2) + 16 + 16];
            val_7 = (0 + ((this.currentGame - 1)) << 2) + 16 + 16;
        }
        else
        {
                val_6 = 16;
            val_7 = 2621443;
        }
        
        mem[16] = 2621444;
        return;
        label_8:
    }
    public void RerollCategory(System.Action onRerollSuccess, System.Action onRerollFailed)
    {
        var val_12;
        System.Action val_13;
        var val_14;
        val_12 = onRerollSuccess;
        GameBehavior val_1 = App.getBehavior;
        val_13 = 0;
        if(val_13 <= 9)
        {
            goto label_5;
        }
        
        Player val_2 = App.Player;
        WordForest.WFOGameEcon val_3 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if(0 >= mem[1152921512476916180])
        {
            goto label_10;
        }
        
        var val_12 = 24788729;
        val_12 = 10837332 + val_12;
        if(val_12 == 0)
        {
                mem2[0] = 1;
        }
        
        val_14 = null;
        val_14 = null;
        PurchaseProxy.currentPurchasePoint = 92;
        string val_4 = Localization.Localize(key:  -1687442544, defaultValue:  -1687442624, useSingularKey:  false);
        GameStoreManager.StoreCategoryFocus = "gems_upper";
        GameBehavior val_5 = App.getBehavior;
        val_12 = 0;
        val_13 = null;
        val_13 = new System.Action(object:  -489895952, method:  new IntPtr(3805046208));
        val_12.Init(outOfCredits:  true, onCloseAction:  7454720);
        if(onRerollFailed == 0)
        {
                return;
        }
        
        goto label_22;
        label_10:
        Player val_8 = App.Player;
        WordForest.WFOGameEcon val_9 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        val_13 = public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>();
        0.AddGems(amount:  0 - mem[1152921512476916180], source:  -489920064, subsource:  null);
        NotificationCenter val_11 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -489895952, aName:  -1618809792);
        label_5:
        if(val_12 == 0)
        {
                return;
        }
        
        label_22:
        val_12.Invoke();
    }
    public void RerollQuestion(int cost, float remainingTime)
    {
        System.DateTime val_13;
        var val_15;
        string val_16;
        val_15 = R2;
        if(cost >= 1)
        {
                if((System.String.IsNullOrEmpty(value:  this.currentGame.associatedEventID)) != false)
        {
                val_16 = "Reroll Question";
        }
        else
        {
                val_16 = this.currentGame.associatedEventID;
        }
        
            Player val_2 = App.Player;
            0.AddGems(amount:  0 - cost, source:  mem[this.currentGame.associatedEventID], subsource:  null);
            NotificationCenter val_4 = NotificationCenter.DefaultCenter;
            val_15 = val_15;
            0.PostNotification(aSender:  -489714208, aName:  -1618809792);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HideTimer();
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        StopTimer();
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        FadeOutPowerups();
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HideQuestionButtons();
        this.currentGame.currentGameplayState = new TRVGameplayState();
        bool val_10 = this.SetupQuestionFromLevelData(progress:  this.currentGame);
        this.currentGame.rerollQuestionUsed = true;
        this.currentGame.currentGameplayState.rerollQuestionPowerupUsed = true;
        if(cost <= 0)
        {
                this.currentGame.currentGameplayState.freererollQuestionPowerupUsed = true;
        }
        
        System.DateTime val_11 = DateTimeCheat.UtcNow;
        this.currentGame.currentGameplayState.quizStartTime = val_13;
        float val_15 = 1f;
        val_15 = val_15 + val_15;
        this.currentGame.currentGameplayState.quizDuration = val_15;
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        StartGameplay(incData:  this.currentGame);
        this.TrackLevelStart();
    }
    public void ProcessQuizComplete(bool success)
    {
        var val_22;
        var val_23;
        var val_24;
        TRVQuizProgress val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        this.CheckShouldShowLowGems();
        bool val_1 = this.IsPlayingChallenge;
        if(success == false)
        {
            goto label_1;
        }
        
        if(val_1 == true)
        {
            goto label_56;
        }
        
        if(this.currentGame != 0)
        {
                Player val_2 = App.Player;
            var val_3 = 0 + 1;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        TRVSubCategoryProgress val_5 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.GetSubCatProgress(subCategory:  this.currentGame.quizCategory);
        val_22 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28;
        val_23 = val_22;
        val_24 = mem[public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28 + 16];
        val_24 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28 + 16;
        goto label_15;
        label_1:
        if(val_1 == true)
        {
            goto label_56;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_25 = this.currentGame;
        TRVSubCategoryProgress val_7 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.GetSubCatProgress(subCategory:  this.currentGame.quizCategory);
        val_26 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28;
        val_27 = mem[public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28 + 16];
        val_27 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28 + 16;
        goto label_23;
        label_15:
        mem[16] = 2621444;
        if(this.currentGame.incorrecctAnswers != 0)
        {
            goto label_25;
        }
        
        if(val_22 == 0)
        {
            goto label_26;
        }
        
        val_28 = mem[public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28 + 20];
        val_28 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28 + 20;
        goto label_27;
        label_23:
        mem[16] = 2621445;
        this.RewardMultiPicked(multi:  1);
        goto label_56;
        label_26:
        val_22 = 20;
        val_28 = 1;
        label_27:
        mem[20] = 2;
        label_25:
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Init(forceUpdate:  true);
        GameBehavior val_10 = App.getBehavior;
        if(0 < 10)
        {
            goto label_36;
        }
        
        GameBehavior val_11 = App.getBehavior;
        if((-4294967290) != 0)
        {
            goto label_41;
        }
        
        label_36:
        var val_23 = 24785462;
        val_23 = 10840076 + val_23;
        if(val_23 == 0)
        {
                mem2[0] = 1;
        }
        
        val_29 = null;
        val_29 = null;
        val_30 = null;
        val_30 = null;
        GameBehavior val_12 = App.getBehavior;
        string val_13 = 0.ToString();
        string val_14 = Events.LEVEL_REACHED + 2144339952 + -489502516(-489502516);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_15 = this.TrackLevelEnd(levelToTrack:  this.currentGame, abortedQuiz:  false);
        App.trackerManager.track(eventName:  Events.LEVEL_REACHED, data:  -489490480);
        label_41:
        val_25 = 1152921511630125472;
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1566656096) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnLevelComplete();
        }
        
        label_56:
        if(this.OnQuizComplete != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(IsPlaying() != true)
        {
                this.OnQuizComplete.Invoke(arg1:  success, arg2:  this.currentGame);
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.SaveProgress();
        this.currentGame.quizCompleted = true;
        var val_24 = 24784654;
        val_24 = 10840884 + val_24;
        if(val_24 == 0)
        {
                mem2[0] = 1;
        }
        
        val_31 = null;
        val_31 = null;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_22 = this.TrackLevelEnd(levelToTrack:  this.currentGame, abortedQuiz:  false);
        App.trackerManager.track(eventName:  -489514592, data:  -489490480);
    }
    public void RemoveTwo(int cost, float remainingTime)
    {
        System.DateTime val_22;
        string val_25;
        var val_26;
        var val_27;
        var val_28;
        TRVGameplayState val_29;
        int val_30;
        TRVGameplayState val_31;
        int val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        if(cost >= 1)
        {
                val_25 = "50/50 Powerup";
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(IsPlaying() != false)
        {
                val_25 = "Question of the Day";
        }
        else
        {
                if((System.String.IsNullOrEmpty(value:  this.currentGame.associatedEventID)) != true)
        {
                val_25 = this.currentGame.associatedEventID;
        }
        
        }
        
            Player val_4 = App.Player;
            0.AddGems(amount:  0 - cost, source:  val_25, subsource:  null);
            NotificationCenter val_6 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  -489222736, aName:  -1618809792);
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_7 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        AddRange(collection:  this.currentGame.currentGameplayState.activeButtons);
        if(null != 0)
        {
                bool val_8 = Remove(item:  this.currentGame.currentQuestionData.<answer>k__BackingField);
            val_26 = null;
            val_27 = UnityEngine.Random.Range(min:  0, max:  1094062064);
        }
        else
        {
                bool val_10 = Remove(item:  this.currentGame.currentQuestionData.<answer>k__BackingField);
            val_26 = 12;
            val_27 = UnityEngine.Random.Range(min:  0, max:  0);
        }
        
        if(val_26 <= val_27)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        bool val_12 = Remove(item:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_11) << 2) + 16);
        bool val_13 = this.currentGame.currentGameplayState.activeButtons.Remove(item:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_11) << 2) + 16);
        if(null != 0)
        {
                val_28 = UnityEngine.Random.Range(min:  0, max:  0);
        }
        else
        {
                val_28 = UnityEngine.Random.Range(min:  0, max:  0);
        }
        
        if(0 <= val_28)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        bool val_16 = Remove(item:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_15) << 2) + 16);
        bool val_17 = this.currentGame.currentGameplayState.activeButtons.Remove(item:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_15) << 2) + 16);
        val_29 = this.currentGame.currentGameplayState;
        if(val_29 != 0)
        {
                val_30 = this.currentGame.currentGameplayState.hintsUsed;
        }
        else
        {
                val_29 = 32;
            val_30 = 35615780;
        }
        
        mem[32] = val_30 + 1;
        if(cost <= 0)
        {
                val_31 = this.currentGame.currentGameplayState;
            if(val_31 != 0)
        {
                val_32 = this.currentGame.currentGameplayState.freehintsUsed;
        }
        else
        {
                val_31 = 36;
            val_32 = 83886592;
        }
        
            mem[36] = 83886593;
        }
        
        this.currentGame.removeTwoHintUsed = true;
        Player val_19 = App.Player;
        val_33 = 2621448;
        if(val_33 != 0)
        {
                val_34 = 23;
        }
        else
        {
                val_33 = 56;
            val_34 = 52;
        }
        
        mem[56] = 53;
        System.DateTime val_20 = DateTimeCheat.UtcNow;
        this.currentGame.currentGameplayState.quizStartTime = val_22;
        float val_26 = 1f;
        val_26 = (???) + val_26;
        this.currentGame.currentGameplayState.quizDuration = val_26;
        twelvegigs.Autopilot.AutopilotManager val_23 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UpdateGameState(incData:  this.currentGame);
        val_35 = null;
        val_35 = null;
        val_36 = null;
        val_36 = null;
        App.trackerManager.track(eventName:  Events.HINT_USED);
        val_37 = null;
        val_37 = null;
        Player val_24 = App.Player;
        string val_25 = System.String.Format(format:  -1645101696, arg0:  Events.HINT_USED, arg1:  13152256);
        App.trackerManager.track(eventName:  -1645101696);
    }
    public void ConcludeQuestionComplete()
    {
        TRVQuizProgress val_18;
        int val_19;
        TRVQuizProgress val_20;
        var val_21;
        TRVQuizProgress val_22;
        if(true == 0)
        {
            goto label_3;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<TRVQuestionHistory> val_2 = this.currentGame.countedAnswerData;
        val_18 = this.currentGame;
        if(val_18 == 0)
        {
            goto label_10;
        }
        
        val_19 = this.currentGame.correctAnswerRequirement;
        goto label_19;
        label_3:
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        StartGameplay(incData:  this.currentGame);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.Play(type:  1, trackIndex:  0);
        return;
        label_10:
        val_19 = this.currentGame.correctAnswerRequirement;
        val_18 = this.currentGame;
        if(val_18 == 0)
        {
                val_18 = 0;
        }
        
        label_19:
        if(this.currentGame.quizCompleted == false)
        {
            goto label_21;
        }
        
        val_20 = this.currentGame;
        val_21 = this.currentGame.countedAnswers;
        if(val_21 >= this.currentGame.correctAnswerRequirement)
        {
            goto label_24;
        }
        
        label_21:
        val_20 = val_19 - val_18.countedAnswers;
        if(this.currentGame.quizCompleted == true)
        {
            goto label_27;
        }
        
        val_22 = this.currentGame;
        if(this.currentGame != 0)
        {
            goto label_28;
        }
        
        val_22 = this.currentGame;
        if(val_22 == 0)
        {
            goto label_29;
        }
        
        label_28:
        val_21 = this.currentGame.previousQuestions - 1;
        if(val_22 <= val_21)
        {
                var val_16 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_16 = val_16 + (val_21 << 2);
        if(((0 + ((this.currentGame.previousQuestions - 1)) << 2) + 16.extraLifeUsed) == false)
        {
            goto label_34;
        }
        
        label_27:
        bool val_8 = this.IsOutOfQuestions();
        if(val_8 == false)
        {
            goto label_35;
        }
        
        val_8.ShowOutOfQuestionsPopup(showFlyout:  false);
        goto label_36;
        label_24:
        if(this.ShowLevelComplete == 0)
        {
            goto label_39;
        }
        
        if(this.ShowLevelComplete.Invoke() == true)
        {
                return;
        }
        
        goto label_39;
        label_35:
        this.StartNextQuestion();
        return;
        label_34:
        if(this.ShowLevelFailed != 0)
        {
                if(this.ShowLevelFailed.Invoke() != false)
        {
                return;
        }
        
        }
        
        this.ProcessQuizComplete(success:  false);
        label_39:
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_12 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        mem2[0] = null;
        public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.SaveProgress();
        GameBehavior val_13 = App.getBehavior;
        label_36:
        twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.FadeOutMusic();
        return;
        label_29:
    }
    public void AbortChallenge()
    {
        if(this.ShowLevelFailed == 0)
        {
                return;
        }
        
        bool val_1 = this.ShowLevelFailed.Invoke();
    }
    public void AbortQuiz()
    {
        var val_3;
        this.CheckShouldShowLowGems();
        if(this.currentGame == 0)
        {
                return;
        }
        
        if(this.currentGame.quizCompleted == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_10.FadeOutMusic();
        var val_3 = 24775066;
        val_3 = 10850472 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = R4.TrackLevelEnd(levelToTrack:  R4 + 12, abortedQuiz:  true);
        App.trackerManager.track(eventName:  -489514592, data:  R4);
    }
    public bool IsOutOfQuestions()
    {
        var val_12;
        var val_13;
        var val_14;
        System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Collections.Generic.List<QuestionData>>, System.Int32> val_16;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        TRVSubCategoryProgress val_2 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.GetSubCatProgress(subCategory:  this.currentGame.quizCategory);
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-607046320) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_12 = public static TRVSpecialCategoriesManager MonoSingleton<TRVSpecialCategoriesManager>::get_Instance();
            val_13 = 0;
            if((IsSpecialQuiz(subCategoryName:  this.currentGame.quizCategory)) == true)
        {
                return (bool);
        }
        
        }
        
        val_12 = 1152921504967655424;
        val_14 = null;
        val_14 = null;
        val_16 = TRVMainController.<>c.<>9__76_0;
        if(val_16 == 0)
        {
                val_16 = null;
            val_16 = new System.Func<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>, System.Int32>(object:  TRVMainController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3806455280));
            TRVMainController.<>c.<>9__76_0 = val_16;
        }
        
        val_13 = 0;
        if((System.Linq.Enumerable.Sum<System.Collections.Generic.KeyValuePair<System.Int32, System.Object>>(source:  this.currentGame.<myData>k__BackingField.questionData, selector:  7720960)) != (public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.totalQuestionsSeen))
        {
                return (bool);
        }
        
        mem2[0] = 1;
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.SaveProgress();
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_13 = 1;
        public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_1C = val_13;
        return (bool);
    }
    public void ShowOutOfQuestionsPopup(bool showFlyout = False)
    {
        var val_7;
        var val_8;
        val_7 = null;
        if(showFlyout != false)
        {
                GameBehavior val_1 = App.getBehavior;
            val_8 = (1179403647 + (public TRVOutOfQuestionsPopup MetaGameBehavior::ShowUGUIFlyOut<TRVOutOfQuestionsPopup>().__il2cppRuntimeField_28) << 3) + 192;
            val_7 = 0;
        }
        else
        {
                GameBehavior val_3 = App.getBehavior;
            if(0 != 0)
        {
            goto (1179403647 + (public TRVOutOfQuestionsPopup MetaGameBehavior::ShowUGUIMonolith<TRVOutOfQuestionsPopup>(bool showNext).__il2cppRuntimeField_28) << 3) + 192;
        }
        
        }
    
    }
    public void RewardMultiPicked(int multi)
    {
        int val_25;
        int val_33;
        int val_34;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_35;
        string val_36;
        var val_37;
        var val_38;
        int val_39;
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        var val_3 = mem[1152921512476916292] + (TRVMainController.currentMultiplier << 2);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        int val_5 = this.currentGame.totalPointsGained;
        Add(key:  -488248080, value:  13152256);
        int val_6 = this.currentGame.correctAnswers;
        Add(key:  -488243872, value:  13152256);
        WordForest.WFOGameEcon val_7 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        var val_9 = mem[1152921512476916292] + (TRVMainController.currentMultiplier << 2);
        string val_10 = System.String.Format(format:  -588332288, arg0:  13152256);
        Add(key:  -488243760, value:  -588332288);
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_12 = GetBonusStarReward();
        Add(key:  -488243632, value:  13152256);
        Add(key:  -488239440, value:  8945664);
        val_33 = 0;
        val_34 = this.currentGame.GetQuizBaseStarReward();
        if(this.currentGame.successfullyCompletedQuiz != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_16 = GetBonusStarReward();
            val_16 = val_16 + val_34;
            val_34 = val_16 * multi;
            val_33 = this.currentGame.GetQuizBaseReward() * multi;
        }
        
        val_35 = val_33;
        var val_32 = 24847986;
        val_32 = 10781752 + val_32;
        val_36 = 1152921504619999232;
        if(val_32 == 0)
        {
                mem2[0] = 1;
        }
        
        val_37 = null;
        val_37 = null;
        if(TRVMainController.noAnswerSelectedCharacter == null)
        {
            goto label_34;
        }
        
        if(val_32 == 0)
        {
                mem2[0] = 1;
        }
        
        val_38 = null;
        val_38 = null;
        if(TRVMainController.noAnswerSelectedCharacter != 3)
        {
            goto label_40;
        }
        
        label_34:
        val_39 = val_34 * ((mem[1152921512476916292] + (val_2) << 2) + 16);
        Add(key:  -488227040, value:  13152256);
        goto label_42;
        label_40:
        val_39 = val_34;
        label_42:
        if(this.currentGame.hasCollectedChest != true)
        {
                twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            AwardStar(earnedAmount:  val_39, source:  -488222832, subSource:  null, additionalParam:  null);
            if(val_35 >= 1)
        {
                val_35 = null;
            val_35 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  -488239440, value:  8945664);
            WordForest.WFOGameEcon val_21 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
            int val_22 = dynamicQuizEntryCost;
            Add(key:  -488218624, value:  13152256);
            Player val_23 = App.Player;
            val_36 = 0;
            decimal val_24 = System.Decimal.op_Implicit(value:  -488190084);
            0.AddCredits(amount:  new System.Decimal() {flags = val_39 - val_34, mid = val_25}, source:  "TRVQuizComplete", subSource:  val_36, externalParams:  val_35, doTrack:  true);
        }
        
        }
        
        this.currentGame.hasCollectedChest = true;
        this.currentGame.finalStarReward = val_39;
        this.currentGame.finalCoinReward = val_35;
        this.currentGame.selectedMulitplier = multi;
        System.Collections.IEnumerator val_26 = this.EventLevelComplete();
        UnityEngine.Coroutine val_27 = this.StartCoroutine(routine:  -488178016);
        twelvegigs.Autopilot.AutopilotManager val_28 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CheckAndRequestServerEvents();
        twelvegigs.Autopilot.AutopilotManager val_29 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-581136352) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_31 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        RequestPromosFromServer();
    }
    private System.Collections.IEnumerator EventLevelComplete()
    {
        object val_1 = new System.Object();
        typeof(TRVMainController.<EventLevelComplete>d__79).__il2cppRuntimeField_8 = 0;
        typeof(TRVMainController.<EventLevelComplete>d__79).__il2cppRuntimeField_10 = this;
    }
    private void TrackLevelStart()
    {
        float val_13;
        string val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        val_13 = 1152921504619999232;
        Add(key:  -1987496192, value:  13152256);
        Add(key:  -487920672, value:  13152256);
        if((System.String.op_Equality(a:  this.currentGame.quizCategory, b:  -487916464)) != false)
        {
                val_14 = "Question of the Day";
        }
        else
        {
                val_14 = this.currentGame.quizCategory;
        }
        
        Add(key:  -747331040, value:  mem[this.currentGame.quizCategory]);
        val_15 = 1152921504892043264;
        Player val_3 = App.Player;
        var val_4 = 0 + 60;
        Add(key:  -1050425600, value:  10170368);
        WordForest.WFOGameEcon val_5 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        int val_6 = dynamicQuizEntryCost;
        val_16 = null;
        Add(key:  -487908160, value:  13152256);
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(IsPlaying() != true)
        {
                bool val_9 = this.currentGame.associatedEventID.Equals(value:  -1298909536);
            Add(key:  -487899856, value:  8945664);
            if((TRVCrazyCategoriesEventHandler.EVENT_TRACKING_ID != null) && ((System.String.IsNullOrEmpty(value:  TRVCrazyCategoriesEventHandler.EVENT_TRACKING_ID + 16)) != true))
        {
                if(TRVCrazyCategoriesEventHandler.EVENT_TRACKING_ID != null)
        {
                bool val_11 = TRVCrazyCategoriesEventHandler.EVENT_TRACKING_ID + 16.Equals(value:  this.currentGame.quizCategory);
        }
        else
        {
                val_17 = 0;
        }
        
            Add(key:  -487899760, value:  8945664);
            val_18 = val_15;
        }
        
            val_13 = val_18;
            val_19 = 0;
            bool val_12 = this.currentGame.associatedEventID.Equals(value:  -1298907008);
            val_16 = null;
            Add(key:  -1298906912, value:  8945664);
            if(this.currentGame != 0)
        {
                val_19 = (((TRVQuizProgress.__il2cppRuntimeField_typeHierarchy + (TRVSpecialCategoriesQuiz.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4 - null)) >> 5;
        }
        
            Add(key:  -575491712, value:  8945664);
            val_20 = val_13;
        }
        
        var val_13 = 24801494;
        val_13 = 10824044 + val_13;
        if(val_13 == 0)
        {
                mem2[0] = 1;
        }
        
        val_21 = null;
        val_21 = null;
        App.trackerManager.track(eventName:  -487879184, data:  78753792);
    }
    private System.Collections.Generic.Dictionary<string, object> TrackLevelEnd(TRVQuizProgress levelToTrack, bool abortedQuiz = False)
    {
        UnityEngine.Material val_39;
        TRVQuizProgress val_41;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        float val_50;
        val_41 = levelToTrack;
        if(val_41 == 0)
        {
            goto label_1;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1987496192, value:  13152256);
        Player val_2 = App.Player;
        Add(key:  -1050425600, value:  10170368);
        Player val_3 = App.Player;
        Add(key:  -487713824, value:  13152256);
        int val_6 = this.currentGame.correctAnswers * this.currentGame.totalPointsGained;
        Add(key:  -487709632, value:  13152256);
        int val_7 = this.currentGame.extraLivesUsedThisQuiz;
        Add(key:  -487709536, value:  13152256);
        int val_9 = this.currentGame.rerollsUsedThisQuiz;
        val_9 = val_9 + this.currentGame.hintsUsedThisQuiz;
        Add(key:  -487709424, value:  13152256);
        if((System.String.op_Equality(a:  this.currentGame.quizCategory, b:  -487916464)) != false)
        {
            
        }
        
        Add(key:  -747331040, value:  mem[this.currentGame.quizCategory]);
        bool val_11 = this.currentGame.successfullyCompletedQuiz;
        Add(key:  -1643554480, value:  8945664);
        int val_12 = this.currentGame.hintsUsedThisQuiz;
        Add(key:  -487705216, value:  13152256);
        bool val_13 = this.currentGame.freeHintWasUsedThisQuiz;
        Add(key:  -487705104, value:  8945664);
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        mem2[0] = ;
        Add(key:  -487704992, value:  357027840);
        WordForest.WFOGameEcon val_14 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        val_42 = 1152921504685600768;
        int val_15 = dynamicQuizEntryCost;
        Add(key:  -487908160, value:  13152256);
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-718511200) == 0)
        {
            goto label_43;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(IsPlaying() == true)
        {
            goto label_43;
        }
        
        int val_20 = this.currentGame.rerollsUsedThisQuiz;
        val_43 = 1152921504615792640;
        Add(key:  -487704896, value:  13152256);
        bool val_21 = this.currentGame.freeRerollWasUsedThisQuiz;
        Add(key:  -487704768, value:  8945664);
        bool val_22 = this.currentGame.associatedEventID.Equals(value:  -1298909536);
        Add(key:  -487899856, value:  8945664);
        if(TRVCrazyCategoriesEventHandler.EVENT_TRACKING_ID == null)
        {
            goto label_52;
        }
        
        if(TRVCrazyCategoriesEventHandler.EVENT_TRACKING_ID == null)
        {
            goto label_53;
        }
        
        val_44 = 0;
        if((System.String.IsNullOrEmpty(value:  TRVCrazyCategoriesEventHandler.EVENT_TRACKING_ID + 16)) == true)
        {
            goto label_59;
        }
        
        val_44 = TRVCrazyCategoriesEventHandler.EVENT_TRACKING_ID + 16.Equals(value:  this.currentGame.quizCategory);
        goto label_59;
        label_53:
        val_44 = 0;
        label_59:
        Add(key:  -487899760, value:  8945664);
        val_43 = 1152921504615792640;
        label_52:
        bool val_25 = this.currentGame.associatedEventID.Equals(value:  -1298907008);
        Add(key:  -1298906912, value:  8945664);
        val_45 = 0;
        if(this.currentGame != 0)
        {
                val_43 = 1152921504615792640;
            if(((TRVQuizProgress.__il2cppRuntimeField_typeHierarchy + (TRVSpecialCategoriesQuiz.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                this.currentGame = 0;
        }
        
            val_45 = this.currentGame;
        }
        
        if(val_45 != 0)
        {
                val_45 = 1;
        }
        
        Add(key:  -575491712, value:  8945664);
        val_42 = 1152921504685600768;
        int val_26 = this.currentGame.expertHintWasUsed;
        Add(key:  -487692352, value:  13152256);
        bool val_27 = this.currentGame.freeexpertHintWasUsed;
        Add(key:  -487692240, value:  8945664);
        label_43:
        val_42 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        val_46 = 0;
        val_47 = 4;
        goto label_71;
        label_94:
        if(val_42 <= null)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_29 = 2621443.GetTrackingData();
        if(2621443 <= null)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(2621443.answeredCorrectly == false)
        {
            goto label_78;
        }
        
        bool val_43 = abortedQuiz;
        if(val_43 == false)
        {
            goto label_81;
        }
        
        val_43 = val_43 - 1;
        if(null != val_43)
        {
            goto label_81;
        }
        
        label_78:
        if(val_43 <= null)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_48 = 1;
        val_49 = "Out Of Time";
        if(abortedQuiz == false)
        {
            goto label_88;
        }
        
        var val_44 = levelToTrack + 24 + 12;
        val_44 = val_44 - 1;
        if(null != val_44)
        {
            goto label_88;
        }
        
        val_49 = "Home Button";
        goto label_89;
        label_81:
        val_48 = val_46;
        goto label_90;
        label_88:
        val_49 = "Incorrect Answer";
        label_89:
        val_48 = val_46;
        2621443.Add(key:  1618769024, value:  -487675552);
        label_90:
        string val_31 = System.String.Format(format:  -487675440, arg0:  13152256);
        Add(key:  -487675440, value:  2621443);
        val_46 = val_48;
        val_41 = val_41;
        val_47 = 5;
        label_71:
        if((val_47 - 4) < (levelToTrack + 24 + 12))
        {
            goto label_94;
        }
        
        Add(key:  -487675744, value:  8945664);
        Add(key:  -487675360, value:  78753792);
        System.Collections.Generic.Dictionary<System.String, System.Object> val_34 = val_41.GetAdditionalTrackingInfo();
        if((val_41 == 0) || (val_41.Count < 1))
        {
            goto label_98;
        }
        
        Dictionary.KeyCollection<TKey, TValue> val_36 = val_41.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_37 = val_46 & 1.GetEnumerator();
        val_50 = 1152921510385703632;
        label_107:
        if(MoveNext() == false)
        {
            goto label_100;
        }
        
        if((ContainsKey(key:  val_39)) == false)
        {
            goto label_102;
        }
        
        string val_41 = -487675264(-487675264) + val_39;
        UnityEngine.Debug.LogError(message:  -487675264);
        goto label_107;
        label_102:
        string val_42 = val_41.Item[val_39];
        Add(key:  val_39, value:  val_41);
        goto label_107;
    }
    public TRVMainController()
    {
        this.numCategoriesSelection = 3;
    }
    private static TRVMainController()
    {
    
    }
    private void <StartNextQuestion>b__60_0()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        StartGameplay(incData:  this.currentGame);
    }
    private void <RerollCategory>b__69_0()
    {
        this.Init(currentlySelectedCategores:  0, fromReroll:  false);
    }

}
