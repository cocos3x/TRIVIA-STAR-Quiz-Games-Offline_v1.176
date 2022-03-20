using UnityEngine;
private sealed class WGDailyChallengeManager.<RequestValidIdDelayed>d__94 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGDailyChallengeManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGDailyChallengeManager.<RequestValidIdDelayed>d__94(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_4;
        var val_5;
        var val_6;
        if((this.<>1__state) != 1)
        {
                val_4 = 0;
            if((this.<>1__state) != 0)
        {
                return val_4;
        }
        
            this.<>1__state = 0;
            this.<>4__this.isRunningDelayedRequest = true;
        }
        else
        {
                this.<>1__state = 0;
        }
        
        Player val_1 = App.Player;
        val_5 = 0;
        if((System.String.op_Equality(a:  1835037, b:  1297836560)) == true)
        {
            goto label_14;
        }
        
        val_5 = 1152921504894439424;
        var val_4 = 26651277;
        val_4 = 8976148 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        if(NetworkConnectivityPinger.NOTIF_NETWORK_CONNECT_RESPONSE == null)
        {
            goto label_14;
        }
        
        if((this.<>4__this) == 0)
        {
            goto label_15;
        }
        
        this.<>4__this.RequestChallengeData(firstTimeNewIdRequest:  true);
        goto label_16;
        label_14:
        UnityEngine.WaitForSeconds val_3 = null;
        val_3 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>1__state = 1;
        this.<>2__current = val_3;
        return true;
        label_15:
        0.RequestChallengeData(firstTimeNewIdRequest:  true);
        label_16:
        val_4 = false;
        this.<>4__this.isRunningDelayedRequest = val_4;
        return val_4;
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
