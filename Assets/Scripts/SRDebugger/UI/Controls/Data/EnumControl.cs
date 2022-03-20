using UnityEngine;

namespace SRDebugger.UI.Controls.Data
{
    public class EnumControl : DataBoundControl
    {
        // Fields
        private object _lastValue;
        private string[] _names;
        private System.Array _values;
        public UnityEngine.UI.LayoutElement ContentLayoutElement;
        public UnityEngine.GameObject[] DisableOnReadOnly;
        public SRF.UI.SRSpinner Spinner;
        public UnityEngine.UI.Text Title;
        public UnityEngine.UI.Text Value;
        
        // Methods
        protected override void Start()
        {
            this.Start();
            this.Refresh();
            mem[1152921513656458960] = 1;
        }
        protected override void OnBind(string propertyName, System.Type t)
        {
            var val_11;
            System.Type val_12;
            float val_13;
            float val_14;
            System.String[] val_15;
            var val_17;
            val_11 = this;
            val_12 = t;
            this.Spinner.interactable = this.Title >> 5;
            if((this.DisableOnReadOnly != null) && (this.Spinner >= 1))
            {
                    var val_11 = 0;
                do
            {
                1152921507203798144.SetActive(value:  this.Spinner >> 5);
                val_11 = val_11 + 1;
            }
            while(val_11 < 1152921507203798144);
            
            }
            
            System.String[] val_3 = System.Enum.GetNames(enumType:  val_12);
            this._names = val_12;
            System.Array val_4 = System.Enum.GetValues(enumType:  val_12);
            this._values = val_12;
            val_13 = 4;
            val_14 = "";
            goto label_10;
            label_20:
            val_15 = this._names;
            if(val_15 != null)
            {
                
            }
            else
            {
                    val_15 = 0;
            }
            
            if(this.DisableOnReadOnly >= mem[35632435])
            {
                goto label_13;
            }
            
            val_14 = this._names[0];
            val_13 = 5;
            label_10:
            val_17 = val_13 - 4;
            if(this._names == null)
            {
                goto label_20;
            }
            
            label_13:
            UnityEngine.TextGenerator val_5 = this.Value.cachedTextGeneratorForLayout;
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  null, y:  null);
            UnityEngine.TextGenerationSettings val_7 = GetGenerationSettings(extents:  new UnityEngine.Vector2() {x = this.Value, y = val_6.x});
            mem2[0] = val_7.color.a;
            val_17 = val_7.resizeTextMaxSize;
            do
            {
                val_13 = mem[(val_7.lineSpacing + 8)];
                val_13 = val_7.lineSpacing + 8;
                var val_9 = 80 - 4;
                mem2[0] = val_13;
            }
            while(val_7.scaleFactor != 0f);
            
            bool val_10 = val_7.alignByGeometry - 28;
        }
        protected override void OnValueUpdated(object newValue)
        {
            this._lastValue = newValue;
            if(this.Value == 0)
            {
                
            }
        
        }
        public override bool CanBind(System.Type type, bool isReadOnly)
        {
            if(type == 0)
            {
                
            }
        
        }
        private void SetIndex(int i)
        {
            object val_1 = this._values.GetValue(index:  i);
            this.UpdateValue(newValue:  this._values);
            this.Refresh();
        }
        public void GoToNext()
        {
            this.SetIndex(i:  SRMath.Wrap(max:  this._values.Length, value:  (System.Array.IndexOf(array:  this._values, value:  this._lastValue)) + 1));
        }
        public void GoToPrevious()
        {
            this.SetIndex(i:  SRMath.Wrap(max:  this._values.Length, value:  (System.Array.IndexOf(array:  this._values, value:  this._lastValue)) - 1));
        }
        public EnumControl()
        {
            val_1 = new SRF.SRMonoBehaviourEx();
        }
    
    }

}
