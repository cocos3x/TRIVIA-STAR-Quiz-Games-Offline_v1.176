using UnityEngine;

namespace SRDebugger.UI
{
    public class ProfilerFPSLabel : SRMonoBehaviourEx
    {
        // Fields
        private float _nextUpdate;
        private SRDebugger.Services.IProfilerService _profilerService;
        public float UpdateFrequency;
        private UnityEngine.UI.Text _text;
        
        // Methods
        protected override void Update()
        {
            this.Update();
            float val_1 = UnityEngine.Time.realtimeSinceStartup;
            if()
            {
                    return;
            }
            
            R4.Refresh();
        }
        private void Refresh()
        {
            var val_4;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = this._profilerService;
            float val_5 = 1f;
            val_5 = val_5 / this._profilerService;
            typeof(System.Object[]).__il2cppRuntimeField_10 = null;
            string val_2 = SRF.SRFStringExtensions.Fmt(formatString:  421771472, args:  472754880);
            float val_3 = UnityEngine.Time.realtimeSinceStartup;
            float val_6 = this.UpdateFrequency;
            val_6 = 0 + val_6;
            this._nextUpdate = val_6;
        }
        public ProfilerFPSLabel()
        {
            this.UpdateFrequency = 1f;
        }
    
    }

}
