using UnityEngine;

namespace SLC.Minigames.WordBalloon
{
    public class WordBalloonFTUXPointer : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Graphic pointerGraphic;
        private DG.Tweening.Sequence pointerMoveSeq;
        
        // Methods
        public void MoveAlong(UnityEngine.GameObject startObj, UnityEngine.GameObject endObj, float moveAlongDuration, DG.Tweening.LoopType moveAlongLoopType = 0, DG.Tweening.Ease moveAlongEaseType = 1)
        {
            DG.Tweening.Ease val_28;
            if(this.pointerMoveSeq != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.pointerMoveSeq, complete:  false);
            }
            
            UnityEngine.Transform val_1 = startObj.transform;
            UnityEngine.Vector3 val_2 = position;
            UnityEngine.Transform val_4 = startObj.transform;
            UnityEngine.Vector3 val_5 = position;
            UnityEngine.GameObject val_7 = this.gameObject;
            UnityEngine.Transform val_8 = endObj.transform;
            UnityEngine.Vector3 val_9 = position;
            UnityEngine.Vector3 val_10 = new UnityEngine.Vector3(x:  val_9.x, y:  val_9.y, z:  val_9.z);
            UnityEngine.Transform val_11 = endObj.transform;
            UnityEngine.Vector3 val_12 = position;
            UnityEngine.Transform val_14 = endObj.transform;
            UnityEngine.Vector3 val_15 = position;
            UnityEngine.GameObject val_17 = this.gameObject;
            UnityEngine.Transform val_18 = endObj.transform;
            UnityEngine.Vector3 val_19 = position;
            UnityEngine.Vector3 val_21 = new UnityEngine.Vector3(x:  val_19.x, y:  val_19.y, z:  val_19.z);
            UnityEngine.GameObject val_22 = this.gameObject;
            UnityEngine.Transform val_23 = endObj.transform;
            this.position = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            UnityEngine.Color val_27 = new UnityEngine.Color(r:  val_19.x, g:  val_19.y, b:  val_19.z, a:  null);
            DG.Tweening.Sequence val_29 = DG.Tweening.DOTween.Sequence();
            this.pointerMoveSeq = 0;
            object val_30 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<System.Object>(t:  0, autoKillOnCompletion:  false);
            object val_31 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  this.pointerMoveSeq, loops:  0, loopType:  moveAlongEaseType);
            DG.Tweening.Tweener val_32 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.pointerGraphic, endValue:  val_19.x, duration:  val_19.y);
            DG.Tweening.Sequence val_33 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.pointerMoveSeq, t:  this.pointerGraphic);
            UnityEngine.GameObject val_34 = this.gameObject;
            UnityEngine.Transform val_35 = this.transform;
            DG.Tweening.Tweener val_36 = DG.Tweening.ShortcutExtensions.DOMove(target:  982733696, endValue:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, duration:  val_19.x, snapping:  moveAlongLoopType);
            object val_37 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  982733696, ease:  val_28);
            DG.Tweening.Sequence val_38 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.pointerMoveSeq, t:  982733696);
            DG.Tweening.Tweener val_39 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.pointerGraphic, endValue:  val_19.x, duration:  val_19.y);
            DG.Tweening.Sequence val_40 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.pointerMoveSeq, t:  this.pointerGraphic);
            DG.Tweening.Sequence val_41 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.pointerMoveSeq, interval:  val_19.x);
        }
        public void Stop()
        {
            if(this.pointerMoveSeq == 0)
            {
                    return;
            }
            
            DG.Tweening.TweenExtensions.Kill(t:  this.pointerMoveSeq, complete:  false);
        }
        public WordBalloonFTUXPointer()
        {
        
        }
    
    }

}
