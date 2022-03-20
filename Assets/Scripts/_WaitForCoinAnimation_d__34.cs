using UnityEngine;
private sealed class TRVPromoCategoriesPopup.<WaitForCoinAnimation>d__34 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVPromoCategoriesPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVPromoCategoriesPopup.<WaitForCoinAnimation>d__34(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        var val_5;
        var val_6;
        if((this.<>1__state) != 1)
        {
                val_4 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = null;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_4 = 1;
            this.<>1__state = val_4;
            this.<>2__current = val_1;
            return (bool)val_4;
        }
        
        this.<>1__state = 0;
        UUI_EventsController.EnableInputs();
        var val_4 = 23617695;
        val_4 = 12009196 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        TRVMainController.noAnswerSelectedCharacter = 3;
        var val_5 = 23616463;
        val_5 = 12009328 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 4;
        GameBehavior val_2 = App.getBehavior;
        val_4 = 0;
        UnityEngine.GameObject val_3 = this.<>4__this.gameObject;
        SLCWindow.CloseWindow(window:  this.<>4__this, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        return (bool)val_4;
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
