using UnityEngine;
[Serializable]
public class WADSounds : ScriptableObject
{
    // Fields
    public UnityEngine.AudioClip bgm_menu;
    public UnityEngine.AudioClip bgm_gameplay;
    public UnityEngine.AudioClip level_clear;
    public UnityEngine.AudioClip chapter_clear;
    public UnityEngine.AudioClip word_success;
    public UnityEngine.AudioClip word_starred_success;
    public UnityEngine.AudioClip word_extra;
    public UnityEngine.AudioClip word_extra_exists;
    public UnityEngine.AudioClip word_exists;
    public UnityEngine.AudioClip word_incorrect;
    public UnityEngine.AudioClip shuffle;
    public UnityEngine.AudioClip hint;
    public UnityEngine.AudioClip coins_gained;
    public UnityEngine.AudioClip[] letter_select;
    
    // Methods
    public WADSounds()
    {
    
    }

}
