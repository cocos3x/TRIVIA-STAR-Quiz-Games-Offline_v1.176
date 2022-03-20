using UnityEngine;

namespace BlockPuzzleMagic
{
    public class BBLGameplayUIController : MonoSingleton<BlockPuzzleMagic.BBLGameplayUIController>
    {
        // Fields
        private UnityEngine.UI.Button buttonTapEnd;
        private UnityEngine.UI.Text buttonEndText;
        private UnityEngine.UI.Text levelLabel;
        private BlockPuzzleMagic.BBLPowerupShapeButton buttonPowerupBomb;
        private BlockPuzzleMagic.BBLPowerupShapeButton buttonPowerupFill;
        private BlockPuzzleMagic.BBLTrashShapeButton buttonPowerupTrash;
        private UnityEngine.GameObject freeCoinsButton;
        private UnityEngine.GameObject howToPlayButton;
        private bool isIntroAnimQueued;
        private bool levelContainsStones;
        private bool levelContainsDots;
        private bool suppressFtuxWindows;
        
        // Properties
        public BlockPuzzleMagic.BBLPowerupShapeButton ButtonPowerupBomb { get; }
        public BlockPuzzleMagic.BBLPowerupShapeButton ButtonPowerupFill { get; }
        public BlockPuzzleMagic.BBLTrashShapeButton ButtonPowerupTrash { get; }
        
        // Methods
        public BlockPuzzleMagic.BBLPowerupShapeButton get_ButtonPowerupBomb()
        {
        
        }
        public BlockPuzzleMagic.BBLPowerupShapeButton get_ButtonPowerupFill()
        {
        
        }
        public BlockPuzzleMagic.BBLTrashShapeButton get_ButtonPowerupTrash()
        {
        
        }
        private void Start()
        {
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  1208366640, method:  new IntPtr(1208326256));
            System.Delegate val_3 = System.Delegate.Combine(a:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_18, b:  7401472);
            val_19 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_18;
            if(val_19 != 0)
            {
                    if(val_19 == null)
            {
                goto label_6;
            }
            
            }
            
            val_19 = 0;
            label_6:
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_18 = val_19;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Boolean> val_5 = new System.Action<System.Boolean>(object:  1208366640, method:  new IntPtr(1208328304));
            System.Delegate val_6 = System.Delegate.Combine(a:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_38, b:  7401472);
            val_20 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_38;
            if(val_20 != 0)
            {
                    if(val_20 == null)
            {
                goto label_10;
            }
            
            }
            
            val_20 = 0;
            label_10:
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_38 = val_20;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Boolean> val_8 = new System.Action<System.Boolean>(object:  1208366640, method:  new IntPtr(1208329328));
            System.Delegate val_9 = System.Delegate.Combine(a:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_24, b:  7401472);
            val_21 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_24;
            if(val_21 != 0)
            {
                    if(val_21 == null)
            {
                goto label_14;
            }
            
            }
            
            val_21 = 0;
            label_14:
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_24 = val_21;
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<Result> val_11 = new System.Action<Result>(object:  1208366640, method:  new IntPtr(1208330352));
            System.Delegate val_12 = System.Delegate.Combine(a:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_34, b:  7401472);
            val_22 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_34;
            if(val_22 != 0)
            {
                    if(val_22 == null)
            {
                goto label_18;
            }
            
            }
            
            val_22 = 0;
            label_18:
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_34 = val_22;
            twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Events.UnityAction val_14 = new UnityEngine.Events.UnityAction(object:  1208366640, method:  new IntPtr(1208331376));
            public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_28.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_15 = new UnityEngine.Events.UnityAction(object:  1208366640, method:  new IntPtr(1208340592));
            this.buttonTapEnd.m_OnClick.AddListener(call:  162246656);
            WordPets.WPTDataParser val_16 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            Initialize();
            System.Collections.IEnumerator val_17 = DelayedGameplayInit();
            UnityEngine.Coroutine val_18 = this.StartCoroutine(routine:  1208341616);
        }
        private System.Collections.IEnumerator DelayedGameplayInit()
        {
            object val_1 = new System.Object();
            typeof(BBLGameplayUIController.<DelayedGameplayInit>d__19).__il2cppRuntimeField_8 = 0;
        }
        private void OnDestroy()
        {
            System.Action<Result> val_21;
            float val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            val_21 = 1152921511021137168;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_22 = 1152921504765685760;
            if(2119322896 != 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  1208611120, method:  new IntPtr(1208331376));
                public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_28.RemoveListener(call:  162246656);
            }
            
