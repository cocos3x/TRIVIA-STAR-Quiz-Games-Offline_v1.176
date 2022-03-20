using UnityEngine;

namespace RestaurantRivals
{
    public class RESReturnGameGiftPopup : ReturnGameGiftPopup
    {
        // Fields
        private UnityEngine.GameObject coinReward;
        private UnityEngine.UI.Text coinAmountTxt;
        private GridCoinCollectAnimationInstantiator coinsAnim;
        private UnityEngine.GameObject spinReward;
        private UnityEngine.UI.Text spinAmountTxt;
        private SpinsCollectAnimationInstantiator spinsAnim;
        private ReturnGameGiftReward currentReward;
        
        // Methods
        public override void Setup(ReturnGameGiftReward reward)
        {
            var val_11;
            float val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            decimal val_17;
            UnityEngine.GameObject val_20;
            val_11 = this;
            if(reward == 0)
            {
                goto label_1;
            }
            
            this.currentReward = reward;
            ReturnGameGiftReward val_1 = reward + 16;
            val_12 = 1152921504617017344;
            val_13 = null;
            val_13 = null;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = reward.<coins>k__BackingField, hi = mem[(reward + 16) + (0)], lo = mem[(reward + 16) + (4)], mid = mem[(reward + 16) + (8)]}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == false)
            {
                goto label_5;
            }
            
            this.coinReward.SetActive(value:  true);
            mem2[0] = 1;
            val_14 = 0;
            string val_3 = RestaurantRivals.RESGameEconHelper.GetAbbreviatedFormat(num:  new System.Decimal() {flags = mem[this.currentReward.<coins>k__BackingField + (0)], hi = mem[this.currentReward.<coins>k__BackingField + (4)], lo = mem[this.currentReward.<coins>k__BackingField + (8)], mid = mem[this.currentReward.<coins>k__BackingField + (12)]});
            string val_4 = -1467947360(-1467947360) + mem[this.currentReward.<coins>k__BackingField + (0)](mem[this.currentReward.<coins>k__BackingField + (0)]);
            if(this.coinAmountTxt != 0)
            {
                goto label_9;
            }
            
