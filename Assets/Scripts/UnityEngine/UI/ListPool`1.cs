using UnityEngine;

namespace UnityEngine.UI
{
    internal static class ListPool<T>
    {
        // Fields
        private static readonly UnityEngine.UI.ObjectPool<System.Collections.Generic.List<T>> s_ListPool;
        
        // Methods
        public static System.Collections.Generic.List<T> Get()
        {
            var val_1;
            var val_2;
            var val_3;
            var val_4;
            val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            if(val_1 == 1)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
                val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            }
            
            val_2 = mem[__RuntimeMethodHiddenParam + 12 + 186];
            val_2 = __RuntimeMethodHiddenParam + 12 + 186;
            val_3 = __RuntimeMethodHiddenParam + 12;
            if(val_2 == 1)
            {
                    val_3 = mem[__RuntimeMethodHiddenParam + 12];
                val_3 = __RuntimeMethodHiddenParam + 12;
                val_2 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_2 = __RuntimeMethodHiddenParam + 12 + 186;
            }
            
            val_4 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 4];
            val_4 = __RuntimeMethodHiddenParam + 12 + 96 + 4;
            if(val_2 == 1)
            {
                    val_4 = val_4;
            }
        
        }
        public static void Release(System.Collections.Generic.List<T> toRelease)
        {
            var val_1;
            var val_2;
            var val_3;
            var val_4;
            val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
            val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            if(val_1 == 1)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 186];
                val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 186;
            }
            
            val_2 = mem[__RuntimeMethodHiddenParam + 12 + 186];
            val_2 = __RuntimeMethodHiddenParam + 12 + 186;
            val_3 = __RuntimeMethodHiddenParam + 12;
            if(val_2 == 1)
            {
                    val_3 = mem[__RuntimeMethodHiddenParam + 12];
                val_3 = __RuntimeMethodHiddenParam + 12;
                val_2 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_2 = __RuntimeMethodHiddenParam + 12 + 186;
            }
            
            val_4 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 8];
            val_4 = __RuntimeMethodHiddenParam + 12 + 96 + 8;
            if(val_2 == 1)
            {
                    val_4 = val_4;
            }
        
        }
        private static ListPool<T>()
        {
            var val_1;
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 12 + 186];
            val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 12 + 186;
            if(val_1 == 1)
            {
                    val_1 = mem[__RuntimeMethodHiddenParam + 12 + 96 + 12 + 186];
                val_1 = __RuntimeMethodHiddenParam + 12 + 96 + 12 + 186;
            }
            
            val_2 = mem[__RuntimeMethodHiddenParam + 12 + 186];
            val_2 = __RuntimeMethodHiddenParam + 12 + 186;
            val_3 = __RuntimeMethodHiddenParam + 12;
            if(val_2 == 1)
            {
                    val_3 = mem[__RuntimeMethodHiddenParam + 12];
                val_3 = __RuntimeMethodHiddenParam + 12;
                val_2 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_2 = __RuntimeMethodHiddenParam + 12 + 186;
            }
            
            val_4 = val_3;
            if(val_2 == 1)
            {
                    val_4 = mem[__RuntimeMethodHiddenParam + 12];
                val_4 = __RuntimeMethodHiddenParam + 12;
                val_2 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_2 = __RuntimeMethodHiddenParam + 12 + 186;
            }
            
            val_5 = mem[__RuntimeMethodHiddenParam + 12 + 186];
            val_5 = __RuntimeMethodHiddenParam + 12 + 186;
            val_6 = __RuntimeMethodHiddenParam + 12;
            if(val_5 == 1)
            {
                    val_6 = mem[__RuntimeMethodHiddenParam + 12];
                val_6 = __RuntimeMethodHiddenParam + 12;
                val_5 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_5 = __RuntimeMethodHiddenParam + 12 + 186;
            }
            
            mem2[0] = __RuntimeMethodHiddenParam + 12 + 96 + 28;
        }
    
    }

}
