using UnityEngine;
private sealed class TRVTimerDisplay.<CheckTimeRemaining>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVTimerDisplay <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVTimerDisplay.<CheckTimeRemaining>d__12(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        ulong val_2;
        var val_5;
        int val_20;
        System.DateTime val_21;
        val_20 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_20;
        }
        
        this.<>1__state = 0;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        val_21 = this.<>4__this.startTime;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512753866904}, d2:  new System.DateTime() {dateData = val_2});
        double val_7 = val_5.TotalSeconds;
        goto label_40;
        label_1:
        this.<>1__state = 0;
        System.DateTime val_8 = DateTimeCheat.UtcNow;
        System.TimeSpan val_9 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512753866904}, d2:  new System.DateTime() {dateData = val_2});
        double val_10 = val_5.TotalSeconds;
        val_21 = this.<>4__this.pointsText;
        string val_11 = this.<>4__this.TimeRemainingText();
        if(((System.String.op_Inequality(a:  this.<>4__this.pointsText, b:  1098586544)) != false) && ((System.String.op_Inequality(a:  this.<>4__this.pointsText, b:  this.<>4__this.pointsText)) != false))
        {
                if((System.String.op_Equality(a:  this.<>4__this.pointsText, b:  -1830317168)) != true)
        {
                if((System.String.op_Equality(a:  this.<>4__this.pointsText, b:  1701898768)) != true)
        {
                if((System.String.op_Equality(a:  this.<>4__this.pointsText, b:  1633189168)) == false)
        {
            goto label_26;
        }
        
        }
        
        }
        
            twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -442930896, clipIndex:  0);
        }
        
        label_26:
        float val_20 = this.<>4__this.quizDuration;
        twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        OnAnswerClicked(selectedAnswer:  1372269104);
        twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_20 = 0;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -442930800, clipIndex:  0);
        this.<>4__this.enabled = false;
        return (bool)val_20;
        label_40:
        if((this.<>4__this.OnTick) >= 0)
        {
                return (bool)val_20;
        }
        
        val_20 = 1;
        this.<>1__state = val_20;
        this.<>2__current = 0;
        return (bool)val_20;
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
