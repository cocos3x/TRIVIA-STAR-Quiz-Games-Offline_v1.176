using UnityEngine;
public class WordPetsFTUXDemoWindow : FTUXDemoWindow
{
    // Fields
    private UnityEngine.UI.Text tutorialText;
    private UnityEngine.UI.Image handCursor;
    private UnityEngine.Vector2 cursorPosOffset;
    private UnityEngine.Vector2 cursorBounce;
    private UnityEngine.RectTransform bubbleObject;
    private UnityEngine.UI.Text bubbleLabel;
    private UnityEngine.UI.Button bubbleButton;
    private UnityEngine.RectTransform bubbleTailTop;
    private UnityEngine.RectTransform bubbleTailBottom;
    private UnityEngine.UI.Button skipButton;
    private UnityEngine.GameObject howToPlayText;
    private UnityEngine.UI.Text descriptionText;
    private UnityEngine.RectOffset screenPaddingForBubbleObject;
    private UnityEngine.Vector2 speechBubbleOffsetBottom;
    private UnityEngine.Vector2 speechBubbleOffsetTop;
    private UnityEngine.RectOffset bubbleTailPadding;
    private WordPets.FtuxId currentFtux;
    private bool proceed;
    private DG.Tweening.Tweener cursorSeq;
    private DG.Tweening.Sequence cursorIdleSeq;
    private UnityEngine.Transform cursorTarget;
    private UnityEngine.Transform currentTargetTile;
    
    // Properties
    public bool CanProceed { get; }
    
    // Methods
    public bool get_CanProceed()
    {
        return (bool)this.proceed;
    }
    public static bool CanShow()
    {
        var val_14;
        WordPets.WPTPlayer val_1 = WordPets.WPTPlayer.Instance;
        if((MonoExtensions.IsBitSet(value:  1685382482, bit:  3)) != true)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_14 = 1;
            if((GetTilesWithCrate(tilesWithProperty: out  System.Collections.Generic.List<WordPets.WPTGameTile> val_4 = 124833980)) == true)
        {
                return (bool)val_14;
        }
        
        }
        
        if((MonoExtensions.IsBitSet(value:  1685382482, bit:  4)) != true)
        {
                twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_14 = 1;
            if((GetTilesWithBalloon(tilesWithProperty: out  System.Collections.Generic.List<WordPets.WPTGameTile> val_8 = 124833980)) == true)
        {
                return (bool)val_14;
        }
        
        }
        
