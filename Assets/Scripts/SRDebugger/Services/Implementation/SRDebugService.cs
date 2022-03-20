using UnityEngine;

namespace SRDebugger.Services.Implementation
{
    public class SRDebugService : IDebugService
    {
        // Fields
        private readonly SRDebugger.Services.IDebugPanelService _debugPanelService;
        private readonly SRDebugger.Services.IDebugTriggerService _debugTrigger;
        private readonly SRDebugger.Services.ISystemInformationService _informationService;
        private readonly SRDebugger.Services.IOptionsService _optionsService;
        private readonly SRDebugger.Services.IPinnedUIService _pinnedUiService;
        private bool _entryCodeEnabled;
        private bool _hasAuthorised;
        private System.Nullable<SRDebugger.DefaultTabs> _queuedTab;
        private UnityEngine.RectTransform _worldSpaceTransform;
        private SRDebugger.VisibilityChangedDelegate PanelVisibilityChanged;
        
        // Properties
        public SRDebugger.Settings Settings { get; }
        public bool IsDebugPanelVisible { get; }
        public bool IsTriggerEnabled { get; set; }
        public bool IsProfilerDocked { get; set; }
        public SRDebugger.Services.IDockConsoleService DockConsole { get; }
        
        // Methods
        public SRDebugService()
        {
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            bool val_30;
            var val_31;
            SRF.Service.SRServiceManager.RegisterService<System.Object>(service:  479688800);
            object val_1 = SRF.Service.SRServiceManager.GetService<System.Object>();
            object val_2 = SRF.Service.SRServiceManager.GetService<System.Object>();
            this._debugTrigger = public static SRDebugger.Services.IDebugTriggerService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.IDebugTriggerService>();
            object val_3 = SRF.Service.SRServiceManager.GetService<System.Object>();
            this._informationService = public static SRDebugger.Services.ISystemInformationService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.ISystemInformationService>();
            object val_4 = SRF.Service.SRServiceManager.GetService<System.Object>();
            this._pinnedUiService = public static SRDebugger.Services.IPinnedUIService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.IPinnedUIService>();
            object val_5 = SRF.Service.SRServiceManager.GetService<System.Object>();
            this._optionsService = public static SRDebugger.Services.IOptionsService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.IOptionsService>();
            object val_6 = SRF.Service.SRServiceManager.GetService<System.Object>();
            this._debugPanelService = public static SRDebugger.Services.IDebugPanelService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.IDebugPanelService>();
            System.Action<WGDailyChallengeCalendarDayDisplay, System.Boolean> val_7 = new System.Action<WGDailyChallengeCalendarDayDisplay, System.Boolean>(object:  479688800, method:  new IntPtr(479654368));
            val_25 = 0;
            val_25 = val_25 + 1;
            val_26 = public static SRDebugger.Services.IDebugPanelService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.IDebugPanelService>();
            SRDebugger.Settings val_9 = SRDebugger.Settings.Instance;
            if(1 == 0)
            {
                goto label_9;
            }
            
            val_27 = 0;
            SRDebugger.Settings val_10 = SRDebugger.Settings.Instance;
            val_25 = 0;
            if(1 != 1)
            {
                goto label_12;
            }
            
            val_27 = UnityEngine.Application.isMobilePlatform;
            goto label_12;
            label_9:
            val_27 = 1;
            label_12:
            val_25 = 0;
            val_25 = val_25 + 1;
            val_28 = this._debugTrigger;
            SRDebugger.Settings val_13 = SRDebugger.Settings.Instance;
            val_25 = 0;
            val_25 = val_25 + 1;
            val_29 = this._debugTrigger;
            SRDebugger.Settings val_15 = SRDebugger.Settings.Instance;
            if(52 != 0)
            {
                    object val_16 = SRF.Service.SRServiceManager.GetService<System.Object>();
            }
            
            val_30 = 0;
            SRDebugger.Settings val_17 = SRDebugger.Settings.Instance;
            if(0 == 0)
            {
                goto label_29;
            }
            
            SRDebugger.Settings val_18 = SRDebugger.Settings.Instance;
            System.Collections.Generic.IList<System.Int32> val_19 = 0.EntryCode;
            var val_24 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_32;
            }
            
            val_25 = 0;
            label_34:
            if((mem[1179403735] + 0) == null)
            {
                goto label_33;
            }
            
            val_25 = val_25 + 1;
            if(((uint)val_25 & 65535) < mem[1179403825])
            {
                goto label_34;
            }
            
            label_32:
            val_31 = 0;
            goto label_35;
            label_33:
            var val_20 = mem[1179403735] + 0;
            val_24 = val_24 + (((mem[1179403735] + 0) + 4) << 3);
            val_31 = val_24 + 188;
            label_35:
            val_30 = false;
            label_29:
            this._entryCodeEnabled = val_30;
            SRDebugger.Settings val_21 = SRDebugger.Settings.Instance;
            if((0 != 0) && (this._entryCodeEnabled != true))
            {
                    UnityEngine.Debug.LogError(message:  479664608);
            }
            
