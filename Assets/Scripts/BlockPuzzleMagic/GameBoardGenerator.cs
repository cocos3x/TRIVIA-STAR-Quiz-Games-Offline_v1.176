using UnityEngine;

namespace BlockPuzzleMagic
{
    public class GameBoardGenerator : MonoSingleton<BlockPuzzleMagic.GameBoardGenerator>
    {
        // Fields
        private int TotalRows;
        private int TotalColumns;
        private float gridSpacing;
        private UnityEngine.RectOffset gridPadding;
        public UnityEngine.GameObject BoardContent;
        private UnityEngine.UI.Image gridBackgroundImage;
        private UnityEngine.Vector2 gridBgPadding;
        private UnityEngine.GameObject blocksContainer;
        private UnityEngine.Color blockColorA;
        private UnityEngine.Color blockColorB;
        private float blockWidth;
        private float blockHeight;
        private float startPosx;
        private float startPosy;
        private int cellIndex;
        
        // Properties
        public float BlockWidth { get; }
        public float BlockHeight { get; }
        
        // Methods
        public float get_BlockWidth()
        {
            return (float)S0;
        }
        public float get_BlockHeight()
        {
            return (float)S0;
        }
        private void OnRectTransformDimensionsChange()
        {
            this.RecalculateGridLayout();
        }
        public void GenerateBoard(BlockPuzzleMagic.PlayerGridLayout _gridLayout)
        {
            BlockPuzzleMagic.GameBoardGenerator val_23;
            BlockPuzzleMagic.PlayerGridLayout val_24;
            BlockPuzzleMagic.BlockColorType val_25;
            var val_26;
            var val_27;
            var val_28;
            UnityEngine.Object val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            val_23 = this;
            val_24 = _gridLayout;
            UnityEngine.Transform val_1 = this.blocksContainer.transform;
            val_25 = 0;
            if(this.blocksContainer.childCount < 1)
            {
                goto label_33;
            }
            
            UnityEngine.Transform val_3 = this.blocksContainer.transform;
            System.Collections.IEnumerator val_4 = this.blocksContainer.GetEnumerator();
            label_27:
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_26 = (uint)val_24 & 65535;
            val_27 = this.blocksContainer;
            if(this.blocksContainer == 0)
            {
                goto label_11;
            }
            
            var val_25 = 0;
            val_25 = val_25 + 1;
            val_28 = this.blocksContainer;
            if(this.blocksContainer != 0)
            {
                    val_29 = 0;
            }
            else
            {
                    val_29 = 0;
            }
            
            UnityEngine.GameObject val_7 = gameObject;
            UnityEngine.Object.Destroy(obj:  null);
            goto label_27;
            label_11:
            val_30 = 0;
            if(this.blocksContainer != 0)
            {
                    val_26 = 0;
                val_26 = val_26 + 1;
                val_31 = this.blocksContainer;
            }
            
            val_23 = val_23;
            val_24 = val_24;
            val_25 = 0;
            label_33:
            mem[1152921514439259472] = val_25;
            mem[1152921514439259388] = val_24.rowCount;
            mem[1152921514439259392] = _gridLayout + 8;
            twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_11 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_C = null;
            if(val_24.rowCount < 1)
            {
                goto label_39;
            }
            
            val_32 = 0;
            label_55:
            val_33 = 0;
            goto label_40;
            label_54:
            var val_13 = (_gridLayout + 20) + 0;
            if((_gridLayout + 16) != 0)
            {
                    System.Predicate<ZooTile> val_14 = new System.Predicate<ZooTile>(object:  1242477808, method:  new IntPtr(1242450736));
                val_34 = _gridLayout + 16;
                object val_15 = val_34.Find(match:  8040448);
            }
            else
            {
                    val_34 = 0;
            }
            
            if((_gridLayout + 16) == 0)
            {
                    1152921514439259444 = 1152921514439259428;
            }
            
            if((_gridLayout + 16) == 0)
            {
                    1152921514439259440 = 1152921514439259424;
            }
            
            if((_gridLayout + 16) == 0)
            {
                    1152921514439259448 = 1152921514439259432;
            }
            
            if((mem[1152921514439259472] & 1) == 0)
            {
                    1152921514439259452 = 1152921514439259436;
            }
            
            bool val_17 = val_24.IsFlagSetOnGridDataNode(_gridDataIndex:  0, _nodeType:  0);
            BlockPuzzleMagic.GridCell val_18 = this.GenerateNewGridCell(rowIndex:  0, columnIndex:  0);
            mem[1152921514439259388] = val_32;
            val_30 = val_33;
            mem[1152921514439259392] = val_33;
            mem[1152921514439259396] = mem[1152921514439259472];
            mem[1152921514439259400] = val_17 ^ 1;
            mem[1152921514439259504] = this.blockColorA;
            mem[1152921514439259508] = 1152921514439259444;
            mem[1152921514439259512] = 1152921514439259448;
            mem[1152921514439259516] = 1152921514439259452;
            mem[1152921514439259408] = val_34;
            mem[1152921514439259412] = (_gridLayout + 20 + 0) + 16;
            this.RefreshVisualState();
            val_23 = val_23;
            val_24 = val_24;
            if(val_17 != true)
            {
                    bool val_20 = val_24.IsFlagSetOnGridDataNode(_gridDataIndex:  0, _nodeType:  4);
                if(val_20 != false)
            {
                    this.AddBlockStone();
            }
            else
            {
                    if(((_gridLayout + 20 + 0) + 16) != 0)
            {
                    mem[1152921514439259472] = mem[(_gridLayout + 20 + 0) + 16 + 8];
            }
            
                if(mem[1152921514439259472] != 0)
            {
                    val_20 = val_23;
                this.AddBlockColorFill(blockColor:  mem[1152921514439259472] = (_gridLayout + 20 + 0) + 16 + 8);
            }
            
            }
            
            }
            
            twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_32 = val_32;
            Add(item:  1242477808);
            val_33 = val_30 + 1;
            mem[1152921514439259472] = 1;
            label_40:
            if(val_33 < (_gridLayout + 8))
            {
                goto label_54;
            }
            
            val_26 = val_32 + 1;
            if(val_26 < val_24.rowCount)
            {
                goto label_55;
            }
            
            label_39:
            this.RecalculateGridLayout();
            twelvegigs.Autopilot.AutopilotManager val_23 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_35 = 0;
        }
        private void RecalculateGridLayout()
        {
            BlockPuzzleMagic.GameBoardGenerator val_43;
            float val_44;
            float val_46;
            var val_47;
            int val_48;
            var val_49;
            var val_50;
            val_43 = this;
            val_44 = 1152921504901095424;
            val_46 = 1152921511020107712;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(2118293440 == 0)
            {
                    return;
            }
            
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_47 = 0;
            UnityEngine.Transform val_4 = this.blocksContainer.transform;
            if(this.blocksContainer != 0)
            {
                    if(null == null)
            {
                goto label_12;
            }
            
            }
            
            if(this.blocksContainer != 0)
            {
                goto label_13;
            }
            
            goto label_16;
            label_12:
            label_13:
            if(null != null)
            {
                    val_47 = 0;
            }
            else
            {
                    val_47 = this.blocksContainer;
            }
            
            label_16:
            UnityEngine.Rect val_5 = rect;
            twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            float val_7 = width;
            uint val_45 = 1242610520;
            float val_44 = (float)this.gridPadding.left;
            int val_10 = this.TotalColumns - 1;
            val_44 = val_45 - val_44;
            val_45 = val_44 - (float)this.gridPadding.right;
            float val_11 = height;
            val_45 = val_45 / (float)this.TotalColumns;
            float val_46 = (float)this.gridPadding.top;
            int val_14 = this.TotalRows - 1;
            val_46 = 1242610520 - val_46;
            val_46 = val_46 - (float)this.gridPadding.bottom;
            float val_15 = val_46 / (float)this.TotalRows;
            float val_16 = UnityEngine.Mathf.Min(a:  val_46, b:  val_5.m_YMin);
            val_44 = 4;
            val_48 = this.TotalColumns;
            this.blockWidth = val_45;
            this.blockHeight = val_45;
            val_46 =  - 4;
            int val_47 = this.TotalRows;
            val_47 = val_47 - 1;
            float val_49 = (float)val_47;
            int val_48 = UnityEngine.Mathf.Max(a:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_C + 8 + 16 + 12, b:  0);
            val_48 = val_48 - (UnityEngine.Mathf.Min(a:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_C + 8 + 16 + 12, b:  this.TotalRows));
            val_49 = this.blockHeight * val_49;
            int val_50 = UnityEngine.Mathf.Max(a:  public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_C + 8 + 16 + 16, b:  0);
            float val_22 = this.gridSpacing * ((float)this.TotalColumns - 1);
            val_50 = val_50 - ;
            val_45 = val_49 * 0.5f;
            float val_23 = val_22 * (-0.5f);
            float val_24 = this.gridSpacing + this.blockHeight;
            float val_25 = this.blockWidth + this.gridSpacing;
            mem[1152921514439404232] = val_23;
            mem[1152921514439404236] = val_45;
            var val_53 = 4;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            UnityEngine.Transform val_26 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_C + 8 + 16.transform;
            val_49 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_C + 8 + 16;
            if(val_49 != null)
            {
                    val_49 = 0;
            }
            
            UnityEngine.Vector3 val_27 = new UnityEngine.Vector3(x:  val_24, y:  val_22, z:  (float)this.TotalColumns - 1);
            val_49.anchoredPosition3D = new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z};
            UnityEngine.Vector2 val_28 = new UnityEngine.Vector2(x:  val_24, y:  val_22);
            val_49.sizeDelta = new UnityEngine.Vector2() {x = val_28.x, y = val_28.y};
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if((public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_C + 8 + 16 + 28) == 0)
            {
                goto label_49;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            UnityEngine.Transform val_30 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_C + 8 + 16 + 28.transform;
            val_50 = public static BlockPuzzleMagic.GamePlay MonoSingleton<BlockPuzzleMagic.GamePlay>::get_Instance().__il2cppRuntimeField_C + 8 + 16 + 28;
            UnityEngine.Vector2 val_31 = new UnityEngine.Vector2(x:  val_24, y:  val_22);
            if(val_50 == 0)
            {
                goto label_53;
            }
            
            if(val_50 == null)
            {
                goto label_55;
            }
            
            goto label_56;
            label_53:
            label_56:
            val_50 = 0;
            label_55:
            val_50.sizeDelta = new UnityEngine.Vector2() {x = val_31.x, y = val_31.y};
            label_49:
            var val_32 = val_53 - 3;
            if(this.TotalColumns != 0)
            {
                    float val_51 = this.gridSpacing;
                val_51 = this.blockWidth + val_51;
                val_23 = val_23 + val_51;
            }
            else
            {
                    float val_52 = this.gridSpacing;
                val_52 = this.blockHeight + val_52;
                val_45 = val_45 - val_52;
            }
            
            val_53 = val_53 + 1;
            float val_33 = width;
            float val_36 = height;
            float val_37 = 1242610520 - (float)this.gridPadding.left;
            val_43 = this.gridPadding;
            val_37 = val_37 - (float)this.gridPadding.right;
            int val_40 = val_43.bottom;
            float val_54 = (float)this.gridPadding.top;
            float val_56 = (float)val_40;
            var val_55 = mem[1152921514439404184];
            val_54 = 1242610520 - val_54;
            float val_41 = val_37 + (mem[1152921514439404180] + mem[1152921514439404180]);
            UnityEngine.RectTransform val_42 = mem[1152921514439404176].rectTransform;
            val_55 = val_55 + val_55;
            val_56 = val_54 - val_56;
            mem[1152921514439404176].SetSizeWithCurrentAnchors(axis:  0, size:  val_40);
            val_56 = val_56 + val_55;
            UnityEngine.RectTransform val_43 = mem[1152921514439404176].rectTransform;
            mem[1152921514439404176].SetSizeWithCurrentAnchors(axis:  1, size:  val_40);
        }
        private BlockPuzzleMagic.GridCell GenerateNewGridCell(int rowIndex, int columnIndex)
        {
            bool val_12 = static_value_021FD2FC;
            if(val_12 != true)
            {
                    val_12 = true;
            }
            
            BlockPuzzleMagic.GameReferenceData val_1 = BlockPuzzleMagic.GameReferenceData.Instance;
            object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  603979776);
            UnityEngine.Transform val_3 = 603979776.transform;
            UnityEngine.Transform val_4 = this.blocksContainer.transform;
            603979776.SetParent(p:  this.blocksContainer);
            UnityEngine.Transform val_5 = 603979776.transform;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            603979776.localScale = new UnityEngine.Vector3();
            UnityEngine.Transform val_7 = 603979776.transform;
            603979776.SetAsLastSibling();
            string val_8 = rowIndex.ToString();
            string val_9 = columnIndex.ToString();
            string val_10 = 1242735152 + 1242748228 + 1359327184 + 1242748224;
            if(603979776 != 0)
            {
                    603979776.name = 1242735152;
            }
            else
            {
                    0.name = 1242735152;
            }
            
            object val_11 = 603979776.GetComponent<System.Object>();
        }
        public GameBoardGenerator()
        {
            this.gridSpacing = 5f;
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            UnityEngine.Color val_2 = UnityEngine.Color.white;
        }
        private bool <GenerateBoard>b__20_0(BlockPuzzleMagic.GridCellData data)
        {
            int val_1 = this.cellIndex;
            val_1 = data.cellId - val_1;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
    
    }

}
