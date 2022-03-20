using UnityEngine;

namespace SRF.Components
{
    public abstract class SRSingleton<T> : SRMonoBehaviour
    {
        // Fields
        private static T _instance;
        
        // Properties
        public static T Instance { get; }
        public static bool HasInstance { get; }
        
        // Methods
        public static T get_Instance()
        {
            if((__RuntimeMethodHiddenParam + 12 + 96 + 92) != 0)
            {
                    if((__RuntimeMethodHiddenParam + 12 + 96 + 186) != 1)
            {
                    return;
            }
            
                return;
            }
            
            System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96 + 8});
            string val_3 = SRF.SRFStringExtensions.Fmt(formatString:  409454704, args:  472754880);
            System.InvalidOperationException val_4 = new System.InvalidOperationException(message:  409454704);
        }
        public static bool get_HasInstance()
        {
            return UnityEngine.Object.op_Inequality(x:  __RuntimeMethodHiddenParam + 12 + 96 + 92, y:  0);
        }
        private void Register()
        {
            var val_6;
            var val_7;
            var val_8;
            val_6 = this;
            if((__RuntimeMethodHiddenParam + 12 + 96 + 92) != 0)
            {
                    System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96 + 8});
                typeof(System.Object[]).__il2cppRuntimeField_10 = __RuntimeMethodHiddenParam + 12 + 96 + 8;
                string val_3 = SRF.SRFStringExtensions.Fmt(formatString:  409118528, args:  472754880);
                UnityEngine.Debug.LogWarning(message:  409118528);
                T[] val_4 = this.GetComponents<System.Object>();
                if(val_6 == 2)
            {
                    UnityEngine.GameObject val_5 = val_6.gameObject;
                val_6 = val_6;
            }
            
                UnityEngine.Object.Destroy(obj:  409704896);
                return;
            }
            
            val_7 = mem[__RuntimeMethodHiddenParam + 12 + 96];
            val_7 = __RuntimeMethodHiddenParam + 12 + 96;
            if((__RuntimeMethodHiddenParam + 12 + 96 + 186) == 1)
            {
                    val_7 = mem[__RuntimeMethodHiddenParam + 12 + 96];
                val_7 = __RuntimeMethodHiddenParam + 12 + 96;
            }
            
            val_8 = 0;
            if(val_6 != 0)
            {
                    val_8 = val_6;
                if(val_8 == 0)
            {
                    val_8 = 0;
            }
            
            }
            
            mem2[0] = val_8;
        }
        protected virtual void Awake()
        {
            if(this == 0)
            {
                
            }
        
        }
        protected virtual void OnEnable()
        {
            mem[__RuntimeMethodHiddenParam + 12 + 96 + 92] = __RuntimeMethodHiddenParam + 12 + 96 + 92;
            if((mem[__RuntimeMethodHiddenParam + 12 + 96 + 92]) != 0)
            {
                    return;
            }
            
            if(this == 0)
            {
                
            }
        
        }
        private void OnApplicationQuit()
        {
            mem2[0] = 0;
        }
        protected SRSingleton<T>()
        {
            if(this != 0)
            {
                    return;
            }
        
        }
    
    }

}
