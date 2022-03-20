using UnityEngine;

namespace SRDebugger.Services
{
    public interface IProfilerService
    {
        // Properties
        public abstract float AverageFrameTime { get; }
        public abstract float LastFrameTime { get; }
        public abstract SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame> FrameBuffer { get; }
        
        // Methods
        public abstract float get_AverageFrameTime(); // 0
        public abstract float get_LastFrameTime(); // 0
        public abstract SRDebugger.CircularBuffer<SRDebugger.Services.ProfilerFrame> get_FrameBuffer(); // 0
    
    }

}
