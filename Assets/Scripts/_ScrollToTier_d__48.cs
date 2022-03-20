using UnityEngine;
private sealed class SeasonPassEventPopup.<ScrollToTier>d__48 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SeasonPassEventPopup <>4__this;
    public int tierIndex;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SeasonPassEventPopup.<ScrollToTier>d__48(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        object val_3;
        if((this.<>1__state) != 1)
        {
                val_2 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_2;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = null;
            val_3 = val_1;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_2 = 1;
            this.<>1__state = val_2;
            this.<>2__current = val_3;
            return (bool)val_2;
        }
        
        this.<>1__state = 0;
        val_3 = this.<>4__this.loopScrollRect;
        val_2 = 0;
        val_3.ScrollToCell(index:  this.tierIndex, speed:  null);
        return (bool)val_2;
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
