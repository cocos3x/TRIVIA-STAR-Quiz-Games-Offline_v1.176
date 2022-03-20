using UnityEngine;

namespace LitJson
{
    internal class Lexer
    {
        // Fields
        private static int[] fsm_return_table;
        private static LitJson.Lexer.StateHandler[] fsm_handler_table;
        private bool allow_comments;
        private bool allow_single_quoted_strings;
        private bool end_of_input;
        private LitJson.FsmContext fsm_context;
        private int input_buffer;
        private int input_char;
        private System.IO.TextReader reader;
        private int state;
        private System.Text.StringBuilder string_buffer;
        private string string_value;
        private int token;
        private int unichar;
        
        // Properties
        public bool AllowComments { get; set; }
        public bool AllowSingleQuotedStrings { get; set; }
        public bool EndOfInput { get; }
        public int Token { get; }
        public string StringValue { get; }
        
        // Methods
        public bool get_AllowComments()
        {
            return (bool)this.allow_comments;
        }
        public void set_AllowComments(bool value)
        {
            this.allow_comments = value;
        }
        public bool get_AllowSingleQuotedStrings()
        {
            return (bool)this.allow_single_quoted_strings;
        }
        public void set_AllowSingleQuotedStrings(bool value)
        {
            this.allow_single_quoted_strings = value;
        }
        public bool get_EndOfInput()
        {
            return (bool)this.end_of_input;
        }
        public int get_Token()
        {
            return (int)this.token;
        }
        public string get_StringValue()
        {
        
        }
        private static Lexer()
        {
            LitJson.Lexer.PopulateFsmTables();
        }
        public Lexer(System.IO.TextReader reader)
        {
            this.input_buffer = 0;
            this.allow_comments = true;
            this.allow_single_quoted_strings = true;
            this.end_of_input = 0;
            this.reader = reader;
            this.state = 1;
            this.string_buffer = new System.Text.StringBuilder(capacity:  128);
            this.fsm_context = new System.Object();
            typeof(LitJson.FsmContext).__il2cppRuntimeField_10 = this;
        }
        private static int HexValue(int digit)
        {
            int val_1 = digit - 65;
            if(val_1 <= 5)
            {
                goto label_0;
            }
            
            int val_2 = digit - 97;
            if(val_2 > 5)
            {
                goto label_1;
            }
            
            var val_3 = 14619744 + (14619744 + ((digit - 97)) << 2);
            if(val_2 == 5)
            {
                    15 = 0;
                15 = 15 & (((int)R8) >> 32);
                15 = 15 & (15 >> 15);
                15 = 15 & (((int)R8) >> ((15 & ((int)R8) >> 32) & ((int)(15 & ((int)R8) >> 32)) >> (15 & ((int)R8) >> 32)));
                15 = 15 & ((((((15 & ((int)R8) >> 32) & ((int)(15 & ((int)R8) >> 32)) >> (15 & ((int)R8) >> 32)) & ((int)R8) >> ((15 & ((int)R8) >> 32) & ((int)(15 & ((int)R8) >> 32)) >> (15 & ((int)R8) >> 32)))) << (32-as. 
                
            
            
            
            
            
               
            )) | (((((15 & ((int)R8) >> 32) & ((int)(15 & ((int)R8) >> 32)) >> (15 & ((int)R8) >> 32)) & ((int)R8) >> ((15 & ((int)R8) >> 32) & ((int)(15 & ((int)R8) >> 32)) >> (15 & ((int)R8) >> 32)))) << as. 
                
            
            
            
            
            
               
            ));
                15 = 15 & ((R8) << ((((15 & ((int)R8) >> 32) & ((int)(15 & ((int)R8) >> 32)) >> (15 & ((int)R8) >> 32)) & ((int)R8) >> ((15 & ((int)R8) >> 32) & ((int)(15 & ((int)R8) >> 32)) >> (15 & ((int)R8) >> 32))) & (((((15 & ((in);
            }
            
            return (int)15;
            label_0:
            var val_4 = 14619784 + (14619784 + ((digit - 65)) << 2);
            if(val_1 == 5)
            {
                    15 = 15 & ((R8) << 15);
                15 = 15 & (15 >> 32);
                15 = 15 & ((R8) >> 32);
                15 = 15 & (15 >> 15);
                15 = 15 & ((R8) >> ((((15 & (R8) << 15) & ((15 & (R8) << 15)) >> 32) & (R8) >> 32) & ((((15 & (R8) << 15) & ((15 & (R8) << 15)) >> 32) & (R8) >> 32)) >> (((15 & (R8) << 15) & ((15 & (R8) << 15)) >> 32) & (R8) >> 32)));
            }
        
        }
        private static void PopulateFsmTables()
        {
            var val_29;
            Lexer.StateHandler val_1 = new Lexer.StateHandler(object:  0, method:  new IntPtr(2091007312));
            typeof(StateHandler[]).__il2cppRuntimeField_10 = null;
            Lexer.StateHandler val_2 = new Lexer.StateHandler(object:  0, method:  new IntPtr(2091008336));
            typeof(StateHandler[]).__il2cppRuntimeField_14 = null;
            Lexer.StateHandler val_3 = new Lexer.StateHandler(object:  0, method:  new IntPtr(2091009360));
            typeof(StateHandler[]).__il2cppRuntimeField_18 = null;
            Lexer.StateHandler val_4 = new Lexer.StateHandler(object:  0, method:  new IntPtr(2091010384));
            typeof(StateHandler[]).__il2cppRuntimeField_1C = null;
            Lexer.StateHandler val_5 = new Lexer.StateHandler(object:  0, method:  new IntPtr(2091011408));
            typeof(StateHandler[]).__il2cppRuntimeField_20 = null;
            Lexer.StateHandler val_6 = new Lexer.StateHandler(object:  0, method:  new IntPtr(2091012432));
            typeof(StateHandler[]).__il2cppRuntimeField_24 = null;
            Lexer.StateHandler val_7 = new Lexer.StateHandler(object:  0, method:  new IntPtr(2091013456));
            typeof(StateHandler[]).__il2cppRuntimeField_28 = null;
            Lexer.StateHandler val_8 = new Lexer.StateHandler(object:  0, method:  new IntPtr(2091014480));
            typeof(StateHandler[]).__il2cppRuntimeField_2C = null;
            Lexer.StateHandler val_9 = new Lexer.StateHandler(object:  0, method:  new IntPtr(2091015504));
            typeof(StateHandler[]).__il2cppRuntimeField_30 = null;
            Lexer.StateHandler val_10 = new Lexer.StateHandler(object:  0, method:  new IntPtr(2091016528));
            typeof(StateHandler[]).__il2cppRuntimeField_34 = null;
            Lexer.StateHandler val_11 = new Lexer.StateHandler(object:  0, method:  new IntPtr(2091017552));
            typeof(StateHandler[]).__il2cppRuntimeField_38 = null;
            Lexer.StateHandler val_12 = new Lexer.StateHandler(object:  0, method:  new IntPtr(2091018576));
            typeof(StateHandler[]).__il2cppRuntimeField_3C = null;
            Lexer.StateHandler val_13 = new Lexer.StateHandler(object:  0, method:  new IntPtr(2091019600));
            typeof(StateHandler[]).__il2cppRuntimeField_40 = null;
            Lexer.StateHandler val_14 = new Lexer.StateHandler(object:  0, method:  new IntPtr(2091020624));
            typeof(StateHandler[]).__il2cppRuntimeField_44 = null;
            Lexer.StateHandler val_15 = new Lexer.StateHandler(object:  0, method:  new IntPtr(2091021648));
            typeof(StateHandler[]).__il2cppRuntimeField_48 = null;
            Lexer.StateHandler val_16 = new Lexer.StateHandler(object:  0, method:  new IntPtr(2091022672));
            typeof(StateHandler[]).__il2cppRuntimeField_4C = null;
            Lexer.StateHandler val_17 = new Lexer.StateHandler(object:  0, method:  new IntPtr(2091023696));
            typeof(StateHandler[]).__il2cppRuntimeField_50 = null;
            Lexer.StateHandler val_18 = new Lexer.StateHandler(object:  0, method:  new IntPtr(2091024720));
            typeof(StateHandler[]).__il2cppRuntimeField_54 = null;
            Lexer.StateHandler val_19 = new Lexer.StateHandler(object:  0, method:  new IntPtr(2091025744));
            typeof(StateHandler[]).__il2cppRuntimeField_58 = null;
            Lexer.StateHandler val_20 = new Lexer.StateHandler(object:  0, method:  new IntPtr(2091026768));
            typeof(StateHandler[]).__il2cppRuntimeField_5C = null;
            Lexer.StateHandler val_21 = new Lexer.StateHandler(object:  0, method:  new IntPtr(2091027792));
            typeof(StateHandler[]).__il2cppRuntimeField_60 = null;
            Lexer.StateHandler val_22 = new Lexer.StateHandler(object:  0, method:  new IntPtr(2091028816));
            typeof(StateHandler[]).__il2cppRuntimeField_64 = null;
            Lexer.StateHandler val_23 = new Lexer.StateHandler(object:  0, method:  new IntPtr(2091029840));
            typeof(StateHandler[]).__il2cppRuntimeField_68 = null;
            Lexer.StateHandler val_24 = new Lexer.StateHandler(object:  0, method:  new IntPtr(2091030864));
            typeof(StateHandler[]).__il2cppRuntimeField_6C = null;
            Lexer.StateHandler val_25 = new Lexer.StateHandler(object:  0, method:  new IntPtr(2091031888));
            typeof(StateHandler[]).__il2cppRuntimeField_70 = null;
            Lexer.StateHandler val_26 = new Lexer.StateHandler(object:  0, method:  new IntPtr(2091032912));
            typeof(StateHandler[]).__il2cppRuntimeField_74 = null;
            Lexer.StateHandler val_27 = new Lexer.StateHandler(object:  0, method:  new IntPtr(2091033936));
            typeof(StateHandler[]).__il2cppRuntimeField_78 = null;
            Lexer.StateHandler val_28 = new Lexer.StateHandler(object:  0, method:  new IntPtr(2091034960));
            typeof(StateHandler[]).__il2cppRuntimeField_7C = null;
            val_29 = null;
            val_29 = null;
            LitJson.Lexer.fsm_handler_table = null;
            LitJson.Lexer.fsm_return_table = null;
        }
        private static char ProcessEscChar(int esc_char)
        {
            if(esc_char > 92)
            {
                goto label_1;
            }
            
            if(esc_char > 39)
            {
                goto label_2;
            }
            
            if((esc_char == 34) || (esc_char == 39))
            {
                    return System.Convert.ToChar(value:  esc_char = esc_char);
            }
            
            return 63;
            label_1:
            if(esc_char > 102)
            {
                goto label_6;
            }
            
            if(esc_char == 102)
            {
                    63 = 12;
            }
            
            return 8;
            label_2:
            if(esc_char != 92)
            {
                    return 63;
            }
            
            return System.Convert.ToChar(value:  esc_char);
            label_6:
            if(esc_char == 110)
            {
                    return 10;
            }
            
            if(esc_char == 114)
            {
                    return 13;
            }
            
            if(esc_char != 116)
            {
                    return 63;
            }
            
            return 9;
        }
        private static bool State1(LitJson.FsmContext ctx)
        {
            LitJson.Lexer val_7;
            bool val_8;
            LitJson.Lexer val_9;
            int val_10;
            LitJson.Lexer val_11;
            int val_12;
            label_8:
            val_7 = ctx.L;
            int val_1 = val_7.NextChar();
            ctx.L.input_char = val_1;
            if(val_1 == 1)
            {
                goto label_2;
            }
            
            if(ctx.L.input_char == 32)
            {
                goto label_8;
            }
            
            if(ctx.L.input_char >= 9)
            {
                    if(ctx.L.input_char < 14)
            {
                goto label_8;
            }
            
            }
            
            if(ctx.L.input_char >= 49)
            {
                    if(ctx.L.input_char <= 57)
            {
                goto label_12;
            }
            
            }
            
            if(ctx.L.input_char <= 91)
            {
                goto label_14;
            }
            
            if(ctx.L.input_char <= 110)
            {
                goto label_15;
            }
            
            if(ctx.L.input_char == 116)
            {
                goto label_51;
            }
            
            if(ctx.L.input_char != 123)
            {
                    val_8 = 0;
            }
            
            if(ctx.L.input_char == 125)
            {
                goto label_40;
            }
            
            return val_8;
            label_2:
            val_8 = true;
            ctx.L.end_of_input = val_8;
            return val_8;
            label_14:
            if(ctx.L.input_char <= 39)
            {
                goto label_20;
            }
            
            int val_2 = ctx.L.input_char - 44;
            val_8 = 0;
            if(val_2 > 4)
            {
                goto label_21;
            }
            
            var val_3 = 14620424 + (14620424 + ((ctx.L.input_char - 44)) << 2);
            if(val_2 == 4)
            {
                    14620424 = 14620424 & ((IP) >> 14620424 + ((ctx.L.input_char - 44)) << 2);
                14620424 = 14620424 & (ctx << 14620424);
                14620424 = 14620424 & (((int)IP) >> 14620424 + ((ctx.L.input_char - 44)) << 2);
                14620424 = 14620424 & (14620424 >> 3);
                14620424 = 14620424 & (((ctx) << (32-14620424 + ((ctx.L.input_char - 44)) << 2)) | ((ctx) << 14620424 + ((ctx.L.input_char - 44)) << 2));
            }
            
            val_9 = ctx.L;
            if(ctx.L != 0)
            {
                goto label_22;
            }
            
            val_9 = ctx.L;
            if(val_9 == 0)
            {
                goto label_46;
            }
            
            label_22:
            val_7 = ctx.L.input_char;
            System.Text.StringBuilder val_4 = ctx.L.string_buffer.Append(value:  (uint)val_7 & 65535);
            val_10 = 2;
            goto label_51;
            label_12:
            val_11 = ctx.L;
            if(ctx.L != 0)
            {
                goto label_26;
            }
            
            val_11 = ctx.L;
            if(val_11 == 0)
            {
                goto label_46;
            }
            
            label_26:
            val_7 = ctx.L.input_char;
            System.Text.StringBuilder val_5 = ctx.L.string_buffer.Append(value:  (uint)val_7 & 65535);
            val_10 = 3;
            label_51:
            ctx.NextState = val_10;
            val_8 = 1;
            return val_8;
            label_15:
            if(ctx.L.input_char == 93)
            {
                goto label_40;
            }
            
            if(ctx.L.input_char == 102)
            {
                goto label_51;
            }
            
            val_8 = 0;
            if(ctx.L.input_char != 110)
            {
                    return val_8;
            }
            
            goto label_51;
            label_20:
            if(ctx.L.input_char == 34)
            {
                goto label_34;
            }
            
            val_8 = 0;
            if(ctx.L.input_char != 39)
            {
                    return val_8;
            }
            
            val_7 = ctx.L;
            if(ctx.L.allow_single_quoted_strings == false)
            {
                    return val_8;
            }
            
            ctx.L.input_char = 34;
            val_8 = 1;
            val_12 = 23;
            goto label_39;
            label_21:
            if(ctx.L.input_char != 58)
            {
                    if(ctx.L.input_char != 91)
            {
                    return val_8;
            }
            
            }
            
            label_40:
            val_8 = true;
            ctx.Return = val_8;
            ctx.NextState = val_8;
            return val_8;
            label_34:
            val_8 = true;
            val_12 = 19;
            label_39:
            ctx.Return = val_8;
            ctx.NextState = val_12;
            return val_8;
            label_46:
        }
        private static bool State2(LitJson.FsmContext ctx)
        {
            var val_4;
            LitJson.Lexer val_5;
            int val_6;
            int val_7;
            LitJson.Lexer val_8;
            int val_1 = ctx.L.NextChar();
            ctx.L.input_char = val_1;
            if(val_1 == 1)
            {
                    val_1 = true;
                ctx.L.end_of_input = val_1;
            }
            
            if(ctx.L.input_char >= 49)
            {
                    if(ctx.L.input_char <= 57)
            {
                goto label_5;
            }
            
            }
            
            val_4 = 0;
            if(ctx.L.input_char != 48)
            {
                    return (bool)val_4;
            }
            
            val_5 = ctx.L;
            if(ctx.L != 0)
            {
                goto label_8;
            }
            
            val_5 = ctx.L;
            if(val_5 == 0)
            {
                goto label_13;
            }
            
            label_8:
            val_6 = ctx.L.input_char;
            System.Text.StringBuilder val_2 = ctx.L.string_buffer.Append(value:  (uint)val_6 & 65535);
            val_7 = 4;
            goto label_11;
            label_5:
            val_8 = ctx.L;
            if(ctx.L != 0)
            {
                goto label_12;
            }
            
            val_8 = ctx.L;
            if(val_8 == 0)
            {
                goto label_13;
            }
            
            label_12:
            val_6 = ctx.L.input_char;
            System.Text.StringBuilder val_3 = ctx.L.string_buffer.Append(value:  (uint)val_6 & 65535);
            val_7 = 3;
            label_11:
            ctx.NextState = val_7;
            val_4 = 1;
            return (bool)val_4;
            label_13:
        }
        private static bool State3(LitJson.FsmContext ctx)
        {
            LitJson.Lexer val_5;
            LitJson.Lexer val_6;
            int val_7;
            int val_8;
            LitJson.Lexer val_9;
            goto label_0;
            label_10:
            if((ctx.L.input_char < 48) || (ctx.L.input_char > 57))
            {
                goto label_4;
            }
            
            val_5 = ctx.L;
            if(ctx.L != 0)
            {
                goto label_5;
            }
            
            val_5 = ctx.L;
            if(val_5 == 0)
            {
                goto label_32;
            }
            
            label_5:
            System.Text.StringBuilder val_1 = ctx.L.string_buffer.Append(value:  (uint)ctx.L.input_char & 65535);
            label_0:
            int val_2 = ctx.L.NextChar();
            ctx.L.input_char = val_2;
            if(val_2 != 1)
            {
                goto label_10;
            }
            
            ctx.L.end_of_input = true;
            return true;
            label_4:
            if(ctx.L.input_char == 32)
            {
                goto label_16;
            }
            
            if(ctx.L.input_char >= 9)
            {
                    if(ctx.L.input_char <= 13)
            {
                goto label_16;
            }
            
            }
            
            if(ctx.L.input_char <= 69)
            {
                goto label_18;
            }
            
            if(ctx.L.input_char == 125)
            {
                goto label_23;
            }
            
            if(ctx.L.input_char == 101)
            {
                goto label_20;
            }
            
            if(ctx.L.input_char != 93)
            {
                    return true;
            }
            
            goto label_23;
            label_18:
            if(ctx.L.input_char == 44)
            {
                goto label_23;
            }
            
            if(ctx.L.input_char == 46)
            {
                goto label_24;
            }
            
            if(ctx.L.input_char != 69)
            {
                    return true;
            }
            
            label_20:
            val_6 = ctx.L;
            if(ctx.L != 0)
            {
                goto label_26;
            }
            
            val_6 = ctx.L;
            if(val_6 == 0)
            {
                goto label_32;
            }
            
            label_26:
            val_7 = ctx.L.input_char;
            System.Text.StringBuilder val_3 = ctx.L.string_buffer.Append(value:  (uint)val_7 & 65535);
            val_8 = 7;
            goto label_29;
            label_23:
            ctx.L.input_buffer = ctx.L.input_char;
            label_16:
            ctx.NextState = 1;
            ctx.Return = 1;
            return true;
            label_24:
            val_9 = ctx.L;
            if(ctx.L != 0)
            {
                goto label_31;
            }
            
            val_9 = ctx.L;
            if(val_9 == 0)
            {
                goto label_32;
            }
            
            label_31:
            val_7 = ctx.L.input_char;
            System.Text.StringBuilder val_4 = ctx.L.string_buffer.Append(value:  (uint)val_7 & 65535);
            val_8 = 5;
            label_29:
            ctx.NextState = val_8;
            return true;
            label_32:
        }
        private static bool State4(LitJson.FsmContext ctx)
        {
            var val_4;
            LitJson.Lexer val_5;
            int val_6;
            int val_7;
            LitJson.Lexer val_8;
            int val_1 = ctx.L.NextChar();
            ctx.L.input_char = val_1;
            if(val_1 == 1)
            {
                    val_1 = true;
                ctx.L.end_of_input = val_1;
            }
            
            if(ctx.L.input_char == 32)
            {
                goto label_7;
            }
            
            if(ctx.L.input_char >= 9)
            {
                    if(ctx.L.input_char <= 13)
            {
                goto label_7;
            }
            
            }
            
            if(ctx.L.input_char <= 69)
            {
                goto label_9;
            }
            
            if(ctx.L.input_char == 125)
            {
                goto label_14;
            }
            
            if(ctx.L.input_char == 101)
            {
                goto label_11;
            }
            
            val_4 = 0;
            if(ctx.L.input_char == 93)
            {
                goto label_14;
            }
            
            return (bool)val_4;
            label_9:
            if(ctx.L.input_char == 44)
            {
                goto label_14;
            }
            
            if(ctx.L.input_char == 46)
            {
                goto label_15;
            }
            
            val_4 = 0;
            if(ctx.L.input_char != 69)
            {
                    return (bool)val_4;
            }
            
            label_11:
            val_5 = ctx.L;
            if(ctx.L != 0)
            {
                goto label_17;
            }
            
            val_5 = ctx.L;
            if(val_5 == 0)
            {
                goto label_23;
            }
            
            label_17:
            val_6 = ctx.L.input_char;
            System.Text.StringBuilder val_2 = ctx.L.string_buffer.Append(value:  (uint)val_6 & 65535);
            val_7 = 7;
            goto label_20;
            label_14:
            ctx.L.input_buffer = ctx.L.input_char;
            label_7:
            ctx.NextState = 1;
            ctx.Return = 1;
            return true;
            label_15:
            val_8 = ctx.L;
            if(ctx.L != 0)
            {
                goto label_22;
            }
            
            val_8 = ctx.L;
            if(val_8 == 0)
            {
                goto label_23;
            }
            
            label_22:
            val_6 = ctx.L.input_char;
            System.Text.StringBuilder val_3 = ctx.L.string_buffer.Append(value:  (uint)val_6 & 65535);
            val_7 = 5;
            label_20:
            ctx.NextState = val_7;
            val_4 = 1;
            return (bool)val_4;
            label_23:
        }
        private static bool State5(LitJson.FsmContext ctx)
        {
            var val_3;
            LitJson.Lexer val_4;
            LitJson.Lexer val_5;
            int val_1 = ctx.L.NextChar();
            ctx.L.input_char = val_1;
            if(val_1 == 1)
            {
                    val_1 = true;
                ctx.L.end_of_input = val_1;
            }
            
            val_3 = 0;
            if(ctx.L.input_char < 48)
            {
                    return (bool)val_3;
            }
            
            val_4 = ctx.L;
            if(ctx.L.input_char > 57)
            {
                    return (bool)val_3;
            }
            
            val_5 = ctx.L;
            if(ctx.L != 0)
            {
                goto label_6;
            }
            
            val_5 = ctx.L;
            if(val_5 == 0)
            {
                goto label_7;
            }
            
            label_6:
            val_4 = ctx.L.input_char;
            System.Text.StringBuilder val_2 = ctx.L.string_buffer.Append(value:  (uint)val_4 & 65535);
            val_3 = 1;
            ctx.NextState = 6;
            return (bool)val_3;
            label_7:
        }
        private static bool State6(LitJson.FsmContext ctx)
        {
            LitJson.Lexer val_4;
            LitJson.Lexer val_5;
            goto label_0;
            label_10:
            if((ctx.L.input_char < 48) || (ctx.L.input_char > 57))
            {
                goto label_4;
            }
            
            val_4 = ctx.L;
            if(ctx.L != 0)
            {
                goto label_5;
            }
            
            val_4 = ctx.L;
            if(val_4 == 0)
            {
                goto label_26;
            }
            
            label_5:
            System.Text.StringBuilder val_1 = ctx.L.string_buffer.Append(value:  (uint)ctx.L.input_char & 65535);
            label_0:
            int val_2 = ctx.L.NextChar();
            ctx.L.input_char = val_2;
            if(val_2 != 1)
            {
                goto label_10;
            }
            
            ctx.L.end_of_input = true;
            return true;
            label_4:
            if(ctx.L.input_char == 32)
            {
                goto label_16;
            }
            
            if(ctx.L.input_char >= 9)
            {
                    if(ctx.L.input_char <= 13)
            {
                goto label_16;
            }
            
            }
            
            if(ctx.L.input_char <= 69)
            {
                goto label_18;
            }
            
            if(ctx.L.input_char == 125)
            {
                goto label_23;
            }
            
            if(ctx.L.input_char == 101)
            {
                goto label_20;
            }
            
            if(ctx.L.input_char != 93)
            {
                    return true;
            }
            
            goto label_23;
            label_18:
            if(ctx.L.input_char == 44)
            {
                goto label_23;
            }
            
            if(ctx.L.input_char != 69)
            {
                    return true;
            }
            
            label_20:
            val_5 = ctx.L;
            if(ctx.L != 0)
            {
                goto label_25;
            }
            
            val_5 = ctx.L;
            if(val_5 == 0)
            {
                goto label_26;
            }
            
            label_25:
            System.Text.StringBuilder val_3 = ctx.L.string_buffer.Append(value:  (uint)ctx.L.input_char & 65535);
            ctx.NextState = 7;
            return true;
            label_23:
            ctx.L.input_buffer = ctx.L.input_char;
            label_16:
            ctx.NextState = 1;
            ctx.Return = 1;
            return true;
            label_26:
        }
        private static bool State7(LitJson.FsmContext ctx)
        {
            var val_3;
            LitJson.Lexer val_4;
            int val_1 = ctx.L.NextChar();
            ctx.L.input_char = val_1;
            if(val_1 == 1)
            {
                    val_1 = true;
                ctx.L.end_of_input = val_1;
            }
            
            if(ctx.L.input_char >= 48)
            {
                    if(ctx.L.input_char <= 57)
            {
                goto label_7;
            }
            
            }
            
            if(ctx.L.input_char != 45)
            {
                    val_3 = 0;
                if(ctx.L.input_char != 43)
            {
                    return (bool)val_3;
            }
            
            }
            
            label_7:
            val_4 = ctx.L;
            if(ctx.L != 0)
            {
                goto label_9;
            }
            
            val_4 = ctx.L;
            if(val_4 == 0)
            {
                goto label_10;
            }
            
            label_9:
            System.Text.StringBuilder val_2 = ctx.L.string_buffer.Append(value:  (uint)ctx.L.input_char & 65535);
            ctx.NextState = 8;
            val_3 = 1;
            return (bool)val_3;
            label_10:
        }
        private static bool State8(LitJson.FsmContext ctx)
        {
            LitJson.Lexer val_3;
            goto label_0;
            label_10:
            if((ctx.L.input_char < 48) || (ctx.L.input_char > 57))
            {
                goto label_4;
            }
            
            val_3 = ctx.L;
            if(ctx.L != 0)
            {
                goto label_5;
            }
            
            val_3 = ctx.L;
            if(val_3 == 0)
            {
                goto label_6;
            }
            
            label_5:
            System.Text.StringBuilder val_1 = ctx.L.string_buffer.Append(value:  (uint)ctx.L.input_char & 65535);
            label_0:
            int val_2 = ctx.L.NextChar();
            ctx.L.input_char = val_2;
            if(val_2 != 1)
            {
                goto label_10;
            }
            
            ctx.L.end_of_input = true;
            return true;
            label_4:
            if(ctx.L.input_char == 32)
            {
                goto label_16;
            }
            
            if(ctx.L.input_char >= 9)
            {
                    if(ctx.L.input_char <= 13)
            {
                goto label_16;
            }
            
            }
            
            if(ctx.L.input_char != 125)
            {
                goto label_18;
            }
            
            label_21:
            ctx.L.input_buffer = ctx.L.input_char;
            label_16:
            ctx.NextState = 1;
            ctx.Return = 1;
            return true;
            label_18:
            if(ctx.L.input_char != 93)
            {
                    return true;
            }
            
            goto label_21;
            label_6:
        }
        private static bool State9(LitJson.FsmContext ctx)
        {
            int val_1 = ctx.L.NextChar();
            ctx.L.input_char = val_1;
            if(val_1 == 1)
            {
                    val_1 = true;
                ctx.L.end_of_input = val_1;
            }
            
            if(ctx.L.input_char == 114)
            {
                    0 = 10;
                ctx.NextState = 0;
                0 = 1;
            }
            
            return (bool)0;
        }
        private static bool State10(LitJson.FsmContext ctx)
        {
            int val_1 = ctx.L.NextChar();
            ctx.L.input_char = val_1;
            if(val_1 == 1)
            {
                    val_1 = true;
                ctx.L.end_of_input = val_1;
            }
            
            if(ctx.L.input_char == 117)
            {
                    0 = 11;
                ctx.NextState = 0;
                0 = 1;
            }
            
            return (bool)0;
        }
        private static bool State11(LitJson.FsmContext ctx)
        {
            int val_1 = ctx.L.NextChar();
            ctx.L.input_char = val_1;
            if(val_1 == 1)
            {
                    val_1 = true;
                ctx.L.end_of_input = val_1;
            }
            
            if(ctx.L.input_char == 101)
            {
                    0 = 1;
                ctx.NextState = 0;
                ctx.Return = 0;
            }
            
            return (bool)0;
        }
        private static bool State12(LitJson.FsmContext ctx)
        {
            int val_1 = ctx.L.NextChar();
            ctx.L.input_char = val_1;
            if(val_1 == 1)
            {
                    val_1 = true;
                ctx.L.end_of_input = val_1;
            }
            
            if(ctx.L.input_char == 97)
            {
                    0 = 13;
                ctx.NextState = 0;
                0 = 1;
            }
            
            return (bool)0;
        }
        private static bool State13(LitJson.FsmContext ctx)
        {
            int val_1 = ctx.L.NextChar();
            ctx.L.input_char = val_1;
            if(val_1 == 1)
            {
                    val_1 = true;
                ctx.L.end_of_input = val_1;
            }
            
            if(ctx.L.input_char == 108)
            {
                    0 = 14;
                ctx.NextState = 0;
                0 = 1;
            }
            
            return (bool)0;
        }
        private static bool State14(LitJson.FsmContext ctx)
        {
            int val_1 = ctx.L.NextChar();
            ctx.L.input_char = val_1;
            if(val_1 == 1)
            {
                    val_1 = true;
                ctx.L.end_of_input = val_1;
            }
            
            if(ctx.L.input_char == 115)
            {
                    0 = 15;
                ctx.NextState = 0;
                0 = 1;
            }
            
            return (bool)0;
        }
        private static bool State15(LitJson.FsmContext ctx)
        {
            int val_1 = ctx.L.NextChar();
            ctx.L.input_char = val_1;
            if(val_1 == 1)
            {
                    val_1 = true;
                ctx.L.end_of_input = val_1;
            }
            
            if(ctx.L.input_char == 101)
            {
                    0 = 1;
                ctx.NextState = 0;
                ctx.Return = 0;
            }
            
            return (bool)0;
        }
        private static bool State16(LitJson.FsmContext ctx)
        {
            int val_1 = ctx.L.NextChar();
            ctx.L.input_char = val_1;
            if(val_1 == 1)
            {
                    val_1 = true;
                ctx.L.end_of_input = val_1;
            }
            
            if(ctx.L.input_char == 117)
            {
                    0 = 17;
                ctx.NextState = 0;
                0 = 1;
            }
            
            return (bool)0;
        }
        private static bool State17(LitJson.FsmContext ctx)
        {
            int val_1 = ctx.L.NextChar();
            ctx.L.input_char = val_1;
            if(val_1 == 1)
            {
                    val_1 = true;
                ctx.L.end_of_input = val_1;
            }
            
            if(ctx.L.input_char == 108)
            {
                    0 = 18;
                ctx.NextState = 0;
                0 = 1;
            }
            
            return (bool)0;
        }
        private static bool State18(LitJson.FsmContext ctx)
        {
            int val_1 = ctx.L.NextChar();
            ctx.L.input_char = val_1;
            if(val_1 == 1)
            {
                    val_1 = true;
                ctx.L.end_of_input = val_1;
            }
            
            if(ctx.L.input_char == 108)
            {
                    0 = 1;
                ctx.NextState = 0;
                ctx.Return = 0;
            }
            
            return (bool)0;
        }
        private static bool State19(LitJson.FsmContext ctx)
        {
            LitJson.Lexer val_3;
            goto label_0;
            label_9:
            if(ctx.L.input_char == 92)
            {
                goto label_2;
            }
            
            if(ctx.L.input_char == 34)
            {
                goto label_3;
            }
            
            val_3 = ctx.L;
            if(ctx.L != 0)
            {
                goto label_4;
            }
            
            val_3 = ctx.L;
            if(val_3 == 0)
            {
                goto label_5;
            }
            
            label_4:
            System.Text.StringBuilder val_1 = ctx.L.string_buffer.Append(value:  (uint)ctx.L.input_char & 65535);
            label_0:
            int val_2 = ctx.L.NextChar();
            ctx.L.input_char = val_2;
            if(val_2 != 1)
            {
                goto label_9;
            }
            
            ctx.L.end_of_input = true;
            return true;
            label_2:
            ctx.NextState = 21;
            ctx.StateStack = 19;
            return true;
            label_3:
            ctx.L.input_buffer = ctx.L.input_char;
            ctx.NextState = 20;
            ctx.Return = true;
            return true;
            label_5:
        }
        private static bool State20(LitJson.FsmContext ctx)
        {
            int val_1 = ctx.L.NextChar();
            ctx.L.input_char = val_1;
            if(val_1 == 1)
            {
                    val_1 = true;
                ctx.L.end_of_input = val_1;
            }
            
            if(ctx.L.input_char == 34)
            {
                    0 = 1;
                ctx.NextState = 0;
                ctx.Return = 0;
            }
            
            return (bool)0;
        }
        private static bool State21(LitJson.FsmContext ctx)
        {
            var val_6;
            var val_7;
            int val_8;
            var val_9;
            LitJson.Lexer val_10;
            int val_1 = ctx.L.NextChar();
            ctx.L.input_char = val_1;
            if(val_1 == 1)
            {
                    val_1 = true;
                ctx.L.end_of_input = val_1;
            }
            
            int val_5 = ctx.L.input_char;
            if(val_5 <= 92)
            {
                goto label_4;
            }
            
            if(val_5 <= 102)
            {
                goto label_5;
            }
            
            val_5 = val_5 - 110;
            val_7 = 0;
            if(val_5 > 7)
            {
                    return (bool)val_9;
            }
            
            var val_2 = 14625248 + (14625248 + ((ctx.L.input_char - 110)) << 2);
            if(val_5 == 7)
            {
                    val_7 = val_7 & (((IP) << (32-as. 
                
            
            
            
            
            
               
            )) | ((IP) << as. 
                
            
            
            
            
            
               
            ));
                val_7 = val_7 & (ctx >> 32);
                val_7 = val_7 & (ctx >> 32);
                val_7 = val_7 & (ctx >> 32);
                val_7 = val_7 & (((IP) << (32-as. 
                
            
            
            
            
            
               
            )) | ((IP) << as. 
                
            
            
            
            
            
               
            ));
                val_7 = val_7 & (ctx >> 32);
                val_7 = val_7 & (((IP) << (32-as. 
                
            
            
            
            
            
               
            )) | ((IP) << as. 
                
            
            
            
            
            
               
            ));
                val_7 = val_7 & (val_7 >> 32);
            }
            
            val_8 = 22;
            goto label_7;
            label_4:
            if(val_5 <= 39)
            {
                goto label_8;
            }
            
            if(val_5 == 47)
            {
                goto label_11;
            }
            
            val_9 = 0;
            if(val_5 == 92)
            {
                goto label_11;
            }
            
            return (bool)val_9;
            label_5:
            val_6 = val_5 | 4;
            if(val_6 == 102)
            {
                goto label_11;
            }
            
            return false;
            label_8:
            if(val_5 != 34)
            {
                    val_6 = 0;
            }
            
            if(val_5 != 39)
            {
                    return (bool)val_9;
            }
            
            label_11:
            val_10 = ctx.L;
            if(ctx.L != 0)
            {
                goto label_13;
            }
            
            val_10 = ctx.L;
            if(val_10 == 0)
            {
                goto label_14;
            }
            
            label_13:
            System.Text.StringBuilder val_4 = ctx.L.string_buffer.Append(value:  LitJson.Lexer.ProcessEscChar(esc_char:  ctx.L.input_char));
            val_8 = ctx.StateStack;
            label_7:
            ctx.NextState = val_8;
            return true;
            label_14:
        }
        private static bool State22(LitJson.FsmContext ctx)
        {
            var val_5;
            var val_6;
            LitJson.Lexer val_7;
            int val_8;
            bool val_9;
            LitJson.Lexer val_10;
            LitJson.Lexer val_11;
            val_5 = 4096;
            ctx.L.unichar = 0;
            val_6 = 4;
            val_7 = ctx.L;
            int val_1 = val_7.NextChar();
            ctx.L.input_char = val_1;
            if(val_1 == 1)
            {
                goto label_4;
            }
            
            if(ctx.L.input_char < 48)
            {
                goto label_6;
            }
            
            val_8 = ctx.L.input_char;
            if(val_8 < 58)
            {
                goto label_12;
            }
            
            label_6:
            if(ctx.L.input_char < 65)
            {
                goto label_10;
            }
            
            val_8 = ctx.L.input_char;
            if(val_8 < 71)
            {
                goto label_12;
            }
            
            label_10:
            val_9 = 0;
            if(ctx.L.input_char < 97)
            {
                    return val_9;
            }
            
            val_8 = ctx.L.input_char;
            if(val_8 > 102)
            {
                    return val_9;
            }
            
            label_12:
            val_10 = ctx.L;
            if(ctx.L != 0)
            {
                goto label_17;
            }
            
            val_10 = ctx.L;
            if(val_10 == 0)
            {
                goto label_23;
            }
            
            label_17:
            val_6 = val_6 - 1;
            ctx.L.unichar = LitJson.Lexer.HexValue(digit:  ctx.L.input_char);
            val_8 = val_5 + 0;
            val_5 = val_8 >> 4;
            val_11 = ctx.L;
            if(ctx.L != 0)
            {
                goto label_22;
            }
            
            val_11 = ctx.L;
            if(val_11 == 0)
            {
                goto label_23;
            }
            
            label_22:
            val_7 = System.Convert.ToChar(value:  ctx.L.unichar);
            System.Text.StringBuilder val_4 = ctx.L.string_buffer.Append(value:  val_7);
            val_9 = 1;
            ctx.NextState = ctx.StateStack;
            return val_9;
            label_4:
            val_9 = true;
            ctx.L.end_of_input = val_9;
            return val_9;
            label_23:
        }
        private static bool State23(LitJson.FsmContext ctx)
        {
            LitJson.Lexer val_3;
            goto label_0;
            label_9:
            if(ctx.L.input_char == 92)
            {
                goto label_2;
            }
            
            if(ctx.L.input_char == 39)
            {
                goto label_3;
            }
            
            val_3 = ctx.L;
            if(ctx.L != 0)
            {
                goto label_4;
            }
            
            val_3 = ctx.L;
            if(val_3 == 0)
            {
                goto label_5;
            }
            
            label_4:
            System.Text.StringBuilder val_1 = ctx.L.string_buffer.Append(value:  (uint)ctx.L.input_char & 65535);
            label_0:
            int val_2 = ctx.L.NextChar();
            ctx.L.input_char = val_2;
            if(val_2 != 1)
            {
                goto label_9;
            }
            
            ctx.L.end_of_input = true;
            return true;
            label_2:
            ctx.NextState = 21;
            ctx.StateStack = 23;
            return true;
            label_3:
            ctx.L.input_buffer = ctx.L.input_char;
            ctx.NextState = 24;
            ctx.Return = true;
            return true;
            label_5:
        }
        private static bool State24(LitJson.FsmContext ctx)
        {
            int val_2;
            int val_1 = ctx.L.NextChar();
            ctx.L.input_char = val_1;
            if(val_1 == 1)
            {
                    val_1 = true;
                ctx.L.end_of_input = val_1;
            }
            
            val_2 = 0;
            if(ctx.L.input_char != 39)
            {
                    return (bool)val_2;
            }
            
            ctx.L.input_char = 34;
            val_2 = 1;
            ctx.NextState = val_2;
            ctx.Return = val_2;
            return (bool)val_2;
        }
        private static bool State25(LitJson.FsmContext ctx)
        {
            var val_2;
            int val_3;
            int val_1 = ctx.L.NextChar();
            ctx.L.input_char = val_1;
            if(val_1 == 1)
            {
                    val_1 = true;
                ctx.L.end_of_input = val_1;
            }
            
            if(ctx.L.input_char != 42)
            {
                    val_2 = 0;
                if(ctx.L.input_char != 47)
            {
                    return (bool)val_2;
            }
            
                val_3 = 26;
            }
            else
            {
                    val_3 = 27;
            }
            
            ctx.NextState = val_3;
            val_2 = 1;
            return (bool)val_2;
        }
        private static bool State26(LitJson.FsmContext ctx)
        {
            label_4:
            int val_1 = ctx.L.NextChar();
            ctx.L.input_char = val_1;
            if(val_1 == 1)
            {
                goto label_2;
            }
            
            if(ctx.L.input_char != 10)
            {
                goto label_4;
            }
            
            ctx.NextState = 1;
            return true;
            label_2:
            ctx.L.end_of_input = true;
            return true;
        }
        private static bool State27(LitJson.FsmContext ctx)
        {
            label_4:
            int val_1 = ctx.L.NextChar();
            ctx.L.input_char = val_1;
            if(val_1 == 1)
            {
                goto label_2;
            }
            
            if(ctx.L.input_char != 42)
            {
                goto label_4;
            }
            
            ctx.NextState = 28;
            return true;
            label_2:
            ctx.L.end_of_input = true;
            return true;
        }
        private static bool State28(LitJson.FsmContext ctx)
        {
            label_4:
            int val_1 = ctx.L.NextChar();
            ctx.L.input_char = val_1;
            if(val_1 == 1)
            {
                goto label_2;
            }
            
            if(ctx.L.input_char == 42)
            {
                goto label_4;
            }
            
            if(ctx.L.input_char != 47)
            {
                    ctx.L.input_char = 27;
            }
            
            if(ctx.L.input_char == 47)
            {
                    ctx.L.input_char = 1;
            }
            
            ctx.NextState = ctx.L.input_char;
            return true;
            label_2:
            ctx.L.end_of_input = true;
            return true;
        }
        private bool GetChar()
        {
            int val_1 = this.NextChar();
            this.input_char = val_1;
            if(val_1 == 1)
            {
                    true = true;
                this.end_of_input = true;
                true = 0;
            }
            
            return (bool)true;
        }
        private int NextChar()
        {
            if((this.input_buffer + 24) == 0)
            {
                
            }
        
        }
        public bool NextToken()
        {
            var val_9;
            int val_10;
            var val_11;
            this.fsm_context.Return = false;
            goto label_2;
            label_12:
            if(this.fsm_context.Return == true)
            {
                goto label_4;
            }
            
            this.state = this.fsm_context.NextState;
            label_2:
            val_9 = null;
            val_9 = null;
            StateHandler[] val_2 = LitJson.Lexer.fsm_handler_table + ((this.state - 1) << 2);
            if(((LitJson.Lexer.fsm_handler_table + ((this.state - 1)) << 2) + 16.Invoke(ctx:  this.fsm_context)) == false)
            {
                goto label_11;
            }
            
            if(this.end_of_input == false)
            {
                goto label_12;
            }
            
            return false;
            label_4:
            this.string_value = this.string_buffer;
            if(this.string_buffer != 0)
            {
                    val_10 = this.string_buffer.Length;
            }
            else
            {
                    val_10 = 0.Length;
            }
            
            System.Text.StringBuilder val_6 = this.string_buffer.Remove(startIndex:  0, length:  val_10);
            val_11 = null;
            val_11 = null;
            int val_9 = this.state;
            val_9 = val_9 - 1;
            System.Int32[] val_7 = LitJson.Lexer.fsm_return_table + (val_9 << 2);
            this.token = (LitJson.Lexer.fsm_return_table + ((this.state - 1)) << 2) + 16;
            if(((LitJson.Lexer.fsm_return_table + ((this.state - 1)) << 2) + 16) == 65542)
            {
                    (LitJson.Lexer.fsm_return_table + ((this.state - 1)) << 2) + 16 = this.input_char;
                this.token = (LitJson.Lexer.fsm_return_table + ((this.state - 1)) << 2) + 16;
            }
            
            this.state = this.fsm_context.NextState;
            return true;
            label_11:
            LitJson.JsonException val_8 = new LitJson.JsonException(c:  this.input_char);
        }
        private void UngetChar()
        {
            this.input_buffer = this.input_char;
        }
    
    }

}
