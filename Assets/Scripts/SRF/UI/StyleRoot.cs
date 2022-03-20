using UnityEngine;

namespace SRF.UI
{
    public sealed class StyleRoot : SRMonoBehaviour
    {
        // Fields
        private SRF.UI.StyleSheet _activeStyleSheet;
        public SRF.UI.StyleSheet StyleSheet;
        
        // Methods
        public SRF.UI.Style GetStyle(string key)
        {
            if(this.StyleSheet == 0)
            {
                    UnityEngine.Debug.LogWarning(message:  391137024, context:  391165264);
                return;
            }
            
            if(this.StyleSheet != 0)
            {
                    return this.StyleSheet.GetStyle(key:  key, searchParent:  true);
            }
            
            return this.StyleSheet.GetStyle(key:  key, searchParent:  true);
        }
        private void OnEnable()
        {
            this._activeStyleSheet = 0;
            if(this.StyleSheet == 0)
            {
                    return;
            }
            
            R4.OnStyleSheetChanged();
        }
        private void OnDisable()
        {
            this.OnStyleSheetChanged();
        }
        private void Update()
        {
            if(this._activeStyleSheet == this.StyleSheet)
            {
                    return;
            }
            
            this.OnStyleSheetChanged();
        }
        private void OnStyleSheetChanged()
        {
            this._activeStyleSheet = this.StyleSheet;
            this.BroadcastMessage(methodName:  391630224, options:  1);
        }
        public void SetDirty()
        {
            this._activeStyleSheet = 0;
        }
        public StyleRoot()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
