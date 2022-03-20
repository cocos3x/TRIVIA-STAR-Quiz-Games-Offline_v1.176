using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    public class TableLayoutGroup : LayoutGroup
    {
        // Fields
        protected UnityEngine.UI.Extensions.TableLayoutGroup.Corner startCorner;
        protected float[] columnWidths;
        protected float minimumRowHeight;
        protected bool flexibleRowHeight;
        protected float columnSpacing;
        protected float rowSpacing;
        private float[] preferredRowHeights;
        
        // Properties
        public UnityEngine.UI.Extensions.TableLayoutGroup.Corner StartCorner { get; set; }
        public float[] ColumnWidths { get; set; }
        public float MinimumRowHeight { get; set; }
        public bool FlexibleRowHeight { get; set; }
        public float ColumnSpacing { get; set; }
        public float RowSpacing { get; set; }
        
        // Methods
        public UnityEngine.UI.Extensions.TableLayoutGroup.Corner get_StartCorner()
        {
        
        }
        public void set_StartCorner(UnityEngine.UI.Extensions.TableLayoutGroup.Corner value)
        {
            this.SetProperty<Corner>(currentValue: ref  this.startCorner, newValue:  value);
        }
        public float[] get_ColumnWidths()
        {
        
        }
        public void set_ColumnWidths(float[] value)
        {
            this.SetProperty<UnityEngine.RectOffset>(currentValue: ref  this.columnWidths, newValue:  value);
        }
        public float get_MinimumRowHeight()
        {
            return (float)S0;
        }
        public void set_MinimumRowHeight(float value)
        {
            this.SetProperty<System.Single>(currentValue: ref  this.minimumRowHeight, newValue:  value);
        }
        public bool get_FlexibleRowHeight()
        {
            return (bool)this.flexibleRowHeight;
        }
        public void set_FlexibleRowHeight(bool value)
        {
            this.SetProperty<System.Boolean>(currentValue: ref  this.flexibleRowHeight, newValue:  value);
        }
        public float get_ColumnSpacing()
        {
            return (float)S0;
        }
        public void set_ColumnSpacing(float value)
        {
            this.SetProperty<System.Single>(currentValue: ref  this.columnSpacing, newValue:  value);
        }
        public float get_RowSpacing()
        {
            return (float)S0;
        }
        public void set_RowSpacing(float value)
        {
            this.SetProperty<System.Single>(currentValue: ref  this.rowSpacing, newValue:  value);
        }
        public override void CalculateLayoutInputHorizontal()
        {
            float val_4;
            var val_5;
            float val_6;
            this.CalculateLayoutInputHorizontal();
            val_4 = (float)R5.horizontal;
            val_5 = 0;
            int val_2 = UnityEngine.Mathf.Min(a:  static_value_02204365, b:  UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished);
            if(val_2 >= 1)
            {
                    var val_4 = 16;
                do
            {
                val_5 = val_5 + 1;
                val_4 = val_4 + 4;
                val_6 = this.columnSpacing;
                val_4 = (val_4 + 1152921506890440784) + val_6;
            }
            while(val_2 != val_5);
            
            }
            else
            {
                    val_6 = this.columnSpacing;
            }
            
            val_6 = val_4 - val_6;
            this.SetLayoutInputForAxis(totalMin:  val_6, totalPreferred:  null, totalFlexible:  null, axis:  val_6);
        }
        public override void CalculateLayoutInputVertical()
        {
            float val_11;
            int val_12;
            float val_13;
            float val_14;
            float val_15;
            System.Single[] val_16;
            float val_17;
            float val_18;
            var val_19;
            float val_12 = (float)this.columnWidths;
            val_11 = (float)static_value_02204366;
            val_12 = val_11 / val_12;
            val_12 = UnityEngine.Mathf.CeilToInt(f:  val_12);
            this.preferredRowHeights = null;
            val_13 = (float)this.columnWidths.vertical;
            val_14 = this.columnWidths.vertical;
            val_15 = (float)val_14;
            if(val_12 >= 2)
            {
                    val_11 = this.rowSpacing;
                val_14 = val_11 * ((float)val_12 - 1);
                val_15 = val_14 + val_15;
                val_13 = val_14 + val_13;
            }
            
            if(this.flexibleRowHeight == false)
            {
                goto label_8;
            }
            
            if(val_12 < 1)
            {
                goto label_24;
            }
            
            val_16 = this.columnWidths;
            var val_16 = 16;
            label_23:
            val_17 = this.minimumRowHeight;
            if(val_16 < 1)
            {
                goto label_10;
            }
            
            val_18 = val_17;
            val_19 = 0;
            label_19:
            var val_6 = 0 + val_19;
            if(val_6 == 0)
            {
                goto label_20;
            }
            
            if(0 <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_13 = 0;
            val_13 = val_13 + val_16;
            float val_8 = UnityEngine.Mathf.Max(a:  UnityEngine.UI.LayoutUtility.GetPreferredHeight(rect:  (0 + 16) + 0), b:  null);
            if((val_1 + 12) <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_14 = val_1 + 8;
            val_18 = (0 + 16) + 0;
            val_14 = val_14 + val_16;
            float val_10 = UnityEngine.Mathf.Max(a:  UnityEngine.UI.LayoutUtility.GetMinHeight(rect:  (val_1 + 8 + 16) + 0), b:  null);
            val_16 = this.columnWidths;
            val_19 = val_19 + 1;
            val_17 = (val_1 + 8 + 16) + 0;
            if(val_19 < val_16)
            {
                goto label_19;
            }
            
            goto label_20;
            label_10:
            val_18 = val_17;
            label_20:
            val_12 = val_12;
            var val_15 = 0;
            val_15 = val_15 + val_18;
            val_13 = val_13 + val_17;
            val_15 = val_15 + 1;
            this.preferredRowHeights[val_15] = val_18;
            val_16 = val_16 + (val_16 << 2);
            System.Single[] val_17 = 0;
            val_17 = val_17 + val_16;
            if(val_15 != val_12)
            {
                goto label_23;
            }
            
            goto label_24;
            label_8:
            if(val_12 >= 1)
            {
                    var val_18 = 0;
                do
            {
                val_16 = this.preferredRowHeights;
                val_18 = val_18 + 1;
                val_16[val_18] = this.minimumRowHeight;
            }
            while(val_12 != val_18);
            
            }
            
            val_14 = (float)val_12;
            val_11 = this.minimumRowHeight;
            val_15 = val_13;
            label_24:
            this.SetLayoutInputForAxis(totalMin:  UnityEngine.Mathf.Max(a:  val_14, b:  null), totalPreferred:  null, totalFlexible:  val_11, axis:  val_13);
        }
        public override void SetLayoutHorizontal()
        {
            System.Single[] val_7;
            int val_8;
            var val_9;
            float val_10;
            float val_11;
            var val_12;
            var val_13;
            if(true != 0)
            {
                    val_7 = this.columnWidths;
            }
            else
            {
                    val_7 = null;
                this.columnWidths = null;
            }
            
            Corner val_7 = this.startCorner;
            Corner val_1 = val_7 + (val_7 >> 31);
            val_8 = mem[R6 + 12];
            val_8 = R6 + 12;
            val_1 = val_1 & (~1);
            val_7 = val_7 - val_1;
            val_9 = 0;
            int val_2 = UnityEngine.Mathf.Min(a:  val_8, b:  UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished);
            if(val_2 >= 1)
            {
                    val_8 = val_2;
                var val_8 = 16;
                do
            {
                val_9 = val_9 + 1;
                val_8 = val_8 + 4;
                val_10 = this.columnSpacing;
                val_11 = (0f + 1152921506890440784) + val_10;
            }
            while(val_8 != val_9);
            
            }
            else
            {
                    val_11 = 0f;
                val_10 = this.columnSpacing;
            }
            
            float val_5 = this.GetStartOffset(axis:  0, requiredSpaceWithoutPadding:  val_10);
            val_12 = 0;
            if(val_7 == 1)
            {
                    1831759680 = 1831759680 + (val_11 - val_10);
            }
            
            goto label_14;
            label_27:
            val_9 = System.Single[].__il2cppRuntimeField_namespaze;
            if(System.Single[].__il2cppRuntimeField_namespaze == 0)
            {
                    val_13 = 1831759680;
            }
            
            if(val_7 == 1)
            {
                    val_13 = val_13 - this.columnWidths[val_9];
            }
            
            if(this.columnWidths[val_9] <= val_12)
            {
                    var val_10 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = this.columnWidths;
            val_10 = val_10 + 0;
            this.SetChildAlongAxis(rect:  (0 + 0) + 16, axis:  0, pos:  val_8[val_9], size:  null);
            if(val_7 == 1)
            {
                    val_13 = val_13 - this.columnSpacing;
            }
            else
            {
                    float val_13 = this.columnSpacing;
                val_13 = this.columnWidths[val_9] + val_13;
                val_13 = val_13 + val_13;
            }
            
            val_12 = 1;
            label_14:
            if(val_12 < this.columnWidths[val_9])
            {
                goto label_27;
            }
        
        }
        public override void SetLayoutVertical()
        {
            System.Single[] val_5;
            var val_6;
            Corner val_7;
            float val_8;
            var val_9;
            float val_10;
            var val_11;
            val_5 = this.columnWidths;
            val_7 = this.startCorner;
            val_8 = 0f;
            if(SB >= 1)
            {
                    var val_6 = 16;
                do
            {
                val_5 = this.preferredRowHeights;
                val_9 = 0 + 1;
                val_6 = val_6 + 4;
                val_8 = val_8 + 1152921505601012928;
            }
            while(SB != val_9);
            
                if(SB >= 2)
            {
                    val_10 = (float)SB - 1;
            }
            
            }
            
            float val_2 = this.GetStartOffset(axis:  1, requiredSpaceWithoutPadding:  val_10);
            if(SB < 1)
            {
                goto label_8;
            }
            
            Corner val_3 = val_7 & (~1);
            var val_12 = 16;
            if(val_3 == 2)
            {
                    val_11 = val_8 + 1832359104;
            }
            
            label_24:
            if(val_3 == 2)
            {
                    val_11 = val_11 - this.preferredRowHeights[0];
            }
            
            if(true < 1)
            {
                goto label_14;
            }
            
            val_9 = 0;
            label_19:
            var val_5 = 0 + val_9;
            if(val_5 == true)
            {
                goto label_14;
            }
            
            if(true <= val_5)
            {
                    var val_8 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = val_8 + val_12;
            this.SetChildAlongAxis(rect:  (0 + 16) + 0, axis:  1, pos:  this.preferredRowHeights[0], size:  null);
            val_9 = val_9 + 1;
            if(val_9 < true)
            {
                goto label_19;
            }
            
            label_14:
            val_5 = val_3;
            if(val_5 == 2)
            {
                    val_11 = val_11 - this.rowSpacing;
            }
            else
            {
                    float val_11 = this.rowSpacing;
                val_11 = this.preferredRowHeights[0] + val_11;
                val_11 = val_11 + val_11;
            }
            
            val_6 = 0 + 1;
            val_12 = val_12 + 0;
            val_7 = 0 + true;
            if(val_6 != (???))
            {
                goto label_24;
            }
            
            label_8:
            this.preferredRowHeights = 0;
        }
        public TableLayoutGroup()
        {
            typeof(System.Single[]).__il2cppRuntimeField_10 = 1119879168;
            this.columnWidths = null;
            this.minimumRowHeight = 32f;
            this.flexibleRowHeight = true;
        }
    
    }

}
