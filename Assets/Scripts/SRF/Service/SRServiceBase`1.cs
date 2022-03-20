using UnityEngine;

namespace SRF.Service
{
    public abstract class SRServiceBase<T> : SRMonoBehaviourEx
    {
        // Methods
        protected override void Awake()
        {
            this.Awake();
            goto __RuntimeMethodHiddenParam + 12 + 96;
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            goto __RuntimeMethodHiddenParam + 12 + 96 + 4;
        }
        protected SRServiceBase<T>()
        {
            if(this != 0)
            {
                    return;
            }
        
        }
    
    }

}
