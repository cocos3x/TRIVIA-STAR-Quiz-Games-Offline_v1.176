using UnityEngine;

namespace RestaurantRivals
{
    public class RESReviewPopup : WGReviewPopup
    {
        // Fields
        private CurrencyCollectAnimationInstantiator spinsAnimControl;
        
        // Methods
        protected override void OnClick_Collect()
        {
            int val_8;
            int val_9;
            int val_10;
            int val_11;
            System.Action val_14;
            static_value_021F99F7.interactable = false;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            AwardSpins(amount:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = R7, hi = R5, lo = -1825802336, mid = R6}), source:  36505104, notify:  false);
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            int val_6 = Spins;
            decimal val_7 = System.Decimal.op_Implicit(value:  643798972);
            this.spinsAnimControl.Play(fromValue:  Spins, toValue:  new System.Decimal() {flags = val_10, hi = val_11, lo = val_9, mid = val_8}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
            System.Action val_12 = new System.Action(object:  643811024, method:  new IntPtr(643786000));
            System.Delegate val_13 = System.Delegate.Combine(a:  this.spinsAnimControl.OnCompleteCallback, b:  7454720);
            val_14 = this.spinsAnimControl.OnCompleteCallback;
            if(val_14 != 0)
            {
                    if(null == null)
            {
                goto label_13;
            }
            
            }
            
            val_14 = 0;
            label_13:
            this.spinsAnimControl.OnCompleteCallback = val_14;
        }
        public RESReviewPopup()
        {
        
        }
        private void <OnClick_Collect>b__1_0()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  644047312, aName:  -1275408272);
            this.Close();
        }
    
    }

}
