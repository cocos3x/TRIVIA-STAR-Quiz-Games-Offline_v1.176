using UnityEngine;

namespace WordPets
{
    public class WPTLevelData
    {
        // Fields
        public System.Collections.Generic.List<WordPets.ColData> colData;
        private int <totalInitialPets>k__BackingField;
        private int <petsExtra>k__BackingField;
        private int <chapter>k__BackingField;
        private int <level>k__BackingField;
        private float <crateChance>k__BackingField;
        private float <spiderWebChance>k__BackingField;
        private float <balloonChance>k__BackingField;
        private int <butterflyAmount>k__BackingField;
        
        // Properties
        public int totalInitialPets { get; set; }
        public int petsExtra { get; set; }
        public int petsRequired { get; }
        public int chapter { get; set; }
        public int level { get; set; }
        public float crateChance { get; set; }
        public float spiderWebChance { get; set; }
        public float balloonChance { get; set; }
        public int butterflyAmount { get; set; }
        
        // Methods
        public int get_totalInitialPets()
        {
            return (int)this.<totalInitialPets>k__BackingField;
        }
        protected void set_totalInitialPets(int value)
        {
            this.<totalInitialPets>k__BackingField = value;
        }
        public int get_petsExtra()
        {
            return (int)this.<petsExtra>k__BackingField;
        }
        private void set_petsExtra(int value)
        {
            this.<petsExtra>k__BackingField = value;
        }
        public int get_petsRequired()
        {
            int val_1 = this.<petsExtra>k__BackingField;
            val_1 = val_1 + (this.<totalInitialPets>k__BackingField);
            return (int)val_1;
        }
        public int get_chapter()
        {
            return (int)this.<chapter>k__BackingField;
        }
        private void set_chapter(int value)
        {
            this.<chapter>k__BackingField = value;
        }
        public int get_level()
        {
            return (int)this.<level>k__BackingField;
        }
        private void set_level(int value)
        {
            this.<level>k__BackingField = value;
        }
        public float get_crateChance()
        {
            return (float)S0;
        }
        private void set_crateChance(float value)
        {
            this.<crateChance>k__BackingField = ;
        }
        public float get_spiderWebChance()
        {
            return (float)S0;
        }
        private void set_spiderWebChance(float value)
        {
            this.<spiderWebChance>k__BackingField = ;
        }
        public float get_balloonChance()
        {
            return (float)S0;
        }
        private void set_balloonChance(float value)
        {
            this.<balloonChance>k__BackingField = ;
        }
        public int get_butterflyAmount()
        {
            return (int)this.<butterflyAmount>k__BackingField;
        }
        private void set_butterflyAmount(int value)
        {
            this.<butterflyAmount>k__BackingField = value;
        }
        private WPTLevelData()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.colData = null;
        }
        public WPTLevelData(WordPets.WPTLevelData copyData)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = copyData.ToSerializableDictionary();
        }
        public WPTLevelData(System.Collections.Generic.Dictionary<string, object> data)
        {
            object val_38;
            float val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            val_38 = data;
            this.colData = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_38 = new System.Object();
            WordPets.WPTGameEcon val_2 = WordPets.WPTGameEcon.Instance;
            val_39 = 1152921510392296080;
            if((val_38.ContainsKey(key:  -1640018224)) != false)
            {
                    object val_4 = val_38.Item[-1640018224];
                string val_5 = val_38.ToString();
                this.<level>k__BackingField = System.Int32.Parse(s:  val_38);
            }
            
            val_40 = 0;
            if((val_38.ContainsKey(key:  148221472)) != false)
            {
                    object val_8 = val_38.Item[148221472];
                string val_9 = val_38.ToString();
                bool val_11 = System.Int32.TryParse(s:  val_38, result: out  int val_10 = 148239032);
                val_40 = val_40;
            }
            
            this.<petsExtra>k__BackingField = 0;
            if((val_38.ContainsKey(key:  148221552)) != false)
            {
                    object val_13 = val_38.Item[148221552];
                string val_14 = val_38.ToString();
                bool val_16 = System.Int32.TryParse(s:  val_38, result: out  int val_15 = 148239028);
            }
            
            this.<totalInitialPets>k__BackingField = 0;
            this.colData = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            if((val_38.ContainsKey(key:  -1785508240)) == false)
            {
                goto label_14;
            }
            
            object val_19 = val_38.Item[-1785508240];
            val_41 = 0;
            if(val_38 != 0)
            {
                    val_41 = 0;
                if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    val_38 = 0;
            }
            
                val_41 = val_38;
            }
            
            val_42 = 0;
            goto label_18;
            label_25:
            if(val_38 <= val_42)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_37 = 0;
            val_43 = 0;
            val_37 = val_37 + 0;
            if(((0 + 0) + 16) != 0)
            {
                    if((((0 + 0) + 16 + 100 + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    (0 + 0) + 16 = 0;
            }
            
                val_43 = (0 + 0) + 16;
            }
            
            WordPets.ColData val_20 = new WordPets.ColData(columnId:  0, myData:  0);
            this.colData.Add(item:  398028800);
            val_42 = 1;
            label_18:
            if(val_42 < 0)
            {
                goto label_25;
            }
            
            val_38 = val_38;
            if((this.<totalInitialPets>k__BackingField) <= 0)
            {
                    this.<totalInitialPets>k__BackingField = (0 + WordPets.ColData.__il2cppRuntimeField_byval_arg);
            }
            
            label_14:
            if((val_38.ContainsKey(key:  148226752)) != false)
            {
                    string val_22 = val_38.Item[148226752];
                bool val_24 = System.Single.TryParse(s:  val_38, result: out  float val_23 = 1.287653E-33f);
            }
            
            this.<crateChance>k__BackingField = 1.102051E-39f;
            if((val_38.ContainsKey(key:  148226832)) != false)
            {
                    string val_26 = val_38.Item[148226832];
                bool val_28 = System.Single.TryParse(s:  val_38, result: out  float val_27 = 1.287652E-33f);
            }
            
            this.<spiderWebChance>k__BackingField = 5.00578E-39f;
            if((val_38.ContainsKey(key:  148226912)) != false)
            {
                    string val_30 = val_38.Item[148226912];
                bool val_32 = System.Single.TryParse(s:  val_38, result: out  float val_31 = 1.287652E-33f);
            }
            
            this.<balloonChance>k__BackingField = 1.998252E-42f;
            if((val_38.ContainsKey(key:  148226992)) != false)
            {
                    string val_34 = val_38.Item[148226992];
                bool val_36 = System.Int32.TryParse(s:  val_38, result: out  int val_35 = 148239012);
            }
            
            this.<butterflyAmount>k__BackingField = 0;
        }
        private System.Collections.Generic.Dictionary<string, object> ToSerializableDictionary()
        {
            var val_4;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  -1640018224, value:  13152256);
            Add(key:  148221472, value:  13152256);
            Add(key:  148221552, value:  13152256);
            val_4 = 0;
            goto label_4;
            label_10:
            if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) <= val_4)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + 0;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = (0 + 0) + 16.ToSerializableDictionary();
            Add(item:  (0 + 0) + 16);
            val_4 = 1;
            label_4:
            if(val_4 < null)
            {
                goto label_10;
            }
            
            Add(key:  -1785508240, value:  80883712);
            Add(key:  148226752, value:  15282176);
            Add(key:  148226832, value:  15282176);
            Add(key:  148226912, value:  15282176);
            Add(key:  148226992, value:  13152256);
        }
        public System.Collections.Generic.Dictionary<char, int> GetAllLettersCounter()
        {
            var val_10;
            char val_11;
            char val_12;
            var val_13;
            System.Collections.Generic.Dictionary<System.Char, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.Char, System.Int32>();
            List.Enumerator<T> val_2 = GetEnumerator();
            goto label_2;
            label_15:
            System.Char[] val_4 = val_3 + 28.ToCharArray();
            val_10 = val_3 + 28;
            val_12 = (val_3 + 28) + 16;
            val_13 = 0;
            goto label_5;
            label_14:
            val_11 = mem[(val_3 + 28 + 16)];
            val_11 = val_12;
            if((ContainsKey(key:  val_11)) != false)
            {
                    set_Item(key:  val_11, value:  Item[val_11] + 1);
            }
            else
            {
                    Add(key:  val_11, value:  1);
            }
            
            val_12 = val_12 + 2;
            val_13 = 1;
            label_5:
            if(val_13 < (val_3 + 28 + 12))
            {
                goto label_14;
            }
            
            label_2:
            if(MoveNext() == true)
            {
                goto label_15;
            }
            
            Dispose();
        }
        public string ToJSON()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = this.ToSerializableDictionary();
            return MiniJSON.Json.Serialize(obj:  148628032);
        }
        public void AddColumn(WordPets.ColData newColData)
        {
            this.colData.Insert(index:  newColData.<Id>k__BackingField, item:  newColData);
        }
        public void InitializeLetterData(bool useEasyLetters)
        {
            int val_38;
            var val_39;
            float val_40;
            string val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            char val_48;
            var val_50;
            float val_51;
            var val_52;
            System.Collections.Generic.List<UnityEngine.Vector2Int> val_1 = new System.Collections.Generic.List<UnityEngine.Vector2Int>();
            val_39 = 0;
            val_40 = val_1;
            goto label_1;
            label_18:
            if((mem[1152921513345651016] + 12) <= val_39)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_38 = mem[1152921513345651016] + 8;
            val_38 = val_38 + 0;
            val_41 = mem[(mem[1152921513345651016] + 8 + 0) + 16];
            val_41 = (mem[1152921513345651016] + 8 + 0) + 16;
            string val_2 = val_41.initialLetters;
            if((System.String.IsNullOrEmpty(value:  val_41)) == false)
            {
                goto label_5;
            }
            
            if(val_41 == 0)
            {
                goto label_6;
            }
            
            val_42 = val_41;
            val_41.InitializeTilePropertyData(colHeight:  (mem[1152921513345651016] + 8 + 0) + 16 + 12, tilePropData: out  string val_4 = 148857400);
            val_43 = 0;
            goto label_7;
            label_5:
            if(val_41 == 0)
            {
                goto label_8;
            }
            
            string val_5 = val_41.initialLetters;
            val_44 = val_41;
            goto label_9;
            label_6:
            val_42 = 12;
            0.InitializeTilePropertyData(colHeight:  0, tilePropData: out  string val_6 = 148857400);
            val_43 = 0;
            label_7:
            mem2[0] = val_43;
            val_45 = 0;
            goto label_10;
            label_15:
            if((val_41.IsTileCrate(rowIndex:  0)) != true)
            {
                    UnityEngine.Vector2Int val_8 = new UnityEngine.Vector2Int(x:  0, y:  0);
                Add(item:  new UnityEngine.Vector2Int() {m_X = val_8.m_X, m_Y = val_8.m_Y});
            }
            
            val_45 = 1;
            label_10:
            if(val_45 < val_42)
            {
                goto label_15;
            }
            
            goto label_16;
            label_8:
            string val_9 = 0.initialLetters;
            val_44 = 0;
            label_9:
            mem2[0] = val_44;
            label_16:
            val_39 = 1;
            label_1:
            if(val_39 < (mem[1152921513345651016] + 12))
            {
                goto label_18;
            }
            
            val_46 = val_1;
            System.Collections.Generic.Dictionary<System.Char, System.Int32> val_10 = new System.Collections.Generic.Dictionary<System.Char, System.Int32>();
            label_64:
            System.Collections.Generic.List<System.Char> val_11 = new System.Collections.Generic.List<System.Char>();
            val_42 = null;
            val_38 = 0;
            goto label_21;
            label_46:
            if( != false)
            {
                    char val_21 = WordPets.LetterGetter.getRandomEasyLetter(letterOccuranceCounter:  478302960);
            }
            
            val_48 = WordPets.LetterGetter.getRandomLetter(letterOccuranceCounter:  478302960);
            if((ContainsKey(key:  (uint)val_48 & 65535)) != false)
            {
                    if((Item[(uint)val_48 & 65535]) > 2)
            {
                goto label_46;
            }
            
            }
            
            if(null == 0)
            {
                goto label_47;
            }
            
            if((ContainsKey(key:  (uint)val_48 & 65535)) == false)
            {
                goto label_50;
            }
            
            val_50 = Item[(uint)val_48 & 65535];
            goto label_49;
            label_47:
            val_41 = ContainsKey(key:  (uint)val_48 & 65535);
            if(val_41 == false)
            {
                goto label_50;
            }
            
            val_50 = Item[(uint)val_48 & 65535];
            label_49:
            set_Item(key:  (uint)val_48 & 65535, value:  val_50 + 1);
            goto label_51;
            label_50:
            Add(key:  (uint)val_48 & 65535, value:  1);
            label_51:
            Add(item:  (uint)val_48 & 65535);
            val_46 = val_1;
            if(((mem[1152921513345651016] + 8 + (val_12) << 2) + 16.IsTileSpiderweb(rowIndex:  List<T>.__il2cppRuntimeField_10.y)) != true)
            {
                    val_51 = null;
                val_41 = WordPets.WPTGameMode.GetLowerCharIndex(character:  (uint)val_48 & 65535);
                if(val_51 == 0)
            {
                    val_51 = null;
            }
            
                var val_31 = val_51 + (val_41 << 2);
                var val_40 = (val_51 + (val_30) << 2) + 16;
                val_40 = val_40 + 1;
                mem2[0] = val_40;
            }
            
            var val_33 = val_42 + ((WordPets.WPTGameMode.GetLowerCharIndex(character:  (uint)val_48 & 65535)) << 2);
            val_38 = val_38 + 1;
            var val_41 = (val_42 + (val_32) << 2) + 16;
            val_41 = val_41 + 1;
            mem2[0] = val_41;
            label_21:
            twelvegigs.Autopilot.AutopilotManager val_34 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_35 = TryFormWord(charCount:  478302960, requiredChar:  null);
            if((public static WPTWordList MonoSingleton<WPTWordList>::get_Instance()) == 0)
            {
                    if(100 > 0)
            {
                goto label_64;
            }
            
            }
            
            var val_43 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            int val_36 = List<T>.__il2cppRuntimeField_10.x;
            if((mem[1152921513345651016] + 12) <= val_36)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_42 = mem[1152921513345651016] + 8;
            val_42 = val_42 + (val_36 << 2);
            val_52 = val_11;
            val_38 = List<T>.__il2cppRuntimeField_10.y;
            if(val_52 == 0)
            {
                    val_52 = val_11;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_52 = val_11;
            val_41 = mem[1152921505700904960];
            (mem[1152921513345651016] + 8 + (val_36) << 2) + 16.ModifyTileLetter(tileIndex:  val_38, letter:  val_41);
            val_46 = val_1;
            val_40 = 16 + 8;
            val_42 = 16 + 2;
            val_43 = val_43 + 1;
        }
        private static System.Collections.Generic.List<int> GetColumnHeights(int colQty, bool forcedSymmetry)
        {
            int val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            int val_27;
            var val_28;
            int val_29;
            int val_30;
            int val_14 = colQty;
            val_19 = forcedSymmetry;
            WordPets.WPTGameEcon val_1 = WordPets.WPTGameEcon.Instance;
            val_20 = 0;
            System.Collections.Generic.List<System.Int32> val_2 = new System.Collections.Generic.List<System.Int32>(capacity:  val_14);
            if(val_19 == false)
            {
                goto label_1;
            }
            
            float val_3 = UnityEngine.Random.Range(min:  null, max:  null);
            if(val_20 == 0)
            {
                goto label_2;
            }
            
            val_21 = val_20;
            val_22 = 4;
            goto label_3;
            label_1:
            if(val_14 < 1)
            {
                    return;
            }
            
            val_23 = 1152921510720759024;
            do
            {
                if(val_20 != 0)
            {
                    val_24 = 4;
            }
            else
            {
                    val_24 = 4;
            }
            
                val_19 = UnityEngine.Random.Range(min:  4, max:  786450 + 1);
                Add(item:  val_19);
                val_14 = val_14 - 1;
            }
            while(null != 0);
            
            return;
            label_2:
            val_21 = 1480;
            val_22 = 4;
            label_3:
            int val_7 = UnityEngine.Random.Range(min:  4, max:  786450 + 1);
            float val_15 = 0.5f;
            val_23 = 0;
            val_15 = (float)val_14 * val_15;
            val_19 = UnityEngine.Mathf.CeilToInt(f:  val_15);
            int val_9 = val_19 - 1;
            if((val_7 - val_9) < 4)
            {
                    val_7 = 4 + val_9;
            }
            
            if(val_14 < 1)
            {
                    return;
            }
            
            val_21 = val_14 & 1;
            int val_11 = 1 - val_19;
            val_11 = val_7 + val_11;
            label_31:
            if(val_21 != 0)
            {
                goto label_13;
            }
            
            val_25 = null;
            if(val_21 > 0)
            {
                goto label_14;
            }
            
            if(val_9 >= val_23)
            {
                goto label_15;
            }
            
            val_27 = val_19;
            goto label_18;
            label_13:
            val_25 = null;
            if(val_21 > 0)
            {
                goto label_24;
            }
            
            label_15:
            val_27 = val_19 - 1;
            label_18:
            val_20 = UnityEngine.Mathf.Abs(value:  val_27);
            val_28 = public System.Void System.Collections.Generic.List<System.Int32>::Add(System.Int32 item);
            val_29 = val_11 + val_20;
            goto label_23;
            label_14:
            if(val_9 >= val_23)
            {
                goto label_24;
            }
            
            val_30 = val_19;
            goto label_27;
            label_24:
            val_30 = val_19 - 1;
            label_27:
            val_20 = UnityEngine.Mathf.Abs(value:  val_30);
            val_29 = val_7 - val_20;
            val_28 = public System.Void System.Collections.Generic.List<System.Int32>::Add(System.Int32 item);
            label_23:
            Add(item:  val_29);
            val_23 = val_23 + 1;
            val_19 = val_19 - 1;
            if(val_14 != val_23)
            {
                goto label_31;
            }
        
        }
        public static WordPets.WPTLevelData CreateRandom(int levelId)
        {
            var val_30;
            int val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            RandomSet val_36;
            var val_37;
            var val_38;
            var val_40;
            var val_41;
            WordPets.WPTGameEcon val_1 = WordPets.WPTGameEcon.Instance;
            WordPets.WPTLevelData val_2 = new WordPets.WPTLevelData();
            typeof(WordPets.WPTLevelData).__il2cppRuntimeField_18 = levelId;
            if(0 != 0)
            {
                    val_30 = 1360;
            }
            else
            {
                    val_30 = 1360;
            }
            
            val_31 = UnityEngine.Random.Range(min:  1360, max:  3572208 + 1);
            if(0 != 0)
            {
                    val_32 = 1373;
            }
            else
            {
                    val_32 = 1373;
            }
            
            typeof(WordPets.WPTLevelData).__il2cppRuntimeField_C = UnityEngine.Random.Range(min:  1373, max:  3574436 + 1);
            if(0 != 0)
            {
                    val_33 = 8;
            }
            else
            {
                    val_33 = 8;
            }
            
            typeof(WordPets.WPTLevelData).__il2cppRuntimeField_10 = UnityEngine.Random.Range(min:  8, max:  786450 + 1);
            if(0 != 0)
            {
                    val_34 = 0;
                typeof(WordPets.WPTLevelData).__il2cppRuntimeField_1C = 786450;
                typeof(WordPets.WPTLevelData).__il2cppRuntimeField_20 = 3572244;
            }
            else
            {
                    val_34 = 1516;
                typeof(WordPets.WPTLevelData).__il2cppRuntimeField_1C = 786450;
                typeof(WordPets.WPTLevelData).__il2cppRuntimeField_20 = 3572244;
            }
            
            typeof(WordPets.WPTLevelData).__il2cppRuntimeField_24 = 1426;
            var val_10 = 0 + 1504;
            if(0 <= 0)
            {
                    0 = 1;
            }
            
            System.Collections.Generic.List<System.Int32> val_11 = WordPets.WPTLevelData.GetColumnHeights(colQty:  val_31, forcedSymmetry:  true);
            RandomSet val_12 = new RandomSet();
            if(val_31 >= 1)
            {
                    var val_33 = 0;
                do
            {
                add(item:  0, weight:  UnityEngine.Random.Range(min:  null, max:  null));
                val_33 = val_33 + 1;
            }
            while(val_31 != val_33);
            
            }
            
            System.Collections.Generic.List<System.Int32> val_13 = new System.Collections.Generic.List<System.Int32>(capacity:  typeof(WordPets.WPTLevelData).__il2cppRuntimeField_C);
            var val_34 = 0;
            Add(item:  roll(unweighted:  false));
            val_34 = val_34 + 1;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_15 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_35 = val_2;
            typeof(WordPets.WPTLevelData).__il2cppRuntimeField_8 = null;
            if(val_31 >= 1)
            {
                    var val_36 = 0;
                do
            {
                if((val_4 + 12) <= val_36)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_35 = val_4 + 8;
                val_35 = val_35 + 0;
                bool val_16 = Contains(item:  0);
                System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_17 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
                Add(key:  149070464, value:  13152256);
                Add(key:  149070544, value:  8945664);
                WordPets.ColData val_18 = new WordPets.ColData(columnId:  0, myData:  78753792);
                val_35 = val_2;
                val_31 = val_31;
                AddColumn(newColData:  398028800);
                val_36 = val_36 + 1;
            }
            while(val_31 != val_36);
            
            }
            
            typeof(WordPets.WPTLevelData).__il2cppRuntimeField_28 = 0;
            val_36 = 1152921504866484224;
            RandomSet val_19 = new RandomSet();
            var val_37 = 0;
            val_37 = val_37 + 1512;
            add(item:  0, weight:  (float)val_37 * 100f);
            if(val_19 == 0)
            {
                    -D16 = -(-D16);
            }
            
            add(item:  1, weight:  (float)(1.102051E-39f) * 100f);
            float val_38 = 0f;
            val_38 = val_38 * 100f;
            if(val_19 != 0)
            {
                    if(val_19 == 0)
            {
                    -D16 = -(-D16);
            }
            
                add(item:  2, weight:  (float)val_38);
            }
            else
            {
                    if(val_19 == 0)
            {
                    -D16 = -(-D16);
            }
            
                val_36 = 1152921504866484224;
                add(item:  2, weight:  (float)val_38);
            }
            
            typeof(RandomSet).__il2cppRuntimeField_8 = 1;
            val_36 = new RandomSet();
            if(val_36 == 0)
            {
                    -D16 = -(-D16);
            }
            
            add(item:  0, weight:  (float)val_37 * 100f);
            float val_39 = 1.102051E-39f;
            val_39 = val_39 * 100f;
            if(val_36 != 0)
            {
                    if(val_36 == 0)
            {
                    -D16 = -(-D16);
            }
            
                add(item:  1, weight:  (float)val_39);
            }
            else
            {
                    if(val_36 == 0)
            {
                    -D16 = -(-D16);
            }
            
                val_36 = 1152921504866484224;
                add(item:  1, weight:  (float)val_39);
            }
            
            typeof(RandomSet).__il2cppRuntimeField_8 = 1;
            val_36 = new RandomSet();
            if(val_36 == 0)
            {
                    -D16 = -(-D16);
            }
            
            var val_40 = (5.00578E-39f) * 100f;
            val_40 = 10000 - val_40;
            add(item:  0, weight:  (float)val_40);
            float val_41 = 5.00578E-39f;
            val_37 = val_36;
            val_41 = val_41 * 100f;
            if(val_36 != 0)
            {
                    if(val_36 == 0)
            {
                    -D16 = -(-D16);
            }
            
                add(item:  1, weight:  (float)val_41);
            }
            else
            {
                    if(val_36 == 0)
            {
                    -D16 = -(-D16);
            }
            
                add(item:  1, weight:  (float)val_41);
            }
            
            typeof(RandomSet).__il2cppRuntimeField_8 = 1;
            val_38 = 0;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_25 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            System.Collections.Generic.List<System.Boolean> val_27 = new System.Collections.Generic.List<System.Boolean>();
            val_31 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            Add(item:  80883712);
            val_37 = 0 + 1;
            if((System.Collections.Generic.List<T>.__il2cppRuntimeField_namespaze) > 0)
            {
                    0 = 1;
            }
            
            val_31 = 16;
            if(0 > ((UnityEngine.Mathf.CeilToInt(f:  5.47031E+08f)) - 1))
            {
                    0 = 1;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            var val_30 =  - 16;
            val_37 = 0 + 1;
            val_40 = 0;
            val_41 = val_2;
            if( >= false)
            {
                    return;
            }
            
            val_41 = levelId;
        }
    
    }

}
