using UnityEngine;

namespace SRDebugger.Services
{
    public interface IDebugCameraService
    {
        // Properties
        public abstract UnityEngine.Camera Camera { get; }
        
        // Methods
        public abstract UnityEngine.Camera get_Camera(); // 0
    
    }

}
