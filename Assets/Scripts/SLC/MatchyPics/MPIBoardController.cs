using UnityEngine;

namespace SLC.MatchyPics
{
    public class MPIBoardController : MonoSingleton<SLC.MatchyPics.MPIBoardController>
    {
        // Fields
        public const int EMPTY_TILE = -1;
        public const float TILES_SPEED = 5;
        public const float SHUFFLE_DELAY = 0.4;
        private SLC.MatchyPics.MPILevel <CurrentLevel>k__BackingField;
        private int <Width>k__BackingField;
        private int <Height>k__BackingField;
        private UnityEngine.GameObject tilePrefab;
        private UnityEngine.Transform gameBoardRoot;
        private MPILineDrawer lineDrawer;
        private UnityEngine.Vector3 tileSize;
        private UnityEngine.RectTransform boardSize;
        public UnityEngine.GameObject ftuxIndicator;
        private System.Collections.Generic.List<SLC.MatchyPics.MPIGridTile> tiles;
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<SLC.MatchyPics.MPIGridTile>> tilesBySprite;
        private UnityEngine.Vector3[,] nodesPositions;
        private int[,] tilesIndex;
        private System.Tuple<UnityEngine.Vector2Int, UnityEngine.Vector2Int> validPair;
        private SLC.MatchyPics.MPIMovementMechanic movementMechanic;
        private UnityEngine.Vector2Int[] movDirections;
        private int directionIndex;
        private bool needsMovementUpdate;
        private SLC.MatchyPics.MPIPathFinding pathFinding;
        private SLC.MatchyPics.MPIGridTile tile_a;
        private SLC.MatchyPics.MPIGridTile tile_b;
        private bool shuffleUpdate;
        private bool isLevelCompleted;
        private FrameSkipper frameSkipper;
        private System.Action OnValidMatchSubmitted;
        private UnityEngine.Vector2Int[] adjacentPos;
        private const float InitialAnimDuration = 0.3;
        private const float DelayDelta = 0.05;
        
        // Properties
        public SLC.MatchyPics.MPILevel CurrentLevel { get; set; }
        public bool IsLocked { get; }
        public int Width { get; set; }
        public int Height { get; set; }
        
