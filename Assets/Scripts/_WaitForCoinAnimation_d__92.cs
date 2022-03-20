using UnityEngine;
private sealed class TRVLevelComplete.<WaitForCoinAnimation>d__92 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVLevelComplete <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVLevelComplete.<WaitForCoinAnimation>d__92(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        if((this.<>1__state) != 1)
        {
                val_7 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_7;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = null;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_7 = 1;
            this.<>1__state = val_7;
            this.<>2__current = val_1;
            return (bool)val_7;
        }
        
        this.<>1__state = 0;
        UUI_EventsController.EnableInputs();
        this.<>4__this.TryShowFomoOnComplete();
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_3 = ShowInterstitial(context:  2);
        if((this.<>4__this) != 0)
        {
                UnityEngine.GameObject val_4 = this.<>4__this.gameObject;
            SLCWindow.CloseWindow(window:  this.<>4__this, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        else
        {
                UnityEngine.GameObject val_5 = 0.gameObject;
            SLCWindow.CloseWindow(window:  0, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        }
        
        if((this.<>4__this.playNextLevelAction) != 0)
        {
                val_7 = 0;
            this.<>4__this.playNextLevelAction.Invoke();
            return (bool)val_7;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_7 = 0;
        Init(currentlySelectedCategores:  0, fromReroll:  false);
        return (bool)val_7;
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
