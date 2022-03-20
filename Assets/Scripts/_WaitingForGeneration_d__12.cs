using UnityEngine;
private sealed class WGWindowManager.<WaitingForGeneration>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGWindowManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGWindowManager.<WaitingForGeneration>d__12(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3 = 0;
        if((this.<>1__state) >= 2)
        {
                return (bool)val_3;
        }
        
        this.<>1__state = 0;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                val_3 = 1;
            this.<>1__state = val_3;
            this.<>2__current = new UnityEngine.WaitForEndOfFrame();
            return (bool)val_3;
        }
        
        val_3 = 0;
        this.<>4__this.ShowAvailablePopups(fromMinimize:  false, entry:  87328000);
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
