using UnityEngine;

namespace RestaurantRivals
{
    public class RESStatViewStarCurrency : MonoBehaviour
    {
        // Fields
        public const string ON_BALANCE_UPDATE = "OnTopSarBalanceUpdate";
        private TweenCoinsText text;
        
        // Methods
        private void Awake()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  667197728, name:  -1898880160);
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  667197728, name:  599596320);
        }
        private void Start()
        {
            this.UpdateStarAmount(Animat:  false);
        }
        public void UpdateStarAmount(bool Animat = True)
        {
            int val_5;
            var val_9;
            var val_10;
            val_9 = Animat;
            Player val_1 = App.Player;
            RestaurantRivals.RESPlayer val_2 = RestaurantRivals.RESPlayer.Instance;
            val_10 = 4 - 0;
            if(val_9 != false)
            {
                    val_9 = 0;
                decimal val_4 = System.Decimal.op_Implicit(value:  667413784);
                val_10 = 1056964608;
                this.text.CountUp(endValue:  new System.Decimal() {mid = val_5}, seconds:  null);
                System.Collections.IEnumerator val_6 = this.DoTextAnimation();
                UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  667425824);
                return;
            }
            
            decimal val_8 = System.Decimal.op_Implicit(value:  667413784);
            this.text.Set(instantValue:  new System.Decimal() {mid = val_5});
        }
        private System.Collections.IEnumerator DoTextAnimation()
        {
            object val_1 = new System.Object();
            typeof(RESStatViewStarCurrency.<DoTextAnimation>d__5).__il2cppRuntimeField_8 = 0;
            typeof(RESStatViewStarCurrency.<DoTextAnimation>d__5).__il2cppRuntimeField_10 = this;
        }
        private void OnServerSync()
        {
            this.UpdateStarAmount(Animat:  false);
        }
        private void OnTopSarBalanceUpdate()
        {
            this.UpdateStarAmount(Animat:  false);
        }
        public RESStatViewStarCurrency()
        {
        
        }
    
    }

}
