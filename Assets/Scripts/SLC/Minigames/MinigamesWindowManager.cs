using UnityEngine;

namespace SLC.Minigames
{
    public class MinigamesWindowManager : SLCWindowManager<SLC.Minigames.MinigamesWindowManager>
    {
        // Properties
        protected override System.Type myWindowType { get; }
        
        // Methods
        protected override System.Type get_myWindowType()
        {
            return System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(447549440)});
        }
        public MinigamesWindowManager()
        {
        
        }
    
    }

}
