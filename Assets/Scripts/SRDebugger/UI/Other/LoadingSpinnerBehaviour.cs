using UnityEngine;

namespace SRDebugger.UI.Other
{
    public class LoadingSpinnerBehaviour : SRMonoBehaviour
    {
        // Fields
        private float _dt;
        public int FrameCount;
        public float SpinDuration;
        
        // Methods
        private void Update()
        {
            var val_7;
            float val_10;
            var val_11;
            float val_1 = UnityEngine.Time.unscaledDeltaTime;
            uint val_11 = 0;
            val_11 = this._dt + val_11;
            this._dt = val_11;
            UnityEngine.Transform val_2 = this.CachedTransform;
            UnityEngine.Quaternion val_3 = localRotation;
            UnityEngine.Vector3 val_4 = eulerAngles;
            float val_12 = this.SpinDuration;
            float val_13 = (float)this.FrameCount;
            float val_14 = this._dt;
            val_12 = val_12 / val_13;
            if(this <= 0)
            {
                    return;
            }
            
            val_13 = 360f / val_13;
            var val_15 = val_7;
            do
            {
                val_14 = val_14 - val_12;
                val_15 = val_15 - val_13;
            }
            while(this > 0);
            
            this._dt = val_14;
            UnityEngine.Transform val_8 = this.CachedTransform;
            UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.Euler(x:  val_14, y:  val_4.y, z:  val_12);
            val_11 = 0;
            this.localRotation = new UnityEngine.Quaternion() {w = val_10};
        }
        public LoadingSpinnerBehaviour()
        {
            this.FrameCount = 12;
            this.SpinDuration = 0.8f;
        }
    
    }

}
