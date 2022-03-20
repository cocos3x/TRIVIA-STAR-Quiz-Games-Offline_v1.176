using UnityEngine;

namespace SRF.Components
{
    public abstract class SRAutoSingleton<T> : SRMonoBehaviour
    {
        // Fields
        private static T _instance;
        
        // Properties
        public static T Instance { get; }
        public static bool HasInstance { get; }
        
        // Methods
        public static T get_Instance()
        {
            var val_6;
            var val_7;
            if(((__RuntimeMethodHiddenParam + 12 + 96 + 92) == 0) && (UnityEngine.Application.isPlaying != false))
            {
                    System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96 + 8});
                string val_4 = 2144339952 + __RuntimeMethodHiddenParam + 12 + 96 + 8(__RuntimeMethodHiddenParam + 12 + 96 + 8);
                UnityEngine.GameObject val_5 = new UnityEngine.GameObject(name:  2144339952);
                val_6 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_6 = __RuntimeMethodHiddenParam + 12 + 186;
                val_7 = __RuntimeMethodHiddenParam + 12;
                if(val_6 == 1)
            {
                    val_7 = mem[__RuntimeMethodHiddenParam + 12];
                val_7 = __RuntimeMethodHiddenParam + 12;
                val_6 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_6 = __RuntimeMethodHiddenParam + 12 + 186;
            }
            
            }
            
            if((__RuntimeMethodHiddenParam + 12 + 96 + 186) != 1)
            {
                    return;
            }
        
        }
        public static bool get_HasInstance()
        {
            return UnityEngine.Object.op_Inequality(x:  __RuntimeMethodHiddenParam + 12 + 96 + 92, y:  0);
        }
        protected virtual void Awake()
        {
            var val_4;
            var val_5;
            if((__RuntimeMethodHiddenParam + 12 + 96 + 92) != 0)
            {
                    System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 12 + 96 + 8});
                typeof(System.Object[]).__il2cppRuntimeField_10 = __RuntimeMethodHiddenParam + 12 + 96 + 8;
                string val_3 = SRF.SRFStringExtensions.Fmt(formatString:  409118528, args:  472754880);
                UnityEngine.Debug.LogWarning(message:  409118528);
                return;
            }
            
            val_4 = mem[__RuntimeMethodHiddenParam + 12 + 96];
            val_4 = __RuntimeMethodHiddenParam + 12 + 96;
            if((__RuntimeMethodHiddenParam + 12 + 96 + 186) == 1)
            {
                    val_4 = mem[__RuntimeMethodHiddenParam + 12 + 96];
                val_4 = __RuntimeMethodHiddenParam + 12 + 96;
            }
            
            val_5 = 0;
            if(this != 0)
            {
                    val_5 = this;
                if(val_5 == 0)
            {
                    val_5 = 0;
            }
            
            }
            
            mem2[0] = val_5;
        }
        private void OnApplicationQuit()
        {
            mem2[0] = 0;
        }
        protected SRAutoSingleton<T>()
        {
            if(this != 0)
            {
                    return;
            }
        
        }
    
    }

}
