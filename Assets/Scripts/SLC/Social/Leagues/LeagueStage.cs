using UnityEngine;

namespace SLC.Social.Leagues
{
    public class LeagueStage : EncodableModel
    {
        // Fields
        public string coinsRequirement;
        public string coinsReward;
        public int pointsReward;
        
        // Properties
        public decimal GetCoinReq { get; set; }
        public decimal GetCoinReward { get; set; }
        
        // Methods
        public decimal get_GetCoinReq()
        {
            System.Globalization.CultureInfo val_1 = System.Globalization.CultureInfo.InvariantCulture;
            decimal val_2 = System.Decimal.Parse(s:  834799328, provider:  R1 + 8);
            return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
        }
        public void set_GetCoinReq(decimal value)
        {
            string val_1 = value.flags.ToString();
            this.coinsRequirement = ;
        }
        public decimal get_GetCoinReward()
        {
            System.Globalization.CultureInfo val_1 = System.Globalization.CultureInfo.InvariantCulture;
            decimal val_2 = System.Decimal.Parse(s:  835023328, provider:  R1 + 12);
            return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
        }
        public void set_GetCoinReward(decimal value)
        {
            string val_1 = value.flags.ToString();
            this.coinsReward = ;
        }
        public LeagueStage()
        {
        
        }
    
    }

}
