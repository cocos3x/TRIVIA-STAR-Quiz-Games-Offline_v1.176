using UnityEngine;

namespace SRDebugger.UI.Other
{
    public class ConsoleTabQuickViewControl : SRMonoBehaviourEx
    {
        // Fields
        private const int Max = 1000;
        private static readonly string MaxString;
        private int _prevErrorCount;
        private int _prevInfoCount;
        private int _prevWarningCount;
        public SRDebugger.Services.IConsoleService ConsoleService;
        public UnityEngine.UI.Text ErrorCountText;
        public UnityEngine.UI.Text InfoCountText;
        public UnityEngine.UI.Text WarningCountText;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            if(this.InfoCountText == 0)
            {
                
            }
        
        }
        protected override void Update()
        {
            float val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            int val_25;
            var val_26;
            var val_27;
            this.Update();
            if(this.ConsoleService == 0)
            {
                    return;
            }
            
            val_16 = 1152921505025908736;
            val_17 = 0;
            val_17 = val_17 + 1;
            val_18 = this.ConsoleService;
            if((SRDebugger.UI.Other.ConsoleTabQuickViewControl.HasChanged(newCount:  this.ConsoleService, oldCount: ref  this._prevErrorCount, max:  1000)) != false)
            {
                    val_17 = 0;
                val_17 = val_17 + 1;
                val_19 = this.ConsoleService;
                val_20 = null;
                val_20 = null;
                string val_5 = SRDebugger.Internal.SRDebuggerUtil.GetNumberString(value:  this.ConsoleService, max:  1000, exceedsMaxString:  SRDebugger.UI.Other.ConsoleTabQuickViewControl.MaxString);
                val_16 = 1152921505025908736;
            }
            
            val_17 = 0;
            val_17 = val_17 + 1;
            val_21 = this.ConsoleService;
            if((SRDebugger.UI.Other.ConsoleTabQuickViewControl.HasChanged(newCount:  this.ConsoleService, oldCount: ref  this._prevWarningCount, max:  1000)) != false)
            {
                    val_17 = 0;
                val_17 = val_17 + 1;
                val_22 = this.ConsoleService;
                val_23 = null;
                val_23 = null;
                string val_10 = SRDebugger.Internal.SRDebuggerUtil.GetNumberString(value:  this.ConsoleService, max:  1000, exceedsMaxString:  SRDebugger.UI.Other.ConsoleTabQuickViewControl.MaxString);
                val_16 = 1152921505025908736;
            }
            
            val_17 = 0;
            val_17 = val_17 + 1;
            val_24 = this.ConsoleService;
            val_25 = this._prevInfoCount;
            if((SRDebugger.UI.Other.ConsoleTabQuickViewControl.HasChanged(newCount:  this.ConsoleService, oldCount: ref  val_25, max:  1000)) == false)
            {
                    return;
            }
            
            val_17 = 0;
            val_25 = 0;
            val_17 = val_17 + 1;
            val_25 = (uint)val_17 & 65535;
            val_26 = this.ConsoleService;
            val_27 = null;
            val_27 = null;
            string val_15 = SRDebugger.Internal.SRDebuggerUtil.GetNumberString(value:  this.ConsoleService, max:  1000, exceedsMaxString:  SRDebugger.UI.Other.ConsoleTabQuickViewControl.MaxString);
            if(this.InfoCountText == 0)
            {
                
            }
        
        }
        private static bool HasChanged(int newCount, ref int oldCount, int max)
        {
            int val_2 = UnityEngine.Mathf.Clamp(value:  oldCount, min:  0, max:  max);
            val_2 = (UnityEngine.Mathf.Clamp(value:  newCount, min:  0, max:  max)) - val_2;
            oldCount = newCount;
            if(UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished != 0)
            {
                    val_2 = 1;
            }
            
            return true;
        }
        public ConsoleTabQuickViewControl()
        {
            this._prevErrorCount = 0;
            this._prevInfoCount = 0;
            this._prevWarningCount = 0;
        }
        private static ConsoleTabQuickViewControl()
        {
            string val_1 = 13152256 + -1467947360(-1467947360);
            SRDebugger.UI.Other.ConsoleTabQuickViewControl.MaxString = null;
        }
    
    }

}
