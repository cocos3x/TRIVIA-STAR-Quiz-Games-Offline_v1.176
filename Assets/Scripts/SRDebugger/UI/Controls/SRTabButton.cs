using UnityEngine;

namespace SRDebugger.UI.Controls
{
    public class SRTabButton : SRMonoBehaviourEx
    {
        // Fields
        public UnityEngine.Behaviour ActiveToggle;
        public UnityEngine.UI.Button Button;
        public UnityEngine.RectTransform ExtraContentContainer;
        public SRF.UI.StyleComponent IconStyleComponent;
        public UnityEngine.UI.Text TitleText;
        
        // Properties
        public bool IsActive { get; set; }
        
        // Methods
        public bool get_IsActive()
        {
            if(this.ActiveToggle != 0)
            {
                    return this.ActiveToggle.enabled;
            }
            
            return this.ActiveToggle.enabled;
        }
        public void set_IsActive(bool value)
        {
            this.ActiveToggle.enabled = value;
        }
        public SRTabButton()
        {
        
        }
    
    }

}
