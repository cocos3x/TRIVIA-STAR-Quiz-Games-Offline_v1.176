using UnityEngine;
private sealed class TRVYouBetchaBetPopup.<WaitForCoinAnimation>d__13 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVYouBetchaBetPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVYouBetchaBetPopup.<WaitForCoinAnimation>d__13(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        var val_4;
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
        UUI_EventsController.EnableInputs();
        var val_3 = 27311823;
        val_3 = 8315068 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        val_3 = 0;
        TRVMainController.noAnswerSelectedCharacter = val_3;
        UnityEngine.GameObject val_2 = this.<>4__this.gameObject;
        SLCWindow.CloseWindow(window:  this.<>4__this, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
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
