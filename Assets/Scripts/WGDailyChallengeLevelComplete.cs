using UnityEngine;
public class WGDailyChallengeLevelComplete : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject graphic_sun;
    private UnityEngine.GameObject graphic_moon;
    private UnityEngine.GameObject lessStarsGroup;
    private UnityEngine.UI.Text description;
    private UnityEngine.GameObject starPrefab;
    private UnityEngine.RectTransform progressParent;
    private UnityEngine.RectTransform progress;
    private DailyChallengeStarGroup starGroup;
    private UnityEngine.UI.Button button_continue_less_stars;
    private UnityEngine.UI.Button button_retry_less_stars;
    private UnityEngine.UI.Text retryUnlockAmount;
    private UnityEngine.GameObject fullStarsGroup;
    private UnityEngine.UI.Text coinReward;
    private UnityEngine.UI.Text appleReward;
    private UnityEngine.UI.Button button_continue_completed;
    private UnityEngine.GameObject regularReward;
    private UnityEngine.GameObject goldenGalaReward;
    private UnityEngine.GameObject[] starsImages;
    private UnityEngine.GameObject goldenGalaOverlay;
    private UnityEngine.UI.Text regularCoinReward;
    private UnityEngine.UI.Text regularAppleReward;
    private UnityEngine.UI.Text galaCoinReward;
    private UnityEngine.UI.Text galaAppleReward;
    private UnityEngine.Transform rewardSource;
    private UnityEngine.Transform middleSource;
    private UnityEngine.Transform leftSource;
    private UnityEngine.Transform rightSource;
    private UnityEngine.UI.Button button_gala_rewards;
    private GridCoinCollectAnimationInstantiator coinsAnim;
    private GoldenCurrencyCollectAnimationInstantiator goldenCurrencyAnimControl;
    private GoldenCurrencyCollectAnimationInstantiator goldenCurrencyAnimControl_mult;
    private UnityEngine.GameObject goldenMultiplierGroup;
    private UnityEngine.UI.Text goldenMultiplierBonusApples;
    private UnityEngine.GameObject[] dcStars;
    private DailyChallengeProgressUI weeklyProgressUI;
    private DailyChallengeProgressUI monthlyProgressUI;
    private UnityEngine.ParticleSystem weekStarParticles;
    private UnityEngine.ParticleSystem monthStarParticles;
    private float starPunchDuration;
    private const string COMPLETE_TEXT_MORNING = "Collect more Suns to earn 3 Stars!";
    private const string COMPLETE_TEXT_EVENING = "Collect more Moons to earn 3 Stars!";
    private const string FREE_COINS_SOURCE = "Daily Challenge";
    private int goldenApplesReward;
    private decimal galaCoinAmount;
    private int galaAppleAmount;
    private decimal retryCost;
    private bool dcRevamp;
    
    // Methods
    private void Awake()
    {
        var val_9;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -100646832, method:  new IntPtr(4194262672));
        this.button_retry_less_stars.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -100646832, method:  new IntPtr(4194271888));
        this.button_continue_less_stars.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -100646832, method:  new IntPtr(4194271888));
        this.button_continue_completed.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -100646832, method:  new IntPtr(4194289296));
        this.button_gala_rewards.m_OnClick.AddListener(call:  162246656);
        System.Action val_5 = new System.Action(object:  -100646832, method:  new IntPtr(4194294416));
        this.coinsAnim.OnCompleteCallback = null;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_7 = new System.Action<System.Boolean>(object:  -100646832, method:  new IntPtr(4194295440));
        System.Delegate val_8 = System.Delegate.Combine(a:  public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_9 = public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C;
        if(val_9 != 0)
        {
                if(val_9 == null)
        {
            goto label_15;
        }
        
        }
        
        val_9 = 0;
        label_15:
        public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C = val_9;
    }
    private void OnEnable()
    {
        this.UpdateUIForDay();
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  0, oneshot:  true, pitch:  null, vol:  null);
        this.button_continue_completed.interactable = false;
        this.button_continue_less_stars.interactable = false;
        this.button_retry_less_stars.interactable = false;
        this.button_gala_rewards.interactable = false;
    }
    private System.Collections.IEnumerator Start()
    {
        object val_1 = new System.Object();
        typeof(WGDailyChallengeLevelComplete.<Start>d__49).__il2cppRuntimeField_8 = 0;
        typeof(WGDailyChallengeLevelComplete.<Start>d__49).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator PlayNewStarAnimation()
    {
        object val_1 = new System.Object();
        typeof(WGDailyChallengeLevelComplete.<PlayNewStarAnimation>d__50).__il2cppRuntimeField_8 = 0;
        typeof(WGDailyChallengeLevelComplete.<PlayNewStarAnimation>d__50).__il2cppRuntimeField_10 = this;
    }
    private void UpdateUIForDay()
    {
        var val_33;
        float val_34;
        float val_35;
        UnityEngine.Transform val_36;
        var val_37;
        var val_38;
        UnityEngine.GameObject val_39;
        val_33 = this;
        val_34 = 1152921504901095424;
        val_35 = 1152921511080275808;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_60 + 16) != 0)
        {
                public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_60 + 16 = 1;
        }
        
        this.graphic_sun.SetActive(value:  true);
        this.graphic_moon.SetActive(value:  (public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_60) >> 5);
        this.lessStarsGroup.SetActive(value:  false);
        this.fullStarsGroup.SetActive(value:  false);
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.button_retry_less_stars.interactable = IsPlayingValid();
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.goldenApplesReward = GetGoldenAppleReward();
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        decimal val_8 = GetRetryCost();
        if(GoldenGalaHandler.dailyChallengeApple != null)
        {
                val_37 = GoldenGalaHandler.dailyChallengeApple ^ 1;
        }
        else
        {
                val_37 = 0;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(val_37 == 0)
        {
                if((public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_60 + 16) != 0)
        {
                "Collect more Moons to earn 3 Stars!" = "Collect more Suns to earn 3 Stars!";
        }
        
            if((public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_60 + 16) != 0)
        {
                "daily_challenge_evening_description" = "daily_challenge_morning_description";
        }
        
            string val_10 = Localization.Localize(key:  -100132432, defaultValue:  -100132720, useSingularKey:  false);
            string val_11 = this.retryCost.ToString();
            var val_34 = 0;
            UnityEngine.Rect val_12 = rect;
            do
        {
            UnityEngine.Transform val_14 = this.progressParent.transform;
            UnityEngine.Vector3 val_15 = GetStarPosition(index:  0, parent:  0, parentLength:  width);
            UnityEngine.Quaternion val_16 = UnityEngine.Quaternion.identity;
            UnityEngine.Transform val_17 = this.starGroup.transform;
            val_36 = this.starGroup;
            UnityEngine.GameObject val_18 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.starPrefab, position:  new UnityEngine.Vector3(), rotation:  new UnityEngine.Quaternion(), parent:  val_36);
            val_34 = val_34 + 1;
            val_33 = val_33;
        }
        while(val_34 != 3);
        
            this.starGroup.Setup(stars:  public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_60 + 24 + 8);
            val_34 = 1152921504901095424;
            val_35 = 1152921511080275808;
            object val_19 = this.progress.GetComponent<System.Object>();
            twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_39 = mem[public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_60 + 24];
            val_39 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_60 + 24;
            float val_35 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_60 + 24 + 24;
            val_35 = 4194991480 * val_35;
            UnityEngine.Vector2 val_21 = new UnityEngine.Vector2(x:  val_35, y:  val_16.y);
            this.progress.sizeDelta = new UnityEngine.Vector2() {x = val_21.x, y = val_21.y};
            this.lessStarsGroup.SetActive(value:  true);
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_24 = (public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_64 + 20 + 12).ToString();
            string val_25 = this.goldenApplesReward.ToString();
            val_38 = this.goldenApplesReward;
            this.fullStarsGroup.SetActive(value:  true);
            this.regularReward.SetActive(value:  val_37 ^ 1);
            val_39 = this.goldenGalaReward;
            val_39.SetActive(value:  false);
            if(val_37 != 0)
        {
                val_39 = val_33;
            this.SetupGalaRewards();
        }
        
        }
        
        if(this.dcRevamp == false)
        {
            goto label_56;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_27 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_29 = (public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_64 + 20 + 12).ToString();
        val_38 = 0;
        string val_30 = this.goldenApplesReward.ToString();
        if(this.appleReward != 0)
        {
            goto label_64;
        }
        
        goto label_64;
        label_69:
        UnityEngine.GameObject val_36 = this.dcStars[val_38];
        if(val_38 < (public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_60 + 24 + 8))
        {
                0 = 1;
        }
        
        val_36.SetActive(value:  true);
        val_38 = 1;
        label_64:
        if(val_38 < val_36)
        {
            goto label_69;
        }
        
        label_56:
        DG.Tweening.TweenCallback val_31 = new DG.Tweening.TweenCallback(object:  -99963760, method:  new IntPtr(4194978512));
        DG.Tweening.Tween val_32 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1028443341, ignoreTimeScale:  false);
        bool val_33 = GoldenMultiplierManager.IsAvaialable;
        if(val_33 == true)
        {
                val_33 = val_33;
            this.SetupGoldenMultiplierUI();
        }
    
    }
    private void SetupGalaRewards()
    {
        var val_12;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_12 = 0;
        goto label_6;
        label_11:
        UnityEngine.GameObject val_12 = this.starsImages[val_12];
        if(val_12 < (public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_60 + 24 + 8))
        {
                0 = 1;
        }
        
        val_12.SetActive(value:  true);
        val_12 = 1;
        label_6:
        if(val_12 < val_12)
        {
            goto label_11;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_4 = (public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_64 + 20 + 12).ToString();
        string val_5 = this.goldenApplesReward.ToString();
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        this.galaAppleAmount = (GoldenGalaHandler.dailyChallengeApple + 52 + 8 + (public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_60 + 24 + 8) << 2) + 16;
        string val_7 = new System.Decimal().ToString();
        string val_8 = this.galaAppleAmount.ToString();
        this.goldenGalaOverlay.SetActive(value:  GoldenGalaHandler.dailyChallengeApple.IsSubscriptionActive ^ 1);
        UnityEngine.Vector3 val_11 = position;
        this.rewardSource.position = new UnityEngine.Vector3();
        this.coinsAnim.coinExpansionEnabled = false;
    }
    private void OnSubscriptionPurchaseAttempt(bool success)
    {
        this.goldenGalaOverlay.SetActive(value:  GoldenGalaHandler.dailyChallengeApple.IsSubscriptionActive ^ 1);
    }
    private UnityEngine.Vector3 GetStarPosition(int index, UnityEngine.Transform parent, float parentLength)
    {
        var val_2;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        (public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_64 + 20 + 20 + 8 + (parent) << 2) + 16.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        UnityEngine.Transform val_3 = R3.transform;
        float val_6 = (float)(public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_64 + 20 + 20 + 8 + (parent) << 2) + 16;
        val_6 = val_6 * val_2;
        val_6 = val_6 / 100f;
        UnityEngine.Vector3 val_4 = new UnityEngine.Vector3(x:  val_6, y:  null, z:  -0.5f);
        UnityEngine.Vector3 val_5 = this.TransformPoint(position:  new UnityEngine.Vector3() {x = R3, y = val_4.x, z = val_4.y});
        return new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
    }
    public void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -99114352, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnDisable()
    {
        var val_6;
        System.Action<System.Boolean> val_7;
        var val_8;
        val_6 = 1152921504901095424;
        val_7 = 1152921511299501312;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1897280256) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_7 = null;
        val_7 = new System.Action<System.Boolean>(object:  -99002352, method:  new IntPtr(4194295440));
        System.Delegate val_5 = System.Delegate.Remove(source:  public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C, value:  7401472);
        val_8 = public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C;
        if(val_8 != 0)
        {
                if(val_8 == null)
        {
            goto label_11;
        }
        
        }
        
        val_8 = 0;
        label_11:
        public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance().__il2cppRuntimeField_C = val_8;
    }
    private void OnRetryButtonClicked()
    {
        int val_20;
        var val_23;
        var val_24;
        var val_25;
        System.Action val_27;
        var val_28;
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -98889072, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        Player val_2 = App.Player;
        val_23 = 52;
        val_23 = val_23;
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal() {flags = this.retryCost, lo = ???, mid = this})) != false)
        {
                var val_21 = 26718393;
            val_21 = 8907668 + val_21;
            if(val_21 == 0)
        {
                mem2[0] = 1;
        }
        
            val_24 = null;
            val_24 = null;
            PurchaseProxy.currentPurchasePoint = 26;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_5 = ShowUGUIMonolith<System.Object>(showNext:  false);
            val_25 = null;
            val_25 = null;
            val_27 = WGDailyChallengeLevelComplete.<>c.<>9__57_0;
            if(val_27 == 0)
        {
                val_27 = null;
            val_27 = new System.Action(object:  WGDailyChallengeLevelComplete.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4196052944));
            WGDailyChallengeLevelComplete.<>c.<>9__57_0 = val_27;
        }
        
            Init(outOfCredits:  true, onCloseAction:  7454720);
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1448559232) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            CheckHomeClick();
        }
        
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        DailyChallengeGameLevel val_11 = CurrentLevel;
        public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_24 = 1;
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_28 = WGDailyChallengeManagerHelper.MorningChallengeAvailableNow() ^ ((public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_60 + 16) >> 5);
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        mem2[0] = ;
        twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Play();
        if( != 0)
        {
                "Daily Challenge Missed Days Retry" = "Daily Challenge Retry";
        }
        
        Player val_18 = App.Player;
        decimal val_19 = System.Decimal.op_UnaryNegation(d:  new System.Decimal() {flags = -98901124, hi = this.retryCost, lo = R6, mid = R7});
        0.AddCredits(amount:  new System.Decimal() {mid = val_20}, source:  "Daily Challenge Retry", subSource:  0, externalParams:  0, doTrack:  true);
    }
    private void OnGalaRewardsClicked()
    {
        var val_8;
        var val_9;
        var val_6 = 26717155;
        val_6 = 8909968 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_8 = null;
        if(GoldenGalaHandler.dailyChallengeApple.IsSubscriptionActive != false)
        {
                GameBehavior val_2 = App.getBehavior;
            val_9 = mem[(1179403647 + (public WGGoldenGalaInfoPopup MetaGameBehavior::ShowUGUIFlyOut<WGGoldenGalaInfoPopup>().__il2cppRuntimeField_28) << 3) + 192];
            val_9 = (1179403647 + (public WGGoldenGalaInfoPopup MetaGameBehavior::ShowUGUIFlyOut<WGGoldenGalaInfoPopup>().__il2cppRuntimeField_28) << 3) + 192;
            val_8 = 0;
        }
        else
        {
                GameBehavior val_4 = App.getBehavior;
            WGSubscriptionManager._subEntryPoint = 67;
        }
    
    }
    private void ShowDailyChallengePopup()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        var val_4 = 26720675;
        val_4 = 8910556 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_68 = 0;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_3 = ShowUGUIMonolith<System.Object>(showNext:  true);
    }
    private void GrantCompleteReward()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        int val_21;
        int val_22;
        int val_23;
        int val_23;
        var val_24;
        WGDailyChallengeLevelComplete val_25;
        float val_26;
        var val_27;
        GridCoinCollectAnimationInstantiator val_28;
        var val_29;
        int val_30;
        if(this.coinsAnim == 0)
        {
                return;
        }
        
        this.button_continue_less_stars.interactable = false;
        this.button_retry_less_stars.interactable = false;
        this.button_continue_completed.interactable = false;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        decimal val_4 = GetReward;
        val_6 = 0;
        val_5 = 0;
        val_7 = 0;
        val_8 = 0;
        val_23 = 0;
        Add(key:  -2092883952, value:  10170368);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_10 = null;
        val_24 = val_10;
        val_10 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        val_25 = this;
        Add(key:  -2092883952, value:  13152256);
        val_26 = 0f;
        if(GoldenGalaHandler.dailyChallengeApple == null)
        {
            goto label_21;
        }
        
        val_27 = 0;
        if(GoldenGalaHandler.dailyChallengeApple.IsSubscriptionActive == false)
        {
            goto label_23;
        }
        
        decimal val_12 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -98548628}, d2:  new System.Decimal() {flags = val_23});
        val_25 = this;
        val_26 = val_5;
        Add(key:  -98560688, value:  10170368);
        var val_24 = mem[1152921513098245160];
        val_27 = mem[1152921513098245164];
        val_24 = mem[1152921513098245180] + val_24;
        mem[1152921513098245160] = val_24;
        Add(key:  -98560688, value:  13152256);
        val_23 = val_8;
        goto label_28;
        label_21:
        val_27 = 0;
        label_23:
        label_28:
        val_5 = 1;
        val_28 = "Daily Challenge";
        Add(key:  -2100705808, value:  8945664);
        val_29 = null;
        val_29 = null;
        val_30 = 0;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                Player val_14 = App.Player;
            0.AddCredits(amount:  new System.Decimal() {mid = val_23}, source:  "Daily Challenge", subSource:  0, externalParams:  new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>(), doTrack:  true);
            twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_28 = this.coinsAnim;
            Player val_16 = App.Player;
            var val_17 = 0 + 60;
            val_26 = 0;
            decimal val_18 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -98548628, hi = mem[(0 + 60) + (0)], lo = mem[(0 + 60) + (4)], mid = mem[(0 + 60) + (8)]}, d2:  new System.Decimal() {flags = 256});
            Player val_19 = App.Player;
            decimal val_20 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -98548648, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
            val_30 = mem[1152921513098245160];
            val_23 = val_21;
            val_28.Play(fromValue:  new System.Decimal() {flags = 1}, toValue:  new System.Decimal() {flags = val_30, hi = val_23, lo = val_22, mid = val_23}, textTickTime:  null, delayBeforeComplete:  null);
            return;
        }
        
        this.OnGoldenCurrencyAnimFinished();
    }
    private void OnRewardCollected()
    {
        this.weeklyProgressUI.InitializeWeeklyProgress(starsToAnimate:  0);
        this.monthlyProgressUI.InitializeMonthlyProgress(starsToAnimate:  0);
    }
    private void OnCoinsAnimFinished()
    {
        int val_8;
        int val_9;
        int val_10;
        int val_11;
        int val_13;
        System.Action val_1 = new System.Action(object:  -98265344, method:  new IntPtr(4196667584));
        var val_13 = 26713679;
        mem2[0] = null;
        val_13 = 8913444 + val_13;
        if(val_13 == 0)
        {
                mem2[0] = 1;
        }
        
        val_13 = 0;
        if(GoldenGalaHandler.dailyChallengeApple != null)
        {
                if(GoldenGalaHandler.dailyChallengeApple.IsSubscriptionActive != false)
        {
                System.Action val_3 = new System.Action(object:  -98265344, method:  new IntPtr(4196672704));
            mem2[0] = null;
            val_13 = this.galaAppleAmount;
        }
        
        }
        
        Player val_4 = App.Player;
        Player val_5 = App.Player;
        int val_6 = 4 - val_13;
        decimal val_7 = System.Decimal.op_Implicit(value:  -98277396);
        this.goldenCurrencyAnimControl.Play(fromValue:  (5.605194E-45f) - this.goldenApplesReward, toValue:  new System.Decimal() {flags = val_10, hi = val_11, lo = val_9, mid = val_8}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
        this.Invoke(methodName:  -98289472, time:  null);
    }
    private void OnGoldenCurrencyAnimFinished()
    {
        this.ShowDailyChallengePopup();
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        OnDailyChallengeRewardGranted();
        UnityEngine.GameObject val_2 = this.gameObject;
        SLCWindow.CloseWindow(window:  -98141056, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void PlayGalaCoinsAnim()
    {
        int val_7;
        int val_7;
        UnityEngine.Vector3 val_1 = position;
        this.rewardSource.position = new UnityEngine.Vector3();
        System.Action val_2 = new System.Action(object:  -98011648, method:  new IntPtr(4196926528));
        this.coinsAnim.OnCompleteCallback = null;
        Player val_3 = App.Player;
        var val_4 = 0 + 60;
        val_7 = mem[(0 + 60) + (0)];
        decimal val_5 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -98023712, hi = val_7, lo = mem[(0 + 60) + (4)], mid = mem[(0 + 60) + (8)]}, d2:  new System.Decimal() {flags = 256, hi = mem[this.galaCoinAmount + (0)], lo = mem[this.galaCoinAmount + (4)], mid = mem[this.galaCoinAmount + (8)]});
        Player val_6 = App.Player;
        this.coinsAnim.Play(fromValue:  new System.Decimal() {mid = val_7}, toValue:  new System.Decimal() {flags = 52}, textTickTime:  val_1.x, delayBeforeComplete:  val_1.y);
    }
    private void PlayGalaGoldenCurrencyAnim()
    {
        int val_5;
        int val_6;
        int val_7;
        int val_8;
        System.Action val_1 = new System.Action(object:  -97875072, method:  new IntPtr(4196667584));
        mem2[0] = null;
        Player val_2 = App.Player;
        Player val_3 = App.Player;
        decimal val_4 = System.Decimal.op_Implicit(value:  -97887120);
        this.goldenCurrencyAnimControl.Play(fromValue:  4 - this.galaAppleAmount, toValue:  new System.Decimal() {flags = val_7, hi = val_8, lo = val_6, mid = val_5}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
    }
    private void SetupGoldenMultiplierUI()
    {
        var val_6;
        System.Action val_1 = new System.Action(object:  -97749760, method:  new IntPtr(4197192512));
        System.Delegate val_2 = System.Delegate.Combine(a:  static_value_021FB066, b:  7454720);
        val_6 = 35631206;
        val_6 = 0;
        mem2[0] = val_6;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.IEnumerator val_4 = this.PlayGoldenCurrencyGet(amount:  public static GoldenMultiplierManager MonoSingleton<GoldenMultiplierManager>::get_Instance().__il2cppRuntimeField_C);
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  -97749760);
    }
    private System.Collections.IEnumerator PlayGoldenCurrencyGet(int amount)
    {
        typeof(WGDailyChallengeLevelComplete.<PlayGoldenCurrencyGet>d__67).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(WGDailyChallengeLevelComplete.<PlayGoldenCurrencyGet>d__67).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        typeof(WGDailyChallengeLevelComplete.<PlayGoldenCurrencyGet>d__67).__il2cppRuntimeField_14 = amount;
    }
    public WGDailyChallengeLevelComplete()
    {
        this.starPunchDuration = 0.3f;
        GameBehavior val_1 = App.getBehavior;
        this.dcRevamp = false;
    }
    private void <UpdateUIForDay>b__51_0()
    {
        var val_5;
        var val_6;
        var val_7;
        UnityEngine.RectTransform val_1 = this.appleReward.rectTransform;
        val_5 = 0;
        UnityEngine.Transform val_2 = this.appleReward.parent;
        val_6 = this.appleReward;
        if(val_6 != 0)
        {
                if(null != null)
        {
                val_6 = 0;
        }
        
            val_5 = val_6;
        }
        
        UnityEngine.UI.LayoutRebuilder.ForceRebuildLayoutImmediate(layoutRoot:  0);
        val_7 = 0;
        UnityEngine.RectTransform val_3 = this.coinReward.rectTransform;
        UnityEngine.Transform val_4 = this.coinReward.parent;
        if(this.coinReward != 0)
        {
                if(null != null)
        {
                this.coinReward = 0;
        }
        
            val_7 = this.coinReward;
        }
        
        UnityEngine.UI.LayoutRebuilder.ForceRebuildLayoutImmediate(layoutRoot:  0);
    }
    private void <SetupGoldenMultiplierUI>b__66_0()
    {
        this.goldenMultiplierGroup.SetActive(value:  false);
    }

}
