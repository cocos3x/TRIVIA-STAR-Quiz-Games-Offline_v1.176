using UnityEngine;

namespace SRDebugger.UI.Other
{
    public class ConfigureCanvasFromSettings : SRMonoBehaviour
    {
        // Methods
        private void Start()
        {
            object val_1 = this.GetComponent<System.Object>();
            SRDebugger.Internal.SRDebuggerUtil.ConfigureCanvas(canvas:  435143584);
            UnityEngine.Object.Destroy(obj:  435143584);
        }
        public ConfigureCanvasFromSettings()
        {
        
        }
    
    }

}
