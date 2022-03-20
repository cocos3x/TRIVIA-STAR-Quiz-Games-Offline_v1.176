using UnityEngine;
private sealed class WordBalloonGridGenerator.<>c__DisplayClass18_0
{
    // Fields
    public int currSlotId;
    
    // Methods
    public WordBalloonGridGenerator.<>c__DisplayClass18_0()
    {
    
    }
    internal bool <Generate>b__0(int slotUid)
    {
        int val_1 = this.currSlotId;
        val_1 = val_1 - slotUid;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }

}
