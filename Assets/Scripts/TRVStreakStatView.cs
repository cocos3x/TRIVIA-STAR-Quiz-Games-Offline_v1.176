using UnityEngine;
public class TRVStreakStatView : CurrencyStatView
{
    // Fields
    private UnityEngine.GameObject textCrossout;
    
    // Properties
    protected override CurrencyType getMyCurrency { get; }
    
    // Methods
    protected override void OnEnable()
    {
        this.OnEnable();
        if((UnityEngine.Object.op_Implicit(exists:  this.textCrossout)) == false)
        {
                return;
        }
        
        R4 + 64.SetActive(value:  false);
    }
    public void SetTextCrossout()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.textCrossout)) == false)
        {
                return;
        }
        
        R4 + 64.SetActive(value:  true);
    }
    private void OnTRVStreakUpdate(Notification notif)
    {
        if(notif.data != 0)
        {
                string val_1 = notif.data.ToString();
            bool val_3 = (System.Boolean.Parse(value:  notif.data)) ^ 1;
        }
    
    }
    protected override void UpdateBalance(bool instantly = False)
    {
        this.UpdateBalance(instantly:  instantly);
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WordForest.WFOGameEcon val_3 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if(currentStreak != mem[1152921512476916260])
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_5 = currentStreak;
        string val_6 = System.String.Format(format:  -561909456, arg0:  13152256);
    }
    protected override decimal GetCountUpBalance()
    {
        var val_7;
        var val_1 = R1 + 36;
        val_7 = null;
        val_7 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = mem[(R1 + 36) + (0)], hi = mem[(R1 + 36) + (4)], lo = mem[(R1 + 36) + (8)], mid = R1 + 48}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                return new System.Decimal() {flags = R1 + 36, hi = mem[(R1 + 36) + (4)], lo = mem[(R1 + 36) + (8)], mid = R1 + 48};
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_5 = currentStreak;
        decimal val_6 = System.Decimal.op_Implicit(value:  -561773360);
        return new System.Decimal() {flags = val_6.flags, hi = val_6.hi, lo = val_6.lo, mid = val_6.mid};
    }
    protected override string GetBalanceUpdateNotificationName()
    {
    
    }
    protected override void OnTouchAreaClicked()
    {
        var val_9;
        var val_10;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_9 = null;
        if(GetActiveAndQueuedWindowCount() != 0)
        {
                GameBehavior val_3 = App.getBehavior;
            val_10 = mem[(1179403647 + (public TRVStreakPopup MetaGameBehavior::ShowUGUIFlyOut<TRVStreakPopup>().__il2cppRuntimeField_28) << 3) + 192];
            val_10 = (1179403647 + (public TRVStreakPopup MetaGameBehavior::ShowUGUIFlyOut<TRVStreakPopup>().__il2cppRuntimeField_28) << 3) + 192;
            val_9 = 0;
        }
        else
        {
                GameBehavior val_5 = App.getBehavior;
            if(0 != 0)
        {
            goto (1179403647 + (public TRVStreakPopup MetaGameBehavior::ShowUGUIMonolith<TRVStreakPopup>(bool showNext).__il2cppRuntimeField_28) << 3) + 192;
        }
        
        }
    
    }
    protected override CurrencyType get_getMyCurrency()
    {
    
    }
    public TRVStreakStatView()
    {
    
    }

}
