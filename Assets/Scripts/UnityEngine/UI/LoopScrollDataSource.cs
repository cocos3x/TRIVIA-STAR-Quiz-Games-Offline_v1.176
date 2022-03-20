using UnityEngine;

namespace UnityEngine.UI
{
    public abstract class LoopScrollDataSource
    {
        // Methods
        public abstract void ProvideData(UnityEngine.Transform transform, int idx); // 0
        protected LoopScrollDataSource()
        {
        
        }
    
    }

}
