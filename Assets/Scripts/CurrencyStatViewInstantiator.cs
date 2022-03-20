using UnityEngine;
public class CurrencyStatViewInstantiator : StatViewInstantiatior
{
    // Fields
    private CurrencyStatViewInstantiator.CurrencyType currencyType;
    
    // Methods
    protected override UnityEngine.GameObject GetPrefabFromTheme()
    {
        if(this.currencyType > 4)
        {
                return;
        }
        
        var val_1 = 14149428 + (14149428 + (this.currencyType) << 2);
        if(this.currencyType == 4)
        {
                14149428 + (this.currencyType) << 2 = (14149428 + (this.currencyType) << 2) & (this << (14149428 + (this.currencyType) << 2));
            14149428 + (this.currencyType) << 2 = (14149428 + (this.currencyType) << 2) & ((IP) << 1);
            mem2[0] = ((14149428 + (this.currencyType) << 2 & (this) << 14149428 + (this.currencyType) << 2) & (IP) << 1) + IP;
        }
        
        if(R2 != 0)
        {
                ThemesHandler val_3 = App.ThemesHandler;
            if(2621443 != 0)
        {
                return 2621443.CoinCurrencyStatViewPrefab_anchored;
        }
        
            return 2621443.CoinCurrencyStatViewPrefab_anchored;
        }
        
        ThemesHandler val_12 = App.ThemesHandler;
        if(2621443 != 0)
        {
                return 2621443.CoinCurrencyStatViewPrefab;
        }
        
        return 2621443.CoinCurrencyStatViewPrefab;
    }
    protected override void SetupAnimatedElements()
    {
    
    }
    protected override void OverrideStatViewPostion(UnityEngine.RectTransform rectTransform)
    {
        var val_6;
        var val_7;
        if(this.currencyType > 4)
        {
                return;
        }
        
        var val_1 = 14150532 + (14150532 + (this.currencyType) << 2);
        if(this.currencyType == 4)
        {
                14150532 + (this.currencyType) << 2 = (14150532 + (this.currencyType) << 2) & (((R8) << (32-14150532 + (this.currencyType) << 2)) | ((R8) << 14150532 + (this.currencyType) << 2));
            14150532 + (this.currencyType) << 2 = (14150532 + (this.currencyType) << 2) & (rectTransform << (14150532 + (this.currencyType) << 2));
            14150532 + (this.currencyType) << 2 = (14150532 + (this.currencyType) << 2) & (rectTransform << (14150532 + (this.currencyType) << 2));
            14150532 + (this.currencyType) << 2 = (14150532 + (this.currencyType) << 2) & ((R8) >> 14150532);
        }
        
        GameBehavior val_2 = App.getBehavior;
        val_6 = 0;
        val_7 = mem[1179404931];
        goto mem[1179404939];
    }
    public CurrencyStatViewInstantiator()
    {
    
    }

}
