using UnityEngine;
private sealed class MPIBoardController.<>c__DisplayClass67_0
{
    // Fields
    public int timeElapsed;
    
    // Methods
    public MPIBoardController.<>c__DisplayClass67_0()
    {
    
    }
    internal void <LoadTiles>b__0(SLC.MatchyPics.MPIGridTile tile)
    {
        tile.InitTimeTiles(timeElapsed:  this.timeElapsed);
    }

}
