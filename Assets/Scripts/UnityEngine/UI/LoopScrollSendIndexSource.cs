using UnityEngine;

namespace UnityEngine.UI
{
    public class LoopScrollSendIndexSource : LoopScrollDataSource
    {
        // Fields
        public static readonly UnityEngine.UI.LoopScrollSendIndexSource Instance;
        
        // Methods
        private LoopScrollSendIndexSource()
        {
        
        }
        public override void ProvideData(UnityEngine.Transform transform, int idx)
        {
            transform.SendMessage(methodName:  1166133360, value:  13152256);
        }
        private static LoopScrollSendIndexSource()
        {
            UnityEngine.UI.LoopScrollSendIndexSource.Instance = new UnityEngine.UI.LoopScrollDataSource();
        }
    
    }

}
