using UnityEngine;
public class WGFeatureMenu : MonoBehaviour
{
    // Fields
    protected UnityEngine.Transform menuItemParent;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Button homeButton;
    private UnityEngine.UI.Button settingsButton;
    private UnityEngine.UI.Button helpButton;
    private UnityEngine.UI.Button restoreButton;
    private TournamentsButton tournamentsButton;
    private UnityEngine.UI.Text homeButtonText;
    protected UnityEngine.Sprite dailyChallengeSprite;
    protected UnityEngine.Sprite eventSprite;
    protected UnityEngine.Sprite leaguesSprite;
    protected UnityEngine.Sprite categoriesSprite;
    protected UnityEngine.Sprite librarySprite;
    protected UnityEngine.Sprite bookRewardSprite;
    protected UnityEngine.Sprite difficultySprite;
    protected UnityEngine.Sprite adControlSprite;
    protected UnityEngine.Sprite moreGamesSprite;
    protected UnityEngine.Sprite wordIQSprite;
    protected UnityEngine.Sprite wadPetsSprite;
    protected UnityEngine.Sprite wadPetsActionableFood;
    protected UnityEngine.Sprite wadPetsActionableUpgrade;
    public System.Action OnNonHomeCloseAction;
    
    // Properties
    private FeatureMenuItem MenuItemPrefab { get; }
    private TournamentsButton TournamentsMenuItemPrefab { get; }
    
