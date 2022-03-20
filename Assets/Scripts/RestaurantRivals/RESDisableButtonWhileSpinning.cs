using UnityEngine;

namespace RestaurantRivals
{
    public class RESDisableButtonWhileSpinning : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
    {
        // Fields
        private UnityEngine.UI.Button myButton;
        private bool wasEnabled;
        
        // Methods
        private void Start()
        {
            object val_1 = this.GetComponent<System.Object>();
            this.myButton = this;
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  528874288, name:  -1275408672);
            NotificationCenter val_3 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  528874288, name:  -1275408576);
        }
        private void OnDestroy()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            0.RemoveObserver(observer:  528986288, name:  -1275408672);
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            0.RemoveObserver(observer:  528986288, name:  -1275408576);
        }
        private void OnSpinStarted()
        {
            this.wasEnabled = this;
            if(this == 0)
            {
                    return;
            }
            
            this.myButton.interactable = false;
        }
        private void OnSpinEnded()
        {
            if(this.wasEnabled == false)
            {
                    return;
            }
            
            this.myButton.interactable = true;
        }
        public void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(true != 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            IsAutoSpin = false;
        }
        public RESDisableButtonWhileSpinning()
        {
        
        }
    
    }

}
