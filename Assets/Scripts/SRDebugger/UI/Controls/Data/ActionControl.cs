using UnityEngine;

namespace SRDebugger.UI.Controls.Data
{
    public class ActionControl : OptionsControlBase
    {
        // Fields
        private SRF.Helpers.MethodReference _method;
        public UnityEngine.UI.Button Button;
        public UnityEngine.UI.Text Title;
        
        // Properties
        public SRF.Helpers.MethodReference Method { get; }
        
        // Methods
        public SRF.Helpers.MethodReference get_Method()
        {
        
        }
        protected override void Start()
        {
            this.Start();
            UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  458441456, method:  new IntPtr(458416432));
            this.Button.m_OnClick.AddListener(call:  162246656);
        }
        private void ButtonOnClick()
        {
            if(this._method != 0)
            {
                    object val_1 = this._method.Invoke(parameters:  null);
                return;
            }
            
            UnityEngine.Debug.LogWarning(message:  458541744, context:  458565920);
        }
        public void SetMethod(string methodName, SRF.Helpers.MethodReference method)
        {
            this._method = method;
            if(this.Title == 0)
            {
                
            }
        
        }
        public ActionControl()
        {
            val_1 = new SRF.SRMonoBehaviourEx();
        }
    
    }

}
