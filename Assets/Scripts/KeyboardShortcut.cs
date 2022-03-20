using UnityEngine;
[Serializable]
public sealed class Settings.KeyboardShortcut
{
    // Fields
    public SRDebugger.Settings.ShortcutActions Action;
    public bool Alt;
    public bool Control;
    public UnityEngine.KeyCode Key;
    public bool Shift;
    
    // Methods
    public Settings.KeyboardShortcut()
    {
    
    }

}
