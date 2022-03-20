using UnityEngine;

namespace SRDebugger
{
    public class Settings : ScriptableObject
    {
        // Fields
        private const string ResourcesPath = "/usr/Resources/SRDebugger";
        private const string ResourcesName = "Settings";
        private static SRDebugger.Settings _instance;
        private bool _isEnabled;
        private bool _autoLoad;
        private SRDebugger.DefaultTabs _defaultTab;
        private SRDebugger.Settings.TriggerEnableModes _triggerEnableMode;
        private SRDebugger.Settings.TriggerBehaviours _triggerBehaviour;
        private bool _enableKeyboardShortcuts;
        private SRDebugger.Settings.KeyboardShortcut[] _keyboardShortcuts;
        private SRDebugger.Settings.KeyboardShortcut[] _newKeyboardShortcuts;
        private bool _keyboardModifierControl;
        private bool _keyboardModifierAlt;
        private bool _keyboardModifierShift;
        private bool _keyboardEscapeClose;
        private bool _enableBackgroundTransparency;
        private bool _collapseDuplicateLogEntries;
        private bool _richTextInConsole;
        private bool _requireEntryCode;
        private bool _requireEntryCodeEveryTime;
        private int[] _entryCode;
        private bool _useDebugCamera;
        private int _debugLayer;
        private float _debugCameraDepth;
        private string _apiKey;
        private bool _enableBugReporter;
        private SRDebugger.DefaultTabs[] _disabledTabs;
        private SRDebugger.PinAlignment _profilerAlignment;
        private SRDebugger.PinAlignment _optionsAlignment;
        private SRDebugger.ConsoleAlignment _consoleAlignment;
        private SRDebugger.PinAlignment _triggerPosition;
        private int _maximumConsoleEntries;
        private bool _enableEventSystemCreation;
        private bool _automaticShowCursor;
        
        // Properties
        public static SRDebugger.Settings Instance { get; }
        public bool IsEnabled { get; }
        public bool AutoLoad { get; }
        public SRDebugger.DefaultTabs DefaultTab { get; }
        public SRDebugger.Settings.TriggerEnableModes EnableTrigger { get; }
        public SRDebugger.Settings.TriggerBehaviours TriggerBehaviour { get; }
        public bool EnableKeyboardShortcuts { get; }
        public System.Collections.Generic.IList<SRDebugger.Settings.KeyboardShortcut> KeyboardShortcuts { get; }
        public bool KeyboardEscapeClose { get; }
        public bool EnableBackgroundTransparency { get; }
        public bool RequireCode { get; }
        public bool RequireEntryCodeEveryTime { get; }
        public System.Collections.Generic.IList<int> EntryCode { get; set; }
        public bool UseDebugCamera { get; }
        public int DebugLayer { get; }
        public float DebugCameraDepth { get; }
        public bool CollapseDuplicateLogEntries { get; }
        public bool RichTextInConsole { get; }
        public string ApiKey { get; }
        public bool EnableBugReporter { get; }
        public System.Collections.Generic.IList<SRDebugger.DefaultTabs> DisabledTabs { get; }
        public SRDebugger.PinAlignment TriggerPosition { get; }
        public SRDebugger.PinAlignment ProfilerAlignment { get; }
        public SRDebugger.PinAlignment OptionsAlignment { get; }
        public SRDebugger.ConsoleAlignment ConsoleAlignment { get; set; }
        public int MaximumConsoleEntries { get; set; }
        public bool EnableEventSystemGeneration { get; set; }
        public bool AutomaticallyShowCursor { get; }
        
