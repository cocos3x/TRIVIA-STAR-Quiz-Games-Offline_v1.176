using UnityEngine;
private sealed class Guild.<>c__DisplayClass49_0
{
    // Fields
    public int id;
    
    // Methods
    public Guild.<>c__DisplayClass49_0()
    {
    
    }
    internal bool <GetRankInGuildById>b__4(SLC.Social.Profile x)
    {
        int val_1 = this.id;
        val_1 = x.ServerId - val_1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }

}
