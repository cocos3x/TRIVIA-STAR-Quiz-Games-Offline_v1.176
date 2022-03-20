using UnityEngine;

namespace SLC.Social.Leagues
{
    public class ClubLevelContribution_Window : FrameSkipper
    {
        // Fields
        private UnityEngine.UI.Text clubNameText;
        private UnityEngine.UI.Text clubLevelText;
        private UnityEngine.UI.Slider clubLevelSlider;
        protected UnityEngine.UI.Text progressRemainingText;
        private UnityEngine.UI.Text[] choiceButtonsText;
        private UnityEngine.UI.Text contributeButtonLabel;
        private UnityEngine.GameObject contributeButtonAmountGroup;
        private UnityEngine.UI.Text contributeButtonAmount;
        private UnityEngine.GameObject contributeButtonTimeGroup;
        private UnityEngine.UI.Text contributeButtonTime;
        protected UGUINetworkedButton contributeButton;
        private UnityEngine.GameObject contributeButtonOverlay;
        private UnityEngine.GameObject contributeLowCreditsError;
        protected UnityEngine.GameObject contributeCooldownError;
        protected UnityEngine.GameObject contributeMaxLevelError;
        protected UnityEngine.GameObject contributeAnimParent;
        private UnityEngine.UI.Button[] selectionButtons;
        private CoinCurrencyCollectAnimationInstantiator coinsGainedAnim;
        private UnityEngine.CanvasGroup choicesCanvasGroup;
        protected int selectedIndex;
        private bool _isAnimating;
        protected bool _isAwaitingResponse;
        protected bool _isAwaitingPing;
        protected System.Decimal[] contributionValues;
        protected System.DateTime lastDonationTime;
        private decimal ContributionAmountFractional;
        protected decimal ContributionAmountCredits;
        private int ContributionIndex;
        
        // Properties
        public int SelectedIndex { get; set; }
        private bool isAnimating { get; set; }
        
        // Methods
        public int get_SelectedIndex()
        {
            return (int)this.selectedIndex;
        }
        public void set_SelectedIndex(int value)
        {
            this.selectedIndex = value;
            GameEcon val_1 = App.getGameEcon;
            string val_2 = this.contributionValues[value][16].ToString(format:  null);
            var val_3 = this.contributionValues[value][16];
            this.contributeLowCreditsError.SetActive(value:  false);
        }
        private bool get_isAnimating()
        {
            return (bool)this._isAnimating;
        }
        private void set_isAnimating(bool value)
        {
            this._isAnimating = value;
        }
        protected virtual void Start()
        {
            System.Action<System.Boolean> val_8;
            CoinCurrencyCollectAnimationInstantiator val_9;
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  875517008, name:  442544128);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  875517008, method:  new IntPtr(875472528));
            this.contributeButton.AddListener(call:  162246656);
            System.Action<System.Boolean> val_3 = new System.Action<System.Boolean>(object:  875517008, method:  new IntPtr(875481744));
            System.Delegate val_4 = System.Delegate.Combine(a:  this.contributeButton.OnConnectionClick, b:  7401472);
            val_8 = this.contributeButton.OnConnectionClick;
            if(val_8 != 0)
            {
                    if(null == null)
            {
                goto label_11;
            }
            
            }
            
            val_8 = 0;
            label_11:
            this.contributeButton.OnConnectionClick = val_8;
            val_9 = this.coinsGainedAnim;
            System.Action val_5 = new System.Action(object:  875517008, method:  new IntPtr(875486864));
            mem2[0] = null;
            if(this.coinsGainedAnim == 0)
            {
                    return;
            }
            
