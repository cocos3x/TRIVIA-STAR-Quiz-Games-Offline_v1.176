using UnityEngine;
private sealed class SuperBundleEventPopup.<UpdateTimer>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SuperBundleEventPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SuperBundleEventPopup.<UpdateTimer>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        long val_8;
        int val_13;
        var val_14;
        val_13 = 0;
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
                return (bool)val_13;
        }
        
        this.<>1__state = 0;
        string val_1 = Localization.Localize(key:  -1118401280, defaultValue:  -1118401376, useSingularKey:  false);
        string val_2 = this.<>4__this.GetDateString();
        string val_3 = System.String.Format(format:  1592589744, arg0:  -1118401280, arg1:  this.<>4__this);
        System.DateTime val_4 = DateTimeCheat.UtcNow;
        System.TimeSpan val_7 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512201864832}, d2:  new System.DateTime() {dateData = this.<>4__this.dealEndTime});
        val_14 = null;
        val_14 = null;
        if((System.TimeSpan.op_LessThanOrEqual(t1:  new System.TimeSpan() {_ticks = val_8}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) == false)
        {
            goto label_14;
        }
        
        val_13 = 0;
        this.<>4__this.openButton.interactable = false;
        return (bool)val_13;
        label_1:
        this.<>1__state = 0;
        return (bool)val_13;
        label_2:
        this.<>1__state = 0;
        System.Collections.IEnumerator val_11 = this.<>4__this.UpdateTimer();
        val_13 = 1;
        this.<>1__state = 2;
        this.<>2__current = this.<>4__this;
        return (bool)val_13;
        label_14:
        val_13 = 1;
        this.<>1__state = val_13;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
        return (bool)val_13;
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
