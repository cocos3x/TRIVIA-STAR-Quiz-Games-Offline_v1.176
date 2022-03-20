using UnityEngine;

namespace SRDebugger.UI.Controls
{
    public class ProfilerGraphAxisLabel : SRMonoBehaviourEx
    {
        // Fields
        private float _prevFrameTime;
        private System.Nullable<float> _queuedFrameTime;
        private float _yPosition;
        public UnityEngine.UI.Text Text;
        
        // Methods
        protected override void Update()
        {
            this.Update();
            if(this == 0)
            {
                    return;
            }
            
            this.SetValueInternal(frameTime:  this._queuedFrameTime.Value);
            mem2[0] = 0;
            mem2[0] = 0;
        }
        public void SetValue(float frameTime, float yPosition)
        {
            System.Nullable<System.Single> val_1 = new System.Nullable<System.Single>(value:  this._prevFrameTime = this._yPosition);
            this._queuedFrameTime = val_1.HasValue;
            mem[1152921513652163804] = 0;
            this._yPosition = R2;
        }
        private void SetValueInternal(float frameTime)
        {
            var val_8;
            var val_9;
            this._prevFrameTime = R1;
            float val_8 = 1000f;
            val_8 = R1 * val_8;
            int val_1 = UnityEngine.Mathf.FloorToInt(f:  val_8);
            float val_9 = 1f;
            val_9 = val_9 / R1;
            int val_2 = UnityEngine.Mathf.RoundToInt(f:  val_9);
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            string val_3 = SRF.SRFStringExtensions.Fmt(formatString:  455474288, args:  472754880);
            val_8 = 0;
            UnityEngine.Transform val_4 = this.CachedTransform;
            if(this != 0)
            {
                    if(null == null)
            {
                goto label_12;
            }
            
            }
            
            val_9 = 1;
            goto label_13;
            label_12:
            val_9 = 0;
            val_8 = this;
            label_13:
            UnityEngine.Rect val_5 = rect;
            float val_6 = width;
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  0.5f, y:  val_5.m_YMin);
            this.anchoredPosition = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
        }
        public ProfilerGraphAxisLabel()
        {
        
        }
    
    }

}
