using UnityEngine;

namespace SRF.UI
{
    public class CopySizeIntoLayoutElement : LayoutElement
    {
        // Fields
        public UnityEngine.RectTransform CopySource;
        public float PaddingHeight;
        public float PaddingWidth;
        public bool SetPreferredSize;
        public bool SetMinimumSize;
        
        // Properties
        public override float preferredWidth { get; }
        public override float preferredHeight { get; }
        public override float minWidth { get; }
        public override float minHeight { get; }
        public override int layoutPriority { get; }
        
        // Methods
        public override float get_preferredWidth()
        {
            float val_6;
            UnityEngine.RectTransform val_7;
            val_6 = -1f;
            if(this.SetPreferredSize == false)
            {
                    return (float)379435992;
            }
            
            val_7 = this.CopySource;
            if(val_7 == 0)
            {
                    return (float)379435992;
            }
            
            if(this.IsActive() == false)
            {
                    return (float)379435992;
            }
            
            val_7 = this.CopySource;
            UnityEngine.Rect val_3 = rect;
            float val_4 = width;
            val_6 = 379435992 + this.PaddingWidth;
            return (float)379435992;
        }
        public override float get_preferredHeight()
        {
            float val_6;
            UnityEngine.RectTransform val_7;
            val_6 = -1f;
            if(this.SetPreferredSize == false)
            {
                    return (float)379564376;
            }
            
            val_7 = this.CopySource;
            if(val_7 == 0)
            {
                    return (float)379564376;
            }
            
            if(this.IsActive() == false)
            {
                    return (float)379564376;
            }
            
            val_7 = this.CopySource;
            UnityEngine.Rect val_3 = rect;
            float val_4 = height;
            val_6 = 379564376 + this.PaddingHeight;
            return (float)379564376;
        }
        public override float get_minWidth()
        {
            float val_6;
            UnityEngine.RectTransform val_7;
            val_6 = -1f;
            if(this.SetMinimumSize == false)
            {
                    return (float)379692760;
            }
            
            val_7 = this.CopySource;
            if(val_7 == 0)
            {
                    return (float)379692760;
            }
            
            if(this.IsActive() == false)
            {
                    return (float)379692760;
            }
            
            val_7 = this.CopySource;
            UnityEngine.Rect val_3 = rect;
            float val_4 = width;
            val_6 = 379692760 + this.PaddingWidth;
            return (float)379692760;
        }
        public override float get_minHeight()
        {
            float val_6;
            UnityEngine.RectTransform val_7;
            val_6 = -1f;
            if(this.SetMinimumSize == false)
            {
                    return (float)379821144;
            }
            
            val_7 = this.CopySource;
            if(val_7 == 0)
            {
                    return (float)379821144;
            }
            
            if(this.IsActive() == false)
            {
                    return (float)379821144;
            }
            
            val_7 = this.CopySource;
            UnityEngine.Rect val_3 = rect;
            float val_4 = height;
            val_6 = 379821144 + this.PaddingHeight;
            return (float)379821144;
        }
        public override int get_layoutPriority()
        {
            return 2;
        }
        public CopySizeIntoLayoutElement()
        {
        
        }
    
    }

}
