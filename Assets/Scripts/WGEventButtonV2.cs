using UnityEngine;
public class WGEventButtonV2 : MonoBehaviour
{
    // Fields
    protected UnityEngine.CanvasGroup canvasGroup;
    protected UnityEngine.UI.Image icon;
    protected UnityEngine.UI.Image notifBadgeIcon;
    protected UGUINetworkedButton eventButton;
    protected UnityEngine.UI.Text buttonLabel;
    protected UnityEngine.ParticleSystem efxUpdate;
    protected WGEventHandler eventHandler;
    
    // Properties
    public UnityEngine.CanvasGroup CanvasGroup { get; }
    public UnityEngine.UI.Image Icon { get; }
    public UGUINetworkedButton Button { get; }
    public UnityEngine.UI.Text Label { get; }
    public UnityEngine.ParticleSystem EfxUpdate { get; }
    public WGEventHandler EventHandler { get; }
    public string EventType { get; }
    
    // Methods
    public UnityEngine.CanvasGroup get_CanvasGroup()
    {
    
    }
    public UnityEngine.UI.Image get_Icon()
    {
    
    }
    public UGUINetworkedButton get_Button()
    {
    
    }
    public UnityEngine.UI.Text get_Label()
    {
    
    }
    public UnityEngine.ParticleSystem get_EfxUpdate()
    {
    
    }
    public WGEventHandler get_EventHandler()
    {
    
    }
    public string get_EventType()
    {
        if(this.eventHandler == 0)
        {
                return;
        }
        
        if(this.eventHandler.myEvent != 0)
        {
                "" = this.eventHandler.myEvent.type;
        }
    
    }
    protected virtual void Start()
    {
        System.Delegate val_4;
        if(this.eventButton == 0)
        {
                return;
        }
        
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -329274976, method:  typeof(WGEventButtonV2).__il2cppRuntimeField_F8);
        val_4 = this.eventButton.OnConnectionClick;
        System.Delegate val_3 = System.Delegate.Combine(a:  val_4, b:  7401472);
        if(val_4 != 0)
        {
                if(null == null)
        {
            goto label_6;
        }
        
        }
        
        val_4 = 0;
        label_6:
        this.eventButton.OnConnectionClick = val_4;
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
        
        UnityEngine.GameObject val_1 = this.notifBadgeIcon.gameObject;
        this.notifBadgeIcon.SetActive(value:  this.eventHandler);
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
                if((R5 + 36) != 0)
        {
            goto R5 + 36 + 332;
        }
        
        }
        
        }
        
        }
    
    }
    public virtual void OnEventEnded()
    {
        var val_7;
        UnityEngine.GameObject val_1 = this.gameObject;
        val_7 = this;
        UnityEngine.Transform val_2 = this.transform;
        if(val_7 != 0)
        {
                if(null == null)
        {
            goto label_3;
        }
        
        }
        
        val_7 = 0;
        label_3:
        DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions46.DOAnchorPosX(target:  0, endValue:  null, duration:  null, snapping:  false);
        object val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  0, ease:  26);
        DG.Tweening.TweenCallback val_5 = new DG.Tweening.TweenCallback(object:  -328756320, method:  new IntPtr(3966185952));
        object val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  0, action:  190734336);
    }
    public virtual void ShowIntroAnimation()
    {
        this.canvasGroup.alpha = null;
        System.Action val_1 = new System.Action(object:  -328639200, method:  new IntPtr(3966303072));
        MonoExtensions.DelayedCallEndOfFrame(monoBehaviour:  -328639200, callback:  7454720);
    }
    public WGEventButtonV2()
    {
    
    }
    private void <OnEventEnded>b__25_0()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  -328411104);
    }
    private void <ShowIntroAnimation>b__26_0()
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
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = -1.152985E+27f}, b:  new UnityEngine.Vector2() {y = val_7.x});
        this.anchoredPosition = new UnityEngine.Vector2() {x = val_9, y = val_10};
        DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions46.DOAnchorPos(target:  -328295008, endValue:  new UnityEngine.Vector2() {x = val_4, y = val_5}, duration:  val_8.x, snapping:  false);
        object val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  -328295008, ease:  27);
        DG.Tweening.Tweener val_13 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.canvasGroup, endValue:  val_8.x, duration:  val_8.y);
    }

}
