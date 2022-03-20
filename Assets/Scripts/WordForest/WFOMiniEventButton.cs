using UnityEngine;

namespace WordForest
{
    public class WFOMiniEventButton : MonoBehaviour
    {
        // Fields
        protected UnityEngine.CanvasGroup canvasGroup;
        protected UnityEngine.UI.Image notifBadgeIcon;
        protected UnityEngine.UI.Text buttonLabel;
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
            if(274227168 == 0)
            {
                    return;
            }
            
            System.Action<System.Boolean> val_3 = new System.Action<System.Boolean>(object:  274227168, method:  typeof(WordForest.WFOMiniEventButton).__il2cppRuntimeField_F8);
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
        public virtual void Refresh()
        {
            if(this.eventHandler == 0)
            {
                    return;
            }
            
            if(this.buttonLabel == 0)
            {
                
            }
        
        }
        protected virtual void OnButtonClick(bool isConnected)
        {
            var val_2;
            var val_3;
            WGEventHandler val_4;
            val_2 = this;
            if(this.eventHandler != 0)
            {
                    val_3 = isConnected;
                if(this.eventHandler == 0)
            {
                    val_4 = this.eventHandler;
                if(val_4 != 0)
            {
                
            }
            else
            {
                    if((R5 + 28) != 0)
            {
                goto R5 + 28 + 332;
            }
            
            }
            
            }
            
            }
        
        }
        public virtual void OnEventEnded()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Object.Destroy(obj:  274724320);
        }
        public void ShowIntroAnimation()
        {
            this.canvasGroup.alpha = null;
            System.Action val_1 = new System.Action(object:  274841440, method:  new IntPtr(274816416));
            MonoExtensions.DelayedCallEndOfFrame(monoBehaviour:  274841440, callback:  7454720);
        }
        public WFOMiniEventButton()
        {
        
        }
        private void <ShowIntroAnimation>b__12_0()
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
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = 4.518328E-29f}, b:  new UnityEngine.Vector2() {y = val_7.x});
            this.anchoredPosition = new UnityEngine.Vector2() {x = val_9, y = val_10};
            DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  275073632, endValue:  new UnityEngine.Vector2() {x = val_4, y = val_5}, duration:  val_8.x, snapping:  false);
            object val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  275073632, ease:  27);
            DG.Tweening.Tweener val_13 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.canvasGroup, endValue:  val_8.x, duration:  val_8.y);
        }
    
    }

}
