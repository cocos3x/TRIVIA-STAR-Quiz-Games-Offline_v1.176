using UnityEngine;

namespace RestaurantRivals
{
    public class RESFTUXLevel
    {
        // Fields
        private int <SpinNum>k__BackingField;
        private RestaurantRivals.RESPayout <Payout>k__BackingField;
        private bool <AttackResult>k__BackingField;
        private decimal <RaidTreasureAmount>k__BackingField;
        private string <RaidResult>k__BackingField;
        private int <OpponentLevel>k__BackingField;
        private int <OpponentObjects>k__BackingField;
        
        // Properties
        public int SpinNum { get; set; }
        public RestaurantRivals.RESPayout Payout { get; set; }
        public bool AttackResult { get; set; }
        public decimal RaidTreasureAmount { get; set; }
        public string RaidResult { get; set; }
        public int OpponentLevel { get; set; }
        public int OpponentObjects { get; set; }
        
        // Methods
        public int get_SpinNum()
        {
            return (int)this.<SpinNum>k__BackingField;
        }
        private void set_SpinNum(int value)
        {
            this.<SpinNum>k__BackingField = value;
        }
        public RestaurantRivals.RESPayout get_Payout()
        {
        
        }
        private void set_Payout(RestaurantRivals.RESPayout value)
        {
            this.<Payout>k__BackingField = value;
        }
        public bool get_AttackResult()
        {
            return (bool)this.<AttackResult>k__BackingField;
        }
        private void set_AttackResult(bool value)
        {
            this.<AttackResult>k__BackingField = value;
        }
        public decimal get_RaidTreasureAmount()
        {
            return new System.Decimal() {flags = 550176992, hi = R1 + 20};
        }
        private void set_RaidTreasureAmount(decimal value)
        {
        
        }
        public string get_RaidResult()
        {
        
        }
        private void set_RaidResult(string value)
        {
            this.<RaidResult>k__BackingField = value;
        }
        public int get_OpponentLevel()
        {
            return (int)this.<OpponentLevel>k__BackingField;
        }
        private void set_OpponentLevel(int value)
        {
            this.<OpponentLevel>k__BackingField = value;
        }
        public int get_OpponentObjects()
        {
            return (int)this.<OpponentObjects>k__BackingField;
        }
        private void set_OpponentObjects(int value)
        {
            this.<OpponentObjects>k__BackingField = value;
        }
        public RESFTUXLevel(int num, RestaurantRivals.RESPayout payout, bool attackResult = False, decimal raidTreasureAmount, string raidResult = "", int opponentLevel = 0, int opponentObjects = 0)
        {
            this.<SpinNum>k__BackingField = num;
            this.<Payout>k__BackingField = payout;
            this.<AttackResult>k__BackingField = attackResult;
            this.<OpponentObjects>k__BackingField = opponentObjects;
        }
    
    }

}
