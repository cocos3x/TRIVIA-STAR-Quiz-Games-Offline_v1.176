using UnityEngine;

namespace RestaurantRivals
{
    public class RESPackageDefinitions : PackageDefinitions
    {
        // Properties
        public override System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> StandardCreditsScheme { get; }
        public override System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> SpinPackages { get; }
        public override System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> SpecialPackages { get; }
        
        // Methods
        public override System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> get_StandardCreditsScheme()
        {
            return this.GetStandardCreditsSchemeFromEcon();
        }
        private System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> GetStandardCreditsSchemeFromEcon()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1624646480, value:  -1254962464);
            Add(key:  2129282688, value:  13152256);
            Add(key:  -1816221696, value:  15282176);
            Add(item:  78753792);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1624646480, value:  -752095232);
            Player val_4 = App.Player;
            RestaurantRivals.RESLevelDef val_5 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  0);
            decimal val_6 = getCoin199Pack;
            Add(key:  2129282688, value:  10170368);
            Add(key:  -1816221696, value:  15282176);
            Add(item:  78753792);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_7 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1624646480, value:  -752095040);
            Player val_8 = App.Player;
            RestaurantRivals.RESLevelDef val_9 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  0);
            decimal val_10 = getCoin499Pack;
            Add(key:  2129282688, value:  10170368);
            Add(key:  -1816221696, value:  15282176);
            Add(item:  78753792);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_11 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1624646480, value:  -752094944);
            Player val_12 = App.Player;
            RestaurantRivals.RESLevelDef val_13 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  0);
            decimal val_14 = getCoin999Pack;
            Add(key:  2129282688, value:  10170368);
            Add(key:  -1816221696, value:  15282176);
            Add(item:  78753792);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_15 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1624646480, value:  -752094848);
            Player val_16 = App.Player;
            RestaurantRivals.RESLevelDef val_17 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  0);
            decimal val_18 = getCoin1999Pack;
            Add(key:  2129282688, value:  10170368);
            Add(key:  -1816221696, value:  15282176);
            Add(item:  78753792);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_19 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1624646480, value:  -752094752);
            Player val_20 = App.Player;
            RestaurantRivals.RESLevelDef val_21 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  0);
            decimal val_22 = getCoin4999Pack;
            Add(key:  2129282688, value:  10170368);
            Add(key:  -1816221696, value:  15282176);
            Add(item:  78753792);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_23 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1624646480, value:  -752094656);
            Player val_24 = App.Player;
            RestaurantRivals.RESLevelDef val_25 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  0);
            decimal val_26 = getCoin9999Pack;
            Add(key:  2129282688, value:  10170368);
            Add(key:  -1816221696, value:  15282176);
            Add(item:  78753792);
        }
        public override System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> get_SpinPackages()
        {
            return this.GetSpinPackagesFromEcon();
        }
        private System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> GetSpinPackagesFromEcon()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1624646480, value:  -1801802112);
            RestaurantRivals.RESGameEcon val_3 = RestaurantRivals.RESGameEcon.Instance;
            int val_4 = 0.NoAdsSpinQuantity;
            Add(key:  -1987367328, value:  13152256);
            Add(key:  -1816221696, value:  15282176);
            Add(item:  78753792);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1624646480, value:  512746512);
            Player val_6 = App.Player;
            RestaurantRivals.RESLevelDef val_7 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  0);
            if(0 < 30)
            {
                    30 = 25;
            }
            
            Add(key:  -1987367328, value:  13152256);
            Add(key:  -1816221696, value:  15282176);
            Add(item:  78753792);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_8 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1624646480, value:  512746608);
            Player val_9 = App.Player;
            RestaurantRivals.RESLevelDef val_10 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  0);
            if(0 < 30)
            {
                    90 = 70;
            }
            
            Add(key:  -1987367328, value:  13152256);
            Add(key:  -1816221696, value:  15282176);
            Add(item:  78753792);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_11 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1624646480, value:  512746704);
            Player val_12 = App.Player;
            RestaurantRivals.RESLevelDef val_13 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  0);
            if(0 < 30)
            {
                    260 = 200;
            }
            
            Add(key:  -1987367328, value:  13152256);
            Add(key:  -1816221696, value:  15282176);
            Add(item:  78753792);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_14 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1624646480, value:  512746800);
            Player val_15 = App.Player;
            RestaurantRivals.RESLevelDef val_16 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  0);
            Add(key:  -1987367328, value:  13152256);
            Add(key:  -1816221696, value:  15282176);
            Add(item:  78753792);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_17 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1624646480, value:  512746896);
            Player val_18 = App.Player;
            RestaurantRivals.RESLevelDef val_19 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  0);
            if(0 < 30)
            {
                    1600 = 1200;
            }
            
            Add(key:  -1987367328, value:  13152256);
            Add(key:  -1816221696, value:  15282176);
            Add(item:  78753792);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_20 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1624646480, value:  512746992);
            Player val_21 = App.Player;
            RestaurantRivals.RESLevelDef val_22 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  0);
            if(0 < 30)
            {
                    3600 = 2800;
            }
            
            Add(key:  -1987367328, value:  13152256);
            Add(key:  -1816221696, value:  15282176);
            Add(item:  78753792);
        }
        public override System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> get_SpecialPackages()
        {
            return this.GetSpecialPackagesFromEcon();
        }
        private System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> GetSpecialPackagesFromEcon()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1624646480, value:  -656231600);
            Player val_3 = App.Player;
            RestaurantRivals.RESLevelDef val_4 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  0);
            Add(key:  2129282688, value:  13152256);
            Player val_5 = App.Player;
            RestaurantRivals.RESLevelDef val_6 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  0);
            Add(key:  -1816221696, value:  10489856);
            Add(item:  78753792);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_7 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1624646480, value:  512971088);
            Player val_8 = App.Player;
            RestaurantRivals.RESLevelDef val_9 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  0);
            if(0 < 30)
            {
                    150 = 105;
            }
            
            Add(key:  -1987367328, value:  13152256);
            Add(key:  -1816221696, value:  15282176);
            Add(item:  78753792);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_10 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1624646480, value:  512971216);
            Player val_11 = App.Player;
            RestaurantRivals.RESLevelDef val_12 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  0);
            if(0 < 30)
            {
                    150 = 105;
            }
            
            Add(key:  -1987367328, value:  13152256);
            Add(key:  -1816221696, value:  15282176);
            Add(item:  78753792);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_13 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1624646480, value:  512971344);
            Player val_14 = App.Player;
            RestaurantRivals.RESLevelDef val_15 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  0);
            if(0 < 30)
            {
                    15 = 12;
            }
            
            Add(key:  -1987367328, value:  13152256);
            Add(key:  -1816221696, value:  15282176);
            Add(item:  78753792);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_16 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1624646480, value:  512971472);
            Player val_17 = App.Player;
            RestaurantRivals.RESLevelDef val_18 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  0);
            if(0 < 30)
            {
                    35 = 30;
            }
            
            Add(key:  -1987367328, value:  13152256);
            Add(key:  -1816221696, value:  15282176);
            Add(item:  78753792);
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_19 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  1624646480, value:  512971600);
            Player val_20 = App.Player;
            RestaurantRivals.RESLevelDef val_21 = RestaurantRivals.RESGameEconHelper.GetRESLevelDef(level:  0);
            if(0 < 30)
            {
                    70 = 60;
            }
            
            Add(key:  -1987367328, value:  13152256);
            Add(key:  -1816221696, value:  15282176);
            Add(item:  78753792);
        }
        public RESPackageDefinitions()
        {
        
        }
    
    }

}
