using UnityEngine;
private sealed class WGMusicController.<FadeIn>d__18 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGMusicController <>4__this;
    private float <duration>5__2;
    private float <t>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGMusicController.<FadeIn>d__18(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        UnityEngine.AudioSource val_3;
        val_2 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_2;
        }
        
            this.<>1__state = 0;
            this.<duration>5__2 = 1f;
            this.<t>5__3 = 0f;
            val_3 = this.<>4__this.source;
            val_3.volume = null;
        }
        else
        {
                this.<>1__state = 0;
        }
        
        if((this.<>4__this) > 0)
        {
                return (bool)val_2;
        }
        
        float val_3 = this.<t>5__3;
        val_3 = 0;
        float val_1 = UnityEngine.Time.deltaTime;
        float val_2 = this.<>4__this.musicVolume;
        val_2 = 0 * val_2;
        val_2 = val_2 / (this.<duration>5__2);
        val_3 = val_3 + val_2;
        this.<t>5__3 = val_3;
        this.<>4__this.source.volume = val_2;
        val_2 = 1;
        this.<>1__state = val_2;
        this.<>2__current = val_3;
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
