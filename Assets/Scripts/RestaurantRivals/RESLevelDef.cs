using UnityEngine;

namespace RestaurantRivals
{
    public class RESLevelDef : ScriptableObject
    {
        // Fields
        public const int buildCategories = 5;
        public const int buildTiers = 5;
        public int levelNumber;
        public string restaurantName;
        private System.Collections.Generic.List<double> buildCosts1;
        private System.Collections.Generic.List<double> buildCosts2;
        private System.Collections.Generic.List<double> buildCosts3;
        private System.Collections.Generic.List<double> buildCosts4;
        private System.Collections.Generic.List<double> buildCosts5;
        public int incentVideoCoins;
        public int coin1Payout;
        public int coin2Payout;
        public int coin3Payout;
        public int bag1Payout;
        public int bag2Payout;
        public int bag3Payout;
        public int attackBlockPayout;
        public int attackHitPayout;
        private double raidPayout;
        private double coin199Pack;
        private double coin499Pack;
        private double coin999Pack;
        private double coin1999Pack;
        private double coin4999Pack;
        private double coin9999Pack;
        public int coinsOOCBundle;
        
        // Properties
        public decimal getRaidPayout { get; }
        public decimal getCoin199Pack { get; }
        public decimal getCoin499Pack { get; }
        public decimal getCoin999Pack { get; }
        public decimal getCoin1999Pack { get; }
        public decimal getCoin4999Pack { get; }
        public decimal getCoin9999Pack { get; }
        public int spins199Pack { get; }
        public int spins499Pack { get; }
        public int spins1199Pack { get; }
        public int spins1999Pack { get; }
        public int spins4999Pack { get; }
        public int spins9999Pack { get; }
        public int spinsLevelReward { get; }
        public double priceOOCBundle { get; }
        public int spinsOOSBundle_FreeUser { get; }
        public double priceOOSBundle_FreeUser { get; }
        public int spinsOOSBundle_PaidUser099Pack { get; }
        public int spinsOOSBundle_PaidUser199Pack { get; }
        public int spinsOOSBundle_PaidUser399Pack { get; }
        public decimal TotalBuildCost { get; }
        public int stages { get; }
        
