using UnityEngine;
private sealed class AttackStartLightning.<AnimateLightning>d__9 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public AttackStartLightning <>4__this;
    private float <stepDuration>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AttackStartLightning.<AnimateLightning>d__9(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_17;
        float val_18;
        float val_19;
        int val_20;
        object val_35;
        if((this.<>1__state) > 10)
        {
            goto label_1;
        }
        
        var val_1 = 9355748 + (9355748 + (this.<>1__state) << 2);
        if((this.<>1__state) == 10)
        {
                9355748 + (this.<>1__state) << 2 = (9355748 + (this.<>1__state) << 2) & ((IP) >> 32);
            9355748 + (this.<>1__state) << 2 = (9355748 + (this.<>1__state) << 2) & (((R8) << (32-(9355748 + (this.<>1__state) << 2 & (IP) >> 32))) | ((R8) << (9355748 + (this.<>1__state) << 2 & (IP) >> 32)));
            9355748 + (this.<>1__state) << 2 = (9355748 + (this.<>1__state) << 2) & ((IP) >> 1);
            9355748 + (this.<>1__state) << 2 = (9355748 + (this.<>1__state) << 2) & (((IP) << (32-1)) | ((IP) << 1));
            9355748 + (this.<>1__state) << 2 = (9355748 + (this.<>1__state) << 2) & ((IP) << 2);
            9355748 + (this.<>1__state) << 2 = (9355748 + (this.<>1__state) << 2) & ((9355748 + (this.<>1__state) << 2) >> 2);
            9355748 + (this.<>1__state) << 2 = (9355748 + (this.<>1__state) << 2) & (((((((((9355748 + (this.<>1__state) << 2 & (IP) >> 32) & ((R8) << (32-(9355748 + (this.<>1__state) << 2 & (IP) >> 32))) | ((R8) << (9355748 + (this.<>1__state) << 2 & (IP) >> 32))) & (IP) >> 1) & ((IP) ) << (32-2)) | ((((((((9355748 + (this.<>1__state) << 2 & (IP) >> 32) & ((R8) << (32-(9355748 + (this.<>1__state) << 2 & (IP) >> 32))) | ((R8) << (9355748 + (this.<>1__state) << 2 & (IP) >> 32))) & (IP) >> 1) & ((IP) ) << 2));
            9355748 + (this.<>1__state) << 2 = 4685833201400852224;
            mem[4685833201400852224] = -1401594368;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_2;
        }
        
        float val_17 = 0.142f;
        val_17 = (this.<>4__this.duration) * val_17;
        val_17 = 0.33f;
        this.<stepDuration>5__2 = val_17;
        float val_18 = this.<>4__this.maxLength;
        val_18 = val_18 * val_17;
        this.<>4__this.displayLength = val_18;
        this.<>4__this.RefreshLine();
        val_18 = this.<stepDuration>5__2;
        val_19 = this.<>4__this.lineWidth;
        goto label_3;
        label_1:
        val_20 = 0;
        return (bool);
        label_2:
        float val_20 = 0.142f;
        val_20 = 0f * val_20;
        this.<stepDuration>5__2 = val_20;
        val_17 = 1.401298E-45f;
        mem[36] = val_17 * 0.33f;
        0.RefreshLine();
        val_18 = this.<stepDuration>5__2;
        val_19 = 3.673424E-39f;
        label_3:
        float val_21 = 3f;
        val_35 = this.<>4__this;
        val_21 = val_19 * val_21;
        System.Collections.IEnumerator val_7 = val_35.FadeSize(from:  val_21, to:  null, duration:  val_17);
        val_20 = 1;
        this.<>1__state = val_20;
        this.<>2__current = ;
        return (bool);
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
