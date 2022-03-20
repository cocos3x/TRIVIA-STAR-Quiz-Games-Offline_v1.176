using UnityEngine;
private sealed class WGLeaguesLoadingPopup.<DelayLoadLeagues>d__11 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGLeaguesLoadingPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGLeaguesLoadingPopup.<DelayLoadLeagues>d__11(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_11;
        var val_12;
        float val_13;
        object val_14;
        val_11 = 0;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_11;
        }
        
        this.<>1__state = 0;
        val_12 = null;
        val_12 = null;
        val_11 = true;
        WGLeaguesLoadingPopup.loadingLeagues = val_11;
        bool val_1 = UnityEngine.Application.isEditor;
        UnityEngine.WaitForSeconds val_2 = null;
        val_13 = 0.5f;
        val_14 = val_2;
        val_2 = new UnityEngine.WaitForSeconds(seconds:  3f = 0.5f);
        this.<>1__state = val_11;
        this.<>2__current = val_14;
        return (bool)val_11;
        label_1:
        this.<>1__state = 0;
        return (bool)val_11;
        label_2:
        this.<>1__state = 0;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_13 = public static SLC.Social.Leagues.LeaguesManager MonoSingleton<SLC.Social.Leagues.LeaguesManager>::get_Instance();
        if((-1937797680) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_13 = public static SLC.Social.Leagues.LeaguesManager MonoSingleton<SLC.Social.Leagues.LeaguesManager>::get_Instance();
            if(WaitFullDataUpdate() != false)
        {
                NotificationCenter val_7 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  this.<>4__this, name:  442544128);
            NotificationCenter val_8 = NotificationCenter.DefaultCenter;
            val_13 = null;
            val_14 = val_13;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.AddObserver(observer:  this.<>4__this, name:  442544128);
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_11 = 0;
            RequestInitialData();
            return (bool)val_11;
        }
        
        }
        
        System.Collections.IEnumerator val_10 = this.<>4__this.OnDataUpdate();
        val_11 = 1;
        this.<>1__state = 2;
        this.<>2__current = this.<>4__this;
        return (bool)val_11;
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
