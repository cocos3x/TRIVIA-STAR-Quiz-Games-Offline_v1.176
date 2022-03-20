using UnityEngine;
[Serializable]
public class WGEventButton : MonoBehaviour
{
    // Fields
    public UGUINetworkedButton event_button;
    public UnityEngine.UI.Image button_prefix;
    public UnityEngine.UI.Text event_text;
    public UnityEngine.UI.Image event_icon;
    public UnityEngine.UI.Button LeftButton;
    public UnityEngine.UI.Button RightButton;
    public UnityEngine.GameObject opposingButton;
    public UnityEngine.GameObject eventsCointainer;
    public UnityEngine.UI.Text eventsCounter;
    public float defaultIconWidth;
    public float defaultTextWidth;
    public UnityEngine.Sprite lcMenuSprite;
    public UnityEngine.Sprite ecMenuSprite;
    public UnityEngine.Sprite wwMenuSprite;
    public UnityEngine.Sprite pcMenuSprite;
    public UnityEngine.Sprite ccCvCMenuSprite;
    public UnityEngine.Sprite apMenuSprite;
    public UnityEngine.Sprite pbMenuSprite;
    public UnityEngine.Sprite pb2MenuSprite;
    public UnityEngine.Sprite lbdMenuSprite;
    public UnityEngine.Sprite lwMenuSprite;
    public UnityEngine.Sprite wordHuntMenuSprite;
    public UnityEngine.Sprite superStreakMenuSprite;
    public UnityEngine.Sprite hotStreakMenuSprite;
    public UnityEngine.Sprite vipPartyMenuSprite;
    public UnityEngine.Sprite ggMenuSprite;
    public UnityEngine.Sprite lightningLevelsMenuSprite;
    public UnityEngine.Sprite hintManiaSprite;
    public UnityEngine.Sprite onTheTrailSprite;
    public UnityEngine.Sprite keyToRichesSprite;
    public UnityEngine.Sprite bingoSprite;
    public UnityEngine.Sprite bavSprite;
    public UnityEngine.Sprite superBundleSprite;
    public UnityEngine.Sprite piggyBankRaidMenuSprite;
    public UnityEngine.Sprite seasonPassSprite;
    public UnityEngine.Sprite snakesAndLaddersMenuSprite;
    public UnityEngine.Sprite islandParadiseSprite;
    public UnityEngine.Sprite spinKingMenuSprite;
    public UnityEngine.Sprite attackMadnessMenuSprite;
    public UnityEngine.Sprite raidMadnessMenuSprite;
    public UnityEngine.Sprite forestMasterMenuSprite;
    public UnityEngine.Sprite letterBankMenuSprite;
    public UnityEngine.Sprite forestFrenzySprite;
    public UnityEngine.Sprite prgressiveIAPSprite;
    protected int CurrentEventIndex;
    protected WGEventHandler currentEventHandler;
    protected bool showingAllEventsButton;
    
