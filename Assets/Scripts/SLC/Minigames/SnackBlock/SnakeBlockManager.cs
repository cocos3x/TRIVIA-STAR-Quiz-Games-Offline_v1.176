using UnityEngine;

namespace SLC.Minigames.SnackBlock
{
    public class SnakeBlockManager : MonoSingleton<SLC.Minigames.SnackBlock.SnakeBlockManager>
    {
        // Fields
        private System.Collections.Generic.List<string[]> parsedWordData;
        private System.Collections.Generic.List<SLC.Minigames.SnackBlock.SnakeGridSpaceType[]> myLevelData;
        private System.Collections.Generic.Dictionary<int, int> currentWordRowIndexDict;
        private const string MINIGAME_NAME = "SnakeBlock";
        private bool <inMinigameFramework>k__BackingField;
        private int _snakePlayerLevel;
        private int _snakeObjectivesCount;
        private int _snakeObjectivesReq;
        private bool isPaused;
        private SLC.Minigames.SnackBlock.SnakeBlockLevelStreamer streamer;
        private SLC.Minigames.SnackBlock.SnakeBlockUIController uiCont;
        private float curLevelSpeed;
        private SLC.Minigames.SnackBlock.SnakeBlockController mySnake;
        private RandomSet randomSet;
        public bool hasFTUXCollided;
        public UnityEngine.GameObject avoidText;
        
        // Properties
        public System.Collections.Generic.List<SLC.Minigames.SnackBlock.SnakeGridSpaceType[]> LevelData { get; }
        public bool inMinigameFramework { get; set; }
        public bool IsPaused { get; }
        public SLC.Minigames.SnackBlock.SnakeBlockUIController GetUIController { get; }
        public float getSpeedForLevel { get; }
        
