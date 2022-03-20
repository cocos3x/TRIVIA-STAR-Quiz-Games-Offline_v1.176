using UnityEngine;

namespace SRDebugger.UI.Other
{
    public class ScrollSettingsBehaviour : MonoBehaviour
    {
        // Fields
        public const float ScrollSensitivity = 40;
        
        // Methods
        private void Awake()
        {
            object val_1 = this.GetComponent<System.Object>();
            mem[1152921513639536532] = 1109393408;
            bool val_2 = SRDebugger.Internal.SRDebuggerUtil.IsMobilePlatform;
            if(val_2 == false)
            {
                    val_2 = 2;
                mem[1152921513639536524] = 0;
                mem[1152921513639536516] = val_2;
            }
        
        }
        public ScrollSettingsBehaviour()
        {
        
        }
    
    }

}