    // Methods
    protected virtual void Awake()
    {
        System.Delegate val_10;
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -298247088, name:  -1649709888);
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -298247088, name:  -1649709760);
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -298247088, name:  1799422256);
        this.event_button.RemoveAllListeners();
        System.Action<System.Boolean> val_4 = new System.Action<System.Boolean>(object:  -298247088, method:  typeof(WGEventButton).__il2cppRuntimeField_F8);
        val_10 = this.event_button.OnConnectionClick;
        System.Delegate val_5 = System.Delegate.Combine(a:  val_10, b:  7401472);
        if(val_10 != 0)
        {
                if(null == null)
        {
            goto label_10;
        }
        
        }
        
        val_10 = 0;
        label_10:
        this.event_button.OnConnectionClick = val_10;
        if(this.LeftButton == 0)
        {
                return;
        }
        
        if(this.RightButton == 0)
        {
                return;
        }
        
        UnityEngine.Events.UnityAction val_8 = new UnityEngine.Events.UnityAction(object:  -298247088, method:  typeof(WGEventButton).__il2cppRuntimeField_E8);
        this.LeftButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_9 = new UnityEngine.Events.UnityAction(object:  -298247088, method:  typeof(WGEventButton).__il2cppRuntimeField_F0);
        this.RightButton.m_OnClick.AddListener(call:  162246656);
    }
    protected virtual void PrevEvent()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_4 = GetCurrentEventsCount + 1;
        float val_5 = UnityEngine.Mathf.Repeat(t:  (float)this.CurrentEventIndex - 1, length:  null);
        this.CurrentEventIndex = (float)this.CurrentEventIndex - 1;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_7 = GetCurrentEventsCount;
        val_7 = val_7 - 2139095040;
        val_7 = val_7 >> 5;
        this.showingAllEventsButton = val_7;
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  -298098224);
    }
    protected virtual void NextEvent()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_4 = GetCurrentEventsCount + 1;
        float val_5 = UnityEngine.Mathf.Repeat(t:  (float)this.CurrentEventIndex + 1, length:  null);
        this.CurrentEventIndex = (float)this.CurrentEventIndex + 1;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_7 = GetCurrentEventsCount;
        val_7 = val_7 - 2139095040;
        val_7 = val_7 >> 5;
        this.showingAllEventsButton = val_7;
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  -297986224);
    }
    private void OnEnable()
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(routine:  -297874224);
    }
    protected virtual void OnClick(bool result)
    {
        WGEventHandler val_5;
        var val_6;
        val_5 = 35627986;
        if(this.showingAllEventsButton != false)
        {
                GameBehavior val_1 = App.getBehavior;
            var val_5 = 28410995;
            val_5 = 7214796 + val_5;
            if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
            val_6 = null;
            val_6 = null;
            AmplitudePluginHelper.lastFeatureAccessPoint = 47;
            return;
        }
        
        if((this.currentEventHandler == 0) || (this.currentEventHandler != 0))
        {
            goto label_12;
        }
        
        val_5 = this.currentEventHandler;
        if(val_5 == 0)
        {
            goto label_14;
        }
        
        label_12:
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  -297749936);
        return;
        label_14:
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PlayingChallenge = false;
        if(this.currentEventHandler == 0)
        {
            
        }
    
    }
    private void OnGameEventControllerUpdate()
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(routine:  -297625648);
    }
    private void OnGameEventHandlerProgress()
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(routine:  -297513648);
    }
    private void OnLocalize()
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(routine:  -297401648);
    }
    protected void UpdateDisplay()
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(routine:  -297289648);
    }
    protected virtual System.Collections.IEnumerator UpdateDisplayDelayed()
    {
        object val_1 = new System.Object();
        typeof(WGEventButton.<UpdateDisplayDelayed>d__56).__il2cppRuntimeField_8 = 0;
        typeof(WGEventButton.<UpdateDisplayDelayed>d__56).__il2cppRuntimeField_10 = this;
    }
    protected void SetButtonContent(WGEventHandler evtHandler)
    {
        UnityEngine.UI.Image val_50;
        UnityEngine.Sprite val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        this.event_text.lineSpacing = null;
        this.event_text.fontSize = 0;
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        bool val_3 = 0.Equals(value:  1800251696);
        if(val_3 == false)
        {
                "en" = 40;
        }
        
        if(val_3 == true)
        {
                "en" = 48;
        }
        
        this.event_text.resizeTextMaxSize = 48;
        UnityEngine.Color val_4 = UnityEngine.Color.white;
        this.button_prefix.color = new UnityEngine.Color() {a = ???};
        var val_50 = 28412132;
        val_50 = 7215888 + val_50;
        if(val_50 == 0)
        {
                mem2[0] = 1;
        }
        
        if(evtHandler.myEvent != 0)
        {
                "" = evtHandler.myEvent.type;
        }
        
        uint val_5 = _PrivateImplementationDetails_.ComputeStringHash(s:  mem[evtHandler.myEvent.type]);
        if(val_5 > 1592546639)
        {
            goto label_12;
        }
        
        if(val_5 > 701935430)
        {
            goto label_13;
        }
        
        if(val_5 > 264778422)
        {
            goto label_14;
        }
        
        if(val_5 > 145907821)
        {
            goto label_15;
        }
        
        if(val_5 == 54006602)
        {
            goto label_16;
        }
        
        if((val_5 != 145907821) || ((System.String.op_Equality(a:  mem[evtHandler.myEvent.type], b:  -1266461296)) == false))
        {
            goto label_161;
        }
        
        this.button_prefix.sprite = this.islandParadiseSprite;
        this.button_prefix.preserveAspect = true;
        this.event_text.lineSpacing = val_4.r;
        goto label_22;
        label_12:
        if(val_5 > 3165936380)
        {
            goto label_23;
        }
        
        if(val_5 > 2763165661)
        {
            goto label_24;
        }
        
        if(val_5 > 2600860205)
        {
            goto label_25;
        }
        
        if(val_5 == 2337712501)
        {
            goto label_26;
        }
        
        if((val_5 != 2600860205) || ((System.String.op_Equality(a:  mem[evtHandler.myEvent.type], b:  -1266462688)) == false))
        {
            goto label_161;
        }
        
        this.button_prefix.sprite = this.pb2MenuSprite;
        this.button_prefix.preserveAspect = true;
        UnityEngine.RectTransform val_8 = this.button_prefix.rectTransform;
        UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  val_4.r, y:  val_4.g);
        this.button_prefix.sizeDelta = new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
        UnityEngine.GameObject val_10 = this.button_prefix.gameObject;
        this.button_prefix.SetActive(value:  true);
        this.event_text.lineSpacing = val_4.r;
        goto label_102;
        label_13:
        if(val_5 > 1188660454)
        {
            goto label_37;
        }
        
        if(val_5 > 999457290)
        {
            goto label_38;
        }
        
        if(val_5 == 958660756)
        {
            goto label_39;
        }
        
        if((val_5 != 999457290) || ((System.String.op_Equality(a:  mem[evtHandler.myEvent.type], b:  -1549997168)) == false))
        {
            goto label_161;
        }
        
        val_50 = this.button_prefix;
        val_51 = this.attackMadnessMenuSprite;
        goto label_42;
        label_23:
        if(val_5 > 3275071436)
        {
            goto label_43;
        }
        
        if(val_5 > 3244402182)
        {
            goto label_44;
        }
        
        if(val_5 == 3193092183)
        {
            goto label_45;
        }
        
        if((val_5 != 3244402182) || ((System.String.op_Equality(a:  mem[evtHandler.myEvent.type], b:  -1425319472)) == false))
        {
            goto label_161;
        }
        
        this.button_prefix.sprite = this.forestMasterMenuSprite;
        val_52 = 0;
        this.button_prefix.preserveAspect = true;
        UnityEngine.RectTransform val_13 = this.button_prefix.rectTransform;
        val_53 = this.button_prefix;
        val_54 = 17126;
        val_54 = 1122369536;
        goto label_51;
        label_14:
        if(val_5 > 655166938)
        {
            goto label_52;
        }
        
        if(val_5 == 386644468)
        {
            goto label_53;
        }
        
        if((val_5 != 655166938) || ((System.String.op_Equality(a:  mem[evtHandler.myEvent.type], b:  -1266461392)) == false))
        {
            goto label_161;
        }
        
        this.button_prefix.sprite = this.spinKingMenuSprite;
        this.button_prefix.preserveAspect = true;
        UnityEngine.RectTransform val_15 = this.button_prefix.rectTransform;
        UnityEngine.Vector2 val_16 = new UnityEngine.Vector2(x:  val_4.r, y:  val_4.g);
        this.button_prefix.sizeDelta = new UnityEngine.Vector2() {x = val_16.x, y = val_16.y};
        UnityEngine.GameObject val_17 = this.button_prefix.gameObject;
        this.button_prefix.SetActive(value:  true);
        if(this.event_text != 0)
        {
            goto label_145;
        }
        
        goto label_145;
        label_24:
        if(val_5 > 2864846394)
        {
            goto label_64;
        }
        
        if(val_5 == 2845304644)
        {
            goto label_65;
        }
        
        if((val_5 != 2864846394) || ((System.String.op_Equality(a:  mem[evtHandler.myEvent.type], b:  -1266462192)) == false))
        {
            goto label_161;
        }
        
        goto label_126;
        label_37:
        if(val_5 > 1399814793)
        {
            goto label_69;
        }
        
        if(val_5 == 1314484049)
        {
            goto label_70;
        }
        
        if((val_5 != 1399814793) || ((System.String.op_Equality(a:  mem[evtHandler.myEvent.type], b:  -1648557216)) == false))
        {
            goto label_161;
        }
        
        goto label_126;
        label_43:
        if(val_5 > 3671570374)
        {
            goto label_74;
        }
        
        if(val_5 == 3531375042)
        {
            goto label_75;
        }
        
        if((val_5 != 3671570374) || ((System.String.op_Equality(a:  mem[evtHandler.myEvent.type], b:  -1298907488)) == false))
        {
            goto label_161;
        }
        
        val_50 = this.button_prefix;
        val_51 = this.raidMadnessMenuSprite;
        label_42:
        val_50.sprite = val_51;
        this.button_prefix.preserveAspect = true;
        UnityEngine.RectTransform val_21 = this.button_prefix.rectTransform;
        goto label_122;
        label_15:
        if(val_5 == 231953039)
        {
            goto label_82;
        }
        
        if((val_5 != 264778422) || ((System.String.op_Equality(a:  mem[evtHandler.myEvent.type], b:  -1266462992)) == false))
        {
            goto label_161;
        }
        
        goto label_126;
        label_25:
        if(val_5 == 2664185753)
        {
            goto label_86;
        }
        
        if((val_5 != 2763165661) || ((System.String.op_Equality(a:  mem[evtHandler.myEvent.type], b:  -1298907888)) == false))
        {
            goto label_161;
        }
        
        goto label_162;
        label_38:
        if(val_5 == 1054264077)
        {
            goto label_90;
        }
        
        if((val_5 != 1188660454) || ((System.String.op_Equality(a:  mem[evtHandler.myEvent.type], b:  -1266462400)) == false))
        {
            goto label_161;
        }
        
        goto label_162;
        label_44:
        if(val_5 == 3251312870)
        {
            goto label_94;
        }
        
        if((val_5 != 3275071436) || ((System.String.op_Equality(a:  mem[evtHandler.myEvent.type], b:  -1266462880)) == false))
        {
            goto label_161;
        }
        
        this.button_prefix.sprite = this.lbdMenuSprite;
        UnityEngine.GameObject val_26 = this.button_prefix.gameObject;
        this.button_prefix.SetActive(value:  true);
        this.event_text.fontSize = 48;
        goto label_102;
        label_52:
        if(val_5 == 697097638)
        {
            goto label_103;
        }
        
        if((val_5 != 701935430) || ((System.String.op_Equality(a:  mem[evtHandler.myEvent.type], b:  -1322387776)) == false))
        {
            goto label_161;
        }
        
        goto label_126;
        label_64:
        if(val_5 == 2902602938)
        {
            goto label_107;
        }
        
        if((val_5 != 3165936380) || ((System.String.op_Equality(a:  mem[evtHandler.myEvent.type], b:  -1298909328)) == false))
        {
            goto label_161;
        }
        
        goto label_162;
        label_69:
        if(val_5 == 1537055809)
        {
            goto label_111;
        }
        
        if((val_5 != 1592546639) || ((System.String.op_Equality(a:  mem[evtHandler.myEvent.type], b:  -1266461904)) == false))
        {
            goto label_161;
        }
        
        goto label_147;
        label_74:
        if(val_5 == 3764625999)
        {
            goto label_115;
        }
        
        if(val_5 == 4210228650)
        {
            goto label_116;
        }
        
        if((val_5 != 4241560753) || ((System.String.op_Equality(a:  mem[evtHandler.myEvent.type], b:  -1298908160)) == false))
        {
            goto label_161;
        }
        
        this.button_prefix.sprite = this.ccCvCMenuSprite;
        this.button_prefix.preserveAspect = true;
        UnityEngine.RectTransform val_31 = this.button_prefix.rectTransform;
        goto label_122;
        label_16:
        if((System.String.op_Equality(a:  mem[evtHandler.myEvent.type], b:  -1321166448)) == false)
        {
            goto label_161;
        }
        
        goto label_162;
        label_26:
        if((System.String.op_Equality(a:  mem[evtHandler.myEvent.type], b:  -1298907104)) == false)
        {
            goto label_161;
        }
        
        goto label_126;
        label_39:
        if((System.String.op_Equality(a:  mem[evtHandler.myEvent.type], b:  -1266462784)) == false)
        {
            goto label_161;
        }
        
        this.button_prefix.sprite = this.vipPartyMenuSprite;
        val_55 = 0;
        this.button_prefix.preserveAspect = true;
        UnityEngine.RectTransform val_35 = this.button_prefix.rectTransform;
        val_56 = this.button_prefix;
        val_57 = 17106;
        val_57 = 1121058816;
        goto label_131;
        label_45:
        if((System.String.op_Equality(a:  mem[evtHandler.myEvent.type], b:  -1266462592)) == false)
        {
            goto label_161;
        }
        
        this.button_prefix.sprite = this.ggMenuSprite;
        this.button_prefix.preserveAspect = true;
        UnityEngine.RectTransform val_37 = this.button_prefix.rectTransform;
        goto label_136;
        label_53:
        if((System.String.op_Equality(a:  mem[evtHandler.myEvent.type], b:  -1298908064)) == false)
        {
            goto label_161;
        }
        
        this.button_prefix.sprite = this.bingoSprite;
        val_55 = 0;
        this.button_prefix.preserveAspect = true;
        UnityEngine.RectTransform val_39 = this.button_prefix.rectTransform;
        val_56 = this.button_prefix;
        val_57 = 17076;
        val_57 = 1119092736;
        label_131:
        UnityEngine.Vector2 val_40 = new UnityEngine.Vector2(x:  val_4.r, y:  val_4.g);
        val_56.sizeDelta = new UnityEngine.Vector2() {x = val_40.x, y = val_40.y};
        UnityEngine.GameObject val_41 = this.button_prefix.gameObject;
        this.button_prefix.SetActive(value:  true);
        if(this.event_text != 0)
        {
            goto label_145;
        }
        
        goto label_145;
        label_65:
        if((System.String.op_Equality(a:  mem[evtHandler.myEvent.type], b:  -1266461696)) == false)
        {
            goto label_161;
        }
        
        goto label_147;
        label_70:
        if((System.String.op_Equality(a:  mem[evtHandler.myEvent.type], b:  -1298908816)) == false)
        {
            goto label_161;
        }
        
        this.button_prefix.sprite = this.seasonPassSprite;
        this.button_prefix.preserveAspect = true;
        UnityEngine.RectTransform val_44 = this.button_prefix.rectTransform;
        UnityEngine.Vector2 val_45 = new UnityEngine.Vector2(x:  val_4.r, y:  val_4.g);
        this.button_prefix.sizeDelta = new UnityEngine.Vector2() {x = val_45.x, y = val_45.y};
        this.event_text.resizeTextMaxSize = 42;
        goto label_154;
        label_75:
        if((System.String.op_Equality(a:  mem[evtHandler.myEvent.type], b:  -1266461808)) == false)
        {
            goto label_161;
        }
        
        this.button_prefix.sprite = this.snakesAndLaddersMenuSprite;
        val_52 = 0;
        this.button_prefix.preserveAspect = true;
        UnityEngine.RectTransform val_47 = this.button_prefix.rectTransform;
        val_53 = this.button_prefix;
        val_54 = 17086;
        val_54 = 1119748096;
        label_51:
        UnityEngine.Vector2 val_48 = new UnityEngine.Vector2(x:  val_4.r, y:  val_4.g);
        val_53.sizeDelta = new UnityEngine.Vector2() {x = val_48.x, y = val_48.y};
        goto label_160;
        label_82:
        if((System.String.op_Equality(a:  mem[evtHandler.myEvent.type], b:  -1342036480)) != false)
        {
            
        }
    
    }
    public WGEventButton()
    {
        this.defaultIconWidth = 105f;
        this.defaultTextWidth = 400f;
    }

}
