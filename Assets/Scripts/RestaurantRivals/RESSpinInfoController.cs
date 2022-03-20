using UnityEngine;

namespace RestaurantRivals
{
    public class RESSpinInfoController : ARESUIController
    {
        // Fields
        private UnityEngine.UI.Text betInfoTxt;
        private UnityEngine.UI.Button betButton;
        private UnityEngine.UI.Slider RechargeableSpinAmountSlider;
        private UnityEngine.UI.Text RechargeableSpinAmountPercentTxt;
        private UnityEngine.GameObject Next5RechargeableSpinGetRoot;
        private UnityEngine.UI.Text Next5RechargeableSpinGetTimerTxt;
        private UnityEngine.GameObject SpinAmountRoot;
        private UnityEngine.UI.Text SpinAmountTxt;
        private UnityEngine.GameObject betBanner;
        private UnityEngine.CanvasGroup betBannerCanvasGroup;
        private UnityEngine.UI.Text betBannerTxt;
        private UnityEngine.GameObject HighstakesReady;
        private UnityEngine.GameObject HighstakesReadyTip;
        private UnityEngine.UI.Text HighstakesReadyTipTitleText;
        private UnityEngine.UI.Text HighstakesReadyTipTxt;
        private UnityEngine.UI.Text payoutInfoTxt;
        private RestaurantRivals.BatteryCollectEffect spinGetEffects;
        private UnityEngine.ParticleSystem coinsGetEffects;
        private UnityEngine.Transform ShieldToSpinTip;
        private UnityEngine.UI.Text ShieldToSpinTipTxt;
        private DG.Tweening.Tween payoutInfoTxtTween;
        
        // Methods
        protected override void OnSpinAmountUpdate()
        {
            this.UpdateSpinAmountInfo();
            this.TryShowHighStakesUI();
        }
        protected override void OnSpinBetUpdate()
        {
            this.UpdateSpinBetInfo();
        }
        protected override void OnSpinStarted()
        {
            this.UpdateSpinAmountInfo();
        }
        protected override void OnSpinEnded()
        {
            this.TryShowHighStakesUI();
        }
        private void OnSpinBetButtonClick()
        {
            var val_8;
            ReelsStatus val_9;
            val_8 = null;
            val_8 = null;
            val_9 = RestaurantRivals.RESReelsController.spinStatus;
            if(val_9 == 2)
            {
                    return;
            }
            
            val_9 = RestaurantRivals.RESReelsController.spinStatus;
            if(val_9 == 3)
            {
                    return;
            }
            
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  0, aName:  655976416);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            IncreaseSpinBet();
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_1C.HideBet();
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(SpinBet != 1)
            {
                    this.StopAllCoroutines();
                System.Collections.IEnumerator val_6 = this.ShowBetBanner();
                UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  663343824);
            }
            
