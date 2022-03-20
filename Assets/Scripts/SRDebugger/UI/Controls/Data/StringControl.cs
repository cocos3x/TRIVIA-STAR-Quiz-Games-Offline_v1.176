using UnityEngine;

namespace SRDebugger.UI.Controls.Data
{
    public class StringControl : DataBoundControl
    {
        // Fields
        public UnityEngine.UI.InputField InputField;
        public UnityEngine.UI.Text Title;
        
        // Methods
        protected override void Start()
        {
            this.Start();
            this.Refresh();
            mem[1152921513659925696] = 1;
            UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder>(object:  463144080, method:  new IntPtr(463119056));
            this.InputField.m_OnValueChanged.AddListener(call:  162353152);
        }
        private void OnValueChanged(string newValue)
        {
            this.UpdateValue(newValue:  newValue);
        }
        protected override void OnBind(string propertyName, System.Type t)
        {
            this.InputField.text = 1098586544;
            this.InputField.interactable = this.InputField >> 5;
        }
        protected override void OnValueUpdated(object newValue)
        {
            object val_1 = newValue;
            if(val_1 == 0)
            {
                goto label_1;
            }
            
            if(null == null)
            {
                goto label_3;
            }
            
            val_1 = 0;
            goto label_3;
            label_1:
            val_1 = "";
            label_3:
            this.InputField.text = 1098586544;
        }
        public override bool CanBind(System.Type type, bool isReadOnly)
        {
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(15388672)});
            bool val_2 = System.Type.op_Equality(left:  type, right:  15388672);
            val_2 = val_2 & isReadOnly ^ 1;
            return (bool)val_2;
        }
        public StringControl()
        {
            val_1 = new SRF.SRMonoBehaviourEx();
        }
    
    }

}
