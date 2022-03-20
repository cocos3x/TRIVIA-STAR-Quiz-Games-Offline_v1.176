using UnityEngine;

namespace SRDebugger.Services
{
    public sealed class BugReportProgressCallback : MulticastDelegate
    {
        // Methods
        public BugReportProgressCallback(object object, IntPtr method)
        {
            mem[1152921513661292824] = method;
            mem[1152921513661292832] = object;
            mem[1152921513661292836] = method;
        }
        public virtual void Invoke(float progress)
        {
            SRDebugger.Services.BugReportProgressCallback val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_6 = this;
            if(this != 0)
            {
                    if(R4 == 0)
            {
                    return;
            }
            
                val_8 = 1152921513661408928;
            }
            else
            {
                    val_7 = 1;
            }
            
            var val_10 = 0;
            goto label_28;
            label_21:
            if(464615288 == 0)
            {
                goto label_4;
            }
            
            Spine.Animation val_1 = R7.Current;
            if((R6 + 178) == 0)
            {
                goto label_5;
            }
            
            val_9 = 0;
            label_7:
            if((R6 + 88 + 0) == R7)
            {
                goto label_6;
            }
            
            val_9 = val_9 + 1;
            if(((uint)val_9 & 65535) < (R6 + 178))
            {
                goto label_7;
            }
            
            label_5:
            val_10 = R6;
            goto label_8;
            label_22:
            var val_5 = (val_9 + 1) + 40;
            val_5 = R6 + (val_5 << 3);
            val_11 = mem[(R6 + ((val_9 + 1) + 40) << 3) + 192];
            val_11 = (R6 + ((val_9 + 1) + 40) << 3) + 192;
            goto label_11;
            label_4:
            var val_6 = R6;
            val_6 = val_6 + ((R7 + 40) << 3);
            goto label_11;
            label_24:
            var val_2 = (R7 + 40) + (((R6 + (R7 + 40) << 3) + 188) << 3);
            var val_7 = (R7 + 40 + ((R6 + (R7 + 40) << 3) + 188) << 3) + 4;
            val_7 = val_7 + ((R6 + (R7 + 40) << 3) + 192);
            val_7 = IP + (val_7 << 3);
            val_7 = val_7 + 188;
            label_26:
            val_11 = mem[((IP + (((R7 + 40 + ((R6 + (R7 + 40) << 3) + 188) << 3) + 4 + (R6 + (R7 + 40) << 3) + 192)) << 3) + 188) + 4];
            val_11 = ((IP + (((R7 + 40 + ((R6 + (R7 + 40) << 3) + 188) << 3) + 4 + (R6 + (R7 + 40) << 3) + 192)) << 3) + 188) + 4;
            goto label_11;
            label_6:
            var val_3 = (R6 + 88) + 0;
            var val_8 = (R6 + 88 + 0) + 4;
            val_8 = val_8 + (R7 + 40);
            val_8 = R6 + (val_8 << 3);
            val_10 = val_8 + 188;
            label_8:
            label_11:
            val_6 = val_6;
            goto label_16;
            label_28:
            val_9 = mem[1152921513661408932];
            if(val_9 == 0)
            {
                goto label_14;
            }
            
            if((mem[1152921513661408932] + 42) != 1)
            {
                goto label_27;
            }
            
            goto label_16;
            label_14:
            if(mem[1152921513661408928] == 0)
            {
                goto label_17;
            }
            
            if((((mem[1152921513661408932] + 40) == 65535) || ((mem[1152921513661408928] + 157) != 1)) || ((mem[1152921513661408928] + 157) == 0))
            {
                goto label_27;
            }
            
            if(val_9 == 0)
            {
                goto label_21;
            }
            
            if(val_9 == 0)
            {
                goto label_22;
            }
            
            if((mem[1152921513661408928] + 178) == 0)
            {
                goto label_26;
            }
            
            var val_9 = 0;
            label_25:
            if((mem[1152921513661408928] + 88 + 0) == (mem[1152921513661408932] + 12))
            {
                goto label_24;
            }
            
            val_9 = val_9 + 1;
            if(((uint)val_9 & 65535) < (mem[1152921513661408928] + 178))
            {
                goto label_25;
            }
            
            goto label_26;
            label_17:
            Spine.Animation val_4 = val_9.Current;
            label_27:
            label_16:
            val_10 = val_10 + 1;
            if(val_10 != val_7)
            {
                goto label_28;
            }
        
        }
        public virtual System.IAsyncResult BeginInvoke(float progress, System.AsyncCallback callback, object object)
        {
        
        }
        public virtual void EndInvoke(System.IAsyncResult result)
        {
        
        }
    
    }

}
