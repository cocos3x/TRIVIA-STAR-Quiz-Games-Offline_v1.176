using UnityEngine;

namespace SLC.Minigames
{
    public class MinigamesUtils
    {
        // Methods
        public static string RomanNumeralize(int num)
        {
            var val_1;
            if(num < 2)
            {
                    val_1 = "I";
                return;
            }
            
            if(num == 2)
            {
                    val_1 = "II";
                return;
            }
            
            if(num < 4)
            {
                    val_1 = "III";
                return;
            }
            
            if(num == 4)
            {
                    val_1 = "IV";
                return;
            }
            
            if(num < 6)
            {
                    val_1 = "V";
                return;
            }
            
            if(num == 6)
            {
                    val_1 = "VI";
                return;
            }
            
            if(num < 8)
            {
                    val_1 = "VII";
            }
        
        }
        public static string ColorToHex(UnityEngine.Color32 color)
        {
            string val_1 = color.r.ToString(format:  -1776898224);
            string val_2 = color.g.ToString(format:  -1776898224);
            string val_3 = color.b.ToString(format:  -1776898224);
            string val_4 = 914828548 + 914828549 + 914828550;
        }
        public static UnityEngine.Color HexToColor(string hex)
        {
            string val_1 = R1.Substring(startIndex:  0, length:  2);
            string val_3 = R1.Substring(startIndex:  2, length:  2);
            string val_5 = R1.Substring(startIndex:  4, length:  2);
            UnityEngine.Color32 val_7 = new UnityEngine.Color32(r:  System.Byte.Parse(s:  R1, style:  515), g:  System.Byte.Parse(s:  R1, style:  515), b:  System.Byte.Parse(s:  R1, style:  515), a:  255);
            UnityEngine.Color val_8 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = hex, g = hex, b = hex, a = hex});
            return new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a};
        }
        public MinigamesUtils()
        {
        
        }
    
    }

}
