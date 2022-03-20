using UnityEngine;

namespace WordForest
{
    public class WFOMysteryChestUI : MonoSingleton<WordForest.WFOMysteryChestUI>
    {
        // Fields
        private UnityEngine.GameObject prefabMysteryChestTile;
        private UnityEngine.GameObject prefabMysteryChestDisplay;
        private DG.Tweening.Ease easeX;
        private System.Collections.Generic.List<UnityEngine.AnimationCurve> curveY;
        private WordForest.WFOMysteryChestManager mysteryChestManager;
        private WordRegion wordRegion;
        public System.Collections.Generic.List<WordForest.MysteryChest> mysteryChestTiles;
        private int currentAssociatedLevel;
        private static bool <isMysteryChestFlowActive>k__BackingField;
        
        // Properties
        public static bool isMysteryChestFlowActive { get; set; }
        public UnityEngine.GameObject PrefabMysteryChestDisplay { get; }
        private bool IsTileCurrentlyInPlay { get; }
        
        // Methods
        public static bool get_isMysteryChestFlowActive()
        {
            return (bool)WordForest.WFOMysteryChestUI.<isMysteryChestFlowActive>k__BackingField;
        }
        private static void set_isMysteryChestFlowActive(bool value)
        {
            WordForest.WFOMysteryChestUI.<isMysteryChestFlowActive>k__BackingField = value;
        }
        public UnityEngine.GameObject get_PrefabMysteryChestDisplay()
        {
        
        }
        public bool IsChestTileAvailable(int chestIndex)
        {
            System.Collections.Generic.List<WordForest.MysteryChest> val_1;
            var val_2;
            System.Collections.Generic.List<WordForest.MysteryChest> val_3;
            if(true <= chestIndex)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (chestIndex << 2);
            val_1 = mem[(0 + (chestIndex) << 2) + 16];
            val_1 = (0 + (chestIndex) << 2) + 16;
            val_2 = 0;
            if(((0 + (chestIndex) << 2) + 16 + 12) < 0)
            {
                    return true;
            }
            
            if(((0 + (chestIndex) << 2) + 16 + 12) <= chestIndex)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + (chestIndex << 2);
            val_3 = mem[(0 + (chestIndex) << 2) + 16 + 12];
            val_3 = (0 + (chestIndex) << 2) + 16 + 12;
            if(val_3 >= val_2)
            {
                    return true;
            }
            
            val_3 = this.mysteryChestTiles;
            if(val_2 <= chestIndex)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + (chestIndex << 2);
            val_1 = mem[(0 + (chestIndex) << 2) + 16];
            val_1 = (0 + (chestIndex) << 2) + 16;
            if(((0 + (chestIndex) << 2) + 16 + 16) < 0)
            {
                    return true;
            }
            
            if(((0 + (chestIndex) << 2) + 16 + 16) <= chestIndex)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + (chestIndex << 2);
            val_3 = this.wordRegion;
            val_1 = this.mysteryChestTiles;
            if(val_4 <= chestIndex)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + (chestIndex << 2);
            if(this.prefabMysteryChestTile <= ((0 + (chestIndex) << 2) + 16 + 12))
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + (((0 + (chestIndex) << 2) + 16 + 12) << 2);
            if(((0 + (chestIndex) << 2) + 16 + 16) < ((0 + ((0 + (chestIndex) << 2) + 16 + 12) << 2) + 16 + 20 + 12))
            {
                    val_2 = 1;
            }
            
            return true;
        }
        private bool get_IsTileCurrentlyInPlay()
        {
            var val_3;
            var val_3 = 0;
            label_3:
            if(val_3 >= true)
            {
                goto label_2;
            }
            
            val_3 = val_3 + 1;
            if((this.IsChestTileAvailable(chestIndex:  0)) == false)
            {
                goto label_3;
            }
            
            val_3 = 1;
            goto label_4;
            label_2:
            val_3 = 0;
            label_4:
            int val_2 = PlayingLevel.GetCurrentPlayerLevelNumber();
            val_2 = this.currentAssociatedLevel - val_2;
            val_2 = val_2 >> 5;
            val_2 = val_3 & val_2;
            return (bool)val_2;
        }
        private void Start()
        {
            var val_6;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.mysteryChestManager = public static WordForest.WFOMysteryChestManager MonoSingleton<WordForest.WFOMysteryChestManager>::get_Instance();
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  276678752, name:  -2100860512);
            WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            System.Action<Result> val_4 = new System.Action<Result>(object:  276678752, method:  new IntPtr(276653728));
            System.Delegate val_5 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
            val_6 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
            if(val_6 != 0)
            {
                    if(val_6 == null)
            {
                goto label_11;
            }
            
            }
            
