using UnityEngine;

namespace UnityEngine.UI
{
    public class LoopHorizontalScrollRect : LoopScrollRect
    {
        // Methods
        protected override float GetSize(UnityEngine.RectTransform item)
        {
            var val_4;
            float val_1 = this.contentSpacing;
            if(static_value_021FA587 != 0)
            {
                    if(item != 0)
            {
                goto label_5;
            }
            
            }
            else
            {
                    float val_3 = UnityEngine.UI.LayoutUtility.GetPreferredWidth(rect:  item);
                val_4 = item;
            }
            
            label_5:
            val_4 = 1165252960 + val_4;
            return (float)val_4;
        }
        protected override float GetDimension(UnityEngine.Vector2 vector)
        {
            float val_1 = vector.x ^ 2147483648;
            return (float)S0;
        }
        protected override UnityEngine.Vector2 GetVector(float value)
        {
            this = 0;
            mem[1152921514362262628] = 0;
            var val_1 = R2 ^ 2147483648;
            val_2 = new UnityEngine.Vector2(x:  value, y:  null);
            return new UnityEngine.Vector2() {x = value};
        }
        protected override void Awake()
        {
            this.Awake();
            mem[1152921514362374876] = 1;
            object val_1 = static_value_021FA588.GetComponent<System.Object>();
            if(static_value_021FA588 == 0)
            {
                    return;
            }
            
            if(static_value_021FA5D8 == true)
            {
                    return;
            }
            
            UnityEngine.Debug.LogError(message:  1165569056);
        }
        protected override bool UpdateItems(UnityEngine.Bounds viewBounds, UnityEngine.Bounds contentBounds)
        {
            var val_4;
            float val_28;
            float val_29;
            var val_30;
            var val_31;
            val_28 = contentBounds.m_Center.x;
            val_29 = viewBounds.m_Extents.z;
            val_30 = 0;
            UnityEngine.Vector3 val_1 = max;
            UnityEngine.Vector3 val_3 = max;
            if()
            {
                goto label_0;
            }
            
            float val_5 = this.NewItemAtEnd();
            uint val_28 = 1165705264;
            if()
            {
                goto label_7;
            }
            
            val_29;
            label_3:
            UnityEngine.Vector3 val_6 = max;
            UnityEngine.Vector3 val_7 = max;
            var val_27 = val_4;
            val_27 = val_28 + val_27;
            if()
            {
                goto label_7;
            }
            
            float val_8 = this.NewItemAtEnd();
            val_28 = val_28 + 1165705264;
            if()
            {
                goto label_3;
            }
            
            goto label_7;
            label_0:
            UnityEngine.Vector3 val_9 = max;
            UnityEngine.Vector3 val_10 = max;
            val_10.x = val_4 - val_10.x;
            if(>=0)
            {
                goto label_5;
            }
            
            float val_11 = this.DeleteItemAtEnd();
            uint val_29 = 1165705264;
            if()
            {
                goto label_7;
            }
            
            label_8:
            UnityEngine.Vector3 val_12 = max;
            UnityEngine.Vector3 val_13 = max;
            val_13.x = val_4 - val_13.x;
            val_13.x = val_13.x - val_29;
            if(>=0)
            {
                goto label_7;
            }
            
            float val_14 = this.DeleteItemAtEnd();
            val_29 = val_29 + 1165705264;
            if()
            {
                goto label_8;
            }
            
            label_7:
            if()
            {
                    val_30 = 1;
            }
            
            label_5:
            UnityEngine.Vector3 val_15 = min;
            UnityEngine.Vector3 val_16 = min;
            if(>=0)
            {
                goto label_9;
            }
            
            float val_17 = this.NewItemAtStart();
            uint val_31 = 1165705264;
            if()
            {
                goto label_11;
            }
            
            val_29;
            label_12:
            UnityEngine.Vector3 val_18 = min;
            UnityEngine.Vector3 val_19 = min;
            var val_30 = val_4;
            val_30 = val_30 - val_31;
            if(>=0)
            {
                goto label_11;
            }
            
            float val_20 = this.NewItemAtStart();
            val_31 = val_31 + 1165705264;
            if()
            {
                goto label_12;
            }
            
            label_11:
            if()
            {
                    0 = 1;
            }
            
            val_31 = val_30 | 1;
            return (bool)val_31;
            label_9:
            UnityEngine.Vector3 val_21 = min;
            UnityEngine.Vector3 val_22 = min;
            val_22.x = val_4 + val_22.x;
            if()
            {
                goto label_14;
            }
            
            float val_23 = this.DeleteItemAtStart();
            uint val_32 = 1165705264;
            if()
            {
                goto label_16;
            }
            
            label_17:
            UnityEngine.Vector3 val_24 = min;
            UnityEngine.Vector3 val_25 = min;
            val_25.x = val_4 + val_25.x;
            val_25.x = val_32 + val_25.x;
            if()
            {
                goto label_16;
            }
            
            float val_26 = this.DeleteItemAtStart();
            val_32 = val_32 + 1165705264;
            if()
            {
                goto label_17;
            }
            
            label_16:
            if()
            {
                    0 = 1;
            }
            
            val_30 = val_30 | 1;
            label_14:
            val_31 = val_30;
            return (bool)val_31;
        }
        public LoopHorizontalScrollRect()
        {
        
        }
    
    }

}
