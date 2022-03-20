using UnityEngine;

namespace PrizeBalloon
{
    public class CoinRewardChance
    {
        // Fields
        public int Amount;
        public int Weight;
        
        // Methods
        public CoinRewardChance(int amount, int weight)
        {
            this.Amount = amount;
            this.Weight = weight;
        }
    
    }

}
