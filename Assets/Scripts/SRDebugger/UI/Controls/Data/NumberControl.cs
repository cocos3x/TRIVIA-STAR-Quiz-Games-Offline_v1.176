using UnityEngine;

namespace SRDebugger.UI.Controls.Data
{
    public class NumberControl : DataBoundControl
    {
        // Fields
        private static readonly System.Type[] IntegerTypes;
        private static readonly System.Type[] DecimalTypes;
        public static readonly System.Collections.Generic.Dictionary<System.Type, SRDebugger.UI.Controls.Data.NumberControl.ValueRange> ValueRanges;
        private string _lastValue;
        private System.Type _type;
        public UnityEngine.GameObject[] DisableOnReadOnly;
        public SRF.UI.SRNumberButton DownNumberButton;
        public SRF.UI.SRNumberSpinner NumberSpinner;
        public UnityEngine.UI.Text Title;
        public SRF.UI.SRNumberButton UpNumberButton;
        
        // Methods
        protected override void Start()
        {
            this.Start();
            this.Refresh();
            mem[1152921513657794256] = 1;
            UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder>(object:  461012640, method:  new IntPtr(460987616));
            this.NumberSpinner.AddListener(call:  162353152);
        }
        private void OnValueChanged(string newValue)
        {
            object val_1 = System.Convert.ChangeType(value:  newValue, conversionType:  this._type);
            this.UpdateValue(newValue:  newValue);
        }
        protected override void OnBind(string propertyName, System.Type t)
        {
            UnityEngine.UI.Text val_15;
            var val_16;
            float val_18;
            double val_19;
            val_15 = this.Title;
            if((SRDebugger.UI.Controls.Data.NumberControl.IsIntegerType(t:  t)) == false)
            {
                goto label_4;
            }
            
            val_16 = 2;
            goto label_6;
            label_4:
            if((SRDebugger.UI.Controls.Data.NumberControl.IsDecimalType(t:  t)) == false)
            {
                goto label_9;
            }
            
            val_16 = 3;
            label_6:
            this.NumberSpinner.contentType = 3;
            object val_3 = this.NumberSpinner.GetAttribute<System.Object>();
            double val_4 = this.NumberSpinner.GetMaxValue(t:  t);
            this.NumberSpinner.MaxValue = this.NumberSpinner;
            this.NumberSpinner.MinValue = this.NumberSpinner;
            if(this.NumberSpinner != 0)
            {
                    val_15 = 0;
                double val_6 = System.Math.Min(val1:  this.NumberSpinner.GetMinValue(t:  t), val2:  null);
                this.NumberSpinner.MaxValue = System.Math.__il2cppRuntimeField_cctor_finished;
                mem2[0] = System.Math.__il2cppRuntimeField_cctor_finished;
                if(this.NumberSpinner != 0)
            {
                    double val_7 = System.Math.Max(val1:  val_6, val2:  null);
                val_18 = System.Math.__il2cppRuntimeField_cctor_finished;
                val_19 = this.NumberSpinner.MinValue;
            }
            else
            {
                    double val_8 = System.Math.Max(val1:  val_6, val2:  null);
                val_18 = System.Math.__il2cppRuntimeField_cctor_finished;
                val_19 = this.NumberSpinner.MinValue;
            }
            
                mem2[0] = val_18;
            }
            
            object val_9 = this.NumberSpinner.GetAttribute<System.Object>();
            if(this.NumberSpinner != 0)
            {
                    if(this.UpNumberButton != 0)
            {
                    this.UpNumberButton.Amount = val_18;
            }
            
                val_15 = this.DownNumberButton;
                bool val_11 = UnityEngine.Object.op_Inequality(x:  val_15, y:  0);
                if(val_11 != false)
            {
                    this.DownNumberButton.Amount = -val_18;
            }
            
            }
            
            this._type = t;
            this.NumberSpinner.interactable = val_11 >> 5;
            if(this.DisableOnReadOnly == null)
            {
                    return;
            }
            
            if(this.NumberSpinner < 1)
            {
                    return;
            }
            
            var val_15 = 0;
            do
            {
                1152921507203798144.SetActive(value:  this.NumberSpinner >> 5);
                val_15 = val_15 + 1;
            }
            while(val_15 < 1152921507203798144);
            
            return;
            label_9:
            System.ArgumentException val_14 = new System.ArgumentException(message:  461329376, paramName:  1383185776);
        }
        protected override void OnValueUpdated(object newValue)
        {
            string val_1 = System.Convert.ToString(value:  newValue);
            if((System.String.op_Inequality(a:  newValue, b:  this._lastValue)) != false)
            {
                    35632427 = this.NumberSpinner;
                35632427.text = newValue;
            }
            
            this._lastValue = newValue;
        }
        public override bool CanBind(System.Type type, bool isReadOnly)
        {
            if((SRDebugger.UI.Controls.Data.NumberControl.IsDecimalType(t:  type)) == false)
            {
                    return SRDebugger.UI.Controls.Data.NumberControl.IsIntegerType(t:  type);
            }
            
            return true;
        }
        protected static bool IsIntegerType(System.Type t)
        {
            var val_2;
            var val_3;
            var val_2 = 0;
            do
            {
                val_2 = null;
                val_2 = null;
                if(val_2 >= (SRDebugger.UI.Controls.Data.NumberControl.IntegerTypes + 12))
            {
                    return false;
            }
            
                val_3 = null;
                val_3 = null;
                val_2 = val_2 + 1;
            }
            while((System.Type.op_Equality(left:  2621443, right:  t)) == false);
            
            return true;
        }
        protected static bool IsDecimalType(System.Type t)
        {
            var val_2;
            var val_3;
            var val_2 = 0;
            do
            {
                val_2 = null;
                val_2 = null;
                if(val_2 >= (SRDebugger.UI.Controls.Data.NumberControl.DecimalTypes + 12))
            {
                    return false;
            }
            
                val_3 = null;
                val_3 = null;
                val_2 = val_2 + 1;
            }
            while((System.Type.op_Equality(left:  2621443, right:  t)) == false);
            
            return true;
        }
        protected double GetMaxValue(System.Type t)
        {
            var val_2;
            var val_4;
            System.Type val_5;
            double val_6;
            val_4 = null;
            val_4 = null;
            val_5 = t;
            if((SRDebugger.UI.Controls.Data.NumberControl.ValueRanges.TryGetValue(key:  val_5, value: out  new ValueRange() {MaxValue = 1.28823234318987E-231})) != false)
            {
                    val_6 = val_2;
                return (double)D0;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_10 = t;
            string val_3 = SRF.SRFStringExtensions.Fmt(formatString:  462039024, args:  472754880);
            val_5 = 0;
            UnityEngine.Debug.LogWarning(message:  462039024);
            val_6 = 2.12199579047121E-314;
            return (double)D0;
        }
        protected double GetMinValue(System.Type t)
        {
            var val_2;
            var val_4;
            System.Type val_5;
            double val_6;
            val_4 = null;
            val_4 = null;
            val_5 = t;
            if((SRDebugger.UI.Controls.Data.NumberControl.ValueRanges.TryGetValue(key:  val_5, value: out  new ValueRange() {MaxValue = 1.2882323432243E-231})) != false)
            {
                    val_6 = val_2;
                return (double)D0;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_10 = t;
            string val_3 = SRF.SRFStringExtensions.Fmt(formatString:  462159392, args:  472754880);
            val_5 = 0;
            UnityEngine.Debug.LogWarning(message:  462159392);
            val_6 = 2.12199579047121E-314;
            return (double)D0;
        }
        public NumberControl()
        {
            val_1 = new SRF.SRMonoBehaviourEx();
        }
        private static NumberControl()
        {
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(13152256)});
            typeof(System.Type[]).__il2cppRuntimeField_10 = null;
            System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(13099008)});
            typeof(System.Type[]).__il2cppRuntimeField_14 = null;
            System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(9052160)});
            typeof(System.Type[]).__il2cppRuntimeField_18 = null;
            System.Type val_4 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(15122432)});
            typeof(System.Type[]).__il2cppRuntimeField_1C = null;
            System.Type val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(16773120)});
            typeof(System.Type[]).__il2cppRuntimeField_20 = null;
            System.Type val_6 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(16719872)});
            typeof(System.Type[]).__il2cppRuntimeField_24 = null;
            SRDebugger.UI.Controls.Data.NumberControl.IntegerTypes = null;
            System.Type val_7 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(15282176)});
            typeof(System.Type[]).__il2cppRuntimeField_10 = null;
            System.Type val_8 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(10489856)});
            typeof(System.Type[]).__il2cppRuntimeField_14 = null;
            SRDebugger.UI.Controls.Data.NumberControl.DecimalTypes = null;
            System.Collections.Generic.Dictionary<System.Type, ValueRange> val_9 = new System.Collections.Generic.Dictionary<System.Type, ValueRange>();
            System.Type val_10 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(13152256)});
            Add(key:  13152256, value:  new ValueRange());
            System.Type val_11 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(13099008)});
            Add(key:  13099008, value:  new ValueRange());
            System.Type val_12 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(9052160)});
            Add(key:  9052160, value:  new ValueRange());
            System.Type val_13 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(15122432)});
            Add(key:  15122432, value:  new ValueRange());
            System.Type val_14 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(16773120)});
            Add(key:  16773120, value:  new ValueRange());
            System.Type val_15 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(16719872)});
            Add(key:  16719872, value:  new ValueRange());
            System.Type val_16 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(15282176)});
            Add(key:  15282176, value:  new ValueRange() {MaxValue = 1.85674631709461E-314, MinValue = 1.85674631709461E-314});
            System.Type val_17 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(10489856)});
            Add(key:  10489856, value:  new ValueRange());
            SRDebugger.UI.Controls.Data.NumberControl.ValueRanges = null;
        }
    
    }

}