    // Methods
    private FeatureMenuItem get_MenuItemPrefab()
    {
        return PrefabLoader.LoadPrefab<WordIQLineAnim>(featureName:  -1432902432);
    }
    private TournamentsButton get_TournamentsMenuItemPrefab()
    {
        return PrefabLoader.LoadPrefab<WordIQLineAnim>(featureName:  -1432902432);
    }
    private void OnEnable()
    {
        var val_11;
        var val_12;
        val_11 = 1152921504769093632;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1432594592, method:  new IntPtr(2862298176));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1432594592, method:  new IntPtr(2862307392));
        this.settingsButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -1432594592, method:  new IntPtr(2862316608));
        this.helpButton.m_OnClick.AddListener(call:  162246656);
        if((UnityEngine.Object.op_Implicit(exists:  this.restoreButton)) != false)
        {
                UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  -1432594592, method:  new IntPtr(2862329920));
            this.restoreButton.m_OnClick.AddListener(call:  162246656);
        }
        
        UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  -1432594592, method:  new IntPtr(2862339136));
        this.homeButton.m_OnClick.AddListener(call:  162246656);
        string val_7 = Localization.Localize(key:  -1432622960, defaultValue:  -1432623040, useSingularKey:  false);
        val_12 = "home_upper";
        GameBehavior val_8 = App.getBehavior;
        if(0 != 1)
        {
                return;
        }
        
        string val_9 = Localization.Localize(key:  -1432622784, defaultValue:  -1432622864, useSingularKey:  false);
        if(this.homeButtonText == 0)
        {
            
        }
    
    }
    private void Start()
    {
        System.Action val_1 = new System.Action(object:  -1432429344, method:  new IntPtr(2862298176));
        DeviceKeypressManager.AddBackAction(backAction:  7454720);
    }
    private void OnDisable()
    {
        System.Action val_1 = new System.Action(object:  -1432317344, method:  new IntPtr(2862298176));
        DeviceKeypressManager.RemoveBackAction(backAction:  7454720);
    }
    protected FeatureMenuItem getNewItem()
    {
        bool val_2 = static_value_021FA45C;
        if(val_2 != true)
        {
                val_2 = true;
        }
        
        FeatureMenuItem val_1 = this.MenuItemPrefab;
        return UnityEngine.Object.Instantiate<System.Object>(original:  1, parent:  this.menuItemParent, worldPositionStays:  false);
    }
    protected virtual void SetupMenuItems()
    {
        if(this.menuItemParent == 0)
        {
                return;
        }
        
        R4.SetupDailyChallenge();
        R4.SetupLeaguesItem();
        R4.SetupWADPets();
        R4.SetupCategories();
        R4.SetupBookRewards();
        R4.SetupDifficulty();
        bool val_2 = AdsManager.ShowAdsControlMenuItem();
        R4.SetupMoreGames();
        R4.SetupSpecialTournamentsButton();
    }
    private bool HasNoInternet()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_8 = this;
        var val_8 = 28331809;
        val_8 = 7295616 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = null;
        val_9 = null;
        val_10 = 0;
        if(NetworkConnectivityPinger.NOTIF_NETWORK_CONNECT_RESPONSE != null)
        {
                return (bool)val_10;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
        string val_3 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_4 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_5 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        System.Func<System.Boolean> val_6 = new System.Func<System.Boolean>(object:  -1431962912, method:  new IntPtr(2862979360));
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = null;
        val_11 = null;
        val_12 = val_8;
        val_13 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
        if( == 0)
        {
                val_13 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
        }
        
        SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        UnityEngine.GameObject val_7 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1431962912, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        val_10 = 1;
        return (bool)val_10;
    }
    private void OnClickHome()
    {
        GameBehavior val_1 = App.getBehavior;
        UnityEngine.GameObject val_2 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1431850912, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClickSettings()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        object val_3 = GetComponent<System.Object>();
        System.Action val_4 = new System.Action(object:  -1431736864, method:  new IntPtr(2863205408));
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_14 = null;
        UnityEngine.GameObject val_5 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1431736864, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClickHelp()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        object val_3 = GetComponent<System.Object>();
        System.Action val_4 = new System.Action(object:  -1431623840, method:  new IntPtr(2863318432));
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_14 = null;
        UnityEngine.GameObject val_5 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1431623840, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClickRestore()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        object val_3 = GetComponent<System.Object>();
        System.Action val_4 = new System.Action(object:  -1431509792, method:  new IntPtr(2863432480));
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_14 = null;
        UnityEngine.GameObject val_5 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1431509792, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    protected void SetupDailyChallenge()
    {
        var val_21;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_21 = 1152921504765685760;
        if((-2116505760) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(CurrentLanguageSupported() == false)
        {
                return;
        }
        
        WGFeatureMenu.FeatureMenuItemConfig val_5 = new WGFeatureMenu.FeatureMenuItemConfig();
        Player val_6 = App.Player;
        if(0 > 5)
        {
                0 = 1;
        }
        
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_C = 1;
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_21 = 0;
        if((-2116505760) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_21 = 0;
            if(FeatureAvailable != false)
        {
                val_21 = 0;
            if(WGDailyChallengeManagerHelper.MorningChallengeAvailableNow() != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        }
        
            if(WGDailyChallengeManagerHelper.EveningChallengeAvailableNow() != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        }
        
        }
        
        }
        
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_1C = ;
        System.Action val_15 = new System.Action(object:  -1431392560, method:  new IntPtr(2863545504));
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_8 = null;
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_10 = this.dailyChallengeSprite;
        string val_16 = Localization.Localize(key:  -1431416672, defaultValue:  -2100705808, useSingularKey:  false);
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_14 = "daily_challenge_upper";
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_18 = 6;
        FeatureMenuItem val_17 = this.getNewItem();
        twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
    }
    private void OnClickDailyChallenge()
    {
        var val_6;
        var val_7;
        var val_8;
        if(this.HasNoInternet() != false)
        {
                return;
        }
        
        GameBehavior val_2 = App.getBehavior;
        bool val_3 = WGDailyChallengeManagerHelper.MorningChallengeAvailableNow();
        if(0 == 1)
        {
                val_6 = null;
            if(val_3 == true)
        {
                val_7 = 5;
        }
        
        }
        else
        {
                val_6 = null;
            if(val_3 == true)
        {
                val_7 = 6;
        }
        
        }
        
        var val_6 = 28327547;
        val_6 = 7298244 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_8 = null;
        val_8 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 6;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_5 = ShowUGUIMonolith<System.Object>(showNext:  false);
        this.Close();
    }
    protected virtual void SetupEventsItem()
    {
        UnityEngine.Sprite val_11;
        var val_12;
        GameBehavior val_2 = App.getBehavior;
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_C = 0;
        System.Action val_3 = new System.Action(object:  -1431155072, method:  new IntPtr(2863778832));
        if(new WGFeatureMenu.FeatureMenuItemConfig() != 0)
        {
                typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_8 = null;
            val_11 = this.eventSprite;
        }
        else
        {
                mem[8] = null;
            val_11 = this.eventSprite;
        }
        
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_10 = val_11;
        string val_4 = Localization.Localize(key:  -1431179168, defaultValue:  -1431179248, useSingularKey:  false);
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_7 = GetCurrentEventsCount.ToString();
        val_12;
        string val_8 = System.String.Format(format:  1592589744, arg0:  -1431179168, arg1:  1098586544);
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_14 = "{0} {1}";
        GameEcon val_9 = App.getGameEcon;
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_18 = 983057;
        FeatureMenuItem val_10 = this.getNewItem();
        if(this != 0)
        {
                return;
        }
    
    }
    protected void OnClickEventsItem()
    {
        if(this.HasNoInternet() == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_3 = ShowUGUIMonolith<System.Object>(showNext:  false);
        R4.Close();
    }
    protected void SetupLeaguesItem()
    {
        float val_13;
        var val_14;
        bool val_15;
        var val_16;
        WGFeatureMenu.FeatureMenuItemConfig val_1 = new WGFeatureMenu.FeatureMenuItemConfig();
        val_13 = 1152921504892043264;
        Player val_2 = App.Player;
        val_14 = 0;
        GameEcon val_3 = App.getGameEcon;
        if(val_14 >= 5614709)
        {
                0 = 1;
        }
        
        val_15 = 0;
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_C = 1;
        if(SLC.Social.Leagues.LeaguesManager.IsAvailable() != false)
        {
                val_15 = 0;
            SLC.Social.Leagues.LeaguesDataController val_5 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_14 = 0;
            SLC.Social.Leagues.Guild val_6 = val_14.MyGuild;
            if(val_14 != 0)
        {
                SLC.Social.Leagues.LeaguesDataController val_7 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_14 = 2621448;
            val_16 = null;
            val_16 = null;
            val_15 = System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = 2097204, hi = 2621448, lo = 1835037, mid = 6}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10});
            val_13 = 1152921504892043264;
        }
        
        }
        
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_1C = val_15;
        System.Action val_9 = new System.Action(object:  -1430916528, method:  new IntPtr(2864021440));
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_8 = null;
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_10 = this.leaguesSprite;
        string val_10 = Localization.Localize(key:  -1430940640, defaultValue:  -1430940736, useSingularKey:  false);
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_14 = "the_league_upper";
        GameEcon val_11 = App.getGameEcon;
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_18 = 5614709;
        FeatureMenuItem val_12 = this.getNewItem();
        if(this == 0)
        {
            
        }
    
    }
    private void OnClickLeagueItem()
    {
        var val_4;
        if(this.HasNoInternet() != false)
        {
                return;
        }
        
        var val_4 = 28326247;
        val_4 = 7299544 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 93;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_3 = ShowUGUIMonolith<System.Object>(showNext:  false);
        this.Close();
    }
    protected void SetupCategories()
    {
        var val_13;
        float val_14;
        val_13 = 1152921504901095424;
        val_14 = 1152921511094568976;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2102212592) == 0)
        {
                return;
        }
        
        if(CategoryPacksManager.FeatureAvailable == false)
        {
                return;
        }
        
        WGFeatureMenu.FeatureMenuItemConfig val_4 = new WGFeatureMenu.FeatureMenuItemConfig();
        Player val_5 = App.Player;
        GameEcon val_6 = App.getGameEcon;
        if(0 >= 1179681)
        {
                0 = 1;
        }
        
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_C = 1;
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_1C = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_38;
        System.Action val_8 = new System.Action(object:  -1430683104, method:  new IntPtr(2864254864));
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_8 = null;
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_10 = this.categoriesSprite;
        string val_9 = Localization.Localize(key:  -1430707216, defaultValue:  -1430707312, useSingularKey:  false);
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_14 = "categories_upper";
        GameEcon val_10 = App.getGameEcon;
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_18 = 1179681;
        FeatureMenuItem val_11 = this.getNewItem();
        if(this == 0)
        {
            
        }
    
    }
    private void OnClickCategories()
    {
        var val_2;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 1)
        {
                63 = 61;
        }
        
        var val_2 = 28325803;
        val_2 = 7299988 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 61;
        CategoryPacksMenuUI.ShowMainScreen();
        this.Close();
    }
    protected void SetupLibrary()
    {
        var val_16;
        var val_17;
        var val_18;
        val_16 = 0;
        val_17 = 4;
        goto label_1;
        label_21:
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<BookInfo>> val_1 = TheLibraryLogic.PlayerBooksByCollection;
        System.Collections.Generic.List<BookInfo> val_2 = TheLibraryLogic.PurchasableBooks;
        if(0 <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((0.ContainsKey(key:  406888448)) != false)
        {
                System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<BookInfo>> val_4 = TheLibraryLogic.PlayerBooksByCollection;
            System.Collections.Generic.List<BookInfo> val_5 = TheLibraryLogic.PurchasableBooks;
            if(0 <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            string val_6 = 0.Item[406888448];
            System.Collections.Generic.List<BookInfo> val_7 = TheLibraryLogic.PurchasableBooks;
            if(0 <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if((TheLibraryLogic.ListContainsBook(bookInfos:  0, bookToCheck:  2621443)) == false)
        {
                val_16 = 1;
        }
        
        }
        else
        {
                val_16 = 1;
        }
        
        val_17 = 5;
        label_1:
        System.Collections.Generic.List<BookInfo> val_10 = TheLibraryLogic.PurchasableBooks;
        if((val_17 - 4) < 0)
        {
            goto label_21;
        }
        
        WGFeatureMenu.FeatureMenuItemConfig val_11 = new WGFeatureMenu.FeatureMenuItemConfig();
        int val_12 = TheLibraryLogic.LifetimeBooksEarned;
        if(val_11 != 0)
        {
                if(val_12 > 0)
        {
                0 = 1;
        }
        
            typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_C = 1;
        }
        else
        {
                if(val_12 > 0)
        {
                0 = 1;
        }
        
            mem[12] = 1;
        }
        
        if(val_16 > 0)
        {
                0 = 1;
        }
        
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_1C = 1;
        System.Action val_13 = new System.Action(object:  -1430453792, method:  new IntPtr(2864488288));
        if(val_11 != 0)
        {
                typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_8 = null;
            val_18 = mem[1152921511766327836];
        }
        else
        {
                mem[8] = null;
            val_18 = mem[1152921511766327836];
        }
        
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_10 = val_18;
        string val_14 = Localization.Localize(key:  -1430477888, defaultValue:  -1430477984, useSingularKey:  false);
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_14 = "library_upper";
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_18 = ChapterBookLogic.GetFirstLevelOfSecondBook();
        FeatureMenuItem val_16 = this.getNewItem();
        if(this == 0)
        {
            
        }
    
    }
    private void OnClickLibrary()
    {
        var val_2;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 1)
        {
                54 = 53;
        }
        
        var val_2 = 28324483;
        val_2 = 7301308 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 53;
        TheLibraryUI.ShowTheLibrary(onCloseAction:  0);
        this.Close();
    }
    protected void SetupBookRewards()
    {
        UnityEngine.Sprite val_7;
        if(TheLibraryLogic.LifetimeBooksEarned > 0)
        {
                0 = 1;
        }
        
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_C = 1;
        System.Action val_3 = new System.Action(object:  -1430220480, method:  new IntPtr(2864713504));
        if(new WGFeatureMenu.FeatureMenuItemConfig() != 0)
        {
                typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_8 = null;
            val_7 = this.bookRewardSprite;
        }
        else
        {
                mem[8] = null;
            val_7 = this.bookRewardSprite;
        }
        
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_10 = val_7;
        string val_4 = Localization.Localize(key:  -1430477888, defaultValue:  -1430244576, useSingularKey:  false);
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_14 = "library_upper";
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_18 = ChapterBookLogic.GetFirstLevelOfSecondBook();
        FeatureMenuItem val_6 = this.getNewItem();
        if(this == 0)
        {
            
        }
    
    }
    private void OnClickBookReward()
    {
        var val_2;
        this.Close();
        GameBehavior val_1 = App.getBehavior;
        if(0 == 1)
        {
                55 = 57;
        }
        
        var val_2 = 28324127;
        val_2 = 7301664 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 57;
        TheLibraryUI.ShowTheLibrary(onCloseAction:  0);
    }
    protected void SetupDifficulty()
    {
        var val_11 = 1152921504892043264;
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        if((0.Equals(value:  1800251696)) == false)
        {
                return;
        }
        
        WGFeatureMenu.FeatureMenuItemConfig val_4 = new WGFeatureMenu.FeatureMenuItemConfig();
        GameEcon val_5 = App.getGameEcon;
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_18 = 104;
        Player val_6 = App.Player;
        if(0 >= typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_18)
        {
                0 = 1;
        }
        
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_C = 1;
        System.Action val_7 = new System.Action(object:  -1429982960, method:  new IntPtr(2864955008));
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_8 = null;
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_10 = this.difficultySprite;
        string val_8 = Localization.Localize(key:  -1430007072, defaultValue:  -1430007168, useSingularKey:  false);
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_14 = "difficulty_upper";
        FeatureMenuItem val_9 = this.getNewItem();
        if(this == 0)
        {
            
        }
    
    }
    private void OnClickDifficulty()
    {
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        if((0.Equals(value:  1800251696)) == false)
        {
                return;
        }
        
        UnityEngine.Debug.LogWarning(message:  -1429890864);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_5 = ShowUGUIMonolith<System.Object>(showNext:  false);
        R4.Close();
    }
    protected virtual void SetupAdControl()
    {
        UnityEngine.Sprite val_5;
        WGFeatureMenu.FeatureMenuItemConfig val_1 = new WGFeatureMenu.FeatureMenuItemConfig();
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_C = 1;
        System.Action val_2 = new System.Action(object:  -1429745296, method:  new IntPtr(2865188576));
        if(val_1 != 0)
        {
                typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_8 = null;
            val_5 = this.adControlSprite;
        }
        else
        {
                mem[8] = null;
            val_5 = this.adControlSprite;
        }
        
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_10 = val_5;
        string val_3 = Localization.Localize(key:  -1429769408, defaultValue:  -1429769504, useSingularKey:  false);
        if(val_1 != 0)
        {
                typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_14 = "ads_control_upper";
        }
        else
        {
                mem[20] = "ads_control_upper";
        }
        
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_18 = 0;
        FeatureMenuItem val_4 = this.getNewItem();
        if(this == 0)
        {
            
        }
    
    }
    protected void OnClickAdControl()
    {
        var val_9;
        var val_10;
        var val_11;
        if(this.HasNoInternet() == true)
        {
                return;
        }
        
        var val_9 = 28323135;
        val_9 = 7302656 + val_9;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = null;
        val_9 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 94;
        this.Close();
        if(SceneDictator.IsInGameScene() != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_5 = ShowUGUIMonolith<System.Object>(showNext:  false);
            val_10 = 13;
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_7 = ShowUGUIMonolith<System.Object>(showNext:  false);
            val_10 = 2;
        }
        
        WGAdsControlPopup val_8 = InitEntryTag(tag:  2);
        var val_10 = 28322965;
        val_10 = 7303096 + val_10;
        if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
        val_11 = null;
        val_11 = null;
        PurchaseProxy.currentPurchasePoint = 77;
    }
    protected void SetupMoreGames()
    {
        var val_8;
        var val_9;
        int val_10;
        UnityEngine.Sprite val_11;
        var val_12;
        bool val_13;
        var val_14;
        var val_8 = 28332576;
        val_8 = 7293996 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_8 = null;
        val_8 = null;
        if(twelvegigs.plugins.InstalledAppsPlugin.fetched == false)
        {
                return;
        }
        
        GameApp[] val_1 = twelvegigs.plugins.InstalledAppsPlugin.PackagesToCheck;
        if(0 == 0)
        {
                return;
        }
        
        Player val_3 = App.Player;
        float val_9 = 6.477733E-38f;
        val_9 = 7294308 + val_9;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = null;
        val_9 = null;
        val_10 = WGMoreGamesManager._unlockLevel;
        if(0 >= val_10)
        {
                0 = 1;
        }
        
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_C = 1;
        System.Action val_4 = new System.Action(object:  -1429503680, method:  new IntPtr(2865430192));
        if(new WGFeatureMenu.FeatureMenuItemConfig() != 0)
        {
                typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_8 = null;
            val_11 = this.moreGamesSprite;
        }
        else
        {
                mem[8] = null;
            val_11 = this.moreGamesSprite;
        }
        
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_10 = val_11;
        string val_5 = Localization.Localize(key:  -1429527792, defaultValue:  -1429527888, useSingularKey:  false);
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_14 = "more_games_upper";
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        val_12 = null;
        val_12 = null;
        val_13 = 0;
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_18 = WGMoreGamesManager._unlockLevel;
        val_10 = 7294704 + 28333482;
        if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
        val_14 = null;
        val_14 = null;
        if(WGMoreGamesManager.totalBonus >= 1)
        {
                val_13 = WGMoreGamesManager.CanCollect();
        }
        
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_1C = val_13;
        FeatureMenuItem val_7 = this.getNewItem();
        if(this == 0)
        {
            
        }
    
    }
    private void OnClickMoreGames()
    {
        this.Close();
        if(WGMoreGamesManager.CanShowMoreGames == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_3 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    protected void SetupWordIQ()
    {
        UnityEngine.Sprite val_5;
        WGFeatureMenu.FeatureMenuItemConfig val_1 = new WGFeatureMenu.FeatureMenuItemConfig();
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_C = 1;
        System.Action val_2 = new System.Action(object:  -1429261056, method:  new IntPtr(2865672832));
        if(val_1 != 0)
        {
                typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_8 = null;
            val_5 = this.wordIQSprite;
        }
        else
        {
                mem[8] = null;
            val_5 = this.wordIQSprite;
        }
        
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_10 = val_5;
        string val_3 = Localization.Localize(key:  -1429285152, defaultValue:  -1429285248, useSingularKey:  false);
        if(val_1 != 0)
        {
                typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_14 = "word_iq_upper";
        }
        else
        {
                mem[20] = "word_iq_upper";
        }
        
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_18 = 0;
        FeatureMenuItem val_4 = this.getNewItem();
        if(this == 0)
        {
            
        }
    
    }
    private void OnClickWordIQ()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        this.Close();
    }
    protected void SetupWADPets()
    {
        var val_9;
        bool val_10;
        var val_11;
        UnityEngine.Sprite val_12;
        WGFeatureMenu.FeatureMenuItemConfig val_1 = new WGFeatureMenu.FeatureMenuItemConfig();
        val_9 = 0;
        val_10 = WADPetsManager.IsFeatureUnlocked();
        if(val_1 != 0)
        {
                val_11 = val_1;
            typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_1C = val_9;
            mem[1152921504921862168] = 0;
            mem[1152921504921862156] = val_10;
        }
        else
        {
                mem[12] = val_10;
            mem[24] = 0;
            val_11 = 28;
            mem[28] = val_9;
            val_10 = mem[12];
        }
        
        if(val_10 != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(IsAnyUpgradeAvailable() != false)
        {
                if(val_1 != 0)
        {
                mem[28] = 1;
        }
        else
        {
                mem[28] = 1;
        }
        
            WGFeatureMenu.FeatureMenuItemConfig.__il2cppRuntimeField_element_class.Add(item:  this.wadPetsActionableUpgrade);
        }
        
            if(WADPetsManager.IsAnyPetHungry() != false)
        {
                if(val_1 != 0)
        {
                mem[28] = 1;
        }
        else
        {
                mem[28] = 1;
        }
        
            WGFeatureMenu.FeatureMenuItemConfig.__il2cppRuntimeField_element_class.Add(item:  this.wadPetsActionableFood);
        }
        
        }
        
        string val_6 = Localization.Localize(key:  -1429042544, defaultValue:  -1429042624, useSingularKey:  false);
        if(val_1 != 0)
        {
                typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_14 = "pets_upper";
            val_12 = this.wadPetsSprite;
        }
        else
        {
                mem[20] = "pets_upper";
            val_12 = this.wadPetsSprite;
        }
        
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_10 = val_12;
        System.Action val_7 = new System.Action(object:  -1429009232, method:  new IntPtr(2865933040));
        typeof(WGFeatureMenu.FeatureMenuItemConfig).__il2cppRuntimeField_8 = null;
        FeatureMenuItem val_8 = this.getNewItem();
        if(this == 0)
        {
            
        }
    
    }
    private void OnClickWADPets()
    {
        var val_1;
        var val_1 = 28321667;
        val_1 = 7304124 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 96;
        WADPetsScreenUI.ShowMainScreen();
        this.Close();
    }
    protected void SetupSpecialTournamentsButton()
    {
        System.Action<System.Boolean> val_8;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        val_8 = 1152921511525052144;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1671729424) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        TournamentsButton val_5 = public static TournamentsManager MonoSingleton<TournamentsManager>::get_Instance().__il2cppRuntimeField_C.TournamentsMenuItemPrefab;
        object val_6 = UnityEngine.Object.Instantiate<System.Object>(original:  public static TournamentsManager MonoSingleton<TournamentsManager>::get_Instance().__il2cppRuntimeField_C, parent:  this.menuItemParent, worldPositionStays:  false);
        this.tournamentsButton = public static TournamentsManager MonoSingleton<TournamentsManager>::get_Instance().__il2cppRuntimeField_C;
        val_8 = null;
        val_8 = new System.Action<System.Boolean>(object:  -1428762704, method:  new IntPtr(2866179568));
        mem2[0] = val_8;
    }
    private void OnClickTournamentsItem(bool isConnected)
    {
        var val_10;
        System.Action val_11;
        UnityEngine.GameObject val_12;
        var val_13;
        if(isConnected != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_3 = ShowUGUIMonolith<System.Object>(showNext:  false);
            this.Close();
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_5 = PlaceGameObject<System.Object>(loc:  0);
        val_10 = public static UGUIDynamicPlacementManager MonoSingleton<UGUIDynamicPlacementManager>::get_Instance();
        val_11 = 0;
        UnityEngine.GameObject val_6 = this.tournamentsButton.gameObject;
        val_12 = this.tournamentsButton;
        val_13 = "Internet connection required. Please check your connection and try again!";
        ShowToolTip(objToToolTip:  null, text:  -1671479392, topToolTip:  true, displayDuration:  null, width:  null, height:  null, tooltipOffsetX:  null, tooltipOffsetY:  null, viewportSettings:  1080033280, showGotItButton:  false, gotItCallback:  null, showPick:  false, maxFontSize:  null);
    }
    protected void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1428513104, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        if(this.OnNonHomeCloseAction == 0)
        {
                return;
        }
        
        this.OnNonHomeCloseAction.Invoke();
    }
    public WGFeatureMenu()
    {
    
    }
    private bool <HasNoInternet>b__31_0()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_60 = this.OnNonHomeCloseAction;
        return true;
    }
    private void <OnClickSettings>b__33_0()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_60 = this.OnNonHomeCloseAction;
    }
    private void <OnClickHelp>b__34_0()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_60 = this.OnNonHomeCloseAction;
    }
    private void <OnClickRestore>b__35_0()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_60 = this.OnNonHomeCloseAction;
    }

}
