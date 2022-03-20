using UnityEngine;

namespace SG
{
    public class ResourceManager : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, SG.Pool> poolDict;
        private static SG.ResourceManager mInstance;
        
        // Properties
        public static SG.ResourceManager Instance { get; }
        
        // Methods
        public static SG.ResourceManager get_Instance()
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            val_9 = null;
            val_9 = null;
            if(SG.ResourceManager.mInstance == 0)
            {
                    System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(461074432)});
                typeof(System.Type[]).__il2cppRuntimeField_10 = null;
                UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  1184521392, components:  473824320);
                UnityEngine.Transform val_4 = transform;
                UnityEngine.Vector3 val_5 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
                localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
                object val_6 = GetComponent<System.Object>();
                val_10 = null;
                val_10 = null;
                SG.ResourceManager.mInstance = null;
                if(UnityEngine.Application.isPlaying != false)
            {
                    val_11 = null;
                val_11 = null;
                UnityEngine.GameObject val_8 = gameObject;
                UnityEngine.Object.DontDestroyOnLoad(target:  157720576);
            }
            else
            {
                    UnityEngine.Debug.LogWarning(message:  1184522528);
            }
            
            }
            
            val_12 = null;
            val_12 = null;
        }
        public void InitPool(UnityEngine.GameObject poolPrefab, int size, SG.PoolInflationType type = 1)
        {
            if(poolPrefab == 0)
            {
                    UnityEngine.Debug.LogError(message:  1184642928);
                return;
            }
            
            string val_2 = poolPrefab.name;
            if((this.poolDict.ContainsKey(key:  poolPrefab)) != false)
            {
                    return;
            }
            
            UnityEngine.GameObject val_4 = this.gameObject;
            SG.Pool val_5 = new SG.Pool(poolName:  poolPrefab, poolObjectPrefab:  poolPrefab, rootPoolObj:  1184677328, initialCount:  size, type:  type);
            this.poolDict.set_Item(key:  poolPrefab, value:  461021184);
        }
        public UnityEngine.GameObject GetObjectFromPool(UnityEngine.GameObject poolPrefab, bool autoActive = True, int autoCreate = 0)
        {
            string val_1 = poolPrefab.name;
            if((autoCreate >= 1) && ((this.poolDict.ContainsKey(key:  poolPrefab)) != true))
            {
                    this.InitPool(poolPrefab:  poolPrefab, size:  autoCreate, type:  0);
            }
            
            if((this.poolDict.ContainsKey(key:  poolPrefab)) == false)
            {
                    return;
            }
            
            SG.Pool val_4 = this.poolDict.Item[poolPrefab];
            if(this.poolDict != 0)
            {
                    return this.poolDict.NextAvailableObject(autoActive:  autoActive);
            }
            
            return this.poolDict.NextAvailableObject(autoActive:  autoActive);
        }
        public void ReturnObjectToPool(UnityEngine.GameObject go)
        {
            var val_5;
            object val_1 = go.GetComponent<System.Object>();
            val_5 = 0;
            if(go == 0)
            {
                    return;
            }
            
            if((this.poolDict.TryGetValue(key:  null, value: out  SG.Pool val_3 = 1184948692)) == false)
            {
                    return;
            }
            
            val_5.ReturnObjectToPool(po:  go);
        }
        public void ReturnTransformToPool(UnityEngine.Transform t)
        {
            if(t == 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = t.gameObject;
            this.ReturnObjectToPool(go:  t);
        }
        public ResourceManager()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.poolDict = null;
        }
        private static ResourceManager()
        {
        
        }
    
    }

}
