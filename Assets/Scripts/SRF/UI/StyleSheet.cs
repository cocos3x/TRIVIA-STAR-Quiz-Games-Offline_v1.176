using UnityEngine;

namespace SRF.UI
{
    [Serializable]
    public class StyleSheet : ScriptableObject
    {
        // Fields
        private System.Collections.Generic.List<string> _keys;
        private System.Collections.Generic.List<SRF.UI.Style> _styles;
        public SRF.UI.StyleSheet Parent;
        
        // Methods
        public SRF.UI.Style GetStyle(string key, bool searchParent = True)
        {
            SRF.UI.StyleSheet val_3;
            SRF.UI.StyleSheet val_4;
            var val_5;
            val_3 = this;
            goto label_5;
            label_8:
            if((searchParent & true) != 0)
            {
                goto label_1;
            }
            
            val_4 = this.Parent;
            val_5 = 0;
            if(val_4 == 0)
            {
                    return;
            }
            
            val_3 = this.Parent;
            label_5:
            int val_2 = this.Parent._keys.IndexOf(item:  key);
            if(val_2 <= 1)
            {
                goto label_8;
            }
            
            val_4 = val_2;
            if(val_2 <= val_4)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + (val_4 << 2);
            val_5 = mem[(0 + (val_2) << 2) + 16];
            val_5 = (0 + (val_2) << 2) + 16;
            return;
            label_1:
            val_5 = 0;
        }
        public StyleSheet()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this._keys = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this._styles = null;
        }
    
    }

}
