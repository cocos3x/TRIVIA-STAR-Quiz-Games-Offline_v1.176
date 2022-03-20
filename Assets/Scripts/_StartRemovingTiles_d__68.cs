using UnityEngine;
private sealed class MPIBoardController.<StartRemovingTiles>d__68 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.MatchyPics.MPIBoardController <>4__this;
    public SLC.MatchyPics.MPIGridTile tileA;
    public SLC.MatchyPics.MPIGridTile tileB;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MPIBoardController.<StartRemovingTiles>d__68(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        object val_4;
        val_3 = 0;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
        this.<>1__state = 0;
        0.ProgressiveMatchSound();
        UnityEngine.WaitForSeconds val_1 = null;
        val_4 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_3 = 1;
        this.<>1__state = val_3;
        goto label_5;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.OnRemoveTilesFinish();
        return (bool)val_3;
        label_2:
        this.<>1__state = 0;
        this.tileA.Hide();
        this.tileB.Hide();
        this.<>4__this.lineDrawer.ClearPath();
        UnityEngine.WaitForSeconds val_2 = null;
        val_4 = val_2;
        val_2 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_3 = 1;
        this.<>1__state = 2;
        label_5:
        this.<>2__current = val_4;
        return (bool)val_3;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
