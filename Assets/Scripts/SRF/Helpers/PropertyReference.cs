using UnityEngine;

namespace SRF.Helpers
{
    public class PropertyReference
    {
        // Fields
        private readonly System.Reflection.PropertyInfo _property;
        private readonly object _target;
        
        // Properties
        public string PropertyName { get; }
        public System.Type PropertyType { get; }
        public bool CanRead { get; }
        public bool CanWrite { get; }
        
        // Methods
        public PropertyReference(object target, System.Reflection.PropertyInfo property)
        {
            val_1 = new System.Object();
            SRDebugUtil.AssertNotNull(value:  target, message:  null, instance:  0);
            this._property = val_1;
            this._target = target;
        }
        public string get_PropertyName()
        {
            if(this._property == 0)
            {
                
            }
        
        }
        public System.Type get_PropertyType()
        {
            if(this._property == 0)
            {
                
            }
        
        }
        public bool get_CanRead()
        {
            System.Reflection.MethodInfo val_1 = this._property.GetGetMethod();
            return System.Reflection.MethodInfo.op_Inequality(left:  this._property, right:  0);
        }
        public bool get_CanWrite()
        {
            System.Reflection.MethodInfo val_1 = this._property.GetSetMethod();
            return System.Reflection.MethodInfo.op_Inequality(left:  this._property, right:  0);
        }
        public object GetValue()
        {
            if(this._property == 0)
            {
                    return;
            }
            
            return SRF.Helpers.SRReflection.GetPropertyValue(obj:  this._target, p:  this._property);
        }
        public void SetValue(object value)
        {
            if(this._property != 0)
            {
                    SRF.Helpers.SRReflection.SetPropertyValue(obj:  this._target, p:  this._property, value:  value);
                return;
            }
            
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  408258624);
        }
        public T GetAttribute<T>()
        {
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24});
            object val_2 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  this._property);
            if(this._property == 0)
            {
                    return;
            }
            
            if(this._property == 0)
            {
                    return;
            }
        
        }
    
    }

}
