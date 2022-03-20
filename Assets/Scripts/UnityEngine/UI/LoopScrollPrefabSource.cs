using UnityEngine;

namespace UnityEngine.UI
{
    [Serializable]
    public class LoopScrollPrefabSource
    {
        // Fields
        public UnityEngine.GameObject poolPrefab;
        public int poolSize;
        private bool inited;
        
        // Methods
        public virtual UnityEngine.GameObject GetObject()
        {
            if(this.inited != true)
            {
                    SG.ResourceManager val_1 = SG.ResourceManager.Instance;
                0.InitPool(poolPrefab:  this.poolPrefab, size:  this.poolSize, type:  1);
                this.inited = true;
            }
            
            SG.ResourceManager val_2 = SG.ResourceManager.Instance;
            UnityEngine.GameObject val_3 = 0.GetObjectFromPool(poolPrefab:  this.poolPrefab, autoActive:  true, autoCreate:  0);
        }
        public virtual void ReturnObject(UnityEngine.Transform go)
        {
            go.SendMessage(methodName:  1166800080, options:  1);
            SG.ResourceManager val_1 = SG.ResourceManager.Instance;
            UnityEngine.GameObject val_2 = go.gameObject;
            0.ReturnObjectToPool(go:  go);
        }
        public LoopScrollPrefabSource()
        {
            this.poolSize = 5;
        }
    
    }

}
