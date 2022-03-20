using UnityEngine;
public class WGSettingsPopup : MonoBehaviour
{
    // Fields
    private GridCoinCollectAnimationInstantiator coinsAnim;
    private UnityEngine.UI.Text titleText;
    private UnityEngine.UI.Button Button_Rate;
    private UnityEngine.UI.Button Button_NoAds;
    private UnityEngine.GameObject adsOn;
    private UnityEngine.GameObject adsOff;
    private UnityEngine.UI.Button Button_Home;
    private UnityEngine.UI.Button Button_Help;
    private UnityEngine.UI.Button Button_HowToPlay;
    private UnityEngine.UI.Button Button_Quit;
    private UnityEngine.UI.Button Button_Languages;
    private UnityEngine.GameObject topGrid;
    private UnityEngine.GameObject midGrid;
    private UnityEngine.GameObject bottomGrid;
    private UGUINetworkedButton Button_FbConnect;
    private UGUINetworkedButton Button_FbShare;
    private UnityEngine.GameObject FbConnectRewardGroup;
    private UnityEngine.UI.Text FbConnectRewardAmount;
    private UnityEngine.UI.Text version_info;
    private UnityEngine.UI.Text supportId_text;
    private UnityEngine.GameObject ChallengeGroup;
    private UnityEngine.GameObject[] sun_groups;
    private UnityEngine.GameObject[] moon_groups;
    private UnityEngine.UI.Text challenge_number_text;
    private UGUINetworkedButton challenge_Button;
    private UnityEngine.Color sunTextColor;
    private UnityEngine.Color moonTextColor;
    private UnityEngine.UI.Outline challenge_number_text_outline;
    private UnityEngine.Color sunTextOutlineColor;
    private UnityEngine.Color moonTextOutlineColor;
    private UnityEngine.RectTransform parentXfm;
    private bool isFbCherry;
    
