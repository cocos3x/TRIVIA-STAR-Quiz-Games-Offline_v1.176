using UnityEngine;
public class TRVGameplayBehavior : GameplayBehavior
{
    // Methods
    public override bool SupportAdvancedPlayerPopup()
    {
        return false;
    }
    public override string StoreBonusAmountText(decimal rawPercent)
    {
        string val_1 = Localization.Localize(key:  -758221296, defaultValue:  -758221392, useSingularKey:  false);
        decimal val_2 = new System.Decimal(value:  100);
        decimal val_3 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = -725396056, hi = rawPercent.flags, lo = rawPercent.hi, mid = rawPercent.lo}, d2:  new System.Decimal() {flags = rawPercent.mid, hi = val_2.flags, lo = val_2.hi, mid = val_2.lo});
        decimal val_5 = System.Math.Round(d:  new System.Decimal() {flags = -725396072});
        string val_6 = val_2.flags.ToString();
        string val_7 = System.String.Format(format:  -758221296, arg0:  -725396040);
    }
    public override decimal CalculateStoreBonusPercent(PurchaseModel pack, int decimalPlaces)
    {
        int val_4;
        int val_5;
        int val_6;
        int val_7;
        int val_8;
        int val_14;
        int val_15;
        int val_16;
        int val_17;
        int val_20;
        int val_30;
        float val_33;
        if(decimalPlaces != 0)
        {
                decimal val_1 = Credits;
        }
        else
        {
                decimal val_2 = Credits;
        }
        
        decimal val_3 = System.Decimal.op_Explicit(value:  null);
        decimal val_9 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = -725279996}, d2:  new System.Decimal() {flags = val_5, hi = val_4, lo = val_6, mid = val_7});
        GameEcon val_10 = App.getGameEcon;
        decimal val_11 = base099CreditPackSize;
        decimal val_12 = new System.Decimal(lo:  99, mid:  0, hi:  0, isNegative:  false, scale:  2);
        decimal val_13 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = -725280016}, d2:  new System.Decimal() {flags = val_8, hi = val_12.flags, lo = val_12.hi, mid = val_12.lo});
        decimal val_19 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = -725280032, hi = val_12.hi, lo = val_12.lo, mid = val_12.mid}, d2:  new System.Decimal() {flags = val_15, hi = val_14, lo = val_16, mid = val_17});
        decimal val_21 = System.Decimal.Round(d:  new System.Decimal() {flags = -725280048}, decimals:  val_20);
        float val_22 = System.Decimal.op_Explicit(value:  new System.Decimal());
        float val_23 = R0 + (-1f);
        val_23 = val_23 * 100f;
        float val_24 = val_23 / 5f;
        float val_26 = S22 + (-1f);
        if((UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished & 1) != 0)
        {
                val_33 = S22;
        }
        
         =  * 5f;
        int val_27 = UnityEngine.Mathf.CeilToInt(f:  null);
        decimal val_28 = System.Decimal.op_Implicit(value:  -725280064);
        decimal val_29 = new System.Decimal(value:  100);
        decimal val_31 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = -725267872}, d2:  new System.Decimal() {flags = val_30, hi = val_29.flags, lo = val_29.hi, mid = val_29.lo});
        return new System.Decimal() {flags = val_31.flags, hi = val_31.hi, lo = val_31.lo, mid = val_31.mid};
    }
    public TRVGameplayBehavior()
    {
    
    }

}
