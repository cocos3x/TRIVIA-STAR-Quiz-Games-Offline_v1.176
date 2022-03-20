using UnityEngine;

namespace SLC.Wordlicious
{
    public class WOLLevel : WOLShape
    {
        // Fields
        private int <chapter>k__BackingField;
        private int <level>k__BackingField;
        private int <width>k__BackingField;
        private int <height>k__BackingField;
        private int <lettersCount>k__BackingField;
        private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Collections.Generic.List<SLC.Wordlicious.Tile>>> <words>k__BackingField;
        private SLC.Wordlicious.WOLLevelProgress <progress>k__BackingField;
        
        // Properties
        public int chapter { get; set; }
        public int level { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int lettersCount { get; set; }
        public int wordsCount { get; }
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Collections.Generic.List<SLC.Wordlicious.Tile>>> words { get; set; }
        public SLC.Wordlicious.WOLLevelProgress progress { get; set; }
        
        // Methods
        public int get_chapter()
        {
            return (int)this.<chapter>k__BackingField;
        }
        public void set_chapter(int value)
        {
            this.<chapter>k__BackingField = value;
        }
        public int get_level()
        {
            return (int)this.<level>k__BackingField;
        }
        public void set_level(int value)
        {
            this.<level>k__BackingField = value;
        }
        public int get_width()
        {
            return (int)this.<width>k__BackingField;
        }
        private void set_width(int value)
        {
            this.<width>k__BackingField = value;
        }
        public int get_height()
        {
            return (int)this.<height>k__BackingField;
        }
        private void set_height(int value)
        {
            this.<height>k__BackingField = value;
        }
        public int get_lettersCount()
        {
            return (int)this.<lettersCount>k__BackingField;
        }
        private void set_lettersCount(int value)
        {
            this.<lettersCount>k__BackingField = value;
        }
        public int get_wordsCount()
        {
            if((this.<words>k__BackingField) == 0)
            {
                    return 0;
            }
            
            return this.<words>k__BackingField.Count;
        }
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Collections.Generic.List<SLC.Wordlicious.Tile>>> get_words()
        {
        
        }
        private void set_words(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<System.Collections.Generic.List<SLC.Wordlicious.Tile>>> value)
        {
            this.<words>k__BackingField = value;
        }
        public SLC.Wordlicious.WOLLevelProgress get_progress()
        {
        
        }
        private void set_progress(SLC.Wordlicious.WOLLevelProgress value)
        {
            this.<progress>k__BackingField = value;
        }
        public WOLLevel(System.Collections.Generic.Dictionary<string, object> serialized)
        {
            this.Deserialize(serialized:  serialized);
            this.<progress>k__BackingField = new SLC.Wordlicious.WOLLevelProgress();
        }
        public WOLLevel(int[,] layout)
        {
            var val_7;
            int val_8;
            var val_10;
            int val_1 = layout.GetUpperBound(dimension:  1);
            val_1 = val_1 + 1;
            this.<width>k__BackingField = val_1;
            val_7 = 0;
            this.<height>k__BackingField = (layout.GetUpperBound(dimension:  0)) + 1;
            mem[1152921513904912776] = null;
            val_8 = this.<height>k__BackingField;
            if(val_8 >= 1)
            {
                    do
            {
                if((this.<width>k__BackingField) >= 1)
            {
                    var val_8 = 0;
                do
            {
                if((layout[this.<width>k__BackingField]) > 0)
            {
                    0 = 1;
            }
            
                val_10 = mem[SL + 8];
                val_10 = SL + 8;
                if(val_10 <= val_8)
            {
                    val_10 = mem[SL + 8];
                val_10 = SL + 8;
            }
            
                val_10 = SL + (val_10 << 2);
                mem2[0] = new SLC.Wordlicious.Tile(x:  0, y:  0, isValid:  true);
                val_8 = val_8 + 1;
                int val_9 = layout[val_10];
                if(val_9 >= 1)
            {
                    val_9 = this.<lettersCount>k__BackingField;
                val_9 = val_9 + 1;
                this.<lettersCount>k__BackingField = val_9;
            }
            
            }
            while(val_8 < (this.<width>k__BackingField));
            
                val_8 = this.<height>k__BackingField;
            }
            
                val_7 = val_7 + 1;
            }
            while(val_7 < val_8);
            
            }
            
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.<words>k__BackingField = null;
            this.<progress>k__BackingField = new SLC.Wordlicious.WOLLevelProgress();
        }
        public WOLLevel(char[,] layout)
        {
            var val_7;
            int val_8;
            var val_10;
            var val_11;
            int val_1 = layout.GetUpperBound(dimension:  1);
            val_1 = val_1 + 1;
            this.<width>k__BackingField = val_1;
            val_7 = 0;
            this.<height>k__BackingField = (layout.GetUpperBound(dimension:  0)) + 1;
            mem[1152921513905098504] = null;
            val_8 = this.<height>k__BackingField;
            if(val_8 >= 1)
            {
                    do
            {
                if((this.<width>k__BackingField) >= 1)
            {
                    var val_8 = 0;
                do
            {
                SLC.Wordlicious.Tile val_4 = null;
                val_4 = new SLC.Wordlicious.Tile(x:  0, y:  0, letter:  layout[0]);
                val_10 = mem[SL + 8];
                val_10 = SL + 8;
                if(val_10 <= val_8)
            {
                    val_10 = mem[SL + 8];
                val_10 = SL + 8;
            }
            
                val_10 = SL + (val_10 << 2);
                mem2[0] = val_4;
                val_11 = mem[SL + 8 + 8 + 8];
                val_11 = SL + 8 + 8 + 8;
                if(val_11 <= val_8)
            {
                    val_11 = mem[SL + 8 + 8 + 8];
                val_11 = SL + 8 + 8 + 8;
            }
            
                val_11 = (SL + 8 + 8) + (val_11 << 2);
                val_8 = val_8 + 1;
                if(((SL + 8 + 8 + (SL + 8 + 8 + 8) << 2) + 16 + 19) != 0)
            {
                    (SL + 8 + 8 + (SL + 8 + 8 + 8) << 2) + 16 + 19 = this.<lettersCount>k__BackingField;
                (SL + 8 + 8 + (SL + 8 + 8 + 8) << 2) + 16 + 19 = ((SL + 8 + 8 + (SL + 8 + 8 + 8) << 2) + 16 + 19) + 1;
                this.<lettersCount>k__BackingField = (SL + 8 + 8 + (SL + 8 + 8 + 8) << 2) + 16 + 19;
            }
            
            }
            while(val_8 < (this.<width>k__BackingField));
            
                val_8 = this.<height>k__BackingField;
            }
            
                val_7 = val_7 + 1;
            }
            while(val_7 < val_8);
            
            }
            
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.<words>k__BackingField = null;
            this.<progress>k__BackingField = new SLC.Wordlicious.WOLLevelProgress();
        }
        public void AddLetters(System.Func<char> randomLetter)
        {
            int val_2;
            char val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            val_2 = this.<height>k__BackingField;
            if(val_2 < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            label_24:
            if((this.<width>k__BackingField) < 1)
            {
                goto label_2;
            }
            
            var val_2 = 0;
            label_23:
            val_4 = mem[R6 + 8];
            val_4 = R6 + 8;
            if(val_4 <= val_2)
            {
                    val_4 = mem[R6 + 8];
                val_4 = R6 + 8;
            }
            
            val_4 = R6 + (val_4 << 2);
            if(((R6 + (R6 + 8) << 2) + 16 + 19) == 0)
            {
                goto label_17;
            }
            
            val_5 = mem[R6 + 8];
            val_5 = R6 + 8;
            if(val_5 <= val_2)
            {
                    val_5 = mem[R6 + 8];
                val_5 = R6 + 8;
            }
            
            val_5 = R6 + (val_5 << 2);
            if(((R6 + (R6 + 8) << 2) + 16 + 20) == 0)
            {
                goto label_12;
            }
            
            val_6 = mem[R6 + 8];
            val_6 = R6 + 8;
            if(val_6 <= val_2)
            {
                    val_6 = mem[R6 + 8];
                val_6 = R6 + 8;
            }
            
            val_6 = R6 + (val_6 << 2);
            if(((R6 + (R6 + 8) << 2) + 16 + 24) == 0)
            {
                goto label_17;
            }
            
            label_12:
            val_7 = mem[R6 + 8];
            val_7 = R6 + 8;
            if(val_7 <= val_2)
            {
                    val_7 = mem[R6 + 8];
                val_7 = R6 + 8;
            }
            
            val_7 = R6 + (val_7 << 2);
            val_3 = randomLetter.Invoke();
            mem2[0] = val_3;
            label_17:
            val_2 = val_2 + 1;
            if(val_2 < (this.<width>k__BackingField))
            {
                goto label_23;
            }
            
            val_2 = this.<height>k__BackingField;
            label_2:
            val_3 = val_3 + 1;
            if(val_3 < val_2)
            {
                goto label_24;
            }
        
        }
        public void LoadProgress()
        {
            this.<progress>k__BackingField = new SLC.Wordlicious.WOLLevelProgress();
            string val_2 = this.GetUniqueId();
            typeof(SLC.Wordlicious.WOLLevelProgress).__il2cppRuntimeField_10 = this;
            if((this.<progress>k__BackingField) == 0)
            {
                
            }
        
        }
        public void ResetProgress()
        {
            SLC.Wordlicious.WOLLevelProgress val_1 = new SLC.Wordlicious.WOLLevelProgress();
            this.<progress>k__BackingField = val_1;
            if(val_1 == 0)
            {
                
            }
        
        }
        public void AddWord(string word, System.Collections.Generic.List<SLC.Wordlicious.Tile> path)
        {
            var val_6;
            if((this.<words>k__BackingField.ContainsKey(key:  word)) != true)
            {
                    System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
                this.<words>k__BackingField.Add(key:  word, value:  80883712);
            }
            
            System.Collections.Generic.List<System.Collections.Generic.List<SLC.Wordlicious.Tile>> val_3 = this.<words>k__BackingField.Item[word];
            this.<words>k__BackingField.Add(item:  path);
            List.Enumerator<T> val_4 = GetEnumerator();
            label_13:
            if(MoveNext() == false)
            {
                goto label_7;
            }
            
            if(val_6 != 0)
            {
                    var val_8 = val_6 + 20;
                val_8 = val_8 + 1;
                mem2[0] = val_8;
            }
            else
            {
                    mem[20] = 2;
            }
            
            if((val_6 + 28.Contains(item:  word)) == true)
            {
                goto label_13;
            }
            
            val_6 + 28.Add(item:  word);
            goto label_13;
            label_7:
            Dispose();
        }
        public void ClearLevelGen()
        {
            int val_1;
            this.<words>k__BackingField.Clear();
            val_1 = this.<height>k__BackingField;
            if(val_1 < 1)
            {
                    return;
            }
            
            int val_1 = this.<width>k__BackingField;
            var val_3 = 0;
            do
            {
                if(val_1 >= 1)
            {
                    var val_2 = 0;
                do
            {
                val_1 = (this.<words>k__BackingField) + (val_1 << 2);
                mem2[0] = 0;
                val_1 = (this.<words>k__BackingField) + (val_1 << 2);
                mem2[0] = 0;
                val_1 = (this.<words>k__BackingField) + (val_1 << 2);
                mem2[0] = 0;
                val_1 = (this.<words>k__BackingField) + (val_1 << 2);
                this.<width>k__BackingField + 8 + 28.Clear();
                val_2 = val_2 + 1;
            }
            while(val_2 < (this.<width>k__BackingField));
            
                val_1 = this.<height>k__BackingField;
            }
            
                val_3 = val_3 + 1;
            }
            while(val_3 < val_1);
        
        }
        public System.Collections.Generic.List<SLC.Wordlicious.Tile> GetNeighbors(SLC.Wordlicious.Tile tile)
        {
            var val_1;
            if(tile != 0)
            {
                    return this.GetNeighbors(x:  0, y:  0);
            }
            
            val_1 = 0;
            return this.GetNeighbors(x:  0, y:  0);
        }
        public System.Collections.Generic.List<SLC.Wordlicious.Tile> GetNeighbors(int x, int y)
        {
            var val_10;
            var val_11;
            var val_12;
            int val_13;
            int val_14;
            var val_15;
            var val_16;
            var val_17;
            val_10 = y;
            val_11 = x;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            int val_10 = this.<width>k__BackingField;
            val_12 = System.Math.Max(val1:  val_10 - 1, val2:  0);
            val_10 = val_10 - 1;
            int val_11 = this.<height>k__BackingField;
            val_11 = val_11 - 1;
            goto label_3;
            label_20:
            val_14 = System.Math.Max(val1:  val_11 - 1, val2:  0);
            goto label_4;
            label_19:
            val_15 = mem[35636011];
            if(val_15 <= val_14)
            {
                    val_15 = mem[35636011];
            }
            
            val_10 = mem[mem[35636011] + 8];
            val_10 = mem[35636011] + 8;
            val_15 = 35636003 + (val_15 << 2);
            if(((35636003 + (mem[35636011]) << 2) + 16 + 19) != 0)
            {
                    val_16 = mem[(35636003 + (mem[35636011]) << 2) + 16 + 8];
                val_16 = (35636003 + (mem[35636011]) << 2) + 16 + 8;
                if(val_16 <= val_14)
            {
                    val_16 = mem[(35636003 + (mem[35636011]) << 2) + 16 + 8];
                val_16 = (35636003 + (mem[35636011]) << 2) + 16 + 8;
            }
            
                val_11 = mem[(35636003 + (mem[35636011]) << 2) + 16 + 8 + 8];
                val_11 = (35636003 + (mem[35636011]) << 2) + 16 + 8 + 8;
                val_16 = ((35636003 + (mem[35636011]) << 2) + 16) + (val_16 << 2);
                if((((35636003 + (mem[35636011]) << 2) + 16 + ((35636003 + (mem[35636011]) << 2) + 16 + 8) << 2) + 16 + 18) == 0)
            {
                    val_17 = mem[((35636003 + (mem[35636011]) << 2) + 16 + ((35636003 + (mem[35636011]) << 2) + 16 + 8) << 2) + 16 + 8];
                val_17 = ((35636003 + (mem[35636011]) << 2) + 16 + ((35636003 + (mem[35636011]) << 2) + 16 + 8) << 2) + 16 + 8;
                if(val_17 <= val_14)
            {
                    val_17 = mem[((35636003 + (mem[35636011]) << 2) + 16 + ((35636003 + (mem[35636011]) << 2) + 16 + 8) << 2) + 16 + 8];
                val_17 = ((35636003 + (mem[35636011]) << 2) + 16 + ((35636003 + (mem[35636011]) << 2) + 16 + 8) << 2) + 16 + 8;
            }
            
                val_11 = mem[((35636003 + (mem[35636011]) << 2) + 16 + ((35636003 + (mem[35636011]) << 2) + 16 + 8) << 2) + 16 + 8 + 8];
                val_11 = ((35636003 + (mem[35636011]) << 2) + 16 + ((35636003 + (mem[35636011]) << 2) + 16 + 8) << 2) + 16 + 8 + 8;
                val_17 = (((35636003 + (mem[35636011]) << 2) + 16 + ((35636003 + (mem[35636011]) << 2) + 16 + 8) << 2) + 16) + (val_17 << 2);
                Add(item:  (((35636003 + (mem[35636011]) << 2) + 16 + ((35636003 + (mem[35636011]) << 2) + 16 + 8) << 2) + 16 + (((35636003 + (mem[35636011]) << 2) + 16 + ((35636003 + (mem[35636011]) << 2) + 16 + 8) << 2) + 16  + 16);
            }
            
            }
            
            val_14 = val_14 + 1;
            label_4:
            if(val_14 <= (System.Math.Min(val1:  val_11 + 1, val2:  val_10)))
            {
                goto label_19;
            }
            
            val_12 = val_12 + 1;
            val_13 = System.Math.Min(val1:  val_10 + 1, val2:  val_11);
            label_3:
            if(val_12 <= val_13)
            {
                goto label_20;
            }
        
        }
        public bool IsValidLevel()
        {
            int val_1;
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            val_1 = this.<height>k__BackingField;
            if(val_1 >= 1)
            {
                    val_2 = 0;
                val_3 = 0;
                do
            {
                if((this.<width>k__BackingField) >= 1)
            {
                    val_4 = 0;
                do
            {
                val_5 = mem[R5 + 8];
                val_5 = R5 + 8;
                if(val_5 <= val_4)
            {
                    val_5 = mem[R5 + 8];
                val_5 = R5 + 8;
            }
            
                val_5 = R5 + (val_5 << 2);
                if(((R5 + (R5 + 8) << 2) + 16 + 19) != 0)
            {
                    val_6 = mem[R5 + 8];
                val_6 = R5 + 8;
                if(val_6 <= val_4)
            {
                    val_6 = mem[R5 + 8];
                val_6 = R5 + 8;
            }
            
                val_6 = R5 + (val_6 << 2);
                if(((R5 + (R5 + 8) << 2) + 16 + 20) == 0)
            {
                    return (bool)val_3;
            }
            
                val_7 = mem[(R5 + (R5 + 8) << 2) + 16 + 8];
                val_7 = (R5 + (R5 + 8) << 2) + 16 + 8;
                if(val_7 <= val_4)
            {
                    val_7 = mem[(R5 + (R5 + 8) << 2) + 16 + 8];
                val_7 = (R5 + (R5 + 8) << 2) + 16 + 8;
            }
            
                val_7 = ((R5 + (R5 + 8) << 2) + 16) + (val_7 << 2);
                if((((R5 + (R5 + 8) << 2) + 16 + ((R5 + (R5 + 8) << 2) + 16 + 8) << 2) + 16 + 24) != 0)
            {
                    return (bool)val_3;
            }
            
            }
            
                val_4 = val_4 + 1;
            }
            while(val_4 < (this.<width>k__BackingField));
            
                val_1 = this.<height>k__BackingField;
            }
            
                val_2 = val_2 + 1;
            }
            while(val_2 < val_1);
            
            }
            
            val_3 = 1;
            return (bool)val_3;
        }
        public bool IsValidTile(int x, int y)
        {
            var val_1 = mem[R6 + 8];
            val_1 = R6 + 8;
            if(val_1 <= x)
            {
                    val_1 = mem[R6 + 8];
                val_1 = R6 + 8;
            }
            
            val_1 = R6 + (val_1 << 2);
            if(((R6 + (R6 + 8) << 2) + 16) != 0)
            {
                    return (bool)(R6 + (R6 + 8) << 2) + 16 + 19;
            }
            
            return (bool)(R6 + (R6 + 8) << 2) + 16 + 19;
        }
        public SLC.Wordlicious.Tile GetTile(int x, int y)
        {
            var val_1 = mem[R6 + 8];
            val_1 = R6 + 8;
            if(val_1 <= x)
            {
                    val_1 = mem[R6 + 8];
                val_1 = R6 + 8;
            }
            
            val_1 = R6 + (val_1 << 2);
        }
        public string GridToString(bool wordsCounter = False)
        {
            int val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            string val_13;
            var val_14;
            val_8 = System.String.alignConst;
            if((this.<height>k__BackingField) < 1)
            {
                    return;
            }
            
            var val_9 = 0;
            label_16:
            if((this.<width>k__BackingField) < 1)
            {
                goto label_2;
            }
            
            var val_8 = 0;
            label_15:
            val_10 = mem[R8 + 8];
            val_10 = R8 + 8;
            if(val_10 <= val_8)
            {
                    val_10 = mem[R8 + 8];
                val_10 = R8 + 8;
            }
            
            val_10 = R8 + (val_10 << 2);
            if(wordsCounter == false)
            {
                goto label_7;
            }
            
            if(((R8 + (R8 + 8) << 2) + 16 + 19) == 0)
            {
                goto label_8;
            }
            
            val_11 = mem[(R8 + (R8 + 8) << 2) + 16 + 8];
            val_11 = (R8 + (R8 + 8) << 2) + 16 + 8;
            val_9 = wordsCounter;
            if(val_11 <= val_8)
            {
                    val_11 = mem[(R8 + (R8 + 8) << 2) + 16 + 8];
                val_11 = (R8 + (R8 + 8) << 2) + 16 + 8;
            }
            
            val_11 = ((R8 + (R8 + 8) << 2) + 16) + (val_11 << 2);
            var val_1 = (((R8 + (R8 + 8) << 2) + 16 + ((R8 + (R8 + 8) << 2) + 16 + 8) << 2) + 16) + 20;
            string val_2 = val_1.ToString();
            val_12 = val_1;
            goto label_14;
            label_7:
            var val_3 = ((R8 + (R8 + 8) << 2) + 16) + 16;
            string val_4 = val_3.ToString();
            val_12 = val_3;
            goto label_14;
            label_8:
            val_12 = "_";
            label_14:
            string val_5 = System.String.Format(format:  709645760, arg0:  2144339952);
            string val_6 = val_8 + 709645760;
            val_13 = val_8;
            val_8 = val_8 + 1;
            if(val_8 < (this.<width>k__BackingField))
            {
                goto label_15;
            }
            
            label_2:
            string val_7 = val_13 + 709645840;
            val_14 = val_13;
            val_9 = val_9 + 1;
            if(val_9 < (this.<height>k__BackingField))
            {
                goto label_16;
            }
        
        }
        public string GetUniqueId()
        {
            int val_10;
            Dictionary.KeyCollection<TKey, TValue> val_1 = this.<words>k__BackingField.Keys;
            System.Collections.Generic.List<ZooTile> val_2 = new System.Collections.Generic.List<ZooTile>(collection:  this.<words>k__BackingField);
            Sort();
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_10 = this.<height>k__BackingField;
            if(val_10 >= 1)
            {
                    var val_11 = 0;
                do
            {
                if((this.<width>k__BackingField) >= 1)
            {
                    var val_10 = 0;
                do
            {
                string val_5 = (0x1000000009AA2000.__il2cppRuntimeField_FD0 + 16).ToString();
                Add(item:  (0x1000000009AA2000.__il2cppRuntimeField_FD0 + 16));
                val_10 = val_10 + 1;
            }
            while(val_10 < (this.<width>k__BackingField));
            
                val_10 = this.<height>k__BackingField;
            }
            
                val_11 = val_11 + 1;
            }
            while(val_11 < val_10);
            
            }
            
            if(null != 0)
            {
                    Sort();
            }
            else
            {
                    Sort();
            }
            
            T[] val_6 = ToArray();
            string val_7 = System.String.Join(separator:  1492657312, value:  80883712);
            T[] val_8 = ToArray();
            string val_9 = System.String.Join(separator:  1492657312, value:  80883712);
            return System.String.Format(format:  709762016, arg0:  1492657312, arg1:  1492657312);
        }
        public System.Collections.Generic.Dictionary<string, object> Serialize()
        {
            twelvegigs.sweepstakes.Distribution val_13;
            float val_17;
            var val_18;
            SLC.Wordlicious.WOLLevel val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            val_17 = 1152921510535002416;
            Add(key:  -1785508240, value:  13152256);
            Add(key:  -1640018224, value:  13152256);
            Add(key:  1701554208, value:  13152256);
            Add(key:  1701554288, value:  13152256);
            System.Collections.Generic.List<System.Char> val_2 = new System.Collections.Generic.List<System.Char>();
            val_18 = mem[1152921513906690024];
            val_19 = this;
            if(val_18 >= 1)
            {
                    var val_18 = 0;
                do
            {
                if(mem[1152921513906690020] >= 1)
            {
                    var val_17 = 0;
                do
            {
                val_20 = mem[mem[1152921513906690008] + 8];
                val_20 = mem[1152921513906690008] + 8;
                if(val_20 <= val_17)
            {
                    val_20 = mem[mem[1152921513906690008] + 8];
                val_20 = mem[1152921513906690008] + 8;
            }
            
                val_17 = mem[mem[1152921513906690008] + 8 + 8];
                val_17 = mem[1152921513906690008] + 8 + 8;
                val_20 = mem[1152921513906690008] + (val_20 << 2);
                if(((mem[1152921513906690008] + (mem[1152921513906690008] + 8) << 2) + 16 + 19) != 0)
            {
                    val_21 = mem[mem[1152921513906690008] + 8];
                val_21 = mem[1152921513906690008] + 8;
                if(val_21 <= val_17)
            {
                    val_21 = mem[mem[1152921513906690008] + 8];
                val_21 = mem[1152921513906690008] + 8;
            }
            
                val_21 = mem[1152921513906690008] + (val_21 << 2);
                val_22 = mem[(mem[1152921513906690008] + (mem[1152921513906690008] + 8) << 2) + 16 + 16];
                val_22 = (mem[1152921513906690008] + (mem[1152921513906690008] + 8) << 2) + 16 + 16;
                val_19 = this;
            }
            else
            {
                    val_22 = 95;
            }
            
                Add(item:  '_');
                val_17 = val_17 + 1;
            }
            while(val_17 < mem[1152921513906690020]);
            
                val_18 = mem[1152921513906690024];
            }
            
                val_18 = val_18 + 1;
            }
            while(val_18 < val_18);
            
            }
            
            Add(key:  709878208, value:  80883712);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Dictionary.Enumerator<TKey, TValue> val_4 = mem[1152921513906690012].GetEnumerator();
            label_44:
            if(0.MoveNext() == false)
            {
                goto label_22;
            }
            
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_6 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            List.Enumerator<T> val_7 = mem[1152921513906690012].GetEnumerator();
            label_35:
            if(MoveNext() == false)
            {
                goto label_24;
            }
            
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_10 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            List.Enumerator<T> val_11 = mem[1152921513906690012].GetEnumerator();
            label_29:
            if(MoveNext() == false)
            {
                goto label_26;
            }
            
            string val_14 = val_13.SerializePos();
            Add(item:  val_13);
            goto label_29;
            label_26:
            var val_19 = 0;
            val_19 = val_19 + 1;
            mem2[0] = 327;
            Dispose();
            if(val_19 != 1)
            {
                    if(val_19 > 1)
            {
                    0 = 1;
            }
            
                var val_20 = 709896256 + ((0 + 1)) << 2;
                val_20 = val_20 - 327;
                val_20 = val_20 >> 5;
                val_20 = 1 & val_20;
                val_23 = val_19 - val_20;
            }
            else
            {
                    val_23 = 0;
            }
            
            T[] val_15 = ToArray();
            string val_16 = System.String.Join(separator:  -2100450224, value:  80883712);
            Add(item:  -2100450224);
            goto label_35;
            label_24:
            var val_21 = val_23;
            val_21 = val_21 + 1;
            mem2[0] = 376;
            Dispose();
            var val_23 = val_21;
            if(val_23 != 1)
            {
                    if(val_23 > 1)
            {
                    0 = 1;
            }
            
                var val_22 = 709896256 + ((val_23 + 1)) << 2;
                val_22 = val_22 - 376;
                val_22 = val_22 >> 5;
                val_22 = 1 & val_22;
                val_23 = val_23 - val_22;
            }
            
            Add(key:  1179403647, value:  80883712);
            goto label_44;
            label_22:
            0.Dispose();
            Add(key:  -922441872, value:  78753792);
        }
        public void Deserialize(System.Collections.Generic.Dictionary<string, object> serialized)
        {
            var val_27;
            var val_35;
            int val_36;
            var val_37;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_45;
            var val_46;
            if((serialized.ContainsKey(key:  -1785508240)) != false)
            {
                    object val_2 = serialized.Item[-1785508240];
                string val_3 = serialized.ToString();
                mem[1152921513906806108] = System.Int32.Parse(s:  serialized);
            }
            
            if((serialized.ContainsKey(key:  -1640018224)) != false)
            {
                    object val_6 = serialized.Item[-1640018224];
                string val_7 = serialized.ToString();
                mem[1152921513906806112] = System.Int32.Parse(s:  serialized);
            }
            
            if((serialized.ContainsKey(key:  1701554208)) != false)
            {
                    object val_10 = serialized.Item[1701554208];
                string val_11 = serialized.ToString();
                mem[1152921513906806116] = System.Int32.Parse(s:  serialized);
            }
            
            if((serialized.ContainsKey(key:  1701554288)) != false)
            {
                    object val_14 = serialized.Item[1701554288];
                string val_15 = serialized.ToString();
                mem[1152921513906806120] = System.Int32.Parse(s:  serialized);
            }
            
            object val_17 = serialized.Item[709878208];
            val_35 = 0;
            if(serialized != 0)
            {
                    val_35 = 0;
                if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    serialized = 0;
            }
            
                val_35 = serialized;
            }
            
            mem[1152921513906806104] = null;
            mem[1152921513906806124] = 0;
            val_36 = mem[1152921513906806120];
            if(val_36 >= 1)
            {
                    val_37 = 0;
                var val_37 = 0;
                do
            {
                if(mem[1152921513906806116] >= 1)
            {
                    var val_36 = 0;
                do
            {
                if(0 <= val_37)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_35 = 0;
                val_35 = val_35 + 0;
                val_37 = val_37 + 1;
                val_36 = val_36 + 1;
                mem2[0] = new SLC.Wordlicious.Tile(x:  0, y:  0, letter:  (0 + 0) + 16.Chars[0]);
            }
            while(val_36 < mem[1152921513906806116]);
            
                val_36 = mem[1152921513906806120];
            }
            
                val_37 = val_37 + 1;
            }
            while(val_37 < val_36);
            
            }
            
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_20 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            mem[1152921513906806128] = null;
            string val_21 = serialized.Item[-922441872];
            val_39 = 0;
            Dictionary.Enumerator<TKey, TValue> val_22 = mem[1152921513906806116].GetEnumerator();
            label_87:
            if(0.MoveNext() == false)
            {
                goto label_39;
            }
            
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_24 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            if(65793 != 0)
            {
                    val_40 = null;
            }
            
            if(65793 != 0)
            {
                    val_40 = null;
                val_41 = 0;
                if(((mem[1768188873] + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_40)
            {
                    65793 = 0;
            }
            
                val_41 = 65793;
            }
            else
            {
                    val_41 = 0;
            }
            
            List.Enumerator<T> val_25 = mem[1152921513906806116].GetEnumerator();
            label_82:
            if(MoveNext() == false)
            {
                goto label_46;
            }
            
            typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
            System.String[] val_28 = val_27.Split(separator:  478563824);
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_29 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_42 = 0;
            var val_30 = val_27 + 16;
            goto label_51;
            label_80:
            typeof(System.Char[]).__il2cppRuntimeField_10 = 44;
            System.String[] val_31 = (val_27 + 16) + 0.Split(separator:  478563824);
            int val_32 = System.Int32.Parse(s:  (val_27 + 16) + 0 + 16);
            int val_33 = System.Int32.Parse(s:  (val_27 + 16) + 0 + 20);
            Add(item:  (mem[1152921513906806104] + (SLC.Wordlicious.Tile[,].__il2cppRuntimeField_name) << 2) + 16);
            val_45 = mem[(mem[1152921513906806104] + (SLC.Wordlicious.Tile[,].__il2cppRuntimeField_name) << 2) + 16];
            val_45 = (mem[1152921513906806104] + (SLC.Wordlicious.Tile[,].__il2cppRuntimeField_name) << 2) + 16;
            if(val_45 != 0)
            {
                    val_46 = mem[(mem[1152921513906806104] + (SLC.Wordlicious.Tile[,].__il2cppRuntimeField_name) << 2) + 16 + 20];
                val_46 = (mem[1152921513906806104] + (SLC.Wordlicious.Tile[,].__il2cppRuntimeField_name) << 2) + 16 + 20;
            }
            else
            {
                    val_45 = 20;
                val_46 = 1;
            }
            
            mem[20] = 2;
            if(((mem[1152921513906806104] + (SLC.Wordlicious.Tile[,].__il2cppRuntimeField_name) << 2) + 16 + 28.Contains(item:  1179403647)) != true)
            {
                    (mem[1152921513906806104] + (SLC.Wordlicious.Tile[,].__il2cppRuntimeField_name) << 2) + 16 + 28.Add(item:  1179403647);
            }
            
            val_42 = 1;
            label_51:
            if(val_42 < (val_27 + 12))
            {
                goto label_80;
            }
            
            Add(item:  80883712);
            goto label_82;
            label_46:
            var val_38 = 0;
            val_38 = val_38 + 1;
            mem2[0] = 653;
            Dispose();
            var val_40 = val_38;
            if(val_40 != 1)
            {
                    if(val_40 > 1)
            {
                    0 = 1;
            }
            
                var val_39 = 710012384 + ((0 + 1)) << 2;
                val_39 = val_39 - 653;
                val_39 = val_39 >> 5;
                val_39 = 1 & val_39;
                val_40 = val_40 - val_39;
            }
            
            Add(key:  1179403647, value:  80883712);
            goto label_87;
            label_39:
            0.Dispose();
        }
    
    }

}
