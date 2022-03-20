using UnityEngine;

namespace SRDebugger.Internal
{
    public static class Service
    {
        // Fields
        private static SRDebugger.Services.IConsoleService _consoleService;
        private static SRDebugger.Services.IDebugPanelService _debugPanelService;
        private static SRDebugger.Services.IDebugTriggerService _debugTriggerService;
        private static SRDebugger.Services.IPinnedUIService _pinnedUiService;
        private static SRDebugger.Services.IDebugCameraService _debugCameraService;
        private static SRDebugger.Services.IOptionsService _optionsService;
        private static SRDebugger.Services.IDockConsoleService _dockConsoleService;
        
        // Properties
        public static SRDebugger.Services.IConsoleService Console { get; }
        public static SRDebugger.Services.IDockConsoleService DockConsole { get; }
        public static SRDebugger.Services.IDebugPanelService Panel { get; }
        public static SRDebugger.Services.IDebugTriggerService Trigger { get; }
        public static SRDebugger.Services.IPinnedUIService PinnedUI { get; }
        public static SRDebugger.Services.IDebugCameraService DebugCamera { get; }
        public static SRDebugger.Services.IOptionsService Options { get; }
        
        // Methods
        public static SRDebugger.Services.IConsoleService get_Console()
        {
            if(SRDebugger.Internal.Service._consoleService != 0)
            {
                    return;
            }
            
            object val_1 = SRF.Service.SRServiceManager.GetService<System.Object>();
            mem2[0] = public static SRDebugger.Services.IConsoleService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.IConsoleService>();
        }
        public static SRDebugger.Services.IDockConsoleService get_DockConsole()
        {
            if(SRDebugger.Internal.Service._dockConsoleService != 0)
            {
                    return;
            }
            
            object val_1 = SRF.Service.SRServiceManager.GetService<System.Object>();
            mem2[0] = public static SRDebugger.Services.IDockConsoleService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.IDockConsoleService>();
        }
        public static SRDebugger.Services.IDebugPanelService get_Panel()
        {
            if(SRDebugger.Internal.Service._debugPanelService != 0)
            {
                    return;
            }
            
            object val_1 = SRF.Service.SRServiceManager.GetService<System.Object>();
            mem2[0] = public static SRDebugger.Services.IDebugPanelService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.IDebugPanelService>();
        }
        public static SRDebugger.Services.IDebugTriggerService get_Trigger()
        {
            if(SRDebugger.Internal.Service._debugTriggerService != 0)
            {
                    return;
            }
            
            object val_1 = SRF.Service.SRServiceManager.GetService<System.Object>();
            mem2[0] = public static SRDebugger.Services.IDebugTriggerService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.IDebugTriggerService>();
        }
        public static SRDebugger.Services.IPinnedUIService get_PinnedUI()
        {
            if(SRDebugger.Internal.Service._pinnedUiService != 0)
            {
                    return;
            }
            
            object val_1 = SRF.Service.SRServiceManager.GetService<System.Object>();
            mem2[0] = public static SRDebugger.Services.IPinnedUIService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.IPinnedUIService>();
        }
        public static SRDebugger.Services.IDebugCameraService get_DebugCamera()
        {
            if(SRDebugger.Internal.Service._debugCameraService != 0)
            {
                    return;
            }
            
            object val_1 = SRF.Service.SRServiceManager.GetService<System.Object>();
            mem2[0] = public static SRDebugger.Services.IDebugCameraService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.IDebugCameraService>();
        }
        public static SRDebugger.Services.IOptionsService get_Options()
        {
            if(SRDebugger.Internal.Service._optionsService != 0)
            {
                    return;
            }
            
            object val_1 = SRF.Service.SRServiceManager.GetService<System.Object>();
            mem2[0] = public static SRDebugger.Services.IOptionsService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.IOptionsService>();
        }
    
    }

}
