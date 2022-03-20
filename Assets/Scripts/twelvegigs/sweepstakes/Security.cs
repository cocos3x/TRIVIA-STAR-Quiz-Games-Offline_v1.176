using UnityEngine;

namespace twelvegigs.sweepstakes
{
    public class Security
    {
        // Methods
        public string RequestId()
        {
            var val_4;
            var val_9;
            float val_1 = UnityEngine.Random.Range(min:  null, max:  null);
            string val_2 = 3407386240.ToString();
            System.DateTime val_3 = System.DateTime.Today;
            string val_7 = val_4.Ticks.ToString();
            System.DateTime val_8 = System.DateTime.Now;
            string val_11 = val_9.ToString();
            string val_12 = System.String.Format(format:  -1183154368, arg0:  1129741684, arg1:  1129741664, arg2:  1129741672);
            string val_13 = twelvegigs.sweepstakes.HashUtil.MD5(text:  -1183154368);
            string val_15 = Substring(startIndex:  0, length:  UnityEngine.Random.Range(min:  13, max:  15));
            string val_16 = ToLower();
        }
        public int Seed()
        {
            return UnityEngine.Random.Range(min:  1, max:  99999999);
        }
        public int UnixTimestamp()
        {
            var val_6;
            System.DateTime val_1 = System.DateTime.UtcNow;
            System.DateTime val_4 = new System.DateTime(year:  1970, month:  1, day:  1);
            System.TimeSpan val_5 = Subtract(value:  new System.DateTime() {dateData = 1152921514326747256});
            double val_8 = val_6.TotalSeconds;
            if(System.DateTime.__il2cppRuntimeField_cctor_finished == 0)
            {
                    1129965680 = 1129965680;
            }
            
            return (int)S0;
        }
        public string Sign(string[] signParams, System.Collections.Generic.Dictionary<string, object> payload)
        {
            var val_9;
            object val_10;
            System.Text.StringBuilder val_1 = null;
            val_9 = 0;
            val_1 = new System.Text.StringBuilder();
            goto label_1;
            label_5:
            string val_2 = twelvegigs.sweepstakes.StringUtil.ReverseString(s:  477709520);
            System.Text.StringBuilder val_3 = Append(value:  477709520);
            val_9 = 1;
            label_1:
            if(val_9 < val_1)
            {
                goto label_5;
            }
            
            if(payload != 0)
            {
                    val_10 = payload;
                string val_4 = MiniJSON.Json.Serialize(obj:  val_10);
            }
            else
            {
                    val_10 = "empty";
            }
            
            System.Byte[] val_5 = twelvegigs.sweepstakes.HashUtil.ToByte(text:  -1361596464);
            string val_6 = twelvegigs.sweepstakes.HashUtil.SHA512(bytes:  -1361596464);
            string val_7 = 24121344 + -1361596464(-1361596464) + 24121344;
            System.Byte[] val_8 = twelvegigs.sweepstakes.HashUtil.ToByte(text:  24121344);
            return twelvegigs.sweepstakes.HashUtil.SHA512(bytes:  24121344);
        }
        public string OpenUdidGenerator(string fromId)
        {
            System.Byte[] val_1 = twelvegigs.sweepstakes.HashUtil.ToByte(text:  fromId);
            return twelvegigs.sweepstakes.HashUtil.SHA512(bytes:  fromId);
        }
        public Security()
        {
        
        }
    
    }

}
