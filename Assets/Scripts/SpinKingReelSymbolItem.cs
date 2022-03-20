using UnityEngine;
public class SpinKingReelSymbolItem : ScrollerIteam
{
    // Fields
    private UnityEngine.UI.Image symbol;
    private SpinKingSlotMachine.SpinKingSymbol <SymbolType>k__BackingField;
    
    // Properties
    public SpinKingSlotMachine.SpinKingSymbol SymbolType { get; set; }
    
    // Methods
    public SpinKingSlotMachine.SpinKingSymbol get_SymbolType()
    {
    
    }
    private void set_SymbolType(SpinKingSlotMachine.SpinKingSymbol value)
    {
        this.<SymbolType>k__BackingField = value;
    }
    public override void SetUp(ScrollerIteamData itemData)
    {
        if(itemData != 0)
        {
                this.<SymbolType>k__BackingField = null;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.Sprite val_2 = GetSymbolSprite(symbol:  this.<SymbolType>k__BackingField);
            this.symbol.sprite = -189820496;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static WGSpinKingSlotPopup MonoSingleton<WGSpinKingSlotPopup>::get_Instance().__il2cppRuntimeField_58.RecycleRESSymbolItemData(itemData:  itemData);
            return;
        }
    
    }
    public SpinKingReelSymbolItem()
    {
    
    }

}
