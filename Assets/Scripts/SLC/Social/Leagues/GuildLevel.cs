using UnityEngine;

namespace SLC.Social.Leagues
{
    public class GuildLevel
    {
        // Fields
        public int MaximumMembers;
        public int RequiredCoinSupport;
        
        // Properties
        public decimal CoinSupportRequired { get; }
        
        // Methods
        public GuildLevel(int maxMembers, int requiredSupport)
        {
            this.MaximumMembers = maxMembers;
            this.RequiredCoinSupport = requiredSupport;
        }
        public decimal get_CoinSupportRequired()
        {
            decimal val_1 = System.Decimal.op_Implicit(value:  818879632);
            return new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid};
        }
    
    }

}
