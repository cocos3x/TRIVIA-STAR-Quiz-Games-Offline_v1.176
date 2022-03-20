using UnityEngine;
public class RESGameplayBehavior : GameplayBehavior
{
    // Methods
    public override bool SupportAdvancedPlayerPopup()
    {
        return false;
    }
    public override bool SupportsHintTutorials()
    {
        return false;
    }
    public override bool SupportsHintPopup()
    {
        return true;
    }
    public override bool DemoPopupEnabled()
    {
        return false;
    }
    public override bool SupportsPickerHint()
    {
        return false;
    }
    public override bool SupportsMegaHint()
    {
        return false;
    }
    public override bool IsPickerHintActivated()
    {
        return false;
    }
    public override string StoreBonusAmountText(decimal rawPercent)
    {
        decimal val_1 = new System.Decimal(value:  100);
        decimal val_2 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = -732770720, hi = rawPercent.flags, lo = rawPercent.hi, mid = rawPercent.lo}, d2:  new System.Decimal() {flags = rawPercent.mid, hi = val_1.flags, lo = val_1.hi, mid = val_1.lo});
        decimal val_4 = System.Math.Round(d:  new System.Decimal() {flags = -732770736});
        string val_5 = ToString();
        string val_6 = System.String.Format(format:  -732782736, arg0:  -732770688);
    }
    public override string GetCurrentLevelPlayerPrefKey()
    {
    
    }
    public override string GetExtraRequiredWordsPrefKey_NormalGameplay()
    {
    
    }
    public RESGameplayBehavior()
    {
    
    }

}