        if((MonoExtensions.IsBitSet(value:  1685382482, bit:  5)) != false)
        {
                val_14 = 0;
            return (bool)val_14;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((GetTilesWithSpiderWeb(tilesWithProperty: out  System.Collections.Generic.List<WordPets.WPTGameTile> val_12 = 124833980)) == false)
        {
                val_14 = 0;
        }
        
        return (bool)val_14;
    }
    public static bool WasTutorialShown(WordPets.FtuxId ftux)
    {
        WordPets.WPTPlayer val_1 = WordPets.WPTPlayer.Instance;
        if(0 != 0)
        {
                return MonoExtensions.IsBitSet(value:  1685382482, bit:  ftux);
        }
        
        return MonoExtensions.IsBitSet(value:  1685382482, bit:  ftux);
    }
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  125096624, method:  new IntPtr(125062384));
        this.bubbleButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  125096624, method:  new IntPtr(125071600));
        this.skipButton.m_OnClick.AddListener(call:  162246656);
    }
    private void OnEnable()
    {
        if(this.currentFtux != 0)
        {
                return;
        }
        
        this.ToggleFtux();
    }
    public bool Proceed(UnityEngine.Transform target)
    {
        UnityEngine.Transform val_4;
        bool val_5;
        val_4 = 35626107;
        if(target != 0)
        {
                val_4 = this.currentTargetTile;
            if(val_4 != 0)
        {
                val_4 = this.currentTargetTile;
            val_5 = 0;
            if(target != val_4)
        {
                return val_5;
        }
        
        }
        
        }
        
        val_5 = true;
        this.proceed = val_5;
        return val_5;
    }
    private void CloseWindow()
    {
        if(this.currentFtux != 0)
        {
                WordPets.WPTPlayer val_1 = WordPets.WPTPlayer.Instance;
            WordPets.WPTPlayer val_2 = WordPets.WPTPlayer.Instance;
            mem[276] = MonoExtensions.SetBit(value:  1685382482, bit:  this.currentFtux);
        }
        
        WordPets.WPTPlayer val_4 = WordPets.WPTPlayer.Instance;
        0.SaveState();
        this.currentFtux = 0;
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_6 = new System.Action(object:  125490992, method:  new IntPtr(125465968));
        CloseOverlay(onClosed:  7454720);
    }
    private void ToggleFtux()
    {
        var val_16;
        var val_17;
        WordPets.WPTPlayer val_1 = WordPets.WPTPlayer.Instance;
        if((MonoExtensions.IsBitSet(value:  1685382482, bit:  1)) != true)
        {
                Player val_3 = App.Player;
            val_16 = 0;
            if(val_16 == 1)
        {
                this.currentFtux = 1;
            this.TriggerLevelOne();
            return;
        }
        
        }
        
        if((MonoExtensions.IsBitSet(value:  1685382482, bit:  2)) != true)
        {
                Player val_5 = App.Player;
            val_16 = 0;
            if(val_16 == 2)
        {
                this.currentFtux = 2;
            this.CloseWindow();
            return;
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_16 = public static WordPets.WPTGameUIController MonoSingleton<WordPets.WPTGameUIController>::get_Instance();
        if(((MonoExtensions.IsBitSet(value:  1685382482, bit:  3)) != true) && ((GetTilesWithCrate(tilesWithProperty: out  System.Collections.Generic.List<WordPets.WPTGameTile> val_8 = 125599700)) != false))
        {
                this.currentFtux = 3;
            val_17 = "Remove Crates by using adjacent letters!";
        }
        else
        {
                if(((MonoExtensions.IsBitSet(value:  1685382482, bit:  4)) != true) && ((GetTilesWithBalloon(tilesWithProperty: out  System.Collections.Generic.List<WordPets.WPTGameTile> val_11 = 125599700)) != false))
        {
                this.currentFtux = 4;
            val_17 = "When Balloons have nothing on top, they float away, taking any pets with them!";
        }
        else
        {
                if((MonoExtensions.IsBitSet(value:  1685382482, bit:  5)) == true)
        {
                return;
        }
        
            if((GetTilesWithSpiderWeb(tilesWithProperty: out  System.Collections.Generic.List<WordPets.WPTGameTile> val_14 = 125599700)) == false)
        {
                return;
        }
        
            this.currentFtux = 5;
            val_17 = "Clear Spider Webs by using adjacent letters!";
        }
        
        }
        
        this.TriggerSpecialTileSequence(message:  125587568, tileList:  0, focalSpeechBubbleTile:  0);
    }
    private void TriggerLevelOne()
    {
        var val_11;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BlockRaycasts = false;
        Interactable = false;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Color val_4 = UnityEngine.Color.clear;
        System.Nullable<UnityEngine.Color> val_5 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {a = ???});
        SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_5.HasValue}, fadeInDuration:  val_4.r, fadeOutDuration:  val_4.g);
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_11 = mem[public static T[] System.Array::Empty<UnityEngine.Transform>().__il2cppRuntimeField_18 + 186];
        val_11 = public static T[] System.Array::Empty<UnityEngine.Transform>().__il2cppRuntimeField_18 + 186;
        if(val_11 == 1)
        {
                val_11 = mem[public static T[] System.Array::Empty<UnityEngine.Transform>().__il2cppRuntimeField_18 + 186];
            val_11 = public static T[] System.Array::Empty<UnityEngine.Transform>().__il2cppRuntimeField_18 + 186;
        }
        
        ShowOverlay(contentToOverlay:  public static T[] System.Array::Empty<UnityEngine.Transform>().__il2cppRuntimeField_18 + 92);
        System.Collections.IEnumerator val_9 = this.LevelOneSequence();
        UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  125723728);
    }
    private System.Collections.IEnumerator LevelOneSequence()
    {
        object val_1 = new System.Object();
        typeof(WordPetsFTUXDemoWindow.<LevelOneSequence>d__32).__il2cppRuntimeField_8 = 0;
        typeof(WordPetsFTUXDemoWindow.<LevelOneSequence>d__32).__il2cppRuntimeField_10 = this;
    }
    private void TriggerLevelTwo()
    {
        this.CloseWindow();
    }
    private void TriggerSpecialTileSequence(string message, System.Collections.Generic.List<WordPets.WPTGameTile> tileList, WordPets.WPTGameTile focalSpeechBubbleTile)
    {
        WordPets.WPTGameTile val_13;
        this.EnableScreenWideInputBlocker();
        if(null >= 1)
        {
                if(null <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            UnityEngine.GameObject val_1 = 2621443.gameObject;
            UnityEngine.Transform val_2 = 2621443.transform;
            typeof(UnityEngine.Transform[]).__il2cppRuntimeField_10 = 2621443;
            var val_3 = 4 + 1;
            var val_4 = 4 - 3;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Color val_6 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        System.Nullable<UnityEngine.Color> val_7 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.r});
        SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_7.HasValue}, fadeInDuration:  null, fadeOutDuration:  null);
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ShowOverlay(contentToOverlay:  -2028557104);
        val_13 = focalSpeechBubbleTile;
        if(val_13 == 0)
        {
                val_13 = typeof(UnityEngine.Transform[]).__il2cppRuntimeField_10;
        }
        
        UnityEngine.Transform val_12 = val_13.transform;
        this.ShowSpeechBubble(bodyText:  message, targetTransform:  2621443, tailBottom:  true);
        System.Collections.IEnumerator val_13 = this.WaitForContinueClose();
        UnityEngine.Coroutine val_14 = this.StartCoroutine(routine:  126072016);
    }
    private System.Collections.IEnumerator WaitForContinueClose()
    {
        object val_1 = new System.Object();
        typeof(WordPetsFTUXDemoWindow.<WaitForContinueClose>d__35).__il2cppRuntimeField_8 = 0;
        typeof(WordPetsFTUXDemoWindow.<WaitForContinueClose>d__35).__il2cppRuntimeField_10 = this;
    }
    public void OnContinueButtonClicked()
    {
        this.proceed = true;
    }
    public void OnSkipButtonClicked()
    {
        WordPets.WPTPlayer val_1 = WordPets.WPTPlayer.Instance;
        WordPets.WPTPlayer val_2 = WordPets.WPTPlayer.Instance;
        mem[276] = MonoExtensions.UnsetBit(value:  1685382482, bit:  7);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SkipFTUX();
        this.CloseWindow();
    }
    private void EnableScreenWideInputBlocker()
    {
        var val_9;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        BlockRaycasts = true;
        Interactable = true;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Color val_4 = UnityEngine.Color.clear;
        System.Nullable<UnityEngine.Color> val_5 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color());
        SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_5.HasValue}, fadeInDuration:  val_4.r, fadeOutDuration:  val_4.g);
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_9 = mem[public static T[] System.Array::Empty<UnityEngine.Transform>().__il2cppRuntimeField_18 + 186];
        val_9 = public static T[] System.Array::Empty<UnityEngine.Transform>().__il2cppRuntimeField_18 + 186;
        if(val_9 == 1)
        {
                val_9 = mem[public static T[] System.Array::Empty<UnityEngine.Transform>().__il2cppRuntimeField_18 + 186];
            val_9 = public static T[] System.Array::Empty<UnityEngine.Transform>().__il2cppRuntimeField_18 + 186;
        }
        
        ShowOverlay(contentToOverlay:  public static T[] System.Array::Empty<UnityEngine.Transform>().__il2cppRuntimeField_18 + 92);
    }
    private void PointCursor(UnityEngine.Transform targetTransform)
    {
        float val_10;
        float val_11;
        float val_12;
        float val_14;
        float val_15;
        float val_16;
        float val_26;
        float val_27;
        float val_28;
        float val_29;
        if(this.cursorSeq != 0)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.cursorSeq, complete:  false);
        }
        
        if(this.cursorIdleSeq != 0)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.cursorIdleSeq, complete:  false);
        }
        
        UnityEngine.GameObject val_1 = this.handCursor.gameObject;
        val_26 = 1;
        if(this.handCursor.activeSelf != false)
        {
                UnityEngine.Color val_3 = color;
            if(this.handCursor <= 0)
        {
                val_26 = 1;
        }
        
        }
        
        UnityEngine.GameObject val_5 = this.handCursor.gameObject;
        this.handCursor.SetActive(value:  true);
        if(1 == 0)
        {
                if(this.cursorTarget != 0)
        {
                UnityEngine.Transform val_7 = this.handCursor.transform;
            UnityEngine.Vector3 val_8 = position;
            this.handCursor.position = new UnityEngine.Vector3();
        }
        
        }
        
        this.cursorTarget = targetTransform;
        val_27 = 0;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 2.12278E-34f, y = this.cursorPosOffset});
        if(targetTransform != 0)
        {
                if(null == null)
        {
            goto label_19;
        }
        
        }
        
        if(targetTransform != 0)
        {
                label_19:
            if(null != null)
        {
                val_27 = 0;
        }
        else
        {
                val_27 = targetTransform;
        }
        
        }
        
        UnityEngine.Vector3 val_13 = TransformPoint(position:  new UnityEngine.Vector3() {x = val_27, y = val_11, z = val_12});
        val_28 = val_14;
        val_29 = val_15;
        UnityEngine.Transform val_17 = this.handCursor.transform;
        if(1 != 0)
        {
                this.handCursor.position = new UnityEngine.Vector3() {x = val_28, y = val_29, z = val_16};
            UnityEngine.Color val_18 = color;
            val_28 = this.handCursor;
            val_26 = val_11;
            val_29 = val_10;
            val_28.color = new UnityEngine.Color() {r = val_26, g = val_12, b = val_29, a = 0f};
            DG.Tweening.Tweener val_19 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.handCursor, endValue:  val_18.r, duration:  val_18.g);
            object val_20 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.handCursor, ease:  1);
            DG.Tweening.TweenCallback val_21 = new DG.Tweening.TweenCallback(object:  126698576, method:  new IntPtr(126673552));
            object val_22 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.handCursor, action:  190734336);
            return;
        }
        
        DG.Tweening.Tweener val_23 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.handCursor, endValue:  new UnityEngine.Vector3() {x = val_28, y = val_29, z = val_16}, duration:  val_13.x, snapping:  true);
        DG.Tweening.TweenCallback val_24 = new DG.Tweening.TweenCallback(object:  126698576, method:  new IntPtr(126673552));
        object val_25 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.handCursor, action:  190734336);
        this.cursorSeq = this.handCursor;
    }
    private void SetIdleSequence()
    {
        float val_4;
        float val_8;
        float val_9;
        float val_17;
        float val_18;
        UnityEngine.Transform val_24;
        float val_25;
        DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
        this.cursorIdleSeq = 0;
        UnityEngine.Transform val_2 = this.handCursor.transform;
        val_24 = this.cursorTarget;
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 2.166364E-34f, y = this.cursorPosOffset}, b:  new UnityEngine.Vector2() {x = R5, y = this.cursorBounce});
        UnityEngine.Vector3 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 2.166361E-34f, y = val_4});
        if(val_24 != 0)
        {
                if(null == null)
        {
            goto label_7;
        }
        
        }
        
        if(val_24 == 0)
        {
            goto label_8;
        }
        
        label_7:
        if(null == null)
        {
            goto label_9;
        }
        
        label_8:
        val_24 = 0;
        label_9:
        UnityEngine.Vector3 val_10 = TransformPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_8, z = val_9});
        DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.handCursor, endValue:  new UnityEngine.Vector3(), duration:  val_10.x, snapping:  true);
        object val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.handCursor, ease:  7);
        DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.handCursor);
        val_25 = 0;
        UnityEngine.Transform val_14 = this.handCursor.transform;
        UnityEngine.Vector3 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 2.166355E-34f, y = this.cursorPosOffset});
        if(this.cursorTarget != 0)
        {
                if(null == null)
        {
            goto label_12;
        }
        
        }
        
        if(this.cursorTarget != 0)
        {
                label_12:
            if(null != null)
        {
                val_25 = 0;
        }
        else
        {
                val_25 = this.cursorTarget;
        }
        
        }
        
        UnityEngine.Vector3 val_19 = TransformPoint(position:  new UnityEngine.Vector3() {x = val_25, y = val_17, z = val_18});
        DG.Tweening.Tweener val_20 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.handCursor, endValue:  new UnityEngine.Vector3(), duration:  val_19.x, snapping:  true);
        object val_21 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.handCursor, ease:  7);
        DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.cursorIdleSeq, t:  this.handCursor);
        object val_23 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  this.cursorIdleSeq, loops:  0, loopType:  0);
    }
    private void ShowSpeechBubble(string bodyText, UnityEngine.Transform targetTransform, bool tailBottom = True)
    {
        float val_6;
        float val_10;
        float val_11;
        float val_14;
        float val_15;
        float val_18;
        float val_19;
        float val_21;
        float val_22;
        float val_28;
        float val_29;
        float val_30;
        float val_32;
        float val_33;
        float val_38;
        float val_39;
        float val_40;
        var val_42;
        var val_43;
        var val_50;
        var val_51;
        var val_58;
        var val_59;
        float val_64;
        float val_65;
        float val_92;
        bool val_93;
        var val_94;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Transform val_2 = this.bubbleObject.transform;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_10 = this.bubbleObject;
        ShowOverlay(contentToOverlay:  -2028557104);
        UnityEngine.Canvas val_3 = this.bubbleLabel.canvas;
        UnityEngine.Transform val_4 = this.bubbleLabel.transform;
        val_92 = this.bubbleLabel;
        if(this.bubbleLabel != 0)
        {
                if(null != null)
        {
            
        }
        
        }
        
        if(tailBottom != false)
        {
                if(val_92 != 0)
        {
                if(null == null)
        {
            goto label_17;
        }
        
        }
        
            val_92 = 0;
        }
        else
        {
                val_92 = val_92;
        }
        
        label_17:
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 2.220276E-34f, y = val_6});
        UnityEngine.Vector3 val_12 = TransformPoint(position:  new UnityEngine.Vector3() {x = targetTransform, y = val_10, z = val_11});
        UnityEngine.Vector3 val_16 = InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_92, y = val_14, z = val_15});
        UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 2.220269E-34f});
        UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 2.220267E-34f, y = val_18}, b:  new UnityEngine.Vector2() {x = val_19, y = mem[this.speechBubbleOffsetTop + (0)]});
        this.bubbleObject.anchoredPosition = new UnityEngine.Vector2() {x = val_21, y = val_22};
        UnityEngine.GameObject val_23 = this.bubbleObject.gameObject;
        this.bubbleObject.SetActive(value:  true);
        UnityEngine.Vector2 val_24 = anchoredPosition;
        UnityEngine.Rect val_25 = rect;
        UnityEngine.Vector2 val_26 = min;
        UnityEngine.Vector2 val_31 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 2.220261E-34f, y = val_28}, b:  new UnityEngine.Vector2() {x = val_29, y = val_30});
        UnityEngine.Vector2 val_34 = anchoredPosition;
        UnityEngine.Rect val_35 = rect;
        UnityEngine.Vector2 val_36 = max;
        UnityEngine.Vector2 val_41 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 2.220252E-34f, y = val_38}, b:  new UnityEngine.Vector2() {x = val_39, y = val_40});
        UnityEngine.Rect val_44 = rect;
        UnityEngine.Vector2 val_45 = min;
        int val_47 = this.screenPaddingForBubbleObject.bottom;
        UnityEngine.Vector2 val_48 = new UnityEngine.Vector2(x:  (float)this.screenPaddingForBubbleObject.left, y:  val_45.y);
        UnityEngine.Vector2 val_49 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 2.220243E-34f}, b:  new UnityEngine.Vector2() {y = val_48.x});
        UnityEngine.Rect val_52 = rect;
        UnityEngine.Vector2 val_53 = max;
        int val_55 = this.screenPaddingForBubbleObject.top;
        UnityEngine.Vector2 val_56 = new UnityEngine.Vector2(x:  (float)this.screenPaddingForBubbleObject.right, y:  val_53.y);
        UnityEngine.Vector2 val_57 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 2.220233E-34f}, b:  new UnityEngine.Vector2() {y = val_56.x});
        if(this.screenPaddingForBubbleObject < 0)
        {
                UnityEngine.Vector2 val_60 = anchoredPosition;
            UnityEngine.Vector2 val_62 = new UnityEngine.Vector2(x:  val_50 - val_32, y:  val_60.y);
            UnityEngine.Vector2 val_63 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 2.220248E-34f, y = val_32}, b:  new UnityEngine.Vector2() {x = val_33, y = val_62.x});
            this.bubbleObject.anchoredPosition = new UnityEngine.Vector2() {x = val_64, y = val_65};
        }
        
        if(this.bubbleObject > 0)
        {
                UnityEngine.Vector2 val_66 = anchoredPosition;
            UnityEngine.Vector2 val_68 = new UnityEngine.Vector2(x:  val_42 - val_58, y:  val_66.y);
            UnityEngine.Vector2 val_69 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 2.220248E-34f, y = val_32}, b:  new UnityEngine.Vector2() {x = val_33, y = val_68.x});
            this.bubbleObject.anchoredPosition = new UnityEngine.Vector2() {x = val_64, y = val_65};
        }
        
        if(this.bubbleObject < 0)
        {
                UnityEngine.Vector2 val_70 = anchoredPosition;
            UnityEngine.Vector2 val_72 = new UnityEngine.Vector2(x:  val_51 - val_33, y:  val_70.y);
            UnityEngine.Vector2 val_73 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 2.220248E-34f, y = val_32}, b:  new UnityEngine.Vector2() {x = val_33, y = val_72.x});
            this.bubbleObject.anchoredPosition = new UnityEngine.Vector2() {x = val_64, y = val_65};
        }
        
        if(this.bubbleObject > 0)
        {
                UnityEngine.Vector2 val_74 = anchoredPosition;
            UnityEngine.Vector2 val_76 = new UnityEngine.Vector2(x:  val_43 - val_59, y:  val_74.y);
            UnityEngine.Vector2 val_77 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 2.220248E-34f, y = val_32}, b:  new UnityEngine.Vector2() {x = val_33, y = val_76.x});
            this.bubbleObject.anchoredPosition = new UnityEngine.Vector2() {x = val_64, y = val_65};
        }
        
        UnityEngine.Vector2 val_78 = val_76.x.anchoredPosition;
        UnityEngine.Vector2 val_79 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 2.220248E-34f, y = val_21}, b:  new UnityEngine.Vector2() {x = val_22, y = val_76.x});
        UnityEngine.Rect val_80 = rect;
        float val_81 = width;
        float val_82 = 127111200 * 0.5f;
        if(this.bubbleObject < 0)
        {
                val_93 = tailBottom;
            val_94 = val_64;
            float val_92 = (float)this.bubbleTailPadding.left;
            val_92 = val_92 - val_82;
            float val_84 = UnityEngine.Mathf.Max(a:  val_92, b:  val_80.m_YMin);
        }
        else
        {
                val_93 = tailBottom;
            val_94 = val_64;
            float val_93 = (float)this.bubbleTailPadding.right;
            val_93 = val_82 - val_93;
            float val_86 = UnityEngine.Mathf.Min(a:  val_93, b:  val_80.m_YMin);
        }
        
        UnityEngine.GameObject val_87 = this.bubbleTailBottom.gameObject;
        this.bubbleTailBottom.SetActive(value:  val_93);
        UnityEngine.GameObject val_88 = this.bubbleTailTop.gameObject;
        this.bubbleTailTop.SetActive(value:  val_93 ^ 1);
        UnityEngine.Vector2 val_90 = anchoredPosition;
        UnityEngine.Vector2 val_91 = new UnityEngine.Vector2(x:  val_90.x, y:  val_90.y);
        this.bubbleTailBottom.anchoredPosition = new UnityEngine.Vector2() {x = val_91.x, y = val_91.y};
    }
    public WordPetsFTUXDemoWindow()
    {
        UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  null, y:  null);
        this.cursorPosOffset = val_1.x;
        UnityEngine.Vector2 val_2;
        mem[1152921513324115176] = val_1.y;
        val_2 = new UnityEngine.Vector2(x:  null, y:  null);
        this.cursorBounce = val_2.x;
        mem[1152921513324115184] = val_2.y;
    }
    private void <CloseWindow>b__29_0()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  127445584, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private bool <LevelOneSequence>b__32_0()
    {
        return (bool)this.proceed;
    }
    private bool <LevelOneSequence>b__32_1()
    {
        return (bool)this.proceed;
    }
    private bool <LevelOneSequence>b__32_2()
    {
        return (bool)this.proceed;
    }
    private bool <LevelOneSequence>b__32_3()
    {
        return (bool)this.proceed;
    }
    private bool <LevelOneSequence>b__32_4()
    {
        return (bool)this.proceed;
    }
    private bool <LevelOneSequence>b__32_5()
    {
        return (bool)this.proceed;
    }
    private bool <LevelOneSequence>b__32_6()
    {
        return (bool)this.proceed;
    }
    private bool <LevelOneSequence>b__32_7()
    {
        return (bool)this.proceed;
    }
    private bool <LevelOneSequence>b__32_8()
    {
        return (bool)this.proceed;
    }
    private bool <WaitForContinueClose>b__35_0()
    {
        return (bool)this.proceed;
    }

}
