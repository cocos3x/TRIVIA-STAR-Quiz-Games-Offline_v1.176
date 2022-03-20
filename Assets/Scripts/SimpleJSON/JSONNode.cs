using UnityEngine;

namespace SimpleJSON
{
    public class JSONNode
    {
        // Properties
        public virtual SimpleJSON.JSONNode Item { get; set; }
        public virtual SimpleJSON.JSONNode Item { get; set; }
        public virtual string Value { get; set; }
        public virtual int Count { get; }
        public virtual System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode> Childs { get; }
        public System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode> DeepChilds { get; }
        public virtual int AsInt { get; set; }
        public virtual float AsFloat { get; set; }
        public virtual double AsDouble { get; set; }
        public virtual bool AsBool { get; set; }
        public virtual SimpleJSON.JSONArray AsArray { get; }
        public virtual SimpleJSON.JSONClass AsObject { get; }
        
        // Methods
        public virtual void Add(string aKey, SimpleJSON.JSONNode aItem)
        {
        
        }
        public virtual SimpleJSON.JSONNode get_Item(int aIndex)
        {
        
        }
        public virtual void set_Item(int aIndex, SimpleJSON.JSONNode value)
        {
        
        }
        public virtual SimpleJSON.JSONNode get_Item(string aKey)
        {
        
        }
        public virtual void set_Item(string aKey, SimpleJSON.JSONNode value)
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
        public virtual void Add(SimpleJSON.JSONNode aItem)
        {
            goto typeof(SimpleJSON.JSONNode).__il2cppRuntimeField_DC;
        }
        public virtual SimpleJSON.JSONNode Remove(string aKey)
        {
        
        }
        public virtual SimpleJSON.JSONNode Remove(int aIndex)
        {
        
        }
        public virtual SimpleJSON.JSONNode Remove(SimpleJSON.JSONNode aNode)
        {
        
        }
        public virtual System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode> get_Childs()
        {
            object val_1 = new System.Object();
            typeof(JSONNode.<get_Childs>d__17).__il2cppRuntimeField_8 = 1;
            typeof(JSONNode.<get_Childs>d__17).__il2cppRuntimeField_10 = System.Environment.CurrentManagedThreadId;
        }
        public System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode> get_DeepChilds()
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
            bool val_2 = System.Int32.TryParse(s:  1187533360, result: out  int val_1 = 1187521348);
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
            if((System.Single.TryParse(s:  1187757360, result: out  float val_1 = 26055.13f)) == true)
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
            bool val_2 = System.Double.TryParse(s:  1187981360, result: out  double val_1 = 5.86934837230437E-315);
            return (double)D0;
        }
        public virtual void set_AsDouble(double value)
        {
            string val_1 = ToString();
        }
        public virtual bool get_AsBool()
        {
            var val_4;
            if((System.Boolean.TryParse(value:  1188205360, result: out  bool val_1 = true)) != false)
            {
                    if(0 != 0)
            {
                    val_4 = 1;
            }
            
                return (bool)val_4;
            }
            
            val_4 = (System.String.IsNullOrEmpty(value:  1188205360)) ^ 1;
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
        public virtual SimpleJSON.JSONArray get_AsArray()
        {
            if(this == 0)
            {
                    return;
            }
            
            if(((SimpleJSON.JSONNode.__il2cppRuntimeField_typeHierarchy + (SimpleJSON.JSONArray.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    this = 0;
            }
        
        }
        public virtual SimpleJSON.JSONClass get_AsObject()
        {
            if(this == 0)
            {
                    return;
            }
            
            if(((SimpleJSON.JSONNode.__il2cppRuntimeField_typeHierarchy + (SimpleJSON.JSONClass.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    this = 0;
            }
        
        }
        public static SimpleJSON.JSONNode op_Implicit(string s)
        {
            object val_1 = new System.Object();
            typeof(SimpleJSON.JSONData).__il2cppRuntimeField_8 = s;
        }
        public static string op_Implicit(SimpleJSON.JSONNode d)
        {
            if((SimpleJSON.JSONNode.op_Equality(a:  d, b:  0)) != false)
            {
                    return;
            }
            
            if(d == 0)
            {
                
            }
        
        }
        public static bool op_Equality(SimpleJSON.JSONNode a, object b)
        {
            if(b == 0)
            {
                goto label_1;
            }
            
            label_4:
            SimpleJSON.JSONNode val_1 = a - b;
            val_1 = val_1 >> 5;
            return (bool)val_1;
            label_1:
            if(a == 0)
            {
                goto label_4;
            }
            
            return true;
        }
        public static bool op_Inequality(SimpleJSON.JSONNode a, object b)
        {
            bool val_1 = SimpleJSON.JSONNode.op_Equality(a:  a, b:  b);
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
            
            var val_3 = 15841912 + (15841912 + ((val_1 - 8)) << 2);
            if(val_2 == '')
            {
                    15841912 = 2140280;
                15841912 = 15841912 & (aText >> 2140280);
                15841912 = 15841912 & ((((15841912 & ((int)aText) >> 15841912)) << (32-as. 
                
            
            
            
            
            
               
            )) | (((15841912 & ((int)aText) >> 15841912)) << as. 
                
            
            
            
            
            
               
            ));
                15841912 = 15841912 & (15841912 >> 32);
                15841912 = 15841912 & ((("\\r") << (32-as. 
                
            
            
            
            
            
               
            )) | (("\\r") << as. 
                
            
            
            
            
            
               
            ));
                15841912 = 15841912 & (((((((15841912 & ((int)aText) >> 15841912) & (((15841912 & ((int)aText) >> 15841912)) << (32-as. 
                
            
            
            
            
            
               
            )) | (((15841912 & ((int)aText) >> 15841912)) << as. 
                
            
            
            
            
            
               
            )) & ((int)((15841912 ) << (32-((((15841912 & ((int)aText) >> 15841912) & (((15841912 & ((int)aText) >> 15841912)) << (32-as. 
                
            
            
            
            
            
               
            )) | (((15841912 & ((int)aText) >> 15841912)) << as. 
                
            
            
            
            
            
               
            )) & ((int)((15841912 )) | ((((((15841912 & ((int)aText) >> 15841912) & (((15841912 & ((int)aText) >> 15841912)) << (32-as. 
                
            
            
            
            
            
               
            )) | (((15841912 & ((int)aText) >> 15841912)) << as. 
                
            
            
            
            
            
               
            )) & ((int)((15841912 ) << ((((15841912 & ((int)aText) >> 15841912) & (((15841912 & ((int)aText) >> 15841912)) << (32-as. 
                
            
            
            
            
            
               
            )) | (((15841912 & ((int)aText) >> 15841912)) << as. 
                
            
            
            
            
            
               
            )) & ((int)((15841912 ));
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
        public static SimpleJSON.JSONNode Parse(string aJSON)
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
            
            SimpleJSON.JSONArray val_3 = null;
            val_43 = val_3;
            val_3 = new SimpleJSON.JSONArray();
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
            
            SimpleJSON.JSONNode val_6 = SimpleJSON.JSONNode.op_Implicit(s:  1098586544);
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
            
            SimpleJSON.JSONClass val_7 = null;
            val_43 = val_7;
            val_7 = new SimpleJSON.JSONClass();
            label_13:
            Push(item:  461553664);
            if((SimpleJSON.JSONNode.op_Equality(a:  0, b:  0)) == true)
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
            
            SimpleJSON.JSONNode val_16 = SimpleJSON.JSONNode.op_Implicit(s:  1098586544);
            val_40 = val_40;
            val_38 = val_38;
            goto label_53;
            label_42:
            string val_18 = aJSON.Chars[0].ToString();
            string val_19 = 1098586544 + 1189500554;
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
            string val_22 = 1098586544 + 1189500554;
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
            
            var val_24 = 15849344 + (15849344 + ((val_23 - 110)) << 2);
            if(val_23 == '')
            {
                    15849344 + ((val_23 - 110)) << 2 = (15849344 + ((val_23 - 110)) << 2) & ((15849344 + ((val_23 - 110)) << 2) >> 32);
                15849344 + ((val_23 - 110)) << 2 = (15849344 + ((val_23 - 110)) << 2) & ((IP) >> 32);
                15849344 + ((val_23 - 110)) << 2 = (15849344 + ((val_23 - 110)) << 2) & ((IP) >> 32);
                15849344 + ((val_23 - 110)) << 2 = (15849344 + ((val_23 - 110)) << 2) & ((IP) >> 32);
                15849344 + ((val_23 - 110)) << 2 = (15849344 + ((val_23 - 110)) << 2) & ((IP) << 2);
                15849344 + ((val_23 - 110)) << 2 = (15849344 + ((val_23 - 110)) << 2) & ((IP) >> 32);
                15849344 + ((val_23 - 110)) << 2 = (15849344 + ((val_23 - 110)) << 2) & ((15849344 + ((val_23 - 110)) << 2) << 2);
                15849344 + ((val_23 - 110)) << 2 = (15849344 + ((val_23 - 110)) << 2) & ((IP) >> 15849344);
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
            goto typeof(SimpleJSON.JSONNode).__il2cppRuntimeField_19C;
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
        public void SaveToFile(string aFileName)
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            val_7 = this;
            val_8 = 0;
            System.IO.DirectoryInfo val_2 = Directory;
            val_9 = new System.IO.FileInfo(fileName:  aFileName);
            System.IO.DirectoryInfo val_3 = System.IO.Directory.CreateDirectory(path:  32108544);
            System.IO.FileStream val_4 = System.IO.File.OpenWrite(path:  aFileName);
            this.SaveToStream(aData:  aFileName);
            if(aFileName != null)
            {
                    val_9 = 0;
                val_7 = 0;
                val_9 = val_9 + 1;
                val_7 = (uint)val_9 & 65535;
                val_10 = aFileName;
            }
            
            if(val_8 == 0)
            {
                    return;
            }
        
        }
        public string SaveToBase64()
        {
            var val_4;
            var val_5;
            var val_6;
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            this.SaveToStream(aData:  32747520);
            val_4 = val_1;
            string val_2 = System.Convert.ToBase64String(inArray:  32747520);
            System.IO.MemoryStream val_4 = null;
            if((mem[null + 178]) == 0)
            {
                goto label_4;
            }
            
            val_4 = 0;
            label_6:
            val_5 = 0;
            if((mem[null + 88] + 0) == null)
            {
                goto label_5;
            }
            
            val_4 = val_4 + 1;
            val_5 = (uint)val_4 & 65535;
            if(val_5 < (mem[null + 178]))
            {
                goto label_6;
            }
            
            label_4:
            val_6 = val_1;
            goto label_7;
            label_5:
            var val_3 = (mem[null + 88]) + 0;
            val_4 = val_4 + (((mem[null + 88] + 0) + 4) << 3);
            label_7:
            if(0 == 0)
            {
                    return;
            }
        
        }
        public static SimpleJSON.JSONNode Deserialize(System.IO.BinaryReader aReader)
        {
            var val_12;
            var val_13;
            System.IO.BinaryReader val_1 = aReader - 1;
            if(val_1 <= 6)
            {
                    var val_2 = 15851556 + (15851556 + ((aReader - 1)) << 2);
                if(val_1 == 6)
            {
                    15851556 = 15851556 & ((IP) << 15851556);
                15851556 = 15851556 & ((((15851556 & (IP) << 15851556)) << (32-15851556 + ((aReader - 1)) << 2)) | (((15851556 & (IP) << 15851556)) << 15851556 + ((aReader - 1)) << 2));
                mem2[0] = ((15851556 & (IP) << 15851556) & (((15851556 & (IP) << 15851556)) << (32-15851556 + ((aReader - 1)) << 2)) | (((15851556 & (IP) << 15851556)) << 15851556 + ((aReader - 1)) << 2)) + ((15851556 & (IP) << 15851556) & (((15851556 & (IP) << 15851556)) << (32-15851556 + ((aReader - 1)) << 2)) | (((15851556 & (IP) << 15851556)) << 15851556 + ((aReader - 1)) << 2));
                (((15851556 & (IP) << 15851556) & (((15851556 & (IP) << 15851556)) << (32-15851556 + ((aReader - 1)) << 2)) | (((15851556 & (IP) << 15851556)) << 15851556 + ((aReader - 1)) << 2)) + ((15851556 & (IP) << 15851556) & (((15851556 & (IP) << 15851556)) << (32-15851556 + ((aReader - 1)) << 2)) | (((15851556 & (IP) << 15851556)) << 15851556 + ((aReader - 1)) << 2))) & ((IP) >> 2) = 35644619 * ((((15851556 & (IP) << 15851556) & (((15851556 & (IP) << 15851556)) << (32-15851556 + ((aReader - 1)) << 2)) | (((15851556 & (IP) << 15851556)) << 15851556 + ((aReader - 1)) << 2)) + ((15851556 & (IP) << 15851556) & (((15851556 & (IP) << 15851556)) << (32-15851556 + ((aReader - 1)) << 2)) | (((15851556 & (IP) << 15851556)) << 15851556 + ((aReader - 1)) << 2))) & ((IP) >> 2));
                (((15851556 & (IP) << 15851556) & (((15851556 & (IP) << 15851556)) << (32-15851556 + ((aReader - 1)) << 2)) | (((15851556 & (IP) << 15851556)) << 15851556 + ((aReader - 1)) << 2)) + ((15851556 & (IP) << 15851556) & (((15851556 & (IP) << 15851556)) << (32-15851556 + ((aReader - 1)) << 2)) | (((15851556 & (IP) << 15851556)) << 15851556 + ((aReader - 1)) << 2))) & ((IP) >> 2) = ((((15851556 & (IP) << 15851556) & (((15851556 & (IP) << 15851556)) << (32-15851556 + ((aReader - 1)) << 2)) | (((15851556 & (IP) << 15851556)) << 15851556 + ((aReader - 1)) << 2)) + ((15851556 & (IP) << 15851556) & (((15851556 & (IP) << 15851556)) << (32-15851556 + ((aReader - 1)) << 2)) | (((15851556 & (IP) << 15851556)) << 15851556 + ((aReader - 1)) << 2))) & ((IP) >> 2)) & 570313904;
                (((15851556 & (IP) << 15851556) & (((15851556 & (IP) << 15851556)) << (32-15851556 + ((aReader - 1)) << 2)) | (((15851556 & (IP) << 15851556)) << 15851556 + ((aReader - 1)) << 2)) + ((15851556 & (IP) << 15851556) & (((15851556 & (IP) << 15851556)) << (32-15851556 + ((aReader - 1)) << 2)) | (((15851556 & (IP) << 15851556)) << 15851556 + ((aReader - 1)) << 2))) & ((IP) >> 2) = ((((15851556 & (IP) << 15851556) & (((15851556 & (IP) << 15851556)) << (32-15851556 + ((aReader - 1)) << 2)) | (((15851556 & (IP) << 15851556)) << 15851556 + ((aReader - 1)) << 2)) + ((15851556 & (IP) << 15851556) & (((15851556 & (IP) << 15851556)) << (32-15851556 + ((aReader - 1)) << 2)) | (((15851556 & (IP) << 15851556)) << 15851556 + ((aReader - 1)) << 2))) & ((IP) >> 2)) & (aReader >> 4);
            }
            
                val_12 = aReader;
                SimpleJSON.JSONArray val_3 = null;
                val_13 = val_3;
                val_3 = new SimpleJSON.JSONArray();
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
            
            string val_10 = 1190437120 + 461180928;
            System.Exception val_11 = new System.Exception(message:  1190437120);
        }
        public static SimpleJSON.JSONNode LoadFromCompressedFile(string aFileName)
        {
            System.Exception val_1 = new System.Exception(message:  1189849168);
        }
        public static SimpleJSON.JSONNode LoadFromCompressedStream(System.IO.Stream aData)
        {
            System.Exception val_1 = new System.Exception(message:  1189849168);
        }
        public static SimpleJSON.JSONNode LoadFromCompressedBase64(string aBase64)
        {
            System.Exception val_1 = new System.Exception(message:  1189849168);
        }
        public static SimpleJSON.JSONNode LoadFromStream(System.IO.Stream aData)
        {
            System.IO.Stream val_4;
            var val_5;
            var val_6;
            val_4 = aData;
            System.IO.BinaryReader val_1 = new System.IO.BinaryReader(input:  val_4);
            SimpleJSON.JSONNode val_2 = SimpleJSON.JSONNode.Deserialize(aReader:  31735808);
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
        public static SimpleJSON.JSONNode LoadFromFile(string aFileName)
        {
            var val_4;
            var val_5;
            var val_6;
            System.IO.FileStream val_1 = System.IO.File.OpenRead(path:  aFileName);
            SimpleJSON.JSONNode val_2 = SimpleJSON.JSONNode.LoadFromStream(aData:  aFileName);
            if(aFileName != null)
            {
                    val_4 = 0;
                val_5 = 0;
                val_4 = val_4 + 1;
                val_5 = (uint)val_4 & 65535;
                val_6 = aFileName;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        public static SimpleJSON.JSONNode LoadFromBase64(string aBase64)
        {
            System.Byte[] val_1 = System.Convert.FromBase64String(s:  aBase64);
            if((new System.IO.MemoryStream(buffer:  aBase64)) != 0)
            {
                    return SimpleJSON.JSONNode.LoadFromStream(aData:  32747520);
            }
            
            return SimpleJSON.JSONNode.LoadFromStream(aData:  32747520);
        }
        public JSONNode()
        {
        
        }
    
    }

}
