using UnityEngine;
public class WGGameplayMessage : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject message_group;
    private UnityEngine.CanvasGroup message_canvas_group;
    private UnityEngine.UI.Text message_text;
    private UnityEngine.GameObject letterNoObj;
    private UnityEngine.UI.Text letterNoText;
    private bool <isMessageShowing>k__BackingField;
    
    // Properties
    public bool isMessageShowing { get; set; }
    
    // Methods
    public bool get_isMessageShowing()
    {
        return (bool)this.<isMessageShowing>k__BackingField;
    }
    private void set_isMessageShowing(bool value)
    {
        this.<isMessageShowing>k__BackingField = value;
    }
    private void Awake()
    {
        this.message_group.SetActive(value:  false);
        this.message_canvas_group.alpha = null;
    }
    public bool ShowMessage(string message, bool showLetterNo = False, int letterCount = -1)
    {
        DG.Tweening.TweenCallback val_7;
        var val_8;
        val_7 = message;
        val_8 = 0;
        if((this.<isMessageShowing>k__BackingField) == true)
        {
                return (bool)val_8;
        }
        
        this.<isMessageShowing>k__BackingField = true;
        if((UnityEngine.Object.op_Implicit(exists:  this.letterNoObj)) != false)
        {
                this.letterNoObj.SetActive(value:  showLetterNo);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.letterNoText)) != false)
        {
                string val_3 = letterCount.ToString();
        }
        
        val_8 = 1;
        this.message_group.SetActive(value:  true);
        this.message_canvas_group.alpha = null;
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.message_canvas_group, endValue:  null, duration:  null);
        val_7 = null;
        val_7 = new DG.Tweening.TweenCallback(object:  -33459056, method:  new IntPtr(4261483216));
        object val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.message_canvas_group, action:  190734336);
        return (bool)val_8;
    }
    private void OnMessageShowComplete()
    {
        DG.Tweening.TweenCallback val_1 = new DG.Tweening.TweenCallback(object:  -33309168, method:  new IntPtr(4261633104));
        DG.Tweening.Tween val_2 = DG.Tweening.DOVirtual.DelayedCall(delay:  null, callback:  1080033280, ignoreTimeScale:  false);
    }
    private void OnMessageHideComplete()
    {
        this.message_group.SetActive(value:  false);
        this.<isMessageShowing>k__BackingField = false;
    }
    public WGGameplayMessage()
    {
    
    }
    private void <OnMessageShowComplete>b__11_0()
    {
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.message_canvas_group, endValue:  null, duration:  null);
        DG.Tweening.TweenCallback val_2 = new DG.Tweening.TweenCallback(object:  -32959856, method:  new IntPtr(4261982416));
        object val_3 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.message_canvas_group, action:  190734336);
    }

}
