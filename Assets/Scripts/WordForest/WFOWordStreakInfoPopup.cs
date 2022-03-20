using UnityEngine;

namespace WordForest
{
    public class WFOWordStreakInfoPopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Button closeButton;
        private UnityEngine.UI.Button okButton;
        
        // Methods
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  358674336, method:  new IntPtr(358641120));
            this.closeButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  358674336, method:  new IntPtr(358641120));
            this.okButton.m_OnClick.AddListener(call:  162246656);
        }
        private void CloseWindow()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  358802720, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public WFOWordStreakInfoPopup()
        {
        
        }
    
    }

}
