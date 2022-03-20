using UnityEngine;
public class WordAddictFTUXDemoWindow : FTUXDemoWindow
{
    // Fields
    protected UnityEngine.UI.Image handCursor;
    protected UnityEngine.RectTransform[] maskActionStep1;
    protected UnityEngine.RectTransform[] maskActionStep2;
    protected UnityEngine.GameObject SkipTutorialBtn;
    protected UnityEngine.Transform bottom_left;
    private UnityEngine.Transform top;
    private UnityEngine.Transform bottom_right;
    protected int padding;
    private const string CURRENT_LANGUAGE_TUTORIAL = "current_language_tutorial";
    protected const string EN = "en";
    private const string ES = "es";
    private const string FR = "fr";
    private const string DE = "de";
    protected const int L = 0;
    protected const int O = 1;
    protected const int S = 2;
    protected const int G = 0;
    protected const int U = 0;
    protected const int N = 1;
    protected const int A = 2;
    protected const int B = 0;
    protected System.Collections.Generic.List<UnityEngine.Transform> allowedPoints;
    protected UnityEngine.Transform initial;
    protected int state;
    protected string currentLanguage;
    private DG.Tweening.Sequence cursorSeq;
    protected UnityEngine.GameObject dummySkipButton;
    
    // Properties
    protected virtual int M { get; }
    protected virtual int Y { get; }
    protected virtual int D { get; }
    protected virtual int E { get; }
    
