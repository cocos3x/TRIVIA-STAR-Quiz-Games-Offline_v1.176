using UnityEngine;

namespace WordPets
{
    public class ToggleActiveMessageHelper : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject[] targetObject;
        
        // Methods
        public void ToggleActive()
        {
            this.ToggleState(isVisible:  true);
        }
        public void ToggleInactive()
        {
            this.ToggleState(isVisible:  false);
        }
        private void ToggleState(bool isVisible)
        {
            var val_1 = 0;
            goto label_0;
            label_5:
            UnityEngine.GameObject val_1 = this.targetObject[val_1];
            val_1.SetActive(value:  isVisible);
            val_1 = 1;
            label_0:
            if(val_1 < val_1)
            {
                goto label_5;
            }
        
        }
        public ToggleActiveMessageHelper()
        {
        
        }
    
    }

}
