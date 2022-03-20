using UnityEngine;

namespace SRDebugger.Services
{
    public interface IDebugTriggerService
    {
        // Properties
        public abstract bool IsEnabled { get; set; }
        public abstract SRDebugger.PinAlignment Position { get; set; }
        
        // Methods
        public abstract bool get_IsEnabled(); // 0
        public abstract void set_IsEnabled(bool value); // 0
        public abstract SRDebugger.PinAlignment get_Position(); // 0
        public abstract void set_Position(SRDebugger.PinAlignment value); // 0
    
    }

}
