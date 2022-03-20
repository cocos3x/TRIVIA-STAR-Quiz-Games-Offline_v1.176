using UnityEngine;

namespace SRDebugger.UI.Tabs
{
    public class ConsoleTabController : SRMonoBehaviourEx
    {
        // Fields
        private const int MaxLength = 2600;
        private UnityEngine.Canvas _consoleCanvas;
        private bool _isDirty;
        public SRDebugger.UI.Controls.ConsoleLogControl ConsoleLogControl;
        public UnityEngine.UI.Toggle PinToggle;
        public UnityEngine.UI.ScrollRect StackTraceScrollRect;
        public UnityEngine.UI.Text StackTraceText;
        public UnityEngine.UI.Toggle ToggleErrors;
        public UnityEngine.UI.Text ToggleErrorsText;
        public UnityEngine.UI.Toggle ToggleInfo;
        public UnityEngine.UI.Text ToggleInfoText;
        public UnityEngine.UI.Toggle ToggleWarnings;
        public UnityEngine.UI.Text ToggleWarningsText;
        public UnityEngine.UI.Toggle FilterToggle;
        public UnityEngine.UI.InputField FilterField;
        public UnityEngine.GameObject FilterBarContainer;
        
        // Methods
        protected override void Start()
        {
            var val_16;
            var val_17;
            var val_18;
            this.Start();
            object val_1 = this.GetComponent<System.Object>();
            this._consoleCanvas = this;
            UnityEngine.Events.UnityAction<System.Boolean> val_2 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  424622272, method:  new IntPtr(424529664));
            val_16 = 1152921512541539280;
            this.ToggleErrors.onValueChanged.AddListener(call:  162353152);
            UnityEngine.Events.UnityAction<System.Boolean> val_3 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  424622272, method:  new IntPtr(424538880));
            this.ToggleWarnings.onValueChanged.AddListener(call:  162353152);
            UnityEngine.Events.UnityAction<System.Boolean> val_4 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  424622272, method:  new IntPtr(424548096));
            this.ToggleInfo.onValueChanged.AddListener(call:  162353152);
            UnityEngine.Events.UnityAction<System.Boolean> val_5 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  424622272, method:  new IntPtr(424557312));
            this.PinToggle.onValueChanged.AddListener(call:  162353152);
            UnityEngine.Events.UnityAction<System.Boolean> val_6 = new UnityEngine.Events.UnityAction<System.Boolean>(object:  424622272, method:  new IntPtr(424566528));
            this.FilterToggle.onValueChanged.AddListener(call:  162353152);
            if(this.FilterToggle.m_IsOn == true)
            {
                    this.FilterToggle.m_IsOn = 1;
            }
            
            this.FilterBarContainer.SetActive(value:  true);
            UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder> val_7 = new UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder>(object:  424622272, method:  new IntPtr(424583936));
            this.FilterField.m_OnValueChanged.AddListener(call:  162353152);
            System.Action<twelvegigs.storage.JsonDictionary> val_8 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  424622272, method:  new IntPtr(424589056));
            this.ConsoleLogControl.SelectedItemChanged = null;
            SRDebugger.Services.IConsoleService val_9 = SRDebugger.Internal.Service.Console;
            SRDebugger.Services.ConsoleUpdatedEventHandler val_10 = new SRDebugger.Services.ConsoleUpdatedEventHandler(object:  424622272, method:  new IntPtr(424591104));
            var val_16 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_17;
            }
            
            val_16 = 0;
            label_19:
            if((mem[1179403735] + 0) == null)
            {
                goto label_18;
            }
            
            val_16 = val_16 + 1;
            if(((uint)val_16 & 65535) < mem[1179403825])
            {
                goto label_19;
            }
            
            label_17:
            val_17 = 0;
            goto label_20;
            label_18:
            var val_11 = mem[1179403735] + 0;
            val_16 = val_16 + (((mem[1179403735] + 0) + 4) << 3);
            val_17 = val_16 + 228;
            label_20:
            SRDebugger.Services.IDebugPanelService val_12 = SRDebugger.Internal.Service.Panel;
            System.Action<WGDailyChallengeCalendarDayDisplay, System.Boolean> val_13 = new System.Action<WGDailyChallengeCalendarDayDisplay, System.Boolean>(object:  424622272, method:  new IntPtr(424592128));
            var val_17 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_22;
            }
            
            val_16 = 0;
            label_24:
            if((mem[1179403735] + 0) == null)
            {
                goto label_23;
            }
            
            val_16 = val_16 + 1;
            if(((uint)val_16 & 65535) < mem[1179403825])
            {
                goto label_24;
            }
            
            label_22:
            val_18 = 0;
            goto label_25;
            label_23:
            var val_14 = mem[1179403735] + 0;
            val_17 = val_17 + (((mem[1179403735] + 0) + 4) << 3);
            val_18 = val_17 + 220;
            label_25:
            SRDebugger.Settings val_15 = SRDebugger.Settings.Instance;
            if(40 != 0)
            {
                    40 = 1;
            }
            
            this.StackTraceText.supportRichText = true;
            this.PopulateStackTraceArea(entry:  0);
            this.Refresh();
        }
        private void FilterToggleValueChanged(bool isOn)
        {
            if(isOn != false)
            {
                    this.FilterBarContainer.SetActive(value:  true);
                bool val_1 = System.String.op_Inequality(a:  this.ConsoleLogControl._filter, b:  this.FilterField.m_Text);
                if(val_1 == true)
            {
                    val_1 = true;
                this.ConsoleLogControl._isDirty = val_1;
                this.ConsoleLogControl._filter = this.FilterField.m_Text;
            }
            
                return;
            }
            
            bool val_2 = System.String.op_Inequality(a:  this.ConsoleLogControl._filter, b:  null);
            if(val_2 == true)
            {
                    val_2 = true;
                this.ConsoleLogControl._isDirty = val_2;
                this.ConsoleLogControl._filter = 0;
            }
            
            this.FilterBarContainer.SetActive(value:  false);
        }
        private void FilterValueChanged(string filterText)
        {
            if((this.FilterToggle.m_IsOn != false) && ((System.String.IsNullOrEmpty(value:  filterText)) != true))
            {
                    string val_2 = filterText.Trim();
                this.FilterToggle = filterText;
                if(filterText.m_stringLength != 0)
            {
                    if((System.String.op_Inequality(a:  this.ConsoleLogControl._filter, b:  filterText)) == false)
            {
                    return;
            }
            
                this.ConsoleLogControl._isDirty = true;
                this.ConsoleLogControl._filter = filterText;
                return;
            }
            
            }
            
            bool val_4 = System.String.op_Inequality(a:  this.ConsoleLogControl._filter, b:  null);
            if(val_4 == true)
            {
                    val_4 = true;
                this.ConsoleLogControl._isDirty = val_4;
                this.ConsoleLogControl._filter = 0;
            }
        
        }
        private void PanelOnVisibilityChanged(SRDebugger.Services.IDebugPanelService debugPanelService, bool b)
        {
            if(this._consoleCanvas == 0)
            {
                    return;
            }
            
            if(b == true)
            {
                    0 = 1;
            }
            
            if(b == false)
            {
                    0 = 0;
            }
            
            this._consoleCanvas.enabled = false;
        }
        private void PinToggleValueChanged(bool isOn)
        {
            var val_3;
            var val_4;
            SRDebugger.Services.IDockConsoleService val_1 = SRDebugger.Internal.Service.DockConsole;
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
            goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 196);
            label_3:
            var val_2 = mem[1179403735] + 0;
            val_4 = val_4 + (((mem[1179403735] + 0) + 4) << 3);
            val_4 = val_4 + 196;
            goto ((1179403647 + ((mem[1179403735] + 0) + 4) << 3) + 196);
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
            SRDebugger.Services.ConsoleUpdatedEventHandler val_3 = new SRDebugger.Services.ConsoleUpdatedEventHandler(object:  425387072, method:  new IntPtr(424591104));
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
        protected override void OnEnable()
        {
            this.OnEnable();
            this._isDirty = true;
        }
        private void ConsoleLogSelectedItemChanged(object item)
        {
            var val_1;
            var val_2;
            val_1 = 35632538;
            val_2 = 0;
            if(item != 0)
            {
                    if(((System.Object.__il2cppRuntimeField_typeHierarchy + (SRDebugger.Services.ConsoleEntry.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    item = 0;
            }
            
                val_2 = item;
            }
            
            this.PopulateStackTraceArea(entry:  0);
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
        private void PopulateStackTraceArea(SRDebugger.Services.ConsoleEntry entry)
        {
            var val_7;
            var val_8;
            string val_9;
            var val_10;
            val_7 = entry;
            if(val_7 == 0)
            {
                goto label_1;
            }
            
            string val_1 = System.Environment.NewLine;
            if((System.String.IsNullOrEmpty(value:  entry.StackTrace)) != false)
            {
                    val_8 = null;
                val_8 = null;
                SRDebugger.Internal.SRDebugStrings.Current.Console_NoStackTrace
            }
            
            string val_3 = entry.Message + null + mem[SRDebugger.Internal.SRDebugStrings.Current.Console_NoStackTrace];
            val_9 = entry.Message;
            if(entry.Message.m_stringLength >= 2601)
            {
                    string val_4 = val_9.Substring(startIndex:  0, length:  2600);
                val_10 = null;
                val_10 = null;
                string val_5 = val_9 + 1269544832 + 15388672;
                val_9 = val_9;
            }
            
            if(this.StackTraceText != 0)
            {
                goto label_12;
            }
            
            goto label_12;
            label_1:
            label_12:
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  null, y:  null);
            this.StackTraceScrollRect.normalizedPosition = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
        }
        private void Refresh()
        {
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            SRDebugger.Services.IConsoleService val_1 = SRDebugger.Internal.Service.Console;
            var val_12 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_2;
            }
            
            val_12 = 0;
            label_4:
            if((mem[1179403735] + 0) == null)
            {
                goto label_3;
            }
            
            val_12 = val_12 + 1;
            if(((uint)val_12 & 65535) < mem[1179403825])
            {
                goto label_4;
            }
            
            label_2:
            val_13 = 0;
            goto label_5;
            label_3:
            var val_2 = mem[1179403735] + 0;
            val_12 = val_12 + (((mem[1179403735] + 0) + 4) << 3);
            val_13 = val_12 + 204;
            label_5:
            string val_3 = SRDebugger.Internal.SRDebuggerUtil.GetNumberString(value:  0, max:  999, exceedsMaxString:  425984512);
            SRDebugger.Services.IConsoleService val_4 = SRDebugger.Internal.Service.Console;
            var val_13 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_8;
            }
            
            val_12 = 0;
            label_10:
            if((mem[1179403735] + 0) == null)
            {
                goto label_9;
            }
            
            val_12 = val_12 + 1;
            if(((uint)val_12 & 65535) < mem[1179403825])
            {
                goto label_10;
            }
            
            label_8:
            val_14 = 0;
            goto label_11;
            label_9:
            var val_5 = mem[1179403735] + 0;
            val_13 = val_13 + (((mem[1179403735] + 0) + 4) << 3);
            val_14 = val_13 + 196;
            label_11:
            string val_6 = SRDebugger.Internal.SRDebuggerUtil.GetNumberString(value:  0, max:  999, exceedsMaxString:  425984512);
            SRDebugger.Services.IConsoleService val_7 = SRDebugger.Internal.Service.Console;
            var val_14 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_14;
            }
            
            val_12 = 0;
            label_16:
            if((mem[1179403735] + 0) == null)
            {
                goto label_15;
            }
            
            val_12 = val_12 + 1;
            if(((uint)val_12 & 65535) < mem[1179403825])
            {
                goto label_16;
            }
            
            label_14:
            val_15 = 0;
            goto label_17;
            label_15:
            var val_8 = mem[1179403735] + 0;
            val_14 = val_14 + (((mem[1179403735] + 0) + 4) << 3);
            val_15 = val_14 + 188;
            label_17:
            string val_9 = SRDebugger.Internal.SRDebuggerUtil.GetNumberString(value:  0, max:  999, exceedsMaxString:  425984512);
            this.ConsoleLogControl._isDirty = true;
            this.ConsoleLogControl._showErrors = this.ToggleErrors.m_IsOn;
            this.ConsoleLogControl._isDirty = true;
            this.ConsoleLogControl._showWarnings = this.ToggleWarnings.m_IsOn;
            this.ConsoleLogControl._isDirty = true;
            this.ConsoleLogControl._showInfo = this.ToggleInfo.m_IsOn;
            SRDebugger.Services.IDockConsoleService val_10 = SRDebugger.Internal.Service.DockConsole;
            var val_15 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_26;
            }
            
            val_12 = 0;
            label_28:
            if((mem[1179403735] + 0) == null)
            {
                goto label_27;
            }
            
            val_12 = val_12 + 1;
            if(((uint)val_12 & 65535) < mem[1179403825])
            {
                goto label_28;
            }
            
            label_26:
            val_16 = 0;
            goto label_29;
            label_27:
            var val_11 = mem[1179403735] + 0;
            val_15 = val_15 + (((mem[1179403735] + 0) + 4) << 3);
            val_16 = val_15 + 188;
            label_29:
            this.PinToggle.isOn = false;
            this._isDirty = false;
        }
        private void ConsoleOnUpdated(SRDebugger.Services.IConsoleService console)
        {
            this._isDirty = true;
        }
        public void Clear()
        {
            var val_3;
            var val_4;
            SRDebugger.Services.IConsoleService val_1 = SRDebugger.Internal.Service.Console;
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
            val_4 = val_4 + 244;
            label_5:
            this._isDirty = true;
        }
        public ConsoleTabController()
        {
        
        }
        private void <Start>b__16_0(bool isOn)
        {
            this._isDirty = true;
        }
        private void <Start>b__16_1(bool isOn)
        {
            this._isDirty = true;
        }
        private void <Start>b__16_2(bool isOn)
        {
            this._isDirty = true;
        }
    
    }

}
