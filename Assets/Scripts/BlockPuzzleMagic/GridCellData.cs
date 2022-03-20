using UnityEngine;

namespace BlockPuzzleMagic
{
    [Serializable]
    public class GridCellData
    {
        // Fields
        public int cellId;
        public int loopNextCell;
        
        // Methods
        public GridCellData(int _id)
        {
            this.loopNextCell = 0;
            this.cellId = _id;
        }
    
    }

}
