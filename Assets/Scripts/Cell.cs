using UnityEngine;
public class Cell : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text letterText;
    protected UnityEngine.GameObject letterGroup;
    private UnityEngine.GameObject starredCoinGroup;
    private UnityEngine.UI.Image sharedDynamicImage;
    private UnityEngine.Sprite uncoloredBackground;
    public string letter;
    public bool isShown;
    private bool isStarred;
    private UnityEngine.Vector3 originLetterScale;
    private UnityEngine.Vector3 finalLetterScale;
    private UnityEngine.Animator animator;
    public UnityEngine.CanvasGroup cellCanvasGroup;
    public System.Action CellClickedAction;
    
    // Properties
    public UnityEngine.GameObject getLetter { get; }
    public UnityEngine.UI.Image DynamicImage { get; }
    
    // Methods
    public UnityEngine.GameObject get_getLetter()
    {
    
    }
    public UnityEngine.UI.Image get_DynamicImage()
    {
    
    }
    public void Start()
    {
        object val_1 = this.GetComponent<System.Object>();
        this.animator = this;
    }
    private void OnEnable()
    {
        if(this.animator != 0)
        {
                return;
        }
        
        object val_2 = R4.GetComponent<System.Object>();
        mem2[0] = R4;
    }
    public void Animate(UnityEngine.Transform from, UnityEngine.Transform fromParent)
    {
        float val_2;
        float val_3;
        float val_4;
        var val_12;
        var val_13;
        var val_14;
        float val_31;
        float val_32;
        DG.Tweening.TweenCallback val_43;
        UnityEngine.Transform val_44;
        UnityEngine.Vector3 val_1 = position;
        UnityEngine.Transform val_5 = this.letterGroup.transform;
        UnityEngine.Vector3 val_6 = localScale;
        UnityEngine.Transform val_7 = from.transform;
        UnityEngine.Vector3 val_8 = position;
        UnityEngine.Vector3 val_9 = CUtils.GetMiddlePoint(begin:  new UnityEngine.Vector3() {x = -6.662032E-37f, y = val_2, z = val_3}, end:  new UnityEngine.Vector3() {x = val_4}, delta:  val_8.x);
        typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_10 = val_2;
        typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_14 = val_3;
        typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_18 = val_4;
        UnityEngine.Transform val_10 = this.transform;
        UnityEngine.Vector3 val_11 = position;
        typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28 = val_12;
        typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_2C = val_13;
        typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_30 = val_14;
        this.SetText();
        UnityEngine.Transform val_15 = this.letterGroup.transform;
        this.letterGroup.position = new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4};
        UnityEngine.Transform val_16 = this.letterGroup.transform;
        UnityEngine.Vector3 val_17 = localScale;
        this.letterGroup.localScale = new UnityEngine.Vector3();
        UnityEngine.Transform val_18 = this.letterGroup.transform;
        this.letterGroup.SetParent(p:  fromParent);
        UnityEngine.GameObject val_19 = this.letterGroup.gameObject;
        UnityEngine.Transform val_20 = this.letterGroup.transform;
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> val_21 = DG.Tweening.ShortcutExtensions.DOPath(target:  this.letterGroup, path:  533912224, duration:  val_17.x, pathType:  1045220557, pathMode:  0, resolution:  1, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
        val_43 = null;
        val_43 = new DG.Tweening.TweenCallback(object:  -2090671696, method:  new IntPtr(2204252032));
        object val_23 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.letterGroup, action:  190734336);
        UnityEngine.GameObject val_24 = this.letterGroup.gameObject;
        val_44 = this.letterGroup;
        UnityEngine.Transform val_25 = val_44.transform;
        DG.Tweening.Tweener val_26 = DG.Tweening.ShortcutExtensions.DOScale(target:  val_44, endValue:  new UnityEngine.Vector3() {x = mem[this.originLetterScale + (0)], y = mem[this.originLetterScale + (4)], z = mem[this.originLetterScale + (8)]}, duration:  val_17.x);
        if(this.isStarred == false)
        {
                return;
        }
        
        UnityEngine.Transform val_27 = this.starredCoinGroup.transform;
        UnityEngine.Transform val_28 = this.starredCoinGroup.transform;
        UnityEngine.Vector3 val_29 = position;
        UnityEngine.Vector3 val_30 = UnityEngine.Vector3.up;
        val_43 = val_31;
        UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -6.662037E-37f}, b:  new UnityEngine.Vector3() {y = val_32, z = val_43});
        DG.Tweening.Tweener val_35 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.starredCoinGroup, endValue:  new UnityEngine.Vector3(), duration:  val_34.x, snapping:  true);
        object val_36 = this.starredCoinGroup.GetComponent<System.Object>();
        DG.Tweening.Tweener val_37 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.starredCoinGroup, endValue:  val_34.x, duration:  val_34.y);
        val_44 = null;
        val_44 = new DG.Tweening.TweenCallback(object:  -2090671696, method:  new IntPtr(2204270464));
        object val_39 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.starredCoinGroup, action:  190734336);
        twelvegigs.Autopilot.AutopilotManager val_40 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -2090695808, clipIndex:  0);
    }
    private void DisableStarSprite()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.starredCoinGroup)) == false)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = R4 + 20.gameObject;
        R4 + 20.SetActive(value:  false);
    }
    public void SetScale(UnityEngine.Vector3 newScale)
    {
        UnityEngine.Transform val_1 = this.letterGroup.transform;
        this.letterGroup.localScale = new UnityEngine.Vector3() {x = newScale.x, y = newScale.y, z = newScale.z};
    }
    private void OnMoveToComplete()
    {
        UnityEngine.Transform val_1 = this.letterGroup.transform;
        UnityEngine.Transform val_2 = this.transform;
        this.letterGroup.SetParent(p:  -2090256752);
        UnityEngine.Transform val_3 = this.letterGroup.transform;
        UnityEngine.Transform val_4 = this.transform;
        UnityEngine.Vector3 val_5 = position;
        this.letterGroup.position = new UnityEngine.Vector3();
        UnityEngine.GameObject val_6 = this.letterGroup.gameObject;
        UnityEngine.Transform val_7 = this.letterGroup.transform;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = -6.848112E-37f, y = this.originLetterScale, z = 0f}, d:  val_5.x);
        DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.letterGroup, endValue:  new UnityEngine.Vector3(), duration:  val_8.x);
        DG.Tweening.TweenCallback val_10 = new DG.Tweening.TweenCallback(object:  -2090256752, method:  new IntPtr(2204681328));
        object val_11 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.letterGroup, action:  190734336);
        this.animator.SetTrigger(name:  -2090280848);
    }
    private void OnScaleUpComplete()
    {
        UnityEngine.GameObject val_1 = this.letterGroup.gameObject;
        UnityEngine.Transform val_2 = this.letterGroup.transform;
        DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.letterGroup, endValue:  new UnityEngine.Vector3() {x = mem[this.originLetterScale + (0)], y = mem[this.originLetterScale + (4)], z = mem[this.originLetterScale + (8)]}, duration:  null);
        DG.Tweening.TweenCallback val_4 = new DG.Tweening.TweenCallback(object:  -2090123248, method:  new IntPtr(2204819024));
        object val_5 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.letterGroup, action:  190734336);
    }
    private void OnScaleDownComplete()
    {
        UnityEngine.Transform val_1 = this.letterGroup.transform;
        this.letterGroup.localScale = new UnityEngine.Vector3() {x = this.finalLetterScale, y = R7, z = -6.967279E-37f};
    }
    public void ShowHint()
    {
        this.isShown = true;
        UnityEngine.Transform val_1 = this.letterGroup.transform;
        UnityEngine.Vector3 val_2 = localScale;
        this.SetText();
        this.OnMoveToComplete();
    }
    public void ShowStarred()
    {
        if(this.starredCoinGroup == 0)
        {
                return;
        }
        
        this.starredCoinGroup.SetActive(value:  true);
        this.isStarred = true;
    }
    public void HideStarred()
    {
        if(this.starredCoinGroup == 0)
        {
                return;
        }
        
        R4 + 20.SetActive(value:  false);
    }
    public void ShowDynamicImage(UnityEngine.Sprite sprite)
    {
        if(this.sharedDynamicImage == 0)
        {
                return;
        }
        
        this.sharedDynamicImage.sprite = sprite;
        UnityEngine.GameObject val_2 = this.sharedDynamicImage.gameObject;
        this.sharedDynamicImage.SetActive(value:  true);
    }
    public void HideDynamicImage()
    {
        if(this.sharedDynamicImage == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = R4 + 24.gameObject;
        R4 + 24.SetActive(value:  false);
    }
    public void SetAndShowText()
    {
        this.isShown = true;
        this.SetText();
    }
    private void SetText()
    {
        this.letterGroup.SetActive(value:  (System.String.IsNullOrEmpty(value:  this.letter)) ^ 1);
        if(this.letterText == 0)
        {
            
        }
    
    }
    public void ShowExists()
    {
        this.animator.SetTrigger(name:  -2089016368);
        UnityEngine.GameObject val_1 = this.letterGroup.gameObject;
        UnityEngine.Transform val_2 = this.letterGroup.transform;
        DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOShakePosition(target:  this.letterGroup, duration:  null, strength:  null, vibrato:  1061158912, randomness:  null, snapping:  false, fadeOut:  true);
        UnityEngine.GameObject val_4 = this.letterGroup.gameObject;
        UnityEngine.Transform val_5 = this.letterGroup.transform;
        DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions.DOShakeRotation(target:  this.letterGroup, duration:  null, strength:  null, vibrato:  1065353216, randomness:  null, fadeOut:  false);
        DG.Tweening.TweenCallback val_7 = new DG.Tweening.TweenCallback(object:  -2088983056, method:  new IntPtr(2205959216));
        object val_8 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.letterGroup, action:  190734336);
    }
    private void ResetLetterGroup()
    {
        float val_6;
        UnityEngine.Transform val_1 = this.letterGroup.transform;
        UnityEngine.Transform val_2 = this.transform;
        UnityEngine.Vector3 val_3 = position;
        this.letterGroup.position = new UnityEngine.Vector3();
        UnityEngine.Transform val_4 = this.letterGroup.transform;
        UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.identity;
        this.letterGroup.rotation = new UnityEngine.Quaternion() {w = val_6};
    }
    public virtual void RecolorCell()
    {
    
    }
    public void SetNewBackgroundAndColor(UnityEngine.Color32 bgColor)
    {
        object val_1 = this.letterGroup.GetComponent<System.Object>();
        this.letterGroup.sprite = this.uncoloredBackground;
        object val_2 = this.letterGroup.GetComponent<System.Object>();
        UnityEngine.Color val_3 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 96, g = 71, b = 130, a = 131});
        UnityEngine.Color val_4 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 80, g = 71, b = 130, a = 131});
        this.letterText.color = new UnityEngine.Color() {a = ???};
    }
    public virtual void SetPickerHintSpriteSwap(bool state)
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        object val_2 = this.GetComponent<System.Object>();
        this.interactable = state;
    }
    public void TryDisplayWord()
    {
        WordRegion val_1 = WordRegion.instance;
        if(0 == 0)
        {
                return;
        }
        
        WordRegion val_3 = WordRegion.instance;
        0.TryShowWordDefinition(selectedCell:  -2088361616);
    }
    public void TryCellClickedAction()
    {
        if(this.CellClickedAction == 0)
        {
                return;
        }
        
        this.CellClickedAction.Invoke();
    }
    public Cell()
    {
    
    }

}
