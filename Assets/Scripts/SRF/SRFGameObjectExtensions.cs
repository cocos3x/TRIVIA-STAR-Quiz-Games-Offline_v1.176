using UnityEngine;

namespace SRF
{
    public static class SRFGameObjectExtensions
    {
        // Methods
        public static T GetIComponent<T>(UnityEngine.GameObject t)
        {
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24});
            UnityEngine.Component val_2 = t.GetComponent(type:  __RuntimeMethodHiddenParam + 24);
            if(t == 0)
            {
                    return;
            }
            
            if(t == 0)
            {
                    return;
            }
        
        }
        public static T GetComponentOrAdd<T>(UnityEngine.GameObject obj)
        {
            if(obj != 0)
            {
                    return;
            }
            
            if(obj == 0)
            {
                
            }
        
        }
        public static void RemoveComponentIfExists<T>(UnityEngine.GameObject obj)
        {
            if(obj == 0)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  obj);
        }
        public static void RemoveComponentsIfExists<T>(UnityEngine.GameObject obj)
        {
            var val_2;
            UnityEngine.GameObject val_1 = obj + 16;
            val_2 = 0;
            goto label_2;
            label_7:
            UnityEngine.Object.Destroy(obj:  157720576);
            val_2 = 1;
            label_2:
            if(val_2 < 1152921504764567552)
            {
                goto label_7;
            }
        
        }
        public static bool EnableComponentIfExists<T>(UnityEngine.GameObject obj, bool enable = True)
        {
            if(obj == 0)
            {
                    return (bool)0;
            }
            
            obj.enabled = enable;
            0 = 1;
            return (bool)0;
        }
        public static void SetLayerRecursive(UnityEngine.GameObject o, int layer)
        {
            UnityEngine.Transform val_1 = o.transform;
            SRF.SRFGameObjectExtensions.SetLayerInternal(t:  o, layer:  layer);
        }
        private static void SetLayerInternal(UnityEngine.Transform t, int layer)
        {
            int val_8;
            float val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_8 = layer;
            UnityEngine.GameObject val_1 = t.gameObject;
            t.layer = val_8;
            System.Collections.IEnumerator val_2 = t.GetEnumerator();
            val_9 = 1152921504683417600;
            label_19:
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_10 = (uint)val_7 & 65535;
            val_11 = t;
            if(t == 0)
            {
                goto label_9;
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_12 = t;
            if(t == 0)
            {
                goto label_19;
            }
            
            goto label_19;
            label_9:
            val_13 = 0;
            val_14 = 1152921504619679744;
            if(t != 0)
            {
                    val_10 = 0;
                val_14 = 0;
                val_10 = val_10 + 1;
                val_14 = (uint)val_10 & 65535;
                val_15 = t;
            }
            
            var val_6 = FP - 28;
        }
    
    }

}
