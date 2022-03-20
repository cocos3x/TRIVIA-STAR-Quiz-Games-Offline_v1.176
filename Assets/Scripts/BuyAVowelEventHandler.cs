using UnityEngine;
public class BuyAVowelEventHandler : WGEventHandler
{
    // Fields
    public const string BAV_EVENT_ID = "BuyAVowel";
    public const string BAV_EVENT_NAME = "BUY A VOWEL";
    private const string PREF_LEVEL_USED = "bav_used_level";
    private const string PREF_LEVEL_SHOWN = "bav_shown_level";
    private static BuyAVowelEventHandler <Instance>k__BackingField;
    private decimal vowelPrice;
    
    // Properties
    public static BuyAVowelEventHandler Instance { get; set; }
    public decimal GetVowelPrice { get; }
    public override bool IsEventValid { get; }
    
    // Methods
    public static BuyAVowelEventHandler get_Instance()
    {
    
    }
    private static void set_Instance(BuyAVowelEventHandler value)
    {
        BuyAVowelEventHandler.<Instance>k__BackingField = value;
    }
    public decimal get_GetVowelPrice()
    {
        var val_4;
        if((CPlayerPrefs.HasKey(key:  -1515421408)) != false)
        {
                var val_2 = R1 + 16;
            return new System.Decimal() {flags = 10174500, hi = System.Decimal.__il2cppRuntimeField_cctor_finished};
        }
        
        val_4 = null;
        val_4 = null;
        return new System.Decimal() {flags = 10174500, hi = System.Decimal.__il2cppRuntimeField_cctor_finished};
    }
    public string GetEventRemainingTime()
    {
        var val_5;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511681484336}, d2:  new System.DateTime() {dateData = 1152921511681496384});
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
    public void TrackBuyVowelOnLevel(string level)
    {
        CPlayerPrefs.SetString(key:  -1515421408, val:  level);
    }
    private void ShowBAVInfoPopup()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    private void ShowBAVEventPopup()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public override bool get_IsEventValid()
    {
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        return System.String.op_Equality(a:  null, b:  1800251696);
    }
    public override void Init(GameEventV2 eventV2)
    {
        var val_6;
        var val_7;
        mem[1152921511682074824] = eventV2;
        val_6 = 6593964 + 29032928;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        BuyAVowelEventHandler.<Instance>k__BackingField = this;
        if(eventV2.eventData == 0)
        {
                return;
        }
        
        val_7 = 1152921510392296080;
        val_6 = "economy";
        if((eventV2.eventData.ContainsKey(key:  -1554533760)) == false)
        {
                return;
        }
        
        object val_2 = eventV2.eventData.Item[-1554533760];
        val_6 = 1;
        val_7 = "coins";
        if((0.ContainsKey(key:  -1987496016)) == false)
        {
                return;
        }
        
        string val_4 = 0.Item[-1987496016];
        bool val_5 = System.Decimal.TryParse(s:  null, result: out  new System.Decimal() {flags = this.vowelPrice, lo = System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth});
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        var val_1;
        var val_1 = 29031291;
        val_1 = 6594500 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 98;
        AmplitudePluginHelper.lastFeatureAccessPoint.ShowBAVInfoPopup();
    }
    public override void OnGameButtonPressed(bool connected)
    {
        var val_1;
        var val_1 = 29031079;
        val_1 = 6594712 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 99;
        AmplitudePluginHelper.lastFeatureAccessPoint.ShowBAVEventPopup();
    }
    public override string GetMainMenuButtonText()
    {
        return Localization.Localize(key:  -1514386464, defaultValue:  -1514386560, useSingularKey:  false);
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -1514386464, defaultValue:  -1514386560, useSingularKey:  false);
    }
    public override void OnWordRegionLoaded()
    {
    
    }
    public override void OnValidWordSubmitted(string word)
    {
        GameBehavior val_2 = App.getBehavior;
        bool val_3 = CPlayerPrefs.GetInt(key:  -1514046256, defaultValue:  0).Equals(obj:  0);
        if(val_3 == true)
        {
                return;
        }
        
        val_3.ShowBAVEventPopup();
        GameBehavior val_4 = App.getBehavior;
        CPlayerPrefs.SetInt(key:  -1514046256, val:  0);
    }
    public override void OnGameSceneBegan()
    {
    
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        TheLibraryMainScreen val_1 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
    }
    public override bool ShouldShowInDailyChallenge(bool dailyChallengeState)
    {
        return false;
    }
    public override void AppendLevelCompleteData(ref System.Collections.Generic.Dictionary<string, object> currentData)
    {
        var val_4;
        if((currentData.ContainsKey(key:  -2100706208)) == false)
        {
                return;
        }
        
        string val_2 = CPlayerPrefs.GetString(key:  -1515421408, defaultValue:  1098586544);
        object val_3 = currentData.Item[-2100706208];
        if("bav_used_level" != 0)
        {
                val_4 = 1152921504615792640;
        }
        else
        {
                val_4 = 1152921504615792640;
        }
        
        currentData.Add(key:  -1513580816, value:  8945664);
    }
    public BuyAVowelEventHandler()
    {
         = new System.Decimal(value:  350);
    }

}
