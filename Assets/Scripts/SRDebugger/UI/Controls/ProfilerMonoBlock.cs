using UnityEngine;

namespace SRDebugger.UI.Controls
{
    public class ProfilerMonoBlock : SRMonoBehaviourEx
    {
        // Fields
        private float _lastRefresh;
        public UnityEngine.UI.Text CurrentUsedText;
        public UnityEngine.GameObject NotSupportedMessage;
        public UnityEngine.UI.Slider Slider;
        public UnityEngine.UI.Text TotalAllocatedText;
        private bool _isSupported;
        
        // Methods
        protected override void OnEnable()
        {
            this.OnEnable();
            uint val_1 = UnityEngine.Profiling.Profiler.GetMonoUsedSize();
            if(val_1 != 0)
            {
                    val_1 = 1;
            }
            
            this._isSupported = true;
            this.NotSupportedMessage.SetActive(value:  false);
            UnityEngine.GameObject val_2 = this.CurrentUsedText.gameObject;
            if(this._isSupported == true)
            {
                    this._isSupported = 1;
            }
            
            this.CurrentUsedText.SetActive(value:  true);
            this.TriggerRefresh();
        }
        protected override void Update()
        {
            var val_5;
            var val_6;
            this.Update();
            SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
            var val_6 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_2;
            }
            
            var val_5 = 0;
            label_4:
            val_5 = 0;
            if((mem[1179403735] + 0) == null)
            {
                goto label_3;
            }
            
            val_5 = val_5 + 1;
            val_5 = (uint)val_5 & 65535;
            if(val_5 < mem[1179403825])
            {
                goto label_4;
            }
            
            label_2:
            val_6 = 0;
            goto label_5;
            label_3:
            var val_2 = mem[1179403735] + 0;
            val_6 = val_6 + (((mem[1179403735] + 0) + 4) << 3);
            val_6 = val_6 + 196;
            label_5:
            if(0 == 0)
            {
                    return;
            }
            
            float val_3 = UnityEngine.Time.realtimeSinceStartup;
            float val_7 = this._lastRefresh;
            val_7 = 0 - val_7;
            if(0 <= 0)
            {
                    return;
            }
            
            this.TriggerRefresh();
            float val_4 = UnityEngine.Time.realtimeSinceStartup;
            this._lastRefresh = 0f;
        }
        public void TriggerRefresh()
        {
            var val_11;
            var val_12;
            UnityEngine.UI.Text val_13;
            UnityEngine.UI.Text val_14;
            if(this._isSupported != false)
            {
                    val_11 = 0;
                val_12 = UnityEngine.Profiling.Profiler.GetMonoHeapSize();
            }
            else
            {
                    val_12 = System.GC.GetTotalMemory(forceFullCollection:  false);
                val_11 = 0;
            }
            
            this.Slider.maxValue = null;
            long val_4 = val_12 >> 10;
            val_4 = val_4 | 0;
            val_13 = this.TotalAllocatedText;
            UnityEngine.UI.Slider val_6 = this.Slider >> 10;
            val_14 = null;
            long val_7 = (val_4 + 0) >> 10;
            val_7 = val_7 | (this.Slider << 22);
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            string val_9 = SRF.SRFStringExtensions.Fmt(formatString:  454280304, args:  472754880);
            if((UnityEngine.Profiling.Profiler.GetMonoUsedSize() >> 20) == 0)
            {
                    return;
            }
            
            val_14 = this.CurrentUsedText;
            val_13 = null;
            typeof(System.Object[]).__il2cppRuntimeField_10 = val_13;
            string val_10 = SRF.SRFStringExtensions.Fmt(formatString:  452865520, args:  472754880);
        }
        public void TriggerCollection()
        {
            System.GC.Collect();
            this.TriggerRefresh();
        }
        public ProfilerMonoBlock()
        {
        
        }
    
    }

}
