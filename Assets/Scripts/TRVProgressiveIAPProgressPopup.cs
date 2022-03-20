using UnityEngine;
public class TRVProgressiveIAPProgressPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text fillText;
    private UnityEngine.UI.Text freeText;
    private UnityEngine.UI.Image fillBar;
    private UnityEngine.RectTransform banner;
    private UnityEngine.RectTransform barParent;
    private UnityEngine.RectTransform giftClosed;
    private UnityEngine.RectTransform giftOpened;
    private UnityEngine.GameObject giftParticleSystem;
    private UnityEngine.UI.Button openGiftButton;
    private UnityEngine.UI.Slider sliderProgressBar;
    private System.Action onAwake;
    private bool hasGiftOpened;
    private TRVProgressiveIAPHandler handler;
    
    // Methods
    private void OnEnable()
    {
        if(this.onAwake != 0)
        {
                this.onAwake.Invoke();
        }
        
        this.onAwake = 0;
    }
    public void Init()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(this.activeInHierarchy != false)
        {
                this.AnimateProgressBar();
            return;
        }
        
        System.Action val_3 = new System.Action(object:  -586631152, method:  new IntPtr(3708311120));
        this.onAwake = null;
    }
    private void AnimateProgressBar()
    {
        string val_9;
        var val_10;
        int val_11;
        var val_12;
        var val_7 = 23667154;
        val_7 = 11964024 + val_7;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = TRVProgressiveIAPHandler.BONUS_MULTIPLIER;
        this.handler = val_9;
        if(val_9 != null)
        {
                val_10 = mem[TRVProgressiveIAPHandler.BONUS_MULTIPLIER + 28];
            val_10 = TRVProgressiveIAPHandler.BONUS_MULTIPLIER + 28;
            val_11 = val_10 - 1;
        }
        else
        {
                val_10 = mem[TRVProgressiveIAPHandler.BONUS_MULTIPLIER + 28];
            val_10 = TRVProgressiveIAPHandler.BONUS_MULTIPLIER + 28;
            val_9 = this.handler;
            val_11 = val_10 - 1;
            if(val_9 == 0)
        {
                val_9 = 0;
        }
        
        }
        
        int val_1 = val_9.GetCurrentTierProgress(calculatedProgress:  val_11);
        var val_8 = 0;
        var val_10 = 0;
        int val_3 = val_1 + 1;
        label_12:
        if(val_8 >= val_3)
        {
            goto label_8;
        }
        
        val_8 = val_8 + 1;
        val_10 = this.handler.levelRq[val_8] + val_10;
        if(val_10 != val_10)
        {
            goto label_12;
        }
        
        val_12 = 1;
        goto label_13;
        label_8:
        val_12 = 0;
        label_13:
        string val_4 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        float val_11 = (float)val_1;
        val_11 = val_11 / ((float)this.handler.GetCurrentTierRequirement(calculatedProgress:  val_11));
        this.SetBarProgress(progressAmount:  val_11);
        float val_12 = (float)val_3;
        val_12 = val_12 / ((float)this.handler.GetCurrentTierRequirement(calculatedProgress:  val_11));
        System.Collections.IEnumerator val_5 = this.AnimateBarFill(targetFillAmount:  val_12, openPurchasePopup:  val_12, req:  0);
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  -586424944);
    }
    private System.Collections.IEnumerator AnimateBarFill(float targetFillAmount, bool openPurchasePopup, int req)
    {
        typeof(TRVProgressiveIAPProgressPopup.<AnimateBarFill>d__16).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(TRVProgressiveIAPProgressPopup.<AnimateBarFill>d__16).__il2cppRuntimeField_14 = openPurchasePopup;
            typeof(TRVProgressiveIAPProgressPopup.<AnimateBarFill>d__16).__il2cppRuntimeField_10 = this;
            typeof(TRVProgressiveIAPProgressPopup.<AnimateBarFill>d__16).__il2cppRuntimeField_18 = req;
        }
        else
        {
                mem[16] = this;
            mem[20] = openPurchasePopup;
            mem[24] = req;
        }
        
        typeof(TRVProgressiveIAPProgressPopup.<AnimateBarFill>d__16).__il2cppRuntimeField_1C = R3;
    }
    private System.Collections.IEnumerator AnimateGiftOpening()
    {
        object val_1 = new System.Object();
        typeof(TRVProgressiveIAPProgressPopup.<AnimateGiftOpening>d__17).__il2cppRuntimeField_8 = 0;
        typeof(TRVProgressiveIAPProgressPopup.<AnimateGiftOpening>d__17).__il2cppRuntimeField_10 = this;
    }
    private void SetBarProgress(float progressAmount)
    {
        var val_4;
        UnityEngine.UI.Slider val_5;
        val_4 = 1152921504765685760;
        if(this.fillBar != 0)
        {
                this.fillBar.fillAmount = progressAmount;
        }
        
        val_5 = this.sliderProgressBar;
        if(val_5 == 0)
        {
                return;
        }
        
        if(this.sliderProgressBar == 0)
        {
            
        }
    
    }
    private void TweenProgressBar(float target, float duration)
    {
        if(this.fillBar != 0)
        {
                DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFillAmount(target:  this.fillBar, endValue:  target, duration:  duration);
        }
        
        if(this.sliderProgressBar == 0)
        {
                return;
        }
        
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOValue(target:  this.sliderProgressBar, endValue:  target, duration:  duration, snapping:  R1);
    }
    public TRVProgressiveIAPProgressPopup()
    {
    
    }
    private void <AnimateBarFill>b__16_0()
    {
        this.StopAllCoroutines();
        System.Collections.IEnumerator val_1 = this.AnimateGiftOpening();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -585593200);
    }

}
