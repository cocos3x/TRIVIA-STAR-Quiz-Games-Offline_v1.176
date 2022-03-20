using UnityEngine;

namespace SLC.Wordlicious
{
    public class WOLTrackingLevelComplete
    {
        // Fields
        private const string HINTS_USED_KEY = "hints_used";
        private const string EXTRA_WORDS_FOUND_KEY = "extra_words_found";
        private const string TRIAL_HINTS_USED_KEY = "trial_hints_used";
        public int hintsUsed;
        public int extraWordsFound;
        public int trialHintsUsed;
        
        // Methods
        public void Load(System.Collections.Generic.Dictionary<string, object> info)
        {
            if((info.ContainsKey(key:  724851136)) != false)
            {
                    object val_2 = info.Item[724851136];
                string val_3 = info.ToString();
                bool val_5 = System.Int32.TryParse(s:  info, result: out  this.hintsUsed);
            }
            
            if((info.ContainsKey(key:  724851232)) != false)
            {
                    object val_7 = info.Item[724851232];
                string val_8 = info.ToString();
                bool val_10 = System.Int32.TryParse(s:  info, result: out  this.extraWordsFound);
            }
            
            if((info.ContainsKey(key:  724851344)) == false)
            {
                    return;
            }
            
            object val_12 = info.Item[724851344];
            string val_13 = info.ToString();
            bool val_15 = System.Int32.TryParse(s:  info, result: out  this.trialHintsUsed);
        }
        public override string ToString()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  724851136, value:  13152256);
            Add(key:  724851232, value:  13152256);
            Add(key:  724851344, value:  13152256);
            string val_2 = MiniJSON.Json.Serialize(obj:  78753792);
        }
        public WOLTrackingLevelComplete()
        {
        
        }
    
    }

}