        // Methods
        public decimal get_getRaidPayout()
        {
            decimal val_1 = System.Decimal.op_Explicit(value:  null);
            return new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid};
        }
        public decimal get_getCoin199Pack()
        {
            decimal val_1 = System.Decimal.op_Explicit(value:  null);
            return new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid};
        }
        public decimal get_getCoin499Pack()
        {
            decimal val_1 = System.Decimal.op_Explicit(value:  null);
            return new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid};
        }
        public decimal get_getCoin999Pack()
        {
            decimal val_1 = System.Decimal.op_Explicit(value:  null);
            return new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid};
        }
        public decimal get_getCoin1999Pack()
        {
            decimal val_1 = System.Decimal.op_Explicit(value:  null);
            return new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid};
        }
        public decimal get_getCoin4999Pack()
        {
            decimal val_1 = System.Decimal.op_Explicit(value:  null);
            return new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid};
        }
        public decimal get_getCoin9999Pack()
        {
            decimal val_1 = System.Decimal.op_Explicit(value:  null);
            return new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid};
        }
        public int get_spins199Pack()
        {
            if(this.levelNumber < 30)
            {
                    30 = 25;
            }
            
            return 25;
        }
        public int get_spins499Pack()
        {
            if(this.levelNumber < 30)
            {
                    90 = 70;
            }
            
            return 70;
        }
        public int get_spins1199Pack()
        {
            if(this.levelNumber < 30)
            {
                    260 = 200;
            }
            
            return 200;
        }
        public int get_spins1999Pack()
        {
            return 400;
        }
        public int get_spins4999Pack()
        {
            if(this.levelNumber < 30)
            {
                    1600 = 1200;
            }
            
            return 1200;
        }
        public int get_spins9999Pack()
        {
            if(this.levelNumber < 30)
            {
                    3600 = 2800;
            }
            
            return 2800;
        }
        public int get_spinsLevelReward()
        {
            return 25;
        }
        public double get_priceOOCBundle()
        {
            return (double)D0;
        }
        public int get_spinsOOSBundle_FreeUser()
        {
            if(this.levelNumber < 5)
            {
                    this = 80;
                return (int)this;
            }
            
            if(this.levelNumber < 30)
            {
                    150 = 105;
            }
            
            return 105;
        }
        public double get_priceOOSBundle_FreeUser()
        {
            if(this.levelNumber < 5)
            {
                    11691680 = 11691688;
            }
            
            return (double)D0;
        }
        public int get_spinsOOSBundle_PaidUser099Pack()
        {
            if(this.levelNumber < 30)
            {
                    15 = 12;
            }
            
            return 12;
        }
        public int get_spinsOOSBundle_PaidUser199Pack()
        {
            if(this.levelNumber < 30)
            {
                    35 = 30;
            }
            
            return 30;
        }
        public int get_spinsOOSBundle_PaidUser399Pack()
        {
            if(this.levelNumber < 30)
            {
                    70 = 60;
            }
            
            return 60;
        }
        public decimal get_TotalBuildCost()
        {
            double val_1 = System.Linq.Enumerable.Sum(source:  R1 + 20);
            double val_2 = System.Linq.Enumerable.Sum(source:  R1 + 24);
            double val_3 = System.Linq.Enumerable.Sum(source:  R1 + 28);
            double val_4 = System.Linq.Enumerable.Sum(source:  R1 + 32);
            double val_6 = (R1 + 20) + D16;
            val_6 = val_6 + (R1 + 24);
            val_6 = val_6 + (R1 + 28);
            val_6 = val_6 + (R1 + 32);
            val_6 = val_6 + (R1 + 36);
            decimal val_7 = System.Decimal.op_Explicit(value:  System.Linq.Enumerable.Sum(source:  R1 + 36));
            return new System.Decimal() {flags = val_7.flags, hi = val_7.hi, lo = val_7.lo, mid = val_7.mid};
        }
        public int get_stages()
        {
            if(this.levelNumber < 5)
            {
                    25 = 20;
            }
            
            return 20;
        }
        public decimal getBuildCost(int category, int tier)
        {
            var val_9;
            int val_1 = tier - 1;
            if(val_1 <= 3)
            {
                    var val_2 = 11692184 + (11692184 + ((tier - 1)) << 2);
                if(val_1 == 3)
            {
                    11692184 + ((tier - 1)) << 2 = (11692184 + ((tier - 1)) << 2) & ((11692184 + ((tier - 1)) << 2) << (11692184 + ((tier - 1)) << 2));
                11692184 + ((tier - 1)) << 2 = (11692184 + ((tier - 1)) << 2) & ((11692184 + ((tier - 1)) << 2) >> 32);
                11692184 + ((tier - 1)) << 2 = (11692184 + ((tier - 1)) << 2) & 564243280;
                11692184 + ((tier - 1)) << 2 = (11692184 + ((tier - 1)) << 2) & ((11692184 + ((tier - 1)) << 2) >> (11692184 + ((tier - 1)) << 2));
            }
            
                val_9 = category + 24;
            }
            else
            {
                    val_9 = category + 20;
            }
            
            if(((category + 36) + 12) <= R3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_4 = (category + 36) + 8;
            val_4 = val_4 + (R3 << 3);
            decimal val_3 = System.Decimal.op_Explicit(value:  null);
            return new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid};
        }
        public decimal getBuildCost(int toStage)
        {
            var val_1 = IP >> 1;
            int val_2 = val_1 + ((IP) >> 31);
            val_1 = val_2 + (val_2 << 2);
            val_1 = R2 - val_1;
            decimal val_3 = this.getBuildCost(category:  toStage, tier:  val_2);
            return new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid};
        }
        public RESLevelDef()
        {
        
        }
    
    }

}
