using UnityEngine;
private sealed class RESRaidAttackScreenTransition.<>c__DisplayClass19_0
{
    // Fields
    public RestaurantRivals.RESRaidAttackScreenTransition <>4__this;
    public System.Action onComplete;
    
    // Methods
    public RESRaidAttackScreenTransition.<>c__DisplayClass19_0()
    {
    
    }
    internal void <WithdrawCurtains>b__0()
    {
        UnityEngine.GameObject val_1 = this.<>4__this.sceneIcon.gameObject;
        this.<>4__this.sceneIcon.SetActive(value:  false);
    }
    internal void <WithdrawCurtains>b__1()
    {
        RestaurantRivals.RESRaidAttackScreenTransition val_25;
        RestaurantRivals.RESRaidAttackScreenTransition val_26;
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this.blackBGIcon, endValue:  null, duration:  null);
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this.OpponentAvatarBg, endValue:  null, duration:  null);
        UnityEngine.Transform val_3 = this.<>4__this.transform;
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Transform val_5 = public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_C.transform;
        UnityEngine.Vector3 val_6 = RestaurantRivals.RESManager.GetWorldPosInSelCamera(selfTransform:  603256740, targetTransform:  this.<>4__this);
        val_25 = this.<>4__this;
        if((this.<>4__this) != 0)
        {
            goto label_10;
        }
        
        val_25 = this.<>4__this;
        if(val_25 == 0)
        {
            goto label_24;
        }
        
        label_10:
        UnityEngine.Vector3 val_9 = position;
        UnityEngine.Vector3 val_11 = new UnityEngine.Vector3(x:  val_9.x, y:  val_9.y, z:  val_9.z);
        this.<>4__this.OpponentAvatarMask.position = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        UnityEngine.GameObject val_12 = this.<>4__this.OpponentAvatarPos.gameObject;
        this.<>4__this.OpponentAvatarPos.SetActive(value:  true);
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_1C + 40.SetActive(value:  false);
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Vector3 val_15 = position;
        val_26 = this.<>4__this;
        if((this.<>4__this) != 0)
        {
            goto label_23;
        }
        
        val_26 = this.<>4__this;
        if(val_26 == 0)
        {
            goto label_24;
        }
        
        label_23:
        UnityEngine.Vector3 val_18 = position;
        UnityEngine.Vector3 val_20 = new UnityEngine.Vector3(x:  val_18.x, y:  val_18.y, z:  val_18.z);
        this.<>4__this.OpponentAvatarPos.position = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
        twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Sprite val_23 = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_C.GetAvatarSpriteByID(id:  public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_24 + 12);
        this.<>4__this.OpponentAvatarImage.sprite = public static RestaurantRivals.RESRaidAttackManager MonoSingleton<RestaurantRivals.RESRaidAttackManager>::get_Instance().__il2cppRuntimeField_C;
        DG.Tweening.Tweener val_24 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.OpponentAvatarPos, endValue:  val_18.x, duration:  val_18.y);
        return;
        label_24:
    }
    internal void <WithdrawCurtains>b__2()
    {
        if(this.onComplete == 0)
        {
                return;
        }
        
        this.onComplete.Invoke();
    }

}
