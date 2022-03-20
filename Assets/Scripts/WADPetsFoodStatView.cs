using UnityEngine;
public class WADPetsFoodStatView : CurrencyStatView
{
    // Properties
    protected override CurrencyType getMyCurrency { get; }
    
    // Methods
    private void OnPetsFoodUpdated(Notification notif)
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
            return new System.Decimal() {flags = -972739216, hi = R1 + 40, lo = R1 + 44, mid = R1 + 48};
        }
        
        Player val_3 = App.Player;
        decimal val_4 = System.Decimal.op_Implicit(value:  -972739216);
        return new System.Decimal() {flags = val_4.flags, hi = val_4.hi, lo = val_4.lo, mid = val_4.mid};
    }
    protected override string GetBalanceUpdateNotificationName()
    {
    
    }
    protected override void OnTouchAreaClicked()
    {
        if(static_value_021FD21C == 0)
        {
                return;
        }
        
        R4 + 28 + 172.Invoke();
    }
    protected override CurrencyType get_getMyCurrency()
    {
    
    }
    public WADPetsFoodStatView()
    {
    
    }

}
