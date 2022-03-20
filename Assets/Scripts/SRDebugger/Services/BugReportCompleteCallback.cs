using UnityEngine;

namespace SRDebugger.Services
{
    public sealed class BugReportCompleteCallback : MulticastDelegate
    {
        // Methods
        public BugReportCompleteCallback(object object, IntPtr method)
        {
            mem[1152921513660795672] = method;
            mem[1152921513660795680] = object;
            mem[1152921513660795684] = method;
        }
        public virtual void Invoke(bool didSucceed, string errorMessage)
        {
            var val_2;
            var val_6;
            var val_7;
            bool val_8;
            var val_9;
            var val_10;
            if(this != 0)
            {
                    if(R8 == 0)
            {
                    return;
            }
            
                val_7 = 1152921513660915872;
            }
            else
            {
                    val_6 = 1;
            }
            
            var val_11 = 0;
            goto label_28;
            label_21:
            if(464122239 == 0)
            {
                goto label_4;
            }
            
            Spine.Animation val_1 = R6.Current;
            val_8 = didSucceed;
            if((R7 + 178) == 0)
            {
                goto label_5;
            }
            
            var val_5 = 0;
            label_7:
            if((R7 + 88 + 0) == R6)
            {
                goto label_6;
            }
            
            val_5 = val_5 + 1;
            if(((uint)val_5 & 65535) < (R7 + 178))
            {
                goto label_7;
            }
            
            label_5:
            val_9 = R7;
            val_8 = val_8;
            goto label_8;
            label_22:
            var val_6 = (0 + 1) + 40;
            val_6 = R7 + (val_6 << 3);
            if(val_8 == true)
            {
                    val_8 = 1;
            }
            
            goto label_16;
            label_4:
            var val_7 = R7;
            val_7 = val_7 + ((R6 + 40) << 3);
            goto label_16;
            label_24:
            val_7 = val_7 + (((R7 + (R6 + 40) << 3) + 192) << 3);
            var val_8 = ((R7 + (R6 + 40) << 3) + ((R7 + (R6 + 40) << 3) + 192) << 3) + 4;
            val_8 = val_8 + val_2;
            val_8 = (R6 + 40) + (val_8 << 3);
            val_8 = val_8 + 188;
            label_26:
            if((R6 + 40) != 0)
            {
                    R6 + 40 = 1;
            }
            
            goto label_16;
            label_6:
            var val_3 = (R7 + 88) + 0;
            var val_9 = (R7 + 88 + 0) + 4;
            val_9 = val_9 + (R6 + 40);
            val_9 = R7 + (val_9 << 3);
            val_9 = val_9 + 188;
            label_8:
            if(val_8 == true)
            {
                    val_8 = 1;
            }
            
            goto label_16;
            label_28:
            val_10 = mem[1152921513660915876];
            if(val_10 == 0)
            {
                goto label_14;
            }
            
            if((mem[1152921513660915876] + 42) != 2)
            {
                goto label_27;
            }
            
            goto label_16;
            label_14:
            if(mem[1152921513660915872] == 0)
            {
                goto label_17;
            }
            
            if((((mem[1152921513660915876] + 40) == 65535) || ((mem[1152921513660915872] + 157) != 1)) || (mem[1152921513660915868] == 0))
            {
                goto label_27;
            }
            
            if(val_10 == 0)
            {
                goto label_21;
            }
            
            if(val_10 == 0)
            {
                goto label_22;
            }
            
            val_2 = mem[1152921513660915876] + 40;
            if((mem[1152921513660915872] + 178) == 0)
            {
                goto label_26;
            }
            
            var val_10 = 0;
            label_25:
            if((mem[1152921513660915872] + 88 + 0) == (mem[1152921513660915876] + 12))
            {
                goto label_24;
            }
            
            val_10 = val_10 + 1;
            if(((uint)val_10 & 65535) < (mem[1152921513660915872] + 178))
            {
                goto label_25;
            }
            
            goto label_26;
            label_17:
            Spine.Animation val_4 = val_10.Current;
            label_27:
            label_16:
            val_11 = val_11 + 1;
            if(val_11 != val_6)
            {
                goto label_28;
            }
        
        }
        public virtual System.IAsyncResult BeginInvoke(bool didSucceed, string errorMessage, System.AsyncCallback callback, object object)
        {
        
        }
        public virtual void EndInvoke(System.IAsyncResult result)
        {
        
        }
    
    }

}
