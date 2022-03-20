using UnityEngine;
private sealed class WGDailyChallengeButton.<UpdateState>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGDailyChallengeButton <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGDailyChallengeButton.<UpdateState>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        object val_5;
        int val_6;
        val_4 = 0;
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
                return (bool)val_4;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_1 = null;
        val_5 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_6 = 1;
        goto label_4;
        label_1:
        val_6 = 0;
        goto label_5;
        label_2:
        this.<>1__state = 0;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.<>4__this.Button_DailyChallenge.interactable = true;
        this.<>4__this.UpdateButtonState();
        System.Collections.IEnumerator val_3 = this.<>4__this.UpdateState();
        val_5 = this.<>4__this;
        val_6 = 2;
        label_4:
        val_4 = 1;
        this.<>2__current = val_5;
        label_5:
        this.<>1__state = val_6;
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
