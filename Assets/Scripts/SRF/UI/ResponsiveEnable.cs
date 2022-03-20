using UnityEngine;

namespace SRF.UI
{
    public class ResponsiveEnable : ResponsiveBase
    {
        // Fields
        public SRF.UI.ResponsiveEnable.Entry[] Entries;
        
        // Methods
        protected override void Refresh()
        {
            SRF.UI.ResponsiveEnable val_10;
            var val_11;
            var val_12;
            UnityEngine.Object val_13;
            var val_14;
            var val_15;
            val_10 = this;
            UnityEngine.RectTransform val_1 = val_10.RectTransform;
            val_11 = val_10;
            val_12 = 0;
            UnityEngine.Rect val_2 = rect;
            goto label_2;
            label_29:
            Entry val_11 = this.Entries[0];
            Entry val_12 = this.Entries[0];
            Entry val_15 = this.Entries[0];
            if(val_15 == 1)
            {
                goto label_5;
            }
            
            if(val_15 != 0)
            {
                goto label_6;
            }
            
            val_11 = 1;
            if(val_15 > 0)
            {
                    float val_3 = height;
                if(val_15 >= 0)
            {
                    val_11 = 1;
            }
            
            }
            
            if(val_15 <= 0)
            {
                goto label_11;
            }
            
            float val_4 = width;
            if(val_15 >= 0)
            {
                    0 = 1;
            }
            
            val_11 = 1 & 1;
            goto label_11;
            label_5:
            val_15 = 1;
            if(val_15 > 1)
            {
                    float val_5 = height;
                if(val_15 <= 1)
            {
                    val_15 = 1;
            }
            
            }
            
            if(1 != 0)
            {
                    val_11 = 1;
            }
            
            if(1 > 0)
            {
                    float val_6 = width;
                if(1 <= 0)
            {
                    0 = 1;
            }
            
                var val_7 = 1 & 1;
                if(1 != 0)
            {
                    val_11 = 1;
            }
            
            }
            
            label_11:
            if((this.Entries[0] != 0) && (this.Entries[0x0][1].ThresholdHeight >= (1.401298E-45f)))
            {
                    var val_16 = 0;
                do
            {
                val_13 = mem[this.Entries[0x0][1].ThresholdWidth + 0];
                val_13 = this.Entries[0x0][1].ThresholdWidth + 0;
                if(val_13 != 0)
            {
                    val_13.SetActive(value:  true);
            }
            
                val_16 = val_16 + 1;
            }
            while(val_16 < this.Entries[0x0][1].ThresholdHeight);
            
            }
            
            val_14 = ;
            if((this.Entries[0] != 0) && (this.Entries[0x0][0].ThresholdHeight >= (1.401298E-45f)))
            {
                    var val_17 = 0;
                do
            {
                val_13 = mem[this.Entries[0x0][0].ThresholdWidth + 0];
                val_13 = this.Entries[0x0][0].ThresholdWidth + 0;
                if(val_13 != 0)
            {
                    val_13.enabled = true;
            }
            
                val_17 = val_17 + 1;
            }
            while(val_17 < this.Entries[0x0][0].ThresholdHeight);
            
            }
            
            val_10 = val_10;
            val_12 = val_12 + 1;
            label_2:
            if(val_12 < this.Entries[0x0][0].ThresholdHeight)
            {
                goto label_29;
            }
            
            return;
            label_6:
            System.IndexOutOfRangeException val_10 = new System.IndexOutOfRangeException();
        }
        public ResponsiveEnable()
        {
            this.Entries = null;
            this = new UnityEngine.MonoBehaviour();
        }
    
    }

}
