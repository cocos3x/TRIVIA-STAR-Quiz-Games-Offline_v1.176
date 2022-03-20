using UnityEngine;

namespace twelvegigs.sweepstakes
{
    public static class StringUtil
    {
        // Methods
        public static string ReverseString(string s)
        {
            System.Char[] val_1 = s.ToCharArray();
            System.Array.Reverse(array:  s);
            return 0.CreateString(val:  s);
        }
        public static byte[] StringToByteArray(string text)
        {
            System.Text.UTF8Encoding val_1 = new System.Text.UTF8Encoding();
            System.Byte[] val_2 = GetBytes(s:  text);
        }
        public static string ByteArrayToString(byte[] bytes)
        {
            System.Text.UTF8Encoding val_1 = new System.Text.UTF8Encoding();
            string val_2 = GetString(bytes:  bytes);
        }
        public static bool IsJson(string input)
        {
            var val_5;
            string val_1 = input.Trim();
            if((input.StartsWith(value:  1466574400)) != false)
            {
                    val_5 = 1;
                if((input.EndsWith(value:  1487337936)) == true)
            {
                    return (bool)val_5;
            }
            
            }
            
            val_5 = 0;
            if((input.StartsWith(value:  1466574320)) == false)
            {
                    return (bool)val_5;
            }
            
            if(input != null)
            {
                    return input.EndsWith(value:  1487188992);
            }
            
            return input.EndsWith(value:  1487188992);
        }
        public static bool IsJson(byte[] bytes)
        {
            string val_1 = twelvegigs.sweepstakes.StringUtil.ByteArrayToString(bytes:  bytes);
            return twelvegigs.sweepstakes.StringUtil.IsJson(input:  bytes);
        }
        public static bool IsPlist(string input)
        {
            var val_4;
            var val_5;
            string val_1 = input.Trim();
            val_4 = "<?xml";
            if(val_4 == 0)
            {
                    val_4 = "<?xml";
            }
            
            val_5 = "</plist>";
            if(val_5 == 0)
            {
                    val_5 = "</plist>";
            }
            
            if((input.StartsWith(value:  1131227952)) == false)
            {
                    return false;
            }
            
            return input.EndsWith(value:  1131228032);
        }
        public static bool IsPlist(byte[] bytes)
        {
            string val_1 = twelvegigs.sweepstakes.StringUtil.ByteArrayToString(bytes:  bytes);
            return twelvegigs.sweepstakes.StringUtil.IsPlist(input:  bytes);
        }
        public static string UpperFirst(string input)
        {
            string val_3 = System.Char.ToUpper(c:  input.Chars[0]).ToString();
            string val_4 = input.Substring(startIndex:  1);
            string val_5 = 1131546030 + input;
        }
        public static string LowerFirst(string input)
        {
            string val_3 = System.Char.ToLower(c:  input.Chars[0]).ToString();
            string val_4 = input.Substring(startIndex:  1);
            string val_5 = 1131666222 + input;
        }
        public static string ToCamelCase(string input)
        {
            return twelvegigs.sweepstakes.StringUtil.ToCamelCase(input:  input, capitalized:  false);
        }
        public static string ToCamelCase(string input, bool capitalized)
        {
            var val_5;
            var val_6;
            int val_7;
            char val_8;
            val_5 = capitalized;
            val_6 = 0;
            val_7 = System.String.alignConst;
            goto label_1;
            label_8:
            char val_1 = input.Chars[0];
            if(val_1 != ('-'))
            {
                    val_8 = val_1;
            }
            
            if(val_1 == '_')
            {
                    val_5 = 1;
            }
            else
            {
                    if((val_5 & true) == 0)
            {
                    val_8 = System.Char.ToUpper(c:  val_8);
            }
            
                val_5 = 0;
                string val_3 = val_8.ToString();
                string val_4 = val_7 + 1131906586;
                val_7 = val_7;
            }
            
            val_6 = 1;
            label_1:
            if(val_6 < input.m_stringLength)
            {
                goto label_8;
            }
        
        }
        public static string ToDashed(string input)
        {
            return twelvegigs.sweepstakes.StringUtil.SplitCamelCase(input:  input, separator:  1359327184);
        }
        public static string ToUnderscore(string input)
        {
            return twelvegigs.sweepstakes.StringUtil.SplitCamelCase(input:  input, separator:  2144339952);
        }
        private static string SplitCamelCase(string input, string separator)
        {
            var val_8;
            var val_9;
            var val_10;
            int val_11;
            val_8 = 0;
            val_9 = 0;
            val_10 = 0;
            val_11 = System.String.alignConst;
            goto label_1;
            label_10:
            char val_1 = input.Chars[0];
            if((System.Char.IsLetterOrDigit(c:  val_1)) != false)
            {
                    bool val_3 = System.Char.IsUpper(c:  val_1);
                if(val_3 == true)
            {
                    val_3 = 1;
                val_10 = 1;
            }
            
                if((val_10 & 1) == 0)
            {
                    string val_4 = val_11 + separator;
            }
            
                val_10 = 0;
                string val_5 = val_1.ToString();
                string val_6 = val_11 + 1132271258;
                val_11 = val_11;
                val_9 = val_3;
            }
            else
            {
                    val_10 = 1;
            }
            
            val_8 = 1;
            label_1:
            if(val_8 < input.m_stringLength)
            {
                goto label_10;
            }
            
            string val_7 = val_11.ToLower();
        }
        public static bool IsDigitsOnly(string str)
        {
            var val_2;
            var val_2 = 0;
            val_2 = 0;
            label_2:
            if(val_2 >= str.m_stringLength)
            {
                goto label_1;
            }
            
            char val_1 = str.Chars[0];
            val_1 = val_1 - 48;
            val_2 = val_2 + 1;
            if(((uint)val_1 & 65535) <= 9)
            {
                goto label_2;
            }
            
            return (bool)val_2;
            label_1:
            val_2 = 1;
            return (bool)val_2;
        }
    
    }

}
