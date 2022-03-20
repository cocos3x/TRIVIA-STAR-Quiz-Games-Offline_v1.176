using UnityEngine;
public class CategoryPackCompleteDisplay : MonoBehaviour
{
    // Fields
    private UnityEngine.RectTransform catPackMeterContainer;
    private CategoryPackProgressMeter catPackMeterPrefab;
    private UnityEngine.CanvasGroup completeMessageCanvasGroup;
    private UnityEngine.CanvasGroup completeMessageBlurbGroup;
    private UnityEngine.UI.MaskableGraphic icon;
    private UnityEngine.UI.Text labelDescription;
    private UnityEngine.UI.Button buttonContinue;
    private LevelCompletePopup levelCompletePopup;
    private CategoryPackProgressMeter catPackMeterInstance;
    
    // Methods
    private void Start()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1507342336, method:  new IntPtr(2787599936));
        this.buttonContinue.m_OnClick.AddListener(call:  162246656);
    }
    public void Init(LevelCompletePopup lvlComplete)
    {
        this.levelCompletePopup = lvlComplete;
    }
    public void Show(bool isChapterComplete, bool isPackComplete)
    {
        this.ShowProgressMeter(isChapterComplete:  isChapterComplete, isPackComplete:  isPackComplete);
    }
    private void ShowProgressMeter(bool isChapterComplete, bool isPackComplete)
    {
        CategoryPackProgressMeter val_5;
        if(new System.Object() != 0)
        {
                typeof(CategoryPackCompleteDisplay.<>c__DisplayClass12_0).__il2cppRuntimeField_8 = isPackComplete;
        }
        else
        {
                mem[8] = isPackComplete;
        }
        
        typeof(CategoryPackCompleteDisplay.<>c__DisplayClass12_0).__il2cppRuntimeField_C = this;
        if(this.catPackMeterInstance == 0)
        {
                object val_3 = UnityEngine.Object.Instantiate<System.Object>(original:  this.catPackMeterPrefab, parent:  this.catPackMeterContainer);
            val_5 = this.catPackMeterPrefab;
            this.catPackMeterInstance = this.catPackMeterPrefab;
        }
        else
        {
                val_5 = this.catPackMeterInstance;
        }
        
        System.Action val_4 = new System.Action(object:  311021568, method:  new IntPtr(2787970752));
        val_5.ShowLevelCompleteAnimation(startDelay:  null, isChapterComplete:  true, onComplete:  isChapterComplete);
    }
    private void ShowPackCompleteMessage()
    {
        float val_3;
        float val_4;
        float val_5;
        float val_10;
        UnityEngine.GameObject val_1 = this.completeMessageCanvasGroup.gameObject;
        this.completeMessageCanvasGroup.SetActive(value:  true);
        this.completeMessageCanvasGroup.alpha = null;
        this.completeMessageCanvasGroup.blocksRaycasts = false;
        this.completeMessageBlurbGroup.alpha = null;
        UnityEngine.Color val_2 = color;
        this.icon.color = new UnityEngine.Color() {r = val_3, g = val_4, b = val_5, a = 0f};
        UnityEngine.Transform val_6 = this.icon.transform;
        UnityEngine.Vector3 val_7 = new UnityEngine.Vector3(x:  val_2.r, y:  val_2.g, z:  val_2.b);
        this.icon.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        UnityEngine.Transform val_8 = this.icon.transform;
        UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.Euler(x:  val_2.r, y:  val_2.g, z:  val_2.b);
        this.icon.localRotation = new UnityEngine.Quaternion() {w = val_10};
        DG.Tweening.Sequence val_11 = DG.Tweening.DOTween.Sequence();
        UnityEngine.Transform val_12 = this.icon.transform;
        DG.Tweening.Tweener val_13 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.icon, endValue:  val_9.x, duration:  val_9.y);
        object val_14 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.icon, ease:  20);
        DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.icon);
        UnityEngine.Transform val_16 = this.icon.transform;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_18 = DG.Tweening.ShortcutExtensions.DOLocalRotate(target:  this.icon, endValue:  new UnityEngine.Vector3(), duration:  val_17.x, mode:  1043878380);
        object val_19 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.icon, ease:  1);
        DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.icon);
        DG.Tweening.Tweener val_21 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.icon, endValue:  val_17.x, duration:  val_17.y);
        object val_22 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.icon, delay:  val_17.x);
        object val_23 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.icon, ease:  1);
        DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  this.icon);
        DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_17.x);
        DG.Tweening.Tweener val_26 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.completeMessageBlurbGroup, endValue:  val_17.x, duration:  val_17.y);
        DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.completeMessageBlurbGroup);
        DG.Tweening.TweenCallback val_28 = new DG.Tweening.TweenCallback(object:  -1506792960, method:  new IntPtr(2788149312));
        object val_29 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
    }
    private void OnContinueClicked()
    {
        if(this.levelCompletePopup == 0)
        {
            
        }
    
    }
    private void OnPackCompleteClicked()
    {
        this.levelCompletePopup.HideLowerUI(fadeOutDuration:  null, delay:  null);
        this.ShowPackCompleteMessage();
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.catPackMeterInstance.meterCanvasGroup, endValue:  null, duration:  null);
    }
    public CategoryPackCompleteDisplay()
    {
    
    }
    private void <ShowPackCompleteMessage>b__13_0()
    {
        this.completeMessageCanvasGroup.blocksRaycasts = true;
    }

}
