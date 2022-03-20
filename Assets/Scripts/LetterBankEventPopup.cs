using UnityEngine;
public class LetterBankEventPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject timer_group;
    private UnityEngine.UI.Text text_timer;
    private UnityEngine.UI.Text text_club_bank;
    private UnityEngine.GameObject leaderboard_group;
    private LetterBankMembersListView membersListView;
    private LetterBankProgressBar progress_bar;
    private UnityEngine.UI.Button button_close;
    private UnityEngine.UI.Button button_info;
    private UnityEngine.UI.Text text_play_level;
    private UnityEngine.UI.Button button_play_level;
    private UnityEngine.UI.Button button_continue_level;
    private UnityEngine.UI.Text text_body_message;
    private UGUINetworkedButton button_join_club;
    private UnityEngine.GameObject min_requirements_group;
    private UnityEngine.UI.Text text_min_requirements;
    private UnityEngine.GameObject info_popup;
    private FrameSkipper skipper;
    
    // Methods
    private void Awake()
    {
        System.Action<System.Boolean> val_14;
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1333337920, name:  -1664295744);
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1333337920, name:  -2005054624);
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        0.AddObserver(observer:  -1333337920, name:  442544128);
        NotificationCenter val_4 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1333337920, name:  -1341924384);
        UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  -1333337920, method:  new IntPtr(2961567488));
        this.button_close.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  -1333337920, method:  new IntPtr(2961576704));
        this.button_info.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_7 = new UnityEngine.Events.UnityAction(object:  -1333337920, method:  new IntPtr(2961585920));
        this.button_play_level.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_8 = new UnityEngine.Events.UnityAction(object:  -1333337920, method:  new IntPtr(2961585920));
        this.button_continue_level.m_OnClick.AddListener(call:  162246656);
        System.Action<System.Boolean> val_9 = new System.Action<System.Boolean>(object:  -1333337920, method:  new IntPtr(2961603328));
        System.Delegate val_10 = System.Delegate.Combine(a:  this.button_join_club.OnConnectionClick, b:  7401472);
        val_14 = this.button_join_club.OnConnectionClick;
        if(val_14 != 0)
        {
                if(null == null)
        {
            goto label_20;
        }
        
        }
        
        val_14 = 0;
        label_20:
        this.button_join_club.OnConnectionClick = val_14;
        UnityEngine.GameObject val_11 = this.gameObject;
        object val_12 = this.AddComponent<System.Object>();
        this.skipper = this;
        System.Action val_13 = new System.Action(object:  -1333337920, method:  new IntPtr(2961604352));
        this.leaderboard_group = null;
    }
    public void OnMyProfileUpdate()
    {
        this.RefreshUI(onEnable:  false);
    }
    public void OnFacebookPluginUpdate(Notification notification)
    {
        this.RefreshUI(onEnable:  false);
    }
    public void OnMyGuildUpdate()
    {
        this.RefreshUI(onEnable:  false);
    }
    public void OnLetterBankEventDataUpdate()
    {
        this.RefreshUI(onEnable:  false);
    }
    private void OnEnable()
    {
        this.RefreshUI(onEnable:  true);
    }
    private void RefreshUI(bool onEnable = False)
    {
        float val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        bool val_39;
        UnityEngine.GameObject val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        string val_1 = Localization.Localize(key:  -1672741904, defaultValue:  2127161280, useSingularKey:  false);
        GameBehavior val_2 = App.getBehavior;
        string val_3 = System.String.Format(format:  -1672741904, arg0:  13152256);
        UnityEngine.GameObject val_4 = this.button_join_club.gameObject;
        val_30 = 1152921505048485888;
        SLC.Social.Leagues.LeaguesDataController val_5 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Leagues.Guild val_6 = 0.MyGuild;
        this.button_join_club.SetActive(value:  false);
        val_31 = 0;
        UnityEngine.GameObject val_7 = this.button_play_level.gameObject;
        SLC.Social.Leagues.LeaguesDataController val_8 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Leagues.Guild val_9 = 0.MyGuild;
        if(0 != 0)
        {
                GameBehavior val_10 = App.getBehavior;
            if(0 != 0)
        {
                val_31 = 1;
        }
        
        }
        
        this.button_play_level.SetActive(value:  true);
        UnityEngine.GameObject val_11 = this.button_continue_level.gameObject;
        val_32 = 0;
        SLC.Social.Leagues.LeaguesDataController val_12 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Leagues.Guild val_13 = 0.MyGuild;
        if(0 != 0)
        {
                GameBehavior val_14 = App.getBehavior;
            val_32 = 0;
        }
        
        this.button_continue_level.SetActive(value:  true);
        UnityEngine.GameObject val_15 = this.text_club_bank.gameObject;
        val_33 = 11876500 + 23760795;
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        val_34 = null;
        val_34 = null;
        if(LetterBankEventHandler._EligibleForEvent == true)
        {
                LetterBankEventHandler._EligibleForEvent = 1;
        }
        
        this.text_club_bank.SetActive(value:  true);
        UnityEngine.GameObject val_16 = this.text_body_message.gameObject;
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        val_35 = null;
        val_35 = null;
        this.text_body_message.SetActive(value:  true);
        UnityEngine.GameObject val_17 = this.leaderboard_group.gameObject;
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        val_36 = null;
        val_36 = null;
        if(LetterBankEventHandler._EligibleForEvent == true)
        {
                LetterBankEventHandler._EligibleForEvent = 1;
        }
        
        this.leaderboard_group.SetActive(value:  true);
        UnityEngine.GameObject val_18 = this.progress_bar.gameObject;
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        val_37 = null;
        val_37 = null;
        if(LetterBankEventHandler._EligibleForEvent != false)
        {
                var val_29 = 23760237;
            val_29 = 11877064 + val_29;
            if(val_29 == 0)
        {
                mem2[0] = 1;
        }
        
            val_38 = null;
            val_38 = null;
            val_39 = LetterBankEventHandler._EligibleForRewards;
        }
        else
        {
                val_39 = 0;
        }
        
        if(val_39 != 0)
        {
                val_39 = 1;
        }
        
        this.progress_bar.SetActive(value:  true);
        val_40 = this.min_requirements_group;
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        val_41 = null;
        val_41 = null;
        if(LetterBankEventHandler._EligibleForEvent != false)
        {
                var val_30 = 23759953;
            val_30 = 11877348 + val_30;
            if(val_30 == 0)
        {
                mem2[0] = 1;
        }
        
            val_42 = null;
            val_42 = null;
            val_43 = LetterBankEventHandler._EligibleForRewards ^ 1;
        }
        else
        {
                val_43 = 0;
        }
        
        if(val_43 != 0)
        {
                val_43 = 1;
        }
        
        val_40.SetActive(value:  true);
        if(val_33 == 0)
        {
                mem2[0] = 1;
        }
        
        val_44 = null;
        val_44 = null;
        if(LetterBankEventHandler._EligibleForEvent != false)
        {
                var val_31 = 23759666;
            val_31 = 11877636 + val_31;
            if(val_31 == 0)
        {
                mem2[0] = 1;
        }
        
            val_45 = null;
            val_45 = null;
            string val_19 = LetterBankEventHandler._TotalClubBank.ToString();
            this.progress_bar.UpdateSlider();
            string val_20 = Localization.Localize(key:  -1332591392, defaultValue:  -1332591616, useSingularKey:  false);
            val_30 = "letter_bank_minimum";
            val_46 = null;
            val_46 = null;
            val_33 = 35637306;
            val_47 = null;
            val_47 = null;
            string val_21 = System.String.Format(format:  -1332591392, arg0:  13152256, arg1:  13152256);
            val_40 = this.membersListView;
            UnityEngine.GameObject val_22 = this.gameObject;
            val_48 = null;
            val_48 = null;
            val_40.Refresh(parentWindowObject:  -1332558464, eventPlayers:  LetterBankEventHandler._EventPlayers, refillCells:  onEnable);
            if(onEnable == false)
        {
                return;
        }
        
            System.Collections.Generic.List<GiftReward> val_23 = LetterBankEventHandler.GetCollectableRewards();
            if(null == 0)
        {
                return;
        }
        
            GameBehavior val_24 = App.getBehavior;
            LetterBankEventHandler.CollectedTierReward();
            return;
        }
        
        SLC.Social.Leagues.LeaguesDataController val_26 = SLC.Social.Leagues.LeaguesManager.DAO;
        SLC.Social.Leagues.Guild val_27 = 0.MyGuild;
        if(0 == 0)
        {
                "letter_bank_ineligible" = "letter_bank_must_join";
        }
        
        if(0 == 0)
        {
                "YOU ARE NOT ELIGIBLE TO PARTICIPATE IN THIS EVENT. PLEASE SEE EVENT INFO FOR EVENT RULES." = "MUST JOIN A CLUB TO PARTICIPATE";
        }
        
        string val_28 = Localization.Localize(key:  -1332583088, defaultValue:  -1332582864, useSingularKey:  false);
    }
    public void ShowGameplayVersion()
    {
        this.timer_group.SetActive(value:  false);
    }
    private void UpdateTimer()
    {
        long val_2;
        var val_8;
        var val_8 = 23757852;
        val_8 = 11879456 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_8 = null;
        val_8 = null;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511864504696}, d2:  new System.DateTime() {dateData = LetterBankEventHandler._EventEndTime});
        string val_7 = val_4._ticks.FormatTimeRemaining(timeSpan:  new System.TimeSpan() {_ticks = val_2});
        if(this.text_timer != 0)
        {
                return;
        }
    
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
    private void OnCloseClicked()
    {
        var val_2;
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1332036736, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        var val_2 = 23757109;
        val_2 = 11880200 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        if(LetterBankEventHandler.level_letters_accum_key == null)
        {
            
        }
    
    }
    private void OnInfoClicked()
    {
        this.info_popup.SetActive(value:  true);
    }
    private void OnPlayClicked()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1331804544, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        GameBehavior val_2 = App.getBehavior;
        if(0 == 2)
        {
                return;
        }
        
        GameBehavior val_3 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    private void OnJoinClubClicked(bool connected)
    {
        var val_10;
        var val_11;
        if(connected != false)
        {
                var val_10 = 23744991;
            val_10 = 11880800 + val_10;
            if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
            val_10 = null;
            val_10 = null;
            AmplitudePluginHelper.lastFeatureAccessPoint = 101;
            GameBehavior val_1 = App.getBehavior;
            if(0 != 4)
        {
                GameBehavior val_2 = App.getBehavior;
        }
        
            UnityEngine.GameObject val_4 = this.gameObject;
            SLCWindow.CloseWindow(window:  -1331692544, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            return;
        }
        
        GameBehavior val_5 = App.getBehavior;
        string val_7 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_8 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_9 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_11 = 0;
        if(val_11 == 0)
        {
                val_11 = 0;
        }
        
        val_11.SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
    }
    public LetterBankEventPopup()
    {
    
    }

}
