using UnityEngine;

namespace WordPets
{
    public class WPTMessageBanner : MonoBehaviour
    {
        // Fields
        private UnityEngine.CanvasGroup canvasGroup;
        private UnityEngine.UI.Button buttonClose;
        private UnityEngine.UI.Text labelMessage;
        private DG.Tweening.Sequence canvasSeq;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  210763328, method:  new IntPtr(210738304));
            this.buttonClose.m_OnClick.AddListener(call:  162246656);
        }
        private void OnCloseClicked()
        {
            this.SetVisible(isVisible:  false);
        }
        public void ShowMessage(string message)
        {
            this.SetVisible(isVisible:  true);
        }
        private void SetVisible(bool isVisible)
        {
            DG.Tweening.Sequence val_24;
            if(this.canvasSeq != 0)
            {
                    DG.Tweening.TweenExtensions.Kill(t:  this.canvasSeq, complete:  false);
            }
            
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            val_24 = 0;
            this.canvasSeq = 0;
            if(isVisible != false)
            {
                    this.canvasGroup.alpha = null;
                UnityEngine.GameObject val_2 = this.canvasGroup.gameObject;
                UnityEngine.Transform val_3 = this.canvasGroup.transform;
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
                this.canvasGroup.localScale = new UnityEngine.Vector3();
                if(this.canvasGroup != 0)
            {
                    this.canvasGroup.blocksRaycasts = true;
            }
            else
            {
                    0.blocksRaycasts = true;
            }
            
                this.canvasGroup.interactable = true;
                DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.canvasGroup, endValue:  val_4.x, duration:  val_4.y);
                object val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.canvasGroup, ease:  1);
                DG.Tweening.Sequence val_7 = DG.Tweening.TweenSettingsExtensions.Append(s:  this.canvasSeq, t:  this.canvasGroup);
                UnityEngine.GameObject val_8 = this.canvasGroup.gameObject;
                UnityEngine.Transform val_9 = this.canvasGroup.transform;
                DG.Tweening.Tweener val_10 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.canvasGroup, endValue:  val_4.x, duration:  val_4.y);
                object val_11 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.canvasGroup, ease:  27);
                DG.Tweening.Sequence val_12 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.canvasSeq, t:  this.canvasGroup);
                DG.Tweening.Sequence val_13 = DG.Tweening.TweenSettingsExtensions.AppendInterval(s:  this.canvasSeq, interval:  val_4.x);
                val_24 = this.canvasSeq;
            }
            
            DG.Tweening.Tweener val_14 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.canvasGroup, endValue:  val_4.x, duration:  val_4.y);
            object val_15 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.canvasGroup, ease:  1);
            DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_24, t:  this.canvasGroup);
            UnityEngine.GameObject val_17 = this.canvasGroup.gameObject;
            UnityEngine.Transform val_18 = this.canvasGroup.transform;
            DG.Tweening.Tweener val_19 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.canvasGroup, endValue:  val_4.x, duration:  val_4.y);
            object val_20 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.canvasGroup, ease:  1);
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Join(s:  this.canvasSeq, t:  this.canvasGroup);
            DG.Tweening.TweenCallback val_22 = new DG.Tweening.TweenCallback(object:  211182272, method:  new IntPtr(211157248));
            object val_23 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.canvasSeq, action:  190734336);
        }
        private void OnBannerFadeOut()
        {
            if(this.canvasGroup != 0)
            {
                    this.canvasGroup.blocksRaycasts = false;
            }
            else
            {
                    0.blocksRaycasts = false;
            }
            
            this.canvasGroup.interactable = false;
        }
        public WPTMessageBanner()
        {
        
        }
    
    }

}
