using UnityEngine;

namespace SLC.Minigames
{
    public class MinigameHomeButton : MonoBehaviour
    {
        // Methods
        private void Awake()
        {
            object val_1 = this.GetComponent<System.Object>();
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  895809264, method:  new IntPtr(895784240));
            this.AddListener(call:  162246656);
        }
        private void OnButtonClick()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            HandleHomeClicked(redirectToGameplay:  false);
        }
        public MinigameHomeButton()
        {
        
        }
    
    }

}
