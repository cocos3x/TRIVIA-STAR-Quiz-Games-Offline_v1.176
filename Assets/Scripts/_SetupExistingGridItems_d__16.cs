using UnityEngine;
private sealed class UIListViewController.<SetupExistingGridItems>d__16 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UIListViewController <>4__this;
    private int <i>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public UIListViewController.<SetupExistingGridItems>d__16(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        int val_3;
        if((this.<>1__state) != 1)
        {
                val_2 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_2;
        }
        
            this.<>1__state = 0;
            this.<>4__this.ToggleLoadingPopup(state:  true);
            val_3 = 0;
        }
        else
        {
                this.<>1__state = 0;
            val_3 = (this.<i>5__2) + 1;
        }
        
        this.<i>5__2 = val_3;
        if(val_3 < (this.<i>5__2))
        {
                val_2 = 1;
            this.<>1__state = val_2;
            this.<>2__current = 0;
            return (bool)val_2;
        }
        
        if((this.<>4__this.OnFinishedUISetup) != 0)
        {
                this.<>4__this.OnFinishedUISetup.Invoke(obj:  true);
        }
        
        val_2 = 0;
        this.<>4__this.ToggleLoadingPopup(state:  false);
        this.<>4__this.populating = val_2;
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
