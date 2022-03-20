using UnityEngine;

namespace AudienceNetwork
{
    internal sealed class FBAdViewBridgeErrorExternalCallback : MulticastDelegate
    {
        // Methods
        public FBAdViewBridgeErrorExternalCallback(object object, IntPtr method)
        {
            mem[1152921514488351656] = method;
            mem[1152921514488351664] = object;
            mem[1152921514488351668] = method;
        }
        public virtual void Invoke(int uniqueId, string error)
        {
            var val_3;
            var val_7;
            var val_8;
            int val_9;
            var val_10;
            var val_11;
            if(this != 0)
            {
                    if(R8 == 0)
            {
                    return;
            }
            
                val_8 = 1152921514488471856;
            }
            else
            {
                    val_7 = 1;
            }
            
            var val_12 = 0;
            goto label_28;
            label_21:
            if(1291678220 == 0)
            {
                goto label_4;
            }
            
            Spine.Animation val_1 = R6.Current;
            val_9 = uniqueId;
            if((R7 + 178) == 0)
            {
                goto label_5;
            }
            
            var val_6 = 0;
            label_7:
            if((R7 + 88 + 0) == R6)
            {
                goto label_6;
            }
            
            val_6 = val_6 + 1;
            if(((uint)val_6 & 65535) < (R7 + 178))
            {
                goto label_7;
            }
            
            label_5:
            val_10 = R7;
            val_9 = val_9;
            goto label_16;
            label_22:
            var val_7 = (0 + 1) + 40;
            val_7 = R7 + (val_7 << 3);
            goto label_16;
            label_4:
            var val_8 = R7;
            val_8 = val_8 + ((R6 + 40) << 3);
            goto label_16;
            label_24:
            var val_2 = R5 + (((R7 + (R6 + 40) << 3) + 192) << 3);
            var val_9 = (R5 + ((R7 + (R6 + 40) << 3) + 192) << 3) + 4;
            val_9 = val_9 + val_3;
            val_9 = (R6 + 40) + (val_9 << 3);
            val_9 = val_9 + 188;
            goto label_16;
            label_6:
            var val_4 = (R7 + 88) + 0;
            var val_10 = (R7 + 88 + 0) + 4;
            val_10 = val_10 + (R6 + 40);
            val_10 = R7 + (val_10 << 3);
            val_10 = val_10 + 188;
            goto label_16;
            label_28:
            val_11 = mem[1152921514488471860];
            if(val_11 == 0)
            {
                goto label_14;
            }
            
            if((mem[1152921514488471860] + 42) != 2)
            {
                goto label_27;
            }
            
            goto label_16;
            label_14:
            if(mem[1152921514488471856] == 0)
            {
                goto label_17;
            }
            
            if((((mem[1152921514488471860] + 40) == 65535) || ((mem[1152921514488471856] + 157) != 1)) || (mem[1152921514488471852] == 0))
            {
                goto label_27;
            }
            
            if(val_11 == 0)
            {
                goto label_21;
            }
            
            if(val_11 == 0)
            {
                goto label_22;
            }
            
            val_3 = mem[1152921514488471860] + 40;
            if((mem[1152921514488471856] + 178) == 0)
            {
                goto label_16;
            }
            
            var val_11 = 0;
            label_25:
            if((mem[1152921514488471856] + 88 + 0) == (mem[1152921514488471860] + 12))
            {
                goto label_24;
            }
            
            val_11 = val_11 + 1;
            if(((uint)val_11 & 65535) < (mem[1152921514488471856] + 178))
            {
                goto label_25;
            }
            
            goto label_16;
            label_17:
            Spine.Animation val_5 = val_11.Current;
            label_27:
            label_16:
            val_12 = val_12 + 1;
            if(val_12 != val_7)
            {
                goto label_28;
            }
        
        }
        public virtual System.IAsyncResult BeginInvoke(int uniqueId, string error, System.AsyncCallback callback, object object)
        {
        
        }
        public virtual void EndInvoke(System.IAsyncResult result)
        {
        
        }
    
    }

}
