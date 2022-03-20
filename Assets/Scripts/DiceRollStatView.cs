using UnityEngine;
public class DiceRollStatView : CurrencyStatView
{
    // Methods
    private void OnDiceRollsBalanceUpdated(Notification notif)
    {
        if(notif.data != 0)
        {
                string val_1 = notif.data.ToString();
            bool val_3 = (System.Boolean.Parse(value:  notif.data)) ^ 1;
        }
    
    }
    protected override decimal GetCountUpBalance()
    {
        var val_6;
        var val_7;
        float val_6 = 5.630884E-38f;
        val_6 = 8802744 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        if((SnakesAndLaddersEventHandler.<Instance>k__BackingField) == 0)
        {
            goto label_2;
        }
        
        var val_1 = R1 + 36;
        val_6 = null;
        val_6 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = mem[(R1 + 36) + (0)], hi = mem[(R1 + 36) + (4)], lo = mem[(R1 + 36) + (8)], mid = mem[(R1 + 36) + (12)]}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == false)
        {
            goto label_5;
        }
        
        var val_3 = R1 + 36;
        return new System.Decimal() {flags = -1038562272, hi = mem[(R1 + 36) + (4)], lo = mem[(R1 + 36) + (8)], mid = mem[(R1 + 36) + (12)]};
        label_2:
        val_7 = null;
        val_7 = null;
        return new System.Decimal() {flags = 10174468, hi = System.Decimal.__il2cppRuntimeField_cctor_finished};
        label_5:
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        int val_4 = SnakesAndLaddersEventHandler.<Instance>k__BackingField.GetDiceBalance();
        decimal val_5 = System.Decimal.op_Implicit(value:  -1038562272);
        return new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.mid};
    }
    protected override string GetBalanceUpdateNotificationName()
    {
    
    }
    protected override void OnTouchAreaClicked()
    {
    
    }
    public DiceRollStatView()
    {
    
    }

}
