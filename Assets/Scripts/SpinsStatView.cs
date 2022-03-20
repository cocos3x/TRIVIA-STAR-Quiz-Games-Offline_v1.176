using UnityEngine;
public class SpinsStatView : CurrencyStatView
{
    // Fields
    public const string SPIN_STAT_UPDATE = "OnSpinAmountUpdate";
    
    // Properties
    protected override CurrencyType getMyCurrency { get; }
    
    // Methods
    private void OnSpinAmountUpdate(Notification notif)
    {
        var val_4;
        if(notif.data != 0)
        {
                string val_1 = notif.data.ToString();
            val_4 = (System.Boolean.Parse(value:  notif.data)) ^ 1;
        }
        else
        {
                val_4 = 1;
        }
    
    }
    protected override decimal GetCountUpBalance()
    {
        null = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = R1 + 36, hi = R1 + 40, lo = R1 + 44, mid = R1 + 48}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                var val_2 = R1 + 36;
            return new System.Decimal() {flags = -1005918432, hi = R1 + 40, lo = R1 + 44, mid = R1 + 48};
        }
        
        RestaurantRivals.RESPlayer val_3 = RestaurantRivals.RESPlayer.Instance;
        decimal val_4 = System.Decimal.op_Implicit(value:  -1005918432);
        return new System.Decimal() {flags = val_4.flags, hi = val_4.hi, lo = val_4.lo, mid = val_4.mid};
    }
    protected override void OnTouchAreaClicked()
    {
    
    }
    protected override string GetBalanceUpdateNotificationName()
    {
    
    }
    protected override CurrencyType get_getMyCurrency()
    {
    
    }
    public SpinsStatView()
    {
    
    }

}
