using UnityEngine;
public class MinigameAudioDefinition : ScriptableObject
{
    // Fields
    public System.Collections.Generic.List<UnityEngine.AudioClip> musicClips;
    public System.Collections.Generic.List<UnityEngine.AudioClip> buttonClickClips;
    public System.Collections.Generic.List<ClipObjects> gameSpecificClips;
    
    // Methods
    public MinigameAudioDefinition()
    {
    
    }

}
