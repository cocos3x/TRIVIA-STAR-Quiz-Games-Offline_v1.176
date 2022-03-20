using UnityEngine;

namespace SRF.Helpers
{
    public static class SRReflection
    {
        // Methods
        public static void SetPropertyValue(object obj, System.Reflection.PropertyInfo p, object value)
        {
            System.Reflection.MethodInfo val_1 = p.GetSetMethod();
            typeof(System.Object[]).__il2cppRuntimeField_10 = value;
            object val_2 = p.Invoke(obj:  obj, parameters:  472754880);
        }
        public static object GetPropertyValue(object obj, System.Reflection.PropertyInfo p)
        {
            System.Reflection.MethodInfo val_1 = p.GetGetMethod();
            if(p != 0)
            {
                    return p.Invoke(obj:  obj, parameters:  null);
            }
            
            return p.Invoke(obj:  obj, parameters:  null);
        }
        public static T GetAttribute<T>(System.Reflection.MemberInfo t)
        {
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24});
            System.Attribute val_2 = System.Attribute.GetCustomAttribute(element:  t, attributeType:  __RuntimeMethodHiddenParam + 24);
            if(t == 0)
            {
                    return;
            }
            
            if(t == 0)
            {
                    return;
            }
        
        }
    
    }

}
