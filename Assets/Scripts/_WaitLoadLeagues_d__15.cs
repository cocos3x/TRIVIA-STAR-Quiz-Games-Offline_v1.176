using UnityEngine;
private sealed class WGLeaguesLoadingPopup.<WaitLoadLeagues>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGLeaguesLoadingPopup <>4__this;
    private UnityEngine.AsyncOperation <asyncLoad>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGLeaguesLoadingPopup.<WaitLoadLeagues>d__15(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_12;
        var val_13;
        UnityEngine.AsyncOperation val_14;
        var val_15;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_12 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_12;
        }
        
        this.<>1__state = 0;
        GameBehavior val_1 = App.getBehavior;
        ThemesHandler val_2 = App.ThemesHandler;
        string val_3 = 0.CurrentThemeName;
        if((System.String.IsNullOrEmpty(value:  null)) == false)
        {
            goto label_8;
        }
        
        val_13 = "";
        goto label_9;
        label_1:
        val_14 = this.<asyncLoad>5__2;
        this.<>1__state = 0;
        goto label_10;
        label_8:
        ThemesHandler val_5 = App.ThemesHandler;
        string val_6 = 0.CurrentThemeName;
        string val_7 = 2144339952 + null;
        val_13 = "_";
        label_9:
        string val_8 = null + 2144339952;
        UnityEngine.AsyncOperation val_9 = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName:  null, mode:  1);
        val_14 = 0;
        this.<asyncLoad>5__2 = 0;
        label_10:
        if(val_14.isDone != false)
        {
                val_15 = null;
            val_15 = null;
            val_12 = false;
            WGLeaguesLoadingPopup.loadingLeagues = val_12;
            if((this.<>4__this.isFlyout) == false)
        {
                return (bool)val_12;
        }
        
            val_12 = 0;
            UnityEngine.GameObject val_11 = this.<>4__this.gameObject;
            SLCWindow.CloseWindow(window:  this.<>4__this, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            return (bool)val_12;
        }
        
        val_12 = 1;
        this.<>1__state = val_12;
        this.<>2__current = 0;
        return (bool)val_12;
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
