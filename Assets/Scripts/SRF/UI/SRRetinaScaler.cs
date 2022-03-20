using UnityEngine;

namespace SRF.UI
{
    public class SRRetinaScaler : SRMonoBehaviour
    {
        // Fields
        private float _retinaScale;
        private int _thresholdDpi;
        private bool _disablePixelPerfect;
        
        // Properties
        public int ThresholdDpi { get; }
        public float RetinaScale { get; }
        
        // Methods
        public int get_ThresholdDpi()
        {
            return (int)this._thresholdDpi;
        }
        public float get_RetinaScale()
        {
            return (float)S0;
        }
        private void Start()
        {
            float val_4;
            float val_1 = UnityEngine.Screen.dpi;
            object val_2 = this.GetComponent<System.Object>();
            if(this != 0)
            {
                    mem[1152921513583911388] = 0;
                val_4 = this._retinaScale;
            }
            else
            {
                    mem[12] = 0;
                val_4 = this._retinaScale;
            }
            
            this.scaleFactor = 0;
            if(this._disablePixelPerfect == false)
            {
                    return;
            }
            
            object val_3 = this.GetComponent<System.Object>();
            this.pixelPerfect = false;
        }
        public SRRetinaScaler()
        {
            this._retinaScale = 2f;
            this._thresholdDpi = 250;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
