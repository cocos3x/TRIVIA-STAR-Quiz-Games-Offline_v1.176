using UnityEngine;
public class GoldenGalaHandler : WGEventHandler
{
    // Fields
    public const string GOLDEN_GALA_EVENT_ID = "GoldenGala";
    private static GoldenGalaHandler _Instance;
    private const string eventEconomy = "economy";
    private const string chapterCoin = "chapter";
    private const string adCoin = "ads";
    private const string dailyChallenge = "dc_s";
    private const string dailyChallengeCoin = "coins";
    private const string dailyChallengeApple = "golden_currency";
    private decimal chapterCoinReward;
    private decimal adCoinReward;
    private System.Collections.Generic.List<System.Decimal> dailyChallengeCoinReward;
    private System.Collections.Generic.List<int> dailyChallengeAppleReward;
    
    // Properties
    public static GoldenGalaHandler Instance { get; }
    public decimal ChapterCoinReward { get; }
    public decimal AdCoinReward { get; }
    public System.Collections.Generic.List<System.Decimal> DailyChallengeCoinReward { get; }
    public System.Collections.Generic.List<int> DailyChallengeAppleReward { get; }
    public bool IsSubscriptionActive { get; }
    public System.TimeSpan GetTimeRemaining { get; }
    public override bool OverrideEventButton { get; }
    
    // Methods
    public static GoldenGalaHandler get_Instance()
    {
    
    }
    public decimal get_ChapterCoinReward()
    {
        return new System.Decimal() {flags = -1236341264, hi = R1 + 16};
    }
    public decimal get_AdCoinReward()
    {
        return new System.Decimal() {flags = -1236229264, hi = R1 + 32};
    }
    public System.Collections.Generic.List<System.Decimal> get_DailyChallengeCoinReward()
    {
    
    }
    public System.Collections.Generic.List<int> get_DailyChallengeAppleReward()
    {
    
    }
    public bool get_IsSubscriptionActive()
    {
        if(this != 0)
        {
                return false;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1897280256) == 0)
        {
                return false;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance()) != 0)
        {
                return hasSubscription(subPackage:  0);
        }
        
        return hasSubscription(subPackage:  0);
    }
    public System.TimeSpan get_GetTimeRemaining()
    {
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511961016688}, d2:  new System.DateTime() {dateData = R1 + 8 + 32});
        return new System.TimeSpan() {_ticks = val_4._ticks};
    }
    public override bool get_OverrideEventButton()
    {
        return true;
    }
    public override void Init(GameEventV2 eventV2)
    {
        mem[1152921511961248888] = eventV2;
        GoldenGalaHandler.dailyChallengeApple = this;
        this.ParseEventData(eventData:  eventV2.eventData);
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        var val_3;
        var val_3 = 29085363;
        val_3 = 6540428 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 68;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public override void OnGameButtonPressed(bool connected)
    {
        var val_3;
        var val_3 = 29085047;
        val_3 = 6540744 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 69;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        TheLibraryMainScreen val_1 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        if(loader == 0)
        {
            
        }
    
    }
    public override bool EventCompleted()
    {
        ulong val_2;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        return (bool)System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = this.adCoinReward});
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -1234978160, defaultValue:  -1234978256, useSingularKey:  false);
    }
    public override string GetMainMenuButtonText()
    {
        return Localization.Localize(key:  -1234978160, defaultValue:  -1234978256, useSingularKey:  false);
    }
    private void ParseEventData(System.Collections.Generic.Dictionary<string, object> eventData)
    {
        int val_14;
        int val_15;
        int val_16;
        int val_17;
        GoldenGalaHandler val_20;
        var val_21;
        bool val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        val_20 = this;
        val_21 = 1152921510392296080;
        if((eventData.ContainsKey(key:  -1554533760)) == false)
        {
                return;
        }
        
        object val_2 = eventData.Item[-1554533760];
        val_22 = 1;
        if((0.ContainsKey(key:  -1234749952)) != false)
        {
                string val_4 = 0.Item[-1234749952];
            val_23 = 0;
            val_24 = null;
            val_23.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            decimal val_5 = System.Decimal.op_Implicit(value:  -1234732640);
            val_21 = 1152921510392296080;
        }
        
        if((0.ContainsKey(key:  -1234749856)) != false)
        {
                string val_7 = 0.Item[-1234749856];
            val_23 = 0;
            val_24 = null;
            val_23.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            decimal val_8 = System.Decimal.op_Implicit(value:  -1234732640);
            val_21 = 1152921510392296080;
        }
        
        if((0.ContainsKey(key:  -1234749776)) == false)
        {
                return;
        }
        
        string val_10 = 0.Item[-1234749776];
        var val_21 = 0;
        val_25 = 0;
        if(0 != 0)
        {
                val_25 = 0;
            val_22 = mem[1179403827];
            if(((mem[1179403747] + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                0 = 0;
        }
        
            val_25 = 0;
        }
        
        label_44:
        if(val_21 >= 0)
        {
                return;
        }
        
        if(0 <= val_21)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_20 = 0;
        val_20 = val_20 + 0;
        val_26 = 0;
        if((val_26.ContainsKey(key:  -1987496016)) != false)
        {
                string val_12 = val_26.Item[-1987496016];
            val_24 = val_26;
            val_23 = null;
            val_24.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            decimal val_13 = System.Decimal.op_Implicit(value:  -1234732640);
            this.dailyChallengeCoinReward.set_Item(index:  0, value:  new System.Decimal() {flags = val_14, hi = val_15, lo = val_16, mid = val_17});
            val_20 = val_20;
            val_21 = 1152921510392296080;
        }
        
        if((val_26.ContainsKey(key:  -1825935328)) != false)
        {
                val_23 = mem[1152921511962061044];
            string val_19 = val_26.Item[-1825935328];
            val_24 = val_26;
            val_26 = null;
            val_24.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            val_23.set_Item(index:  0, value:  1179403647);
        }
        
        val_21 = val_21 + 1;
        goto label_44;
    }
    public GoldenGalaHandler()
    {
        decimal val_1 = new System.Decimal(value:  25);
        decimal val_2 = new System.Decimal(value:  10);
        System.Collections.Generic.List<System.Decimal> val_3 = new System.Collections.Generic.List<System.Decimal>();
        decimal val_4 = new System.Decimal(value:  10);
        Add(item:  new System.Decimal() {flags = val_4.flags, hi = val_4.hi, lo = val_4.lo, mid = val_4.mid});
        decimal val_5 = new System.Decimal(value:  20);
        Add(item:  new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.mid});
        decimal val_6 = new System.Decimal(value:  30);
        Add(item:  new System.Decimal() {flags = val_6.flags, hi = val_6.hi, lo = val_6.lo, mid = val_6.mid});
        decimal val_7 = new System.Decimal(value:  50);
        Add(item:  new System.Decimal() {flags = val_7.flags, hi = val_7.hi, lo = val_7.lo, mid = val_7.mid});
        this.dailyChallengeCoinReward = null;
        System.Collections.Generic.List<System.Int32> val_8 = new System.Collections.Generic.List<System.Int32>();
        if(null != 0)
        {
                Add(item:  5);
            Add(item:  10);
            Add(item:  15);
        }
        else
        {
                Add(item:  5);
            Add(item:  10);
            Add(item:  15);
        }
        
        Add(item:  20);
        this.dailyChallengeAppleReward = null;
    }

}
