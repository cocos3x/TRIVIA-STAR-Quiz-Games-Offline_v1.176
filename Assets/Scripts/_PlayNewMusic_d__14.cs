using UnityEngine;
private sealed class Music.<PlayNewMusic>d__14 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Music.Type type;
    public Music <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Music.<PlayNewMusic>d__14(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_8;
        UnityEngine.AudioClip val_9;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_8 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_8;
        }
        
        this.<>1__state = 0;
        typeof(System.Object[]).__il2cppRuntimeField_10 = "Playing new music (";
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = ") <COLOR=#DDFF99>";
        UnityEngine.AudioClip val_8 = this.<>4__this.musicClips[this.type];
        string val_1 = val_8.name;
        typeof(System.Object[]).__il2cppRuntimeField_1C = val_8;
        typeof(System.Object[]).__il2cppRuntimeField_20 = "</COLOR>";
        string val_2 = +472754880;
        val_9 = this.<>4__this.musicClips[this.type];
        UnityEngine.Debug.Log(message:  472754880, context:  val_9);
        if((this.<>4__this.fadeBetweenTracks) == false)
        {
            goto label_29;
        }
        
        System.Collections.IEnumerator val_3 = this.<>4__this.FadeOut();
        UnityEngine.Coroutine val_4 = this.<>4__this.StartCoroutine(routine:  this.<>4__this);
        val_8 = 1;
        this.<>1__state = val_8;
        this.<>2__current = this.<>4__this;
        return (bool)val_8;
        label_1:
        this.<>1__state = 0;
        label_29:
        this.<>4__this.audioSource.Stop();
        val_9 = this.<>4__this.musicClips;
        this.<>4__this.currentType = this.type;
        this.<>4__this.audioSource.clip = val_9[this.type];
        if((this.<>4__this.audioSource.IsEnabled()) != false)
        {
                this.<>4__this.audioSource.Play();
        }
        
        if((this.<>4__this.fadeBetweenTracks) != false)
        {
                System.Collections.IEnumerator val_6 = this.<>4__this.FadeIn();
            val_8 = 0;
            UnityEngine.Coroutine val_7 = this.<>4__this.StartCoroutine(routine:  this.<>4__this);
            return (bool)val_8;
        }
        
        val_8 = 0;
        this.<>4__this.audioSource.volume = null;
        return (bool)val_8;
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
