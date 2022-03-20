using UnityEngine;

namespace LitJson
{
    public class JsonWriter
    {
        // Fields
        private static System.Globalization.NumberFormatInfo number_format;
        private LitJson.WriterContext context;
        private System.Collections.Generic.Stack<LitJson.WriterContext> ctx_stack;
        private bool has_reached_end;
        private char[] hex_seq;
        private int indentation;
        private int indent_value;
        private System.Text.StringBuilder inst_string_builder;
        private bool pretty_print;
        private bool validate;
        private System.IO.TextWriter writer;
        
        // Properties
        public int IndentValue { get; set; }
        public bool PrettyPrint { get; set; }
        public System.IO.TextWriter TextWriter { get; }
        public bool Validate { get; set; }
        
        // Methods
        public int get_IndentValue()
        {
            return (int)this.indent_value;
        }
        public void set_IndentValue(int value)
        {
            int val_1 = this.indentation;
            val_1 = val_1 * value;
            this.indentation = val_1;
            this.indent_value = value;
        }
        public bool get_PrettyPrint()
        {
            return (bool)this.pretty_print;
        }
        public void set_PrettyPrint(bool value)
        {
            this.pretty_print = value;
        }
        public System.IO.TextWriter get_TextWriter()
        {
        
        }
        public bool get_Validate()
        {
            return (bool)this.validate;
        }
        public void set_Validate(bool value)
        {
            this.validate = value;
        }
        private static JsonWriter()
        {
            System.Globalization.NumberFormatInfo val_1 = System.Globalization.NumberFormatInfo.InvariantInfo;
            LitJson.JsonWriter.number_format = 0;
        }
        public JsonWriter()
        {
            this.inst_string_builder = new System.Text.StringBuilder();
            this.writer = new System.IO.StringWriter(sb:  24121344);
            this.Init();
        }
        public JsonWriter(System.Text.StringBuilder sb)
        {
            System.IO.StringWriter val_1 = new System.IO.StringWriter(sb:  sb);
        }
        public JsonWriter(System.IO.TextWriter writer)
        {
            if(writer != 0)
            {
                    this.writer = writer;
                this.Init();
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  1348190896);
        }
        private void DoValidation(LitJson.Condition cond)
        {
            LitJson.WriterContext val_4;
            int val_5;
            var val_6;
            LitJson.JsonException val_7;
            var val_8;
            val_4 = this.context;
            if(this.context.ExpectingValue != true)
            {
                    val_4 = this.context;
                if(val_4 != 0)
            {
                    val_5 = this.context.Count;
            }
            else
            {
                    val_4 = 8;
                val_5 = 0;
            }
            
                mem[8] = 1;
            }
            
            if(this.validate == false)
            {
                    return;
            }
            
            if(this.has_reached_end != true)
            {
                    if(cond > 4)
            {
                    return;
            }
            
                val_6 = 14614000 + (14614000 + (cond) << 2);
                if(cond == 4)
            {
                    14614000 = 14614000 & 2086566848;
                14614000 = this * (14614000 + (cond) << 2);
                14614000 = 14614000 & 1043283424;
                14614000 = 14614000 & ((IP) >> 14614000 + (cond) << 2);
                14614000 = 14614000 & (14614000 >> 14614000);
            }
            
                if(this.context.InArray == true)
            {
                    return;
            }
            
                val_7 = null;
                val_8 = "Can\'t close an array here";
            }
            
            label_31:
             = new LitJson.JsonException(message:  2086541152);
            goto label_31;
        }
        private void Init()
        {
            this.has_reached_end = false;
            this.pretty_print = true;
            this.validate = true;
            System.Collections.Generic.Stack<com.adjust.sdk.JSONNode> val_1 = new System.Collections.Generic.Stack<com.adjust.sdk.JSONNode>();
            this.ctx_stack = null;
            this.context = new LitJson.WriterContext();
            this.ctx_stack.Push(item:  272097280);
        }
        private static void IntToHex(int n, char[] hex)
        {
            int val_3 = n;
            var val_2 = 3;
            do
            {
                n = val_3 >> 31;
                n = val_3 + (n >> 28);
                n = n & (~15);
                int val_1 = val_3 - n;
                if(val_1 > 9)
            {
                    val_1 = val_1 + 55;
            }
            
                if(val_1 <= 9)
            {
                    val_1 = val_1 + 48;
            }
            
                val_2 = val_2 - 1;
                mem2[0] = val_1;
                val_3 = val_3 >> 4;
            }
            while(val_2 != 1);
        
        }
        private void Indent()
        {
            if(this.pretty_print == true)
            {
                    this.pretty_print = this.indentation;
                this.pretty_print = this.indent_value + this.pretty_print;
                this.indentation = this.pretty_print;
            }
        
        }
        private void Put(string str)
        {
            LitJson.WriterContext val_1;
            if(this.pretty_print != false)
            {
                    val_1 = this.context;
                if((this.context.ExpectingValue != true) && (this.indentation >= 1))
            {
                    var val_1 = 0;
                do
            {
                val_1 = this.writer;
                val_1 = val_1 + 1;
            }
            while(val_1 < this.indentation);
            
            }
            
            }
            
            if(this.writer == 0)
            {
                
            }
        
        }
        private void PutNewline()
        {
            this.PutNewline(add_comma:  true);
        }
        private void PutNewline(bool add_comma)
        {
            if(this.pretty_print == false)
            {
                    return;
            }
            
            if(this.context.ExpectingValue == true)
            {
                    return;
            }
            
            if((R4 + 40) == 0)
            {
                
            }
        
        }
        private void PutString(string str)
        {
            System.IO.TextWriter val_8;
            var val_10;
            System.IO.TextWriter val_11;
            System.Char[] val_12;
            this.Put(str:  System.String.alignConst);
            if(str.m_stringLength < 1)
            {
                goto label_3;
            }
            
            var val_8 = 0;
            label_30:
            char val_1 = str.Chars[0];
            char val_2 = val_1 - 8;
            if(val_2 > '')
            {
                goto label_5;
            }
            
            var val_3 = 14615332 + (14615332 + ((val_1 - 8)) << 2);
            if(val_2 == '')
            {
                    14615332 = 14615332 & 2087639616;
                14615332 = 14615332 & 260954952;
                14615332 = 14615332 & 260954952;
                14615332 = 14615332 & ((IP) >> 1);
                14615332 = 14615332 & 260954952;
                14615332 = 14615332 & ((IP) << 4);
            }
            
            val_8 = this.writer;
            val_10 = "\\b";
            goto label_28;
            label_5:
            if(val_1 != '\')
            {
                goto label_8;
            }
            
            label_16:
            val_11 = this.writer;
            val_12 = str.Chars[0];
            if(val_11 != 0)
            {
                goto label_22;
            }
            
            goto label_22;
            label_8:
            if(str.Chars[0] >= ' ')
            {
                    if(str.Chars[0] <= ('~'))
            {
                goto label_16;
            }
            
            }
            
            LitJson.JsonWriter.IntToHex(n:  str.Chars[0], hex:  this.hex_seq);
            val_11 = this.writer;
            val_12 = this.hex_seq;
            goto label_22;
            label_28:
            label_22:
            val_8 = val_8 + 1;
            if(str.m_stringLength != val_8)
            {
                goto label_30;
            }
            
            label_3:
            if(this.writer == 0)
            {
                
            }
        
        }
        private void Unindent()
        {
            if(this.pretty_print == true)
            {
                    this.pretty_print = this.indentation;
                this.pretty_print = this.pretty_print - this.indent_value;
                this.indentation = this.pretty_print;
            }
        
        }
        public override string ToString()
        {
            if(this.inst_string_builder == 0)
            {
                    return;
            }
            
            goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_D4;
        }
        public void Reset()
        {
            this.has_reached_end = false;
            this.ctx_stack.Clear();
            this.context = new LitJson.WriterContext();
            this.ctx_stack.Push(item:  272097280);
            if(this.inst_string_builder == 0)
            {
                    return;
            }
            
            System.Text.StringBuilder val_3 = this.inst_string_builder.Remove(startIndex:  0, length:  this.inst_string_builder.Length);
        }
        public void Write(bool boolean)
        {
            this.DoValidation(cond:  4);
            this.PutNewline(add_comma:  true);
            if(boolean == true)
            {
                    "false" = "true";
            }
            
            this.Put(str:  1295406192);
            this.context.ExpectingValue = false;
        }
        public void Write(decimal number)
        {
            var val_2;
            this.DoValidation(cond:  4);
            this.PutNewline(add_comma:  true);
            val_2 = null;
            val_2 = null;
            string val_1 = System.Convert.ToString(value:  new System.Decimal() {flags = number.flags, hi = number.hi, lo = number.lo, mid = number.mid}, provider:  LitJson.JsonWriter.number_format);
            this.Put(str:  number.flags);
            this.context.ExpectingValue = false;
        }
        public void Write(double number)
        {
            var val_4;
            this.DoValidation(cond:  4);
            this.PutNewline(add_comma:  true);
            val_4 = null;
            val_4 = null;
            string val_1 = System.Convert.ToString(value:  number, provider:  R2);
            this.Put(str:  R2);
            if((R2.IndexOf(value:  '.')) == 1)
            {
                    int val_3 = R2.IndexOf(value:  'E');
            }
            
            this.context.ExpectingValue = false;
        }
        public void Write(int number)
        {
            var val_2;
            this.DoValidation(cond:  4);
            this.PutNewline(add_comma:  true);
            val_2 = null;
            val_2 = null;
            string val_1 = System.Convert.ToString(value:  number, provider:  LitJson.JsonWriter.number_format);
            this.Put(str:  number);
            this.context.ExpectingValue = false;
        }
        public void Write(long number)
        {
            var val_2;
            this.DoValidation(cond:  4);
            this.PutNewline(add_comma:  true);
            val_2 = null;
            val_2 = null;
            string val_1 = System.Convert.ToString(value:  R2, provider:  LitJson.JsonWriter.number_format);
            this.Put(str:  R2);
            this.context.ExpectingValue = false;
        }
        public void Write(string str)
        {
            this.DoValidation(cond:  4);
            this.PutNewline(add_comma:  true);
            if(str != null)
            {
                    this.PutString(str:  str);
            }
            else
            {
                    this.Put(str:  1295406352);
            }
            
            this.context.ExpectingValue = false;
        }
        public void Write(ulong number)
        {
            var val_2;
            this.DoValidation(cond:  4);
            this.PutNewline(add_comma:  true);
            val_2 = null;
            val_2 = null;
            string val_1 = System.Convert.ToString(value:  R2, provider:  LitJson.JsonWriter.number_format);
            this.Put(str:  R2);
            this.context.ExpectingValue = false;
        }
        public void WriteArrayEnd()
        {
            this.DoValidation(cond:  0);
            this.PutNewline(add_comma:  false);
            LitJson.WriterContext val_1 = this.ctx_stack.Pop();
            if(this.ctx_stack == 1)
            {
                    this.has_reached_end = true;
            }
            else
            {
                    LitJson.WriterContext val_2 = this.ctx_stack.Peek();
                this.context = this.ctx_stack;
                mem2[0] = 0;
            }
            
            if(this.pretty_print == true)
            {
                    this.pretty_print = this.indentation;
                public LitJson.WriterContext System.Collections.Generic.Stack<LitJson.WriterContext>::Peek() = this.indent_value;
                this.pretty_print = this.pretty_print - (public LitJson.WriterContext System.Collections.Generic.Stack<LitJson.WriterContext>::Peek());
                this.indentation = this.pretty_print;
            }
            
            this.Put(str:  1487188992);
        }
        public void WriteArrayStart()
        {
            this.DoValidation(cond:  2);
            this.PutNewline(add_comma:  true);
            this.Put(str:  1466574320);
            this.context = new LitJson.WriterContext();
            typeof(LitJson.WriterContext).__il2cppRuntimeField_C = 1;
            this.ctx_stack.Push(item:  this.context);
            if(this.pretty_print == true)
            {
                    this.pretty_print = this.indentation;
                this.context = this.indent_value;
                this.pretty_print = this.context + this.pretty_print;
                this.indentation = this.pretty_print;
            }
        
        }
        public void WriteObjectEnd()
        {
            this.DoValidation(cond:  1);
            this.PutNewline(add_comma:  false);
            LitJson.WriterContext val_1 = this.ctx_stack.Pop();
            if(this.ctx_stack == 1)
            {
                    this.has_reached_end = true;
            }
            else
            {
                    LitJson.WriterContext val_2 = this.ctx_stack.Peek();
                this.context = this.ctx_stack;
                mem2[0] = 0;
            }
            
            if(this.pretty_print == true)
            {
                    this.pretty_print = this.indentation;
                public LitJson.WriterContext System.Collections.Generic.Stack<LitJson.WriterContext>::Peek() = this.indent_value;
                this.pretty_print = this.pretty_print - (public LitJson.WriterContext System.Collections.Generic.Stack<LitJson.WriterContext>::Peek());
                this.indentation = this.pretty_print;
            }
            
            this.Put(str:  1487337936);
        }
        public void WriteObjectStart()
        {
            this.DoValidation(cond:  2);
            this.PutNewline(add_comma:  true);
            this.Put(str:  1466574400);
            this.context = new LitJson.WriterContext();
            typeof(LitJson.WriterContext).__il2cppRuntimeField_D = 1;
            this.ctx_stack.Push(item:  this.context);
            if(this.pretty_print == true)
            {
                    this.pretty_print = this.indentation;
                this.context = this.indent_value;
                this.pretty_print = this.context + this.pretty_print;
                this.indentation = this.pretty_print;
            }
        
        }
        public void WritePropertyName(string property_name)
        {
            LitJson.WriterContext val_2;
            int val_3;
            var val_4;
            this.DoValidation(cond:  3);
            this.PutNewline(add_comma:  true);
            this.PutString(str:  property_name);
            if(this.pretty_print == false)
            {
                goto label_1;
            }
            
            val_2 = this;
            val_3 = property_name.m_stringLength;
            if(val_3 > this.context.Padding)
            {
                    val_3 = property_name.m_stringLength;
                this.context.Padding = val_3;
            }
            
            val_4 = this.context.Padding - property_name.m_stringLength;
            goto label_7;
            label_9:
            val_4 = val_4 - 1;
            label_7:
            if(val_4 > 1)
            {
                goto label_9;
            }
            
            goto label_10;
            label_1:
            val_2 = this.context;
            label_10:
            mem2[0] = 1;
        }
    
    }

}
