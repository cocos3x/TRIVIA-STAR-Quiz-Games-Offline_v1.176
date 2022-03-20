using UnityEngine;

namespace SRDebugger.Services
{
    public interface IPinEntryService
    {
        // Properties
        public abstract bool IsShowingKeypad { get; }
        
        // Methods
        public abstract bool get_IsShowingKeypad(); // 0
        public abstract void ShowPinEntry(System.Collections.Generic.IList<int> requiredPin, string message, SRDebugger.Services.PinEntryCompleteCallback callback, bool allowCancel = True); // 0
        public abstract void ShowPinEntry(System.Collections.Generic.IList<int> requiredPin, string message, SRDebugger.Services.PinEntryCompleteCallback callback, bool blockInput, bool allowCancel); // 0
    
    }

}
