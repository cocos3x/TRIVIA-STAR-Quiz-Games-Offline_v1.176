using UnityEngine;
public class TRVLevelComplete : MonoBehaviour
{
    // Fields
    private const string lastChapterCollectedKey = "LCCK";
    private static int lastLevelCompleteAnimShownAt;
    private static int lastEventLevelCompleteAnimShownAt;
    public UnityEngine.GameObject levelFailureGroup;
    public UnityEngine.GameObject levelFailureProgressBar;
    private UnityEngine.UI.Text failurePointRewardText;
    private UnityEngine.UI.Text failureLevelProgressText;
    private UnityEngine.UI.Text failureTryAgainCost;
    private UnityEngine.UI.Text failureStarMultiplierText;
    private UnityEngine.UI.Image failureLevelProgressBar;
    private UnityEngine.UI.Button tryAgainButton;
    private UnityEngine.GameObject levelSuccessGroup;
    private UnityEngine.GameObject levelCompleteBanner;
    private UnityEngine.UI.Text pregameCointext;
    private UnityEngine.UI.Text pregameStarText;
    private UnityEngine.UI.Button pregameOpenButton;
    private UnityEngine.GameObject preminigameTapContinueObject;
    private UnityEngine.GameObject preminigameRewardGroup;
    private UnityEngine.GameObject preCrazyCategoriesPointParent;
    private UnityEngine.UI.Text preCrazyCategoriesPointsAmount;
    private UnityEngine.UI.Text streakReward;
    private UnityEngine.GameObject streakGroup;
    private UnityEngine.GameObject chestGroup;
    private UnityEngine.UI.Image openChestImage;
    private UnityEngine.UI.Image closedChestImage;
    private TRVPickerGameButton minigameButtonPrefab;
    private System.Collections.Generic.Dictionary<TRVPickerGameButton, int> gameButtons;
    private UnityEngine.GameObject chestRewardMultiParent;
    private UnityEngine.UI.Image minigameBackdrop;
    private UnityEngine.UI.Text minigameOpenText;
    private UnityEngine.CanvasGroup multiplierChestGroup;
    private UGUINetworkedButton redrawButton;
    private UnityEngine.UI.Button noThanksButton;
    private UnityEngine.GameObject postMinigameGroup;
    public UnityEngine.GameObject progressBarParent;
    private UnityEngine.UI.Text postMinigameNextGameText;
    private UnityEngine.UI.Text postMinigameChapterProgressText;
    private UnityEngine.UI.Text postMinigameTryAgainCost;
    private UnityEngine.UI.Text postMinigameStarMultiText;
    private UnityEngine.UI.Image postMinigameChestImage;
    private UnityEngine.UI.Image postMinigameChapterProgressBar;
    private UnityEngine.UI.Button postMinigameNextButton;
    private UnityEngine.GameObject postMinigameNextButtonGroup;
    private TournamentsButton tournamentsButton;
    private System.Collections.Generic.List<UnityEngine.GameObject> statViews;
    public CoinCurrencyParticles ccp;
    public GoldenApplesParticles sp;
    public GemsParticles gp;
    public CurrencyStatView starStatView;
    public CurrencyStatView coinStatView;
    public CurrencyStatView gemStatView;
    private TRVLevelCompleteReward levelCompleteRewardPrefab;
    private UnityEngine.Transform levelCompleteRewardParent;
    private System.Collections.Generic.Dictionary<string, TRVLevelCompleteReward> spawnedRewards;
    private UnityEngine.UI.Button storeButton;
    private UnityEngine.UI.Button gemStoreButton;
    private UnityEngine.UI.Button homeButton;
    private UnityEngine.Sprite WoodChestIcon;
    private UnityEngine.Sprite WoodChestOpen;
    private UnityEngine.Sprite SilverChestIcon;
    private UnityEngine.Sprite SilverChestOpen;
    private UnityEngine.Sprite GoldenChestIcon;
    private UnityEngine.Sprite GoldenChestOpen;
    private System.Collections.Generic.List<UnityEngine.Sprite> cardSpecificSprites;
    private UnityEngine.GameObject challengeFriendGroup;
    private UnityEngine.UI.Button challengeFriendButton;
    private UnityEngine.UI.Text completionTimeText;
    private TRVSpecialCategoriesLevelComplete specialCategoriesLevelComplete;
    public System.Action playNextLevelAction;
    
    // Properties
    private int chapterLength { get; }
    private bool ChapterRewardAvailable { get; }
    private bool CompletedChapterCycle { get; }
    private bool RerollBonusToday { get; set; }
    
