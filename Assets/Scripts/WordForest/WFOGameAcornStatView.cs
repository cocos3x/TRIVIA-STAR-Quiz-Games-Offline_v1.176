using UnityEngine;

namespace WordForest
{
    public class WFOGameAcornStatView : GoldenApplesStatView
    {
        // Methods
        private void OnAcornLevelBalanceUpdated(Notification notif)
        {
            var val_3;
            var val_4;
            val_3 = notif;
            if(val_3 != 0)
            {
                    true = notif.data;
            }
            
            if(true != 0)
            {
                goto label_1;
            }
            
            label_7:
            val_4 = this;
            this.UpdateBalance(instantly:  false);
            label_1:
            if(val_4 == 0)
            {
                goto label_7;
            }
            
            bool val_2 = (System.Boolean.Parse(value:  R5 + 16)) ^ 1;
            goto label_7;
        }
        protected override string GetBalanceUpdateNotificationName()
        {
        
        }
        protected override decimal GetCountUpBalance()
        {
            null = null;
            if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = R1 + 36, hi = R1 + 40, lo = R1 + 44, mid = R1 + 48}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
            {
                    var val_2 = R1 + 36;
                return new System.Decimal() {flags = 305799504, hi = R1 + 40, lo = R1 + 44, mid = R1 + 48};
            }
            
            WordForest.WFOPlayer val_3 = WordForest.WFOPlayer.Instance;
            int val_4 = 0.starsLevelBalance;
            decimal val_5 = System.Decimal.op_Implicit(value:  305799504);
            return new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.mid};
        }
        protected override void OnTouchAreaClicked()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        public WFOGameAcornStatView()
        {
        
        }
    
    }

}
