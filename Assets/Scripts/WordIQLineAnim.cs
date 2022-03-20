using UnityEngine;
public class WordIQLineAnim : MonoBehaviour
{
    // Fields
    private bool playOnAwake;
    private UnityEngine.UI.Image imageToTween;
    private UnityEngine.CanvasGroup canvasToTween;
    private float localYMove;
    
    // Methods
    private void Awake()
    {
        if(this.playOnAwake == false)
        {
                return;
        }
        
        this.Play();
    }
    public void Play()
    {
        var val_19;
        var val_20;
        var val_21;
        float val_22;
        DG.Tweening.TweenCallback val_23;
        var val_24;
        var val_25;
        val_19 = 1152921504765685760;
        if((UnityEngine.Object.op_Implicit(exists:  this.imageToTween)) != false)
        {
                DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.imageToTween, endValue:  null, duration:  null);
            object val_3 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.imageToTween, delay:  null);
            UnityEngine.Transform val_4 = this.imageToTween.transform;
            DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  this.imageToTween, endValue:  null, duration:  null, snapping:  this.localYMove);
            object val_6 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.imageToTween, delay:  null);
            DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.imageToTween, endValue:  null, duration:  null);
            object val_8 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.imageToTween, delay:  null);
            val_20 = this.imageToTween;
            val_21 = val_20;
            val_22 = 1152921504797581312;
            val_23 = null;
            val_24 = 1152921512269378272;
        }
        else
        {
                if((UnityEngine.Object.op_Implicit(exists:  this.canvasToTween)) == false)
        {
                return;
        }
        
            DG.Tweening.Tweener val_10 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.canvasToTween, endValue:  null, duration:  null);
            object val_11 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.canvasToTween, delay:  null);
            UnityEngine.Transform val_12 = this.canvasToTween.transform;
            DG.Tweening.Tweener val_13 = DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  this.canvasToTween, endValue:  null, duration:  null, snapping:  this.localYMove);
            object val_14 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.canvasToTween, delay:  null);
            DG.Tweening.Tweener val_15 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.canvasToTween, endValue:  null, duration:  null);
            object val_16 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.canvasToTween, delay:  null);
            val_20 = this.canvasToTween;
            val_21 = val_20;
            val_22 = 1152921504797581312;
            val_23 = null;
            val_24 = 1152921512269395680;
        }
        
        val_23 = new DG.Tweening.TweenCallback(object:  -927360864, method:  new IntPtr(3367581408));
        System.Delegate val_18 = System.Delegate.Combine(a:  1152921510714553472, b:  190734336);
        val_25 = 1152921510714553472;
        if(val_25 != 0)
        {
                if((public static DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetDelay<DG.Tweening.Tweener>(DG.Tweening.Tweener t, float delay)) == val_22)
        {
            goto label_14;
        }
        
        }
        
        val_25 = 0;
        label_14:
        mem2[0] = val_25;
    }
    public void KillYourself()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  -927216096);
    }
    public WordIQLineAnim()
    {
        this.localYMove = 50f;
        this.playOnAwake = true;
    }
    private void <Play>b__5_0()
    {
        this.KillYourself();
    }
    private void <Play>b__5_1()
    {
        this.KillYourself();
    }

}
