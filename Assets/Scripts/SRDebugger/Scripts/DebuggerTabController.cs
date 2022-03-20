using UnityEngine;

namespace SRDebugger.Scripts
{
    public class DebuggerTabController : SRMonoBehaviourEx
    {
        // Fields
        private SRDebugger.UI.Other.SRTab _aboutTabInstance;
        private System.Nullable<SRDebugger.DefaultTabs> _activeTab;
        private bool _hasStarted;
        public SRDebugger.UI.Other.SRTab AboutTab;
        public SRDebugger.UI.Other.SRTabController TabController;
        
        // Properties
        public System.Nullable<SRDebugger.DefaultTabs> ActiveTab { get; }
        
        // Methods
        public System.Nullable<SRDebugger.DefaultTabs> get_ActiveTab()
        {
            SRDebugger.Scripts.DebuggerTabController val_7 = 0;
            bool val_1 = System.String.IsNullOrEmpty(value:  R1 + 56 + 40 + 68);
            if(val_1 != false)
            {
                    this = val_7;
                mem[1152921513617869076] = val_7;
                return (System.Nullable<SRDebugger.DefaultTabs>)val_1;
            }
            
            System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(415174656)});
            val_7 = null;
            object val_3 = System.Enum.Parse(enumType:  415174656, value:  R1 + 56 + 40 + 68);
            System.Type val_4 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(415174656)});
            this = 0;
            mem[1152921513617869076] = 0;
            if((System.Enum.IsDefined(enumType:  415174656, value:  415174656)) == false)
            {
                    return (System.Nullable<SRDebugger.DefaultTabs>)val_1;
            }
            
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            this = new System.Nullable<com.adjust.sdk.AdjustLogLevel>(value:  null);
            return (System.Nullable<SRDebugger.DefaultTabs>)this;
        }
        protected override void Start()
        {
            SRDebugger.Scripts.DebuggerTabController val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_26;
            var val_27;
            val_21 = this;
            val_21.Start();
            this._hasStarted = true;
            T[] val_1 = UnityEngine.Resources.LoadAll<System.Object>(path:  421176528);
            val_22 = "SRDebugger/UI/Prefabs/Tabs";
            val_23 = 0;
            System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(415174656)});
            System.String[] val_3 = System.Enum.GetNames(enumType:  415174656);
            goto label_5;
            label_29:
            val_24 = 0;
            if(mem[1952408948] == null)
            {
                goto label_28;
            }
            
             =  + 1;
            if(((uint) & 65535) < 29537)
            {
                goto label_29;
            }
            
            val_26 = 4;
            goto label_30;
            label_28:
            var val_13 = 1952408948 + 0;
            var val_22 = (1952408948 + 0) + 4;
            val_22 = 65793 + (val_22 << 3);
            val_26 = val_22 + 220;
            label_30:
            val_21 = val_21;
            val_22 = val_22;
            if(4 == 0)
            {
                    UnityEngine.RectTransform val_14 = SRInstantiate.Instantiate<UnityEngine.RectTransform>(prefab:  "SRDebugger/UI/Prefabs/Tabs".__il2cppRuntimeField_10);
                mem[1152921513617984328].AddTab(tab:  "SRDebugger/UI/Prefabs/Tabs".__il2cppRuntimeField_10, visibleInSidebar:  true);
            }
            
            val_23 = 1;
            label_5:
            if(mem[1152921513617984324] != 0)
            {
                    UnityEngine.RectTransform val_16 = SRInstantiate.Instantiate<UnityEngine.RectTransform>(prefab:  mem[1152921513617984324]);
                mem[1152921513617984308] = mem[1152921513617984324];
                mem[1152921513617984328].AddTab(tab:  mem[1152921513617984324], visibleInSidebar:  false);
            }
            
            if(mem[1152921513617984316] != false)
            {
                    val_27 = mem[1152921513617984312];
            }
            else
            {
                    SRDebugger.Settings val_17 = SRDebugger.Settings.Instance;
                val_27 = 2621443;
            }
            
            if((this.OpenTab(tab:  2621443)) != false)
            {
                    return;
            }
            
            System.Collections.Generic.IList<SRDebugger.UI.Other.SRTab> val_19 = mem[1152921513617984328].Tabs;
            object val_20 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  mem[1152921513617984328]);
            mem[1152921513617984328].ActiveTab = mem[1152921513617984328];
        }
        public bool OpenTab(SRDebugger.DefaultTabs tab)
        {
            SRDebugger.Scripts.DebuggerTabController val_7;
            SRDebugger.UI.Other.SRTab val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_7 = this;
            if(this._hasStarted != false)
            {
                    UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                System.Collections.Generic.IList<SRDebugger.UI.Other.SRTab> val_1 = this.TabController.Tabs;
                val_8 = 0;
                val_8 = val_8 + 1;
                val_9 = this.TabController;
            }
            else
            {
                    System.Nullable<com.adjust.sdk.AdjustLogLevel> val_2 = new System.Nullable<com.adjust.sdk.AdjustLogLevel>(value:  tab);
                this._activeTab = val_2.HasValue;
                val_10 = 1;
                mem[1152921513618104508] = 0;
                return (bool)val_10;
            }
            
            label_23:
            val_8 = 0;
            val_8 = val_8 + 1;
            val_7 = (uint)val_8 & 65535;
            val_11 = this.TabController;
            if(this.TabController == 0)
            {
                goto label_16;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_12 = this.TabController;
            val_8 = this.TabController;
            if((System.String.op_Equality(a:  this.TabController, b:  415174656)) == false)
            {
                goto label_23;
            }
            
            val_13 = 0;
            this.TabController.ActiveTab = val_8;
            val_14 = 421310824;
            val_15 = 114;
            val_16 = 1;
            val_17 = this.TabController;
            val_18 = 0;
            goto label_25;
            label_16:
            val_14 = 421310824;
            val_15 = 112;
            val_13 = 0;
            val_17 = this.TabController;
            val_18 = 0;
            val_16 = 0;
            label_25:
            if(this.TabController != 0)
            {
                    var val_8 = 0;
                val_8 = 0;
                val_8 = val_8 + 1;
                val_8 = (uint)val_8 & 65535;
                val_19 = this.TabController;
                val_17 = val_17;
            }
            
            if(val_13 != 1)
            {
                    val_10 = val_16 & 0;
                return (bool)val_10;
            }
            
            val_10 = 0;
            return (bool)val_10;
        }
        public void ShowAboutTab()
        {
            if(this._aboutTabInstance == 0)
            {
                    return;
            }
            
            R4 + 56.ActiveTab = R4 + 36;
        }
        public DebuggerTabController()
        {
        
        }
    
    }

}
