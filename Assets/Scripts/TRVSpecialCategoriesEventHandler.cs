using UnityEngine;
public class TRVSpecialCategoriesEventHandler : WGEventHandler
{
    // Fields
    private static TRVSpecialCategoriesEventHandler _Instance;
    public const string SPECIAL_CATEGORIES_EVENT_ID = "SpecialCategories";
    public const string EVENT_TRACKING_ID = "Special Categories";
    private System.Collections.Generic.Dictionary<string, object> myEventData;
    private System.Collections.Generic.Dictionary<int, int> tierRewards;
    private System.Collections.Generic.Dictionary<int, int> quizLength;
    private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<object>> quizDifficulties;
    private string eventCatergory;
    private int quizProgress;
    private int lastCollectedReward;
    
    // Properties
    public static TRVSpecialCategoriesEventHandler Instance { get; }
    public override int getPriorityWeight { get; }
    public GameEventV2 getEvent { get; }
    public string getEventCategory { get; }
    public int getQuizProgress { get; }
    public System.Collections.Generic.Dictionary<int, int> getTierRewards { get; }
    private static int LastProgressTimestampPref { get; set; }
    public override bool IsEventHidden { get; }
    public override bool IsEventValid { get; }
    
    // Methods
    public static TRVSpecialCategoriesEventHandler get_Instance()
    {
    
    }
    public override int get_getPriorityWeight()
    {
        return 1;
    }
    public GameEventV2 get_getEvent()
    {
    
    }
    public string get_getEventCategory()
    {
    
    }
    public int get_getQuizProgress()
    {
        return (int)this.quizProgress;
    }
    public System.Collections.Generic.Dictionary<int, int> get_getTierRewards()
    {
    
    }
    private static int get_LastProgressTimestampPref()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -424437104, defaultValue:  0);
    }
    private static void set_LastProgressTimestampPref(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -424437104, value:  value);
    }
    public override void Init(GameEventV2 eventV2)
    {
        mem[1152921512772600776] = eventV2;
        this.ParseEventData(eventData:  eventV2.eventData);
        TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID = this;
        if((this.CheckNeedsNewData(eventData:  eventV2.eventData)) != false)
        {
                this.GenerateNewData();
            return;
        }
        
        this.LoadPersistantData();
    }
    private bool CheckNeedsNewData(GameEventV2 eventData)
    {
        if((CPlayerPrefs.HasKey(key:  -1266461600)) == false)
        {
                return true;
        }
        
        string val_2 = CPlayerPrefs.GetString(key:  -1266461600);
        object val_3 = MiniJSON.Json.Deserialize(json:  -1266461600);
        if("SpecialCategories" == 0)
        {
                return true;
        }
        
        if(null != null)
        {
                "SpecialCategories" = 0;
        }
        
        if(null != null)
        {
                return true;
        }
        
        if("SpecialCategories".Count == 0)
        {
                return true;
        }
        
        if(("SpecialCategories".ContainsKey(key:  1624646480)) == false)
        {
                return true;
        }
        
        string val_6 = "SpecialCategories".Item[1624646480];
        string val_7 = ToString();
        return System.String.op_Inequality(a:  null, b:  -424056464);
    }
    private void GenerateNewData()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1624646480, value:  13152256);
        Add(key:  -431047344, value:  13152256);
        Add(key:  -1605526400, value:  8945664);
        Add(key:  -423964416, value:  13152256);
        string val_2 = MiniJSON.Json.Serialize(obj:  78753792);
        CPlayerPrefs.SetString(key:  -1266461600, val:  78753792);
        CPlayerPrefs.Save();
        this.LoadPersistantData();
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.ResetSubCat(subcat:  this.eventCatergory);
    }
    private void LoadPersistantData()
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_5;
        var val_6;
        var val_7;
        string val_1 = CPlayerPrefs.GetString(key:  -1266461600);
        object val_2 = MiniJSON.Json.Deserialize(json:  -1266461600);
        val_5 = 0;
        if("SpecialCategories" != 0)
        {
                val_5 = 0;
            if(null != null)
        {
                "SpecialCategories" = 0;
        }
        
            val_5 = "SpecialCategories";
        }
        
        this.myEventData = val_5;
        object val_3 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  0, key:  -431047344, defaultValue:  13152256);
        val_6 = null;
        val_7 = val_5;
        val_7.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        this.quizProgress = 1179403647;
        object val_4 = EnumerableExtentions.GetOrDefault<System.String, System.Object>(dic:  this.myEventData, key:  -423964416, defaultValue:  13152256);
        val_6 = null;
        val_7 = this.myEventData;
        val_7.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        this.lastCollectedReward = null;
    }
    private void SaveData()
    {
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.myEventData, key:  -431047344, newValue:  13152256);
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  this.myEventData, key:  -423964416, newValue:  13152256);
        string val_1 = MiniJSON.Json.Serialize(obj:  this.myEventData);
        CPlayerPrefs.SetString(key:  -1266461600, val:  this.myEventData);
        CPlayerPrefs.Save();
    }
    private void ParseEventData(System.Collections.Generic.Dictionary<string, object> eventData)
    {
        string val_20;
        var val_49;
        var val_50;
        if(eventData == 0)
        {
                return;
        }
        
        if(eventData.Count == 0)
        {
                return;
        }
        
        val_49 = "economy";
        if((eventData.ContainsKey(key:  -1554533760)) == false)
        {
                return;
        }
        
        object val_3 = eventData.Item[-1554533760];
        if(eventData == 0)
        {
                return;
        }
        
        val_49 = eventData;
        if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_49 = 0;
        }
        
        return;
        label_46:
        if(MoveNext() == false)
        {
            goto label_37;
        }
        
        if((System.Int32.TryParse(s:  val_20, result: out  int val_21 = -423556236)) == false)
        {
            goto label_41;
        }
        
        string val_23 = 0.Item[val_20];
        if((System.Int32.TryParse(s:  null, result: out  int val_24 = -423556240)) == false)
        {
            goto label_41;
        }
        
        this.tierRewards.Add(key:  0, value:  0);
        goto label_46;
        label_41:
        UnityEngine.Debug.LogError(message:  -423579184);
        goto label_46;
        label_37:
        Dispose();
        if((0.ContainsKey(key:  -423579024)) == false)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_27 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        this.quizLength = null;
        string val_28 = 0.Item[-423579024];
        Dictionary.KeyCollection<TKey, TValue> val_29 = 0.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_30 = GetEnumerator();
        label_63:
        if(MoveNext() == false)
        {
            goto label_54;
        }
        
        if((System.Int32.TryParse(s:  val_20, result: out  int val_32 = -423556244)) == false)
        {
            goto label_58;
        }
        
        string val_34 = 0.Item[val_20];
        if((System.Int32.TryParse(s:  null, result: out  int val_35 = -423556248)) == false)
        {
            goto label_58;
        }
        
        this.quizLength.Add(key:  0, value:  0);
        goto label_63;
        label_58:
        UnityEngine.Debug.LogError(message:  -423579184);
        goto label_63;
        label_54:
        Dispose();
        if((0.ContainsKey(key:  -423574832)) == false)
        {
                return;
        }
        
        string val_38 = 0.Item[-423574832];
        if(0 != 0)
        {
                if(((mem[1179403747] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                0 = 0;
        }
        
        }
        
        System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_39 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
        this.quizDifficulties = null;
        Dictionary.KeyCollection<TKey, TValue> val_40 = 0.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_41 = GetEnumerator();
        label_82:
        if(MoveNext() == false)
        {
            goto label_71;
        }
        
        string val_43 = 0.Item[val_20];
        val_50 = 0;
        if(0 != 0)
        {
                if(((mem[1179403747] + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                0 = 0;
        }
        
            val_50 = 0;
        }
        
        bool val_45 = System.Int32.TryParse(s:  val_20, result: out  int val_44 = -423556252);
        if(((val_50 == 0) || (val_50 != 0)) || (0 < 1))
        {
            goto label_77;
        }
        
        this.quizDifficulties.Add(key:  0, value:  0);
        goto label_82;
        label_77:
        UnityEngine.Debug.LogError(message:  -423568608);
        goto label_82;
        label_71:
        Dispose();
        if((eventData.ContainsKey(key:  -490682048)) != false)
        {
                object val_47 = eventData.Item[-490682048];
            string val_48 = eventData.ToString();
            this.eventCatergory = eventData;
            return;
        }
        
        this.eventCatergory = "Queen";
        UnityEngine.Debug.LogError(message:  -423568368);
    }
    public int GetQuizLength()
    {
        int val_3;
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_7;
        int val_8;
        Dictionary.KeyCollection<TKey, TValue> val_1 = this.quizLength.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = GetEnumerator();
        val_8 = 3;
        goto label_3;
        label_5:
        val_7 = this.quizLength;
        if(this.quizProgress >= val_7.Item[val_3])
        {
                val_8 = val_3;
        }
        
        label_3:
        if(MoveNext() == true)
        {
            goto label_5;
        }
        
        Dispose();
        return (int)UnityEngine.Mathf.Max(a:  3, b:  val_8);
    }
    public string GetEventPrimaryCategory()
    {
    
    }
    public TRVCategorySelectionInfo GetEventSubCategory()
    {
        TRVCategorySelectionInfo val_1 = new TRVCategorySelectionInfo();
        typeof(TRVCategorySelectionInfo).__il2cppRuntimeField_8 = this.eventCatergory;
    }
    public int GetQuestionDifficulty(int quizProgress)
    {
        var val_4;
        var val_10;
        int val_11;
        var val_12;
        var val_13;
        int val_1 = this.GetQuizLength();
        Dictionary.KeyCollection<TKey, TValue> val_2 = this.quizDifficulties.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = GetEnumerator();
        val_10 = 0;
        goto label_4;
        label_6:
        if(val_4 == val_1)
        {
                System.Collections.Generic.List<System.Object> val_5 = this.quizDifficulties.Item[val_1];
            val_10 = this.quizDifficulties;
        }
        
        label_4:
        if(MoveNext() == true)
        {
            goto label_6;
        }
        
        Dispose();
        label_22:
        if(val_10 == 0)
        {
                Dictionary.KeyCollection<TKey, TValue> val_7 = this.quizDifficulties.Keys;
            val_11 = System.Linq.Enumerable.Max(source:  this.quizDifficulties);
            val_12 = this.quizDifficulties;
            System.Collections.Generic.List<System.Object> val_9 = val_12.Item[val_11];
            val_10 = val_12;
            if(val_12 == 0)
        {
            goto label_19;
        }
        
        }
        
        if(val_12 > quizProgress)
        {
                if(val_12 <= quizProgress)
        {
                var val_10 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_10 = val_10 + (quizProgress << 2);
            (0 + (quizProgress) << 2) + 16.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            val_13 = mem[(0 + (quizProgress) << 2) + 16];
            val_13 = (0 + (quizProgress) << 2) + 16;
            return (int)val_13;
        }
        
        val_13 = 0;
        UnityEngine.Debug.LogError(message:  -423061696);
        return (int)val_13;
        label_19:
        if( != 1)
        {
            goto label_20;
        }
        
        Dispose();
        if( == 0)
        {
            goto label_22;
        }
        
        goto label_22;
        label_20:
    }
    public override TRVQuizProgress GetCustomQuizLevel(TRVSubCategoryData data)
    {
        TRVSpecialCategoriesQuiz val_1 = new TRVSpecialCategoriesQuiz(quizCategoryData:  data, isPromo:  false);
    }
    public int getCurrentReward()
    {
        if((this.tierRewards.ContainsKey(key:  this.quizProgress)) == false)
        {
                return 0;
        }
        
        if(this.tierRewards != 0)
        {
                return this.tierRewards.Item[this.quizProgress];
        }
        
        return this.tierRewards.Item[this.quizProgress];
    }
    public void CollectReward()
    {
        var val_5;
        var val_11;
        int val_1 = this.getCurrentReward();
        Dictionary.KeyCollection<TKey, TValue> val_2 = this.tierRewards.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = GetEnumerator();
        val_11 = 1;
        goto label_3;
        label_4:
        val_11 = 2;
        label_3:
        bool val_4 = MoveNext();
        if(val_4 == true)
        {
                val_4 = val_5;
            public System.Boolean Dictionary.KeyCollection.Enumerator<System.Int32, System.Int32>::MoveNext() = this.quizProgress;
        }
        
        if(val_4 != (public System.Boolean Dictionary.KeyCollection.Enumerator<System.Int32, System.Int32>::MoveNext()))
        {
            goto label_4;
        }
        
        Dispose();
        Player val_6 = App.Player;
        string val_7 = System.String.Format(format:  -422684480, arg0:  13152256);
        0.AddGems(amount:  val_1, source:  -422684480, subsource:  null);
        Player val_8 = App.Player;
        string val_9 = System.String.Format(format:  -422684480, arg0:  13152256);
        string val_10 = val_1.ToString();
        0.TrackNonCoinReward(source:  -422684480, subSource:  null, rewardType:  -1668821072, rewardAmount:  val_1, additionalParams:  0);
        this.lastCollectedReward = this.quizProgress;
        this.SaveData();
    }
    public override bool IsRewardReadyToCollect()
    {
        var val_2;
        bool val_1 = this.tierRewards.ContainsKey(key:  this.quizProgress);
        val_2 = 0;
        if(val_1 == false)
        {
                return true;
        }
        
        int val_2 = this.quizProgress;
        val_2 = this.lastCollectedReward - val_2;
        if(val_1 == true)
        {
                val_2 = 1;
        }
        
        return true;
    }
    public override bool EventCompleted()
    {
        if(this.quizProgress != 0)
        {
                this.quizProgress = this.tierRewards;
        }
        
        if(this.quizProgress == 0)
        {
                return false;
        }
        
        if(this.quizProgress.Count == 0)
        {
                return false;
        }
        
        Dictionary.KeyCollection<TKey, TValue> val_2 = this.tierRewards.Keys;
        if(this.quizProgress >= (System.Linq.Enumerable.Max(source:  this.tierRewards)))
        {
                0 = 1;
        }
        
        return false;
    }
    public override bool get_IsEventHidden()
    {
        goto typeof(TRVSpecialCategoriesEventHandler).__il2cppRuntimeField_29C;
    }
    public override bool get_IsEventValid()
    {
        if(this != 0)
        {
                return false;
        }
        
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        return System.String.op_Equality(a:  null, b:  1800251696);
    }
    public override string GetEventDisplayName()
    {
        string val_1 = this.eventCatergory.ToUpper();
        return System.String.Format(format:  -568469520, arg0:  this.eventCatergory);
    }
    public override string GetGameButtonText()
    {
    
    }
    public override string GetMainMenuButtonText()
    {
        string val_1 = this.eventCatergory.ToUpper();
        return System.String.Format(format:  -568341024, arg0:  this.eventCatergory);
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public override void OnGameButtonPressed(bool connected)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        TheLibraryMainScreen val_1 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        loader.Init(category:  this.eventCatergory);
    }
    public override void OnCategoryComplete()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 180) < TRVSpecialCategoriesQuiz.__il2cppRuntimeField_typeHierarchyDepth)
        {
                return;
        }
    
    }
    public override void AppendGemSpentTracking(ref System.Collections.Generic.Dictionary<string, object> refData)
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1647818192) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_5 = refData;
        Add(key:  -575491712, value:  8945664);
    }
    public override void UpdateProgress()
    {
        TRVSpecialCategoriesEventHandler.LastProgressTimestampPref = ServerHandler.UnixServerTime;
        this.UpdateProgress();
    }
    public TRVSpecialCategoriesEventHandler()
    {
        this.eventCatergory = "";
    }

}
