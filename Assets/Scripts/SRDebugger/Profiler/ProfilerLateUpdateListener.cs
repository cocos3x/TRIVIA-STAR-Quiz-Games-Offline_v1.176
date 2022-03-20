using UnityEngine;

namespace SRDebugger.Profiler
{
    public class ProfilerLateUpdateListener : MonoBehaviour
    {
        // Fields
        public System.Action OnLateUpdate;
        
        // Methods
        private void LateUpdate()
        {
            if(this.OnLateUpdate == 0)
            {
                    return;
            }
            
            this.OnLateUpdate.Invoke();
        }
        public ProfilerLateUpdateListener()
        {
        
        }
    
    }

}
