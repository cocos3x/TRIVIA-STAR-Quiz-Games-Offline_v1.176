using UnityEngine;

namespace RestaurantRivals
{
    public class WelcomeBonusPopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Button buttonCollect;
        
        // Methods
        private void OnCollect()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            AwardWelcomeBonus();
            UnityEngine.GameObject val_2 = this.gameObject;
            SLCWindow.CloseWindow(window:  674599040, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        private void Awake()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  674720256, method:  new IntPtr(674695232));
            this.buttonCollect.m_OnClick.AddListener(call:  162246656);
        }
        public WelcomeBonusPopup()
        {
        
        }
    
    }

}
