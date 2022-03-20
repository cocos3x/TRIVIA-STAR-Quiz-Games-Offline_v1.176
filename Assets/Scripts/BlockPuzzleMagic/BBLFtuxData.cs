using UnityEngine;

namespace BlockPuzzleMagic
{
    public class BBLFtuxData
    {
        // Fields
        public const int TUTORIAL_CHAPTER_ID = 0;
        public const int INITIAL_PLAYER_LEVEL_FTUX = 1;
        public static int PlayerFtuxLevel;
        public static readonly BlockPuzzleMagic.ChapterRef FtuxChapter;
        
        // Properties
        public static int MaxFtuxLevel { get; }
        private static BlockPuzzleMagic.ShapeInfoData blankShapePiece { get; }
        private static System.Collections.Generic.List<BlockPuzzleMagic.ShapeInfoData> usableBlockShapes1 { get; }
        private static System.Collections.Generic.List<BlockPuzzleMagic.ShapeInfoData> usableBlockShapes2 { get; }
        private static System.Collections.Generic.List<BlockPuzzleMagic.ShapeInfoData> usableBlockShapes3 { get; }
        private static BlockPuzzleMagic.BlockData referenceBlockData1 { get; }
        private static BlockPuzzleMagic.BlockData referenceBlockData2 { get; }
        private static BlockPuzzleMagic.BlockData referenceBlockData3 { get; }
        private static BlockPuzzleMagic.BlockData referenceBlockDataInteractableEmpty { get; }
        private static BlockPuzzleMagic.BlockData referenceBlockDataNonInteractable { get; }
        private static System.Collections.Generic.Dictionary<int, BlockPuzzleMagic.BlockData> referenceGridData1 { get; }
        private static System.Collections.Generic.Dictionary<int, BlockPuzzleMagic.BlockData> referenceGridData2 { get; }
        private static System.Collections.Generic.Dictionary<int, BlockPuzzleMagic.BlockData> referenceGridData3 { get; }
        