        // Methods
        public System.Collections.Generic.List<SLC.Minigames.SnackBlock.SnakeGridSpaceType[]> get_LevelData()
        {
        
        }
        public bool get_inMinigameFramework()
        {
            return (bool)this.<inMinigameFramework>k__BackingField;
        }
        private void set_inMinigameFramework(bool value)
        {
            this.<inMinigameFramework>k__BackingField = value;
        }
        public bool get_IsPaused()
        {
            return (bool)this.isPaused;
        }
        public SLC.Minigames.SnackBlock.SnakeBlockUIController get_GetUIController()
        {
        
        }
        public float get_getSpeedForLevel()
        {
            float val_2;
            if((this.<inMinigameFramework>k__BackingField) != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_2 = (float)public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_60;
            }
            else
            {
                    val_2 = 1f;
            }
            
            float val_2 = 0.425f;
            val_2 = 1065327882 * val_2;
            return (float)val_2;
        }
        private void OnDestroy()
        {
            UnityEngine.Time.fixedDeltaTime = null;
        }
        private void Start()
        {
            var val_7;
            twelvegigs.sweepstakes.Distribution val_11;
            SLC.Minigames.SnackBlock.SnakeBlockManager val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            SLC.Minigames.SnackBlock.SnakeBlockManager val_40;
            var val_41;
            SLC.Minigames.SnackBlock.SnakeBlockManager val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            var val_47;
            var val_48;
            val_35 = this;
            UnityEngine.Time.fixedDeltaTime = null;
            object val_1 = UnityEngine.Resources.Load<System.Object>(path:  1029266256);
            string val_2 = text;
            object val_3 = MiniJSON.Json.Deserialize(json:  1029266256);
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.parsedWordData = null;
            if(("minigames/snakeblock/word_data") != 0)
            {
                    if(null == null)
            {
                goto label_72;
            }
            
            }
            
            if(("minigames/snakeblock/word_data") != 0)
            {
                    label_72:
            }
            
            val_36 = 0;
            List.Enumerator<T> val_5 = GetEnumerator();
            var val_35 = 0;
            val_37 = 1152921510382894416;
            label_24:
            if(MoveNext() == false)
            {
                goto label_8;
            }
            
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_8 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            if(val_7 != 0)
            {
                    val_38 = null;
            }
            
            if(val_7 != 0)
            {
                    val_38 = null;
                val_39 = 0;
                val_40 = val_35;
                if(((val_7 + 100 + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_38)
            {
                    val_7 = 0;
            }
            
                val_39 = val_7;
            }
            else
            {
                    val_39 = 0;
            }
            
            List.Enumerator<T> val_9 = GetEnumerator();
            label_18:
            if(MoveNext() == false)
            {
                goto label_15;
            }
            
            Add(item:  val_11);
            goto label_18;
            label_15:
            val_35 = val_35 + 1;
            mem2[0] = 125;
            Dispose();
            if(val_35 != 1)
            {
                    if(val_35 > 1)
            {
                    0 = 1;
            }
            
                var val_36 = 1029295944 + ((0 + 1)) << 2;
                val_36 = val_36 - 125;
                val_36 = val_36 >> 5;
                val_36 = 1 & val_36;
                val_35 = val_35 - val_36;
            }
            
            T[] val_12 = ToArray();
            this.parsedWordData.Add(item:  80883712);
            goto label_24;
            label_8:
            Dispose();
            this.randomSet.addIntRange(lowest:  0, highest:  this.parsedWordData - 1);
            this.<inMinigameFramework>k__BackingField = true;
            twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-1745297776) != 0)
            {
                goto label_35;
            }
            
            val_41 = "Snake: No Minigame Manager";
            goto label_38;
            label_35:
            val_42 = val_35;
            if((this.<inMinigameFramework>k__BackingField) == false)
            {
                goto label_69;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_17 = CurrentMinigameId;
            if((Equals(value:  907413856)) == false)
            {
                goto label_44;
            }
            
            val_42 = val_35;
            if((this.<inMinigameFramework>k__BackingField) == false)
            {
                goto label_69;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            mem[1152921514226089644] = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_60;
            twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_21 = new System.Action(object:  1029308048, method:  new IntPtr(1029278800));
            System.Delegate val_22 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68, b:  7454720);
            val_43 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68;
            if(val_43 != 0)
            {
                    if(val_43 == null)
            {
                goto label_52;
            }
            
            }
            
            val_43 = 0;
            label_52:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_68 = val_43;
            twelvegigs.Autopilot.AutopilotManager val_23 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_24 = new System.Action(object:  1029308048, method:  new IntPtr(1029279824));
            System.Delegate val_25 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64, b:  7454720);
            val_44 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64;
            if(val_44 != 0)
            {
                    if(val_44 == null)
            {
                goto label_56;
            }
            
            }
            
            val_44 = 0;
            label_56:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_64 = val_44;
            twelvegigs.Autopilot.AutopilotManager val_26 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_27 = new System.Action(object:  1029308048, method:  new IntPtr(1029280848));
            System.Delegate val_28 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_6C, b:  7454720);
            val_45 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_6C;
            if(val_45 != 0)
            {
                    if(val_45 == null)
            {
                goto label_60;
            }
            
            }
            
            val_45 = 0;
            label_60:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_6C = val_45;
            twelvegigs.Autopilot.AutopilotManager val_29 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_37 = 1152921504614248448;
            System.Action<System.Boolean> val_30 = new System.Action<System.Boolean>(object:  1029308048, method:  new IntPtr(1029281872));
            System.Delegate val_31 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_78, b:  7401472);
            val_46 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_78;
            if(val_46 != 0)
            {
                    if(val_46 == null)
            {
                goto label_64;
            }
            
            }
            
