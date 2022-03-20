using UnityEngine;

namespace SRDebugger.UI.Other
{
    public class ScrollRectPatch : MonoBehaviour
    {
        // Fields
        public UnityEngine.RectTransform Content;
        public UnityEngine.UI.Mask ReplaceMask;
        public UnityEngine.RectTransform Viewport;
        
        // Methods
        private void Awake()
        {
            UnityEngine.RectTransform val_8;
            object val_1 = this.GetComponent<System.Object>();
            if(this != 0)
            {
                    this.Content = this.Content;
                val_8 = this.Viewport;
            }
            else
            {
                    mem[12] = this.Content;
                val_8 = this.Viewport;
            }
            
            this.viewport = val_8;
            if(this.ReplaceMask == 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_3 = this.ReplaceMask.gameObject;
            object val_4 = this.ReplaceMask.GetComponent<System.Object>();
            UnityEngine.Object.Destroy(obj:  this.ReplaceMask);
            if(this.ReplaceMask != 0)
            {
                    object val_5 = this.ReplaceMask.GetComponent<System.Object>();
                UnityEngine.Object.Destroy(obj:  this.ReplaceMask);
                UnityEngine.Object.Destroy(obj:  this.ReplaceMask);
            }
            else
            {
                    object val_6 = 0.GetComponent<System.Object>();
                UnityEngine.Object.Destroy(obj:  0);
                UnityEngine.Object.Destroy(obj:  this.ReplaceMask);
            }
            
            object val_7 = this.ReplaceMask.AddComponent<System.Object>();
        }
        public ScrollRectPatch()
        {
        
        }
    
    }

}
