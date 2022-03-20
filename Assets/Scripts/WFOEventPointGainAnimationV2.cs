using UnityEngine;
public class WFOEventPointGainAnimationV2 : MonoBehaviour
{
    // Fields
    public static bool IsActive;
    private EventButtonPanel eventButtonPanel;
    private UnityEngine.Sprite iconAttackMadness;
    private UnityEngine.Sprite iconRaidMadness;
    private UnityEngine.Sprite iconIslandParadise;
    private UnityEngine.UI.Image largePointImage;
    private UnityEngine.UI.Image prefabPointImage;
    private UnityEngine.Transform symbolPrefab;
    private UnityEngine.Transform symbolParent;
    private UnityEngine.Transform centralSymbolTransform;
    private UnityEngine.GameObject glow;
    private UnityEngine.UI.Text symbolCountText;
    private DG.Tweening.Ease easeX;
    private UnityEngine.AnimationCurve curveY;
    private float duration;
    private float symbolInterval;
    private float symbolScale;
    private int currentPoints;
    private int pendingPoints;
    private WFOEventPointType eventPointType;
    private WGEventButtonV2 progress;
    private UnityEngine.Transform target;
    private UnityEngine.Vector3 originalCentralSymbolPos;
    private System.Action onComplete;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Vector3 val_1 = position;
    }
    private void OnDisable()
    {
        WFOEventPointGainAnimationV2.IsActive = false;
    }
    private void OnEnable()
    {
        WFOEventPointGainAnimationV2.IsActive = true;
        this.ResetUI();
        System.Collections.IEnumerator val_1 = this.PointGainAnimation();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -385580608);
    }
    public void Setup(WFOEventPointType type, int points, int initialPoints, System.Action _onComplete)
    {
        this.currentPoints = initialPoints;
        this.pendingPoints = points;
        this.eventPointType = type;
        this.onComplete = _onComplete;
        WordRegion val_1 = WordRegion.instance;
        0.AddLevelCompleteBlocker(blocker:  3);
    }
    private void SetupEventIcons()
    {
        UnityEngine.UI.Image val_1;
        UnityEngine.Sprite val_2;
        if(this.eventPointType == 2)
        {
            goto label_0;
        }
        
        if(this.eventPointType == 1)
        {
            goto label_1;
        }
        
        if(this.eventPointType != 0)
        {
                return;
        }
        
        val_1 = this.largePointImage;
        val_1.sprite = this.iconAttackMadness;
        val_2 = this.iconAttackMadness;
        goto label_6;
        label_0:
        val_1 = this.largePointImage;
        val_1.sprite = this.iconIslandParadise;
        val_2 = this.iconIslandParadise;
        goto label_6;
        label_1:
        val_1 = this.largePointImage;
        val_1.sprite = this.iconRaidMadness;
        val_2 = this.iconRaidMadness;
        label_6:
        this.prefabPointImage.sprite = val_2;
    }
    private void SetupEventProgress()
    {
        var val_5;
        if(this.eventPointType <= 2)
        {
                val_5 = mem[34443788 + (this.eventPointType) << 2];
            val_5 = 34443788 + (this.eventPointType) << 2;
        }
        else
        {
                val_5 = "";
        }
        
        WGEventButtonV2 val_1 = this.eventButtonPanel.GetEventButton(eventId:  1098586544);
        this.progress = this.eventButtonPanel;
        string val_2 = this.currentPoints.ToString();
        if(this.progress.efxUpdate == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_4 = this.progress.efxUpdate.gameObject;
        this.progress.efxUpdate.SetActive(value:  true);
    }
    private System.Collections.IEnumerator PointGainAnimation()
    {
        object val_1 = new System.Object();
        typeof(WFOEventPointGainAnimationV2.<PointGainAnimation>d__30).__il2cppRuntimeField_8 = 0;
        typeof(WFOEventPointGainAnimationV2.<PointGainAnimation>d__30).__il2cppRuntimeField_10 = this;
    }
    private void Play(int symbolCount)
    {
        var val_23;
        DG.Tweening.TweenCallback val_25;
        if(new System.Object() != 0)
        {
                typeof(WFOEventPointGainAnimationV2.<>c__DisplayClass31_0).__il2cppRuntimeField_8 = this;
        }
        else
        {
                mem[8] = this;
        }
        
        typeof(WFOEventPointGainAnimationV2.<>c__DisplayClass31_0).__il2cppRuntimeField_C = symbolCount;
        this.SetupEventIcons();
        this.SetupEventProgress();
        string val_2 = -1467947360(-1467947360) + 13152256;
        string val_3 = this.currentPoints.ToString();
        UnityEngine.Transform val_4 = this.progress.icon.transform;
        this.target = this.progress.icon;
        DG.Tweening.Sequence val_5 = DG.Tweening.DOTween.Sequence();
        val_23 = null;
        val_23 = null;
        val_25 = WFOEventPointGainAnimationV2.<>c.<>9__31_0;
        if(val_25 == 0)
        {
                val_25 = null;
            val_25 = new DG.Tweening.TweenCallback(object:  WFOEventPointGainAnimationV2.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3910107008));
            WFOEventPointGainAnimationV2.<>c.<>9__31_0 = val_25;
        }
        
        DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -1.08727E+25f, y = typeof(WFOEventPointGainAnimationV2.<>c__DisplayClass31_0).__il2cppRuntimeField_C}, d:  this.symbolScale);
        DG.Tweening.Tweener val_10 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.centralSymbolTransform, endValue:  new UnityEngine.Vector3(), duration:  val_9.x);
        DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.centralSymbolTransform);
        UnityEngine.Transform val_12 = this.symbolCountText.transform;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_14 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.symbolCountText, endValue:  new UnityEngine.Vector3(), duration:  val_13.x);
        DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.symbolCountText);
        DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_13.x);
        UnityEngine.Transform val_17 = this.glow.transform;
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_19 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.glow, endValue:  new UnityEngine.Vector3(), duration:  val_18.x);
        DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.glow);
        DG.Tweening.TweenCallback val_21 = new DG.Tweening.TweenCallback(object:  367304704, method:  new IntPtr(3910120320));
        object val_22 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
    }
    private void TweenText(int count)
    {
        int val_13;
        int val_14;
        val_13 = count;
        object val_1 = new System.Object();
        if(val_1 != 0)
        {
                val_14 = val_1;
            typeof(WFOEventPointGainAnimationV2.<>c__DisplayClass32_0).__il2cppRuntimeField_10 = val_13;
            WFOEventPointGainAnimationV2.<>c__DisplayClass32_0.__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_FFFFFFFFFFFFFFFC = this;
        }
        else
        {
                mem[12] = this;
            val_14 = 16;
            mem[16] = val_13;
            val_13 = mem[16];
        }
        
        if(val_13 < 1)
        {
                return;
        }
        
        float val_13 = (float)UnityEngine.Mathf.Min(a:  10, b:  val_14);
        val_13 = this.symbolInterval * val_13;
        typeof(WFOEventPointGainAnimationV2.<>c__DisplayClass32_0).__il2cppRuntimeField_8 = (float)this.currentPoints;
        DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.Sequence val_4 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  (float)this.currentPoints);
        DG.Tweening.Core.DOSetter<System.Single> val_5 = new DG.Tweening.Core.DOSetter<System.Single>(object:  367411200, method:  new IntPtr(3910266112));
        int val_14 = mem[16];
        val_14 = val_14 + this.currentPoints;
        DG.Tweening.Tweener val_6 = DG.Tweening.DOTween.To(setter:  198881280, startValue:  (float)this.currentPoints, endValue:  null, duration:  (float)val_14);
        object val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  198881280, ease:  1);
        DG.Tweening.TweenCallback val_8 = new DG.Tweening.TweenCallback(object:  367411200, method:  new IntPtr(3910267136));
        object val_9 = DG.Tweening.TweenSettingsExtensions.OnUpdate<System.Object>(t:  198881280, action:  190734336);
        DG.Tweening.TweenCallback val_10 = new DG.Tweening.TweenCallback(object:  367411200, method:  new IntPtr(3910268160));
        object val_11 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  198881280, action:  190734336);
        DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  198881280);
    }
    private System.Collections.IEnumerator AutoGenerateSymbols(int count)
    {
        typeof(WFOEventPointGainAnimationV2.<AutoGenerateSymbols>d__33).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(WFOEventPointGainAnimationV2.<AutoGenerateSymbols>d__33).__il2cppRuntimeField_14 = this;
        }
        else
        {
                mem[20] = this;
        }
        
        typeof(WFOEventPointGainAnimationV2.<AutoGenerateSymbols>d__33).__il2cppRuntimeField_10 = count;
    }
    private DG.Tweening.Sequence MoveSymbol(float scale, UnityEngine.Transform trans, UnityEngine.Transform dest, bool destroy = True)
    {
        var val_1;
        bool val_5;
        bool val_10;
        UnityEngine.Transform val_18;
        object val_2 = new System.Object();
        if(val_2 != 0)
        {
                val_18 = val_2;
            typeof(WFOEventPointGainAnimationV2.<>c__DisplayClass34_0).__il2cppRuntimeField_C = dest;
            WFOEventPointGainAnimationV2.<>c__DisplayClass34_0.__il2cppRuntimeField_namespaze.__il2cppRuntimeField_FFFFFFFFFFFFFFFC = val_1;
        }
        else
        {
                mem[8] = val_1;
            val_18 = 12;
            mem[12] = dest;
        }
        
        typeof(WFOEventPointGainAnimationV2.<>c__DisplayClass34_0).__il2cppRuntimeField_10 = this;
        DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
        UnityEngine.Vector3 val_4 = position;
        DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions.DOMoveX(target:  val_18, endValue:  val_4.x, duration:  val_4.y, snapping:  val_5);
        object val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  val_18, ease:  this.easeX);
        DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  val_18);
        UnityEngine.Vector3 val_9 = position;
        DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions.DOMoveY(target:  mem[12], endValue:  val_9.x, duration:  val_9.y, snapping:  val_10);
        object val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  mem[12], animCurve:  this.curveY);
        DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  mem[12]);
        DG.Tweening.Tweener val_14 = DG.Tweening.ShortcutExtensions.DOScale(target:  mem[12], endValue:  val_9.x, duration:  val_9.y);
        DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  mem[12]);
        DG.Tweening.TweenCallback val_16 = new DG.Tweening.TweenCallback(object:  367517696, method:  new IntPtr(3910510592));
        DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
    }
    private void OnPointCollision()
    {
        if(this.progress.efxUpdate != 0)
        {
                this.progress.efxUpdate.Play();
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -1541987328, clipIndex:  0);
    }
    private void OnPointGainComplete()
    {
        if(this.onComplete != 0)
        {
                this.onComplete.Invoke();
        }
        
        if(this.progress.efxUpdate != 0)
        {
                UnityEngine.GameObject val_2 = this.progress.efxUpdate.gameObject;
            this.progress.efxUpdate.SetActive(value:  false);
        }
        
        this.Close();
    }
    private void ResetUI()
    {
        UnityEngine.Transform val_1 = this.symbolCountText.transform;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.symbolCountText.localScale = new UnityEngine.Vector3();
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.centralSymbolTransform.localScale = new UnityEngine.Vector3();
        UnityEngine.Transform val_4 = this.glow.transform;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
        this.glow.localScale = new UnityEngine.Vector3();
    }
    private void ResetCentralSymbolPos()
    {
        UnityEngine.Transform val_1 = this.symbolCountText.transform;
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.symbolCountText, endValue:  null, duration:  null);
        this.centralSymbolTransform.position = new UnityEngine.Vector3() {x = mem[this.originalCentralSymbolPos + (0)], y = mem[this.originalCentralSymbolPos + (4)], z = mem[this.originalCentralSymbolPos + (8)]};
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.centralSymbolTransform.localScale = new UnityEngine.Vector3();
        UnityEngine.Transform val_4 = this.glow.transform;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
        this.glow.localScale = new UnityEngine.Vector3();
    }
    private void Close()
    {
        WordRegion val_1 = WordRegion.instance;
        0.RemoveLevelCompleteBlocker(blocker:  3);
        UnityEngine.GameObject val_2 = this.gameObject;
        SLCWindow.CloseWindow(window:  -383724224, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WFOEventPointGainAnimationV2()
    {
        this.duration = 0.6f;
        this.symbolInterval = 0.12f;
        this.symbolScale = 3f;
    }
    private void <AutoGenerateSymbols>b__33_0()
    {
        this.ResetCentralSymbolPos();
    }
    private void <AutoGenerateSymbols>b__33_1()
    {
        this.OnPointGainComplete();
    }

}
