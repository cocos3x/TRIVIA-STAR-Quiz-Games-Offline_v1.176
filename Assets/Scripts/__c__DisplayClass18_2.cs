using UnityEngine;
private sealed class TRVTriviaPursuitEventHandler.<>c__DisplayClass18_2
{
    // Fields
    public TriviaPursuitCategory chosenUnfinishedCategory;
    
    // Methods
    public TRVTriviaPursuitEventHandler.<>c__DisplayClass18_2()
    {
    
    }
    internal bool <GetEventsRegisteredCategories>b__2(TriviaPursuitCategory x)
    {
        TriviaPursuitCategory val_1 = this.chosenUnfinishedCategory;
        val_1 = val_1 - x;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }

}
