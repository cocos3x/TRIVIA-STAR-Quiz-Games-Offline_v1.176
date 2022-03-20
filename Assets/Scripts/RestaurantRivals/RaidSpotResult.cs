using UnityEngine;

namespace RestaurantRivals
{
    public class RaidSpotResult : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text normalLabel;
        private UnityEngine.UI.Text noCoinsLabel;
        
        // Methods
        private void Awake()
        {
            UnityEngine.GameObject val_1 = this.normalLabel.gameObject;
            this.normalLabel.SetActive(value:  false);
            UnityEngine.GameObject val_2 = this.noCoinsLabel.gameObject;
            this.noCoinsLabel.SetActive(value:  false);
        }
        public void Setup(decimal amount)
        {
            null = null;
            if((System.Decimal.op_Equality(d1:  new System.Decimal() {flags = amount.flags, hi = amount.hi, lo = amount.lo, mid = amount.mid}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
            {
                    UnityEngine.GameObject val_2 = this.noCoinsLabel.gameObject;
                this.noCoinsLabel.SetActive(value:  true);
                UnityEngine.GameObject val_3 = this.normalLabel.gameObject;
                this.normalLabel.SetActive(value:  false);
                return;
            }
            
            decimal val_4 = new System.Decimal(value:  999999999);
            string val_5 = RestaurantRivals.RESGameEconHelper.FormatNumberWithLimit(num:  new System.Decimal() {flags = amount.flags, hi = amount.hi, lo = amount.lo, mid = amount.mid}, numLimit:  new System.Decimal() {flags = val_4.flags, hi = val_4.hi, lo = val_4.lo, mid = val_4.flags});
            UnityEngine.GameObject val_6 = this.noCoinsLabel.gameObject;
            this.noCoinsLabel.SetActive(value:  false);
            UnityEngine.GameObject val_7 = this.normalLabel.gameObject;
            this.normalLabel.SetActive(value:  true);
        }
        public RaidSpotResult()
        {
        
        }
    
    }

}
