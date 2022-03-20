using UnityEngine;
private sealed class Music.<FadeIn>d__13 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Music <>4__this;
    private float <duration>5__2;
    private float <t>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Music.<FadeIn>d__13(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        float val_3;
        float val_4;
        float val_5;
        val_2 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_2;
        }
        
            val_3 = this;
            this.<duration>5__2 = 1f;
            this.<>1__state = 0;
            val_4 = 1152921511074432724;
            mem[1152921511074432728] = 0;
            this.<>4__this.audioSource.volume = null;
        }
        else
        {
                val_3 = this.<duration>5__2;
            val_4 = this.<t>5__3;
            this.<>1__state = 0;
        }
        
        if((this.<>1__state) > 1)
        {
                return (bool)val_2;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        float val_2 = val_3;
        val_2 = 0 / val_2;
        val_5 = val_4 + val_2;
        mem2[0] = val_5;
        if((this.<>4__this) == 0)
        {
                val_5 = mem[this.<t>5__3];
            val_5 = val_4;
        }
        
        val_4 = 0;
        this.<>4__this.audioSource.volume = val_2;
        val_2 = 1;
        this.<>1__state = val_2;
        this.<>2__current = val_4;
        return (bool)val_2;
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
