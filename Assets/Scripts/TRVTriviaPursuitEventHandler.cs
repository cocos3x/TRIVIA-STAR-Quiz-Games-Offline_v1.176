using UnityEngine;
public class TRVTriviaPursuitEventHandler : WGEventHandler
{
    // Fields
    public const string TRIVIA_PURSUIT_EVENT_ID = "TriviaPursuit";
    public const string EVENT_TRACKING_ID = "Trivia Pursuit";
    private const string TRIVIA_PURSUIT_NAME = "TRIVIA PURSUIT";
    private static TRVTriviaPursuitEventHandler <Instance>k__BackingField;
    private TriviaPursuitEventProgress eventProgress;
    
    // Properties
    public static TRVTriviaPursuitEventHandler Instance { get; set; }
    private TriviaPursuitEcon EventEcon { get; set; }
    public override bool IsEventValid { get; }
    
    // Methods
    public static TRVTriviaPursuitEventHandler get_Instance()
    {
    
    }
    private static void set_Instance(TRVTriviaPursuitEventHandler value)
    {
        TRVTriviaPursuitEventHandler.<Instance>k__BackingField = value;
    }
    private TriviaPursuitEcon get_EventEcon()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>()) != 0)
        {
                return;
        }
    
    }
    private void set_EventEcon(TriviaPursuitEcon value)
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>().__il2cppRuntimeField_5F4 = value;
    }
    public override void Init(GameEventV2 eventV2)
    {
        mem[1152921512792036824] = eventV2;
        TRVTriviaPursuitEventHandler.<Instance>k__BackingField = this;
        this.RefreshEventData(data:  eventV2.eventData);
    }
    public override void OnDataUpdated(GameEventV2 eventV2)
    {
        this.RefreshEventData(data:  eventV2.eventData);
    }
    public override bool get_IsEventValid()
    {
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        return System.String.op_Equality(a:  null, b:  1800251696);
    }
    public override void OnEventEnded()
    {
        TRVTriviaPursuitEventHandler.<Instance>k__BackingField = 0;
        if(this.eventProgress == 0)
        {
            
        }
    
    }
    public override void OnGameSceneBegan()
    {
        var val_2;
        if(this != 0)
        {
                return;
        }
        
        if(this != 0)
        {
                return;
        }
        
        mem2[0] = 1;
        var val_1 = 27334946;
        val_1 = 8294792 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        if(TRVMainController.noAnswerSelectedCharacter != null)
        {
                return;
        }
        
        R4.ShowTriviaPursuitPopup(forceUpdate:  false, showFlyout:  false);
    }
    public override void OnCategoryComplete()
    {
        object val_1 = new System.Object();
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        typeof(TRVTriviaPursuitEventHandler.<>c__DisplayClass17_0).__il2cppRuntimeField_8 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 8;
        System.Predicate<ZooTile> val_3 = new System.Predicate<ZooTile>(object:  365920256, method:  new IntPtr(3890807696));
        TriviaPursuitCategory val_4 = this.eventProgress.SelectedCategories.Find(match:  8040448);
        if(this.eventProgress.SelectedCategories == 0)
        {
                return;
        }
        
        bool val_5 = this.eventProgress.SelectedCategories.IsCompleted();
        if(val_5 != false)
        {
                return;
        }
        
        val_5 = val_5 + 1;
        mem2[0] = val_5;
        this.CheckEventGoal();
    }
    public override System.Collections.Generic.List<TRVCategorySelectionInfo> GetEventsRegisteredCategories(System.Collections.Generic.List<TRVCategorySelectionInfo> categories)
    {
        int val_21;
        System.Collections.Generic.List<TRVCategorySelectionInfo> val_22;
        float val_23;
        var val_24;
        char* val_25;
        var val_26;
        System.Collections.Generic.List<TRVCategorySelectionInfo> val_27;
        var val_28;
        System.Func<TriviaPursuitCategory, System.Boolean> val_30;
        var val_31;
        val_21 = this;
        val_22 = categories;
        object val_1 = null;
        val_23 = val_1;
        val_1 = new System.Object();
        typeof(TRVTriviaPursuitEventHandler.<>c__DisplayClass18_0).__il2cppRuntimeField_8 = val_22;
        if(val_21 != 0)
        {
                return;
        }
        
        object val_2 = null;
        val_22 = val_2;
        val_2 = new System.Object();
        if(val_22 != 0)
        {
                val_24 = val_22;
            typeof(TRVTriviaPursuitEventHandler.<>c__DisplayClass18_1).__il2cppRuntimeField_C = val_23;
        }
        else
        {
                val_24 = 12;
            mem[12] = val_23;
        }
        
        val_25 = 0;
        val_26 = 0;
        goto label_5;
        label_17:
        System.Predicate<ZooTile> val_3 = new System.Predicate<ZooTile>(object:  366026752, method:  new IntPtr(3890951440));
        TriviaPursuitCategory val_4 = this.eventProgress.SelectedCategories.Find(match:  8040448);
        if(this.eventProgress.SelectedCategories != 0)
        {
                if(this.eventProgress.SelectedCategories.IsCompleted() != true)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            var val_22 = categories + 8;
            val_22 = val_22 + 8142080;
            (categories + 8 + 8142080) + 16 + 12.Add(item:  -403962960);
            val_26 = 1;
        }
        
        }
        
        val_25 = 1152921507830107969;
        label_5:
        typeof(TRVTriviaPursuitEventHandler.<>c__DisplayClass18_1).__il2cppRuntimeField_8 = val_25;
        val_27 = typeof(TRVTriviaPursuitEventHandler.<>c__DisplayClass18_0).__il2cppRuntimeField_8;
        if(val_25 < (categories + 12))
        {
            goto label_17;
        }
        
        val_23 = val_23;
        if((val_26 & 1) == 0)
        {
                Player val_6 = App.Player;
            val_22 = 0;
            TriviaPursuitEcon val_7 = this.EventEcon;
            TriviaPursuitEcon val_8 = this.EventEcon;
            val_27 = 0;
            int val_10 = UnityEngine.Random.Range(min:  1, max:  0 + 1);
            val_10 = val_10 + val_22;
            this.eventProgress.NextTPLevel = val_10;
        }
        
        Player val_11 = App.Player;
        if(0 == this.eventProgress.NextTPLevel)
        {
                object val_12 = new System.Object();
            val_28 = null;
            val_28 = null;
            val_30 = TRVTriviaPursuitEventHandler.<>c.<>9__18_1;
            if(val_30 == 0)
        {
                val_30 = null;
            val_30 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  TRVTriviaPursuitEventHandler.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3890968848));
            TRVTriviaPursuitEventHandler.<>c.<>9__18_1 = val_30;
        }
        
            System.Collections.Generic.IEnumerable<TSource> val_14 = System.Linq.Enumerable.Where<System.Object>(source:  this.eventProgress.SelectedCategories, predicate:  7720960);
            System.Collections.Generic.List<TSource> val_15 = System.Linq.Enumerable.ToList<System.Object>(source:  this.eventProgress.SelectedCategories);
            val_27 = this.eventProgress.SelectedCategories;
            if(this.eventProgress.SelectedCategories != 0)
        {
                val_31 = val_27;
            val_22 = UnityEngine.Random.Range(min:  0, max:  -403995376);
        }
        else
        {
                val_31 = 12;
            val_22 = UnityEngine.Random.Range(min:  0, max:  365973504);
        }
        
            if(val_31 <= val_22)
        {
                var val_23 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_23 = val_23 + (val_22 << 2);
            typeof(TRVTriviaPursuitEventHandler.<>c__DisplayClass18_2).__il2cppRuntimeField_8 = (0 + (val_17) << 2) + 16;
            System.Predicate<ZooTile> val_18 = new System.Predicate<ZooTile>(object:  366080000, method:  new IntPtr(3890972944));
            val_21 = val_27.FindIndex(match:  8040448);
            if((System.String.IsNullOrEmpty(value:  (0 + (val_17) << 2) + 16 + 8)) != false)
        {
                UnityEngine.Debug.LogError(message:  -403992304);
        }
        else
        {
                TRVCategorySelectionInfo val_21 = null;
            val_27 = val_21;
            val_21 = new TRVCategorySelectionInfo();
            if(val_27 != 0)
        {
                typeof(TRVCategorySelectionInfo).__il2cppRuntimeField_8 = (0 + (val_17) << 2) + 16 + 8;
        }
        else
        {
                mem[8] = (0 + (val_17) << 2) + 16 + 8;
        }
        
            Add(item:  -403962960);
            typeof(TRVTriviaPursuitEventHandler.<>c__DisplayClass18_0).__il2cppRuntimeField_8.set_Item(index:  val_21, value:  356761600);
        }
        
        }
        
        if(val_23 != 0)
        {
                return;
        }
    
    }
    public override bool EventCompleted()
    {
        ulong val_2;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        return (bool)System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = 1152921512792963376});
    }
    public override bool IsChallengeCompleted()
    {
        goto typeof(TRVTriviaPursuitEventHandler).__il2cppRuntimeField_29C;
    }
    public override void UpdateProgress()
    {
        mem2[0] = ServerHandler.UnixServerTime;
        this.UpdateProgress();
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        if(this != 0)
        {
                return;
        }
        
        R4.ShowTriviaPursuitPopup(forceUpdate:  false, showFlyout:  false);
    }
    public override void OnGameButtonPressed(bool connected)
    {
        if(this != 0)
        {
                return;
        }
        
        R4.ShowTriviaPursuitPopup(forceUpdate:  false, showFlyout:  false);
    }
    public override string GetMainMenuButtonText()
    {
        string val_1 = this.GetEventProgressText();
        return System.String.Format(format:  -1826949520, arg0:  -403274000, arg1:  -403249904);
    }
    public override string GetGameButtonText()
    {
        string val_1 = this.GetEventProgressText();
        return System.String.Format(format:  -1826949520, arg0:  -403274000, arg1:  -403137904);
    }
    public override string GetEventDisplayName()
    {
    
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        TheLibraryMainScreen val_1 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        string val_2 = this.GetEventProgressText();
        float val_3 = this.GetEventProgressValue();
        if(loader == 0)
        {
            
        }
    
    }
    public override UnityEngine.Sprite GetEventIcon()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static TRVUtils MonoSingleton<TRVUtils>::get_Instance()) != 0)
        {
                return GetEventIcon(eventHandler:  -402792688);
        }
        
        return GetEventIcon(eventHandler:  -402792688);
    }
    public void RerollAnimateCategories()
    {
        Player val_1 = App.Player;
        TriviaPursuitEcon val_2 = this.EventEcon;
        if(0 < 2621443)
        {
                string val_3 = Localization.Localize(key:  -1687442544, defaultValue:  -1687442624, useSingularKey:  false);
            GameStoreManager.StoreCategoryFocus = "gems_upper";
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_5 = ShowUGUIMonolith<System.Object>(showNext:  true);
            System.Action val_6 = new System.Action(object:  -402678528, method:  new IntPtr(3892262608));
            Init(outOfCredits:  true, onCloseAction:  7454720);
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_8 = GetWindow<System.Object>();
            UnityEngine.GameObject val_9 = gameObject;
            SLCWindow.CloseWindow(window:  2119322896, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            return;
        }
        
        Player val_10 = App.Player;
        TriviaPursuitEcon val_11 = this.EventEcon;
        0.AddGems(amount:  0 - 2621443, source:  -402702640, subsource:  null);
        NotificationCenter val_13 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -1618809792);
        this.RerollCategoriesData();
        this.ShowTriviaPursuitPopup(forceUpdate:  true, showFlyout:  false);
    }
    public void CollectReward()
    {
        Player val_1 = App.Player;
        TriviaPursuitEcon val_2 = this.EventEcon;
        0.AddGems(amount:  0, source:  -402590528, subsource:  null);
        Player val_3 = App.Player;
        TriviaPursuitEcon val_4 = this.EventEcon;
        string val_5 = 0 + 12;
        string val_6 = val_5.ToString();
        0.TrackNonCoinReward(source:  -402590416, subSource:  null, rewardType:  -1668821072, rewardAmount:  val_5, additionalParams:  0);
    }
    private void RefreshEventData(System.Collections.Generic.Dictionary<string, object> data)
    {
        if((System.String.op_Inequality(a:  static_value_021FAC76, b:  -1298907008)) != false)
        {
                string val_2 = -1322383584(-1322383584) + -1298907008(-1298907008);
            UnityEngine.Debug.LogError(message:  -1322383584);
            return;
        }
        
        if(this.IsEventNewCycle() != false)
        {
                this.ResetEventProgress();
            this.RerollCategoriesData();
        }
        
        this.ParseEcon(data:  data);
        if(this.eventProgress == 0)
        {
            
        }
    
    }
    private void ParseEcon(System.Collections.Generic.Dictionary<string, object> data)
    {
        var val_25;
        if(data == 0)
        {
                return;
        }
        
        if((data.ContainsKey(key:  -1554533760)) == false)
        {
                return;
        }
        
        object val_2 = data.Item[-1554533760];
        val_25 = 0;
        if(data != 0)
        {
                if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                data = 0;
        }
        
            val_25 = data;
        }
        
        TriviaPursuitEcon val_3 = new TriviaPursuitEcon();
        if((val_25.ContainsKey(key:  -413747344)) != false)
        {
                string val_5 = val_25.Item[-413747344];
            bool val_7 = System.Int32.TryParse(s:  null, result: out  int val_6 = 358252552);
        }
        
        if((val_25.ContainsKey(key:  -402337632)) != false)
        {
                string val_9 = val_25.Item[-402337632];
            bool val_11 = System.Int32.TryParse(s:  null, result: out  int val_10 = 358252560);
        }
        
        if((val_25.ContainsKey(key:  -1605526400)) != false)
        {
                TRVReward val_13 = new TRVReward(rewardType:  1, rewardAmount:  0);
            string val_14 = val_25.Item[-1605526400];
            bool val_16 = System.Int32.TryParse(s:  null, result: out  int val_15 = -1130806324);
        }
        
        if((val_25.ContainsKey(key:  -1306409504)) != false)
        {
                string val_18 = val_25.Item[-1306409504];
            bool val_20 = System.Int32.TryParse(s:  null, result: out  int val_19 = 358252564);
        }
        
        if((val_25.ContainsKey(key:  -1605531600)) != false)
        {
                string val_22 = val_25.Item[-1605531600];
        }
        
        System.Int32.TryParse(s:  null, result: out  int val_23 = 358252568).EventEcon = 358252544;
    }
    private void RerollCategoriesData()
    {
        bool val_4;
        TriviaPursuitEventProgress val_5;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_6;
        var val_7;
        val_4 = static_value_021FAC40;
        if(val_4 != true)
        {
                val_4 = true;
        }
        
        System.Collections.Generic.List<System.String> val_1 = this.GetNewCategories();
        val_5 = this.eventProgress;
        val_6 = null;
        val_6 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.eventProgress.SelectedCategories = val_6;
        val_7 = 0;
        goto label_2;
        label_9:
        TriviaPursuitCategory val_3 = null;
        val_6 = val_3;
        val_3 = new TriviaPursuitCategory();
        if(50331648 <= val_7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_4 = 0;
        val_4 = val_4 + 0;
        if(val_6 != 0)
        {
                typeof(TriviaPursuitCategory).__il2cppRuntimeField_8 = (0 + 0) + 16;
        }
        else
        {
                mem[8] = (0 + 0) + 16;
        }
        
        typeof(TriviaPursuitCategory).__il2cppRuntimeField_C = 0;
        val_5 = this.eventProgress.SelectedCategories;
        val_5.Add(item:  366186496);
        val_7 = 1;
        label_2:
        if(val_7 < 50331648)
        {
            goto label_9;
        }
        
        if(this.eventProgress == 0)
        {
            
        }
    
    }
    private System.Collections.Generic.List<string> GetNewCategories()
    {
        string val_8;
        var val_29;
        var val_30;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_4 = getAvailableSubCategories;
        Dictionary.KeyCollection<TKey, TValue> val_5 = Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_6 = GetEnumerator();
        label_12:
        if(MoveNext() == false)
        {
            goto label_6;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_10 = getAvailableSubCategories;
        string val_11 = Item[val_8];
        System.Collections.Generic.List<ZooTile> val_12 = new System.Collections.Generic.List<ZooTile>(collection:  -1484293744);
        Add(key:  val_8, value:  80883712);
        goto label_12;
        label_6:
        Dispose();
        var val_29 = 3;
        do
        {
            RandomSet val_13 = new RandomSet();
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            string val_14 = Item[357081088];
            WordForest.WFOGameEcon val_15 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
            add(item:  2, weight:  (float)mem[1152921512476916340].Item[2]);
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            string val_17 = Item[357081088];
            WordForest.WFOGameEcon val_18 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
            add(item:  1, weight:  (float)mem[1152921512476916340].Item[1]);
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            string val_20 = Item[357081088];
            WordForest.WFOGameEcon val_21 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
            add(item:  0, weight:  (float)mem[1152921512476916340].Item[0]);
            int val_23 = roll(unweighted:  false);
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            string val_24 = Item[357081088];
            if(null != 0)
        {
                val_29 = null;
            val_30 = UnityEngine.Random.Range(min:  0, max:  1085059232);
        }
        else
        {
                val_29 = 12;
            val_30 = UnityEngine.Random.Range(min:  0, max:  0);
        }
        
            if(val_29 <= val_30)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            string val_27 = Item[357081088];
            bool val_28 = Remove(item:  (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_name + (val_26) << 2) + 16);
            Add(item:  (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_name + (val_26) << 2) + 16);
            val_29 = val_29 - 1;
        }
        while(null != 0);
    
    }
    private string GetEventProgressText()
    {
        var val_5;
        System.Func<TriviaPursuitCategory, System.Int32> val_7;
        val_5 = null;
        val_5 = null;
        val_7 = TRVTriviaPursuitEventHandler.<>c.<>9__35_0;
        if(val_7 == 0)
        {
                val_7 = null;
            val_7 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  TRVTriviaPursuitEventHandler.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3893012848));
            TRVTriviaPursuitEventHandler.<>c.<>9__35_0 = val_7;
        }
        
        int val_2 = System.Linq.Enumerable.Sum<WADPets.WADPet>(source:  this.eventProgress.SelectedCategories, selector:  7720960);
        TriviaPursuitEcon val_3 = EventEcon;
        string val_4 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
    }
    private float GetEventProgressValue()
    {
        var val_4;
        System.Func<TriviaPursuitCategory, System.Int32> val_6;
        val_4 = null;
        val_4 = null;
        val_6 = TRVTriviaPursuitEventHandler.<>c.<>9__36_0;
        if(val_6 == 0)
        {
                val_6 = null;
            val_6 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  TRVTriviaPursuitEventHandler.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3893144304));
            TRVTriviaPursuitEventHandler.<>c.<>9__36_0 = val_6;
        }
        
        int val_2 = System.Linq.Enumerable.Sum<WADPets.WADPet>(source:  this.eventProgress.SelectedCategories, selector:  7720960);
        TriviaPursuitEcon val_3 = val_2.EventEcon;
        var val_4 = val_2 + 8;
        float val_5 = (float)val_2;
        val_4 = val_4 + (val_4 << 1);
        val_5 = val_5 / (float)val_4;
        return (float)val_5;
    }
    private bool IsEventNewCycle()
    {
        var val_1 = R6 + 8;
        val_1 = this - val_1;
        if(R6 != 0)
        {
                val_1 = 1;
        }
        
        return true;
    }
    private void ResetEventProgress()
    {
        this.eventProgress = new TriviaPursuitEventProgress();
        typeof(TriviaPursuitEventProgress).__il2cppRuntimeField_8 = R6 + 8;
    }
    private void CheckEventGoal()
    {
        float val_1 = this.GetEventProgressValue();
        if(<0)
        {
                return;
        }
        
        R4.ShowTriviaPursuitRewardPopup();
        R4.ResetEventProgress();
        mem2[0] = 1;
        if((R4 + 16) == 0)
        {
            
        }
    
    }
    private bool IsEligibleToReroll()
    {
        var val_3;
        System.Predicate<TriviaPursuitCategory> val_5;
        val_3 = null;
        val_3 = null;
        val_5 = TRVTriviaPursuitEventHandler.<>c.<>9__40_0;
        if(val_5 == 0)
        {
                val_5 = null;
            val_5 = new System.Predicate<ZooTile>(object:  TRVTriviaPursuitEventHandler.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3893617904));
            TRVTriviaPursuitEventHandler.<>c.<>9__40_0 = val_5;
        }
        
        System.Collections.Generic.List<TriviaPursuitCategory> val_3 = this.eventProgress.SelectedCategories;
        TriviaPursuitCategory val_2 = val_3.Find(match:  8040448);
        val_3 = val_3 >> 5;
        return (bool)val_3;
    }
    private TRVTriviaPursuitEventPopupDisplayInfo GetCommonDisplayInfo()
    {
        float val_5;
        System.Collections.Generic.List<TriviaPursuitCategory> val_12;
        object val_1 = new System.Object();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        typeof(TRVTriviaPursuitEventPopupDisplayInfo).__il2cppRuntimeField_8 = null;
        val_12 = this.eventProgress.SelectedCategories;
        if(val_12 == 0)
        {
            goto label_3;
        }
        
        List.Enumerator<T> val_3 = GetEnumerator();
        label_13:
        if(MoveNext() == false)
        {
            goto label_6;
        }
        
        object val_6 = new System.Object();
        typeof(TRVTriviaPursuitCategoryDisplayInfo).__il2cppRuntimeField_8 = val_5 + 8;
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Sprite val_8 = GetCategoryIcon(category:  val_5 + 8);
        typeof(TRVTriviaPursuitCategoryDisplayInfo).__il2cppRuntimeField_C = public static TRVUtils MonoSingleton<TRVUtils>::get_Instance();
        float val_9 = val_5.GetProgress();
        typeof(TRVTriviaPursuitCategoryDisplayInfo).__il2cppRuntimeField_10 = val_5;
        string val_10 = val_5.GetProgressText();
        typeof(TRVTriviaPursuitCategoryDisplayInfo).__il2cppRuntimeField_14 = val_5;
        Add(item:  365813760);
        goto label_13;
        label_6:
        Dispose();
        label_3:
        TriviaPursuitEcon val_11 = EventEcon;
        typeof(TRVTriviaPursuitEventPopupDisplayInfo).__il2cppRuntimeField_10 = val_5 + 12;
    }
    private void ShowTriviaPursuitPopup(bool forceUpdate = False, bool showFlyout = False)
    {
        var val_12;
        TRVTriviaPursuitEventPopupDisplayInfo val_1 = this.GetCommonDisplayInfo();
        if(new System.Object() != 0)
        {
                typeof(TRVTriviaPursuitPopupGeneralDisplayInfo).__il2cppRuntimeField_8 = ???;
            typeof(TRVTriviaPursuitPopupGeneralDisplayInfo).__il2cppRuntimeField_10 = this.eventProgress;
        }
        else
        {
                mem[8] = ???;
            mem[16] = this.eventProgress;
        }
        
        typeof(TRVTriviaPursuitPopupGeneralDisplayInfo).__il2cppRuntimeField_C = "Complete Levels in select Categories to earn a big reward!";
        TriviaPursuitEcon val_3 = EventEcon;
        typeof(TRVTriviaPursuitPopupGeneralDisplayInfo).__il2cppRuntimeField_14 = "Complete Levels in select Categories to earn a big reward!".__il2cppRuntimeField_10;
        bool val_4 = this.IsEligibleToReroll();
        typeof(TRVTriviaPursuitPopupGeneralDisplayInfo).__il2cppRuntimeField_18 = val_4;
        val_4 = val_4 >> 5;
        val_4 = val_4 | forceUpdate;
        typeof(TRVTriviaPursuitPopupGeneralDisplayInfo).__il2cppRuntimeField_19 = val_4;
        if(forceUpdate != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_6 = GetWindow<System.Object>();
            ShowEventPopup(info:  366452736);
            return;
        }
        
        if(showFlyout != false)
        {
                GameBehavior val_8 = App.getBehavior;
            val_12 = 0;
        }
        else
        {
                GameBehavior val_10 = App.getBehavior;
            val_12 = 0;
        }
        
        val_12.ShowEventPopup(info:  366452736);
        if(val_12 != 0)
        {
                return;
        }
        
        mem2[0] = 1;
        if(this.eventProgress == 0)
        {
            
        }
    
    }
    private void ShowTriviaPursuitRewardPopup()
    {
        TRVTriviaPursuitEventPopupDisplayInfo val_1 = this.GetCommonDisplayInfo();
        if(new System.Object() != 0)
        {
                typeof(TRVTriviaPursuitPopupRewardDisplayInfo).__il2cppRuntimeField_8 = ???;
            typeof(TRVTriviaPursuitPopupRewardDisplayInfo).__il2cppRuntimeField_10 = this.eventProgress;
        }
        else
        {
                mem[8] = ???;
            mem[16] = this.eventProgress;
        }
        
        typeof(TRVTriviaPursuitPopupRewardDisplayInfo).__il2cppRuntimeField_C = "Congratulations! Collect your reward!";
        GameBehavior val_3 = App.getBehavior;
        0.ShowRewardPopup(info:  366505984);
    }
    public TRVTriviaPursuitEventHandler()
    {
        this.eventProgress = new TriviaPursuitEventProgress();
    }
    private void <RerollAnimateCategories>b__29_0()
    {
        this.ShowTriviaPursuitPopup(forceUpdate:  false, showFlyout:  false);
    }

}
