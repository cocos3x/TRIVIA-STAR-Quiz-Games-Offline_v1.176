using UnityEngine;

namespace BlockPuzzleMagic
{
    public class BlockShapeSpawner : MonoSingleton<BlockPuzzleMagic.BlockShapeSpawner>
    {
        // Fields
        private const int RANDOM_PICKLIMIT_PER_SHAPE = 3;
        private const int RANDOM_PICKLIMIT_PER_COLOR = 3;
        private UnityEngine.Transform[] ShapeContainers;
        private UnityEngine.UI.Image[] rotateShapeIcon;
        private BlockPuzzleMagic.ShapeInfo[] spawnedShapes;
        private DG.Tweening.Sequence[] rotationIconSeq;
        private System.Collections.Generic.Dictionary<int, int> shapeBlockPickCounter;
        private System.Collections.Generic.Dictionary<BlockPuzzleMagic.BlockColorType, int> shapeColorPickCounter;
        private BlockPuzzleMagic.ShapeBlockList activeShapeBlockModule;
        private System.Collections.Generic.List<int> shapeBlockRandomPool;
        private System.Collections.Generic.List<BlockPuzzleMagic.BlockColorType> shapeColorRandomPool;
        private RandomSet powerupAPChanceRandomSet;
        
        // Properties
        public UnityEngine.Transform[] getShapeContainers { get; }
        public BlockPuzzleMagic.ShapeInfo[] SpawnedShapes { get; }
        public bool Interactable { set; }
        
