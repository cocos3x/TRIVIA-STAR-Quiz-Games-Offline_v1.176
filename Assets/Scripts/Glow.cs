using UnityEngine;
public class Glow : MonoBehaviour
{
    // Fields
    private float cycleDuraton;
    private float maxAlpha;
    private float minAlpha;
    private UnityEngine.CanvasGroup canvasGroup;
    
    // Methods
    private void OnEnable()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  2131835232);
        this.canvasGroup = this;
        this.GlowDown();
    }
    private void GlowUp()
    {
        float val_6 = this.cycleDuraton;
        val_6 = val_6 * 0.5f;
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.canvasGroup, endValue:  val_6, duration:  null);
        object val_2 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.canvasGroup, ease:  7);
        DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  2131952352, method:  new IntPtr(2131927328));
        float val_4 = this.cycleDuraton * 0.5f;
        DG.Tweening.Tween val_5 = DG.Tweening.DOVirtual.DelayedCall(delay:  val_4, callback:  val_4, ignoreTimeScale:  false);
    }
    private void GlowDown()
    {
        float val_6 = this.cycleDuraton;
        val_6 = val_6 * 0.5f;
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.canvasGroup, endValue:  val_6, duration:  null);
        object val_2 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.canvasGroup, ease:  7);
        DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  2132073568, method:  new IntPtr(2132048544));
        float val_4 = this.cycleDuraton * 0.5f;
        DG.Tweening.Tween val_5 = DG.Tweening.DOVirtual.DelayedCall(delay:  val_4, callback:  val_4, ignoreTimeScale:  false);
    }
    public Glow()
    {
        this.cycleDuraton = 5f;
        this.maxAlpha = 1f;
        this.minAlpha = 0.5f;
    }

}
