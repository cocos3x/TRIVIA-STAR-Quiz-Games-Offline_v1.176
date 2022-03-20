using UnityEngine;

namespace RestaurantRivals
{
    public class RESEconConfig : EconConfig
    {
        // Fields
        public System.Collections.Generic.List<RestaurantRivals.RESLevelDef> levelDefs;
        protected System.Collections.Generic.Dictionary<GiftRewardSource, System.Collections.Generic.List<GiftRewardTypeChance>> rrvGiftRewardTypeChances;
        
        // Properties
        public override System.Collections.Generic.Dictionary<GiftRewardSource, System.Collections.Generic.List<GiftRewardTypeChance>> GiftRewardTypeChances { get; }
        
        // Methods
        private void Awake()
        {
            mem[1152921513726369064] = 0;
        }
        public override System.Collections.Generic.Dictionary<GiftRewardSource, System.Collections.Generic.List<GiftRewardTypeChance>> get_GiftRewardTypeChances()
        {
        
        }
        public RESEconConfig()
        {
            var val_2;
            System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_1 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
            val_2 = null;
            val_2 = null;
            Add(key:  0, value:  RestaurantRivals.RESGameEcon.DailyBonusRewardTypeChances);
            Add(key:  2, value:  RestaurantRivals.RESGameEcon.DailyBonusRewardTypeChances);
            Add(key:  1, value:  RestaurantRivals.RESGameEcon.DailyBonusRewardTypeChances);
            this.rrvGiftRewardTypeChances = null;
        }
    
    }

}
