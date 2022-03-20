using UnityEngine;
private sealed class StrugglingPlayerFreeHintHandler.<WaitThenDisplayPopup>d__19 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public StrugglingPlayerFreeHintHandler <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public StrugglingPlayerFreeHintHandler.<WaitThenDisplayPopup>d__19(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_16;
        float val_17;
        var val_18;
        var val_19;
        float val_20;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_16 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool);
        }
        
        val_16 = 1;
        this.<>1__state = val_16;
        this.<>2__current = 0;
        return (bool);
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
            goto label_11;
        }
        
        val_17 = 36;
        val_18 = 1;
        goto label_6;
        label_2:
        this.<>1__state = 0;
        this.<>4__this.timeWaited = 0f;
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                WordRegion val_3 = WordRegion.instance;
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            GameEcon val_4 = App.getGameEcon;
            val_19 = 1152921504622129152;
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            typeof(System.Object[]).__il2cppRuntimeField_18 = null;
            float val_5 = this.<>4__this.TimeToWaitBetweenHints;
            typeof(System.Object[]).__il2cppRuntimeField_1C = null;
            string val_6 = System.String.Format(format:  -1003769184, args:  472754880);
            UnityEngine.Debug.LogWarning(message:  -1003769184);
        }
        
        label_11:
        val_17 = this.<>4__this.timeWaited;
        val_18 = 0;
        label_6:
        float val_7 = this.<>4__this.TimeToWaitBetweenHints;
        val_20 = this.<>4__this;
        MainController val_8 = MainController.instance;
        0.StruggleHintProvided = true;
        val_19 = 1152921511135858672;
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_16 = 0;
        if((public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18) == 0)
        {
                return (bool);
        }
        
        this.<>4__this.freeHintAvailableNow = true;
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UpdateFreeHintEligable();
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18.CheckFreeHinting();
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_16 = 0;
        public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18.SetPopup(message:  -1003768944, interactablePopup:  true);
        return (bool);
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
