using UnityEngine;

namespace SRDebugger.Services
{
    public interface IDockConsoleService
    {
        // Properties
        public abstract bool IsVisible { get; set; }
        public abstract bool IsExpanded { get; set; }
        public abstract SRDebugger.ConsoleAlignment Alignment { get; set; }
        
        // Methods
        public abstract bool get_IsVisible(); // 0
        public abstract void set_IsVisible(bool value); // 0
        public abstract bool get_IsExpanded(); // 0
        public abstract void set_IsExpanded(bool value); // 0
        public abstract SRDebugger.ConsoleAlignment get_Alignment(); // 0
        public abstract void set_Alignment(SRDebugger.ConsoleAlignment value); // 0
    
    }

}
