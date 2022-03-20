using UnityEngine;
public class FPHPowerupHintButton : FPHPowerupButton
{
    // Fields
    private ParticlePositionToPoint prefabEfxHint;
    
    // Properties
    protected override int Cost { get; }
    protected override string TrackingSource { get; }
    
    // Methods
    protected override int get_Cost()
    {
        var val_2;
        GameBehavior val_1 = App.getBehavior;
        val_2 = 0;
        if(0 <= (R6 + 1376))
        {
                return (int)val_2;
        }
        
        return (int)val_2;
    }
    protected override string get_TrackingSource()
    {
    
    }
    protected override bool ExecutePowerup()
    {
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        val_14 = 0;
        FPHGameplayController val_1 = FPHGameplayController.Instance;
        System.Collections.Generic.List<System.Int32> val_2 = 0.DoPowerupHint();
        if(0 == 0)
        {
                return true;
        }
        
        val_15 = 0;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_16 = 0;
        if(val_16 >= 1)
        {
                var val_15 = 0;
            do
        {
            object val_4 = new System.Object();
            if(0 <= val_15)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_14 = 0;
            val_14 = val_14 + 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            UnityEngine.Transform val_5 = this.transform;
            object val_6 = UnityEngine.Object.Instantiate<System.Object>(original:  mem[1152921511578446040], parent:  -1618335552);
            if(val_4 != 0)
        {
                val_17 = val_4;
            typeof(FPHPowerupHintButton.<>c__DisplayClass5_0).__il2cppRuntimeField_8 = mem[1152921511578446040];
        }
        else
        {
                val_17 = 8;
            mem[8] = mem[1152921511578446040];
        }
        
            UnityEngine.Transform val_7 = val_17.transform;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            val_17.localPosition = new UnityEngine.Vector3();
            UnityEngine.Transform val_9 = mem[8].transform;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
            mem[8].localScale = new UnityEngine.Vector3();
            val_15 = val_15;
            UnityEngine.Transform val_11 = (public static FPHGameplayUIController MonoSingleton<FPHGameplayUIController>::get_Instance().__il2cppRuntimeField_20 + 36 + 8 + ((0 + 0) + 16) << 2) + 16.transform;
            mem2[0] = (public static FPHGameplayUIController MonoSingleton<FPHGameplayUIController>::get_Instance().__il2cppRuntimeField_20 + 36 + 8 + ((0 + 0) + 16) << 2) + 16;
            DG.Tweening.TweenCallback val_12 = new DG.Tweening.TweenCallback(object:  304631808, method:  new IntPtr(2676606720));
            DG.Tweening.Tween val_13 = DG.Tweening.DOVirtual.DelayedCall(delay:  val_10.x, callback:  1073741824, ignoreTimeScale:  false);
            val_16 = 0;
            val_15 = val_15 + 1;
        }
        while(val_15 < val_16);
        
        }
        
        if(val_16 > 0)
        {
                val_14 = 1;
        }
        
        return true;
    }
    public override void Initialize()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 >= (R7 + 1368))
        {
                0 = 1;
        }
        
        R6.interactable = true;
        if(0 != (R6 + 1372))
        {
                return;
        }
        
        System.Action val_2 = new System.Action(object:  -1618222528, method:  new IntPtr(2676719744));
        MonoExtensions.DelayedCallEndOfFrame(monoBehaviour:  -1618222528, callback:  7454720);
    }
    public FPHPowerupHintButton()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }
    private void <Initialize>b__6_0()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = PlaceGameObject<System.Object>(loc:  0);
        UnityEngine.Transform val_3 = transform;
        UnityEngine.GameObject val_4 = this.gameObject;
        UnityEngine.Transform val_5 = this.transform;
        SetParent(p:  -1617998352);
        UnityEngine.Transform val_6 = transform;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
        localScale = new UnityEngine.Vector3();
        UnityEngine.GameObject val_8 = this.gameObject;
        ShowToolTip(objToToolTip:  -1617998352, text:  -1618022528, topToolTip:  true, displayDuration:  val_7.x, width:  val_7.y, height:  val_7.z, tooltipOffsetX:  null, tooltipOffsetY:  null, viewportSettings:  1082130432, showGotItButton:  false, gotItCallback:  1133903872, showPick:  false, maxFontSize:  3259498496);
    }

}
