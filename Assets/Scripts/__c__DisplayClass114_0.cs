using UnityEngine;
private sealed class PuzzleCollectionHandler.<>c__DisplayClass114_0
{
    // Fields
    public int i;
    public PuzzleCollectionHandler <>4__this;
    
    // Methods
    public PuzzleCollectionHandler.<>c__DisplayClass114_0()
    {
    
    }
    internal bool <GetNewPuzzleName>b__0(string n)
    {
        PuzzleCollectionHandler val_2 = this.<>4__this;
        System.String[] val_1 = val_2.CompletedPuzzles;
        val_2 = val_2 + (this.i << 2);
        return System.String.op_Inequality(a:  n, b:  (this.<>4__this + (this.i) << 2).shownCompletePopup);
    }

}