            this.UpdateSpinBetInfo();
        }
        protected override void Awake()
        {
            this.Awake();
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  663481424, method:  new IntPtr(663440016));
            this.betButton.m_OnClick.AddListener(call:  162246656);
            this.betBannerCanvasGroup.alpha = null;
            this.CheckBetMultiplierButton();
            UnityEngine.Transform val_2 = this.HighstakesReady.transform;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.HighstakesReady.localScale = new UnityEngine.Vector3();
            UnityEngine.Transform val_4 = this.HighstakesReadyTip.transform;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            this.HighstakesReadyTip.localScale = new UnityEngine.Vector3();
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            this.ShieldToSpinTip.localScale = new UnityEngine.Vector3();
        }
        private void Start()
        {
            this.UpdateNext5RechargeableSpinGetTimerTxt();
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.ShowHighstakesReady(show:  IsHighStakesReady());
            this.InvokeRepeating(methodName:  663594000, time:  null, repeatRate:  null);
            this.UpdateSpinBetInfo();
            this.UpdateSpinAmountInfo();
        }
        public void ShowPayoutInfo(string payout)
        {
            if(this.payoutInfoTxtTween != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.payoutInfoTxtTween, complete:  false);
            }
            
            UnityEngine.Transform val_1 = this.payoutInfoTxt.transform;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.payoutInfoTxt, endValue:  null, duration:  null);
            object val_3 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.payoutInfoTxt, ease:  27);
            this.payoutInfoTxtTween = this.payoutInfoTxt;
        }
        public void HidePayoutInfo()
        {
            if(this.payoutInfoTxtTween != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.payoutInfoTxtTween, complete:  false);
            }
            
            UnityEngine.Transform val_1 = this.payoutInfoTxt.transform;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.payoutInfoTxt, endValue:  null, duration:  null);
            object val_3 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.payoutInfoTxt, ease:  26);
        }
        public void StartSpinGetEffects(int spins = 0, bool recharge = False)
        {
            if(recharge != false)
            {
                    UnityEngine.Transform val_1 = this.Next5RechargeableSpinGetTimerTxt.transform;
                0 = this.Next5RechargeableSpinGetTimerTxt;
            }
            
            this.spinGetEffects.Play(spins:  spins, origin:  0);
        }
        public void ShowCoinGetEffects(decimal basePayout, decimal payout)
        {
            int val_7;
            int val_8;
            int val_9;
            int val_10;
            float val_17;
            UnityEngine.AnimationCurve val_18;
            float val_19;
            int val_20;
            string val_1 = basePayout.flags.ToString();
            if(basePayout.lo > 1)
            {
                    string val_2 = basePayout.flags.Substring(startIndex:  0, length:  2);
                bool val_4 = System.Int32.TryParse(s:  664119628, result: out  int val_3 = 664119624);
            }
            
            val_20 = payout.hi;
            decimal val_5 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = 664119604, hi = payout.flags, lo = val_20, mid = payout.lo}, d2:  new System.Decimal() {flags = payout.mid, hi = basePayout.flags, lo = basePayout.hi, mid = basePayout.lo});
            decimal val_6 = System.Decimal.op_Implicit(value:  664119588);
            decimal val_12 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = 664119572}, d2:  new System.Decimal() {flags = val_8, hi = val_7, lo = val_9, mid = val_10});
            EmissionModule val_15 = mem[1152921513860913328].emission;
            MinMaxCurve val_16 = ParticleSystem.MinMaxCurve.op_Implicit(constant:  (float)UnityEngine.Mathf.RoundToInt(f:  System.Decimal.op_Explicit(value:  new System.Decimal())));
            val_15.m_ParticleSystem.rateOverTime = new MinMaxCurve() {m_CurveMax = val_18, m_ConstantMin = val_17, m_ConstantMax = val_19};
            val_16.m_ConstantMin + 80.Play();
        }
        public void ShowAddSpinTipAndNotify(int amount)
        {
            string val_1 = System.String.Format(format:  2128510224, arg0:  13152256);
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.ShieldToSpinTip, endValue:  null, duration:  null);
            object val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.ShieldToSpinTip, ease:  27);
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.ShieldToSpinTip);
            DG.Tweening.TweenCallback val_6 = new DG.Tweening.TweenCallback(object:  664256992, method:  new IntPtr(664227872));
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  null);
            DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.ShieldToSpinTip, endValue:  null, duration:  null);
            object val_10 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.ShieldToSpinTip, ease:  26);
            DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.ShieldToSpinTip);
            object val_12 = DG.Tweening.TweenExtensions.Play<System.Object>(t:  0);
        }
        public void CheckBetMultiplierButton()
        {
            UnityEngine.GameObject val_1 = this.betButton.gameObject;
            RestaurantRivals.RESPlayer val_2 = RestaurantRivals.RESPlayer.Instance;
            RestaurantRivals.RESGameEcon val_3 = RestaurantRivals.RESGameEcon.Instance;
            if(0 >= 0)
            {
                    0 = 1;
            }
            
            this.betButton.SetActive(value:  true);
        }
        private void UpdateNext5RechargeableSpinGetTimerTxt()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_2 = GetRechargeableSpinTimer();
            string val_3 = 664481568 + -1825802336(-1825802336);
            if(this.Next5RechargeableSpinGetTimerTxt == 0)
            {
                
            }
        
        }
        private void UpdateSpinBetInfo()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_3 = SpinBet.ToString();
            string val_4 = 664601856 + 664613916;
            if(this.betInfoTxt != 0)
            {
                    return;
            }
        
        }
        private void UpdateSpinAmountInfo()
        {
            var val_32;
            var val_33;
            var val_34;
            this.RechargeableSpinAmountSlider.interactable = true;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            float val_32 = (float)RestaurantRivals.RESManager.RechargeableSpinAmount;
            val_32 = (float)Spins / val_32;
            this.RechargeableSpinAmountSlider.interactable = false;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(Spins > RestaurantRivals.RESManager.RechargeableSpinAmount)
            {
                    string val_8 = RestaurantRivals.RESManager.RechargeableSpinAmount.ToString();
                string val_10 = RestaurantRivals.RESManager.RechargeableSpinAmount.ToString();
                val_32 = ;
                val_33 = "/";
                val_34 = ;
            }
            else
            {
                    twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                string val_13 = Spins.ToString();
                string val_15 = RestaurantRivals.RESManager.RechargeableSpinAmount.ToString();
                val_32 = ;
                val_33 = "/";
                val_34 = ;
            }
            
            string val_16 = 664758904 + 1115175264 + 664758904;
            twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(Spins < RestaurantRivals.RESManager.RechargeableSpinAmount)
            {
                    0 = 1;
            }
            
            this.Next5RechargeableSpinGetRoot.SetActive(value:  true);
            twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(Spins >= RestaurantRivals.RESManager.RechargeableSpinAmount)
            {
                    0 = 1;
            }
            
            this.SpinAmountRoot.SetActive(value:  true);
            twelvegigs.Autopilot.AutopilotManager val_23 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(Spins < RestaurantRivals.RESManager.RechargeableSpinAmount)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_26 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(ExtraSpins == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_28 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_30 = ExtraSpins.ToString();
            string val_31 = 664746704 + 664758904 + 664746784;
            if(this.SpinAmountTxt != 0)
            {
                    return;
            }
        
        }
        private void TryShowHighStakesUI()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.ShowHighstakesReady(show:  IsHighStakesReady());
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.ShowHighstakesReadyTip(betThreshold:  public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_50, betOption:  public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_54);
        }
        private System.Collections.IEnumerator ShowBetBanner()
        {
            object val_1 = new System.Object();
            typeof(RESSpinInfoController.<ShowBetBanner>d__38).__il2cppRuntimeField_8 = 0;
            typeof(RESSpinInfoController.<ShowBetBanner>d__38).__il2cppRuntimeField_10 = this;
        }
        private void ShowHighstakesReady(bool show)
        {
            UnityEngine.Transform val_1 = this.HighstakesReady.transform;
            if(show != false)
            {
                    DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.HighstakesReady, endValue:  null, duration:  null);
                object val_3 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.HighstakesReady, ease:  27);
                return;
            }
            
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.HighstakesReady, endValue:  null, duration:  null);
            object val_5 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.HighstakesReady, ease:  26);
        }
        private void ShowHighstakesReadyTip(int betThreshold, int betOption)
        {
            if(betThreshold > 51)
            {
                    "Highstakes Ready!" = "Highstakes Increased!";
            }
            
            GameEcon val_1 = App.getGameEcon;
            string val_2 = betOption.ToString(format:  null);
            string val_3 = 665240224 + 665252292;
            System.Collections.IEnumerator val_4 = this.ActuralShowHighstakesReadyTip();
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  665264320);
        }
        private System.Collections.IEnumerator ActuralShowHighstakesReadyTip()
        {
            object val_1 = new System.Object();
            typeof(RESSpinInfoController.<ActuralShowHighstakesReadyTip>d__41).__il2cppRuntimeField_8 = 0;
            typeof(RESSpinInfoController.<ActuralShowHighstakesReadyTip>d__41).__il2cppRuntimeField_10 = this;
        }
        public RESSpinInfoController()
        {
        
        }
        private void <ShowAddSpinTipAndNotify>b__32_0()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  665608512, aName:  -1275408272);
        }
    
    }

}
