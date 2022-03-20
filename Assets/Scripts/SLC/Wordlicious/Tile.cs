using UnityEngine;

namespace SLC.Wordlicious
{
    public class Tile : IEquatable<SLC.Wordlicious.Tile>
    {
        // Fields
        public const char InvalidChar = '\x5f';
        public int x;
        public int y;
        public char letter;
        public bool visited;
        public bool isValid;
        public int fwords;
        public bool removedRepeated;
        public System.Collections.Generic.List<string> words;
        
        // Methods
        public Tile(int x, int y, bool isValid = False)
        {
            this.letter = 95;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.words = null;
            this.x = x;
            this.y = y;
            this.isValid = isValid;
        }
        public Tile(int x, int y, char letter)
        {
            this.letter = 95;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.words = null;
            this.x = x;
            if(static_value_021FC2E9 == true)
            {
                    letter - 95 = 1;
            }
            
            this.y = y;
            this.letter = letter;
            this.isValid = true;
        }
        public bool Equals(SLC.Wordlicious.Tile other)
        {
            var val_1 = 0;
            if(other == 0)
            {
                    return (bool)val_1;
            }
            
            if(this.x != IP)
            {
                    return (bool)val_1;
            }
            
            if(this.y != IP)
            {
                    return (bool)val_1;
            }
            
            val_1 = this.letter - val_1;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        public bool IsNeighbor(SLC.Wordlicious.Tile tile)
        {
            int val_1 = this.x - 35635946;
            if(System.Math.__il2cppRuntimeField_cctor_finished < 0)
            {
                    val_1 = 0 - val_1;
            }
            
            if(val_1 > 1)
            {
                    return false;
            }
            
            int val_2 = this.y - tile;
            if(System.Math.__il2cppRuntimeField_cctor_finished < 0)
            {
                    val_2 = 0 - val_2;
            }
            
            if(val_2 < 2)
            {
                    0 = 1;
            }
            
            return true;
        }
        public override string ToString()
        {
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            typeof(System.Object[]).__il2cppRuntimeField_18 = null;
            typeof(System.Object[]).__il2cppRuntimeField_1C = null;
            typeof(System.Object[]).__il2cppRuntimeField_20 = null;
            string val_1 = System.String.Format(format:  694997136, args:  472754880);
        }
        public string SerializePos()
        {
            string val_1 = System.String.Format(format:  -1953079376, arg0:  13152256, arg1:  13152256);
        }
        public System.Collections.Generic.Dictionary<string, object> Serialize()
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1884385248, value:  13152256);
            Add(key:  1884385328, value:  13152256);
            Add(key:  695221296, value:  9158656);
            Add(key:  695221376, value:  8945664);
            Add(key:  695221472, value:  8945664);
            Add(key:  695221568, value:  13152256);
            Add(key:  695221648, value:  8945664);
            Add(key:  -922441872, value:  this.words);
        }
        public void Deserialize(System.Collections.Generic.Dictionary<string, object> info)
        {
            string val_41;
            string val_42;
            float val_44;
            string val_45;
            val_42 = info;
            val_44 = 1152921510392296080;
            if((val_42.ContainsKey(key:  1884385248)) != false)
            {
                    object val_2 = val_42.Item[1884385248];
                string val_3 = val_42.ToString();
                bool val_5 = System.Int32.TryParse(s:  val_42, result: out  this.x);
            }
            
            if((val_42.ContainsKey(key:  1884385328)) != false)
            {
                    object val_7 = val_42.Item[1884385328];
                string val_8 = val_42.ToString();
                bool val_10 = System.Int32.TryParse(s:  val_42, result: out  this.y);
            }
            
            if((val_42.ContainsKey(key:  695221296)) != false)
            {
                    object val_12 = val_42.Item[695221296];
                string val_13 = val_42.ToString();
                val_45 = val_42;
                bool val_15 = System.Char.TryParse(s:  val_45, result: out  this.letter);
            }
            
            if((val_42.ContainsKey(key:  695221376)) != false)
            {
                    object val_17 = val_42.Item[695221376];
                string val_18 = val_42.ToString();
                val_45 = val_42;
                bool val_20 = System.Boolean.TryParse(value:  val_45, result: out  this.isValid);
            }
            
            if((val_42.ContainsKey(key:  695221472)) != false)
            {
                    object val_22 = val_42.Item[695221472];
                string val_23 = val_42.ToString();
                val_45 = val_42;
                bool val_25 = System.Boolean.TryParse(value:  val_45, result: out  this.visited);
            }
            
            if((val_42.ContainsKey(key:  695221568)) != false)
            {
                    object val_27 = val_42.Item[695221568];
                string val_28 = val_42.ToString();
                bool val_30 = System.Int32.TryParse(s:  val_42, result: out  this.fwords);
            }
            
            if((val_42.ContainsKey(key:  695221648)) != false)
            {
                    object val_32 = val_42.Item[695221648];
                string val_33 = val_42.ToString();
                val_45 = val_42;
                bool val_35 = System.Boolean.TryParse(value:  val_45, result: out  this.removedRepeated);
            }
            
            if((val_42.ContainsKey(key:  -922441872)) == false)
            {
                    return;
            }
            
            object val_37 = val_42.Item[-922441872];
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_38 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.words = null;
            val_42 = 0;
            List.Enumerator<T> val_39 = GetEnumerator();
            val_44 = 1152921510046813136;
            label_49:
            if(MoveNext() == false)
            {
                goto label_46;
            }
            
            this.words.Add(item:  val_41);
            goto label_49;
            label_46:
            Dispose();
        }
    
    }

}
