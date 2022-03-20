using UnityEngine;
private sealed class WordJumbleFTUX.<>c__DisplayClass6_0
{
    // Fields
    public char character;
    
    // Methods
    public WordJumbleFTUX.<>c__DisplayClass6_0()
    {
    
    }
    internal bool <FillListWithTilesSequentially>b__0(SLC.Minigames.WordJumble.WordJumbleLetterTile x)
    {
        char val_1 = this.character;
        val_1 = (x.<character>k__BackingField) - val_1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }

}
