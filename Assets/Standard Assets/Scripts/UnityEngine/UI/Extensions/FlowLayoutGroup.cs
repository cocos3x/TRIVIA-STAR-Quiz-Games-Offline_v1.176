using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    public class FlowLayoutGroup : LayoutGroup
    {
        // Fields
        public float SpacingX;
        public float SpacingY;
        public bool ExpandHorizontalSpacing;
        public bool ChildForceExpandWidth;
        public bool ChildForceExpandHeight;
        private float _layoutHeight;
        private readonly System.Collections.Generic.IList<UnityEngine.RectTransform> _rowList;
        
        // Properties
        protected bool IsCenterAlign { get; }
        protected bool IsRightAlign { get; }
        protected bool IsMiddleAlign { get; }
        protected bool IsLowerAlign { get; }
        
        // Methods
        public override void CalculateLayoutInputHorizontal()
        {
            this.CalculateLayoutInputHorizontal();
            float val_1 = this.GetGreatestMinimumChildWidth();
            float val_4 = (float)R5.left;
            val_4 = 1827127360 + val_4;
            val_4 = val_4 + (float)this.right;
            this.SetLayoutInputForAxis(totalMin:  val_4, totalPreferred:  null, totalFlexible:  (float)this.right, axis:  val_4);
        }
        public override void SetLayoutHorizontal()
        {
            UnityEngine.RectTransform val_1 = this.rectTransform;
            UnityEngine.Rect val_2 = rect;
            float val_4 = this.SetLayout(width:  width, axis:  0, layoutInput:  false);
        }
        public override void SetLayoutVertical()
        {
            UnityEngine.RectTransform val_1 = this.rectTransform;
            UnityEngine.Rect val_2 = rect;
            float val_4 = this.SetLayout(width:  width, axis:  0, layoutInput:  true);
        }
        public override void CalculateLayoutInputVertical()
        {
            UnityEngine.RectTransform val_1 = this.rectTransform;
            UnityEngine.Rect val_2 = rect;
            float val_4 = this.SetLayout(width:  width, axis:  0, layoutInput:  true);
            this._layoutHeight = this;
        }
        protected bool get_IsCenterAlign()
        {
            if(this == 7)
            {
                    this = 1;
                return (bool)this;
            }
            
            return true;
        }
        protected bool get_IsRightAlign()
        {
            if(this == 8)
            {
                    this = 1;
                return (bool)this;
            }
            
            return true;
        }
        protected bool get_IsMiddleAlign()
        {
            if(this == 3)
            {
                    this = 1;
                return (bool)this;
            }
            
            return false;
        }
        protected bool get_IsLowerAlign()
        {
            if(this == 6)
            {
                    this = 1;
                return (bool)this;
            }
            
            if((-6) < 2)
            {
                    0 = 1;
            }
            
            return true;
        }
        public float SetLayout(float width, int axis, bool layoutInput)
        {
            UnityEngine.UI.Extensions.FlowLayoutGroup val_32;
            System.Collections.Generic.IList<UnityEngine.RectTransform> val_33;
            float val_35;
            var val_36;
            float val_37;
            var val_38;
            int val_39;
            var val_40;
            var val_41;
            float val_42;
            float val_43;
            var val_44;
            var val_45;
            float val_46;
            var val_48;
            var val_49;
            val_32 = this;
            UnityEngine.RectTransform val_1 = this.rectTransform;
            UnityEngine.Rect val_2 = rect;
            float val_3 = height;
            UnityEngine.RectTransform val_4 = val_32.rectTransform;
            UnityEngine.Rect val_5 = rect;
            float val_6 = width;
            uint val_31 = 1828015400;
            int val_7 = left;
            val_31 = val_31 - (float)val_7;
            float val_9 = val_31 - (float)right;
            if(1828015362 < 3)
            {
                    int val_10 = val_7.bottom;
            }
            
            val_35 = val_7.top;
            float val_32 = val_9;
            val_36 = 0;
            val_37 = (float)val_35;
            val_38 = 0;
            val_39 = 0;
            float val_12 = 1828015400 * 0.5f;
            goto label_8;
            label_32:
            val_40 = val_36;
            val_32 = val_32 - 6;
            if(val_32 <= (2.802597E-45f))
            {
                    val_40 = 0 + val_36;
            }
            
            if((val_7 + 12) <= val_40)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_33 = val_7 + 8;
            val_33 = val_33 + (val_40 << 2);
            float val_13 = UnityEngine.UI.LayoutUtility.GetPreferredSize(rect:  (val_7 + 8 + ((0 + val_36)) << 2) + 16, axis:  0);
            val_41 = (val_7 + 8 + ((0 + val_36)) << 2) + 16;
            float val_15 = UnityEngine.Mathf.Min(a:  UnityEngine.UI.LayoutUtility.GetPreferredSize(rect:  (val_7 + 8 + ((0 + val_36)) << 2) + 16, axis:  1), b:  val_5.m_YMin);
            float val_16 = val_39 + ((val_7 + 8 + ((0 + val_36)) << 2) + 16);
            var val_34 = ???;
            if(val_34 == 0)
            {
                    if((val_34 - 6) <= 2)
            {
                    val_42 = 1828015400 - val_37;
                val_43 = val_42 - val_38;
            }
            else
            {
                    val_34 = val_34 - 3;
                if(val_34 <= 2)
            {
                    val_43 = val_37 + val_12;
            }
            
            }
            
                val_39 = val_39 - this.SpacingX;
                this.LayoutRow(contents:  0, rowWidth:  (float)(val_7 + 8 + ((0 + val_36)) << 2) + 16.left, rowHeight:  val_5.m_YMin, maxWidth:  val_42 = this._layoutHeight, xOffset:  val_5.m_Height, yOffset:  val_12, axis:  val_39);
            }
            
            var val_35 = 0;
            val_35 = val_35 + 1;
            val_44 = this._rowList;
            val_41 = val_41;
            val_32 = val_32;
            float val_20 = val_38 + val_37;
            val_35 = mem[1152921510729841788];
            uint val_37 = 0;
            val_37 = val_20 + val_35;
            val_33 = this._rowList;
            var val_36 = 0;
            val_36 = val_36 + 1;
            val_45 = val_33;
            if((Klass->__il2cppRuntimeField_interfaceOffsets[].interfaceType) > null)
            {
                    val_38 = val_41;
            }
            
            val_37 = ((val_7 + 8 + ((0 + val_36)) << 2) + 16) + val_37;
            var val_38 = mem[1152921510729841780] + 12;
            val_38 = val_38 - 1;
            val_36 = 1;
            if(val_36 < val_38)
            {
                    val_20 = this.SpacingX;
                val_39 = val_37 + val_20;
            }
            
            label_8:
            if(val_36 < (mem[1152921510729841780] + 12))
            {
                goto label_32;
            }
            
            if((???) == 0)
            {
                    var val_39 = mem[1152921510729841744];
                if((val_39 - 6) <= 2)
            {
                    val_46 = (1828015400 - val_37) - val_38;
            }
            else
            {
                    val_39 = val_39 - 3;
                if(val_39 <= 2)
            {
                    val_20 = val_42;
            }
            
                if(val_39 <= 2)
            {
                    val_46 = val_37 + val_12;
            }
            
            }
            
                float val_40 = this.SpacingX;
                val_33 = 0;
                val_33 = val_33 + 1;
                val_48 = this._rowList;
                val_40 = val_39 - val_40;
                if(this._rowList >= 2)
            {
                    -0.5f = this.SpacingX;
            }
            
                if(this._rowList < 2)
            {
                    -0.5f = 0f;
            }
            
                val_35 = (float)mem[1152921510729841740].left;
                this.LayoutRow(contents:  0, rowWidth:  val_9 - (-0.5f), rowHeight:  val_5.m_YMin, maxWidth:  val_35, xOffset:  val_5.m_Height, yOffset:  val_12, axis:  val_40);
            }
            
            val_33 = 0;
            val_33 = val_33 + 1;
            val_49 = this._rowList;
            val_37 = val_38 + val_37;
            if((mem[1152921510729841744] - 6) < 3)
            {
                    int val_29 = mem[1152921510729841740].top;
            }
            
            val_37 = val_37 + (float)mem[1152921510729841740].bottom;
            if(layoutInput != true)
            {
                    return (float)(float)mem[1152921510729841740].bottom;
            }
            
            if((???) == 0)
            {
                    return (float)(float)mem[1152921510729841740].bottom;
            }
            
            this.SetLayoutInputForAxis(totalMin:  (float)mem[1152921510729841740].bottom, totalPreferred:  val_5.m_YMin, totalFlexible:  val_35, axis:  val_37);
            return (float)(float)mem[1152921510729841740].bottom;
        }
        private float CalculateRowVerticalOffset(float groupHeight, float yOffset, float currentRowHeight)
        {
            var val_3 = R2;
            var val_3 = R1;
            if((R2 - 6) <= 2)
            {
                    val_3 = val_3 - val_3;
                val_3 = val_3 - R3;
                return (float)val_3;
            }
            
            if((R2 - 3) > 2)
            {
                    return (float)val_3;
            }
            
            val_3 = val_3 * 0.5f;
            val_3 = val_3 + val_3;
            return (float)val_3;
        }
        protected void LayoutRow(System.Collections.Generic.IList<UnityEngine.RectTransform> contents, float rowWidth, float rowHeight, float maxWidth, float xOffset, float yOffset, int axis)
        {
            var val_1;
            var val_2;
            System.Collections.Generic.IList<UnityEngine.RectTransform> val_6;
            var val_15;
            UnityEngine.UI.Extensions.FlowLayoutGroup val_23;
            System.Collections.Generic.IList<UnityEngine.RectTransform> val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            float val_31;
            UnityEngine.RectTransform val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            val_23 = this;
            int val_31 = axis;
            var val_28 = val_1;
            if(this.ChildForceExpandWidth == false)
            {
                goto label_1;
            }
            
            val_24 = this._rowList;
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_25 = (uint)val_23 & 65535;
            val_26 = val_24;
            goto label_6;
            label_1:
            if(this.ChildForceExpandWidth > true)
            {
                goto label_9;
            }
            
            if(146 != (1 << this.ChildForceExpandWidth))
            {
                goto label_8;
            }
            
            if(292 != (1 << this.ChildForceExpandWidth))
            {
                    rowWidth = val_2 - val_31;
                val_28 = rowWidth + val_28;
            }
            
            goto label_9;
            label_6:
            label_68:
            val_27 = 0;
            goto label_10;
            label_40:
            val_28 = val_27;
            if(1152921510730078026 <= 2)
            {
                    var val_24 = 0;
                val_24 = val_24 + 1;
                val_25 = (uint)val_24 & 65535;
                val_29 = val_24;
            }
            
            val_24 = val_24;
            var val_25 = 0;
            val_25 = 0;
            val_25 = val_25 + 1;
            val_25 = (uint)val_25 & 65535;
            val_30 = val_24;
            float val_9 = UnityEngine.UI.LayoutUtility.GetPreferredSize(rect:  val_24, axis:  0);
            float val_11 = UnityEngine.UI.LayoutUtility.GetPreferredSize(rect:  val_24, axis:  1);
            val_23 = val_23;
            if(mem[1152921510730078082] == false)
            {
                    R3 = val_24;
            }
            
            float val_12 = UnityEngine.Mathf.Min(a:  val_24, b:  rowHeight);
            if(1152921510730078029 <= 2)
            {
                    System.Collections.Generic.IList<UnityEngine.RectTransform> val_13 = R3 - R3;
            }
            else
            {
                    if(1152921510730078026 <= 2)
            {
                    val_6 = R3 - R3;
            }
            
            }
            
            if(this.ExpandHorizontalSpacing == false)
            {
                    0f + val_28 = val_28;
            }
            
            if(val_27 == 0)
            {
                    0f + val_28 = val_28;
            }
            
            if(val_15 != 0)
            {
                    val_32 = val_24;
                val_33 = 1;
            }
            else
            {
                    val_32 = val_24;
                val_33 = 0;
            }
            
            this.SetChildAlongAxis(rect:  val_32, axis:  0, pos:  val_31 = val_6 + val_6, size:  rowHeight);
            val_24 = 0;
            val_25 = 0;
            val_24 = val_24 + 1;
            val_25 = (uint)val_24 & 65535;
            val_34 = val_24;
            var val_26 = val_24;
            val_26 = val_26 - 1;
            if(val_27 < val_26)
            {
                    var val_27 = mem[1152921510730078072];
                val_27 = (((val_2 - val_31) / (float)val_24) + val_24) + val_27;
                val_28 = (0f + val_28) + val_27;
            }
            
            val_27 = 1;
            label_10:
            val_24 = 0;
            val_24 = val_24 + 1;
            val_25 = (uint)val_24 & 65535;
            val_35 = val_24;
            if(val_27 < val_24)
            {
                goto label_40;
            }
            
            return;
            label_8:
            int val_18 = val_2 - val_31;
            label_9:
            if(this.ExpandHorizontalSpacing == false)
            {
                goto label_68;
            }
            
            var val_29 = 0;
            val_29 = val_29 + 1;
            val_36 = val_24;
            var val_30 = val_24;
            val_30 = val_30 - 1;
            val_31 = val_2 - val_31;
            var val_32 = 0;
            val_32 = val_32 + 1;
            val_37 = val_24;
            val_31 = val_31 / (float)val_30;
            if((val_24 < 2) || (1152921510730078032 > 8))
            {
                goto label_68;
            }
            
            if(146 != 1)
            {
                goto label_55;
            }
            
            if((292 & 1) != 0)
            {
                goto label_68;
            }
            
            var val_33 = 0;
            val_33 = val_33 + 1;
            val_38 = val_24;
            goto label_61;
            label_55:
            var val_34 = 0;
            val_34 = val_34 + 1;
            val_39 = val_24;
            goto label_66;
            label_61:
            var val_35 = val_24;
            val_35 = val_35 - 1;
            goto label_68;
            label_66:
            var val_36 = val_24;
            float val_37 = -0.5f;
            val_36 = val_36 - 1;
            val_37 = val_31 * val_37;
            goto label_68;
        }
        public float GetGreatestMinimumChildWidth()
        {
            var val_3;
            float val_4;
            val_3 = 0;
            val_4 = 0f;
            goto label_1;
            label_7:
            if(mem[35668828] <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = mem[35668824];
            val_3 = val_3 + 0;
            val_4 = (mem[35668824] + 0) + 16;
            val_3 = 1;
            label_1:
            if(val_3 < ((mem[35668824] + 0) + 16 + 12))
            {
                goto label_7;
            }
            
            return (float)UnityEngine.Mathf.Max(a:  UnityEngine.UI.LayoutUtility.GetMinWidth(rect:  (mem[35668824] + 0) + 16), b:  null);
        }
        public FlowLayoutGroup()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this._rowList = null;
        }
    
    }

}
