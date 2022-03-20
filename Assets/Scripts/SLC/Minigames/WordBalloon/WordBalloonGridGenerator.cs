using UnityEngine;

namespace SLC.Minigames.WordBalloon
{
    public class WordBalloonGridGenerator
    {
        // Fields
        public const int MAXIMUM_GRID_WIDTH = 9;
        public const int MAXIMUM_GRID_HEIGHT = 11;
        private System.Collections.Generic.List<System.Collections.Generic.List<string>> gridContents;
        private System.Collections.Generic.List<SLC.Minigames.WordBalloon.WordBalloonGridSurface> horizontalSurfaceList;
        private System.Collections.Generic.List<SLC.Minigames.WordBalloon.WordBalloonGridSurface> verticalSurfaceList;
        private System.Collections.Generic.List<string> populatedWordsList;
        private System.Collections.Generic.List<SLC.Minigames.WordBalloon.WordSolutionData> gridSolutionData;
        private System.Collections.Generic.Dictionary<int, string> slotIdToWordCollection;
        private System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<int>> wordToSlotListCollection;
        private float[] weightageRow;
        private float[] weightageColumnModifier;
        private static SLC.Minigames.WordBalloon.WordBalloonGridGenerator instance;
        
        // Properties
        public static SLC.Minigames.WordBalloon.WordBalloonGridGenerator Instance { get; }
        
