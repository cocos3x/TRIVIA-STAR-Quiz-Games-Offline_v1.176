using UnityEngine;

namespace SRF.Service
{
    public interface IAsyncService
    {
        // Properties
        public abstract bool IsLoaded { get; }
        
        // Methods
        public abstract bool get_IsLoaded(); // 0
    
    }

}
