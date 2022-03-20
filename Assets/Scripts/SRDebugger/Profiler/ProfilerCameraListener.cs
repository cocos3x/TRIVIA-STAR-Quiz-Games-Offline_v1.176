using UnityEngine;

namespace SRDebugger.Profiler
{
    public class ProfilerCameraListener : MonoBehaviour
    {
        // Fields
        private UnityEngine.Camera _camera;
        private System.Diagnostics.Stopwatch _stopwatch;
        public System.Action<SRDebugger.Profiler.ProfilerCameraListener, double> RenderDurationCallback;
        
        // Properties
        protected System.Diagnostics.Stopwatch Stopwatch { get; }
        public UnityEngine.Camera Camera { get; }
        
        // Methods
        protected System.Diagnostics.Stopwatch get_Stopwatch()
        {
            System.Diagnostics.Stopwatch val_2 = this._stopwatch;
            if(val_2 != 0)
            {
                    return;
            }
            
            System.Diagnostics.Stopwatch val_1 = null;
            val_2 = val_1;
            val_1 = new System.Diagnostics.Stopwatch();
            this._stopwatch = val_2;
        }
        public UnityEngine.Camera get_Camera()
        {
            if(this._camera != 0)
            {
                    return;
            }
            
            object val_2 = this._camera.GetComponent<System.Object>();
            this._camera = this;
        }
        private void OnPreCull()
        {
            if(this.isActiveAndEnabled == false)
            {
                    return;
            }
            
            System.Diagnostics.Stopwatch val_2 = R4.Stopwatch;
            R4.Start();
        }
        private void OnPostRender()
        {
            var val_3;
            if(this.isActiveAndEnabled == false)
            {
                    return;
            }
            
            System.TimeSpan val_2 = Elapsed;
            System.Diagnostics.Stopwatch val_6 = this.Stopwatch;
            this.Stop();
            System.Diagnostics.Stopwatch val_7 = this.Stopwatch;
            this.Reset();
            if(this.RenderDurationCallback != 0)
            {
                    this.RenderDurationCallback.Invoke(arg1:  487979056, arg2:  val_3.TotalSeconds);
                return;
            }
            
            UnityEngine.Object.Destroy(obj:  487979056);
        }
        public ProfilerCameraListener()
        {
        
        }
    
    }

}
