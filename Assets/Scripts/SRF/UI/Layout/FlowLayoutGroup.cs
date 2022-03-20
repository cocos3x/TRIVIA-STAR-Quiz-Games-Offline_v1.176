using UnityEngine;

namespace SRF.UI.Layout
{
    public class FlowLayoutGroup : LayoutGroup
    {
        // Fields
        private readonly System.Collections.Generic.IList<UnityEngine.RectTransform> _rowList;
        private float _layoutHeight;
        public bool ChildForceExpandHeight;
        public bool ChildForceExpandWidth;
        public float Spacing;
        
        // Properties
        protected bool IsCenterAlign { get; }
        protected bool IsRightAlign { get; }
        protected bool IsMiddleAlign { get; }
        protected bool IsLowerAlign { get; }
        
        // Methods
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
        public override void CalculateLayoutInputHorizontal()
        {
            this.CalculateLayoutInputHorizontal();
            float val_1 = this.GetGreatestMinimumChildWidth();
            float val_4 = (float)R5.left;
            val_4 = 393404976 + val_4;
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
        public float SetLayout(float width, int axis, bool layoutInput)
        {
            var val_29;
            System.Collections.Generic.IList<UnityEngine.RectTransform> val_30;
            float val_32;
            var val_33;
            float val_34;
            var val_35;
            int val_36;
            var val_37;
            var val_38;
            int val_39;
            float val_40;
            float val_41;
            var val_42;
            var val_43;
            float val_45;
            var val_46;
            UnityEngine.RectTransform val_1 = this.rectTransform;
            UnityEngine.Rect val_2 = rect;
            float val_3 = height;
            val_29 = ;
            UnityEngine.RectTransform val_4 = this.rectTransform;
            UnityEngine.Rect val_5 = rect;
            float val_6 = width;
            uint val_28 = 393857304;
            int val_7 = left;
            val_28 = val_28 - (float)val_7;
            if(393857266 < 3)
            {
                    int val_10 = val_7.bottom;
            }
            
            val_32 = val_7.top;
            float val_29 = val_28 - (float)right;
            val_33 = 0;
            val_34 = (float)val_32;
            val_35 = 0;
            val_36 = 0;
            float val_12 = 393857304 * 0.5f;
            goto label_8;
            label_36:
            val_37 = val_33;
            val_29 = val_29 - 6;
            if(val_29 <= (2.802597E-45f))
            {
                    val_37 = 0 + val_33;
            }
            
            if((val_7 + 12) <= val_37)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_30 = val_7 + 8;
            val_30 = val_30 + (val_37 << 2);
            float val_13 = UnityEngine.UI.LayoutUtility.GetPreferredSize(rect:  (val_7 + 8 + ((0 + val_33)) << 2) + 16, axis:  0);
            val_29 = (val_7 + 8 + ((0 + val_33)) << 2) + 16;
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_38 = this._rowList;
            if(this._rowList >= 1)
            {
                    UnityEngine.Mathf.Min(a:  UnityEngine.UI.LayoutUtility.GetPreferredSize(rect:  (val_7 + 8 + ((0 + val_33)) << 2) + 16, axis:  1), b:  val_5.m_YMin) = this.Spacing;
                val_39 = val_36 + (UnityEngine.Mathf.Min(a:  UnityEngine.UI.LayoutUtility.GetPreferredSize(rect:  (val_7 + 8 + ((0 + val_33)) << 2) + 16, axis:  1), b:  val_5.m_YMin));
            }
            
            UnityEngine.Mathf.Min(a:  UnityEngine.UI.LayoutUtility.GetPreferredSize(rect:  (val_7 + 8 + ((0 + val_33)) << 2) + 16, axis:  1), b:  val_5.m_YMin) = val_29 + val_39;
            if(this._rowList > 1)
            {
                    var val_32 = ???;
                if(val_32 == 0)
            {
                    if((val_32 - 6) <= 2)
            {
                    val_40 = 393857304 - val_34;
                val_41 = val_40 - val_35;
            }
            else
            {
                    val_32 = val_32 - 3;
                if(val_32 <= 2)
            {
                    val_41 = val_34 + val_12;
            }
            
            }
            
                val_39 = val_39 - this.Spacing;
                this.LayoutRow(contents:  0, rowWidth:  (float)this._rowList.left, rowHeight:  val_5.m_YMin, maxWidth:  val_40 = this._layoutHeight, xOffset:  val_5.m_Height, yOffset:  val_12, axis:  val_39);
            }
            
                var val_33 = 0;
                val_33 = val_33 + 1;
                val_42 = this._rowList;
                float val_20 = val_35 + val_34;
                val_32 = this.Spacing;
                val_39 = 0;
                val_34 = val_20 + val_32;
            }
            
            val_30 = this._rowList;
            var val_34 = 0;
            val_34 = val_34 + 1;
            val_43 = val_30;
            val_36 = val_29 + val_39;
            val_33 = 1;
            if((Klass->__il2cppRuntimeField_interfaceOffsets[].interfaceType) > null)
            {
                    val_35 = (val_7 + 8 + ((0 + val_33)) << 2) + 16;
            }
            
            label_8:
            if(val_33 < 0)
            {
                goto label_36;
            }
            
            var val_35 = ???;
            if(val_35 == 0)
            {
                    if((val_35 - 6) <= 2)
            {
                    val_20 = 393857304 - val_34;
                val_45 = val_20 - val_35;
            }
            else
            {
                    val_35 = val_35 - 3;
                if(val_35 <= 2)
            {
                    val_20 = this._layoutHeight;
            }
            
                if(val_35 <= 2)
            {
                    val_45 = val_34 + val_12;
            }
            
            }
            
                this.LayoutRow(contents:  0, rowWidth:  (float)0.left, rowHeight:  val_5.m_YMin, maxWidth:  val_32, xOffset:  val_5.m_Height, yOffset:  val_12, axis:  val_36);
            }
            
            val_30 = 0;
            val_30 = val_30 + 1;
            val_46 = this._rowList;
            val_34 = val_35 + val_34;
            if((this._rowList - 6) < 3)
            {
                    int val_26 = this._rowList.top;
            }
            
            val_34 = val_34 + (float)this._rowList.bottom;
            if(layoutInput != true)
            {
                    return (float)(float)this._rowList.bottom;
            }
            
            if((???) == 0)
            {
                    return (float)(float)this._rowList.bottom;
            }
            
            this.SetLayoutInputForAxis(totalMin:  (float)this._rowList.bottom, totalPreferred:  val_5.m_YMin, totalFlexible:  val_32, axis:  val_34);
            return (float)(float)this._rowList.bottom;
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
            System.Collections.Generic.IList<UnityEngine.RectTransform> val_9;
            var val_19;
            float val_21;
            System.Collections.Generic.IList<UnityEngine.RectTransform> val_22;
            var val_23;
            var val_24;
            var val_25;
            System.Collections.Generic.IList<UnityEngine.RectTransform> val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            float val_31;
            UnityEngine.RectTransform val_32;
            var val_33;
            var val_34;
            val_21 = R3;
            val_22 = axis;
            bool val_23 = this.ChildForceExpandWidth;
            var val_27 = val_1;
            if(val_23 == false)
            {
                goto label_1;
            }
            
            val_23 = 0;
            val_24 = 0;
            goto label_2;
            label_13:
            var val_21 = 0;
            val_22 = 0;
            val_21 = val_21 + 1;
            val_22 = (uint)val_21 & 65535;
            val_25 = this._rowList;
            float val_4 = UnityEngine.UI.LayoutUtility.GetFlexibleWidth(rect:  this._rowList);
            val_23 = 1;
            if((Klass->__il2cppRuntimeField_interfaceOffsets[].interfaceType) > null)
            {
                    val_24 = 1;
            }
            
            label_2:
            val_26 = this._rowList;
            var val_22 = 0;
            val_22 = 0;
            val_22 = val_22 + 1;
            val_22 = (uint)val_22 & 65535;
            val_27 = val_26;
            if(val_23 < val_26)
            {
                goto label_13;
            }
            
            if(val_24 < 1)
            {
                goto label_14;
            }
            
            int val_7 = (val_2 - val_22) / 1f;
            goto label_15;
            label_1:
            if(val_23 > true)
            {
                goto label_19;
            }
            
            if(146 != (1 << val_23))
            {
                goto label_17;
            }
            
            if(292 != (1 << val_23))
            {
                    rowWidth = val_2 - val_22;
                val_27 = rowWidth + val_27;
            }
            
            goto label_19;
            label_14:
            label_15:
            val_21 = val_21;
            goto label_19;
            label_17:
            int val_8 = val_2 - val_22;
            label_19:
            val_28 = 0;
            goto label_20;
            label_43:
            val_24 = val_28;
            val_23 = val_23 - 6;
            if(val_23 <= true)
            {
                    var val_24 = 0;
                val_26 = 0;
                val_24 = val_24 + 1;
                val_26 = (uint)val_24 & 65535;
                val_29 = this._rowList;
            }
            
            val_22 = this._rowList;
            val_26 = 0;
            val_26 = val_26 + 1;
            val_30 = val_22;
            float val_12 = UnityEngine.UI.LayoutUtility.GetPreferredSize(rect:  val_22, axis:  0);
            float val_13 = UnityEngine.UI.LayoutUtility.GetFlexibleWidth(rect:  val_22);
            if((Klass->__il2cppRuntimeField_interfaceOffsets[].interfaceType) > null)
            {
                    val_22 = 0f + val_22;
            }
            
            float val_15 = UnityEngine.UI.LayoutUtility.GetPreferredSize(rect:  val_22, axis:  1);
            if(this.ChildForceExpandHeight == false)
            {
                    val_21 = val_22;
            }
            
            var val_25 = val_2;
            float val_16 = UnityEngine.Mathf.Min(a:  val_22, b:  rowHeight);
            if((val_25 - 3) <= 2)
            {
                    System.Collections.Generic.IList<UnityEngine.RectTransform> val_18 = val_21 - val_21;
            }
            else
            {
                    val_25 = val_25 - 6;
                if(val_25 <= 2)
            {
                    val_9 = val_21 - val_21;
            }
            
            }
            
            if(val_19 != 0)
            {
                    val_32 = val_22;
                val_33 = 1;
            }
            else
            {
                    val_32 = val_22;
                val_33 = 0;
            }
            
            this.SetChildAlongAxis(rect:  val_32, axis:  0, pos:  val_31 = val_9 + val_9, size:  rowHeight);
            float val_26 = this.Spacing;
            val_28 = 1;
            val_26 = val_22 + val_26;
            val_27 = val_27 + val_26;
            label_20:
            val_26 = 0;
            val_22 = 0;
            val_26 = val_26 + 1;
            val_22 = (uint)val_26 & 65535;
            val_34 = this._rowList;
            if(val_28 < this._rowList)
            {
                goto label_43;
            }
        
        }
        public float GetGreatestMinimumChildWidth()
        {
            var val_3;
            float val_4;
            val_3 = 0;
            val_4 = 0f;
            goto label_1;
            label_7:
            if(mem[35634688] <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = mem[35634684];
            val_3 = val_3 + 0;
            val_4 = (mem[35634684] + 0) + 16;
            val_3 = 1;
            label_1:
            if(val_3 < ((mem[35634684] + 0) + 16 + 12))
            {
                goto label_7;
            }
            
            return (float)UnityEngine.Mathf.Max(a:  UnityEngine.UI.LayoutUtility.GetMinWidth(rect:  (mem[35634684] + 0) + 16), b:  null);
        }
        public FlowLayoutGroup()
        {
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            this._rowList = null;
        }
    
    }

}
