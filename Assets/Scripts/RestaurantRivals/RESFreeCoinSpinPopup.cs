using UnityEngine;

namespace RestaurantRivals
{
    public class RESFreeCoinSpinPopup : WGFreeHintPopup
    {
        // Fields
        protected UnityEngine.UI.Text banner_text;
        protected UnityEngine.UI.Text reward_text;
        private UnityEngine.GameObject coin_reward_icon;
        private UnityEngine.GameObject spin_reward_icon;
        protected UnityEngine.UI.Text sorry_message_text;
        private UnityEngine.GameObject Success_reward_coin;
        private UnityEngine.GameObject Success_reward_spin;
        
        // Methods
        protected override void SetUp()
        {
            int val_4;
            int val_24;
            var val_25;
            var val_26;
            int val_27;
            int val_28;
            int val_29;
            mem[1152921513744680460] = ???;
            mem[1152921513744680468] = ???;
            if(true == 2)
            {
                goto label_1;
            }
            
            if(true != 0)
            {
                    return;
            }
            
            Player val_1 = App.Player;
            RestaurantRivals.RESLevelDef val_2 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  0);
            decimal val_3 = System.Decimal.op_Implicit(value:  547886664);
            mem[1152921513744680424] = val_4;
            decimal val_5 = new System.Decimal(value:  0);
            string val_6 = RestaurantRivals.RESGameEconHelper.FormatNumberWithLimit(num:  new System.Decimal() {flags = val_4, hi = R5, lo = SB, mid = SL}, numLimit:  new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.flags});
            decimal val_7 = new System.Decimal(value:  0);
            string val_8 = RestaurantRivals.RESGameEconHelper.FormatNumberWithLimit(num:  new System.Decimal() {flags = 547886648, hi = R7, lo = SB, mid = SL}, numLimit:  new System.Decimal() {flags = val_7.flags, hi = val_7.hi, lo = val_7.lo, mid = val_7.flags});
            string val_9 = -1467947360(-1467947360) + 547886648;
            this.coin_reward_icon.SetActive(value:  true);
            this.spin_reward_icon.SetActive(value:  false);
            this.Success_reward_coin.SetActive(value:  true);
            val_25 = 0;
            goto label_19;
            label_1:
            Player val_10 = App.Player;
            if(188 < 1)
            {
                goto label_23;
            }
            
            if(188 != 1)
            {
                goto label_24;
            }
            
            GameEcon val_12 = App.getGameEcon;
            val_26 = 312;
            val_27 = 0 + 308;
            val_28 = 0 + 304;
            val_29 = 0 + 300;
            goto label_32;
            label_23:
            GameEcon val_13 = App.getGameEcon;
            val_26 = 296;
            val_27 = 0 + 292;
            val_28 = 0 + 288;
            val_29 = 0 + 284;
            goto label_32;
            label_24:
            GameEcon val_14 = App.getGameEcon;
            val_26 = 328;
            val_27 = 0 + 324;
            val_28 = 0 + 320;
            val_29 = 0 + 316;
            label_32:
            val_24 = mem[(0 + 324)];
            val_24 = val_27;
            mem[1152921513744680424] = val_29;
            mem[1152921513744680428] = val_28;
            mem[1152921513744680432] = val_24;
            mem[1152921513744680436] = val_26;
            decimal val_15 = new System.Decimal(value:  999999999);
            string val_16 = RestaurantRivals.RESGameEconHelper.FormatNumberWithLimit(num:  new System.Decimal() {flags = val_29, hi = val_28, lo = val_24, mid = 19}, numLimit:  new System.Decimal() {flags = val_15.flags, hi = val_15.hi, lo = val_15.lo, mid = val_15.flags});
            string val_17 = System.String.Format(format:  547853968, arg0:  10170368);
            this.coin_reward_icon.SetActive(value:  false);
            this.spin_reward_icon.SetActive(value:  true);
            this.Success_reward_coin.SetActive(value:  false);
            val_25 = 1;
            label_19:
            this.Success_reward_spin.SetActive(value:  true);
            System.Action<System.Boolean> val_18 = new System.Action<System.Boolean>(object:  547898720, method:  new IntPtr(4256035920));
            "+{0} Spins".__il2cppRuntimeField_12C = null;
            interactable = true;
            SetActive(value:  true);
            SetActive(value:  false);
            SetActive(value:  false);
            UnityEngine.CanvasRenderer val_19 = canvasRenderer;
            SetAlpha(alpha:  null);
            if((System.Action<T>.__il2cppRuntimeField_this_arg) == 0)
            {
                    return;
            }
            
            this.SetActive(value:  false);
        }
        protected override void UpdateLogic()
        {
            if(true != 1)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1745532016) == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_4 = IsVideoAvailable();
        }
        public override void OnCollectClicked()
        {
            if(true == 2)
            {
                goto label_1;
            }
            
            if(true != 0)
            {
                goto label_2;
            }
            
            this.OnCollectClicked();
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            RecalcSession();
            return;
            label_1:
            static_value_021FBD6D.interactable = false;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            AwardSpins(amount:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = R6, hi = R7, lo = R8, mid = SB}), source:  1098586544, notify:  false);
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_5 = System.Decimal.op_Explicit(value:  new System.Decimal());
            public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_14.StartSpinGetEffects(spins:  val_5, recharge:  true);
            Player val_6 = App.Player;
            string val_7 = ToString();
            0.TrackNonCoinReward(source:  val_5, subSource:  null, rewardType:  -837290080, rewardAmount:  1152921513744961768, additionalParams:  0);
            this.Close(dontDestroyMonolith:  false);
            label_2:
            var val_8 = FP - 28;
        }
        public RESFreeCoinSpinPopup()
        {
        
        }
    
    }

}
