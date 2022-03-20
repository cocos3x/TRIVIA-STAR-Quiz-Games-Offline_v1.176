using UnityEngine;

namespace SRF.UI
{
    public abstract class ResponsiveBase : SRMonoBehaviour
    {
        // Fields
        private bool _queueRefresh;
        
        // Properties
        protected UnityEngine.RectTransform RectTransform { get; }
        
        // Methods
        protected UnityEngine.RectTransform get_RectTransform()
        {
            UnityEngine.Transform val_1 = this.CachedTransform;
            if(this == 0)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
        
        }
        protected void OnEnable()
        {
            this._queueRefresh = true;
        }
        protected void OnRectTransformDimensionsChange()
        {
            this._queueRefresh = true;
        }
        protected void Update()
        {
            if(this._queueRefresh == false)
            {
                    return;
            }
            
            this._queueRefresh = false;
        }
        protected abstract void Refresh(); // 0
        private void DoRefresh()
        {
            goto typeof(SRF.UI.ResponsiveBase).__il2cppRuntimeField_DC;
        }
        protected ResponsiveBase()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
