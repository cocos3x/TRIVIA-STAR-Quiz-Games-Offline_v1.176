using UnityEngine;

namespace SLC.Minigames.WordFill
{
    public class WFLShapeDef
    {
        // Fields
        public System.Collections.Generic.List<char> grid;
        public int size;
        public string id;
        public int width;
        public int height;
        
        // Methods
        public WFLShapeDef(string data)
        {
            System.Collections.Generic.List<System.Char> val_14;
            System.Collections.Generic.IEnumerable<TSource> val_15;
            string val_16;
            var val_17;
            var val_18;
            string val_2 = data;
            System.Collections.Generic.List<System.Char> val_1 = new System.Collections.Generic.List<System.Char>();
            this.grid = null;
            val_2 = new System.Object();
            val_14 = null;
            typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
            System.String[] val_3 = val_2.Split(separator:  478563824);
            val_15 = val_2;
            string val_5 = Chars[0].ToString();
            this.size = System.Int32.Parse(s:  951786474);
            this.id = data.m_firstChar;
            if((System.Linq.Enumerable.Count<WGEventHandler>(source:  val_15)) < 2)
            {
                    return;
            }
            
            label_27:
            string val_8 = val_15 + 4;
            val_14 = null;
            typeof(System.Char[]).__il2cppRuntimeField_10 = 46;
            System.String[] val_9 = val_2.Split(separator:  478563824);
            val_16 = val_2;
            if(this.width == 0)
            {
                    val_16 = val_16;
                this.width = data.m_stringLength;
            }
            
            if(this.height == 0)
            {
                    this.height = System.Linq.Enumerable.Count<WGEventHandler>(source:  val_16);
            }
            
            val_17 = 0;
            goto label_19;
            label_26:
            string val_11 = val_16 + 0;
            val_18 = 0;
            goto label_21;
            label_24:
            val_14 = this.grid;
            val_14.Add(item:  (data + 0) + 16.Chars[0]);
            val_18 = 1;
            label_21:
            if(val_18 < ((data + 0) + 16 + 8))
            {
                goto label_24;
            }
            
            val_16 = val_16;
            val_17 = 1;
            label_19:
            if(val_17 < (data + 12))
            {
                goto label_26;
            }
            
            val_15 = val_15;
            if(2 < (System.Linq.Enumerable.Count<WGEventHandler>(source:  val_15)))
            {
                goto label_27;
            }
        
        }
        public SLC.Minigames.WordFill.WFLShape GenerateShape(string word)
        {
            var val_10;
            int val_11;
            int val_12;
            var val_13;
            int val_14;
            int val_15;
            int val_16;
            char val_17;
            val_10 = 1152921504866484224;
            int val_1 = RandomSet.singleInRange(lowest:  0, highest:  1);
            val_11 = this.width;
            val_12 = this.height;
            if(1 >= ((val_11 * val_12) << 1))
            {
                    if(this.grid == 0)
            {
                    val_11 = this.width;
                val_12 = this.height;
            }
            
                int val_3 = val_12 * val_11;
            }
            
            object val_6 = null;
            val_13 = val_6;
            val_6 = new System.Object();
            if(val_13 != 0)
            {
                    typeof(SLC.Minigames.WordFill.WFLShape).__il2cppRuntimeField_C = this.width;
                val_14 = this.height;
            }
            else
            {
                    mem[12] = this.width;
                val_14 = this.height;
            }
            
            typeof(SLC.Minigames.WordFill.WFLShape).__il2cppRuntimeField_10 = val_14;
            typeof(SLC.Minigames.WordFill.WFLShape).__il2cppRuntimeField_8 = null;
            val_15 = this.height;
            if(val_15 < 1)
            {
                    return;
            }
            
            val_16 = this.width;
            var val_11 = 0;
            do
            {
                if(val_16 >= 1)
            {
                    do
            {
                if((RandomSet.singleInRange(lowest:  0, highest:  this.grid - 1)) <= val_15)
            {
                    var val_10 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_10 = val_10 + (val_15 << 1);
                val_17 = 45;
                if(((0 + (this.height) << 1) + 16) != 45)
            {
                    string val_7 = (0 + (this.height) << 1) + 16.ToString();
                int val_8 = System.Int32.Parse(s:  951923050);
                if(val_1 == 1)
            {
                    val_1 = this.size;
                0 = 1 - val_8;
                val_8 = 0 + val_1;
            }
            
                0 = val_8 - 1;
                char val_9 = word.Chars[0];
                val_17 = val_9;
            }
            
                if(val_13 == 0)
            {
                    val_17 = val_9;
            }
            
                val_12 = typeof(SLC.Minigames.WordFill.WFLShape).__il2cppRuntimeField_8;
                val_13 = mem[System.Char[,].__il2cppRuntimeField_name + 8];
                val_13 = System.Char[,].__il2cppRuntimeField_name + 8;
                val_10 = 0 + 1;
                mem2[0] = val_17;
                val_16 = this.width;
                val_15 = this.height;
            }
            while(val_10 < val_16);
            
            }
            
                val_11 = val_11 + 1;
            }
            while(val_11 < val_15);
        
        }
    
    }

}