        // Methods
        public static int get_MaxFtuxLevel()
        {
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            BlockPuzzleMagic.LevelRef val_2 = public static BlockPuzzleMagic.BBLDataParser MonoSingletonSelfGenerating<BlockPuzzleMagic.BBLDataParser>::get_Instance().__il2cppRuntimeField_14.LastLevel;
            return (int)public static BlockPuzzleMagic.BBLDataParser MonoSingletonSelfGenerating<BlockPuzzleMagic.BBLDataParser>::get_Instance().__il2cppRuntimeField_14 + 8;
        }
        public static BlockPuzzleMagic.Level CreateFtuxLevel(BlockPuzzleMagic.LevelRef ftuxLevelRef)
        {
            int val_12;
            var val_13;
            var val_14;
            var val_15;
            if(ftuxLevelRef.levelId == 3)
            {
                goto label_2;
            }
            
            if(ftuxLevelRef.levelId == 2)
            {
                goto label_3;
            }
            
            val_12 = 0;
            if(ftuxLevelRef.levelId != 1)
            {
                goto label_4;
            }
            
            System.Collections.Generic.List<BlockPuzzleMagic.ShapeInfoData> val_1 = BlockPuzzleMagic.BBLFtuxData.usableBlockShapes1;
            val_12 = null;
            val_13 = null;
            System.Collections.Generic.Dictionary<System.Int32, BlockPuzzleMagic.BlockData> val_2 = BlockPuzzleMagic.BBLFtuxData.referenceGridData1;
            goto label_14;
            label_2:
            System.Collections.Generic.List<BlockPuzzleMagic.ShapeInfoData> val_3 = BlockPuzzleMagic.BBLFtuxData.usableBlockShapes3;
            val_12 = null;
            val_13 = null;
            System.Collections.Generic.Dictionary<System.Int32, BlockPuzzleMagic.BlockData> val_4 = BlockPuzzleMagic.BBLFtuxData.referenceGridData3;
            goto label_14;
            label_3:
            System.Collections.Generic.List<BlockPuzzleMagic.ShapeInfoData> val_5 = BlockPuzzleMagic.BBLFtuxData.usableBlockShapes2;
            val_12 = null;
            val_13 = null;
            System.Collections.Generic.Dictionary<System.Int32, BlockPuzzleMagic.BlockData> val_6 = BlockPuzzleMagic.BBLFtuxData.referenceGridData2;
            label_14:
            label_4:
            val_14 = 0;
            BlockPuzzleMagic.Level val_7 = BlockPuzzleMagic.LevelManager.CreateLevel(levelRef:  ftuxLevelRef);
            ftuxLevelRef.loopLayoutId = val_12;
            goto label_20;
            label_34:
            if((ContainsKey(key:  0)) != false)
            {
                    val_15 = val_13;
                System.TimeType val_9 = Item[0];
            }
            else
            {
                    val_15 = null;
                BlockPuzzleMagic.BlockData val_10 = BlockPuzzleMagic.BBLFtuxData.referenceBlockDataNonInteractable;
            }
            
            var val_11 = (ftuxLevelRef.dotLayoutId + 20) + 0;
            val_14 = 1;
            mem2[0] = val_15;
            label_20:
            if(val_14 < (ftuxLevelRef.dotLayoutId + 20 + 12))
            {
                goto label_34;
            }
        
        }
        public static bool IsFreeTutorialPowerupAvailable(BlockPuzzleMagic.PowerUpType powerupType)
        {
            var val_1;
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            if(powerupType == 0)
            {
                goto label_1;
            }
            
            if(powerupType == 2)
            {
                goto label_2;
            }
            
            val_1 = 0;
            if(powerupType != 1)
            {
                    return (bool)val_1;
            }
            
            val_2 = 1152921504881233920;
            var val_1 = 25292463;
            val_1 = 10341680 + val_1;
            if(val_1 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_3 = null;
            val_4 = 4;
            goto label_7;
            label_1:
            val_2 = 1152921504881233920;
            var val_2 = 25292367;
            val_2 = 10341776 + val_2;
            if(val_2 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_3 = null;
            val_4 = 6;
            label_7:
            BlockPuzzleMagic.FtuxId val_3 = BBLFTUXDemoWindow.currentFtuxFlag;
            val_3 = val_3 - val_4;
            val_1 = val_3 >> 5;
            return (bool)val_1;
            label_2:
            var val_4 = 25292219;
            val_4 = 10341924 + val_4;
            if(val_4 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_5 = null;
            val_5 = null;
            BlockPuzzleMagic.FtuxId val_5 = BBLFTUXDemoWindow.currentFtuxFlag;
            val_5 = val_5 - 5;
            val_5 = val_5 >> 5;
            return (bool)val_5;
        }
        public static bool IsEligibleForCuratedFtuxLevels(int playerLevel)
        {
            return false;
        }
        private static BlockPuzzleMagic.ShapeInfoData get_blankShapePiece()
        {
            if(new BlockPuzzleMagic.ShapeInfoData() != 0)
            {
                    typeof(BlockPuzzleMagic.ShapeInfoData).__il2cppRuntimeField_C = 0;
            }
            else
            {
                    mem[12] = 0;
            }
            
            typeof(BlockPuzzleMagic.ShapeInfoData).__il2cppRuntimeField_8 = 0;
        }
        private static System.Collections.Generic.List<BlockPuzzleMagic.ShapeInfoData> get_usableBlockShapes1()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            BlockPuzzleMagic.ShapeInfoData val_2 = BlockPuzzleMagic.BBLFtuxData.blankShapePiece;
            Add(item:  465014784);
            if(new BlockPuzzleMagic.ShapeInfoData() != 0)
            {
                    typeof(BlockPuzzleMagic.ShapeInfoData).__il2cppRuntimeField_C = 6;
            }
            else
            {
                    mem[12] = 6;
            }
            
            typeof(BlockPuzzleMagic.ShapeInfoData).__il2cppRuntimeField_8 = 6;
            Add(item:  466718720);
            BlockPuzzleMagic.ShapeInfoData val_4 = BlockPuzzleMagic.BBLFtuxData.blankShapePiece;
            Add(item:  80883712);
        }
        private static System.Collections.Generic.List<BlockPuzzleMagic.ShapeInfoData> get_usableBlockShapes2()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            BlockPuzzleMagic.ShapeInfoData val_2 = BlockPuzzleMagic.BBLFtuxData.blankShapePiece;
            Add(item:  465014784);
            if(new BlockPuzzleMagic.ShapeInfoData() != 0)
            {
                    typeof(BlockPuzzleMagic.ShapeInfoData).__il2cppRuntimeField_C = 4;
            }
            else
            {
                    mem[12] = 4;
            }
            
            typeof(BlockPuzzleMagic.ShapeInfoData).__il2cppRuntimeField_8 = 3;
            Add(item:  466718720);
            BlockPuzzleMagic.ShapeInfoData val_4 = BlockPuzzleMagic.BBLFtuxData.blankShapePiece;
            Add(item:  80883712);
        }
        private static System.Collections.Generic.List<BlockPuzzleMagic.ShapeInfoData> get_usableBlockShapes3()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            BlockPuzzleMagic.ShapeInfoData val_2 = BlockPuzzleMagic.BBLFtuxData.blankShapePiece;
            Add(item:  465014784);
            if(new BlockPuzzleMagic.ShapeInfoData() != 0)
            {
                    typeof(BlockPuzzleMagic.ShapeInfoData).__il2cppRuntimeField_C = 5;
            }
            else
            {
                    mem[12] = 5;
            }
            
            typeof(BlockPuzzleMagic.ShapeInfoData).__il2cppRuntimeField_8 = 9;
            Add(item:  466718720);
            BlockPuzzleMagic.ShapeInfoData val_4 = BlockPuzzleMagic.BBLFtuxData.blankShapePiece;
            Add(item:  80883712);
        }
        private static BlockPuzzleMagic.BlockData get_referenceBlockData1()
        {
            System.Collections.Generic.List<BlockPuzzleMagic.ShapeInfoData> val_2 = BlockPuzzleMagic.BBLFtuxData.usableBlockShapes1;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if(new BlockPuzzleMagic.BlockData() != 0)
            {
                    typeof(BlockPuzzleMagic.BlockData).__il2cppRuntimeField_8 = BBLFtuxData.__il2cppRuntimeField_14 + 12;
            }
            else
            {
                    mem[8] = BBLFtuxData.__il2cppRuntimeField_14 + 12;
            }
            
            typeof(BlockPuzzleMagic.BlockData).__il2cppRuntimeField_C = 0;
        }
        private static BlockPuzzleMagic.BlockData get_referenceBlockData2()
        {
            System.Collections.Generic.List<BlockPuzzleMagic.ShapeInfoData> val_2 = BlockPuzzleMagic.BBLFtuxData.usableBlockShapes2;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if(new BlockPuzzleMagic.BlockData() != 0)
            {
                    typeof(BlockPuzzleMagic.BlockData).__il2cppRuntimeField_8 = BBLFtuxData.__il2cppRuntimeField_14 + 12;
            }
            else
            {
                    mem[8] = BBLFtuxData.__il2cppRuntimeField_14 + 12;
            }
            
            typeof(BlockPuzzleMagic.BlockData).__il2cppRuntimeField_C = 0;
        }
        private static BlockPuzzleMagic.BlockData get_referenceBlockData3()
        {
            System.Collections.Generic.List<BlockPuzzleMagic.ShapeInfoData> val_2 = BlockPuzzleMagic.BBLFtuxData.usableBlockShapes3;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if(new BlockPuzzleMagic.BlockData() != 0)
            {
                    typeof(BlockPuzzleMagic.BlockData).__il2cppRuntimeField_8 = BBLFtuxData.__il2cppRuntimeField_14 + 12;
            }
            else
            {
                    mem[8] = BBLFtuxData.__il2cppRuntimeField_14 + 12;
            }
            
            typeof(BlockPuzzleMagic.BlockData).__il2cppRuntimeField_C = 0;
        }
        private static BlockPuzzleMagic.BlockData get_referenceBlockDataInteractableEmpty()
        {
            if(new BlockPuzzleMagic.BlockData() != 0)
            {
                    typeof(BlockPuzzleMagic.BlockData).__il2cppRuntimeField_8 = 0;
            }
            else
            {
                    mem[8] = 0;
            }
            
            typeof(BlockPuzzleMagic.BlockData).__il2cppRuntimeField_C = 0;
        }
        private static BlockPuzzleMagic.BlockData get_referenceBlockDataNonInteractable()
        {
            if(new BlockPuzzleMagic.BlockData() != 0)
            {
                    typeof(BlockPuzzleMagic.BlockData).__il2cppRuntimeField_8 = 0;
            }
            else
            {
                    mem[8] = 0;
            }
            
            typeof(BlockPuzzleMagic.BlockData).__il2cppRuntimeField_C = 0;
        }
        private static System.Collections.Generic.Dictionary<int, BlockPuzzleMagic.BlockData> get_referenceGridData1()
        {
            System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_1 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
            BlockPuzzleMagic.BlockData val_2 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData1;
            Add(key:  27, value:  465014784);
            BlockPuzzleMagic.BlockData val_3 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData1;
            Add(key:  28, value:  78753792);
            BlockPuzzleMagic.BlockData val_4 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData1;
            Add(key:  29, value:  78753792);
            BlockPuzzleMagic.BlockData val_5 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData1;
            Add(key:  30, value:  78753792);
            BlockPuzzleMagic.BlockData val_6 = BlockPuzzleMagic.BBLFtuxData.referenceBlockDataInteractableEmpty;
            Add(key:  31, value:  78753792);
            BlockPuzzleMagic.BlockData val_7 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData1;
            Add(key:  32, value:  78753792);
            BlockPuzzleMagic.BlockData val_8 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData1;
            Add(key:  33, value:  78753792);
            BlockPuzzleMagic.BlockData val_9 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData1;
            Add(key:  34, value:  78753792);
            BlockPuzzleMagic.BlockData val_10 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData1;
            Add(key:  35, value:  78753792);
            BlockPuzzleMagic.BlockData val_11 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData1;
            Add(key:  36, value:  78753792);
            BlockPuzzleMagic.BlockData val_12 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData1;
            Add(key:  37, value:  78753792);
            BlockPuzzleMagic.BlockData val_13 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData1;
            Add(key:  38, value:  78753792);
            BlockPuzzleMagic.BlockData val_14 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData1;
            Add(key:  39, value:  78753792);
            BlockPuzzleMagic.BlockData val_15 = BlockPuzzleMagic.BBLFtuxData.referenceBlockDataInteractableEmpty;
            Add(key:  40, value:  78753792);
            BlockPuzzleMagic.BlockData val_16 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData1;
            Add(key:  41, value:  78753792);
            BlockPuzzleMagic.BlockData val_17 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData1;
            Add(key:  42, value:  78753792);
            BlockPuzzleMagic.BlockData val_18 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData1;
            Add(key:  43, value:  78753792);
            BlockPuzzleMagic.BlockData val_19 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData1;
            Add(key:  44, value:  78753792);
            BlockPuzzleMagic.BlockData val_20 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData1;
            Add(key:  45, value:  78753792);
            BlockPuzzleMagic.BlockData val_21 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData1;
            Add(key:  46, value:  78753792);
            BlockPuzzleMagic.BlockData val_22 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData1;
            Add(key:  47, value:  78753792);
            BlockPuzzleMagic.BlockData val_23 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData1;
            Add(key:  48, value:  78753792);
            BlockPuzzleMagic.BlockData val_24 = BlockPuzzleMagic.BBLFtuxData.referenceBlockDataInteractableEmpty;
            Add(key:  49, value:  78753792);
            BlockPuzzleMagic.BlockData val_25 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData1;
            Add(key:  50, value:  78753792);
            BlockPuzzleMagic.BlockData val_26 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData1;
            Add(key:  51, value:  78753792);
            BlockPuzzleMagic.BlockData val_27 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData1;
            Add(key:  52, value:  78753792);
            BlockPuzzleMagic.BlockData val_28 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData1;
            Add(key:  53, value:  78753792);
        }
        private static System.Collections.Generic.Dictionary<int, BlockPuzzleMagic.BlockData> get_referenceGridData2()
        {
            System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_1 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
            BlockPuzzleMagic.BlockData val_2 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  2, value:  465014784);
            BlockPuzzleMagic.BlockData val_3 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  3, value:  78753792);
            BlockPuzzleMagic.BlockData val_4 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  4, value:  78753792);
            BlockPuzzleMagic.BlockData val_5 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  5, value:  78753792);
            BlockPuzzleMagic.BlockData val_6 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  11, value:  78753792);
            BlockPuzzleMagic.BlockData val_7 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  12, value:  78753792);
            BlockPuzzleMagic.BlockData val_8 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  13, value:  78753792);
            BlockPuzzleMagic.BlockData val_9 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  14, value:  78753792);
            BlockPuzzleMagic.BlockData val_10 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  20, value:  78753792);
            BlockPuzzleMagic.BlockData val_11 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  21, value:  78753792);
            BlockPuzzleMagic.BlockData val_12 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  22, value:  78753792);
            BlockPuzzleMagic.BlockData val_13 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  23, value:  78753792);
            BlockPuzzleMagic.BlockData val_14 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  29, value:  78753792);
            BlockPuzzleMagic.BlockData val_15 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  30, value:  78753792);
            BlockPuzzleMagic.BlockData val_16 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  31, value:  78753792);
            BlockPuzzleMagic.BlockData val_17 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  32, value:  78753792);
            BlockPuzzleMagic.BlockData val_18 = BlockPuzzleMagic.BBLFtuxData.referenceBlockDataInteractableEmpty;
            Add(key:  38, value:  78753792);
            BlockPuzzleMagic.BlockData val_19 = BlockPuzzleMagic.BBLFtuxData.referenceBlockDataInteractableEmpty;
            Add(key:  39, value:  78753792);
            BlockPuzzleMagic.BlockData val_20 = BlockPuzzleMagic.BBLFtuxData.referenceBlockDataInteractableEmpty;
            Add(key:  40, value:  78753792);
            BlockPuzzleMagic.BlockData val_21 = BlockPuzzleMagic.BBLFtuxData.referenceBlockDataInteractableEmpty;
            Add(key:  41, value:  78753792);
            BlockPuzzleMagic.BlockData val_22 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  47, value:  78753792);
            BlockPuzzleMagic.BlockData val_23 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  48, value:  78753792);
            BlockPuzzleMagic.BlockData val_24 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  49, value:  78753792);
            BlockPuzzleMagic.BlockData val_25 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  50, value:  78753792);
            BlockPuzzleMagic.BlockData val_26 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  56, value:  78753792);
            BlockPuzzleMagic.BlockData val_27 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  57, value:  78753792);
            BlockPuzzleMagic.BlockData val_28 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  58, value:  78753792);
            BlockPuzzleMagic.BlockData val_29 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  59, value:  78753792);
            BlockPuzzleMagic.BlockData val_30 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  65, value:  78753792);
            BlockPuzzleMagic.BlockData val_31 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  66, value:  78753792);
            BlockPuzzleMagic.BlockData val_32 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  67, value:  78753792);
            BlockPuzzleMagic.BlockData val_33 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  68, value:  78753792);
            BlockPuzzleMagic.BlockData val_34 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  74, value:  78753792);
            BlockPuzzleMagic.BlockData val_35 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  75, value:  78753792);
            BlockPuzzleMagic.BlockData val_36 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  76, value:  78753792);
            BlockPuzzleMagic.BlockData val_37 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData2;
            Add(key:  77, value:  78753792);
        }
        private static System.Collections.Generic.Dictionary<int, BlockPuzzleMagic.BlockData> get_referenceGridData3()
        {
            System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_1 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
            BlockPuzzleMagic.BlockData val_2 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData3;
            Add(key:  3, value:  465014784);
            BlockPuzzleMagic.BlockData val_3 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData3;
            Add(key:  4, value:  78753792);
            BlockPuzzleMagic.BlockData val_4 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData3;
            Add(key:  12, value:  78753792);
            BlockPuzzleMagic.BlockData val_5 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData3;
            Add(key:  13, value:  78753792);
            BlockPuzzleMagic.BlockData val_6 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData3;
            Add(key:  21, value:  78753792);
            BlockPuzzleMagic.BlockData val_7 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData3;
            Add(key:  22, value:  78753792);
            BlockPuzzleMagic.BlockData val_8 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData3;
            Add(key:  27, value:  78753792);
            BlockPuzzleMagic.BlockData val_9 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData3;
            Add(key:  28, value:  78753792);
            BlockPuzzleMagic.BlockData val_10 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData3;
            Add(key:  29, value:  78753792);
            BlockPuzzleMagic.BlockData val_11 = BlockPuzzleMagic.BBLFtuxData.referenceBlockDataInteractableEmpty;
            Add(key:  30, value:  78753792);
            BlockPuzzleMagic.BlockData val_12 = BlockPuzzleMagic.BBLFtuxData.referenceBlockDataInteractableEmpty;
            Add(key:  31, value:  78753792);
            BlockPuzzleMagic.BlockData val_13 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData3;
            Add(key:  32, value:  78753792);
            BlockPuzzleMagic.BlockData val_14 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData3;
            Add(key:  33, value:  78753792);
            BlockPuzzleMagic.BlockData val_15 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData3;
            Add(key:  34, value:  78753792);
            BlockPuzzleMagic.BlockData val_16 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData3;
            Add(key:  35, value:  78753792);
            BlockPuzzleMagic.BlockData val_17 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData3;
            Add(key:  36, value:  78753792);
            BlockPuzzleMagic.BlockData val_18 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData3;
            Add(key:  37, value:  78753792);
            BlockPuzzleMagic.BlockData val_19 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData3;
            Add(key:  38, value:  78753792);
            BlockPuzzleMagic.BlockData val_20 = BlockPuzzleMagic.BBLFtuxData.referenceBlockDataInteractableEmpty;
            Add(key:  39, value:  78753792);
            BlockPuzzleMagic.BlockData val_21 = BlockPuzzleMagic.BBLFtuxData.referenceBlockDataInteractableEmpty;
            Add(key:  40, value:  78753792);
            BlockPuzzleMagic.BlockData val_22 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData3;
            Add(key:  41, value:  78753792);
            BlockPuzzleMagic.BlockData val_23 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData3;
            Add(key:  42, value:  78753792);
            BlockPuzzleMagic.BlockData val_24 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData3;
            Add(key:  43, value:  78753792);
            BlockPuzzleMagic.BlockData val_25 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData3;
            Add(key:  44, value:  78753792);
            BlockPuzzleMagic.BlockData val_26 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData3;
            Add(key:  48, value:  78753792);
            BlockPuzzleMagic.BlockData val_27 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData3;
            Add(key:  49, value:  78753792);
            BlockPuzzleMagic.BlockData val_28 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData3;
            Add(key:  57, value:  78753792);
            BlockPuzzleMagic.BlockData val_29 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData3;
            Add(key:  58, value:  78753792);
            BlockPuzzleMagic.BlockData val_30 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData3;
            Add(key:  66, value:  78753792);
            BlockPuzzleMagic.BlockData val_31 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData3;
            Add(key:  67, value:  78753792);
            BlockPuzzleMagic.BlockData val_32 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData3;
            Add(key:  75, value:  78753792);
            BlockPuzzleMagic.BlockData val_33 = BlockPuzzleMagic.BBLFtuxData.referenceBlockData3;
            Add(key:  76, value:  78753792);
        }
        public BBLFtuxData()
        {
        
        }
        private static BBLFtuxData()
        {
            BlockPuzzleMagic.BBLFtuxData.PlayerFtuxLevel = 1;
            typeof(BlockPuzzleMagic.ChapterRef).__il2cppRuntimeField_8 = 0;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            if(new BlockPuzzleMagic.LevelRef() != 0)
            {
                    typeof(BlockPuzzleMagic.LevelRef).__il2cppRuntimeField_8 = 1;
            }
            else
            {
                    mem[8] = 1;
            }
            
            typeof(BlockPuzzleMagic.LevelRef).__il2cppRuntimeField_10 = 1;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            BlockPuzzleMagic.GoalRef val_5 = new BlockPuzzleMagic.GoalRef(_goalType:  2, _goalAmt:  3);
            Add(item:  465760256);
            typeof(BlockPuzzleMagic.LevelRef).__il2cppRuntimeField_C = null;
            Add(item:  465653760);
            if(new BlockPuzzleMagic.LevelRef() != 0)
            {
                    typeof(BlockPuzzleMagic.LevelRef).__il2cppRuntimeField_8 = 2;
            }
            else
            {
                    mem[8] = 2;
            }
            
            typeof(BlockPuzzleMagic.LevelRef).__il2cppRuntimeField_10 = 1;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_7 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            BlockPuzzleMagic.GoalRef val_8 = new BlockPuzzleMagic.GoalRef(_goalType:  1, _goalAmt:  4);
            Add(item:  465760256);
            typeof(BlockPuzzleMagic.LevelRef).__il2cppRuntimeField_C = null;
            Add(item:  465653760);
            if(new BlockPuzzleMagic.LevelRef() != 0)
            {
                    typeof(BlockPuzzleMagic.LevelRef).__il2cppRuntimeField_8 = 3;
            }
            else
            {
                    mem[8] = 3;
            }
            
            typeof(BlockPuzzleMagic.LevelRef).__il2cppRuntimeField_10 = 1;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_10 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            BlockPuzzleMagic.GoalRef val_11 = new BlockPuzzleMagic.GoalRef(_goalType:  1, _goalAmt:  2);
            Add(item:  465760256);
            BlockPuzzleMagic.GoalRef val_12 = new BlockPuzzleMagic.GoalRef(_goalType:  2, _goalAmt:  2);
            Add(item:  465760256);
            typeof(BlockPuzzleMagic.LevelRef).__il2cppRuntimeField_C = null;
            Add(item:  465653760);
            typeof(BlockPuzzleMagic.ChapterRef).__il2cppRuntimeField_C = null;
            BlockPuzzleMagic.BBLFtuxData.FtuxChapter = new BlockPuzzleMagic.ChapterRef();
        }
    
    }

}
