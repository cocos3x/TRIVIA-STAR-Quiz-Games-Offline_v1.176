using UnityEngine;
public class FeaturedOfferStoreItem : WGStoreItem
{
    // Fields
    private UnityEngine.UI.Text text_percent_discount;
    
    // Methods
    public override void UpdateUI(PurchaseModel pack, int packIndex, int totalPackItems, IStoreUI storeUI)
    {
        int val_3;
        this.UpdateUI(pack:  pack, packIndex:  packIndex, totalPackItems:  totalPackItems, storeUI:  storeUI);
        decimal val_1 = FeaturedOfferManager.BonusCoinPercentage;
        decimal val_2 = new System.Decimal(value:  100);
        decimal val_4 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = -1259930152}, d2:  new System.Decimal() {flags = val_3, hi = val_2.flags, lo = val_2.hi, mid = val_2.lo});
        GameEcon val_5 = App.getGameEcon;
        string val_6 = ToString(format:  null);
        string val_7 = System.String.Format(format:  -1259942304, arg0:  -1259930120);
        string val_8 = Localization.Localize(key:  -1259942224, defaultValue:  -1259942128, useSingularKey:  false);
        string val_9 = -1259942304(-1259942304) + -1259942224(-1259942224);
        if(this.text_percent_discount != 0)
        {
                return;
        }
    
    }
    public FeaturedOfferStoreItem()
    {
    
    }

}