        // Methods
        public static SRDebugger.Settings get_Instance()
        {
            bool val_1 = UnityEngine.Object.op_Equality(x:  SRDebugger.Settings._instance, y:  0);
            if(val_1 != false)
            {
                    SRDebugger.Settings val_2 = SRDebugger.Settings.GetOrCreateInstance();
                SRDebugger.Settings._instance = val_1;
            }
            
            if(val_1._keyboardShortcuts == null)
            {
                    return;
            }
            
            if((mem[val_1._keyboardShortcuts + 12]) == 0)
            {
                    return;
            }
            
            SRDebugger.Settings._instance.UpgradeKeyboardShortcuts();
        }
        private static SRDebugger.Settings.KeyboardShortcut[] GetDefaultKeyboardShortcuts()
        {
            var val_5;
            var val_6;
            val_5 = 1152921505022394368;
            object val_1 = new System.Object();
            if(val_1 != 0)
            {
                    typeof(Settings.KeyboardShortcut).__il2cppRuntimeField_14 = 1;
                typeof(Settings.KeyboardShortcut).__il2cppRuntimeField_D = 1;
                typeof(Settings.KeyboardShortcut).__il2cppRuntimeField_10 = 282;
            }
            else
            {
                    val_6 = 1;
                typeof(Settings.KeyboardShortcut).__il2cppRuntimeField_D = val_6;
                mem[20] = val_6;
                mem[16] = 282;
            }
            
            typeof(Settings.KeyboardShortcut).__il2cppRuntimeField_8 = 1;
            typeof(KeyboardShortcut[]).__il2cppRuntimeField_10 = val_1;
            object val_2 = new System.Object();
            if(val_2 == 0)
            {
                goto label_6;
            }
            
            typeof(Settings.KeyboardShortcut).__il2cppRuntimeField_14 = 1;
            typeof(Settings.KeyboardShortcut).__il2cppRuntimeField_D = 1;
            typeof(Settings.KeyboardShortcut).__il2cppRuntimeField_10 = 283;
            typeof(Settings.KeyboardShortcut).__il2cppRuntimeField_8 = 2;
            if(val_2 != 0)
            {
                goto label_8;
            }
            
            goto label_8;
            label_6:
            val_6 = 1;
            typeof(Settings.KeyboardShortcut).__il2cppRuntimeField_D = val_6;
            mem[20] = val_6;
            mem[16] = 283;
            mem[8] = 2;
            label_8:
            typeof(KeyboardShortcut[]).__il2cppRuntimeField_14 = val_2;
            object val_3 = new System.Object();
            if(val_3 == 0)
            {
                goto label_10;
            }
            
            typeof(Settings.KeyboardShortcut).__il2cppRuntimeField_14 = 1;
            typeof(Settings.KeyboardShortcut).__il2cppRuntimeField_D = 1;
            typeof(Settings.KeyboardShortcut).__il2cppRuntimeField_10 = 284;
            typeof(Settings.KeyboardShortcut).__il2cppRuntimeField_8 = 3;
            if(val_3 != 0)
            {
                goto label_12;
            }
            
            goto label_12;
            label_10:
            val_6 = 1;
            typeof(Settings.KeyboardShortcut).__il2cppRuntimeField_D = val_6;
            mem[20] = val_6;
            mem[16] = 284;
            mem[8] = 3;
            label_12:
            typeof(KeyboardShortcut[]).__il2cppRuntimeField_18 = val_3;
            object val_4 = new System.Object();
            if(val_4 == 0)
            {
                goto label_14;
            }
            
            typeof(Settings.KeyboardShortcut).__il2cppRuntimeField_14 = 1;
            typeof(Settings.KeyboardShortcut).__il2cppRuntimeField_D = 1;
            typeof(Settings.KeyboardShortcut).__il2cppRuntimeField_10 = 285;
            typeof(Settings.KeyboardShortcut).__il2cppRuntimeField_8 = 4;
            if(val_4 != 0)
            {
                goto label_16;
            }
            
            goto label_16;
            label_14:
            val_5 = 1;
            typeof(Settings.KeyboardShortcut).__il2cppRuntimeField_D = val_5;
            mem[20] = val_5;
            mem[16] = 285;
            mem[8] = 4;
            label_16:
            typeof(KeyboardShortcut[]).__il2cppRuntimeField_1C = val_4;
        }
        private void UpgradeKeyboardShortcuts()
        {
            var val_4;
            bool val_5;
            val_4 = 0;
            UnityEngine.Debug.Log(message:  416309296);
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            goto label_3;
            label_11:
            KeyboardShortcut val_4 = this._keyboardShortcuts[val_4];
            if(new System.Object() != 0)
            {
                    typeof(Settings.KeyboardShortcut).__il2cppRuntimeField_8 = this._keyboardShortcuts[0x0][0].Action;
                typeof(Settings.KeyboardShortcut).__il2cppRuntimeField_10 = this._keyboardShortcuts[0x0][0].Key;
                typeof(Settings.KeyboardShortcut).__il2cppRuntimeField_C = this._keyboardModifierAlt;
                typeof(Settings.KeyboardShortcut).__il2cppRuntimeField_14 = this._keyboardModifierShift;
                val_5 = this._keyboardModifierControl;
            }
            else
            {
                    mem[8] = this._keyboardShortcuts[0x0][0].Action;
                mem[16] = this._keyboardShortcuts[0x0][0].Key;
                mem[12] = this._keyboardModifierAlt;
                mem[20] = this._keyboardModifierShift;
                val_5 = this._keyboardModifierControl;
            }
            
            typeof(Settings.KeyboardShortcut).__il2cppRuntimeField_D = val_5;
            Add(item:  415547392);
            val_4 = 1;
            label_3:
            if(val_4 < null)
            {
                goto label_11;
            }
            
            this._keyboardShortcuts = null;
            T[] val_3 = ToArray();
            this._newKeyboardShortcuts = null;
        }
        public bool get_IsEnabled()
        {
            return (bool)this._isEnabled;
        }
        public bool get_AutoLoad()
        {
            return (bool)this._autoLoad;
        }
        public SRDebugger.DefaultTabs get_DefaultTab()
        {
        
        }
        public SRDebugger.Settings.TriggerEnableModes get_EnableTrigger()
        {
        
        }
        public SRDebugger.Settings.TriggerBehaviours get_TriggerBehaviour()
        {
        
        }
        public bool get_EnableKeyboardShortcuts()
        {
            return (bool)this._enableKeyboardShortcuts;
        }
        public System.Collections.Generic.IList<SRDebugger.Settings.KeyboardShortcut> get_KeyboardShortcuts()
        {
        
        }
        public bool get_KeyboardEscapeClose()
        {
            return (bool)this._keyboardEscapeClose;
        }
        public bool get_EnableBackgroundTransparency()
        {
            return (bool)this._enableBackgroundTransparency;
        }
        public bool get_RequireCode()
        {
            return (bool)this._requireEntryCode;
        }
        public bool get_RequireEntryCodeEveryTime()
        {
            return (bool)this._requireEntryCodeEveryTime;
        }
        public System.Collections.Generic.IList<int> get_EntryCode()
        {
            System.Collections.ObjectModel.ReadOnlyCollection<System.Int32> val_1 = new System.Collections.ObjectModel.ReadOnlyCollection<System.Int32>(list:  this._entryCode);
        }
        public void set_EntryCode(System.Collections.Generic.IList<int> value)
        {
            var val_6;
            var val_7;
            var val_8;
            System.Func<System.Int32, System.Boolean> val_10;
            System.Exception val_11;
            var val_12;
            val_6 = 0;
            val_6 = val_6 + 1;
            val_7 = value;
            if(value != 4)
            {
                goto label_6;
            }
            
            val_8 = null;
            val_8 = null;
            val_10 = Settings.<>c.<>9__35_0;
            if(val_10 == 0)
            {
                    val_10 = null;
                val_10 = new System.Func<System.Int32, System.Boolean>(object:  Settings.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(418125888));
                Settings.<>c.<>9__35_0 = val_10;
            }
            
            if((System.Linq.Enumerable.Any<System.Int32>(source:  value, predicate:  7720960)) == true)
            {
                goto label_12;
            }
            
            TSource[] val_4 = System.Linq.Enumerable.ToArray<System.Int32>(source:  value);
            this._entryCode = value;
            return;
            label_6:
            val_11 = null;
            val_12 = "Entry code must be length 4";
            goto label_13;
            label_12:
            val_11 = null;
            val_12 = "All digits in entry code must be >= 0 and <= 9";
            label_13:
            val_11 = new System.Exception(message:  418128064);
        }
        public bool get_UseDebugCamera()
        {
            return (bool)this._useDebugCamera;
        }
        public int get_DebugLayer()
        {
            return (int)this._debugLayer;
        }
        public float get_DebugCameraDepth()
        {
            return (float)S0;
        }
        public bool get_CollapseDuplicateLogEntries()
        {
            return (bool)this._collapseDuplicateLogEntries;
        }
        public bool get_RichTextInConsole()
        {
            return (bool)this._richTextInConsole;
        }
        public string get_ApiKey()
        {
        
        }
        public bool get_EnableBugReporter()
        {
            return (bool)this._enableBugReporter;
        }
        public System.Collections.Generic.IList<SRDebugger.DefaultTabs> get_DisabledTabs()
        {
        
        }
        public SRDebugger.PinAlignment get_TriggerPosition()
        {
        
        }
        public SRDebugger.PinAlignment get_ProfilerAlignment()
        {
        
        }
        public SRDebugger.PinAlignment get_OptionsAlignment()
        {
        
        }
        public SRDebugger.ConsoleAlignment get_ConsoleAlignment()
        {
        
        }
        public void set_ConsoleAlignment(SRDebugger.ConsoleAlignment value)
        {
            this._consoleAlignment = value;
        }
        public int get_MaximumConsoleEntries()
        {
            return (int)this._maximumConsoleEntries;
        }
        public void set_MaximumConsoleEntries(int value)
        {
            this._maximumConsoleEntries = value;
        }
        public bool get_EnableEventSystemGeneration()
        {
            return (bool)this._enableEventSystemCreation;
        }
        public void set_EnableEventSystemGeneration(bool value)
        {
            this._enableEventSystemCreation = value;
        }
        public bool get_AutomaticallyShowCursor()
        {
            return (bool)this._automaticShowCursor;
        }
        private static SRDebugger.Settings GetOrCreateInstance()
        {
            object val_1 = UnityEngine.Resources.Load<System.Object>(path:  420385248);
            if(420385248 != 0)
            {
                    return;
            }
            
            return UnityEngine.ScriptableObject.CreateInstance<UnityEngine.Networking.PlayerConnection.PlayerConnection>();
        }
        public Settings()
        {
            bool val_2 = static_value_021FB515;
            if(val_2 != true)
            {
                    val_2 = true;
            }
            
            this._enableKeyboardShortcuts = true;
            this._isEnabled = true;
            this._autoLoad = true;
            KeyboardShortcut[] val_1 = SRDebugger.Settings.GetDefaultKeyboardShortcuts();
            this._richTextInConsole = true;
            this._keyboardModifierShift = true;
            this._keyboardEscapeClose = true;
            this._enableBackgroundTransparency = true;
            this._collapseDuplicateLogEntries = true;
            this._newKeyboardShortcuts = val_2;
            this._keyboardModifierControl = true;
            this._entryCode = null;
            this._maximumConsoleEntries = 1500;
            this._enableEventSystemCreation = true;
            this._automaticShowCursor = true;
        }
    
    }

}
