using UnityEngine;
private sealed class LevelCompletePopup.<PlayGoldenCurrencyGet>d__36 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LevelCompletePopup <>4__this;
    public int amount;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LevelCompletePopup.<PlayGoldenCurrencyGet>d__36(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_8;
        int val_9;
        int val_10;
        int val_11;
        int val_13 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_13;
        }
        
            this.<>1__state = 0;
            val_13 = 1;
            this.<>1__state = val_13;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
            return (bool)val_13;
        }
        
        this.<>1__state = 0;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_3 = public static GoldenMultiplierManager MonoSingleton<GoldenMultiplierManager>::get_Instance().__il2cppRuntimeField_C.ToString();
        string val_4 = System.String.Format(format:  2128510224, arg0:  -244407620);
        this.<>4__this.goldenMultiplierGroup.SetActive(value:  true);
        Player val_5 = App.Player;
        Player val_6 = App.Player;
        val_13 = 0;
        decimal val_7 = System.Decimal.op_Implicit(value:  -244407636);
        this.<>4__this.appleCollector.Play(fromValue:  4 - this.amount, toValue:  new System.Decimal() {flags = val_10, hi = val_11, lo = val_9, mid = val_8}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
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
