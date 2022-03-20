using UnityEngine;
public class WGStore_DicePackItem : WGStoreItem
{
    // Methods
    public override void UpdateUI(PurchaseModel pack, int packIndex, int totalPackItems, IStoreUI storeUI)
    {
        UnityEngine.Object val_10;
        PurchaseModel val_16;
        var val_17;
        val_16 = pack;
        mem[1152921512178373624] = val_16;
        mem[1152921512178373628] = storeUI;
        if(storeUI != 0)
        {
                storeUI.sprite = 0;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  storeUI)) != false)
        {
                decimal val_3 = DiceRolls;
            GameEcon val_4 = App.getGameEcon;
            string val_5 = ToString(format:  null);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  -1018420120)) != false)
        {
                string val_8 = val_16.LocalPrice;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  -1018420120)) == false)
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
    protected override void HandleConnectionClick(bool result)
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                this.HandleConnectionClick(result:  result);
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SLCWindow.CloseWindow(window:  public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_1C, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGStore_DicePackItem()
    {
        mem[1152921512178618056] = 1;
        val_1 = new MyButton();
    }

}
