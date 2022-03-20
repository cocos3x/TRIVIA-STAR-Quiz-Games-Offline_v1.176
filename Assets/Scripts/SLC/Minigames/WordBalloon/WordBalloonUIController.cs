using UnityEngine;

namespace SLC.Minigames.WordBalloon
{
    public class WordBalloonUIController : MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonUIController>
    {
        // Fields
        private SLC.Minigames.MinigamesCheckpointSlider checkpointSlider;
        private UnityEngine.UI.Text categoryLabel;
        private SLC.Minigames.WordBalloon.WordBalloonGrid letterGrid;
        private UnityEngine.CanvasGroup levelCompleteOverlay;
        private UnityEngine.UI.Button hintButton;
        private UnityEngine.CanvasGroup flyoutGroup;
        private UnityEngine.UI.Text flyoutLabel;
        private DG.Tweening.Sequence flyoutGroupSeq;
        private UnityEngine.UI.Button pauseButton;
        private UnityEngine.CanvasGroup pauseOverlayGroup;
        private SLC.Minigames.WordBalloon.WordBalloonFTUXPointer ftuxPointer;
        private UnityEngine.UI.Text ftuxMessageBlurb;
        private UnityEngine.UI.Button resetBoardButton;
        private UnityEngine.UI.Button newBoardButton;
        private DG.Tweening.Tween ftuxHighlightTween;
        
        // Methods
        public override void InitMonoSingleton()
        {
            var val_14;
            var val_15;
            System.Action val_16;
            var val_17;
            var val_18;
            UnityEngine.Events.UnityAction val_20;
            var val_21;
            UnityEngine.Events.UnityAction val_23;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_2 = new System.Action(object:  997818640, method:  new IntPtr(997754704));
            System.Delegate val_3 = System.Delegate.Combine(a:  public static SLC.Minigames.WordBalloon.WordBalloonManager MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonManager>::get_Instance().__il2cppRuntimeField_14, b:  7454720);
            val_14 = public static SLC.Minigames.WordBalloon.WordBalloonManager MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonManager>::get_Instance().__il2cppRuntimeField_14;
            if(val_14 != 0)
            {
                    if(val_14 == null)
            {
                goto label_6;
            }
            
            }
            
            val_14 = 0;
            label_6:
            public static SLC.Minigames.WordBalloon.WordBalloonManager MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonManager>::get_Instance().__il2cppRuntimeField_14 = val_14;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action val_5 = new System.Action(object:  997818640, method:  new IntPtr(997755728));
            System.Delegate val_6 = System.Delegate.Combine(a:  public static SLC.Minigames.WordBalloon.WordBalloonManager MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonManager>::get_Instance().__il2cppRuntimeField_18, b:  7454720);
            val_15 = public static SLC.Minigames.WordBalloon.WordBalloonManager MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonManager>::get_Instance().__il2cppRuntimeField_18;
            if(val_15 != 0)
            {
                    if(val_15 == null)
            {
                goto label_10;
            }
            
            }
            
            val_15 = 0;
            label_10:
            public static SLC.Minigames.WordBalloon.WordBalloonManager MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonManager>::get_Instance().__il2cppRuntimeField_18 = val_15;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_16 = null;
            val_16 = new System.Action(object:  997818640, method:  new IntPtr(997756752));
            System.Delegate val_9 = System.Delegate.Combine(a:  public static SLC.Minigames.WordBalloon.WordBalloonManager MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonManager>::get_Instance().__il2cppRuntimeField_1C, b:  7454720);
            val_17 = public static SLC.Minigames.WordBalloon.WordBalloonManager MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonManager>::get_Instance().__il2cppRuntimeField_1C;
            if(val_17 != 0)
            {
                    if(val_17 == null)
            {
                goto label_14;
            }
            
            }
            
            val_17 = 0;
            label_14:
            public static SLC.Minigames.WordBalloon.WordBalloonManager MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonManager>::get_Instance().__il2cppRuntimeField_1C = val_17;
            UnityEngine.Events.UnityAction val_10 = new UnityEngine.Events.UnityAction(object:  997818640, method:  new IntPtr(997765968));
            this.hintButton.m_OnClick.AddListener(call:  162246656);
            UnityEngine.Events.UnityAction val_11 = new UnityEngine.Events.UnityAction(object:  997818640, method:  new IntPtr(997775184));
            this.pauseButton.m_OnClick.AddListener(call:  162246656);
            val_18 = null;
            val_18 = null;
            val_20 = WordBalloonUIController.<>c.<>9__14_0;
            if(val_20 == 0)
            {
                    val_20 = null;
                val_20 = new UnityEngine.Events.UnityAction(object:  WordBalloonUIController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(997784400));
                WordBalloonUIController.<>c.<>9__14_0 = val_20;
            }
            
            this.resetBoardButton.m_OnClick.AddListener(call:  162246656);
            val_21 = null;
            val_21 = null;
            val_23 = WordBalloonUIController.<>c.<>9__14_1;
            if(val_23 == 0)
            {
                    val_23 = null;
                val_23 = new UnityEngine.Events.UnityAction(object:  WordBalloonUIController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(997793616));
                WordBalloonUIController.<>c.<>9__14_1 = val_23;
            }
            
            this.newBoardButton.m_OnClick.AddListener(call:  162246656);
        }
        private void Start()
        {
            this.checkpointSlider.UpdateUI();
        }
        public void ShowFlyoutStatus(string message)
        {
            if(this.flyoutGroupSeq != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.flyoutGroupSeq, complete:  false);
            }
            
