using UnityEngine;
public class WGAudioDefinition : ScriptableObject
{
    // Fields
    public UnityEngine.AudioClip[] generalClips;
    public UnityEngine.AudioClip[] buttonClips;
    public string newItemId;
    public UnityEngine.AudioClip newItemClips;
    public bool fadeBetweenTracks;
    public float defaultMusicVolume;
    public System.Collections.Generic.List<UnityEngine.AudioClip> menuMusic;
    public System.Collections.Generic.List<UnityEngine.AudioClip> gameplayMusic;
    public System.Collections.Generic.List<ClipObjects> gameSpecificClips;
    
    // Methods
    public WGAudioDefinition()
    {
        this.defaultMusicVolume = 1f;
        this.fadeBetweenTracks = true;
    }

}
