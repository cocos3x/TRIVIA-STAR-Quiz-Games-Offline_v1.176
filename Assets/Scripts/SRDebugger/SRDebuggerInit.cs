using UnityEngine;

namespace SRDebugger
{
    public class SRDebuggerInit : SRMonoBehaviourEx
    {
        // Methods
        protected override void Awake()
        {
            this.Awake();
            SRDebugger.Settings val_1 = SRDebugger.Settings.Instance;
            if(0 == 0)
            {
                    return;
            }
            
            SRDebug.Init();
        }
        protected override void Start()
        {
            this.Start();
            UnityEngine.GameObject val_1 = this.CachedGameObject;
            UnityEngine.Object.Destroy(obj:  413737200);
        }
        public SRDebuggerInit()
        {
        
        }
    
    }

}
