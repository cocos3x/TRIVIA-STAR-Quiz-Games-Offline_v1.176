using UnityEngine;

namespace SRDebugger.UI.Other
{
    public class DebugPanelBackgroundBehaviour : SRMonoBehaviour
    {
        // Fields
        private string _defaultKey;
        private bool _isTransparent;
        private SRF.UI.StyleComponent _styleComponent;
        public string TransparentStyleKey;
        
        // Methods
        private void Awake()
        {
            object val_1 = this.GetComponent<System.Object>();
            this._styleComponent = this;
            this._defaultKey = this;
            this.Update();
        }
        private void Update()
        {
            if(this._isTransparent == false)
            {
                goto label_0;
            }
            
            label_6:
            SRDebugger.Settings val_1 = SRDebugger.Settings.Instance;
            if((this._isTransparent + 44) != 0)
            {
                    return;
            }
            
            R4 + 44.StyleKey = R4 + 36;
            mem2[0] = 0;
            return;
            label_0:
            SRDebugger.Settings val_2 = SRDebugger.Settings.Instance;
            if((this._isTransparent + 44) != 0)
            {
                    this._styleComponent.StyleKey = this.TransparentStyleKey;
                this._isTransparent = true;
                return;
            }
            
            if(this._isTransparent == true)
            {
                goto label_6;
            }
        
        }
        public DebugPanelBackgroundBehaviour()
        {
            this.TransparentStyleKey = "";
        }
    
    }

}
