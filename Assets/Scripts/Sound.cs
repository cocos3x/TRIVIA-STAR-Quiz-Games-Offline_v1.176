using UnityEngine;
public class Sound : MonoBehaviour
{
    // Fields
    public UnityEngine.AudioSource audioSource;
    public UnityEngine.AudioSource loopAudioSource;
    public UnityEngine.AudioClip[] buttonClips;
    public UnityEngine.AudioClip[] otherClips;
    public UnityEngine.AudioClip coinDeposit;
    public UnityEngine.AudioClip coinCollect;
    private static Sound _instance;
    
    // Properties
    public static Sound instance { get; set; }
    
    // Methods
    public static Sound get_instance()
    {
        if((UnityEngine.Object.op_Implicit(exists:  Sound._instance)) == true)
        {
                return;
        }
        
        Sound._instance = new UnityEngine.MonoBehaviour();
    }
    public static void set_instance(Sound value)
    {
        Sound._instance = value;
    }
    private void Awake()
    {
        Sound._instance = this;
    }
    private void Start()
    {
        this.UpdateSetting();
    }
    public bool IsMuted()
    {
        UnityEngine.Debug.LogError(message:  -2120309568);
        bool val_1 = IsEnabled();
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public bool IsEnabled()
    {
        UnityEngine.Debug.LogError(message:  -2120309568);
        return CPlayerPrefs.GetBool(key:  -2120197360, defaultValue:  true);
    }
    public void SetEnabled(bool enabled)
    {
        UnityEngine.Debug.LogError(message:  -2120309568);
        CPlayerPrefs.SetBool(key:  -2120197360, value:  enabled);
        this.UpdateSetting();
    }
    public void Play(UnityEngine.AudioClip clip)
    {
        UnityEngine.Debug.LogError(message:  -2120309568);
        this.audioSource.pitch = null;
        this.audioSource.PlayOneShot(clip:  clip);
    }
    public void Play(UnityEngine.AudioClip clip, float pitch)
    {
        UnityEngine.Debug.LogError(message:  -2120309568);
        this.audioSource.pitch = pitch;
        this.audioSource.PlayOneShot(clip:  clip);
    }
    public void Play(UnityEngine.AudioSource audioSource)
    {
        UnityEngine.Debug.LogError(message:  -2120309568);
        if(IsEnabled() == false)
        {
                return;
        }
        
        R4.Play();
    }
    public void PlayButton(Sound.Button type = 0)
    {
        this.Play(clip:  this.buttonClips[type]);
    }
    public void Play(Sound.Others type, float volume = 1)
    {
        this.audioSource.volume = volume;
        this.Play(clip:  this.otherClips[type]);
    }
    public void PlayLooping(Sound.Others type, float volume = 1)
    {
        this.loopAudioSource.volume = volume;
        this.loopAudioSource.PlayOneShot(clip:  this.otherClips[type]);
    }
    public void StopLooping()
    {
        this.loopAudioSource.Stop();
    }
    public void UpdateSetting()
    {
        this.audioSource.mute = this.IsMuted();
        this.loopAudioSource.mute = this.IsMuted();
    }
    public Sound()
    {
    
    }

}
