using UnityEngine;

namespace RestaurantRivals
{
    public class RESShieldGettingPopup : MonoBehaviour
    {
        // Fields
        private UnityEngine.Transform shieldObject;
        private UnityEngine.Vector3 originalPosition;
        
        // Methods
        private void OnEnable()
        {
            UnityEngine.Vector3 val_1 = position;
            System.Collections.IEnumerator val_2 = this.ShowShield();
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  644862320);
        }
        private System.Collections.IEnumerator ShowShield()
        {
            object val_1 = new System.Object();
            typeof(RESShieldGettingPopup.<ShowShield>d__3).__il2cppRuntimeField_8 = 0;
            typeof(RESShieldGettingPopup.<ShowShield>d__3).__il2cppRuntimeField_10 = this;
        }
        public RESShieldGettingPopup()
        {
        
        }
    
    }

}
