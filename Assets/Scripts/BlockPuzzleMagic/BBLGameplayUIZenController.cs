using UnityEngine;

namespace BlockPuzzleMagic
{
    public class BBLGameplayUIZenController : MonoSingleton<BlockPuzzleMagic.BBLGameplayUIZenController>
    {
        // Fields
        private UnityEngine.UI.Text scoreBestLabel;
        private UnityEngine.UI.Text scoreCurrentLabel;
        private UnityEngine.CanvasGroup multiLineCelebrationGroup;
        private UnityEngine.UI.Text multiLineCelebrationText;
        private UnityEngine.CanvasGroup highScoreCelebrationGroup;
        private UnityEngine.UI.Text highScoreCelebrationText;
        private DG.Tweening.Tweener tweenerScoreCurrent;
        private DG.Tweening.Tweener tweenerScoreBest;
        private DG.Tweening.Sequence celebrationSeq;
        private bool isGameOverShown;
        
        // Properties
        private bool isHighScoreMessageShown { get; set; }
        
        // Methods
        private void set_isHighScoreMessageShown(bool value)
        {
            UnityEngine.PlayerPrefs.SetInt(key:  1212970928, value:  value);
        }
        private bool get_isHighScoreMessageShown()
        {
            int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  1212970928, defaultValue:  0);
            val_1 = val_1 - 1;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        private void Start()
        {
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  1213225184, method:  new IntPtr(1213195040));
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
            System.Action<System.Boolean> val_5 = new System.Action<System.Boolean>(object:  1213225184, method:  new IntPtr(1213196064));
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
            System.Action<twelvegigs.storage.JsonDictionary> val_8 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  1213225184, method:  new IntPtr(1213197088));
            System.Delegate val_9 = System.Delegate.Combine(a:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_1C, b:  7401472);
            val_21 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_1C;
            if(val_21 != 0)
            {
                    if(val_21 == null)
            {
                goto label_14;
            }
            
            }
            
            val_21 = 0;
            label_14:
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_1C = val_21;
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Boolean> val_11 = new System.Action<System.Boolean>(object:  1213225184, method:  new IntPtr(1213198112));
            System.Delegate val_12 = System.Delegate.Combine(a:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_24, b:  7401472);
            val_22 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_24;
            if(val_22 != 0)
            {
                    if(val_22 == null)
            {
                goto label_18;
            }
            
            }
            
