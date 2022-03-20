using UnityEngine;

namespace RestaurantRivals
{
    public class RESEventButton : MonoBehaviour
    {
        // Fields
        protected UnityEngine.CanvasGroup canvasGroup;
        protected UnityEngine.UI.Image notifBadgeIcon;
        protected UGUINetworkedButton eventButton;
        protected WGEventHandler eventHandler;
        
        // Properties
        public string EventType { get; }
        
        // Methods
        public string get_EventType()
        {
            if(this.eventHandler == 0)
            {
                    this.eventHandler = 0;
                return;
            }
            
            return this.eventHandler.EventType;
        }
        protected virtual void Awake()
        {
            System.Delegate val_5;
            object val_1 = this.GetComponent<System.Object>();
            this.eventButton = this;
            if(530059824 == 0)
            {
                    return;
            }
            
            System.Action<System.Boolean> val_3 = new System.Action<System.Boolean>(object:  530059824, method:  typeof(RestaurantRivals.RESEventButton).__il2cppRuntimeField_F0);
            val_5 = this.eventButton.OnConnectionClick;
            System.Delegate val_4 = System.Delegate.Combine(a:  val_5, b:  7401472);
            if(val_5 != 0)
            {
                    if(null == null)
            {
                goto label_6;
            }
            
            }
            
            val_5 = 0;
            label_6:
            this.eventButton.OnConnectionClick = val_5;
        }
        public virtual void Initialize(WGEventHandler handler)
        {
            this.eventHandler = handler;
        }
        protected virtual void OnButtonClick(bool isConnected)
        {
            if(this.eventHandler == 0)
            {
                    return;
            }
            
            if(this.eventHandler != 0)
            {
                    return;
            }
            
            if(this.eventHandler != 0)
            {
                    return;
            }
            
            if(this.eventHandler == 0)
            {
                
            }
        
        }
        public virtual void OnEventEnded()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Object.Destroy(obj:  530436784);
        }
        public void ShowIntroAnimation()
        {
            this.canvasGroup.alpha = null;
            System.Action val_1 = new System.Action(object:  530553904, method:  new IntPtr(530528880));
            MonoExtensions.DelayedCallEndOfFrame(monoBehaviour:  530553904, callback:  7454720);
        }
        public RESEventButton()
        {
        
        }
        private void <ShowIntroAnimation>b__10_0()
        {
            float val_4;
            float val_5;
            float val_9;
            float val_10;
            var val_14;
            var val_15;
            UnityEngine.GameObject val_1 = this.gameObject;
            val_14 = 0;
            UnityEngine.Transform val_2 = this.transform;
            if(this != 0)
            {
                    if(null == null)
            {
                goto label_3;
            }
            
            }
            
            val_15 = 1;
            goto label_4;
            label_3:
            val_15 = 0;
            val_14 = this;
            label_4:
            UnityEngine.Vector2 val_3 = anchoredPosition;
            UnityEngine.Vector2 val_6 = anchoredPosition;
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_6.x, y:  val_6.y);
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 6.902005E-20f}, b:  new UnityEngine.Vector2() {y = val_7.x});
            this.anchoredPosition = new UnityEngine.Vector2() {x = val_9, y = val_10};
            DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  530786096, endValue:  new UnityEngine.Vector2() {x = val_4, y = val_5}, duration:  val_8.x, snapping:  false);
            object val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  530786096, ease:  27);
            DG.Tweening.Tweener val_13 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.canvasGroup, endValue:  val_8.x, duration:  val_8.y);
        }
    
    }

}
