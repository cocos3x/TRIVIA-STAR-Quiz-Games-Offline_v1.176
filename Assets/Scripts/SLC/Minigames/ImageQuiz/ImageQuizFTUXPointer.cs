using UnityEngine;

namespace SLC.Minigames.ImageQuiz
{
    public class ImageQuizFTUXPointer : MonoBehaviour
    {
        // Fields
        private UnityEngine.RectTransform pointerTransform;
        private UnityEngine.Vector2 moveBy;
        private float moveDuration;
        private DG.Tweening.LoopType moveLoopType;
        private DG.Tweening.Ease moveEaseType;
        private DG.Tweening.Sequence pointerSeq;
        private System.Nullable<UnityEngine.Vector2> originalPointerAnchoredPosition;
        private UnityEngine.UI.Image pointerImage;
        
        // Methods
        public void PointAt(UnityEngine.GameObject targetObj, bool flipPointerX = False, bool flipPointerY = False)
        {
            float val_2;
            float val_17;
            float val_18;
            float val_20;
            float val_27;
            float val_28;
            if(this.pointerSeq != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.pointerSeq, complete:  false);
            }
            
            if(this.pointerSeq == 0)
            {
                    UnityEngine.Vector2 val_1 = 0.anchoredPosition;
                System.Nullable<UnityEngine.Vector2> val_3 = new System.Nullable<UnityEngine.Vector2>(value:  new UnityEngine.Vector2() {x = 0f, y = val_2});
            }
            
            if(this.pointerImage == 0)
            {
                    object val_5 = this.pointerTransform.GetComponentInChildren<System.Object>();
                this.pointerImage = this.pointerTransform;
            }
            
            UnityEngine.GameObject val_6 = this.pointerTransform.gameObject;
            UnityEngine.Transform val_7 = targetObj.transform;
            UnityEngine.Transform val_8 = targetObj.transform;
            UnityEngine.Vector3 val_9 = val_3.HasValue.position;
            UnityEngine.Transform val_10 = targetObj.transform;
            UnityEngine.Vector3 val_11 = 0.position;
            UnityEngine.GameObject val_12 = this.gameObject;
            UnityEngine.Transform val_13 = targetObj.transform;
            UnityEngine.Vector3 val_14 = position;
            UnityEngine.Vector3 val_15 = new UnityEngine.Vector3(x:  val_14.x, y:  val_14.y, z:  val_14.z);
            this.position = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
            UnityEngine.Vector2 val_16 = Value;
            this.pointerTransform.anchoredPosition = new UnityEngine.Vector2() {x = val_17, y = val_18};
            if(flipPointerX == true)
            {
                    0 = 1127481344;
            }
            
            if(flipPointerY == true)
            {
                    0f = 1127481344;
            }
            
            UnityEngine.Quaternion val_19 = UnityEngine.Quaternion.Euler(x:  180f, y:  val_16.y, z:  val_14.z);
            this.pointerTransform.localRotation = new UnityEngine.Quaternion() {x = val_3.HasValue, y = 0f, z = 0f, w = val_20};
            if(flipPointerY == true)
            {
                    val_19.z = -val_19.z;
            }
            
            UnityEngine.Vector2 val_21 = new UnityEngine.Vector2(x:  this.moveBy = -this.moveBy, y:  val_19.y);
            DG.Tweening.Sequence val_22 = DG.Tweening.DOTween.Sequence();
            this.pointerSeq = 0;
            object val_23 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<System.Object>(t:  0, autoKillOnCompletion:  false);
            object val_24 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  this.pointerSeq, loops:  0, loopType:  this.moveLoopType);
            UnityEngine.Vector2 val_25 = val_21.y.Value;
            UnityEngine.Vector2 val_26 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 1.466884f, y = val_21.y}, b:  new UnityEngine.Vector2() {x = val_2, y = val_21.x});
            DG.Tweening.Tweener val_29 = DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  this.pointerTransform, endValue:  new UnityEngine.Vector2() {x = val_27, y = val_28}, duration:  val_26.x, snapping:  this.moveDuration);
            object val_30 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.pointerTransform, ease:  this.moveEaseType);
            DG.Tweening.Sequence val_31 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.pointerSeq, t:  this.pointerTransform);
            UnityEngine.Color val_32 = val_3.HasValue.color;
            this.pointerImage.color = new UnityEngine.Color() {r = val_3.HasValue, g = 0f, b = 0f, a = 0f};
            DG.Tweening.Tweener val_33 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.pointerImage, endValue:  val_32.r, duration:  val_32.g);
            object val_34 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.pointerImage, ease:  1);
        }
        public void Stop()
        {
            if(this.pointerSeq == 0)
            {
                    return;
            }
            
            DG.Tweening.TweenExtensions.Kill(t:  this.pointerSeq, complete:  false);
        }
        public ImageQuizFTUXPointer()
        {
            this.moveLoopType = 1;
            this.moveEaseType = 7;
        }
    
    }

}