            this.flyoutGroup.alpha = null;
            UnityEngine.GameObject val_1 = this.flyoutGroup.gameObject;
            this.flyoutGroup.SetActive(value:  true);
            DG.Tweening.Sequence val_2 = DG.Tweening.DOTween.Sequence();
            this.flyoutGroupSeq = 0;
            DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.flyoutGroup, endValue:  null, duration:  null);
            DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.flyoutGroup);
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.flyoutGroupSeq, interval:  null);
            DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.flyoutGroup, endValue:  null, duration:  null);
            DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.flyoutGroupSeq, t:  this.flyoutGroup);
            DG.Tweening.TweenCallback val_8 = new DG.Tweening.TweenCallback(object:  998125584, method:  new IntPtr(998100560));
            object val_9 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.flyoutGroupSeq, action:  190734336);
        }
        private void OnMinigameBegin()
        {
            DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.levelCompleteOverlay, endValue:  null, duration:  null);
            DG.Tweening.TweenCallback val_2 = new DG.Tweening.TweenCallback(object:  998304144, method:  new IntPtr(998258640));
            object val_3 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.levelCompleteOverlay, action:  190734336);
            this.checkpointSlider.UpdateUI();
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.letterGrid.ClearGrid();
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.letterGrid.CreateGrid(letterTileData:  public static SLC.Minigames.WordBalloon.WordBalloonManager MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonManager>::get_Instance().__il2cppRuntimeField_20 + 8, columnLimit:  public static SLC.Minigames.WordBalloon.WordBalloonManager MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonManager>::get_Instance().__il2cppRuntimeField_20 + 12);
            UnityEngine.GameObject val_7 = this.hintButton.gameObject;
            twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Minigames.WordBalloon.WordBalloonManager MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonManager>::get_Instance().__il2cppRuntimeField_C) > 0)
            {
                    0 = 1;
            }
            
            this.hintButton.SetActive(value:  true);
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Minigames.WordBalloon.WordBalloonManager MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonManager>::get_Instance()) != 0)
            {
                    return;
            }
        
        }
        private void OnMinigameEnd()
        {
            var val_3;
            DG.Tweening.TweenCallback val_5;
            val_3 = null;
            val_3 = null;
            val_5 = WordBalloonUIController.<>c.<>9__18_0;
            if(val_5 == 0)
            {
                    val_5 = null;
                val_5 = new DG.Tweening.TweenCallback(object:  WordBalloonUIController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(998416720));
                WordBalloonUIController.<>c.<>9__18_0 = val_5;
            }
            
            DG.Tweening.Tween val_2 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1069547520, ignoreTimeScale:  false);
        }
        private void OnLevelComplete()
        {
            System.Collections.IEnumerator val_1 = this.OnLevelCompleteCoroutine();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  998553744);
        }
        private System.Collections.IEnumerator OnLevelCompleteCoroutine()
        {
            object val_1 = new System.Object();
            typeof(WordBalloonUIController.<OnLevelCompleteCoroutine>d__20).__il2cppRuntimeField_8 = 0;
            typeof(WordBalloonUIController.<OnLevelCompleteCoroutine>d__20).__il2cppRuntimeField_10 = this;
        }
        private void ProceedToNewLevel()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            InitializeGame(existingData:  0);
            BeginGame();
        }
        private void OnPauseClicked()
        {
            this.pauseOverlayGroup.alpha = null;
            UnityEngine.GameObject val_1 = this.pauseOverlayGroup.gameObject;
            this.pauseOverlayGroup.SetActive(value:  true);
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.pauseOverlayGroup, endValue:  null, duration:  null);
        }
        private void OnHintClicked()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<System.Int32> val_2 = GetSolvableSlotSequence();
            if((public static SLC.Minigames.WordBalloon.WordBalloonGrid MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>::get_Instance()) != 0)
            {
                    twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                HighlightSlots(slotsToUse:  992963312);
                return;
            }
            
            this.ShowFlyoutStatus(message:  999002320);
        }
        private void StartFTUX()
        {
            var val_6;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Boolean, TRVQuizProgress> val_2 = new System.Action<System.Boolean, TRVQuizProgress>(object:  999140480, method:  new IntPtr(999114432));
            System.Delegate val_3 = System.Delegate.Combine(a:  public static SLC.Minigames.WordBalloon.WordBalloonGrid MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>::get_Instance().__il2cppRuntimeField_40, b:  7507968);
            val_6 = public static SLC.Minigames.WordBalloon.WordBalloonGrid MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>::get_Instance().__il2cppRuntimeField_40;
            if(val_6 != 0)
            {
                    if(val_6 == null)
            {
                goto label_6;
            }
            
            }
            
            val_6 = 0;
            label_6:
            public static SLC.Minigames.WordBalloon.WordBalloonGrid MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>::get_Instance().__il2cppRuntimeField_40 = val_6;
            DG.Tweening.TweenCallback val_4 = new DG.Tweening.TweenCallback(object:  999140480, method:  new IntPtr(999115456));
            DG.Tweening.Tween val_5 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1036831949, ignoreTimeScale:  false);
        }
        public void EndFTUX()
        {
            var val_6;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Boolean, TRVQuizProgress> val_2 = new System.Action<System.Boolean, TRVQuizProgress>(object:  999268864, method:  new IntPtr(999114432));
            System.Delegate val_3 = System.Delegate.Remove(source:  public static SLC.Minigames.WordBalloon.WordBalloonGrid MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>::get_Instance().__il2cppRuntimeField_40, value:  7507968);
            val_6 = public static SLC.Minigames.WordBalloon.WordBalloonGrid MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>::get_Instance().__il2cppRuntimeField_40;
            if(val_6 != 0)
            {
                    if(val_6 == null)
            {
                goto label_6;
            }
            
            }
            
            val_6 = 0;
            label_6:
            public static SLC.Minigames.WordBalloon.WordBalloonGrid MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>::get_Instance().__il2cppRuntimeField_40 = val_6;
            UnityEngine.GameObject val_4 = this.ftuxMessageBlurb.gameObject;
            this.ftuxMessageBlurb.SetActive(value:  false);
            UnityEngine.GameObject val_5 = this.ftuxPointer.gameObject;
            this.ftuxPointer.SetActive(value:  false);
            if(this.ftuxPointer.pointerMoveSeq == 0)
            {
                    return;
            }
            
            DG.Tweening.TweenExtensions.Kill(t:  this.ftuxPointer.pointerMoveSeq, complete:  false);
        }
        private void OnFTUXWordProcessed(bool isWordValid, string processedWord)
        {
            if(isWordValid == false)
            {
                    return;
            }
            
            if(this.ftuxHighlightTween != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.ftuxHighlightTween, complete:  false);
            }
            
            UnityEngine.GameObject val_1 = this.ftuxPointer.gameObject;
            this.ftuxPointer.SetActive(value:  false);
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            this.ShowFTUXStep();
        }
        private void ShowFTUXStep()
        {
            DG.Tweening.TweenCallback val_9;
            var val_10;
            DG.Tweening.Tween val_11;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            (public static SLC.Minigames.WordBalloon.WordBalloonManager MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonManager>::get_Instance().__il2cppRuntimeField_20 + 20 + 12 - public static SLC.Minigames..FtuxSetGridInteractable(blanketState:  false, exclusionList:  0);
            UnityEngine.GameObject val_3 = this.ftuxMessageBlurb.gameObject;
            this.ftuxMessageBlurb.SetActive(value:  true);
            val_9 = null;
            val_10 = 1152921514196299712;
             = new DG.Tweening.TweenCallback(object:  999557664, method:  new IntPtr(999527520));
            val_11 = 15820;
            val_11 = 1036831949;
            DG.Tweening.Tween val_8 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1077936128, ignoreTimeScale:  false);
            this.ftuxHighlightTween = ;
        }
        private void FtuxHighlightAction(System.Collections.Generic.List<int> slotSequence)
        {
            this.FtuxSetGridInteractable(blanketState:  false, exclusionList:  slotSequence);
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Minigames.WordBalloon.WordBalloonGrid MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>::get_Instance()) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.TimeType val_2 = public static SLC.Minigames.WordBalloon.WordBalloonGrid MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>::get_Instance().__il2cppRuntimeField_2C.Item[2621443];
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static SLC.Minigames.WordBalloon.WordBalloonGrid MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>::get_Instance()) == 0)
            {
                    var val_8 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = val_8 + 3971853244;
            System.TimeType val_4 = public static SLC.Minigames.WordBalloon.WordBalloonGrid MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>::get_Instance().__il2cppRuntimeField_2C.Item[(0 + 3971853244) + 16];
            UnityEngine.GameObject val_5 = this.ftuxPointer.gameObject;
            this.ftuxPointer.SetActive(value:  true);
            UnityEngine.GameObject val_6 = public static SLC.Minigames.WordBalloon.WordBalloonGrid MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>::get_Instance().__il2cppRuntimeField_2C.gameObject;
            UnityEngine.GameObject val_7 = public static SLC.Minigames.WordBalloon.WordBalloonGrid MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>::get_Instance().__il2cppRuntimeField_2C.gameObject;
            this.ftuxPointer.MoveAlong(startObj:  public static SLC.Minigames.WordBalloon.WordBalloonGrid MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>::get_Instance().__il2cppRuntimeField_2C, endObj:  public static SLC.Minigames.WordBalloon.WordBalloonGrid MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>::get_Instance().__il2cppRuntimeField_2C, moveAlongDuration:  null, moveAlongLoopType:  1065353216, moveAlongEaseType:  0);
        }
        private void FtuxSetGridInteractable(bool blanketState, System.Collections.Generic.List<int> exclusionList)
        {
            var val_4;
            bool val_12;
            float val_13;
            int val_14;
            var val_15;
            val_12 = blanketState;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Dictionary.Enumerator<TKey, TValue> val_2 = GetEnumerator();
            val_15 = 1152921514180276928;
            goto label_7;
            label_10:
            val_14 = val_4;
            if(val_14.HasLetterTile != false)
            {
                    val_14 = mem[val_4 + 40];
                val_14 = val_4 + 40;
                mem2[0] = val_12;
            }
            
            label_7:
            if(0.MoveNext() == true)
            {
                goto label_10;
            }
            
            0.Dispose();
            if(exclusionList == 0)
            {
                    return;
            }
            
            if(999818752 < 1)
            {
                    return;
            }
            
            bool val_7 = val_12 ^ 1;
            var val_13 = 0;
            val_13 = 1152921514180133184;
            val_12 = 1152921514180138304;
            do
            {
                if(999818752 <= val_13)
            {
                    var val_12 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_12 = val_12 + 0;
                val_14 = mem[(0 + 0) + 16];
                val_14 = (0 + 0) + 16;
                if((public static SLC.Minigames.WordBalloon.WordBalloonGrid MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>::get_Instance().__il2cppRuntimeField_2C.ContainsKey(key:  val_14)) != false)
            {
                    System.TimeType val_9 = public static SLC.Minigames.WordBalloon.WordBalloonGrid MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>::get_Instance().__il2cppRuntimeField_2C.Item[val_14];
                val_15 = public static SLC.Minigames.WordBalloon.WordBalloonGrid MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>::get_Instance().__il2cppRuntimeField_2C;
                if(val_15.HasLetterTile != false)
            {
                    System.TimeType val_11 = public static SLC.Minigames.WordBalloon.WordBalloonGrid MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>::get_Instance().__il2cppRuntimeField_2C.Item[val_14];
                val_14 = mem[public static SLC.Minigames.WordBalloon.WordBalloonGrid MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>::get_Instance().__il2cppRuntimeField_2C + 40];
                val_14 = public static SLC.Minigames.WordBalloon.WordBalloonGrid MonoSingleton<SLC.Minigames.WordBalloon.WordBalloonGrid>::get_Instance().__il2cppRuntimeField_2C + 40;
                mem2[0] = val_7;
            }
            
            }
            
                val_13 = val_13 + 1;
            }
            while(val_13 < val_7);
        
        }
        public WordBalloonUIController()
        {
        
        }
        private void <ShowFlyoutStatus>b__16_0()
        {
            UnityEngine.GameObject val_1 = this.flyoutGroup.gameObject;
            this.flyoutGroup.SetActive(value:  false);
        }
        private void <OnMinigameBegin>b__17_0()
        {
            UnityEngine.GameObject val_1 = this.levelCompleteOverlay.gameObject;
            this.levelCompleteOverlay.SetActive(value:  false);
        }
        private void <ShowFTUXStep>b__28_0()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<System.Int32> val_2 = GetSolvableSlotSequence();
            this.FtuxHighlightAction(slotSequence:  992963312);
        }
        private void <ShowFTUXStep>b__28_1()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<System.Int32> val_2 = GetSolvableSlotSequence();
            this.FtuxHighlightAction(slotSequence:  992963312);
        }
        private void <ShowFTUXStep>b__28_2()
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<System.Int32> val_2 = GetSolvableSlotSequence();
            this.FtuxHighlightAction(slotSequence:  992963312);
        }
    
    }

}