    // Methods
    protected virtual int get_M()
    {
        return 1;
    }
    protected virtual int get_Y()
    {
        return 2;
    }
    protected virtual int get_D()
    {
        return 1;
    }
    protected virtual int get_E()
    {
        return 2;
    }
    private void OnEnable()
    {
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        this.currentLanguage = 0;
        string val_3 = UnityEngine.PlayerPrefs.GetString(key:  89682112, defaultValue:  1800251696);
        if((System.String.op_Inequality(a:  null, b:  89682112)) != false)
        {
                this.state = 1;
            UnityEngine.PlayerPrefs.SetString(key:  89682112, value:  this.currentLanguage);
        }
        else
        {
                this.state = UnityEngine.PlayerPrefs.GetInt(key:  -367594080, defaultValue:  1);
        }
        
        WordRegion val_6 = WordRegion.instance;
        System.Action<twelvegigs.storage.JsonDictionary> val_7 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  89711360, method:  new IntPtr(89686336));
        0.addOnWordFoundAction(callback:  7401472);
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Color val_9 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        System.Nullable<UnityEngine.Color> val_10 = new System.Nullable<UnityEngine.Color>(value:  new UnityEngine.Color() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.r});
        SetOptions(bgColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_10.HasValue}, fadeInDuration:  null, fadeOutDuration:  null);
    }
    private void OnWordFound(string word)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_2 = new System.Action(object:  89840768, method:  new IntPtr(89807552));
        CloseOverlay(onClosed:  7454720);
        if(this.cursorSeq != 0)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.cursorSeq, complete:  false);
        }
        
        UnityEngine.GameObject val_3 = this.handCursor.gameObject;
        this.handCursor.SetActive(value:  false);
        UnityEngine.PlayerPrefs.SetInt(key:  -367594080, value:  this.state);
        bool val_4 = PrefsSerializationManager.SavePlayerPrefs();
        this.StopAllCoroutines();
        System.Collections.IEnumerator val_5 = this.ProgressSoon(seconds:  null);
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  89840768);
    }
    private System.Collections.IEnumerator ProgressSoon(float seconds = 1.1)
    {
        if((new WordAddictFTUXDemoWindow.<ProgressSoon>d__37(<>1__state:  0)) != 0)
        {
                typeof(WordAddictFTUXDemoWindow.<ProgressSoon>d__37).__il2cppRuntimeField_14 = this;
        }
        else
        {
                mem[20] = this;
        }
        
        typeof(WordAddictFTUXDemoWindow.<ProgressSoon>d__37).__il2cppRuntimeField_10 = R1;
    }
    protected virtual void UpdateState(string word)
    {
        int val_1 = this.state;
        val_1 = val_1 + 1;
        this.state = val_1;
    }
    protected virtual void Progress()
    {
        float val_10;
        float val_13;
        float val_18;
        float val_19;
        var val_38;
        var val_39;
        System.Predicate<LetterTile> val_41;
        var val_42;
        var val_44;
        System.Predicate<LetterTile> val_46;
        var val_47;
        MainController val_1 = MainController.instance;
        if(0 != 0)
        {
                MainController val_3 = MainController.instance;
            if(3 != 0)
        {
                3 = 5;
            this.state = 3;
        }
        
        }
        
        WordRegion val_4 = WordRegion.instance;
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        GameBehavior val_6 = App.getBehavior;
        string val_7 = 0.GetCurrentLanguage();
        if(0 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        UnityEngine.Transform val_8 = static_value_00280017 + 8 + 16.transform;
        if((static_value_00280017 + 8 + 16) != null)
        {
                val_38 = 0;
        }
        
        UnityEngine.Vector2 val_9 = sizeDelta;
        var val_38 = val_10;
        UnityEngine.Transform val_11 = 0.transform;
        UnityEngine.Vector3 val_12 = localScale;
        val_38 = val_38 * val_13;
        if(this.state == 2)
        {
            goto label_29;
        }
        
        if(this.state != 1)
        {
            goto label_30;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.SkipTutorialBtn.SetActive(value:  DisplaySkipTutorial);
        if(0 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        UnityEngine.Transform val_16 = static_value_00280017 + 8 + 16.transform;
        if(0 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        UnityEngine.Transform val_17 = static_value_00280017 + 8 + 20.transform;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_10 = static_value_00280017 + 8 + 16;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_14 = static_value_00280017 + 8 + 20;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_18 = this;
        ShowOverlay(contentToOverlay:  -2028557104);
        this.position = new UnityEngine.Vector3() {x = val_13, y = val_18, z = val_19};
        if(this == 0)
        {
            goto label_59;
        }
        
        this.sizeDelta = new UnityEngine.Vector2() {x = val_10, y = val_13};
        goto label_60;
        label_29:
        this.SkipTutorialBtn.SetActive(value:  false);
        NotificationCenter val_20 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  90225920, aName:  -2084758544);
        if(0 <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Transform val_21 = 2621443.transform;
        if(0 <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Transform val_22 = 1.transform;
        if(0 <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(0 <= 2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Transform val_23 = 0.transform;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_10 = 2621443;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_14 = 1;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_18 = 0;
        typeof(UnityEngine.Transform[]).__il2cppRuntimeField_1C = this;
        ShowOverlay(contentToOverlay:  -2028557104);
        UnityEngine.Vector3 val_24 = position;
        this.position = new UnityEngine.Vector3();
        if(this == 0)
        {
            goto label_99;
        }
        
        this.sizeDelta = new UnityEngine.Vector2() {x = val_10, y = val_13};
        goto label_100;
        label_30:
        UnityEngine.Transform val_25 = this.handCursor.transform;
        int val_26 = DG.Tweening.ShortcutExtensions.DOKill(target:  this.handCursor, complete:  false);
        UnityEngine.GameObject val_27 = this.handCursor.gameObject;
        this.handCursor.SetActive(value:  false);
        this.allowedPoints.Clear();
        this.initial = this.bottom_left;
        UnityEngine.PlayerPrefs.SetInt(key:  -367594080, value:  1);
        bool val_28 = PrefsSerializationManager.SavePlayerPrefs();
        this.CloseWindow();
        goto label_107;
        label_59:
        0.sizeDelta = new UnityEngine.Vector2() {x = val_10, y = val_13};
        label_60:
        UnityEngine.GameObject val_29 = this.gameObject;
        this.SetActive(value:  true);
        Player val_30 = App.Player;
        bool val_31 = System.String.op_Equality(a:  null, b:  1800251696);
        if(0 != 1)
        {
            goto label_112;
        }
        
        if(val_31 == false)
        {
            goto label_113;
        }
        
        val_39 = null;
        val_39 = null;
        val_41 = WordAddictFTUXDemoWindow.<>c.<>9__39_0;
        if(val_41 == 0)
        {
                val_41 = null;
            val_41 = new System.Predicate<ZooTile>(object:  WordAddictFTUXDemoWindow.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(90197824));
            WordAddictFTUXDemoWindow.<>c.<>9__39_0 = val_41;
        }
        
        int val_33 = Pan.tappingAllowed + 48.FindIndex(match:  8040448);
        val_42 = null;
        val_42 = null;
        if((WordAddictFTUXDemoWindow.<>c.<>9__39_1) != 0)
        {
            goto label_138;
        }
        
        System.Predicate<ZooTile> val_34 = new System.Predicate<ZooTile>(object:  WordAddictFTUXDemoWindow.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(90198848));
        WordAddictFTUXDemoWindow.<>c.<>9__39_1 = null;
        goto label_138;
        label_112:
        if(val_31 != false)
        {
                val_44 = null;
            val_44 = null;
            val_46 = WordAddictFTUXDemoWindow.<>c.<>9__39_8;
            if(val_46 == 0)
        {
                val_46 = null;
            val_46 = new System.Predicate<ZooTile>(object:  WordAddictFTUXDemoWindow.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(90199872));
            WordAddictFTUXDemoWindow.<>c.<>9__39_8 = val_46;
        }
        
            int val_36 = Pan.tappingAllowed + 48.FindIndex(match:  8040448);
            val_47 = null;
            val_47 = null;
            if((WordAddictFTUXDemoWindow.<>c.<>9__39_9) == 0)
        {
                System.Predicate<ZooTile> val_37 = new System.Predicate<ZooTile>(object:  WordAddictFTUXDemoWindow.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(90200896));
            WordAddictFTUXDemoWindow.<>c.<>9__39_9 = null;
        }
        
        }
    
    }
    protected void CloseWindow()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_2 = new System.Action(object:  90362496, method:  new IntPtr(89807552));
        CloseOverlay(forceImmediate:  true, onClosed:  7454720);
        UnityEngine.GameObject val_3 = this.gameObject;
        SLCWindow.CloseWindow(window:  90362496, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    protected void AnimateCursor()
    {
        UnityEngine.GameObject val_1 = this.handCursor.gameObject;
        this.handCursor.SetActive(value:  true);
        UnityEngine.Transform val_2 = this.handCursor.transform;
        int val_3 = DG.Tweening.ShortcutExtensions.DOKill(target:  this.handCursor, complete:  false);
        UnityEngine.Color val_4 = UnityEngine.Color.white;
        this.handCursor.color = new UnityEngine.Color() {a = ???};
        UnityEngine.RectTransform val_5 = this.handCursor.rectTransform;
        UnityEngine.RectTransform val_6 = this.handCursor.rectTransform;
        UnityEngine.Rect val_7 = rect;
        float val_8 = height;
        float val_36 = -0.5f;
        val_36 = 90491112 * val_36;
        UnityEngine.Vector3 val_9 = new UnityEngine.Vector3(x:  val_36, y:  val_7.m_YMin, z:  90491112);
        UnityEngine.Vector3 val_10 = TransformPoint(position:  new UnityEngine.Vector3() {x = this.handCursor, y = val_9.x, z = val_9.y});
        UnityEngine.RectTransform val_11 = this.handCursor.rectTransform;
        UnityEngine.Vector3 val_12 = position;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 1.075734E-35f, y = R4, z = R6}, b:  new UnityEngine.Vector3() {x = R7});
        UnityEngine.GameObject val_14 = this.handCursor.gameObject;
        UnityEngine.Transform val_15 = this.handCursor.transform;
        UnityEngine.Vector3 val_16 = position;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 1.075732E-35f}, b:  new UnityEngine.Vector3());
        this.handCursor.position = new UnityEngine.Vector3();
        System.Collections.Generic.List<UnityEngine.Vector3> val_18 = new System.Collections.Generic.List<UnityEngine.Vector3>();
        List.Enumerator<T> val_19 = GetEnumerator();
        label_23:
        if(MoveNext() == false)
        {
            goto label_18;
        }
        
        UnityEngine.Vector3 val_22 = position;
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 1.075737E-35f}, b:  new UnityEngine.Vector3());
        Add(item:  new UnityEngine.Vector3());
        goto label_23;
        label_18:
        Dispose();
        T[] val_24 = ToArray();
        DG.Tweening.Sequence val_25 = DG.Tweening.DOTween.Sequence();
        mem[1152921513287284796] = 0;
        object val_26 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<System.Object>(t:  0, autoKillOnCompletion:  true);
        DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.PrependInterval(s:  0, interval:  val_17.x);
        UnityEngine.Transform val_28 = this.handCursor.transform;
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> val_29 = DG.Tweening.ShortcutExtensions.DOPath(target:  this.handCursor, path:  80883712, duration:  1.094062E+09f, pathType:  1.094062E+09f, pathMode:  0, resolution:  1, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
        object val_30 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.handCursor, ease:  1);
        DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.handCursor);
        DG.Tweening.Tweener val_32 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.handCursor, endValue:  1.094062E+09f, duration:  val_17.y);
        DG.Tweening.Sequence val_33 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.handCursor);
        DG.Tweening.TweenCallback val_34 = new DG.Tweening.TweenCallback(object:  90503168, method:  new IntPtr(90478144));
        object val_35 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
    }
    private void OnCompleteCycle()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(this.activeSelf != false)
        {
                this.AnimateCursor();
            return;
        }
        
        this.StopAllCoroutines();
    }
    public void OnSkipTutorialClick()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SkipTutorial();
        this.CloseWindow();
    }
    private void OnOverlayClosed()
    {
        this.SkipTutorialBtn.SetActive(value:  false);
        if(this.dummySkipButton == 0)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  this.dummySkipButton);
    }
    protected virtual UnityEngine.RectTransform GetMaskWordRegion(int stepNum)
    {
        UnityEngine.RectTransform val_1;
        UnityEngine.RectTransform[] val_2;
        if(stepNum != 2)
        {
                val_1 = 0;
            if(stepNum != 1)
        {
                return;
        }
        
            val_2 = this.maskActionStep1;
        }
        else
        {
                val_2 = this.maskActionStep2;
        }
        
        val_1 = val_2[0];
    }
    protected virtual UnityEngine.RectTransform GetMaskPan(int stepNum)
    {
        UnityEngine.RectTransform val_1;
        UnityEngine.RectTransform[] val_2;
        if(stepNum != 2)
        {
                val_1 = 0;
            if(stepNum != 1)
        {
                return;
        }
        
            val_2 = this.maskActionStep1;
        }
        else
        {
                val_2 = this.maskActionStep2;
        }
        
        val_1 = val_2[1];
    }
    protected virtual UnityEngine.Vector3 GetWordRegionPosStep1(UnityEngine.Transform letterSlot1, UnityEngine.Transform letterSlot2)
    {
        var val_2;
        var val_4;
        UnityEngine.Vector3 val_1 = position;
        UnityEngine.Vector3 val_3 = position;
        UnityEngine.Vector3 val_5 = position;
        UnityEngine.Vector3 val_7 = position;
        float val_11 = 0.5f;
        float val_9 = val_2 + val_4;
        this = 0;
        mem[1152921513288325380] = 0;
        mem[1152921513288325384] = 0;
        val_11 = val_9 * val_11;
        this = new UnityEngine.Vector3(x:  val_11, y:  val_7.y, z:  val_9);
        return new UnityEngine.Vector3() {x = val_11, y = val_7.y, z = val_9};
    }
    protected virtual UnityEngine.Vector2 GetWordRegionSizeStep1(float cellSize)
    {
        var val_4 = R1 + 40;
        float val_5 = R2;
        float val_1 = val_5 + val_5;
        val_4 = val_4 << 1;
        this = 0;
        mem[1152921513288445572] = 0;
        val_1 = val_1 + ((float)val_4 << 2);
        val_5 = (float)val_4 + val_5;
        val_3 = new UnityEngine.Vector2(x:  val_5, y:  null);
        return new UnityEngine.Vector2() {x = val_5};
    }
    protected virtual UnityEngine.Vector2 GetWordRegionSizeStep2(float cellSize)
    {
        var val_3 = R1 + 40;
        val_3 = val_3 + (val_3 << 1);
        val_3 = val_3 << 1;
        float val_4 = (float)val_3 << 1;
        this = 0;
        mem[1152921513288557572] = 0;
        val_4 = val_4 + R2;
        val_2 = new UnityEngine.Vector2(x:  3f, y:  null);
        return new UnityEngine.Vector2() {x = 3f};
    }
    public WordAddictFTUXDemoWindow()
    {
        this.padding = 10;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.allowedPoints = null;
        this.state = 1;
        this.currentLanguage = "en";
    }

}
