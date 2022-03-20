using UnityEngine;
private sealed class TRVGameplayUI.<StartGame>d__27 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVGameplayUI <>4__this;
    private int <button>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVGameplayUI.<StartGame>d__27(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_22;
        UnityEngine.CanvasGroup val_23;
        object val_24;
        int val_25;
        val_22 = 0;
        if((this.<>1__state) > 4)
        {
                return (bool)val_22;
        }
        
        var val_1 = 8052368 + (8052368 + (this.<>1__state) << 2);
        if((this.<>1__state) == 4)
        {
                val_22 = 0;
            val_22 = val_22 & (((int)IP) >> val_22);
            val_22 = val_22 & ((IP) >> R3);
            val_22 = val_22 & (0 >> R3);
            val_22 = val_22 & (((0) << (32-R6)) | ((0) << R6));
        }
        
        this.<>1__state = 0;
        val_23 = this.<>4__this.gameplayCanvasGroup;
        val_23.alpha = null;
        System.Collections.IEnumerator val_2 = this.<>4__this.checkLevelFlyout();
        val_24 = this.<>4__this;
        val_25 = 1;
        val_22 = 1;
        this.<>2__current = ;
        this.<>1__state = ;
        return (bool)val_22;
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
