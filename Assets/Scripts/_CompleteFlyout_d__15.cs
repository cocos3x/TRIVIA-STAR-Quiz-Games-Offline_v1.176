using UnityEngine;
private sealed class WGGoldenMultiplierFlyout.<CompleteFlyout>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGGoldenMultiplierFlyout <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGGoldenMultiplierFlyout.<CompleteFlyout>d__15(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_18;
        UnityEngine.RectTransform val_19;
        val_18 = 0;
        if((this.<>1__state) > 3)
        {
                return (bool)val_18;
        }
        
        var val_1 = 6837732 + (6837732 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                6837732 + (this.<>1__state) << 2 = (6837732 + (this.<>1__state) << 2) & ((6837732 + (this.<>1__state) << 2) << (6837732 + (this.<>1__state) << 2));
            6837732 + (this.<>1__state) << 2 = (6837732 + (this.<>1__state) << 2) & ((6837732 + (this.<>1__state) << 2) << 1);
            6837732 + (this.<>1__state) << 2 = (6837732 + (this.<>1__state) << 2) & 3068404256;
            mem2[0] = (((6837732 + (this.<>1__state) << 2 & (6837732 + (this.<>1__state) << 2) << 6837732 + (this.<>1__state) << 2) & ((6837732 + (this.<>1__state) << 2 & (6837732 + (this.<>1__state) << 2) << 6837732 + (th + this;
        }
        
        this.<>1__state = 0;
        object val_2 = UnityEngine.Object.FindObjectOfType<System.Object>();
        UnityEngine.RectTransform val_3 = GetButtonTransform;
        val_19 = public static GoldenApplesMultiplierStatView UnityEngine.Object::FindObjectOfType<GoldenApplesMultiplierStatView>();
        if((this.<>4__this) == 0)
        {
            goto label_5;
        }
        
        this.<>4__this.uiButton = val_19;
        goto label_6;
        label_29:
        this.<>2__current = ;
        return (bool)val_18;
        label_5:
        mem[32] = val_19;
        val_19 = mem[32];
        label_6:
        if((-1226592400) == 0)
        {
                val_18 = 0;
            UnityEngine.Debug.LogError(message:  -1226587280);
            this.<>4__this.OnDisplayComplete();
            return (bool)val_18;
        }
        
        UnityEngine.GameObject val_13 = this.<>4__this.gameObject;
        object val_14 = this.<>4__this.GetComponentInParent<System.Object>();
        if((this.<>4__this) != 0)
        {
                UnityEngine.Camera val_16 = this.<>4__this.worldCamera;
            this.<>4__this.canvasCamera = this.<>4__this;
        }
        
        null = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>1__state = 1;
        goto label_29;
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
