using UnityEngine;

namespace SRDebugger.Services
{
    public sealed class PinEntryCompleteCallback : MulticastDelegate
    {
        // Methods
        public PinEntryCompleteCallback(object object, IntPtr method)
        {
            mem[1152921513662970008] = method;
            mem[1152921513662970016] = object;
            mem[1152921513662970020] = method;
        }
        public virtual void Invoke(bool validPinEntered)
        {
            var val_2;
            var val_5;
            var val_6;
            bool val_7;
            var val_8;
            var val_9;
            if(this != 0)
            {
                    if(R5 == 0)
            {
                    return;
            }
            
                val_6 = 1152921513663086112;
            }
            else
            {
                    val_5 = 1;
            }
            
            var val_11 = 0;
            goto label_28;
            label_21:
            if(466292479 == 0)
            {
                goto label_4;
            }
            
            Spine.Animation val_1 = R7.Current;
            val_7 = validPinEntered;
            if((R6 + 178) == 0)
            {
                goto label_5;
            }
            
            var val_5 = 0;
            label_7:
            val_8 = mem[R6 + 88 + 0];
            val_8 = R6 + 88 + 0;
            if(val_8 == R7)
            {
                goto label_6;
            }
            
            val_5 = val_5 + 1;
            if(((uint)val_5 & 65535) < (R6 + 178))
            {
                goto label_7;
            }
            
            label_5:
            val_9 = R6;
            val_7 = val_7;
            goto label_8;
            label_22:
            var val_6 = R6 + 88 + 0 + 40;
            val_6 = R6 + (val_6 << 3);
            if(val_7 == true)
            {
                    val_7 = 1;
            }
            
            goto label_16;
            label_4:
            var val_7 = R6;
            val_7 = val_7 + ((R7 + 40) << 3);
            goto label_16;
            label_24:
            val_7 = val_7 + (((R6 + (R7 + 40) << 3) + 188) << 3);
            var val_8 = ((R6 + (R7 + 40) << 3) + ((R6 + (R7 + 40) << 3) + 188) << 3) + 4;
            val_8 = val_8 + val_2;
            val_8 = ((R6 + (R7 + 40) << 3) + 192) + (val_8 << 3);
            val_8 = val_8 + 188;
            label_26:
            if((R7 + 40) != 0)
            {
                    R7 + 40 = 1;
            }
            
            goto label_16;
            label_6:
            var val_3 = (R6 + 88) + 0;
            var val_9 = (R6 + 88 + 0) + 4;
            val_9 = val_9 + (R7 + 40);
            val_9 = R6 + (val_9 << 3);
            val_9 = val_9 + 188;
            label_8:
            if(val_7 == true)
            {
                    val_7 = 1;
            }
            
            goto label_16;
            label_28:
            val_8 = mem[1152921513663086116];
            if(val_8 == 0)
            {
                goto label_14;
            }
            
            if((mem[1152921513663086116] + 42) != 1)
            {
                goto label_27;
            }
            
            goto label_16;
            label_14:
            if(mem[1152921513663086112] == 0)
            {
                goto label_17;
            }
            
            if((((mem[1152921513663086116] + 40) == 65535) || ((mem[1152921513663086112] + 157) != 1)) || (mem[1152921513663086108] == 0))
            {
                goto label_27;
            }
            
            if(val_8 == 0)
            {
                goto label_21;
            }
            
            if(val_8 == 0)
            {
                goto label_22;
            }
            
            val_2 = mem[1152921513663086116] + 40;
            if((mem[1152921513663086112] + 178) == 0)
            {
                goto label_26;
            }
            
            var val_10 = 0;
            label_25:
            if((mem[1152921513663086112] + 88 + 0) == (mem[1152921513663086116] + 12))
            {
                goto label_24;
            }
            
            val_10 = val_10 + 1;
            if(((uint)val_10 & 65535) < (mem[1152921513663086112] + 178))
            {
                goto label_25;
            }
            
            goto label_26;
            label_17:
            Spine.Animation val_4 = val_8.Current;
            label_27:
            label_16:
            val_11 = val_11 + 1;
            if(val_11 != val_5)
            {
                goto label_28;
            }
        
        }
        public virtual System.IAsyncResult BeginInvoke(bool validPinEntered, System.AsyncCallback callback, object object)
        {
        
        }
        public virtual void EndInvoke(System.IAsyncResult result)
        {
        
        }
    
    }

}
