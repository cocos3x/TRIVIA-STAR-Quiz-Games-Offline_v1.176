using UnityEngine;
private sealed class MPIBoardController.<>c__DisplayClass47_0
{
    // Fields
    public int timeElapsed;
    
    // Methods
    public MPIBoardController.<>c__DisplayClass47_0()
    {
    
    }
    internal void <UpdateTilesTimer>b__0(SLC.MatchyPics.MPIGridTile t)
    {
        t.UpdateTimer(timeElapsed:  this.timeElapsed);
    }

}
