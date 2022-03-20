using UnityEngine;

namespace SRDebugger.Services
{
    public interface IDebugService
    {
        // Properties
        public abstract SRDebugger.Settings Settings { get; }
        public abstract bool IsDebugPanelVisible { get; }
        public abstract bool IsTriggerEnabled { get; set; }
        public abstract SRDebugger.Services.IDockConsoleService DockConsole { get; }
        public abstract bool IsProfilerDocked { get; set; }
        
        // Methods
        public abstract SRDebugger.Settings get_Settings(); // 0
        public abstract bool get_IsDebugPanelVisible(); // 0
        public abstract bool get_IsTriggerEnabled(); // 0
        public abstract void set_IsTriggerEnabled(bool value); // 0
        public abstract SRDebugger.Services.IDockConsoleService get_DockConsole(); // 0
        public abstract bool get_IsProfilerDocked(); // 0
        public abstract void set_IsProfilerDocked(bool value); // 0
        public abstract void AddSystemInfo(SRDebugger.InfoEntry entry, string category = "Default"); // 0
        public abstract void ShowDebugPanel(bool requireEntryCode = True); // 0
        public abstract void ShowDebugPanel(SRDebugger.DefaultTabs tab, bool requireEntryCode = True); // 0
        public abstract void HideDebugPanel(); // 0
        public abstract void DestroyDebugPanel(); // 0
        public abstract void AddOptionContainer(object container); // 0
        public abstract void RemoveOptionContainer(object container); // 0
        public abstract void PinAllOptions(string category); // 0
        public abstract void UnpinAllOptions(string category); // 0
        public abstract void PinOption(string name); // 0
        public abstract void UnpinOption(string name); // 0
        public abstract void ClearPinnedOptions(); // 0
        public abstract void ShowBugReportSheet(SRDebugger.ActionCompleteCallback onComplete, bool takeScreenshot = True, string descriptionContent); // 0
        public abstract void add_PanelVisibilityChanged(SRDebugger.VisibilityChangedDelegate value); // 0
        public abstract void remove_PanelVisibilityChanged(SRDebugger.VisibilityChangedDelegate value); // 0
        public abstract UnityEngine.RectTransform EnableWorldSpaceMode(); // 0
    
    }

}