            val_9.RemoveAllListeners();
            val_9 = null;
            val_9 = new UnityEngine.Events.UnityAction(object:  875517008, method:  new IntPtr(875491984));
            this.coinsGainedAnim.AddListener(call:  162246656);
        }
        protected void ContributeButton_OnInitialClick()
        {
            this._isAwaitingPing = true;
            this.SetContributeButtonState(state:  3);
        }
        protected void ContributeButton_OnConnectionClick(bool result)
        {
            if(result != false)
            {
                    this._isAwaitingPing = false;
                this.OnContributeButtonClick();
                return;
            }
            
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  875761488, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowConnectionRequired();
        }
        private void OnMyGuildUpdate()
        {
            if(this._isAwaitingResponse == true)
            {
                    return;
            }
            
            this.RefreshUI(onEnable:  false);
        }
        private void OnEnable()
        {
            this.RefreshUI(onEnable:  true);
        }
        protected virtual void SetSliderValue(float val, bool instant = False)
        {
            var val_10;
            var val_11;
            val_10 = this;
            val_11 = instant;
            if(R2 == 0)
            {
                    if(this.clubLevelSlider <= 0)
            {
                goto label_3;
            }
            
            }
            
            if(this.clubLevelSlider != 0)
            {
                goto typeof(UnityEngine.UI.Slider).__il2cppRuntimeField_234;
            }
            
            goto typeof(UnityEngine.UI.Slider).__il2cppRuntimeField_234;
            label_3:
            object val_1 = new System.Object();
            typeof(ClubLevelContribution_Window.<>c__DisplayClass37_0).__il2cppRuntimeField_C = ???;
            typeof(ClubLevelContribution_Window.<>c__DisplayClass37_0).__il2cppRuntimeField_8 = R6 + 36;
            DG.Tweening.Core.DOSetter<System.Single> val_2 = new DG.Tweening.Core.DOSetter<System.Single>(object:  445100032, method:  new IntPtr(876081680));
            DG.Tweening.Tweener val_3 = DG.Tweening.DOTween.To(setter:  198881280, startValue:  this.clubLevelSlider, endValue:  null, duration:  null);
            object val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  198881280, ease:  1);
            DG.Tweening.TweenCallback val_5 = new DG.Tweening.TweenCallback(object:  445100032, method:  new IntPtr(876082704));
            object val_6 = DG.Tweening.TweenSettingsExtensions.OnUpdate<System.Object>(t:  198881280, action:  190734336);
            var val_7 = FP - 24;
        }
        protected void RefreshUI(bool onEnable = False)
        {
            System.DateTime val_5;
            SLC.Social.Leagues.ClubLevelContribution_Window val_21;
            System.Decimal[] val_23;
            var val_24;
            var val_26;
            val_21 = this;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile val_2 = 0.MyProfile;
            System.DateTime val_3 = GetContributedAt;
            val_23 = this.contributionValues;
            this.lastDonationTime = val_5;
            if(val_23 == null)
            {
                    val_23 = null;
                this.contributionValues = null;
            }
            
            val_24 = 0;
            SLC.Social.Leagues.LeaguesDataController val_9 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_10 = 0.MyGuild;
            SLC.Social.Leagues.LeaguesDataController val_11 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_12 = 0.MyGuild;
            string val_13 = 116.ToString();
            SLC.Social.Leagues.LeaguesDataController val_14 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_15 = 0.MyGuild;
            SLC.Social.Leagues.GuildLevel val_16 = 0.Level;
            SLC.Social.Leagues.LeaguesDataController val_17 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_18 = 0.MyGuild;
            val_26 = 0;
            SLC.Social.Leagues.GuildLevel val_19 = val_26.NextLevel;
            if(0 != val_26)
            {
                
            }
            else
            {
                    string val_20 = Localization.Localize(key:  876392448, defaultValue:  876392336, useSingularKey:  false);
                val_26 = "max_club_level";
                this.SetContributeButtonState(state:  0);
            }
            
            mem[1152921514073198188].SetActive(value:  false);
            mem[1152921514073198192].SetActive(value:  false);
            mem[1152921514073198196].SetActive(value:  false);
        }
        protected virtual void SetProgressRemainingText(bool onEnable)
        {
            int val_9;
            int val_10;
            int val_11;
            int val_12;
            int val_21;
            int val_22;
            int val_23;
            int val_24;
            int val_27;
            int val_28;
            int val_29;
            int val_30;
            int val_39;
            int val_40;
            int val_41;
            float val_42;
            var val_44;
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_2 = 0.MyGuild;
            SLC.Social.Leagues.GuildLevel val_3 = 0.Level;
            decimal val_4 = CoinSupportRequired;
            SLC.Social.Leagues.LeaguesDataController val_5 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_6 = 0.MyGuild;
            SLC.Social.Leagues.GuildLevel val_7 = 0.NextLevel;
            decimal val_8 = CoinSupportRequired;
            val_39 = val_10;
            SLC.Social.Leagues.LeaguesDataController val_13 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_14 = 0.MyGuild;
            decimal val_15 = GetLeagueContributedCoins;
            SLC.Social.Leagues.LeaguesDataController val_16 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_17 = 0.MyGuild;
            SLC.Social.Leagues.LeaguesDataController val_18 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_19 = 0.MyGuild;
            decimal val_20 = ProgressThisLevel(currentLevel:  val_15.hi);
            decimal val_26 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 876705080}, d2:  new System.Decimal() {flags = val_22, hi = val_21, lo = val_23, mid = val_24});
            val_40 = val_12;
            decimal val_31 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 876705064, hi = val_28, lo = val_29, mid = val_30}, d2:  new System.Decimal() {flags = val_27, hi = val_39, lo = val_11, mid = val_9});
            float val_32 = System.Decimal.op_Explicit(value:  new System.Decimal());
            string val_33 = Localization.Localize(key:  876693072, defaultValue:  876692960, useSingularKey:  false);
            val_41 = val_28;
            val_42 = "num_coins_remaining";
            if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = val_41, hi = val_29, lo = val_30, mid = val_27}, d2:  new System.Decimal() {flags = val_39, hi = val_11, lo = val_9, mid = val_40})) != false)
            {
                    val_39 = 0;
                decimal val_35 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 876705132, hi = val_39, lo = val_11, mid = val_9}, d2:  new System.Decimal() {flags = val_12, hi = val_41, lo = val_29, mid = val_30});
                decimal val_36 = new System.Decimal(value:  1000);
                val_40 = val_36.flags;
                val_41 = val_36.hi;
                string val_37 = MetricSystem.Abbreviate(number:  new System.Decimal(), maxSigFigs:  3, round:  true, useColor:  true, maxValueWithoutAbbr:  new System.Decimal() {flags = val_40, hi = val_41, lo = val_36.lo, mid = val_36.mid}, useRichText:  true, withSpaces:  false);
                val_42 = val_42;
                val_44 = R0;
            }
            else
            {
                    val_44 = "0";
            }
            
            string val_38 = System.String.Format(format:  876693072, arg0:  1254115712);
            if(mem[1152921514073498792] != 0)
            {
                    return;
            }
        
        }
        protected override void UpdateLogic()
        {
            ulong val_8;
            long val_14;
            var val_25;
            if(this._isAwaitingResponse != false)
            {
                    return;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_2 = 0.MyGuild;
            SLC.Social.Leagues.GuildLevel val_3 = 0.Level;
            SLC.Social.Leagues.LeaguesDataController val_4 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_5 = 0.MyGuild;
            SLC.Social.Leagues.GuildLevel val_6 = 0.NextLevel;
            if(0 == 0)
            {
                    return;
            }
            
            val_25 = null;
            val_25 = null;
            System.DateTime val_7 = DateTimeCheat.UtcNow;
            System.TimeSpan val_10 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921514073602768}, d2:  new System.DateTime() {dateData = val_8});
            System.TimeSpan val_13 = System.TimeSpan.op_Subtraction(t1:  new System.TimeSpan() {_ticks = 1152921514073602760}, t2:  new System.TimeSpan() {_ticks = SLC.Social.Leagues.LeaguesEconomy.AllowedDonationInterval});
            if((System.TimeSpan.op_GreaterThanOrEqual(t1:  new System.TimeSpan() {_ticks = val_14}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) != false)
            {
                    this.SetContributeButtonState(state:  2);
                double val_18 = System.Math.Truncate(d:  val_14.TotalHours);
                string val_19 = 1.28823246183255E-231.ToString(format:  -1827641632);
                string val_21 = val_14.Minutes.ToString(format:  -1827641632);
                string val_23 = val_14.Seconds.ToString(format:  -1827641632);
                string val_24 = System.String.Format(format:  -1687058320, arg0:  876821224, arg1:  876821220, arg2:  876821220);
                if(this.contributeButtonTime != 0)
            {
                    return;
            }
            
                return;
            }
            
            this.SetContributeButtonState(state:  1);
        }
        protected virtual bool CheckAllowedAndShowError()
        {
            ulong val_2;
            long val_9;
            SLC.Social.Leagues.ClubLevelContribution_Window val_23;
            var val_24;
            System.DateTime val_25;
            System.Action val_26;
            decimal val_27;
            var val_28;
            var val_29;
            var val_30;
            val_23 = this;
            val_24 = null;
            val_24 = null;
            System.DateTime val_1 = DateTimeCheat.UtcNow;
            val_25 = this.lastDonationTime;
            System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921514073760872}, d2:  new System.DateTime() {dateData = val_2});
            val_26 = 1152921504622821376;
            val_27 = 0;
            System.TimeSpan val_7 = System.TimeSpan.op_Subtraction(t1:  new System.TimeSpan() {_ticks = 1152921514073760864}, t2:  new System.TimeSpan() {_ticks = SLC.Social.Leagues.LeaguesEconomy.AllowedDonationInterval});
            if((System.TimeSpan.op_GreaterThanOrEqual(t1:  new System.TimeSpan() {_ticks = val_9}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) != false)
            {
                    val_28 = 0;
                this.contributeCooldownError.SetActive(value:  true);
                return (bool)val_28;
            }
            
            val_27 = this.contributionValues[this.selectedIndex];
            val_23 = this.contributionValues[this.selectedIndex];
            Player val_11 = App.Player;
            val_25 = 52;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = this.contributionValues[this.selectedIndex], hi = this.contributionValues[this.selectedIndex], lo = val_27, mid = val_23}, d2:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256})) != false)
            {
                    var val_25 = 26444529;
                val_25 = 9181532 + val_25;
                if(val_25 == 0)
            {
                    mem2[0] = 1;
            }
            
                val_29 = null;
                val_25 = val_23;
                val_29 = null;
                PurchaseProxy.currentPurchasePoint = 20;
                twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                object val_14 = ShowUGUIMonolith<System.Object>(showNext:  false);
                val_27 = 1152921505051893760;
                val_30 = null;
                val_30 = null;
                val_26 = ClubLevelContribution_Window.<>c.<>9__41_0;
                if(val_26 == 0)
            {
                    val_26 = null;
                val_26 = new System.Action(object:  ClubLevelContribution_Window.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(876966336));
                ClubLevelContribution_Window.<>c.<>9__41_0 = val_26;
            }
            
                val_28 = 0;
                Init(outOfCredits:  true, onCloseAction:  7454720);
                UnityEngine.GameObject val_16 = this.gameObject;
                SLCWindow.CloseWindow(window:  876991360, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
                return (bool)val_28;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_17 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_26 = val_23;
            SLC.Social.Leagues.Guild val_18 = 0.MyGuild;
            SLC.Social.Leagues.GuildLevel val_19 = 0.Level;
            SLC.Social.Leagues.LeaguesDataController val_20 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Leagues.Guild val_21 = 0.MyGuild;
            SLC.Social.Leagues.GuildLevel val_22 = 0.NextLevel;
            val_28 = 1;
            if(0 != 0)
            {
                    return (bool)val_28;
            }
        
        }
        public void OnContributeButtonClick()
        {
            if(this._isAnimating == false)
            {
                    this._isAnimating = this._isAwaitingResponse;
                goto label_1;
            }
            
            return;
            label_1:
            mem[1152921514073976220] = this.contributionValues[this.selectedIndex];
            this.ContributionIndex = this.selectedIndex;
            this.contributeLowCreditsError.SetActive(value:  false);
            this.contributeCooldownError.SetActive(value:  false);
            this.contributeMaxLevelError.SetActive(value:  false);
            if(this == 0)
            {
                    return;
            }
            
            SLC.Social.Leagues.LeaguesDataController val_1 = SLC.Social.Leagues.LeaguesManager.DAO;
            System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  877194496, method:  new IntPtr(877169472));
            0.ContributeCoins(coinsToContribute:  new System.Decimal() {flags = this.ContributionAmountFractional, hi = SL, lo = R8, mid = this.selectedIndex}, resultAction:  null);
            this._isAnimating = true;
            this._isAwaitingResponse = true;
        }
        private void SuccessfulContribution(bool success)
        {
            var val_7 = 35631731;
            if(877355648 == 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = this.gameObject;
            val_7 = this;
            if(877355648 == 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_4 = this.gameObject;
            val_7 = this;
            if(this.activeSelf == false)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  877355648);
        }
        protected virtual System.Collections.IEnumerator DeferredUpdate(bool success)
        {
            typeof(ClubLevelContribution_Window.<DeferredUpdate>d__47).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(ClubLevelContribution_Window.<DeferredUpdate>d__47).__il2cppRuntimeField_10 = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            typeof(ClubLevelContribution_Window.<DeferredUpdate>d__47).__il2cppRuntimeField_14 = success;
        }
        protected void ConcludeAnimation()
        {
            this._isAnimating = false;
        }
        private void OnDisable()
        {
            this.CancelInvoke();
            this._isAnimating = false;
            this._isAwaitingResponse = false;
        }
        private void SetContributeButtonState(SLC.Social.Leagues.ClubLevelContribution_Window.ContributeState state)
        {
            if(this._isAwaitingResponse == false)
            {
                    this._isAwaitingResponse = this._isAwaitingPing;
                goto label_1;
            }
            
            string val_1 = Localization.Localize(key:  877783840, defaultValue:  877783744, useSingularKey:  false);
            this.contributeCooldownError.SetActive(value:  false);
            this.contributeButton.interactable = false;
            this.contributeButtonOverlay.SetActive(value:  true);
            this.contributeButtonTimeGroup.SetActive(value:  false);
            GameEcon val_2 = App.getGameEcon;
            string val_3 = this.contributionValues[this.selectedIndex][16].ToString(format:  null);
            var val_5 = this.contributionValues[this.selectedIndex][16];
            this.contributeButtonAmountGroup.SetActive(value:  true);
            return;
            label_1:
            if(state <= 3)
            {
                    var val_4 = 9174008 + (9174008 + (state) << 2);
                if(state == 3)
            {
                    9174008 = 9174008;
                9174008 = R8 * (9174008 + (state) << 2);
                9174008 = 9174008 & (-1475281517);
            }
            
            }
        
        }
        public ClubLevelContribution_Window()
        {
            var val_1;
            this.selectedIndex = 1;
            val_1 = null;
            val_1 = null;
            this.lastDonationTime = System.DateTime.MinValue;
            this.ContributionIndex = 0;
        }
        private void <Start>b__32_0()
        {
            var val_5;
            var val_6;
            System.Action val_8;
            var val_5 = 26442409;
            val_5 = 9183652 + val_5;
            if(val_5 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_5 = null;
            val_5 = null;
            PurchaseProxy.currentPurchasePoint = 20;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
            val_6 = null;
            val_6 = null;
            val_8 = ClubLevelContribution_Window.<>c.<>9__32_1;
            if(val_8 == 0)
            {
                    val_8 = null;
                val_8 = new System.Action(object:  ClubLevelContribution_Window.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(878143120));
                ClubLevelContribution_Window.<>c.<>9__32_1 = val_8;
            }
            
            Init(outOfCredits:  true, onCloseAction:  7454720);
            UnityEngine.GameObject val_4 = this.gameObject;
            SLCWindow.CloseWindow(window:  878168144, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
    
    }

}
