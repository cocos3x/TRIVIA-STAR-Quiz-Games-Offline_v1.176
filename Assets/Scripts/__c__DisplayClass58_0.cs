using UnityEngine;
private sealed class MPIBoardController.<>c__DisplayClass58_0
{
    // Fields
    public System.Collections.Generic.HashSet<int> collectionItems;
    public SLC.MatchyPics.MPIBoardController <>4__this;
    
    // Methods
    public MPIBoardController.<>c__DisplayClass58_0()
    {
    
    }
    internal bool <SetTimedObject>b__0(SLC.MatchyPics.MPIGridTile i)
    {
        if((i.<tileData>k__BackingField.type) != 0)
        {
                return (bool)0;
        }
        
        if((this.collectionItems.Contains(item:  i.<tileData>k__BackingField.SpriteIndex)) == false)
        {
                return (bool)0;
        }
        
        0 = (this.<>4__this.HasSameAdjacentTiles(tile:  i)) ^ 1;
        return (bool)0;
    }

}
