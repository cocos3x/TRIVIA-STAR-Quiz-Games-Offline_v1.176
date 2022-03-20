using UnityEngine;

namespace CrosswordCreator.Crossword
{
    public class Crossword
    {
        // Fields
        private int wMax;
        private int hMax;
        private int xOffset;
        private int yOffset;
        private int xWindow;
        private int yWindow;
        private char[,] board;
        private bool[,] isAvail;
        private int wDataMax;
        private int hDataMax;
        public System.Collections.Generic.Dictionary<string, CrosswordCreator.Crossword.WordTuple> WordTuples;
        private readonly int[] HORIZGAIN;
        private readonly int[] VERTGAIN;
        private const char EMPTY = '\x20';
        
        // Properties
        public char Item { get; set; }
        public int Width { get; }
        public int Height { get; }
        
        // Methods
        public Crossword(int maxWidth, int maxHeight)
        {
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.WordTuples = null;
            typeof(System.Int32[]).__il2cppRuntimeField_10 = 1;
            this.HORIZGAIN = null;
            typeof(System.Int32[]).__il2cppRuntimeField_14 = 1;
            this.VERTGAIN = null;
            this.wMax = maxWidth;
            this.hMax = maxHeight;
            maxHeight = 7 + (maxHeight << 1);
            this.wDataMax = 7 + (maxWidth << 1);
            this.hDataMax = maxHeight;
            this.board = null;
            this.isAvail = null;
            this.Reset();
        }
        public void Reset()
        {
            int val_3 = this.wDataMax;
            int val_1 = val_3 + (val_3 >> 31);
            int val_2 = this.hDataMax + (this.hDataMax >> 31);
            val_1 = val_1 >> 1;
            val_2 = val_2 >> 1;
            this.yWindow = 1;
            if(val_3 >= 1)
            {
                    var val_4 = 0;
                do
            {
                if(this.hDataMax >= 1)
            {
                    var val_3 = 0;
                do
            {
                this.board[this.hDataMax] = 32;
                val_3 = val_3 + 1;
                this.board[this.hDataMax][val_3] = 1;
            }
            while(val_3 < this.hDataMax);
            
                val_3 = this.wDataMax;
            }
            
                val_4 = val_4 + 1;
            }
            while(val_4 < val_3);
            
            }
            
            this.WordTuples.Clear();
            Crossword.Crosspoint.Clear();
        }
        public bool HasAvailableCrosspoints()
        {
            var val_3;
            if(this.WordTuples.Count != 0)
            {
                    if(Crossword.Crosspoint.Count > 0)
            {
                    val_3 = 1;
            }
            
                return (bool)val_3;
            }
            
            val_3 = 1;
            return (bool)val_3;
        }
        public bool AddWord(string word)
        {
            CrosswordCreator.Crossword.Crossword val_11;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_12;
            var val_13;
            var val_14;
            int val_15;
            int val_16;
            var val_17;
            val_11 = this;
            if(this.WordTuples.Count == 0)
            {
                goto label_2;
            }
            
            val_12 = null;
            val_12 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_13 = 0;
            val_14 = 1152921505010094080;
            goto label_3;
            label_19:
            val_15 = 0;
            Crosspoint val_3 = Crossword.Crosspoint.Get(index:  0);
            goto label_6;
            label_16:
            if(word.Chars[0] == 3)
            {
                    if((this.CanPlaceWord(word:  word, x:  0, y:  0, dir:  1, letterindex:  val_15)) != false)
            {
                    val_16 = this.HORIZGAIN[1.401298E-45f];
                int val_11 = this.VERTGAIN[1];
                CrosswordCreator.Crossword.WordTuple val_6 = new CrosswordCreator.Crossword.WordTuple(word:  word, x:  this.VERTGAIN, y:  0, dir:  1);
                val_12 = val_12;
                Add(item:  403140608);
                val_11 = val_11;
            }
            
            }
            
            val_15 = 1;
            label_6:
            if(val_15 < (word + 8))
            {
                goto label_16;
            }
            
            val_13 = 1;
            val_14 = 1152921505010094080;
            label_3:
            if(val_13 < Crossword.Crosspoint.Count)
            {
                goto label_19;
            }
            
            int val_8 = RandomSet.singleInRange(lowest:  0, highest:  1094062063);
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            this.PlaceWord(wt:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_8) << 2) + 16);
            val_17 = 1;
            return (bool);
            label_2:
            val_16 = val_11;
            val_11 = this.xOffset;
            val_12 = this.yOffset;
            val_17 = 1;
            val_15 = null;
            val_15 = new CrosswordCreator.Crossword.WordTuple(word:  word, x:  val_11, y:  val_12, dir:  RandomSet.singleInRange(lowest:  0, highest:  1));
            this.PlaceWord(wt:  403140608);
            return (bool);
        }
        public void Trim()
        {
            var val_3;
            var val_11;
            var val_13;
            var val_14;
            float val_15;
            int val_16;
            Dictionary.ValueCollection<TKey, TValue> val_1 = this.WordTuples.Values;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_2 = GetEnumerator();
            val_11 = 12;
            val_13 = 1152921513433235120;
            goto label_3;
            label_6:
            val_14 = val_3;
            if(val_14 != 0)
            {
                    val_15 = mem[val_3 + 16];
                val_15 = val_3 + 16;
                int val_11 = this.xOffset;
                val_11 = (val_3 + 16 + -4) - val_11;
                mem2[0] = val_11;
                val_16 = this.yOffset;
            }
            else
            {
                    mem[12] = 0 - this.xOffset;
                val_14 = 16;
                val_16 = this.yOffset;
                val_15 = 3.673424E-39f;
                val_13 = 1152921513433235120;
            }
            
            mem[16] = val_15 - val_16;
            label_3:
            if(MoveNext() == true)
            {
                goto label_6;
            }
            
            Dispose();
            if(this.yWindow <= this.xWindow)
            {
                    return;
            }
            
            this.xWindow = this.yWindow;
            this.yWindow = this.xWindow;
            Dictionary.ValueCollection<TKey, TValue> val_7 = this.WordTuples.Values;
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_8 = GetEnumerator();
            val_16 = 16;
            val_14 = 12;
            val_15 = 1152921504620371968;
            goto label_10;
            label_15:
            val_11 = val_3;
            if(val_11 != 0)
            {
                    mem2[0] = val_3 + 16;
                mem2[0] = val_3 + 12;
            }
            else
            {
                    mem[16] = mem[12];
                mem[12] = mem[16];
                val_13 = 1152921513433235120;
            }
            
            var val_9 = (val_3 + 20) - 1;
            if(val_9 < 0)
            {
                    val_9 = 1 - (val_3 + 20);
            }
            
            mem2[0] = val_9;
            label_10:
            if(MoveNext() == true)
            {
                goto label_15;
            }
            
            Dispose();
        }
        public override string ToString()
        {
            int val_7;
            int val_8;
            var val_9;
            int val_10;
            val_7 = this.yOffset;
            val_8 = this.yWindow;
            val_9 = "";
            if(val_7 >= (val_8 + val_7))
            {
                    return;
            }
            
            var val_10 = val_7;
            do
            {
                val_10 = this.xOffset;
                int val_7 = this.xWindow;
                val_7 = val_7 + val_10;
                if(val_10 < val_7)
            {
                    do
            {
                string val_2 = this.board[val_7][16].ToString();
                string val_3 = 1098586544 + this.board[val_7][16];
                val_9 = val_9;
                int val_9 = this.xOffset;
                val_10 = val_10 + 1;
                val_9 = this.xWindow + val_9;
            }
            while(val_10 < val_9);
            
                val_7 = this.yOffset;
                val_8 = this.yWindow;
            }
            
                int val_4 = val_7 + val_8;
                val_4 = val_4 - 1;
                if(val_10 < val_4)
            {
                    string val_5 = 1098586544 + 1269544832;
                val_9 = val_9;
                val_7 = this.yOffset;
                val_8 = this.yWindow;
            }
            
                val_10 = val_10 + 1;
            }
            while(val_10 < (val_8 + val_7));
        
        }
        public char get_Item(int i, int j)
        {
            int val_2 = j;
            val_2 = this.yOffset + val_2;
            int val_1 = this.xOffset + i;
            return (char)this.board[this];
        }
        public void set_Item(int i, int j, char value)
        {
            int val_2 = j;
            val_2 = this.yOffset + val_2;
            int val_1 = this.xOffset + i;
            this.board[this] = value;
        }
        public int get_Width()
        {
            return (int)this.xWindow;
        }
        public int get_Height()
        {
            return (int)this.yWindow;
        }
        private bool IsValidPosition(int x, int y)
        {
            int val_3;
            var val_4;
            int val_5;
            int val_2 = this.xWindow;
            val_2 = val_2 + this.xOffset;
            val_3 = val_2 - this.wMax;
            val_4 = 0;
            if(val_3 > x)
            {
                    return true;
            }
            
            val_3 = this.hMax;
            val_5 = this.yOffset;
            if((val_3 + val_5) > y)
            {
                    this.wMax = this.wMax + this.xOffset;
            }
            
            if(this.wMax <= x)
            {
                    return true;
            }
            
            int val_3 = this.yWindow;
            val_3 = val_3 + val_5;
            val_3 = val_3 - val_3;
            if(val_3 > y)
            {
                    return true;
            }
            
            val_5 = this.isAvail;
            val_3 = 0;
            if(val_5[val_4] == true)
            {
                    val_4 = 1;
            }
            
            return true;
        }
        private void ExtendWindow(int x, int y)
        {
            int val_3;
            int val_4;
            val_3 = this.xOffset;
            if(val_3 > x)
            {
                    this.xOffset = x;
                int val_1 = val_3 - x;
                val_3 = x;
                val_1 = val_1 + this.xWindow;
                this.xWindow = val_1;
            }
            
            val_4 = this.yOffset;
            if(val_4 > y)
            {
                    this.yOffset = y;
                int val_2 = val_4 - y;
                val_4 = y;
                val_2 = val_2 + this.yWindow;
                this.yWindow = val_2;
            }
            
            int val_3 = this.xWindow;
            val_3 = val_3 + val_3;
            if(val_3 <= x)
            {
                    x = x + 1;
                x = x - val_3;
                this.xWindow = x;
            }
            
            int val_4 = this.yWindow;
            val_4 = val_4 + val_4;
            if(val_4 <= y)
            {
                    val_4 = y + 1;
                val_4 = val_4 - val_4;
                this.yWindow = val_4;
            }
        
        }
        private bool CanPlaceWord(string word, int x, int y, int dir, int letterindex = 0)
        {
            int val_5;
            var val_6;
            int val_7;
            System.Char[,] val_9;
            System.Char[,] val_12;
            int val_14;
            int val_5 = this.HORIZGAIN[dir];
            int val_6 = this.VERTGAIN[dir];
            val_6 = 0;
            goto label_4;
            label_39:
            bool val_1 = this.IsValidPosition(x:  letterindex, y:  y);
            if(val_1 == false)
            {
                    return false;
            }
            
            char val_7 = this.board[val_1];
            if(val_7 != ' ')
            {
                    val_9 = this.board;
                char val_2 = word.Chars[0];
                if(val_9[val_7] != val_2)
            {
                    return false;
            }
            
            }
            
            if(this.board[val_2] == ' ')
            {
                    System.Int32[] val_12 = this.VERTGAIN;
                val_12 = this.board;
                int val_11 = this.HORIZGAIN[dir];
                val_11 = y - val_11;
                val_12 = letterindex - val_12[dir];
                val_14 = dir;
                if(val_12[this.HORIZGAIN[dir]] != ' ')
            {
                    return false;
            }
            
                val_9 = this.board;
                int val_14 = this.VERTGAIN[val_14];
                int val_15 = this.HORIZGAIN[val_14];
                val_15 = val_15 + y;
                val_14 = val_14 + letterindex;
                val_12 = dir;
                val_14 = letterindex;
                if(val_9[this.HORIZGAIN[val_14]] != ' ')
            {
                    return false;
            }
            
            }
            
            val_5 = this.HORIZGAIN[val_12] + val_14;
            val_6 = val_6 + 1;
            val_7 = this.VERTGAIN[val_12] + y;
            label_4:
            if(val_6 < (word + 8))
            {
                goto label_39;
            }
            
            val_12 = this.board;
            int val_19 = this.HORIZGAIN[dir];
            int val_20 = this.VERTGAIN[dir];
            int val_3 = letterindex + 1;
            val_14 = val_5;
            if(val_12[x] != ' ')
            {
                    return false;
            }
            
            bool val_4 = this.IsValidPosition(x:  val_14, y:  val_7);
            if(val_4 == false)
            {
                    return false;
            }
            
            char val_22 = this.board[val_4];
            val_22 = val_22 - 32;
            val_22 = val_22 >> 5;
            return (bool)val_22;
        }
        private void PlaceWord(CrosswordCreator.Crossword.WordTuple wt)
        {
            var val_9;
            CrosswordCreator.Crossword.Crossword val_32;
            CrosswordCreator.Crossword.WordTuple val_33;
            var val_34;
            int val_36;
            var val_37;
            CrosswordCreator.Crossword.Crossword val_38;
            var val_39;
            CrosswordCreator.Crossword.WordTuple val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            val_32 = this;
            val_33 = wt;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_34 = 0;
            goto label_1;
            label_16:
            int val_34 = this.HORIZGAIN[wt.dir];
            int val_35 = this.VERTGAIN[wt.dir];
            this.board[wt.y] = wt + 8.Chars[0];
            Crosspoint val_3 = Crossword.Crosspoint.GetAt(x:  35641537, y:  wt + 8);
            val_33 = val_33;
            val_32 = val_32;
            if(35641537 != 0)
            {
                    Add(item:  static_value_021FD8C1);
            }
            
            val_34 = 1;
            label_1:
            if(val_34 < (wt + 8 + 8))
            {
                goto label_16;
            }
            
            this.ExtendWindow(x:  wt + 12, y:  wt + 16);
            int val_36 = this.HORIZGAIN[wt + 20];
            int val_37 = this.VERTGAIN[wt + 20];
            var val_38 = wt + 8 + 8;
            val_38 = val_38 - 1;
            this.ExtendWindow(x:  (wt + 8 + 8) - 1, y:  wt + 12);
            int val_6 = (wt + 16) - (this.VERTGAIN[wt + 20]);
            this.MarkUnavailable(x:  (wt + 12) - (this.HORIZGAIN[wt + 20]), y:  val_6);
            int val_41 = this.HORIZGAIN[wt + 20];
            val_36 = mem[wt + 16];
            val_36 = wt + 16;
            val_37 = mem[wt + 8];
            val_37 = wt + 8;
            int val_42 = this.VERTGAIN[wt + 20];
            val_38 = val_32;
            this.MarkUnavailable(x:  0, y:  val_6);
            val_39 = val_1;
            if(val_39 == 0)
            {
                    val_39 = val_1;
            }
            
            List.Enumerator<T> val_7 = GetEnumerator();
            label_45:
            val_40 = val_33;
            if(MoveNext() == false)
            {
                goto label_34;
            }
            
            if(val_9 != 0)
            {
                    val_41 = val_9;
                val_42 = mem[val_9 + 8];
                val_42 = val_9 + 8;
            }
            else
            {
                    val_41 = 8;
                val_42 = 0;
            }
            
            this.MarkUnavailable(x:  0, y:  val_9 + 12);
            if((this.IsLettercorner(x:  -1, y:  (val_9 + 12) - 1)) != false)
            {
                    this.MarkUnavailable(x:  -1, y:  (val_9 + 12) - 1);
            }
            
            if((this.IsLettercorner(x:  1, y:  (val_9 + 12) - 1)) != false)
            {
                    this.MarkUnavailable(x:  1, y:  (val_9 + 12) - 1);
            }
            
            if((this.IsLettercorner(x:  -1, y:  (val_9 + 12) + 1)) != false)
            {
                    this.MarkUnavailable(x:  -1, y:  (val_9 + 12) + 1);
            }
            
            if((this.IsLettercorner(x:  1, y:  (val_9 + 12) + 1)) != false)
            {
                    this.MarkUnavailable(x:  1, y:  (val_9 + 12) + 1);
            }
            
            if((this.IsSandwiched(x:  0, y:  (val_9 + 12) - 1, dir:  0)) != false)
            {
                    this.MarkUnavailable(x:  0, y:  (val_9 + 12) - 1);
            }
            
            if((this.IsSandwiched(x:  0 + 1, y:  val_9 + 12, dir:  1)) != false)
            {
                    this.MarkUnavailable(x:  1, y:  val_9 + 12);
            }
            
            if((this.IsSandwiched(x:  0, y:  (val_9 + 12) + 1, dir:  0)) != false)
            {
                    this.MarkUnavailable(x:  0, y:  (val_9 + 12) + 1);
            }
            
            if((this.IsSandwiched(x:  0 - 1, y:  val_9 + 12, dir:  1)) == false)
            {
                goto label_45;
            }
            
            this.MarkUnavailable(x:  -1, y:  val_9 + 12);
            goto label_45;
            label_34:
            Dispose();
            val_43 = 0;
            goto label_46;
            label_62:
            int val_43 = this.HORIZGAIN[wt + 20];
            val_38 = val_32;
            val_44 = mem[mem[1152921513435958804] + 8];
            val_44 = mem[1152921513435958804] + 8;
            val_40 = val_33;
            if(val_44 <= val_36)
            {
                    val_44 = mem[mem[1152921513435958804] + 8];
                val_44 = mem[1152921513435958804] + 8;
            }
            
            val_37 = mem[mem[1152921513435958804] + 8 + 8];
            val_37 = mem[1152921513435958804] + 8 + 8;
            val_44 = mem[1152921513435958804] + val_44;
            if(((mem[1152921513435958804] + mem[1152921513435958804] + 8) + 16) != 0)
            {
                    val_37 = mem[wt + 20];
                val_37 = wt + 20;
                int val_33 = val_37 - 1;
                if(val_33 < 0)
            {
                    val_33 = 1 - val_37;
            }
            
                Crossword.Crosspoint.Add(x:  val_36, y:  this.VERTGAIN[wt + 20], l:  wt + 8.Chars[0], dir:  val_33);
                val_38 = val_32;
            }
            
            val_43 = 1;
            label_46:
            if(val_43 < (wt + 8 + 8))
            {
                goto label_62;
            }
            
            mem[1152921513435958816].Add(key:  wt + 8, value:  val_40);
        }
        private bool IsLettercorner(int x, int y)
        {
            System.Char[,] val_9;
            var val_11;
            char val_8 = this.board[this];
            if(val_8 != ' ')
            {
                    val_9 = this.board;
                int val_2 = x + 1;
                val_11 = 1;
                if(val_9[val_8] != ' ')
            {
                    return true;
            }
            
            }
            
            int val_3 = x + 1;
            char val_10 = this.board[val_11];
            if(val_10 != ' ')
            {
                    val_9 = this.board;
                int val_4 = y + 1;
                val_11 = 1;
                if(val_9[val_10] != ' ')
            {
                    return true;
            }
            
            }
            
            int val_5 = y + 1;
            char val_12 = this.board[val_11];
            if(val_12 != ' ')
            {
                    val_9 = this.board;
                int val_6 = x - 1;
                val_11 = 1;
                if(val_9[val_12] != ' ')
            {
                    return true;
            }
            
            }
            
            val_9 = this.board;
            int val_7 = x - 1;
            val_11 = 0;
            if(val_9[val_11] == ' ')
            {
                    return true;
            }
            
            char val_15 = this.board[val_11];
            val_15 = val_15 - 32;
            if(0 != (y - 1))
            {
                    val_11 = 1;
            }
            
            return true;
        }
        private bool IsSandwiched(int x, int y, int dir)
        {
            var val_2;
            var val_3;
            var val_4;
            int val_2 = this.VERTGAIN[dir];
            val_2 = x - this.HORIZGAIN[dir];
            val_2 = y - val_2;
            val_4 = 0;
            if(this.isAvail[this.VERTGAIN[dir]] == true)
            {
                    return (bool)val_4;
            }
            
            int val_4 = this.HORIZGAIN[dir];
            val_3 = this.HORIZGAIN[dir] + y;
            val_4 = val_4 + x;
            val_4 = this.isAvail[this.HORIZGAIN[dir]] >> 5;
            return (bool)val_4;
        }
        private void MarkUnavailable(int x, int y)
        {
            this.isAvail[true] = false;
            Crossword.Crosspoint.Remove(x:  x, y:  y);
        }
        public int CountFreeSpaces()
        {
            int val_5;
            int val_6;
            var val_7;
            int val_8;
            val_5 = this.yOffset;
            val_6 = this.yWindow;
            val_7 = 0;
            if(val_5 >= (val_6 + val_5))
            {
                    return (int)val_7;
            }
            
            val_8 = this.xOffset;
            val_7 = 0;
            var val_6 = val_5;
            do
            {
                if(val_8 < (this.xWindow + val_8))
            {
                    do
            {
                val_8 = val_8 + 1;
                if(this.board[this.xWindow] == ' ')
            {
                    val_7 = val_7 + 1;
            }
            
            }
            while(val_8 < (this.xWindow + this.xOffset));
            
                val_5 = this.yOffset;
                val_8 = this.xOffset;
                val_6 = this.yWindow;
            }
            
                val_6 = val_6 + 1;
            }
            while(val_6 < (val_6 + val_5));
            
            return (int)val_7;
        }
    
    }

}
