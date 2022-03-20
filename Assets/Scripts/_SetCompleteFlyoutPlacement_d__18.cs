using UnityEngine;
private sealed class WGChallengeFlyout.<SetCompleteFlyoutPlacement>d__18 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGChallengeFlyout <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGChallengeFlyout.<SetCompleteFlyoutPlacement>d__18(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_15;
        float val_16;
        float val_18;
        float val_19;
        float val_23;
        UnityEngine.RectTransform val_24;
        int val_25;
        var val_26;
        float val_27;
        if(((this.<>1__state) - 1) < 2)
        {
                this.<>1__state = 0;
            val_23 = 1152921504765685760;
            val_24 = this.<>4__this.completeFlyout;
            val_25 = 0;
            if(val_24 == 0)
        {
                return (bool)val_25;
        }
        
            val_26 = 1152921504985972736;
            val_27 = 1152921511601087840;
            UnityEngine.Camera val_3 = SLCWindowManager<WGWindowManager>.gameplayCamera;
            val_24 = public static UnityEngine.Camera SLCWindowManager<WGWindowManager>::get_gameplayCamera();
            val_25 = 0;
            if((-1595693728) == 0)
        {
                return (bool)val_25;
        }
        
            val_24 = this.<>4__this.uiButton;
            val_25 = 0;
            if(val_24 == 0)
        {
                return (bool)val_25;
        }
        
            val_24 = this.<>4__this.canvasCamera;
            val_25 = 0;
            if(val_24 == 0)
        {
                return (bool)val_25;
        }
        
            val_25 = 0;
            UnityEngine.GameObject val_7 = this.<>4__this.gameObject;
            val_24 = this.<>4__this;
            if(val_24 == 0)
        {
                return (bool)val_25;
        }
        
            val_25 = 0;
            UnityEngine.GameObject val_9 = this.<>4__this.gameObject;
            val_24 = this.<>4__this;
            if(val_24.activeInHierarchy == false)
        {
                return (bool)val_25;
        }
        
            UnityEngine.Camera val_11 = SLCWindowManager<WGWindowManager>.gameplayCamera;
            UnityEngine.Transform val_12 = this.<>4__this.uiButton.transform;
            UnityEngine.Vector3 val_13 = position;
            UnityEngine.Vector3 val_17 = WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = -3.856473E-19f, y = val_15, z = val_16});
            val_23 = val_19;
            val_27 = 0;
            UnityEngine.Vector3 val_21 = ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = this.<>4__this.canvasCamera, y = val_18, z = val_23});
            this.<>4__this.completeFlyout.position = new UnityEngine.Vector3() {x = R6, y = R7, z = R8};
            val_25 = 1;
            this.<>1__state = 2;
            this.<>2__current = val_27;
            return (bool)val_25;
        }
        
        val_25 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_25;
        }
        
        this.<>1__state = 0;
        val_25 = 1;
        this.<>1__state = val_25;
        this.<>2__current = new UnityEngine.WaitForFixedUpdate();
        return (bool)val_25;
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
