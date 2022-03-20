using UnityEngine;

namespace SRDebugger.Services
{
    public interface IConsoleService
    {
        // Properties
        public abstract int ErrorCount { get; }
        public abstract int WarningCount { get; }
        public abstract int InfoCount { get; }
        public abstract SRDebugger.IReadOnlyList<SRDebugger.Services.ConsoleEntry> Entries { get; }
        public abstract SRDebugger.IReadOnlyList<SRDebugger.Services.ConsoleEntry> AllEntries { get; }
        
        // Methods
        public abstract int get_ErrorCount(); // 0
        public abstract int get_WarningCount(); // 0
        public abstract int get_InfoCount(); // 0
        public abstract SRDebugger.IReadOnlyList<SRDebugger.Services.ConsoleEntry> get_Entries(); // 0
        public abstract SRDebugger.IReadOnlyList<SRDebugger.Services.ConsoleEntry> get_AllEntries(); // 0
        public abstract void add_Updated(SRDebugger.Services.ConsoleUpdatedEventHandler value); // 0
        public abstract void remove_Updated(SRDebugger.Services.ConsoleUpdatedEventHandler value); // 0
        public abstract void Clear(); // 0
    
    }

}
