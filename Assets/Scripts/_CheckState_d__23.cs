using UnityEngine;
private sealed class WGDailyBonusPopup.<CheckState>d__23 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGDailyBonusPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGDailyBonusPopup.<CheckState>d__23(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        var val_9;
        var val_14;
        var val_27;
        UnityEngine.UI.Text val_28;
        var val_29;
        object val_31;
        int val_32;
        val_27 = 0;
        if((this.<>1__state) > 3)
        {
                return (bool)val_27;
        }
        
        var val_1 = 6793820 + (6793820 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                val_27 = val_27 & 0;
            val_27 = val_27 & ((IP) >> 7);
            val_27 = val_27 & 4187726544;
        }
        
        this.<>1__state = 0;
        val_28 = this.<>4__this.timerText;
        if(val_28 == 0)
        {
            goto label_23;
        }
        
        System.TimeSpan val_3 = currentTimeUntilNextBonus;
        int val_7 = UnityEngine.Mathf.Max(a:  val_4.Hours, b:  0);
        System.TimeSpan val_8 = currentTimeUntilNextBonus;
        int val_12 = UnityEngine.Mathf.Max(a:  val_9.Minutes, b:  0);
        System.TimeSpan val_13 = currentTimeUntilNextBonus;
        int val_17 = UnityEngine.Mathf.Max(a:  val_14.Seconds, b:  0);
        string val_18 = System.String.Format(format:  -1662255760, arg0:  13152256, arg1:  13152256, arg2:  13152256);
        twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_28 = public static WGDailyBonusManager MonoSingleton<WGDailyBonusManager>::get_Instance();
        twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_28 = public static WGDailyBonusManager MonoSingleton<WGDailyBonusManager>::get_Instance();
        twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_28 = public static WGDailyBonusManager MonoSingleton<WGDailyBonusManager>::get_Instance();
        System.TimeSpan val_22 = currentTimeUntilNextBonus;
        val_28 = 1152921504622821376;
        val_29 = null;
        val_29 = null;
        if((val_4.CompareTo(value:  new System.TimeSpan() {_ticks = System.TimeSpan.__il2cppRuntimeField_cctor_finished})) > 1)
        {
            goto label_23;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_24 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGDailyBonusManager MonoSingleton<WGDailyBonusManager>::get_Instance().__il2cppRuntimeField_10 = 0;
        twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_28 = public static WGDailyBonusManager MonoSingleton<WGDailyBonusManager>::get_Instance();
        UpdateUIState();
        val_31 = this.<>4__this;
        val_32 = 1;
        goto label_29;
        label_23:
        UnityEngine.WaitForSeconds val_26 = null;
        val_31 = val_26;
        val_26 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_32 = 2;
        label_29:
        val_27 = 1;
        this.<>2__current = ;
        this.<>1__state = ;
        return (bool)val_27;
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
