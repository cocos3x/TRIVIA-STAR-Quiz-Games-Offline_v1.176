using UnityEngine;

namespace Spine
{
    public class Pool<T>
    {
        // Fields
        public readonly int max;
        private readonly System.Collections.Generic.Stack<T> freeObjects;
        private int <Peak>k__BackingField;
        
        // Properties
        public int Count { get; }
        public int Peak { get; set; }
        
        // Methods
        public int get_Count()
        {
            if(R4 == 0)
            {
                
            }
        
        }
        public int get_Peak()
        {
            return (int)this;
        }
        private void set_Peak(int value)
        {
            mem[1152921510783521264] = value;
        }
        public Pool<T>(int initialCapacity = 16, int max = 2147483647)
        {
            mem[1152921510783633256] = max;
            mem[1152921510783633260] = __RuntimeMethodHiddenParam + 12 + 96 + 4;
        }
        public T Obtain()
        {
            var val_3 = __RuntimeMethodHiddenParam;
            if(R6 != 0)
            {
                    if(this == 0)
            {
                
            }
            
            }
        
        }
        public void Free(T obj)
        {
            var val_3;
            var val_4;
            val_3 = 35665965;
            if(obj != 0)
            {
                    if(val_3 >= (__RuntimeMethodHiddenParam + 12 + 96))
            {
                goto __RuntimeMethodHiddenParam + 12 + 96 + 36;
            }
            
                val_4 = val_3;
                int val_1 = System.Math.Max(val1:  1882048288, val2:  35665965);
            }
            else
            {
                    System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  1882023072, message:  1882023152);
            }
        
        }
        public void Clear()
        {
            if(R4 == 0)
            {
                
            }
        
        }
        protected void Reset(T obj)
        {
            var val_1;
            var val_2;
            val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 44];
            val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 44;
            if(obj == 0)
            {
                    return;
            }
            
            var val_1 = 0;
            val_1 = 0;
            val_1 = val_1 + 1;
            val_1 = (uint)val_1 & 65535;
            val_2 = obj;
            goto mem[(1152921504626761728 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
    
    }

}
