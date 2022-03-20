using UnityEngine;

namespace WordForest
{
    public class WFONewsButton : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject rootNotifBadge;
        private UnityEngine.UI.Text labelNotifBadge;
        private UnityEngine.UI.Button button;
        
        // Methods
        private void Start()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            object val_2 = this.GetComponent<System.Object>();
            this.button = this;
            UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  333500736, method:  new IntPtr(333475712));
            this.AddListener(call:  162246656);
            NotificationCenter val_4 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  333500736, name:  404738048);
            this.UpdateNotificationBadge();
        }
        private void OnDestroy()
        {
            NotificationCenter val_1 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.RemoveObserver(observer:  333612736, name:  404738048);
        }
        private void OnButtonClicked()
        {
            GameBehavior val_1 = App.getBehavior;
            if(0 == 0)
            {
                
            }
        
        }
        private void OnNewsStatusUpdated()
        {
            this.UpdateNotificationBadge();
        }
        private void UpdateNotificationBadge()
        {
            int val_1 = WordForest.WFONewsPopup.UnseenNewsCount;
            string val_2 = val_1.ToString();
            if(val_1 > 0)
            {
                    0 = 1;
            }
            
            this.rootNotifBadge.SetActive(value:  true);
        }
        public WFONewsButton()
        {
        
        }
    
    }

}
