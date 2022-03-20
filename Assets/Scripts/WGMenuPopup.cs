using UnityEngine;
public class WGMenuPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text bannerText;
    private UnityEngine.UI.Button homeButton;
    private UnityEngine.UI.Button libraryButton;
    private UnityEngine.UI.Button difficultyButton;
    private UnityEngine.UI.Button bookRewardsButton;
    private UnityEngine.UI.Button categoriesButton;
    private UnityEngine.UI.Button settingsButton;
    private UnityEngine.UI.Button helpButton;
    private UnityEngine.UI.Button storeButton;
    private UnityEngine.UI.Button removeAdsButton;
    private UnityEngine.UI.Button quitButton;
    private UnityEngine.UI.Button[] buttonOrder;
    private UnityEngine.RectTransform[] rowContainers;
    private float widthTwoIcons;
    private float widthThreeIcons;
    private int maxButtonPerRow;
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
    private const string HOME_MENU_BANNER_TEXT = "MENU";
    private const string PAUSED_MENU_BANNER_TEXT = "PAUSED";
    private bool inRequest;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_19;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  14254544, method:  new IntPtr(14120976));
        this.homeButton.m_OnClick.AddListener(call:  162246656);
        if(this.libraryButton != 0)
        {
                UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  14254544, method:  new IntPtr(14134288));
            this.libraryButton.m_OnClick.AddListener(call:  162246656);
        }
        
        if(this.difficultyButton != 0)
        {
                UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  14254544, method:  new IntPtr(14147600));
            this.difficultyButton.m_OnClick.AddListener(call:  162246656);
        }
        
        if(this.bookRewardsButton != 0)
        {
                UnityEngine.Events.UnityAction val_7 = new UnityEngine.Events.UnityAction(object:  14254544, method:  new IntPtr(14160912));
            this.bookRewardsButton.m_OnClick.AddListener(call:  162246656);
        }
        
        if(this.categoriesButton != 0)
        {
                UnityEngine.Events.UnityAction val_9 = new UnityEngine.Events.UnityAction(object:  14254544, method:  new IntPtr(14174224));
            this.categoriesButton.m_OnClick.AddListener(call:  162246656);
        }
        
        UnityEngine.Events.UnityAction val_10 = new UnityEngine.Events.UnityAction(object:  14254544, method:  new IntPtr(14183440));
        this.settingsButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_11 = new UnityEngine.Events.UnityAction(object:  14254544, method:  new IntPtr(14192656));
        this.helpButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_12 = new UnityEngine.Events.UnityAction(object:  14254544, method:  new IntPtr(14201872));
        this.storeButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_13 = new UnityEngine.Events.UnityAction(object:  14254544, method:  static System.Void DebugBanner::.cctor());
        this.removeAdsButton.m_OnClick.AddListener(call:  162246656);
        val_19 = null;
        val_19 = new UnityEngine.Events.UnityAction(object:  14254544, method:  new IntPtr(14220304));
        this.quitButton.m_OnClick.AddListener(call:  162246656);
        NotificationCenter val_15 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  14254544, name:  -2005054624);
        NotificationCenter val_16 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  14254544, name:  -106451056);
        if(this.challenge_Button == 0)
        {
                return;
        }
        
        val_19 = this.challenge_Button;
        System.Action<System.Boolean> val_18 = new System.Action<System.Boolean>(object:  14254544, method:  new IntPtr(14229520));
        this.challenge_Button.OnConnectionClick = null;
    }
    private void OnEnable()
    {
        var val_53;
        var val_54;
        bool val_55;
        var val_56;
        var val_57;
        var val_59;
        if(SceneDictator.IsInGameScene() == false)
        {
            goto label_3;
        }
        
        if(SceneDictator.IsInGameScene() == false)
        {
            goto label_6;
        }
        
        GameEcon val_3 = App.getGameEcon;
        string val_4 = 0.titleFormat;
        string val_5 = Localization.Localize(key:  14453136, defaultValue:  14453232, useSingularKey:  false);
        string val_6 = System.String.Format(format:  null, arg0:  14453136);
        UnityEngine.GameObject val_7 = this.quitButton.gameObject;
        this.quitButton.SetActive(value:  false);
        UnityEngine.GameObject val_8 = this.homeButton.gameObject;
        val_53 = 1;
        goto label_15;
        label_3:
        GameEcon val_9 = App.getGameEcon;
        string val_10 = 0.titleFormat;
        string val_11 = Localization.Localize(key:  14465600, defaultValue:  14465696, useSingularKey:  false);
        string val_12 = System.String.Format(format:  null, arg0:  14465600);
        UnityEngine.GameObject val_13 = this.quitButton.gameObject;
        this.quitButton.SetActive(value:  true);
        UnityEngine.GameObject val_14 = this.homeButton.gameObject;
        val_53 = 0;
        label_15:
        this.homeButton.SetActive(value:  false);
        label_6:
        var val_53 = 27120591;
        val_53 = 8505196 + val_53;
        if(val_53 == 0)
        {
                mem2[0] = 1;
        }
        
        val_54 = null;
        val_54 = null;
        if(App.game == 16)
        {
                UnityEngine.GameObject val_15 = this.homeButton.gameObject;
            this.homeButton.SetActive(value:  true);
        }
        
        if(this.libraryButton != 0)
        {
                UnityEngine.GameObject val_17 = this.libraryButton.gameObject;
            int val_18 = TheLibraryLogic.LifetimeBooksEarned;
            if(val_18 != 0)
        {
                val_18 = 1;
        }
        
            this.libraryButton.SetActive(value:  true);
        }
        
        if(this.bookRewardsButton != 0)
        {
                UnityEngine.GameObject val_20 = this.bookRewardsButton.gameObject;
            int val_21 = TheLibraryLogic.LifetimeBooksEarned;
            if(val_21 != 0)
        {
                val_21 = 1;
        }
        
            this.bookRewardsButton.SetActive(value:  true);
        }
        
        if(this.categoriesButton != 0)
        {
                UnityEngine.GameObject val_23 = this.categoriesButton.gameObject;
            GameBehavior val_24 = App.getBehavior;
            val_55 = 0;
            if(0 != 0)
        {
                val_55 = 0;
            if(CategoryPacksManager.FeatureAvailable != false)
        {
                Player val_26 = App.Player;
            GameEcon val_27 = App.getGameEcon;
            val_55 = GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  1179681);
        }
        
        }
        
            this.categoriesButton.SetActive(value:  val_55);
        }
        
        if(this.difficultyButton != 0)
        {
                UnityEngine.GameObject val_30 = this.difficultyButton.gameObject;
            Player val_31 = App.Player;
            GameEcon val_32 = App.getGameEcon;
            if(0 >= 104)
        {
                0 = 1;
        }
        
            this.difficultyButton.SetActive(value:  true);
        }
        
        UnityEngine.GameObject val_33 = this.removeAdsButton.gameObject;
        this.removeAdsButton.SetActive(value:  AdsManager.ShowAdsControlButtons(fromSettings:  true));
        val_56 = 4;
        goto label_78;
        label_101:
        UnityEngine.UI.Button val_54 = this.buttonOrder[0];
        UnityEngine.GameObject val_35 = val_54.gameObject;
        if(val_54.activeInHierarchy != false)
        {
                UnityEngine.UI.Button val_55 = this.buttonOrder[0];
            UnityEngine.GameObject val_37 = val_55.gameObject;
            UnityEngine.Transform val_38 = val_55.transform;
            val_55.SetParent(p:  this.rowContainers[0]);
            UnityEngine.UI.Button val_57 = this.buttonOrder[0];
            UnityEngine.GameObject val_39 = val_57.gameObject;
            UnityEngine.Transform val_40 = val_57.transform;
            val_57.SetSiblingIndex(index:  0);
        }
        
        val_56 = 5;
        label_78:
        val_57 = val_56 - 4;
        if(val_57 < (UnityEngine.Mathf.Min(a:  1, b:  155430911)))
        {
            goto label_101;
        }
        
        val_59 = 0;
        goto label_102;
        label_116:
        val_56 = 0;
        val_57 = 0;
        UnityEngine.RectTransform val_58 = this.rowContainers[val_59];
        goto label_105;
        label_110:
        UnityEngine.Transform val_42 = val_58.GetChild(index:  0);
        UnityEngine.GameObject val_43 = val_58.gameObject;
        val_57 = val_57 + val_58.activeSelf;
        val_56 = 1;
        label_105:
        if(val_56 < val_58.childCount)
        {
            goto label_110;
        }
        
        if(val_57 < true)
        {
                68 = 64;
        }
        
        if(val_58 != 0)
        {
                UnityEngine.Rect val_46 = rect;
            UnityEngine.Vector2 val_48 = new UnityEngine.Vector2(x:  height, y:  val_46.m_YMin);
        }
        else
        {
                UnityEngine.Rect val_49 = rect;
            UnityEngine.Vector2 val_51 = new UnityEngine.Vector2(x:  height, y:  val_49.m_YMin);
        }
        
        val_58.sizeDelta = new UnityEngine.Vector2() {x = val_51.x, y = val_51.y};
        UnityEngine.GameObject val_52 = val_58.gameObject;
        if(val_57 > false)
        {
                0 = 1;
        }
        
        val_58.SetActive(value:  true);
        val_59 = 1;
        label_102:
        if(val_59 < val_58)
        {
            goto label_116;
        }
        
        this.UpdateChallengeUI();
    }
    private void OnClick_Quit()
    {
        App.Quit();
    }
    private void OnClick_Home()
    {
        if(SceneDictator.IsInGameScene() != false)
        {
                GameBehavior val_2 = App.getBehavior;
        }
        
        UnityEngine.GameObject val_3 = this.gameObject;
        SLCWindow.CloseWindow(window:  15459248, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClick_Library()
    {
        var val_4;
        var val_5;
        var val_6;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge != false)
        {
                val_4 = 1152921504895770624;
            var val_4 = 27115979;
            val_4 = 8509812 + val_4;
            if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
            val_5 = null;
            val_6 = 58;
        }
        else
        {
                if(SceneDictator.IsInGameScene() == true)
        {
                val_6 = 54;
        }
        
            val_4 = 1152921504895770624;
            var val_5 = 27115819;
            val_5 = 8509972 + val_5;
            if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
            val_5 = null;
        }
        
        AmplitudePluginHelper.lastFeatureAccessPoint = 54;
        TheLibraryUI.ShowTheLibrary(onCloseAction:  0);
    }
    private void OnClick_Difficulty()
    {
        var val_6;
        System.Action val_8;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        object val_3 = GetComponent<System.Object>();
        val_6 = null;
        val_6 = null;
        val_8 = WGMenuPopup.<>c.<>9__34_0;
        if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new System.Action(object:  WGMenuPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(15659248));
            WGMenuPopup.<>c.<>9__34_0 = val_8;
        }
        
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_14 = val_8;
        UnityEngine.GameObject val_5 = this.gameObject;
        SLCWindow.CloseWindow(window:  15684272, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClick_BookRewards()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        System.Action val_13;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge != false)
        {
                val_8 = 1152921504895770624;
            var val_8 = 27115047;
            val_8 = 8510744 + val_8;
            if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
            val_9 = null;
            val_10 = 56;
        }
        else
        {
                if(SceneDictator.IsInGameScene() == true)
        {
                val_10 = 55;
        }
        
            val_8 = 1152921504895770624;
            var val_9 = 27114887;
            val_9 = 8510904 + val_9;
            if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
            val_9 = null;
        }
        
        AmplitudePluginHelper.lastFeatureAccessPoint = 55;
        GameBehavior val_4 = App.getBehavior;
        val_11 = null;
        val_11 = null;
        val_13 = WGMenuPopup.<>c.<>9__35_0;
        if(val_13 == 0)
        {
                val_13 = null;
            val_13 = new System.Action(object:  WGMenuPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(15772272));
            WGMenuPopup.<>c.<>9__35_0 = val_13;
        }
        
        0.DisplayBooksEarned(onCloseCallback:  7454720);
        UnityEngine.GameObject val_7 = this.gameObject;
        SLCWindow.CloseWindow(window:  15797296, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClick_Categories()
    {
        var val_3;
        if(SceneDictator.IsInGameScene() == true)
        {
                62 = 63;
        }
        
        var val_3 = 27114219;
        val_3 = 8511572 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 63;
        UnityEngine.GameObject val_2 = this.gameObject;
        SLCWindow.CloseWindow(window:  15909296, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        CategoryPacksMenuUI.ShowMainScreen();
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
        
        if(this.inRequest == true)
        {
                return;
        }
        
        mem2[0] = 1;
        R4 + 92.WaitingStatus(waiting:  true);
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_4 = new System.Action<System.Boolean>(object:  R4, method:  new IntPtr(15997296));
        RequestServerUpdate(callback:  7401472);
        return;
        label_2:
        this.UpdateChallengeUI();
    }
    private void UpdateChallengeUI()
    {
        UnityEngine.GameObject[] val_18;
        var val_19;
        var val_20;
        var val_21;
        UnityEngine.Color val_22;
        GameBehavior val_1 = App.getBehavior;
        val_18 = 0;
        if(0 != 0)
        {
                val_19 = 1152921504901095424;
            val_20 = 1152921511080275808;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_18 = 0;
            if((-2116505760) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_18 = 0;
            if(FeatureAvailable != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_18 = 0;
            if(CurrentLanguageSupported() != false)
        {
                val_18 = 0;
            if(WGDailyChallengeManagerHelper.MorningChallengeAvailableNow() != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        }
        
            if(WGDailyChallengeManagerHelper.EveningChallengeAvailableNow() != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        }
        
        }
        
        }
        
        }
        
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.ChallengeGroup)) != false)
        {
                if((public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_78) != 0)
        {
                public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_78 = 1;
        }
        
            this.ChallengeGroup.SetActive(value:  true);
        }
        
        val_21 = 0;
        bool val_14 = WGDailyChallengeManagerHelper.MorningChallengeAvailableNow();
        goto label_41;
        label_46:
        UnityEngine.GameObject val_18 = this.sun_groups[val_21];
        val_18.SetActive(value:  val_14);
        val_21 = 1;
        label_41:
        if(val_21 < val_18)
        {
            goto label_46;
        }
        
        if(val_14 != false)
        {
                val_22 = this.sunTextColor;
            this.challenge_number_text.color = new UnityEngine.Color() {r = val_22, g = SB, b = 1.241516E-37f, a = this.sun_groups};
            if((UnityEngine.Object.op_Implicit(exists:  this.challenge_number_text_outline)) != false)
        {
                val_22 = this.sunTextOutlineColor;
            this.challenge_number_text_outline.effectColor = new UnityEngine.Color() {r = val_22, g = 3.246603E-38f, b = 1.241516E-37f, a = this.sun_groups};
        }
        
        }
        
        val_20 = 0;
        bool val_16 = WGDailyChallengeManagerHelper.EveningChallengeAvailableNow();
        goto label_53;
        label_58:
        UnityEngine.GameObject val_19 = this.moon_groups[val_20];
        val_19.SetActive(value:  val_16);
        val_20 = 1;
        label_53:
        val_18 = this.moon_groups;
        if(val_20 < val_19)
        {
            goto label_58;
        }
        
        if(val_16 == false)
        {
                return;
        }
        
        val_22 = this.moonTextColor;
        this.challenge_number_text.color = new UnityEngine.Color() {r = val_22, g = SB, b = 1.241516E-37f, a = val_18};
        if((UnityEngine.Object.op_Implicit(exists:  this.challenge_number_text_outline)) == false)
        {
                return;
        }
        
        this.challenge_number_text_outline.effectColor = new UnityEngine.Color() {r = mem[this.moonTextOutlineColor + (0)], g = mem[this.moonTextOutlineColor + (4)], b = mem[this.moonTextOutlineColor + (8)], a = this};
    }
    private void OnDailyChallengeDataUpdate()
    {
        this.UpdateChallengeUI();
    }
    private void OnClickSettingsButton()
    {
        var val_6;
        System.Action val_8;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        object val_3 = GetComponent<System.Object>();
        val_6 = null;
        val_6 = null;
        val_8 = WGMenuPopup.<>c.<>9__40_0;
        if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new System.Action(object:  WGMenuPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(16711152));
            WGMenuPopup.<>c.<>9__40_0 = val_8;
        }
        
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_14 = val_8;
        UnityEngine.GameObject val_5 = this.gameObject;
        SLCWindow.CloseWindow(window:  16736176, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClickHelpButton()
    {
        var val_6;
        System.Action val_8;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        object val_3 = GetComponent<System.Object>();
        val_6 = null;
        val_6 = null;
        val_8 = WGMenuPopup.<>c.<>9__41_0;
        if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new System.Action(object:  WGMenuPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(16824176));
            WGMenuPopup.<>c.<>9__41_0 = val_8;
        }
        
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_14 = val_8;
        UnityEngine.GameObject val_5 = this.gameObject;
        SLCWindow.CloseWindow(window:  16849200, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClickStore()
    {
        var val_7;
        TrackerPurchasePoints val_8;
        var val_9;
        System.Action val_11;
        if(SceneDictator.IsInGameScene() != false)
        {
                var val_7 = 27112973;
            val_7 = 8513088 + val_7;
            if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
            val_7 = null;
            val_8 = 13;
        }
        else
        {
                var val_8 = 27112893;
            val_8 = 8513168 + val_8;
            if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
            val_7 = null;
            val_8 = 12;
        }
        
        val_7 = null;
        PurchaseProxy.currentPurchasePoint = val_8;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = ShowUGUIMonolith<System.Object>(showNext:  false);
        val_9 = null;
        val_9 = null;
        val_11 = WGMenuPopup.<>c.<>9__42_0;
        if(val_11 == 0)
        {
                val_11 = null;
            val_11 = new System.Action(object:  WGMenuPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(16937200));
            WGMenuPopup.<>c.<>9__42_0 = val_11;
        }
        
        Init(outOfCredits:  false, onCloseAction:  7454720);
        UnityEngine.GameObject val_6 = this.gameObject;
        SLCWindow.CloseWindow(window:  16962224, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClickRemoveAds()
    {
        var val_9;
        if(SceneDictator.IsInGameScene() != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_4 = ShowUGUIMonolith<System.Object>(showNext:  false);
            val_9 = 13;
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_6 = ShowUGUIMonolith<System.Object>(showNext:  false);
            val_9 = 2;
        }
        
        WGAdsControlPopup val_7 = InitEntryTag(tag:  2);
        UnityEngine.GameObject val_8 = this.gameObject;
        SLCWindow.CloseWindow(window:  17074224, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnComplete(bool success)
    {
        var val_6;
        var val_7;
        FeatureAccessPoints val_8;
        this.inRequest = false;
        this.challenge_Button.WaitingStatus(waiting:  false);
        if(WGDailyChallengeManagerHelper.MorningChallengeAvailableNow() == false)
        {
            goto label_2;
        }
        
        val_6 = 1152921504895770624;
        var val_6 = 27111579;
        val_6 = 8514212 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_7 = null;
        val_8 = 6;
        goto label_6;
        label_2:
        if(WGDailyChallengeManagerHelper.EveningChallengeAvailableNow() == false)
        {
            goto label_7;
        }
        
        val_6 = 1152921504895770624;
        var val_7 = 27111467;
        val_7 = 8514324 + val_7;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_7 = null;
        val_8 = 9;
        label_6:
        AmplitudePluginHelper.lastFeatureAccessPoint = val_8;
        label_7:
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = ShowUGUIMonolith<System.Object>(showNext:  false);
        UnityEngine.GameObject val_5 = this.gameObject;
        SLCWindow.CloseWindow(window:  17190320, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGMenuPopup()
    {
        this.widthTwoIcons = 774f;
        this.widthThreeIcons = 920f;
        this.maxButtonPerRow = 3;
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        UnityEngine.Color val_3 = new UnityEngine.Color(r:  val_2.r, g:  val_2.g, b:  val_2.b, a:  val_2.a);
        UnityEngine.Color val_4 = new UnityEngine.Color(r:  val_2.r, g:  val_2.g, b:  val_2.b, a:  val_2.a);
    }
    private void <Awake>b__29_0(bool success)
    {
        this.OnClick_Challenge();
    }

}
