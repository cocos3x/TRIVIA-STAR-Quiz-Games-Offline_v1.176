using UnityEngine;
public class VIPPartyEventHandler : WGEventHandler
{
    // Fields
    public const string VIP_PARTY_EVENT_ID = "VipParty";
    private static VIPPartyEventHandler instance;
    private VIPPartyEventInfo eventInfo;
    
    // Properties
    public static VIPPartyEventHandler Instance { get; }
    
    // Methods
    public static VIPPartyEventHandler get_Instance()
    {
    
    }
    public override void Init(GameEventV2 eventV2)
    {
        VIPPartyEventHandler.instance = this;
        mem[1152921512210124312] = eventV2;
        this.eventInfo.timestamp = eventV2.serverTimestamp;
        this.ParseEventData(eventData:  eventV2.eventData);
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
                return;
        }
        
        Player val_3 = App.Player;
        string val_4 = -1304441104(-1304441104) + 1835037;
        UnityEngine.Debug.LogWarning(message:  -1304441104);
    }
    public override void OnDataUpdated(GameEventV2 eventV2)
    {
        if(true == 0)
        {
                return;
        }
        
        if((System.String.op_Inequality(a:  872415232, b:  -1266462784)) != false)
        {
                string val_2 = eventV2.ToString();
            string val_3 = -1322383584(-1322383584) + eventV2;
            UnityEngine.Debug.LogError(message:  -1322383584);
            return;
        }
        
        this.eventInfo.timestamp = eventV2.serverTimestamp;
        this.ParseEventData(eventData:  eventV2.eventData);
    }
    public override void OnLevelComplete(int levelsProgressed = 1)
    {
        this.UpdateProgressionToServer();
    }
    public override void OnEventEnded()
    {
        VIPPartyEventHandler.instance = 0;
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -986196304, defaultValue:  -986196400, useSingularKey:  false);
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        TheLibraryMainScreen val_1 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        if(this.eventInfo.isVIP == true)
        {
                this.eventInfo.isVIP = 1;
        }
        
        loader.SetupVipStatus(isVIP:  true);
    }
    public override string GetMainMenuButtonText()
    {
        return Localization.Localize(key:  -986196304, defaultValue:  -986196400, useSingularKey:  false);
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        this.ShowVipPartyEventInfoPopup();
        this.TrackPurchase(point:  54);
    }
    public override void OnGameButtonPressed(bool connected)
    {
        this.ShowVipPartyEventInfoPopup();
        this.TrackPurchase(point:  55);
    }
    public override void OnPurchaseCompleted(PurchaseModel obj)
    {
        var val_3;
        var val_4;
        Player val_1 = App.Player;
        val_3 = 2621448;
        if(val_3 != 0)
        {
                val_4 = 35144008;
        }
        else
        {
                val_3 = 356;
            val_4 = 0;
        }
        
        mem[356] = 1;
        this.eventInfo.isVIP = true;
        this.UpdateProgressionToServer();
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -985610592);
    }
    private void ParseEventData(System.Collections.Generic.Dictionary<string, object> eventData)
    {
        string val_21;
        var val_29;
        VIPPartyEventInfo val_30;
        var val_31;
        GameEventRewardType val_32;
        var val_34;
        var val_35;
        var val_36;
        if(eventData == 0)
        {
                return;
        }
        
        val_30 = "economy";
        if((eventData.ContainsKey(key:  -1554533760)) == false)
        {
                return;
        }
        
        object val_2 = eventData.Item[-1554533760];
        if(eventData == 0)
        {
                return;
        }
        
        val_30 = eventData;
        if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_30 = 0;
        }
        
        val_31 = "reward";
        if((val_30.ContainsKey(key:  -1470584448)) == false)
        {
                return;
        }
        
        string val_4 = val_30.Item[-1470584448];
        val_30 = val_30;
        if(val_30 == 0)
        {
                return;
        }
        
        if(((mem[1179403747] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_30 = 0;
        }
        
        Player val_5 = App.Player;
        string val_6 = 33449456.ToUpper();
        val_31 = 33449456;
        string val_7 = val_30.Item[1726392512];
        val_32 = 0;
        label_56:
        if(this.eventInfo == 0)
        {
                val_32 = val_32;
        }
        
        if(val_32 != 0)
        {
                this.eventInfo.rewardType = val_32;
            val_30 = this.eventInfo;
            decimal val_8 = System.Decimal.op_Implicit(value:  -985453712);
        }
        else
        {
                this.eventInfo.rewardType = 1;
            decimal val_9;
            val_30 = this.eventInfo;
            val_9 = new System.Decimal(value:  25);
        }
        
        val_29 = "status";
        if((eventData.ContainsKey(key:  1658601040)) == false)
        {
                return;
        }
        
        object val_11 = eventData.Item[1658601040];
        if(eventData != 0)
        {
                val_29 = "isVIP";
            if((eventData.ContainsKey(key:  -985473888)) != false)
        {
                object val_13 = eventData.Item[-985473888];
            string val_14 = eventData.ToString();
            bool val_16 = System.Boolean.TryParse(value:  eventData, result: out  this.eventInfo.isVIP);
            return;
        }
        
        }
        
        this.eventInfo.isVIP = false;
        return;
        label_52:
        if(0.MoveNext() == false)
        {
            goto label_44;
        }
        
        bool val_23 = System.Int32.TryParse(s:  val_21, result: out  int val_22 = -985453684);
        if((0 < 1) || (0 != 1))
        {
            goto label_52;
        }
        
        val_34 = 0;
        if(0 == 0)
        {
                val_34 = 0;
        }
        
        string val_24 = val_34.Trim();
        string val_25 = val_34.ToLower();
        if((System.String.Compare(strA:  null, strB:  -1987496016)) == 0)
        {
            goto label_50;
        }
        
        if((System.String.Compare(strA:  null, strB:  -1318762160)) == 0)
        {
            goto label_51;
        }
        
        if((System.String.Compare(strA:  null, strB:  -1318762064)) != 0)
        {
            goto label_52;
        }
        
        val_35 = 4;
        goto label_55;
        label_44:
        val_36 = 0;
        val_35 = 0;
        goto label_54;
        label_50:
        val_35 = 1;
        goto label_55;
        label_51:
        val_35 = 3;
        label_55:
        val_36 = 0;
        label_54:
        0.Dispose();
        goto label_56;
    }
    private void UpdateProgressionToServer()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1470901296, value:  13152256);
        Add(key:  -985473888, value:  8945664);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PutUpdate(eventID:  -985296848, data:  78753792);
    }
    private bool IsEventEnded()
    {
        ulong val_2;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        return (bool)System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = 1152921512211604912});
    }
    public VIPPartyEventInfo GetEventInfo()
    {
    
    }
    public bool IsEventExpired()
    {
        ulong val_2;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        return (bool)System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = 1152921512211837104});
    }
    public string GetEventRemainingTime()
    {
        var val_5;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512211937056}, d2:  new System.DateTime() {dateData = 1152921512211949104});
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
    public void ShowVipPartyEventInfoPopup()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public void ShowChapterClearPopup()
    {
    
    }
    public void OnAnimFinished_StorePurchaseOnChapterComplete()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -984519440, value:  10170368);
        Player val_2 = App.Player;
        0.AddCredits(amount:  new System.Decimal() {flags = mem[this.eventInfo.reward + (0)], hi = mem[this.eventInfo.reward + (4)], lo = mem[this.eventInfo.reward + (8)], mid = this.eventInfo}, source:  "Chapter Complete", subSource:  0, externalParams:  null, doTrack:  true);
    }
    public void TrackPurchase(TrackerPurchasePoints point)
    {
        var val_1;
        var val_1 = 27992073;
        val_1 = 7633988 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        PurchaseProxy.currentPurchasePoint = point;
    }
    public VIPPartyEventHandler()
    {
        this.eventInfo = new System.Object();
    }

}
