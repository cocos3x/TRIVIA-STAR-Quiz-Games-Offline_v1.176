using UnityEngine;

namespace SRF.UI
{
    public class CopyLayoutElement : UIBehaviour, ILayoutElement
    {
        // Fields
        public bool CopyMinHeight;
        public bool CopyMinWidth;
        public bool CopyPreferredHeight;
        public bool CopyPreferredWidth;
        public UnityEngine.RectTransform CopySource;
        public float PaddingMinHeight;
        public float PaddingMinWidth;
        public float PaddingPreferredHeight;
        public float PaddingPreferredWidth;
        
        // Properties
        public float preferredWidth { get; }
        public float preferredHeight { get; }
        public float minWidth { get; }
        public float minHeight { get; }
        public int layoutPriority { get; }
        public float flexibleHeight { get; }
        public float flexibleWidth { get; }
        
        // Methods
        public float get_preferredWidth()
        {
            if(this.CopyPreferredWidth == false)
            {
                    return (float)this.CopySource;
            }
            
            if(this.CopySource == 0)
            {
                    return (float)this.CopySource;
            }
            
            if(this.IsActive() == false)
            {
                    return (float)this.CopySource;
            }
            
            float val_3 = UnityEngine.UI.LayoutUtility.GetPreferredWidth(rect:  this.CopySource);
            -1f = this.CopySource + this.PaddingPreferredWidth;
            return (float)this.CopySource;
        }
        public float get_preferredHeight()
        {
            if(this.CopyPreferredHeight == false)
            {
                    return (float)this.CopySource;
            }
            
            if(this.CopySource == 0)
            {
                    return (float)this.CopySource;
            }
            
            if(this.IsActive() == false)
            {
                    return (float)this.CopySource;
            }
            
            float val_3 = UnityEngine.UI.LayoutUtility.GetPreferredHeight(rect:  this.CopySource);
            -1f = this.CopySource + this.PaddingPreferredHeight;
            return (float)this.CopySource;
        }
        public float get_minWidth()
        {
            if(this.CopyMinWidth == false)
            {
                    return (float)this.CopySource;
            }
            
            if(this.CopySource == 0)
            {
                    return (float)this.CopySource;
            }
            
            if(this.IsActive() == false)
            {
                    return (float)this.CopySource;
            }
            
            float val_3 = UnityEngine.UI.LayoutUtility.GetMinWidth(rect:  this.CopySource);
            -1f = this.CopySource + this.PaddingMinWidth;
            return (float)this.CopySource;
        }
        public float get_minHeight()
        {
            if(this.CopyMinHeight == false)
            {
                    return (float)this.CopySource;
            }
            
            if(this.CopySource == 0)
            {
                    return (float)this.CopySource;
            }
            
            if(this.IsActive() == false)
            {
                    return (float)this.CopySource;
            }
            
            float val_3 = UnityEngine.UI.LayoutUtility.GetMinHeight(rect:  this.CopySource);
            -1f = this.CopySource + this.PaddingMinHeight;
            return (float)this.CopySource;
        }
        public int get_layoutPriority()
        {
            return 2;
        }
        public float get_flexibleHeight()
        {
            return (float)S0;
        }
        public float get_flexibleWidth()
        {
            return (float)S0;
        }
        public void CalculateLayoutInputHorizontal()
        {
        
        }
        public void CalculateLayoutInputVertical()
        {
        
        }
        public CopyLayoutElement()
        {
        
        }
    
    }

}
