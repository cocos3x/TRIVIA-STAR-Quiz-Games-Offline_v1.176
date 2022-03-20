using UnityEngine;

namespace SRF.Helpers
{
    public class MethodReference
    {
        // Fields
        private System.Reflection.MethodInfo _method;
        private object _target;
        
        // Properties
        public string MethodName { get; }
        
        // Methods
        public MethodReference(object target, System.Reflection.MethodInfo method)
        {
            object val_1 = target;
            val_1 = new System.Object();
            SRDebugUtil.AssertNotNull(value:  val_1, message:  null, instance:  0);
            this._method = method;
            this._target = val_1;
        }
        public string get_MethodName()
        {
            if(this._method == 0)
            {
                
            }
        
        }
        public object Invoke(object[] parameters)
        {
            if(this._method != 0)
            {
                    return this._method.Invoke(obj:  this._target, parameters:  parameters);
            }
            
            return this._method.Invoke(obj:  this._target, parameters:  parameters);
        }
    
    }

}