        // Methods
        public static SLC.Minigames.WordBalloon.WordBalloonGridGenerator get_Instance()
        {
            SLC.Minigames.WordBalloon.WordBalloonGridGenerator val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if(SLC.Minigames.WordBalloon.WordBalloonGridGenerator.instance == 0)
            {
                    val_2 = new SLC.Minigames.WordBalloon.WordBalloonGridGenerator();
                val_3 = null;
                val_3 = null;
                SLC.Minigames.WordBalloon.WordBalloonGridGenerator.instance = val_2;
                val_2 = null;
            }
            
            val_2 = null;
        }
        public WordBalloonGridGenerator()
        {
            this.weightageRow = null;
            this.weightageColumnModifier = null;
            this.InitRandomizerWeights();
        }
        private void InitRandomizerWeights()
        {
            var val_5;
            var val_6;
            var val_7;
            System.Single[] val_8;
            val_5 = 0;
            goto label_3;
            label_9:
            float val_5 = 0f;
            val_5 = ((float)UnityEngine.Mathf.RoundToInt(f:  null)) - val_5;
            float val_6 = System.Math.Abs(val_5);
            val_6 = val_6 / ((float)UnityEngine.Mathf.RoundToInt(f:  null));
            val_6 = 1f - val_6;
            float val_2 = DG.Tweening.DOVirtual.EasedValue(from:  val_6, to:  null, lifetimePercentage:  null, easeType:  1028443341);
            val_5 = 1;
            mem2[0] = 1028443341;
            label_3:
            if(val_5 < this.weightageColumnModifier[16])
            {
                goto label_9;
            }
            
            val_6 = 16;
            val_7 = 0;
            goto label_10;
            label_15:
            val_8 = this.weightageRow;
            if(this.weightageRow == null)
            {
                    val_8 = this.weightageRow;
            }
            
            this.weightageColumnModifier[16] = this.weightageColumnModifier[16] - 1;
            float val_7 = 0f;
            val_7 = val_7 / (float)this.weightageColumnModifier[16];
            float val_3 = DG.Tweening.DOVirtual.EasedValue(from:  val_7, to:  null, lifetimePercentage:  (float)this.weightageColumnModifier[16], easeType:  0);
            uint val_8 = 0;
            val_8 = (1f - val_8) * 100f;
            val_6 = 20;
            val_7 = 1;
            mem2[0] = val_8;
            label_10:
            if(val_7 < val_8[val_6])
            {
                goto label_15;
            }
        
        }
        private SLC.Minigames.WordBalloon.WordBalloonGridSurface GetRandomSurface(string wordToPlace)
        {
            var val_13;
            System.Predicate<ZooTile> val_14;
            var val_15;
            var val_16;
            object val_1 = new System.Object();
            typeof(WordBalloonGridGenerator.<>c__DisplayClass16_0).__il2cppRuntimeField_8 = wordToPlace;
            val_13 = 0;
            null = new RandomSet();
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.CalculateHorizontalSurfaces();
            this.CalculateVerticalSurfaces();
            System.Predicate<ZooTile> val_4 = new System.Predicate<ZooTile>(object:  451809280, method:  new IntPtr(987295216));
            System.Collections.Generic.List<T> val_5 = this.horizontalSurfaceList.FindAll(match:  8040448);
            goto label_3;
            label_7:
            if(this.horizontalSurfaceList <= val_13)
            {
                    var val_13 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_13 = val_13 + 0;
            Add(item:  (0 + 0) + 16);
            val_13 = 1;
            label_3:
            if(val_13 < null)
            {
                goto label_7;
            }
            
            val_14 = null;
            val_14 = new System.Predicate<ZooTile>(object:  451809280, method:  new IntPtr(987303408));
            System.Collections.Generic.List<T> val_7 = this.verticalSurfaceList.FindAll(match:  8040448);
            val_15 = 0;
            goto label_9;
            label_13:
            if(this.verticalSurfaceList <= val_15)
            {
                    var val_14 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_14 = val_14 + 0;
            val_14 = mem[(0 + 0) + 16];
            val_14 = (0 + 0) + 16;
            Add(item:  val_14);
            val_15 = 1;
            label_9:
            if(val_15 < null)
            {
                goto label_13;
            }
            
            val_16 = 0;
            int val_12 = roll(unweighted:  false);
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        private int GetRandomSurfaceIndexForWord(SLC.Minigames.WordBalloon.WordBalloonGridSurface targetSurface, int wordLength)
        {
            var val_6;
            RandomSet val_1 = null;
            val_6 = 0;
            val_1 = new RandomSet();
            goto label_1;
            label_9:
            add(item:  0, weight:  (float)UnityEngine.Mathf.RoundToInt(f:  (this.weightageColumnModifier[targetSurface.GetColumnIdBySurfaceIndex(index:  0)]) * 100f));
            val_6 = 1;
            label_1:
            int val_5 = targetSurface.Width;
            val_5 = val_5 - wordLength;
            if(val_6 < val_5)
            {
                goto label_9;
            }
            
            if(val_1 != 0)
            {
                    return roll(unweighted:  false);
            }
            
            return roll(unweighted:  false);
        }
        public SLC.Minigames.WordBalloon.WordBalloonLevelData Generate(System.Collections.Generic.List<string> wordList)
        {
            SLC.Minigames.WordBalloon.WordBalloonGridGenerator val_51;
            float val_52;
            var val_53;
            int val_55;
            int val_56;
            int val_57;
            var val_58;
            char* val_59;
            var val_61;
            float val_62;
            SLC.Minigames.WordBalloon.WordBalloonGridGenerator val_63;
            System.Collections.Generic.List<System.Collections.Generic.List<System.String>> val_64;
            UnityEngine.Material val_65;
            int val_66;
            SLC.Minigames.WordBalloon.WordBalloonGridGenerator val_67;
            SLC.Minigames.WordBalloon.WordBalloonGridGenerator val_68;
            System.Collections.Generic.List<System.Collections.Generic.List<System.String>> val_69;
            int val_70;
            SLC.Minigames.WordBalloon.WordBalloonGridGenerator val_71;
            var val_54 = 0;
            this.populatedWordsList = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.gridSolutionData = null;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.wordToSlotListCollection = null;
            System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_4 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
            this.slotIdToWordCollection = null;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_5 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.gridContents = null;
            val_51 = this;
            val_52 = 1152921511481194736;
            do
            {
                var val_53 = 11;
                do
            {
                Add(item:  0);
                val_53 = val_53 - 1;
            }
            while((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) != 0);
            
                this.gridContents.Add(item:  80883712);
                val_54 = val_54 + 1;
            }
            while(val_54 != 9);
            
            val_53 = 0;
            goto label_5;
            label_49:
            if(this.gridContents <= val_53)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            SLC.Minigames.WordBalloon.WordBalloonGridSurface val_7 = this.GetRandomSurface(wordToPlace:  List<T>.__il2cppRuntimeField_10);
            if(this.horizontalSurfaceList != 1)
            {
                goto label_8;
            }
            
            val_52 = this.FirstColumnIndex;
            if(this.gridContents != 0)
            {
                goto label_37;
            }
            
            string val_9 = this.GetGridContent(col:  val_52, row:  0);
            if((System.String.IsNullOrEmpty(value:  987844272)) == true)
            {
                goto label_37;
            }
            
            val_55 = 0;
            if(val_52 > 8)
            {
                goto label_14;
            }
            
            label_13:
            string val_11 = this.GetGridContent(col:  val_52, row:  this.gridContents);
            if((System.String.IsNullOrEmpty(value:  987844272)) == true)
            {
                goto label_12;
            }
            
            int val_13 = val_52 + 1;
            if(val_52 < 8)
            {
                goto label_13;
            }
            
            goto label_14;
            label_8:
            int val_14 = this.GetRandomSurfaceIndexForWord(targetSurface:  987844272, wordLength:  List<T>.__il2cppRuntimeField_10 + 8);
            val_56 = 0;
            goto label_24;
            label_20:
            string val_17 = this.GetGridContent(col:  null, row:  10);
            int val_19 = 10 - 1;
            if((System.String.IsNullOrEmpty(value:  987844272)) == false)
            {
                goto label_18;
            }
            
            string val_20 = this.GetGridContent(col:  null, row:  val_19);
            if((System.String.IsNullOrEmpty(value:  987844272)) == true)
            {
                goto label_19;
            }
            
            label_18:
            this.CutAndPasteGridContent(fromCol:  null, fromRow:  val_19, toCol:  null, toRow:  10);
            label_19:
            val_52 = this.gridContents;
            if(val_19 > val_52)
            {
                goto label_20;
            }
            
            string val_23 = List<T>.__il2cppRuntimeField_10.Chars[0].ToString();
            this.SetGridContent(col:  null, row:  val_52, newSlotLetterValue:  987832234, word:  List<T>.__il2cppRuntimeField_10, indexOfValueWithinWord:  val_56);
            val_56 = 1;
            goto label_24;
            label_12:
            val_55 = val_52;
            label_14:
            if((val_55 != 1) || (val_52 < 0))
            {
                goto label_27;
            }
            
            val_55 = val_52;
            label_28:
            string val_24 = this.GetGridContent(col:  val_55, row:  this.gridContents);
            if((System.String.IsNullOrEmpty(value:  987844272)) == true)
            {
                goto label_27;
            }
            
            int val_26 = val_55 - 1;
            if(val_55 > 0)
            {
                goto label_28;
            }
            
            val_55 = 0;
            label_27:
            if((val_55 - val_52) <= 1)
            {
                goto label_29;
            }
            
            if(val_55 <= val_52)
            {
                goto label_37;
            }
            
            do
            {
                System.Collections.Generic.List<System.Collections.Generic.List<System.String>> val_55 = this.gridContents;
                int val_28 = val_55 - 1;
                if(val_55 <= 10)
            {
                    do
            {
                string val_29 = this.GetGridContent(col:  val_28, row:  val_55);
                if((System.String.IsNullOrEmpty(value:  987844272)) != true)
            {
                    this.CutAndPasteGridContent(fromCol:  val_28, fromRow:  val_55, toCol:  0, toRow:  val_55);
            }
            
                val_55 = val_55 + 1;
            }
            while(val_55 != 11);
            
            }
            
            }
            while(val_28 > val_52);
            
            goto label_37;
            label_29:
            if(val_55 < val_52)
            {
                    do
            {
                System.Collections.Generic.List<System.Collections.Generic.List<System.String>> val_56 = this.gridContents;
                int val_31 = val_55 + 1;
                if(val_56 <= 10)
            {
                    do
            {
                string val_32 = this.GetGridContent(col:  val_31, row:  val_56);
                if((System.String.IsNullOrEmpty(value:  987844272)) != true)
            {
                    this.CutAndPasteGridContent(fromCol:  val_31, fromRow:  val_56, toCol:  0, toRow:  val_56);
            }
            
                val_56 = val_56 + 1;
            }
            while(val_56 != 11);
            
            }
            
            }
            while(val_31 != val_52);
            
            }
            
            label_37:
            val_57 = 0;
            label_24:
            Add(item:  List<T>.__il2cppRuntimeField_10);
            val_53 = 1;
            label_5:
            if(val_53 < (wordList + 12))
            {
                goto label_49;
            }
            
            val_58 = 0;
            val_59 = 0;
            val_61 = 0;
            val_62 = 1152921511111017856;
            val_63 = val_51;
            goto label_62;
            label_73:
            val_64 = this.gridContents;
            if(val_64 != 0)
            {
                
            }
            else
            {
                    val_64 = 0;
            }
            
            val_63 = val_51;
            if(val_61 >= 50331648)
            {
                goto label_65;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            var val_57 = 0;
            val_57 = val_57 + 0;
            val_66 = ((0 + 0) + 16 + 12) - 1;
            goto label_68;
            label_72:
            if(((0 + 0) + 16 + 8 + 12) <= val_61)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_58 = (0 + 0) + 16 + 8 + 8;
            val_58 = val_58 + 0;
            ((0 + 0) + 16 + 8 + 8 + 0) + 16.RemoveAt(index:  val_66);
            val_66 = val_66 - 1;
            label_68:
            val_63 = val_51;
            if(val_66 >= val_59)
            {
                goto label_72;
            }
            
            val_61 = 1;
            label_62:
            if(this.gridContents == 0)
            {
                goto label_73;
            }
            
            label_65:
            if(1152921505700909039 < 0)
            {
                goto label_75;
            }
            
            val_52 = 1152921511956665184;
            label_108:
            val_59 = 1152921505700909039;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_67 = val_51;
            if(mem[1152921505782185916] == 0)
            {
                goto label_82;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_67 = val_51;
            if((mem[1152921505782185916] + 12) < 1)
            {
                goto label_82;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if((mem[1152921505782185916] + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_68 = val_51;
            if((System.String.IsNullOrEmpty(value:  mem[1152921505782185916] + 8 + 16)) == false)
            {
                goto label_87;
            }
            
            label_82:
            val_69 = this.gridContents;
            if(val_69 != 0)
            {
                
            }
            else
            {
                    val_69 = this.gridContents;
                if(val_69 == 0)
            {
                    val_69 = 0;
            }
            
            }
            
            if(0 <= val_59)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_59 = 0;
            val_59 = val_59 + 81280956;
            object val_39 = null;
            val_62 = val_39;
            val_39 = new System.Object();
            val_63 = val_51;
            typeof(WordBalloonGridGenerator.<>c__DisplayClass18_0).__il2cppRuntimeField_8 = System.Collections.Generic.List<T>.__il2cppRuntimeField_namespaze;
            if((System.Collections.Generic.List<T>.__il2cppRuntimeField_namespaze) == val_59)
            {
                    1 = 2;
            }
            
            if((ContainsKey(key:  1094062064)) != false)
            {
                    System.TimeType val_42 = Item[1094062064];
                string val_43 = Item[78753792];
                System.Predicate<System.Int32> val_44 = new System.Predicate<System.Int32>(object:  451862528, method:  new IntPtr(987816176));
                if(this.wordToSlotListCollection != 0)
            {
                    val_70 = FindIndex(match:  8040448);
            }
            else
            {
                    val_70 = FindIndex(match:  8040448);
            }
            
                val_52 = 1152921511956665184;
                set_Item(index:  val_70, value:  1094062062);
                val_59 = val_59;
                if((ContainsKey(key:  1094062062)) != false)
            {
                    set_Item(key:  1094062062, value:  78753792);
            }
            
                Add(key:  1094062062, value:  78753792);
                bool val_48 = Remove(key:  1094062064);
            }
            
            typeof(WordBalloonGridGenerator.<>c__DisplayClass18_0).__il2cppRuntimeField_8 = 1152921505700909041;
            RemoveAt(index:  1094062063);
            label_87:
            val_65 = val_59;
            if(1152921505700909038 > 1)
            {
                goto label_108;
            }
            
            label_75:
            val_71 = val_51;
            if(1152921505700909039 >= 0)
            {
                    val_62 = 1152921513509191808;
                do
            {
                val_52 = 1152921505700909039;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_65 = mem[1152921505782185916];
                if((ContainsKey(key:  val_65)) != false)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_71 = val_51;
                val_59 = mem[1152921505782185916];
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                string val_50 = Item[mem[1152921505782185916]];
                object val_51 = new System.Object();
                typeof(SLC.Minigames.WordBalloon.WordSolutionData).__il2cppRuntimeField_8 = val_59;
                typeof(SLC.Minigames.WordBalloon.WordSolutionData).__il2cppRuntimeField_C = this.wordToSlotListCollection;
                val_65 = this.gridSolutionData;
                Add(item:  452075520);
            }
            
                val_61 = 1152921505700909042;
            }
            while(1152921505700909038 > 1);
            
            }
            
            SLC.Minigames.WordBalloon.WordBalloonLevelData val_52 = this.PackageEntireGridAsData();
        }
        private void CalculateVerticalSurfaces()
        {
            var val_9;
            var val_10;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.verticalSurfaceList = null;
            bool val_11 = false;
            var val_10 = 0;
            do
            {
                string val_2 = this.GetGridContent(col:  0, row:  0);
                val_10 = val_10 + 1;
                val_11 = val_11 + (System.String.IsNullOrEmpty(value:  988005424));
            }
            while(val_10 != 9);
            
            var val_13 = 0;
            label_12:
            if(val_11 > false)
            {
                    0 = 1;
            }
            
            var val_12 = 0;
            if(val_13 != 0)
            {
                    val_13 = 1;
            }
            
            label_11:
            string val_5 = this.GetGridContent(col:  0, row:  0);
            val_9 = System.String.IsNullOrEmpty(value:  988005424);
            if(val_13 != 0)
            {
                    string val_7 = this.GetGridContent(col:  0, row:  val_13 - 1);
                val_10 = (System.String.IsNullOrEmpty(value:  988005424)) ^ 1;
            }
            else
            {
                    val_10 = 1;
            }
            
            if(0 == 0)
            {
                    if(((val_10 & 1) != 0) || (val_10 != 1))
            {
                goto label_6;
            }
            
            }
            
            SLC.Minigames.WordBalloon.WordBalloonGridSurface val_9 = null;
            val_9 = val_9;
            val_9 = new SLC.Minigames.WordBalloon.WordBalloonGridSurface(_orientationType:  1, row:  0);
            if(val_9 != 0)
            {
                    typeof(SLC.Minigames.WordBalloon.WordBalloonGridSurface).__il2cppRuntimeField_14 = -1152921508452100469;
            }
            else
            {
                    mem[20] = 11;
            }
            
            SLC.Minigames.WordBalloon.WordBalloonGridSurface.__il2cppRuntimeField_byval_arg.Add(item:  0);
            this.verticalSurfaceList.Add(item:  451969024);
            label_6:
            val_12 = val_12 + 1;
            if(val_12 != 9)
            {
                goto label_11;
            }
            
            val_13 = val_13 + 1;
            if(val_13 != 11)
            {
                goto label_12;
            }
        
        }
        private void CalculateHorizontalSurfaces()
        {
            var val_9;
            int val_10;
            var val_11;
            var val_12;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            var val_11 = 0;
            mem[1152921514184903100] = null;
            label_18:
            val_9 = 0;
            var val_10 = 0;
            label_17:
            if(val_11 == 0)
            {
                goto label_1;
            }
            
            string val_3 = this.GetGridContent(col:  0, row:  val_11 - 1);
            bool val_4 = System.String.IsNullOrEmpty(value:  988121520);
            val_10 = this.GetAmountOfEmptySpacesBelowSlot(slotX:  0, slotY:  0);
            if(val_4 == false)
            {
                goto label_2;
            }
            
            bool val_6 = val_4 ^ 1;
            goto label_3;
            label_1:
            val_10 = this.GetAmountOfEmptySpacesBelowSlot(slotX:  0, slotY:  0);
            label_2:
            if(val_10 < 1)
            {
                goto label_10;
            }
            
            if(val_9 == 0)
            {
                    SLC.Minigames.WordBalloon.WordBalloonGridSurface val_8 = null;
                val_9 = val_8;
                val_8 = new SLC.Minigames.WordBalloon.WordBalloonGridSurface(_orientationType:  0, row:  0);
                if(val_9 != 0)
            {
                
            }
            else
            {
                    val_11 = 0;
            }
            
                typeof(SLC.Minigames.WordBalloon.WordBalloonGridSurface).__il2cppRuntimeField_14 = 11;
            }
            
            SLC.Minigames.WordBalloon.WordBalloonGridSurface.__il2cppRuntimeField_byval_arg.Add(item:  0);
            label_3:
            if((val_10 < 1) || (1 == 0))
            {
                goto label_10;
            }
            
            val_12 = UnityEngine.Mathf.Min(a:  val_10, b:  11);
            goto label_13;
            label_10:
            val_9 = 0;
            if((11 >= 1) && (val_9 != 0))
            {
                    Add(item:  0);
            }
            
            val_12 = 11;
            label_13:
            val_10 = val_10 + 1;
            if(val_10 != 9)
            {
                goto label_17;
            }
            
            val_11 = val_11 + 1;
            if(val_11 != 11)
            {
                goto label_18;
            }
        
        }
        private SLC.Minigames.WordBalloon.WordBalloonLevelData PackageEntireGridAsData()
        {
            var val_4;
            twelvegigs.sweepstakes.Distribution val_5;
            System.Collections.Generic.List<SLC.Minigames.WordBalloon.WordSolutionData> val_6;
            if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_7 = 0;
            val_4 = 4;
            goto label_5;
            label_22:
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            var val_5 = static_value_0028000B;
            val_5 = val_5 + 0;
            bool val_2 = System.String.IsNullOrEmpty(value:  (static_value_0028000B + 0) + 16);
            if(val_2 != false)
            {
                
            }
            else
            {
                    if(val_2 <= this.gridContents)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                var val_6 = static_value_0028000B;
                val_6 = val_6 + 0;
                val_5 = val_6 + 16;
            }
            
            Add(item:  val_5);
            val_4 = 5;
            label_5:
            if((val_4 - 4) < null)
            {
                goto label_22;
            }
            
            val_7 = val_7 + 1;
            if(new System.Object() != 0)
            {
                    typeof(SLC.Minigames.WordBalloon.WordBalloonLevelData).__il2cppRuntimeField_8 = null;
                typeof(SLC.Minigames.WordBalloon.WordBalloonLevelData).__il2cppRuntimeField_C = this.gridContents;
                typeof(SLC.Minigames.WordBalloon.WordBalloonLevelData).__il2cppRuntimeField_14 = this.populatedWordsList;
                val_6 = this.gridSolutionData;
            }
            else
            {
                    mem[12] = this.gridContents;
                mem[8] = null;
                mem[20] = this.populatedWordsList;
                val_6 = this.gridSolutionData;
            }
            
            typeof(SLC.Minigames.WordBalloon.WordBalloonLevelData).__il2cppRuntimeField_18 = val_6;
        }
        private int GetAmountOfEmptySpacesBelowSlot(int slotX, int slotY)
        {
            var val_2;
            System.Collections.Generic.List<System.Collections.Generic.List<System.String>> val_3;
            var val_4;
            val_2 = slotY;
            val_3 = this.gridContents;
            val_4 = 0;
            if(true <= slotX)
            {
                    return (int)val_4;
            }
            
            val_4 = 0;
            goto label_3;
            label_11:
            if(true <= slotX)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + (slotX << 2);
            if(((0 + (slotX) << 2) + 16 + 12) <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = (0 + (slotX) << 2) + 16 + 8;
            val_3 = val_3 + (val_2 << 2);
            bool val_1 = System.String.IsNullOrEmpty(value:  ((0 + (slotX) << 2) + 16 + 8 + (slotY) << 2) + 16);
            val_4 = val_4 + val_1;
            val_2 = val_2 + 1;
            label_3:
            if(val_1 <= slotX)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + (slotX << 2);
            val_3 = mem[(0 + (slotX) << 2) + 16];
            val_3 = (0 + (slotX) << 2) + 16;
            if(val_2 < ((0 + (slotX) << 2) + 16 + 12))
            {
                goto label_11;
            }
            
            return (int)val_4;
        }
        private string GetGridContent(int col, int row)
        {
            var val_1 = 0;
            if(true <= col)
            {
                    return;
            }
            
            if(true <= col)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (col << 2);
            if(((0 + (col) << 2) + 16 + 12) <= row)
            {
                    return;
            }
            
            if(((0 + (col) << 2) + 16 + 12) <= col)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + (col << 2);
            if(((0 + (col) << 2) + 16 + 12) <= row)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = (0 + (col) << 2) + 16 + 8;
            val_3 = val_3 + (row << 2);
            val_1 = mem[((0 + (col) << 2) + 16 + 8 + (row) << 2) + 16];
            val_1 = ((0 + (col) << 2) + 16 + 8 + (row) << 2) + 16;
        }
        private void SetGridContent(int col, int row, string newSlotLetterValue, string word, int indexOfValueWithinWord)
        {
            int val_7;
            var val_8;
            val_7 = col;
            int val_2 = (row + (row << 3)) + val_7;
            if((this.slotIdToWordCollection.ContainsKey(key:  val_2)) != false)
            {
                    this.slotIdToWordCollection.set_Item(key:  val_2, value:  word);
            }
            else
            {
                    this.slotIdToWordCollection.Add(key:  val_2, value:  word);
            }
            
            if((this.wordToSlotListCollection.ContainsKey(key:  word)) == true)
            {
                goto label_6;
            }
            
            System.Collections.Generic.List<System.Int32> val_5 = new System.Collections.Generic.List<System.Int32>();
            val_8 = 0;
            val_7 = 1152921510720759024;
            goto label_7;
            label_10:
            Add(item:  0);
            val_8 = 1;
            label_7:
            if(val_8 < word.m_stringLength)
            {
                goto label_10;
            }
            
            this.wordToSlotListCollection.Add(key:  word, value:  80883712);
            label_6:
            System.Collections.Generic.List<System.Int32> val_6 = this.wordToSlotListCollection.Item[word];
            this.wordToSlotListCollection.set_Item(index:  indexOfValueWithinWord, value:  val_2);
            this.SetGridContent(col:  val_7, row:  row, newSlotLetterValue:  newSlotLetterValue);
        }
        private void SetGridContent(int col, int row, string newSlotLetterValue)
        {
            if(true <= col)
            {
                    return;
            }
            
            if(true <= col)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (col << 2);
            if(((0 + (col) << 2) + 16 + 12) <= row)
            {
                    return;
            }
            
            if(((0 + (col) << 2) + 16 + 12) <= col)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + (col << 2);
            (0 + (col) << 2) + 16.set_Item(index:  row, value:  newSlotLetterValue);
        }
        private void CutAndPasteGridContent(int fromCol, int fromRow, int toCol, int toRow)
        {
            System.Collections.Generic.Dictionary<System.Int32, System.String> val_15;
            int val_16;
            System.Collections.Generic.Dictionary<System.Int32, System.String> val_17;
            var val_18;
            int val_19;
            object val_1 = null;
            val_15 = val_1;
            val_1 = new System.Object();
            string val_2 = this.GetGridContent(col:  fromCol, row:  fromRow);
            val_16 = (fromRow + (fromRow << 3)) + fromCol;
            typeof(WordBalloonGridGenerator.<>c__DisplayClass26_0).__il2cppRuntimeField_8 = val_16;
            if(val_15 == 0)
            {
                    val_16 = typeof(WordBalloonGridGenerator.<>c__DisplayClass26_0).__il2cppRuntimeField_8;
            }
            
            val_17 = 0;
            if((this.slotIdToWordCollection.ContainsKey(key:  val_16)) != false)
            {
                    string val_5 = this.slotIdToWordCollection.Item[typeof(WordBalloonGridGenerator.<>c__DisplayClass26_0).__il2cppRuntimeField_8];
                val_17 = this.slotIdToWordCollection;
            }
            
            int val_15 = toRow;
            val_15 = val_15 + (val_15 << 3);
            val_18 = 0;
            if((this.wordToSlotListCollection.ContainsKey(key:  val_17)) != false)
            {
                    System.Collections.Generic.List<System.Int32> val_7 = this.wordToSlotListCollection.Item[val_17];
                val_18 = this.wordToSlotListCollection;
            }
            
            int val_8 = val_15 + toCol;
            System.Predicate<System.Int32> val_9 = new System.Predicate<System.Int32>(object:  451915776, method:  new IntPtr(989007088));
            if(val_18 != 0)
            {
                    val_19 = val_18.FindIndex(match:  8040448);
            }
            else
            {
                    val_19 = 0.FindIndex(match:  8040448);
            }
            
            val_18.set_Item(index:  val_19, value:  val_8);
            if((this.slotIdToWordCollection.ContainsKey(key:  typeof(WordBalloonGridGenerator.<>c__DisplayClass26_0).__il2cppRuntimeField_8)) != false)
            {
                    val_15 = this.slotIdToWordCollection;
                bool val_13 = val_15.Remove(key:  typeof(WordBalloonGridGenerator.<>c__DisplayClass26_0).__il2cppRuntimeField_8);
            }
            
            if((this.slotIdToWordCollection.ContainsKey(key:  val_8)) != false)
            {
                    this.slotIdToWordCollection.set_Item(key:  val_8, value:  val_17);
            }
            
            this.slotIdToWordCollection.Add(key:  val_8, value:  val_17);
            this.SetGridContent(col:  toCol, row:  toRow, newSlotLetterValue:  989052592);
            this.SetGridContent(col:  fromCol, row:  fromRow, newSlotLetterValue:  null);
        }
        private void PrintGridContent()
        {
            SLC.Minigames.WordBalloon.WordBalloonGridGenerator val_6;
            System.Collections.Generic.List<System.Collections.Generic.List<System.String>> val_7;
            var val_8;
            var val_9;
            object val_10;
            var val_11;
            var val_12;
            val_6 = this;
            val_7 = this.gridContents;
            val_8 = "";
            if("" == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_9 = 0;
            val_9 = 4;
            goto label_5;
            label_16:
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            var val_7 = static_value_0028000B;
            val_7 = val_7 + 0;
            val_7 = "\"{0}\", ";
            val_10 = " ";
            if((System.String.IsNullOrEmpty(value:  (static_value_0028000B + 0) + 16)) != true)
            {
                    if(val_10 <= SB)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_6 = val_6;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                var val_8 = static_value_0028000B;
                val_8 = val_8 + 0;
                val_10 = val_8 + 16;
            }
            
            string val_2 = System.String.Format(format:  989185648, arg0:  val_10);
            string val_3 = 1098586544 + 989185648;
            val_9 = 5;
            val_11 = val_8;
            label_5:
            if((val_9 - 4) < val_8)
            {
                goto label_16;
            }
            
            string val_5 = 1098586544 + 1269544832;
            val_12 = val_11;
            val_9 = val_9 + 1;
            string val_6 = 989189840 + 1098586544 + 1113431872;
            UnityEngine.Debug.Log(message:  989189840);
        }
        private static WordBalloonGridGenerator()
        {
        
        }
    
    }

}
