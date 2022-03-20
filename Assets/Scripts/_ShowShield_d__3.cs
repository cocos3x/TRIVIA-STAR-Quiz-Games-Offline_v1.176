using UnityEngine;
private sealed class RESShieldGettingPopup.<ShowShield>d__3 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public RestaurantRivals.RESShieldGettingPopup <>4__this;
    private UnityEngine.Transform <shieldIconTran>5__2;
    private UnityEngine.Vector3 <targetPosition>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RESShieldGettingPopup.<ShowShield>d__3(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_39;
        RestaurantRivals.RESShieldGettingPopup val_40;
        int val_41;
        var val_42;
        UnityEngine.Transform val_43;
        var val_44;
        object val_45;
        var val_46;
        var val_47;
        UnityEngine.Transform val_48;
        val_39 = this;
        val_40 = this.<>4__this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_41 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_41;
        }
        
        this.<>1__state = 0;
        UnityEngine.GameObject val_1 = val_40.gameObject;
        val_40.SetActive(value:  true);
        if(val_40 == 0)
        {
            goto label_6;
        }
        
        val_42 = val_40;
        val_43 = this.<>4__this.shieldObject;
        goto label_7;
        label_1:
        this.<>1__state = 0;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
        val_44 = 1152921511370979232;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_42 = mem[public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 96];
        val_42 = public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 96;
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 100) > 0)
        {
                0 = 1;
        }
        
        public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_18 + 16.UpdateShieldsIcon(shieldCount:  val_42 + (1.444279E-39f), showBrokenAnima:  true);
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_39 = 1152921511658978240;
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_14.ShowAddSpinTipAndNotify(amount:  public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 100);
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_3C = 0;
        val_41 = 0;
        UnityEngine.GameObject val_11 = val_40.gameObject;
        val_40.SetActive(value:  false);
        return (bool)val_41;
        label_2:
        this.<>1__state = 0;
        val_44 = 0;
        DG.Tweening.Tweener val_12 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.<>4__this.shieldObject, endValue:  new UnityEngine.Vector3() {x = mem[this.<targetPosition>5__3 + (0)], y = mem[this.<targetPosition>5__3 + (4)], z = mem[this.<targetPosition>5__3 + (8)]}, duration:  null, snapping:  false);
        object val_13 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<>4__this.shieldObject, ease:  11);
        UnityEngine.Vector3 val_14 = localScale;
        DG.Tweening.Tweener val_15 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.shieldObject, endValue:  new UnityEngine.Vector3(), duration:  val_14.x);
        UnityEngine.WaitForSeconds val_16 = null;
        val_45 = val_16;
        val_16 = new UnityEngine.WaitForSeconds(seconds:  val_14.x);
        val_41 = 1;
        this.<>1__state = 2;
        goto label_40;
        label_6:
        val_42 = 12;
        val_43 = 0;
        label_7:
        val_40 = 0;
        val_43.position = new UnityEngine.Vector3() {x = this.<>4__this.originalPosition, y = R5, z = val_40};
        this.<shieldIconTran>5__2 = val_40;
        val_44 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(CanAddShield == false)
        {
            goto label_45;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        RestaurantRivals.RESPlayer val_21 = RestaurantRivals.RESPlayer.Instance;
        twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_40 = mem[public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 96];
        val_40 = public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 96;
        twelvegigs.Autopilot.AutopilotManager val_23 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((val_40 + 1030672) <= MaxShieldCount)
        {
            goto label_56;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_26 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_46 = MaxShieldCount;
        goto label_60;
        label_45:
        twelvegigs.Autopilot.AutopilotManager val_28 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_29 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_30 = MaxShieldCount;
        val_30 = val_30 + (val_30 >> 31);
        val_47 = val_30 >> 1;
        val_48 = public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_18 + 16;
        goto label_69;
        label_56:
        RestaurantRivals.RESPlayer val_31 = RestaurantRivals.RESPlayer.Instance;
        twelvegigs.Autopilot.AutopilotManager val_32 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        label_60:
        val_48 = public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_18 + 16;
        label_69:
        UnityEngine.Transform val_33 = val_48.GetShieldIcon(index:  ((public static RestaurantRivals.RESManager MonoSingleton<RestaurantRivals.RESManager>::get_Instance().__il2cppRuntimeField_34 + 96 + 1030672) - 1));
        this.<shieldIconTran>5__2 = val_48;
        UnityEngine.Vector3 val_34 = RestaurantRivals.RESManager.GetWorldPosInSelCamera(selfTransform:  645434848, targetTransform:  0);
        UnityEngine.WaitForSeconds val_35 = null;
        val_45 = val_35;
        val_35 = new UnityEngine.WaitForSeconds(seconds:  val_34.x);
        val_41 = 1;
        this.<>1__state = val_41;
        label_40:
        this.<>2__current = val_45;
        return (bool)val_41;
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
