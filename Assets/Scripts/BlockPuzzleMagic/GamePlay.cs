using UnityEngine;

namespace BlockPuzzleMagic
{
    public class GamePlay : MonoSingleton<BlockPuzzleMagic.GamePlay>
    {
        // Fields
        public System.Collections.Generic.List<BlockPuzzleMagic.GridCell> cellGrid;
        private UnityEngine.RectTransform floatingShapesLayer;
        private BlockPuzzleMagic.Level currentLevel;
        public System.Action<BlockPuzzleMagic.Level> OnLevelDataInitialized;
        public System.Action<BlockPuzzleMagic.ShapeInfo> OnShapePlaced;
        public System.Action<BlockPuzzleMagic.ShapeInfo> OnShapeRotated;
        public System.Action<bool> OnShapesChecked;
        public System.Action<System.Collections.Generic.List<System.Collections.Generic.List<BlockPuzzleMagic.GridCell>>> OnBlocksCleared;
        public System.Action OnGoalProgressUpdated;
        public System.Action<bool> OnPowerupMode;
        public System.Action<BlockPuzzleMagic.PowerUpType> OnPowerupUsed;
        public System.Action<bool> OnGameOver;
        private BlockPuzzleMagic.ShapeInfo currentShape;
        public static int currentLevelFailCount;
        private bool <GridCellsInteractable>k__BackingField;
        
        // Properties
        public UnityEngine.RectTransform FloatingShapesLayer { get; }
        public BlockPuzzleMagic.Level CurrentLevel { get; }
        public BlockPuzzleMagic.GameMode CurrentGameMode { get; }
        public bool GridCellsInteractable { get; set; }
        
