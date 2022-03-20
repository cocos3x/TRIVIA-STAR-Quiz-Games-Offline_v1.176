using UnityEngine;

namespace SRDebugger.UI.Controls
{
    public sealed class PinEntryControlCallback : MulticastDelegate
    {
        // Methods
        public PinEntryControlCallback(object object, IntPtr method)
        {
            mem[1152921513646609576] = method;
            mem[1152921513646609584] = object;
            mem[1152921513646609588] = method;
        }
        public virtual void Invoke(System.Collections.Generic.IList<int> result, bool didCancel)
        {
            SRDebugger.UI.Controls.PinEntryControlCallback val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            val_13 = this;
            if(this != 0)
            {
                    if(R4 == 0)
            {
                    return;
            }
            
                val_15 = 1152921513646729776;
            }
            else
            {
                    val_14 = 1;
            }
            
            var val_19 = 0;
            System.Collections.Generic.IList<System.Int32> val_1 = result - 8;
            goto label_49;
            label_44:
            if(R6 == 0)
            {
                goto label_4;
            }
            
            if(R6 == 0)
            {
                goto label_5;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_17 = result;
            goto label_9;
            label_4:
            val_16 = mem[R6 + 40];
            val_16 = R6 + 40;
            if(R6 == 0)
            {
                goto label_10;
            }
            
            Spine.Animation val_2 = R6.Current;
            val_18 = 0;
            val_18 = val_18 + 1;
            val_19 = result;
            goto label_14;
            label_5:
            var val_13 = R6 + 40;
            val_13 = 1152921504687464448 + (val_13 << 3);
            if(didCancel == true)
            {
                    didCancel = 1;
            }
            
            val_13 = val_13;
            goto label_43;
            label_10:
            System.Collections.Generic.IList<System.Int32> val_3 = 1152921504687464448 + (val_16 << 3);
            goto label_43;
            label_37:
            if(result == 0)
            {
                goto label_17;
            }
            
            Spine.Animation val_4 = R6.Current;
            if((R6 + 40 + 178) == 0)
            {
                goto label_18;
            }
            
            var val_14 = 0;
            label_20:
            if((R6 + 40 + 88 + 0) == R6)
            {
                goto label_19;
            }
            
            val_14 = val_14 + 1;
            if(((uint)val_14 & 65535) < (R6 + 40 + 178))
            {
                goto label_20;
            }
            
            label_18:
            val_20 = val_16;
            goto label_21;
            label_38:
            var val_15 = (0 + 1) + 40;
            val_15 = val_16 + (val_15 << 3);
            if(didCancel == true)
            {
                    didCancel = 1;
            }
            
            goto label_43;
            label_17:
            var val_16 = val_16;
            val_16 = val_16 + ((R6 + 40) << 3);
            goto label_43;
            label_9:
            if(didCancel == true)
            {
                    didCancel = 1;
            }
            
            val_13 = val_13;
            goto label_25;
            label_14:
            if(didCancel == true)
            {
                    didCancel = 1;
            }
            
            goto label_25;
            label_40:
            label_42:
            if((R6 + 40) != 0)
            {
                    R6 + 40 = 1;
            }
            
            goto label_26;
            label_19:
            var val_9 = (R6 + 40 + 88) + 0;
            var val_17 = (R6 + 40 + 88 + 0) + 4;
            val_17 = val_17 + (R6 + 40);
            val_17 = val_16 + (val_17 << 3);
            val_20 = val_17 + 188;
            label_21:
            if(didCancel == true)
            {
                    didCancel = 1;
            }
            
            label_26:
            label_25:
            val_14 = val_14;
            goto label_43;
            label_49:
            if(R6 == 0)
            {
                goto label_29;
            }
            
            if((R6 + 42) == 2)
            {
                goto label_48;
            }
            
            goto label_43;
            label_29:
            if((R6 + 42) != 2)
            {
                goto label_32;
            }
            
            if(R7 == 0)
            {
                goto label_33;
            }
            
            if((((R6 + 40) == 65535) || ((R7 + 157) != 1)) || ((R7 + 157) == 0))
            {
                goto label_43;
            }
            
            if(R6 == 0)
            {
                goto label_37;
            }
            
            if(R6 == 0)
            {
                goto label_38;
            }
            
            if((R7 + 178) == 0)
            {
                goto label_42;
            }
            
            var val_18 = 0;
            label_41:
            if((R7 + 88 + 0) == (R6 + 12))
            {
                goto label_40;
            }
            
            val_18 = val_18 + 1;
            if(((uint)val_18 & 65535) < (R7 + 178))
            {
                goto label_41;
            }
            
            goto label_42;
            label_32:
            if((R6 + 40) != 0)
            {
                goto label_44;
            }
            
            if(R7 != 0)
            {
                goto label_48;
            }
            
            Spine.Animation val_10 = R6.Current;
            if(R6 == 0)
            {
                goto label_48;
            }
            
            goto label_48;
            label_33:
            Spine.Animation val_11 = R6.Current;
            label_48:
            label_43:
            val_19 = val_19 + 1;
            if(val_19 != val_14)
            {
                goto label_49;
            }
        
        }
        public virtual System.IAsyncResult BeginInvoke(System.Collections.Generic.IList<int> result, bool didCancel, System.AsyncCallback callback, object object)
        {
        
        }
        public virtual void EndInvoke(System.IAsyncResult result)
        {
        
        }
    
    }

}
