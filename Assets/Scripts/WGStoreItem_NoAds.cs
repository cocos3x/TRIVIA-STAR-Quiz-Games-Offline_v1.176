using UnityEngine;
public class WGStoreItem_NoAds : WGStoreItem
{
    // Fields
    private UnityEngine.UI.Text gemAmount;
    private UnityEngine.GameObject gemGroupParent;
    private UnityEngine.GameObject coinGroupParent;
    
    // Methods
    public override void UpdateUI(PurchaseModel pack, int packIndex, int totalPackItems, IStoreUI storeUI)
    {
        UnityEngine.UI.Text val_25;
        var val_26;
        var val_28;
        string val_30;
        val_25 = 35633532;
        mem[1152921513265910216] = pack;
        mem[1152921513265910220] = storeUI;
        if(storeUI != 0)
        {
                storeUI.sprite = 0;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  storeUI)) == false)
        {
            goto label_11;
        }
        
        decimal val_3 = Credits;
        val_26 = null;
        val_26 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == false)
        {
            goto label_11;
        }
        
        decimal val_5 = Credits;
        GameEcon val_6 = App.getGameEcon;
        string val_7 = ToString(format:  null);
        goto label_17;
        label_11:
        this.coinGroupParent.SetActive(value:  false);
        label_17:
        if((UnityEngine.Object.op_Implicit(exists:  this.gemAmount)) == false)
        {
            goto label_25;
        }
        
        decimal val_9 = Gems;
        val_28 = null;
        val_28 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero})) == false)
        {
            goto label_25;
        }
        
        val_25 = this.gemAmount;
        decimal val_11 = Gems;
        GameEcon val_12 = App.getGameEcon;
        string val_13 = ToString(format:  null);
        if(val_25 != 0)
        {
            goto label_34;
        }
        
        goto label_34;
        label_25:
        if(this.gemGroupParent != 0)
        {
                this.gemGroupParent.SetActive(value:  false);
        }
        
        label_34:
        if((UnityEngine.Object.op_Implicit(exists:  this.gemGroupParent)) != false)
        {
                string val_16 = pack.LocalPrice;
            val_25 = pack;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.gemGroupParent)) != false)
        {
                UnityEngine.GameObject val_18 = this.gemGroupParent.gameObject;
            this.gemGroupParent.SetActive(value:  false);
        }
        
        val_30 = pack.id;
        if((val_30.Contains(value:  -1801681824)) == false)
        {
                return;
        }
        
        val_30 = 1152921504892043264;
        GameEcon val_20 = App.getGameEcon;
        if((pack.sale_price.Equals(obj:  null)) != false)
        {
                Player val_22 = App.Player;
            if(0.RemovedAds == false)
        {
                return;
        }
        
        }
        
        UnityEngine.GameObject val_24 = this.gameObject;
        this.SetActive(value:  false);
    }
    public WGStoreItem_NoAds()
    {
        mem[1152921513266054936] = 1;
        val_1 = new MyButton();
    }

}