        // Methods
        public UnityEngine.RectTransform get_FloatingShapesLayer()
        {
        
        }
        public BlockPuzzleMagic.Level get_CurrentLevel()
        {
        
        }
        public BlockPuzzleMagic.GameMode get_CurrentGameMode()
        {
            if(this.currentLevel != 0)
            {
                    this.currentLevel = this.currentLevel.gameMode;
            }
            
            if(this.currentLevel == 0)
            {
                    this.currentLevel = 0;
            }
        
        }
        public bool get_GridCellsInteractable()
        {
            return (bool)this.<GridCellsInteractable>k__BackingField;
        }
        public void set_GridCellsInteractable(bool value)
        {
            this.<GridCellsInteractable>k__BackingField = value;
        }
        public void Init(BlockPuzzleMagic.GameMode gameMode)
        {
            BlockPuzzleMagic.Level val_15;
            var val_16;
            this.currentLevel = 0;
            BestBlocksPlayer val_1 = BestBlocksPlayer.Instance;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_15 = public static BlockPuzzleMagic.GameProgressManager MonoSingleton<BlockPuzzleMagic.GameProgressManager>::get_Instance();
            if((HasSavedGame(gameMode:  gameMode)) != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_15 = public static BlockPuzzleMagic.GameProgressManager MonoSingleton<BlockPuzzleMagic.GameProgressManager>::get_Instance();
                BlockPuzzleMagic.Level val_5 = LoadSavedGame(gameMode:  gameMode);
                this.currentLevel = val_15;
            }
            
            if(gameMode == 1)
            {
                goto label_8;
            }
            
            if(gameMode != 2)
            {
                goto label_29;
            }
            
            if(this.currentLevel == 0)
            {
                goto label_10;
            }
            
            val_15 = this.currentLevel.levelId;
            GameBehavior val_6 = App.getBehavior;
            if(val_15 == 0)
            {
                goto label_29;
            }
            
            label_10:
            if(0 == 0)
            {
                goto label_16;
            }
            
            EnumerableExtentions.SetOrAdd<System.Int32Enum, System.Int32>(dic:  3748210, key:  2, newValue:  0);
            goto label_17;
            label_8:
            if(this.currentLevel != 0)
            {
                goto label_29;
            }
            
            if(0 == 0)
            {
                goto label_19;
            }
            
            mem[300] = 0;
            mem[292] = 0;
            goto label_20;
            label_16:
            EnumerableExtentions.SetOrAdd<System.Int32Enum, System.Int32>(dic:  3748210, key:  2, newValue:  0);
            label_17:
            EnumerableExtentions.SetOrAdd<System.Int32Enum, System.Boolean>(dic:  0, key:  2, newValue:  false);
            WordPets.WPTDataParser val_7 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            BlockPuzzleMagic.Level val_8 = GetGameLevel(gameMode:  2);
            this.currentLevel = public static BlockPuzzleMagic.LevelManager MonoSingletonSelfGenerating<BlockPuzzleMagic.LevelManager>::get_Instance();
            this.currentLevel.SetUsableShapeData(containerId:  0, shapeId:  3, shapeColor:  2);
            this.currentLevel.SetUsableShapeData(containerId:  1, shapeId:  2, shapeColor:  5);
            this.currentLevel.SetUsableShapeData(containerId:  2, shapeId:  15, shapeColor:  3);
            goto label_29;
            label_19:
            mem[292] = 0;
            mem[300] = 0;
            label_20:
            EnumerableExtentions.SetOrAdd<System.Int32Enum, System.Int32>(dic:  3748210, key:  1, newValue:  0);
            EnumerableExtentions.SetOrAdd<System.Int32Enum, System.Boolean>(dic:  0, key:  1, newValue:  false);
            WordPets.WPTDataParser val_9 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            BlockPuzzleMagic.Level val_10 = GetGameLevel(gameMode:  1);
            this.currentLevel = public static BlockPuzzleMagic.LevelManager MonoSingletonSelfGenerating<BlockPuzzleMagic.LevelManager>::get_Instance();
            label_29:
            twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            GenerateBoard(_gridLayout:  this.currentLevel.gridLayout);
            BestBlocksPlayer val_12 = BestBlocksPlayer.Instance;
            bool val_13 = 0.IsFTUXGameLevels();
            if(val_13 == false)
            {
                goto label_39;
            }
            
            val_16 = 4;
            goto label_40;
            label_50:
            if(val_13 <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_16 = 5;
            label_40:
            val_15 = val_16 - 4;
            if(val_15 < 0)
            {
                goto label_50;
            }
            
            label_39:
            twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Init(shapesData:  this.currentLevel.usableShapeIds);
            this.<GridCellsInteractable>k__BackingField = true;
            if(this.OnLevelDataInitialized == 0)
            {
                    return;
            }
            
            this.OnLevelDataInitialized.Invoke(obj:  this.currentLevel);
        }
        public void Restart()
        {
            if(this.currentLevel != 0)
            {
                    35640063 = this.currentLevel.gameMode;
            }
            
            if(35640063 == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ClearProgress(gameMode:  35640063);
            this.Init(gameMode:  35640063);
        }
        public void CheckBoardStatus()
        {
            var val_8;
            var val_9;
            float val_10;
            var val_11;
            val_8 = 1152921514440824192;
            null = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_9 = this.currentLevel.gridLayout.rowCount;
            if(val_9 >= 1)
            {
                    val_11 = 0;
                do
            {
                if((this.IsRowCompletelyFilled(rowID:  0, rowList: out  System.Collections.Generic.List<BlockPuzzleMagic.GridCell> val_4 = 1244073016)) != false)
            {
                    Add(item:  0);
            }
            
                val_8 = 0 + 1;
            }
            while(val_9 != val_8);
            
            }
            
            if(R8 >= 1)
            {
                    val_11 = 0;
                val_10 = 1152921514440841600;
                do
            {
                if((this.IsColumnCompletelyFilled(columnID:  0, colList: out  System.Collections.Generic.List<BlockPuzzleMagic.GridCell> val_6 = 1244073012)) != false)
            {
                    val_9 = val_11;
                Add(item:  0);
            }
            
                val_8 = 0 + 1;
            }
            while(R8 != val_8);
            
            }
            
            this.BreakAllCompletedLines(breakingRows:  80883712, breakingColumns:  80883712);
        }
        private bool IsRowCompletelyFilled(int rowID, out System.Collections.Generic.List<BlockPuzzleMagic.GridCell> rowList)
        {
            char* val_7;
            System.Predicate<ZooTile> val_8;
            var val_9;
            System.Collections.Generic.List<BlockPuzzleMagic.GridCell> val_10;
            object val_1 = new System.Object();
            typeof(GamePlay.<>c__DisplayClass27_0).__il2cppRuntimeField_8 = rowID;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            if(new System.Object() != 0)
            {
                    typeof(GamePlay.<>c__DisplayClass27_1).__il2cppRuntimeField_C = val_1;
            }
            else
            {
                    mem[12] = val_1;
            }
            
            val_7 = 0;
            typeof(GamePlay.<>c__DisplayClass27_1).__il2cppRuntimeField_8 = ;
            val_8 = this.currentLevel.gridLayout;
            val_9 = 1152921514441046384;
            val_10 = 1;
            rowList = null;
            return (bool);
        }
        private bool IsColumnCompletelyFilled(int columnID, out System.Collections.Generic.List<BlockPuzzleMagic.GridCell> colList)
        {
            System.Predicate<ZooTile> val_8;
            var val_9;
            System.Collections.Generic.List<BlockPuzzleMagic.GridCell> val_10;
            object val_1 = new System.Object();
            typeof(GamePlay.<>c__DisplayClass28_0).__il2cppRuntimeField_8 = columnID;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            if(new System.Object() != 0)
            {
                    typeof(GamePlay.<>c__DisplayClass28_1).__il2cppRuntimeField_C = val_1;
            }
            else
            {
                    mem[12] = val_1;
            }
            
            val_8 = 0;
            goto label_4;
            label_12:
            val_8 = null;
            val_8 = new System.Predicate<ZooTile>(object:  464109568, method:  new IntPtr(1244345232));
            BlockPuzzleMagic.GridCell val_5 = this.cellGrid.Find(match:  8040448);
            if(this.cellGrid == 0)
            {
                goto label_7;
            }
            
            if(this.cellGrid.isFilled == false)
            {
                goto label_8;
            }
            
            Add(item:  this.cellGrid);
            label_7:
            val_8 = 1152921508563318913;
            label_4:
            typeof(GamePlay.<>c__DisplayClass28_1).__il2cppRuntimeField_8 = val_8;
            if(val_8 < this.currentLevel.gridLayout.rowCount)
            {
                goto label_12;
            }
            
            val_9 = 1152921514441192016;
            val_10 = 1;
            colList = null;
            return (bool)val_10;
            label_8:
            val_9 = 1152921514441192016;
            val_10 = 0;
            colList = val_10;
            return (bool)val_10;
        }
        private void BreakAllCompletedLines(System.Collections.Generic.List<System.Collections.Generic.List<BlockPuzzleMagic.GridCell>> breakingRows, System.Collections.Generic.List<System.Collections.Generic.List<BlockPuzzleMagic.GridCell>> breakingColumns)
        {
            System.Collections.Generic.List<BlockPuzzleMagic.GridCell> val_4;
            System.Collections.Generic.List<System.Collections.Generic.List<BlockPuzzleMagic.GridCell>> val_9;
            System.Collections.Generic.List<BlockPuzzleMagic.Goal> val_10;
            var val_11;
            BlockPuzzleMagic.Level val_12;
            var val_13;
            val_9 = breakingColumns;
            if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) < 1)
            {
                goto label_2;
            }
            
            List.Enumerator<T> val_2 = GetEnumerator();
            val_10 = 1152921514411133968;
            val_11 = 1152921514440841600;
            label_5:
            if(MoveNext() == false)
            {
                goto label_3;
            }
            
            this.BreakThisLine(breakingLine:  val_4, animationDelay:  null);
            Add(item:  val_4);
            goto label_5;
            label_3:
            Dispose();
            label_2:
            if(1244532584 < 1)
            {
                goto label_7;
            }
            
            List.Enumerator<T> val_5 = GetEnumerator();
            val_11 = 1152921514440841600;
            label_12:
            bool val_6 = MoveNext();
            if(val_6 == false)
            {
                goto label_8;
            }
            
            if(val_6 > false)
            {
                    13663756 = 13663760;
            }
            
            this.BreakThisLine(breakingLine:  val_4, animationDelay:  0.15f);
            Add(item:  val_4);
            goto label_12;
            label_8:
            Dispose();
            val_9 = val_9;
            label_7:
            if(this.OnBlocksCleared != 0)
            {
                    this.OnBlocksCleared.Invoke(obj:  80883712);
            }
            
            val_12 = this.currentLevel;
            if((val_12 == 0) || (this.currentLevel.gameMode != 2))
            {
                goto label_25;
            }
            
            val_13 = 0;
            val_11 = 16;
            goto label_19;
            label_28:
            if(this.currentLevel.gameMode <= val_13)
            {
                    var val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = val_9 + 0;
            val_12 = mem[(0 + 0) + 16];
            val_12 = (0 + 0) + 16;
            if(val_12 != 0)
            {
                    val_10 = mem[(0 + 0) + 16 + 16];
                val_10 = (0 + 0) + 16 + 16;
            }
            else
            {
                    val_10 = 2621443;
            }
            
            if(val_10 < ((0 + 0) + 16 + 12))
            {
                goto label_25;
            }
            
            val_12 = this.currentLevel;
            val_13 = 1;
            label_19:
            val_10 = this.currentLevel.goals;
            if(val_13 < ((0 + 0) + 16 + 12))
            {
                goto label_28;
            }
            
            this.GameOver(success:  true);
            return;
            label_25:
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            FillShapeContainer(skipAutosave:  true);
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SaveGame();
        }
        private void BreakThisLine(System.Collections.Generic.List<BlockPuzzleMagic.GridCell> breakingLine, float animationDelay = 0)
        {
            var val_1 = 0;
            this.UpdateGoalProgress(clearedBlocks:  breakingLine, skipRowColumnCheck:  false);
            goto label_1;
            label_5:
            if(this <= val_1)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            (0 + 0) + 16.ClearCell(doAnimation:  true, animationDelay:  0f, ignoreBreaksRequired:  R2);
            val_1 = 1;
            label_1:
            if(val_1 < ((0 + 0) + 16))
            {
                goto label_5;
            }
        
        }
        public void UpdateGoalProgress(System.Collections.Generic.List<BlockPuzzleMagic.GridCell> clearedBlocks, bool skipRowColumnCheck = False)
        {
            BlockPuzzleMagic.GamePlay val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            System.Predicate<BlockPuzzleMagic.GridCell> val_12;
            bool val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            val_6 = this;
            if(true < 1)
            {
                    return;
            }
            
            if(this.currentLevel.goals == 0)
            {
                    return;
            }
            
            val_7 = 0;
            goto label_5;
            label_61:
            object val_1 = null;
            val_8 = val_1;
            val_1 = new System.Object();
            if(val_1 <= val_7)
            {
                    var val_8 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = val_8 + 0;
            if(val_8 != 0)
            {
                    val_9 = val_8;
                typeof(GamePlay.<>c__DisplayClass31_0).__il2cppRuntimeField_8 = (0 + 0) + 16;
            }
            else
            {
                    val_9 = 8;
                mem[8] = (0 + 0) + 16;
            }
            
            if(((0 + 0) + 16 + 8) == 2)
            {
                    (0 + 0) + 16 + 8 = skipRowColumnCheck;
            }
            
            if(((0 + 0) + 16 + 8) == false)
            {
                goto label_12;
            }
            
            if(((0 + 0) + 16 + 8) == 1)
            {
                    (0 + 0) + 16 + 8 = skipRowColumnCheck;
            }
            
            if(((0 + 0) + 16 + 8) == false)
            {
                goto label_15;
            }
            
            if(((0 + 0) + 16 + 8) != 4)
            {
                goto label_18;
            }
            
            val_10 = null;
            val_10 = null;
            val_12 = GamePlay.<>c.<>9__31_0;
            if(val_12 != 0)
            {
                goto label_48;
            }
            
            val_12 = null;
            val_12 = new System.Predicate<ZooTile>(object:  GamePlay.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(1244810176));
            GamePlay.<>c.<>9__31_0 = val_12;
            goto label_24;
            label_12:
            if(((0 + 0) + 16 + 8) != true)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_13 = static_value_0028000F;
            if(0 == 0)
            {
                    var val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = val_9 + ((0 - 1) << 2);
            val_14 = mem[(0 + ((0 - 1)) << 2) + 16];
            val_14 = (0 + ((0 - 1)) << 2) + 16;
            val_15 = mem[(0 + ((0 - 1)) << 2) + 16 + 12];
            val_15 = (0 + ((0 - 1)) << 2) + 16 + 12;
            goto label_30;
            label_15:
            if(((0 + 0) + 16 + 8) != true)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_13 = static_value_00280013;
            if(0 == 0)
            {
                    var val_10 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_10 = val_10 + ((0 - 1) << 2);
            val_14 = mem[(0 + ((0 - 1)) << 2) + 16];
            val_14 = (0 + ((0 - 1)) << 2) + 16;
            val_15 = mem[(0 + ((0 - 1)) << 2) + 16 + 16];
            val_15 = (0 + ((0 - 1)) << 2) + 16 + 16;
            label_30:
            if(val_13 != val_15)
            {
                goto label_54;
            }
            
            val_16 = mem[8];
            if(val_16 == 0)
            {
                goto label_38;
            }
            
            val_9 = mem[(0 + 0) + 16 + 16];
            val_9 = (0 + 0) + 16 + 16;
            goto label_39;
            label_18:
            if(((0 + 0) + 16 + 8) != 5)
            {
                goto label_42;
            }
            
            val_17 = null;
            val_17 = null;
            val_12 = GamePlay.<>c.<>9__31_1;
            if(val_12 != 0)
            {
                goto label_48;
            }
            
            val_12 = null;
            val_12 = new System.Predicate<ZooTile>(object:  GamePlay.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(1244811200));
            GamePlay.<>c.<>9__31_1 = val_12;
            label_24:
            val_6 = val_6;
            goto label_48;
            label_42:
            if(((0 + 0) + 16 + 8) != 3)
            {
                goto label_54;
            }
            
            val_12 = null;
            val_12 = new System.Predicate<ZooTile>(object:  464162816, method:  new IntPtr(1244812224));
            label_48:
            System.Collections.Generic.List<BlockPuzzleMagic.GridCell> val_11 = clearedBlocks;
            System.Collections.Generic.List<T> val_7 = val_11.FindAll(match:  8040448);
            if(val_11 < 1)
            {
                goto label_54;
            }
            
            val_9 = mem[8];
            if(val_9 == 0)
            {
                goto label_56;
            }
            
            val_8 = mem[(0 + 0) + 16 + 16];
            val_8 = (0 + 0) + 16 + 16;
            goto label_57;
            label_38:
            val_16 = 16;
            val_9 = 2621443;
            label_39:
            mem[16] = 2621444;
            goto label_58;
            label_56:
            val_9 = 16;
            val_8 = mem[16];
            label_57:
            val_11 = val_8 + val_11;
            mem[16] = val_11;
            label_58:
            label_54:
            val_7 = 1;
            label_5:
            if(val_7 < 1)
            {
                goto label_61;
            }
            
            if(1 != 1)
            {
                    1 = this.OnGoalProgressUpdated;
            }
            
            if(1 == 0)
            {
                    return;
            }
            
            1.Invoke();
        }
        public bool CanPlaceShape(BlockPuzzleMagic.ShapeInfo blockShape, out System.Collections.Generic.List<BlockPuzzleMagic.GridCell> fittingBlocks)
        {
            var val_5 = 0;
            goto label_1;
            label_10:
            if(true <= val_5)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + 0;
            if(((0 + 0) + 16 + 24) != 0)
            {
                    if((((0 + 0) + 16.isFilled) != true) && (((0 + 0) + 16 + 25) != 0))
            {
                    bool val_3 = this.CheckShapeCanPlace(placingCell:  (0 + 0) + 16, placingBlockShape:  blockShape, fittingBlocks: out  System.Collections.Generic.List<BlockPuzzleMagic.GridCell> val_2 = 1245047728);
                if(val_3 == true)
            {
                    return false;
            }
            
            }
            
            }
            
            val_5 = 1;
            label_1:
            if(val_5 < val_3)
            {
                goto label_10;
            }
            
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            fittingBlocks = null;
            return false;
        }
        private bool CheckShapeCanPlace(BlockPuzzleMagic.GridCell placingCell, BlockPuzzleMagic.ShapeInfo placingBlockShape, out System.Collections.Generic.List<BlockPuzzleMagic.GridCell> fittingBlocks)
        {
            UnityEngine.Object val_9;
            var val_10;
            System.Collections.Generic.List<BlockPuzzleMagic.ShapeBlock> val_11;
            var val_12;
            BlockPuzzleMagic.ShapeInfo val_13;
            var val_14;
            val_9 = placingCell;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            mem2[0] = null;
            if(val_9 != 0)
            {
                
            }
            
            val_10 = 1;
            if(placingBlockShape == 0)
            {
                    return (bool)val_10;
            }
            
            val_11 = placingBlockShape.<ShapeBlocks>k__BackingField;
            if(val_11 == 0)
            {
                    return (bool)val_10;
            }
            
            val_12 = 0;
            goto label_8;
            label_35:
            object val_3 = null;
            val_9 = val_3;
            val_3 = new System.Object();
            if(val_3 <= val_12)
            {
                    var val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = val_9 + 0;
            if(((0 + 0) + 16 + 24) != 0)
            {
                    if(((0 + 0) + 16 + 24 + 12) != 0)
            {
                goto label_31;
            }
            
            }
            
            int val_10 = 0;
            val_10 = ((0 + 0) + 16 + 28) + val_10;
            val_10 = val_10 - (placingBlockShape.<FirstBlock>k__BackingField.rowIDOrientated);
            typeof(GamePlay.<>c__DisplayClass33_0).__il2cppRuntimeField_8 = val_10;
            int val_11 = placingCell.columnId;
            int val_12 = placingBlockShape + 16 + 32;
            val_11 = ((0 + 0) + 16 + 32) + val_11;
            val_12 = val_11 - val_12;
            typeof(GamePlay.<>c__DisplayClass33_0).__il2cppRuntimeField_C = val_12;
            System.Predicate<ZooTile> val_5 = new System.Predicate<ZooTile>(object:  464269312, method:  new IntPtr(1245140448));
            object val_6 = mem[1152921514441948076].Find(match:  8040448);
            val_9 = mem[1152921514441948076];
            val_13 = placingBlockShape;
            if(val_9 != 0)
            {
                goto label_23;
            }
            
            if((placingBlockShape + 20) != 0)
            {
                goto label_31;
            }
            
            goto label_25;
            label_23:
            if(((mem[1152921514441948076] + 24) == 0) || ((val_9.isFilled == true) || ((mem[1152921514441948076] + 25) == 0)))
            {
                goto label_29;
            }
            
            fittingBlocks.Add(item:  val_9);
            goto label_31;
            label_29:
            val_14 = mem[fittingBlocks];
            val_14 = fittingBlocks;
            if((placingBlockShape + 21) == 0)
            {
                goto label_37;
            }
            
            val_14.Add(item:  val_9);
            val_13 = placingBlockShape;
            label_31:
            val_11 = mem[placingBlockShape + 48];
            val_11 = placingBlockShape + 48;
            val_12 = 1;
            label_8:
            if(val_12 < (placingBlockShape + 48 + 12))
            {
                goto label_35;
            }
            
            val_10 = 1;
            return (bool)val_10;
            label_25:
            val_14 = mem[fittingBlocks];
            val_14 = fittingBlocks;
            label_37:
            val_14.Clear();
            val_10 = 0;
            return (bool)val_10;
        }
        public void NotifyShapePlaced(BlockPuzzleMagic.ShapeInfo shape)
        {
            if(this.OnShapePlaced != 0)
            {
                    this.OnShapePlaced.Invoke(obj:  shape);
            }
            
            System.Action val_1 = new System.Action(object:  1245313248, method:  new IntPtr(1245288224));
            MonoExtensions.DelayedCallEndOfFrame(monoBehaviour:  1245313248, callback:  7454720);
        }
        public void NotifyShapeRotated(BlockPuzzleMagic.ShapeInfo shape)
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            CheckIfAvailableShapesArePlaceable();
            BestBlocksPlayer val_2 = BestBlocksPlayer.Instance;
            if(this.currentLevel != 0)
            {
                    0 = this.currentLevel.gameMode;
            }
            
            0.IncrementCurrentRotationsUsed(mode:  0, stepAmt:  1);
            if(this.OnShapeRotated == 0)
            {
                    return;
            }
            
            this.OnShapeRotated.Invoke(obj:  shape);
        }
        public bool CanUsePowerup(BlockPuzzleMagic.PowerUpType powerupType, bool showStoreIfOOC = False, float oocDelay = 0)
        {
            DG.Tweening.TweenCallback val_9;
            var val_10;
            var val_12;
            var val_13;
            DG.Tweening.TweenCallback val_15;
            BestBlocksPlayer val_1 = BestBlocksPlayer.Instance;
            BlockPuzzleMagic.BestBlocksGameEcon val_2 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
            decimal val_3 = GetPowerupCost(_type:  0);
            val_12 = 1;
            if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal())) != true)
            {
                    if((0.IsFreePowerupAvailable(powerupType:  powerupType)) != true)
            {
                    val_12 = BlockPuzzleMagic.BBLFtuxData.IsFreeTutorialPowerupAvailable(powerupType:  powerupType);
            }
            
            }
            
            if(((~val_12) & showStoreIfOOC) != 0)
            {
                    return (bool)val_12;
            }
            
            val_10 = 1152921505071063040;
            val_13 = null;
            val_13 = null;
            val_9 = ???;
            val_15 = GamePlay.<>c.<>9__36_0;
            if(val_15 == 0)
            {
                    val_15 = null;
                val_15 = new DG.Tweening.TweenCallback(object:  GamePlay.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(1245558304));
                GamePlay.<>c.<>9__36_0 = val_15;
            }
            
            DG.Tweening.Tween val_8 = DG.Tweening.DOVirtual.DelayedCall(delay:  oocDelay, callback:  val_9, ignoreTimeScale:  false);
            return (bool)val_12;
        }
        public void UsePowerup(BlockPuzzleMagic.PowerUpType powerupType, bool freeUsage = False)
        {
            var val_12;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_13;
            var val_14;
            var val_15;
            var val_16;
            val_12 = freeUsage;
            BestBlocksPlayer val_1 = BestBlocksPlayer.Instance;
            val_13 = 0;
            int val_2 = EnumerableExtentions.GetOrDefault<System.Int32Enum, System.Int32>(dic:  1919184449, key:  powerupType, defaultValue:  0);
            if((BlockPuzzleMagic.BBLFtuxData.IsFreeTutorialPowerupAvailable(powerupType:  powerupType)) == true)
            {
                goto label_4;
            }
            
            val_14 = 1;
            if(val_12 != true)
            {
                    val_14 = val_13.IsFreePowerupAvailable(powerupType:  powerupType);
            }
            
            val_12 = 1919184449;
            if(val_12 != 0)
            {
                    val_15 = val_12.Item[powerupType];
            }
            else
            {
                    val_12 = 0;
                val_15 = 0.Item[powerupType];
            }
            
            val_12.set_Item(key:  powerupType, value:  val_15 + 1);
            if(val_14 == false)
            {
                goto label_8;
            }
            
            label_4:
            var val_12 = 132;
            val_12 = val_12 + 1;
            mem[324] = 6580592;
            mem[312] = val_12;
            mem[316] = 2;
            goto label_9;
            label_8:
            var val_13 = mem[312];
            val_13 = val_13 + 1;
            mem[312] = val_13;
            mem[316] = 3;
            if(powerupType <= 2)
            {
                    val_16 = mem[34443800 + (powerupType) << 2];
                val_16 = 34443800 + (powerupType) << 2;
            }
            
            val_13 = 0;
            BlockPuzzleMagic.BestBlocksGameEcon val_8 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
            decimal val_9 = GetPowerupCost(_type:  0);
            bool val_10 = CurrencyController.DebitBalance(value:  new System.Decimal(), source:  System.String.__il2cppRuntimeField_static_fields, externalParams:  val_13, animated:  false);
            NotificationCenter val_11 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  1245710688, aName:  -302451824);
            label_9:
            if(this.OnPowerupUsed == 0)
            {
                    return;
            }
            
            this.OnPowerupUsed.Invoke(obj:  powerupType);
        }
        public void GameOver(bool success)
        {
            var val_1;
            var val_2;
            val_1 = 35640076;
            if(success != false)
            {
                    val_1 = 1152921505070743552;
                val_2 = null;
                val_2 = null;
                BlockPuzzleMagic.GamePlay.currentLevelFailCount = 0;
            }
            
            if(this.OnGameOver == 0)
            {
                    return;
            }
            
            this.OnGameOver.Invoke(obj:  success);
        }
        public void HackGameOver(bool success = True)
        {
            this.GameOver(success:  success);
        }
        public void HackRefreshCurrentLevel()
        {
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            if(this.currentLevel == 0)
            {
                    this.currentLevel.gameMode = 0;
            }
            
            BlockPuzzleMagic.Level val_2 = GetGameLevel(gameMode:  0);
            this.currentLevel = public static BlockPuzzleMagic.LevelManager MonoSingletonSelfGenerating<BlockPuzzleMagic.LevelManager>::get_Instance();
        }
        public void HackQuickGoNextLevel()
        {
            BlockPuzzleMagic.Level val_3;
            BlockPuzzleMagic.GameMode val_4;
            val_3 = this.currentLevel;
            if(val_3 == 0)
            {
                goto label_8;
            }
            
            if(this.currentLevel.gameMode != 2)
            {
                goto label_2;
            }
            
            GameBehavior val_1 = App.getBehavior;
            var val_2 = 0 + 1;
            val_3 = this.currentLevel;
            if(val_3 == 0)
            {
                goto label_8;
            }
            
            label_2:
            val_4 = this.currentLevel.gameMode;
            goto label_9;
            label_8:
            val_4 = 0;
            label_9:
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ClearProgress(gameMode:  0);
            this.Init(gameMode:  0);
        }
        public GamePlay()
        {
        
        }
        private static GamePlay()
        {
        
        }
    
    }

}
