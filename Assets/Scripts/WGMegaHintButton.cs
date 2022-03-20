using UnityEngine;
public class WGMegaHintButton : MyButton
{
    // Fields
    private UnityEngine.UI.Text hintCostText;
    private UnityEngine.GameObject crossedOutCost;
    private UnityEngine.UI.Text crossedOutText;
    private bool alwaysShowDiscount;
    
    // Methods
    private void Awake()
    {
    
    }
    protected override void Start()
    {
        this.Start();
        this.UpdateDisplay();
    }
    public override void OnButtonClick()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        OnMegaHintPressed(freeHint:  false);
    }
    private void OnHintDiscountAvailable()
    {
        this.UpdateDisplay();
    }
    private void OnHintDiscountExpire()
    {
        this.UpdateDisplay();
    }
    private void UpdateDisplay()
    {
        var val_14;
        if(this.hintCostText != 0)
        {
                if(this.alwaysShowDiscount != false)
        {
                GameEcon val_3 = App.getGameEcon;
            decimal val_4 = HintMEGACostDiscounted;
        }
        else
        {
                GameEcon val_5 = App.getGameEcon;
        }
        
            GameEcon val_6 = App.getGameEcon;
            string val_7 = ToString(format:  null);
            val_14;
        }
        
        if(this.crossedOutText != 0)
        {
                GameEcon val_9 = App.getGameEcon;
            GameEcon val_10 = App.getGameEcon;
            string val_11 = ToString(format:  null);
            val_14;
        }
        
        if(this.crossedOutCost == 0)
        {
                return;
        }
        
        this.crossedOutCost.SetActive(value:  false);
    }
    private void OnEnable()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                return;
        }
        
        UnityEngine.Transform val_2 = R4.transform;
        UnityEngine.Transform val_3 = R4.parent;
        UnityEngine.GameObject val_4 = R4.gameObject;
        R4.SetActive(value:  false);
    }
    public WGMegaHintButton()
    {
    
    }

}
