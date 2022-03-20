using UnityEngine;

namespace SRF
{
    public static class SRFTransformExtensions
    {
        // Methods
        public static System.Collections.Generic.IEnumerable<UnityEngine.Transform> GetChildren(UnityEngine.Transform t)
        {
            object val_1 = new System.Object();
            typeof(SRFTransformExtensions.<GetChildren>d__0).__il2cppRuntimeField_8 = 1;
            typeof(SRFTransformExtensions.<GetChildren>d__0).__il2cppRuntimeField_10 = System.Environment.CurrentManagedThreadId;
            typeof(SRFTransformExtensions.<GetChildren>d__0).__il2cppRuntimeField_18 = t;
        }
        public static void ResetLocal(UnityEngine.Transform t)
        {
            float val_3;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            t.localPosition = new UnityEngine.Vector3();
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
            t.localRotation = new UnityEngine.Quaternion() {w = val_3};
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            t.localScale = new UnityEngine.Vector3();
        }
        public static UnityEngine.GameObject CreateChild(UnityEngine.Transform t, string name)
        {
            UnityEngine.Transform val_2 = transform;
            parent = t;
            if((new UnityEngine.GameObject(name:  name)) != 0)
            {
                    UnityEngine.Transform val_3 = transform;
                SRF.SRFTransformExtensions.ResetLocal(t:  157720576);
            }
            else
            {
                    UnityEngine.Transform val_4 = transform;
                SRF.SRFTransformExtensions.ResetLocal(t:  157720576);
            }
            
            UnityEngine.GameObject val_5 = gameObject;
            UnityEngine.GameObject val_6 = t.gameObject;
            layer = t.layer;
        }
        public static void SetParentMaintainLocals(UnityEngine.Transform t, UnityEngine.Transform parent)
        {
            t.SetParent(parent:  parent, worldPositionStays:  false);
        }
        public static void SetLocals(UnityEngine.Transform t, UnityEngine.Transform from)
        {
            float val_3;
            UnityEngine.Vector3 val_1 = localPosition;
            t.localPosition = new UnityEngine.Vector3();
            UnityEngine.Quaternion val_2 = localRotation;
            t.localRotation = new UnityEngine.Quaternion() {w = val_3};
            UnityEngine.Vector3 val_4 = localScale;
            t.localScale = new UnityEngine.Vector3();
        }
        public static void Match(UnityEngine.Transform t, UnityEngine.Transform from)
        {
            float val_3;
            UnityEngine.Vector3 val_1 = position;
            t.position = new UnityEngine.Vector3();
            UnityEngine.Quaternion val_2 = rotation;
            t.rotation = new UnityEngine.Quaternion() {w = val_3};
        }
        public static void DestroyChildren(UnityEngine.Transform t)
        {
            float val_8;
            float val_9;
            var val_10;
            var val_11;
            var val_12;
            UnityEngine.Object val_13;
            var val_14;
            var val_15;
            var val_16;
            System.Collections.IEnumerator val_1 = t.GetEnumerator();
            val_8 = 1152921504683417600;
            val_9 = 1152921504765685760;
            label_23:
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_10 = (uint)val_7 & 65535;
            val_11 = t;
            if(t == 0)
            {
                goto label_7;
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_12 = t;
            if(t != 0)
            {
                    val_13 = 0;
            }
            else
            {
                    val_13 = 0;
            }
            
            UnityEngine.GameObject val_4 = gameObject;
            UnityEngine.Object.Destroy(obj:  null);
            goto label_23;
            label_7:
            val_14 = 0;
            val_15 = 1152921504619679744;
            if(t != 0)
            {
                    val_10 = 0;
                val_15 = 0;
                val_10 = val_10 + 1;
                val_15 = (uint)val_10 & 65535;
                val_16 = t;
            }
            
            var val_6 = FP - 28;
        }
    
    }

}
