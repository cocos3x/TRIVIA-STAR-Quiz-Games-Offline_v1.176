using UnityEngine;

namespace BlockPuzzleMagic
{
    [Serializable]
    public class BlockColor
    {
        // Fields
        public static readonly BlockPuzzleMagic.BlockColorType[] STANDARD_REGULAR_COLORS;
        public BlockPuzzleMagic.BlockColorType blockColor;
        public UnityEngine.Color colorValue;
        
        // Methods
        public BlockColor(BlockPuzzleMagic.BlockColorType _colorType, UnityEngine.Color _colorValues)
        {
            this.blockColor = _colorType;
            this.colorValue = _colorValues;
            mem[1152921514426090640] = _colorValues.g;
            mem[1152921514426090644] = _colorValues.b;
            mem[1152921514426090648] = _colorValues.a;
        }
        private static BlockColor()
        {
            BlockPuzzleMagic.BlockColor.STANDARD_REGULAR_COLORS = null;
        }
    
    }

}