            if(this.buttonTapEnd != 0)
            {
                    UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  1208611120, method:  new IntPtr(1208340592));
                this.buttonTapEnd.m_OnClick.RemoveListener(call:  162246656);
            }
            
            val_23 = 1152921504901095424;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(2118293440 == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<twelvegigs.storage.JsonDictionary> val_10 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  1208611120, method:  new IntPtr(1208326256));
            System.Delegate val_11 = System.Delegate.Remove(source:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_18, value:  7401472);
            val_24 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_18;
            if(val_24 != 0)
            {
                    if(val_24 == null)
            {
                goto label_25;
            }
            
            }
            
            val_24 = 0;
            label_25:
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_18 = val_24;
            twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Boolean> val_13 = new System.Action<System.Boolean>(object:  1208611120, method:  new IntPtr(1208328304));
            System.Delegate val_14 = System.Delegate.Remove(source:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_38, value:  7401472);
            val_25 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_38;
            if(val_25 != 0)
            {
                    if(val_25 == null)
            {
                goto label_29;
            }
            
            }
            
            val_25 = 0;
            label_29:
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_38 = val_25;
            twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Boolean> val_16 = new System.Action<System.Boolean>(object:  1208611120, method:  new IntPtr(1208329328));
            System.Delegate val_17 = System.Delegate.Remove(source:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_24, value:  7401472);
            val_26 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_24;
            if(val_26 != 0)
            {
                    if(val_26 == null)
            {
                goto label_33;
            }
            
            }
            
            val_26 = 0;
            label_33:
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_24 = val_26;
            twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_22 = 1152921504614248448;
            val_21 = null;
            val_21 = new System.Action<Result>(object:  1208611120, method:  new IntPtr(1208330352));
            System.Delegate val_20 = System.Delegate.Remove(source:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_34, value:  7401472);
            val_27 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_34;
            if(val_27 != 0)
            {
                    if(val_27 == null)
            {
                goto label_37;
            }
            
            }
            
            val_27 = 0;
            label_37:
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_34 = val_27;
        }
        private void OnLevelInitialized(BlockPuzzleMagic.Level currentLevel)
        {
            bool val_15 = static_value_021FBB90;
            if(val_15 != true)
            {
                    val_15 = true;
            }
            
            BestBlocksPlayer val_1 = BestBlocksPlayer.Instance;
            bool val_2 = val_15.IsFTUXGameLevels();
            string val_3 = System.String.Format(format:  2127161280, arg0:  13152256);
            WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            bool val_5 = VideoEnabledAndUnlocked();
            this.howToPlayButton.SetActive(value:  val_5 ^ 1);
            this.freeCoinsButton.SetActive(value:  val_5);
            BestBlocksPlayer val_7 = BestBlocksPlayer.Instance;
            bool val_8 = this.freeCoinsButton.IsFTUXGameLevels();
            if(currentLevel.levelId >= 2)
            {
                    twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                object val_10 = ShowUGUIMonolith<System.Object>(showNext:  false);
                this.isIntroAnimQueued = true;
            }
            
            this.levelContainsStones = currentLevel.gridLayout.GridContainsNodeType(_nodeType:  4);
            this.levelContainsDots = currentLevel.gridLayout.GridContainsNodeType(_nodeType:  2);
            this.suppressFtuxWindows = false;
            bool val_13 = this.CheckShowFTUX(currentLevel:  currentLevel);
            UnityEngine.GameObject val_14 = this.buttonTapEnd.gameObject;
            this.buttonTapEnd.SetActive(value:  false);
        }
        private void OnShapesChecked(bool canFit)
        {
            UnityEngine.Transform val_18;
            UnityEngine.GameObject val_1 = this.buttonTapEnd.gameObject;
            UnityEngine.Transform val_2 = this.buttonTapEnd.transform;
            int val_3 = DG.Tweening.DOTween.Complete(targetOrId:  this.buttonTapEnd, withCallbacks:  true);
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_18 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance();
            BlockPuzzleMagic.FtuxId val_5 = this.CheckShowFTUXOnInputResolved(currentLevel:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14);
            if(this != 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_6 = this.buttonTapEnd.gameObject;
            val_18 = this.buttonTapEnd;
            if(val_18.activeSelf != canFit)
            {
                    return;
            }
            
            UnityEngine.GameObject val_8 = this.buttonTapEnd.gameObject;
            if(canFit == true)
            {
                    0 = 1f;
            }
            
            UnityEngine.Transform val_9 = this.buttonTapEnd.transform;
            UnityEngine.Vector3 val_10 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            this.buttonTapEnd.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            UnityEngine.GameObject val_11 = this.buttonTapEnd.gameObject;
            this.buttonTapEnd.SetActive(value:  true);
            this.UpdateTapToEndButtonText();
            UnityEngine.GameObject val_12 = this.buttonTapEnd.gameObject;
            val_18 = this.buttonTapEnd;
            if(canFit == true)
            {
                    1f = 0;
            }
            
            UnityEngine.Transform val_13 = val_18.transform;
            DG.Tweening.Tweener val_14 = DG.Tweening.ShortcutExtensions.DOScaleY(target:  val_18, endValue:  null, duration:  null);
            object val_15 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  val_18, ease:  4);
            if(canFit != false)
            {
                    val_18 = val_18;
                DG.Tweening.TweenCallback val_16 = new DG.Tweening.TweenCallback(object:  1208935472, method:  new IntPtr(1208902256));
                object val_17 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  val_18, action:  190734336);
                return;
            }
            
            this.buttonPowerupTrash.trashIconShake.ShakeNow();
        }
        private void OnPowerupUsed(BlockPuzzleMagic.PowerUpType powerupUsed)
        {
            UnityEngine.GameObject val_1 = this.buttonTapEnd.gameObject;
            if(this.buttonTapEnd.activeSelf == false)
            {
                    return;
            }
            
            R4.UpdateTapToEndButtonText();
        }
        private void OnButtonTapToEndClicked()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            GameOver(success:  false);
        }
        private void OnGameOver(bool success)
        {
            var val_11;
            var val_12;
            var val_13;
            DG.Tweening.TweenCallback val_15;
            this.suppressFtuxWindows = true;
            if(success == false)
            {
                goto label_1;
            }
            
            UnityEngine.Color val_1 = UnityEngine.Color.clear;
            val_11 = mem[public static T[] System.Array::Empty<UnityEngine.Transform>().__il2cppRuntimeField_18 + 186];
            val_11 = public static T[] System.Array::Empty<UnityEngine.Transform>().__il2cppRuntimeField_18 + 186;
            if(val_11 == 1)
            {
                    val_11 = mem[public static T[] System.Array::Empty<UnityEngine.Transform>().__il2cppRuntimeField_18 + 186];
                val_11 = public static T[] System.Array::Empty<UnityEngine.Transform>().__il2cppRuntimeField_18 + 186;
            }
            
            BlockPuzzleMagic.BBLGameplayUIHelper.ShowGameplayOverlay(bgColor:  new UnityEngine.Color(), setBgColorInstantly:  true, contentToShow:  public static T[] System.Array::Empty<UnityEngine.Transform>().__il2cppRuntimeField_18 + 92);
            BestBlocksPlayer val_2 = BestBlocksPlayer.Instance;
            bool val_3 = IsFTUXGameLevels();
            WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            val_12 = null;
            val_13 = null;
            val_15 = BBLGameplayUIController.<>c.<>9__25_0;
            if(val_15 != 0)
            {
                goto label_25;
            }
            
            val_15 = null;
            val_15 = new DG.Tweening.TweenCallback(object:  BBLGameplayUIController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(1209292528));
            BBLGameplayUIController.<>c.<>9__25_0 = val_15;
            goto label_25;
            label_1:
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_8 = ShowUGUIMonolith<System.Object>(showNext:  false);
            return;
            label_25:
            DG.Tweening.Tween val_10 = DG.Tweening.DOVirtual.DelayedCall(delay:  val_1.r, callback:  1062836634, ignoreTimeScale:  false);
        }
        private void OnWindowClosed()
        {
            if(this.isIntroAnimQueued != false)
            {
                    twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                if(GetActiveAndQueuedWindowCount() <= 0)
            {
                    BlockPuzzleMagic.BBLGameplayUIHelper.PlayLevelIntroAnimation(pulseOrigin:  40);
                this.isIntroAnimQueued = false;
            }
            
            }
            
            this.CheckShowFTUXDelayed();
        }
        private void UpdateTapToEndButtonText()
        {
            bool val_3 = static_value_021FBB95;
            if(val_3 != true)
            {
                    val_3 = true;
            }
            
            BestBlocksPlayer val_1 = BestBlocksPlayer.Instance;
            if((val_3.GetPowerupAmountUsedThisLevel(powerupType:  0)) < 1)
            {
                    "NO MORE SPACE (TAP HERE TO END)" = "NO MORE SPACE (USE TRASH CAN)";
            }
            
            if(this.buttonEndText == 0)
            {
                
            }
        
        }
        private void CheckShowFTUXDelayed()
        {
            if(this.suppressFtuxWindows == true)
            {
                    return;
            }
            
            DG.Tweening.TweenCallback val_1 = new DG.Tweening.TweenCallback(object:  R4, method:  new IntPtr(1209640064));
            DG.Tweening.Tween val_2 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1036831949, ignoreTimeScale:  false);
        }
        private bool CheckShowFTUX(BlockPuzzleMagic.Level currentLevel)
        {
            int val_12;
            var val_13;
            System.Collections.Generic.List<BlockPuzzleMagic.Goal> val_14;
            bool val_15;
            var val_16;
            var val_17;
            val_12 = this;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_13 = 0;
            if(GetActiveAndQueuedWindowCount() > 0)
            {
                    return (bool)val_13;
            }
            
            if(this.suppressFtuxWindows == true)
            {
                    return (bool)val_13;
            }
            
            BestBlocksPlayer val_3 = BestBlocksPlayer.Instance;
            if(val_13 > 1)
            {
                goto label_7;
            }
            
            val_14 = 13;
            if((101 & 32) != 0)
            {
                goto label_26;
            }
            
            label_7:
            if(this.levelContainsDots == false)
            {
                goto label_9;
            }
            
            val_14 = 7;
            if((240 & 128) != 0)
            {
                goto label_26;
            }
            
            label_9:
            val_15 = this.levelContainsStones;
            if(val_15 == false)
            {
                goto label_11;
            }
            
            val_15 = 101;
            val_14 = 8;
            if((val_15 & 1) != 0)
            {
                goto label_26;
            }
            
            label_11:
            val_12 = currentLevel.levelId;
            BlockPuzzleMagic.BestBlocksGameEcon val_4 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
            val_16 = -402653179;
            if(val_12 != (-402653179))
            {
                goto label_15;
            }
            
            val_16 = 240;
            val_14 = 4;
            if((val_16 & 16) != 0)
            {
                goto label_26;
            }
            
            label_15:
            val_12 = currentLevel.levelId;
            BlockPuzzleMagic.BestBlocksGameEcon val_5 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
            if(val_12 != 4)
            {
                goto label_18;
            }
            
            val_14 = 5;
            if((240 & 32) != 0)
            {
                goto label_26;
            }
            
            label_18:
            val_12 = 0;
            goto label_20;
            label_28:
            if(240 <= val_12)
            {
                    var val_11 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_11 = val_11 + 0;
            if((((0 + 0) + 16 + 8) - 1) > 2)
            {
                goto label_24;
            }
            
            val_14 = ((0 + 0) + 16 + 8) + 9;
            if((33449456 & (1 << val_14)) != 0)
            {
                goto label_26;
            }
            
            label_24:
            val_12 = 1;
            label_20:
            val_14 = currentLevel.goals;
            if(val_12 < 33449456)
            {
                goto label_28;
            }
            
            val_13 = 0;
            return (bool)val_13;
            label_26:
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_17 = 0;
            object val_8 = ShowUGUIMonolith<System.Object>(showNext:  false);
            if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance()) != 0)
            {
                    val_17 = 0;
            }
            
            ShowFTUXStep(stage:  13, targetGO:  0);
            val_13 = 1;
            return (bool)val_13;
        }
        private BlockPuzzleMagic.FtuxId CheckShowFTUXOnInputResolved(BlockPuzzleMagic.Level currentLevel)
        {
            UnityEngine.Transform[] val_19;
            var val_20;
            var val_21;
            float val_22;
            var val_23;
            var val_24;
            float val_25;
            var val_26;
            var val_27;
            val_19 = this;
            val_20 = currentLevel;
            object val_1 = new System.Object();
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_21 = 0;
            if(GetActiveAndQueuedWindowCount() > 0)
            {
                    return;
            }
            
            if(this.suppressFtuxWindows == true)
            {
                    return;
            }
            
            BestBlocksPlayer val_4 = BestBlocksPlayer.Instance;
            if(val_1 != 0)
            {
                    val_22 = val_1;
                typeof(BBLGameplayUIController.<>c__DisplayClass30_0).__il2cppRuntimeField_8 = 0;
            }
            else
            {
                    val_22 = 8;
                mem[8] = 0;
            }
            
            typeof(BBLGameplayUIController.<>c__DisplayClass30_0).__il2cppRuntimeField_C = 0;
            if(((this.suppressFtuxWindows + 281) != 2) || (this.levelContainsStones == false))
            {
                goto label_10;
            }
            
            val_19 = 0;
            goto label_11;
            label_22:
            val_23 = 4;
            if((currentLevel.gridLayout.IsFlagSetOnGridDataNode(_gridDataIndex:  0, _nodeType:  4)) == false)
            {
                goto label_13;
            }
            
            BlockPuzzleMagic.BlockData val_21 = currentLevel.gridLayout.gridBlockData[val_19];
            if(currentLevel.gridLayout.gridBlockData[0x0][0].breaksRequired < 2)
            {
                goto label_18;
            }
            
            label_13:
            val_19 = 1;
            label_11:
            if(val_19 < currentLevel.gridLayout.gridBlockData[0x0][0].breaksRequired)
            {
                goto label_22;
            }
            
            val_24 = 0;
            goto label_23;
            label_18:
            val_24 = 9;
            label_23:
            typeof(BBLGameplayUIController.<>c__DisplayClass30_0).__il2cppRuntimeField_8 = val_24;
            label_10:
            val_25 = 0f;
            if((this.suppressFtuxWindows + 280) == 64)
            {
                    val_19 = 1152921511021106112;
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                if(IsAllPiecesUnplaceable() != false)
            {
                    mem[8] = 6;
                twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                UnityEngine.GameObject val_9 = AnyUnplaceablePieces();
                val_25 = 0.25f;
                typeof(BBLGameplayUIController.<>c__DisplayClass30_0).__il2cppRuntimeField_C = public static BlockPuzzleMagic.BlockShapeSpawner MonoSingleton<BlockPuzzleMagic.BlockShapeSpawner>::get_Instance();
            }
            
            }
            
            if(((BlockPuzzleMagic.ShapeInfo.IsRotationAllowed != false) && ((this.suppressFtuxWindows + 281) == 64)) && (currentLevel.levelId == 1))
            {
                    val_19 = 4;
                val_26 = 0;
                twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                var val_15 =  - 4;
                val_22 = val_22;
                if( == 1)
            {
                    mem[8] = 14;
                UnityEngine.GameObject val_16 = public static BlockPuzzleMagic.BlockShapeSpawner MonoSingleton<BlockPuzzleMagic.BlockShapeSpawner>::get_Instance().__il2cppRuntimeField_14 + 16.gameObject;
                val_25 = 0.2f;
                typeof(BBLGameplayUIController.<>c__DisplayClass30_0).__il2cppRuntimeField_C = public static BlockPuzzleMagic.BlockShapeSpawner MonoSingleton<BlockPuzzleMagic.BlockShapeSpawner>::get_Instance().__il2cppRuntimeField_14 + 16;
            }
            
            }
            
            val_21 = 0;
            if(val_22 == 0)
            {
                    return;
            }
            
            if(val_1 == 0)
            {
                    val_20 = mem[8];
            }
            
            if(val_20 != 0)
            {
                    val_23 = 1;
                if((this.suppressFtuxWindows + 280) != (val_23 << (val_20 & 31)))
            {
                    return;
            }
            
            }
            
            UnityEngine.Color val_18 = UnityEngine.Color.clear;
            val_27 = mem[public static T[] System.Array::Empty<UnityEngine.Transform>().__il2cppRuntimeField_18 + 186];
            val_27 = public static T[] System.Array::Empty<UnityEngine.Transform>().__il2cppRuntimeField_18 + 186;
            if(val_27 == 1)
            {
                    val_27 = mem[public static T[] System.Array::Empty<UnityEngine.Transform>().__il2cppRuntimeField_18 + 186];
                val_27 = public static T[] System.Array::Empty<UnityEngine.Transform>().__il2cppRuntimeField_18 + 186;
            }
            
            val_20 = 1;
            val_19 = mem[public static T[] System.Array::Empty<UnityEngine.Transform>().__il2cppRuntimeField_18 + 92];
            val_19 = public static T[] System.Array::Empty<UnityEngine.Transform>().__il2cppRuntimeField_18 + 92;
            BlockPuzzleMagic.BBLGameplayUIHelper.ShowGameplayOverlay(bgColor:  new UnityEngine.Color(), setBgColorInstantly:  true, contentToShow:  val_19);
            DG.Tweening.TweenCallback val_19 = new DG.Tweening.TweenCallback(object:  462352384, method:  new IntPtr(1209947008));
            DG.Tweening.Tween val_20 = DG.Tweening.DOVirtual.DelayedCall(delay:  val_18.r, callback:  1045220557, ignoreTimeScale:  false);
            val_21 = mem[8];
        }
        public BBLGameplayUIController()
        {
        
        }
        private void <OnShapesChecked>b__22_0()
        {
            UnityEngine.GameObject val_1 = this.buttonTapEnd.gameObject;
            this.buttonTapEnd.SetActive(value:  false);
        }
        private void <CheckShowFTUXDelayed>b__28_0()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(2118293440 == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_4 = this.CheckShowFTUX(currentLevel:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14);
        }
    
    }

}
