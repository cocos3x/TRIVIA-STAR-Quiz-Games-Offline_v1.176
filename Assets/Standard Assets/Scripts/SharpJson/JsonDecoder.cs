using UnityEngine;

namespace SharpJson
{
    public class JsonDecoder
    {
        // Fields
        private string <errorMessage>k__BackingField;
        private bool <parseNumbersAsFloat>k__BackingField;
        private SharpJson.Lexer lexer;
        
        // Properties
        public string errorMessage { get; set; }
        public bool parseNumbersAsFloat { get; set; }
        
        // Methods
        public string get_errorMessage()
        {
        
        }
        private void set_errorMessage(string value)
        {
            this.<errorMessage>k__BackingField = value;
        }
        public bool get_parseNumbersAsFloat()
        {
            return (bool)this.<parseNumbersAsFloat>k__BackingField;
        }
        public void set_parseNumbersAsFloat(bool value)
        {
            this.<parseNumbersAsFloat>k__BackingField = value;
        }
        public JsonDecoder()
        {
            this.<parseNumbersAsFloat>k__BackingField = false;
            this.<errorMessage>k__BackingField = false;
        }
        public object Decode(string text)
        {
            this.<errorMessage>k__BackingField = 0;
            this.lexer = new SharpJson.Lexer(text:  text);
            typeof(SharpJson.Lexer).__il2cppRuntimeField_C = this.<parseNumbersAsFloat>k__BackingField;
            return this.ParseValue();
        }
        public static object DecodeText(string text)
        {
            typeof(SharpJson.JsonDecoder).__il2cppRuntimeField_C = 0;
            typeof(SharpJson.JsonDecoder).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    return Decode(text:  text);
            }
            
            return Decode(text:  text);
        }
        private System.Collections.Generic.IDictionary<string, object> ParseObject()
        {
            var val_15;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.lexer.SkipWhiteSpaces();
            Token val_3 = SharpJson.Lexer.NextToken(json:  this.lexer.json, index: ref  this.lexer.index);
            goto label_9;
            label_14:
            string val_4 = this.lexer.ParseString();
            string val_5 = this.EvalLexer<System.String>(value:  this.lexer);
            if((this.<errorMessage>k__BackingField) != null)
            {
                    return;
            }
            
            this.lexer.SkipWhiteSpaces();
            Token val_7 = SharpJson.Lexer.NextToken(json:  this.lexer.json, index: ref  this.lexer.index);
            if(this.lexer.json != 4)
            {
                goto label_6;
            }
            
            object val_8 = this.ParseValue();
            if((this.<errorMessage>k__BackingField) != null)
            {
                    return;
            }
            
            set_Item(key:  1840943408, value:  1840943408);
            goto label_9;
            label_12:
            this.lexer.SkipWhiteSpaces();
            Token val_10 = SharpJson.Lexer.NextToken(json:  this.lexer.json, index: ref  this.lexer.index);
            label_9:
            this.lexer.SkipWhiteSpaces();
            Token val_12 = SharpJson.Lexer.NextToken(json:  this.lexer.json, index: ref  int val_11 = 1840931368);
            if(this.lexer.json == 5)
            {
                goto label_12;
            }
            
            if(this.lexer.json == 9)
            {
                goto label_13;
            }
            
            if(this.lexer.json != null)
            {
                goto label_14;
            }
            
            this.TriggerError(message:  1840878224);
            val_15 = 0;
            return;
            label_13:
            this.lexer.SkipWhiteSpaces();
            Token val_14 = SharpJson.Lexer.NextToken(json:  this.lexer.json, index: ref  this.lexer.index);
            val_15 = null;
            return;
            label_6:
            this.TriggerError(message:  1840919280);
        }
        private System.Collections.Generic.IList<object> ParseArray()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_11;
            SharpJson.Lexer val_12;
            val_11 = null;
            val_11 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.lexer.SkipWhiteSpaces();
            Token val_3 = SharpJson.Lexer.NextToken(json:  this.lexer.json, index: ref  this.lexer.index);
            goto label_5;
            label_10:
            object val_4 = this.ParseValue();
            val_12 = this;
            if((this.<errorMessage>k__BackingField) != null)
            {
                goto label_3;
            }
            
            Add(item:  1841440432);
            goto label_5;
            label_8:
            this.lexer.SkipWhiteSpaces();
            Token val_6 = SharpJson.Lexer.NextToken(json:  this.lexer.json, index: ref  this.lexer.index);
            label_5:
            val_12 = this.lexer;
            val_12.SkipWhiteSpaces();
            Token val_8 = SharpJson.Lexer.NextToken(json:  this.lexer.json, index: ref  int val_7 = 1841428396);
            if(this.lexer.json == 5)
            {
                goto label_8;
            }
            
