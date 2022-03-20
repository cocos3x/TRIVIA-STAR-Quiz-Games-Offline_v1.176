using UnityEngine;

namespace SRDebugger.Services
{
    public interface IPinnedUIService
    {
        // Properties
        public abstract bool IsProfilerPinned { get; set; }
        
        // Methods
        public abstract void add_OptionPinStateChanged(System.Action<SRDebugger.Internal.OptionDefinition, bool> value); // 0
        public abstract void remove_OptionPinStateChanged(System.Action<SRDebugger.Internal.OptionDefinition, bool> value); // 0
        public abstract bool get_IsProfilerPinned(); // 0
        public abstract void set_IsProfilerPinned(bool value); // 0
        public abstract void Pin(SRDebugger.Internal.OptionDefinition option, int order = -1); // 0
        public abstract void Unpin(SRDebugger.Internal.OptionDefinition option); // 0
        public abstract void UnpinAll(); // 0
        public abstract bool HasPinned(SRDebugger.Internal.OptionDefinition option); // 0
    
    }

}