            val_46 = 0;
            label_64:
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_78 = val_46;
            twelvegigs.Autopilot.AutopilotManager val_32 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_47 = 1152921504614248448;
            System.Action<twelvegigs.storage.JsonDictionary> val_33 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  1029308048, method:  new IntPtr(1029282896));
            System.Delegate val_34 = System.Delegate.Combine(a:  public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_74, b:  7401472);
            val_48 = public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_74;
            if(val_48 != 0)
            {
                    if(val_48 == null)
            {
                goto label_68;
            }
            
            }
            
            val_48 = 0;
            label_68:
            val_42 = val_35;
            public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_74 = val_48;
            goto label_69;
            label_44:
            val_41 = "Snake: Minigame Mismatch";
            label_38:
            val_42 = val_35;
            UnityEngine.Debug.LogError(message:  1029283920, context:  1029308048);
            mem[1152921514226089640] = 0;
            label_69:
            this.StartGame(reset:  true);
        }
        private void Instance_OnInjectTracking(System.Collections.Generic.Dictionary<string, object> obj)
        {
            obj.Add(key:  -487709536, value:  13152256);
        }
        private void TogglePopupWindow(bool showing)
        {
            bool val_3 = showing;
            this.uiCont.HideUIForPopup(showingPopup:  val_3);
            UnityEngine.Camera val_1 = UnityEngine.Camera.main;
            val_3 = 0 - val_3 ^ 1;
            0.cullingMask = val_3;
        }
        private void AddToRandomWordRowIndexes(int row)
        {
            if(this.randomSet.remainingCount() == 0)
            {
                    this.randomSet.reset();
            }
            
            this.currentWordRowIndexDict.Add(key:  row, value:  this.randomSet.roll(unweighted:  false));
        }
        public string GetWordForRowColumnIndex(int row, int column)
        {
            int val_1 = this.currentWordRowIndexDict.Item[row];
            if(val_1 <= val_1)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + (val_1 << 2);
            var val_2 = ((0 + (val_1) << 2) + 16) + (column << 2);
        }
        private void OnRankUpContinue()
        {
            this.StartGame(reset:  false);
        }
        public void OnContinue()
        {
            this.mySnake.enabled = true;
            System.Collections.IEnumerator val_1 = this.mySnake.Continue();
            UnityEngine.Coroutine val_2 = this.mySnake.StartCoroutine(routine:  this.mySnake);
            this.isPaused = false;
        }
        private void OnRestartFromCheckpoint()
        {
            this.StartGame(reset:  true);
        }
        private void StartGame(bool reset = True)
        {
            bool val_5;
            this.GenerateLevelData();
            if(this.myLevelData != 0)
            {
                    this.streamer.Spawnlevel();
            }
            
            this.mySnake.Init(reset:  reset);
            UnityEngine.GameObject val_1 = this.streamer.getSnakeLevel;
            val_5 = 0;
            if(this.streamer == 0)
            {
                    UnityEngine.Debug.LogError(message:  1030298832);
                return;
            }
            
            if((this.<inMinigameFramework>k__BackingField) != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                if((this.<inMinigameFramework>k__BackingField) != false)
            {
                    this.uiCont.ShowFTUX();
                val_5 = true;
            }
            
            }
            
            this.isPaused = val_5;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UpdateUI();
        }
        private void GenerateLevelData()
        {
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            val_17 = this;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.myLevelData = null;
            System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_2 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
            mem[1152921514227242180] = null;
            bool val_17 = this.<inMinigameFramework>k__BackingField;
            if(val_17 != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                int val_4 = GetLevelsToNextCheckpoint;
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                val_18 = val_4 & (~(val_4 >> 31));
                val_19 = (public static SLC.Minigames.MinigameManager MonoSingleton<SLC.Minigames.MinigameManager>::get_Instance().__il2cppRuntimeField_60) >> 5;
            }
            else
            {
                    val_19 = 0;
                val_18 = 5;
            }
            
            var val_16 = 3;
            do
            {
                val_17.AppendBlankRow(level: ref  System.Collections.Generic.List<SLC.Minigames.SnackBlock.SnakeGridSpaceType[]> val_6 = 80883712);
                val_16 = val_16 - 1;
            }
            while(val_17 == true);
            
            if(val_18 != 0)
            {
                    var val_18 = 0;
                do
            {
                val_17 = val_17 >> 5;
                this.AppendWordRowSection(level: ref  System.Collections.Generic.List<SLC.Minigames.SnackBlock.SnakeGridSpaceType[]> val_8 = 80883712, ftux:  val_19 & val_17);
                val_18 = val_18 + 1;
            }
            while(val_18 != val_18);
            
            }
            
            val_20 = this.myLevelData;
            this.AppendFinshLineRow(level: ref  System.Collections.Generic.List<SLC.Minigames.SnackBlock.SnakeGridSpaceType[]> val_9 = 80883712);
            val_21 = 0;
            null = new System.Text.StringBuilder();
            goto label_13;
            label_29:
            val_22 = 0;
            goto label_14;
            label_26:
            if((mem[null + 12]) <= val_21)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_19 = mem[null + 8];
            val_19 = val_19 + 0;
            val_17 = mem[(mem[null + 8] + 0) + 16];
            val_17 = (mem[null + 8] + 0) + 16;
            var val_11 = val_17 + 16;
            val_19 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem2[0] = ;
            string val_12 = 454152192 + 1488600160;
            System.Text.StringBuilder val_13 = Append(value:  454152192);
            val_20 = this.myLevelData;
            val_22 = 1;
            label_14:
            if((mem[null + 12]) <= val_21)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_20 = mem[null + 8];
            val_20 = val_20 + 0;
            if(val_22 < ((mem[null + 8] + 0) + 16 + 12))
            {
                goto label_26;
            }
            
            string val_14 = System.Environment.NewLine;
            System.Text.StringBuilder val_15 = Append(value:  null);
            val_21 = 1;
            label_13:
            if(val_21 < (mem[val_20 + 12]))
            {
                goto label_29;
            }
        
        }
        private void AppendWordRowSection(ref System.Collections.Generic.List<SLC.Minigames.SnackBlock.SnakeGridSpaceType[]> level, bool ftux)
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            int val_2 = UnityEngine.Random.Range(min:  7, max:  15);
            if(val_2 >= 1)
            {
                    var val_19 = val_2;
                do
            {
                Add(item:  1094074352);
                val_19 = val_19 - 1;
            }
            while(null != 0);
            
            }
            
            float val_20 = (float)val_2 << 2;
            val_20 = val_20 * 0.2f;
            int val_4 = UnityEngine.Mathf.FloorToInt(f:  val_20);
            float val_21 = (float)val_2;
            val_21 = val_21 * 0.2f;
            float val_22 = (float)UnityEngine.Mathf.FloorToInt(f:  val_21);
            val_22 = val_22 * 1.6f;
            int val_23 = UnityEngine.Mathf.FloorToInt(f:  val_22);
            RandomSet val_7 = new RandomSet();
            addIntRange(lowest:  1, highest:  val_2 - 1);
            System.Collections.Generic.List<System.Int32> val_9 = new System.Collections.Generic.List<System.Int32>();
            if(val_23 >= 1)
            {
                    do
            {
                Add(item:  roll(unweighted:  false));
                val_23 = val_23 - 1;
            }
            while(null != 0);
            
            }
            
            int val_11 = UnityEngine.Random.Range(min:  0, max:  3);
            System.Collections.Generic.List<System.Int32> val_12 = new System.Collections.Generic.List<System.Int32>();
            label_14:
            if(0 != 0)
            {
                    System.Collections.Generic.List<T>.__il2cppRuntimeField_namespaze = 1152921505700909039;
            }
            
            goto label_14;
        }
        private void AppendFtuxMessageRow(ref System.Collections.Generic.List<SLC.Minigames.SnackBlock.SnakeGridSpaceType[]> level)
        {
            typeof(SLC.Minigames.SnackBlock.SnakeGridSpaceType[]).__il2cppRuntimeField_10 = 0;
            typeof(SLC.Minigames.SnackBlock.SnakeGridSpaceType[]).__il2cppRuntimeField_14 = 8;
            typeof(SLC.Minigames.SnackBlock.SnakeGridSpaceType[]).__il2cppRuntimeField_18 = 0;
            typeof(SLC.Minigames.SnackBlock.SnakeGridSpaceType[]).__il2cppRuntimeField_1C = 0;
            level.Add(item:  1094074352);
        }
        private void AppendWordRow(ref System.Collections.Generic.List<SLC.Minigames.SnackBlock.SnakeGridSpaceType[]> level, bool ftux)
        {
            var val_2 = 1152921505700921344 + ((UnityEngine.Random.Range(min:  0, max:  4)) << 2);
            if(ftux == true)
            {
                    3 = 7;
                2 = 6;
            }
            
            this.AddToRandomWordRowIndexes(row:  (mem[level + 12]) + this.myLevelData);
            level.Add(item:  1094074352);
        }
        private void AppendBlankRow(ref System.Collections.Generic.List<SLC.Minigames.SnackBlock.SnakeGridSpaceType[]> level)
        {
            var val_1 = 0;
            level.Add(item:  1094074352);
        }
        private void AppendFinshLineRow(ref System.Collections.Generic.List<SLC.Minigames.SnackBlock.SnakeGridSpaceType[]> level)
        {
            var val_1 = 0;
            level.Add(item:  1094074352);
        }
        private int AppendBlockerRow(ref System.Collections.Generic.List<SLC.Minigames.SnackBlock.SnakeGridSpaceType[]> level, int index)
        {
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            int val_1 = index - 1;
            if((mem[level + 12]) <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_7 = mem[level + 8];
            var val_8 = 0;
            val_7 = val_7 + (val_1 << 2);
            val_9 = mem[(mem[level + 8] + ((index - 1)) << 2) + 16];
            val_9 = (mem[level + 8] + ((index - 1)) << 2) + 16;
            var val_2 = val_9 + 16;
            label_6:
            if(val_8 >= ((mem[level + 8] + ((index - 1)) << 2) + 16 + 12))
            {
                goto label_4;
            }
            
            val_8 = val_8 + 1;
            if((((mem[level + 8] + ((index - 1)) << 2) + 16 + 16) + 0) == 0)
            {
                goto label_6;
            }
            
            val_10 = 4;
            goto label_7;
            label_24:
            if(((UnityEngine.Random.Range(min:  0, max:  5)) >= 1) && (((mem[level + 8] + ((index - 1)) << 2) + 16 + 16) != 0))
            {
                    if((mem[level + 12]) <= index)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_9 = mem[level + 8];
                val_9 = val_9 + (index << 2);
                mem2[0] = 1;
            }
            else
            {
                    if((mem[level + 12]) <= index)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_10 = mem[level + 8];
                val_10 = val_10 + (index << 2);
                val_11 = mem[(mem[level + 8] + (index) << 2) + 16];
                val_11 = (mem[level + 8] + (index) << 2) + 16;
                mem2[0] = 0;
            }
            
            val_10 = 5;
            label_7:
            if((mem[level + 12]) <= index)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_11 = mem[level + 8];
            val_12 = val_10 - 4;
            val_11 = val_11 + (index << 2);
            if(val_12 < ((mem[level + 8] + (index) << 2) + 16 + 12))
            {
                goto label_24;
            }
            
            val_13 = 1;
            goto label_25;
            label_4:
            val_10 = 0;
            val_12 = 0;
            goto label_26;
            label_37:
            val_9 = UnityEngine.Random.Range(min:  0, max:  6);
            if((mem[level + 12]) <= index)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_12 = mem[level + 8];
            val_12 = val_12 + (index << 2);
            val_11 = mem[(mem[level + 8] + (index) << 2) + 16];
            val_11 = (mem[level + 8] + (index) << 2) + 16;
            if(val_9 > 1)
            {
                    val_12 = 1;
                val_14 = val_11 + 0;
                val_15 = 1;
            }
            else
            {
                    val_14 = val_11 + 0;
                val_15 = 0;
            }
            
            mem2[0] = val_15;
            val_10 = 1;
            label_26:
            if((mem[level + 12]) <= index)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_13 = mem[level + 8];
            val_13 = val_13 + (index << 2);
            if(val_10 < ((mem[level + 8] + (index) << 2) + 16 + 12))
            {
                goto label_37;
            }
            
            val_13 = val_12;
            label_25:
            if(val_13 != 4)
            {
                    return (int)val_13;
            }
            
            val_9 = val_13;
            if((mem[level + 12]) <= index)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_14 = mem[level + 8];
            val_14 = val_14 + (index << 2);
            val_10 = mem[(mem[level + 8] + (index) << 2) + 16];
            val_10 = (mem[level + 8] + (index) << 2) + 16;
            var val_6 = val_10 + ((UnityEngine.Random.Range(min:  0, max:  4)) << 2);
            mem2[0] = 0;
            val_13 = val_9;
            return (int)val_13;
        }
        private void AppendFoodRow(ref System.Collections.Generic.List<SLC.Minigames.SnackBlock.SnakeGridSpaceType[]> level, System.Collections.Generic.List<int> validRows, int foods)
        {
            if(foods < 1)
            {
                    return;
            }
            
            var val_8 = 0;
            label_12:
            if(level == 0)
            {
                goto label_3;
            }
            
            int val_1 = UnityEngine.Random.Range(min:  0, max:  1031343312);
            if(val_1 <= val_1)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + (val_1 << 2);
            bool val_2 = validRows.Remove(item:  (0 + (val_1) << 2) + 16);
            if((mem[level + 12]) <= ((0 + (val_1) << 2) + 16))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_6 = mem[level + 8];
            val_6 = val_6 + (((0 + (val_1) << 2) + 16) << 2);
            if((mem[level + 12]) <= ((0 + (val_1) << 2) + 16))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_7 = mem[level + 8];
            val_7 = val_7 + (((0 + (val_1) << 2) + 16) << 2);
            val_8 = val_8 + 1;
            var val_4 = ((mem[level + 8] + ((0 + (val_1) << 2) + 16) << 2) + 16) + ((UnityEngine.Random.Range(min:  0, max:  (mem[level + 8] + ((0 + (val_1) << 2) + 16) << 2) + 16 + 12)) << 2);
            mem2[0] = 4;
            if(val_8 < foods)
            {
                goto label_12;
            }
            
            return;
            label_3:
            UnityEngine.Debug.LogError(message:  1031287152);
        }
        public void HandleFailed()
        {
            this.isPaused = true;
            if((this.<inMinigameFramework>k__BackingField) != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                bool val_2 = HandleLevelFailed();
                return;
            }
            
            int val_3 = this._snakePlayerLevel;
            val_3 = val_3 - 1;
            this._snakePlayerLevel = val_3;
            this.StartGame(reset:  true);
        }
        public void HandleComplete()
        {
            if((this.<inMinigameFramework>k__BackingField) == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(HandleLevelComplete() != false)
            {
                    this.isPaused = true;
            }
            else
            {
                    System.Collections.IEnumerator val_3 = this.streamer.SpawnNext();
                UnityEngine.Coroutine val_4 = this.streamer.StartCoroutine(routine:  this.streamer);
            }
            
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UpdateUI();
        }
        public void HACK_InstantWin()
        {
            this.HandleComplete();
        }
        public void OnPauseInput()
        {
            bool val_2 = this.isPaused;
            val_2 = val_2 ^ 1;
            this.isPaused = val_2;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UpdateUI();
        }
        public void DisableAvoidText()
        {
            if(this.avoidText != 0)
            {
                    this.avoidText.SetActive(value:  false);
            }
            
            this.hasFTUXCollided = true;
        }
        public SnakeBlockManager()
        {
            this.curLevelSpeed = 0.1f;
            this._snakeObjectivesReq = 3;
            this.randomSet = new RandomSet();
        }
    
    }

}
