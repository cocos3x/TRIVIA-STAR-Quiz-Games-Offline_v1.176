using UnityEngine;
[Serializable]
public class ThemeSettings
{
    // Fields
    public UnityEngine.Color lineDragColor;
    public UnityEngine.Color tileHighlightColor;
    public Cell cellTile;
    public LetterTile LetterTile;
    
    // Methods
    public ThemeSettings()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        UnityEngine.Color val_2 = UnityEngine.Color.white;
    }

}
