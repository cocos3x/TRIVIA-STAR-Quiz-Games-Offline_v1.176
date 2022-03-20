using UnityEngine;
public class WGAudioController : MonoSingleton<WGAudioController>
{
    // Fields
    public WGSoundController sound;
    public WGMusicController music;
    private WGAudioDefinition definition;
    
    // Methods
    public WGAudioDefinition GetDefinition()
    {
        bool val_1 = UnityEngine.Object.op_Equality(x:  this.definition, y:  0);
        if(val_1 == true)
        {
                val_1 = this;
            this.LoadDefinition();
        }
    
    }
    public bool IsSoundEnabled()
    {
        if(this.sound == 0)
        {
                return false;
        }
        
        if(this.sound != 0)
        {
                return this.sound.IsEnabled();
        }
        
        return this.sound.IsEnabled();
    }
    public bool IsMusicEnabled()
    {
        if(this.music == 0)
        {
                return false;
        }
        
        if(this.music != 0)
        {
                return this.music.IsEnabled();
        }
        
        return this.music.IsEnabled();
    }
    public bool IsMusicPlaying()
    {
        if(this.music == 0)
        {
                return false;
        }
        
        if(this.music != 0)
        {
                return this.music.IsPlaying();
        }
        
        return this.music.IsPlaying();
    }
    public void ToggleMute(bool mute)
    {
        if(this.music != 0)
        {
                this.music.ToggleMute(mute:  mute);
        }
        
        if(this.sound == 0)
        {
                return;
        }
        
        this.sound.ToggleMute(mute:  mute);
    }
    private void LoadDefinition()
    {
        var val_5;
        var val_5 = 27173863;
        val_5 = 8451924 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        typeof(System.String[]).__il2cppRuntimeField_10 = "game/";
        typeof(System.String[]).__il2cppRuntimeField_14 = null;
        typeof(System.String[]).__il2cppRuntimeField_18 = "/";
        typeof(System.String[]).__il2cppRuntimeField_1C = null;
        typeof(System.String[]).__il2cppRuntimeField_20 = "_AudioDefinition";
        string val_1 = +477709520;
        object val_2 = UnityEngine.Resources.Load<System.Object>(path:  477709520);
        this.definition = null;
        if(477709520 != 0)
        {
                return;
        }
        
        string val_4 = -298886576(-298886576) + 295313408 + -298886736(-298886736) + 295313408;
        UnityEngine.Debug.LogError(message:  -298886576);
    }
    public WGAudioController()
    {
    
    }

}
