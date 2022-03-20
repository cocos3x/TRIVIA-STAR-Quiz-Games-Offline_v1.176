using UnityEngine;

namespace SRDebugger.UI.Controls
{
    public abstract class DataBoundControl : OptionsControlBase
    {
        // Fields
        private bool _hasStarted;
        private bool _isReadOnly;
        private object _prevValue;
        private SRF.Helpers.PropertyReference _prop;
        private string <PropertyName>k__BackingField;
        
        // Properties
        public SRF.Helpers.PropertyReference Property { get; }
        public bool IsReadOnly { get; }
        public string PropertyName { get; set; }
        
        // Methods
        public SRF.Helpers.PropertyReference get_Property()
        {
        
        }
        public bool get_IsReadOnly()
        {
            return (bool)this._isReadOnly;
        }
        public string get_PropertyName()
        {
        
        }
        private void set_PropertyName(string value)
        {
            this.<PropertyName>k__BackingField = value;
        }
        public void Bind(string propertyName, SRF.Helpers.PropertyReference prop)
        {
            this._prop = prop;
            this.<PropertyName>k__BackingField = propertyName;
            if(prop != 0)
            {
                    bool val_1 = prop.CanWrite;
                val_1 = val_1 ^ 1;
                this._isReadOnly = val_1;
            }
            else
            {
                    bool val_2 = 0.CanWrite;
                val_2 = val_2 ^ 1;
                this._isReadOnly = val_2;
            }
            
            System.Type val_3 = prop.PropertyType;
            goto typeof(SRDebugger.UI.Controls.DataBoundControl).__il2cppRuntimeField_114;
        }
        protected void UpdateValue(object newValue)
        {
            if(this._prevValue == newValue)
            {
                    return;
            }
            
            if(this._isReadOnly == true)
            {
                    return;
            }
            
            R5 + 56.SetValue(value:  newValue);
            mem2[0] = newValue;
        }
        public override void Refresh()
        {
            if(this._prop == 0)
            {
                    return;
            }
            
            object val_1 = this._prop.GetValue();
            this._prevValue = this._prop;
        }
        protected virtual void OnBind(string propertyName, System.Type t)
        {
        
        }
        protected abstract void OnValueUpdated(object newValue); // 0
        public abstract bool CanBind(System.Type type, bool isReadOnly); // 0
        protected override void Start()
        {
            this.Start();
            this._hasStarted = true;
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            if(this._hasStarted == false)
            {
                    return;
            }
            
            goto typeof(SRDebugger.UI.Controls.DataBoundControl).__il2cppRuntimeField_114;
        }
        protected DataBoundControl()
        {
            val_1 = new SRF.SRMonoBehaviourEx();
        }
    
    }

}
