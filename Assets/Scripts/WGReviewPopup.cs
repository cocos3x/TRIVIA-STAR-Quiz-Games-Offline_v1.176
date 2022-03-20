using UnityEngine;
public class WGReviewPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text titleBannerText;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.GameObject reviewSection;
    private UnityEngine.UI.Toggle[] stars;
    private UnityEngine.UI.Button submitButton;
    private UnityEngine.GameObject shareSection;
    private UnityEngine.UI.Button shareButton;
    private UnityEngine.GameObject[] yourStars;
    private UnityEngine.UI.Text shareRewardText;
    private TMPro.TextMeshProUGUI rateRewardText_rate;
    private UnityEngine.GameObject feedbackTypeSection;
    private UnityEngine.GameObject feedbackSuggestionOnlyParent;
    private UnityEngine.UI.Button feedbackGiveButton;
    private UnityEngine.UI.Button feedbackDeclineButton;
    private UnityEngine.UI.Button feedbackLessAdsButton;
    private UnityEngine.UI.Button feedbackMoreCoinsButton;
    private UnityEngine.UI.Button feedbackOtherSuggestions;
    private UnityEngine.UI.Text feedbackText;
    private UnityEngine.GameObject feedbackLessAdsSection;
    private UnityEngine.GameObject feedbackBonusCoinsSection;
    private UnityEngine.GameObject feedbackGiveSuggestionSection;
    private UnityEngine.GameObject noAdsGift;
    private UnityEngine.UI.Button noAdsButton;
    private UnityEngine.UI.Text noAdsText;
    private UnityEngine.GameObject freeTrialGift;
    private UnityEngine.UI.Button freeTrialButton;
    private UnityEngine.UI.Text freeTrialDurationText;
    private UnityEngine.GameObject thanksSection;
    protected UnityEngine.UI.Button collectButton;
    private UnityEngine.UI.Text thanksRewardText;
    private GridCoinCollectAnimationInstantiator coinsAnim;
    private UnityEngine.UI.Text thanksRatingText;
    private TMPro.TextMeshProUGUI rateRewardText_thanks;
    private UnityEngine.GameObject f_thanksSection;
    private UnityEngine.UI.Button continueButton;
    private UnityEngine.UI.Text thanksFeedbackText;
    private UnityEngine.GameObject thanksFeedbackCloseButton;
    private UnityEngine.GameObject thanksFreeGiftSection;
    private UnityEngine.GameObject thanksGiftText;
    private bool didReview;
    protected decimal rateReward;
    private int currentStarRating;
    
    // Properties
    public int CurrentStarRating { get; set; }
    
    // Methods
    public int get_CurrentStarRating()
    {
        int val_1 = this.currentStarRating;
        val_1 = val_1 + 1;
        return (int)val_1;
    }
    public void set_CurrentStarRating(int value)
    {
        var val_3;
        this.currentStarRating = value;
        val_3 = 0;
        goto label_1;
        label_6:
        UnityEngine.UI.Toggle val_3 = this.stars[val_3];
        if(val_3 <= this.currentStarRating)
        {
                0 = 1;
        }
        
        val_3.isOn = true;
        val_3 = 1;
        label_1:
        if(val_3 < val_3)
        {
            goto label_6;
        }
        
        if(this.submitButton == 0)
        {
                return;
        }
        
        this.submitButton.interactable = (~this.currentStarRating) >> 31;
    }
    private void Start()
    {
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        this.didReview = false;
        GameEcon val_1 = App.getGameEcon;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        var val_22 = 28659803;
        public static WGReviewManager MonoSingleton<WGReviewManager>::get_Instance().__il2cppRuntimeField_14 = 0;
        val_22 = 6965984 + val_22;
        if(val_22 == 0)
        {
                mem2[0] = 1;
        }
        
        val_22 = null;
        val_22 = null;
        if(App.game == 16)
        {
            goto label_28;
        }
        
        if(val_22 == 0)
        {
                mem2[0] = 1;
        }
        
        val_23 = null;
        val_23 = null;
        if(App.game == 17)
        {
            goto label_28;
        }
        
        if(val_22 == 0)
        {
                mem2[0] = 1;
        }
        
        val_24 = null;
        val_24 = null;
        if(App.game == 99)
        {
            goto label_28;
        }
        
        if(val_22 == 0)
        {
                mem2[0] = 1;
        }
        
        val_25 = null;
        val_25 = null;
        if(App.game == 20)
        {
            goto label_28;
        }
        
        if(val_22 == 0)
        {
                mem2[0] = 1;
        }
        
        val_26 = null;
        val_26 = null;
        if(App.game != 21)
        {
            goto label_34;
        }
        
        label_28:
        label_83:
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  33494640, method:  new IntPtr(33346736));
        this.submitButton.m_OnClick.AddListener(call:  162246656);
        if(this.shareButton != 0)
        {
                UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  33494640, method:  new IntPtr(33360048));
            this.shareButton.m_OnClick.AddListener(call:  162246656);
        }
        
        if(this.feedbackGiveButton != 0)
        {
                UnityEngine.Events.UnityAction val_7 = new UnityEngine.Events.UnityAction(object:  33494640, method:  new IntPtr(33373360));
            this.feedbackGiveButton.m_OnClick.AddListener(call:  162246656);
        }
        
        if(this.feedbackDeclineButton != 0)
        {
                UnityEngine.Events.UnityAction val_9 = new UnityEngine.Events.UnityAction(object:  33494640, method:  new IntPtr(33386672));
            this.feedbackDeclineButton.m_OnClick.AddListener(call:  162246656);
        }
        
        if(this.collectButton != 0)
        {
                UnityEngine.Events.UnityAction val_11 = new UnityEngine.Events.UnityAction(object:  33494640, method:  typeof(WGReviewPopup).__il2cppRuntimeField_E0);
            this.collectButton.m_OnClick.AddListener(call:  162246656);
        }
        
        if(this.continueButton != 0)
        {
                UnityEngine.Events.UnityAction val_13 = new UnityEngine.Events.UnityAction(object:  33494640, method:  new IntPtr(33412272));
            this.continueButton.m_OnClick.AddListener(call:  162246656);
        }
        
        if(this.feedbackLessAdsButton != 0)
        {
                UnityEngine.Events.UnityAction val_15 = new UnityEngine.Events.UnityAction(object:  33494640, method:  new IntPtr(33425584));
            this.feedbackLessAdsButton.m_OnClick.AddListener(call:  162246656);
        }
        
        if(this.feedbackMoreCoinsButton != 0)
        {
                UnityEngine.Events.UnityAction val_17 = new UnityEngine.Events.UnityAction(object:  33494640, method:  new IntPtr(33438896));
            this.feedbackMoreCoinsButton.m_OnClick.AddListener(call:  162246656);
        }
        
        if(this.feedbackOtherSuggestions != 0)
        {
                UnityEngine.Events.UnityAction val_19 = new UnityEngine.Events.UnityAction(object:  33494640, method:  new IntPtr(33452208));
            this.feedbackOtherSuggestions.m_OnClick.AddListener(call:  162246656);
        }
        
        UnityEngine.Events.UnityAction val_20 = new UnityEngine.Events.UnityAction(object:  33494640, method:  new IntPtr(33386672));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        LoadAppReview();
        return;
        label_34:
        if(this.submitButton != 0)
        {
            goto label_83;
        }
        
        goto label_83;
    }
    private void OnEnable()
    {
        UnityEngine.GameObject val_1 = this.closeButton.gameObject;
        this.closeButton.SetActive(value:  true);
        this.reviewSection.SetActive(value:  true);
        GameEcon val_2 = App.getGameEcon;
        string val_3 = 0.titleFormat;
        string val_4 = Localization.Localize(key:  33717808, defaultValue:  33717920, useSingularKey:  false);
        string val_5 = System.String.Format(format:  null, arg0:  33717808);
        this.shareSection.SetActive(value:  false);
        if(this.feedbackTypeSection != 0)
        {
                this.feedbackTypeSection.SetActive(value:  false);
        }
        
        this.feedbackSuggestionOnlyParent.SetActive(value:  false);
        this.thanksSection.SetActive(value:  false);
        this.f_thanksSection.SetActive(value:  false);
        this.SetupReview();
        if(this.submitButton == 0)
        {
                return;
        }
        
        this.submitButton.interactable = false;
    }
    private void OnDisable()
    {
        this.StopAllCoroutines();
    }
    private void SetupReview()
    {
        GameEcon val_1 = App.getGameEcon;
        string val_2 = 0.titleFormat;
        string val_3 = Localization.Localize(key:  33717808, defaultValue:  33717920, useSingularKey:  false);
        string val_4 = System.String.Format(format:  null, arg0:  33717808);
        this.CurrentStarRating = 0;
    }
    private void SetupShare()
    {
        decimal val_10;
        var val_12;
        var val_13;
        var val_14;
        var val_16;
        val_10 = 1152921504892043264;
        GameEcon val_1 = App.getGameEcon;
        val_12 = 0;
        string val_2 = 0.titleFormat;
        string val_3 = Localization.Localize(key:  -39464832, defaultValue:  -39464928, useSingularKey:  false);
        string val_4 = System.String.Format(format:  null, arg0:  -39464832);
        if(this.titleBannerText != 0)
        {
            goto label_5;
        }
        
        goto label_5;
        label_10:
        UnityEngine.GameObject val_10 = this.yourStars[val_12];
        if(val_12 <= this.currentStarRating)
        {
                0 = 1;
        }
        
        val_10.SetActive(value:  true);
        val_12 = 1;
        label_5:
        if(val_12 < val_10)
        {
            goto label_10;
        }
        
        var val_11 = 28656179;
        val_11 = 6969608 + val_11;
        if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
        val_13 = null;
        val_13 = null;
        if(App.game == 15)
        {
                val_10 = this.rateReward;
            decimal val_5 = new System.Decimal(value:  100);
            decimal val_6 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 34242232, hi = val_10, lo = this.currentStarRating, mid = 1}, d2:  new System.Decimal() {flags = this.shareRewardText, hi = val_5.flags, lo = val_5.hi, mid = val_5.lo});
            val_16 = null;
            val_16 = null;
            string val_7 = ToString(format:  GameEcon.numberFormatDecimal);
            if(this.rateRewardText_rate != 0)
        {
                return;
        }
        
            return;
        }
        
        GameEcon val_8 = App.getGameEcon;
        val_14 = 0;
        string val_9 = this.rateReward.ToString(format:  null);
    }
    private void SetupFeedback_v1()
    {
        GameEcon val_1 = App.getGameEcon;
        string val_2 = 0.titleFormat;
        string val_3 = Localization.Localize(key:  -39464832, defaultValue:  -39464928, useSingularKey:  false);
        string val_4 = System.String.Format(format:  null, arg0:  -39464832);
        this.feedbackSuggestionOnlyParent.SetActive(value:  true);
    }
    private void SetupFeedback()
    {
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        val_15 = this;
        val_16 = 1152921504892043264;
        GameEcon val_1 = App.getGameEcon;
        string val_2 = 0.titleFormat;
        string val_3 = Localization.Localize(key:  -39464832, defaultValue:  -39464928, useSingularKey:  false);
        string val_4 = System.String.Format(format:  null, arg0:  -39464832);
        this.feedbackLessAdsSection.SetActive(value:  false);
        this.feedbackBonusCoinsSection.SetActive(value:  false);
        this.feedbackGiveSuggestionSection.SetActive(value:  false);
        GameBehavior val_5 = App.getBehavior;
        val_17 = 0;
        val_18 = WGSubscriptionManager.WillGetFreeTrial;
        Player val_7 = App.Player;
        var val_14 = 0;
        val_14 = val_17 & val_14;
        val_14 = val_18 & val_14;
        if(val_14 != true)
        {
            goto label_11;
        }
        
        this.feedbackTypeSection.SetActive(value:  true);
        this.feedbackBonusCoinsSection.SetActive(value:  true);
        UnityEngine.GameObject val_8 = this.feedbackMoreCoinsButton.gameObject;
        if(this.feedbackMoreCoinsButton != 0)
        {
            goto label_32;
        }
        
        label_33:
        label_32:
        this.feedbackMoreCoinsButton.SetActive(value:  true);
        if(this.feedbackLessAdsSection != 0)
        {
            goto label_26;
        }
        
        label_27:
        label_26:
        this.feedbackLessAdsSection.SetActive(value:  true);
        this.feedbackGiveSuggestionSection.SetActive(value:  true);
        if(this.feedbackText != 0)
        {
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_314;
        }
        
        goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_314;
        label_11:
        Player val_9 = App.Player;
        if(188 > 0)
        {
                0 = 1;
        }
        
        var val_10 = R5 & 1;
        val_10 = R6 & val_10;
        if(val_10 != 1)
        {
            goto label_22;
        }
        
        SB + 52.SetActive(value:  true);
        SB + 88.SetActive(value:  true);
        UnityEngine.GameObject val_11 = SB + 72.gameObject;
        if((SB + 72) != 0)
        {
            goto label_26;
        }
        
        goto label_27;
        label_22:
        Player val_12 = App.Player;
        var val_13 = R5 ^ 1;
        if(188 != 0)
        {
                188 = 1;
        }
        
        if(188 != 0)
        {
            goto label_31;
        }
        
        if((SB + 52) != 0)
        {
            goto label_32;
        }
        
        goto label_33;
        label_31:
        SB + 56.SetActive(value:  true);
    }
    private void SetupThanks(bool fromRating)
    {
        decimal val_27;
        var val_28;
        var val_29;
        UnityEngine.UI.Text val_30;
        var val_31;
        var val_33;
        var val_34;
        val_27 = fromRating;
        UnityEngine.GameObject val_1 = this.closeButton.gameObject;
        this.closeButton.SetActive(value:  false);
        if(this.coinsAnim != 0)
        {
                this.coinsAnim.SetActive(value:  true);
        }
        
        GameEcon val_3 = App.getGameEcon;
        string val_4 = 0.titleFormat;
        string val_5 = Localization.Localize(key:  -39464832, defaultValue:  -39464928, useSingularKey:  false);
        string val_6 = System.String.Format(format:  null, arg0:  -39464832);
        GameBehavior val_7 = App.getBehavior;
        if(0 != 0)
        {
                val_28 = "rfeedback_thanks_popup";
            string val_8 = Localization.Localize(key:  34771520, defaultValue:  34771328, useSingularKey:  false);
        }
        else
        {
                string val_9 = Localization.Localize(key:  34771808, defaultValue:  34771632, useSingularKey:  false);
            AppConfigs val_10 = App.Configuration;
            val_28 = "wgreviewpopup_feedback_rating";
            string val_11 = System.String.Format(format:  34771808, arg0:  0);
        }
        
        val_29 = val_28;
        bool val_12 = UnityEngine.Object.op_Implicit(exists:  this.thanksRatingText);
        val_30 = this.thanksFeedbackText;
        if((UnityEngine.Object.op_Implicit(exists:  val_30)) != false)
        {
                val_30 = this.thanksFeedbackText;
        }
        
        int val_27 = 28653407;
        val_27 = 6972380 + val_27;
        if(val_27 == 0)
        {
                mem2[0] = 1;
        }
        
        val_31 = null;
        val_31 = null;
        if(App.game != 15)
        {
            goto label_33;
        }
        
        if(val_27 == false)
        {
            goto label_34;
        }
        
        val_27 = this.rateReward;
        decimal val_14 = new System.Decimal(value:  100);
        decimal val_15 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 34812520, hi = val_27, lo = 34771808, mid = val_30}, d2:  new System.Decimal() {flags = val_27, hi = val_14.flags, lo = val_14.hi, mid = val_14.lo});
        val_33 = null;
        val_33 = null;
        string val_16 = ToString(format:  GameEcon.numberFormatDecimal);
        this.rateRewardText_thanks.text = 34812552;
        string val_17 = Localization.Localize(key:  34771808, defaultValue:  34771632, useSingularKey:  false);
        AppConfigs val_18 = App.Configuration;
        val_30 = 0;
        string val_19 = System.String.Format(format:  34771808, arg0:  0);
        val_29 = "wgreviewpopup_feedback_rating";
        val_34 = this;
        System.Collections.IEnumerator val_20 = this.WaitShowThanks_SCS();
        goto label_52;
        label_33:
        if(val_27 == false)
        {
            goto label_46;
        }
        
        GameEcon val_21 = App.getGameEcon;
        val_30 = 0;
        string val_22 = this.rateReward.ToString(format:  null);
        val_29 = this.rateReward;
        val_34 = this;
        System.Collections.IEnumerator val_23 = this.WaitShowThanks();
        goto label_52;
        label_34:
        val_34 = this;
        System.Collections.IEnumerator val_24 = this.WaitShowThanksF_SCS();
        goto label_52;
        label_46:
        val_34 = this;
        System.Collections.IEnumerator val_25 = this.WaitShowThanksF();
        label_52:
        UnityEngine.Coroutine val_26 = val_34.StartCoroutine(routine:  34824608);
    }
    private System.Collections.IEnumerator WaitShowThanks()
    {
        object val_1 = new System.Object();
        typeof(WGReviewPopup.<WaitShowThanks>d__53).__il2cppRuntimeField_8 = 0;
        typeof(WGReviewPopup.<WaitShowThanks>d__53).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator WaitShowThanksF()
    {
        object val_1 = new System.Object();
        typeof(WGReviewPopup.<WaitShowThanksF>d__54).__il2cppRuntimeField_8 = 0;
        typeof(WGReviewPopup.<WaitShowThanksF>d__54).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator WaitShowThanks_SCS()
    {
        object val_1 = new System.Object();
        typeof(WGReviewPopup.<WaitShowThanks_SCS>d__55).__il2cppRuntimeField_8 = 0;
        typeof(WGReviewPopup.<WaitShowThanks_SCS>d__55).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator WaitShowThanksF_SCS()
    {
        object val_1 = new System.Object();
        typeof(WGReviewPopup.<WaitShowThanksF_SCS>d__56).__il2cppRuntimeField_8 = 0;
        typeof(WGReviewPopup.<WaitShowThanksF_SCS>d__56).__il2cppRuntimeField_10 = this;
    }
    private void OnClick_Submit_v1()
    {
        this.reviewSection.SetActive(value:  false);
        int val_3 = this.currentStarRating;
        val_3 = val_3 + 1;
        if(val_3 >= 5)
        {
                this.shareSection.SetActive(value:  true);
            this.SetupShare();
        }
        else
        {
                if(val_3 >= 3)
        {
                this.SetupThanks(fromRating:  false);
        }
        else
        {
                this.SetupFeedback_v1();
        }
        
        }
        
        this.didReview = true;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HandleReviewSelected(rating:  this.currentStarRating + 1, forceTracking:  true);
    }
    private void OnClick_Submit()
    {
        this.reviewSection.SetActive(value:  false);
        if(this.currentStarRating == 4)
        {
                this.shareSection.SetActive(value:  true);
            this.SetupShare();
        }
        else
        {
                this.SetupFeedback();
        }
        
        this.didReview = true;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HandleReviewSelected(rating:  this.currentStarRating + 1, forceTracking:  false);
    }
    private void OnClick_Share()
    {
        this.shareSection.SetActive(value:  false);
        this.SetupThanks(fromRating:  true);
        TrackingComponent.CurrentIntent = 6;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ShowInAppReview();
    }
    private void OnClick_Feedback()
    {
        if(this.feedbackTypeSection != 0)
        {
                this.feedbackTypeSection.SetActive(value:  false);
        }
        
        this.feedbackSuggestionOnlyParent.SetActive(value:  false);
        if(this.thanksFeedbackCloseButton != 0)
        {
                this.thanksFeedbackCloseButton.SetActive(value:  true);
        }
        
        this.SetupThanks(fromRating:  false);
        Player val_3 = App.Player;
        if(16 != 0)
        {
                return;
        }
        
        WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        ShowSupport(prefillText:  1098586544);
    }
    private void OnClickTooManyAds()
    {
        this.feedbackTypeSection.SetActive(value:  false);
        this.noAdsGift.SetActive(value:  true);
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  35981360, method:  new IntPtr(35951968));
        this.noAdsButton.m_OnClick.AddListener(call:  162246656);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        GrantNoAdTime();
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_4 = System.String.Format(format:  35957088, arg0:  13152256);
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        DoAmpTracking(optionSelected:  35957264);
    }
    private void OnClickNotEnoughCoins()
    {
        this.feedbackTypeSection.SetActive(value:  false);
        this.freeTrialGift.SetActive(value:  true);
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  36134656, method:  new IntPtr(35951968));
        this.freeTrialButton.m_OnClick.AddListener(call:  162246656);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_3 = System.String.Format(format:  36110320, arg0:  13152256);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        TryGrantFreeTrial();
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        DoAmpTracking(optionSelected:  36110544);
    }
    private void OnClickOtherSuggestion()
    {
        this.feedbackTypeSection.SetActive(value:  false);
        this.feedbackSuggestionOnlyParent.SetActive(value:  false);
        UnityEngine.GameObject val_1 = this.feedbackLessAdsButton.gameObject;
        this.feedbackLessAdsButton.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.feedbackMoreCoinsButton.gameObject;
        this.feedbackMoreCoinsButton.SetActive(value:  false);
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        DoAmpTracking(optionSelected:  1152921513233041168);
        this.OnClick_Feedback();
    }
    private void OnClick_Decline()
    {
        this.Close();
    }
    protected virtual void OnClick_Collect()
    {
        int val_6;
        string val_8;
        var val_9;
        var val_10;
        var val_11;
        this.collectButton.interactable = false;
        val_8 = "Rate Bonus";
        CurrencyController.CreditBalance(value:  new System.Decimal() {flags = mem[this.rateReward + (0)], hi = mem[this.rateReward + (4)], lo = mem[this.rateReward + (8)], mid = mem[this.rateReward + (12)]}, source:  val_8, externalParams:  0, animated:  false);
        val_9 = 1152921504765685760;
        if(this.coinsAnim != 0)
        {
                System.Action val_2 = new System.Action(object:  36546608, method:  new IntPtr(36513392));
            this.coinsAnim.OnCompleteCallback = null;
            Player val_3 = App.Player;
            val_11 = val_11;
            val_10 = val_10;
            decimal val_4 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 36534556, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256, hi = this.rateReward, lo = ???, mid = this.coinsAnim});
            Player val_5 = App.Player;
            this.coinsAnim.Play(fromValue:  new System.Decimal() {mid = val_6}, toValue:  new System.Decimal() {flags = 52, hi = val_8}, textTickTime:  null, delayBeforeComplete:  null);
            val_9 = 1152921504765685760;
        }
        
        bool val_7 = UnityEngine.Object.op_Equality(x:  this.coinsAnim, y:  0);
        if(val_7 == true)
        {
                val_7 = this;
            this.Close();
        }
    
    }
    private void OnClick_Continue()
    {
        this.Close();
    }
    private void OnCoinsAnimFinished()
    {
        this.Close();
    }
    protected void Close()
    {
        var val_3;
        if(this.didReview == false)
        {
            goto label_1;
        }
        
        var val_3 = 28649175;
        val_3 = 6976612 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        if(App.game != 16)
        {
            goto label_7;
        }
        
        label_1:
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HandleReviewSelected(rating:  0, forceTracking:  false);
        label_7:
        UnityEngine.GameObject val_2 = this.gameObject;
        SLCWindow.CloseWindow(window:  36903088, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGReviewPopup()
    {
        this.currentStarRating = 4;
    }

}
