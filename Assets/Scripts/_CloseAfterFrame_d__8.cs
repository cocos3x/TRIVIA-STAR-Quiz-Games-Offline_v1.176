using UnityEngine;
private sealed class LeaguesWelcome_Window.<CloseAfterFrame>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Social.Leagues.LeaguesWelcome_Window <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LeaguesWelcome_Window.<CloseAfterFrame>d__8(int <>1__state)
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
        if((this.<>1__state) != 1)
        {
                val_3 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForEndOfFrame val_1 = null;
            val_4 = val_1;
            val_1 = new UnityEngine.WaitForEndOfFrame();
            val_3 = 1;
            this.<>1__state = val_3;
            this.<>2__current = val_4;
            return (bool)val_3;
        }
        
        val_4 = this.<>4__this;
        this.<>1__state = 0;
        val_3 = 0;
        UnityEngine.GameObject val_2 = val_4.gameObject;
        SLCWindow.CloseWindow(window:  val_4, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
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
