using UnityEngine;
public class FPHEventLobbyButton : MonoBehaviour
{
    // Fields
    public UGUINetworkedButton event_button;
    public UnityEngine.UI.Image button_prefix;
    public UnityEngine.UI.Text event_text;
    public UnityEngine.UI.Image event_icon;
    public UnityEngine.UI.Button LeftButton;
    public UnityEngine.UI.Button RightButton;
    public UnityEngine.GameObject eventsCointainer;
    public UnityEngine.UI.Text eventsCounter;
    public UnityEngine.UI.HorizontalLayoutGroup iconTextLayout;
    private bool categorySelectPopupEventBar;
    private UnityEngine.Sprite bigQuizIcon;
    public UnityEngine.Sprite pbMenuSprite;
    private UnityEngine.Sprite progressiveIAPIcon;
    private int CurrentEventIndex;
    private WGEventHandler currentEventHandler;
    private bool showingAllEventsButton;
    
    // Methods
    private void Awake()
    {
        System.Action<System.Boolean> val_10;
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1649645696, name:  -1649709888);
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1649645696, name:  -1649709760);
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1649645696, name:  1799422256);
        this.event_button.RemoveAllListeners();
        System.Action<System.Boolean> val_4 = new System.Action<System.Boolean>(object:  -1649645696, method:  new IntPtr(2645269952));
        System.Delegate val_5 = System.Delegate.Combine(a:  this.event_button.OnConnectionClick, b:  7401472);
        val_10 = this.event_button.OnConnectionClick;
        if(val_10 != 0)
        {
                if(null == null)
        {
            goto label_11;
        }
        
        }
        
        val_10 = 0;
        label_11:
        this.event_button.OnConnectionClick = val_10;
        if(this.LeftButton == 0)
        {
                return;
        }
        
        if(this.RightButton == 0)
        {
                return;
        }
        
        UnityEngine.Events.UnityAction val_8 = new UnityEngine.Events.UnityAction(object:  -1649645696, method:  new IntPtr(2645287360));
        this.LeftButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_9 = new UnityEngine.Events.UnityAction(object:  -1649645696, method:  new IntPtr(2645296576));
        this.RightButton.m_OnClick.AddListener(call:  162246656);
    }
    private void PrevEvent()
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
        this.UpdateDisplay();
    }
    private void NextEvent()
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
        this.UpdateDisplay();
    }
    private void OnEnable()
    {
        this.UpdateDisplay();
    }
    private void OnClick(bool result)
    {
        WGEventHandler val_11;
        var val_12;
        var val_13;
        var val_14;
        System.Action val_16;
        System.Delegate val_17;
        val_11 = 35639230;
        if(this.showingAllEventsButton == false)
        {
            goto label_1;
        }
        
        GameBehavior val_1 = App.getBehavior;
        val_12 = 13222544 + 22403247;
        if(val_12 == 0)
        {
                mem2[0] = 1;
        }
        
        val_13 = null;
        val_13 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 47;
        if(this.categorySelectPopupEventBar == false)
        {
                return;
        }
        
        label_36:
        val_12 = 1152921511021137168;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = GetWindow<System.Object>();
        if(2119322896 == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_7 = GetWindow<System.Object>();
        UnityEngine.GameObject val_8 = gameObject;
        SLCWindow.CloseWindow(window:  2119322896, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        return;
        label_1:
        if(this.categorySelectPopupEventBar == false)
        {
            goto label_22;
        }
        
        if((this.currentEventHandler == 0) || (this.currentEventHandler != 0))
        {
            goto label_38;
        }
        
        val_11 = this.currentEventHandler;
        if(val_11 != 0)
        {
            goto label_38;
        }
        
        val_14 = null;
        val_14 = null;
        val_16 = FPHEventLobbyButton.<>c.<>9__20_0;
        if(val_16 == 0)
        {
                val_16 = null;
            val_16 = new System.Action(object:  FPHEventLobbyButton.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2645804992));
            FPHEventLobbyButton.<>c.<>9__20_0 = val_16;
        }
        
        val_17 = this.currentEventHandler.OnMyPopupWasClosed_action;
        System.Delegate val_10 = System.Delegate.Combine(a:  val_17, b:  7454720);
        if(val_17 != 0)
        {
                if(null == null)
        {
            goto label_35;
        }
        
        }
        
        val_17 = 0;
        label_35:
        this.currentEventHandler.OnMyPopupWasClosed_action = val_17;
        goto label_36;
        label_22:
        if((this.currentEventHandler == 0) || (this.currentEventHandler != 0))
        {
            goto label_38;
        }
        
        val_11 = this.currentEventHandler;
        if(val_11 == 0)
        {
            goto label_40;
        }
        
        label_38:
        this.UpdateDisplay();
        return;
        label_40:
        if(this.currentEventHandler == 0)
        {
            
        }
    
    }
    private void OnGameEventControllerUpdate()
    {
        this.UpdateDisplay();
    }
    private void OnGameEventHandlerProgress()
    {
        this.UpdateDisplay();
    }
    private void OnLocalize()
    {
        this.UpdateDisplay();
    }
    public void UpdateDisplay()
    {
        int val_44;
        var val_45;
        var val_46;
        WGEventHandler val_47;
        var val_48;
        float val_49;
        var val_50;
        UnityEngine.Sprite val_51;
        if(this.categorySelectPopupEventBar != false)
        {
                UnityEngine.GameObject val_1 = this.gameObject;
            val_44 = 1152921511127380480;
            object val_2 = this.GetComponent<System.Object>();
            if((-1648446992) != 0)
        {
                UnityEngine.GameObject val_4 = this.gameObject;
            object val_5 = this.GetComponent<System.Object>();
            this.alpha = null;
        }
        
        }
        
        if(WordGameEventsController.EventsEnabled == false)
        {
            goto label_10;
        }
        
        UnityEngine.GameObject val_7 = this.event_text.gameObject;
        this.event_text.SetActive(value:  true);
        val_45 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((GetCurrentEventsCount >= 2) && (this.LeftButton != 0))
        {
                if(this.RightButton != 0)
        {
                UnityEngine.GameObject val_12 = this.LeftButton.gameObject;
            this.LeftButton.SetActive(value:  true);
            UnityEngine.GameObject val_13 = this.RightButton.gameObject;
            this.RightButton.SetActive(value:  true);
        }
        
        }
        
        if(this.showingAllEventsButton == false)
        {
            goto label_27;
        }
        
        val_46 = this;
        val_47 = this.currentEventHandler;
        if(val_47 != 0)
        {
            goto label_28;
        }
        
        label_86:
        label_27:
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_44 = this.CurrentEventIndex;
        val_47 = public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance();
        WGEventHandler val_15 = GetOrderedEventHandlersByIndex(index:  val_44);
        val_48 = this;
        this.currentEventHandler = val_47;
        if(val_47 == 0)
        {
            goto label_32;
        }
        
        label_28:
        val_49 = 1152921504765685760;
        if(((-2101040096) != 0) && (this.showingAllEventsButton != true))
        {
                this.button_prefix.sprite = -2101040096;
            this.button_prefix.enabled = true;
            UnityEngine.GameObject val_17 = this.button_prefix.gameObject;
            this.button_prefix.SetActive(value:  true);
        }
        
        UnityEngine.GameObject val_18 = this.event_button.gameObject;
        this.event_button.SetActive(value:  true);
        if(this.eventsCointainer != 0)
        {
                this.eventsCointainer.SetActive(value:  true);
        }
        
        val_50 = 0;
        bool val_20 = UnityEngine.Object.op_Inequality(x:  this.eventsCounter, y:  0);
        if(this.showingAllEventsButton != false)
        {
                UnityEngine.GameObject val_21 = this.button_prefix.gameObject;
            this.button_prefix.SetActive(value:  false);
            string val_22 = Localization.Localize(key:  -1648606576, defaultValue:  -1648606688, useSingularKey:  false);
            this.event_text.resizeTextMaxSize = 65;
            val_51 = 0;
            this.iconTextLayout.childAlignment = 5;
            UnityEngine.RectTransform val_23 = this.event_text.rectTransform;
            UnityEngine.Vector2 val_24 = new UnityEngine.Vector2(x:  null, y:  null);
            this.event_text.sizeDelta = new UnityEngine.Vector2() {x = val_24.x, y = val_24.y};
            return;
        }
        
        UnityEngine.RectTransform val_25 = this.button_prefix.rectTransform;
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.one;
        this.button_prefix.localScale = new UnityEngine.Vector3();
        this.iconTextLayout.childAlignment = 4;
        UnityEngine.RectTransform val_27 = this.event_text.rectTransform;
        UnityEngine.Vector2 val_28 = new UnityEngine.Vector2(x:  val_26.x, y:  val_26.y);
        this.event_text.sizeDelta = new UnityEngine.Vector2() {x = val_28.x, y = val_28.y};
        this.iconTextLayout.spacing = val_26.x;
        UnityEngine.Color val_29 = UnityEngine.Color.white;
        this.button_prefix.color = new UnityEngine.Color() {r = val_24.x, g = val_24.y, a = ???};
        string val_30 = EventType;
        val_51 = this.currentEventHandler;
        if((System.String.op_Equality(a:  -2101040096, b:  -1648577792)) == false)
        {
            goto label_70;
        }
        
        val_51 = this.bigQuizIcon;
        this.button_prefix.sprite = val_51;
        this.event_text.resizeTextMaxSize = 65;
        UnityEngine.GameObject val_32 = this.button_prefix.gameObject;
        this.button_prefix.SetActive(value:  true);
        goto label_93;
        label_70:
        if((System.String.op_Equality(a:  -2101040096, b:  -1648557216)) == false)
        {
            goto label_77;
        }
        
        this.button_prefix.sprite = this.pbMenuSprite;
        this.event_text.resizeTextMaxSize = 56;
        UnityEngine.GameObject val_34 = this.button_prefix.gameObject;
        val_51 = 0;
        this.button_prefix.SetActive(value:  true);
        UnityEngine.RectTransform val_35 = this.button_prefix.rectTransform;
        UnityEngine.Vector3 val_36 = new UnityEngine.Vector3(x:  val_29.r, y:  val_29.g, z:  val_29.b);
        this.button_prefix.localScale = new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z};
        goto label_93;
        label_32:
        if(this.CurrentEventIndex != 0)
        {
            goto label_86;
        }
        
        label_10:
        UnityEngine.GameObject val_37 = this.event_button.gameObject;
        this.event_button.SetActive(value:  false);
        if(this.categorySelectPopupEventBar == false)
        {
            goto label_89;
        }
        
        UnityEngine.GameObject val_38 = this.gameObject;
        if(this != 0)
        {
            goto label_91;
        }
        
        label_92:
        label_91:
        this.SetActive(value:  false);
        return;
        label_89:
        if(this.eventsCointainer != 0)
        {
            goto label_91;
        }
        
        goto label_92;
        label_77:
        if((System.String.op_Equality(a:  -2101040096, b:  -1648524352)) != false)
        {
                this.button_prefix.sprite = this.progressiveIAPIcon;
            UnityEngine.Color val_40 = new UnityEngine.Color(r:  val_29.r, g:  val_29.g, b:  val_29.b);
            this.button_prefix.color = new UnityEngine.Color() {r = val_40.r, g = val_40.g, b = val_40.b, a = val_49};
            UnityEngine.GameObject val_41 = this.button_prefix.gameObject;
            this.button_prefix.SetActive(value:  true);
            this.event_text.fontSize = 56;
            this.event_text.resizeTextMaxSize = 56;
            val_51 = 0;
            this.button_prefix.preserveAspect = true;
            UnityEngine.RectTransform val_42 = this.button_prefix.rectTransform;
            UnityEngine.Vector3 val_43 = new UnityEngine.Vector3(x:  val_29.r, y:  val_29.g, z:  val_29.b);
            this.button_prefix.localScale = new UnityEngine.Vector3() {x = val_43.x, y = val_43.y, z = val_43.z};
            this.iconTextLayout.spacing = val_29.r;
            this.iconTextLayout.left = 30;
        }
        
        label_93:
        this.event_text.fontSize = 0;
    }
    public FPHEventLobbyButton()
    {
    
    }

}
