using UnityEngine;
private sealed class RESAttackExplosionEffects.<FadeSize>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float duration;
    public float from;
    public float to;
    public RESAttackExplosionEffects <>4__this;
    private float <t>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RESAttackExplosionEffects.<FadeSize>d__12(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        float val_6;
        UnityEngine.LineRenderer val_7;
        if((this.<>1__state) != 1)
        {
                val_5 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_5;
        }
        
            val_6 = 0f;
            this.<t>5__2 = 0f;
            this.<>1__state = 0;
        }
        else
        {
                this.<>1__state = 0;
            if((this.<>1__state) >= 0)
        {
                val_7 = this.<>4__this.electricity;
            val_5 = 0;
            val_7.startWidth = this.to * 1.25f;
            this.<>4__this.electricity.endWidth = this.to * 1.25f;
            return (bool)val_5;
        }
        
        }
        
        float val_3 = UnityEngine.Time.deltaTime;
        float val_5 = this.duration;
        val_5 = 0 / val_5;
        val_6 = val_6 + val_5;
        this.<t>5__2 = val_6;
        float val_6 = 1.25f;
        val_6 = this.from * val_6;
        float val_4 = UnityEngine.Mathf.Lerp(a:  val_6, b:  null, t:  0);
        this.<>4__this.electricity.startWidth = val_4;
        val_7 = this.<>4__this.electricity;
        val_7.endWidth = val_4;
        val_5 = 1;
        this.<>1__state = val_5;
        this.<>2__current = 0;
        return (bool)val_5;
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
