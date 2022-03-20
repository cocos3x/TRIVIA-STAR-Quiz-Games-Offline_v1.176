using UnityEngine;

namespace SRDebugger.UI.Other
{
    public class HandleManager : SRMonoBehaviour
    {
        // Fields
        private bool _hasSet;
        public UnityEngine.GameObject BottomHandle;
        public UnityEngine.GameObject BottomLeftHandle;
        public UnityEngine.GameObject BottomRightHandle;
        public SRDebugger.PinAlignment DefaultAlignment;
        public UnityEngine.GameObject LeftHandle;
        public UnityEngine.GameObject RightHandle;
        public UnityEngine.GameObject TopHandle;
        public UnityEngine.GameObject TopLeftHandle;
        public UnityEngine.GameObject TopRightHandle;
        
        // Methods
        private void Start()
        {
            if(this._hasSet == true)
            {
                    return;
            }
            
            this.SetAlignment(alignment:  this.DefaultAlignment);
        }
        public void SetAlignment(SRDebugger.PinAlignment alignment)
        {
            UnityEngine.GameObject val_4;
            UnityEngine.GameObject val_5;
            UnityEngine.GameObject val_6;
            this._hasSet = true;
            if(alignment < 2)
            {
                goto label_0;
            }
            
            SRDebugger.PinAlignment val_1 = alignment & (~1);
            if(val_1 != 2)
            {
                goto label_1;
            }
            
            val_1.SetActive(obj:  this.BottomHandle, active:  false);
            val_1.SetActive(obj:  this.TopHandle, active:  true);
            val_1.SetActive(obj:  this.BottomLeftHandle, active:  false);
            val_4 = this.BottomRightHandle;
            goto label_2;
            label_0:
            this.SetActive(obj:  this.BottomHandle, active:  true);
            this.SetActive(obj:  this.TopHandle, active:  false);
            this.SetActive(obj:  this.TopLeftHandle, active:  false);
            val_4 = this.TopRightHandle;
            label_2:
            this.SetActive(obj:  val_4, active:  false);
            label_1:
            if(alignment > 3)
            {
                    return;
            }
            
            var val_2 = 9546704 + (9546704 + (alignment) << 2);
            if(alignment == 3)
            {
                    9546704 = 9546704;
                9546704 = 9546704 & ((IP) >> 9546704);
                9546704 = 9546704 & (9546704 << 9546704);
                9546704 = 9546704 & ((IP) >> ((9546704 & (IP) >> 9546704) & ((9546704 & (IP) >> 9546704)) << (9546704 & (IP) >> 9546704)));
            }
            
            9546704.SetActive(obj:  this.LeftHandle, active:  false);
            9546704.SetActive(obj:  this.RightHandle, active:  true);
            9546704.SetActive(obj:  this.TopLeftHandle, active:  false);
            val_5 = this.BottomLeftHandle;
            9546704.SetActive(obj:  null, active:  false);
            if(alignment > 3)
            {
                    return;
            }
            
            var val_3 = 9546828 + 4;
            var val_4 = val_3 + ((9546828 + 4) + (alignment) << 2);
            if(alignment == 3)
            {
                    val_3 = val_3 & (val_3 << val_3);
                val_3 = val_3 & ((R8) >> 32);
                val_3 = val_3 & ((IP) >> (((9546828 + 4) & ((9546828 + 4)) << (9546828 + 4)) & (R8) >> 32));
                val_3 = val_3 & (((int)R8) >> ((((9546828 + 4) & ((9546828 + 4)) << (9546828 + 4)) & (R8) >> 32) & (IP) >> (((9546828 + 4) & ((9546828 + 4)) << (9546828 + 4)) & (R8) >> 32)));
            }
            
            val_3.SetActive(obj:  this.BottomLeftHandle, active:  false);
            val_6 = this.BottomRightHandle;
            this.SetActive(obj:  null, active:  true);
        }
        private void SetActive(UnityEngine.GameObject obj, bool active)
        {
            if(obj == 0)
            {
                    return;
            }
            
            obj.SetActive(value:  active);
        }
        public HandleManager()
        {
        
        }
    
    }

}
