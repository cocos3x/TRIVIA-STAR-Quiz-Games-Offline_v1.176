using UnityEngine;
public class WGFreeHintPopup : MonoBehaviour
{
    // Fields
    protected UnityEngine.GameObject group_start;
    protected UnityEngine.UI.Text desc_text;
    private UnityEngine.GameObject pet_icon;
    protected UnityEngine.UI.Text freeCoinButtonText;
    protected UGUINetworkedButton Button_FreeHint;
    private UnityEngine.UI.Button Button_Close_FreeHint;
    protected UnityEngine.GameObject group_sorry;
    protected UnityEngine.UI.Text sorry_message;
    protected UnityEngine.UI.Text sorry_button_text;
    protected UnityEngine.UI.Text sorry_banner_text;
    private UGUINetworkedButton Button_WatchAnother;
    private UnityEngine.UI.Button Button_Close_Sorry;
    protected UnityEngine.GameObject group_success;
    protected UnityEngine.UI.Button Button_CollectHint;
    private bool hideTextWhileCollecting;
    protected UnityEngine.UI.Text message_thankYou;
    protected GridCoinCollectAnimationInstantiator coinsAnim;
    private UnityEngine.Transform coinSource;
    private UnityEngine.Transform midCoinTransform;
    private UnityEngine.Transform leftCoinTransform;
    private UnityEngine.Transform rightCoinTransform;
    protected UnityEngine.UI.Text coin_amount;
    private UnityEngine.UI.Text gala_regular_coin_amount;
    private UnityEngine.UI.Text gala_bonus_coin_amount;
    private UnityEngine.GameObject regularRewardGroup;
    private UnityEngine.GameObject galaRewardGroup;
    private UnityEngine.GameObject galaRewardOverlay;
    private UnityEngine.UI.Button Button_GalaReward;
    protected UnityEngine.LineRenderer strikeoutLine;
    protected CurrencyRewardType curRewType;
    public System.Action OnClose;
    protected decimal reward;
    private decimal petsReward;
    protected HeyZapAdTag initTag;
    protected HeyZapAdTag currTag;
    protected string initFreeCointEvent;
    protected string currFreeCoinEvent;
    private int _isMinigameWindow;
    public static bool dailyCollected;
    private FrameSkipper frameSkipper;
    protected WGFreeHintPopup.WGFreeHintPopupStates state;
    
    // Properties
    private bool isMinigameWindow { get; }
    
