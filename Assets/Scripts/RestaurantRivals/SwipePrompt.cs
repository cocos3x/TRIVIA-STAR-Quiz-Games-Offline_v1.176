using UnityEngine;

namespace RestaurantRivals
{
    public class SwipePrompt : MonoBehaviour
    {
        // Fields
        protected UnityEngine.GameObject swipePromptHand;
        protected UnityEngine.CanvasGroup canvasGroup;
        protected UnityEngine.TrailRenderer swipePromptTrail;
        protected float startY;
        protected float endY;
        private DG.Tweening.Sequence seq;
        
        // Methods
        private void OnEnable()
        {
            this.Play();
        }
        private void OnDisable()
        {
            DG.Tweening.TweenExtensions.Kill(t:  this.seq, complete:  false);
        }
        private void Play()
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            this.seq = 0;
            DG.Tweening.TweenCallback val_2 = new DG.Tweening.TweenCallback(object:  673957120, method:  new IntPtr(673889088));
            DG.Tweening.Sequence val_3 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  0, callback:  190734336);
            DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.canvasGroup, endValue:  null, duration:  null);
            DG.Tweening.Sequence val_5 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.seq, t:  this.canvasGroup);
            UnityEngine.Transform val_6 = this.swipePromptHand.transform;
            DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions.DOLocalMoveY(target:  this.swipePromptHand, endValue:  null, duration:  null, snapping:  this.endY);
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.seq, t:  this.swipePromptHand);
            DG.Tweening.TweenCallback val_9 = new DG.Tweening.TweenCallback(object:  673957120, method:  new IntPtr(673910592));
            DG.Tweening.Sequence val_10 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.seq, callback:  190734336);
            DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.canvasGroup, endValue:  null, duration:  null);
            DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.seq, t:  this.canvasGroup);
            DG.Tweening.TweenCallback val_13 = new DG.Tweening.TweenCallback(object:  673957120, method:  new IntPtr(673923904));
            DG.Tweening.Sequence val_14 = DG.Tweening.TweenSettingsExtensions.AppendCallback(s:  this.seq, callback:  190734336);
            DG.Tweening.Sequence val_15 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.seq, interval:  null);
            object val_16 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  this.seq, loops:  0);
        }
        public SwipePrompt()
        {
        
        }
        private void <Play>b__8_0()
        {
            UnityEngine.Transform val_1 = this.swipePromptHand.transform;
            UnityEngine.Vector3 val_2 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
            this.swipePromptHand.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            this.swipePromptHand.SetActive(value:  true);
            this.canvasGroup.alpha = null;
        }
        private void <Play>b__8_1()
        {
            this.swipePromptTrail.Clear();
        }
        private void <Play>b__8_2()
        {
            this.swipePromptHand.SetActive(value:  false);
        }
    
    }

}
