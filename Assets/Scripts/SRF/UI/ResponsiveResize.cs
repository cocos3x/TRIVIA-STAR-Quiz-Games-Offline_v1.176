using UnityEngine;

namespace SRF.UI
{
    public class ResponsiveResize : ResponsiveBase
    {
        // Fields
        public SRF.UI.ResponsiveResize.Element[] Elements;
        
        // Methods
        protected override void Refresh()
        {
            SRF.UI.ResponsiveResize val_7;
            Element val_8;
            var val_9;
            var val_10;
            val_7 = this;
            UnityEngine.RectTransform val_1 = this.RectTransform;
            val_8 = val_7;
            val_9 = 0;
            UnityEngine.Rect val_2 = rect;
            goto label_2;
            label_20:
            val_8 = this.Elements[0];
            Element val_7 = this.Elements[0];
            bool val_3 = UnityEngine.Object.op_Equality(x:  val_7, y:  0);
            if(val_3 == true)
            {
                goto label_17;
            }
            
            val_10 = 0;
            goto label_8;
            label_11:
            float val_4 = width;
            val_10 = 1;
            if(val_3 < 0)
            {
                    0 = 1;
            }
            
            if(val_3 >= val_10)
            {
                    0 = 1;
            }
            
            if(val_3 != val_10)
            {
                    4286578687 = S26;
                -1f = 412512256;
            }
            
            label_8:
            if(val_10 < (mem[this.Elements[0x0][0] + 12]))
            {
                goto label_11;
            }
            
            val_7 = val_7;
            if(val_10 > (mem[this.Elements[0x0][0] + 12]))
            {
                    if(val_7 != 0)
            {
                    val_7.SetSizeWithCurrentAnchors(axis:  0, size:  385029192);
            }
            else
            {
                    val_7.SetSizeWithCurrentAnchors(axis:  0, size:  385029192);
            }
            
                object val_5 = val_7.GetComponent<System.Object>();
                val_8 = val_7;
                bool val_6 = UnityEngine.Object.op_Inequality(x:  val_8, y:  0);
            }
            
            label_17:
            val_9 = 1;
            label_2:
            if(val_9 < val_8)
            {
                goto label_20;
            }
        
        }
        public ResponsiveResize()
        {
            this.Elements = null;
            this = new UnityEngine.MonoBehaviour();
        }
    
    }

}
