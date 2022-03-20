using UnityEngine;
private sealed class Music.<FadeOut>d__12 : IEnumerator<object>, IEnumerator, IDisposable
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
    public Music.<FadeOut>d__12(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Music val_2;
        int val_3;
        float val_4;
        float val_5;
        float val_6;
        float val_7;
        val_2 = this.<>4__this;
        if((this.<>1__state) != 1)
        {
                val_3 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
            val_4 = this;
            this.<duration>5__2 = 1f;
            val_5 = 0f;
            this.<>1__state = 0;
            val_6 = 1152921511073718740;
            mem[1152921511073718744] = 0;
        }
        else
        {
                this.<>1__state = 0;
            if((this.<>1__state) > 1)
        {
                val_3 = 0;
            this.<>4__this.audioSource.Stop();
            return (bool)val_3;
        }
        
            val_4 = this.<duration>5__2;
            val_6 = this.<t>5__3;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        var val_2 = val_4;
        val_2 = 0 / val_2;
        val_7 = (this.<t>5__3) + val_2;
        mem2[0] = val_7;
        if(val_2 == 0)
        {
                val_7 = mem[this.<t>5__3];
            val_7 = val_6;
        }
        
        float val_3 = 1f;
        val_2 = 0;
        val_3 = val_3 - val_7;
        this.<>4__this.audioSource.volume = val_3;
        val_3 = 1;
        this.<>1__state = val_3;
        this.<>2__current = val_2;
        return (bool)val_3;
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
