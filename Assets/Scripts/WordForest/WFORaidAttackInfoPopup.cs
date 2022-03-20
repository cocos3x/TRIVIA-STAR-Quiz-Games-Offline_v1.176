using UnityEngine;

namespace WordForest
{
    public class WFORaidAttackInfoPopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Button closeButton;
        
        // Methods
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  339252432, method:  new IntPtr(339227408));
            this.closeButton.m_OnClick.AddListener(call:  162246656);
        }
        private void CloseWindow()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  339372624, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public WFORaidAttackInfoPopup()
        {
        
        }
    
    }

}
