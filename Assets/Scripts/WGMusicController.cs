using UnityEngine;
public class WGMusicController : MonoBehaviour
{
    // Fields
    public UnityEngine.AudioSource source;
    public WGAudioDefinition definition;
    private MusicType currentMusicType;
    private float musicVolume;
    private int currentTrack;
    
    // Properties
    public MusicType CurrentType { get; }
    public int CurrentTrack { get; }
    
    // Methods
    public MusicType get_CurrentType()
    {
    
    }
    public int get_CurrentTrack()
    {
        return (int)this.currentTrack;
    }
    public bool IsPlaying()
    {
        if(this.source == 0)
        {
                return false;
        }
        
        if(this.source != 0)
        {
                return this.source.isPlaying;
        }
        
        return this.source.isPlaying;
    }
    private void Start()
    {
        object val_1 = this.GetComponent<System.Object>();
        this.source = this;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WGAudioDefinition val_3 = GetDefinition();
        this.definition = public static WGAudioController MonoSingleton<WGAudioController>::get_Instance();
        this.musicVolume = public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_20;
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
    public void ToggleMute(bool mute)
    {
        if(this.source == 0)
        {
                return;
        }
        
        this.source.mute = mute;
    }
    public void FadeOutMusic()
    {
        if(this.source == 0)
        {
                return;
        }
        
        System.Collections.IEnumerator val_2 = R4.FadeOut();
        UnityEngine.Coroutine val_3 = R4.StartCoroutine(routine:  R4);
    }
    public void Play(MusicType type, int trackIndex = 0)
    {
        if(type == 2)
        {
                return;
        }
        
        if(this.currentMusicType == type)
        {
                this.currentMusicType = this.currentTrack;
        }
        
        if(this.currentMusicType == trackIndex)
        {
            goto label_1;
        }
        
        label_4:
        System.Collections.IEnumerator val_1 = this.PlayNewMusic(type:  type, track:  trackIndex);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -284745568);
        return;
        label_1:
        if(this.source.isPlaying == true)
        {
                return;
        }
        
        goto label_4;
    }
    public void PlayRandomMusicTrack(MusicType type)
    {
        if(type == 2)
        {
                return;
        }
        
        35630612 = this.source;
        if(35630612 == 0)
        {
                return;
        }
        
        if(type != 1)
        {
                if(type != 0)
        {
                return;
        }
        
            this.Play(type:  0, trackIndex:  UnityEngine.Random.Range(min:  0, max:  0));
            return;
        }
        
        this.Play(type:  1, trackIndex:  UnityEngine.Random.Range(min:  0, max:  0));
    }
    private System.Collections.IEnumerator FadeOut()
    {
        object val_1 = new System.Object();
        typeof(WGMusicController.<FadeOut>d__17).__il2cppRuntimeField_8 = 0;
        typeof(WGMusicController.<FadeOut>d__17).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator FadeIn()
    {
        object val_1 = new System.Object();
        typeof(WGMusicController.<FadeIn>d__18).__il2cppRuntimeField_8 = 0;
        typeof(WGMusicController.<FadeIn>d__18).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator PlayNewMusic(MusicType type, int track)
    {
        typeof(WGMusicController.<PlayNewMusic>d__19).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(WGMusicController.<PlayNewMusic>d__19).__il2cppRuntimeField_10 = type;
            typeof(WGMusicController.<PlayNewMusic>d__19).__il2cppRuntimeField_14 = this;
        }
        else
        {
                mem[20] = this;
            mem[16] = type;
        }
        
        typeof(WGMusicController.<PlayNewMusic>d__19).__il2cppRuntimeField_18 = track;
    }
    private void UpdateSetting()
    {
        bool val_1 = UnityEngine.Object.op_Equality(x:  this.source, y:  0);
        if(val_1 == true)
        {
                return;
        }
        
        if(val_1.IsEnabled() != false)
        {
                mem2[0] = 2;
            R4.Play(type:  R4 + 20, trackIndex:  R4 + 28);
            return;
        }
        
        SLCDebug.Log(logMessage:  -284135840, colorHash:  -1835139200, isError:  false);
        R4 + 12.Stop();
    }
    private void StopSource()
    {
        this.source.Stop();
    }
    private void PlaySource()
    {
        this.source.Play();
    }
    public WGMusicController()
    {
        this.currentMusicType = 2;
        this.musicVolume = 1f;
    }

}
