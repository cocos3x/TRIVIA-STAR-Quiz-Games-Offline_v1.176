using UnityEngine;

namespace SRF
{
    public static class SRFIListExtensions
    {
        // Methods
        public static T Random<T>(System.Collections.Generic.IList<T> list)
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            val_10 = list;
            val_11 = __RuntimeMethodHiddenParam;
            val_12 = 0;
            val_12 = val_12 + 1;
            val_14 = val_10;
            if(val_10 == 0)
            {
                goto label_7;
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_13 = (uint)val_8 & 65535;
            val_15 = val_10;
            val_16 = val_10;
            if(val_16 != 1)
            {
                goto label_15;
            }
            
            var val_9 = 0;
            val_17 = 0;
            val_9 = val_9 + 1;
            val_17 = (uint)val_9 & 65535;
            val_18 = val_10;
            goto label_20;
            label_15:
            val_19 = mem[__RuntimeMethodHiddenParam + 24];
            val_19 = __RuntimeMethodHiddenParam + 24;
            var val_10 = 0;
            val_22 = 0;
            val_10 = val_10 + 1;
            val_23 = (uint)val_10 & 65535;
            val_24 = val_10;
            goto label_25;
            label_20:
            val_21 = mem[(1152921504687464448 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3) + 4];
            val_20 = val_10;
            goto mem[(1152921504687464448 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
            label_25:
            int val_5 = UnityEngine.Random.Range(min:  0, max:  R4);
            var val_12 = R4;
            if((R4 + 178) == 0)
            {
                goto label_28;
            }
            
            var val_11 = 0;
            label_30:
            val_23 = 0;
            val_19 = mem[R4 + 88 + 0];
            val_19 = R4 + 88 + 0;
            if(val_19 == (R8 + 24 + 4))
            {
                goto label_29;
            }
            
            val_11 = val_11 + 1;
            val_23 = (uint)val_11 & 65535;
            if(val_23 < (R4 + 178))
            {
                goto label_30;
            }
            
            label_28:
            val_25 = R4;
            goto label_31;
            label_29:
            var val_6 = (R4 + 88) + 0;
            val_12 = val_12 + (((R4 + 88 + 0) + 4) << 3);
            val_25 = val_12 + 188;
            label_31:
            val_12 = mem[((R4 + ((R4 + 88 + 0) + 4) << 3) + 188)];
            val_12 = val_25;
            goto ((R4 + ((R4 + 88 + 0) + 4) << 3) + 188);
            label_7:
            System.IndexOutOfRangeException val_7 = new System.IndexOutOfRangeException(message:  372872064);
        }
        public static T RandomOrDefault<T>(System.Collections.Generic.IList<T> list)
        {
            var val_3;
            var val_4;
            var val_6;
            val_3 = __RuntimeMethodHiddenParam;
            val_4 = mem[__RuntimeMethodHiddenParam + 24];
            val_4 = __RuntimeMethodHiddenParam + 24;
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_6 = list;
            if(list == 0)
            {
                    return;
            }
            
            goto __RuntimeMethodHiddenParam + 24 + 4;
        }
        public static T PopLast<T>(System.Collections.Generic.IList<T> list)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_9 = list;
            if(list != 0)
            {
                    var val_10 = 0;
                val_10 = val_10 + 1;
                val_10 = list;
                System.Collections.Generic.IList<T> val_3 = list - 1;
                var val_11 = 0;
                val_11 = val_11 + 1;
                val_11 = list;
                var val_12 = 0;
                val_12 = val_12 + 1;
                val_12 = list;
                val_13 = list;
                System.Collections.Generic.IList<T> val_6 = val_13 - 1;
                var val_13 = 0;
                val_13 = 0;
                val_13 = val_13 + 1;
                val_13 = (uint)val_13 & 65535;
                val_14 = list;
                return;
            }
            
            System.InvalidOperationException val_8 = new System.InvalidOperationException();
        }
    
    }

}
