using UnityEngine;

namespace SharpJson
{
    internal class Lexer
    {
        // Fields
        private int <lineNumber>k__BackingField;
        private bool <parseNumbersAsFloat>k__BackingField;
        private char[] json;
        private int index;
        private bool success;
        private char[] stringBuffer;
        
        // Properties
        public bool hasError { get; }
        public int lineNumber { get; set; }
        public bool parseNumbersAsFloat { get; set; }
        
        // Methods
        public bool get_hasError()
        {
            bool val_1 = this.success;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        public int get_lineNumber()
        {
            return (int)this.<lineNumber>k__BackingField;
        }
        private void set_lineNumber(int value)
        {
            this.<lineNumber>k__BackingField = value;
        }
        public bool get_parseNumbersAsFloat()
        {
            return (bool)this.<parseNumbersAsFloat>k__BackingField;
        }
        public void set_parseNumbersAsFloat(bool value)
        {
            this.<parseNumbersAsFloat>k__BackingField = value;
        }
        public Lexer(string text)
        {
            this.success = true;
            this.stringBuffer = null;
            this.<lineNumber>k__BackingField = true;
            this.index = 0;
            this.success = true;
            System.Char[] val_1 = text.ToCharArray();
            this.json = text;
            this.<parseNumbersAsFloat>k__BackingField = 0;
        }
        public void Reset()
        {
            this.<lineNumber>k__BackingField = 1;
            this.index = 0;
            this.success = 1;
        }
        public string ParseString()
        {
            this.SkipWhiteSpaces();
            int val_1 = this.index + 1;
            this.index = val_1;
            if((0 != 1) || (this.index == val_1))
            {
                goto label_23;
            }
            
            this.index = this.index + 1;
            char val_11 = this.json[this.index << 1];
            if(val_11 == '\')
            {
                goto label_17;
            }
            
            if(val_11 == '"')
            {
                goto label_18;
            }
            
            var val_5 = 0 + 1;
            this.stringBuffer[0] = val_11;
            goto label_21;
            label_17:
            if(this.index == (this.json[this.index << 1]))
            {
                goto label_23;
            }
            
            this.index = this.index + 1;
            char val_12 = this.json[this.index << 1];
            if(val_12 > '\')
            {
                goto label_26;
            }
            
            if(val_12 == '"')
            {
                goto label_27;
            }
            
            if(val_12 == ('/'))
            {
                goto label_28;
            }
            
            if(val_12 != '\')
            {
                goto label_39;
            }
            
            var val_7 = 0 + 1;
            goto label_38;
            label_26:
            if(val_12 > 'f')
            {
                goto label_33;
            }
            
            if(val_12 == 'b')
            {
                goto label_34;
            }
            
            if(val_12 != 'f')
            {
                goto label_39;
            }
            
            var val_8 = 0 + 1;
            goto label_38;
            label_33:
            val_12 = val_12 - 110;
            if(val_12 <= '')
            {
                    var val_9 = 20379848 + (20379848 + ((this.json[(this.index) << 1][0] - 110)) << 2);
                if(val_12 == '')
            {
                    20379848 + ((this.json[(this.index) << 1][0] - 110)) << 2 = (20379848 + ((this.json[(this.index) << 1][0] - 110)) << 2) & ((20379848 + ((this.json[(this.index) << 1][0] - 110)) << 2) >> 32);
                20379848 + ((this.json[(this.index) << 1][0] - 110)) << 2 = (20379848 + ((this.json[(this.index) << 1][0] - 110)) << 2) & 1837823216;
                20379848 + ((this.json[(this.index) << 1][0] - 110)) << 2 = (20379848 + ((this.json[(this.index) << 1][0] - 110)) << 2) & 1837823216;
                20379848 + ((this.json[(this.index) << 1][0] - 110)) << 2 = (20379848 + ((this.json[(this.index) << 1][0] - 110)) << 2) & 1837823216;
                20379848 + ((this.json[(this.index) << 1][0] - 110)) << 2 = (20379848 + ((this.json[(this.index) << 1][0] - 110)) << 2) & ((20379848 + ((this.json[(this.index) << 1][0] - 110)) << 2) << 2);
                20379848 + ((this.json[(this.index) << 1][0] - 110)) << 2 = (20379848 + ((this.json[(this.index) << 1][0] - 110)) << 2) & 1837823216;
                20379848 + ((this.json[(this.index) << 1][0] - 110)) << 2 = (20379848 + ((this.json[(this.index) << 1][0] - 110)) << 2) & 0;
            }
            
            }
        
        }
        private string GetNumberString()
        {
            this.SkipWhiteSpaces();
            int val_2 = (this.GetLastIndexOfNumber(index:  this.index)) + 1;
            string val_4 = 0.CreateString(val:  this.json, startIndex:  this.index, length:  val_2 - this.index);
            this.index = val_2;
        }
        public float ParseFloatNumber()
        {
            string val_1 = this.GetNumberString();
            System.Globalization.CultureInfo val_2 = System.Globalization.CultureInfo.InvariantCulture;
            if((System.Single.TryParse(s:  1838526448, style:  167, provider:  0, result: out  float val_3 = 5.78365E+27f)) == true)
            {
                    0f = 0;
            }
            
            return (float)0f;
        }
        public double ParseDoubleNumber()
        {
            string val_1 = this.GetNumberString();
            System.Globalization.CultureInfo val_2 = System.Globalization.CultureInfo.InvariantCulture;
            bool val_4 = System.Double.TryParse(s:  1838638448, style:  511, provider:  0, result: out  double val_3 = 9.08402147681816E-315);
            return (double)D0;
        }
        private int GetLastIndexOfNumber(int index)
        {
            System.Char[] val_3;
            int val_3 = index;
            var val_1 = 16 + (index << 1);
            label_7:
            val_3 = this.json;
            if(val_3 >= 16)
            {
                    return (int)val_3 - 1;
            }
            
            val_3 = this.json;
            if(9488 >= 10)
            {
                    if((1152921505083303189 > 26) || ((67108877 & 1) != 0))
            {
                goto label_6;
            }
            
            }
            
            label_8:
            val_1 = val_1 + 2;
            val_3 = val_3 + 1;
            goto label_7;
            label_6:
            if(null == 101)
            {
                goto label_8;
            }
            
            return (int)val_3 - 1;
        }
        private void SkipWhiteSpaces()
        {
            int val_3;
            int val_4;
            val_3 = this.index;
            goto label_1;
            label_10:
            char val_2 = this.json[this.index << 1];
            if(val_2 == '
            ')
            {
                    val_2 = this.<lineNumber>k__BackingField;
                val_2 = val_2 + 1;
                this.<lineNumber>k__BackingField = val_2;
            }
            
            val_4 = this.index;
            if((System.Char.IsWhiteSpace(c:  this.json[val_4 << 1])) == false)
            {
                    return;
            }
            
            val_3 = this.index + 1;
            this.index = val_3;
            label_1:
            val_4 = this.json;
            if(val_3 < this.index)
            {
                goto label_10;
            }
        
        }
        public SharpJson.Lexer.Token LookAhead()
        {
            this.SkipWhiteSpaces();
            Token val_2 = SharpJson.Lexer.NextToken(json:  this.json, index: ref  int val_1 = 1839367932);
        }
        public SharpJson.Lexer.Token NextToken()
        {
            this.SkipWhiteSpaces();
            return SharpJson.Lexer.NextToken(json:  this.json, index: ref  this.index);
        }
        private static SharpJson.Lexer.Token NextToken(char[] json, ref int index)
        {
            if(index == json)
            {
                    return;
            }
            
            int val_15 = index;
            index = val_15 + 1;
            char val_14 = json[val_15 << 1];
            if(val_14 > '[')
            {
                goto label_3;
            }
            
            char val_2 = val_14 - 34;
            if(val_2 > '')
            {
                goto label_4;
            }
            
            var val_3 = 20382060 + (20382060 + ((json[(index) << 1][0] - 34)) << 2);
            if(val_2 == '')
            {
                    6 = 6 & ((R8) << 1);
                6 = 6 & ((IP) >> 1);
                6 = 6 & ((IP) >> 1);
                6 = 6 & ((IP) >> 1);
                6 = 6 & ((IP) >> 1);
                6 = 6 & ((IP) >> 1);
                6 = 6 & ((IP) >> 1);
                6 = 6 & ((IP) >> 1);
                6 = 6 & ((IP) >> 1);
                6 = 6 & ((IP) >> 1);
                6 = 6 & (((((((((((((6 & (R8) << 1) & (IP) >> 1) & (IP) >> 1) & (IP) >> 1) & (IP) >> 1) & (IP) >> 1) & (IP) >> 1) & (IP) >> 1) & (IP) >> 1) & (IP) >> 1)) << (32-R3)) | ((((((((((((6 & (R8) << 1) & (IP) >> 1) & (IP) >> 1) & (IP) >> 1) & (IP) >> 1) & (IP) >> 1) & (IP) >> 1) & (IP) >> 1) & (IP) >> 1) & (IP) >> 1)) << R3));
                6 = 6 & (((index) << (32-as. 
                
            
            
            
            
            
               
            )) | ((index) << as. 
                
            
            
            
            
            
               
            ));
                6 = 6 & ((IP) >> 1);
                6 = 6 & ((IP) >> 1);
                6 = 6 & (((index) << (32-as. 
                
            
            
            
            
            
               
            )) | ((index) << as. 
                
            
            
            
            
            
               
            ));
                6 = 6 & (((index) << (32-as. 
                
            
            
            
            
            
               
            )) | ((index) << as. 
                
            
            
            
            
            
               
            ));
                6 = 6 & (((index) << (32-as. 
                
            
            
            
            
            
               
            )) | ((index) << as. 
                
            
            
            
            
            
               
            ));
                6 = 6 & (((index) << (32-as. 
                
            
            
            
            
            
               
            )) | ((index) << as. 
                
            
            
            
            
            
               
            ));
                6 = 6 & (((index) << (32-as. 
                
            
            
            
            
            
               
            )) | ((index) << as. 
                
            
            
            
            
            
               
            ));
                6 = 6 & (((index) << (32-as. 
                
            
            
            
            
            
               
            )) | ((index) << as. 
                
            
            
            
            
            
               
            ));
                6 = 6 & (((index) << (32-as. 
                
            
            
            
            
            
               
            )) | ((index) << as. 
                
            
            
            
            
            
               
            ));
                6 = 6 & (((index) << (32-as. 
                
            
            
            
            
            
               
            )) | ((index) << as. 
                
            
            
            
            
            
               
            ));
                6 = 6 & (((index) << (32-as. 
                
            
            
            
            
            
               
            )) | ((index) << as. 
                
            
            
            
            
            
               
            ));
                6 = 6 & (((index) << (32-as. 
                
            
            
            
            
            
               
            )) | ((index) << as. 
                
            
            
            
            
            
               
            ));
                6 = 6 & (((R8) << (32-R3)) | ((R8) << R3));
            }
            
            return;
            label_3:
            if(val_14 == ']')
            {
                    return;
            }
            
            if(val_14 == '{')
            {
                    return;
            }
            
            if(val_14 != '}')
            {
                goto label_8;
            }
            
            return;
            label_4:
            if(val_14 == '[')
            {
                    return;
            }
            
            label_8:
            val_15 = index - 1;
            index = val_15;
            int val_4 = index - val_15;
            if(val_4 < 5)
            {
                    if(val_4 != 4)
            {
                    return;
            }
            
            }
            else
            {
                    if((json[val_15 << 1]) == 'f')
            {
                    val_15 = index + 1;
                if((json[val_15 << 1]) == 'a')
            {
                    if((json[(index + 2) << 1]) == 'l')
            {
                    if((json[(index + 3) << 1]) == 's')
            {
                    if((json[(index + 4) << 1]) == 'e')
            {
                    int val_21 = index;
                val_21 = val_21 + 5;
                index = val_21;
                return;
            }
            
            }
            
            }
            
            }
            
            }
            
            }
            
            if((json[index << 1]) == 't')
            {
                    if((json[(index + 1) << 1]) == 'r')
            {
                    if((json[(index + 2) << 1]) == 'u')
            {
                    if((json[(index + 3) << 1]) == 'e')
            {
                    int val_26 = index;
                val_26 = val_26 + 4;
                index = val_26;
                return;
            }
            
            }
            
            }
            
            }
            
            if((json[index << 1]) != 'n')
            {
                    return;
            }
            
            if((json[(index + 1) << 1]) != 'u')
            {
                    return;
            }
            
            if((json[(index + 2) << 1]) != 'l')
            {
                    return;
            }
            
            if((json[(index + 3) << 1]) != 'l')
            {
                    return;
            }
            
            int val_31 = index;
            val_31 = val_31 + 4;
            index = val_31;
        }
    
    }

}
