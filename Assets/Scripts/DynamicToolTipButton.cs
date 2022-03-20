using UnityEngine;
public class DynamicToolTipButton : MyButton
{
    // Fields
    private bool topToolTip;
    private UnityEngine.GameObject toolTipOwner;
    private string tooltipLocKey;
    private string toolTipText;
    private UnityEngine.GameObject currentToolTip;
    
    // Methods
    public override void OnButtonClick()
    {
        this.OnButtonClick();
        this.PlaceToolTip();
    }
    private void PlaceToolTip()
    {
        string val_9;
        UnityEngine.GameObject val_10;
        val_9 = 1152921504765685760;
        if(this.currentToolTip != 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_3 = PlaceGameObject<System.Object>(loc:  0);
        UnityEngine.GameObject val_4 = gameObject;
        this.currentToolTip = public static UGUIDynamicPlacementManager MonoSingleton<UGUIDynamicPlacementManager>::get_Instance();
        UnityEngine.GameObject val_5 = this.gameObject;
        val_10 = this;
        if(this.toolTipOwner != 0)
        {
                UnityEngine.GameObject val_7 = this.toolTipOwner.gameObject;
            val_10 = this.toolTipOwner;
        }
        
        string val_8 = Localization.Localize(key:  this.tooltipLocKey, defaultValue:  this.toolTipText, useSingularKey:  false);
        val_9 = this.tooltipLocKey;
        if(this.topToolTip == true)
        {
                this.topToolTip = 1;
        }
        
        ShowToolTip(objToToolTip:  val_10, text:  val_9, topToolTip:  true, displayDuration:  null, width:  null, height:  null, tooltipOffsetX:  null, tooltipOffsetY:  null, viewportSettings:  1080033280, showGotItButton:  false, gotItCallback:  0, showPick:  false, maxFontSize:  0);
    }
    public DynamicToolTipButton()
    {
        this.topToolTip = true;
        this.tooltipLocKey = "";
        this.toolTipText = "";
    }

}
