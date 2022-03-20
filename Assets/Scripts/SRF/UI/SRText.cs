using UnityEngine;

namespace SRF.UI
{
    public class SRText : Text
    {
        // Fields
        private System.Action<SRF.UI.SRText> LayoutDirty;
        
        // Methods
        public void add_LayoutDirty(System.Action<SRF.UI.SRText> value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this.LayoutDirty, b:  value);
            if(this.LayoutDirty == 0)
            {
                goto label_1;
            }
            
            val_2 = this.LayoutDirty;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.LayoutDirty != 1152921513585329236)
            {
                goto label_3;
            }
        
        }
        public void remove_LayoutDirty(System.Action<SRF.UI.SRText> value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this.LayoutDirty, value:  value);
            if(this.LayoutDirty == 0)
            {
                goto label_1;
            }
            
            val_2 = this.LayoutDirty;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.LayoutDirty != 1152921513585457620)
            {
                goto label_3;
            }
        
        }
        public override void SetLayoutDirty()
        {
            this.SetLayoutDirty();
            if(this.LayoutDirty == 0)
            {
                    return;
            }
            
            this.LayoutDirty.Invoke(obj:  388801232);
        }
        public SRText()
        {
        
        }
    
    }

}
