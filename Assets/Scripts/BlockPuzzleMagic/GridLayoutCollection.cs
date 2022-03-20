using UnityEngine;

namespace BlockPuzzleMagic
{
    public class GridLayoutCollection : ScriptableObject
    {
        // Fields
        public BlockPuzzleMagic.GridLayoutType collectionType;
        private bool defaultGridNodeState;
        public BlockPuzzleMagic.GridLayout[] layouts;
        
        // Methods
        public GridLayoutCollection()
        {
        
        }
    
    }

}
