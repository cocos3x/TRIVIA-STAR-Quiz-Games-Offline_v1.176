using UnityEngine;

namespace WordPets
{
    public class ToggleCanvasAlphaMessageHelper : MonoBehaviour
    {
        // Fields
        private UnityEngine.CanvasGroup[] targetObject;
        
        // Methods
        public void ToggleVisible()
        {
            this.ToggleState(isVisible:  true);
        }
        public void ToggleInvisible()
        {
            this.ToggleState(isVisible:  false);
        }
        private void ToggleState(bool isVisible)
        {
            var val_1 = 0;
            goto label_0;
            label_5:
            UnityEngine.CanvasGroup val_1 = this.targetObject[val_1];
            val_1.alpha = 0f;
            val_1 = 1;
            label_0:
            if(val_1 < val_1)
            {
                goto label_5;
            }
        
        }
        public ToggleCanvasAlphaMessageHelper()
        {
        
        }
    
    }

}
