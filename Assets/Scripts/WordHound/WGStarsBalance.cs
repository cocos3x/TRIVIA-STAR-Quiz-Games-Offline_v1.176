using UnityEngine;

namespace WordHound
{
    public class WGStarsBalance : MonoBehaviour
    {
        // Fields
        private bool listenForUpdate;
        private TweenCoinsText balanceText;
        
        // Methods
        private void OnEnable()
        {
            this.OnStarsChanged();
            if(this.listenForUpdate == false)
            {
                    return;
            }
            
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  687598336, name:  -843271104);
        }
        public void Init(int initialStars)
        {
            int val_2;
            decimal val_1 = System.Decimal.op_Implicit(value:  687702392);
            this.balanceText.Set(instantValue:  new System.Decimal() {mid = val_2});
        }
        public void OnStarsChanged()
        {
            int val_3;
            Player val_1 = App.Player;
            decimal val_2 = System.Decimal.op_Implicit(value:  687822584);
            this.balanceText.CountUp(endValue:  new System.Decimal() {mid = val_3}, seconds:  null);
        }
        public WGStarsBalance()
        {
        
        }
    
    }

}
