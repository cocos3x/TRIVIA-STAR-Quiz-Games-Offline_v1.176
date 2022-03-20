using UnityEngine;
[Serializable]
public class WSSounds : ScriptableObject
{
    // Fields
    public WSSounds.MusicChanging changeMusic;
    public UnityEngine.AudioClip selectForward;
    public UnityEngine.AudioClip selectBack;
    public UnityEngine.AudioClip showingChapters;
    public UnityEngine.AudioClip selectLevel;
    public UnityEngine.AudioClip[] highlightSuccess;
    public UnityEngine.AudioClip highlightFailure;
    public UnityEngine.AudioClip[] winSound;
    public UnityEngine.AudioClip hintSound;
    public UnityEngine.AudioClip startBoard;
    public UnityEngine.AudioClip clearBoard;
    public UnityEngine.AudioClip levelComplete;
    public UnityEngine.AudioClip coinCollect;
    public UnityEngine.AudioClip coinDeposit;
    public UnityEngine.AudioClip selectAdd;
    public UnityEngine.AudioClip selectRemove;
    
    // Methods
    public WSSounds()
    {
    
    }

}
