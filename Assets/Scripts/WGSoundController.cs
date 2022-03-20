using UnityEngine;
public class WGSoundController : MonoBehaviour
{
    // Fields
    private UnityEngine.AudioSource oneShotSource;
    private UnityEngine.AudioSource prioritySource;
    private WGAudioDefinition definition;
    
    // Methods
    private void Start()
    {
        T[] val_1 = this.GetComponents<System.Object>();
        if(this.oneShotSource != 0)
        {
                this.oneShotSource = this.prioritySource;
            if(this.oneShotSource >= 2)
        {
                this.oneShotSource = this.definition;
            this.prioritySource = this.oneShotSource;
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WGAudioDefinition val_3 = GetDefinition();
        this.definition = public static WGAudioController MonoSingleton<WGAudioController>::get_Instance();
        this.UpdateSetting();
    }
    public void PlayButtonSound(WGAudioDefinition.ButtonClip type = 0, float pitch = 1, float vol = 1)
    {
        this.PlayOneShot(clip:  this.definition.buttonClips[type], pitch:  pitch, vol:  vol);
    }
    public void PlayGeneralSound(WGAudioDefinition.GeneralClip type, bool oneshot = True, float pitch = 1, float vol = 1)
    {
        float val_1;
        UnityEngine.AudioClip val_2 = this.definition.generalClips[type];
        if(oneshot != false)
        {
                this.PlayOneShot(clip:  val_2, pitch:  val_1, vol:  vol);
            return;
        }
        
        this.Play(clip:  val_2, pitch:  val_1, vol:  vol);
    }
    public void PlayGameSpecificSound(string id, int clipIndex = 0)
    {
        object val_1 = new System.Object();
        typeof(WGSoundController.<>c__DisplayClass6_0).__il2cppRuntimeField_8 = id;
        System.Predicate<ZooTile> val_2 = new System.Predicate<ZooTile>(object:  374759424, method:  new IntPtr(4014664496));
        ClipObjects val_3 = this.definition.gameSpecificClips.Find(match:  8040448);
        if(this.definition.gameSpecificClips != 0)
        {
                var val_4 = null + (clipIndex << 2);
            this.PlayOneShot(clip:  (null + (clipIndex) << 2) + 16, pitch:  null, vol:  null);
            return;
        }
        
        string val_5 = -1748293760(-1748293760) + typeof(WGSoundController.<>c__DisplayClass6_0).__il2cppRuntimeField_8(typeof(WGSoundController.<>c__DisplayClass6_0).__il2cppRuntimeField_8) + -1748293968(-1748293968);
        SLCDebug.Log(logMessage:  -1748293760, colorHash:  -1835139200, isError:  false);
    }
    public void PlayGameSpecificSound(string id, bool randomIndex, float vol = 1)
    {
        var val_6;
        object val_1 = new System.Object();
        typeof(WGSoundController.<>c__DisplayClass7_0).__il2cppRuntimeField_8 = id;
        System.Predicate<ZooTile> val_2 = new System.Predicate<ZooTile>(object:  374812672, method:  new IntPtr(4014802096));
        ClipObjects val_3 = this.definition.gameSpecificClips.Find(match:  8040448);
        if(this.definition.gameSpecificClips != 0)
        {
                val_6 = 0;
            if(randomIndex != false)
        {
                int val_4 = UnityEngine.Random.Range(min:  0, max:  0);
            val_6 = val_4;
        }
        
            val_4 = this.definition.gameSpecificClips + (val_6 << 2);
            this.PlayOneShot(clip:  0, pitch:  vol, vol:  null);
            return;
        }
        
        string val_5 = -1748293760(-1748293760) + typeof(WGSoundController.<>c__DisplayClass7_0).__il2cppRuntimeField_8(typeof(WGSoundController.<>c__DisplayClass7_0).__il2cppRuntimeField_8) + -1748293968(-1748293968);
        UnityEngine.Debug.LogError(message:  -1748293760);
    }
    public bool IsMuted()
    {
        bool val_1 = this.IsEnabled();
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public bool IsEnabled()
    {
        return CPlayerPrefs.GetBool(key:  -2120197360, defaultValue:  true);
    }
    public bool IsSoundPlaying()
    {
        if(this.oneShotSource != 0)
        {
                return this.oneShotSource.isPlaying;
        }
        
        return this.oneShotSource.isPlaying;
    }
    public bool IsSoundPlaying(WGAudioDefinition.GeneralClip type)
    {
        UnityEngine.AudioSource val_4 = this.prioritySource;
        if(val_4 == 0)
        {
                return false;
        }
        
        UnityEngine.AudioClip val_2 = this.prioritySource.clip;
        val_4 = this.prioritySource;
        if(val_4 != this.definition.generalClips[type])
        {
                return false;
        }
        
        if(this.prioritySource != 0)
        {
                return this.prioritySource.isPlaying;
        }
        
        return this.prioritySource.isPlaying;
    }
    public void SetEnabled(bool enabled, bool isTracking = True)
    {
        TrackerManager val_2;
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        string val_7;
        var val_8;
        val_2 = isTracking;
        val_3 = 35627645;
        if(val_2 != false)
        {
                var val_2 = 28562722;
            val_2 = 7062816 + val_2;
            if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
            val_4 = null;
            val_4 = null;
            val_5 = null;
            val_2 = App.trackerManager;
            if(enabled != false)
        {
                val_6 = null;
            val_7 = 1152921504891461788;
        }
        else
        {
                val_8 = null;
            val_7 = 1152921504891461792;
        }
        
            val_2.track(eventName:  val_7);
        }
        
        CPlayerPrefs.SetBool(key:  -2120197360, value:  enabled);
        this.UpdateSetting();
    }
    public void UpdateSetting()
    {
        this.oneShotSource.mute = this.IsEnabled() ^ 1;
        UnityEngine.AudioSource val_5 = this.prioritySource;
        bool val_3 = UnityEngine.Object.op_Inequality(x:  val_5, y:  0);
        if(val_3 == false)
        {
                return;
        }
        
        val_5 = val_3.IsEnabled() ^ 1;
        this.prioritySource.mute = val_5;
    }
    public void ToggleMute(bool mute)
    {
        if(mute != false)
        {
                this.oneShotSource.mute = true;
            if(this.prioritySource == 0)
        {
                return;
        }
        
            this.prioritySource.mute = true;
            return;
        }
        
        this.UpdateSetting();
    }
    private void PlayOneShot(UnityEngine.AudioClip clip, float pitch = 1, float vol = 1)
    {
        if(clip == 0)
        {
                return;
        }
        
        this.oneShotSource.pitch = pitch;
        this.oneShotSource.volume = pitch;
        this.oneShotSource.PlayOneShot(clip:  clip);
    }
    private void Play(UnityEngine.AudioClip clip, float pitch = 1, float vol = 1)
    {
        if(this.prioritySource == 0)
        {
                this.PlayOneShot(clip:  clip, pitch:  pitch, vol:  vol);
            return;
        }
        
        this.prioritySource.Stop();
        this.prioritySource.pitch = pitch;
        this.prioritySource.volume = pitch;
        this.prioritySource.clip = clip;
        this.prioritySource.Play();
    }
    public WGSoundController()
    {
    
    }

}
