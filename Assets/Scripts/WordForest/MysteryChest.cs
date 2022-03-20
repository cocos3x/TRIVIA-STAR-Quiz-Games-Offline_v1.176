using UnityEngine;

namespace WordForest
{
    public class MysteryChest
    {
        // Fields
        public WFOMysteryChestMovingObject ChestTile;
        public int LineWord;
        public int CellIndex;
        public bool collected;
        
        // Methods
        public MysteryChest()
        {
            this.LineWord = 0;
            this.CellIndex = 0;
        }
    
    }

}
