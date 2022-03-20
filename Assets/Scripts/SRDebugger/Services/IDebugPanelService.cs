using UnityEngine;

namespace SRDebugger.Services
{
    public interface IDebugPanelService
    {
        // Properties
        public abstract bool IsLoaded { get; }
        public abstract bool IsVisible { get; set; }
        public abstract System.Nullable<SRDebugger.DefaultTabs> ActiveTab { get; }
        
        // Methods
        public abstract bool get_IsLoaded(); // 0
        public abstract bool get_IsVisible(); // 0
        public abstract void set_IsVisible(bool value); // 0
        public abstract System.Nullable<SRDebugger.DefaultTabs> get_ActiveTab(); // 0
        public abstract void add_VisibilityChanged(System.Action<SRDebugger.Services.IDebugPanelService, bool> value); // 0
        public abstract void remove_VisibilityChanged(System.Action<SRDebugger.Services.IDebugPanelService, bool> value); // 0
        public abstract void Unload(); // 0
        public abstract void OpenTab(SRDebugger.DefaultTabs tab); // 0
    
    }

}
