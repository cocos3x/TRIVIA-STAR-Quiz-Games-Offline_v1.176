using UnityEngine;

namespace com.adjust.sdk
{
    public class JSONNode
    {
        // Properties
        public virtual com.adjust.sdk.JSONNode Item { get; set; }
        public virtual com.adjust.sdk.JSONNode Item { get; set; }
        public virtual string Value { get; set; }
        public virtual int Count { get; }
        public virtual System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> Childs { get; }
        public System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> DeepChilds { get; }
        public virtual int AsInt { get; set; }
        public virtual float AsFloat { get; set; }
        public virtual double AsDouble { get; set; }
        public virtual bool AsBool { get; set; }
        public virtual com.adjust.sdk.JSONArray AsArray { get; }
        public virtual com.adjust.sdk.JSONClass AsObject { get; }
        
        // Methods
        public virtual void Add(string aKey, com.adjust.sdk.JSONNode aItem)
        {
        
        }
        public virtual com.adjust.sdk.JSONNode get_Item(int aIndex)
        {
        
        }
        public virtual void set_Item(int aIndex, com.adjust.sdk.JSONNode value)
        {
        
        }
        public virtual com.adjust.sdk.JSONNode get_Item(string aKey)
        {
        
        }
        public virtual void set_Item(string aKey, com.adjust.sdk.JSONNode value)
        {
        
        }
        public virtual string get_Value()
        {
        
        }
        public virtual void set_Value(string value)
        {
        
        }
        public virtual int get_Count()
        {
            return 0;
        }
        public virtual void Add(com.adjust.sdk.JSONNode aItem)
        {
            goto typeof(com.adjust.sdk.JSONNode).__il2cppRuntimeField_DC;
        }
        public virtual com.adjust.sdk.JSONNode Remove(string aKey)
        {
        
        }
        public virtual com.adjust.sdk.JSONNode Remove(int aIndex)
        {
        
        }
        public virtual com.adjust.sdk.JSONNode Remove(com.adjust.sdk.JSONNode aNode)
        {
        
        }
        public virtual System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> get_Childs()
        {
            object val_1 = new System.Object();
            typeof(JSONNode.<get_Childs>d__17).__il2cppRuntimeField_8 = 1;
            typeof(JSONNode.<get_Childs>d__17).__il2cppRuntimeField_10 = System.Environment.CurrentManagedThreadId;
        }
        public System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> get_DeepChilds()
        {
            object val_1 = new System.Object();
            typeof(JSONNode.<get_DeepChilds>d__19).__il2cppRuntimeField_8 = 1;
            typeof(JSONNode.<get_DeepChilds>d__19).__il2cppRuntimeField_10 = System.Environment.CurrentManagedThreadId;
            typeof(JSONNode.<get_DeepChilds>d__19).__il2cppRuntimeField_14 = this;
        }
        public override string ToString()
        {
        
        }
        public virtual string ToString(string aPrefix)
        {
        
        }
        public virtual int get_AsInt()
        {
            bool val_2 = System.Int32.TryParse(s:  1342260464, result: out  int val_1 = 1342248452);
            if(val_2 == true)
            {
                    val_2 = 0;
            }
            
            return (int)val_2;
        }
        public virtual void set_AsInt(int value)
        {
            string val_1 = value.ToString();
        }
        public virtual float get_AsFloat()
        {
            if((System.Single.TryParse(s:  1342484464, result: out  float val_1 = 8.892191E+09f)) == true)
            {
                    0f = 0;
            }
            
            return (float)0f;
        }
        public virtual void set_AsFloat(float value)
        {
            string val_1 = ???.ToString();
        }
        public virtual double get_AsDouble()
        {
            bool val_2 = System.Double.TryParse(s:  1342708464, result: out  double val_1 = 6.63380183797343E-315);
            return (double)D0;
        }
        public virtual void set_AsDouble(double value)
        {
            string val_1 = ToString();
        }
        public virtual bool get_AsBool()
        {
            var val_4;
            if((System.Boolean.TryParse(value:  1342932464, result: out  bool val_1 = true)) != false)
            {
                    if(0 != 0)
            {
                    val_4 = 1;
            }
            
                return (bool)val_4;
            }
            
            val_4 = (System.String.IsNullOrEmpty(value:  1342932464)) ^ 1;
            return (bool)val_4;
        }
        public virtual void set_AsBool(bool value)
        {
            if(value == true)
            {
                    "false" = "true";
            }
            
            if(this == 0)
            {
                
            }
        
        }
        public virtual com.adjust.sdk.JSONArray get_AsArray()
        {
            if(this == 0)
            {
                    return;
            }
            
            if(((com.adjust.sdk.JSONNode.__il2cppRuntimeField_typeHierarchy + (com.adjust.sdk.JSONArray.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    this = 0;
            }
        
        }
        public virtual com.adjust.sdk.JSONClass get_AsObject()
        {
            if(this == 0)
            {
                    return;
            }
            
            if(((com.adjust.sdk.JSONNode.__il2cppRuntimeField_typeHierarchy + (com.adjust.sdk.JSONClass.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    this = 0;
            }
        
        }
        public static com.adjust.sdk.JSONNode op_Implicit(string s)
        {
            object val_1 = new System.Object();
            typeof(com.adjust.sdk.JSONData).__il2cppRuntimeField_8 = s;
        }
        public static string op_Implicit(com.adjust.sdk.JSONNode d)
        {
            if((com.adjust.sdk.JSONNode.op_Equality(a:  d, b:  0)) != false)
            {
                    return;
            }
            
            if(d == 0)
            {
                
            }
        
        }
        public static bool op_Equality(com.adjust.sdk.JSONNode a, object b)
        {
            if(b == 0)
            {
                goto label_1;
            }
            
            label_4:
            com.adjust.sdk.JSONNode val_1 = a - b;
            val_1 = val_1 >> 5;
            return (bool)val_1;
            label_1:
            if(a == 0)
            {
                goto label_4;
            }
            
            return true;
        }
        public static bool op_Inequality(com.adjust.sdk.JSONNode a, object b)
        {
            bool val_1 = com.adjust.sdk.JSONNode.op_Equality(a:  a, b:  b);
            val_1 = val_1 ^ 1;
            return (bool)val_1;
        }
        public override bool Equals(object obj)
        {
            this = this - obj;
            this = this >> 5;
            return (bool)this;
        }
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
        internal static string Escape(string aText)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_6 = 0;
            val_7 = "";
            goto label_1;
            label_13:
            char val_1 = aText.Chars[0];
            char val_2 = val_1 - 8;
            if(val_2 > '')
            {
                goto label_2;
            }
            
            var val_3 = 13438320 + (13438320 + ((val_1 - 8)) << 2);
            if(val_2 == '')
            {
                    13438320 = 526448;
                13438320 = 13438320 & (aText >> 526448);
                13438320 = 13438320 & ((((13438320 & ((int)aText) >> 13438320)) << (32-as. 
                
            
            
            
            
            
               
            )) | (((13438320 & ((int)aText) >> 13438320)) << as. 
                
            
            
            
            
            
               
            ));
                13438320 = 13438320 & (13438320 >> 32);
                13438320 = 13438320 & ((("\\r") << (32-as. 
                
            
            
            
            
            
               
            )) | (("\\r") << as. 
                
            
            
            
            
            
               
            ));
                13438320 = 13438320 & (((((((13438320 & ((int)aText) >> 13438320) & (((13438320 & ((int)aText) >> 13438320)) << (32-as. 
                
            
            
            
            
            
               
            )) | (((13438320 & ((int)aText) >> 13438320)) << as. 
                
            
            
            
            
            
               
            )) & ((int)((13438320 ) << (32-((((13438320 & ((int)aText) >> 13438320) & (((13438320 & ((int)aText) >> 13438320)) << (32-as. 
                
            
            
            
            
            
               
            )) | (((13438320 & ((int)aText) >> 13438320)) << as. 
                
            
            
            
            
            
               
            )) & ((int)((13438320 )) | ((((((13438320 & ((int)aText) >> 13438320) & (((13438320 & ((int)aText) >> 13438320)) << (32-as. 
                
            
            
            
            
            
               
            )) | (((13438320 & ((int)aText) >> 13438320)) << as. 
                
            
            
            
            
            
               
            )) & ((int)((13438320 ) << ((((13438320 & ((int)aText) >> 13438320) & (((13438320 & ((int)aText) >> 13438320)) << (32-as. 
                
            
            
            
            
            
               
            )) | (((13438320 & ((int)aText) >> 13438320)) << as. 
                
            
            
            
            
            
               
            )) & ((int)((13438320 ));
            }
            
            val_8 = "\\b";
            goto label_8;
            label_2:
            if(val_1 == '"')
            {
                goto label_4;
            }
            
            if(val_1 != '\')
            {
                goto label_5;
            }
            
            val_8 = "\\\\";
            goto label_8;
            label_5:
            string val_4 = val_1.ToString();
            val_9 = ;
            goto label_11;
            label_4:
            val_8 = "\\\"";
            label_8:
            label_11:
            string val_5 = 1098586544 + 1372269024;
            val_6 = 1;
            val_7 = val_7;
            label_1:
            if(val_6 < aText.m_stringLength)
            {
                goto label_13;
            }
        
        }
        public static com.adjust.sdk.JSONNode Parse(string aJSON)
        {
            var val_37;
            System.Collections.Generic.Stack<com.adjust.sdk.JSONNode> val_38;
            var val_39;
            float val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            val_37 = 0;
            val_38 = null;
            val_38 = new System.Collections.Generic.Stack<com.adjust.sdk.JSONNode>();
            val_39 = 0;
            val_40 = "";
            val_41 = "";
            val_42 = val_41;
            goto label_1;
            label_78:
            char val_2 = aJSON.Chars[0];
            if(val_2 > ',')
            {
                goto label_2;
            }
            
            if(val_2 > ' ')
            {
                goto label_3;
            }
            
            if(val_2 > '')
            {
                goto label_4;
            }
            
            if(val_2 == '	')
            {
                goto label_5;
            }
            
            if(val_2 == '
            ')
            {
                goto label_76;
            }
            
            goto label_42;
            label_2:
            if(val_2 > ']')
            {
                goto label_8;
            }
            
            if(val_2 > '[')
            {
                goto label_9;
            }
            
            if(val_2 == (':'))
            {
                goto label_10;
            }
            
            if(val_2 != '[')
            {
                goto label_42;
            }
            
            if(val_37 != 1)
            {
                goto label_43;
            }
            
            com.adjust.sdk.JSONArray val_3 = null;
            val_43 = val_3;
            val_3 = new com.adjust.sdk.JSONArray();
            goto label_13;
            label_3:
            if(val_2 == '"')
            {
                goto label_14;
            }
            
            if(val_2 != ',')
            {
                goto label_42;
            }
            
            if(val_37 != 1)
            {
                goto label_43;
            }
            
            if(((System.String.op_Inequality(a:  1098586544, b:  1098586544)) == false) || ((System.String.op_Inequality(a:  1098586544, b:  1098586544)) == false))
            {
                goto label_23;
            }
            
            com.adjust.sdk.JSONNode val_6 = com.adjust.sdk.JSONNode.op_Implicit(s:  1098586544);
            val_40 = val_40;
            val_38 = val_38;
            goto label_23;
            label_8:
            if(val_2 == '}')
            {
                goto label_24;
            }
            
            if(val_2 != '{')
            {
                goto label_42;
            }
            
            if(val_37 != 1)
            {
                goto label_43;
            }
            
            com.adjust.sdk.JSONClass val_7 = null;
            val_43 = val_7;
            val_7 = new com.adjust.sdk.JSONClass();
            label_13:
            Push(item:  470073344);
            if((com.adjust.sdk.JSONNode.op_Equality(a:  0, b:  0)) == true)
            {
                goto label_36;
            }
            
            string val_9 = Trim();
            if((System.String.op_Inequality(a:  1098586544, b:  1098586544)) == false)
            {
                goto label_36;
            }
            
            object val_11 = Peek();
            if(0 != 0)
            {
                goto label_36;
            }
            
            goto label_36;
            label_4:
            if(val_2 == '')
            {
                goto label_76;
            }
            
            if(val_2 != ' ')
            {
                goto label_42;
            }
            
            label_5:
            if(val_37 != 1)
            {
                goto label_43;
            }
            
            val_37 = 0;
            goto label_76;
            label_9:
            if(val_2 == '\')
            {
                goto label_41;
            }
            
            if(val_2 != ']')
            {
                goto label_42;
            }
            
            label_24:
            if(val_37 != 1)
            {
                goto label_43;
            }
            
            object val_12 = Pop();
            if((System.String.op_Inequality(a:  1098586544, b:  1098586544)) == false)
            {
                goto label_53;
            }
            
            string val_14 = Trim();
            if((System.String.op_Inequality(a:  1098586544, b:  1098586544)) == false)
            {
                goto label_53;
            }
            
            com.adjust.sdk.JSONNode val_16 = com.adjust.sdk.JSONNode.op_Implicit(s:  1098586544);
            val_40 = val_40;
            val_38 = val_38;
            goto label_53;
            label_42:
            string val_18 = aJSON.Chars[0].ToString();
            string val_19 = 1098586544 + 1344227178;
            label_63:
            val_42 = val_42;
            goto label_76;
            label_14:
            val_37 = 1;
            goto label_76;
            label_10:
            if((val_37 & 1) != 0)
            {
                goto label_63;
            }
            
            label_43:
            string val_21 = aJSON.Chars[0].ToString();
            string val_22 = 1098586544 + 1344227178;
            val_42 = val_42;
            val_37 = 1;
            goto label_76;
            label_41:
            if((val_37 & 1) != 0)
            {
                goto label_58;
            }
            
            char val_23 = aJSON.Chars[1];
            if(val_23 > 'f')
            {
                goto label_59;
            }
            
            if(val_23 == 'b')
            {
                goto label_60;
            }
            
            if(val_23 != 'f')
            {
                goto label_65;
            }
            
            val_44 = "\f";
            goto label_74;
            label_58:
            val_37 = 0;
            goto label_64;
            label_59:
            val_23 = val_23 - 110;
            if(val_23 > '')
            {
                goto label_65;
            }
            
            var val_24 = 13429632 + (13429632 + ((val_23 - 110)) << 2);
            if(val_23 == '')
            {
                    13429632 + ((val_23 - 110)) << 2 = (13429632 + ((val_23 - 110)) << 2) & ((13429632 + ((val_23 - 110)) << 2) >> 32);
                13429632 + ((val_23 - 110)) << 2 = (13429632 + ((val_23 - 110)) << 2) & ((IP) >> 32);
                13429632 + ((val_23 - 110)) << 2 = (13429632 + ((val_23 - 110)) << 2) & ((IP) >> 32);
                13429632 + ((val_23 - 110)) << 2 = (13429632 + ((val_23 - 110)) << 2) & ((IP) >> 32);
                13429632 + ((val_23 - 110)) << 2 = (13429632 + ((val_23 - 110)) << 2) & ((IP) << 2);
                13429632 + ((val_23 - 110)) << 2 = (13429632 + ((val_23 - 110)) << 2) & ((IP) >> 32);
                13429632 + ((val_23 - 110)) << 2 = (13429632 + ((val_23 - 110)) << 2) & ((13429632 + ((val_23 - 110)) << 2) << 2);
                13429632 + ((val_23 - 110)) << 2 = (13429632 + ((val_23 - 110)) << 2) & ((IP) >> 13429632);
            }
            
            val_44 = "\n";
            goto label_74;
            label_65:
            string val_25 = val_23.ToString();
            val_45;
            goto label_67;
            label_60:
            val_44 = "\b";
            goto label_74;
            label_36:
            val_41 = "";
            object val_27 = Peek();
            goto label_71;
            label_53:
            val_37 = 0;
            val_41 = "";
            object val_29 = Peek();
            goto label_73;
            label_74:
            label_67:
            string val_30 = 1098586544 + 1975550000;
            val_42 = val_42;
            val_37 = 1;
            label_64:
            val_46 = val_40;
            val_40 = "";
            goto label_76;
            label_23:
            val_41 = "";
            label_71:
            val_37 = 0;
            label_73:
            val_42 = val_41;
            label_76:
            val_39 = val_39 + 1;
            label_1:
            if(val_39 < aJSON.m_stringLength)
            {
                goto label_78;
            }
            
            if((val_37 & 1) != 0)
            {
                    aJSON.m_stringLength = val_38;
                return;
            }
            
            label_79:
            System.Exception val_36 = new System.Exception(message:  1189487248);
            goto label_79;
        }
        public virtual void Serialize(System.IO.BinaryWriter aWriter)
        {
        
        }
        public void SaveToStream(System.IO.Stream aData)
        {
            System.IO.BinaryWriter val_1 = new System.IO.BinaryWriter(output:  aData);
            goto typeof(com.adjust.sdk.JSONNode).__il2cppRuntimeField_19C;
        }
        public void SaveToCompressedStream(System.IO.Stream aData)
        {
            System.Exception val_1 = new System.Exception(message:  1189849168);
        }
        public void SaveToCompressedFile(string aFileName)
        {
            System.Exception val_1 = new System.Exception(message:  1189849168);
        }
        public string SaveToCompressedBase64()
        {
            System.Exception val_1 = new System.Exception(message:  1189849168);
        }
        public static com.adjust.sdk.JSONNode Deserialize(System.IO.BinaryReader aReader)
        {
            var val_12;
            var val_13;
            System.IO.BinaryReader val_1 = aReader - 1;
            if(val_1 <= 6)
            {
                    var val_2 = 13448700 + (13448700 + ((aReader - 1)) << 2);
                if(val_1 == 6)
            {
                    13448700 = 13448700 & ((IP) << 13448700);
                13448700 = 13448700 & (((IP) << (32-2)) | ((IP) << 2));
                13448700 = 13448700 & (((IP) << (32-1)) | ((IP) << 1));
                13448700 = 13448700 & (aReader >> 2);
                13448700 = 13448700 * 13448700;
                mem2[0] = (((((13448700 & (IP) << 13448700) & ((IP) << (32-2)) | ((IP) << 2)) & ((IP) << (32-1)) | ((IP) << 1)) & (aReader) >> 2) * ((((13448700 & (IP) << 13448700) & ((IP) << (32-2)) | ((IP) << 2)) & ((IP) <<  + IP;
            }
            
                val_12 = aReader;
                com.adjust.sdk.JSONArray val_3 = null;
                val_13 = val_3;
                val_3 = new com.adjust.sdk.JSONArray();
                if(val_12 < 1)
            {
                    return;
            }
            
                do
            {
                Add(aItem:  aReader);
                val_12 = val_12 - 1;
            }
            while(val_13 != 0);
            
                return;
            }
            
            string val_10 = 1190437120 + 469700608;
            System.Exception val_11 = new System.Exception(message:  1190437120);
        }
        public static com.adjust.sdk.JSONNode LoadFromCompressedFile(string aFileName)
        {
            System.Exception val_1 = new System.Exception(message:  1189849168);
        }
        public static com.adjust.sdk.JSONNode LoadFromCompressedStream(System.IO.Stream aData)
        {
            System.Exception val_1 = new System.Exception(message:  1189849168);
        }
        public static com.adjust.sdk.JSONNode LoadFromCompressedBase64(string aBase64)
        {
            System.Exception val_1 = new System.Exception(message:  1189849168);
        }
        public static com.adjust.sdk.JSONNode LoadFromStream(System.IO.Stream aData)
        {
            System.IO.Stream val_4;
            var val_5;
            var val_6;
            val_4 = aData;
            System.IO.BinaryReader val_1 = new System.IO.BinaryReader(input:  val_4);
            com.adjust.sdk.JSONNode val_2 = com.adjust.sdk.JSONNode.Deserialize(aReader:  31735808);
            if(val_1 == 0)
            {
                goto label_1;
            }
            
            System.IO.BinaryReader val_4 = null;
            if((mem[null + 178]) == 0)
            {
                goto label_2;
            }
            
            val_4 = 0;
            label_4:
            val_5 = 0;
            if((mem[null + 88] + 0) == null)
            {
                goto label_3;
            }
            
            val_4 = val_4 + 1;
            val_5 = (uint)val_4 & 65535;
            if(val_5 < (mem[null + 178]))
            {
                goto label_4;
            }
            
            label_2:
            val_6 = val_1;
            goto label_5;
            label_3:
            var val_3 = (mem[null + 88]) + 0;
            val_4 = val_4 + (((mem[null + 88] + 0) + 4) << 3);
            label_5:
            label_1:
            if(0 == 0)
            {
                    return;
            }
        
        }
        public static com.adjust.sdk.JSONNode LoadFromBase64(string aBase64)
        {
            System.Byte[] val_1 = System.Convert.FromBase64String(s:  aBase64);
            if((new System.IO.MemoryStream(buffer:  aBase64)) != 0)
            {
                    return com.adjust.sdk.JSONNode.LoadFromStream(aData:  32747520);
            }
            
            return com.adjust.sdk.JSONNode.LoadFromStream(aData:  32747520);
        }
        public JSONNode()
        {
        
        }
    
    }

}
