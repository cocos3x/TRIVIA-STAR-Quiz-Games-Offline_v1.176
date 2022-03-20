using UnityEngine;
private sealed class DeeplinkDelegate.<DelayedShowScene>d__14 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DeeplinkDelegate.<DelayedShowScene>d__14(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_26;
        var val_27;
        var val_28;
        val_26 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_26;
        }
        
        this.<>1__state = 0;
        GameBehavior val_1 = App.getBehavior;
        ThemesHandler val_2 = App.ThemesHandler;
        if(0 == 0)
        {
            goto label_9;
        }
        
        ThemesHandler val_4 = App.ThemesHandler;
        string val_5 = 0.CurrentThemeName;
        if((System.String.IsNullOrEmpty(value:  null)) == false)
        {
            goto label_13;
        }
        
        label_9:
        val_27 = "";
        goto label_14;
        label_1:
        this.<>1__state = 0;
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_26 = 0;
        HandleDeeplinkMainGame();
        return (bool)val_26;
        label_13:
        ThemesHandler val_8 = App.ThemesHandler;
        string val_9 = 0.CurrentThemeName;
        string val_10 = 2144339952 + null;
        val_27 = "_";
        label_14:
        string val_11 = null + 2144339952;
        UnityEngine.SceneManagement.Scene val_12 = UnityEngine.SceneManagement.SceneManager.GetSceneByName(name:  null);
        if(val_12.m_Handle.isLoaded == false)
        {
            goto label_24;
        }
        
        GameBehavior val_14 = App.getBehavior;
        ThemesHandler val_15 = App.ThemesHandler;
        if(0 == 0)
        {
            goto label_31;
        }
        
        ThemesHandler val_17 = App.ThemesHandler;
        string val_18 = 0.CurrentThemeName;
        if((System.String.IsNullOrEmpty(value:  null)) == false)
        {
            goto label_35;
        }
        
        label_31:
        val_28 = "";
        goto label_36;
        label_35:
        ThemesHandler val_20 = App.ThemesHandler;
        string val_21 = 0.CurrentThemeName;
        string val_22 = 2144339952 + null;
        val_28 = "_";
        label_36:
        string val_23 = null + 2144339952;
        UnityEngine.AsyncOperation val_24 = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(sceneName:  null);
        label_24:
        UnityEngine.WaitForSeconds val_25 = null;
        val_25 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_26 = 1;
        this.<>1__state = val_26;
        this.<>2__current = val_25;
        return (bool)val_26;
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
