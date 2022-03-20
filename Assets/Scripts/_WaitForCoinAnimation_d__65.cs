using UnityEngine;
private sealed class FPHLevelCompletePopup.<WaitForCoinAnimation>d__65 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public FPHLevelCompletePopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FPHLevelCompletePopup.<WaitForCoinAnimation>d__65(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        if((this.<>1__state) != 1)
        {
                val_3 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = null;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_3 = 1;
            this.<>1__state = val_3;
            this.<>2__current = val_1;
            return (bool)val_3;
        }
        
        this.<>1__state = 0;
        GameBehavior val_2 = App.getBehavior;
        val_3 = 0;
        UUI_EventsController.EnableInputs();
        this.<>4__this.Close(showAd:  true);
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
