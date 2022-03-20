using UnityEngine;

namespace SRDebugger.UI.Other
{
    public class SetLayerFromSettings : SRMonoBehaviour
    {
        // Methods
        private void Start()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SRDebugger.Settings val_2 = SRDebugger.Settings.Instance;
            SRF.SRFGameObjectExtensions.SetLayerRecursive(o:  442978928, layer:  0);
        }
        public SetLayerFromSettings()
        {
        
        }
    
    }

}