        // Methods
        public SLC.MatchyPics.MPILevel get_CurrentLevel()
        {
        
        }
        private void set_CurrentLevel(SLC.MatchyPics.MPILevel value)
        {
            this.<CurrentLevel>k__BackingField = value;
        }
        public bool get_IsLocked()
        {
            if(this.shuffleUpdate == false)
            {
                    this.shuffleUpdate = this.needsMovementUpdate;
                goto label_0;
            }
            
            return true;
            label_0:
            if(this.isLevelCompleted == true)
            {
                    this.isLevelCompleted = 1;
            }
            
            return true;
        }
        public int get_Width()
        {
            return (int)this.<Width>k__BackingField;
        }
        private void set_Width(int value)
        {
            this.<Width>k__BackingField = value;
        }
        public int get_Height()
        {
            return (int)this.<Height>k__BackingField;
        }
        private void set_Height(int value)
        {
            this.<Height>k__BackingField = value;
        }
        public void addOnValidMatchSubmittedAction(System.Action callback)
        {
            System.Action val_3;
            if((this.CheckValidCallback(wordRegionEvent:  this.OnValidMatchSubmitted, callback:  callback)) == false)
            {
                    return;
            }
            
            val_3 = this.OnValidMatchSubmitted;
            System.Delegate val_2 = System.Delegate.Combine(a:  val_3, b:  callback);
            if(val_3 != 0)
            {
                    if(null == null)
            {
                goto label_3;
            }
            
            }
            
            val_3 = 0;
            label_3:
            this.OnValidMatchSubmitted = val_3;
        }
        public override void InitMonoSingleton()
        {
            var val_4;
            var val_7;
            var val_10;
            this.pathFinding = new SLC.MatchyPics.MPIPathFinding();
            twelvegigs.Autopilot.WUTAutopilotGameplay val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  749426480);
            this.frameSkipper = this;
            UnityEngine.Vector2Int val_3 = UnityEngine.Vector2Int.up;
            typeof(UnityEngine.Vector2Int[]).__il2cppRuntimeField_10 = val_4;
            UnityEngine.Vector2Int val_6 = UnityEngine.Vector2Int.right;
            typeof(UnityEngine.Vector2Int[]).__il2cppRuntimeField_18 = val_7;
            UnityEngine.Vector2Int val_9 = UnityEngine.Vector2Int.down;
            typeof(UnityEngine.Vector2Int[]).__il2cppRuntimeField_20 = val_10;
            UnityEngine.Vector2Int val_12 = UnityEngine.Vector2Int.left;
            typeof(UnityEngine.Vector2Int[]).__il2cppRuntimeField_28 = ???;
            this.movDirections = null;
        }
        public void LoadLevel(SLC.MatchyPics.MPILevel level)
        {
            int val_8;
            int val_9;
            int val_27;
            int val_28;
            System.Int32[,] val_29;
            SLC.MatchyPics.MPIBoardController val_31;
            twelvegigs.sweepstakes.Distribution val_32;
            var val_33;
            var val_34;
            int val_35;
            SLC.MatchyPics.MPILevel val_37;
            var val_38;
            int val_39;
            this.isLevelCompleted = false;
            this.<CurrentLevel>k__BackingField = level;
            int val_27 = level.LevelDefinition.Width;
            val_27 = val_27 + 2;
            this.<Width>k__BackingField = val_27;
            val_27 = (this.<CurrentLevel>k__BackingField.LevelDefinition.Height) + 2;
            this.<Height>k__BackingField = val_27;
            this.tilesIndex = null;
            val_28 = this.<Height>k__BackingField;
            if(val_28 >= 1)
            {
                    var val_29 = 0;
                do
            {
                if((this.<Width>k__BackingField) >= 1)
            {
                    var val_28 = 0;
                do
            {
                val_29 = this.tilesIndex;
                val_28 = val_28 + 1;
                mem2[0] = 0;
            }
            while(val_28 < (this.<Width>k__BackingField));
            
                val_28 = this.<Height>k__BackingField;
            }
            
                val_29 = val_29 + 1;
            }
            while(val_29 < val_28);
            
            }
            
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_31 = this;
            mem[1152921513946343816] = null;
            val_32 = public System.Void System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<SLC.MatchyPics.MPIGridTile>>::.ctor();
            System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_2 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
            mem[1152921513946343820] = null;
            val_33 = 0;
            goto label_12;
            label_51:
            val_32 = 0;
            var val_30 = 16;
            val_34 = 0;
            val_30 = val_30 + 0;
            goto label_13;
            label_48:
            object val_3 = UnityEngine.Object.Instantiate<System.Object>(original:  mem[1152921513946343784], parent:  mem[1152921513946343788]);
            object val_4 = mem[1152921513946343784].GetComponent<System.Object>();
            val_29 = mem[1152921513946343784];
            if((mem[level.LevelTiles + 12]) <= SL)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_31 = mem[level.LevelTiles + 8];
            val_31 = val_31 + val_30;
            if(val_29 != 0)
            {
                    val_29.Setup(data:  (mem[level.LevelTiles + 8] + (16 + 0)) + 0);
            }
            else
            {
                    val_29.Setup(data:  (mem[level.LevelTiles + 8] + (16 + 0)) + 0);
            }
            
            UnityEngine.GameObject val_5 = val_29.gameObject;
            val_29.SetActive(value:  false);
            UnityEngine.Vector2Int val_6 = this.<Width>k__BackingField.Location;
            UnityEngine.Vector2Int val_7 = UnityEngine.Vector2Int.zero;
            val_35 = val_9;
            if((UnityEngine.Vector2Int.op_Equality(lhs:  new UnityEngine.Vector2Int() {m_X = this.<Width>k__BackingField, m_Y = val_27}, rhs:  new UnityEngine.Vector2Int() {m_X = val_8, m_Y = val_35})) != false)
            {
                    UnityEngine.Vector2Int val_11 = new UnityEngine.Vector2Int(x:  1, y:  1);
                val_35 = 0;
                val_29.Location = new UnityEngine.Vector2Int() {m_X = val_11.m_X, m_Y = val_11.m_Y};
            }
            
            val_27 = public System.Void System.Collections.Generic.List<SLC.MatchyPics.MPIGridTile>::Add(SLC.MatchyPics.MPIGridTile item);
            Add(item:  val_29);
            if((mem[level.LevelTiles + 12]) <= SL)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_32 = mem[level.LevelTiles + 8];
            val_32 = val_30;
            val_32 = val_32 + val_32;
            if(((mem[level.LevelTiles + 8] + (16 + 0)) + 0 + 20) == 0)
            {
                    UnityEngine.Vector2Int val_12 = val_11.m_X.Location;
                int val_13 = val_11.m_X.x;
                UnityEngine.Vector2Int val_14 = Location;
                int val_15 = val_8.y;
                mem2[0] = ???;
                val_31 = this;
                if((ContainsKey(key:  mem[1152921513946343784] + 44 + 12)) != true)
            {
                    System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_17 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
                val_35 = public System.Void System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<SLC.MatchyPics.MPIGridTile>>::Add(System.Int32 key, System.Collections.Generic.List<SLC.MatchyPics.MPIGridTile> value);
                Add(key:  mem[1152921513946343784] + 44 + 12, value:  80883712);
            }
            
                System.TimeType val_18 = Item[mem[1152921513946343784] + 44 + 12];
                val_32 = val_29;
                val_27 = public System.Void System.Collections.Generic.List<SLC.MatchyPics.MPIGridTile>::Add(SLC.MatchyPics.MPIGridTile item);
                Add(item:  val_32);
            }
            
            val_34 = 1;
            label_13:
            var val_19 = 0 + val_34;
            if(val_34 < level.LevelDefinition.Width)
            {
                goto label_48;
            }
            
            val_33 = 1;
            label_12:
            if(1 < level.LevelDefinition.Height)
            {
                goto label_51;
            }
            
            this.LoadPathdFindingAndValidateBoard();
            val_37 = this.<CurrentLevel>k__BackingField;
            if(val_37 == 0)
            {
                goto label_52;
            }
            
            val_38 = val_31;
            mem[1152921513946343836] = level.MovementMechanic;
            goto label_53;
            label_52:
            val_38 = val_31;
            mem[1152921513946343836] = level.MovementMechanic;
            val_37 = this.<CurrentLevel>k__BackingField;
            if(val_37 == 0)
            {
                goto label_54;
            }
            
            label_53:
            if(level.directionIndex > 1)
            {
                    val_39 = mem[level + 52];
                val_39 = level.directionIndex;
            }
            
            mem[1152921513946343844] = UnityEngine.Random.Range(min:  0, max:  mem[1152921513946343840] + 12);
            if((this.<CurrentLevel>k__BackingField.IsNew) != false)
            {
                    System.Collections.Generic.List<SLC.MatchyPics.MPIGridTile> val_22 = this.SetTimedObject(count:  level.BombMechanic, outerEdge:  false, type:  1);
                System.Collections.Generic.List<SLC.MatchyPics.MPIGridTile> val_23 = this.SetTimedObject(count:  level.ChestReward, outerEdge:  true, type:  2);
                this.<CurrentLevel>k__BackingField.SaveStartToJSON();
                this.SetupCollections(items:  level.collectionItems);
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            val_8 = level.BombMechanic;
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            typeof(System.Object[]).__il2cppRuntimeField_18 = null;
            UnityEngine.Debug.LogFormat(format:  749538032, args:  472754880);
            string val_24 = this.TilesToString();
            UnityEngine.Debug.Log(message:  749562192);
            System.Collections.IEnumerator val_25 = this.LoadTiles();
            UnityEngine.Coroutine val_26 = this.StartCoroutine(routine:  749562192);
            return;
            label_54:
        }
        public void SelectTile(SLC.MatchyPics.MPIGridTile tile)
        {
            if(this.shuffleUpdate == false)
            {
                    this.shuffleUpdate = this.needsMovementUpdate;
                goto label_1;
            }
            
            return;
            label_1:
            if((tile.<tileData>k__BackingField.IsRemoved) == true)
            {
                    return;
            }
            
            tile.HighLight();
            if(this.tile_a == 0)
            {
                    this.tile_a = tile;
                UnityEngine.Vector2Int val_2 = Location;
                string val_5 = 749678864 + 155537408;
                UnityEngine.Debug.Log(message:  749678864);
                return;
            }
            
            if(this.tile_a == tile)
            {
                    this.tile_a.Reset();
                this.tile_a = 0;
                return;
            }
            
            this.tile_b = tile;
            UnityEngine.Vector2Int val_7 = Location;
            string val_8 = 749687152 + 155537408;
            UnityEngine.Debug.Log(message:  749687152);
            if((this.tile_a.IsAMatch(tile:  this.tile_b)) != false)
            {
                    this.ValidatePairPath(tile1:  this.tile_a, tile2:  this.tile_b);
            }
            else
            {
                    this.tile_a.ShakeAndReset();
                this.tile_b.ShakeAndReset();
                twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  5, oneshot:  true, pitch:  null, vol:  null);
            }
            
            this.tile_a = 0;
            this.tile_b = 0;
        }
        public void ShufflePowerUp()
        {
            this.shuffleUpdate = true;
            this.ShuffleBoard();
            this.LoadPathdFindingAndValidateBoard();
            System.Collections.IEnumerator val_1 = this.SetTilesPositions(shuffle:  true, setActive:  true);
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  749888784);
            if((this.<CurrentLevel>k__BackingField) == 0)
            {
                
            }
        
        }
        public void ShowHint(bool isFtux = False)
        {
            if(this.isLevelCompleted == true)
            {
                    return;
            }
            
            if(this.validPair != 0)
            {
                    int val_5 = this.tilesIndex[isFtux.x.y];
                int val_6 = this.tilesIndex[this.tilesIndex[isFtux.x.y].x.y];
                if(this.tilesIndex[this.tilesIndex[isFtux.x.y].x.y] <= val_5)
            {
                    var val_7 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_7 = val_7 + (val_5 << 2);
                (0 + (this.tilesIndex[val_2][0]) << 2) + 16.HighLightHint(isFtux:  isFtux);
                if(((0 + (this.tilesIndex[val_2][0]) << 2) + 16) <= val_6)
            {
                    var val_8 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_8 = val_8 + (val_6 << 2);
                (0 + (this.tilesIndex[val_4][0]) << 2) + 16.HighLightHint(isFtux:  isFtux);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  750079184);
        }
        public void NoBombs()
        {
            var val_2;
            System.Action<SLC.MatchyPics.MPIGridTile> val_4;
            this.<CurrentLevel>k__BackingField.BombMechanic = 0;
            val_2 = null;
            val_2 = null;
            val_4 = MPIBoardController.<>c.<>9__45_0;
            if(val_4 == 0)
            {
                    val_4 = null;
                val_4 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  MPIBoardController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(750297872));
                MPIBoardController.<>c.<>9__45_0 = val_4;
            }
            
            this.tiles.ForEach(action:  7401472);
            if((this.<CurrentLevel>k__BackingField) == 0)
            {
                
            }
        
        }
        public void UpdateImageSet()
        {
            twelvegigs.sweepstakes.Distribution val_3;
            this.tilesBySprite.Clear();
            List.Enumerator<T> val_1 = GetEnumerator();
            label_14:
            if(MoveNext() == false)
            {
                goto label_3;
            }
            
            if(val_3.IsActive == false)
            {
                goto label_14;
            }
            
            val_3.UpdateImageSet();
            if((this.tilesBySprite.ContainsKey(key:  val_3 + 44 + 12)) != true)
            {
                    System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_6 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
                this.tilesBySprite.Add(key:  val_3 + 44 + 12, value:  80883712);
            }
            
            System.Collections.Generic.List<SLC.MatchyPics.MPIGridTile> val_7 = this.tilesBySprite.Item[val_3 + 44 + 12];
            this.tilesBySprite.Add(item:  val_3);
            goto label_14;
            label_3:
            Dispose();
            if((this.<CurrentLevel>k__BackingField) != 0)
            {
                    return;
            }
        
        }
        public void UpdateTilesTimer()
        {
            object val_1 = new System.Object();
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            typeof(MPIBoardController.<>c__DisplayClass47_0).__il2cppRuntimeField_8 = public static SLC.MatchyPics.MPIGameplayController MonoSingleton<SLC.MatchyPics.MPIGameplayController>::get_Instance().__il2cppRuntimeField_18;
            System.Action<twelvegigs.storage.JsonDictionary> val_3 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  437166080, method:  new IntPtr(750598672));
            this.tiles.ForEach(action:  7401472);
        }
        private void ValidatePairPath(SLC.MatchyPics.MPIGridTile tile1, SLC.MatchyPics.MPIGridTile tile2)
        {
            int val_3;
            object val_14;
            System.Tuple<UnityEngine.Vector2Int, UnityEngine.Vector2Int> val_15;
            UnityEngine.Vector2Int val_1 = Location;
            UnityEngine.Vector2Int val_2 = Location;
            System.Collections.Generic.List<UnityEngine.Vector2Int> val_4 = this.pathFinding.ValidatePath(from:  new UnityEngine.Vector2Int(), to:  new UnityEngine.Vector2Int() {m_X = val_3});
            val_14 = this.pathFinding;
            if((this.pathFinding.<Width>k__BackingField) < 1)
            {
                goto label_5;
            }
            
            string val_5 = MiniJSON.Json.Serialize(obj:  val_14);
            string val_6 = 750728080 + val_14;
            UnityEngine.Debug.Log(message:  750728080);
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            EarnPoints(points:  this.pathFinding.<Width>k__BackingField);
            System.Collections.Generic.List<UnityEngine.Vector3> val_8 = this.GetPathPositions(path:  val_14);
            val_14 = this;
            this.lineDrawer.DrawPath(path:  750770832);
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_15 = 0;
            Play(pointsPath:  750770832);
            System.Collections.IEnumerator val_10 = this.StartRemovingTiles(tileA:  tile1, tileB:  tile2);
            UnityEngine.Coroutine val_11 = tile2.StartCoroutine(routine:  750770832);
            this.RemoveTile(tile:  tile1);
            this.RemoveTile(tile:  tile2);
            this.validPair = val_15;
            if(this.tilesBySprite.Count == 0)
            {
                goto label_16;
            }
            
            this.PerformMovementMechanic();
            if(this.needsMovementUpdate == false)
            {
                    this.needsMovementUpdate = this;
                this.LoadPathdFindingAndValidateBoard();
            }
            
            this.ResetTiles();
            return;
            label_5:
            UnityEngine.Debug.Log(message:  750738432);
            tile1.ShakeAndReset();
            tile2.ShakeAndReset();
            twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  5, oneshot:  true, pitch:  null, vol:  null);
            return;
            label_16:
            UnityEngine.Debug.Log(message:  750738528);
            val_15 = this.frameSkipper;
            this.isLevelCompleted = true;
            this.frameSkipper.updateLogic = 0;
        }
        private void PerformMovementMechanic()
        {
            int val_4;
            SLC.MatchyPics.MPIPathFinding val_5;
            UnityEngine.Vector2Int val_6;
            int val_7;
            if(this.movementMechanic == 0)
            {
                    return;
            }
            
            if(this.movementMechanic == 2)
            {
                    this.directionIndex = this.directionIndex + 1;
                val_4 = R1;
                this.directionIndex = ;
            }
            else
            {
                    val_4 = this.directionIndex;
            }
            
            val_5 = this.pathFinding;
            val_6 = this.movDirections[val_4];
            if((val_5.PerformMovement(tiles:  this.tilesIndex, direction:  new UnityEngine.Vector2Int() {m_X = this.movDirections[val_4], m_Y = val_6})) == 0)
            {
                    return;
            }
            
            val_7 = this.<Height>k__BackingField;
            if(val_7 >= 1)
            {
                    do
            {
                if((this.<Width>k__BackingField) >= 1)
            {
                    do
            {
                int val_5 = this.tilesIndex[this.<Width>k__BackingField];
                if(val_5 >= 0)
            {
                    int val_6 = this.tilesIndex[val_5];
                if(this.tilesIndex[val_5] <= val_6)
            {
                    var val_7 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_7 = val_7 + (val_6 << 2);
                UnityEngine.Vector2Int val_3 = new UnityEngine.Vector2Int(x:  0, y:  0);
                (0 + (this.tilesIndex[this.tilesIndex[this.<Width>k__BackingField][0]][0]) << 2) + 16.Location = new UnityEngine.Vector2Int() {m_X = val_3.m_X, m_Y = val_3.m_Y};
                if(((0 + (this.tilesIndex[this.tilesIndex[this.<Width>k__BackingField][0]][0]) << 2) + 16) <= val_6)
            {
                    var val_8 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_8 = val_8 + (val_6 << 2);
                (0 + (this.tilesIndex[this.tilesIndex[this.<Width>k__BackingField][0]][0]) << 2) + 16.ResetHint();
            }
            
                val_6 = 0 + 1;
            }
            while(val_6 < (this.<Width>k__BackingField));
            
                val_7 = this.<Height>k__BackingField;
            }
            
                val_5 = 0 + 1;
            }
            while(val_5 < val_7);
            
            }
            
            this.needsMovementUpdate = true;
        }
        private bool CheckValidPairs()
        {
            float val_2;
            System.Collections.Generic.IEnumerable<TSource> val_4;
            System.Tuple<UnityEngine.Vector2Int, UnityEngine.Vector2Int> val_9;
            var val_10;
            System.Func<SLC.MatchyPics.MPIGridTile, UnityEngine.Vector2Int> val_12;
            var val_13;
            Dictionary.Enumerator<TKey, TValue> val_1 = GetEnumerator();
            label_11:
            if(0.MoveNext() == false)
            {
                goto label_2;
            }
            
            if((val_4 + 12) == 0)
            {
                goto label_11;
            }
            
            val_10 = null;
            val_10 = null;
            val_12 = MPIBoardController.<>c.<>9__50_0;
            if(val_12 == 0)
            {
                    val_12 = null;
                val_12 = new System.Func<System.Object, UnityEngine.Vector2Int>(object:  MPIBoardController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(751408080));
                MPIBoardController.<>c.<>9__50_0 = val_12;
            }
            
            System.Collections.Generic.IEnumerable<TResult> val_6 = System.Linq.Enumerable.Select<System.Object, UnityEngine.Vector2Int>(source:  val_4, selector:  7720960);
            System.Collections.Generic.List<TSource> val_7 = System.Linq.Enumerable.ToList<UnityEngine.Vector2Int>(source:  val_4);
            System.Tuple<UnityEngine.Vector2Int, UnityEngine.Vector2Int> val_8 = this.pathFinding.FindPaths(fnodes:  val_4);
            this.validPair = this.pathFinding;
            if(this.pathFinding == 0)
            {
                goto label_11;
            }
            
            val_2 = 2;
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            val_9 = this.validPair;
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            UnityEngine.Debug.LogFormat(format:  751423440, args:  472754880);
            val_13 = 1;
            goto label_23;
            label_2:
            val_13 = 0;
            label_23:
            0.Dispose();
            return (bool)val_13;
        }
        private void CalculateNodesPositions()
        {
            var val_11;
            var val_16;
            System.Collections.Generic.List<UnityEngine.Vector3> val_17;
            int val_18;
            int val_19;
            UnityEngine.Vector3 val_20;
            UnityEngine.Vector3 val_23;
            val_16 = this;
            UnityEngine.Vector3 val_17 = this.tileSize;
            val_17 = null;
            val_17 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            this.nodesPositions = null;
            val_18 = this.<Height>k__BackingField;
            if(val_18 > 0)
            {
                    float val_16 = 0.5f;
                val_19 = this.<Width>k__BackingField;
                val_20 = ((float)(this.<Height>k__BackingField) - 1) * val_16;
                val_16 = ((float)1 - (this.<Width>k__BackingField)) * val_16;
                float val_4 = S16 * val_20;
                val_17 = val_17 * val_16;
                do
            {
                if(val_19 >= 1)
            {
                    var val_20 = 0;
                do
            {
                val_20 = this.tileSize;
                UnityEngine.Vector3 val_5 = new UnityEngine.Vector3(x:  0f, y:  null);
                val_16 = val_16;
                val_17 = val_17;
                val_23 = this.nodesPositions[0];
                Add(item:  new UnityEngine.Vector3() {x = this.nodesPositions[0], y = val_23, z = this.nodesPositions[0]});
                val_19 = this.<Width>k__BackingField;
                val_20 = val_20 + 1;
            }
            while(val_20 < val_19);
            
                val_18 = this.<Height>k__BackingField;
            }
            
            }
            while((0 + 1) < val_18);
            
            }
            else
            {
                    val_19 = this.<Width>k__BackingField;
            }
            
            float val_21 = -0.6f;
            UnityEngine.Vector2 val_8 = val_5.x.sizeDelta;
            float val_22 = val_5.x;
            val_21 = this.tileSize * ((float)val_19 + val_21);
            UnityEngine.Vector2 val_10 = sizeDelta;
            val_22 = val_22 / val_21;
            float val_12 = ((float)val_18 + val_21) * S16;
            val_12 = val_11 / val_12;
            typeof(System.Single[]).__il2cppRuntimeField_10 = val_22;
            typeof(System.Single[]).__il2cppRuntimeField_14 = val_12;
            typeof(System.Single[]).__il2cppRuntimeField_18 = 1068708659;
            float val_13 = UnityEngine.Mathf.Min(values:  533895840);
            val_23 = 0;
            UnityEngine.Transform val_14 = this.gameBoardRoot.transform;
            UnityEngine.Vector3 val_15 = new UnityEngine.Vector3(x:  533895840, y:  val_10.y, z:  null);
            this.gameBoardRoot.localScale = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
        }
        private void LoadPathdFindingAndValidateBoard()
        {
            this.pathFinding.LoadBoard(board:  this.tilesIndex);
            if(this.CheckValidPairs() == true)
            {
                    return;
            }
            
            do
            {
                this.ShuffleBoard();
                this.shuffleUpdate = true;
            }
            while(this.CheckValidPairs() == false);
        
        }
        private void ResetTiles()
        {
            int val_1 = this.<Height>k__BackingField;
            if(val_1 < 1)
            {
                    return;
            }
            
            var val_6 = 0;
            do
            {
                if((this.<Width>k__BackingField) >= 1)
            {
                    var val_5 = 0;
                do
            {
                int val_1 = this.tilesIndex[this.<Width>k__BackingField];
                if(val_1 >= 0)
            {
                    int val_2 = this.tilesIndex[val_1];
                if(this.tilesIndex[val_1] <= val_2)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_3 = val_3 + (val_2 << 2);
                (0 + (this.tilesIndex[this.tilesIndex[this.<Width>k__BackingField][0]][0]) << 2) + 16.ResetHint();
                if(((0 + (this.tilesIndex[this.tilesIndex[this.<Width>k__BackingField][0]][0]) << 2) + 16) <= val_2)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_4 = val_4 + (val_2 << 2);
                (0 + (this.tilesIndex[this.tilesIndex[this.<Width>k__BackingField][0]][0]) << 2) + 16.Reset();
            }
            
                val_5 = val_5 + 1;
            }
            while(val_5 < (this.<Width>k__BackingField));
            
                val_1 = this.<Height>k__BackingField;
            }
            
                val_6 = val_6 + 1;
            }
            while(val_6 < val_1);
        
        }
        private void ShuffleBoard()
        {
            SLC.MatchyPics.MPIBoardController val_6;
            System.Collections.Generic.List<System.Int32> val_7;
            System.Collections.Generic.List<UnityEngine.Vector2Int> val_8;
            int val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_6 = this;
            val_7 = null;
            val_7 = new System.Collections.Generic.List<System.Int32>();
            val_8 = null;
            val_8 = new System.Collections.Generic.List<UnityEngine.Vector2Int>();
            val_9 = this.<Height>k__BackingField;
            if(val_9 > 0)
            {
                    do
            {
                if((this.<Width>k__BackingField) >= 1)
            {
                    var val_8 = 0;
                do
            {
                val_10 = mem[this.tilesIndex + 8];
                val_10 = this.tilesIndex + 8;
                if(val_10 <= val_8)
            {
                    val_10 = mem[this.tilesIndex + 8];
                val_10 = this.tilesIndex + 8;
            }
            
                val_11 = mem[this.tilesIndex + 8 + 8];
                val_11 = this.tilesIndex + 8 + 8;
                val_10 = this.tilesIndex + (val_10 << 2);
                if(((this.tilesIndex + (this.tilesIndex + 8) << 2) + 16) >= 0)
            {
                    val_12 = mem[this.tilesIndex + 8];
                val_12 = this.tilesIndex + 8;
                if(val_12 <= val_8)
            {
                    val_12 = mem[this.tilesIndex + 8];
                val_12 = this.tilesIndex + 8;
            }
            
                val_12 = this.tilesIndex + (val_12 << 2);
                Add(item:  (this.tilesIndex + (this.tilesIndex + 8) << 2) + 16);
                UnityEngine.Vector2Int val_3 = new UnityEngine.Vector2Int(x:  0, y:  0);
                Add(item:  new UnityEngine.Vector2Int() {m_X = val_3.m_X, m_Y = val_3.m_Y});
                val_13 = mem[this.tilesIndex + 8];
                val_13 = this.tilesIndex + 8;
                if(val_13 <= val_8)
            {
                    val_13 = mem[this.tilesIndex + 8];
                val_13 = this.tilesIndex + 8;
            }
            
                val_11 = mem[this.tilesIndex + 8 + 8];
                val_11 = this.tilesIndex + 8 + 8;
                val_13 = this.tilesIndex + (val_13 << 2);
                if((this.tiles + 12) <= ((this.tilesIndex + (this.tilesIndex + 8) << 2) + 16))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_6 = this.tiles + 8;
                val_6 = val_6 + (((this.tilesIndex + (this.tilesIndex + 8) << 2) + 16) << 2);
                (this.tiles + 8 + ((this.tilesIndex + (this.tilesIndex + 8) << 2) + 16) << 2) + 16.ResetHint();
                val_8 = val_8;
                if((this.tiles + 12) <= ((this.tilesIndex + (this.tilesIndex + 8) << 2) + 16))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_7 = this.tiles + 8;
                val_7 = val_7 + (((this.tilesIndex + (this.tilesIndex + 8) << 2) + 16) << 2);
                (this.tiles + 8 + ((this.tilesIndex + (this.tilesIndex + 8) << 2) + 16) << 2) + 16.Reset();
                val_6 = val_6;
                val_7 = val_7;
            }
            
                val_8 = val_8 + 1;
            }
            while(val_8 < (this.<Width>k__BackingField));
            
                val_9 = val_9;
            }
            
                val_14 = 0 + 1;
            }
            while(val_14 < val_9);
            
            }
            
            val_15 = 0;
            PluginExtension.Shuffle<UnityEngine.Vector2Int>(list:  80883712, seed:  new System.Nullable<System.Int32>() {HasValue = false});
            this.tile_a = 0;
            this.tile_b = 0;
        }
        private void OnRemoveTilesFinish()
        {
            var val_5;
            if(this.needsMovementUpdate == false)
            {
                goto label_1;
            }
            
            val_5 = this;
            System.Collections.IEnumerator val_1 = this.MoveTiles();
            goto label_2;
            label_1:
            if(this.shuffleUpdate == false)
            {
                goto label_3;
            }
            
            val_5 = this;
            System.Collections.IEnumerator val_2 = this.SetTilesPositions(shuffle:  true, setActive:  true);
            label_2:
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  752451968);
            return;
            label_3:
            if(this.OnValidMatchSubmitted != 0)
            {
                    this.OnValidMatchSubmitted.Invoke();
            }
            
            if(this.isLevelCompleted == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnLevelCompleted();
        }
        private void RemoveTile(SLC.MatchyPics.MPIGridTile tile)
        {
            UnityEngine.Vector2Int val_1 = 0.Location;
            int val_2 = 0.x;
            UnityEngine.Vector2Int val_3 = Location;
            this.tilesIndex[???.y] = 0;
            System.Collections.Generic.List<SLC.MatchyPics.MPIGridTile> val_5 = this.tilesBySprite.Item[tile.<tileData>k__BackingField.SpriteIndex];
            bool val_6 = this.tilesBySprite.Remove(item:  tile);
            System.Collections.Generic.List<SLC.MatchyPics.MPIGridTile> val_7 = this.tilesBySprite.Item[tile.<tileData>k__BackingField.SpriteIndex];
            if(this.tilesBySprite == 0)
            {
                    bool val_8 = this.tilesBySprite.Remove(key:  tile.<tileData>k__BackingField.SpriteIndex);
            }
            
            tile.<tileData>k__BackingField.IsRemoved = true;
            tile.OnTileRemoved();
        }
        private void SetupCollections(int items)
        {
            if(items == 0)
            {
                    return;
            }
            
            System.Collections.Generic.List<SLC.MatchyPics.MPIGridTile> val_1 = this.SetTimedObject(count:  items, outerEdge:  true, type:  3);
            this.<CurrentLevel>k__BackingField.collectionItems = this.<CurrentLevel>k__BackingField;
        }
        private System.Collections.Generic.List<SLC.MatchyPics.MPIGridTile> SetTimedObject(int count, bool outerEdge, SLC.MatchyPics.MPITileData.Type type)
        {
            var val_10;
            System.Collections.Generic.HashSet<System.Int32> val_11;
            int val_12;
            System.Collections.Generic.List<ZooTile> val_13;
            var val_14;
            System.Predicate<ZooTile> val_15;
            var val_16;
            var val_17;
            var val_18;
            val_10 = type;
            val_11 = 35633385;
            val_12 = count;
            if(val_12 == 0)
            {
                goto label_1;
            }
            
            if(outerEdge == false)
            {
                goto label_2;
            }
            
            System.Collections.Generic.List<SLC.MatchyPics.MPIGridTile> val_1 = this.GetOuterEdgeTiles();
            val_13 = this;
            goto label_3;
            label_1:
            val_13 = 0;
            return;
            label_2:
            val_13 = null;
            val_13 = new System.Collections.Generic.List<ZooTile>(collection:  this.tiles);
            label_3:
            object val_3 = null;
            val_14 = val_3;
            val_3 = new System.Object();
            typeof(MPIBoardController.<>c__DisplayClass58_0).__il2cppRuntimeField_C = this;
            if((val_10 - 1) < 2)
            {
                goto label_6;
            }
            
            if(val_10 != 3)
            {
                goto label_7;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SLC.MatchyPics.MPICollection val_6 = GetCollection(imageSetIndex:  this.<CurrentLevel>k__BackingField.imageSetIndex);
            val_11 = null;
            val_11 = new System.Collections.Generic.HashSet<System.Int32>(collection:  public static SLC.MatchyPics.MPICollectionsManager MonoSingleton<SLC.MatchyPics.MPICollectionsManager>::get_Instance().__il2cppRuntimeField_10);
            typeof(MPIBoardController.<>c__DisplayClass58_0).__il2cppRuntimeField_8 = val_11;
            val_15 = null;
            val_16 = val_14;
            val_17 = System.Boolean MPIBoardController.<>c__DisplayClass58_0::<SetTimedObject>b__0(SLC.MatchyPics.MPIGridTile i);
            val_18 = 1152921513949706304;
            goto label_13;
            label_6:
            val_15 = null;
            val_16 = this;
            val_17 = System.Boolean SLC.MatchyPics.MPIBoardController::<SetTimedObject>b__58_1(SLC.MatchyPics.MPIGridTile i);
            val_18 = 1152921513949706304;
            label_13:
            val_15 = new System.Predicate<ZooTile>(object:  752953136, method:  new IntPtr(752925760));
            System.Collections.Generic.List<T> val_9 = FindAll(match:  8040448);
            val_13 = val_13;
            label_7:
            val_14 = 1152921504619999232;
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            val_11 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            typeof(System.Object[]).__il2cppRuntimeField_14 = val_11;
            typeof(System.Object[]).__il2cppRuntimeField_18 = null;
            UnityEngine.Debug.LogErrorFormat(format:  752927808, args:  472754880);
            val_10 = 0;
            PluginExtension.Shuffle<UnityEngine.Sprite>(list:  80883712, seed:  new System.Nullable<System.Int32>() {HasValue = false});
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_11 = mem[List<T>.__il2cppRuntimeField_10 + 44];
            val_11 = List<T>.__il2cppRuntimeField_10 + 44;
            val_10 = val_10 + 1;
            mem2[0] = ;
        }
        private bool HasSameAdjacentTiles(SLC.MatchyPics.MPIGridTile tile)
        {
            int val_2;
            int val_4;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            UnityEngine.Vector2Int val_1 = Location;
            val_11 = 0;
            val_12 = mem[1152921513949867412];
            int val_3 = val_12 + 16;
            goto label_2;
            label_21:
            UnityEngine.Vector2Int val_5 = UnityEngine.Vector2Int.op_Addition(a:  new UnityEngine.Vector2Int() {m_X = 753073672, m_Y = val_2}, b:  new UnityEngine.Vector2Int() {m_X = val_4, m_Y = val_3});
            val_13 = val_2.x;
            val_14 = val_2.y;
            val_15 = mem[mem[1152921513949867364] + 8];
            val_15 = mem[1152921513949867364] + 8;
            if(val_15 <= val_13)
            {
                    val_15 = mem[mem[1152921513949867364] + 8];
                val_15 = mem[1152921513949867364] + 8;
            }
            
            val_15 = mem[1152921513949867364] + (val_15 << 2);
            if(((mem[1152921513949867364] + (mem[1152921513949867364] + 8) << 2) + 16) == 1)
            {
                goto label_9;
            }
            
            val_14 = mem[1152921513949867352];
            val_13 = val_2.x;
            int val_9 = val_2.y;
            val_16 = mem[mem[1152921513949867364] + 8];
            val_16 = mem[1152921513949867364] + 8;
            if(val_16 <= val_13)
            {
                    val_16 = mem[mem[1152921513949867364] + 8];
                val_16 = mem[1152921513949867364] + 8;
            }
            
            val_16 = mem[1152921513949867364] + (val_16 << 2);
            if((mem[1152921513949867352] + 12) <= ((mem[1152921513949867364] + (mem[1152921513949867364] + 8) << 2) + 16))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_11 = mem[1152921513949867352] + 8;
            val_12 = val_12;
            val_11 = val_11 + (((mem[1152921513949867364] + (mem[1152921513949867364] + 8) << 2) + 16) << 2);
            if(((mem[1152921513949867352] + 8 + ((mem[1152921513949867364] + (mem[1152921513949867364] + 8) << 2) + 16) << 2) + 16 + 44 + 12) == (tile.<tileData>k__BackingField.SpriteIndex))
            {
                goto label_19;
            }
            
            label_9:
            var val_12 = val_3;
            val_11 = 1;
            val_12 = val_12 + 8;
            label_2:
            if(val_11 < (mem[1152921513949867412] + 12))
            {
                goto label_21;
            }
            
            val_17 = 0;
            return (bool)val_17;
            label_19:
            val_2 = val_2;
            val_4 = val_4;
            string val_10 = 753061616 + 155537408;
            UnityEngine.Debug.Log(message:  753061616);
            val_17 = 1;
            return (bool)val_17;
        }
        private System.Collections.Generic.List<SLC.MatchyPics.MPIGridTile> GetOuterEdgeTiles()
        {
            int val_6;
            System.Int32[,] val_7;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            val_6 = this.<Height>k__BackingField;
            if((val_6 - 2) < 3)
            {
                    return;
            }
            
            var val_10 = 2;
            do
            {
                if(((this.<Width>k__BackingField) - 2) >= 3)
            {
                    var val_9 = 2;
                do
            {
                val_7 = this.tilesIndex;
                int val_6 = val_7[this.<Width>k__BackingField];
                if(val_6 >= 0)
            {
                    int val_7 = this.tilesIndex[val_6];
                if(this.tilesIndex[val_6] <= val_7)
            {
                    var val_8 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_8 = val_8 + (val_7 << 2);
                val_7 = mem[(0 + (this.tilesIndex[this.tilesIndex[this.<Width>k__BackingField][0]][0]) << 2) + 16];
                val_7 = (0 + (this.tilesIndex[this.tilesIndex[this.<Width>k__BackingField][0]][0]) << 2) + 16;
                Add(item:  val_7);
            }
            
                val_9 = val_9 + 1;
            }
            while(val_9 < ((this.<Width>k__BackingField) - 2));
            
                val_6 = this.<Height>k__BackingField;
            }
            
                val_10 = val_10 + 1;
            }
            while(val_10 < (val_6 - 2));
        
        }
        private bool CheckValidCallback(System.Delegate wordRegionEvent, System.Delegate callback)
        {
            if(wordRegionEvent == 0)
            {
                    return true;
            }
            
            35633388 = wordRegionEvent;
            if(wordRegionEvent.invoke_impl == new IntPtr(0))
            {
                    return true;
            }
            
            System.Collections.Generic.List<TSource> val_1 = System.Linq.Enumerable.ToList<System.Object>(source:  wordRegionEvent);
            bool val_2 = wordRegionEvent.Contains(item:  callback);
            val_2 = val_2 ^ 1;
            return (bool)val_2;
        }
        public string TilesToString()
        {
            int val_4;
            string val_6;
            var val_7;
            val_4 = System.String.alignConst;
            if((this.<Height>k__BackingField) < 1)
            {
                    return;
            }
            
            var val_6 = 0;
            do
            {
                if((this.<Width>k__BackingField) >= 1)
            {
                    var val_5 = 0;
                do
            {
                int val_4 = this.tilesIndex[this.<Width>k__BackingField];
                string val_1 = System.String.Format(format:  753614816, arg0:  13152256);
                string val_2 = val_4 + 753614816;
                val_6 = val_4;
                val_5 = val_5 + 1;
            }
            while(val_5 < (this.<Width>k__BackingField));
            
            }
            
                string val_3 = val_6 + 709645840;
                val_7 = val_6;
                val_6 = val_6 + 1;
            }
            while(val_6 < (this.<Height>k__BackingField));
        
        }
        public bool SetBoardMask(UnityEngine.RectTransform transform, SLC.MatchyPics.MPIFTUXWindow.Type type)
        {
            var val_8;
            float val_11;
            var val_17;
            System.Collections.Generic.List<SLC.MatchyPics.MPIGridTile> val_27;
            UnityEngine.Object val_28;
            var val_29;
            float val_30;
            float val_31;
            float val_32;
            val_27 = type;
            object val_1 = null;
            val_28 = val_1;
            val_1 = new System.Object();
            if(val_27 != 0)
            {
                    val_29 = 1;
                if((val_27 - 1) >= 2)
            {
                    return (bool)val_29;
            }
            
                if(val_27 == 1)
            {
                    3 = 2;
            }
            
                typeof(MPIBoardController.<>c__DisplayClass64_0).__il2cppRuntimeField_8 = 2;
                val_27 = this.tiles;
                System.Predicate<ZooTile> val_3 = new System.Predicate<ZooTile>(object:  437272576, method:  new IntPtr(753776048));
                SLC.MatchyPics.MPIGridTile val_4 = val_27.Find(match:  8040448);
                val_28 = val_27;
                val_29 = 0;
                if(val_28 == 0)
            {
                    return (bool)val_29;
            }
            
                UnityEngine.Transform val_6 = this.gameBoardRoot.transform;
                UnityEngine.Vector3 val_7 = localScale;
                val_27 = 0;
                UnityEngine.Transform val_9 = this.gameBoardRoot.transform;
                UnityEngine.Vector3 val_10 = localScale;
                float val_27 = val_11;
                UnityEngine.Vector3 val_12 = this.tileSize * val_8;
                val_27 = S18 * val_27;
                UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  val_27, y:  val_10.y);
                transform.sizeDelta = new UnityEngine.Vector2() {x = val_13.x, y = val_13.y};
                UnityEngine.Transform val_14 = this.gameBoardRoot.transform;
                transform.parent = this.gameBoardRoot;
                UnityEngine.Transform val_15 = val_28.transform;
                UnityEngine.Vector3 val_16 = localPosition;
                UnityEngine.Transform val_18 = val_28.transform;
                UnityEngine.Vector3 val_19 = localPosition;
                UnityEngine.Vector2 val_21 = new UnityEngine.Vector2(x:  val_19.x, y:  val_19.y);
                UnityEngine.Vector3 val_22 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 6.769264E-12f, y = val_21.x});
                if(transform != 0)
            {
                goto label_22;
            }
            
            }
            else
            {
                    float val_28 = (float)this.<Width>k__BackingField;
                float val_29 = (float)this.<Height>k__BackingField;
                val_17 = 0;
                val_28 = val_28 + (-1.6f);
                val_29 = val_29 + (-1.6f);
                val_28 = this.tileSize * val_28;
                UnityEngine.Vector2 val_23 = new UnityEngine.Vector2(x:  val_28, y:  null);
                transform.sizeDelta = new UnityEngine.Vector2() {x = val_23.x, y = val_23.y};
                UnityEngine.Transform val_24 = this.gameBoardRoot.transform;
                UnityEngine.Vector3 val_25 = localScale;
                transform.localScale = new UnityEngine.Vector3() {y = val_13.x, z = val_13.y};
                val_11 = 0;
                UnityEngine.Vector3 val_26 = new UnityEngine.Vector3(x:  val_25.x, y:  val_25.y);
            }
            
            label_22:
            transform.localPosition = new UnityEngine.Vector3() {x = val_30, y = val_31, z = val_32};
            val_29 = 1;
            return (bool)val_29;
        }
        public UnityEngine.Vector3 GetWordPosition(SLC.MatchyPics.MPIGridTile tile)
        {
            float val_3;
            float val_4;
            float val_7;
            UnityEngine.Transform val_1 = R2.transform;
            val_7 = 0;
            UnityEngine.Vector3 val_2 = localPosition;
            if(tile.hintAnimation != 0)
            {
                    if(null != null)
            {
                    val_7 = 0;
            }
            else
            {
                    val_7 = tile.hintAnimation;
            }
            
            }
            
            UnityEngine.Vector3 val_6 = this.TransformPoint(position:  new UnityEngine.Vector3() {x = val_7, y = val_3, z = val_4});
            return new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        }
        public void Hack_GrantMatch()
        {
            if(this.shuffleUpdate == true)
            {
                    return;
            }
            
            if(this.needsMovementUpdate == false)
            {
                    this.needsMovementUpdate = this.isLevelCompleted;
                goto label_2;
            }
            
            return;
            label_2:
            int val_5 = this.tilesIndex[this.needsMovementUpdate.x.y];
            int val_6 = this.tilesIndex[this.tilesIndex[this.needsMovementUpdate.x.y].x.y];
            if(this.tilesIndex[this.tilesIndex[this.needsMovementUpdate.x.y].x.y] <= val_5)
            {
                    var val_7 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + (val_5 << 2);
            if(val_7 <= val_6)
            {
                    var val_8 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = val_8 + (val_6 << 2);
            this.ValidatePairPath(tile1:  (0 + (this.tilesIndex[val_2][0]) << 2) + 16, tile2:  (0 + (this.tilesIndex[val_4][0]) << 2) + 16);
        }
        private System.Collections.IEnumerator LoadTiles()
        {
            object val_1 = new System.Object();
            typeof(MPIBoardController.<LoadTiles>d__67).__il2cppRuntimeField_8 = 0;
            typeof(MPIBoardController.<LoadTiles>d__67).__il2cppRuntimeField_10 = this;
        }
        private System.Collections.IEnumerator StartRemovingTiles(SLC.MatchyPics.MPIGridTile tileA, SLC.MatchyPics.MPIGridTile tileB)
        {
            typeof(MPIBoardController.<StartRemovingTiles>d__68).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(MPIBoardController.<StartRemovingTiles>d__68).__il2cppRuntimeField_10 = this;
                typeof(MPIBoardController.<StartRemovingTiles>d__68).__il2cppRuntimeField_14 = tileA;
            }
            else
            {
                    mem[16] = this;
                mem[20] = tileA;
            }
            
            typeof(MPIBoardController.<StartRemovingTiles>d__68).__il2cppRuntimeField_18 = tileB;
        }
        private System.Collections.Generic.List<UnityEngine.Vector3> GetPathPositions(System.Collections.Generic.List<UnityEngine.Vector2Int> path)
        {
            SLC.MatchyPics.MPIBoardController val_8;
            UnityEngine.Vector3 val_9;
            float val_12;
            val_8 = this;
            val_9 = path;
            System.Collections.Generic.List<UnityEngine.Vector3> val_1 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            List.Enumerator<T> val_2 = GetEnumerator();
            goto label_2;
            label_13:
            int val_4 = 0.x;
            int val_5 = 0.y;
            val_5 = val_5 + (val_5 << 1);
            val_9 = this.nodesPositions[val_5 << 2];
            UnityEngine.Vector3 val_9 = this.nodesPositions[val_5 << 2];
            if(this.gameBoardRoot != 0)
            {
                    if(null == null)
            {
                goto label_7;
            }
            
            }
            
            if(this.gameBoardRoot == 0)
            {
                goto label_8;
            }
            
            label_7:
            if(null == null)
            {
                goto label_9;
            }
            
            val_12 = 0;
            goto label_11;
            label_8:
            val_12 = 0;
            goto label_11;
            label_9:
            val_12 = this.gameBoardRoot;
            label_11:
            UnityEngine.Vector3 val_6 = TransformPoint(position:  new UnityEngine.Vector3() {x = val_12, y = val_9, z = this.nodesPositions[val_5 << 2]});
            Add(item:  new UnityEngine.Vector3());
            val_8 = val_8;
            label_2:
            if(0.MoveNext() == true)
            {
                goto label_13;
            }
            
            0.Dispose();
        }
        private System.Collections.IEnumerator SetTilesPositions(bool shuffle, bool setActive = True)
        {
            typeof(MPIBoardController.<SetTilesPositions>d__70).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(MPIBoardController.<SetTilesPositions>d__70).__il2cppRuntimeField_10 = shuffle;
                typeof(MPIBoardController.<SetTilesPositions>d__70).__il2cppRuntimeField_14 = this;
            }
            else
            {
                    mem[20] = this;
                mem[16] = shuffle;
            }
            
            typeof(MPIBoardController.<SetTilesPositions>d__70).__il2cppRuntimeField_18 = setActive;
        }
        private System.Collections.IEnumerator InitialBoardAnimation()
        {
            object val_1 = new System.Object();
            typeof(MPIBoardController.<InitialBoardAnimation>d__73).__il2cppRuntimeField_8 = 0;
            typeof(MPIBoardController.<InitialBoardAnimation>d__73).__il2cppRuntimeField_10 = this;
        }
        private System.Collections.IEnumerator MoveTiles()
        {
            object val_1 = new System.Object();
            typeof(MPIBoardController.<MoveTiles>d__74).__il2cppRuntimeField_8 = 0;
            typeof(MPIBoardController.<MoveTiles>d__74).__il2cppRuntimeField_10 = this;
        }
        private void ProgressiveMatchSound()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  1918153760, randomIndex:  true, vol:  null);
        }
        public MPIBoardController()
        {
            var val_2;
            var val_5;
            var val_8;
            UnityEngine.Vector2Int val_1 = UnityEngine.Vector2Int.up;
            typeof(UnityEngine.Vector2Int[]).__il2cppRuntimeField_10 = val_2;
            UnityEngine.Vector2Int val_4 = UnityEngine.Vector2Int.down;
            typeof(UnityEngine.Vector2Int[]).__il2cppRuntimeField_18 = val_5;
            UnityEngine.Vector2Int val_7 = UnityEngine.Vector2Int.left;
            typeof(UnityEngine.Vector2Int[]).__il2cppRuntimeField_20 = val_8;
            UnityEngine.Vector2Int val_10 = UnityEngine.Vector2Int.right;
            typeof(UnityEngine.Vector2Int[]).__il2cppRuntimeField_28 = ???;
            this.adjacentPos = null;
        }
        private bool <SetTimedObject>b__58_1(SLC.MatchyPics.MPIGridTile i)
        {
            if((i.<tileData>k__BackingField.type) != 0)
            {
                    return false;
            }
            
            bool val_1 = this.HasSameAdjacentTiles(tile:  i);
            val_1 = val_1 ^ 1;
            return (bool)val_1;
        }
    
    }

}
