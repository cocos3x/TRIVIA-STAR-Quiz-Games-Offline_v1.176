using UnityEngine;

namespace LitJson
{
    public sealed class WrapperFactory : MulticastDelegate
    {
        // Methods
        public WrapperFactory(object object, IntPtr method)
        {
            mem[1152921510970363672] = method;
            mem[1152921510970363680] = object;
            mem[1152921510970363684] = method;
        }
        public virtual LitJson.IJsonWrapper Invoke()
        {
            LitJson.WrapperFactory val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            val_4 = this;
            if(this != 0)
            {
                    if(R8 == 0)
            {
                    return;
            }
            
                val_6 = 1152921510970479776;
            }
            else
            {
                    val_5 = 1;
            }
            
            var val_9 = 0;
            goto label_26;
            label_25:
            if(((R5 + 157) != 1) || ((R5 + 157) == 0))
            {
                goto label_23;
            }
            
            if(R6 == 0)
            {
                goto label_6;
            }
            
            if(R6 == 0)
            {
                goto label_7;
            }
            
            if((R5 + 178) == 0)
            {
                goto label_8;
            }
            
            var val_4 = 0;
            label_10:
            if((R5 + 88 + 0) == (R6 + 12))
            {
                goto label_9;
            }
            
            val_4 = val_4 + 1;
            if(((uint)val_4 & 65535) < (R5 + 178))
            {
                goto label_10;
            }
            
            label_8:
            val_7 = R5;
            goto label_11;
            label_6:
            if(R6 == 0)
            {
                goto label_12;
            }
            
            Spine.Animation val_1 = R6.Current;
            if((R5 + 178) == 0)
            {
                goto label_13;
            }
            
            val_8 = 0;
            label_15:
            if((R5 + 88 + 0) == R6)
            {
                goto label_14;
            }
            
            val_8 = val_8 + 1;
            if(((uint)val_8 & 65535) < (R5 + 178))
            {
                goto label_15;
            }
            
            label_13:
            val_9 = R5;
            goto label_16;
            label_7:
            var val_5 = R6 + 40;
            val_5 = R5 + (val_5 << 3);
            val_10 = mem[(R5 + (R6 + 40) << 3) + 192];
            val_10 = (R5 + (R6 + 40) << 3) + 192;
            goto label_19;
            label_12:
            var val_6 = R5;
            val_6 = val_6 + ((R6 + 40) << 3);
            goto label_19;
            label_9:
            var val_2 = (R5 + 88) + 0;
            var val_7 = (R5 + 88 + 0) + 4;
            val_7 = val_7 + (R6 + 40);
            val_7 = R5 + (val_7 << 3);
            val_7 = val_7 + 188;
            label_11:
            val_10 = mem[((R5 + (((R5 + 88 + 0) + 4 + R6 + 40)) << 3) + 188) + 4];
            val_10 = ((R5 + (((R5 + 88 + 0) + 4 + R6 + 40)) << 3) + 188) + 4;
            goto label_19;
            label_14:
            var val_3 = (R5 + 88) + 0;
            var val_8 = (R5 + 88 + 0) + 4;
            val_8 = val_8 + (R6 + 40);
            val_8 = R5 + (val_8 << 3);
            val_9 = val_8 + 188;
            label_16:
            label_19:
            val_4 = val_4;
            goto label_24;
            label_26:
            val_8 = mem[1152921510970479780];
            if(val_8 == 0)
            {
                goto label_22;
            }
            
            if((mem[1152921510970479780] + 42) != 0)
            {
                goto label_23;
            }
            
            goto label_24;
            label_22:
            if(mem[1152921510970479776] != 0)
            {
                    val_8 = mem[mem[1152921510970479780] + 40];
                val_8 = mem[1152921510970479780] + 40;
            }
            
            if(val_8 != 65535)
            {
                goto label_25;
            }
            
            label_23:
            label_24:
            val_9 = val_9 + 1;
            if(val_9 != val_5)
            {
                goto label_26;
            }
        
        }
        public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object)
        {
        
        }
        public virtual LitJson.IJsonWrapper EndInvoke(System.IAsyncResult result)
        {
        
        }
    
    }

}
