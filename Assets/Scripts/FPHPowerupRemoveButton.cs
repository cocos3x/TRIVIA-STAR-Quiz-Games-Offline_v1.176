using UnityEngine;
public class FPHPowerupRemoveButton : FPHPowerupButton
{
    // Properties
    protected override int Cost { get; }
    protected override string TrackingSource { get; }
    
    // Methods
    protected override int get_Cost()
    {
        var val_2;
        GameBehavior val_1 = App.getBehavior;
        val_2 = 0;
        if(0 <= (R6 + 1392))
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
        FPHGameplayController val_1 = FPHGameplayController.Instance;
        if(0 == 0)
        {
            
        }
    
    }
    public override void Initialize()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 >= (R7 + 1384))
        {
                0 = 1;
        }
        
        R6.interactable = true;
        if(0 != (R6 + 1388))
        {
                return;
        }
        
        System.Action val_2 = new System.Action(object:  -1617317040, method:  new IntPtr(2677625232));
        MonoExtensions.DelayedCallEndOfFrame(monoBehaviour:  -1617317040, callback:  7454720);
    }
    public FPHPowerupRemoveButton()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }
    private void <Initialize>b__5_0()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = PlaceGameObject<System.Object>(loc:  0);
        UnityEngine.Transform val_3 = transform;
        UnityEngine.GameObject val_4 = this.gameObject;
        UnityEngine.Transform val_5 = this.transform;
        SetParent(p:  -1617092752);
        UnityEngine.Transform val_6 = transform;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
        localScale = new UnityEngine.Vector3();
        UnityEngine.GameObject val_8 = this.gameObject;
        ShowToolTip(objToToolTip:  -1617092752, text:  -1617117040, topToolTip:  true, displayDuration:  val_7.x, width:  val_7.y, height:  val_7.z, tooltipOffsetX:  null, tooltipOffsetY:  null, viewportSettings:  1082130432, showGotItButton:  false, gotItCallback:  1137180672, showPick:  false, maxFontSize:  3259498496);
    }

}
