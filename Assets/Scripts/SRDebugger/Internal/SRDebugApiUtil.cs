using UnityEngine;

namespace SRDebugger.Internal
{
    public static class SRDebugApiUtil
    {
        // Methods
        public static string ParseErrorException(System.Net.WebException ex)
        {
            if(ex.m_Response != 0)
            {
                    string val_1 = SRDebugger.Internal.SRDebugApiUtil.ReadResponseStream(stream:  ex.m_Response);
                string val_2 = SRDebugger.Internal.SRDebugApiUtil.ParseErrorResponse(response:  ex.m_Response, fallback:  490485104);
            }
        
        }
        public static string ParseErrorResponse(string response, string fallback = "Unexpected Response")
        {
            string val_12;
            string val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            val_12 = response;
            val_13 = fallback;
            object val_1 = SRF.Json.Deserialize(json:  val_12);
            val_14 = 0;
            string val_2 = val_14.Item[1706003856];
            string val_3 = 1098586544 + 0;
            if((val_14.TryGetValue(key:  490614624, value: out  UnityEngine.Material val_4 = 490626664)) == false)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
            
            var val_13 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_8;
            }
            
            var val_12 = 0;
            label_10:
            if((mem[1179403735] + 0) == null)
            {
                goto label_9;
            }
            
            val_12 = val_12 + 1;
            if(((uint)val_12 & 65535) < mem[1179403825])
            {
                goto label_10;
            }
            
            label_8:
            val_15 = 0;
            goto label_11;
            label_9:
            var val_6 = mem[1179403735] + 0;
            val_13 = val_13 + (((mem[1179403735] + 0) + 4) << 3);
            val_15 = val_13 + 188;
            label_11:
            val_14 = 0;
            val_13 = "\n";
            label_24:
            var val_15 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_14;
            }
            
            var val_14 = 0;
            label_16:
            val_12 = mem[mem[1179403735] + 0];
            val_12 = mem[1179403735] + 0;
            if(val_12 == null)
            {
                goto label_15;
            }
            
            val_14 = val_14 + 1;
            val_12 = (uint)val_14 & 65535;
            if(val_12 < mem[1179403825])
            {
                goto label_16;
            }
            
            label_14:
            val_16 = val_14;
            goto label_17;
            label_15:
            var val_7 = mem[1179403735] + 0;
            val_15 = val_15 + (((mem[1179403735] + 0) + 4) << 3);
            val_16 = val_15 + 188;
            label_17:
            if(val_14 == 0)
            {
                goto label_18;
            }
            
            var val_17 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_20;
            }
            
            var val_16 = 0;
            label_22:
            if((mem[1179403735] + 0) == null)
            {
                goto label_21;
            }
            
            val_16 = val_16 + 1;
            if(((uint)val_16 & 65535) < mem[1179403825])
            {
                goto label_22;
            }
            
            label_20:
            val_17 = val_14;
            goto label_23;
            label_21:
            var val_8 = mem[1179403735] + 0;
            val_17 = val_17 + (((mem[1179403735] + 0) + 4) << 3);
            val_17 = val_17 + 188;
            label_23:
            string val_9 = 1098586544 + 1269544832;
            string val_10 = 1098586544 + 0;
            goto label_24;
            label_18:
            if(val_14 == 0)
            {
                goto label_25;
            }
            
            var val_19 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_26;
            }
            
            var val_18 = 0;
            label_28:
            val_12 = mem[mem[1179403735] + 0];
            val_12 = mem[1179403735] + 0;
            if(val_12 == null)
            {
                goto label_27;
            }
            
            val_18 = val_18 + 1;
            val_12 = (uint)val_18 & 65535;
            if(val_12 < mem[1179403825])
            {
                goto label_28;
            }
            
            label_26:
            val_18 = val_14;
            goto label_29;
            label_27:
            var val_11 = mem[1179403735] + 0;
            val_19 = val_19 + (((mem[1179403735] + 0) + 4) << 3);
            val_18 = val_19 + 188;
            label_29:
            label_25:
            if(0 == 0)
            {
                    return;
            }
        
        }
        public static bool ReadResponse(System.Net.HttpWebRequest request, out string result)
        {
            string val_1 = SRDebugger.Internal.SRDebugApiUtil.ReadResponseStream(stream:  request);
            result = request;
            return true;
        }
        public static string ReadResponseStream(System.Net.WebResponse stream)
        {
            var val_4;
            var val_5;
            var val_6;
            System.IO.StreamReader val_5 = null;
            if((mem[null + 178]) == 0)
            {
                goto label_3;
            }
            
            var val_4 = 0;
            label_5:
            val_4 = mem[mem[null + 88] + 0];
            val_4 = mem[null + 88] + 0;
            if(val_4 == null)
            {
                goto label_4;
            }
            
            val_4 = val_4 + 1;
            if(((uint)val_4 & 65535) < (mem[null + 178]))
            {
                goto label_5;
            }
            
            label_3:
            val_5 = new System.IO.StreamReader(stream:  stream);
            goto label_6;
            label_4:
            var val_2 = (mem[null + 88]) + 0;
            val_5 = val_5 + (((mem[null + 88] + 0) + 4) << 3);
            label_6:
            if(stream != 0)
            {
                    val_4 = 0;
                val_4 = val_4 + 1;
                val_6 = stream;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
    
    }

}
