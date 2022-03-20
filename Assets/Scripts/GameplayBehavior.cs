using UnityEngine;
public class GameplayBehavior
{
    // Methods
    public virtual bool SupportsHintTutorials()
    {
        return false;
    }
    public virtual void OnClick_UseHint()
    {
        var val_2;
        var val_2 = 29135503;
        val_2 = 6490284 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        string val_1 = -760573888(-760573888) + 295313408;
        UnityEngine.Debug.LogError(message:  -760573888);
    }
    public virtual void OnClick_UseMegaHint()
    {
        var val_2;
        var val_2 = 29135175;
        val_2 = 6490612 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        string val_1 = -760461728(-760461728) + 295313408;
        UnityEngine.Debug.LogError(message:  -760461728);
    }
    public virtual void OnClick_UsePickerHint()
    {
        var val_2;
        var val_2 = 29134847;
        val_2 = 6490940 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        string val_1 = -760349568(-760349568) + 295313408;
        UnityEngine.Debug.LogError(message:  -760349568);
    }
    public virtual string GetDifficultyForTracking()
    {
    
    }
    public virtual string GetProgressForTracking()
    {
    
    }
    public virtual string GetProgressTypeForTracking()
    {
    
    }
    public virtual bool DemoPopupEnabled()
    {
        return false;
    }
    public virtual bool SupportsHintPopup()
    {
        return true;
    }
    public virtual bool SupportsPickerHint()
    {
        return false;
    }
    public virtual bool SupportsMegaHint()
    {
        return false;
    }
    public virtual bool SupportsCheckHint()
    {
        return false;
    }
    public virtual bool IsPickerHintActivated()
    {
        return false;
    }
    public virtual bool SupportAdvancedPlayerPopup()
    {
        return true;
    }
    public virtual bool SupportSkipTutorial()
    {
        return true;
    }
    public virtual bool SupportExtraWords()
    {
        return true;
    }
    public virtual bool WaitForGenerationBeforeGamePopups()
    {
        return false;
    }
    public virtual int GetWordPanRadius(int numTile = 0)
    {
        return 250;
    }
    public virtual float GetPanElipseAdjustment()
    {
        return (float)S0;
    }
    public virtual float SetWordTileScale(int numTile)
    {
        int val_1 = numTile - 1;
        if(val_1 == 6)
        {
                1f = 0.75f;
        }
        
        if(val_1 == 7)
        {
                1f = 1060320051;
        }
        
        return (float)1f;
    }
    public virtual float GetLetterTileContainerScale()
    {
        return (float)S0;
    }
    public virtual float LineWordCellGap()
    {
        return (float)S0;
    }
    public virtual string StoreBonusAmountText(decimal rawPercent)
    {
        string val_1 = Localization.Localize(key:  -758221296, defaultValue:  -758221392, useSingularKey:  false);
        decimal val_2 = new System.Decimal(value:  100);
        decimal val_3 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = -758209272, hi = rawPercent.flags, lo = rawPercent.hi, mid = rawPercent.lo}, d2:  new System.Decimal() {flags = rawPercent.mid, hi = val_2.flags, lo = val_2.hi, mid = val_2.lo});
        decimal val_5 = System.Math.Round(d:  new System.Decimal() {flags = -758209288});
        string val_6 = val_2.flags.ToString();
        string val_7 = System.String.Format(format:  -758221296, arg0:  -758209256);
    }
    public virtual decimal CalculateStoreBonusPercent(PurchaseModel pack, int decimalPlaces)
    {
        int val_4;
        int val_5;
        int val_10;
        int val_12;
        int val_13;
        int val_14;
        int val_15;
        int val_18;
        if(decimalPlaces != 0)
        {
                decimal val_1 = Credits;
        }
        else
        {
                decimal val_2 = Credits;
        }
        
        decimal val_3 = System.Decimal.op_Explicit(value:  null);
        decimal val_6 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = -758093184}, d2:  new System.Decimal() {flags = val_4, hi = val_5});
        GameEcon val_7 = App.getGameEcon;
        decimal val_8 = base099CreditPackSize;
        decimal val_9 = new System.Decimal(lo:  99, mid:  0, hi:  0, isNegative:  false, scale:  2);
        decimal val_11 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = -758093224}, d2:  new System.Decimal() {flags = val_10, hi = val_9.flags, lo = val_9.hi, mid = val_9.lo});
        decimal val_17 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = -758093240}, d2:  new System.Decimal() {flags = val_13, hi = val_12, lo = val_14, mid = val_15});
        decimal val_19 = System.Decimal.Round(d:  new System.Decimal() {flags = -758093256}, decimals:  val_18);
        decimal val_20 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -758081088}, d2:  new System.Decimal() {flags = ???, hi = System.Decimal.One, lo = System.Decimal.Powers10.__il2cppRuntimeField_18, mid = System.Decimal.Powers10.__il2cppRuntimeField_1C});
        return new System.Decimal() {flags = val_20.flags, hi = val_20.hi, lo = val_20.lo, mid = val_20.mid};
    }
    public virtual string InfinityText()
    {
        string val_1 = Localization.Localize(key:  -2101083296, defaultValue:  -2101083200, useSingularKey:  false);
        return System.String.Format(format:  -2101083296, arg0:  -757988992);
    }
    public virtual string GetExtraReqWordsInfo()
    {
    
    }
    public virtual bool ShowCoinCollectOnServerCoinAwardPopup()
    {
        return true;
    }
    public virtual bool ShowAdsControlPopupAutomatically()
    {
        return true;
    }
    public virtual string GetCurrentLevelPlayerPrefKey()
    {
    
    }
    public virtual string GetExtraRequiredWordsPrefKey_NormalGameplay()
    {
    
    }
    public virtual bool UseNewLevelGen()
    {
        return false;
    }
    public GameplayBehavior()
    {
    
    }

}