            val_22 = 0;
            label_18:
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_24 = val_22;
            twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<twelvegigs.storage.JsonDictionary> val_14 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  1213225184, method:  new IntPtr(1213199136));
            System.Delegate val_15 = System.Delegate.Combine(a:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_28, b:  7401472);
            val_23 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_28;
            if(val_23 != 0)
            {
                    if(val_23 == null)
            {
                goto label_22;
            }
            
            }
            
            val_23 = 0;
            label_22:
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_28 = val_23;
            WordPets.WPTDataParser val_16 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            Initialize();
            System.Collections.IEnumerator val_17 = DelayedGameplayInit();
            UnityEngine.Coroutine val_18 = this.StartCoroutine(routine:  1208341616);
        }
        private System.Collections.IEnumerator DelayedGameplayInit()
        {
            object val_1 = new System.Object();
            typeof(BBLGameplayUIZenController.<DelayedGameplayInit>d__14).__il2cppRuntimeField_8 = 0;
        }
        private void OnDestroy()
        {
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            val_18 = 1152921504901095424;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(2118293440 == 0)
            {
                goto label_5;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<twelvegigs.storage.JsonDictionary> val_4 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  1213449184, method:  new IntPtr(1213195040));
            System.Delegate val_5 = System.Delegate.Remove(source:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_18, value:  7401472);
            val_19 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_18;
            if(val_19 != 0)
            {
                    if(val_19 == null)
            {
                goto label_11;
            }
            
            }
            
            val_19 = 0;
            label_11:
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_18 = val_19;
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Boolean> val_7 = new System.Action<System.Boolean>(object:  1213449184, method:  new IntPtr(1213196064));
            System.Delegate val_8 = System.Delegate.Remove(source:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_38, value:  7401472);
            val_20 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_38;
            if(val_20 != 0)
            {
                    if(val_20 == null)
            {
                goto label_15;
            }
            
            }
            
            val_20 = 0;
            label_15:
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_38 = val_20;
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<twelvegigs.storage.JsonDictionary> val_10 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  1213449184, method:  new IntPtr(1213197088));
            System.Delegate val_11 = System.Delegate.Remove(source:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_1C, value:  7401472);
            val_21 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_1C;
            if(val_21 != 0)
            {
                    if(val_21 == null)
            {
                goto label_19;
            }
            
            }
            
            val_21 = 0;
            label_19:
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_1C = val_21;
            twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Boolean> val_13 = new System.Action<System.Boolean>(object:  1213449184, method:  new IntPtr(1213198112));
            System.Delegate val_14 = System.Delegate.Remove(source:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_24, value:  7401472);
            val_22 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_24;
            if(val_22 != 0)
            {
                    if(val_22 == null)
            {
                goto label_23;
            }
            
            }
            
            val_22 = 0;
            label_23:
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_24 = val_22;
            twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<twelvegigs.storage.JsonDictionary> val_16 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  1213449184, method:  new IntPtr(1213199136));
            System.Delegate val_17 = System.Delegate.Remove(source:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_28, value:  7401472);
            val_18 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_28;
            if(val_18 != 0)
            {
                    if(val_18 == null)
            {
                goto label_27;
            }
            
            }
            
            val_18 = 0;
            label_27:
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_28 = val_18;
            label_5:
            if(this.isGameOverShown != false)
            {
                    return;
            }
            
            this.isGameOverShown.TrackModeComplete(isOutOfMoves:  false);
        }
        private void ShowMultilineCelebration(int lineCount)
        {
            var val_16;
            var val_17;
            if(this.celebrationSeq != 0)
            {
                    DG.Tweening.TweenExtensions.Complete(t:  this.celebrationSeq);
            }
            
            if((lineCount - 4) <= 2)
            {
                    val_16 = mem[34443576 + ((lineCount - 4)) << 2];
                val_16 = 34443576 + ((lineCount - 4)) << 2;
            }
            else
            {
                    val_16 = "Good!";
            }
            
            UnityEngine.Transform val_3 = this.multiLineCelebrationGroup.transform;
            val_17 = this.multiLineCelebrationGroup;
            if(val_17 != 0)
            {
                    if(null == null)
            {
                goto label_8;
            }
            
            }
            
            val_17 = 0;
            label_8:
            typeof(BBLGameplayUIZenController.<>c__DisplayClass16_0).__il2cppRuntimeField_8 = val_17;
            if(new System.Object() == 0)
            {
                    val_17 = typeof(BBLGameplayUIZenController.<>c__DisplayClass16_0).__il2cppRuntimeField_8;
            }
            
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  null, y:  null);
            val_17.anchoredPosition = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            UnityEngine.GameObject val_5 = typeof(BBLGameplayUIZenController.<>c__DisplayClass16_0).__il2cppRuntimeField_8.gameObject;
            typeof(BBLGameplayUIZenController.<>c__DisplayClass16_0).__il2cppRuntimeField_8.SetActive(value:  true);
            DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
            this.celebrationSeq = 0;
            DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  0, endValue:  null, duration:  null, snapping:  false);
            object val_8 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  0, ease:  27);
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  0);
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.celebrationSeq, interval:  null);
            DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  0, endValue:  null, duration:  null, snapping:  false);
            object val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  0, ease:  26);
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.celebrationSeq, t:  0);
            DG.Tweening.TweenCallback val_14 = new DG.Tweening.TweenCallback(object:  462565376, method:  new IntPtr(1213561840));
            object val_15 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.celebrationSeq, action:  190734336);
        }
        private void ShowHighScoreCelebration()
        {
            var val_16;
            object val_1 = new System.Object();
            if(val_1.isHighScoreMessageShown == true)
            {
                    return;
            }
            
            if(this.celebrationSeq != 0)
            {
                    DG.Tweening.TweenExtensions.Complete(t:  this.celebrationSeq);
            }
            
            UnityEngine.Transform val_3 = this.highScoreCelebrationGroup.transform;
            val_16 = this.highScoreCelebrationGroup;
            if(val_16 != 0)
            {
                    if(null == null)
            {
                goto label_6;
            }
            
            }
            
            val_16 = 0;
            label_6:
            typeof(BBLGameplayUIZenController.<>c__DisplayClass17_0).__il2cppRuntimeField_8 = val_16;
            if(val_1 == 0)
            {
                    val_16 = typeof(BBLGameplayUIZenController.<>c__DisplayClass17_0).__il2cppRuntimeField_8;
            }
            
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  null, y:  null);
            val_16.anchoredPosition = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            UnityEngine.GameObject val_5 = typeof(BBLGameplayUIZenController.<>c__DisplayClass17_0).__il2cppRuntimeField_8.gameObject;
            typeof(BBLGameplayUIZenController.<>c__DisplayClass17_0).__il2cppRuntimeField_8.SetActive(value:  true);
            DG.Tweening.Sequence val_6 = DG.Tweening.DOTween.Sequence();
            this.celebrationSeq = 0;
            DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  0, endValue:  null, duration:  null, snapping:  false);
            object val_8 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  0, ease:  27);
            DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  0);
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.celebrationSeq, interval:  null);
            DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions46.DOAnchorPosY(target:  0, endValue:  null, duration:  null, snapping:  false);
            object val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  0, ease:  26);
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.celebrationSeq, t:  0);
            DG.Tweening.TweenCallback val_14 = new DG.Tweening.TweenCallback(object:  462618624, method:  new IntPtr(1213719920));
            object val_15 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.celebrationSeq, action:  190734336);
            this.celebrationSeq.isHighScoreMessageShown = true;
        }
        private void TrackModeStart()
        {
            bool val_3;
            var val_4;
            val_3 = static_value_021FBBAD;
            if(val_3 != true)
            {
                    val_3 = true;
            }
            
            BestBlocksPlayer val_1 = BestBlocksPlayer.Instance;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            if(268439482 > 0)
            {
                    0 = 1;
            }
            
            Add(key:  1213853424, value:  8945664);
            Add(key:  1213853520, value:  13152256);
            var val_3 = 25261726;
            val_3 = 10363812 + val_3;
            if(val_3 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_4 = null;
            val_4 = null;
            App.trackerManager.track(eventName:  1213853616, data:  78753792);
        }
        private void TrackModeComplete(bool isOutOfMoves)
        {
            var val_4;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            BestBlocksPlayer val_2 = BestBlocksPlayer.Instance;
            Add(key:  1213965712, value:  13152256);
            BestBlocksPlayer val_3 = BestBlocksPlayer.Instance;
            Add(key:  1213965792, value:  13152256);
            Add(key:  1213965904, value:  8945664);
            var val_4 = 25263682;
            val_4 = 10361856 + val_4;
            if(val_4 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_4 = null;
            val_4 = null;
            App.trackerManager.track(eventName:  1213966000, data:  78753792);
        }
        private void OnLevelInitialized(BlockPuzzleMagic.Level currentLevel)
        {
            bool val_9;
            var val_10;
            var val_11;
            val_9 = static_value_021FBBAF;
            if(val_9 != true)
            {
                    val_9 = true;
            }
            
            BestBlocksPlayer val_1 = BestBlocksPlayer.Instance;
            string val_2 = System.String.Format(format:  2123518576, arg0:  13152256);
            BestBlocksPlayer val_3 = BestBlocksPlayer.Instance;
            string val_4 = System.String.Format(format:  1214090400, arg0:  13152256);
            BestBlocksPlayer val_5 = BestBlocksPlayer.Instance;
            if(this.scoreCurrentLabel <= 0)
            {
                    "SCORE: {0}" = 1;
                this.scoreCurrentLabel.isHighScoreMessageShown = true;
            }
            
            this.isGameOverShown = false;
            if(null != 0)
            {
                    val_10 = null;
                val_11 = UnityEngine.Random.Range(min:  0, max:  System.Int32[].__il2cppRuntimeField_namespaze);
            }
            else
            {
                    val_10 = 12;
                val_11 = UnityEngine.Random.Range(min:  0, max:  0);
            }
            
            var val_8 = null + (val_11 << 2);
            BlockPuzzleMagic.BBLGameplayUIHelper.PlayLevelIntroAnimation(pulseOrigin:  (null + (val_7) << 2) + 16);
            (null + (val_7) << 2) + 16.TrackModeStart();
        }
        private void OnShapePlaced(BlockPuzzleMagic.ShapeInfo shape)
        {
            bool val_3;
            var val_4;
            var val_5;
            val_3 = static_value_021FBBB0;
            if(val_3 != true)
            {
                    val_3 = true;
            }
            
            BlockPuzzleMagic.BestBlocksGameEcon val_1 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
            this.UpdatePlayerScore(scoreToAdd:  301989888 * 35634096, skipAnimation:  false);
            BestBlocksPlayer val_3 = BestBlocksPlayer.Instance;
            if(this != 0)
            {
                    val_4 = this;
            }
            else
            {
                    val_4 = 300;
                val_5 = 6;
            }
            
            mem[300] = 7;
        }
        private void OnBlocksCleared(System.Collections.Generic.List<System.Collections.Generic.List<BlockPuzzleMagic.GridCell>> blocksCleared)
        {
            var val_6;
            var val_9;
            float val_12;
            int val_13;
            var val_14;
            BlockPuzzleMagic.BestBlocksGameEcon val_1 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
            if(blocksCleared != 0)
            {
                
            }
            else
            {
                    val_12 = 0f;
            }
            
            List.Enumerator<T> val_2 = GetEnumerator();
            val_13 = 0;
            goto label_3;
            label_6:
            label_3:
            if(MoveNext() == true)
            {
                goto label_6;
            }
            
            Dispose();
            val_14 = val_6;
            List.Enumerator<T> val_7 = GetEnumerator();
            label_11:
            if(MoveNext() == false)
            {
                goto label_9;
            }
            
            val_14 = val_9;
            if(val_14.Item[1214356496] != 0)
            {
                goto label_11;
            }
            
            val_13 = val_14.Item[1214356576] + val_13;
            label_9:
            Dispose();
            if(val_13 >= 1)
            {
                    this.UpdatePlayerScore(scoreToAdd:  val_13, skipAnimation:  false);
            }
            
            if(val_12 < 3)
            {
                    return;
            }
            
            this.ShowMultilineCelebration(lineCount:  0);
        }
        private void UpdatePlayerScore(int scoreToAdd, bool skipAnimation = False)
        {
            bool val_14;
            int val_15;
            var val_16;
            int val_17;
            int val_18;
            val_14 = static_value_021FBBB2;
            if(val_14 != true)
            {
                    val_14 = true;
            }
            
            BestBlocksPlayer val_1 = BestBlocksPlayer.Instance;
            if(val_14 != 0)
            {
                    val_15 = val_14;
                int val_14 = 268439482;
                val_16 = 293;
                val_14 = val_14 + scoreToAdd;
                val_17 = 100667322;
                mem[293] = val_14;
            }
            else
            {
                    val_15 = 292;
                mem[292] = 1030672 + scoreToAdd;
                val_16 = 296;
                val_17 = mem[293];
            }
            
            mem[296] = val_17 + scoreToAdd;
            if(skipAnimation == false)
            {
                goto label_3;
            }
            
            string val_4 = System.String.Format(format:  1214090400, arg0:  13152256);
            if(this.scoreCurrentLabel != 0)
            {
                goto label_6;
            }
            
            goto label_6;
            label_3:
            if(this.tweenerScoreCurrent != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.tweenerScoreCurrent, complete:  false);
            }
            
            DG.Tweening.TweenCallback<System.Single> val_5 = new DG.Tweening.TweenCallback<System.Single>(object:  1214518256, method:  new IntPtr(1214481968));
            DG.Tweening.Tweener val_6 = DG.Tweening.DOVirtual.Float(from:  1030672f, to:  null, duration:  null, onVirtualUpdate:  1030672f);
            object val_7 = DG.Tweening.TweenSettingsExtensions.SetSpeedBased<System.Object>(t:  1030672f);
            object val_8 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  1030672f, ease:  1);
            this.tweenerScoreCurrent = 1030672f;
            label_6:
            if(val_14 != 0)
            {
                    val_18 = mem[292];
            }
            else
            {
                    val_18 = mem[292];
            }
            
            if(val_18 <= 268566133)
            {
                    return;
            }
            
            mem[289] = mem[292];
            this.ShowHighScoreCelebration();
            if(skipAnimation != false)
            {
                    val_15 = this.scoreBestLabel;
                string val_9 = System.String.Format(format:  2123518576, arg0:  13152256);
                if(val_15 != 0)
            {
                    return;
            }
            
                return;
            }
            
            if(this.tweenerScoreBest != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.tweenerScoreBest, complete:  false);
            }
            
            DG.Tweening.TweenCallback<System.Single> val_10 = new DG.Tweening.TweenCallback<System.Single>(object:  1214518256, method:  new IntPtr(1214493232));
            DG.Tweening.Tweener val_11 = DG.Tweening.DOVirtual.Float(from:  2.685661E+08f, to:  null, duration:  null, onVirtualUpdate:  2.685661E+08f);
            object val_12 = DG.Tweening.TweenSettingsExtensions.SetSpeedBased<System.Object>(t:  2.685661E+08f);
            object val_13 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  2.685661E+08f, ease:  1);
            this.tweenerScoreBest = 2.685661E+08f;
        }
        private void OnShapesChecked(bool canFit)
        {
            if(canFit == true)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            GameOver(success:  false);
        }
        private void OnGameOver(bool success)
        {
            if(this.isGameOverShown == true)
            {
                    return;
            }
            
            this.isGameOverShown.TrackModeComplete(isOutOfMoves:  true);
            this.isGameOverShown.isHighScoreMessageShown = false;
            mem2[0] = 1;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        public BBLGameplayUIZenController()
        {
        
        }
        private void <UpdatePlayerScore>b__23_0(float v)
        {
            int val_1 = UnityEngine.Mathf.FloorToInt(f:  v);
            string val_2 = System.String.Format(format:  1214090400, arg0:  13152256);
            if(this.scoreCurrentLabel != 0)
            {
                    return;
            }
        
        }
        private void <UpdatePlayerScore>b__23_1(float v)
        {
            int val_1 = UnityEngine.Mathf.FloorToInt(f:  v);
            string val_2 = System.String.Format(format:  2123518576, arg0:  13152256);
            if(this.scoreBestLabel != 0)
            {
                    return;
            }
        
        }
    
    }

}
