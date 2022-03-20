using UnityEngine;
private sealed class PiggyBankPopup.<UpdateTimer>d__47 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public PiggyBankPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PiggyBankPopup.<UpdateTimer>d__47(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_8;
        var val_9;
        object val_10;
        int val_11;
        val_8 = 0;
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
                return (bool)val_8;
        }
        
        this.<>1__state = 0;
        string val_1 = Localization.Localize(key:  -1118401280, defaultValue:  -1118401376, useSingularKey:  false);
        val_9 = "deal_ends_in";
        string val_2 = this.<>4__this.GetDateString();
        string val_3 = System.String.Format(format:  1592589744, arg0:  -1118401280, arg1:  this.<>4__this);
        UnityEngine.WaitForSeconds val_4 = null;
        val_10 = val_4;
        val_4 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_11 = 1;
        goto label_7;
        label_1:
        val_11 = 0;
        goto label_8;
        label_2:
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
                System.Collections.IEnumerator val_5 = this.<>4__this.UpdateTimer();
            val_9 = this.<>4__this;
        }
        else
        {
                System.Collections.IEnumerator val_6 = 0.UpdateTimer();
            val_9 = 0;
        }
        
        val_10 = 0;
        UnityEngine.Coroutine val_7 = this.<>4__this.StartCoroutine(routine:  0);
        val_11 = 2;
        label_7:
        val_8 = 1;
        this.<>2__current = val_10;
        label_8:
        this.<>1__state = val_11;
        return (bool)val_8;
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
