using UnityEngine;
public class WGStoreItem_pet : WGStoreItem
{
    // Methods
    public override void UpdateUI(PurchaseModel pack, int packIndex, int totalPackItems, IStoreUI storeUI)
    {
        UnityEngine.Object val_10;
        PurchaseModel val_16;
        var val_17;
        val_16 = pack;
        mem[1152921513266427848] = val_16;
        mem[1152921513266427852] = storeUI;
        if(storeUI != 0)
        {
                storeUI.sprite = 0;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  storeUI)) != false)
        {
                decimal val_3 = PetsFood;
            GameEcon val_4 = App.getGameEcon;
            string val_5 = ToString(format:  null);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  69634104)) != false)
        {
                string val_8 = val_16.LocalPrice;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  69634104)) == false)
        {
                return;
        }
        
        if(val_10 != 0)
        {
                return;
        }
        
        if(totalPackItems >= 1)
        {
                string val_14 = pack.id;
            val_14 = (packIndex - totalPackItems) + val_14;
            val_17 = val_16 + ((UnityEngine.Mathf.Max(a:  val_14, b:  0)) << 2);
        }
        else
        {
                val_17 = val_16 + (packIndex << 2);
        }
        
        val_16.sprite = (pack + (packIndex) << 2).vipApplied;
    }
    public WGStoreItem_pet()
    {
        mem[1152921513266560280] = 1;
        val_1 = new MyButton();
    }

}
