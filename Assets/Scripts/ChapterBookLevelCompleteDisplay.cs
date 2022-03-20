using UnityEngine;
public class ChapterBookLevelCompleteDisplay : MonoBehaviour
{
    // Fields
    private LevelCompletePopup levelCompletePopupParent;
    private UnityEngine.CanvasGroup thisMainCanvasGroup;
    private UnityEngine.CanvasGroup progressBarCanvasGroup;
    private ChapterBookProgressBar chapterBookProgressBar;
    private UnityEngine.UI.Button progressBarButton;
    private UnityEngine.RectTransform bookRewardAnimate;
    private UnityEngine.RectTransform bookRewardFocusXfm;
    private UnityEngine.RectTransform bookRewardProgressBarXfm;
    private UnityEngine.RectTransform bookRewardFinalXfm;
    private UnityEngine.UI.Image bookRewardBurstGlow;
    private UnityEngine.CanvasGroup bookAnimationGroup;
    private UnityEngine.UI.Text text_levels_until_reward;
    private UnityEngine.CanvasGroup largeBookRewardGroup;
    private LibraryBookDisplay rewardedBookDisplay;
    private UnityEngine.CanvasGroup otherBookRewardInfo;
    private UnityEngine.UI.Button button_Library;
    private UnityEngine.UI.Button button_Continue;
    private UnityEngine.CanvasGroup chooseNextBookDisplay;
    private LibraryBookDisplay[] bookOptions;
    private UnityEngine.UI.Text[] bookOptionCollectionProgress;
    private UnityEngine.UI.Button[] bookOptionButtons;
    private UnityEngine.UI.Button tapToContinueButton;
    private UnityEngine.CanvasGroup tapToContinueCanvasGroup;
    private System.Collections.Generic.List<BookInfo> availableBookOptions;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_6;
        var val_7;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1714135136, method:  new IntPtr(2580705760));
        this.progressBarButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1714135136, method:  new IntPtr(2580714976));
        this.button_Library.m_OnClick.AddListener(call:  162246656);
        val_6 = null;
        val_7 = 0;
        val_6 = new UnityEngine.Events.UnityAction(object:  -1714135136, method:  new IntPtr(2580724192));
        this.button_Continue.m_OnClick.AddListener(call:  162246656);
        goto label_7;
        label_15:
        if(new System.Object() != 0)
        {
                typeof(ChapterBookLevelCompleteDisplay.<>c__DisplayClass23_0).__il2cppRuntimeField_C = this;
        }
        else
        {
                mem[12] = this;
        }
        
        typeof(ChapterBookLevelCompleteDisplay.<>c__DisplayClass23_0).__il2cppRuntimeField_8 = val_7;
        UnityEngine.UI.Button val_6 = this.bookOptionButtons[val_7];
        val_6 = this.bookOptionButtons[0x0][0].m_OnClick;
        UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  299573248, method:  new IntPtr(2580725216));
        val_6.AddListener(call:  162246656);
        val_7 = 1;
        label_7:
        if(val_7 < val_6)
        {
            goto label_15;
        }
    
    }
    public void Display(int currentPlayerLevel = -1, float secondsBeforeDisplay = 3)
    {
        var val_30;
        var val_31;
        var val_32;
        bool val_33;
        var val_34;
        var val_35;
        val_30 = currentPlayerLevel;
        UnityEngine.GameObject val_1 = this.chooseNextBookDisplay.gameObject;
        this.chooseNextBookDisplay.SetActive(value:  false);
        this.chooseNextBookDisplay.alpha = secondsBeforeDisplay;
        this.thisMainCanvasGroup.alpha = secondsBeforeDisplay;
        UnityEngine.GameObject val_2 = this.progressBarCanvasGroup.gameObject;
        this.progressBarCanvasGroup.SetActive(value:  false);
        this.progressBarCanvasGroup.alpha = secondsBeforeDisplay;
        this.bookAnimationGroup.alpha = secondsBeforeDisplay;
        UnityEngine.GameObject val_3 = this.largeBookRewardGroup.gameObject;
        this.largeBookRewardGroup.SetActive(value:  false);
        this.largeBookRewardGroup.alpha = secondsBeforeDisplay;
        if(val_30 <= 0)
        {
                Player val_4 = App.Player;
            val_30 = 0;
        }
        
        if(((WADChapterManager.GetNumLevelsInCurrentChapter() + 1) - (WADChapterManager.GetCurrentLevelWithinChapter(level:  0))) > 1)
        {
                string val_9 = Localization.Localize(key:  -1713903648, defaultValue:  -1713903776, useSingularKey:  false);
            val_31 = "x_levels_until_next_reward";
            val_32 = 1152921504619999232;
        }
        else
        {
                string val_10 = Localization.Localize(key:  -1713903392, defaultValue:  -1713903520, useSingularKey:  false);
            val_31 = "x_level_until_next_reward";
            val_32 = 1152921504619999232;
        }
        
        string val_11 = System.String.Format(format:  -1713903392, arg0:  13152256);
        val_33 = 0;
        UnityEngine.GameObject val_12 = this.text_levels_until_reward.gameObject;
        if((ChapterBookLogic.ShowChapterComplete(playerLevel:  0)) != true)
        {
                val_33 = (ChapterBookLogic.ShowBookComplete(playerLevel:  0)) ^ 1;
        }
        
        this.text_levels_until_reward.SetActive(value:  val_33);
        this.chapterBookProgressBar.Setup(playerLevel:  0, showIncomplete:  false);
        bool val_15 = ChapterBookLogic.ShowBookComplete(playerLevel:  0);
        val_15.MatchTransformToAnother(mover:  this.bookRewardAnimate, toMatch:  this.bookRewardProgressBarXfm);
        UnityEngine.GameObject val_16 = this.progressBarCanvasGroup.gameObject;
        this.progressBarCanvasGroup.SetActive(value:  true);
        this.progressBarCanvasGroup.alpha = secondsBeforeDisplay;
        if(val_15 != false)
        {
                val_34 = 14265128 + 21376411;
            if(val_34 == 0)
        {
                mem2[0] = 1;
        }
        
            val_35 = null;
            val_35 = null;
            this.rewardedBookDisplay.Setup(info:  TheLibraryLogic._LastGrantedBook);
            this.Invoke(methodName:  -1713874592, time:  secondsBeforeDisplay);
        }
        else
        {
                System.Collections.Generic.Dictionary<System.String, BookInfo> val_17 = BookList.BookInfos;
            string val_18 = TheLibraryLogic.CurrentBookUnlockTarget;
            val_34 = 0;
            string val_19 = 0.Item[null];
            this.rewardedBookDisplay.Setup(info:  0);
            var val_29 = ~(ChapterBookLogic.GetFirstLevelOfBook(playerLevel:  0));
            val_29 = val_30 + val_29;
            val_29 = val_29 - 4294967295;
            val_34 = 0;
            DG.Tweening.Sequence val_21 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Tweener val_22 = DG.Tweening.ShortcutExtensions.DOShakeRotation(target:  this.bookRewardAnimate, duration:  secondsBeforeDisplay, strength:  null, vibrato:  1061158912, randomness:  null, fadeOut:  false);
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.bookRewardAnimate);
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.PrependInterval(s:  0, interval:  secondsBeforeDisplay);
            object val_25 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  0, loops:  0);
            object val_26 = DG.Tweening.TweenExtensions.Play<System.Object>(t:  0);
        }
        
        DG.Tweening.Tweener val_27 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.thisMainCanvasGroup, endValue:  secondsBeforeDisplay, duration:  null);
        object val_28 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.thisMainCanvasGroup, delay:  secondsBeforeDisplay);
    }
    private void PlayBookCompleteAnimation()
    {
        this.levelCompletePopupParent.HideLowerUI(fadeOutDuration:  null, delay:  null);
        this.levelCompletePopupParent.AnimateBook(book:  this.bookRewardAnimate, target:  this.bookRewardFinalXfm, duration:  null);
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.progressBarCanvasGroup, endValue:  null, duration:  null);
        this.ShowRewardedBook();
    }
    private void PlayBookIntroAnimation()
    {
        this.AnimateBook(book:  this.bookRewardAnimate, target:  this.bookRewardProgressBarXfm, duration:  null);
        UnityEngine.GameObject val_1 = this.progressBarCanvasGroup.gameObject;
        this.progressBarCanvasGroup.SetActive(value:  true);
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.progressBarCanvasGroup, endValue:  null, duration:  null);
    }
    private void MatchTransformToAnother(UnityEngine.RectTransform mover, UnityEngine.RectTransform toMatch)
    {
        float val_2;
        float val_3;
        float val_6;
        UnityEngine.Vector2 val_1 = sizeDelta;
        mover.sizeDelta = new UnityEngine.Vector2() {x = val_2, y = val_3};
        UnityEngine.Vector3 val_4 = localPosition;
        mover.localPosition = new UnityEngine.Vector3();
        UnityEngine.Quaternion val_5 = localRotation;
        mover.localRotation = new UnityEngine.Quaternion() {w = val_6};
        UnityEngine.Vector3 val_7 = localScale;
        mover.localScale = new UnityEngine.Vector3();
    }
    private void AnimateBook(UnityEngine.RectTransform book, UnityEngine.RectTransform target, float duration)
    {
        float val_2;
        float val_3;
        UnityEngine.Vector2 val_1 = sizeDelta;
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOSizeDelta(target:  book, endValue:  new UnityEngine.Vector2() {x = val_2, y = val_3}, duration:  val_1.x, snapping:  R3);
        UnityEngine.Vector3 val_5 = localPosition;
        DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  book, endValue:  new UnityEngine.Vector3(), duration:  val_5.x, snapping:  R3);
        object val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  book, ease:  7);
        UnityEngine.Quaternion val_8 = localRotation;
        UnityEngine.Vector3 val_9 = eulerAngles;
        DG.Tweening.Tweener val_10 = DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  book, endValue:  new UnityEngine.Vector3(), duration:  val_9.x, mode:  R3);
        object val_11 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  book, ease:  7);
        UnityEngine.Vector3 val_12 = localScale;
        DG.Tweening.Tweener val_13 = DG.Tweening.ShortcutExtensions.DOScale(target:  book, endValue:  new UnityEngine.Vector3(), duration:  val_12.x);
        object val_14 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  book, ease:  7);
    }
    private void FadeOutAndDisableGroup(UnityEngine.CanvasGroup group, float duration)
    {
        UnityEngine.CanvasGroup val_5;
        var val_6;
        val_5 = group;
        if(new System.Object() != 0)
        {
                typeof(ChapterBookLevelCompleteDisplay.<>c__DisplayClass29_0).__il2cppRuntimeField_8 = val_5;
        }
        else
        {
                mem[8] = val_5;
            val_5 = mem[8];
        }
        
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  val_5, endValue:  duration, duration:  null);
        DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  299626496, method:  new IntPtr(2581839200));
        System.Delegate val_4 = System.Delegate.Combine(a:  group + 68, b:  190734336);
        val_6 = group + 68;
        if(val_6 != 0)
        {
                if(val_6 == null)
        {
            goto label_6;
        }
        
        }
        
        val_6 = 0;
        label_6:
        mem2[0] = val_6;
    }
    private void ShowRewardedBook()
    {
        UnityEngine.GameObject val_1 = this.largeBookRewardGroup.gameObject;
        this.largeBookRewardGroup.SetActive(value:  true);
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.largeBookRewardGroup, endValue:  null, duration:  null);
        this.otherBookRewardInfo.alpha = null;
        DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.otherBookRewardInfo, endValue:  null, duration:  null);
        object val_4 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.otherBookRewardInfo, delay:  null);
    }
    private void OnProgressBarClicked()
    {
        TheLibraryUI.ShowTheLibrary(onCloseAction:  0);
    }
    private void OnLibraryButtonClicked()
    {
        TheLibraryUI.ShowTheLibrary(onCloseAction:  0);
    }
    private void OnContinueButtonClicked()
    {
        this.ShowBookOptions();
    }
    private void ShowBookOptions()
    {
        System.Collections.Generic.List<BookInfo> val_7;
        var val_8;
        this.levelCompletePopupParent.HideUpperUI(fadeOutDuration:  null, delay:  null);
        this.levelCompletePopupParent.FadeOutAndDisableGroup(group:  this.otherBookRewardInfo, duration:  null);
        this.levelCompletePopupParent.FadeOutAndDisableGroup(group:  this.largeBookRewardGroup, duration:  null);
        twelvegigs.Autopilot.WUTAutopilotGameplay val_1 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<twelvegigs.Autopilot.WUTAutopilotGameplay>(child:  this.rewardedBookDisplay);
        this.rewardedBookDisplay.FadeOutAndDisableGroup(group:  this.rewardedBookDisplay, duration:  null);
        System.Collections.Generic.List<BookInfo> val_2 = TheLibraryLogic.GetBookChoices(currentBookIndex:  0);
        this.availableBookOptions = 0;
        val_7 = 0;
        val_8 = 4;
        goto label_4;
        label_22:
        LibraryBookDisplay val_7 = this.bookOptions[0];
        if(0 <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_7.Setup(info:  2621443);
        if(val_7 <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        string val_3 = TheLibraryLogic.GetProgressForCollection(collectionName:  406888448, showCompletedState:  false);
        string val_4 = System.String.Format(format:  1592589744, arg0:  406888448, arg1:  406888448);
        val_7 = this.availableBookOptions;
        val_8 = 5;
        label_4:
        if(1 < this.bookOptionCollectionProgress[0])
        {
            goto label_22;
        }
        
        UnityEngine.GameObject val_5 = this.chooseNextBookDisplay.gameObject;
        this.chooseNextBookDisplay.SetActive(value:  true);
        DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.chooseNextBookDisplay, endValue:  null, duration:  null);
    }
    private void OnBookOptionClicked(int chosenIndex)
    {
        var val_8;
        var val_9;
        val_8 = 0;
        goto label_1;
        label_7:
        UnityEngine.UI.Button val_8 = this.bookOptionButtons[val_8];
        this.bookOptionButtons[0x0][0].m_OnClick.RemoveAllListeners();
        val_8 = 1;
        label_1:
        if(val_8 < this.bookOptionButtons[0x0][0].m_OnClick)
        {
            goto label_7;
        }
        
        if(this.bookOptionButtons[0x0][0].m_OnClick <= chosenIndex)
        {
                var val_9 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_9 = val_9 + (chosenIndex << 2);
        TheLibraryLogic.CurrentBookUnlockTarget = (0 + (chosenIndex) << 2) + 16 + 8;
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
        string val_2 = TheLibraryLogic.CurrentBookUnlockTarget;
        TheLibraryLogic.PostCurrentUnlockTarget(sku:  null);
        LibraryBookDisplay val_10 = this.bookOptions[chosenIndex];
        UnityEngine.Transform val_3 = val_10.transform;
        UnityEngine.Transform val_4 = this.bookAnimationGroup.transform;
        val_10.parent = this.bookAnimationGroup;
        val_10.FadeOutAndDisableGroup(group:  this.chooseNextBookDisplay, duration:  null);
        LibraryBookDisplay val_11 = this.bookOptions[chosenIndex];
        val_9 = 0;
        UnityEngine.Transform val_5 = val_11.transform;
        if(val_11 != 0)
        {
                if(null != null)
        {
                val_11 = 0;
        }
        
            val_9 = val_11;
        }
        
        this.AnimateBook(book:  0, target:  this.bookRewardProgressBarXfm, duration:  null);
        Player val_6 = App.Player;
        this.chapterBookProgressBar.Setup(playerLevel:  1, showIncomplete:  true);
        DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.progressBarCanvasGroup, endValue:  null, duration:  null);
        this.levelCompletePopupParent.ShowUpperUI(fadeInDuration:  null, delay:  null);
        this.Invoke(methodName:  -1711978912, time:  null);
    }
    private void ShowFinalScreen()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1711632880, method:  new IntPtr(2583301200));
        this.tapToContinueButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.GameObject val_2 = this.tapToContinueButton.gameObject;
        this.tapToContinueButton.SetActive(value:  true);
        DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.tapToContinueCanvasGroup, endValue:  null, duration:  null);
    }
    private void HandleWindowConcluded()
    {
        if(this.levelCompletePopupParent == 0)
        {
            
        }
    
    }
    public ChapterBookLevelCompleteDisplay()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.availableBookOptions = null;
    }

}
