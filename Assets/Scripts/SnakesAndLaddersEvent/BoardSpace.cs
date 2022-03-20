using UnityEngine;

namespace SnakesAndLaddersEvent
{
    [Serializable]
    public class BoardSpace
    {
        // Fields
        public int Number;
        public int NumberConnected;
        public bool IsRewardSpace;
        
        // Methods
        public BoardSpace(int number, int numberConnected = -1, bool isRewardSpace = False)
        {
            this.Number = number;
            this.NumberConnected = numberConnected;
            this.IsRewardSpace = isRewardSpace;
        }
    
    }

}
