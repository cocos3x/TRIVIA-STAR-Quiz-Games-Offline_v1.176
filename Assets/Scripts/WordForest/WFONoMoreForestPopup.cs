using UnityEngine;

namespace WordForest
{
    public class WFONoMoreForestPopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Button closeButton;
        private UnityEngine.UI.Button playButton;
        private UnityEngine.UI.Text playButtonText;
        
        // Methods
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  335739440, method:  new IntPtr(335701104));
            this.playButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  335739440, method:  new IntPtr(335710320));
            this.closeButton.m_OnClick.AddListener(call:  162246656);
            Player val_3 = App.Player;
            string val_4 = System.String.Format(format:  2127161280, arg0:  13152256);
            if(this.playButtonText != 0)
            {
                    return;
            }
        
        }
        private void OnPlayButtonClicked()
        {
            GameBehavior val_1 = App.getBehavior;
            UnityEngine.GameObject val_2 = this.gameObject;
            SLCWindow.CloseWindow(window:  335871920, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void OnCloseButtonClicked()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  335983920, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public WFONoMoreForestPopup()
        {
        
        }
    
    }

}
