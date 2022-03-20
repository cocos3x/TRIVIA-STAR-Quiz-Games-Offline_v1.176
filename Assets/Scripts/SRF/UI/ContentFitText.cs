using UnityEngine;

namespace SRF.UI
{
    public class ContentFitText : UIBehaviour, ILayoutElement
    {
        // Fields
        public SRF.UI.SRText CopySource;
        public UnityEngine.Vector2 Padding;
        
        // Properties
        public float minWidth { get; }
        public float preferredWidth { get; }
        public float flexibleWidth { get; }
        public float minHeight { get; }
        public float preferredHeight { get; }
        public float flexibleHeight { get; }
        public int layoutPriority { get; }
        
        // Methods
        public float get_minWidth()
        {
            float val_4;
            if(this.CopySource == 0)
            {
                    val_4 = -1f;
                return (float)val_4;
            }
            
            UnityEngine.RectTransform val_2 = this.CopySource.rectTransform;
            float val_3 = UnityEngine.UI.LayoutUtility.GetMinWidth(rect:  this.CopySource);
            val_4 = this.CopySource + this.Padding;
            return (float)val_4;
        }
        public float get_preferredWidth()
        {
            float val_4;
            if(this.CopySource == 0)
            {
                    val_4 = -1f;
                return (float)val_4;
            }
            
            UnityEngine.RectTransform val_2 = this.CopySource.rectTransform;
            float val_3 = UnityEngine.UI.LayoutUtility.GetPreferredWidth(rect:  this.CopySource);
            val_4 = this.CopySource + this.Padding;
            return (float)val_4;
        }
        public float get_flexibleWidth()
        {
            if(this.CopySource == 0)
            {
                    return (float)S0;
            }
            
            UnityEngine.RectTransform val_2 = this.CopySource.rectTransform;
            return UnityEngine.UI.LayoutUtility.GetFlexibleWidth(rect:  this.CopySource);
        }
        public float get_minHeight()
        {
            float val_4;
            if(this.CopySource == 0)
            {
                    val_4 = -1f;
                return (float)val_4;
            }
            
            UnityEngine.RectTransform val_2 = this.CopySource.rectTransform;
            float val_3 = UnityEngine.UI.LayoutUtility.GetFlexibleHeight(rect:  this.CopySource);
            val_4 = this.CopySource + S2;
            return (float)val_4;
        }
        public float get_preferredHeight()
        {
            float val_4;
            if(this.CopySource == 0)
            {
                    val_4 = -1f;
                return (float)val_4;
            }
            
            UnityEngine.RectTransform val_2 = this.CopySource.rectTransform;
            float val_3 = UnityEngine.UI.LayoutUtility.GetPreferredHeight(rect:  this.CopySource);
            val_4 = this.CopySource + S2;
            return (float)val_4;
        }
        public float get_flexibleHeight()
        {
            if(this.CopySource == 0)
            {
                    return (float)S0;
            }
            
            UnityEngine.RectTransform val_2 = this.CopySource.rectTransform;
            return UnityEngine.UI.LayoutUtility.GetFlexibleHeight(rect:  this.CopySource);
        }
        public int get_layoutPriority()
        {
            return 0;
        }
        public void CalculateLayoutInputHorizontal()
        {
            this.CopySource.CalculateLayoutInputHorizontal();
        }
        public void CalculateLayoutInputVertical()
        {
            this.CopySource.CalculateLayoutInputVertical();
        }
        protected override void OnEnable()
        {
            this.SetDirty();
            System.Action<twelvegigs.storage.JsonDictionary> val_1 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  376857056, method:  new IntPtr(376831008));
            this.CopySource.add_LayoutDirty(value:  7401472);
        }
        private void CopySourceOnLayoutDirty(SRF.UI.SRText srText)
        {
            this.SetDirty();
        }
        protected override void OnTransformParentChanged()
        {
            this.SetDirty();
        }
        protected override void OnDisable()
        {
            System.Action<twelvegigs.storage.JsonDictionary> val_1 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  377209440, method:  new IntPtr(376831008));
            this.CopySource.remove_LayoutDirty(value:  7401472);
            this.SetDirty();
        }
        protected override void OnDidApplyAnimationProperties()
        {
            this.SetDirty();
        }
        protected override void OnBeforeTransformParentChanged()
        {
            this.SetDirty();
        }
        protected void SetDirty()
        {
            var val_3;
            if(this.IsActive() == false)
            {
                    return;
            }
            
            val_3 = 0;
            UnityEngine.Transform val_2 = R4.transform;
            if(R4 != 0)
            {
                    if(R4 != null)
            {
                    R4 = 0;
            }
            
                val_3 = R4;
            }
            
            UnityEngine.UI.LayoutRebuilder.MarkLayoutForRebuild(rect:  0);
        }
        public ContentFitText()
        {
        
        }
    
    }

}
