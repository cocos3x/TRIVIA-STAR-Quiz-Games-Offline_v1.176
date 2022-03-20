using UnityEngine;
public class WGStarterPackStoreItem : WGStoreItem
{
    // Fields
    private UnityEngine.UI.Text text_countdown_time;
    private UnityEngine.UI.Text text_coins_amount;
    private UnityEngine.UI.Text text_dollar_value;
    private FrameSkipper _skipper;
    
    // Properties
    private FrameSkipper skipper { get; }
    
    // Methods
    private FrameSkipper get_skipper()
    {
        if(this._skipper != 0)
        {
                return;
        }
        
        object val_2 = this.GetComponent<System.Object>();
        this._skipper = this;
    }
    public override void Awake()
    {
        this.Awake();
        FrameSkipper val_1 = this.skipper;
        System.Action val_2 = new System.Action(object:  65783920, method:  new IntPtr(65758896));
        mem[1152921513262565512] = null;
    }
    public override void UpdateUI(PurchaseModel pack, int packIndex, int totalPackItems, IStoreUI storeUI)
    {
        UnityEngine.UI.Text val_7;
        this.UpdateUI(pack:  pack, packIndex:  packIndex, totalPackItems:  totalPackItems, storeUI:  storeUI);
        val_7 = this.text_coins_amount;
        if(val_7 == 0)
        {
                return;
        }
        
        decimal val_2 = Credits;
        string val_3 = ToString(format:  -1774412176);
        string val_4 = Localization.Localize(key:  -1528659216, defaultValue:  -1528659376, useSingularKey:  false);
        string val_5 = System.String.Format(format:  1592589744, arg0:  65900248, arg1:  -1528659216);
    }
    private void UpdateTimer()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.TimeSpan val_2 = timeRemaining;
        string val_3 = GenericStringExtentions.ToString(span:  new System.TimeSpan(), formatted:  true);
        if(this.text_countdown_time != 0)
        {
                return;
        }
    
    }
    public WGStarterPackStoreItem()
    {
        mem[1152921513262942504] = 1;
        val_1 = new MyButton();
    }

}
