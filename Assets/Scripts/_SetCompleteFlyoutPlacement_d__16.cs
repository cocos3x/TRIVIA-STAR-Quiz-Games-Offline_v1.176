using UnityEngine;
private sealed class WGGoldenMultiplierFlyout.<SetCompleteFlyoutPlacement>d__16 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGGoldenMultiplierFlyout <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGGoldenMultiplierFlyout.<SetCompleteFlyoutPlacement>d__16(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_15;
        float val_19;
        float val_20;
        float val_23;
        float val_24;
        float val_26;
        float val_27;
        UnityEngine.RectTransform val_30;
        int val_31;
        UnityEngine.RectTransform val_32;
        UnityEngine.RectTransform val_33;
        if(((this.<>1__state) - 1) >= 2)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        val_30 = this.<>4__this.completeFlyout;
        val_31 = 0;
        if(val_30 == 0)
        {
                return (bool)val_31;
        }
        
        UnityEngine.Camera val_3 = SLCWindowManager<WGWindowManager>.gameplayCamera;
        val_30 = public static UnityEngine.Camera SLCWindowManager<WGWindowManager>::get_gameplayCamera();
        val_31 = 0;
        if((-1595693728) == 0)
        {
                return (bool)val_31;
        }
        
        val_30 = this.<>4__this.uiButton;
        val_31 = 0;
        if(val_30 == 0)
        {
                return (bool)val_31;
        }
        
        val_30 = this.<>4__this.canvasCamera;
        val_31 = 0;
        if(val_30 == 0)
        {
                return (bool)val_31;
        }
        
        val_31 = 0;
        UnityEngine.GameObject val_7 = this.<>4__this.gameObject;
        val_30 = this.<>4__this;
        if(val_30 == 0)
        {
                return (bool)val_31;
        }
        
        val_31 = 0;
        UnityEngine.GameObject val_9 = this.<>4__this.gameObject;
        val_30 = this.<>4__this;
        if(val_30.activeInHierarchy == false)
        {
                return (bool)val_31;
        }
        
        UnityEngine.Camera val_11 = SLCWindowManager<WGWindowManager>.gameplayCamera;
        if((this.<>4__this) == 0)
        {
            goto label_24;
        }
        
        val_32 = this.<>4__this.uiButton;
        val_33 = val_32;
        goto label_25;
        label_1:
        val_31 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_31;
        }
        
        this.<>1__state = 0;
        val_31 = 1;
        this.<>1__state = val_31;
        this.<>2__current = new UnityEngine.WaitForFixedUpdate();
        return (bool)val_31;
        label_24:
        val_33 = this.<>4__this.uiButton;
        val_32 = this.<>4__this.uiButton;
        label_25:
        UnityEngine.Rect val_13 = rect;
        UnityEngine.Vector2 val_14 = center;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = -7.127399E-06f, y = val_15});
        UnityEngine.Vector3 val_21 = TransformPoint(position:  new UnityEngine.Vector3() {x = val_33, y = val_19, z = val_20});
        UnityEngine.Vector3 val_25 = WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = -3.856473E-19f, y = val_23, z = val_24});
        UnityEngine.Vector3 val_29 = ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = this.<>4__this.canvasCamera, y = val_26, z = val_27});
        this.<>4__this.completeFlyout.position = new UnityEngine.Vector3() {x = R6, y = R7, z = R8};
        this.<>1__state = 2;
        this.<>2__current = 0;
        return (bool)val_31;
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
