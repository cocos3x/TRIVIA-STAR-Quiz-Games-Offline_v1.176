using UnityEngine;

namespace BlockPuzzleMagic
{
    public class GridLayoutDefinitions : ScriptableObject
    {
        // Fields
        public const int MAX_GRID_COLUMN_COUNT_CHALLENGE = 9;
        public const int MAX_GRID_ROW_COUNT_CHALLENGE = 9;
        public const int MAX_GRID_COLUMN_COUNT_ZEN = 10;
        public const int MAX_GRID_ROW_COUNT_ZEN = 10;
        public const int ON = 1;
        public const int XX = 0;
        public BlockPuzzleMagic.GridLayoutCollection[] layoutDefinitions;
        
        // Properties
        public BlockPuzzleMagic.GridLayout[] NormalLayouts { get; }
        public BlockPuzzleMagic.GridLayout[] DotLayouts { get; }
        public BlockPuzzleMagic.GridLayout[] StoneLayouts { get; }
        public BlockPuzzleMagic.GridLayout[] LoopLayouts { get; }
        
        // Methods
        public BlockPuzzleMagic.GridLayout[] get_NormalLayouts()
        {
            return this.GetGridLayoutsByType(layoutType:  1);
        }
        public BlockPuzzleMagic.GridLayout[] get_DotLayouts()
        {
            return this.GetGridLayoutsByType(layoutType:  2);
        }
        public BlockPuzzleMagic.GridLayout[] get_StoneLayouts()
        {
            return this.GetGridLayoutsByType(layoutType:  3);
        }
        public BlockPuzzleMagic.GridLayout[] get_LoopLayouts()
        {
            return this.GetGridLayoutsByType(layoutType:  4);
        }
        public BlockPuzzleMagic.GridLayout[] GetGridLayoutsByType(BlockPuzzleMagic.GridLayoutType layoutType)
        {
            goto label_0;
            label_6:
            BlockPuzzleMagic.GridLayoutCollection val_2 = this.layoutDefinitions[0];
            if(this.layoutDefinitions[0].collectionType == layoutType)
            {
                goto label_4;
            }
            
            4 = 5;
            label_0:
            if((4 - 4) < this.layoutDefinitions[0].collectionType)
            {
                goto label_6;
            }
            
            return;
            label_4:
            if(this.layoutDefinitions[0] != 0)
            {
                    return;
            }
        
        }
        public BlockPuzzleMagic.GridLayout[] GetGridLayoutsByType(BlockPuzzleMagic.GridLayout.NodeType nodeType)
        {
            if((nodeType - 1) < 4)
            {
                    return this.GetGridLayoutsByType(layoutType:  32131764 + ((nodeType - 1)) << 2);
            }
            
            nodeType = nodeType - 64;
            nodeType = nodeType >> 5;
            nodeType = nodeType << 2;
            return this.GetGridLayoutsByType(layoutType:  nodeType);
        }
        public GridLayoutDefinitions()
        {
        
        }
    
    }

}