        // Methods
        public UnityEngine.Transform[] get_getShapeContainers()
        {
        
        }
        public BlockPuzzleMagic.ShapeInfo[] get_SpawnedShapes()
        {
        
        }
        public void set_Interactable(bool value)
        {
            goto label_1;
            label_12:
            if(this.spawnedShapes[0] != 0)
            {
                    BlockPuzzleMagic.ShapeInfo val_4 = this.spawnedShapes[0];
                this.spawnedShapes[0].shapeCanvas.blocksRaycasts = value;
            }
            
            4 = 5;
            label_1:
            if((4 - 4) < this.spawnedShapes[0].shapeCanvas)
            {
                goto label_12;
            }
        
        }
        public override void InitMonoSingleton()
        {
            var val_2 = 0;
            goto label_1;
            label_8:
            if(this.spawnedShapes[val_2] == 0)
            {
                    this.ToggleRotationIcon(iconIndex:  0, isVisible:  false);
            }
            
            val_2 = 1;
            label_1:
            if(val_2 < this)
            {
                goto label_8;
            }
        
        }
        private void Start()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  1232685952, method:  new IntPtr(1232660928));
            public static AdsUIController MonoSingleton<AdsUIController>::get_Instance().__il2cppRuntimeField_1C.AddListener(call:  162246656);
        }
        private void OnDestroy()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(2124183120 == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  1232797952, method:  new IntPtr(1232660928));
            public static AdsUIController MonoSingleton<AdsUIController>::get_Instance().__il2cppRuntimeField_1C.RemoveListener(call:  162246656);
        }
        private void OnCanvasResized()
        {
            System.Collections.IEnumerator val_1 = this.UpdateSpawnShapesPosition();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  1232909952);
        }
        private System.Collections.IEnumerator UpdateSpawnShapesPosition()
        {
            object val_1 = new System.Object();
            typeof(BlockShapeSpawner.<UpdateSpawnShapesPosition>d__22).__il2cppRuntimeField_8 = 0;
            typeof(BlockShapeSpawner.<UpdateSpawnShapesPosition>d__22).__il2cppRuntimeField_10 = this;
        }
        public void Init(System.Collections.Generic.List<BlockPuzzleMagic.ShapeInfoData> shapesData)
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            RandomSet val_17;
            var val_18;
            var val_19;
            var val_20;
            object val_1 = new System.Object();
            if(val_1 != 0)
            {
                    val_13 = val_1;
                typeof(BlockShapeSpawner.<>c__DisplayClass23_0).__il2cppRuntimeField_8 = shapesData;
            }
            else
            {
                    val_13 = 8;
                mem[8] = shapesData;
            }
            
            typeof(BlockShapeSpawner.<>c__DisplayClass23_0).__il2cppRuntimeField_C = this;
            this.DestroyShapes();
            BlockPuzzleMagic.GameReferenceData val_2 = BlockPuzzleMagic.GameReferenceData.Instance;
            this.activeShapeBlockModule = this.ShapeContainers;
            this.ResetShapeBlockRandomPool();
            this.ResetShapeColorRandomPool();
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            BlockPuzzleMagic.BestBlocksGameEcon val_4 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
            this.powerupAPChanceRandomSet.clear();
            this.powerupAPChanceRandomSet.replacement = true;
            val_14 = 0;
            int val_5 = 0.GetPowerupTutorialLevel(powerupType:  1);
            float val_15 = 100f;
            val_15 = (0 + 1484) * val_15;
            val_14 = val_15;
            val_15 = 0;
            int val_7 = 0.GetPowerupTutorialLevel(powerupType:  2);
            float val_16 = 100f;
            val_16 = (0 + 1488) * val_16;
            if(0 == 0)
            {
                    -D16 = -(-D16);
            }
            
            val_15 = val_16;
            val_16 = UnityEngine.Mathf.Max(a:  0, b:  (10000 - val_14) - val_15);
            this.powerupAPChanceRandomSet.add(item:  0, weight:  (float)val_16);
            this.powerupAPChanceRandomSet.add(item:  1, weight:  (float)val_14);
            val_17 = this.powerupAPChanceRandomSet;
            val_17.add(item:  2, weight:  (float)val_15);
            if(val_13 == 0)
            {
                goto label_32;
            }
            
            val_18 = 4;
            goto label_22;
            label_35:
            if((shapesData + 12) <= val_16)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((shapesData + 8 + 16 + 8) < 0)
            {
                goto label_27;
            }
            
            if((shapesData + 12) <= val_16)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((this.DoesShapeIdExists(shapeId:  shapesData + 8 + 16 + 8)) == false)
            {
                goto label_32;
            }
            
            label_27:
            val_18 = 5;
            label_22:
            val_16 = val_18 - 4;
            if(val_16 < (shapesData + 12))
            {
                goto label_35;
            }
            
            val_17 = null;
            val_17 = new System.Action(object:  463470592, method:  new IntPtr(1233171392));
            val_19 = this;
            val_20 = val_17;
            goto label_36;
            label_32:
            System.Action val_14 = new System.Action(object:  1233197440, method:  new IntPtr(1233172416));
            val_19 = this;
            val_20 = null;
            label_36:
            MonoExtensions.DelayedCallEndOfFrame(monoBehaviour:  1233197440, callback:  7454720);
        }
        private void ResetShapeBlockRandomPool()
        {
            var val_5;
            BlockPuzzleMagic.BestBlocksGameEcon val_1 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14) != 0)
            {
                    public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance() = mem[public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14 + 8];
                public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance() = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14 + 8;
            }
            
            if((public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14) == 0)
            {
                    public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance() = 0;
            }
            
            System.Collections.Generic.List<System.Int32> val_3 = 0.GetAllowedShapeIdsForMode(gameMode:  0);
            this.shapeBlockPickCounter.Clear();
            this.shapeBlockRandomPool.Clear();
            val_5 = 4;
            goto label_7;
            label_26:
            if(this.shapeBlockRandomPool <= SL)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            bool val_4 = 0.Contains(item:  static_value_0028000B);
            if(val_4 != false)
            {
                    if(val_4 <= SL)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                this.shapeBlockPickCounter.Add(key:  static_value_0028000B, value:  0);
                if(this.shapeBlockPickCounter <= SL)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                this.shapeBlockRandomPool.Add(item:  static_value_0028000B);
            }
            
            val_5 = 5;
            label_7:
            if((val_5 - 4) < this.shapeBlockRandomPool)
            {
                goto label_26;
            }
            
            PluginExtension.Shuffle<System.Int32>(list:  this.shapeBlockRandomPool, seed:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        private void ResetShapeColorRandomPool()
        {
            var val_4;
            var val_5;
            System.Int32Enum val_6;
            var val_7;
            var val_8;
            this.shapeColorPickCounter.Clear();
            this.shapeColorRandomPool.Clear();
            val_4 = 4;
            goto label_3;
            label_30:
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_5 = null;
            val_5 = null;
            val_6 = mem[BlockPuzzleMagic.BlockColor.STANDARD_REGULAR_COLORS + 16];
            val_6 = BlockPuzzleMagic.BlockColor.STANDARD_REGULAR_COLORS + 16;
            if((public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14 + 24.Contains(item:  val_6)) != true)
            {
                    val_7 = null;
                val_7 = null;
                this.shapeColorPickCounter.Add(key:  BlockPuzzleMagic.BlockColor.STANDARD_REGULAR_COLORS + 16, value:  0);
                val_6 = mem[BlockPuzzleMagic.BlockColor.STANDARD_REGULAR_COLORS + 16];
                val_6 = BlockPuzzleMagic.BlockColor.STANDARD_REGULAR_COLORS + 16;
                this.shapeColorRandomPool.Add(item:  val_6);
            }
            
            val_4 = 5;
            label_3:
            val_8 = null;
            val_8 = null;
            if((val_4 - 4) < (BlockPuzzleMagic.BlockColor.STANDARD_REGULAR_COLORS + 12))
            {
                goto label_30;
            }
            
            PluginExtension.Shuffle<System.Int32Enum>(list:  this.shapeColorRandomPool, seed:  new System.Nullable<System.Int32>() {HasValue = false});
        }
        public void RegenerateNewShapes()
        {
            this.DestroyShapes();
            DG.Tweening.TweenCallback val_1 = new DG.Tweening.TweenCallback(object:  1233749504, method:  new IntPtr(1233172416));
            DG.Tweening.Tween val_2 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1036831949, ignoreTimeScale:  false);
        }
        public void DestroyShape(int containerIndex)
        {
            BlockPuzzleMagic.ShapeInfo val_3;
            val_3 = this.spawnedShapes[containerIndex];
            if(val_3 != 0)
            {
                    BlockPuzzleMagic.ShapeInfo val_3 = this.spawnedShapes[containerIndex];
                UnityEngine.GameObject val_2 = val_3.gameObject;
                val_3 = val_3;
                UnityEngine.Object.Destroy(obj:  val_3);
            }
            
            this.spawnedShapes[containerIndex] = 0;
        }
        private void DestroyShapes()
        {
            goto label_0;
            label_2:
            this.DestroyShape(containerIndex:  0);
            0 = 1;
            label_0:
            if(0 < this)
            {
                goto label_2;
            }
        
        }
        public void FillShapeContainer()
        {
            this.FillShapeContainer(skipAutosave:  false);
        }
        public void FillShapeContainer(bool skipAutosave)
        {
            BlockPuzzleMagic.BlockShapeSpawner val_16;
            var val_17;
            var val_18;
            var val_19;
            float val_20;
            val_16 = this;
            var val_19 = 0;
            val_17 = 1152921504765685760;
            label_7:
            if(val_19 >= true)
            {
                goto label_2;
            }
            
            val_19 = val_19 + 1;
            if(this.spawnedShapes[val_19] == 0)
            {
                goto label_7;
            }
            
            goto label_8;
            label_2:
            BlockPuzzleMagic.BestBlocksGameEcon val_2 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
            bool val_3 = 0.IsEasyMode();
            System.Collections.Generic.List<System.Int32> val_4 = this.GetRandomShapeIds(isEasyMode:  val_3, qty:  0);
            System.Collections.Generic.List<BlockPuzzleMagic.BlockColorType> val_5 = this.GetRandomColorTypes(qty:  val_3);
            val_18 = 4;
            goto label_12;
            label_25:
            if(this.ShapeContainers <= val_17)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            BlockPuzzleMagic.GameReferenceData val_6 = BlockPuzzleMagic.GameReferenceData.Instance;
            if(this.ShapeContainers <= val_17)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            BlockPuzzleMagic.BlockColor val_7 = 0.GetBlockColor(colorType:  mem[1152921514431578120] + 16);
            BlockPuzzleMagic.ShapeInfo val_8 = this.CreateShapeWithID(shapeContainer:  this.ShapeContainers[0], shapeID:  2621443, shapeColor:  0);
            this.spawnedShapes[0] = val_16;
            val_18 = 5;
            val_16 = val_16;
            label_12:
            if((val_18 - 4) < val_16)
            {
                goto label_25;
            }
            
            val_17 = 1152921504765685760;
            label_8:
            val_19 = 4;
            val_20 = 1152921504901095424;
            var val_14 =  - 4;
            twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SaveGame();
            DG.Tweening.TweenCallback val_16 = new DG.Tweening.TweenCallback(object:  1234796544, method:  new IntPtr(1234771520));
            DG.Tweening.Tween val_17 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1045220557, ignoreTimeScale:  false);
        }
        private System.Collections.Generic.List<int> GetRandomShapeIds(bool isEasyMode, int qty = 3)
        {
            float val_28;
            System.Collections.Generic.List<System.Int32> val_29;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            BlockPuzzleMagic.BlockShapeSpawner val_40;
            var val_41;
            var val_42;
            var val_43;
            int val_44;
            var val_45;
            var val_46;
            System.Predicate<ZooTile> val_47;
            var val_48;
            var val_49;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_29 = null;
            val_29 = new System.Collections.Generic.List<System.Int32>(capacity:  3);
            val_30 = null;
            val_30 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            System.Collections.Generic.List<System.Int32> val_4 = new System.Collections.Generic.List<System.Int32>();
            val_31 = 0;
            if(isEasyMode != true)
            {
                    do
            {
                val_30 = val_30;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_32 = BlockPuzzleMagic.GridLayout.GetCellIdTowardsDirection(cellId:  List<T>.__il2cppRuntimeField_10, dir:  3);
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_33 = 1;
                if((BlockPuzzleMagic.GridLayout.GetCellIdTowardsDirection(cellId:  List<T>.__il2cppRuntimeField_10, dir:  1)) >= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_34 = 0;
                if(((public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_C + 8 + (val_6) << 2) + 16.isFilled) != true)
            {
                    if(((public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_C + 8 + (val_6) << 2) + 16 + 25) != 0)
            {
                    val_34 = 1;
            }
            
            }
            
                val_32 = val_32;
            }
            
                if(val_32 >= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_35 = 0;
                if(((public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_C + 8 + (val_7) << 2) + 16.isFilled) != true)
            {
                    if(((public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_C + 8 + (val_7) << 2) + 16 + 25) != 0)
            {
                    val_35 = 1;
            }
            
            }
            
                val_33 = 0;
            }
            
                var val_30 = 4;
                val_36 = 1;
                val_37 = 1;
                if((BlockPuzzleMagic.GridLayout.GetCellIdTowardsDirection(cellId:  List<T>.__il2cppRuntimeField_10, dir:  4)) >= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_38 = 0;
                if(((public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_C + 8 + (val_8) << 2) + 16.isFilled) != true)
            {
                    if(((public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_C + 8 + (val_8) << 2) + 16 + 25) != 0)
            {
                    val_38 = 1;
            }
            
            }
            
                val_36 = 0;
            }
            
                if((BlockPuzzleMagic.GridLayout.GetCellIdTowardsDirection(cellId:  List<T>.__il2cppRuntimeField_10, dir:  2)) >= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_39 = 0;
                if(((public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_C + 8 + (val_9) << 2) + 16.isFilled) != true)
            {
                    if(((public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_C + 8 + (val_9) << 2) + 16 + 25) != 0)
            {
                    val_39 = 1;
            }
            
            }
            
                val_37 = 0;
            }
            
                var val_31 = val_33;
                val_30 = val_30 + 1;
                val_31 = val_31 & 0;
                val_31 = val_31 & val_36;
            }
            while((val_31 & val_37) != 0);
            
                val_29 = val_29;
                val_30 = val_30;
            }
            
            val_40 = this;
            PluginExtension.Shuffle<System.Int32>(list:  mem[1152921514431981992], seed:  new System.Nullable<System.Int32>() {HasValue = false});
            if(qty < 1)
            {
                goto label_48;
            }
            
            label_90:
            object val_14 = null;
            val_28 = val_14;
            val_14 = new System.Object();
            val_41 = 0;
            val_42 = 0;
            typeof(BlockShapeSpawner.<>c__DisplayClass31_0).__il2cppRuntimeField_8 = val_41;
            if(0 == 0)
            {
                goto label_77;
            }
            
            val_42 = 0;
            int val_15 = mem[1152921514431982000].roll(unweighted:  false);
            if(val_15 != 2)
            {
                    if(val_15 != 1)
            {
                goto label_77;
            }
            
                val_43 = 99;
            }
            else
            {
                    val_43 = 100;
            }
            
            val_42 = 1;
            typeof(BlockShapeSpawner.<>c__DisplayClass31_0).__il2cppRuntimeField_8 = val_43;
            goto label_77;
            label_87:
            if(1 < 100)
            {
                    0 = 1;
            }
            
            if((mem[1152921514431981992] + 12) <= 0)
            {
                    mem[1152921514431981992] + 12 = val_40;
                this.ResetShapeBlockRandomPool();
            }
            
            int val_16 = UnityEngine.Random.Range(min:  0, max:  mem[1152921514431981992] + 12);
            if((mem[1152921514431981992] + 12) <= val_16)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_32 = mem[1152921514431981992] + 8;
            val_32 = val_32 + (val_16 << 2);
            val_44 = mem[(mem[1152921514431981992] + 8 + (val_16) << 2) + 16];
            val_44 = (mem[1152921514431981992] + 8 + (val_16) << 2) + 16;
            if(val_28 != 0)
            {
                    typeof(BlockShapeSpawner.<>c__DisplayClass31_0).__il2cppRuntimeField_8 = val_44;
                val_45 = mem[1152921514431981980];
            }
            else
            {
                    typeof(BlockShapeSpawner.<>c__DisplayClass31_0).__il2cppRuntimeField_8 = val_44;
                val_45 = mem[1152921514431981980];
                val_44 = typeof(BlockShapeSpawner.<>c__DisplayClass31_0).__il2cppRuntimeField_8;
            }
            
            if(val_45 != 0)
            {
                    val_46 = val_45.Item[val_44];
            }
            else
            {
                    val_46 = 0.Item[val_44];
            }
            
            val_45.set_Item(key:  val_44, value:  val_46 + 1);
            val_28 = val_28;
            val_40 = this;
            if((mem[1152921514431981980].Item[typeof(BlockShapeSpawner.<>c__DisplayClass31_0).__il2cppRuntimeField_8]) >= 3)
            {
                    mem[1152921514431981992].RemoveAt(index:  val_16);
            }
            
            val_41 = 1;
            val_42 = 1;
            if((1 & isEasyMode) == false)
            {
                goto label_77;
            }
            
            val_47 = null;
            val_47 = new System.Predicate<ZooTile>(object:  463523840, method:  new IntPtr(1235172288));
            typeof(BlockShapeSpawner.<>c__DisplayClass31_0).__il2cppRuntimeField_C = val_47;
            object val_23 = mem[1152921514431981988] + 12.Find(match:  8040448);
            object val_24 = mem[1152921514431981988] + 12 + 12.GetComponent<System.Object>();
            twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_42 = 0;
            if((CanPlaceShape(blockShape:  mem[1152921514431981988] + 12 + 12, fittingBlocks: out  System.Collections.Generic.List<BlockPuzzleMagic.GridCell> val_26 = 1235188344)) == false)
            {
                goto label_77;
            }
            
            var val_28 = val_41 + 1;
            val_48 = 0;
            goto label_78;
            label_84:
            if(val_28 <= val_48)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_33 = 0;
            val_33 = val_33 + 0;
            mem2[0] = 0;
            if(0 <= val_48)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_34 = 0;
            val_34 = val_34 + 0;
            Add(item:  (0 + 0) + 16);
            val_48 = 1;
            label_78:
            if(val_48 < 0)
            {
                goto label_84;
            }
            
            var val_35 = val_29;
            val_42 = 1;
            val_35 = val_35 - val_48;
            val_41 = val_28;
            label_77:
            if((val_41 <= 99) && (val_42 == 1))
            {
                    if(val_35 > 0)
            {
                goto label_87;
            }
            
            }
            
            val_29 = val_29;
            val_30 = val_30;
            Add(item:  typeof(BlockShapeSpawner.<>c__DisplayClass31_0).__il2cppRuntimeField_8);
            if(1 != qty)
            {
                goto label_90;
            }
            
            label_48:
            val_49 = 0;
            if(val_30 != 0)
            {
                    return;
            }
        
        }
        private System.Collections.Generic.List<BlockPuzzleMagic.BlockColorType> GetRandomColorTypes(int qty = 3)
        {
            var val_7;
            System.Collections.Generic.Dictionary<BlockPuzzleMagic.BlockColorType, System.Int32> val_8;
            var val_9;
            val_7 = qty;
            if(val_7 < 1)
            {
                    return;
            }
            
            do
            {
                if((new System.Collections.Generic.List<WordPets.WordPetType>()) <= 0)
            {
                    new System.Collections.Generic.List<WordPets.WordPetType>() = this;
                this.ResetShapeColorRandomPool();
            }
            
                int val_2 = UnityEngine.Random.Range(min:  0, max:  1235288384);
                if(val_2 <= val_2)
            {
                    var val_7 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_8 = this.shapeColorPickCounter;
                val_7 = val_7 + (val_2 << 2);
                if(val_8 != 0)
            {
                    val_9 = val_8.Item[(0 + (val_2) << 2) + 16];
            }
            else
            {
                    val_8 = 0;
                val_9 = 0.Item[(0 + (val_2) << 2) + 16];
            }
            
                val_8.set_Item(key:  (0 + (val_2) << 2) + 16, value:  val_9 + 1);
                if((this.shapeColorPickCounter.Item[(0 + (val_2) << 2) + 16]) >= 3)
            {
                    this.shapeColorRandomPool.RemoveAt(index:  val_2);
            }
            
                Add(item:  (0 + (val_2) << 2) + 16);
                val_7 = val_7 - 1;
            }
            while(null != 0);
        
        }
        private bool DoesShapeIdExists(int shapeId)
        {
            object val_1 = new System.Object();
            typeof(BlockShapeSpawner.<>c__DisplayClass33_0).__il2cppRuntimeField_8 = shapeId;
            System.Predicate<ZooTile> val_2 = new System.Predicate<ZooTile>(object:  463577088, method:  new IntPtr(1235461824));
            BlockPuzzleMagic.ShapeBlockSpawn val_3 = this.activeShapeBlockModule.ShapeBlocks.Find(match:  8040448);
            if(this.activeShapeBlockModule.ShapeBlocks != 0)
            {
                    this.activeShapeBlockModule.ShapeBlocks = 1;
            }
            
            return true;
        }
        private BlockPuzzleMagic.ShapeInfo CreateShapeWithID(UnityEngine.Transform shapeContainer, int shapeID, BlockPuzzleMagic.BlockColor shapeColor)
        {
            var val_22;
            int val_23;
            var val_24;
            int val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            val_22 = shapeColor;
            val_23 = shapeID;
            object val_1 = new System.Object();
            if(val_1 != 0)
            {
                    val_24 = val_1;
                typeof(BlockShapeSpawner.<>c__DisplayClass34_0).__il2cppRuntimeField_8 = val_23;
            }
            else
            {
                    val_24 = 8;
                mem[8] = val_23;
                val_23 = mem[8];
            }
            
            if(val_23 == 1)
            {
                goto label_3;
            }
            
            if(val_24 != 100)
            {
                goto label_5;
            }
            
            BlockPuzzleMagic.GameReferenceData val_2 = BlockPuzzleMagic.GameReferenceData.Instance;
            UnityEngine.GameObject val_3 = mem[.ctor() + 16].gameObject;
            object val_4 = UnityEngine.Object.Instantiate<System.Object>(original:  mem[.ctor() + 16]);
            val_26 = mem[.ctor() + 16];
            val_27 = 1152921514432372800;
            goto label_11;
            label_3:
            val_28 = 0;
            return;
            label_5:
            if(val_1 == 0)
            {
                    val_25 = mem[8];
            }
            
            if(val_25 != 101)
            {
                goto label_14;
            }
            
            BlockPuzzleMagic.GameReferenceData val_5 = BlockPuzzleMagic.GameReferenceData.Instance;
            UnityEngine.GameObject val_6 = mem[.ctor() + 20].gameObject;
            object val_7 = UnityEngine.Object.Instantiate<System.Object>(original:  mem[.ctor() + 20]);
            val_26 = mem[.ctor() + 20];
            val_27 = 1152921514432373824;
            label_11:
            object val_8 = val_26.GetComponent<System.Object>();
            val_28 = val_26;
            UnityEngine.GameObject val_9 = this.gameObject;
            UnityEngine.Transform val_10 = this.transform;
            val_22 = this;
            UnityEngine.Vector3 val_11 = position;
            val_29 = "shpsrc_shp_spwn";
            return;
            label_14:
            System.Predicate<ZooTile> val_15 = new System.Predicate<ZooTile>(object:  463630336, method:  new IntPtr(1235601584));
            BlockPuzzleMagic.ShapeBlockSpawn val_16 = this.activeShapeBlockModule.ShapeBlocks.Find(match:  8040448);
            object val_17 = UnityEngine.Object.Instantiate<System.Object>(original:  this.activeShapeBlockModule.ShapeBlocks);
            object val_18 = this.activeShapeBlockModule.ShapeBlocks.GetComponent<System.Object>();
            val_28 = this.activeShapeBlockModule.ShapeBlocks;
            UnityEngine.GameObject val_19 = this.gameObject;
            UnityEngine.Transform val_20 = this.transform;
            UnityEngine.Vector3 val_21 = position;
            val_29 = "shpsrc_shp_spwn";
        }
        public void CheckIfAvailableShapesArePlaceable()
        {
            var val_9;
            float val_11;
            var val_12;
            BlockPuzzleMagic.ShapeInfo val_13;
            int val_14;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_9 = 0;
            val_11 = 1152921504765685760;
            val_12 = 1152921504901095424;
            goto label_1;
            label_29:
            val_13 = this.spawnedShapes[val_9];
            if(val_13 != 0)
            {
                goto label_6;
            }
            
            this.ToggleRotationIcon(iconIndex:  0, isVisible:  false);
            goto label_7;
            label_6:
            BlockPuzzleMagic.ShapeInfo val_9 = this.spawnedShapes[val_9];
            var val_12 = 0;
            label_20:
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((CanPlaceShape(blockShape:  this.spawnedShapes[val_9], fittingBlocks: out  System.Collections.Generic.List<BlockPuzzleMagic.GridCell> val_4 = 1236026600)) == true)
            {
                goto label_19;
            }
            
            this.spawnedShapes[val_9].RotateShape(isClockwise:  true, skipAnimate:  true);
            val_12 = val_12 + 1;
            if(val_12 < 3)
            {
                goto label_20;
            }
            
            val_14 = 0;
            goto label_21;
            label_19:
            val_14 = this.spawnedShapes[0x0][0].rotationHeading;
            label_21:
            this.spawnedShapes[val_9].SetRotation(rotationId:  this.spawnedShapes[0x0][0].rotationHeading);
            BlockPuzzleMagic.ShapeInfo val_14 = this.spawnedShapes[val_9];
            int val_6 = val_14 - this.spawnedShapes[0x0][0].rotationHeading;
            if(val_14 != this.spawnedShapes[0x0][0].rotationHeading)
            {
                    val_13 = 1;
            }
            
            if(val_14 > 1)
            {
                    0 = 1;
            }
            
            this.ToggleRotationIcon(iconIndex:  0, isVisible:  true);
            val_12 = val_12;
            val_11 = 1152921504765685760;
            label_7:
            val_9 = 1;
            label_1:
            if(val_9 < this)
            {
                goto label_29;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_24.Invoke(obj:  true);
        }
        public UnityEngine.GameObject AnyUnplaceablePieces()
        {
            goto label_1;
            label_16:
            if(this.spawnedShapes[0] == 0)
            {
                goto label_10;
            }
            
            BlockPuzzleMagic.ShapeInfo val_4 = this.spawnedShapes[0];
            if((this.spawnedShapes[0].<Placeable>k__BackingField) == true)
            {
                goto label_10;
            }
            
            BlockPuzzleMagic.ShapeInfo val_5 = this.spawnedShapes[0];
            if(this.spawnedShapes[0].rotationHeadingNeededToPlace >= 4)
            {
                goto label_14;
            }
            
            label_10:
            4 = 5;
            label_1:
            if((4 - 4) < this.spawnedShapes[0].rotationHeadingNeededToPlace)
            {
                goto label_16;
            }
            
            return;
            label_14:
            BlockPuzzleMagic.ShapeInfo val_6 = this.spawnedShapes[0];
            if(val_6 != 0)
            {
                    return val_6.gameObject;
            }
            
            return val_6.gameObject;
        }
        public bool IsAllPiecesUnplaceable()
        {
            var val_2;
            var val_3;
            val_2 = 4;
            goto label_1;
            label_16:
            if(this.spawnedShapes[0] != 0)
            {
                    BlockPuzzleMagic.ShapeInfo val_4 = this.spawnedShapes[0];
                val_3 = 0;
                if((this.spawnedShapes[0].<Placeable>k__BackingField) != true)
            {
                    return (bool)val_3;
            }
            
                BlockPuzzleMagic.ShapeInfo val_5 = this.spawnedShapes[0];
                if(this.spawnedShapes[0].rotationHeadingNeededToPlace < 4)
            {
                    return (bool)val_3;
            }
            
            }
            
            val_2 = 5;
            label_1:
            if((val_2 - 4) < this.spawnedShapes[0].rotationHeadingNeededToPlace)
            {
                goto label_16;
            }
            
            val_3 = 1;
            return (bool)val_3;
        }
        private void ToggleRotationIcon(int iconIndex, bool isVisible)
        {
            DG.Tweening.Sequence val_14;
            if(isVisible != false)
            {
                    BestBlocksPlayer val_1 = BestBlocksPlayer.Instance;
                val_14 = 0;
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                if((public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14) != 0)
            {
                    MonoSingleton<T>.__il2cppRuntimeField_cctor_finished = mem[public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14 + 8];
                MonoSingleton<T>.__il2cppRuntimeField_cctor_finished = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14 + 8;
            }
            
                if((public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14) == 0)
            {
                    MonoSingleton<T>.__il2cppRuntimeField_cctor_finished = 0;
            }
            
                EnumerableExtentions.SetOrAdd<System.Int32Enum, System.Boolean>(dic:  0, key:  0, newValue:  true);
                if(this.rotationIconSeq[iconIndex] == 0)
            {
                    DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
                this.rotationIconSeq[iconIndex] = 0;
                object val_4 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<System.Object>(t:  this.rotationIconSeq[iconIndex], autoKillOnCompletion:  false);
                object val_5 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  this.rotationIconSeq[iconIndex], loops:  0, loopType:  1);
                UnityEngine.UI.Image val_18 = this.rotateShapeIcon[iconIndex];
                DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOFade(target:  val_18, endValue:  null, duration:  null);
                object val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  val_18, ease:  7);
                DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.rotationIconSeq[iconIndex], t:  val_18);
                val_14 = this.rotationIconSeq[iconIndex];
                UnityEngine.UI.Image val_19 = this.rotateShapeIcon[iconIndex];
                DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions46.DOFade(target:  val_19, endValue:  null, duration:  null);
                object val_10 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  val_19, ease:  7);
                DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_14, t:  val_19);
            }
            
                DG.Tweening.TweenExtensions.Restart(t:  this.rotationIconSeq[iconIndex], includeDelay:  true, changeDelayTo:  null);
                return;
            }
            
            if(this.rotationIconSeq[iconIndex] != 0)
            {
                    object val_12 = DG.Tweening.TweenExtensions.Pause<System.Object>(t:  this.rotationIconSeq[iconIndex]);
            }
            
            UnityEngine.UI.Image val_23 = this.rotateShapeIcon[iconIndex];
            UnityEngine.Color val_13 = color;
            this.rotateShapeIcon[iconIndex].color = new UnityEngine.Color() {r = R6, g = R7, b = SB, a = 0f};
        }
        public BlockShapeSpawner()
        {
            this.spawnedShapes = null;
            this.rotationIconSeq = null;
            System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
            this.shapeBlockPickCounter = null;
            System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32> val_2 = new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>();
            this.shapeColorPickCounter = null;
            System.Collections.Generic.List<System.Int32> val_3 = new System.Collections.Generic.List<System.Int32>();
            this.shapeBlockRandomPool = null;
            System.Collections.Generic.List<WordPets.WordPetType> val_4 = new System.Collections.Generic.List<WordPets.WordPetType>();
            this.shapeColorRandomPool = null;
            this.powerupAPChanceRandomSet = new RandomSet();
        }
    
    }

}
