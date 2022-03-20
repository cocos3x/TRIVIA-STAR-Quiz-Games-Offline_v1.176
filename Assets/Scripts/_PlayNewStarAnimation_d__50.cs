using UnityEngine;
private sealed class WGDailyChallengeLevelComplete.<PlayNewStarAnimation>d__50 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGDailyChallengeLevelComplete <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGDailyChallengeLevelComplete.<PlayNewStarAnimation>d__50(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_35;
        var val_36;
        DailyChallengeProgressUI val_37;
        var val_38;
        val_35 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_35;
        }
        
        this.<>1__state = 0;
        typeof(WGDailyChallengeLevelComplete.<>c__DisplayClass50_0).__il2cppRuntimeField_8 = this.<>4__this;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_36 = 0;
        goto label_9;
        label_16:
        UnityEngine.GameObject val_35 = this.<>4__this.dcStars[val_36];
        UnityEngine.Transform val_3 = val_35.transform;
        UnityEngine.Vector3 val_4 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
        DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions.DOPunchScale(target:  val_35, punch:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  this.<>4__this.starPunchDuration, vibrato:  this.<>4__this.starPunchDuration, elasticity:  null);
        float val_36 = 0f;
        val_36 = (this.<>4__this.starPunchDuration) * val_36;
        val_36 = val_36 / 3f;
        val_36 = (this.<>4__this.starPunchDuration) + val_36;
        object val_6 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  val_35, delay:  val_36);
        val_36 = 1;
        label_9:
        if(val_36 < val_35)
        {
            goto label_16;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        typeof(System.Int32[]).__il2cppRuntimeField_10 = (public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_64 + 8 - public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>;
        typeof(WGDailyChallengeLevelComplete.<>c__DisplayClass50_0).__il2cppRuntimeField_C = UnityEngine.Mathf.Min(a:  public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_7C, b:  UnityEngine.Mathf.Max(values:  478302960));
        this.<>4__this.monthlyProgressUI.InitializeMonthlyProgress(starsToAnimate:  0);
        DG.Tweening.TweenCallback val_12 = new DG.Tweening.TweenCallback(object:  385994752, method:  new IntPtr(4199315648));
        float val_13 = (this.<>4__this.starPunchDuration) * 3f;
        DG.Tweening.Tween val_14 = DG.Tweening.DOVirtual.DelayedCall(delay:  val_13, callback:  val_13, ignoreTimeScale:  false);
        MainModule val_15 = this.<>4__this.monthStarParticles.main;
        MinMaxCurve val_16 = val_4.x.startLifetime;
        val_16.m_ConstantMax.TweenProgressBar(amount:  val_16.m_ConstantMin, delay:  val_4.x.constantMin);
        val_38 = 1152921511080275808;
        twelvegigs.Autopilot.AutopilotManager val_18 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingCurrentWeek() == false)
        {
            goto label_33;
        }
        
        object val_20 = new System.Object();
        typeof(WGDailyChallengeLevelComplete.<>c__DisplayClass50_1).__il2cppRuntimeField_C = new System.Object();
        twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_38 = mem[public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_64 + 12];
        val_38 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_64 + 12;
        twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        typeof(System.Int32[]).__il2cppRuntimeField_10 = (public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_64 + 12 - public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager;
        typeof(WGDailyChallengeLevelComplete.<>c__DisplayClass50_1).__il2cppRuntimeField_8 = UnityEngine.Mathf.Min(a:  public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance().__il2cppRuntimeField_7C, b:  UnityEngine.Mathf.Max(values:  478302960));
        this.<>4__this.weeklyProgressUI.InitializeWeeklyProgress(starsToAnimate:  0);
        DG.Tweening.TweenCallback val_25 = new DG.Tweening.TweenCallback(object:  386048000, method:  new IntPtr(4199328960));
        float val_26 = (this.<>4__this.starPunchDuration) * 3f;
        DG.Tweening.Tween val_27 = DG.Tweening.DOVirtual.DelayedCall(delay:  val_26, callback:  val_26, ignoreTimeScale:  false);
        val_37 = this.<>4__this.weeklyProgressUI;
        MainModule val_28 = this.<>4__this.weekStarParticles.main;
        MinMaxCurve val_29 = val_4.x.startLifetime;
        val_37.TweenProgressBar(amount:  val_29.m_ConstantMax, delay:  val_29.m_ConstantMin.constantMin);
        goto label_48;
        label_1:
        this.<>1__state = 0;
        return (bool)val_35;
        label_33:
        this.<>4__this.weeklyProgressUI.InitializeWeeklyProgress(starsToAnimate:  0);
        label_48:
        MainModule val_31 = this.<>4__this.monthStarParticles.main;
        MinMaxCurve val_32 = val_4.x.startLifetime;
        float val_33 = val_32.m_ConstantMin.constantMin;
        val_35 = 1;
        mem2[0] = val_35;
        mem2[0] = new UnityEngine.WaitForSeconds(seconds:  this.<>4__this.starPunchDuration);
        return (bool)val_35;
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
