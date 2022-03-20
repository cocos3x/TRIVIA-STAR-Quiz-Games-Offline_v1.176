using UnityEngine;

namespace WordForest
{
    public class WFODigAnimation : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Image holeImage;
        private UnityEngine.UI.Image shovelImage;
        
        // Methods
        public void StartDigAnimation()
        {
            var val_39;
            DG.Tweening.TweenCallback val_41;
            var val_42;
            DG.Tweening.TweenCallback val_44;
            var val_45;
            DG.Tweening.TweenCallback val_47;
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            val_39 = null;
            val_39 = null;
            val_41 = WFODigAnimation.<>c.<>9__2_0;
            if(val_41 == 0)
            {
                    val_41 = null;
                val_41 = new DG.Tweening.TweenCallback(object:  WFODigAnimation.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(284983184));
                WFODigAnimation.<>c.<>9__2_0 = val_41;
            }
            
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            UnityEngine.Transform val_4 = this.shovelImage.transform;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.shovelImage, endValue:  new UnityEngine.Vector3(), duration:  val_5.x, snapping:  true);
            object val_7 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  this.shovelImage, loops:  2, loopType:  1);
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.shovelImage);
            val_42 = null;
            val_42 = null;
            val_44 = WFODigAnimation.<>c.<>9__2_1;
            if(val_44 == 0)
            {
                    val_44 = null;
                val_44 = new DG.Tweening.TweenCallback(object:  WFODigAnimation.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(284988304));
                WFODigAnimation.<>c.<>9__2_1 = val_44;
            }
            
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            UnityEngine.Transform val_11 = this.shovelImage.transform;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
            DG.Tweening.Tweener val_13 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.shovelImage, endValue:  new UnityEngine.Vector3(), duration:  val_12.x, snapping:  true);
            object val_14 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  this.shovelImage, loops:  2, loopType:  1);
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.shovelImage);
            val_45 = null;
            val_45 = null;
            val_47 = WFODigAnimation.<>c.<>9__2_2;
            if(val_47 == 0)
            {
                    val_47 = null;
                val_47 = new DG.Tweening.TweenCallback(object:  WFODigAnimation.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(284993424));
                WFODigAnimation.<>c.<>9__2_2 = val_47;
            }
            
            DG.Tweening.Sequence val_17 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            UnityEngine.Transform val_18 = this.shovelImage.transform;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.zero;
            DG.Tweening.Tweener val_20 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.shovelImage, endValue:  new UnityEngine.Vector3(), duration:  val_19.x, snapping:  true);
            object val_21 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  this.shovelImage, loops:  2, loopType:  1);
            DG.Tweening.Sequence val_22 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.shovelImage);
            DG.Tweening.Sequence val_23 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_19.x);
            DG.Tweening.Tweener val_24 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.shovelImage, endValue:  val_19.x, duration:  val_19.y);
            DG.Tweening.Sequence val_25 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.shovelImage);
            DG.Tweening.Sequence val_26 = DG.Tweening.DOTween.Sequence();
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_19.x);
            UnityEngine.Transform val_28 = this.holeImage.transform;
            DG.Tweening.Tweener val_29 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.holeImage, endValue:  val_19.x, duration:  val_19.y);
            DG.Tweening.Sequence val_30 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.holeImage);
            DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_19.x);
            UnityEngine.Transform val_32 = this.holeImage.transform;
            DG.Tweening.Tweener val_33 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.holeImage, endValue:  val_19.x, duration:  val_19.y);
            DG.Tweening.Sequence val_34 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.holeImage);
            DG.Tweening.Sequence val_35 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  0, interval:  val_19.x);
            UnityEngine.Transform val_36 = this.holeImage.transform;
            DG.Tweening.Tweener val_37 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.holeImage, endValue:  val_19.x, duration:  val_19.y);
            DG.Tweening.Sequence val_38 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  this.holeImage);
        }
        public void FadeHole()
        {
            DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.holeImage, endValue:  null, duration:  null);
        }
        public WFODigAnimation()
        {
        
        }
    
    }

}
