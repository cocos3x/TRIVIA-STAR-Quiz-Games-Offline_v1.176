using UnityEngine;

namespace RestaurantRivals
{
    public class RESReelSymbolItem : ScrollerIteam
    {
        // Fields
        private UnityEngine.UI.Image symbol;
        private string <SymbolName>k__BackingField;
        
        // Properties
        public string SymbolName { get; set; }
        
        // Methods
        public string get_SymbolName()
        {
        
        }
        private void set_SymbolName(string value)
        {
            this.<SymbolName>k__BackingField = value;
        }
        public override void SetUp(ScrollerIteamData itemData)
        {
            if(itemData != 0)
            {
                    this.<SymbolName>k__BackingField = null;
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                UnityEngine.Sprite val_2 = GetSymbolSprite(symbol:  this.<SymbolName>k__BackingField);
                this.symbol.sprite = -1825802336;
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
                public static RestaurantRivals.RESSlotUIManager MonoSingleton<RestaurantRivals.RESSlotUIManager>::get_Instance().__il2cppRuntimeField_C.RecycleRESSymbolItemData(itemData:  itemData);
                return;
            }
        
        }
        public RESReelSymbolItem()
        {
        
        }
    
    }

}
