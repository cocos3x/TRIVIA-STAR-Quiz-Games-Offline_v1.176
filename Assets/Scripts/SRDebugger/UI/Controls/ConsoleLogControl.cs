using UnityEngine;

namespace SRDebugger.UI.Controls
{
    public class ConsoleLogControl : SRMonoBehaviourEx
    {
        // Fields
        private SRF.UI.Layout.VirtualVerticalLayoutGroup _consoleScrollLayoutGroup;
        private UnityEngine.UI.ScrollRect _consoleScrollRect;
        private bool _isDirty;
        private System.Nullable<UnityEngine.Vector2> _scrollPosition;
        private bool _showErrors;
        private bool _showInfo;
        private bool _showWarnings;
        public System.Action<SRDebugger.Services.ConsoleEntry> SelectedItemChanged;
        private string _filter;
        
        // Properties
        public bool ShowErrors { get; set; }
        public bool ShowWarnings { get; set; }
        public bool ShowInfo { get; set; }
        public bool EnableSelection { get; set; }
        public string Filter { get; set; }
        
        // Methods
        public bool get_ShowErrors()
        {
            return (bool)this._showErrors;
        }
        public void set_ShowErrors(bool value)
        {
            this._isDirty = true;
            this._showErrors = value;
        }
        public bool get_ShowWarnings()
        {
            return (bool)this._showWarnings;
        }
        public void set_ShowWarnings(bool value)
        {
            this._isDirty = true;
            this._showWarnings = value;
        }
        public bool get_ShowInfo()
        {
            return (bool)this._showInfo;
        }
        public void set_ShowInfo(bool value)
        {
            this._isDirty = true;
            this._showInfo = value;
        }
        public bool get_EnableSelection()
        {
            if(this._consoleScrollLayoutGroup != 0)
            {
                    return (bool)this._consoleScrollLayoutGroup.EnableSelection;
            }
            
            return (bool)this._consoleScrollLayoutGroup.EnableSelection;
        }
        public void set_EnableSelection(bool value)
        {
            this._consoleScrollLayoutGroup.EnableSelection = value;
        }
        public string get_Filter()
        {
        
        }
        public void set_Filter(string value)
        {
            bool val_1 = System.String.op_Inequality(a:  this._filter, b:  value);
            if(val_1 == true)
            {
                    val_1 = true;
                this._isDirty = val_1;
                this._filter = value;
            }
        
        }
        protected override void Awake()
        {
            UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder> val_5;
            var val_6;
            this.Awake();
            val_5 = null;
            val_5 = new UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder>(object:  445180832, method:  new IntPtr(445152736));
            this._consoleScrollLayoutGroup._selectedItemChanged.AddListener(call:  162353152);
            SRDebugger.Services.IConsoleService val_2 = SRDebugger.Internal.Service.Console;
            SRDebugger.Services.ConsoleUpdatedEventHandler val_3 = new SRDebugger.Services.ConsoleUpdatedEventHandler(object:  445180832, method:  new IntPtr(445155808));
            var val_6 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_4;
            }
            
            var val_5 = 0;
            label_6:
            val_5 = 0;
            if((mem[1179403735] + 0) == null)
            {
                goto label_5;
            }
            
            val_5 = val_5 + 1;
            val_5 = (uint)val_5 & 65535;
            if(val_5 < mem[1179403825])
            {
                goto label_6;
            }
            
