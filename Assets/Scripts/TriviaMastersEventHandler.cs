using UnityEngine;
public class TriviaMastersEventHandler : WGEventHandler
{
    // Fields
    private const string TRIVIA_MASTERS_NAME = "TRIVIA MASTERS";
    public const string TRIVIA_MASTERS_EVENT_ID = "TriviaMasters";
    public const string EVENT_TRACKING_ID = "Trivia Masters Event";
    private static TriviaMastersEventHandler <Instance>k__BackingField;
    private TriviaMastersEventProgress eventProgress;
    
    // Properties
    public static TriviaMastersEventHandler Instance { get; set; }
    private TriviaMastersEcon EventEcon { get; set; }
    
    // Methods
    public static TriviaMastersEventHandler get_Instance()
    {
    
    }
    private static void set_Instance(TriviaMastersEventHandler value)
    {
        TriviaMastersEventHandler.<Instance>k__BackingField = value;
    }
    private TriviaMastersEcon get_EventEcon()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>()) != 0)
        {
                return;
        }
    
    }
    private void set_EventEcon(TriviaMastersEcon value)
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>().__il2cppRuntimeField_5F0 = value;
    }
    public override void Init(GameEventV2 eventV2)
    {
        mem[1152921512801314648] = eventV2;
        TriviaMastersEventHandler.<Instance>k__BackingField = this;
        this.RefreshEventData(data:  eventV2.eventData);
    }
    public override void OnDataUpdated(GameEventV2 eventV2)
    {
        this.RefreshEventData(data:  eventV2.eventData);
    }
    public override void OnEventEnded()
    {
        TriviaMastersEventHandler.<Instance>k__BackingField = 0;
        if(this.eventProgress == 0)
        {
            
        }
    
    }
    public override void OnGameSceneBegan()
    {
        if(this != 0)
        {
                return;
        }
        
        if(this != 0)
        {
                return;
        }
        
        mem2[0] = 1;
        R4.ShowTriviaMastersPopup();
    }
    public override void OnCategoryComplete()
    {
        if(this.eventProgress.IsPlayingTMQuiz == false)
        {
                return;
        }
        
        this.eventProgress.IsPlayingTMQuiz = false;
        this.EarnToken();
        float val_1 = this.GetEventProgressValue();
        if(this.eventProgress < 0)
        {
                return;
        }
        
        R4.ShowTriviaMastersRewardPopup();
    }
    public override bool EventCompleted()
    {
        ulong val_2;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        return (bool)System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = 1152921512801931984});
    }
    public override bool IsChallengeCompleted()
    {
        goto typeof(TriviaMastersEventHandler).__il2cppRuntimeField_29C;
    }
    public override void OnCategorySelected(TRVCategorySelectionInfo category)
    {
        TriviaMastersEventProgress val_8;
        int val_9;
        val_8 = this.eventProgress;
        if(category == 0)
        {
                val_8 = this.eventProgress;
        }
        
        this.eventProgress.IsPlayingTMQuiz = System.String.op_Equality(a:  category.categoryName, b:  this.eventProgress.SelectedCategory);
        if(this.eventProgress.IsPlayingTMQuiz != true)
        {
                val_9 = this.eventProgress.NextTMLevel;
            Player val_2 = App.Player;
            if(val_9 != 0)
        {
                return;
        }
        
        }
        
        this.eventProgress.SelectedCategory = "";
        Player val_3 = App.Player;
        TriviaMastersEcon val_4 = this.EventEcon;
        TriviaMastersEcon val_5 = this.EventEcon;
        int val_7 = UnityEngine.Random.Range(min:  2621443, max:  1 + 1);
        val_7 = val_7 + 0;
        this.eventProgress.NextTMLevel = val_7;
        if(this.eventProgress == 0)
        {
            
        }
    
    }
    public override System.Collections.Generic.List<TRVCategorySelectionInfo> GetEventsRegisteredCategories(System.Collections.Generic.List<TRVCategorySelectionInfo> categories)
    {
        System.Predicate<ZooTile> val_9;
        TriviaMastersEventProgress val_10;
        val_9 = 35628243;
        if(this.IsEligible() == false)
        {
                return;
        }
        
        if(new RandomSet() != 0)
        {
                addIntRange(lowest:  0, highest:  R7 - 1);
        }
        else
        {
                addIntRange(lowest:  0, highest:  R7 - 1);
        }
        
        int val_5 = roll(unweighted:  false);
        val_10 = this.eventProgress;
        if(val_5 <= val_5)
        {
                var val_9 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_9 = val_9 + (val_5 << 2);
        this.eventProgress.SelectedCategory = (0 + (val_5) << 2) + 16 + 8;
        val_9 = null;
        val_9 = new System.Predicate<ZooTile>(object:  -394419376, method:  new IntPtr(3900519824));
        TRVCategorySelectionInfo val_7 = categories.Find(match:  8040448);
        if(categories == 0)
        {
                return;
        }
        
        val_9 = categories;
        if((val_10.Contains(item:  -394419376)) == true)
        {
                return;
        }
        
        val_9.Add(item:  -394419376);
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
        
        R4.ShowTriviaMastersPopup();
    }
    public override void OnGameButtonPressed(bool connected)
    {
        if(this != 0)
        {
                return;
        }
        
        R4.ShowTriviaMastersPopup();
    }
    public override string GetMainMenuButtonText()
    {
        string val_1 = Localization.Localize(key:  -393978896, defaultValue:  -393978992, useSingularKey:  false);
        string val_2 = this.GetEventProgressText();
        return System.String.Format(format:  -1826949520, arg0:  -393978896, arg1:  -393954784);
    }
    public override string GetGameButtonText()
    {
        string val_1 = Localization.Localize(key:  -393978896, defaultValue:  -393978992, useSingularKey:  false);
        string val_2 = this.GetEventProgressText();
        return System.String.Format(format:  -1826949520, arg0:  -393978896, arg1:  -393842784);
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -393978896, defaultValue:  -393978992, useSingularKey:  false);
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
                return GetEventIcon(eventHandler:  -393497568);
        }
        
        return GetEventIcon(eventHandler:  -393497568);
    }
    public void CollectReward()
    {
        int val_11;
        bool val_11;
        string val_12;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_13;
        val_11 = static_value_021FA4DA;
        if(val_11 != true)
        {
                val_11 = true;
        }
        
        TriviaMastersEcon val_1 = this.EventEcon;
        if(mem[50331656] != 0)
        {
                if(mem[50331656] != 1)
        {
                return;
        }
        
            Player val_2 = App.Player;
            TriviaMastersEcon val_3 = this.EventEcon;
            val_12 = "Trivia Masters";
            0.AddGems(amount:  0, source:  -487899856, subsource:  null);
            Player val_4 = App.Player;
            TriviaMastersEcon val_5 = this.EventEcon;
            string val_6 = 0 + 12;
            val_13 = 0;
            string val_7 = val_6.ToString();
            0.TrackNonCoinReward(source:  -487899856, subSource:  null, rewardType:  -1668821072, rewardAmount:  val_6, additionalParams:  val_13);
            return;
        }
        
        Player val_8 = App.Player;
        TriviaMastersEcon val_9 = this.EventEcon;
        val_12 = 0;
        decimal val_10 = System.Decimal.op_Implicit(value:  -393397608);
        val_13 = "Trivia Masters";
        0.AddCredits(amount:  new System.Decimal() {mid = val_11}, source:  val_13, subSource:  val_12, externalParams:  val_12, doTrack:  true);
    }
    private void RefreshEventData(System.Collections.Generic.Dictionary<string, object> data)
    {
        if((System.String.op_Inequality(a:  static_value_021FA513, b:  -1298909536)) != false)
        {
                string val_2 = -1322383584(-1322383584) + -1298909536(-1298909536);
            UnityEngine.Debug.LogError(message:  -1322383584);
            return;
        }
        
        bool val_3 = this.IsEventNewCycle();
        if(val_3 == true)
        {
                val_3 = this;
            this.ResetEventProgress();
        }
        
        this.ParseEcon(data:  data);
        if(this.eventProgress == 0)
        {
            
        }
    
    }
    private void ParseEcon(System.Collections.Generic.Dictionary<string, object> data)
    {
        var val_23;
        var val_24;
        var val_25;
        float val_26;
        var val_27;
        if(data == 0)
        {
                return;
        }
        
        val_23 = 1152921510392296080;
        if((data.ContainsKey(key:  -1554533760)) == false)
        {
                return;
        }
        
        val_24 = 1152921510385703632;
        object val_2 = data.Item[-1554533760];
        val_25 = 0;
        val_26 = 1152921504685600768;
        if(data != 0)
        {
                val_23 = val_23;
            if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                data = 0;
        }
        
            val_25 = data;
        }
        
        TriviaMastersEcon val_3 = new TriviaMastersEcon();
        if((val_25.ContainsKey(key:  -393156896)) != false)
        {
                string val_5 = val_25.Item[-393156896];
            bool val_7 = System.Int32.TryParse(s:  null, result: out  int val_6 = 358146056);
        }
        
        if((val_25.ContainsKey(key:  -1605526400)) == false)
        {
            goto label_22;
        }
        
        string val_9 = val_25.Item[-1605526400];
        val_26 = "g";
        if((0.ContainsKey(key:  -1968282976)) == false)
        {
            goto label_16;
        }
        
        .__il2cppRuntimeField_8 = 1;
        val_24 = val_24;
        val_27 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
        goto label_20;
        label_16:
        val_26 = "c";
        if((0.ContainsKey(key:  -1785508240)) == false)
        {
            goto label_22;
        }
        
        .__il2cppRuntimeField_8 = 0;
        val_27 = public System.Object System.Collections.Generic.Dictionary<System.String, System.Object>::get_Item(System.String key);
        label_20:
        string val_12 = 0.Item[-1785508240];
        bool val_14 = System.Int32.TryParse(s:  null, result: out  int val_13 = -1130990708);
        val_23 = 1152921510392296080;
        label_22:
        if((val_25.ContainsKey(key:  -393156816)) != false)
        {
                string val_16 = val_25.Item[-393156816];
            bool val_18 = System.Int32.TryParse(s:  null, result: out  int val_17 = 358146064);
        }
        
        if((val_25.ContainsKey(key:  -393156720)) != false)
        {
                string val_20 = val_25.Item[-393156720];
        }
        
        System.Int32.TryParse(s:  null, result: out  int val_21 = 358146068).EventEcon = 358146048;
    }
    private bool IsEligible()
    {
        var val_3;
        Player val_1 = App.Player;
        val_3 = 0;
        if(0 != this.eventProgress.NextTMLevel)
        {
                return true;
        }
        
        float val_2 = this.GetEventProgressValue();
        if(0 < 0)
        {
                val_3 = 1;
        }
        
        return true;
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
        this.eventProgress = new TriviaMastersEventProgress();
        typeof(TriviaMastersEventProgress).__il2cppRuntimeField_8 = R6 + 8;
    }
    private void EarnToken()
    {
        TriviaMastersEventProgress val_1;
        int val_2;
        val_1 = this.eventProgress;
        if(val_1 != 0)
        {
                val_2 = this.eventProgress.Tokens;
        }
        else
        {
                val_1 = 20;
            val_2 = 1;
        }
        
        mem[20] = 2;
        if(this.eventProgress == 0)
        {
            
        }
    
    }
    private float GetEventProgressValue()
    {
        TriviaMastersEcon val_1 = this.EventEcon;
        float val_2 = (float)S0;
        val_2 = (float)this.eventProgress.Tokens / val_2;
        return (float)val_2;
    }
    private string GetEventProgressText()
    {
        TriviaMastersEcon val_1 = EventEcon;
        string val_2 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
    }
    private void ShowTriviaMastersRewardPopup()
    {
        GameBehavior val_1 = App.getBehavior;
        TriviaMastersEcon val_3 = this.EventEcon;
        TriviaMastersEcon val_4 = this.EventEcon;
        0.SetupUI(tokens:  0, reward:  0);
        this.ResetEventProgress();
        mem2[0] = 1;
        this.ShowTriviaMastersPopup();
        goto typeof(TriviaMastersEventHandler).__il2cppRuntimeField_17C;
    }
    private void ShowTriviaMastersPopup()
    {
        GameBehavior val_1 = App.getBehavior;
        string val_3 = this.GetEventProgressText();
        0.SetupUI(progressText:  -392164944, progressValue:  this.GetEventProgressValue());
    }
    public TriviaMastersEventHandler()
    {
        this.eventProgress = new TriviaMastersEventProgress();
    }
    private bool <GetEventsRegisteredCategories>b__19_0(TRVCategorySelectionInfo x)
    {
        if(this.eventProgress != 0)
        {
                return System.String.op_Equality(a:  x.categoryName, b:  this.eventProgress.SelectedCategory);
        }
        
        return System.String.op_Equality(a:  x.categoryName, b:  this.eventProgress.SelectedCategory);
    }

}