            UnityEngine.Transform val_22 = SRF.Hierarchy.Get(key:  466780208);
            UnityEngine.GameObject val_23 = gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  466780208);
        }
        public SRDebugger.Settings get_Settings()
        {
            return SRDebugger.Settings.Instance;
        }
        public bool get_IsDebugPanelVisible()
        {
            var val_1;
            var val_1 = 0;
            val_1 = val_1 + 1;
            val_1 = this._debugPanelService;
            goto mem[(1152921505026068480 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public bool get_IsTriggerEnabled()
        {
            var val_1;
            var val_1 = 0;
            val_1 = val_1 + 1;
            val_1 = this._debugTrigger;
            goto mem[(1152921505026174976 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public void set_IsTriggerEnabled(bool value)
        {
            var val_2;
            var val_3;
            var val_2 = 0;
            val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = (uint)val_2 & 65535;
            val_3 = this._debugTrigger;
            goto mem[(1152921505026174976 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public bool get_IsProfilerDocked()
        {
            bool val_2;
            var val_3;
            val_2 = static_value_021FC42F;
            if(val_2 != true)
            {
                    val_2 = true;
            }
            
            SRDebugger.Services.IPinnedUIService val_1 = SRDebugger.Internal.Service.PinnedUI;
            if(1507 == 0)
            {
                goto label_2;
            }
            
            var val_3 = 0;
            label_4:
            if(793910273 == null)
            {
                goto label_3;
            }
            
            val_3 = val_3 + 1;
            if(((uint)val_3 & 65535) < 1507)
            {
                goto label_4;
            }
            
            label_2:
            val_3 = val_2;
            goto ((21384261 + ((15449083 + 0) + 4) << 3) + 204);
            label_3:
            var val_2 = 15449083 + 0;
            var val_4 = (15449083 + 0) + 4;
            val_4 = 21384261 + (val_4 << 3);
            val_3 = val_4 + 204;
            goto ((21384261 + ((15449083 + 0) + 4) << 3) + 204);
        }
        public void set_IsProfilerDocked(bool value)
        {
            bool val_2;
            var val_3;
            var val_4;
            val_2 = static_value_021FC430;
            if(val_2 != true)
            {
                    val_2 = true;
            }
            
            SRDebugger.Services.IPinnedUIService val_1 = SRDebugger.Internal.Service.PinnedUI;
            var val_4 = 21384261;
            if(1507 == 0)
            {
                goto label_2;
            }
            
            var val_3 = 0;
            label_4:
            val_3 = 0;
            if(793910273 == null)
            {
                goto label_3;
            }
            
            val_3 = val_3 + 1;
            val_3 = (uint)val_3 & 65535;
            if(val_3 < 1507)
            {
                goto label_4;
            }
            
            label_2:
            val_4 = val_2;
            goto ((21384261 + ((15449083 + 0) + 4) << 3) + 212);
            label_3:
            var val_2 = 15449083 + 0;
            val_4 = val_4 + (((15449083 + 0) + 4) << 3);
            val_4 = val_4 + 212;
            goto ((21384261 + ((15449083 + 0) + 4) << 3) + 212);
        }
        public void AddSystemInfo(SRDebugger.InfoEntry entry, string category = "Default")
        {
            var val_2;
            var val_3;
            var val_2 = 0;
            val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = (uint)val_2 & 65535;
            val_3 = this._informationService;
            goto mem[(1152921505026600960 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public void ShowDebugPanel(bool requireEntryCode = True)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            val_2 = this;
            val_3 = 35636274;
            if(requireEntryCode == true)
            {
                    true = this._entryCodeEnabled;
            }
            
            if(true == true)
            {
                goto label_1;
            }
            
            label_7:
            var val_1 = 0;
            val_4 = 0;
            val_1 = val_1 + 1;
            val_4 = (uint)val_1 & 65535;
            val_5 = this._debugPanelService;
            goto mem[(1152921505026068480 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
            label_1:
            if((R4 + 29) != 0)
            {
                goto label_7;
            }
            
            R4.PromptEntryCode();
        }
        public void ShowDebugPanel(SRDebugger.DefaultTabs tab, bool requireEntryCode = True)
        {
            var val_7;
            var val_8;
            var val_9;
            SRDebugger.Services.IDebugPanelService val_10;
            var val_11;
            var val_12;
            var val_13;
            val_7 = this;
            val_8 = requireEntryCode;
            val_9 = tab;
            if(val_8 == true)
            {
                    true = this._entryCodeEnabled;
            }
            
            if(true == true)
            {
                goto label_1;
            }
            
            label_12:
            val_10 = this._debugPanelService;
            var val_5 = 0;
            val_11 = 0;
            val_5 = val_5 + 1;
            val_11 = (uint)val_5 & 65535;
            val_12 = val_10;
            val_11 = 0;
            val_10 = 0;
            val_11 = val_11 + 1;
            val_10 = (uint)val_11 & 65535;
            val_13 = this._debugPanelService;
            goto mem[(1152921505026068480 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
            label_1:
            if((SL + 29) != 0)
            {
                goto label_12;
            }
            
            1152921513677544192 = new System.Nullable<com.adjust.sdk.AdjustLogLevel>(value:  R8);
            mem2[0] = 0;
            mem2[0] = 0;
            SL.PromptEntryCode();
            var val_4 = FP - 28;
        }
        public void HideDebugPanel()
        {
            var val_1;
            var val_1 = 0;
            val_1 = val_1 + 1;
            val_1 = this._debugPanelService;
            goto mem[(1152921505026068480 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public void DestroyDebugPanel()
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            val_3 = 0;
            val_4 = 0;
            val_3 = val_3 + 1;
            val_4 = (uint)val_3 & 65535;
            val_5 = this._debugPanelService;
            val_4 = 0;
            val_3 = 0;
            val_4 = val_4 + 1;
            val_3 = (uint)val_4 & 65535;
            val_6 = this._debugPanelService;
            goto mem[(1152921505026068480 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public void AddOptionContainer(object container)
        {
            var val_2;
            var val_3;
            var val_2 = 0;
            val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = (uint)val_2 & 65535;
            val_3 = this._optionsService;
            goto mem[(1152921505026281472 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public void RemoveOptionContainer(object container)
        {
            var val_2;
            var val_3;
            var val_2 = 0;
            val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = (uint)val_2 & 65535;
            val_3 = this._optionsService;
            goto mem[(1152921505026281472 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public void PinAllOptions(string category)
        {
            string val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_10 = category;
            var val_9 = mem[1152921513678189940];
            if((mem[1152921513678189940] + 178) == 0)
            {
                goto label_2;
            }
            
            val_11 = 0;
            label_4:
            val_12 = 0;
            if((mem[1152921513678189940] + 88 + 0) == null)
            {
                goto label_3;
            }
            
            val_11 = val_11 + 1;
            val_12 = (uint)val_11 & 65535;
            if(val_12 < (mem[1152921513678189940] + 178))
            {
                goto label_4;
            }
            
            label_2:
            val_13 = mem[1152921513678189940];
            goto label_5;
            label_3:
            var val_1 = (mem[1152921513678189940] + 88) + 0;
            val_9 = val_9 + (((mem[1152921513678189940] + 88 + 0) + 4) << 3);
            val_13 = val_9 + 220;
            label_5:
            var val_10 = mem[1152921513678189940];
            if((mem[1152921513678189940] + 178) == 0)
            {
                goto label_7;
            }
            
            val_11 = 0;
            label_9:
            val_12 = 0;
            if((mem[1152921513678189940] + 88 + 0) == null)
            {
                goto label_8;
            }
            
            val_11 = val_11 + 1;
            val_12 = (uint)val_11 & 65535;
            if(val_12 < (mem[1152921513678189940] + 178))
            {
                goto label_9;
            }
            
            label_7:
            val_14 = mem[1152921513678189940];
            goto label_10;
            label_8:
            var val_2 = (mem[1152921513678189940] + 88) + 0;
            val_10 = val_10 + (((mem[1152921513678189940] + 88 + 0) + 4) << 3);
            val_14 = val_10 + 188;
            label_10:
            val_15 = mem[1152921513678189940];
            label_29:
            var val_11 = val_15;
            if((mem[1152921513678189940] + 178) == 0)
            {
                goto label_12;
            }
            
            val_11 = 0;
            label_14:
            val_12 = mem[mem[1152921513678189940] + 88 + 0];
            val_12 = mem[1152921513678189940] + 88 + 0;
            if(val_12 == null)
            {
                goto label_13;
            }
            
            val_11 = val_11 + 1;
            val_12 = (uint)val_11 & 65535;
            if(val_12 < (mem[1152921513678189940] + 178))
            {
                goto label_14;
            }
            
            label_12:
            val_16 = val_15;
            goto label_15;
            label_13:
            var val_3 = (mem[1152921513678189940] + 88) + 0;
            val_11 = val_11 + (((mem[1152921513678189940] + 88 + 0) + 4) << 3);
            val_16 = val_11 + 188;
            label_15:
            if(val_15 == 0)
            {
                goto label_16;
            }
            
            var val_13 = val_15;
            if((mem[1152921513678189940] + 178) == 0)
            {
                goto label_18;
            }
            
            var val_12 = 0;
            label_20:
            if((mem[1152921513678189940] + 88 + 0) == null)
            {
                goto label_19;
            }
            
            val_12 = val_12 + 1;
            if(((uint)val_12 & 65535) < (mem[1152921513678189940] + 178))
            {
                goto label_20;
            }
            
            label_18:
            val_17 = val_15;
            goto label_21;
            label_19:
            var val_4 = (mem[1152921513678189940] + 88) + 0;
            val_13 = val_13 + (((mem[1152921513678189940] + 88 + 0) + 4) << 3);
            val_17 = val_13 + 188;
            label_21:
            if((System.String.op_Equality(a:  mem[1152921513678189940] + 12, b:  val_10)) == false)
            {
                goto label_29;
            }
            
            var val_15 = mem[1152921513678189944];
            if((mem[1152921513678189944] + 178) == 0)
            {
                goto label_25;
            }
            
            var val_14 = 0;
            label_27:
            if((mem[1152921513678189944] + 88 + 0) == null)
            {
                goto label_26;
            }
            
            val_14 = val_14 + 1;
            if(((uint)val_14 & 65535) < (mem[1152921513678189944] + 178))
            {
                goto label_27;
            }
            
            label_25:
            val_18 = mem[1152921513678189944];
            goto label_29;
            label_26:
            var val_6 = (mem[1152921513678189944] + 88) + 0;
            val_15 = val_15 + (((mem[1152921513678189944] + 88 + 0) + 4) << 3);
            val_18 = val_15 + 220;
            goto label_29;
            label_16:
            if(val_15 == 0)
            {
                goto label_30;
            }
            
            var val_16 = val_15;
            if((mem[1152921513678189940] + 178) == 0)
            {
                goto label_31;
            }
            
            val_11 = 0;
            label_33:
            val_12 = 0;
            if((mem[1152921513678189940] + 88 + 0) == null)
            {
                goto label_32;
            }
            
            val_11 = val_11 + 1;
            val_12 = (uint)val_11 & 65535;
            if(val_12 < (mem[1152921513678189940] + 178))
            {
                goto label_33;
            }
            
            label_31:
            val_19 = val_15;
            goto label_34;
            label_32:
            var val_7 = (mem[1152921513678189940] + 88) + 0;
            val_16 = val_16 + (((mem[1152921513678189940] + 88 + 0) + 4) << 3);
            val_19 = val_16 + 188;
            label_34:
            label_30:
            var val_8 = FP - 28;
        }
        public void UnpinAllOptions(string category)
        {
            string val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_10 = category;
            var val_9 = mem[1152921513678310132];
            if((mem[1152921513678310132] + 178) == 0)
            {
                goto label_2;
            }
            
            val_11 = 0;
            label_4:
            val_12 = 0;
            if((mem[1152921513678310132] + 88 + 0) == null)
            {
                goto label_3;
            }
            
            val_11 = val_11 + 1;
            val_12 = (uint)val_11 & 65535;
            if(val_12 < (mem[1152921513678310132] + 178))
            {
                goto label_4;
            }
            
            label_2:
            val_13 = mem[1152921513678310132];
            goto label_5;
            label_3:
            var val_1 = (mem[1152921513678310132] + 88) + 0;
            val_9 = val_9 + (((mem[1152921513678310132] + 88 + 0) + 4) << 3);
            val_13 = val_9 + 220;
            label_5:
            var val_10 = mem[1152921513678310132];
            if((mem[1152921513678310132] + 178) == 0)
            {
                goto label_7;
            }
            
            val_11 = 0;
            label_9:
            val_12 = 0;
            if((mem[1152921513678310132] + 88 + 0) == null)
            {
                goto label_8;
            }
            
            val_11 = val_11 + 1;
            val_12 = (uint)val_11 & 65535;
            if(val_12 < (mem[1152921513678310132] + 178))
            {
                goto label_9;
            }
            
            label_7:
            val_14 = mem[1152921513678310132];
            goto label_10;
            label_8:
            var val_2 = (mem[1152921513678310132] + 88) + 0;
            val_10 = val_10 + (((mem[1152921513678310132] + 88 + 0) + 4) << 3);
            val_14 = val_10 + 188;
            label_10:
            val_15 = mem[1152921513678310132];
            label_29:
            var val_11 = val_15;
            if((mem[1152921513678310132] + 178) == 0)
            {
                goto label_12;
            }
            
            val_11 = 0;
            label_14:
            val_12 = mem[mem[1152921513678310132] + 88 + 0];
            val_12 = mem[1152921513678310132] + 88 + 0;
            if(val_12 == null)
            {
                goto label_13;
            }
            
            val_11 = val_11 + 1;
            val_12 = (uint)val_11 & 65535;
            if(val_12 < (mem[1152921513678310132] + 178))
            {
                goto label_14;
            }
            
            label_12:
            val_16 = val_15;
            goto label_15;
            label_13:
            var val_3 = (mem[1152921513678310132] + 88) + 0;
            val_11 = val_11 + (((mem[1152921513678310132] + 88 + 0) + 4) << 3);
            val_16 = val_11 + 188;
            label_15:
            if(val_15 == 0)
            {
                goto label_16;
            }
            
            var val_13 = val_15;
            if((mem[1152921513678310132] + 178) == 0)
            {
                goto label_18;
            }
            
            var val_12 = 0;
            label_20:
            if((mem[1152921513678310132] + 88 + 0) == null)
            {
                goto label_19;
            }
            
            val_12 = val_12 + 1;
            if(((uint)val_12 & 65535) < (mem[1152921513678310132] + 178))
            {
                goto label_20;
            }
            
            label_18:
            val_17 = val_15;
            goto label_21;
            label_19:
            var val_4 = (mem[1152921513678310132] + 88) + 0;
            val_13 = val_13 + (((mem[1152921513678310132] + 88 + 0) + 4) << 3);
            val_17 = val_13 + 188;
            label_21:
            if((System.String.op_Equality(a:  mem[1152921513678310132] + 12, b:  val_10)) == false)
            {
                goto label_29;
            }
            
            var val_15 = mem[1152921513678310136];
            if((mem[1152921513678310136] + 178) == 0)
            {
                goto label_25;
            }
            
            var val_14 = 0;
            label_27:
            if((mem[1152921513678310136] + 88 + 0) == null)
            {
                goto label_26;
            }
            
            val_14 = val_14 + 1;
            if(((uint)val_14 & 65535) < (mem[1152921513678310136] + 178))
            {
                goto label_27;
            }
            
            label_25:
            val_18 = mem[1152921513678310136];
            goto label_29;
            label_26:
            var val_6 = (mem[1152921513678310136] + 88) + 0;
            val_15 = val_15 + (((mem[1152921513678310136] + 88 + 0) + 4) << 3);
            val_18 = val_15 + 228;
            goto label_29;
            label_16:
            if(val_15 == 0)
            {
                goto label_30;
            }
            
            var val_16 = val_15;
            if((mem[1152921513678310132] + 178) == 0)
            {
                goto label_31;
            }
            
            val_11 = 0;
            label_33:
            val_12 = 0;
            if((mem[1152921513678310132] + 88 + 0) == null)
            {
                goto label_32;
            }
            
            val_11 = val_11 + 1;
            val_12 = (uint)val_11 & 65535;
            if(val_12 < (mem[1152921513678310132] + 178))
            {
                goto label_33;
            }
            
            label_31:
            val_19 = val_15;
            goto label_34;
            label_32:
            var val_7 = (mem[1152921513678310132] + 88) + 0;
            val_16 = val_16 + (((mem[1152921513678310132] + 88 + 0) + 4) << 3);
            val_19 = val_16 + 188;
            label_34:
            label_30:
            var val_8 = FP - 28;
        }
        public void PinOption(string name)
        {
            string val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_10 = name;
            var val_9 = mem[1152921513678430324];
            if((mem[1152921513678430324] + 178) == 0)
            {
                goto label_2;
            }
            
            val_11 = 0;
            label_4:
            val_12 = 0;
            if((mem[1152921513678430324] + 88 + 0) == null)
            {
                goto label_3;
            }
            
            val_11 = val_11 + 1;
            val_12 = (uint)val_11 & 65535;
            if(val_12 < (mem[1152921513678430324] + 178))
            {
                goto label_4;
            }
            
            label_2:
            val_13 = mem[1152921513678430324];
            goto label_5;
            label_3:
            var val_1 = (mem[1152921513678430324] + 88) + 0;
            val_9 = val_9 + (((mem[1152921513678430324] + 88 + 0) + 4) << 3);
            val_13 = val_9 + 220;
            label_5:
            var val_10 = mem[1152921513678430324];
            if((mem[1152921513678430324] + 178) == 0)
            {
                goto label_7;
            }
            
            val_11 = 0;
            label_9:
            val_12 = 0;
            if((mem[1152921513678430324] + 88 + 0) == null)
            {
                goto label_8;
            }
            
            val_11 = val_11 + 1;
            val_12 = (uint)val_11 & 65535;
            if(val_12 < (mem[1152921513678430324] + 178))
            {
                goto label_9;
            }
            
            label_7:
            val_14 = mem[1152921513678430324];
            goto label_10;
            label_8:
            var val_2 = (mem[1152921513678430324] + 88) + 0;
            val_10 = val_10 + (((mem[1152921513678430324] + 88 + 0) + 4) << 3);
            val_14 = val_10 + 188;
            label_10:
            val_15 = mem[1152921513678430324];
            label_29:
            var val_11 = val_15;
            if((mem[1152921513678430324] + 178) == 0)
            {
                goto label_12;
            }
            
            val_11 = 0;
            label_14:
            val_12 = mem[mem[1152921513678430324] + 88 + 0];
            val_12 = mem[1152921513678430324] + 88 + 0;
            if(val_12 == null)
            {
                goto label_13;
            }
            
            val_11 = val_11 + 1;
            val_12 = (uint)val_11 & 65535;
            if(val_12 < (mem[1152921513678430324] + 178))
            {
                goto label_14;
            }
            
            label_12:
            val_16 = val_15;
            goto label_15;
            label_13:
            var val_3 = (mem[1152921513678430324] + 88) + 0;
            val_11 = val_11 + (((mem[1152921513678430324] + 88 + 0) + 4) << 3);
            val_16 = val_11 + 188;
            label_15:
            if(val_15 == 0)
            {
                goto label_16;
            }
            
            var val_13 = val_15;
            if((mem[1152921513678430324] + 178) == 0)
            {
                goto label_18;
            }
            
            var val_12 = 0;
            label_20:
            if((mem[1152921513678430324] + 88 + 0) == null)
            {
                goto label_19;
            }
            
            val_12 = val_12 + 1;
            if(((uint)val_12 & 65535) < (mem[1152921513678430324] + 178))
            {
                goto label_20;
            }
            
            label_18:
            val_17 = val_15;
            goto label_21;
            label_19:
            var val_4 = (mem[1152921513678430324] + 88) + 0;
            val_13 = val_13 + (((mem[1152921513678430324] + 88 + 0) + 4) << 3);
            val_17 = val_13 + 188;
            label_21:
            if((System.String.op_Equality(a:  mem[1152921513678430324] + 8, b:  val_10)) == false)
            {
                goto label_29;
            }
            
            var val_15 = mem[1152921513678430328];
            if((mem[1152921513678430328] + 178) == 0)
            {
                goto label_25;
            }
            
            var val_14 = 0;
            label_27:
            if((mem[1152921513678430328] + 88 + 0) == null)
            {
                goto label_26;
            }
            
            val_14 = val_14 + 1;
            if(((uint)val_14 & 65535) < (mem[1152921513678430328] + 178))
            {
                goto label_27;
            }
            
            label_25:
            val_18 = mem[1152921513678430328];
            goto label_29;
            label_26:
            var val_6 = (mem[1152921513678430328] + 88) + 0;
            val_15 = val_15 + (((mem[1152921513678430328] + 88 + 0) + 4) << 3);
            val_18 = val_15 + 220;
            goto label_29;
            label_16:
            if(val_15 == 0)
            {
                goto label_30;
            }
            
            var val_16 = val_15;
            if((mem[1152921513678430324] + 178) == 0)
            {
                goto label_31;
            }
            
            val_11 = 0;
            label_33:
            val_12 = 0;
            if((mem[1152921513678430324] + 88 + 0) == null)
            {
                goto label_32;
            }
            
            val_11 = val_11 + 1;
            val_12 = (uint)val_11 & 65535;
            if(val_12 < (mem[1152921513678430324] + 178))
            {
                goto label_33;
            }
            
            label_31:
            val_19 = val_15;
            goto label_34;
            label_32:
            var val_7 = (mem[1152921513678430324] + 88) + 0;
            val_16 = val_16 + (((mem[1152921513678430324] + 88 + 0) + 4) << 3);
            val_19 = val_16 + 188;
            label_34:
            label_30:
            var val_8 = FP - 28;
        }
        public void UnpinOption(string name)
        {
            string val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_10 = name;
            var val_9 = mem[1152921513678550516];
            if((mem[1152921513678550516] + 178) == 0)
            {
                goto label_2;
            }
            
            val_11 = 0;
            label_4:
            val_12 = 0;
            if((mem[1152921513678550516] + 88 + 0) == null)
            {
                goto label_3;
            }
            
            val_11 = val_11 + 1;
            val_12 = (uint)val_11 & 65535;
            if(val_12 < (mem[1152921513678550516] + 178))
            {
                goto label_4;
            }
            
            label_2:
            val_13 = mem[1152921513678550516];
            goto label_5;
            label_3:
            var val_1 = (mem[1152921513678550516] + 88) + 0;
            val_9 = val_9 + (((mem[1152921513678550516] + 88 + 0) + 4) << 3);
            val_13 = val_9 + 220;
            label_5:
            var val_10 = mem[1152921513678550516];
            if((mem[1152921513678550516] + 178) == 0)
            {
                goto label_7;
            }
            
            val_11 = 0;
            label_9:
            val_12 = 0;
            if((mem[1152921513678550516] + 88 + 0) == null)
            {
                goto label_8;
            }
            
            val_11 = val_11 + 1;
            val_12 = (uint)val_11 & 65535;
            if(val_12 < (mem[1152921513678550516] + 178))
            {
                goto label_9;
            }
            
            label_7:
            val_14 = mem[1152921513678550516];
            goto label_10;
            label_8:
            var val_2 = (mem[1152921513678550516] + 88) + 0;
            val_10 = val_10 + (((mem[1152921513678550516] + 88 + 0) + 4) << 3);
            val_14 = val_10 + 188;
            label_10:
            val_15 = mem[1152921513678550516];
            label_29:
            var val_11 = val_15;
            if((mem[1152921513678550516] + 178) == 0)
            {
                goto label_12;
            }
            
            val_11 = 0;
            label_14:
            val_12 = mem[mem[1152921513678550516] + 88 + 0];
            val_12 = mem[1152921513678550516] + 88 + 0;
            if(val_12 == null)
            {
                goto label_13;
            }
            
            val_11 = val_11 + 1;
            val_12 = (uint)val_11 & 65535;
            if(val_12 < (mem[1152921513678550516] + 178))
            {
                goto label_14;
            }
            
            label_12:
            val_16 = val_15;
            goto label_15;
            label_13:
            var val_3 = (mem[1152921513678550516] + 88) + 0;
            val_11 = val_11 + (((mem[1152921513678550516] + 88 + 0) + 4) << 3);
            val_16 = val_11 + 188;
            label_15:
            if(val_15 == 0)
            {
                goto label_16;
            }
            
            var val_13 = val_15;
            if((mem[1152921513678550516] + 178) == 0)
            {
                goto label_18;
            }
            
            var val_12 = 0;
            label_20:
            if((mem[1152921513678550516] + 88 + 0) == null)
            {
                goto label_19;
            }
            
            val_12 = val_12 + 1;
            if(((uint)val_12 & 65535) < (mem[1152921513678550516] + 178))
            {
                goto label_20;
            }
            
            label_18:
            val_17 = val_15;
            goto label_21;
            label_19:
            var val_4 = (mem[1152921513678550516] + 88) + 0;
            val_13 = val_13 + (((mem[1152921513678550516] + 88 + 0) + 4) << 3);
            val_17 = val_13 + 188;
            label_21:
            if((System.String.op_Equality(a:  mem[1152921513678550516] + 8, b:  val_10)) == false)
            {
                goto label_29;
            }
            
            var val_15 = mem[1152921513678550520];
            if((mem[1152921513678550520] + 178) == 0)
            {
                goto label_25;
            }
            
            var val_14 = 0;
            label_27:
            if((mem[1152921513678550520] + 88 + 0) == null)
            {
                goto label_26;
            }
            
            val_14 = val_14 + 1;
            if(((uint)val_14 & 65535) < (mem[1152921513678550520] + 178))
            {
                goto label_27;
            }
            
            label_25:
            val_18 = mem[1152921513678550520];
            goto label_29;
            label_26:
            var val_6 = (mem[1152921513678550520] + 88) + 0;
            val_15 = val_15 + (((mem[1152921513678550520] + 88 + 0) + 4) << 3);
            val_18 = val_15 + 228;
            goto label_29;
            label_16:
            if(val_15 == 0)
            {
                goto label_30;
            }
            
            var val_16 = val_15;
            if((mem[1152921513678550516] + 178) == 0)
            {
                goto label_31;
            }
            
            val_11 = 0;
            label_33:
            val_12 = 0;
            if((mem[1152921513678550516] + 88 + 0) == null)
            {
                goto label_32;
            }
            
            val_11 = val_11 + 1;
            val_12 = (uint)val_11 & 65535;
            if(val_12 < (mem[1152921513678550516] + 178))
            {
                goto label_33;
            }
            
            label_31:
            val_19 = val_15;
            goto label_34;
            label_32:
            var val_7 = (mem[1152921513678550516] + 88) + 0;
            val_16 = val_16 + (((mem[1152921513678550516] + 88 + 0) + 4) << 3);
            val_19 = val_16 + 188;
            label_34:
            label_30:
            var val_8 = FP - 28;
        }
        public void ClearPinnedOptions()
        {
            var val_1;
            var val_1 = 0;
            val_1 = val_1 + 1;
            val_1 = this._pinnedUiService;
            goto mem[(1152921505026441216 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public void ShowBugReportSheet(SRDebugger.ActionCompleteCallback onComplete, bool takeScreenshot = True, string descriptionContent)
        {
            typeof(SRDebugService.<>c__DisplayClass32_0).__il2cppRuntimeField_8 = onComplete;
            object val_2 = SRF.Service.SRServiceManager.GetService<System.Object>();
            typeof(SRDebugger.Services.BugReportCompleteCallback).__il2cppRuntimeField_8 = System.Void SRDebugService.<>c__DisplayClass32_0::<ShowBugReportSheet>b__0(bool succeed, string message);
            typeof(SRDebugger.Services.BugReportCompleteCallback).__il2cppRuntimeField_10 = new System.Object();
            typeof(SRDebugger.Services.BugReportCompleteCallback).__il2cppRuntimeField_14 = System.Void SRDebugService.<>c__DisplayClass32_0::<ShowBugReportSheet>b__0(bool succeed, string message);
            ShowBugReporter(callback:  418848768, takeScreenshotFirst:  takeScreenshot, descriptionText:  descriptionContent);
        }
        public SRDebugger.Services.IDockConsoleService get_DockConsole()
        {
            return SRDebugger.Internal.Service.DockConsole;
        }
        public void add_PanelVisibilityChanged(SRDebugger.VisibilityChangedDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this.PanelVisibilityChanged, b:  value);
            if(this.PanelVisibilityChanged == 0)
            {
                goto label_1;
            }
            
            val_2 = this.PanelVisibilityChanged;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.PanelVisibilityChanged != 1152921513679037452)
            {
                goto label_3;
            }
        
        }
        public void remove_PanelVisibilityChanged(SRDebugger.VisibilityChangedDelegate value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this.PanelVisibilityChanged, value:  value);
            if(this.PanelVisibilityChanged == 0)
            {
                goto label_1;
            }
            
            val_2 = this.PanelVisibilityChanged;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.PanelVisibilityChanged != 1152921513679165836)
            {
                goto label_3;
            }
        
        }
        private void DebugPanelServiceOnVisibilityChanged(SRDebugger.Services.IDebugPanelService debugPanelService, bool b)
        {
            if(this.PanelVisibilityChanged == 0)
            {
                    return;
            }
            
            this.PanelVisibilityChanged.Invoke(isVisible:  b);
        }
        private void PromptEntryCode()
        {
            var val_7;
            var val_8;
            var val_9;
            val_7 = this;
            object val_1 = SRF.Service.SRServiceManager.GetService<System.Object>();
            SRDebugger.Settings val_2 = SRDebugger.Settings.Instance;
            System.Collections.Generic.IList<System.Int32> val_3 = 0.EntryCode;
            val_8 = null;
            val_8 = null;
            SRDebugger.Services.PinEntryCompleteCallback val_4 = new SRDebugger.Services.PinEntryCompleteCallback(object:  482634848, method:  new IntPtr(482609824));
            val_7 = 0;
            val_7 = val_7 + 1;
            val_9 = public static SRDebugger.Services.IPinEntryService SRF.Service.SRServiceManager::GetService<SRDebugger.Services.IPinEntryService>();
        }
        public UnityEngine.RectTransform EnableWorldSpaceMode()
        {
            UnityEngine.RectTransform val_10;
            var val_11;
            if(this._worldSpaceTransform != 0)
            {
                    val_10 = this._worldSpaceTransform;
                return;
            }
            
            SRDebugger.Settings val_2 = SRDebugger.Settings.Instance;
            if(52 == 0)
            {
                    var val_10 = 0;
                val_10 = val_10 + 1;
                val_11 = this._debugPanelService;
                UnityEngine.GameObject val_4 = gameObject;
                SRF.SRFGameObjectExtensions.RemoveComponentIfExists<UnityEngine.UI.CanvasScaler>(obj:  482739232);
                UnityEngine.GameObject val_5 = gameObject;
                SRF.SRFGameObjectExtensions.RemoveComponentIfExists<UnityEngine.UI.CanvasScaler>(obj:  482739232);
                renderMode = 2;
                object val_6 = GetComponent<System.Object>();
                val_10 = public System.Void System.Diagnostics.DebuggerTypeProxyAttribute::.ctor(System.Type type);
                UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  null, y:  null);
                sizeDelta = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
                position = new UnityEngine.Vector3();
                this._worldSpaceTransform = val_10;
                return;
            }
            
            System.InvalidOperationException val_9 = new System.InvalidOperationException(message:  482742304);
        }
        private void <PromptEntryCode>b__39_0(bool entered)
        {
            System.Nullable<SRDebugger.DefaultTabs> val_3;
            if(entered == false)
            {
                goto label_1;
            }
            
            SRDebugger.Settings val_1 = SRDebugger.Settings.Instance;
            val_3 = this._queuedTab;
            if(true == 0)
            {
                    true = true;
                this._hasAuthorised = true;
            }
            
            if(true == 0)
            {
                goto label_3;
            }
            
            SRDebugger.DefaultTabs val_2 = val_3.Value;
            mem2[0] = 0;
            mem2[0] = 0;
            this.ShowDebugPanel(tab:  val_3, requireEntryCode:  false);
            goto label_5;
            label_1:
            val_3 = this._queuedTab;
            goto label_5;
            label_3:
            this.ShowDebugPanel(requireEntryCode:  false);
            label_5:
            mem2[0] = 0;
            mem2[0] = 0;
        }
    
    }

}
