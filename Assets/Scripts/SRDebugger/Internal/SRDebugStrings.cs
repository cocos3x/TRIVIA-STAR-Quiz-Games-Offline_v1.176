using UnityEngine;

namespace SRDebugger.Internal
{
    public class SRDebugStrings
    {
        // Fields
        public static readonly SRDebugger.Internal.SRDebugStrings Current;
        public readonly string Console_MessageTruncated;
        public readonly string Console_NoStackTrace;
        public readonly string PinEntryPrompt;
        public readonly string Profiler_DisableProfilerInfo;
        public readonly string Profiler_EnableProfilerInfo;
        public readonly string Profiler_NoProInfo;
        public readonly string Profiler_NotSupported;
        public readonly string ProfilerCameraListenerHelp;
        
        // Methods
        public SRDebugStrings()
        {
            this.Console_MessageTruncated = "-- Message Truncated --";
            this.Console_NoStackTrace = "-- No Stack Trace Available --";
        }
        private static SRDebugStrings()
        {
            SRDebugger.Internal.SRDebugStrings.Current = new SRDebugger.Internal.SRDebugStrings();
        }
    
    }

}
