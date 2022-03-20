using UnityEngine;
public class TournamentsPopup : MonoBehaviour
{
    // Fields
    public bool allowProfileAccess;
    private TournamentsTierDisplay main_tier_display;
    private UnityEngine.UI.Text text_timer;
    private TournamentsMembersListView membersView;
    private UnityEngine.UI.Button prizesButton;
    private UnityEngine.UI.Button infoButton;
    private UnityEngine.UI.Button closeButton;
    private TournamentsMemberGridItem fixedPlayerGridItem;
    private UnityEngine.GameObject pizesTooltip;
    private UnityEngine.UI.Text[] rankGroups;
    private UnityEngine.UI.Text[] prizeGifts;
    private UnityEngine.UI.Text[] prizeCoins;
    private UnityEngine.UI.Text[] prizeGems;
    private UnityEngine.GameObject[] prizePromotion;
    private UnityEngine.GameObject[] prizeDemotion;
    private TournamentsTierDisplay prizes_tier_display;
    private UnityEngine.GameObject infoTooltip;
    private UnityEngine.UI.Text infoDescription;
    private TournamentInfo tournamentInfo;
    private FrameSkipper skipper;
    
    // Methods
    private void Awake()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1664242960, name:  -1664295744);
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1664242960, name:  -2005054624);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -1664242960, method:  new IntPtr(2630679856));
        this.prizesButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -1664242960, method:  new IntPtr(2630689072));
        this.infoButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  -1664242960, method:  new IntPtr(2630698288));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.GameObject val_6 = this.gameObject;
        object val_7 = this.AddComponent<System.Object>();
        this.skipper = this;
        System.Action val_8 = new System.Action(object:  -1664242960, method:  new IntPtr(2630699312));
        this.membersView = null;
    }
    public void OnMyProfileUpdate()
    {
        this.RefreshUI(onEnable:  false);
    }
    public void OnFacebookPluginUpdate(Notification notification)
    {
        this.RefreshUI(onEnable:  false);
    }
    private void OnEnable()
    {
        this.RefreshUI(onEnable:  true);
    }
    private void RefreshUI(bool onEnable = False)
    {
        var val_9;
        var val_10;
        var val_11;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.tournamentInfo = null;
        if((public static TournamentsManager MonoSingleton<TournamentsManager>::get_Instance().__il2cppRuntimeField_C) != 0)
        {
                MonoSingleton<T>.__il2cppRuntimeField_cctor_finished = mem[public static TournamentsManager MonoSingleton<TournamentsManager>::get_Instance().__il2cppRuntimeField_C + 28];
            MonoSingleton<T>.__il2cppRuntimeField_cctor_finished = public static TournamentsManager MonoSingleton<TournamentsManager>::get_Instance().__il2cppRuntimeField_C + 28;
        }
        
        GameBehavior val_2 = App.getBehavior;
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_4 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_9 = null;
        val_10 = null;
        val_11 = 0;
        if( == 0)
        {
                val_11 = 0;
        }
        
        val_11.SetupMessage(titleTxt:  -1663756496, messageTxt:  -1671479392, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
        UnityEngine.GameObject val_7 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1663723184, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void ShowMyProfileFlyout(int whocares)
    {
        if(this.allowProfileAccess == false)
        {
                return;
        }
        
        SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Profile val_2 = 0.MyProfile;
        SLC.Social.Leagues.LeaguesUIManager.ShowPlayerProfile(serverId:  0, gridItem:  0);
    }
    private void RefreshPrizesTooltip()
    {
        int val_20;
        var val_21;
        var val_22;
        val_20 = this.tournamentInfo.tierIndex;
        this.prizes_tier_display.RefreshDisplay(tierIndex:  val_20);
        val_21 = 0;
        goto label_3;
        label_66:
        val_22 = null;
        UnityEngine.UI.Text val_20 = this.rankGroups[val_21];
        val_22 = null;
        System.Int32[][] val_1 = TournamentsEconomy.giftRewardsByTier + (this.tournamentInfo.tierIndex << 2);
        var val_2 = ((TournamentsEconomy.giftRewardsByTier + (this.tournamentInfo.tierIndex) << 2) + 16) + 0;
        UnityEngine.UI.Text val_21 = this.prizeGifts[val_21];
        UnityEngine.Transform val_3 = val_21.transform;
        UnityEngine.Transform val_4 = val_21.parent;
        UnityEngine.GameObject val_5 = val_21.gameObject;
        if((((TournamentsEconomy.giftRewardsByTier + (this.tournamentInfo.tierIndex) << 2) + 16 + 0) + 16) > 0)
        {
                0 = 1;
        }
        
        val_21.SetActive(value:  true);
        UnityEngine.UI.Text val_22 = this.prizeGifts[val_21];
        string val_6 = ((TournamentsEconomy.giftRewardsByTier + (this.tournamentInfo.tierIndex) << 2) + 16 + 0) + 16.ToString();
        System.Int32[][] val_7 = TournamentsEconomy.coinRewardsByTier + (this.tournamentInfo.tierIndex << 2);
        var val_8 = ((TournamentsEconomy.coinRewardsByTier + (this.tournamentInfo.tierIndex) << 2) + 16) + 0;
        UnityEngine.UI.Text val_23 = this.prizeCoins[val_21];
        UnityEngine.Transform val_9 = val_23.transform;
        UnityEngine.Transform val_10 = val_23.parent;
        UnityEngine.GameObject val_11 = val_23.gameObject;
        if((((TournamentsEconomy.coinRewardsByTier + (this.tournamentInfo.tierIndex) << 2) + 16 + 0) + 16) > 0)
        {
                0 = 1;
        }
        
        val_23.SetActive(value:  true);
        string val_12 = ((TournamentsEconomy.coinRewardsByTier + (this.tournamentInfo.tierIndex) << 2) + 16 + 0) + 16.ToString();
        var val_25 = this.prizeCoins[val_21];
        System.Int32[][] val_13 = TournamentsEconomy.gemOrPetFoodRewardsByTier;
        val_25 = val_25 + (this.tournamentInfo.tierIndex << 2);
        UnityEngine.UI.Text val_26 = this.prizeGems[val_21];
        UnityEngine.Transform val_14 = val_26.transform;
        UnityEngine.Transform val_15 = val_26.parent;
        UnityEngine.GameObject val_16 = val_26.gameObject;
        if(UnityEngine.UI.Text.__il2cppRuntimeField_byval_arg > 0)
        {
                0 = 1;
        }
        
        val_26.SetActive(value:  true);
        UnityEngine.UI.Text val_27 = this.prizeGems[val_21];
        string val_17 = UnityEngine.UI.Text.__il2cppRuntimeField_byval_arg.ToString();
        if((TournamentsEconomy.promotionByRankGroup + 12 + 16) > 0)
        {
                0 = 1;
        }
        
        if(this.tournamentInfo.tierIndex != 0)
        {
                this.tournamentInfo.tierIndex = 1;
        }
        
        this.prizePromotion[val_21].SetActive(value:  true);
        UnityEngine.GameObject val_29 = this.prizeDemotion[val_21];
        val_20 = TournamentsEconomy.TierIndexCanDemote(tierIndex:  this.tournamentInfo.tierIndex);
        if((TournamentsEconomy.promotionByRankGroup + 12 + 16) < 0)
        {
                0 = 1;
        }
        
        val_29.SetActive(value:  1 & val_20);
        val_21 = 1;
        label_3:
        if(val_21 < val_29)
        {
            goto label_66;
        }
    
    }
    private void RefreshInfoTooltip()
    {
        var val_12;
        var val_13;
        var val_14;
        string val_1 = Localization.Localize(key:  -1662505712, defaultValue:  -1662505968, useSingularKey:  false);
        val_12 = null;
        val_12 = null;
        string val_2 = ToString();
        string val_3 = System.String.Format(format:  -1662505712, arg0:  301973508);
        var val_12 = 25355023;
        val_12 = 10270764 + val_12;
        if(val_12 == 0)
        {
                mem2[0] = 1;
        }
        
        val_13 = null;
        val_13 = null;
        if(App.game == 17)
        {
                "Earn #currency by getting long streaks during levels." = "Earn #currency by completing quizzes!";
        }
        
        if(App.game == 17)
        {
                "tournament_info_2" = "tournament_info_2_trv";
        }
        
        string val_4 = Localization.Localize(key:  -1662505280, defaultValue:  -1662505600, useSingularKey:  false);
        string val_5 = Localization.Localize(key:  -1662505056, defaultValue:  -1662504944, useSingularKey:  false);
        val_14 = null;
        val_14 = null;
        string val_6 = ToString();
        string val_7 = System.String.Format(format:  -1662505056, arg0:  301973512);
        string val_8 = Localization.Localize(key:  -1662504752, defaultValue:  -1662504640, useSingularKey:  false);
        string val_9 = ToString();
        string val_10 = System.String.Format(format:  -1662504752, arg0:  301973516);
        typeof(System.Object[]).__il2cppRuntimeField_10 = "tournament_info_1";
        typeof(System.Object[]).__il2cppRuntimeField_14 = "tournament_info_2_trv";
        typeof(System.Object[]).__il2cppRuntimeField_18 = "tournament_info_3";
        typeof(System.Object[]).__il2cppRuntimeField_1C = "tournament_info_4";
        string val_11 = System.String.Format(format:  -1662500352, args:  472754880);
        if(this.infoDescription == 0)
        {
            
        }
    
    }
    private void UpdateTimer()
    {
        long val_2;
        if(this.tournamentInfo == 0)
        {
                return;
        }
        
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511534417576}, d2:  new System.DateTime() {dateData = this.tournamentInfo.endTime});
        string val_7 = val_4._ticks.FormatTimeRemaining(timeSpan:  new System.TimeSpan() {_ticks = val_2});
    }
    private string FormatTimeRemaining(System.TimeSpan timeSpan)
    {
        double val_1 = ???.TotalSeconds;
        int val_2 = ???.Days;
        int val_3 = ???.Hours;
        val_3 = val_3 + ((val_2 + (val_2 << 1)) << 3);
        int val_5 = ???.Minutes;
        int val_6 = ???.Seconds;
        string val_7 = System.String.Format(format:  -1662255760, arg0:  13152256, arg1:  13152256, arg2:  13152256);
    }
    private void OnPrizesClicked()
    {
        UnityEngine.GameObject val_1 = this.pizesTooltip.gameObject;
        this.pizesTooltip.SetActive(value:  true);
    }
    private void OnInfoClicked()
    {
        UnityEngine.GameObject val_1 = this.infoTooltip.gameObject;
        this.infoTooltip.SetActive(value:  true);
    }
    private void OnCloseClicked()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1661879168, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public TournamentsPopup()
    {
        this.allowProfileAccess = true;
    }

}
