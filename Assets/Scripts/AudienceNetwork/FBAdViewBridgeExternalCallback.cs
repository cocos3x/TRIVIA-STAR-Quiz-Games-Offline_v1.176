using UnityEngine;

namespace AudienceNetwork
{
    internal sealed class FBAdViewBridgeExternalCallback : MulticastDelegate
    {
        // Methods
        public FBAdViewBridgeExternalCallback(object object, IntPtr method)
        {
            mem[1152921514487870888] = method;
            mem[1152921514487870896] = object;
            mem[1152921514487870900] = method;
        }
        public virtual void Invoke(int uniqueId)
        {
            int val_3;
            AudienceNetwork.FBAdViewBridgeExternalCallback val_7;
            var val_8;
            var val_9;
            int val_10;
            var val_11;
            var val_12;
            val_7 = this;
            if(this != 0)
            {
                    if(R4 == 0)
            {
                    return;
            }
            
                val_9 = 1152921514487986992;
            }
            else
            {
                    val_8 = 1;
            }
            
            var val_12 = 0;
            goto label_28;
            label_21:
            if(1291193356 == 0)
            {
                goto label_4;
            }
            
            Spine.Animation val_1 = R7.Current;
            val_10 = uniqueId;
            if((R6 + 178) == 0)
            {
                goto label_5;
            }
            
            var val_6 = 0;
            label_7:
            val_11 = 0;
            if((R6 + 88 + 0) == R7)
            {
                goto label_6;
            }
            
            val_6 = val_6 + 1;
            val_11 = (uint)val_6 & 65535;
            if(val_11 < (R6 + 178))
            {
                goto label_7;
            }
            
            label_5:
            val_12 = R6;
            val_10 = val_10;
            goto label_8;
            label_22:
            var val_7 = (uint)(ushort)(((0 + 1)) & 0xFFFF) + 40;
            val_7 = R6 + (val_7 << 3);
            goto label_11;
            label_4:
            var val_8 = R6;
            val_8 = val_8 + ((R7 + 40) << 3);
            goto label_10;
            label_24:
            var val_2 = R5 + (((R6 + (R7 + 40) << 3) + 188) << 3);
            var val_9 = (R5 + ((R6 + (R7 + 40) << 3) + 188) << 3) + 4;
            val_9 = val_9 + ((R6 + (R7 + 40) << 3) + 192);
            val_9 = IP + (val_9 << 3);
            val_9 = val_9 + 188;
            goto label_11;
            label_6:
            var val_4 = (R6 + 88) + 0;
            var val_10 = (R6 + 88 + 0) + 4;
            val_10 = val_10 + (R7 + 40);
            val_10 = R6 + (val_10 << 3);
            val_12 = val_10 + 188;
            label_8:
            label_10:
            label_11:
            val_7 = val_7;
            goto label_16;
            label_28:
            val_11 = mem[1152921514487986996];
            if(val_11 == 0)
            {
                goto label_14;
            }
            
            if((mem[1152921514487986996] + 42) != 1)
            {
                goto label_27;
            }
            
            goto label_16;
            label_14:
            if(mem[1152921514487986992] == 0)
            {
                goto label_17;
            }
            
            if((((mem[1152921514487986996] + 40) == 65535) || ((mem[1152921514487986992] + 157) != 1)) || ((mem[1152921514487986992] + 157) == 0))
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
            
            val_3 = uniqueId;
            if((mem[1152921514487986992] + 178) == 0)
            {
                goto label_11;
            }
            
            var val_11 = 0;
            label_25:
            if((mem[1152921514487986992] + 88 + 0) == (mem[1152921514487986996] + 12))
            {
                goto label_24;
            }
            
            val_11 = val_11 + 1;
            if(((uint)val_11 & 65535) < (mem[1152921514487986992] + 178))
            {
                goto label_25;
            }
            
            goto label_11;
            label_17:
            Spine.Animation val_5 = val_11.Current;
            label_27:
            label_16:
            val_12 = val_12 + 1;
            if(val_12 != val_8)
            {
                goto label_28;
            }
        
        }
        public virtual System.IAsyncResult BeginInvoke(int uniqueId, System.AsyncCallback callback, object object)
        {
        
        }
        public virtual void EndInvoke(System.IAsyncResult result)
        {
        
        }
    
    }

}
