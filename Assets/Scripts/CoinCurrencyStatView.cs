using UnityEngine;
public class CoinCurrencyStatView : CurrencyStatView
{
    // Fields
    public const string COINS_STAT_UPDATE = "CoinsStatViewUpdate";
    
    // Methods
    private void CoinsStatViewUpdate(Notification notif)
    {
        var val_4;
        var val_5;
        val_4 = 35641518;
        if(notif.data != 0)
        {
                string val_1 = notif.data.ToString();
            bool val_2 = System.Boolean.Parse(value:  notif.data);
        }
        else
        {
                val_5 = 0;
        }
        
        if(notif == 0)
        {
                return;
        }
        
        var val_3 = val_5 ^ 1;
        goto typeof(CoinCurrencyStatView).__il2cppRuntimeField_E4;
    }
    protected override decimal GetCountUpBalance()
    {
        var val_5;
        int val_6;
        var val_1 = R1 + 36;
        val_5 = null;
        val_5 = null;
        val_6 = mem[(R1 + 36) + (4)];
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = mem[(R1 + 36) + (0)], hi = val_6, lo = mem[(R1 + 36) + (8)], mid = mem[(R1 + 36) + (12)]}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                var val_3 = R1 + 36;
            return new System.Decimal() {flags = -356439216, hi = App.__il2cppRuntimeField_cctor_finished, lo = mem[(R1 + 36) + (8)], mid = mem[(R1 + 36) + (12)]};
        }
        
        Player val_4 = App.Player;
        return new System.Decimal() {flags = -356439216, hi = App.__il2cppRuntimeField_cctor_finished, lo = mem[(R1 + 36) + (8)], mid = mem[(R1 + 36) + (12)]};
    }
    protected override void OnTouchAreaClicked()
    {
        UnityEngine.Debug.LogWarning(message:  -356351216);
    }
    protected override string GetBalanceUpdateNotificationName()
    {
    
    }
    public CoinCurrencyStatView()
    {
    
    }

}
