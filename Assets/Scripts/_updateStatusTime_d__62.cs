using UnityEngine;
private sealed class WGSubscriptionPopup.<updateStatusTime>d__62 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGSubscriptionPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGSubscriptionPopup.<updateStatusTime>d__62(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        long val_9;
        int val_13;
        SubscriptionHandler.SubScriptionType val_14;
        val_13 = 0;
        if((this.<>1__state) >= 2)
        {
                return (bool)val_13;
        }
        
        this.<>1__state = 0;
        val_13 = 0;
        UnityEngine.GameObject val_1 = this.<>4__this.gameObject;
        val_14 = this.<>4__this;
        if(val_14.activeInHierarchy == false)
        {
                return (bool)val_13;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_14 = this.<>4__this.subPackage;
        if((canCollectSubscription(subPackage:  val_14)) != false)
        {
                val_13 = 0;
            this.<>4__this.statusObject.SetActive(value:  false);
            this.<>4__this.InitCollectPopup();
            return (bool)val_13;
        }
        
        val_14 = this.<>4__this.statusCoinTimer;
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.DateTime val_6 = getNextCollectTime(subPackage:  MonoSingleton<T>.__il2cppRuntimeField_cctor_finished);
        System.DateTime val_7 = DateTimeCheat.UtcNow;
        System.TimeSpan val_8 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511983443928}, d2:  new System.DateTime());
        val_13 = 1;
        string val_11 = GenericStringExtentions.ToString(span:  new System.TimeSpan() {_ticks = val_9}, formatted:  true);
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
