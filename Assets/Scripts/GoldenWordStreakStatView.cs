using UnityEngine;
public class GoldenWordStreakStatView : GoldenApplesStatView
{
    // Methods
    private void OnWordStreakUpdated()
    {
        goto typeof(GoldenWordStreakStatView).__il2cppRuntimeField_E4;
    }
    protected override decimal GetCountUpBalance()
    {
        int val_1 = WordStreak.ApplesFromStreak;
        decimal val_2 = System.Decimal.op_Implicit(value:  -1228631888);
        return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
    }
    protected override string GetBalanceUpdateNotificationName()
    {
    
    }
    protected override void OnTouchAreaClicked()
    {
    
    }
    public GoldenWordStreakStatView()
    {
    
    }

}
