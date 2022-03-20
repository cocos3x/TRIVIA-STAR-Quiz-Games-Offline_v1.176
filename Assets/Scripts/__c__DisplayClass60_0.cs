using UnityEngine;
private sealed class GridCell.<>c__DisplayClass60_0
{
    // Fields
    public BlockPuzzleMagic.Block blockToDestroy;
    public BlockPuzzleMagic.GridCell <>4__this;
    
    // Methods
    public GridCell.<>c__DisplayClass60_0()
    {
    
    }
    internal void <ClearCell>b__1()
    {
        if(this.blockToDestroy != 0)
        {
                UnityEngine.GameObject val_2 = this.blockToDestroy.gameObject;
            UnityEngine.Object.Destroy(obj:  this.blockToDestroy);
        }
        
        this.<>4__this.RefreshVisualState();
    }

}
