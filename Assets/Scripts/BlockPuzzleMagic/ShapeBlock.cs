using UnityEngine;

namespace BlockPuzzleMagic
{
    [Serializable]
    public class ShapeBlock
    {
        // Fields
        public UnityEngine.Transform block;
        public int rowID;
        public int columnID;
        public UnityEngine.UI.Image image;
        public BlockPuzzleMagic.ShapeBlockProperties properties;
        public int rowIDOrientated;
        public int columnIDOrientated;
        
        // Methods
        public ShapeBlock(UnityEngine.Transform _block, int _rowID, int _columnID, UnityEngine.UI.Image _img, BlockPuzzleMagic.ShapeBlockProperties _prop)
        {
            this.block = _block;
            this.rowID = _rowID;
            this.columnID = _columnID;
            this.image = _img;
            this.properties = _prop;
            this.rowIDOrientated = _rowID;
            this.columnIDOrientated = _columnID;
        }
    
    }

}
