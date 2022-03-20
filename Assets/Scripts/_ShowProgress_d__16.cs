using UnityEngine;
private sealed class WPTLevelClear.<ShowProgress>d__16 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WPTLevelClear <>4__this;
    public float currentProgress;
    private WPTLevelClear.<>c__DisplayClass16_0 <>8__1;
    public float initialProgress;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WPTLevelClear.<ShowProgress>d__16(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_22;
        DG.Tweening.Core.DOGetter<System.Int32> val_23;
        DG.Tweening.Core.DOSetter<System.Int32> val_24;
        val_22 = 0;
        if((this.<>1__state) > 3)
        {
                return (bool);
        }
        
        var val_1 = 6100592 + (6100592 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                6100592 + (this.<>1__state) << 2 = (6100592 + (this.<>1__state) << 2) & ((6100592 + (this.<>1__state) << 2) << (6100592 + (this.<>1__state) << 2));
            6100592 + (this.<>1__state) << 2 = (6100592 + (this.<>1__state) << 2) & (((int)R8) >> 6);
            6100592 + (this.<>1__state) << 2 = (6100592 + (this.<>1__state) << 2) & 1611573279;
        }
        
        this.<>1__state = 0;
        this.<>8__1 = new System.Object();
        typeof(WPTLevelClear.<>c__DisplayClass16_0).__il2cppRuntimeField_C = this.<>4__this;
        val_23 = 0;
        UnityEngine.Transform val_3 = this.<>4__this.upperGroup.transform;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        val_24 = 16102;
        val_24 = 1055286886;
        DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.upperGroup, endValue:  new UnityEngine.Vector3(), duration:  val_4.x);
        UnityEngine.Transform val_6 = this.<>4__this.centerGroup.transform;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.centerGroup, endValue:  new UnityEngine.Vector3(), duration:  val_7.x);
        object val_9 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.<>4__this.centerGroup, delay:  val_7.x);
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_22 = 1;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGeneralSound(type:  0, oneshot:  true, pitch:  val_7.x, vol:  val_7.y);
        UnityEngine.WaitForSeconds val_11 = null;
        val_11 = new UnityEngine.WaitForSeconds(seconds:  val_7.x);
        this.<>1__state = val_22;
        this.<>2__current = val_11;
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
