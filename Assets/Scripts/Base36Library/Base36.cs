using UnityEngine;

namespace Base36Library
{
    public static class Base36
    {
        // Fields
        private const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string Min = "-1Y2P0IJ32E8E8";
        private const string Max = "1Y2P0IJ32E8E7";
        
        // Methods
        public static bool WouldOverflow(string value)
        {
            if((Base36Library.Base36._Compare(valueA:  1163917808, valueB:  value)) < 0)
            {
                    return true;
            }
            
            int val_2 = Base36Library.Base36._Compare(valueA:  value, valueB:  1163917904);
            val_2 = val_2 >> 31;
            return (bool)val_2;
        }
        public static int Compare(string valueA, string valueB)
        {
            string val_1 = Base36Library.Base36.Sanitize(value:  valueA);
            string val_2 = Base36Library.Base36.Sanitize(value:  valueB);
            return Base36Library.Base36._Compare(valueA:  valueA, valueB:  valueB);
        }
        public static long Decode(string value)
        {
            string val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            string val_1 = Base36Library.Base36.Sanitize(value:  value);
            Base36Library.Base36.CheckOverflow(value:  value);
            string val_3 = Base36Library.Base36.Abs(value:  value);
            val_10 = value;
            val_11 = 0;
            val_12 = 0;
            val_13 = 0;
            goto label_2;
            label_8:
            val_14 = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if(val_14 == 0)
            {
                    val_14 = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            
            int val_6 = 0 + value.m_stringLength;
            double val_7 = System.Math.Pow(x:  null, y:  null);
            if(System.Math.__il2cppRuntimeField_cctor_finished == 0)
            {
                    System.Math.__il2cppRuntimeField_cctor_finished = System.Math.__il2cppRuntimeField_cctor_finished;
            }
            
            int val_8 = (IndexOf(value:  val_10.Chars[0])) >> 31;
            val_10 = value;
            val_11 = 1;
            val_12 = R3 + val_12;
            label_2:
            if(val_11 < (value + 8))
            {
                goto label_8;
            }
            
            if(value.Chars[0] != ('-'))
            {
                    0 - val_12 = val_12;
            }
            
            return (long)0 - val_12;
        }
        public static string Encode(long value)
        {
            var val_10;
            float val_11;
            long val_10 = value;
            val_10 = 35633949;
            var val_1 = R1 ^ 2147483648;
            val_11 = "-1Y2P0IJ32E8E8";
        }
        private static string Abs(string value)
        {
            int val_2;
            if(value.Chars[0] != ('-'))
            {
                    return;
            }
            
            if(value != null)
            {
                    val_2 = value.m_stringLength;
                return value.Substring(startIndex:  1, length:  -1);
            }
            
            val_2 = 0;
            return value.Substring(startIndex:  1, length:  -1);
        }
        private static void CheckOverflow(string value)
        {
            if((Base36Library.Base36._Compare(valueA:  1163917808, valueB:  value)) <= 1)
            {
                goto label_1;
            }
            
            if((Base36Library.Base36._Compare(valueA:  value, valueB:  1163917904)) > 1)
            {
                    return;
            }
            
            System.Globalization.CultureInfo val_3 = System.Globalization.CultureInfo.InvariantCulture;
            label_6:
            string val_4 = System.String.Format(provider:  0, format:  1164519104, arg0:  R4);
            System.ArgumentException val_5 = new System.ArgumentException(message:  null);
            label_1:
            System.Globalization.CultureInfo val_6 = System.Globalization.CultureInfo.InvariantCulture;
            goto label_6;
        }
        private static string Sanitize(string value)
        {
            var val_13;
            var val_14;
            System.Func<System.Char, System.Boolean> val_16;
            System.ArgumentNullException val_17;
            var val_18;
            val_13 = 35633951;
            if(value == null)
            {
                goto label_1;
            }
            
            if((System.String.IsNullOrEmpty(value:  value)) == true)
            {
                goto label_2;
            }
            
            string val_2 = value.Trim();
            string val_3 = value.ToUpperInvariant();
            string val_4 = Base36Library.Base36.Abs(value:  value);
            val_14 = null;
            val_14 = null;
            val_16 = Base36.<>c.<>9__9_0;
            if(val_16 == 0)
            {
                    val_16 = null;
                val_16 = new System.Func<System.Char, System.Boolean>(object:  Base36.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(1164640736));
                Base36.<>c.<>9__9_0 = val_16;
            }
            
            bool val_6 = System.Linq.Enumerable.Any<System.Char>(source:  value, predicate:  7720960);
            if(val_6 == false)
            {
                    val_6 = value;
                return;
            }
            
            System.Globalization.CultureInfo val_7 = System.Globalization.CultureInfo.InvariantCulture;
            string val_8 = System.String.Format(provider:  0, format:  1164641760, arg0:  R4);
            System.ArgumentException val_9 = null;
            val_13 = val_9;
            val_9 = new System.ArgumentException(message:  null);
            label_1:
            val_17 = null;
            val_18 = 0;
            val_17 = new System.ArgumentNullException(message:  1164642912, innerException:  0);
            goto label_11;
            label_2:
            val_17 = null;
            val_18 = 0;
            val_17 = new System.ArgumentException(message:  1164643040);
            label_11:
        }
        private static int _Compare(string valueA, string valueB)
        {
            if((System.String.op_Equality(a:  valueA, b:  valueB)) == true)
            {
                    return (int)0;
            }
            
            char val_3 = valueB.Chars[0];
            char val_4 = valueA.Chars[0] - 45;
            val_3 = val_3 - 45;
            val_3 = val_3 >> 5;
            val_4 = val_4 >> 5;
            char val_5 = val_4 & val_3;
            if(val_4 == val_5)
            {
                    0 = 0;
            }
            
            if(val_3 != val_5)
            {
                    return (int)0;
            }
            
            string val_6 = Base36Library.Base36.Abs(value:  valueA);
            string val_7 = Base36Library.Base36.Abs(value:  valueB);
            if(valueA.m_stringLength < valueB.m_stringLength)
            {
                    if(val_5 != ' ')
            {
                    1 = 0;
            }
            
                return (int)1;
            }
            
            if(valueA.m_stringLength > valueB.m_stringLength)
            {
                    if(val_5 != ' ')
            {
                    0 = 1;
            }
            
                return (int)0;
            }
            
            var val_13 = 0;
            label_14:
            if(val_13 >= valueA.m_stringLength)
            {
                goto label_10;
            }
            
            int val_9 = IndexOf(value:  valueA.Chars[0]);
            int val_11 = IndexOf(value:  valueB.Chars[0]);
            val_13 = val_13 + 1;
            if(val_9 == val_11)
            {
                goto label_14;
            }
            
            if(val_9 < val_11)
            {
                    0 = 1;
            }
            
            if(val_5 != ' ')
            {
                    1 = 0;
            }
            
            return (int)0;
            label_10:
            System.Exception val_12 = new System.Exception(message:  1164767456);
        }
    
    }

}
