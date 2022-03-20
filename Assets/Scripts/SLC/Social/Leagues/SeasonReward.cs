using UnityEngine;

namespace SLC.Social.Leagues
{
    public class SeasonReward : EncodableModel
    {
        // Fields
        public string cat1;
        public string cat2;
        public string cat3;
        public string cat4;
        
        // Properties
        public decimal GetCategory1Reward { get; }
        public decimal GetCategory2Reward { get; }
        public decimal GetCategory3Reward { get; }
        public decimal GetCategory4Reward { get; }
        
        // Methods
        public decimal get_GetCategory1Reward()
        {
            System.Globalization.CultureInfo val_1 = System.Globalization.CultureInfo.InvariantCulture;
            decimal val_2 = System.Decimal.Parse(s:  833901280, provider:  R1 + 8);
            return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
        }
        public decimal get_GetCategory2Reward()
        {
            System.Globalization.CultureInfo val_1 = System.Globalization.CultureInfo.InvariantCulture;
            decimal val_2 = System.Decimal.Parse(s:  834013280, provider:  R1 + 12);
            return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
        }
        public decimal get_GetCategory3Reward()
        {
            System.Globalization.CultureInfo val_1 = System.Globalization.CultureInfo.InvariantCulture;
            decimal val_2 = System.Decimal.Parse(s:  834125280, provider:  R1 + 16);
            return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
        }
        public decimal get_GetCategory4Reward()
        {
            System.Globalization.CultureInfo val_1 = System.Globalization.CultureInfo.InvariantCulture;
            decimal val_2 = System.Decimal.Parse(s:  834237280, provider:  R1 + 20);
            return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
        }
        public decimal GetRewardFromRank(int rank)
        {
            if(R2 <= 1)
            {
                    decimal val_1 = this.GetCategory1Reward;
                return new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid};
            }
            
            if(R2 <= 4)
            {
                    decimal val_2 = this.GetCategory2Reward;
                return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
            }
            
            if(R2 <= 10)
            {
                    decimal val_3 = this.GetCategory3Reward;
                return new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid};
            }
            
            decimal val_4 = this.GetCategory4Reward;
            return new System.Decimal() {flags = val_4.flags, hi = val_4.hi, lo = val_4.lo, mid = val_4.mid};
        }
        public SeasonReward()
        {
        
        }
    
    }

}
