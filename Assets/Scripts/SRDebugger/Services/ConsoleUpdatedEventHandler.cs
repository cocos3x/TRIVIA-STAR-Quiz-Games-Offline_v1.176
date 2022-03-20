using UnityEngine;

namespace SRDebugger.Services
{
    public sealed class ConsoleUpdatedEventHandler : MulticastDelegate
    {
        // Methods
        public ConsoleUpdatedEventHandler(object object, IntPtr method)
        {
            mem[1152921513661773592] = method;
            mem[1152921513661773600] = object;
            mem[1152921513661773604] = method;
        }
        public virtual void Invoke(SRDebugger.Services.IConsoleService console)
        {
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            if(this != 0)
            {
                    if(R8 == 0)
            {
                    return;
            }
            
                val_13 = 1152921513661893792;
            }
            else
            {
                    val_12 = 1;
            }
            
            var val_17 = 0;
            SRDebugger.Services.IConsoleService val_1 = console - 8;
            goto label_47;
            label_35:
            Spine.Animation val_2 = R7.Current;
            if(R7 == 0)
            {
                goto label_32;
            }
            
            goto label_32;
            label_46:
            val_14 = R7;
            if(val_14 == 0)
            {
                goto label_6;
            }
            
            if(R7 == 0)
            {
                goto label_7;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_15 = console;
            goto label_45;
            label_6:
            val_14 = mem[R7 + 40];
            val_14 = R7 + 40;
            if(R7 == 0)
            {
                goto label_12;
            }
            
            Spine.Animation val_3 = R7.Current;
            val_16 = 0;
            val_16 = val_16 + 1;
            val_17 = console;
            goto label_45;
            label_7:
            var val_12 = R7 + 40;
            val_12 = 1152921505025908736 + (val_12 << 3);
            goto label_45;
            label_12:
            SRDebugger.Services.IConsoleService val_4 = 1152921505025908736 + (val_14 << 3);
            goto label_45;
            label_39:
            if(console == 0)
            {
                goto label_19;
            }
            
            Spine.Animation val_5 = R7.Current;
            if((R7 + 40 + 178) == 0)
            {
                goto label_20;
            }
            
            val_16 = 0;
            label_22:
            if((R7 + 40 + 88 + 0) == R7)
            {
                goto label_21;
            }
            
            val_16 = val_16 + 1;
            if(((uint)val_16 & 65535) < (R7 + 40 + 178))
            {
                goto label_22;
            }
            
            label_20:
            val_18 = val_14;
            goto label_45;
            label_40:
            var val_13 = (val_16 + 1) + 40;
            val_13 = val_14 + (val_13 << 3);
            goto label_45;
            label_19:
            var val_14 = val_14;
            val_14 = val_14 + ((R7 + 40) << 3);
            goto label_45;
            label_21:
            var val_10 = (R7 + 40 + 88) + 0;
            var val_15 = (R7 + 40 + 88 + 0) + 4;
            val_15 = val_15 + (R7 + 40);
            val_15 = val_14 + (val_15 << 3);
            val_18 = val_15 + 188;
            goto label_45;
            label_47:
            if(R7 == 0)
            {
                goto label_31;
            }
            
            if((R7 + 42) == 1)
            {
                goto label_32;
            }
            
            goto label_45;
            label_31:
            if((R7 + 42) != 1)
            {
                goto label_34;
            }
            
            if(R6 == 0)
            {
                goto label_35;
            }
            
            if((((R7 + 40) == 65535) || ((R6 + 157) != 1)) || ((R6 + 157) == 0))
            {
                goto label_45;
            }
            
            if(R7 == 0)
            {
                goto label_39;
            }
            
            if(R7 == 0)
            {
                goto label_40;
            }
            
            if((R6 + 178) == 0)
            {
                goto label_45;
            }
            
            var val_16 = 0;
            do
            {
                if((R6 + 88 + 0) == (R7 + 12))
            {
                goto label_45;
            }
            
                val_16 = val_16 + 1;
            }
            while(((uint)val_16 & 65535) < (R6 + 178));
            
            goto label_45;
            label_34:
            if((R7 + 40) != 0)
            {
                goto label_46;
            }
            
            label_32:
            label_45:
            val_17 = val_17 + 1;
            if(val_17 != val_12)
            {
                goto label_47;
            }
        
        }
        public virtual System.IAsyncResult BeginInvoke(SRDebugger.Services.IConsoleService console, System.AsyncCallback callback, object object)
        {
        
        }
        public virtual void EndInvoke(System.IAsyncResult result)
        {
        
        }
    
    }

}