    // Methods
    private void OnEnable()
    {
        var val_43;
        bool val_44;
        UnityEngine.RectTransform val_45;
        if(SceneDictator.IsInGameScene() != false)
        {
                GameEcon val_3 = App.getGameEcon;
            string val_4 = 0.titleFormat;
            string val_5 = Localization.Localize(key:  14453136, defaultValue:  14453232, useSingularKey:  false);
            string val_6 = System.String.Format(format:  null, arg0:  14453136);
            if((UnityEngine.Object.op_Implicit(exists:  this.Button_HowToPlay)) != false)
        {
                UnityEngine.Transform val_8 = this.Button_HowToPlay.transform;
            UnityEngine.Transform val_9 = this.midGrid.transform;
            this.Button_HowToPlay.SetParent(p:  this.midGrid);
        }
        
            UnityEngine.GameObject val_10 = this.Button_Home.gameObject;
            this.Button_Home.SetActive(value:  true);
            UnityEngine.GameObject val_11 = this.Button_Quit.gameObject;
            val_43 = 0;
        }
        else
        {
                GameEcon val_12 = App.getGameEcon;
            string val_13 = 0.titleFormat;
            string val_14 = Localization.Localize(key:  54369536, defaultValue:  54369632, useSingularKey:  false);
            string val_15 = System.String.Format(format:  null, arg0:  54369536);
            if((UnityEngine.Object.op_Implicit(exists:  this.Button_HowToPlay)) != false)
        {
                UnityEngine.Transform val_17 = this.Button_HowToPlay.transform;
            UnityEngine.Transform val_18 = this.topGrid.transform;
            this.Button_HowToPlay.SetParent(p:  this.topGrid);
        }
        
            UnityEngine.GameObject val_19 = this.Button_Home.gameObject;
            this.Button_Home.SetActive(value:  false);
            UnityEngine.GameObject val_20 = this.Button_Quit.gameObject;
            val_43 = 1;
        }
        
        this.Button_Quit.SetActive(value:  true);
        UnityEngine.GameObject val_21 = this.Button_Rate.gameObject;
        this.Button_Rate.SetActive(value:  false);
        string val_22 = DeviceIdPlugin.GetClientVersion();
        Player val_23 = App.Player;
        this.Button_Rate.interactable = WGReviewManager.CanShow;
        UnityEngine.GameObject val_25 = this.Button_NoAds.gameObject;
        val_44 = 0;
        this.Button_NoAds.SetActive(value:  AdsManager.ShowAdsControlButtons(fromSettings:  false));
        if(AdsManager.isInVideoCooldown != true)
        {
                val_44 = AdsManager.isInPurchaseCooldown ^ 1;
        }
        
        this.adsOff.SetActive(value:  val_44 ^ 1);
        this.adsOn.SetActive(value:  val_44);
        this.SetFacebookButtons();
        this.UpdateChallengeUI();
        if(this.parentXfm == 0)
        {
                UnityEngine.Transform val_31 = this.ChallengeGroup.transform;
            UnityEngine.Transform val_32 = this.ChallengeGroup.parent;
            object val_33 = this.ChallengeGroup.GetComponent<System.Object>();
            val_45 = this.ChallengeGroup;
            this.parentXfm = this.ChallengeGroup;
        }
        else
        {
                val_45 = this.parentXfm;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_34 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(2124183120 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_36 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            float val_37 = GetBannerAdHeight();
            float val_42 = 0.5f;
            val_42 = 2124183120 * val_42;
            UnityEngine.Vector3 val_38 = new UnityEngine.Vector3(x:  val_42, y:  null, z:  2124183120);
        }
        else
        {
                UnityEngine.Vector3 val_39 = UnityEngine.Vector3.zero;
        }
        
        val_45.localPosition = new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z};
        System.Collections.IEnumerator val_40 = this.UpdateLayout();
        UnityEngine.Coroutine val_41 = this.StartCoroutine(routine:  54455168);
    }
    private void Awake()
    {
        UGUINetworkedButton val_16;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  54745344, method:  new IntPtr(54637376));
        this.Button_Rate.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  54745344, method:  new IntPtr(54646592));
        this.Button_Home.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  54745344, method:  new IntPtr(54655808));
        this.Button_NoAds.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  54745344, method:  new IntPtr(54665024));
        this.Button_Help.m_OnClick.AddListener(call:  162246656);
        if((UnityEngine.Object.op_Implicit(exists:  this.Button_HowToPlay)) != false)
        {
                UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  54745344, method:  new IntPtr(54678336));
            this.Button_HowToPlay.m_OnClick.AddListener(call:  162246656);
        }
        
        UnityEngine.Events.UnityAction val_7 = new UnityEngine.Events.UnityAction(object:  54745344, method:  new IntPtr(54687552));
        this.Button_Quit.m_OnClick.AddListener(call:  162246656);
        System.Action<System.Boolean> val_8 = new System.Action<System.Boolean>(object:  54745344, method:  new IntPtr(54692672));
        this.Button_FbConnect.OnConnectionClick = null;
        val_16 = this.Button_FbShare;
        System.Action<System.Boolean> val_9 = new System.Action<System.Boolean>(object:  54745344, method:  new IntPtr(54697792));
        this.Button_FbShare.OnConnectionClick = null;
        if(this.Button_Languages != 0)
        {
                val_16 = null;
            val_16 = new UnityEngine.Events.UnityAction(object:  54745344, method:  new IntPtr(54711104));
            this.Button_Languages.m_OnClick.AddListener(call:  162246656);
        }
        
        NotificationCenter val_12 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  54745344, name:  -2005054624);
        NotificationCenter val_13 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  54745344, name:  -106451056);
        if(this.challenge_Button == 0)
        {
                return;
        }
        
        val_16 = this.challenge_Button;
        System.Action<System.Boolean> val_15 = new System.Action<System.Boolean>(object:  54745344, method:  new IntPtr(54720320));
        this.challenge_Button.OnConnectionClick = null;
    }
    private void OnFacebookPluginUpdate(Notification notification)
    {
        int val_8;
        float val_9;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_10;
        GridCoinCollectAnimationInstantiator val_11;
        int val_12;
        float val_13;
        if((this.isFbCherry != false) && (FacebookPlugin.IsLoggedIn != false))
        {
                this.isFbCherry = false;
            val_9 = 1152921504892043264;
            val_10 = 0;
            GameEcon val_2 = App.getGameEcon;
            val_11 = 0;
            val_12 = 0;
            val_13 = 0f;
            CurrencyController.CreditBalance(value:  new System.Decimal(), source:  "FB Connect Bonus", externalParams:  val_10, animated:  false);
            if(this.coinsAnim != 0)
        {
                System.Action val_4 = new System.Action(object:  54956672, method:  new IntPtr(54927552));
            this.coinsAnim.OnCompleteCallback = null;
            Player val_5 = App.Player;
            decimal val_6 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 54944620, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
            Player val_7 = App.Player;
            val_13 = 7.286752E-44f;
            val_11 = this.coinsAnim;
            val_11.Play(fromValue:  new System.Decimal() {mid = val_8}, toValue:  new System.Decimal() {flags = 52, hi = val_10, lo = val_12, mid = val_9}, textTickTime:  null, delayBeforeComplete:  null);
        }
        
        }
        
        this.SetFacebookButtons();
    }
    private void OnCoinsAnimFinished()
    {
    
    }
    private void SetFacebookButtons()
    {
        bool val_26;
        bool val_27;
        var val_28;
        UnityEngine.GameObject val_1 = this.Button_FbConnect.gameObject;
        this.Button_FbConnect.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.Button_FbShare.gameObject;
        this.Button_FbShare.SetActive(value:  false);
        Player val_3 = App.Player;
        this.isFbCherry = System.String.IsNullOrEmpty(value:  static_value_0028001C);
        GameBehavior val_5 = App.getBehavior;
        val_26 = 0;
        if(0 != 0)
        {
                val_26 = FacebookPlugin.TaskAvailable(taskToCheck:  1);
        }
        
        GameBehavior val_7 = App.getBehavior;
        val_27 = 0;
        if(0 != 0)
        {
                val_27 = FacebookPlugin.IsLoggedIn;
        }
        
        val_28 = 0;
        UnityEngine.GameObject val_9 = this.Button_FbConnect.gameObject;
        this.Button_FbConnect.SetActive(value:  val_26);
        if(val_26 != false)
        {
                if(this.isFbCherry == true)
        {
                val_28 = 1;
        }
        
        }
        
        this.FbConnectRewardGroup.SetActive(value:  true);
        GameEcon val_10 = App.getGameEcon;
        var val_26 = 0;
        val_26 = val_26 + 360;
        GameEcon val_11 = App.getGameEcon;
        string val_12 = val_26.ToString(format:  null);
        UnityEngine.GameObject val_13 = this.Button_FbShare.gameObject;
        this.Button_FbShare.SetActive(value:  val_27);
        UnityEngine.GameObject val_14 = this.Button_FbConnect.gameObject;
        if(this.Button_FbConnect.activeSelf == true)
        {
                return;
        }
        
        UnityEngine.GameObject val_16 = this.Button_FbShare.gameObject;
        if(this.Button_FbShare.activeSelf != false)
        {
                return;
        }
        
        if(this.Button_Languages != 0)
        {
                UnityEngine.GameObject val_19 = this.Button_Languages.gameObject;
            if(this.Button_Languages.activeSelf == true)
        {
                return;
        }
        
        }
        
        UnityEngine.Transform val_21 = this.Button_FbConnect.transform;
        UnityEngine.Transform val_22 = this.Button_FbConnect.parent;
        UnityEngine.GameObject val_23 = this.Button_FbConnect.gameObject;
        this.Button_FbConnect.SetActive(value:  false);
        System.Collections.IEnumerator val_24 = this.UpdateLayout();
        UnityEngine.Coroutine val_25 = this.StartCoroutine(routine:  55242112);
    }
    private System.Collections.IEnumerator UpdateLayout()
    {
        object val_1 = new System.Object();
        typeof(WGSettingsPopup.<UpdateLayout>d__37).__il2cppRuntimeField_8 = 0;
        typeof(WGSettingsPopup.<UpdateLayout>d__37).__il2cppRuntimeField_10 = this;
    }
    private void OnDailyChallengeDataUpdate()
    {
        this.UpdateChallengeUI();
    }
    private void UpdateChallengeUI()
    {
        var val_16;
        bool val_17;
        UnityEngine.GameObject val_18;
        var val_19;
        var val_20;
        UnityEngine.Color val_21;
        var val_23;
        val_16 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_17 = 0;
        if(FeatureAvailable != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_17 = 0;
            if((-2116505760) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_17 = 0;
            if(CurrentLanguageSupported() != false)
        {
                val_17 = 0;
            if(WGDailyChallengeManagerHelper.MorningChallengeAvailableNow() != true)
        {
                if(WGDailyChallengeManagerHelper.EveningChallengeAvailableNow() == false)
        {
            goto label_15;
        }
        
        }
        
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_17 = CurrentChallengeComplete() ^ 1;
        }
        
        }
        
        }
        
        label_15:
        val_18 = this.ChallengeGroup;
        val_19 = 0;
        val_18.SetActive(value:  val_17);
        if(val_17 == false)
        {
                return;
        }
        
        bool val_11 = WGDailyChallengeManagerHelper.MorningChallengeAvailableNow();
        goto label_21;
        label_26:
        UnityEngine.GameObject val_15 = this.sun_groups[val_19];
        val_15.SetActive(value:  val_11);
        val_20 = 1;
        label_21:
        if(val_20 < val_15)
        {
            goto label_26;
        }
        
        if(val_11 != false)
        {
                val_21 = this.sunTextColor;
            this.challenge_number_text.color = new UnityEngine.Color() {r = val_21, g = SL, b = 1.241516E-37f, a = this.sun_groups};
            if((UnityEngine.Object.op_Implicit(exists:  this.challenge_number_text_outline)) != false)
        {
                val_21 = this.sunTextOutlineColor;
            this.challenge_number_text_outline.effectColor = new UnityEngine.Color() {r = val_21, g = 3.246603E-38f, b = 1.241516E-37f, a = this.sun_groups};
        }
        
        }
        
        val_23 = 0;
        bool val_13 = WGDailyChallengeManagerHelper.EveningChallengeAvailableNow();
        goto label_33;
        label_38:
        UnityEngine.GameObject val_16 = this.moon_groups[val_23];
        val_16.SetActive(value:  val_13);
        val_23 = 1;
        label_33:
        val_18 = this.moon_groups;
        if(val_23 < val_16)
        {
            goto label_38;
        }
        
        if(val_13 == false)
        {
                return;
        }
        
        val_21 = this.moonTextColor;
        this.challenge_number_text.color = new UnityEngine.Color() {r = val_21, g = SL, b = 1.241516E-37f, a = val_18};
        if((UnityEngine.Object.op_Implicit(exists:  this.challenge_number_text_outline)) == false)
        {
                return;
        }
        
        this.challenge_number_text_outline.effectColor = new UnityEngine.Color() {r = mem[this.moonTextOutlineColor + (0)], g = mem[this.moonTextOutlineColor + (4)], b = mem[this.moonTextOutlineColor + (8)], a = this};
    }
    private void OnClick_Rate()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        UnityEngine.GameObject val_3 = this.gameObject;
        SLCWindow.CloseWindow(window:  56104832, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClick_NoAds()
    {
        var val_7;
        System.Action val_9;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        if(SceneDictator.IsInGameScene() == true)
        {
                2 = 13;
        }
        
        WGAdsControlPopup val_4 = InitEntryTag(tag:  13);
        val_7 = null;
        val_7 = null;
        val_9 = WGSettingsPopup.<>c.<>9__41_0;
        if(val_9 == 0)
        {
                val_9 = null;
            val_9 = new System.Action(object:  WGSettingsPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(56192832));
            WGSettingsPopup.<>c.<>9__41_0 = val_9;
        }
        
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_60 = val_9;
        UnityEngine.GameObject val_6 = this.gameObject;
        SLCWindow.CloseWindow(window:  56217856, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClick_Home()
    {
        GameBehavior val_1 = App.getBehavior;
        UnityEngine.GameObject val_2 = this.gameObject;
        SLCWindow.CloseWindow(window:  56329856, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClick_Help()
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        ShowFAQs();
    }
    private void OnClick_HowToPlay()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        UnityEngine.GameObject val_3 = this.gameObject;
        SLCWindow.CloseWindow(window:  56553856, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClick_Quit()
    {
        App.Quit();
    }
    private void OnClick_FbConnect(bool result)
    {
        var val_9;
        System.Func<System.Boolean> val_11;
        var val_12;
        if(result != false)
        {
                if((FacebookPlugin.TaskAvailable(taskToCheck:  1)) == false)
        {
                return;
        }
        
            TrackingComponent.CurrentIntent = 4;
            FacebookPlugin.PerformTask(task:  1);
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_3 = ShowUGUIMonolith<System.Object>(showNext:  false);
        string val_4 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_5 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_6 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_9 = null;
        val_9 = null;
        val_11 = WGSettingsPopup.<>c.<>9__46_0;
        if(val_11 == 0)
        {
                val_11 = null;
            val_11 = new System.Func<System.Boolean>(object:  WGSettingsPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(56753856));
            WGSettingsPopup.<>c.<>9__46_0 = val_11;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_11;
        val_12 = null;
        val_12 = null;
        SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        UnityEngine.GameObject val_8 = this.gameObject;
        SLCWindow.CloseWindow(window:  56778880, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClick_FbShare(bool result)
    {
        var val_9;
        System.Func<System.Boolean> val_11;
        var val_12;
        if(result != false)
        {
                WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            ShareDefault();
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_3 = ShowUGUIMonolith<System.Object>(showNext:  false);
        string val_4 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_5 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_6 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_9 = null;
        val_9 = null;
        val_11 = WGSettingsPopup.<>c.<>9__47_0;
        if(val_11 == 0)
        {
                val_11 = null;
            val_11 = new System.Func<System.Boolean>(object:  WGSettingsPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(56866880));
            WGSettingsPopup.<>c.<>9__47_0 = val_11;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_11;
        val_12 = null;
        val_12 = null;
        SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        UnityEngine.GameObject val_8 = this.gameObject;
        SLCWindow.CloseWindow(window:  56891904, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClick_Challenge()
    {
        if(WGDailyChallengeManagerHelper.MorningChallengeAvailableNow() != true)
        {
                if(WGDailyChallengeManagerHelper.EveningChallengeAvailableNow() == false)
        {
            goto label_2;
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = ShowUGUIMonolith<System.Object>(showNext:  false);
        UnityEngine.GameObject val_5 = this.gameObject;
        SLCWindow.CloseWindow(window:  57003904, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        return;
        label_2:
        this.UpdateChallengeUI();
    }
    private void OnClick_Languages()
    {
        var val_8;
        System.Action val_10;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        object val_3 = GetComponent<System.Object>();
        val_8 = null;
        val_8 = null;
        val_10 = WGSettingsPopup.<>c.<>9__49_0;
        if(val_10 == 0)
        {
                val_10 = null;
            val_10 = new System.Action(object:  WGSettingsPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(57091904));
            WGSettingsPopup.<>c.<>9__49_0 = val_10;
        }
        
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_14 = val_10;
        UnityEngine.Transform val_5 = this.transform;
        UnityEngine.Transform val_6 = this.parent;
        UnityEngine.GameObject val_7 = this.gameObject;
        this.SetActive(value:  false);
    }
    public WGSettingsPopup()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        UnityEngine.Color val_3 = new UnityEngine.Color(r:  val_2.r, g:  val_2.g, b:  val_2.b, a:  val_2.a);
        UnityEngine.Color val_4 = new UnityEngine.Color(r:  val_2.r, g:  val_2.g, b:  val_2.b, a:  val_2.a);
    }
    private void <Awake>b__33_0(bool success)
    {
        this.OnClick_Challenge();
    }

}
