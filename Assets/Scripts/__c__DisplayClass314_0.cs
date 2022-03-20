using UnityEngine;
private sealed class GameEcon.<>c__DisplayClass314_0
{
    // Fields
    public int currPackId;
    
    // Methods
    public GameEcon.<>c__DisplayClass314_0()
    {
    
    }
    internal bool <ReadFromKnobs>b__0(CategoryPackInfo obj)
    {
        int val_1 = this.currPackId;
        val_1 = obj.packId - val_1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }

}
