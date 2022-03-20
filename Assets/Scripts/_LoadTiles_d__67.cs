using UnityEngine;
private sealed class MPIBoardController.<LoadTiles>d__67 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.MatchyPics.MPIBoardController <>4__this;
    private SLC.MatchyPics.MPIBoardController.<>c__DisplayClass67_0 <>8__1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MPIBoardController.<LoadTiles>d__67(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_14;
        int val_15;
        if((this.<>1__state) <= 3)
        {
                var val_1 = 9997828 + (9997828 + (this.<>1__state) << 2);
            if((this.<>1__state) == 3)
        {
                9997828 + (this.<>1__state) << 2 = (9997828 + (this.<>1__state) << 2) & ((9997828 + (this.<>1__state) << 2) << (9997828 + (this.<>1__state) << 2));
            9997828 + (this.<>1__state) << 2 = (9997828 + (this.<>1__state) << 2) & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ));
            9997828 + (this.<>1__state) << 2 = (9997828 + (this.<>1__state) << 2) & 1514706912;
        }
        
            this.<>1__state = 0;
            this.<>8__1 = new System.Object();
            UnityEngine.WaitForEndOfFrame val_3 = null;
            val_14 = val_3;
            val_3 = new UnityEngine.WaitForEndOfFrame();
            val_15 = 1;
            this.<>1__state = val_15;
            this.<>2__current = val_14;
            return (bool);
        }
        
        val_15 = 0;
        return (bool);
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
