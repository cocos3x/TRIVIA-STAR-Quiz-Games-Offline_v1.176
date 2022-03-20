using UnityEngine;

namespace SRDebugger.Services.Implementation
{
    public class DockConsoleServiceImpl : IDockConsoleService
    {
        // Fields
        private SRDebugger.ConsoleAlignment _alignment;
        private SRDebugger.UI.Other.DockConsoleController _consoleRoot;
        private bool _didSuspendTrigger;
        private bool _isExpanded;
        private bool _isVisible;
        
        // Properties
        public bool IsVisible { get; set; }
        public bool IsExpanded { get; set; }
        public SRDebugger.ConsoleAlignment Alignment { get; set; }
        
        // Methods
        public DockConsoleServiceImpl()
        {
            this._isExpanded = true;
            SRDebugger.Settings val_1 = SRDebugger.Settings.Instance;
            this._alignment = 0;
        }
        public bool get_IsVisible()
        {
            return (bool)this._isVisible;
        }
        public void set_IsVisible(bool value)
        {
            SRDebugger.UI.Other.DockConsoleController val_3;
            bool val_3 = this._isVisible;
            val_3 = val_3 >> 5;
            if(val_3 != value)
            {
                    return;
            }
            
            this._isVisible = value;
            val_3 = this._consoleRoot;
            bool val_1 = UnityEngine.Object.op_Equality(x:  val_3, y:  0);
            if(value != true)
            {
                    UnityEngine.GameObject val_2 = this._consoleRoot.CachedGameObject;
                val_3 = this._consoleRoot;
                val_3.SetActive(value:  value);
            }
            else
            {
                    this.Load();
            }
            
            this.CheckTrigger();
        }
        public bool get_IsExpanded()
        {
            return (bool)this._isExpanded;
        }
        public void set_IsExpanded(bool value)
        {
            SRDebugger.UI.Other.DockConsoleController val_2;
            bool val_2 = this._isExpanded;
            val_2 = val_2 >> 5;
            if(val_2 != value)
            {
                    return;
            }
            
            this._isExpanded = value;
            val_2 = this._consoleRoot;
            bool val_1 = UnityEngine.Object.op_Equality(x:  val_2, y:  0);
            if(value != true)
            {
                    val_2 = this._consoleRoot;
                val_2.SetDropdownVisibility(visible:  value);
            }
            else
            {
                    this.Load();
            }
            
            this.CheckTrigger();
        }
        public SRDebugger.ConsoleAlignment get_Alignment()
        {
        
        }
        public void set_Alignment(SRDebugger.ConsoleAlignment value)
        {
            SRDebugger.UI.Other.DockConsoleController val_2;
            this._alignment = value;
            val_2 = this._consoleRoot;
            if(val_2 != 0)
            {
                    val_2 = this._consoleRoot;
                val_2.SetAlignmentMode(alignment:  value);
            }
            
            this.CheckTrigger();
        }
        private void Load()
        {
            SRDebugger.UI.Other.DockConsoleController val_5;
            var val_6;
            object val_1 = SRF.Service.SRServiceManager.GetService<System.Object>();
            if((public static SRDebugger.Services.IPinnedUIService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.IPinnedUIService>()) == 0)
            {
                goto label_3;
            }
            
            val_5 = 0;
            if(((as. 
               
               
              
            
            
            
            .__il2cppRuntimeField_64 + (SRDebugger.Services.Implementation.PinnedUIServiceImpl.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
            {
                    public static SRDebugger.Services.IPinnedUIService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.IPinnedUIService>() = 0;
            }
            
            val_5 = public static SRDebugger.Services.IPinnedUIService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.IPinnedUIService>();
            if(0 != 0)
            {
                goto label_7;
            }
            
            val_6 = "[DockConsoleService] Expected IPinnedUIService to be PinnedUIServiceImpl";
            goto label_10;
            label_3:
            val_6 = "[DockConsoleService] PinnedUIService not found";
            label_10:
            UnityEngine.Debug.LogError(message:  473565776);
            return;
            label_7:
            SRDebugger.UI.Other.DockConsoleController val_4 = val_5.DockConsoleController;
            this._consoleRoot = val_5;
            if(this._isExpanded == true)
            {
                    this._isExpanded = 1;
            }
            
            val_5.SetDropdownVisibility(visible:  true);
            if(this._isVisible == true)
            {
                    this._isVisible = 1;
            }
            
            this._consoleRoot.IsVisible = true;
            this._consoleRoot.SetAlignmentMode(alignment:  this._alignment);
            this.CheckTrigger();
        }
        private void CheckTrigger()
        {
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            bool val_21;
            SRDebugger.Services.IDebugTriggerService val_1 = SRDebugger.Internal.Service.Trigger;
            var val_10 = 1179403647;
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
            val_10 = val_10 + (((mem[1179403735] + 0) + 4) << 3);
            val_13 = val_10 + 204;
            label_5:
            if(0 > 7)
            {
                goto label_8;
            }
            
            if(67 != 1)
            {
                goto label_7;
            }
            
            if((140 & 1) != 0)
            {
                goto label_8;
            }
            
            val_14 = 1;
            val_15 = 1152921513670484080;
            goto label_9;
            label_7:
            val_14 = 0;
            val_15 = 1152921513670484080;
            label_9:
            System.Nullable<com.adjust.sdk.AdjustLogLevel> val_3 = new System.Nullable<com.adjust.sdk.AdjustLogLevel>(value:  0);
            label_8:
            val_16 = 0;
            if(false != 0)
            {
                    false = this._isVisible;
            }
            
            if(false != false)
            {
                    var val_11;
                System.Int32Enum val_4 = val_3.HasValue.Value;
                val_11 = this._alignment - val_11;
                val_16 = val_11 >> 5;
            }
            
            bool val_12 = this._didSuspendTrigger;
            val_12 = val_12 >> 5;
            val_17 = val_16 | val_12;
            SRDebugger.Services.IDebugTriggerService val_5 = SRDebugger.Internal.Service.Trigger;
            var val_13 = val_12;
            if(val_17 == 0)
            {
                goto label_12;
            }
            
            if(((this._didSuspendTrigger >> 5) + 178) == 0)
            {
                goto label_13;
            }
            
            val_17 = 0;
            label_15:
            val_12 = mem[(this._didSuspendTrigger >> 5) + 88 + 0];
            val_12 = (this._didSuspendTrigger >> 5) + 88 + 0;
            if(val_12 == null)
            {
                goto label_14;
            }
            
            val_17 = val_17 + 1;
            if(((uint)val_17 & 65535) < ((this._didSuspendTrigger >> 5) + 178))
            {
                goto label_15;
            }
            
            label_13:
            val_18 = val_12;
            goto label_16;
            label_12:
            if(((this._didSuspendTrigger >> 5) + 178) == 0)
            {
                goto label_17;
            }
            
            val_12 = 0;
            label_19:
            val_17 = 0;
            if(((this._didSuspendTrigger >> 5) + 88 + 0) == null)
            {
                goto label_18;
            }
            
            val_12 = val_12 + 1;
            val_17 = (uint)val_12 & 65535;
            if(val_17 < ((this._didSuspendTrigger >> 5) + 178))
            {
                goto label_19;
            }
            
            label_17:
            val_19 = val_12;
            goto label_20;
            label_14:
            var val_6 = ((this._didSuspendTrigger >> 5) + 88) + 0;
            val_13 = val_13 + ((((this._didSuspendTrigger >> 5) + 88 + 0) + 4) << 3);
            val_18 = val_13 + 188;
            label_16:
            var val_14 = val_12;
            val_14 = val_16 & val_14;
            if(val_14 != 1)
            {
                    return;
            }
            
            SRDebugger.Services.IDebugTriggerService val_7 = SRDebugger.Internal.Service.Trigger;
            val_12 = 0;
            val_17 = 0;
            val_12 = val_12 + 1;
            val_17 = (uint)val_12 & 65535;
            val_20 = val_14;
            goto label_26;
            label_18:
            var val_8 = ((this._didSuspendTrigger >> 5) + 88) + 0;
            val_13 = val_13 + ((((this._didSuspendTrigger >> 5) + 88 + 0) + 4) << 3);
            val_19 = val_13 + 196;
            label_20:
            val_21 = 0;
            goto label_27;
            label_26:
            val_21 = true;
            label_27:
            this._didSuspendTrigger = val_21;
        }
    
    }

}
