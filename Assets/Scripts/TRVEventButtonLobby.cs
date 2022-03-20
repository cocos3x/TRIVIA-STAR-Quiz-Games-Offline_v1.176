using UnityEngine;
public class TRVEventButtonLobby : MonoBehaviour
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
    private UnityEngine.Sprite crazyCategoriesIcon;
    private UnityEngine.Sprite triviaMastersIcon;
    private UnityEngine.Sprite starChampionshipIcon;
    private UnityEngine.Sprite triviaPursuitIcon;
    private UnityEngine.Sprite leaderboardIcon;
    public UnityEngine.Sprite pbMenuSprite;
    private UnityEngine.Sprite youBetchaIcon;
    private UnityEngine.Sprite progressiveIAPIcon;
    private int CurrentEventIndex;
    private WGEventHandler currentEventHandler;
    private bool showingAllEventsButton;
    
    // Methods
    private void Awake()
    {
        System.Action<System.Boolean> val_10;
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -529895408, name:  -1649709888);
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -529895408, name:  -1649709760);
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -529895408, name:  1799422256);
        this.event_button.RemoveAllListeners();
        System.Action<System.Boolean> val_4 = new System.Action<System.Boolean>(object:  -529895408, method:  new IntPtr(3765020240));
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
        
        UnityEngine.Events.UnityAction val_8 = new UnityEngine.Events.UnityAction(object:  -529895408, method:  new IntPtr(3765037648));
        this.LeftButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_9 = new UnityEngine.Events.UnityAction(object:  -529895408, method:  new IntPtr(3765046864));
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
        val_11 = 35637869;
        if(this.showingAllEventsButton == false)
        {
            goto label_1;
        }
        
        GameBehavior val_1 = App.getBehavior;
        val_12 = 12314200 + 23311591;
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
        val_16 = TRVEventButtonLobby.<>c.<>9__26_0;
        if(val_16 == 0)
        {
                val_16 = null;
            val_16 = new System.Action(object:  TRVEventButtonLobby.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3765553232));
            TRVEventButtonLobby.<>c.<>9__26_0 = val_16;
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
        System.Collections.IEnumerator val_1 = this.UpdateDisplayAfterDelay();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -529016176);
    }
    private System.Collections.IEnumerator UpdateDisplayAfterDelay()
    {
        object val_1 = new System.Object();
        typeof(TRVEventButtonLobby.<UpdateDisplayAfterDelay>d__30).__il2cppRuntimeField_8 = 0;
        typeof(TRVEventButtonLobby.<UpdateDisplayAfterDelay>d__30).__il2cppRuntimeField_10 = this;
    }
    public void UpdateDisplay()
    {
        int val_51;
        var val_52;
        WGEventHandler val_53;
        var val_54;
        var val_55;
        UnityEngine.UI.Image val_56;
        if(this.categorySelectPopupEventBar != false)
        {
                UnityEngine.GameObject val_1 = this.gameObject;
            val_51 = 1152921511127380480;
            object val_2 = this.GetComponent<System.Object>();
            if((-528661104) != 0)
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
        
        val_52 = this;
        val_53 = this.currentEventHandler;
        if(val_53 != 0)
        {
            goto label_28;
        }
        
        label_100:
        label_27:
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_51 = this.CurrentEventIndex;
        val_53 = public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance();
        WGEventHandler val_15 = GetOrderedEventHandlersByIndex(index:  val_51);
        val_52 = this;
        this.currentEventHandler = val_53;
        if(val_53 == 0)
        {
            goto label_32;
        }
        
        label_28:
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
        
        val_54 = 0;
        if(this.eventsCounter != 0)
        {
                string val_21 = Localization.Localize(key:  -1286775296, defaultValue:  -1286775392, useSingularKey:  false);
        }
        
        if(this.showingAllEventsButton == false)
        {
            goto label_53;
        }
        
        UnityEngine.GameObject val_22 = this.button_prefix.gameObject;
        this.button_prefix.SetActive(value:  false);
        string val_23 = Localization.Localize(key:  -1648606576, defaultValue:  -1648606688, useSingularKey:  false);
        this.event_text.resizeTextMaxSize = 65;
        this.iconTextLayout.childAlignment = 5;
        UnityEngine.RectTransform val_24 = this.event_text.rectTransform;
        UnityEngine.Vector2 val_25 = new UnityEngine.Vector2(x:  null, y:  null);
        this.event_text.sizeDelta = new UnityEngine.Vector2() {x = val_25.x, y = val_25.y};
        goto label_60;
        label_53:
        UnityEngine.RectTransform val_26 = this.button_prefix.rectTransform;
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.one;
        this.button_prefix.localScale = new UnityEngine.Vector3() {x = val_25.x, y = val_25.y};
        this.iconTextLayout.childAlignment = 4;
        UnityEngine.RectTransform val_28 = this.event_text.rectTransform;
        UnityEngine.Vector2 val_29 = new UnityEngine.Vector2(x:  val_27.x, y:  val_27.y);
        this.event_text.sizeDelta = new UnityEngine.Vector2() {x = val_29.x, y = val_29.y};
        this.iconTextLayout.spacing = val_27.x;
        this.iconTextLayout.left = 10;
        string val_30 = EventType;
        uint val_31 = _PrivateImplementationDetails_.ComputeStringHash(s:  -2101040096);
        if(val_31 > 2109769660)
        {
            goto label_71;
        }
        
        if(val_31 > 1054264077)
        {
            goto label_72;
        }
        
        if(val_31 == 813111565)
        {
            goto label_73;
        }
        
        if((val_31 != 1054264077) || ((System.String.op_Equality(a:  -2101040096, b:  -1648524352)) == false))
        {
            goto label_135;
        }
        
        this.button_prefix.sprite = this.progressiveIAPIcon;
        UnityEngine.Color val_33 = new UnityEngine.Color(r:  val_27.x, g:  val_27.y, b:  val_27.z);
        this.button_prefix.color = new UnityEngine.Color() {r = val_33.r, g = val_33.g, b = val_33.b, a = val_33.a};
        UnityEngine.GameObject val_34 = this.button_prefix.gameObject;
        this.button_prefix.SetActive(value:  true);
        this.event_text.fontSize = 56;
        this.event_text.resizeTextMaxSize = 56;
        this.button_prefix.preserveAspect = true;
        UnityEngine.RectTransform val_35 = this.button_prefix.rectTransform;
        UnityEngine.Vector3 val_36 = new UnityEngine.Vector3(x:  val_27.x, y:  val_27.y, z:  val_27.z);
        this.button_prefix.localScale = new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z};
        this.iconTextLayout.spacing = val_27.x;
        if(this.iconTextLayout != 0)
        {
            goto label_123;
        }
        
        goto label_123;
        label_71:
        if(val_31 > 3409954492)
        {
            goto label_89;
        }
        
        if(val_31 == 2673580851)
        {
            goto label_90;
        }
        
        if(val_31 == 3275071436)
        {
            goto label_91;
        }
        
        if((val_31 != 3409954492) || ((System.String.op_Equality(a:  -2101040096, b:  -1266461600)) == false))
        {
            goto label_135;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_38 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_55 = public static TRVUtils MonoSingleton<TRVUtils>::get_Instance();
        UnityEngine.Sprite val_39 = GetCategoryIcon(category:  TRVSpecialCategoriesEventHandler.EVENT_TRACKING_ID + 32);
        val_56 = this.button_prefix;
        goto label_99;
        label_32:
        if(this.CurrentEventIndex != 0)
        {
            goto label_100;
        }
        
        label_10:
        UnityEngine.GameObject val_40 = this.event_button.gameObject;
        this.event_button.SetActive(value:  false);
        if(this.categorySelectPopupEventBar == false)
        {
            goto label_103;
        }
        
        UnityEngine.GameObject val_41 = this.gameObject;
        if(this != 0)
        {
            goto label_105;
        }
        
        label_106:
        label_105:
        this.SetActive(value:  false);
        return;
        label_103:
        if(this.eventsCointainer != 0)
        {
            goto label_105;
        }
        
        goto label_106;
        label_72:
        if(val_31 == 1399814793)
        {
            goto label_107;
        }
        
        if(val_31 == 2102096662)
        {
            goto label_108;
        }
        
        if((val_31 != 2109769660) || ((System.String.op_Equality(a:  -2101040096, b:  -575491712)) == false))
        {
            goto label_135;
        }
        
        val_56 = this.button_prefix;
        val_55 = this.currentEventHandler;
        label_99:
        val_56.sprite = -2101040096;
        UnityEngine.Color val_43 = new UnityEngine.Color(r:  val_27.x, g:  val_27.y, b:  val_27.z);
        this.button_prefix.color = new UnityEngine.Color() {r = val_43.r, g = val_43.g, b = val_43.b, a = val_43.a};
        this.button_prefix.preserveAspect = true;
        UnityEngine.RectTransform val_44 = this.button_prefix.rectTransform;
        UnityEngine.Vector2 val_45 = new UnityEngine.Vector2(x:  val_27.x, y:  val_27.y);
        this.button_prefix.sizeDelta = new UnityEngine.Vector2() {x = val_45.x, y = val_45.y};
        this.event_text.resizeTextMaxSize = 52;
        UnityEngine.GameObject val_46 = this.button_prefix.gameObject;
        this.button_prefix.SetActive(value:  true);
        this.iconTextLayout.spacing = val_27.x;
        if(this.iconTextLayout != 0)
        {
            goto label_123;
        }
        
        goto label_123;
        label_89:
        if(val_31 == 3548535312)
        {
            goto label_124;
        }
        
        if(val_31 == 4137344480)
        {
            goto label_125;
        }
        
        if((val_31 != 3988837984) || ((System.String.op_Equality(a:  -2101040096, b:  -1648577792)) == false))
        {
            goto label_135;
        }
        
        this.button_prefix.sprite = this.bigQuizIcon;
        UnityEngine.Color val_48 = new UnityEngine.Color(r:  val_27.x, g:  val_27.y, b:  val_27.z);
        this.button_prefix.color = new UnityEngine.Color() {r = val_48.r, g = val_48.g, b = val_48.b, a = val_48.a};
        this.event_text.resizeTextMaxSize = 65;
        UnityEngine.GameObject val_49 = this.button_prefix.gameObject;
        this.button_prefix.SetActive(value:  true);
        goto label_134;
        label_73:
        if((System.String.op_Equality(a:  -2101040096, b:  -1298909536)) != false)
        {
            
        }
    
    }
    public TRVEventButtonLobby()
    {
    
    }

}
