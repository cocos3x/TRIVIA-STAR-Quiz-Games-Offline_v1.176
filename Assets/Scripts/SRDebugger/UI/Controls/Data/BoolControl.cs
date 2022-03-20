using UnityEngine;

namespace SRDebugger.UI.Controls.Data
{
    public class BoolControl : DataBoundControl
    {
        // Fields
        public UnityEngine.UI.Text Title;
        public UnityEngine.UI.Toggle Toggle;
        
        // Methods
        protected override void Start()
        {
            this.Start();
            this.Refresh();
            mem[1152921513655721424] = 1;
            UnityEngine.Events.UnityAction<System.Boolean> val_1 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  458939808, method:  new IntPtr(458914784));
            this.Toggle.onValueChanged.AddListener(call:  162353152);
        }
        private void ToggleOnValueChanged(bool isOn)
        {
            this.UpdateValue(newValue:  8945664);
        }
        protected override void OnBind(string propertyName, System.Type t)
        {
            this.Toggle.interactable = this.Title >> 5;
        }
        protected override void OnValueUpdated(object newValue)
        {
            newValue.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this.Toggle.isOn = true;
        }
        public override bool CanBind(System.Type type, bool isReadOnly)
        {
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(8945664)});
            return System.Type.op_Equality(left:  type, right:  8945664);
        }
        public BoolControl()
        {
            val_1 = new SRF.SRMonoBehaviourEx();
        }
    
    }

}
