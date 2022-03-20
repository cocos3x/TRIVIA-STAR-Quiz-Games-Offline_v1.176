using UnityEngine;

namespace WordForest
{
    public struct WFORewardData
    {
        // Fields
        public int id;
        public WordForest.WFORewardType rewardType;
        public decimal amount;
        public int transformToId;
        
        // Methods
        public WFORewardData(int rId, WordForest.WFORewardType rType, int rAmt, int rTid)
        {
            this = rId;
            this.rewardType = rType;
            decimal val_1 = System.Decimal.op_Implicit(value:  308925904);
            this.transformToId = rTid;
        }
        public WFORewardData(WordForest.WFORewardType rType, int rAmt)
        {
            this.rewardType = rType;
            decimal val_1 = System.Decimal.op_Implicit(value:  309046096);
            this = 0;
            this.transformToId = 0;
        }
    
    }

}
