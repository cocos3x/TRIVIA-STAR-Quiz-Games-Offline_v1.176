using UnityEngine;

namespace RestaurantRivals
{
    public class RESBatteryGettingPopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.Transform batteryObject;
        private UnityEngine.CanvasGroup canvasGroup;
        
        // Methods
        private void OnEnable()
        {
            System.Collections.IEnumerator val_1 = this.ShowBattery();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  526998320);
        }
        public System.Collections.IEnumerator ShowBattery()
        {
            object val_1 = new System.Object();
            typeof(RESBatteryGettingPopup.<ShowBattery>d__3).__il2cppRuntimeField_8 = 0;
            typeof(RESBatteryGettingPopup.<ShowBattery>d__3).__il2cppRuntimeField_10 = this;
        }
        public RESBatteryGettingPopup()
        {
        
        }
    
    }

}
