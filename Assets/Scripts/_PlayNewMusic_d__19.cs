using UnityEngine;
private sealed class WGMusicController.<PlayNewMusic>d__19 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public MusicType type;
    public WGMusicController <>4__this;
    public int track;
    private System.Collections.Generic.List<UnityEngine.AudioClip> <musicClips>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGMusicController.<PlayNewMusic>d__19(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_8;
        MusicType val_9;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_8 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_8;
        }
        
        val_9 = this.type;
        this.<>1__state = 0;
        if(val_9 == 0)
        {
                this.<>4__this.definition.gameplayMusic = this.<>4__this.definition.menuMusic;
        }
        
        this.<musicClips>5__2 = this.<>4__this.definition.menuMusic.SyncRoot;
        if((mem[this.<>4__this.definition.menuMusic.SyncRoot + 12]) < 1)
        {
                return (bool)val_8;
        }
        
        this.track = ;
        typeof(System.Object[]).__il2cppRuntimeField_10 = "Playing new music (";
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = ") <COLOR=#DDFF99>";
        var val_8 = 0;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_8 = val_8 + (this.track << 2);
        string val_1 = (0 + (this.track) << 2) + 16.name;
        typeof(System.Object[]).__il2cppRuntimeField_1C = (0 + (this.track) << 2) + 16;
        var val_9 = 0;
        typeof(System.Object[]).__il2cppRuntimeField_20 = "</COLOR>";
        string val_2 = +472754880;
        if(null <= this.track)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_9 = val_9 + (this.track << 2);
        val_9 = mem[(0 + (this.track) << 2) + 16];
        val_9 = (0 + (this.track) << 2) + 16;
        UnityEngine.Debug.Log(message:  472754880, context:  val_9);
        if((this.<>4__this.definition.fadeBetweenTracks) == false)
        {
            goto label_34;
        }
        
        System.Collections.IEnumerator val_3 = this.<>4__this.FadeOut();
        UnityEngine.Coroutine val_4 = this.<>4__this.StartCoroutine(routine:  this.<>4__this);
        val_8 = 1;
        this.<>1__state = val_8;
        this.<>2__current = this.<>4__this;
        return (bool)val_8;
        label_1:
        this.<>1__state = 0;
        label_34:
        this.<>4__this.source.Stop();
        this.<>4__this.currentMusicType = this.type;
        val_9 = this.track;
        this.<>4__this.currentTrack = val_9;
        if(this.type <= val_9)
        {
                var val_10 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_10 = val_10 + (val_9 << 2);
        this.<>4__this.source.clip = (0 + (this.track) << 2) + 16;
        if((this.<>4__this.source.IsEnabled()) != false)
        {
                this.<>4__this.source.Play();
        }
        
        if((this.<>4__this.definition.fadeBetweenTracks) != false)
        {
                System.Collections.IEnumerator val_6 = this.<>4__this.FadeIn();
            val_8 = 0;
            UnityEngine.Coroutine val_7 = this.<>4__this.StartCoroutine(routine:  this.<>4__this);
            return (bool)val_8;
        }
        
        val_8 = 0;
        this.<>4__this.source.volume = null;
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