    // Methods
    private bool get_isMinigameWindow()
    {
        if(this._isMinigameWindow == 1)
        {
                object val_1 = this.GetComponent<System.Object>();
            bool val_2 = UnityEngine.Object.op_Implicit(exists:  -39032688);
            this._isMinigameWindow = val_2;
        }
        
        val_2 = val_2 - 1;
        val_2 = val_2 >> 5;
        return (bool)val_2;
    }
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -38872560, method:  new IntPtr(4256030800));
        this.Button_Close_FreeHint.m_OnClick.AddListener(call:  162246656);
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -38872560, method:  new IntPtr(4256035920));
        this.Button_WatchAnother.OnConnectionClick = null;
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -38872560, method:  typeof(WGFreeHintPopup).__il2cppRuntimeField_108);
        this.Button_Close_Sorry.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -38872560, method:  typeof(WGFreeHintPopup).__il2cppRuntimeField_100);
        this.Button_CollectHint.m_OnClick.AddListener(call:  162246656);
        if(this.Button_GalaReward != 0)
        {
                UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  -38872560, method:  new IntPtr(4256065616));
            this.Button_GalaReward.m_OnClick.AddListener(call:  162246656);
        }
        
        UnityEngine.GameObject val_7 = this.gameObject;
        UnityEngine.UI.LayoutElement val_8 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -38872560);
        this.frameSkipper = this;
        this.pet_icon = 60;
        System.Action val_9 = new System.Action(object:  -38872560, method:  typeof(WGFreeHintPopup).__il2cppRuntimeField_E0);
        this.frameSkipper.updateLogic = null;
    }
    protected virtual void UpdateLogic()
    {
        var val_9;
        var val_21;
        var val_22;
        var val_23;
        if(this.state == 1)
        {
                val_21 = 1152921504901095424;
            val_22 = 1152921511451249552;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1745532016) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_4 = IsVideoAvailable();
        }
        
        }
        
        if(this.freeCoinButtonText == 0)
        {
                return;
        }
        
        val_22 = 1152921511026388688;
        WordPets.WPTDataParser val_5 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if(rewardVideoCapReached != false)
        {
                WordPets.WPTDataParser val_7 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            System.DateTime val_8 = offsetServerTime;
            int val_11 = val_9.Hour;
            val_11 = 23 - val_11;
            string val_12 = val_11.ToString(format:  -1827641632);
            int val_13 = val_9.Minute;
            val_13 = 60 - val_13;
            string val_14 = val_13.ToString(format:  -1827641632);
            int val_15 = val_9.Second;
            val_15 = 60 - val_15;
            string val_16 = val_15.ToString(format:  -1827641632);
            string val_17 = System.String.Format(format:  -1687058320, arg0:  -38702548, arg1:  -38702548, arg2:  -38702548);
            string val_18 = Localization.Localize(key:  -38727216, defaultValue:  -38727104, useSingularKey:  false);
            string val_19 = System.String.Format(format:  -524018304, arg0:  -1687058320, arg1:  -38727216);
            val_21 = "{1} {0}";
            val_23 = 0;
        }
        else
        {
                string val_20 = Localization.Localize(key:  -38722800, defaultValue:  -38722896, useSingularKey:  false);
            val_21 = "get_free_coins_upper";
            val_23 = 1;
        }
        
        this.Button_FreeHint.interactable = true;
    }
    private void OnEnable()
    {
        var val_7;
        System.Action<System.Boolean> val_8;
        val_7 = 1152921504901095424;
        val_8 = 1152921511299501312;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1897280256) == 0)
        {
            goto label_5;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_8 = null;
        val_8 = new System.Action<System.Boolean>(object:  -38552896, method:  new IntPtr(4256389376));
        System.Delegate val_5 = System.Delegate.Combine(a:  public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_7 = public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C;
        if(val_7 != 0)
        {
                if(val_7 == null)
        {
            goto label_11;
        }
        
        }
        
        val_7 = 0;
        label_11:
        public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C = val_7;
        label_5:
        NotificationCenter val_6 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -38552896, name:  2128120864);
    }
    private void Start()
    {
        UnityEngine.Transform val_1 = this.transform;
        object val_2 = this.GetComponent<System.Object>();
        if((UnityEngine.Object.op_Implicit(exists:  -38439872)) == true)
        {
                return;
        }
        
        goto R4 + 236;
    }
    public virtual void InitWithTag(HeyZapAdTag tag, string eventName, CurrencyRewardType rt = 0)
    {
        this.initFreeCointEvent = eventName;
        this.initTag = tag;
        this.curRewType = rt;
    }
    public void UpdateGoldenGalaOverlay()
    {
        this.galaRewardOverlay.SetActive(value:  GoldenGalaHandler.dailyChallengeApple.IsSubscriptionActive ^ 1);
    }
    protected virtual void SetUp()
    {
        var val_53;
        UnityEngine.UI.Text val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        decimal val_60;
        var val_61;
        var val_62;
        var val_63;
        decimal val_64;
        var val_65;
        var val_66;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        mem2[0] = ;
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        typeof(System.Object[]).__il2cppRuntimeField_14 = this.initFreeCointEvent;
        UnityEngine.Debug.LogWarningFormat(format:  -38091008, args:  472754880);
        System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  -38037888, method:  new IntPtr(4256035920));
        this.Button_FreeHint.OnConnectionClick = null;
        this.Button_FreeHint.interactable = true;
        this.group_start.SetActive(value:  true);
        this.group_success.SetActive(value:  false);
        this.group_sorry.SetActive(value:  false);
        UnityEngine.CanvasRenderer val_2 = this.message_thankYou.canvasRenderer;
        this.message_thankYou.SetAlpha(alpha:  null);
        Player val_3 = App.Player;
        if(188 < 1)
        {
            goto label_22;
        }
        
        if(188 != 1)
        {
            goto label_23;
        }
        
        GameEcon val_5 = App.getGameEcon;
        if(0 != 0)
        {
            goto label_31;
        }
        
        goto label_31;
        label_22:
        GameEcon val_6 = App.getGameEcon;
        if(0 != 0)
        {
            goto label_31;
        }
        
        goto label_31;
        label_23:
        GameEcon val_7 = App.getGameEcon;
        label_31:
        this.reward = 1m;
        mem[1152921513158743820] = 1919184449;
        mem[1152921513158743824] = 6580591;
        mem[1152921513158743828] = 19;
        GameBehavior val_8 = App.getBehavior;
        if(0 != 0)
        {
                decimal val_10 = System.Decimal.op_Explicit(value:  WADPetsManager.GetLevelCurveModifier(ability:  4));
            mem[1152921513158743700].SetActive(value:  System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10}));
        }
        
        string val_12 = Localization.Localize(key:  -38066112, defaultValue:  -38066272, useSingularKey:  false);
        decimal val_13 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -38049976, hi = mem[this.reward + (0)], lo = mem[this.reward + (4)], mid = mem[this.reward + (8)]}, d2:  new System.Decimal() {flags = mem[this.reward + (12)], hi = this.petsReward, mid = this});
        GameEcon val_14 = App.getGameEcon;
        string val_15 = ToString(format:  null);
        string val_16 = System.String.Format(format:  -38066112, arg0:  -38049944);
        val_54 = this.desc_text;
        val_55 = 1152921504765685760;
        if(mem[1152921513158743764] != 0)
        {
                val_54 = mem[1152921513158743764];
            val_53 = 0;
            UnityEngine.Vector3 val_18 = position;
            mem[1152921513158743760].position = new UnityEngine.Vector3();
        }
        
        if((mem[1152921513158743756] + 24) != 0)
        {
                mem[1152921513158743756] + 24.SetActive(value:  false);
        }
        
        if(mem[1152921513158743804] != 0)
        {
                mem[1152921513158743804].enabled = false;
        }
        
        val_56 = 0;
        if(mem[1152921513158743804] == 0)
        {
            goto label_77;
        }
        
        GameEcon val_22 = App.getGameEcon;
        val_57 = 3748210;
        val_56 = 0;
        val_53 = 0;
        val_56 = val_56;
        val_57 = val_57;
        if(((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = 3748210}, d2:  new System.Decimal() {flags = 1, hi = 1919184449, lo = 6580591, mid = 19})) == false) || (this.initTag != 4))
        {
            goto label_77;
        }
        
        val_58 = null;
        val_58 = null;
        if(WGFreeHintPopup.dailyCollected == false)
        {
            goto label_77;
        }
        
        mem[1152921513158743852] = 18;
        val_59 = null;
        val_59 = null;
        mem[1152921513158743860] = Events.AD_SEEN_REW_VID_DB;
        GameEcon val_24 = App.getGameEcon;
        string val_25 = Localization.Localize(key:  -38066112, defaultValue:  -38066272, useSingularKey:  false);
        GameEcon val_26 = App.getGameEcon;
        string val_27 = ToString(format:  null);
        val_60 = this.reward;
        val_61 = val_61;
        val_60 = val_60;
        decimal val_28 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -38049976, hi = 1, lo = 1919184449, mid = 6580591}, d2:  new System.Decimal() {flags = 19, mid = mem[1152921513158743840]});
        GameEcon val_29 = App.getGameEcon;
        string val_30 = ToString(format:  null);
        string val_31 = System.String.Format(format:  1592589744, arg0:  -38049960, arg1:  -38049944);
        string val_32 = System.String.Format(format:  -38066112, arg0:  1592589744);
        GameEcon val_33 = App.getGameEcon;
        string val_34 = ToString(format:  null);
        System.Collections.IEnumerator val_35 = this.SetStrkeOutLinePos_coroutine(textToStrike:  -38049960);
        UnityEngine.Coroutine val_36 = this.StartCoroutine(routine:  -38037888);
        mem[1152921513158743804].enabled = true;
        val_62 = null;
        val_62 = null;
        WGFreeHintPopup.dailyCollected = false;
        goto label_95;
        label_77:
        mem[1152921513158743852] = this.initTag;
        mem[1152921513158743860] = this.initFreeCointEvent;
        val_63 = null;
        val_63 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = R5, hi = R6, lo = R7, mid = SL}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                string val_38 = Localization.Localize(key:  -38066112, defaultValue:  -38066272, useSingularKey:  false);
            GameEcon val_39 = App.getGameEcon;
            string val_40 = new System.Decimal().ToString(format:  null);
            val_65 = val_65;
            val_64 = val_64;
            decimal val_41 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -38049976, hi = 1, lo = 1919184449, mid = 6580591}, d2:  new System.Decimal() {flags = 19, hi = mem[1152921513158743832]});
            GameEcon val_42 = App.getGameEcon;
            string val_43 = ToString(format:  null);
            string val_44 = System.String.Format(format:  1592589744, arg0:  -38037752, arg1:  -38049944);
            string val_45 = System.String.Format(format:  -38066112, arg0:  1592589744);
            GameEcon val_46 = App.getGameEcon;
            string val_47 = new System.Decimal().ToString(format:  null);
            System.Collections.IEnumerator val_48 = this.SetStrkeOutLinePos_coroutine(textToStrike:  -38037752);
            UnityEngine.Coroutine val_49 = this.StartCoroutine(routine:  -38037888);
            mem[1152921513158743804].enabled = true;
        }
        
        label_95:
        val_66 = mem[1152921513158743820];
        val_66 = val_66;
        decimal val_50 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -38049976, hi = 1, lo = 1919184449, mid = 6580591}, d2:  new System.Decimal() {flags = 19, hi = mem[1152921513158743832], lo = mem[1152921513158743836], mid = mem[1152921513158743840]});
        GameEcon val_51 = App.getGameEcon;
        string val_52 = ToString(format:  null);
        if(mem[1152921513158743776] != 0)
        {
                return;
        }
    
    }
    protected void SetStrikeOutLinePos(string textToStrike)
    {
        System.Collections.IEnumerator val_1 = this.SetStrkeOutLinePos_coroutine(textToStrike:  textToStrike);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -37889024);
    }
    private System.Collections.IEnumerator SetStrkeOutLinePos_coroutine(string textToStrike)
    {
        if((new WGFreeHintPopup.<SetStrkeOutLinePos_coroutine>d__51(<>1__state:  0)) != 0)
        {
                typeof(WGFreeHintPopup.<SetStrkeOutLinePos_coroutine>d__51).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        typeof(WGFreeHintPopup.<SetStrkeOutLinePos_coroutine>d__51).__il2cppRuntimeField_14 = textToStrike;
    }
    public void OnFreeHintClick(bool result)
    {
        HeyZapAdTag val_11;
        var val_13;
        var val_14;
        System.Collections.Hashtable val_15;
        var val_16;
        if(result == false)
        {
            goto label_1;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(IsVideoAvailable() == false)
        {
            goto label_5;
        }
        
        if(this.isMinigameWindow == false)
        {
            goto label_6;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_11 = this.currTag;
        bool val_5 = ShowIncentivizedVideo(heyZapAdTag:  val_11);
        goto label_10;
        label_1:
        System.Collections.Hashtable val_6 = null;
        val_13 = val_6;
        val_6 = new System.Collections.Hashtable();
        val_14 = null;
        val_15 = null;
        val_16 = "noconnection";
        goto label_13;
        label_5:
        System.Collections.Hashtable val_7 = null;
        val_13 = val_7;
        val_7 = new System.Collections.Hashtable();
        val_14 = null;
        val_15 = null;
        val_16 = "unavailable";
        label_13:
        Notification val_8 = new Notification(aSender:  -37636160, aName:  2128120864, aData:  75878400);
        return;
        label_6:
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_11 = this.currTag;
        bool val_10 = ShowIncentivizedVideo(tag:  val_11, adCapExempt:  false);
        label_10:
        if(val_10 == false)
        {
                val_10 = 1;
            this.state = val_10;
        }
        
        this.Button_FreeHint.interactable = false;
        this.Button_FreeHint.interactable = true;
    }
    public virtual void OnVideoResponse(Notification notif)
    {
        UnityEngine.GameObject val_20;
        var val_21;
        UnityEngine.GameObject val_22;
        var val_23;
        UnityEngine.UI.Text val_24;
        var val_25;
        var val_26;
        System.Action<System.Boolean> val_27;
        string val_1 = notif.data.ToString();
        bool val_2 = System.Boolean.Parse(value:  notif.data);
        this.group_start.SetActive(value:  false);
        this.group_success.SetActive(value:  val_2);
        this.Button_CollectHint.interactable = val_2;
        val_20 = this.group_sorry;
        val_20.SetActive(value:  val_2 ^ 1);
        if(val_2 == false)
        {
            goto label_10;
        }
        
        if(GoldenGalaHandler.dailyChallengeApple == null)
        {
            goto label_12;
        }
        
        val_21 = GoldenGalaHandler.dailyChallengeApple ^ 1;
        goto label_13;
        label_10:
        val_22 = 1152921504765685760;
        val_20 = this.sorry_message;
        if(val_20 == 0)
        {
                return;
        }
        
        val_20 = this.sorry_button_text;
        if(val_20 == 0)
        {
                return;
        }
        
        val_20 = this.sorry_banner_text;
        if(val_20 == 0)
        {
                return;
        }
        
        if(notif.data == 0)
        {
            goto label_25;
        }
        
        string val_7 = Localization.Localize(key:  -598573744, defaultValue:  -598573648, useSingularKey:  false);
        string val_8 = Localization.Localize(key:  -598573536, defaultValue:  -598573408, useSingularKey:  false);
        val_23 = "video_unavailable_explanation";
        val_24 = this.sorry_button_text;
        val_25 = "TRY AGAIN";
        val_26 = "try_again_upper";
        goto label_28;
        label_12:
        val_21 = 0;
        label_13:
        this.regularRewardGroup.SetActive(value:  val_21 ^ 1);
        val_22 = this.galaRewardGroup;
        if(val_22 != 0)
        {
                val_22 = this.galaRewardGroup;
            val_22.SetActive(value:  false);
        }
        
        if(val_21 == 0)
        {
                return;
        }
        
        this.SetupGalaRewards();
        return;
        label_25:
        if(notif.data == 0)
        {
            goto label_35;
        }
        
        string val_11 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_12 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        string val_13 = Localization.Localize(key:  -1827175552, defaultValue:  -425598240, useSingularKey:  false);
        System.Action<System.Boolean> val_14 = new System.Action<System.Boolean>(object:  -37407728, method:  new IntPtr(4256035920));
        System.Delegate val_15 = System.Delegate.Remove(source:  this.Button_WatchAnother.OnConnectionClick, value:  7401472);
        val_27 = this.Button_WatchAnother.OnConnectionClick;
        if(val_27 != 0)
        {
                if(null == null)
        {
            goto label_42;
        }
        
        }
        
        val_27 = 0;
        label_42:
        this.Button_WatchAnother.OnConnectionClick = val_27;
        UnityEngine.Events.UnityAction val_16 = new UnityEngine.Events.UnityAction(object:  -37407728, method:  new IntPtr(4257525632));
        this.Button_WatchAnother.AddListener(call:  162246656);
        return;
        label_35:
        string val_17 = Localization.Localize(key:  -37440544, defaultValue:  -37440640, useSingularKey:  false);
        string val_18 = Localization.Localize(key:  -37436160, defaultValue:  -37436336, useSingularKey:  false);
        val_23 = "wgfreehintpopup_message";
        val_24 = this.sorry_button_text;
        val_25 = "WATCH ANOTHER";
        val_26 = "watch_another_upper";
        label_28:
        string val_19 = Localization.Localize(key:  -37431840, defaultValue:  -37431936, useSingularKey:  false);
        if(val_24 == 0)
        {
            
        }
    
    }
    private void SetupGalaRewards()
    {
        UnityEngine.Vector3 val_1 = position;
        this.coinSource.position = new UnityEngine.Vector3();
        float val_8 = 6.46438E-38f;
        this.coinsAnim.coinExpansionEnabled = false;
        val_8 = 7317068 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        this.galaRewardOverlay.SetActive(value:  GoldenGalaHandler.dailyChallengeApple.IsSubscriptionActive ^ 1);
        GameEcon val_4 = App.getGameEcon;
        string val_5 = this.reward.ToString(format:  null);
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        GameEcon val_6 = App.getGameEcon;
        string val_7 = ToString(format:  null);
        if(this.gala_bonus_coin_amount != 0)
        {
                return;
        }
    
    }
    private void OnSubscriptionPurchaseAttempt(bool success)
    {
        this.galaRewardOverlay.SetActive(value:  GoldenGalaHandler.dailyChallengeApple.IsSubscriptionActive ^ 1);
    }
    public virtual void OnCollectClicked()
    {
        int val_16;
        int val_17;
        var val_18;
        int val_20;
        int val_21;
        decimal val_22;
        int val_23;
        int val_24;
        var val_25;
        int val_26;
        int val_27;
        GridCoinCollectAnimationInstantiator val_28;
        string val_29;
        var val_30;
        var val_31;
        this.Button_CollectHint.interactable = false;
        val_17 = 1152921504614301696;
        System.Action val_1 = new System.Action(object:  -36869488, method:  typeof(WGFreeHintPopup).__il2cppRuntimeField_F0);
        this.coinsAnim.OnCompleteCallback = null;
        if(this.coinsAnim != 0)
        {
                mem2[0] = 0;
        }
        
        if((System.String.op_Equality(a:  this.currFreeCoinEvent, b:  -36923696)) != false)
        {
                typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            UnityEngine.Debug.LogErrorFormat(format:  -36915408, args:  472754880);
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        val_18 = 1152921504617017344;
        Add(key:  -2092883952, value:  10170368);
        if(GoldenGalaHandler.dailyChallengeApple == null)
        {
            goto label_26;
        }
        
        if(GoldenGalaHandler.dailyChallengeApple.IsSubscriptionActive == false)
        {
            goto label_35;
        }
        
        System.Action val_6 = new System.Action(object:  -36869488, method:  new IntPtr(4258056272));
        this.coinsAnim.OnCompleteCallback = null;
        val_21 = R3;
        val_20 = R2;
        val_17 = GoldenGalaHandler.dailyChallengeApple + 44;
        decimal val_7 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -36881552, hi = this.reward, lo = val_20, mid = val_21}, d2:  new System.Decimal() {flags = ???, hi = GoldenGalaHandler.dailyChallengeApple + 32, lo = GoldenGalaHandler.dailyChallengeApple + 36, mid = GoldenGalaHandler.dailyChallengeApple + 40});
        val_18 = 1152921504617017344;
        Add(key:  -98560688, value:  10170368);
        goto label_35;
        label_26:
        label_35:
        GameBehavior val_8 = App.getBehavior;
        if(0 != 0)
        {
                Add(key:  -36910000, value:  10170368);
            val_22 = this.reward;
            val_24 = ???;
            val_25 = IP;
            val_23 = ???;
            val_22 = val_22;
            decimal val_9 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -36881568, hi = val_22, lo = val_23, mid = val_24}, d2:  new System.Decimal() {mid = val_17});
        }
        
        Player val_10 = App.Player;
        val_29 = this.currFreeCoinEvent;
        0.AddCredits(amount:  new System.Decimal() {flags = mem[this.reward + (0)], hi = mem[this.reward + (4)], lo = mem[this.reward + (8)], mid = -36881568}, source:  val_29, subSource:  0, externalParams:  null, doTrack:  true);
        if(this.coinsAnim == 0)
        {
                return;
        }
        
        Player val_12 = App.Player;
        val_30 = 52;
        val_31 = 256;
        val_31 = val_31;
        val_30 = val_30;
        decimal val_13 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -36881552, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256, hi = this.reward, lo = val_29});
        Player val_14 = App.Player;
        decimal val_15 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -36881568, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
        val_28 = this.coinsAnim;
        val_27 = GoldenGalaHandler.dailyChallengeApple + 32;
        val_26 = GoldenGalaHandler.dailyChallengeApple + 36;
        val_28.Play(fromValue:  new System.Decimal() {flags = PurchaseProxy.currentPurchasePoint, mid = val_16}, toValue:  new System.Decimal() {flags = val_27, hi = val_26, lo = GoldenGalaHandler.dailyChallengeApple + 40, mid = val_17}, textTickTime:  null, delayBeforeComplete:  null);
        if(this.hideTextWhileCollecting == false)
        {
                return;
        }
        
        this.message_thankYou.CrossFadeAlpha(alpha:  null, duration:  null, ignoreTimeScale:  false);
    }
    private void OnGalaRewardButtonClicked()
    {
        var val_22;
        var val_23;
        var val_24;
        System.Action val_26;
        System.Action val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_32;
        var val_20 = 28306855;
        val_20 = 7320268 + val_20;
        if(val_20 == 0)
        {
                mem2[0] = 1;
        }
        
        val_22 = GoldenGalaHandler.dailyChallengeApple.IsSubscriptionActive;
        UnityEngine.GameObject val_2 = this.gameObject;
        object val_3 = this.GetComponent<System.Object>();
        if(val_22 == false)
        {
            goto label_4;
        }
        
        if((-36710384) == 0)
        {
            goto label_7;
        }
        
        GameBehavior val_7 = App.getBehavior;
        val_23 = 1152921504995770368;
        val_24 = null;
        val_24 = null;
        val_26 = WGFreeHintPopup.<>c.<>9__58_0;
        if(val_26 == 0)
        {
                val_26 = null;
            val_26 = new System.Action(object:  WGFreeHintPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4258230864));
            WGFreeHintPopup.<>c.<>9__58_0 = val_26;
        }
        
        mem[32] = val_26;
        goto label_18;
        label_4:
        val_28 = null;
        if((-36710384) == 0)
        {
            goto label_21;
        }
        
        GameBehavior val_11 = App.getBehavior;
        val_23 = 4;
        val_30 = null;
        val_30 = null;
        val_27 = WGFreeHintPopup.<>c.<>9__58_1;
        if(val_27 == 0)
        {
                val_27 = null;
            val_27 = new System.Action(object:  WGFreeHintPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4258231888));
            WGFreeHintPopup.<>c.<>9__58_1 = val_27;
        }
        
        val_32 = val_23;
        System.Delegate val_14 = System.Delegate.Combine(a:  4, b:  7454720);
        if(val_32 != 0)
        {
                if(65793 == null)
        {
            goto label_33;
        }
        
        }
        
        val_32 = 0;
        label_33:
        mem[204] = val_32;
        val_26 = 7321232 + 28305892;
        if(val_26 == 0)
        {
                mem2[0] = 1;
        }
        
        WGSubscriptionManager._subEntryPoint = 68;
        label_18:
        UnityEngine.GameObject val_15 = this.gameObject;
        SLCWindow.CloseWindow(window:  -36710384, setDestroyOnDisableState:  true, dontDestroyOnDisable:  true);
        return;
        label_7:
        GameBehavior val_16 = App.getBehavior;
        val_29 = mem[(1179403647 + (public WGGoldenGalaInfoPopup MetaGameBehavior::ShowUGUIFlyOut<WGGoldenGalaInfoPopup>().__il2cppRuntimeField_28) << 3) + 192];
        val_29 = (1179403647 + (public WGGoldenGalaInfoPopup MetaGameBehavior::ShowUGUIFlyOut<WGGoldenGalaInfoPopup>().__il2cppRuntimeField_28) << 3) + 192;
        val_28 = 0;
        goto (1179403647 + (public WGGoldenGalaInfoPopup MetaGameBehavior::ShowUGUIFlyOut<WGGoldenGalaInfoPopup>().__il2cppRuntimeField_28) << 3) + 192;
        label_21:
        GameBehavior val_18 = App.getBehavior;
        WGSubscriptionManager._subEntryPoint = 68;
    }
    private void PlayGalaCoinAnim()
    {
        int val_6;
        GridCoinCollectAnimationInstantiator val_7;
        var val_8;
        UnityEngine.Vector3 val_1 = position;
        this.coinSource.position = new UnityEngine.Vector3();
        val_7 = this.coinsAnim;
        System.Action val_2 = new System.Action(object:  -36582000, method:  typeof(WGFreeHintPopup).__il2cppRuntimeField_F0);
        this.coinsAnim.OnCompleteCallback = null;
        Player val_3 = App.Player;
        var val_7 = 28305115;
        val_7 = 7322008 + val_7;
        val_8 = 256;
        if(val_7 == 0)
        {
                val_7 = val_8;
            val_8 = val_7;
            mem2[0] = 1;
        }
        
        if(GoldenGalaHandler.dailyChallengeApple == null)
        {
                val_8 = val_8;
        }
        
        val_8 = val_8;
        decimal val_4 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -36594064, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256, hi = mem[R8 + (0)], lo = mem[R8 + (4)], mid = mem[R8 + (8)]});
        Player val_5 = App.Player;
        this.coinsAnim.Play(fromValue:  new System.Decimal() {mid = val_6}, toValue:  new System.Decimal() {flags = 52}, textTickTime:  val_1.x, delayBeforeComplete:  val_1.y);
    }
    private void OnApplicationPause(bool pause)
    {
        if(pause == true)
        {
                return;
        }
        
        this.Button_FreeHint.interactable = true;
    }
    protected virtual void CloseSorry()
    {
        this.group_start.SetActive(value:  true);
        this.Button_FreeHint.interactable = true;
        this.group_success.SetActive(value:  false);
        this.group_sorry.SetActive(value:  false);
    }
    protected virtual void Close(bool dontDestroyMonolith)
    {
        System.Action val_6 = 35628176;
        if(this.isMinigameWindow != true)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_6 = public static AdsUIController MonoSingleton<AdsUIController>::get_Instance();
            if((UnityEngine.Object.op_Implicit(exists:  2124183120)) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_6 = public static AdsUIController MonoSingleton<AdsUIController>::get_Instance();
            SawFreeHint();
        }
        
        }
        
        if(this.OnClose != 0)
        {
                val_6 = 0;
            this.OnClose.Invoke();
            this.OnClose = val_6;
        }
        
        UnityEngine.GameObject val_5 = this.gameObject;
        SLCWindow.CloseWindow(window:  -36184560, setDestroyOnDisableState:  true, dontDestroyOnDisable:  dontDestroyMonolith);
    }
    public virtual void OnDisable()
    {
        var val_7;
        System.Action<System.Boolean> val_8;
        val_7 = 1152921504901095424;
        val_8 = 1152921511299501312;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1897280256) == 0)
        {
            goto label_5;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_8 = null;
        val_8 = new System.Action<System.Boolean>(object:  -36068464, method:  new IntPtr(4256389376));
        System.Delegate val_5 = System.Delegate.Remove(source:  public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C, value:  7401472);
        val_7 = public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C;
        if(val_7 != 0)
        {
                if(val_7 == null)
        {
            goto label_11;
        }
        
        }
        
        val_7 = 0;
        label_11:
        public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C = val_7;
        label_5:
        NotificationCenter val_6 = NotificationCenter.DefaultCenter;
        0.RemoveObserver(observer:  -36068464, name:  2128120864);
    }
    public WGFreeHintPopup()
    {
        this.initFreeCointEvent = "un-initialized";
        this.currFreeCoinEvent = "un-initialized";
        this._isMinigameWindow = 0;
    }
    private static WGFreeHintPopup()
    {
    
    }
    private void <Awake>b__42_0()
    {
        goto typeof(WGFreeHintPopup).__il2cppRuntimeField_10C;
    }
    private void <OnVideoResponse>b__54_0()
    {
        goto typeof(WGFreeHintPopup).__il2cppRuntimeField_10C;
    }

}
