using UnityEngine;

namespace SRDebugger.UI.Controls.Data
{
    public class ReadOnlyControl : DataBoundControl
    {
        // Fields
        public UnityEngine.UI.Text ValueText;
        public UnityEngine.UI.Text Title;
        
        // Methods
        protected override void Start()
        {
            this.Start();
            this.Refresh();
            mem[1152921513659307328] = 1;
        }
        protected override void OnBind(string propertyName, System.Type t)
        {
            if(this.Title == 0)
            {
                
            }
        
        }
        protected override void OnValueUpdated(object newValue)
        {
            string val_1 = System.Convert.ToString(value:  newValue);
            if(this.ValueText == 0)
            {
                
            }
        
        }
        public override bool CanBind(System.Type type, bool isReadOnly)
        {
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(15388672)});
            bool val_2 = System.Type.op_Equality(left:  type, right:  15388672);
            val_2 = val_2 & isReadOnly;
            return (bool)val_2;
        }
        public ReadOnlyControl()
        {
            val_1 = new SRF.SRMonoBehaviourEx();
        }
    
    }

}
