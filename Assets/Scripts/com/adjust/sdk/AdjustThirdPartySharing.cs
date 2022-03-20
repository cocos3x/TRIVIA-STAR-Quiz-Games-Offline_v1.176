using UnityEngine;

namespace com.adjust.sdk
{
    public class AdjustThirdPartySharing
    {
        // Fields
        internal System.Nullable<bool> isEnabled;
        internal System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> granularOptions;
        
        // Methods
        public AdjustThirdPartySharing(System.Nullable<bool> isEnabled)
        {
            this.isEnabled = isEnabled.HasValue;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.granularOptions = null;
        }
        public void addGranularOption(string partnerName, string key, string value)
        {
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> val_4;
            twelvegigs.sweepstakes.Distribution val_5;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_6;
            val_4 = this;
            val_5 = value;
            if(partnerName == null)
            {
                    return;
            }
            
            if(val_5 == null)
            {
                    return;
            }
            
            if((this.granularOptions.ContainsKey(key:  partnerName)) != false)
            {
                    System.Collections.Generic.List<System.String> val_2 = this.granularOptions.Item[partnerName];
                val_6 = this.granularOptions;
            }
            else
            {
                    val_6 = null;
                val_6 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
                val_4 = this.granularOptions;
                val_4.Add(key:  partnerName, value:  80883712);
            }
            
            if(val_6 != 0)
            {
                    Add(item:  key);
            }
            else
            {
                    val_6 = 0;
                0.Add(item:  key);
            }
            
            val_6.Add(item:  val_5);
        }
    
    }

}
