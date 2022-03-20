using UnityEngine;

namespace SRDebugger.Services.Implementation
{
    public class DebugCameraServiceImpl : IDebugCameraService
    {
        // Fields
        private UnityEngine.Camera _debugCamera;
        
        // Properties
        public UnityEngine.Camera Camera { get; }
        
        // Methods
        public DebugCameraServiceImpl()
        {
            SRDebugger.Settings val_1 = SRDebugger.Settings.Instance;
            if(52 == 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = new UnityEngine.GameObject(name:  469586704);
            object val_3 = AddComponent<System.Object>();
            this._debugCamera = null;
            SRDebugger.Settings val_4 = SRDebugger.Settings.Instance;
            int val_9 = 1;
            val_9 = val_9 << (52 & 31);
            cullingMask = val_9;
            SRDebugger.Settings val_6 = SRDebugger.Settings.Instance;
            this._debugCamera.depth = null;
            this._debugCamera.clearFlags = 3;
            UnityEngine.Transform val_7 = this._debugCamera.transform;
            UnityEngine.Transform val_8 = SRF.Hierarchy.Get(key:  466780208);
            this._debugCamera.SetParent(p:  466780208);
        }
        public UnityEngine.Camera get_Camera()
        {
        
        }
    
    }

}
