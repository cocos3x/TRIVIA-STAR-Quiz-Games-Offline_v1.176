using UnityEngine;

namespace SRDebugger.UI
{
    public class DebugPanelRoot : SRMonoBehaviourEx
    {
        // Fields
        public UnityEngine.Canvas Canvas;
        public UnityEngine.CanvasGroup CanvasGroup;
        public SRDebugger.Scripts.DebuggerTabController TabController;
        
        // Methods
        public void Close()
        {
            var val_4;
            object val_1 = SRF.Service.SRServiceManager.GetService<System.Object>();
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_4 = public static SRDebugger.Services.IDebugService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.IDebugService>();
            goto ((as. 
               
               
              
            
            
            
             + ((as. 
               
               
              
            
            
            
            .__il2cppRuntimeField_58 + 0) + 4) << 3) + 268);
        }
        public void CloseAndDestroy()
        {
            var val_4;
            object val_1 = SRF.Service.SRServiceManager.GetService<System.Object>();
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_4 = public static SRDebugger.Services.IDebugService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.IDebugService>();
            goto ((as. 
               
               
              
            
            
            
             + ((as. 
               
               
              
            
            
            
            .__il2cppRuntimeField_58 + 0) + 4) << 3) + 276);
        }
        public DebugPanelRoot()
        {
        
        }
    
    }

}
