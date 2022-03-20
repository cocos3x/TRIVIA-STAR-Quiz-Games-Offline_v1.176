using UnityEngine;

namespace SRF.UI
{
    public class InheritColour : SRMonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Graphic _graphic;
        public UnityEngine.UI.Graphic From;
        
        // Properties
        private UnityEngine.UI.Graphic Graphic { get; }
        
        // Methods
        private UnityEngine.UI.Graphic get_Graphic()
        {
            if(this._graphic != 0)
            {
                    return;
            }
            
            object val_2 = this.GetComponent<System.Object>();
            this._graphic = this;
        }
        private void Refresh()
        {
            if(this.From == 0)
            {
                    return;
            }
            
            UnityEngine.UI.Graphic val_2 = this.Graphic;
            UnityEngine.CanvasRenderer val_3 = this.From.canvasRenderer;
            UnityEngine.Color val_4 = GetColor();
        }
        private void Update()
        {
            this.Refresh();
        }
        private void Start()
        {
            this.Refresh();
        }
        public InheritColour()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
