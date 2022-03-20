using UnityEngine;

namespace LitJson
{
    public class JsonReader
    {
        // Fields
        private static System.Collections.Generic.IDictionary<int, System.Collections.Generic.IDictionary<int, int[]>> parse_table;
        private System.Collections.Generic.Stack<int> automaton_stack;
        private int current_input;
        private int current_symbol;
        private bool end_of_json;
        private bool end_of_input;
        private LitJson.Lexer lexer;
        private bool parser_in_string;
        private bool parser_return;
        private bool read_started;
        private System.IO.TextReader reader;
        private bool reader_is_owned;
        private bool skip_non_members;
        private object token_value;
        private LitJson.JsonToken token;
        
        // Properties
        public bool AllowComments { get; set; }
        public bool AllowSingleQuotedStrings { get; set; }
        public bool SkipNonMembers { get; set; }
        public bool EndOfInput { get; }
        public bool EndOfJson { get; }
        public LitJson.JsonToken Token { get; }
        public object Value { get; }
        
        // Methods
        public bool get_AllowComments()
        {
            if(this.lexer != 0)
            {
                    return (bool)this.lexer.allow_comments;
            }
            
            return (bool)this.lexer.allow_comments;
        }
        public void set_AllowComments(bool value)
        {
            this.lexer.allow_comments = value;
        }
        public bool get_AllowSingleQuotedStrings()
        {
            if(this.lexer != 0)
            {
                    return (bool)this.lexer.allow_single_quoted_strings;
            }
            
            return (bool)this.lexer.allow_single_quoted_strings;
        }
        public void set_AllowSingleQuotedStrings(bool value)
        {
            this.lexer.allow_single_quoted_strings = value;
        }
        public bool get_SkipNonMembers()
        {
            return (bool)this.skip_non_members;
        }
        public void set_SkipNonMembers(bool value)
        {
            this.skip_non_members = value;
        }
        public bool get_EndOfInput()
        {
            return (bool)this.end_of_input;
        }
        public bool get_EndOfJson()
        {
            return (bool)this.end_of_json;
        }
        public LitJson.JsonToken get_Token()
        {
        
        }
        public object get_Value()
        {
        
        }
        private static JsonReader()
        {
            LitJson.JsonReader.PopulateParseTable();
        }
        public JsonReader(string json_text)
        {
            System.IO.StringReader val_1 = new System.IO.StringReader(s:  json_text);
        }
        public JsonReader(System.IO.TextReader reader)
        {
        
        }
        private JsonReader(System.IO.TextReader reader, bool owned)
        {
            if(reader != 0)
            {
                    this.read_started = false;
                this.parser_in_string = false;
                this.parser_return = false;
                System.Collections.Generic.Stack<System.Int32> val_1 = new System.Collections.Generic.Stack<System.Int32>();
                this.automaton_stack = null;
                Push(item:  65553);
                this.automaton_stack.Push(item:  65543);
                this.lexer = new LitJson.Lexer(reader:  reader);
                this.end_of_json = false;
                this.end_of_input = false;
                this.skip_non_members = true;
                this.reader = reader;
                this.reader_is_owned = owned;
                return;
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  1312665440);
        }
        private static void PopulateParseTable()
        {
            var val_2;
            System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_1 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
            val_2 = null;
            val_2 = null;
            LitJson.JsonReader.parse_table = null;
            LitJson.ParserToken val_14 = 65537;
            LitJson.JsonReader.TableAddRow(rule:  65548);
            typeof(System.Int32[]).__il2cppRuntimeField_10 = 91;
            LitJson.ParserToken val_2 = val_14 + 12;
            typeof(System.Int32[]).__il2cppRuntimeField_14 = val_2;
            LitJson.JsonReader.TableAddCol(row:  65548, col:  91, symbols:  478302960);
            LitJson.JsonReader.TableAddRow(rule:  val_2);
            LitJson.JsonReader.TableAddCol(row:  val_2, col:  34, symbols:  478302960);
            LitJson.JsonReader.TableAddCol(row:  val_2, col:  91, symbols:  478302960);
            typeof(System.Int32[]).__il2cppRuntimeField_10 = 93;
            LitJson.JsonReader.TableAddCol(row:  val_2, col:  93, symbols:  478302960);
            LitJson.JsonReader.TableAddCol(row:  val_2, col:  123, symbols:  478302960);
            LitJson.JsonReader.TableAddCol(row:  val_2, col:  65537, symbols:  478302960);
            int val_3 = val_14 + 1;
            LitJson.JsonReader.TableAddCol(row:  val_2, col:  val_3, symbols:  478302960);
            int val_4 = val_14 + 2;
            LitJson.JsonReader.TableAddCol(row:  val_2, col:  val_4, symbols:  478302960);
            int val_5 = val_14 + 3;
            LitJson.JsonReader.TableAddCol(row:  val_2, col:  val_5, symbols:  478302960);
            LitJson.ParserToken val_6 = val_14 + 7;
            LitJson.JsonReader.TableAddRow(rule:  val_6);
            typeof(System.Int32[]).__il2cppRuntimeField_10 = 123;
            LitJson.ParserToken val_7 = val_14 + 8;
            typeof(System.Int32[]).__il2cppRuntimeField_14 = val_7;
            LitJson.JsonReader.TableAddCol(row:  val_6, col:  123, symbols:  478302960);
            LitJson.JsonReader.TableAddRow(rule:  val_7);
            LitJson.JsonReader.TableAddCol(row:  val_7, col:  34, symbols:  478302960);
            typeof(System.Int32[]).__il2cppRuntimeField_10 = 125;
            LitJson.JsonReader.TableAddCol(row:  val_7, col:  125, symbols:  478302960);
            LitJson.ParserToken val_8 = val_14 + 9;
            LitJson.JsonReader.TableAddRow(rule:  val_8);
            LitJson.JsonReader.TableAddCol(row:  val_8, col:  34, symbols:  478302960);
            LitJson.ParserToken val_9 = val_14 + 10;
            LitJson.JsonReader.TableAddRow(rule:  val_9);
            LitJson.JsonReader.TableAddCol(row:  val_9, col:  44, symbols:  478302960);
            var val_10 = val_14 + 17;
            typeof(System.Int32[]).__il2cppRuntimeField_10 = val_10;
            LitJson.JsonReader.TableAddCol(row:  val_9, col:  125, symbols:  478302960);
            LitJson.ParserToken val_11 = val_14 + 15;
            LitJson.JsonReader.TableAddRow(rule:  val_11);
            LitJson.JsonReader.TableAddCol(row:  val_11, col:  34, symbols:  478302960);
            LitJson.ParserToken val_12 = val_14 + 6;
            LitJson.JsonReader.TableAddRow(rule:  val_12);
            typeof(System.Int32[]).__il2cppRuntimeField_10 = 65548;
            LitJson.JsonReader.TableAddCol(row:  val_12, col:  91, symbols:  478302960);
            typeof(System.Int32[]).__il2cppRuntimeField_10 = val_6;
            LitJson.JsonReader.TableAddCol(row:  val_12, col:  123, symbols:  478302960);
            LitJson.ParserToken val_13 = val_14 + 13;
            LitJson.JsonReader.TableAddRow(rule:  val_13);
            typeof(System.Int32[]).__il2cppRuntimeField_10 = val_11;
            LitJson.JsonReader.TableAddCol(row:  val_13, col:  34, symbols:  478302960);
            typeof(System.Int32[]).__il2cppRuntimeField_10 = 65548;
            LitJson.JsonReader.TableAddCol(row:  val_13, col:  91, symbols:  478302960);
            typeof(System.Int32[]).__il2cppRuntimeField_10 = val_6;
            LitJson.JsonReader.TableAddCol(row:  val_13, col:  123, symbols:  478302960);
            typeof(System.Int32[]).__il2cppRuntimeField_10 = val_14;
            LitJson.JsonReader.TableAddCol(row:  val_13, col:  65537, symbols:  478302960);
            typeof(System.Int32[]).__il2cppRuntimeField_10 = val_3;
            LitJson.JsonReader.TableAddCol(row:  val_13, col:  val_3, symbols:  478302960);
            typeof(System.Int32[]).__il2cppRuntimeField_10 = val_4;
            LitJson.JsonReader.TableAddCol(row:  val_13, col:  val_4, symbols:  478302960);
            typeof(System.Int32[]).__il2cppRuntimeField_10 = val_5;
            LitJson.JsonReader.TableAddCol(row:  val_13, col:  val_5, symbols:  478302960);
            val_14 = val_14 + 14;
            LitJson.JsonReader.TableAddRow(rule:  val_14);
            LitJson.JsonReader.TableAddCol(row:  val_14, col:  44, symbols:  478302960);
            typeof(System.Int32[]).__il2cppRuntimeField_10 = val_10;
            LitJson.JsonReader.TableAddCol(row:  val_14, col:  93, symbols:  478302960);
        }
        private static void TableAddCol(LitJson.ParserToken row, int col, int[] symbols)
        {
            var val_3;
            System.Collections.Generic.IDictionary<System.Int32, System.Collections.Generic.IDictionary<System.Int32, System.Int32[]>> val_4;
            var val_5;
            var val_6;
            val_3 = null;
            val_3 = null;
            val_4 = LitJson.JsonReader.parse_table;
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_5 = val_4;
            val_4 = 0;
            val_4 = val_4 + 1;
            val_6 = val_4;
            goto mem[(parse_table + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        private static void TableAddRow(LitJson.ParserToken rule)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_1 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
            var val_3 = 0;
            val_4 = 0;
            val_3 = val_3 + 1;
            val_4 = (uint)val_3 & 65535;
            val_5 = LitJson.JsonReader.parse_table;
            goto mem[(parse_table + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        private void ProcessNumber(string number)
        {
            var val_10;
            object val_11;
            var val_12;
            var val_13;
            val_10 = 35642047;
            if((number.IndexOf(value:  '.')) == 1)
            {
                    if((number.IndexOf(value:  'e')) == 1)
            {
                    if((number.IndexOf(value:  'E')) == 1)
            {
                goto label_9;
            }
            
            }
            
            }
            
            val_10 = 1152921504617336832;
            if((System.Double.TryParse(s:  number, result: out  double val_4 = 1.02987190999059E-314)) != false)
            {
                    this.token = 8;
                val_11 = null;
            }
            else
            {
                    label_9:
                if((System.Int32.TryParse(s:  number, result: out  int val_6 = 2084483972)) != false)
            {
                    this.token = 6;
                val_12 = 0;
                val_13 = 1152921504619999232;
            }
            else
            {
                    val_10 = 0;
                if((System.Int64.TryParse(s:  number, result: out  long val_8 = 2084483960)) != false)
            {
                    this.token = 7;
                val_12 = 0;
                val_13 = 1152921504620052480;
            }
            else
            {
                    this.token = 6;
                val_11 = null;
            }
            
            }
            
            }
            
            this.token_value = val_11;
        }
        private void ProcessSymbol()
        {
            bool val_2;
            if(this.current_symbol <= 122)
            {
                goto label_1;
            }
            
            var val_2 = 65536;
            val_2 = this.current_symbol + val_2;
            if(val_2 > 9)
            {
                goto label_2;
            }
            
            var val_1 = 14612004 + (14612004 + ((this.current_symbol + 65536)) << 2);
            if(val_2 == 9)
            {
                    14612004 = 14612004 & ((R8) >> 32);
                mem2[0] = (14612004 & (R8) >> 32) + this;
                ((14612004 & (R8) >> 32) + this) & 1042316288 = (((14612004 & (R8) >> 32) + this) & 1042316288) & ((R8) << 14612004 + ((this.current_symbol + 65536)) << 2);
                ((14612004 & (R8) >> 32) + this) & 1042316288 = (((14612004 & (R8) >> 32) + this) & 1042316288) & ((R8) >> 2);
                ((14612004 & (R8) >> 32) + this) & 1042316288 = (((14612004 & (R8) >> 32) + this) & 1042316288) & (((int)R8) >> 14612004 + ((this.current_symbol + 65536)) << 2);
                ((14612004 & (R8) >> 32) + this) & 1042316288 = (((14612004 & (R8) >> 32) + this) & 1042316288) & (((int)R8) >> 14612004 + ((this.current_symbol + 65536)) << 2);
                ((14612004 & (R8) >> 32) + this) & 1042316288 = (((14612004 & (R8) >> 32) + this) & 1042316288) & (((int)R8) >> 14612004 + ((this.current_symbol + 65536)) << 2);
                ((14612004 & (R8) >> 32) + this) & 1042316288 = (((14612004 & (R8) >> 32) + this) & 1042316288) & (((int)R8) >> 14612004 + ((this.current_symbol + 65536)) << 2);
                ((14612004 & (R8) >> 32) + this) & 1042316288 = (((14612004 & (R8) >> 32) + this) & 1042316288) & 521158144;
            }
            
            this.ProcessNumber(number:  this.lexer.string_value);
            goto label_4;
            label_1:
            if(this.current_symbol == 34)
            {
                goto label_5;
            }
            
            if(this.current_symbol == 91)
            {
                goto label_6;
            }
            
            if(this.current_symbol == 93)
            {
                    this.current_symbol = true;
                this.parser_return = this.current_symbol;
                this.current_symbol = 5;
            }
            
            goto label_7;
            label_2:
            if(this.current_symbol == 123)
            {
                goto label_8;
            }
            
            if(this.current_symbol == 125)
            {
                    this.current_symbol = true;
                this.parser_return = this.current_symbol;
                this.current_symbol = 3;
                label_7:
                this.token = this.current_symbol;
            }
            
            return;
            label_5:
            if(this.parser_in_string == false)
            {
                goto label_10;
            }
            
            this.parser_in_string = true;
            this.parser_return = true;
            return;
            label_6:
            this.parser_return = true;
            val_2 = 4;
            goto label_18;
            label_4:
            this.parser_return = true;
            return;
            label_8:
            val_2 = true;
            this.parser_return = val_2;
            label_18:
            this.token = val_2;
            return;
            label_10:
            if(this.token == 0)
            {
                    this.token = 9;
                this.token = this.token;
            }
            
            this.parser_in_string = true;
        }
        private bool ReadToken()
        {
            if(this.end_of_input == true)
            {
                    return (bool)0;
            }
            
            bool val_1 = this.lexer.NextToken();
            if(this.lexer.end_of_input != false)
            {
                    this.Close();
                return (bool)0;
            }
            
            0 = 1;
            this.current_input = this.lexer.token;
            return (bool)0;
        }
        public void Close()
        {
            if(this.end_of_input == true)
            {
                    return;
            }
            
            mem2[0] = 257;
            mem2[0] = 0;
        }
        public bool Read()
        {
            bool val_14;
            int val_15;
            var val_16;
            int val_17;
            System.Collections.Generic.IDictionary<System.Int32, System.Collections.Generic.IDictionary<System.Int32, System.Int32[]>> val_18;
            var val_19;
            int val_20;
            var val_21;
            var val_22;
            var val_23;
            LitJson.JsonException val_24;
            val_14 = 0;
            if(this.end_of_input == true)
            {
                    return true;
            }
            
            if(this.end_of_json != false)
            {
                    this.end_of_json = false;
                this.automaton_stack.Clear();
                this.automaton_stack.Push(item:  65553);
                this.automaton_stack.Push(item:  65553 - 10);
            }
            
            val_14 = false;
            this.parser_in_string = val_14;
            this.parser_return = false;
            this.token_value = val_14;
            this.token = val_14;
            if(this.read_started == true)
            {
                goto label_27;
            }
            
            this.read_started = true;
            if(this.ReadToken() == false)
            {
                    return true;
            }
            
            goto label_27;
            label_33:
            this.current_symbol = val_14.Pop();
            this.ProcessSymbol();
            val_15 = this.current_symbol;
            if(val_15 != this.current_input)
            {
                goto label_9;
            }
            
            if(this.ReadToken() == true)
            {
                goto label_27;
            }
            
            goto label_11;
            label_9:
            val_16 = null;
            val_17 = this.current_symbol;
            val_16 = null;
            val_18 = LitJson.JsonReader.parse_table;
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_19 = val_18;
            val_20 = this.current_input;
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_21 = val_18;
            if((LitJson.JsonReader.parse_table + 16) == 65554)
            {
                goto label_27;
            }
            
            val_22 = mem[LitJson.JsonReader.parse_table + 12];
            val_22 = LitJson.JsonReader.parse_table + 12;
            if((val_22 - 1) < 0)
            {
                goto label_27;
            }
            
            val_20 = val_22 + 3;
            goto label_28;
            label_31:
            val_22 = mem[LitJson.JsonReader.parse_table + 12];
            val_22 = LitJson.JsonReader.parse_table + 12;
            val_20 = val_20 - 1;
            label_28:
            val_18 = this.automaton_stack;
            var val_8 = val_20 - 4;
            val_18.Push(item:  80404480);
            if((val_20 - 5) >= 0)
            {
                goto label_31;
            }
            
            label_27:
            if(this.parser_return == false)
            {
                goto label_33;
            }
            
            if(this.automaton_stack.Peek() == 65553)
            {
                    true = true;
                this.end_of_json = true;
            }
            
            return true;
            label_11:
            if(this.automaton_stack.Peek() == 65553)
            {
                    if(this.parser_return == true)
            {
                    val_14 = 1;
            }
            
                return true;
            }
            
            LitJson.JsonException val_12 = new LitJson.JsonException(message:  2085017280);
            val_23 = null;
            if((public System.Boolean LitJson.JsonReader::Read()) == 1)
            {
                    val_24 = val_23;
                if(null != 0)
            {
                    LitJson.JsonException val_13 = null;
                val_24 = val_13;
                val_13 = new LitJson.JsonException(token:  this.current_input, inner_exception:  null);
            }
            
                mem[4] = val_24;
                val_23 = 4;
            }
        
        }
    
    }

}
