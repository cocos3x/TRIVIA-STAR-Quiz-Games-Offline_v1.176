using UnityEngine;

namespace SG
{
    internal class Pool
    {
        // Fields
        private System.Collections.Generic.Stack<SG.PoolObject> availableObjStack;
        private UnityEngine.GameObject rootObj;
        private SG.PoolInflationType inflationType;
        private string poolName;
        private int objectsInUse;
        
        // Methods
        public Pool(string poolName, UnityEngine.GameObject poolObjectPrefab, UnityEngine.GameObject rootPoolObj, int initialCount, SG.PoolInflationType type)
        {
            SG.PoolObject val_13;
            System.Collections.Generic.Stack<com.adjust.sdk.JSONNode> val_1 = new System.Collections.Generic.Stack<com.adjust.sdk.JSONNode>();
            this.availableObjStack = null;
            val_2 = new System.Object();
            if(val_2 == 0)
            {
                    return;
            }
            
            this.inflationType = type;
            this.poolName = poolName;
            string val_4 = poolName + 1183823936;
            this.rootObj = new UnityEngine.GameObject(name:  poolName);
            UnityEngine.Transform val_6 = transform;
            UnityEngine.Transform val_7 = rootPoolObj.transform;
            SetParent(parent:  rootPoolObj, worldPositionStays:  false);
            object val_8 = UnityEngine.Object.Instantiate<System.Object>(original:  UnityEngine.GameObject val_2 = poolObjectPrefab);
            object val_9 = val_2.GetComponent<System.Object>();
            val_13 = val_2;
            if(val_2 == 0)
            {
                    object val_11 = val_2.AddComponent<System.Object>();
                val_13 = val_2;
            }
            
            mem2[0] = poolName;
            this.AddObjectToPool(po:  val_13);
            this.populatePool(initialCount:  UnityEngine.Mathf.Max(a:  initialCount, b:  1));
        }
        private void AddObjectToPool(SG.PoolObject po)
        {
            UnityEngine.GameObject val_1 = po.gameObject;
            po.SetActive(value:  false);
            UnityEngine.GameObject val_2 = po.gameObject;
            po.name = this.poolName;
            this.availableObjStack.Push(item:  po);
            if(po != 0)
            {
                    po.isPooled = true;
            }
            else
            {
                    mem[16] = 1;
            }
            
            UnityEngine.GameObject val_3 = po.gameObject;
            UnityEngine.Transform val_4 = po.transform;
            UnityEngine.Transform val_5 = this.rootObj.transform;
            po.SetParent(parent:  this.rootObj, worldPositionStays:  false);
        }
        private void populatePool(int initialCount)
        {
            object val_3;
            int val_3 = initialCount;
            val_3 = 35633307;
            if(val_3 < 1)
            {
                    return;
            }
            
            SG.PoolObject val_1 = this.availableObjStack.Peek();
            val_3 = this.availableObjStack;
            object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  val_3);
            this.AddObjectToPool(po:  val_3);
            val_3 = val_3 - 1;
        }
        public UnityEngine.GameObject NextAvailableObject(bool autoActive)
        {
            UnityEngine.Object val_6;
            var val_7;
            var val_8;
            if(true >= 2)
            {
                goto label_2;
            }
            
            if(this.inflationType == 0)
            {
                goto label_3;
            }
            
            val_6 = 0;
            if(this.inflationType != 1)
            {
                goto label_9;
            }
            
            val_6 = 0;
            val_7 = (UnityEngine.Mathf.Max(a:  this.objectsInUse, b:  0)) + R8;
            if(val_7 >= 1)
            {
                goto label_8;
            }
            
            goto label_9;
            label_3:
            val_7 = 1;
            label_8:
            this.populatePool(initialCount:  1);
            label_2:
            SG.PoolObject val_2 = this.availableObjStack.Pop();
            val_6 = this.availableObjStack;
            label_9:
            val_8 = 0;
            if(val_6 == 0)
            {
                    return;
            }
            
            int val_5 = this.objectsInUse;
            val_5 = val_5 + 1;
            this.objectsInUse = val_5;
            if(val_6 != 0)
            {
                    mem2[0] = 0;
            }
            else
            {
                    mem[16] = 0;
            }
            
            UnityEngine.GameObject val_4 = val_6.gameObject;
            val_8 = val_6;
            if(autoActive == false)
            {
                    return;
            }
            
            val_8.SetActive(value:  true);
        }
        public void ReturnObjectToPool(SG.PoolObject po)
        {
            if((this.poolName.Equals(value:  po.poolName)) != false)
            {
                    int val_3 = this.objectsInUse;
                val_3 = val_3 - 1;
                this.objectsInUse = val_3;
                if(po.isPooled == true)
            {
                    return;
            }
            
                R5.AddObjectToPool(po:  R4);
                return;
            }
            
            string val_2 = System.String.Format(format:  1184380560, arg0:  po.poolName, arg1:  this.poolName);
            UnityEngine.Debug.LogError(message:  1184380560);
        }
    
    }

}
