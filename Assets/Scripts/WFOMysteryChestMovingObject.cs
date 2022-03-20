using UnityEngine;
public class WFOMysteryChestMovingObject : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject sunBurst;
    private UnityEngine.GameObject chestIcon;
    
    // Methods
    private void Start()
    {
        UnityEngine.Transform val_1 = this.sunBurst.transform;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.sunBurst.localScale = new UnityEngine.Vector3() {x = 0f};
        float val_4 = UnityEngine.Random.Range(min:  UnityEngine.Random.Range(min:  val_2.x, max:  val_2.y), max:  val_2.y);
        UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_4, y:  val_2.y);
        val_5.x.Normalize();
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = -4.174273E+25f, y = val_5.x}, d:  val_4);
        UnityEngine.Transform val_9 = this.chestIcon.transform;
        UnityEngine.Transform val_10 = this.chestIcon.transform;
        UnityEngine.Vector3 val_11 = localPosition;
        UnityEngine.Vector3 val_13 = new UnityEngine.Vector3(x:  val_11.x, y:  val_11.y, z:  val_11.z);
        this.chestIcon.localPosition = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
        object val_14 = this.chestIcon.GetComponent<System.Object>();
        this.chestIcon.alpha = val_11.x;
        DG.Tweening.Sequence val_15 = DG.Tweening.DOTween.Sequence();
        DG.Tweening.TweenCallback val_16 = new DG.Tweening.TweenCallback(object:  -368423792, method:  new IntPtr(3926513360));
        DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        DG.Tweening.Sequence val_18 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_11.x);
        DG.Tweening.TweenCallback val_19 = new DG.Tweening.TweenCallback(object:  -368423792, method:  new IntPtr(3926514384));
        DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
        DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_11.x);
        UnityEngine.Transform val_22 = this.chestIcon.transform;
        DG.Tweening.Tweener val_23 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.chestIcon, endValue:  val_11.x, duration:  val_11.y);
        DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.chestIcon);
    }
    public WFOMysteryChestMovingObject()
    {
    
    }
    private void <Start>b__2_0()
    {
        UnityEngine.Transform val_1 = this.chestIcon.transform;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.chestIcon, endValue:  new UnityEngine.Vector3(), duration:  val_2.x, snapping:  false);
        object val_4 = this.chestIcon.GetComponent<System.Object>();
        DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.chestIcon, endValue:  val_2.x, duration:  val_2.y);
    }
    private void <Start>b__2_1()
    {
        UnityEngine.Transform val_1 = this.chestIcon.transform;
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.chestIcon, endValue:  null, duration:  null);
        UnityEngine.Transform val_3 = this.sunBurst.transform;
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.sunBurst, endValue:  null, duration:  null);
        object val_5 = this.sunBurst.GetComponent<System.Object>();
        DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.sunBurst, endValue:  null, duration:  null);
        object val_7 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.sunBurst, delay:  null);
    }

}
