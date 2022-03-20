using UnityEngine;

namespace SRDebugger.UI.Controls
{
    public class ProfilerMemoryBlock : SRMonoBehaviourEx
    {
        // Fields
        private float _lastRefresh;
        public UnityEngine.UI.Text CurrentUsedText;
        public UnityEngine.UI.Slider Slider;
        public UnityEngine.UI.Text TotalAllocatedText;
        
        // Methods
        protected override void OnEnable()
        {
            this.OnEnable();
            this.TriggerRefresh();
        }
        protected override void Update()
        {
            this.Update();
            float val_1 = UnityEngine.Time.realtimeSinceStartup;
            float val_3 = this._lastRefresh;
            val_3 = 0 - val_3;
            if()
            {
                    return;
            }
            
            R4.TriggerRefresh();
            float val_2 = UnityEngine.Time.realtimeSinceStartup;
            mem2[0] = 0;
        }
        public void TriggerRefresh()
        {
            uint val_1 = UnityEngine.Profiling.Profiler.GetTotalReservedMemory();
            uint val_6 = UnityEngine.Profiling.Profiler.GetTotalAllocatedMemory();
            this.Slider.maxValue = val_1;
            uint val_3 = val_1 >> 20;
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            val_6 = val_6 >> 20;
            string val_4 = SRF.SRFStringExtensions.Fmt(formatString:  452861280, args:  472754880);
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            string val_5 = SRF.SRFStringExtensions.Fmt(formatString:  452865520, args:  472754880);
            if(this.CurrentUsedText != 0)
            {
                    return;
            }
        
        }
        public void TriggerCleanup()
        {
            System.Collections.IEnumerator val_1 = this.CleanUp();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  453018032);
        }
        private System.Collections.IEnumerator CleanUp()
        {
            object val_1 = new System.Object();
            typeof(ProfilerMemoryBlock.<CleanUp>d__8).__il2cppRuntimeField_8 = 0;
            typeof(ProfilerMemoryBlock.<CleanUp>d__8).__il2cppRuntimeField_10 = this;
        }
        public ProfilerMemoryBlock()
        {
        
        }
    
    }

}
