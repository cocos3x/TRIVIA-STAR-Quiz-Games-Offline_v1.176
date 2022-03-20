using UnityEngine;

namespace WordForest
{
    public class WFOForestInfoPopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Button closeButton;
        private UnityEngine.UI.Button okButton;
        
        // Methods
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  290639744, method:  new IntPtr(290606528));
            this.closeButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  290639744, method:  new IntPtr(290606528));
            this.okButton.m_OnClick.AddListener(call:  162246656);
        }
        private void CloseWindow()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  290768128, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public WFOForestInfoPopup()
        {
        
        }
    
    }

}