            if(this.lexer.json == 11)
            {
                goto label_9;
            }
            
            if(this.lexer.json != null)
            {
                goto label_10;
            }
            
            this.TriggerError(message:  1840878224);
            label_3:
            val_11 = 0;
            return;
            label_9:
            this.lexer.SkipWhiteSpaces();
            Token val_10 = SharpJson.Lexer.NextToken(json:  this.lexer.json, index: ref  this.lexer.index);
        }
        private object ParseValue()
        {
            this.lexer.SkipWhiteSpaces();
            System.Char[] val_18 = this.lexer.json;
            Token val_2 = SharpJson.Lexer.NextToken(json:  val_18, index: ref  int val_1 = 1841837472);
            val_18 = val_18 - 1;
            if(val_18 <= 9)
            {
                    var val_3 = 20377596 + (20377596 + ((this.lexer.json - 1)) << 2);
                if(val_18 == 9)
            {
                    20377596 + ((this.lexer.json - 1)) << 2 = (20377596 + ((this.lexer.json - 1)) << 2) & ((R8) >> 32);
                20377596 + ((this.lexer.json - 1)) << 2 = (20377596 + ((this.lexer.json - 1)) << 2) & ((20377596 + ((this.lexer.json - 1)) << 2) >> (20377596 + ((this.lexer.json - 1)) << 2));
                20377596 + ((this.lexer.json - 1)) << 2 = (20377596 + ((this.lexer.json - 1)) << 2) & 3683699008;
                20377596 + ((this.lexer.json - 1)) << 2 = (20377596 + ((this.lexer.json - 1)) << 2) & 920924752;
                20377596 + ((this.lexer.json - 1)) << 2 = (20377596 + ((this.lexer.json - 1)) << 2) & 920924752;
                20377596 + ((this.lexer.json - 1)) << 2 = (20377596 + ((this.lexer.json - 1)) << 2) & ((((((((20377596 + ((this.lexer.json - 1)) << 2 & (R8) >> 32) & ((int)(20377596 + ((this.lexer.json - 1)) << 2 & (R8) >> 32)) >> (20377596 + ((this.lexer.json - 1)) << 2 & (R8) >> 32)) & 3683699008) & 92) << (32-1)) | (((((((20377596 + ((this.lexer.json - 1)) << 2 & (R8) >> 32) & ((int)(20377596 + ((this.lexer.json - 1)) << 2 & (R8) >> 32)) >> (20377596 + ((this.lexer.json - 1)) << 2 & (R8) >> 32)) & 3683699008) & 92) << 1));
                20377596 + ((this.lexer.json - 1)) << 2 = (20377596 + ((this.lexer.json - 1)) << 2) & 1841849504;
                20377596 + ((this.lexer.json - 1)) << 2 = (20377596 + ((this.lexer.json - 1)) << 2) & ((((((((((20377596 + ((this.lexer.json - 1)) << 2 & (R8) >> 32) & ((int)(20377596 + ((this.lexer.json - 1)) << 2 & (R8) >> 32)) >> (20377596 + ((this.lexer.json - 1)) << 2 & (R8) >> 32)) & 3683699008) & ) << (32-2)) | (((((((((20377596 + ((this.lexer.json - 1)) << 2 & (R8) >> 32) & ((int)(20377596 + ((this.lexer.json - 1)) << 2 & (R8) >> 32)) >> (20377596 + ((this.lexer.json - 1)) << 2 & (R8) >> 32)) & 3683699008) & ) << 2));
                20377596 + ((this.lexer.json - 1)) << 2 = (20377596 + ((this.lexer.json - 1)) << 2) & 920924752;
                20377596 + ((this.lexer.json - 1)) << 2 = (20377596 + ((this.lexer.json - 1)) << 2) & (((IP) << (32-2)) | ((IP) << 2));
            }
            
                this.lexer.SkipWhiteSpaces();
                Token val_5 = SharpJson.Lexer.NextToken(json:  this.lexer.json, index: ref  this.lexer.index);
                return;
            }
            
            this.TriggerError(message:  1841815152);
        }
        private void TriggerError(string message)
        {
            string val_1 = System.String.Format(format:  1842072672, arg0:  message, arg1:  13152256);
            this.<errorMessage>k__BackingField = "Error: \'{0}\' at line {1}";
        }
        private T EvalLexer<T>(T value)
        {
            if(this.lexer.hasError == false)
            {
                    return (double)value;
            }
            
            this.TriggerError(message:  1842197088);
            return (double)value;
        }
    
    }

}
