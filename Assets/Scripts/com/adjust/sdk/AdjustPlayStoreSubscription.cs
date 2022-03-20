using UnityEngine;

namespace com.adjust.sdk
{
    public class AdjustPlayStoreSubscription
    {
        // Fields
        internal string price;
        internal string currency;
        internal string sku;
        internal string orderId;
        internal string signature;
        internal string purchaseToken;
        internal string billingStore;
        internal string purchaseTime;
        internal System.Collections.Generic.List<string> partnerList;
        internal System.Collections.Generic.List<string> callbackList;
        
        // Methods
        public AdjustPlayStoreSubscription(string price, string currency, string sku, string orderId, string signature, string purchaseToken)
        {
            val_1 = new System.Object();
            this.price = price;
            this.currency = val_1;
            this.sku = sku;
            this.orderId = orderId;
            this.signature = signature;
            this.purchaseToken = purchaseToken;
        }
        public void setPurchaseTime(string purchaseTime)
        {
            this.purchaseTime = purchaseTime;
        }
        public void addCallbackParameter(string key, string value)
        {
            System.Collections.Generic.List<System.String> val_2 = this.callbackList;
            if(val_2 == 0)
            {
                    val_2 = null;
                val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
                this.callbackList = val_2;
                if(val_2 == 0)
            {
                    val_2 = 0;
            }
            
            }
            
            val_2.Add(item:  key);
            this.callbackList.Add(item:  value);
        }
        public void addPartnerParameter(string key, string value)
        {
            System.Collections.Generic.List<System.String> val_2 = this.partnerList;
            if(val_2 == 0)
            {
                    val_2 = null;
                val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
                this.partnerList = val_2;
                if(val_2 == 0)
            {
                    val_2 = 0;
            }
            
            }
            
            val_2.Add(item:  key);
            this.partnerList.Add(item:  value);
        }
    
    }

}
