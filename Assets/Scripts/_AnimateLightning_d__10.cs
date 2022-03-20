using UnityEngine;
private sealed class RESAttackExplosionEffects.<AnimateLightning>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public RESAttackExplosionEffects <>4__this;
    private float <stepDuration>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RESAttackExplosionEffects.<AnimateLightning>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_16;
        float val_17;
        float val_18;
        int val_19;
        object val_34;
        if((this.<>1__state) > 9)
        {
            goto label_1;
        }
        
        var val_1 = 8134680 + (8134680 + (this.<>1__state) << 2);
        if((this.<>1__state) == 9)
        {
                8134680 + (this.<>1__state) << 2 = (8134680 + (this.<>1__state) << 2) & ((R8) >> 32);
            8134680 + (this.<>1__state) << 2 = (8134680 + (this.<>1__state) << 2) & (((this) << (32-(8134680 + (this.<>1__state) << 2 & (R8) >> 32))) | ((this) << (8134680 + (this.<>1__state) << 2 & (R8) >> 32)));
            8134680 + (this.<>1__state) << 2 = (8134680 + (this.<>1__state) << 2) & ((R8) >> 1);
            8134680 + (this.<>1__state) << 2 = (8134680 + (this.<>1__state) << 2) & (((int)IP) >> 1);
            mem2[0] = ((((8134680 + (this.<>1__state) << 2 & (R8) >> 32) & ((this) << (32-(8134680 + (this.<>1__state) << 2 & (R8) >> 32))) | ((this) << (8134680 + (this.<>1__state) << 2 & (R8) >> 32))) & (R8) >> 1) & ((in + ((((8134680 + (this.<>1__state) << 2 & (R8) >> 32) & ((this) << (32-(8134680 + (this.<>1__state) << 2 & (R8) >> 32))) | ((this) << (8134680 + (this.<>1__state) << 2 & (R8) >> 32))) & (R8) >> 1) & ((in;
            (((((8134680 + (this.<>1__state) << 2 & (R8) >> 32) & ((this) << (32-(8134680 + (this.<>1__state) << 2 & (R8) >> 32))) | ((this) << (8134680 + (this.<>1__state) << 2 & (R8) >> 32))) & (R8) >> 1) & ((in + ((((8134680 + (this.<>1__state) << 2 & (R8) >> 32) & ((this) << (32-(8134680 + (this.<>1__state) << 2 & (R8) >> 32))) | ((this) << (8134680 + (this.<>1__state) << 2 & (R8) >> 32))) & (R8) >> 1) & ((in) & ((((((8134680 + (this.<>1__state) << 2 & (R8) >> 32) & ((this) << (32-(8134680 + (this.<>1__state) << 2 & (R8) >> 32))) | ((this) << (8134680 + (this.<>1__state) << 2 & (R8) >> 32))) & (R8) >> 1) & ((in + ((((8134680 + (this.<>1__state) << 2 & (R8) >> 32) & ((this) << (32-(8134680 + (this.<>1__state) << 2 & (R8) >> 32))) | ((this) << (8134680 + (this.<>1__state) << 2 & (R8) >> 32))) & (R8) >> 1) & ((in) << 8134680) = ((((((8134680 + (this.<>1__state) << 2 & (R8) >> 32) & ((this) << (32-(8134680 + (this.<>1__state) << 2 & (R8) >> 32))) | ((this) << (8134680 + (this.<>1__state) << 2 & (R8) >> 32))) & (R8) >> 1) & ((in + ((((8134680 + (this.<>1__state) << 2 & (R8) >> 32) & ((this) << (32-(8134680 + (this.<>1__state) << 2 & (R8) >> 32))) | ((this) << (8134680 + (this.<>1__state) << 2 & (R8) >> 32))) & (R8) >> 1) & ((in) & ((((((8134680 + (this.<>1__state) << 2 & (R8) >> 32) & ((this) << (32-(8134680 + (this.<>1__state) << 2 & (R8) >> 32))) | ((this) << (8134680 + (this.<>1__state) << 2 & (R8) >> 32))) & (R8) >> 1) & ((in + ((((8134680 + (this.<>1__state) << 2 & (R8) >> 32) & ((this) << (32-(8134680 + (this.<>1__state) << 2 & (R8) >> 32))) | ((this) << (8134680 + (this.<>1__state) << 2 & (R8) >> 32))) & (R8) >> 1) & ((in) << 8134680)) & (-165002360);
            (((((8134680 + (this.<>1__state) << 2 & (R8) >> 32) & ((this) << (32-(8134680 + (this.<>1__state) << 2 & (R8) >> 32))) | ((this) << (8134680 + (this.<>1__state) << 2 & (R8) >> 32))) & (R8) >> 1) & ((in + ((((8134680 + (this.<>1__state) << 2 & (R8) >> 32) & ((this) << (32-(8134680 + (this.<>1__state) << 2 & (R8) >> 32))) | ((this) << (8134680 + (this.<>1__state) << 2 & (R8) >> 32))) & (R8) >> 1) & ((in) & ((((((8134680 + (this.<>1__state) << 2 & (R8) >> 32) & ((this) << (32-(8134680 + (this.<>1__state) << 2 & (R8) >> 32))) | ((this) << (8134680 + (this.<>1__state) << 2 & (R8) >> 32))) & (R8) >> 1) & ((in + ((((8134680 + (this.<>1__state) << 2 & (R8) >> 32) & ((this) << (32-(8134680 + (this.<>1__state) << 2 & (R8) >> 32))) | ((this) << (8134680 + (this.<>1__state) << 2 & (R8) >> 32))) & (R8) >> 1) & ((in) << 8134680) = ((((((8134680 + (this.<>1__state) << 2 & (R8) >> 32) & ((this) << (32-(8134680 + (this.<>1__state) << 2 & (R8) >> 32))) | ((this) << (8134680 + (this.<>1__state) << 2 & (R8) >> 32))) & (R8) >> 1) & ((in + ((((8134680 + (this.<>1__state) << 2 & (R8) >> 32) & ((this) << (32-(8134680 + (this.<>1__state) << 2 & (R8) >> 32))) | ((this) << (8134680 + (this.<>1__state) << 2 & (R8) >> 32))) & (R8) >> 1) & ((in) & ((((((8134680 + (this.<>1__state) << 2 & (R8) >> 32) & ((this) << (32-(8134680 + (this.<>1__state) << 2 & (R8) >> 32))) | ((this) << (8134680 + (this.<>1__state) << 2 & (R8) >> 32))) & (R8) >> 1) & ((in + ((((8134680 + (this.<>1__state) << 2 & (R8) >> 32) & ((this) << (32-(8134680 + (this.<>1__state) << 2 & (R8) >> 32))) | ((this) << (8134680 + (this.<>1__state) << 2 & (R8) >> 32))) & (R8) >> 1) & ((in) << 8134680)) & 908739464;
            (((((8134680 + (this.<>1__state) << 2 & (R8) >> 32) & ((this) << (32-(8134680 + (this.<>1__state) << 2 & (R8) >> 32))) | ((this) << (8134680 + (this.<>1__state) << 2 & (R8) >> 32))) & (R8) >> 1) & ((in + ((((8134680 + (this.<>1__state) << 2 & (R8) >> 32) & ((this) << (32-(8134680 + (this.<>1__state) << 2 & (R8) >> 32))) | ((this) << (8134680 + (this.<>1__state) << 2 & (R8) >> 32))) & (R8) >> 1) & ((in) & ((((((8134680 + (this.<>1__state) << 2 & (R8) >> 32) & ((this) << (32-(8134680 + (this.<>1__state) << 2 & (R8) >> 32))) | ((this) << (8134680 + (this.<>1__state) << 2 & (R8) >> 32))) & (R8) >> 1) & ((in + ((((8134680 + (this.<>1__state) << 2 & (R8) >> 32) & ((this) << (32-(8134680 + (this.<>1__state) << 2 & (R8) >> 32))) | ((this) << (8134680 + (this.<>1__state) << 2 & (R8) >> 32))) & (R8) >> 1) & ((in) << 8134680) = R8 * 8134680;
            mem2[0] = (R8 * 8134680) + this;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_2;
        }
        
        float val_16 = 0.142f;
        val_16 = (this.<>4__this.duration) * val_16;
        val_16 = 0.33f;
        this.<stepDuration>5__2 = val_16;
        float val_17 = this.<>4__this.maxLength;
        val_17 = val_17 * val_16;
        this.<>4__this.displayLength = val_17;
        this.<>4__this.RefreshLine();
        val_17 = this.<stepDuration>5__2;
        val_18 = this.<>4__this.lineWidth;
        goto label_3;
        label_1:
        val_19 = 0;
        return (bool);
        label_2:
        float val_19 = 0.142f;
        val_19 = 0f * val_19;
        this.<stepDuration>5__2 = val_19;
        val_16 = 1.401298E-45f;
        mem[40] = val_16 * 0.33f;
        0.RefreshLine();
        val_17 = this.<stepDuration>5__2;
        val_18 = 3.673424E-39f;
        label_3:
        float val_20 = 3f;
        val_34 = this.<>4__this;
        val_20 = val_18 * val_20;
        System.Collections.IEnumerator val_6 = val_34.FadeSize(from:  val_20, to:  null, duration:  val_16);
        val_19 = 1;
        this.<>1__state = val_19;
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
