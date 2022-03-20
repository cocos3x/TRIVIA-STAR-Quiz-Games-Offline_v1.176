using UnityEngine;
private sealed class RESBatteryGettingPopup.<ShowBattery>d__3 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public RestaurantRivals.RESBatteryGettingPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RESBatteryGettingPopup.<ShowBattery>d__3(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_14;
        object val_15;
        var val_16;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_14 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_14;
        }
        
        this.<>1__state = 0;
        this.<>4__this.canvasGroup.alpha = null;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
        this.<>4__this.batteryObject.localScale = new UnityEngine.Vector3();
        UnityEngine.WaitForSeconds val_2 = null;
        val_15 = val_2;
        val_2 = new UnityEngine.WaitForSeconds(seconds:  val_1.x);
        val_14 = 1;
        this.<>1__state = val_14;
        goto label_9;
        label_1:
        this.<>1__state = 0;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_14.StartSpinGetEffects(spins:  0, recharge:  false);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        FinishSpinConclusion();
        val_14 = 0;
        UnityEngine.GameObject val_5 = this.<>4__this.gameObject;
        this.<>4__this.SetActive(value:  false);
        return (bool)val_14;
        label_2:
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
                DG.Tweening.Tweener val_6 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this.canvasGroup, endValue:  null, duration:  null);
            val_16 = public static DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetEase<DG.Tweening.Tweener>(DG.Tweening.Tweener t, DG.Tweening.Ease ease);
            object val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<>4__this.canvasGroup, ease:  6);
        }
        else
        {
                DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions46.DOFade(target:  2621443, endValue:  null, duration:  null);
            val_16 = public static DG.Tweening.Tweener DG.Tweening.TweenSettingsExtensions::SetEase<DG.Tweening.Tweener>(DG.Tweening.Tweener t, DG.Tweening.Ease ease);
            object val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  2621443, ease:  6);
        }
        
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.batteryObject, endValue:  new UnityEngine.Vector3(), duration:  val_10.x);
        object val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<>4__this.batteryObject, ease:  5);
        UnityEngine.WaitForSeconds val_13 = null;
        val_15 = val_13;
        val_13 = new UnityEngine.WaitForSeconds(seconds:  val_10.x);
        val_14 = 1;
        this.<>1__state = 2;
        label_9:
        this.<>2__current = val_15;
        return (bool)val_14;
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
