using UnityEngine;

namespace Prime31
{
    public class StoreKitReceipt
    {
        // Fields
        public string receipt_type;
        public int adam_id;
        public int app_item_id;
        public string bundle_id;
        public string application_version;
        public int download_id;
        public int version_external_identifier;
        public string receipt_creation_date;
        public string receipt_creation_date_ms;
        public string receipt_creation_date_pst;
        public string request_date;
        public string request_date_ms;
        public string request_date_pst;
        public string original_purchase_date;
        public string original_purchase_date_ms;
        public string original_purchase_date_pst;
        public string original_application_version;
        public System.Collections.Generic.List<Prime31.StoreKitReceiptInAppItem> in_app;
        
        // Methods
        public StoreKitReceipt()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.in_app = null;
        }
    
    }

}
