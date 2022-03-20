using UnityEngine;

namespace SRF
{
    public abstract class SRMonoBehaviourEx : SRMonoBehaviour
    {
        // Fields
        private static System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.IList<SRF.SRMonoBehaviourEx.FieldInfo>> _checkedFields;
        
        // Methods
        private static void CheckFields(SRF.SRMonoBehaviourEx instance, bool justSet = False)
        {
            System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.IList<FieldInfo>> val_7;
            if(SRF.SRMonoBehaviourEx._checkedFields == 0)
            {
                    System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
                SRF.SRMonoBehaviourEx._checkedFields = null;
            }
            
            System.Type val_2 = instance.GetType();
            val_7 = SRF.SRMonoBehaviourEx._checkedFields;
            System.Type val_3 = instance.GetType();
            if((TryGetValue(key:  instance, value: out  UnityEngine.Material val_4 = 369523036)) != true)
            {
                    System.Collections.Generic.List<FieldInfo> val_6 = SRF.SRMonoBehaviourEx.ScanType(t:  instance);
                val_7 = instance;
                Add(key:  instance, value:  val_7);
            }
            
            SRF.SRMonoBehaviourEx.PopulateObject(cache:  val_7, instance:  instance, justSet:  justSet);
        }
        private static void PopulateObject(System.Collections.Generic.IList<SRF.SRMonoBehaviourEx.FieldInfo> cache, SRF.SRMonoBehaviourEx instance, bool justSet)
        {
            var val_2;
            System.Type val_3;
            var val_4;
            var val_5;
            var val_16;
            var val_17;
            System.Type val_18;
            var val_19;
            var val_20;
            var val_21;
            SRF.SRMonoBehaviourEx val_22;
            object val_23;
            var val_24;
            val_16 = 0;
            goto label_1;
            label_37:
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_17 = cache;
            val_18 = val_4;
            System.Collections.Generic.EqualityComparer<T> val_6 = System.Collections.Generic.EqualityComparer<System.Object>.Default;
            val_19 = public static System.Collections.Generic.EqualityComparer<T> System.Collections.Generic.EqualityComparer<System.Object>::get_Default();
            if(val_19 == 0)
            {
                goto label_31;
            }
            
            if(val_5 == false)
            {
                goto label_10;
            }
            
            if(val_18 == 0)
            {
                    val_18 = val_3;
            }
            
            object val_7 = SRF.Service.SRServiceManager.GetService(t:  val_18);
            if(val_18 == 0)
            {
                goto label_14;
            }
            
            val_22 = instance;
            val_23 = val_18;
            goto label_15;
            label_10:
            if((val_2 & 65280) != 0)
            {
                goto label_16;
            }
            
            UnityEngine.Component val_8 = instance.GetComponent(type:  val_3);
            System.Collections.Generic.EqualityComparer<T> val_9 = System.Collections.Generic.EqualityComparer<System.Object>.Default;
            val_19 = public static System.Collections.Generic.EqualityComparer<T> System.Collections.Generic.EqualityComparer<System.Object>::get_Default();
            if(val_19 == 0)
            {
                goto label_19;
            }
            
            label_16:
            if(justSet == true)
            {
                goto label_31;
            }
            
            goto label_21;
            label_14:
            typeof(System.Object[]).__il2cppRuntimeField_10 = val_3;
            typeof(System.Object[]).__il2cppRuntimeField_14 = val_18;
            string val_10 = System.String.Format(format:  369635360, args:  472754880);
            UnityEngine.Debug.LogWarning(message:  369635360);
            goto label_31;
            label_19:
            val_22 = instance;
            val_23 = instance;
            label_15:
            val_3.SetValue(obj:  val_22, value:  val_23);
            label_31:
            val_16 = val_16 + 1;
            label_1:
            val_19 = 0;
            val_19 = val_19 + 1;
            val_21 = (uint)val_19 & 65535;
            val_24 = cache;
            if(val_16 < cache)
            {
                goto label_37;
            }
            
            return;
            label_21:
            if((val_2 & 255) == 0)
            {
                    UnityEngine.GameObject val_12 = instance.CachedGameObject;
                UnityEngine.Component val_13 = instance.AddComponent(componentType:  val_3);
                val_20 = 0;
                val_3.SetValue(obj:  instance, value:  instance);
            }
            
            string val_14 = SRF.SRFStringExtensions.Fmt(formatString:  369635504, args:  472754880);
            UnityEngine.UnassignedReferenceException val_15 = new UnityEngine.UnassignedReferenceException(message:  369635504);
        }
        private static System.Collections.Generic.List<SRF.SRMonoBehaviourEx.FieldInfo> ScanType(System.Type t)
        {
            System.Reflection.MemberInfo val_5;
            System.Collections.Generic.List<FieldInfo> val_6;
            System.Type val_7;
            System.Type val_8;
            var val_9;
            System.Type val_10;
            var val_11;
            var val_12;
            var val_13;
            val_5 = t;
            val_6 = null;
            val_6 = new System.Collections.Generic.List<FieldInfo>();
            object val_2 = SRF.Helpers.SRReflection.GetAttribute<System.Object>(t:  val_5);
            val_7 = val_5;
            System.Type val_6 = val_5;
            val_8 = val_6;
            val_6 = val_6 + 16;
            val_9 = 0;
            goto label_2;
            label_15:
            val_5 = mem[(t + 16) + 0];
            val_5 = (t + 16) + 0;
            object val_3 = SRF.Helpers.SRReflection.GetAttribute<System.Object>(t:  val_5);
            object val_4 = SRF.Helpers.SRReflection.GetAttribute<System.Object>(t:  val_5);
            if(val_5 == 0)
            {
                goto label_4;
            }
            
            label_8:
            if(val_5 == 0)
            {
                goto label_5;
            }
            
            val_10 = mem[(t + 16) + 0 + 8];
            val_10 = (t + 16) + 0 + 8;
            val_11 = 1;
            val_12 = 0;
            val_13 = 0;
            goto label_6;
            label_4:
            if(val_5 == 0)
            {
                goto label_7;
            }
            
            goto label_8;
            label_5:
            if(val_5 != 0)
            {
                    if(((t + 16) + 0 + 8) != 0)
            {
                    val_13 = 1;
            }
            
                if(((t + 16) + 0 + 9) != 0)
            {
                    val_12 = 1;
            }
            
            }
            else
            {
                    if(val_7 != 0)
            {
                
            }
            
                if(1152921513566543616 != 0)
            {
                    val_12 = 1;
            }
            
                if(t._impl != 0)
            {
                    val_13 = 1;
            }
            
            }
            
            val_11 = 0;
            val_10 = 0;
            label_6:
            Add(item:  new FieldInfo() {AutoCreate = 1 | 256, AutoSet = 1 | 256, Field = val_5, Import = false, ImportType = val_10});
            val_6 = val_6;
            val_7 = val_7;
            val_8 = val_8;
            label_7:
            val_9 = 1;
            label_2:
            if(val_9 < (t + 12))
            {
                goto label_15;
            }
        
        }
        protected virtual void Awake()
        {
            SRF.SRMonoBehaviourEx.CheckFields(instance:  369905216, justSet:  false);
        }
        protected virtual void Start()
        {
        
        }
        protected virtual void Update()
        {
        
        }
        protected virtual void FixedUpdate()
        {
        
        }
        protected virtual void OnEnable()
        {
        
        }
        protected virtual void OnDisable()
        {
        
        }
        protected virtual void OnDestroy()
        {
        
        }
        protected SRMonoBehaviourEx()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
