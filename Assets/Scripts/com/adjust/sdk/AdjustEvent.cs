using UnityEngine;

namespace com.adjust.sdk
{
    public class AdjustEvent
    {
        // Fields
        internal string currency;
        internal string eventToken;
        internal string callbackId;
        internal string transactionId;
        internal System.Nullable<double> revenue;
        internal System.Collections.Generic.List<string> partnerList;
        internal System.Collections.Generic.List<string> callbackList;
        internal string receipt;
        internal bool isReceiptSet;
        
        // Methods
        public AdjustEvent(string eventToken)
        {
            string val_1 = eventToken;
            val_1 = new System.Object();
            this.isReceiptSet = false;
            this.eventToken = val_1;
        }
        public void setRevenue(double amount, string currency)
        {
            string val_1;
            System.Nullable<System.Double> val_2 = new System.Nullable<System.Double>(value:  amount);
            this.currency = val_1;
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
        public void setTransactionId(string transactionId)
        {
            this.transactionId = transactionId;
        }
        public void setCallbackId(string callbackId)
        {
            this.callbackId = callbackId;
        }
        public void setReceipt(string receipt, string transactionId)
        {
            this.transactionId = transactionId;
            this.receipt = receipt;
            this.isReceiptSet = true;
        }
    
    }

}
