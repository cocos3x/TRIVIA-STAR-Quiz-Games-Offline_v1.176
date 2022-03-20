using UnityEngine;

namespace SLC.Social.Leagues
{
    public class ClubEdit_Window : MonoBehaviour
    {
        // Fields
        private SLC.Social.Leagues.LeaguesUICreateGuildView editGuildView;
        private UnityEngine.CanvasGroup flyoutCanvasGroup;
        private UnityEngine.UI.Text flyoutText;
        
        // Methods
        private void Start()
        {
            System.Action<System.String> val_3;
            System.Action<twelvegigs.storage.JsonDictionary> val_1 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  872566368, method:  new IntPtr(872541344));
            System.Delegate val_2 = System.Delegate.Combine(a:  this.editGuildView.showMessageFlyout, b:  7401472);
            val_3 = this.editGuildView.showMessageFlyout;
            if(val_3 != 0)
            {
                    if(null == null)
            {
                goto label_4;
            }
            
            }
            
            val_3 = 0;
            label_4:
            this.editGuildView.showMessageFlyout = val_3;
        }
        private void ShowTopFlyoutWithMessage(string message)
        {
            var val_5;
            int val_1 = DG.Tweening.ShortcutExtensions.DOKill(target:  this.flyoutCanvasGroup, complete:  false);
            this.flyoutCanvasGroup.alpha = null;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.flyoutCanvasGroup, endValue:  null, duration:  null);
            DG.Tweening.TweenCallback val_3 = new DG.Tweening.TweenCallback(object:  872708064, method:  new IntPtr(872683040));
            System.Delegate val_4 = System.Delegate.Combine(a:  this.flyoutText, b:  190734336);
            val_5 = this.flyoutText;
            if(val_5 != 0)
            {
                    if(null == null)
            {
                goto label_6;
            }
            
            }
            
            val_5 = 0;
            label_6:
            mem2[0] = val_5;
        }
        public ClubEdit_Window()
        {
        
        }
        private void <ShowTopFlyoutWithMessage>b__4_0()
        {
            DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.flyoutCanvasGroup, endValue:  null, duration:  null);
            object val_2 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.flyoutCanvasGroup, delay:  null);
        }
    
    }

}
