using UnityEngine;
public class MinigameAudioController : MonoSingleton<MinigameAudioController>
{
    // Fields
    private MinigameAudioDefinition definition;
    private UnityEngine.AudioSource musicSource;
    private UnityEngine.AudioSource soundSource;
    private UnityEngine.AudioClip coinCollectSFX;
    
    // Methods
    private void Start()
    {
        if(this.definition == 0)
        {
                UnityEngine.Debug.LogError(message:  -1748843472);
        }
        
        bool val_2 = IsSoundEnabled();
        if(val_2 == true)
        {
                0 = 0;
        }
        
        if(val_2 == false)
        {
                0 = 1;
        }
        
        this.soundSource.mute = true;
        bool val_3 = this.soundSource.IsMusicEnabled();
        if(val_3 == false)
        {
                0 = 1;
        }
        
        if(val_3 == true)
        {
                0 = 0;
        }
        
        this.musicSource.mute = false;
    }
    public void StartMusic(int clipIndex = 0)
    {
        if(this.IsMusicEnabled() == false)
        {
                return;
        }
        
        this.musicSource.Stop();
        if(this.musicSource <= clipIndex)
        {
                var val_2 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = val_2 + (clipIndex << 2);
        this.musicSource.clip = (0 + (clipIndex) << 2) + 16;
        this.musicSource.Play();
    }
    public void StopMusic()
    {
        this.musicSource.Stop();
    }
    public void PlayButtonSound(int clipIndex = 0, float volumeScale = 1)
    {
        bool val_1 = this.IsSoundEnabled();
        if(val_1 == false)
        {
                return;
        }
        
        if(val_1 <= clipIndex)
        {
                var val_2 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = val_2 + (clipIndex << 2);
        this.PlayOneShot(clip:  (0 + (clipIndex) << 2) + 16, volumeScale:  volumeScale);
    }
    public void PlayGameSpecificSound(string id, int clipIndex = 0, float volumeScale = 1)
    {
        typeof(MinigameAudioController.<>c__DisplayClass8_0).__il2cppRuntimeField_8 = id;
        if(new System.Object().IsSoundEnabled() == false)
        {
                return;
        }
        
        System.Predicate<ZooTile> val_3 = new System.Predicate<ZooTile>(object:  297123840, method:  new IntPtr(2546670256));
        ClipObjects val_4 = this.definition.gameSpecificClips.Find(match:  8040448);
        if(this.definition.gameSpecificClips != 0)
        {
                System.Collections.Generic.List<ClipObjects> val_5 = this.definition.gameSpecificClips + (clipIndex << 2);
            this.PlayOneShot(clip:  0, volumeScale:  volumeScale);
            return;
        }
        
        string val_6 = -1748293760(-1748293760) + typeof(MinigameAudioController.<>c__DisplayClass8_0).__il2cppRuntimeField_8(typeof(MinigameAudioController.<>c__DisplayClass8_0).__il2cppRuntimeField_8) + -1748293968(-1748293968);
        UnityEngine.Debug.LogError(message:  -1748293760);
    }
    public void PlayGameSpecificSound(string id, float volumeScale)
    {
        typeof(MinigameAudioController.<>c__DisplayClass9_0).__il2cppRuntimeField_8 = id;
        if(new System.Object().IsSoundEnabled() == false)
        {
                return;
        }
        
        System.Predicate<ZooTile> val_3 = new System.Predicate<ZooTile>(object:  297177088, method:  new IntPtr(2546810256));
        ClipObjects val_4 = this.definition.gameSpecificClips.Find(match:  8040448);
        if(this.definition.gameSpecificClips != 0)
        {
                this.PlayOneShot(clip:  System.Predicate<T>.__il2cppRuntimeField_byval_arg, volumeScale:  volumeScale);
            return;
        }
        
        string val_5 = -1748293760(-1748293760) + typeof(MinigameAudioController.<>c__DisplayClass9_0).__il2cppRuntimeField_8(typeof(MinigameAudioController.<>c__DisplayClass9_0).__il2cppRuntimeField_8) + -1748293968(-1748293968);
        UnityEngine.Debug.LogError(message:  -1748293760);
    }
    public void PlayGameSpecificSound(string id, bool randomIndex, float volumeScale = 1)
    {
        var val_7;
        typeof(MinigameAudioController.<>c__DisplayClass10_0).__il2cppRuntimeField_8 = id;
        if(new System.Object().IsSoundEnabled() == false)
        {
                return;
        }
        
        System.Predicate<ZooTile> val_3 = new System.Predicate<ZooTile>(object:  297230336, method:  new IntPtr(2546947856));
        ClipObjects val_4 = this.definition.gameSpecificClips.Find(match:  8040448);
        if(this.definition.gameSpecificClips != 0)
        {
                val_7 = 0;
            if(randomIndex != false)
        {
                int val_5 = UnityEngine.Random.Range(min:  0, max:  0);
            val_7 = val_5;
        }
        
            val_5 = this.definition.gameSpecificClips + (val_7 << 2);
            this.PlayOneShot(clip:  0, volumeScale:  volumeScale);
            return;
        }
        
        string val_6 = -1748293760(-1748293760) + typeof(MinigameAudioController.<>c__DisplayClass10_0).__il2cppRuntimeField_8(typeof(MinigameAudioController.<>c__DisplayClass10_0).__il2cppRuntimeField_8) + -1748293968(-1748293968);
        UnityEngine.Debug.LogError(message:  -1748293760);
    }
    public void PlayCoinCollect()
    {
        if(this.IsSoundEnabled() == false)
        {
                return;
        }
        
        if((R4 + 24) != 0)
        {
                R4.PlayOneShot(clip:  R4 + 24, volumeScale:  null);
            return;
        }
        
        UnityEngine.Debug.LogError(message:  -1747894128);
    }
    private void PlayOneShot(UnityEngine.AudioClip clip, float volumeScale = 1)
    {
        this.soundSource.pitch = volumeScale;
        this.soundSource.PlayOneShot(clip:  clip, volumeScale:  volumeScale);
    }
    public bool IsSoundMuted()
    {
        bool val_1 = this.IsSoundEnabled();
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public bool IsSoundEnabled()
    {
        return CPlayerPrefs.GetBool(key:  -2120197360, defaultValue:  true);
    }
    public bool IsMusicMuted()
    {
        bool val_1 = this.IsMusicEnabled();
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public bool IsMusicEnabled()
    {
        return CPlayerPrefs.GetBool(key:  -2124605408, defaultValue:  true);
    }
    public MinigameAudioController()
    {
    
    }

}
