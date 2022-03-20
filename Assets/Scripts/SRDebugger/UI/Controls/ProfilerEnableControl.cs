using UnityEngine;

namespace SRDebugger.UI.Controls
{
    public class ProfilerEnableControl : SRMonoBehaviourEx
    {
        // Fields
        private bool _previousState;
        public UnityEngine.UI.Text ButtonText;
        public UnityEngine.UI.Button EnableButton;
        public UnityEngine.UI.Text Text;
        
        // Methods
        protected override void Start()
        {
            UnityEngine.UI.Text val_4;
            var val_5;
            string val_6;
            var val_7;
            this.Start();
            if(UnityEngine.Profiling.Profiler.supported == false)
            {
                goto label_1;
            }
            
            if(UnityEngine.Application.HasProLicense() == false)
            {
                goto label_2;
            }
            
            this.UpdateLabels();
            return;
            label_1:
            val_4 = this.Text;
            val_5 = null;
            val_5 = null;
            val_6 = mem[SRDebugger.Internal.SRDebugStrings.Current + 32];
            val_6 = SRDebugger.Internal.SRDebugStrings.Current.Profiler_NotSupported;
            goto label_6;
            label_2:
            val_4 = this.Text;
            val_7 = null;
            val_7 = null;
            val_6 = mem[SRDebugger.Internal.SRDebugStrings.Current + 28];
            val_6 = SRDebugger.Internal.SRDebugStrings.Current.Profiler_NoProInfo;
            label_6:
            UnityEngine.GameObject val_3 = this.EnableButton.gameObject;
            this.EnableButton.SetActive(value:  false);
            this.enabled = false;
        }
        protected void UpdateLabels()
        {
            var val_4;
            var val_5;
            string val_6;
            UnityEngine.UI.Text val_7;
            var val_9;
            var val_10;
            val_4 = null;
            if(UnityEngine.Profiling.Profiler.enabled != false)
            {
                    val_5 = null;
                val_6 = mem[SRDebugger.Internal.SRDebugStrings.Current + 20];
                val_6 = SRDebugger.Internal.SRDebugStrings.Current.Profiler_DisableProfilerInfo;
                val_7 = this.ButtonText;
                val_9 = "Disable";
            }
            else
            {
                    val_10 = null;
                val_6 = mem[SRDebugger.Internal.SRDebugStrings.Current + 24];
                val_6 = SRDebugger.Internal.SRDebugStrings.Current.Profiler_EnableProfilerInfo;
                val_7 = this.ButtonText;
                val_9 = "Enable";
            }
            
            this._previousState = UnityEngine.Profiling.Profiler.enabled;
        }
        protected override void Update()
        {
            this.Update();
            bool val_1 = UnityEngine.Profiling.Profiler.enabled;
            if(this._previousState == true)
            {
                    this._previousState = 1;
            }
            
            val_1 = val_1 ^ 1;
            if(val_1 != true)
            {
                    return;
            }
            
            R4.UpdateLabels();
        }
        public void ToggleProfiler()
        {
            UnityEngine.Debug.Log(message:  455022080);
            bool val_1 = UnityEngine.Profiling.Profiler.enabled;
            val_1 = val_1 ^ 1;
            UnityEngine.Profiling.Profiler.enabled = val_1;
        }
        public ProfilerEnableControl()
        {
        
        }
    
    }

}
