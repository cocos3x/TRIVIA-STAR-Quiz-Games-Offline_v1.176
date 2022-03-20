using UnityEngine;

namespace SRDebugger.UI.Tabs
{
    public class ProfilerTabController : SRMonoBehaviourEx
    {
        // Fields
        private bool _isDirty;
        public UnityEngine.UI.Toggle PinToggle;
        
        // Methods
        protected override void Start()
        {
            this.Start();
            UnityEngine.Events.UnityAction<System.Boolean> val_1 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  430821024, method:  new IntPtr(430796000));
            this.PinToggle.onValueChanged.AddListener(call:  162353152);
            this.Refresh();
        }
        private void PinToggleValueChanged(bool isOn)
        {
            var val_3;
            var val_4;
            SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
            var val_4 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_2;
            }
            
            var val_3 = 0;
            label_4:
            val_3 = 0;
            if((mem[1179403735] + 0) == null)
            {
                goto label_3;
            }
            
            val_3 = val_3 + 1;
            val_3 = (uint)val_3 & 65535;
            if(val_3 < mem[1179403825])
            {
                goto label_4;
            }
            
            label_2:
            val_4 = 0;
            goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 236);
            label_3:
            var val_2 = mem[1179403735] + 0;
            val_4 = val_4 + (((mem[1179403735] + 0) + 4) << 3);
            val_4 = val_4 + 236;
            goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 236);
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this._isDirty = true;
        }
        protected override void Update()
        {
            this.Update();
            if(this._isDirty == false)
            {
                    return;
            }
            
            this.Refresh();
        }
        private void Refresh()
        {
            var val_3;
            var val_4;
            SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
            var val_4 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_2;
            }
            
            var val_3 = 0;
            label_4:
            val_3 = 0;
            if((mem[1179403735] + 0) == null)
            {
                goto label_3;
            }
            
            val_3 = val_3 + 1;
            val_3 = (uint)val_3 & 65535;
            if(val_3 < mem[1179403825])
            {
                goto label_4;
            }
            
            label_2:
            val_4 = 0;
            goto label_5;
            label_3:
            var val_2 = mem[1179403735] + 0;
            val_4 = val_4 + (((mem[1179403735] + 0) + 4) << 3);
            val_4 = val_4 + 228;
            label_5:
            this.PinToggle.isOn = false;
            this._isDirty = false;
        }
        public ProfilerTabController()
        {
        
        }
    
    }

}
