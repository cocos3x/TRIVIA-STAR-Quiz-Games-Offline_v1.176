using UnityEngine;
public class Music : MonoSingleton<Music>
{
    // Fields
    public UnityEngine.AudioSource audioSource;
    public UnityEngine.AudioClip[] musicClips;
    private Music.Type currentType;
    public bool fadeBetweenTracks;
    
    // Methods
    public bool IsMuted()
    {
        bool val_1 = this.IsEnabled();
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public bool IsEnabled()
    {
        return CPlayerPrefs.GetBool(key:  -2124605408, defaultValue:  true);
    }
    public void SetEnabled(bool enabled, bool updateMusic = False)
    {
        CPlayerPrefs.SetBool(key:  -2124605408, value:  enabled);
        if(updateMusic == false)
        {
                return;
        }
        
        this.UpdateSetting();
    }
    public void Play(Music.Type type)
    {
        if(type == 0)
        {
                return;
        }
        
        if(this.currentType == type)
        {
                if(this.audioSource.isPlaying != false)
        {
                return;
        }
        
        }
        
        System.Collections.IEnumerator val_2 = this.PlayNewMusic(type:  type);
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  -2124345024);
    }
    public void Play(int trackNumber)
    {
        this.Play(type:  trackNumber);
    }
    public void Play()
    {
        this.Play(type:  this.currentType);
    }
    public void Stop()
    {
        System.Collections.IEnumerator val_1 = this.FadeOut();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -2123988544);
    }
    private System.Collections.IEnumerator FadeOut()
    {
        object val_1 = new System.Object();
        typeof(Music.<FadeOut>d__12).__il2cppRuntimeField_8 = 0;
        typeof(Music.<FadeOut>d__12).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator FadeIn()
    {
        object val_1 = new System.Object();
        typeof(Music.<FadeIn>d__13).__il2cppRuntimeField_8 = 0;
        typeof(Music.<FadeIn>d__13).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator PlayNewMusic(Music.Type type)
    {
        typeof(Music.<PlayNewMusic>d__14).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(Music.<PlayNewMusic>d__14).__il2cppRuntimeField_14 = this;
        }
        else
        {
                mem[20] = this;
        }
        
        typeof(Music.<PlayNewMusic>d__14).__il2cppRuntimeField_10 = type;
    }
    private void UpdateSetting()
    {
        bool val_1 = UnityEngine.Object.op_Equality(x:  this.audioSource, y:  0);
        if(val_1 == true)
        {
                return;
        }
        
        if(val_1.IsEnabled() != false)
        {
                mem2[0] = 0;
            R4.Play(type:  R4 + 20);
            return;
        }
        
        R4 + 12.Stop();
    }
    public Music()
    {
        this.fadeBetweenTracks = true;
    }

}
