using UnityEngine;
private sealed class WordIQLevelCompleteDisplayAnim.<TweenStat>d__20 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordIQLevelCompleteDisplayAnim <>4__this;
    private float <endAmount>5__2;
    private float <incrementPerSecond>5__3;
    private bool <showMilestoneUpgrade>5__4;
    private int <statDisplayMilestone>5__5;
    private float <statDisplayAmount>5__6;
    private int <milestoneReached>5__7;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WordIQLevelCompleteDisplayAnim.<TweenStat>d__20(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_30;
        float val_31;
        float val_32;
        float val_33;
        var val_34;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_30 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_30;
        }
        
        this.<>1__state = 0;
        float val_1 = UnityEngine.Time.time;
        float val_2 = UnityEngine.Time.time;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_31 = 1152921512263062736;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        float val_5 = PlayerIQ;
        val_32 = this;
        this.<endAmount>5__2 = public static WordIQManager MonoSingleton<WordIQManager>::get_Instance();
        float val_30 = this.<>4__this.statTweenDuration;
        val_30 = (3361248464 - (public static WordIQManagerUI MonoSingleton<WordIQManagerUI>::get_Instance().__il2cppRuntimeField_14)) / val_30;
        this.<incrementPerSecond>5__3 = val_30;
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_8 = GetMilestone(iqPoints:  val_30);
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_10 = GetMilestone(iqPoints:  val_30);
        val_10 = val_8 - val_10;
        this.<statDisplayMilestone>5__5 = val_8;
        if((public static WordIQManager MonoSingleton<WordIQManager>::get_Instance()) != 0)
        {
                val_10 = 1;
        }
        
        this.<statDisplayAmount>5__6 = public static WordIQManagerUI MonoSingleton<WordIQManagerUI>::get_Instance().__il2cppRuntimeField_14;
        this.<showMilestoneUpgrade>5__4 = true;
        val_33 = this.<statDisplayAmount>5__6;
        goto label_15;
        label_1:
        val_32 = this.<endAmount>5__2;
        val_33 = this.<statDisplayAmount>5__6;
        this.<>1__state = 0;
        label_15:
        if((this.<>1__state) < 0)
        {
            goto label_16;
        }
        
        string val_11 = WordIQManagerUI.FormatPoints(iqPoints:  val_32);
        val_30 = 0;
        if((System.String.op_Inequality(a:  this.<>4__this.iqStat, b:  this.<>4__this.iqStat)) == false)
        {
                return (bool)val_30;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_30 = 0;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -928764432, clipIndex:  0);
        return (bool)val_30;
        label_2:
        this.<>1__state = 0;
        this.<statDisplayMilestone>5__5 = this.<milestoneReached>5__7;
        goto label_30;
        label_16:
        float val_14 = UnityEngine.Time.deltaTime;
        float val_15 = (this.<incrementPerSecond>5__3) * 0;
        float val_16 = (this.<endAmount>5__2) - (this.<statDisplayAmount>5__6);
        float val_17 = UnityEngine.Mathf.Min(a:  val_15, b:  null);
        float val_31 = val_15;
        val_31 = val_33 + val_31;
        this.<statDisplayAmount>5__6 = val_31;
        if((this.<showMilestoneUpgrade>5__4) == false)
        {
            goto label_30;
        }
        
        val_31 = 1152921512263062736;
        twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((GetMilestone(iqPoints:  val_31)) != (this.<statDisplayMilestone>5__5))
        {
            goto label_34;
        }
        
        label_30:
        string val_20 = WordIQManagerUI.FormatPoints(iqPoints:  val_31);
        val_32 = 0;
        if((System.String.op_Inequality(a:  this.<>4__this.iqStat, b:  this.<>4__this.iqStat)) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -928764432, clipIndex:  0);
        }
        
        val_30 = 1;
        this.<>1__state = 2;
        this.<>2__current = val_32;
        return (bool)val_30;
        label_34:
        twelvegigs.Autopilot.AutopilotManager val_23 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.<milestoneReached>5__7 = GetMilestone(iqPoints:  val_31);
        twelvegigs.Autopilot.AutopilotManager val_25 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        float val_26 = GetMilestoneAmount(milestoneIndex:  this.<milestoneReached>5__7);
        if((this.<>4__this) != 0)
        {
                System.Collections.IEnumerator val_27 = this.<>4__this.ShowMilestoneReached(milestoneIndex:  this.<milestoneReached>5__7, milestoneAmount:  val_26);
            val_34 = this.<>4__this;
        }
        else
        {
                System.Collections.IEnumerator val_28 = 0.ShowMilestoneReached(milestoneIndex:  this.<milestoneReached>5__7, milestoneAmount:  val_26);
            val_34 = 0;
        }
        
        UnityEngine.Coroutine val_29 = this.<>4__this.StartCoroutine(routine:  0);
        this.<>1__state = 1;
        this.<>2__current = this.<>4__this;
        return (bool)val_30;
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
