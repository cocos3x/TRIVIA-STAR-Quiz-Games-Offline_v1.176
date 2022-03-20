using UnityEngine;

namespace BlockPuzzleMagic
{
    [Serializable]
    public class GridLayout
    {
        // Fields
        public static readonly BlockPuzzleMagic.GridLayout ZenGridLayout;
        public int columnCount;
        public int[] gridData;
        public System.Collections.Generic.List<BlockPuzzleMagic.GridCellData> extraGridData;
        
        // Properties
        public static int MaxColumnCount { get; }
        public static int MaxRowCount { get; }
        public int rowCount { get; }
        
        // Methods
        public static int get_MaxColumnCount()
        {
            var val_4;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_4 = 9;
            if(2118293440 == 0)
            {
                    return (int)val_4;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14 + 8) != 1)
            {
                    val_4 = 9;
            }
            
            return (int)val_4;
        }
        public static int get_MaxRowCount()
        {
            var val_4;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_4 = 9;
            if(2118293440 == 0)
            {
                    return (int)val_4;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_14 + 8) != 1)
            {
                    val_4 = 9;
            }
            
            return (int)val_4;
        }
        public int get_rowCount()
        {
            float val_1 = (float)S0;
            val_1 = val_1 / (float)this.columnCount;
            return UnityEngine.Mathf.CeilToInt(f:  val_1);
        }
        public GridLayout(int ColumnCount, int[] GridData)
        {
            this.columnCount = ColumnCount;
            this.gridData = null;
            GridData.CopyTo(array:  478302960, index:  0);
        }
        public GridLayout(BlockPuzzleMagic.GridLayout target)
        {
            BlockPuzzleMagic.GridLayout val_1 = target;
            val_1 = new System.Object();
            if(val_1 != 0)
            {
                    this.columnCount = target.columnCount;
            }
            else
            {
                    this.columnCount = 0;
            }
            
            this.gridData = null;
            target.gridData.CopyTo(array:  478302960, index:  0);
        }
        public override string ToString()
        {
            var val_3;
            int val_4;
            val_3 = 0;
            val_4 = System.String.alignConst;
            goto label_1;
            label_5:
            int val_3 = this.gridData[val_3];
            string val_1 = val_4 + 13152256;
            val_3 = 1;
            if(this.columnCount == 0)
            {
                    ", " = "\n";
            }
            
            string val_2 = val_4 + 1269544832;
            val_4 = val_4;
            label_1:
            if(val_3 < val_4)
            {
                goto label_5;
            }
        
        }
        public BlockPuzzleMagic.GridCellData GetOrAddExtraGridCellData(int cellId, bool dontAddIfNull = False)
        {
            var val_6;
            System.Collections.Generic.List<BlockPuzzleMagic.GridCellData> val_7;
            object val_8;
            val_6 = dontAddIfNull;
            object val_1 = new System.Object();
            typeof(GridLayout.<>c__DisplayClass15_0).__il2cppRuntimeField_8 = cellId;
            val_7 = this.extraGridData;
            if(val_7 == 0)
            {
                    val_8 = 0;
                if(val_6 == true)
            {
                    return;
            }
            
                val_7 = null;
                val_7 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
                this.extraGridData = val_7;
            }
            
            System.Predicate<ZooTile> val_3 = new System.Predicate<ZooTile>(object:  465281024, method:  new IntPtr(1265151088));
            object val_4 = Find(match:  8040448);
            val_8 = val_7;
            if(val_6 == true)
            {
                    return;
            }
            
            val_8 = null;
            typeof(BlockPuzzleMagic.GridCellData).__il2cppRuntimeField_C = 0;
            val_8 = new System.Object();
            typeof(BlockPuzzleMagic.GridCellData).__il2cppRuntimeField_8 = typeof(GridLayout.<>c__DisplayClass15_0).__il2cppRuntimeField_8;
            this.extraGridData.Add(item:  465068032);
        }
        public bool GridContainsNodeType(BlockPuzzleMagic.GridLayout.NodeType _nodeType)
        {
            if((this.GetNodeTypeGridCount(_nodeType:  _nodeType)) > 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public int GetNodeTypeGridCount(BlockPuzzleMagic.GridLayout.NodeType _nodeType)
        {
            var val_2;
            var val_3;
            val_2 = 0;
            val_3 = 0;
            goto label_0;
            label_2:
            bool val_1 = this.IsFlagSetOnGridDataNode(_gridDataIndex:  0, _nodeType:  _nodeType);
            val_3 = val_3 + val_1;
            val_2 = 1;
            label_0:
            if(val_2 < val_1)
            {
                goto label_2;
            }
            
            return (int)val_3;
        }
        public bool IsFlagSetOnGridDataNode(int _gridDataIndex, BlockPuzzleMagic.GridLayout.NodeType _nodeType)
        {
            System.Int32[] val_1;
            var val_2;
            val_1 = this;
            val_2 = 0;
            if(_gridDataIndex <= _gridDataIndex)
            {
                    return (bool)val_2;
            }
            
            val_1 = this.gridData;
            int val_1 = val_1[_gridDataIndex];
            if(_nodeType != 0)
            {
                    val_1 = val_1 & _nodeType;
                val_1 = val_1 - _nodeType;
            }
            
            val_2 = val_1 >> 5;
            return (bool)val_2;
        }
        public void SetFlagToGridDataNode(int _gridDataIndex, BlockPuzzleMagic.GridLayout.NodeType _nodeType)
        {
            if(this <= _gridDataIndex)
            {
                    return;
            }
            
            this = this.gridData;
            int val_1 = this[_gridDataIndex];
            val_1 = val_1 | _nodeType;
            this[_gridDataIndex] = val_1;
        }
        public void RemoveFlagFromGridDataNode(int _gridDataIndex, BlockPuzzleMagic.GridLayout.NodeType _nodeType)
        {
            if(this <= _gridDataIndex)
            {
                    return;
            }
            
            this = this.gridData;
            int val_1 = this[_gridDataIndex];
            val_1 = val_1 & (~_nodeType);
            this[_gridDataIndex] = val_1;
        }
        public static UnityEngine.Vector2 GetColumnRowIndexFromGridIndex(int gridIndex)
        {
            var val_6 = BlockPuzzleMagic.GridLayout.MaxColumnCount;
            float val_6 = (float)BlockPuzzleMagic.GridLayout.MaxColumnCount;
            val_6 = (float)R1 / val_6;
            int val_3 = UnityEngine.Mathf.FloorToInt(f:  val_6);
            if(val_6 <= 1)
            {
                    val_6 = BlockPuzzleMagic.GridLayout.MaxColumnCount + val_6;
            }
            
            mem2[0] = 0;
            mem2[0] = 0;
            gridIndex = new UnityEngine.Vector2(x:  (float)val_6, y:  null);
            return new UnityEngine.Vector2() {x = (float)val_6};
        }
        public static int GetGridIndexFromColumnRowIndex(UnityEngine.Vector2 gridColRow)
        {
            return UnityEngine.Mathf.FloorToInt(f:  (float)BlockPuzzleMagic.GridLayout.MaxColumnCount);
        }
        public static BlockPuzzleMagic.GridLayout.Direction GetDirectionBetweenCells(int originCellId, int nextCellId)
        {
            if(originCellId >= 1)
            {
                    if((originCellId - BlockPuzzleMagic.GridLayout.MaxColumnCount) == nextCellId)
            {
                    return;
            }
            
            }
            
            if((BlockPuzzleMagic.GridLayout.MaxColumnCount + originCellId) == nextCellId)
            {
                    return;
            }
            
            if((originCellId + 1) == nextCellId)
            {
                    return;
            }
            
            int val_6 = originCellId - 1;
            val_6 = val_6 - nextCellId;
            if(originCellId > 0)
            {
                    0 = (val_6 >> 5) << 2;
            }
        
        }
        public static int GetCellIdTowardsDirection(int cellId, BlockPuzzleMagic.GridLayout.Direction dir)
        {
            float val_7;
            float val_9;
            var val_11;
            UnityEngine.Vector2 val_1 = BlockPuzzleMagic.GridLayout.GetColumnRowIndexFromGridIndex(gridIndex:  1266746544);
            Direction val_2 = dir - 1;
            if(val_2 <= 3)
            {
                    var val_3 = 13642176 + (13642176 + ((dir - 1)) << 2);
                if(val_2 == 3)
            {
                    13642176 + ((dir - 1)) << 2 = (13642176 + ((dir - 1)) << 2) & ((13642176 + ((dir - 1)) << 2) << (13642176 + ((dir - 1)) << 2));
                13642176 + ((dir - 1)) << 2 = (13642176 + ((dir - 1)) << 2) & ((R8) << (13642176 + ((dir - 1)) << 2 & (13642176 + ((dir - 1)) << 2) << 13642176 + ((dir - 1)) << 2));
                13642176 + ((dir - 1)) << 2 = (13642176 + ((dir - 1)) << 2) & ((13642176 + ((dir - 1)) << 2) >> 32);
                13642176 + ((dir - 1)) << 2 = (13642176 + ((dir - 1)) << 2) & ((R4) >> (((13642176 + ((dir - 1)) << 2 & (13642176 + ((dir - 1)) << 2) << 13642176 + ((dir - 1)) << 2) & (R8) << (13642176 + ((dir - 1)) << 2 & (13642176 + ((dir - 1)) << 2) << 13642176 + ((dir - 1)) << 2)) &);
            }
            
                val_9 = -1f;
                 = R5 + ;
                val_7 = ;
            }
            
            val_11 = 0;
            if(val_2 < 3)
            {
                    return (int)val_11;
            }
            
            int val_4 = BlockPuzzleMagic.GridLayout.MaxRowCount;
            int val_5 = BlockPuzzleMagic.GridLayout.MaxColumnCount;
            val_11 = BlockPuzzleMagic.GridLayout.GetGridIndexFromColumnRowIndex(gridColRow:  new UnityEngine.Vector2() {y = val_7});
            return (int)val_11;
        }
        private static GridLayout()
        {
            BlockPuzzleMagic.GridLayout.ZenGridLayout = new BlockPuzzleMagic.GridLayout(ColumnCount:  10, GridData:  478302960);
        }
    
    }

}