            val_6 = 0;
            label_11:
            public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_6;
        }
        private void OnDestroy()
        {
            var val_4;
            WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            System.Action<Result> val_2 = new System.Action<Result>(object:  276790752, method:  new IntPtr(276653728));
            System.Delegate val_3 = System.Delegate.Remove(source:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, value:  7401472);
            val_4 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
            if(val_4 != 0)
            {
                    if(val_4 == null)
            {
                goto label_6;
            }
            
            }
            
            val_4 = 0;
            label_6:
            public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_4;
        }
        private void OnSceneLoaded(SceneType obj)
        {
            if(WordForest.WFOMysteryChestManager.IsFeatureUnlocked == false)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            35628505 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
            if(PlayingChallenge != false)
            {
                    return;
            }
            
            WordRegion val_4 = WordRegion.instance;
            if(0 == 0)
            {
                    return;
            }
            
            WordRegion val_6 = WordRegion.instance;
            this.wordRegion = 0;
            System.Action<System.Boolean, System.String, LineWord, Cell> val_7 = new System.Action<System.Boolean, System.String, LineWord, Cell>(object:  276923232, method:  new IntPtr(276882848));
            0.addOnPreprocessPlayerTurnAction(callback:  7614464);
            System.Action<twelvegigs.storage.JsonDictionary> val_8 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  276923232, method:  new IntPtr(276887968));
            this.wordRegion.addOnWordFoundAction(callback:  7401472);
            System.Action<UnityEngine.Vector3> val_9 = new System.Action<UnityEngine.Vector3>(object:  276923232, method:  new IntPtr(276893088));
            this.wordRegion.addOnHintUsedAtLocation(callback:  7401472);
            System.Action<twelvegigs.storage.JsonDictionary> val_10 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  276923232, method:  new IntPtr(276898208));
            this.wordRegion.addOnBeforeLevelCompleteAction(callback:  7401472);
        }
        private void OnBeforeLevelStart()
        {
            this.OnWordRegionLoaded();
        }
        private void ClearMysteryChest(int chestIndex)
        {
            if(true <= chestIndex)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + (chestIndex << 2);
            mem2[0] = 0;
            if(0 <= chestIndex)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + (chestIndex << 2);
            mem2[0] = 0;
            GameplayMode val_1 = PlayingLevel.CurrentGameplayMode;
            if(this.currentAssociatedLevel <= chestIndex)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + (chestIndex << 2);
            if(val_6 <= chestIndex)
            {
                    var val_7 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + (chestIndex << 2);
            if(val_7 <= chestIndex)
            {
                    var val_8 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = val_8 + (chestIndex << 2);
            if(((0 + (chestIndex) << 2) + 16 + 20) != 0)
            {
                    (0 + (chestIndex) << 2) + 16 + 20 = 1;
            }
            
            this.mysteryChestManager.SetCurrentChestLocData(mode:  0, gameLevel:  this.currentAssociatedLevel, lineWordIndex:  (0 + (chestIndex) << 2) + 16 + 12, cellIndex:  (0 + (chestIndex) << 2) + 16 + 16, collected:  true, chestIndex:  chestIndex);
            if(this.mysteryChestManager <= chestIndex)
            {
                    var val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = val_9 + (chestIndex << 2);
            UnityEngine.GameObject val_2 = (0 + (chestIndex) << 2) + 16 + 8.gameObject;
            UnityEngine.Object.Destroy(obj:  (0 + (chestIndex) << 2) + 16 + 8);
            if(((0 + (chestIndex) << 2) + 16 + 8) <= chestIndex)
            {
                    var val_10 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_10 = val_10 + (chestIndex << 2);
            mem2[0] = 0;
            NotificationCenter val_3 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  277196512, aName:  277172384);
        }
        private void CollectMysteryChestIcon(int chestIndex)
        {
            int val_8 = chestIndex;
            if(new System.Object() != 0)
            {
                    typeof(WFOMysteryChestUI.<>c__DisplayClass22_0).__il2cppRuntimeField_8 = this;
            }
            else
            {
                    mem[8] = this;
            }
            
            typeof(WFOMysteryChestUI.<>c__DisplayClass22_0).__il2cppRuntimeField_C = val_8;
            if(WordForest.WFOMysteryChestManager.IsFeatureUnlocked == false)
            {
                    return;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            mem2[0] = 1;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            UnityEngine.Transform val_3 = (0 + (chestIndex) << 2) + 16 + 8.transform;
            UnityEngine.Vector3 val_4 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions.DOShakeRotation(target:  (0 + (chestIndex) << 2) + 16 + 8, duration:  null, strength:  new UnityEngine.Vector3() {x = 0.5f, y = val_4.x, z = val_4.y}, vibrato:  val_4.z, randomness:  null, fadeOut:  true);
            val_8 = null;
            val_8 = new DG.Tweening.TweenCallback(object:  405856256, method:  new IntPtr(277325472));
            object val_7 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  (0 + (chestIndex) << 2) + 16 + 8, action:  190734336);
        }
        private void CollectMysteryChest()
        {
            var val_2;
            if(WordForest.WFOMysteryChestManager.IsFeatureUnlocked == false)
            {
                    return;
            }
            
            if((WordForest.WFOMysteryChestUI.<isMysteryChestFlowActive>k__BackingField) == true)
            {
                    return;
            }
            
            val_2 = mem[R5 + 92];
            val_2 = R5 + 92;
            mem2[0] = 1;
            R4.Invoke(methodName:  277446688, time:  null);
        }
        private void ShowChest()
        {
            GameBehavior val_1 = App.getBehavior;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_7 = new System.Action(object:  277584832, method:  new IntPtr(277559808));
            0.Setup(rarityType:  0, itemData:  0, collectedChestCount:  GetCollectedChestCount, totalChestCount:  GetChestCount, onComplete:  null);
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            GameplayMode val_9 = PlayingLevel.CurrentGameplayMode;
            ClearChestLocData(mode:  0);
        }
        protected void OnMysteryChestOpenAnimComplete()
        {
            WordForest.WFOMysteryChestUI.<isMysteryChestFlowActive>k__BackingField = false;
        }
        private void ShiftMysteryChest(int chestIndex)
        {
            int val_10;
            int val_11;
            int val_12;
            val_10 = chestIndex;
            if(new System.Object() != 0)
            {
                    typeof(WFOMysteryChestUI.<>c__DisplayClass26_0).__il2cppRuntimeField_C = this;
            }
            else
            {
                    mem[12] = this;
            }
            
            typeof(WFOMysteryChestUI.<>c__DisplayClass26_0).__il2cppRuntimeField_10 = val_10;
            if(12 != 0)
            {
                    return;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if(((0 + (chestIndex) << 2)) <= ((0 + (chestIndex) << 2) + 16 + 12))
            {
                    var val_10 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_10 = val_10 + (((0 + (chestIndex) << 2) + 16 + 12) << 2);
            typeof(WFOMysteryChestUI.<>c__DisplayClass26_0).__il2cppRuntimeField_8 = (0 + ((0 + (chestIndex) << 2) + 16 + 12) << 2) + 16;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            System.Predicate<ZooTile> val_2 = new System.Predicate<ZooTile>(object:  405909504, method:  new IntPtr(277801216));
            mem2[0] = (0 + ((0 + (chestIndex) << 2) + 16 + 12) << 2) + 16 + 20.FindIndex(match:  8040448);
            GameplayMode val_4 = PlayingLevel.CurrentGameplayMode;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_11 = typeof(WFOMysteryChestUI.<>c__DisplayClass26_0).__il2cppRuntimeField_10;
            if(((0 + (chestIndex) << 2)) <= val_11)
            {
                    var val_11 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_11 = val_11 + (val_11 << 2);
            val_12 = typeof(WFOMysteryChestUI.<>c__DisplayClass26_0).__il2cppRuntimeField_10;
            if(((0 + (chestIndex) << 2) + 16 + 20) != 0)
            {
                    (0 + (chestIndex) << 2) + 16 + 20 = 1;
            }
            
            this.mysteryChestManager.SetCurrentChestLocData(mode:  0, gameLevel:  this.currentAssociatedLevel, lineWordIndex:  (0 + (chestIndex) << 2) + 16 + 12, cellIndex:  (0 + (chestIndex) << 2) + 16 + 16, collected:  true, chestIndex:  val_12);
            val_10 = this.mysteryChestTiles;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if(((0 + (chestIndex) << 2) + 16 + 16) > 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                UnityEngine.Transform val_5 = (0 + (chestIndex) << 2) + 16 + 8.transform;
                val_11 = (0 + (chestIndex) << 2) + 16 + 8;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_10 = mem[(0 + (chestIndex) << 2) + 16 + 16];
                val_10 = (0 + (chestIndex) << 2) + 16 + 16;
                if(((0 + ((0 + (chestIndex) << 2) + 16 + 12) << 2) + 16 + 20 + 12) <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_12 = (0 + ((0 + (chestIndex) << 2) + 16 + 12) << 2) + 16 + 20 + 8;
                val_12 = val_12 + (val_10 << 2);
                UnityEngine.Transform val_6 = ((0 + ((0 + (chestIndex) << 2) + 16 + 12) << 2) + 16 + 20 + 8 + ((0 + (chestIndex) << 2) + 16 + 16) << 2) + 16.transform;
                val_12 = ((0 + ((0 + (chestIndex) << 2) + 16 + 12) << 2) + 16 + 20 + 8 + ((0 + (chestIndex) << 2) + 16 + 16) << 2) + 16;
                val_11.SetParent(p:  val_12);
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                UnityEngine.Transform val_7 = (0 + (chestIndex) << 2) + 16 + 8.transform;
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
                (0 + (chestIndex) << 2) + 16 + 8.localPosition = new UnityEngine.Vector3();
            }
            else
            {
                    this.ClearMysteryChest(chestIndex:  typeof(WFOMysteryChestUI.<>c__DisplayClass26_0).__il2cppRuntimeField_10);
            }
            
            Player val_9 = App.Player;
            0.SaveState();
        }
        private void OnWordRegionLoaded()
        {
            int val_20;
            float val_36;
            float val_37;
            var val_38;
            var val_39;
            System.Predicate<LineWord> val_41;
            var val_42;
            var val_43;
            if(WordForest.WFOMysteryChestManager.IsFeatureUnlocked == false)
            {
                    return;
            }
            
            val_36 = 1152921504982192128;
            GameplayMode val_2 = PlayingLevel.CurrentGameplayMode;
            WordForest.ChestLocData val_3 = this.mysteryChestManager.GetCurrentChestPlacementData(mode:  0);
            val_37 = this.mysteryChestManager;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.mysteryChestTiles = null;
            if(val_37 == 0)
            {
                goto label_8;
            }
            
            int val_5 = PlayingLevel.GetCurrentPlayerLevelNumber();
            if(null != val_5)
            {
                goto label_8;
            }
            
            this.currentAssociatedLevel = val_5;
            val_38 = 4;
            goto label_10;
            label_23:
            WordForest.MysteryChest val_6 = new WordForest.MysteryChest();
            if(this.mysteryChestManager.chestCountRandomSet.items <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            typeof(WordForest.MysteryChest).__il2cppRuntimeField_C = this.mysteryChestManager.chestCountRandomSet.replacement + 16 + 8;
            if(this.mysteryChestManager.chestCountRandomSet.items <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            typeof(WordForest.MysteryChest).__il2cppRuntimeField_10 = this.mysteryChestManager.chestCountRandomSet.replacement + 16 + 12;
            if(this.mysteryChestManager.chestCountRandomSet.items <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            typeof(WordForest.MysteryChest).__il2cppRuntimeField_14 = this.mysteryChestManager.chestCountRandomSet.replacement + 16.Collected;
            this.mysteryChestTiles.Add(item:  405749760);
            val_38 = 5;
            label_10:
            if((val_38 - 4) < this.mysteryChestManager.chestCountRandomSet.items)
            {
                goto label_23;
            }
            
            val_36 = 1152921504982192128;
            goto label_28;
            label_8:
            int val_9 = this.mysteryChestManager.GetRandomChestCount();
            label_28:
            if(this.currentAssociatedLevel == PlayingLevel.GetCurrentPlayerLevelNumber())
            {
                goto label_33;
            }
            
            GameplayMode val_11 = PlayingLevel.CurrentGameplayMode;
            this.mysteryChestManager.ClearChestLocData(mode:  0);
            this.currentAssociatedLevel = PlayingLevel.GetCurrentPlayerLevelNumber();
            if(val_9 < 1)
            {
                goto label_96;
            }
            
            label_95:
            val_39 = null;
            val_39 = null;
            val_41 = WFOMysteryChestUI.<>c.<>9__27_0;
            if(val_41 == 0)
            {
                    val_41 = null;
                val_41 = new System.Predicate<ZooTile>(object:  WFOMysteryChestUI.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(278067840));
                WFOMysteryChestUI.<>c.<>9__27_0 = val_41;
            }
            
            if((this.mysteryChestManager.Exists(match:  8040448)) == true)
            {
                    return;
            }
            
            System.Collections.Generic.List<System.Int32> val_15 = this.wordRegion.getAvailableLineIndices;
            if(this.wordRegion == 0)
            {
                    return;
            }
            
            RandomSet val_16 = new RandomSet();
            System.Collections.Generic.List<System.Int32> val_17 = this.wordRegion.getAvailableLineIndices;
            if(this.wordRegion == 0)
            {
                goto label_96;
            }
            
            List.Enumerator<T> val_18 = GetEnumerator();
            label_54:
            if(MoveNext() == false)
            {
                goto label_52;
            }
            
            add(item:  val_20, weight:  null);
            goto label_54;
            label_52:
            Dispose();
            var val_37 = 1;
            if(val_37 != 1)
            {
                    val_37 = val_37 + 0;
            }
            
            WordForest.MysteryChest val_21 = new WordForest.MysteryChest();
            if(val_21 != 0)
            {
                    val_42 = val_21;
                val_43 = 0;
                typeof(WordForest.MysteryChest).__il2cppRuntimeField_10 = val_43;
            }
            else
            {
                    val_42 = 16;
                mem[16] = 0;
                val_43 = 0;
            }
            
            typeof(WordForest.MysteryChest).__il2cppRuntimeField_14 = val_43;
            int val_38 = val_9;
            val_38 = val_38 - 1;
            val_38 = val_38 >> 5;
            val_38 = val_38 | 0;
            label_79:
            if(remainingCount() == 0)
            {
                goto label_60;
            }
            
            typeof(WordForest.MysteryChest).__il2cppRuntimeField_C = roll(unweighted:  false);
            goto label_62;
            label_71:
            var val_39 = mem[16];
            val_39 = val_39 + 1;
            mem[16] = val_39;
            label_62:
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if(((0 + (val_23) << 2) + 16 + 20 + 12) <= val_42)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_40 = (0 + (val_23) << 2) + 16 + 20 + 8;
            val_40 = val_40 + (val_42 << 2);
            if((((0 + (val_23) << 2) + 16 + 20 + 8 + ((mem[16] + 1)) << 2) + 16 + 36) != 0)
            {
                goto label_71;
            }
            
            if(val_38 != 0)
            {
                goto label_80;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if(((0 + (val_23) << 2) + 16 + 24) >= ((0 + (val_23) << 2)))
            {
                goto label_79;
            }
            
            goto label_80;
            label_60:
            typeof(WordForest.MysteryChest).__il2cppRuntimeField_C = 0;
            mem[16] = 0;
            label_80:
            if(typeof(WordForest.MysteryChest).__il2cppRuntimeField_C != 1)
            {
                    typeof(WordForest.MysteryChest).__il2cppRuntimeField_C = mem[16];
            }
            
            this.mysteryChestTiles.Add(item:  405749760);
            GameplayMode val_24 = PlayingLevel.CurrentGameplayMode;
            val_37 = 0;
            if(0 <= 0)
            {
                    var val_41 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_41 = val_41 + 0;
            if(val_41 <= 0)
            {
                    var val_42 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_42 = val_42 + 0;
            if(val_42 <= 0)
            {
                    var val_43 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_43 = val_43 + 0;
            if(((0 + 0) + 16 + 20) != 0)
            {
                    (0 + 0) + 16 + 20 = 1;
            }
            
            this.mysteryChestManager.SetCurrentChestLocData(mode:  0, gameLevel:  this.currentAssociatedLevel, lineWordIndex:  (0 + 0) + 16 + 12, cellIndex:  (0 + 0) + 16 + 16, collected:  true, chestIndex:  0);
            var val_44 = 0;
            val_44 = val_44 + 1;
            if(val_44 < val_9)
            {
                goto label_95;
            }
            
            label_96:
            Player val_25 = App.Player;
            val_36 = 1152921504982192128;
            0.SaveState();
            label_33:
            val_38 = 4;
            goto label_104;
            label_129:
            if(this.currentAssociatedLevel == PlayingLevel.GetCurrentPlayerLevelNumber())
            {
                    bool val_27 = this.IsChestTileAvailable(chestIndex:  0);
                if(val_27 != false)
            {
                    if(val_27 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_37 = mem[16];
                if(0 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if((public static System.Void PluginExtension::Shuffle<System.Char>(System.Collections.Generic.IList<T> list, System.Nullable<int> seed)) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_36 = 1152921504982192128;
                if(1152921511597576336 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                UnityEngine.Transform val_28 = (public static System.Void PluginExtension::Shuffle<ChallengeTask>(System.Collections.Generic.IList<T> list, System.Nullable<int> seed).__il2cppRuntimeField_10 + 20 + 8 + 0) + 16.transform;
                object val_29 = UnityEngine.Object.Instantiate<System.Object>(original:  this.prefabMysteryChestTile, parent:  (public static System.Void PluginExtension::Shuffle<ChallengeTask>(System.Collections.Generic.IList<T> list, System.Nullable<int> seed).__il2cppRuntimeField_10 + 20 + 8 + 0) + 16);
                object val_30 = this.prefabMysteryChestTile.GetComponent<System.Object>();
                var val_45 = 0;
                mem[8] = this.prefabMysteryChestTile;
                val_45 = val_45 + 1;
            }
            
            }
            
            val_38 = 5;
            label_104:
            val_41 = val_38 - 4;
            if(val_41 < val_45)
            {
                goto label_129;
            }
            
            if(val_45 >= 1)
            {
                    val_41 = 1152921504901095424;
                val_38 = 1152921512382697520;
                twelvegigs.Autopilot.AutopilotManager val_31 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                if(IsFTUXCompleted() != true)
            {
                    twelvegigs.Autopilot.AutopilotManager val_33 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                object val_34 = ShowUGUIMonolith<System.Object>(showNext:  false);
                twelvegigs.Autopilot.AutopilotManager val_35 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                CompleteFTUX();
            }
            
            }
            
            NotificationCenter val_36 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  278164544, aName:  277172384);
        }
        private void OnWordRegionPreprocessPlayerTurn(bool hintUsage, string wordEntered, LineWord lineWord, Cell cell)
        {
            var val_4;
            bool val_1 = this.IsTileCurrentlyInPlay;
            if(val_1 == false)
            {
                    return;
            }
            
            val_4 = 4;
            goto label_2;
            label_15:
            if(val_1 <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            bool val_2 = System.String.IsNullOrEmpty(value:  wordEntered);
            if(val_2 == false)
            {
                goto label_13;
            }
            
            val_4 = 5;
            label_2:
            if((val_4 - 4) < val_2)
            {
                goto label_15;
            }
            
            return;
            label_13:
            if(val_2 <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_5 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_5 = val_5 + (static_value_0028000F << 2);
            if(((0 + (static_value_0028000F) << 2) + 16 + 12.Equals(value:  wordEntered)) == false)
            {
                    return;
            }
            
            mem2[0] = 1;
        }
        private void OnWordRegionWordFound(string wordCompleted)
        {
            var val_3;
            System.Collections.Generic.List<WordForest.MysteryChest> val_4;
            var val_5;
            bool val_1 = this.IsTileCurrentlyInPlay;
            if(val_1 == false)
            {
                    return;
            }
            
            val_3 = 4;
            goto label_2;
            label_23:
            val_4 = this.mysteryChestTiles;
            if(val_1 <= SL)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_4 = static_value_0028000F;
            if(val_4 >= 0)
            {
                goto label_12;
            }
            
            if(0 <= SL)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            var val_5 = SB + 8;
            val_5 = val_5 + (static_value_0028000F << 2);
            val_4 = mem[(SB + 8 + (static_value_0028000F) << 2) + 16 + 12];
            val_4 = (SB + 8 + (static_value_0028000F) << 2) + 16 + 12;
            bool val_2 = val_4.Equals(value:  wordCompleted);
            if(val_2 == true)
            {
                goto label_21;
            }
            
            label_12:
            val_3 = 5;
            label_2:
            if((val_3 - 4) < val_2)
            {
                goto label_23;
            }
            
            val_5 = 4;
            goto label_24;
            label_36:
            val_4 = this.mysteryChestTiles;
            if(val_2 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_4 = static_value_0028000F;
            if(val_4 < 0)
            {
                    this.ShiftMysteryChest(chestIndex:  5);
            }
            
            val_5 = 5;
            label_24:
            if((val_5 - 4) < this)
            {
                goto label_36;
            }
            
            return;
            label_21:
            this.CollectMysteryChestIcon(chestIndex:  SL);
        }
        private void OnWordRegionHintUsed(UnityEngine.Vector3 location)
        {
            float val_8;
            float val_9;
            var val_10;
            var val_11;
            var val_13;
            System.Predicate<Cell> val_15;
            val_8 = location.z;
            val_9 = location.y;
            bool val_1 = this.IsTileCurrentlyInPlay;
            if(val_1 == false)
            {
                    return;
            }
            
            val_10 = 4;
            goto label_2;
            label_42:
            if(val_1 <= 35628514)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if(0 <= 35628514)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            bool val_2 = UnityEngine.Object.op_Inequality(x:  static_value_0028000B, y:  0);
            if(val_2 != false)
            {
                    if(val_2 <= 35628514)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                UnityEngine.Transform val_3 = static_value_0028000B.transform;
                UnityEngine.Vector3 val_4 = position;
                bool val_5 = UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3(), rhs:  new UnityEngine.Vector3() {x = location.x, y = val_9, z = val_8});
                if(val_5 != false)
            {
                    if(val_5 <= 35628514)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_11 = static_value_0028000F;
                if(0 <= val_11)
            {
                    var val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_9 = val_9 + (val_11 << 2);
                val_13 = null;
                val_13 = null;
                val_15 = WFOMysteryChestUI.<>c.<>9__30_0;
                if(val_15 == 0)
            {
                    val_11 = val_8;
                val_15 = null;
                val_15 = new System.Predicate<ZooTile>(object:  WFOMysteryChestUI.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(278816512));
                val_8 = val_11;
                WFOMysteryChestUI.<>c.<>9__30_0 = val_15;
            }
            
                val_9 = val_9;
                if(((0 + (static_value_0028000F) << 2) + 16 + 20.Exists(match:  8040448)) == false)
            {
                    return;
            }
            
                this.ShiftMysteryChest(chestIndex:  35628514);
            }
            
            }
            
            val_10 = 5;
            label_2:
            if((val_10 - 4) < this)
            {
                goto label_42;
            }
        
        }
        private void CheckShowChestOnComplete(GameLevel level)
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(GetCollectedChestCount < 1)
            {
                    return;
            }
            
            this.CollectMysteryChest();
            WordRegion val_3 = WordRegion.instance;
            0.AddLevelCompleteBlocker(blocker:  0);
        }
        public void Hack_CollectMysteryChest()
        {
            var val_1;
            System.Collections.Generic.List<WordForest.MysteryChest> val_2;
            val_1 = 4;
            goto label_1;
            label_13:
            val_2 = this.mysteryChestTiles;
            if(true <= 35628516)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_2 = static_value_0028000F;
            if(val_2 < 0)
            {
                goto label_11;
            }
            
            val_1 = 5;
            label_1:
            if((val_1 - 4) < 0)
            {
                goto label_13;
            }
            
            return;
            label_11:
            this.CollectMysteryChestIcon(chestIndex:  35628516);
        }
        public WFOMysteryChestUI()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this.mysteryChestTiles = null;
            this.currentAssociatedLevel = 0;
        }
    
    }

}