            goto label_9;
            label_1:
            UnityEngine.Debug.LogError(message:  640957536);
            return;
            label_5:
            val_15 = 0;
            this.coinReward.SetActive(value:  false);
            mem2[0] = 0;
            label_9:
            val_16 = null;
            ReturnGameGiftReward val_5 = this.currentReward + 32;
            val_17 = this.currentReward.<spins>k__BackingField;
            val_16 = null;
            val_20 = this.spinReward;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_17, hi = mem[(this.currentReward + 32) + (0)], lo = mem[(this.currentReward + 32) + (4)], mid = mem[(this.currentReward + 32) + (8)]}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
            {
                    val_20.SetActive(value:  true);
                mem2[0] = 1;
                string val_7 = RestaurantRivals.RESGameEconHelper.GetAbbreviatedFormat(num:  new System.Decimal() {flags = mem[this.currentReward.<spins>k__BackingField + (0)], hi = mem[this.currentReward.<spins>k__BackingField + (4)], lo = mem[this.currentReward.<spins>k__BackingField + (8)], mid = mem[this.currentReward.<spins>k__BackingField + (12)]});
                string val_8 = -1467947360(-1467947360) + mem[this.currentReward.<spins>k__BackingField + (0)](mem[this.currentReward.<spins>k__BackingField + (0)]);
                if(this.spinAmountTxt != 0)
            {
                goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_314;
            }
            
            }
            else
            {
                    R5.SetActive(value:  false);
                mem2[0] = 0;
                var val_9 = FP - 28;
            }
        
        }
        protected override void OnConnectionClick(bool connected)
        {
            int val_14;
            int val_15;
            int val_16;
            var val_27;
            int val_28;
            int val_29;
            float val_30;
            var val_31;
            int val_32;
            int val_33;
            ReturnGameGiftReward val_34;
            var val_35;
            int val_36;
            int val_37;
            var val_38;
            GridCoinCollectAnimationInstantiator val_39;
            System.Action val_40;
            System.Action val_41;
            var val_42;
            if(connected == false)
            {
                    return;
            }
            
            connected.interactable = false;
            ReturnGameGiftReward val_1 = this.currentReward + 32;
            val_27 = null;
            val_27 = null;
            val_29 = mem[(this.currentReward + 32) + (4)];
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = this.currentReward.<spins>k__BackingField, hi = mem[(this.currentReward + 32) + (0)], lo = val_29, mid = mem[(this.currentReward + 32) + (8)]}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_28 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = mem[this.currentReward.<spins>k__BackingField + (0)], hi = mem[this.currentReward.<spins>k__BackingField + (4)], lo = mem[this.currentReward.<spins>k__BackingField + (8)], mid = this.currentReward});
                string val_5 = System.String.Format(format:  641151632, arg0:  13152256);
                AwardSpins(amount:  val_28, source:  641151632, notify:  true);
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                RecalcSession();
                val_29 = 0;
                if(this.spinsAnim != 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                int val_12 = Spins;
                decimal val_13 = System.Decimal.op_Implicit(value:  641216956);
                val_28 = 49024;
                val_28 = 3212836864;
                val_29 = this.currentReward.<tier>k__BackingField;
                this.spinsAnim.Play(fromValue:  Spins - (System.Decimal.op_Explicit(value:  new System.Decimal() {flags = this.currentReward.<spins>k__BackingField, hi = mem[this.currentReward.<spins>k__BackingField + (8)], lo = val_28, mid = this.currentReward})), toValue:  new System.Decimal() {flags = val_29, hi = val_16, lo = val_15, mid = val_14}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  val_28, originObject:  val_28);
            }
            
            }
            
            ReturnGameGiftReward val_27 = this.currentReward;
            val_30 = 1152921504617017344;
            val_27 = val_27 + 16;
            val_31 = null;
            val_31 = null;
            val_33 = mem[(this.currentReward + 16) + (4)];
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = this.currentReward.<coins>k__BackingField, hi = mem[(this.currentReward + 16) + (0)], lo = val_33, mid = mem[(this.currentReward + 16) + (8)]}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
            {
                    ReturnGameGiftReward val_28 = this.currentReward;
                val_34 = val_28;
                if(val_28 == 0)
            {
                    val_34 = this.currentReward;
            }
            
                val_28 = val_28 + 16;
                string val_19 = System.String.Format(format:  641151632, arg0:  13152256);
                CurrencyController.CreditBalance(value:  new System.Decimal() {flags = this.currentReward.<coins>k__BackingField, hi = mem[(this.currentReward + 16) + (0)], lo = mem[(this.currentReward + 16) + (4)], mid = mem[(this.currentReward + 16) + (8)]}, source:  "Return Game Gift Reward {0}", externalParams:  0, animated:  false);
                val_33 = 0;
                if(this.coinsAnim != 0)
            {
                    Player val_21 = App.Player;
                if(this.currentReward == 0)
            {
                    val_36 = val_36;
                val_35 = val_35;
            }
            
                val_36 = val_36;
                val_35 = val_35;
                decimal val_22 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 641216956, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256, hi = this.currentReward.<coins>k__BackingField, lo = this.currentReward.<coins>k__BackingField, mid = val_36});
                Player val_23 = App.Player;
                val_30 = 1152921504617017344;
                if(this.coinsAnim == 0)
            {
                    val_37 = val_37;
            }
            
                this.coinsAnim.Play(fromValue:  new System.Decimal() {flags = this.currentReward.<tier>k__BackingField}, toValue:  new System.Decimal() {flags = val_32, lo = val_37, mid = 256}, textTickTime:  null, delayBeforeComplete:  null);
            }
            
            }
            
            ReturnGameGiftReward val_29 = this.currentReward;
            val_29 = val_29 + 16;
            val_38 = null;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = this.currentReward.<coins>k__BackingField, hi = mem[(this.currentReward + 16) + (0)], lo = mem[(this.currentReward + 16) + (4)], mid = mem[(this.currentReward + 16) + (8)]}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
            {
                    val_39 = this.coinsAnim;
                val_40 = 1152921504614301696;
                val_41 = this.coinsAnim.OnCompleteCallback;
            }
            else
            {
                    val_39 = this.spinsAnim;
                val_40 = 1152921504614301696;
            }
            
            val_40 = new System.Action(object:  641229008, method:  System.Void ReturnGameGiftPopup::Close());
            val_42 = 0;
            System.Delegate val_26 = System.Delegate.Combine(a:  0, b:  7454720);
            if(val_42 != 0)
            {
                    if(1179403647 == null)
            {
                goto label_51;
            }
            
            }
            
            val_42 = 0;
            label_51:
            mem2[0] = val_42;
        }
        public RESReturnGameGiftPopup()
        {
        
        }
    
    }

}
