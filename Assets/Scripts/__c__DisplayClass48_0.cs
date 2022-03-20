using UnityEngine;
private sealed class WFOForestManager.<>c__DisplayClass48_0
{
    // Fields
    public int forestId;
    
    // Methods
    public WFOForestManager.<>c__DisplayClass48_0()
    {
    
    }
    internal bool <GetForestLayout>b__0(WordForest.WFOForestContent n)
    {
        int val_1 = this.forestId;
        val_1 = n.forestId - val_1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }

}