            label_4:
            val_6 = 0;
            goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 228);
            label_5:
            var val_4 = mem[1179403735] + 0;
            val_6 = val_6 + (((mem[1179403735] + 0) + 4) << 3);
            val_6 = val_6 + 228;
            goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 228);
        }
        protected override void Start()
        {
            this.Start();
            this._isDirty = true;
            System.Collections.IEnumerator val_1 = this.ScrollToBottom();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  445301024);
        }
        private System.Collections.IEnumerator ScrollToBottom()
        {
            object val_1 = new System.Object();
            typeof(ConsoleLogControl.<ScrollToBottom>d__26).__il2cppRuntimeField_8 = 0;
            typeof(ConsoleLogControl.<ScrollToBottom>d__26).__il2cppRuntimeField_10 = this;
        }
        protected override void OnDestroy()
        {
            var val_5;
            var val_6;
            SRDebugger.Services.IConsoleService val_1 = SRDebugger.Internal.Service.Console;
            if(0 == 0)
            {
                goto label_1;
            }
            
            SRDebugger.Services.IConsoleService val_2 = SRDebugger.Internal.Service.Console;
            SRDebugger.Services.ConsoleUpdatedEventHandler val_3 = new SRDebugger.Services.ConsoleUpdatedEventHandler(object:  445525024, method:  new IntPtr(445155808));
            var val_6 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_3;
            }
            
            var val_5 = 0;
            label_5:
            val_5 = 0;
            if((mem[1179403735] + 0) == null)
            {
                goto label_4;
            }
            
            val_5 = val_5 + 1;
            val_5 = (uint)val_5 & 65535;
            if(val_5 < mem[1179403825])
            {
                goto label_5;
            }
            
            label_3:
            val_6 = 0;
            goto label_6;
            label_4:
            var val_4 = mem[1179403735] + 0;
            val_6 = val_6 + (((mem[1179403735] + 0) + 4) << 3);
            val_6 = val_6 + 236;
            label_6:
            label_1:
            this.OnDestroy();
        }
        private void OnSelectedItemChanged(object arg0)
        {
            var val_1;
            var val_2;
            val_1 = 35632412;
            val_2 = 0;
            if(arg0 != 0)
            {
                    if(((System.Object.__il2cppRuntimeField_typeHierarchy + (SRDebugger.Services.ConsoleEntry.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    arg0 = 0;
            }
            
                val_2 = arg0;
            }
            
            if(this.SelectedItemChanged == 0)
            {
                    return;
            }
            
            this.SelectedItemChanged.Invoke(obj:  0);
        }
        protected override void Update()
        {
            this.Update();
            if(this != 0)
            {
                    UnityEngine.Vector2 val_1 = Value;
                this._consoleScrollRect.normalizedPosition = new UnityEngine.Vector2();
                mem2[0] = 0;
                mem2[0] = 0;
                mem2[0] = 0;
            }
            
            if(this._isDirty == true)
            {
                    this._isDirty = this;
                this.Refresh();
            }
        
        }
        private void Refresh()
        {
            var val_2;
            float val_5;
            float val_6;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            bool val_19;
            var val_20;
            UnityEngine.Vector2 val_1 = normalizedPosition;
            if((SRF.SRFFloatExtensions.ApproxZero(f:  val_1.x)) != false)
            {
                    UnityEngine.Vector2 val_4 = normalizedPosition;
                val_2 = 0;
                System.Nullable<UnityEngine.Vector2> val_7 = new System.Nullable<UnityEngine.Vector2>(value:  new UnityEngine.Vector2() {x = val_5, y = val_6});
            }
            
            this._consoleScrollLayoutGroup.ClearItems();
            SRDebugger.Services.IConsoleService val_8 = SRDebugger.Internal.Service.Console;
            var val_14 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_6;
            }
            
            val_14 = 0;
            label_8:
            val_15 = 0;
            if((mem[1179403735] + 0) == null)
            {
                goto label_7;
            }
            
            val_14 = val_14 + 1;
            val_15 = (uint)val_14 & 65535;
            if(val_15 < mem[1179403825])
            {
                goto label_8;
            }
            
            label_6:
            val_16 = 0;
            goto label_9;
            label_7:
            var val_9 = mem[1179403735] + 0;
            val_14 = val_14 + (((mem[1179403735] + 0) + 4) << 3);
            val_16 = val_14 + 212;
            label_9:
            val_17 = 0;
            goto label_10;
            label_36:
            var val_16 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_12;
            }
            
            var val_15 = 0;
            label_14:
            val_15 = 0;
            if((mem[1179403735] + 0) == null)
            {
                goto label_13;
            }
            
            val_15 = val_15 + 1;
            val_15 = (uint)val_15 & 65535;
            if(val_15 < mem[1179403825])
            {
                goto label_14;
            }
            
            label_12:
            val_18 = 0;
            goto label_15;
            label_13:
            var val_10 = mem[1179403735] + 0;
            val_16 = val_16 + (((mem[1179403735] + 0) + 4) << 3);
            val_18 = val_16 + 196;
            label_15:
            val_14 = 0;
            if(1 > 4)
            {
                goto label_20;
            }
            
            if(1 == 4)
            {
                    1 = 1 & ((mem[1179403735] + 0) << 1);
            }
            
            if(1 == 4)
            {
                    1 = 1 & (1 >> 1);
                1 = 1 & (this >> 1);
                1 = 1 & ((mem[1179403735] + 0) << 1);
            }
            
            if(this._showErrors == false)
            {
                goto label_25;
            }
            
            if(1 == 3)
            {
                goto label_19;
            }
            
            if(1 != 2)
            {
                goto label_20;
            }
            
            val_19 = this._showWarnings;
            goto label_21;
            label_19:
            val_19 = this._showInfo;
            label_21:
            if(val_19 == false)
            {
                goto label_25;
            }
            
            label_20:
            if((System.String.IsNullOrEmpty(value:  this._filter)) == true)
            {
                goto label_23;
            }
            
            val_15 = 0;
            if((val_15.IndexOf(value:  this._filter, comparisonType:  5)) <= 1)
            {
                goto label_25;
            }
            
            label_23:
            this._consoleScrollLayoutGroup.AddItem(item:  0);
            goto label_29;
            label_25:
            if(val_14 == this._consoleScrollLayoutGroup._selectedItem)
            {
                    this._consoleScrollLayoutGroup.SelectedItem = 0;
            }
            
            label_29:
            val_17 = 1;
            label_10:
            var val_17 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_32;
            }
            
            val_14 = 0;
            label_34:
            val_15 = 0;
            if((mem[1179403735] + 0) == null)
            {
                goto label_33;
            }
            
            val_14 = val_14 + 1;
            val_15 = (uint)val_14 & 65535;
            if(val_15 < mem[1179403825])
            {
                goto label_34;
            }
            
            label_32:
            val_20 = 0;
            goto label_35;
            label_33:
            var val_13 = mem[1179403735] + 0;
            val_17 = val_17 + (((mem[1179403735] + 0) + 4) << 3);
            val_20 = val_17 + 188;
            label_35:
            if(val_17 < 0)
            {
                goto label_36;
            }
            
            this._isDirty = false;
        }
        private void SetIsDirty()
        {
            this._isDirty = true;
        }
        private void ConsoleOnUpdated(SRDebugger.Services.IConsoleService console)
        {
            this._isDirty = true;
        }
        public ConsoleLogControl()
        {
            this._showErrors = true;
        }
    
    }

}