    // Methods
    private int get_chapterLength()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>()) != 0)
        {
                return (int)mem[1152921512476916192];
        }
        
        return (int)mem[1152921512476916192];
    }
    private bool get_ChapterRewardAvailable()
    {
        Player val_1 = App.Player;
        if(this.chapterLength != 0)
        {
                return true;
        }
        
        int val_5 = CPlayerPrefs.GetInt(key:  -513608608, defaultValue:  0);
        Player val_4 = App.Player;
        val_5 = val_5 - 0;
        if(0 != 0)
        {
                0 = 1;
        }
        
        return true;
    }
    private bool get_CompletedChapterCycle()
    {
        Player val_1 = App.Player;
        int val_2 = this.chapterLength;
        return false;
    }
    private bool get_RerollBonusToday()
    {
        ulong val_11;
        ulong val_13;
        var val_16;
        var val_17;
        var val_18;
        val_16 = 0;
        val_17 = "rerollLast";
        if((CPlayerPrefs.HasKey(key:  -513384528)) == false)
        {
                return (bool)val_16;
        }
        
        string val_2 = CPlayerPrefs.GetString(key:  -513384528, defaultValue:  1098586544);
        val_17 = 1152921504616751104;
        val_18 = null;
        val_18 = null;
        System.DateTime val_3 = SLCDateTime.ParseInvariant(dateTime:  -513372480, defaultValue:  new System.DateTime() {dateData = 1152921512683397040});
        System.DateTime val_6 = Date;
        System.DateTime val_7 = DateTimeCheat.UtcNow;
        System.DateTime val_10 = Date;
        val_16 = System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = val_13}, d2:  new System.DateTime() {dateData = val_11});
        return (bool)val_16;
    }
    private void set_RerollBonusToday(bool value)
    {
        if(value == false)
        {
                return;
        }
        
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        string val_2 = SLCDateTime.SerializeInvariant(dateTime:  new System.DateTime());
        CPlayerPrefs.SetString(key:  -513384528, val:  R0);
        CPlayerPrefs.Save();
    }
    private void OnEnable()
    {
        System.Action<System.Boolean> val_29;
        float val_30;
        System.Collections.Generic.List<UnityEngine.GameObject> val_31;
        var val_32;
        System.Action<UnityEngine.GameObject> val_34;
        float val_35;
        System.Action<System.Boolean> val_36;
        UnityEngine.GameObject val_1 = this.levelFailureGroup.gameObject;
        this.levelFailureGroup.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.levelSuccessGroup.gameObject;
        this.levelSuccessGroup.SetActive(value:  false);
        UnityEngine.GameObject val_3 = this.postMinigameGroup.gameObject;
        this.postMinigameGroup.SetActive(value:  false);
        this.storeButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -513014576, method:  new IntPtr(3781835536));
        this.storeButton.m_OnClick.AddListener(call:  162246656);
        this.gemStoreButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  -513014576, method:  new IntPtr(3781852944));
        this.gemStoreButton.m_OnClick.AddListener(call:  162246656);
        this.homeButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  -513014576, method:  new IntPtr(3781870352));
        this.homeButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.GameObject val_7 = this.homeButton.gameObject;
        this.homeButton.SetActive(value:  false);
        val_29 = 1152921504614248448;
        val_30 = 1152921511020114880;
        null = new System.Action<System.Boolean>(object:  -513014576, method:  new IntPtr(3781879568));
        this.redrawButton.OnConnectionClick = null;
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_31 = this.statViews;
        val_32 = null;
        val_32 = null;
        val_34 = TRVLevelComplete.<>c.<>9__78_0;
        if(val_34 == 0)
        {
                val_34 = null;
            val_34 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  TRVLevelComplete.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3781884688));
            val_29 = val_29;
            TRVLevelComplete.<>c.<>9__78_0 = val_34;
            val_30 = 1152921511020114880;
        }
        
        val_31.ForEach(action:  7401472);
        if((public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C.successfullyCompletedQuiz) != false)
        {
                System.Collections.IEnumerator val_12 = this.SetupPostMinigameState();
            UnityEngine.Coroutine val_13 = this.StartCoroutine(routine:  -513014576);
        }
        else
        {
                this.SetupLevelFailureState();
        }
        
        val_35 = 1152921504765685760;
        if(this.tournamentsButton == 0)
        {
            goto label_39;
        }
        
        val_34 = this.tournamentsButton;
        val_31 = val_29;
        val_31 = new System.Action<System.Boolean>(object:  -513014576, method:  new IntPtr(3781898000));
        System.Delegate val_16 = System.Delegate.Combine(a:  this.tournamentsButton.ExternalClickCallback, b:  7401472);
        val_36 = this.tournamentsButton.ExternalClickCallback;
        if(val_36 != 0)
        {
                if(null == null)
        {
            goto label_43;
        }
        
        }
        
        val_36 = 0;
        label_43:
        this.tournamentsButton.ExternalClickCallback = val_36;
        label_39:
        if(((this.challengeFriendGroup == 0) || (this.challengeFriendButton == 0)) || (this.completionTimeText == 0))
        {
            goto label_61;
        }
        
        val_29 = 1152921504901095424;
        val_30 = 1152921511277700704;
        twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1919080864) == 0)
        {
            goto label_61;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.GameObject val_23 = this.challengeFriendGroup.gameObject;
        this.challengeFriendGroup.SetActive(value:  true);
        UnityEngine.Events.UnityAction val_24 = new UnityEngine.Events.UnityAction(object:  -513014576, method:  new IntPtr(3781923600));
        this.challengeFriendButton.m_OnClick.AddListener(call:  162246656);
        twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_26 = GenericStringExtentions.ToString(span:  new System.TimeSpan() {_ticks = public static ChallengeFriendController MonoSingleton<ChallengeFriendController>::get_Instance().__il2cppRuntimeField_28 + 16}, formatted:  true);
        if(this.completionTimeText != 0)
        {
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_314;
        }
        
        goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_314;
        label_61:
        var val_27 = FP - 28;
    }
    private void ChallengeFriend()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ShareChallenge();
    }
    private void SetupPreGameState()
    {
        var val_35;
        UnityEngine.GameObject val_1 = this.levelCompleteBanner.gameObject;
        this.levelCompleteBanner.SetActive(value:  true);
        this.setChestSprite(image:  this.closedChestImage, closed:  true);
        UnityEngine.GameObject val_2 = this.openChestImage.gameObject;
        this.openChestImage.SetActive(value:  false);
        WordForest.WFOGameEcon val_3 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_7 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C.GetQuizBaseStarReward();
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_11 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C.GetQuizBaseReward().ToString();
        string val_12 = System.String.Format(format:  -1225078832, arg0:  -512596796);
        string val_13 = (val_7 * (mem[1152921512476916292] + (public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 60) << 2) + 16).ToString();
        string val_14 = System.String.Format(format:  -1225078832, arg0:  -512596792);
        this.pregameOpenButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_15 = new UnityEngine.Events.UnityAction(object:  -512584752, method:  new IntPtr(3782304272));
        this.pregameOpenButton.m_OnClick.AddListener(call:  162246656);
        this.pregameOpenButton.interactable = false;
        UnityEngine.GameObject val_16 = this.levelSuccessGroup.gameObject;
        this.levelSuccessGroup.SetActive(value:  true);
        UnityEngine.GameObject val_17 = this.minigameBackdrop.gameObject;
        this.minigameBackdrop.SetActive(value:  false);
        UnityEngine.GameObject val_18 = this.minigameOpenText.gameObject;
        this.minigameOpenText.SetActive(value:  false);
        UnityEngine.GameObject val_19 = this.multiplierChestGroup.gameObject;
        this.multiplierChestGroup.SetActive(value:  false);
        UnityEngine.GameObject val_20 = this.redrawButton.gameObject;
        this.redrawButton.SetActive(value:  false);
        UnityEngine.GameObject val_21 = this.noThanksButton.gameObject;
        this.noThanksButton.SetActive(value:  false);
        this.chestGroup.SetActive(value:  false);
        this.streakGroup.SetActive(value:  true);
        twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_23 = GetBonusStarReward();
        string val_25 = System.String.Format(format:  -1631218480, arg0:  13152256);
        val_35 = "+ {0}";
        if((TRVCrazyCategoriesEventHandler.EVENT_TRACKING_ID == null) || (TRVCrazyCategoriesEventHandler.BonusStarsEligable() == false))
        {
            goto label_45;
        }
        
        UnityEngine.GameObject val_27 = this.preCrazyCategoriesPointParent.gameObject;
        this.preCrazyCategoriesPointParent.SetActive(value:  true);
        twelvegigs.Autopilot.AutopilotManager val_28 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_30 = public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C.GetQuizBaseStarReward().ToString();
        string val_31 = System.String.Format(format:  -1225078832, arg0:  -512596796);
        val_35 = "{0}";
        if(this.preCrazyCategoriesPointsAmount != 0)
        {
            goto label_53;
        }
        
        goto label_53;
        label_45:
        UnityEngine.GameObject val_32 = this.preCrazyCategoriesPointParent.gameObject;
        this.preCrazyCategoriesPointParent.SetActive(value:  false);
        label_53:
        System.Collections.IEnumerator val_33 = this.PlayStreakAnimation();
        UnityEngine.Coroutine val_34 = this.StartCoroutine(routine:  -512584752);
    }
    private System.Collections.IEnumerator PlayStreakAnimation()
    {
        TRVLevelComplete.<PlayStreakAnimation>d__81 val_1 = new TRVLevelComplete.<PlayStreakAnimation>d__81(<>1__state:  0);
        typeof(TRVLevelComplete.<PlayStreakAnimation>d__81).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator StartMinigame()
    {
        TRVLevelComplete.<StartMinigame>d__82 val_1 = new TRVLevelComplete.<StartMinigame>d__82(<>1__state:  0);
        typeof(TRVLevelComplete.<StartMinigame>d__82).__il2cppRuntimeField_10 = this;
    }
    private void MultiplierPicked(int multi, TRVPickerGameButton selectedButton)
    {
        var val_5;
        var val_28;
        TRVLevelComplete val_33;
        TRVPickerGameButton val_34;
        System.Collections.Generic.IEnumerable<System.Int32> val_35;
        var val_36;
        var val_37;
        val_33 = this;
        val_34 = selectedButton;
        if((new TRVLevelComplete.<>c__DisplayClass83_0()) != 0)
        {
                typeof(TRVLevelComplete.<>c__DisplayClass83_0).__il2cppRuntimeField_8 = val_33;
        }
        else
        {
                mem[8] = val_33;
        }
        
        typeof(TRVLevelComplete.<>c__DisplayClass83_0).__il2cppRuntimeField_C = multi;
        Dictionary.KeyCollection<TKey, TValue> val_2 = this.gameButtons.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = GetEnumerator();
        label_8:
        if(MoveNext() == false)
        {
            goto label_5;
        }
        
        UnityEngine.UI.Button val_6 = val_5.myButton;
        val_5.interactable = false;
        goto label_8;
        label_5:
        Dispose();
        WordForest.WFOGameEcon val_7 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_9 = mem[1152921512476916344].Item[public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 52];
        val_35 = mem[1152921512476916344];
        val_35.Sort();
        int val_10 = System.Linq.Enumerable.Max(source:  val_35);
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WordPets.WPTDataParser val_12 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if(VideoEnabledAndUnlocked() != false)
        {
                Player val_14 = App.Player;
            WordForest.WFOGameEcon val_15 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
            int val_33 = 0;
            val_33 = val_33 - 1;
            if((GameEcon.IsEnabledAndLevelMet(playerLevel:  val_33, knobValue:  mem[1152921512476916268])) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            mem2[0] = typeof(TRVLevelComplete.<>c__DisplayClass83_0).__il2cppRuntimeField_C;
            System.Collections.IEnumerator val_18 = this.animateReveal(selected:  val_34, rerollAvailable:  true);
            UnityEngine.Coroutine val_19 = val_33.StartCoroutine(routine:  -512133040);
            UnityEngine.Events.UnityAction val_20 = new UnityEngine.Events.UnityAction(object:  359903232, method:  new IntPtr(3782806160));
            this.noThanksButton.m_OnClick.AddListener(call:  162246656);
            return;
        }
        
        }
        
        if((typeof(TRVLevelComplete.<>c__DisplayClass83_0).__il2cppRuntimeField_C.RerollBonusToday) == true)
        {
            goto label_43;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_23 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        typeof(TRVLevelComplete.<>c__DisplayClass83_1).__il2cppRuntimeField_8 = 0;
        val_36 = 4;
        goto label_55;
        label_63:
        if((new TRVLevelComplete.<>c__DisplayClass83_1()) <= val_34)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_36 = 5;
        label_55:
        if(1 < (mem[1152921512476916344] + 12))
        {
            goto label_63;
        }
        
        val_33 = val_33;
        val_35 = null;
        val_35 = new System.Func<System.Collections.Generic.KeyValuePair<TRVPickerGameButton, System.Int32>, System.Boolean>(object:  359956480, method:  new IntPtr(3782807184));
        System.Collections.Generic.KeyValuePair<System.Object, System.Int32> val_27 = System.Linq.Enumerable.FirstOrDefault<System.Collections.Generic.KeyValuePair<System.Object, System.Int32>>(source:  -512145112, predicate:  this.gameButtons);
        val_34 = val_34;
        val_37 = val_28;
        if(val_37 != 0)
        {
                mem2[0] = val_28 + 28;
        }
        else
        {
                val_37 = 28;
            mem2[0] = 52;
        }
        
        mem[28] = selectedButton + 28;
        typeof(TRVLevelComplete.<>c__DisplayClass83_0).__il2cppRuntimeField_C = ;
        this.RerollBonusToday = true;
        label_43:
        twelvegigs.Autopilot.AutopilotManager val_29 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        mem2[0] = typeof(TRVLevelComplete.<>c__DisplayClass83_0).__il2cppRuntimeField_C;
        twelvegigs.Autopilot.AutopilotManager val_30 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        RewardMultiPicked(multi:  typeof(TRVLevelComplete.<>c__DisplayClass83_0).__il2cppRuntimeField_C);
        System.Collections.IEnumerator val_31 = this.animateReveal(selected:  val_34, rerollAvailable:  false);
        UnityEngine.Coroutine val_32 = this.StartCoroutine(routine:  -512133040);
    }
    private void RedrawMultiplier(bool connected)
    {
        TRVLevelComplete val_15;
        UnityEngine.UI.Button val_16;
        var val_17;
        var val_18;
        var val_19;
        this.redrawButton.interactable = false;
        this.noThanksButton.interactable = false;
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        val_15 = 0;
        val_15.AddObserver(observer:  -511987248, name:  2128120864);
        if(connected == false)
        {
            goto label_6;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((ShowIncentivizedVideo(tag:  42, adCapExempt:  false)) == false)
        {
            goto label_10;
        }
        
        this.redrawButton.interactable = true;
        val_16 = this.noThanksButton;
        goto label_12;
        label_6:
        GameBehavior val_4 = App.getBehavior;
        string val_6 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_7 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_8 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_17 = 0;
        if(val_17 == 0)
        {
                val_17 = 0;
        }
        
        val_17.SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
        val_15 = this;
        this.redrawButton.interactable = true;
        val_16 = this.noThanksButton;
        label_12:
        val_16.interactable = true;
        return;
        label_10:
        GameBehavior val_9 = App.getBehavior;
        string val_11 = Localization.Localize(key:  2129276784, defaultValue:  2129276896, useSingularKey:  false);
        string val_12 = Localization.Localize(key:  2129276992, defaultValue:  2129277104, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_13 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        System.Func<System.Boolean> val_14 = new System.Func<System.Boolean>(object:  -511987248, method:  new IntPtr(3782955024));
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = null;
        val_18 = null;
        val_19 = 0;
        val_19.SetupMessage(titleTxt:  2129276784, messageTxt:  2129276992, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
    }
    private void OnVideoResponse(Notification notif)
    {
        UnityEngine.Object val_9;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        this.redrawButton.interactable = false;
        this.noThanksButton.interactable = false;
        string val_1 = notif.data.ToString();
        if((System.Boolean.Parse(value:  notif.data)) == false)
        {
            goto label_8;
        }
        
        UnityEngine.GameObject val_3 = this.noThanksButton.gameObject;
        this.noThanksButton.SetActive(value:  false);
        UnityEngine.GameObject val_4 = this.redrawButton.gameObject;
        this.redrawButton.SetActive(value:  false);
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        mem2[0] = 1;
        val_19 = this;
        Dictionary.KeyCollection<TKey, TValue> val_6 = this.gameButtons.Keys;
        val_20 = this.gameButtons;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_7 = GetEnumerator();
        val_21 = 1152921512684609168;
        label_23:
        if(MoveNext() == false)
        {
            goto label_19;
        }
        
        UnityEngine.GameObject val_10 = val_9.gameObject;
        UnityEngine.Object.Destroy(obj:  val_9);
        goto label_23;
        label_8:
        GameBehavior val_11 = App.getBehavior;
        string val_13 = Localization.Localize(key:  2129276784, defaultValue:  2129276896, useSingularKey:  false);
        string val_14 = Localization.Localize(key:  2129276992, defaultValue:  2129277104, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_15 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        System.Func<System.Boolean> val_16 = new System.Func<System.Boolean>(object:  -511824048, method:  new IntPtr(3783113104));
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = null;
        val_22 = null;
        val_19 = 0;
        goto label_45;
        label_19:
        Dispose();
        this.gameButtons.Clear();
        System.Collections.IEnumerator val_17 = this.StartMinigame();
        UnityEngine.Coroutine val_18 = val_19.StartCoroutine(routine:  -511824048);
        return;
        label_45:
        val_19.SetupMessage(titleTxt:  2129276784, messageTxt:  2129276992, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
    }
    private System.Collections.IEnumerator animateReveal(TRVPickerGameButton selected, bool rerollAvailable)
    {
        if((new TRVLevelComplete.<animateReveal>d__86(<>1__state:  0)) != 0)
        {
                typeof(TRVLevelComplete.<animateReveal>d__86).__il2cppRuntimeField_10 = selected;
            typeof(TRVLevelComplete.<animateReveal>d__86).__il2cppRuntimeField_14 = this;
        }
        else
        {
                mem[20] = this;
            mem[16] = selected;
        }
        
        typeof(TRVLevelComplete.<animateReveal>d__86).__il2cppRuntimeField_18 = rerollAvailable;
    }
    private System.Collections.IEnumerator SetupPostMinigameState()
    {
        TRVLevelComplete.<SetupPostMinigameState>d__87 val_1 = new TRVLevelComplete.<SetupPostMinigameState>d__87(<>1__state:  0);
        typeof(TRVLevelComplete.<SetupPostMinigameState>d__87).__il2cppRuntimeField_10 = this;
    }
    private void HandlePostMinigameEventSetup(bool animate)
    {
        int val_38;
        UnityEngine.Transform val_39;
        float val_40;
        int val_41;
        var val_42;
        UnityEngine.Transform val_43;
        var val_44;
        bool val_45;
        val_38 = 1152921504901095424;
        val_39 = 1152921511548963376;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.specialCategoriesLevelComplete.Init(currentQuiz:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C, lcPopup:  -511417888);
        if(TRVCrazyCategoriesEventHandler.BonusStarsEligable() != false)
        {
                string val_3 = Localization.Localize(key:  -511466880, defaultValue:  -511466992, useSingularKey:  false);
            TRVLevelReward val_5 = new TRVLevelReward(description:  -511466880, rwvalue:  TRVCrazyCategoriesEventHandler.EVENT_TRACKING_ID.bonusStars(stars:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 64), rwt:  1, multi:  0);
            System.Collections.IEnumerator val_6 = this.SetupReward(parent:  this.levelCompleteRewardParent, reward:  360382464, anim:  false);
            UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  -511417888);
            val_39 = 1152921511548963376;
            val_38 = 1152921504901095424;
        }
        
        val_40 = 1152921512589735248;
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-607046320) == 0)
        {
            goto label_44;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((TRVSpecialCategoriesManager.IsOldSpecialQuiz(progress:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C)) == false)
        {
            goto label_44;
        }
        
        if((public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C.successfullyCompletedQuiz) == false)
        {
            goto label_19;
        }
        
        if(animate == false)
        {
            goto label_44;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((IsRewardReadyToCollect(progress:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C)) == false)
        {
            goto label_44;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_38 = GetCurrentReward(progress:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C);
        Player val_19 = App.Player;
        decimal val_20 = System.Decimal.op_Implicit(value:  -511429952);
        twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CollectReward(progress:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C);
        TRVLevelReward val_23 = new TRVLevelReward(description:  -511454480, rwvalue:  val_38, rwt:  2, multi:  0);
        System.Collections.IEnumerator val_24 = this.SetupReward(parent:  this.levelCompleteRewardParent, reward:  360382464, anim:  true);
        UnityEngine.Coroutine val_25 = this.StartCoroutine(routine:  -511417888);
        Player val_26 = App.Player;
        decimal val_27 = System.Decimal.op_Implicit(value:  -511429968);
        if(this.gemStatView != 0)
        {
            goto label_44;
        }
        
        goto label_44;
        label_19:
        this.levelFailureProgressBar.SetActive(value:  false);
        label_44:
        var val_36 = 27525692;
        val_36 = 8104048 + val_36;
        if(val_36 == 0)
        {
                mem2[0] = 1;
        }
        
        val_41 = 1152921504970797056;
        if(TRVYouBetchaEventHandler.EVENT_TRACKING_ID == null)
        {
                return;
        }
        
        if(TRVYouBetchaEventHandler.EVENT_TRACKING_ID.shouldShowPopup == false)
        {
                return;
        }
        
        if(val_36 == 0)
        {
                mem2[0] = 1;
        }
        
        if(TRVYouBetchaEventHandler.EVENT_TRACKING_ID != null)
        {
                val_38 = (TRVYouBetchaEventHandler.EVENT_TRACKING_ID + 21) >> 5;
        }
        else
        {
                val_38 = (TRVYouBetchaEventHandler.EVENT_TRACKING_ID + 21) >> 5;
            if(val_36 == 0)
        {
                mem2[0] = 1;
        }
        
        }
        
        bool val_29 = TRVYouBetchaEventHandler.EVENT_TRACKING_ID.TryRewardBet();
        val_39 = this.levelCompleteRewardParent;
        string val_30 = Localization.Localize(key:  -511442080, defaultValue:  -511441984, useSingularKey:  false);
        val_40 = "you_betcha";
        if(val_38 != 0)
        {
                TRVLevelReward val_31 = new TRVLevelReward(description:  -511442080, rwvalue:  0, rwt:  0, multi:  0);
            val_42 = this;
            val_43 = val_39;
            val_44 = null;
            val_45 = 0;
        }
        else
        {
                if(val_36 == 0)
        {
                mem2[0] = 1;
        }
        
            val_41 = 0;
            val_42 = this;
            val_43 = val_39;
            val_44 = new TRVLevelReward(description:  -511442080, rwvalue:  TRVYouBetchaEventHandler.EVENT_TRACKING_ID.betReward, rwt:  0, multi:  val_41);
            val_45 = animate;
        }
        
        System.Collections.IEnumerator val_34 = this.SetupReward(parent:  val_43, reward:  360382464, anim:  val_45);
        UnityEngine.Coroutine val_35 = val_42.StartCoroutine(routine:  -511417888);
    }
    private System.Collections.IEnumerator OnRewardAnimFinished(float delay = 0)
    {
        if((new TRVLevelComplete.<OnRewardAnimFinished>d__89(<>1__state:  0)) != 0)
        {
                typeof(TRVLevelComplete.<OnRewardAnimFinished>d__89).__il2cppRuntimeField_14 = this;
        }
        else
        {
                mem[20] = this;
        }
        
        typeof(TRVLevelComplete.<OnRewardAnimFinished>d__89).__il2cppRuntimeField_10 = R1;
    }
    private void SetupLevelFailureState()
    {
        var val_47;
        System.Action<UnityEngine.GameObject> val_49;
        var val_50;
        var val_51;
        int val_52;
        var val_53;
        var val_54;
        var val_55;
        float val_56;
        var val_57;
        int val_58;
        float val_59;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_47 = null;
        val_47 = null;
        val_49 = TRVLevelComplete.<>c.<>9__90_0;
        if(val_49 == 0)
        {
                val_49 = null;
            val_49 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  TRVLevelComplete.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3783782176));
            TRVLevelComplete.<>c.<>9__90_0 = val_49;
        }
        
        this.statViews.ForEach(action:  7401472);
        UnityEngine.GameObject val_3 = this.homeButton.gameObject;
        this.homeButton.SetActive(value:  true);
        val_50 = null;
        if((TRVSpecialCategoriesManager.IsOldSpecialQuiz(progress:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C)) != false)
        {
                val_51 = null;
            val_52 = TRVLevelComplete.lastEventLevelCompleteAnimShownAt;
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_53 = 0;
            int val_7 = GetQuizProgress(progress:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C);
        }
        else
        {
                val_55 = null;
            val_52 = TRVLevelComplete.lastLevelCompleteAnimShownAt;
            val_53 = 0;
            Player val_8 = App.Player;
            val_54 = 0;
        }
        
        if(val_52 != val_54)
        {
                UnityEngine.Transform val_9 = this.starStatView.AppleIcon;
            UnityEngine.Transform val_10 = this.starStatView.transform;
            UnityEngine.Vector3 val_11 = position;
            this.sp.PlayParticles(destinationPosition:  new UnityEngine.Vector3(), particleCount:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C.totalPointsGained, animateStatView:  true);
            Player val_13 = App.Player;
            int val_15 = 4 - (public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C.totalPointsGained);
            decimal val_16 = System.Decimal.op_Implicit(value:  -511113704);
            NotificationCenter val_17 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  -511101632, aName:  -2092882624);
            Player val_18 = App.Player;
            val_57 = null;
            val_57 = null;
            TRVLevelComplete.lastLevelCompleteAnimShownAt = 0;
            val_53 = 1;
        }
        
        WordForest.WFOGameEcon val_19 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        string val_21 = dynamicQuizEntryCost.ToString();
        string val_23 = (public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 64).ToString();
        Player val_24 = App.Player;
        if(this.chapterLength != 0)
        {
                Player val_26 = App.Player;
            val_58 = this.chapterLength;
        }
        else
        {
                val_58 = chapterLength;
        }
        
        int val_29 = chapterLength;
        string val_30 = System.String.Format(format:  -1222347616, arg0:  13152256, arg1:  13152256);
        Player val_31 = App.Player;
        if(this.chapterLength != 0)
        {
                Player val_33 = App.Player;
            val_56 = (float)this.chapterLength;
            val_59 = (float)this.chapterLength / val_56;
        }
        else
        {
                val_59 = 1f;
        }
        
        this.failureLevelProgressBar.fillAmount = val_11.x;
        WordForest.WFOGameEcon val_36 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        var val_38 = mem[1152921512476916292] + (TRVMainController.currentMultiplier << 2);
        string val_39 = Localization.Localize(key:  -710867072, defaultValue:  -765467904, useSingularKey:  false);
        string val_40 = System.String.Format(format:  -511147232, arg0:  13152256, arg1:  -710867072);
        this.tryAgainButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_41 = new UnityEngine.Events.UnityAction(object:  -511101632, method:  new IntPtr(3783836544));
        this.tryAgainButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.GameObject val_42 = this.levelFailureGroup.gameObject;
        this.levelFailureGroup.SetActive(value:  true);
        this.HandlePostMinigameEventSetup(animate:  true);
        System.Collections.IEnumerator val_43 = this.OnRewardAnimFinished(delay:  val_11.x);
        UnityEngine.Coroutine val_44 = this.StartCoroutine(routine:  -511101632);
    }
    private void NextQuizButtonClicked()
    {
        System.Action val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        System.Action val_54;
        if(this.ChapterRewardAvailable == false)
        {
            goto label_1;
        }
        
        TRVLevelComplete.<>c__DisplayClass91_0 val_2 = new TRVLevelComplete.<>c__DisplayClass91_0();
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  1, oneshot:  true, pitch:  null, vol:  null);
        string val_4 = Localization.Localize(key:  -510948000, defaultValue:  -510948096, useSingularKey:  false);
        UnityEngine.Transform val_5 = this.postMinigameTryAgainCost.transform;
        UnityEngine.Transform val_6 = this.postMinigameTryAgainCost.parent;
        UnityEngine.GameObject val_7 = this.postMinigameTryAgainCost.gameObject;
        this.postMinigameTryAgainCost.SetActive(value:  true);
        UnityEngine.Transform val_8 = this.postMinigameStarMultiText.transform;
        UnityEngine.Transform val_9 = this.postMinigameStarMultiText.parent;
        UnityEngine.GameObject val_10 = this.postMinigameStarMultiText.gameObject;
        this.postMinigameStarMultiText.SetActive(value:  true);
        UnityEngine.GameObject val_11 = this.homeButton.gameObject;
        this.homeButton.SetActive(value:  true);
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_13 = ShowUGUIMonolith<System.Object>(showNext:  true);
        typeof(TRVLevelComplete.<>c__DisplayClass91_0).__il2cppRuntimeField_8 = 0;
        WADGiftRewardManager val_14 = WGGiftRewardManager<WADGiftRewardManager>.Instance;
        System.Collections.Generic.List<GiftReward> val_16 = GetRewards(rewardsSource:  3, expertLeveledUp: out  bool val_15 = true, cardsGranted:  0);
        Player val_17 = App.Player;
        CPlayerPrefs.SetInt(key:  -513608608, val:  0);
        CPlayerPrefs.Save();
        object val_18 = GetComponent<System.Object>();
        val_46 = null;
        val_46 = new System.Action(object:  360169472, method:  new IntPtr(3784031696));
        val_47 = 0;
        val_48 = 0;
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_14 = val_46;
        goto label_31;
        label_1:
        val_46 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(IsOutOfQuestions() == false)
        {
            goto label_35;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ShowOutOfQuestionsPopup(showFlyout:  true);
        val_47 = 1;
        val_48 = 1;
        label_31:
        this.Close(showAd:  true, load:  true);
        return;
        label_35:
        Player val_23 = App.Player;
        var val_24 = 0 + 60;
        WordForest.WFOGameEcon val_25 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        int val_26 = dynamicQuizEntryCost;
        decimal val_27 = System.Decimal.op_Implicit(value:  -510892836);
        if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = mem[(0 + 60) + (0)], hi = mem[(0 + 60) + (4)], lo = mem[(0 + 60) + (8)], mid = mem[(0 + 60) + (12)]}, d2:  new System.Decimal())) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_29 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  2, oneshot:  true, pitch:  null, vol:  null);
            WordForest.WFOGameEcon val_30 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
            int val_31 = dynamicQuizEntryCost;
            decimal val_32 = System.Decimal.op_Implicit(value:  -510892836);
            bool val_33 = CurrencyController.DebitBalance(value:  new System.Decimal(), source:  "TRVQuizEntry", externalParams:  0, animated:  true);
            UnityEngine.Transform val_34 = this.ccp.transform;
            UnityEngine.Transform val_35 = this.coinStatView.AppleIcon;
            UnityEngine.Vector3 val_36 = position;
            this.ccp.position = new UnityEngine.Vector3();
            twelvegigs.Autopilot.AutopilotManager val_37 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C.successfullyCompletedQuiz) == true)
        {
                this.failureTryAgainCost = this.postMinigameNextButton;
        }
        
            UnityEngine.Transform val_39 = this.failureTryAgainCost.transform;
            val_50 = 0;
            UnityEngine.Vector3 val_40 = position;
            val_49 = 0;
            this.ccp.PlayParticles(destinationPosition:  new UnityEngine.Vector3(), particleCount:  429496729, animateStatView:  false);
            this.postMinigameNextButton.interactable = false;
            this.tryAgainButton.interactable = false;
            UUI_EventsController.DisableInputs();
            System.Collections.IEnumerator val_41 = this.WaitForCoinAnimation();
            UnityEngine.Coroutine val_42 = this.StartCoroutine(routine:  -510880784);
            return;
        }
        
        var val_47 = 27518665;
        val_47 = 8107396 + val_47;
        if(val_47 == 0)
        {
                mem2[0] = 1;
        }
        
        val_51 = null;
        val_51 = null;
        PurchaseProxy.currentPurchasePoint = 93;
        GameBehavior val_43 = App.getBehavior;
        val_50 = 1152921504966430720;
        val_52 = null;
        val_52 = null;
        val_54 = TRVLevelComplete.<>c.<>9__91_1;
        if(val_54 == 0)
        {
                val_54 = null;
            val_54 = new System.Action(object:  TRVLevelComplete.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3784061488));
            TRVLevelComplete.<>c.<>9__91_1 = val_54;
        }
        
        0.Init(outOfCredits:  true, onCloseAction:  7454720);
        UnityEngine.GameObject val_46 = this.gameObject;
        SLCWindow.CloseWindow(window:  -510880784, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private System.Collections.IEnumerator WaitForCoinAnimation()
    {
        TRVLevelComplete.<WaitForCoinAnimation>d__92 val_1 = new TRVLevelComplete.<WaitForCoinAnimation>d__92(<>1__state:  0);
        typeof(TRVLevelComplete.<WaitForCoinAnimation>d__92).__il2cppRuntimeField_10 = this;
    }
    private void NoAdButtonClicked()
    {
        var val_5;
        System.Action val_7;
        GameBehavior val_1 = App.getBehavior;
        val_5 = null;
        val_5 = null;
        val_7 = TRVLevelComplete.<>c.<>9__93_0;
        if(val_7 == 0)
        {
                val_7 = null;
            val_7 = new System.Action(object:  TRVLevelComplete.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3784332592));
            TRVLevelComplete.<>c.<>9__93_0 = val_7;
        }
        
        mem[96] = val_7;
        UnityEngine.GameObject val_4 = this.gameObject;
        SLCWindow.CloseWindow(window:  -510609680, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void StoreButtonClicked()
    {
        var val_5;
        var val_6;
        System.Action val_8;
        var val_5 = 27516833;
        val_5 = 8109228 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        PurchaseProxy.currentPurchasePoint = 2;
        GameBehavior val_1 = App.getBehavior;
        val_6 = null;
        val_6 = null;
        val_8 = TRVLevelComplete.<>c.<>9__94_0;
        if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new System.Action(object:  TRVLevelComplete.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3784445616));
            TRVLevelComplete.<>c.<>9__94_0 = val_8;
        }
        
        0.Init(outOfCredits:  false, onCloseAction:  7454720);
        UnityEngine.GameObject val_4 = this.gameObject;
        SLCWindow.CloseWindow(window:  -510496656, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void GemStoreButtonClicked()
    {
        var val_6;
        var val_7;
        System.Action val_9;
        var val_6 = 27516245;
        val_6 = 8109816 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        PurchaseProxy.currentPurchasePoint = 2;
        string val_1 = Localization.Localize(key:  -1687442544, defaultValue:  -1687442624, useSingularKey:  false);
        GameStoreManager.StoreCategoryFocus = "gems_upper";
        GameBehavior val_2 = App.getBehavior;
        val_7 = null;
        val_7 = null;
        val_9 = TRVLevelComplete.<>c.<>9__95_0;
        if(val_9 == 0)
        {
                val_9 = null;
            val_9 = new System.Action(object:  TRVLevelComplete.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3784558640));
            TRVLevelComplete.<>c.<>9__95_0 = val_9;
        }
        
        0.Init(outOfCredits:  false, onCloseAction:  7454720);
        UnityEngine.GameObject val_5 = this.gameObject;
        SLCWindow.CloseWindow(window:  -510383632, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void HomeButtonClicked()
    {
        var val_5;
        System.Action val_7;
        GameBehavior val_1 = App.getBehavior;
        val_5 = null;
        val_5 = null;
        val_7 = TRVLevelComplete.<>c.<>9__96_0;
        if(val_7 == 0)
        {
                val_7 = null;
            val_7 = new System.Action(object:  TRVLevelComplete.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3784671664));
            TRVLevelComplete.<>c.<>9__96_0 = val_7;
        }
        
        mem[96] = val_7;
        UnityEngine.GameObject val_4 = this.gameObject;
        SLCWindow.CloseWindow(window:  -510270608, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private System.Collections.IEnumerator SetupReward(UnityEngine.Transform parent, TRVLevelReward reward, bool anim = False)
    {
        if((new TRVLevelComplete.<SetupReward>d__97(<>1__state:  0)) != 0)
        {
                typeof(TRVLevelComplete.<SetupReward>d__97).__il2cppRuntimeField_10 = this;
            typeof(TRVLevelComplete.<SetupReward>d__97).__il2cppRuntimeField_14 = reward;
            typeof(TRVLevelComplete.<SetupReward>d__97).__il2cppRuntimeField_18 = parent;
        }
        else
        {
                mem[16] = this;
            mem[24] = parent;
            mem[20] = reward;
        }
        
        typeof(TRVLevelComplete.<SetupReward>d__97).__il2cppRuntimeField_1C = anim;
    }
    public void setChestSprite(UnityEngine.UI.Image image, bool closed)
    {
        var val_2;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(closed == true)
        {
                val_2 = 228;
        }
        
        image.sprite = this.SilverChestIcon;
    }
    public void Close(bool showAd = True, bool load = True)
    {
        TournamentsButton val_8;
        TournamentsButton val_9;
        val_8 = this.tournamentsButton;
        if(val_8 == 0)
        {
            goto label_3;
        }
        
        val_9 = this.tournamentsButton;
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -509889552, method:  new IntPtr(3781898000));
        System.Delegate val_3 = System.Delegate.Remove(source:  this.tournamentsButton.ExternalClickCallback, value:  7401472);
        val_8 = this.tournamentsButton.ExternalClickCallback;
        if(val_8 != 0)
        {
                if(null == null)
        {
            goto label_7;
        }
        
        }
        
        val_8 = 0;
        label_7:
        this.tournamentsButton.ExternalClickCallback = val_8;
        label_3:
        if(showAd != false)
        {
                val_8.TryShowFomoOnComplete();
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_9 = public static AdsUIController MonoSingleton<AdsUIController>::get_Instance();
            bool val_5 = ShowInterstitial(context:  2);
        }
        
        if(load != false)
        {
                GameBehavior val_6 = App.getBehavior;
        }
        
        UnityEngine.GameObject val_7 = this.gameObject;
        SLCWindow.CloseWindow(window:  -509889552, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void PostLevelVideoButtonClicked(bool connected)
    {
        var val_3;
        if(connected == false)
        {
                return;
        }
        
        GameBehavior val_1 = App.getBehavior;
        val_3 = null;
        val_3 = null;
    }
    private void TryShowFomoOnComplete()
    {
        if((FOMOPackEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        if((FOMOPackEventHandler.<Instance>k__BackingField.AvailableShow) == false)
        {
                return;
        }
        
        if((FOMOPackEventHandler.<Instance>k__BackingField.CanLevelShow) == false)
        {
                return;
        }
        
        if((FOMOPackEventHandler.<Instance>k__BackingField.TryShowPopup(isOOC:  false)) == false)
        {
                return;
        }
        
        FOMOPackEventHandler.<Instance>k__BackingField.SetShowedLevel();
    }
    private void OnTournamentsClicked(bool isConnected)
    {
        var val_13;
        System.Action val_15;
        var val_16;
        System.Action val_17;
        UnityEngine.GameObject val_18;
        var val_19;
        var val_20;
        if(isConnected != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            GameBehavior val_2 = App.getBehavior;
            object val_4 = 0.GetComponent<System.Object>();
            val_13 = null;
            val_13 = null;
            val_15 = TRVLevelComplete.<>c.<>9__102_0;
            if(val_15 == 0)
        {
                val_15 = null;
            val_15 = new System.Action(object:  TRVLevelComplete.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3785402032));
            TRVLevelComplete.<>c.<>9__102_0 = val_15;
        }
        
            mem[20] = val_15;
            this.Close(showAd:  false, load:  false);
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_7 = PlaceGameObject<System.Object>(loc:  0);
        val_16 = public static UGUIDynamicPlacementManager MonoSingleton<UGUIDynamicPlacementManager>::get_Instance();
        val_17 = 0;
        UnityEngine.GameObject val_8 = this.tournamentsButton.gameObject;
        val_18 = this.tournamentsButton;
        val_19 = "tournament_connection";
        val_20 = "Internet connection required. Please check your connection and try again!";
        string val_12 = Localization.Localize(key:  -509555936, defaultValue:  -1671479392, useSingularKey:  false);
        ShowToolTip(objToToolTip:  null, text:  -509555936, topToolTip:  true, displayDuration:  null, width:  null, height:  null, tooltipOffsetX:  null, tooltipOffsetY:  null, viewportSettings:  1080033280, showGotItButton:  false, gotItCallback:  null, showPick:  false, maxFontSize:  null);
    }
    public TRVLevelComplete()
    {
        System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32> val_1 = new System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32>();
        this.gameButtons = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.statViews = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.cardSpecificSprites = null;
    }
    private static TRVLevelComplete()
    {
        TRVLevelComplete.lastLevelCompleteAnimShownAt = 0;
        TRVLevelComplete.lastEventLevelCompleteAnimShownAt = 0;
    }
    private void <SetupPreGameState>b__80_0()
    {
        System.Collections.IEnumerator val_1 = this.StartMinigame();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -509186608);
    }
    private bool <RedrawMultiplier>b__84_0()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        RewardMultiPicked(multi:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 72);
        System.Collections.IEnumerator val_3 = this.SetupPostMinigameState();
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  -509074608);
        return true;
    }
    private bool <OnVideoResponse>b__85_0()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        RewardMultiPicked(multi:  public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 72);
        System.Collections.IEnumerator val_3 = this.SetupPostMinigameState();
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  -508962608);
        return true;
    }

}
