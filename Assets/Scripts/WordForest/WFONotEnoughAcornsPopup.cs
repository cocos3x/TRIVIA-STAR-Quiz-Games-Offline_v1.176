using UnityEngine;

namespace WordForest
{
    public class WFONotEnoughAcornsPopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Button closeButton;
        private UnityEngine.UI.Button playButton;
        private UnityEngine.UI.Text playButtonText;
        
        // Methods
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  336230448, method:  new IntPtr(336192112));
            this.closeButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  336230448, method:  new IntPtr(336201328));
            this.playButton.m_OnClick.AddListener(call:  162246656);
            Player val_3 = App.Player;
            string val_4 = System.String.Format(format:  2127161280, arg0:  13152256);
            if(this.playButtonText != 0)
            {
                    return;
            }
        
        }
        private void OnCloseButtonClicked()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  336362928, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void OnPlayButtonClicked()
        {
            GameBehavior val_1 = App.getBehavior;
            UnityEngine.GameObject val_2 = this.gameObject;
            SLCWindow.CloseWindow(window:  336474928, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public WFONotEnoughAcornsPopup()
        {
        
        }
    
    }

}
