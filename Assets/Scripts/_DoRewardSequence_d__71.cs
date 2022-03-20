using UnityEngine;
private sealed class RaidMadnessEventHandler.<DoRewardSequence>d__71 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGEventButtonV2 eventProgressUI;
    public WGLevelClearPopup popup;
    public WGEventButtonV2 eventButton;
    private UnityEngine.UI.Image <icon>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RaidMadnessEventHandler.<DoRewardSequence>d__71(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_13;
        float val_18;
        float val_19;
        bool val_21;
        bool val_22;
        int val_34;
        object val_35;
        if((this.<>1__state) != 1)
        {
                val_34 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_34;
        }
        
            this.<>1__state = 0;
            UnityEngine.Transform val_1 = this.popup.transform;
            object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  this.eventProgressUI.icon, parent:  this.popup);
            this.<icon>5__2 = this.eventProgressUI.icon;
            UnityEngine.Transform val_3 = this.eventProgressUI.icon.transform;
            UnityEngine.Transform val_4 = this.eventButton.transform;
            UnityEngine.Vector3 val_5 = position;
            this.eventProgressUI.icon.position = new UnityEngine.Vector3();
            UnityEngine.RectTransform val_6 = this.<icon>5__2.rectTransform;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            this.<icon>5__2.localScale = new UnityEngine.Vector3();
            UnityEngine.Transform val_8 = this.popup.transform;
            UnityEngine.Transform val_9 = this.popup.transform;
            UnityEngine.Vector3 val_10 = localPosition;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(d:  val_11.x, a:  new UnityEngine.Vector3() {x = -3.859879f, y = 160f, z = val_13});
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = -3.859877f}, b:  new UnityEngine.Vector3());
            UnityEngine.Vector3 val_20 = TransformPoint(position:  new UnityEngine.Vector3() {x = this.popup, y = val_18, z = val_19});
            UnityEngine.Transform val_23 = this.<icon>5__2.transform;
            DG.Tweening.Tweener val_24 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<icon>5__2, endValue:  val_20.x, duration:  val_20.y);
            object val_25 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<icon>5__2, ease:  27);
            UnityEngine.Transform val_26 = this.<icon>5__2.transform;
            DG.Tweening.Tweener val_27 = DG.Tweening.ShortcutExtensions.DOMoveX(target:  this.<icon>5__2, endValue:  val_20.x, duration:  val_20.y, snapping:  val_21);
            object val_28 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<icon>5__2, ease:  3);
            UnityEngine.Transform val_29 = this.<icon>5__2.transform;
            DG.Tweening.Tweener val_30 = DG.Tweening.ShortcutExtensions.DOMoveY(target:  this.<icon>5__2, endValue:  val_20.x, duration:  val_20.y, snapping:  val_22);
            object val_31 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<icon>5__2, ease:  3);
            UnityEngine.WaitForSeconds val_32 = null;
            val_35 = val_32;
            val_32 = new UnityEngine.WaitForSeconds(seconds:  val_20.x);
            val_34 = 1;
            this.<>1__state = val_34;
            this.<>2__current = val_35;
            return (bool)val_34;
        }
        
        val_35 = this.<icon>5__2;
        this.<>1__state = 0;
        val_34 = 0;
        UnityEngine.GameObject val_33 = val_35.gameObject;
        UnityEngine.Object.Destroy(obj:  val_35);
        return (bool)val_34;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
