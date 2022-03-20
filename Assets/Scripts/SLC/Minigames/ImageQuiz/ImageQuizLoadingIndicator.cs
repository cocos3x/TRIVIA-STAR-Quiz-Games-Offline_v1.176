using UnityEngine;

namespace SLC.Minigames.ImageQuiz
{
    public class ImageQuizLoadingIndicator : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Image[] dots;
        private DG.Tweening.Sequence loadSeq;
        
        // Methods
        public void Show(bool isVisible)
        {
            bool val_16;
            DG.Tweening.Sequence val_17;
            var val_18;
            val_16 = isVisible;
            val_17 = this.loadSeq;
            if(val_17 != 0)
            {
                goto label_1;
            }
            
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            this.loadSeq = 0;
            object val_2 = DG.Tweening.TweenSettingsExtensions.SetAutoKill<System.Object>(t:  0, autoKillOnCompletion:  false);
            object val_3 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  this.loadSeq, loops:  0, loopType:  0);
            val_18 = 4;
            goto label_4;
            label_14:
            float val_18 = 3.564031E+07f;
            DG.Tweening.Sequence val_4 = DG.Tweening.DOTween.Sequence();
            UnityEngine.UI.Image val_17 = this.dots[0];
            UnityEngine.Transform val_5 = val_17.transform;
            DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  val_17, endValue:  35640314, duration:  null, snapping:  false);
            object val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  val_17, ease:  6);
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  val_17);
            val_18 = val_18 * 0.2f;
            UnityEngine.UI.Image val_19 = this.dots[0];
            UnityEngine.Transform val_9 = val_19.transform;
            DG.Tweening.Tweener val_10 = DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  val_19, endValue:  35640314, duration:  null, snapping:  false);
            object val_11 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  val_19, ease:  5);
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  val_19);
            DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.Insert(s:  this.loadSeq, atPosition:  35640314, t:  val_18);
            val_18 = 5;
            label_4:
            if((val_18 - 4) < this.loadSeq)
            {
                goto label_14;
            }
            
            val_17 = this.loadSeq;
            val_16 = val_16;
            label_1:
            if(val_16 != false)
            {
                    DG.Tweening.TweenExtensions.Restart(t:  val_17, includeDelay:  true, changeDelayTo:  35640314);
            }
            else
            {
                    object val_15 = DG.Tweening.TweenExtensions.Pause<System.Object>(t:  val_17);
            }
            
            UnityEngine.GameObject val_16 = this.gameObject;
            this.SetActive(value:  val_16);
        }
        public ImageQuizLoadingIndicator()
        {
        
        }
    
    }

}
