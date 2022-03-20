using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    public class RadialLayout : LayoutGroup
    {
        // Fields
        public float fDistance;
        public float MinAngle;
        public float MaxAngle;
        public float StartAngle;
        
        // Methods
        protected override void OnEnable()
        {
            this.OnEnable();
            this.CalculateRadial();
        }
        public override void SetLayoutHorizontal()
        {
        
        }
        public override void SetLayoutVertical()
        {
        
        }
        public override void CalculateLayoutInputVertical()
        {
            this.CalculateRadial();
        }
        public override void CalculateLayoutInputHorizontal()
        {
            this.CalculateRadial();
        }
        private void CalculateRadial()
        {
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            val_15 = this;
            Clear();
            UnityEngine.Transform val_1 = this.transform;
            if(this.childCount == 0)
            {
                    return;
            }
            
            float val_15 = this.MinAngle;
            val_16 = 0;
            UnityEngine.Transform val_3 = this.transform;
            val_17 = 0;
            float val_16 = this.StartAngle;
            val_15 = (this.MaxAngle - val_15) / (float)this.childCount;
            goto label_4;
            label_20:
            UnityEngine.Transform val_6 = this.transform;
            UnityEngine.Transform val_7 = this.GetChild(index:  0);
            if(val_15 == 0)
            {
                goto label_6;
            }
            
            val_18 = val_15;
            if(null == null)
            {
                goto label_7;
            }
            
            label_6:
            val_18 = 0;
            label_7:
            if(0 != 0)
            {
                    Add(driver:  1829168960, rectTransform:  0, drivenProperties:  52998);
                float val_9 = val_16 * 0.01745329f;
                UnityEngine.Vector3 val_10 = new UnityEngine.Vector3(x:  val_9, y:  null, z:  (float)this.childCount);
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 2.605846E+27f, y = val_10.x, z = val_10.y}, d:  val_9);
                val_18.localPosition = new UnityEngine.Vector3();
                UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  val_11.x, y:  val_11.y);
                val_18.pivot = new UnityEngine.Vector2() {x = val_12.x, y = val_12.y};
                if(val_18 != 0)
            {
                    val_18.anchorMax = new UnityEngine.Vector2() {x = val_12.x, y = val_12.y};
            }
            else
            {
                    val_18.anchorMax = new UnityEngine.Vector2() {x = val_12.x, y = val_12.y};
            }
            
                val_18.anchorMin = new UnityEngine.Vector2() {x = val_12.x, y = val_12.y};
                val_16 = val_15 + val_16;
                val_15 = val_15;
                val_16 = 0;
            }
            
            val_17 = 1;
            label_4:
            UnityEngine.Transform val_13 = this.transform;
            if(val_17 < this.childCount)
            {
                goto label_20;
            }
        
        }
        public RadialLayout()
        {
        
        }
    
    }

}
