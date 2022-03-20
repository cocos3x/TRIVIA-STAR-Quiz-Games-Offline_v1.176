using UnityEngine;

namespace SRF.UI
{
    public class CopyPreferredSize : LayoutElement
    {
        // Fields
        public UnityEngine.RectTransform CopySource;
        public float PaddingHeight;
        public float PaddingWidth;
        
        // Properties
        public override float preferredWidth { get; }
        public override float preferredHeight { get; }
        public override int layoutPriority { get; }
        
        // Methods
        public override float get_preferredWidth()
        {
            if(this.CopySource == 0)
            {
                    return (float)this.CopySource;
            }
            
            if(this.IsActive() == false)
            {
                    return (float)this.CopySource;
            }
            
            float val_3 = UnityEngine.UI.LayoutUtility.GetPreferredWidth(rect:  this.CopySource);
            -1f = this.CopySource + this.PaddingWidth;
            return (float)this.CopySource;
        }
        public override float get_preferredHeight()
        {
            if(this.CopySource == 0)
            {
                    return (float)this.CopySource;
            }
            
            if(this.IsActive() == false)
            {
                    return (float)this.CopySource;
            }
            
            float val_3 = UnityEngine.UI.LayoutUtility.GetPreferredHeight(rect:  this.CopySource);
            -1f = this.CopySource + this.PaddingHeight;
            return (float)this.CopySource;
        }
        public override int get_layoutPriority()
        {
            return 2;
        }
        public CopyPreferredSize()
        {
        
        }
    
    }

}
