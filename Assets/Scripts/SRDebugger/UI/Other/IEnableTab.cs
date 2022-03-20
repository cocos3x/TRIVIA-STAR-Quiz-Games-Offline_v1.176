using UnityEngine;

namespace SRDebugger.UI.Other
{
    public interface IEnableTab
    {
        // Properties
        public abstract bool IsEnabled { get; }
        
        // Methods
        public abstract bool get_IsEnabled(); // 0
    
    }

}
