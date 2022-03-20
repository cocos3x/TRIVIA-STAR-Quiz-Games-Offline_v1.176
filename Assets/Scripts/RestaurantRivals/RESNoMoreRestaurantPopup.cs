using UnityEngine;

namespace RestaurantRivals
{
    public class RESNoMoreRestaurantPopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Button playButton;
        
        // Methods
        private void Start()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  579586000, method:  new IntPtr(579560976));
            this.playButton.m_OnClick.AddListener(call:  162246656);
        }
        private void OnPlayButtonClicked()
        {
            GameBehavior val_1 = App.getBehavior;
            UnityEngine.GameObject val_2 = this.gameObject;
            SLCWindow.CloseWindow(window:  579706192, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        public RESNoMoreRestaurantPopup()
        {
        
        }
    
    }

}
