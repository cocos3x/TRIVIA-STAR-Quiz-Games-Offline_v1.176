using UnityEngine;

namespace SRDebugger.Services.Implementation
{
    public class StandardConsoleService : IConsoleService
    {
        // Fields
        private readonly bool _collapseEnabled;
        private bool _hasCleared;
        private readonly SRDebugger.CircularBuffer<SRDebugger.Services.ConsoleEntry> _allConsoleEntries;
        private SRDebugger.CircularBuffer<SRDebugger.Services.ConsoleEntry> _consoleEntries;
        private readonly object _threadLock;
        private int <ErrorCount>k__BackingField;
        private int <WarningCount>k__BackingField;
        private int <InfoCount>k__BackingField;
        private SRDebugger.Services.ConsoleUpdatedEventHandler Updated;
        
        // Properties
        public int ErrorCount { get; set; }
        public int WarningCount { get; set; }
        public int InfoCount { get; set; }
        public SRDebugger.IReadOnlyList<SRDebugger.Services.ConsoleEntry> Entries { get; }
        public SRDebugger.IReadOnlyList<SRDebugger.Services.ConsoleEntry> AllEntries { get; }
        
        // Methods
        public StandardConsoleService()
        {
            this._threadLock = new System.Object();
            Application.LogCallback val_2 = new Application.LogCallback(object:  483251392, method:  new IntPtr(483224320));
            UnityEngine.Application.RegisterLogCallbackThreaded(handler:  150691840);
            SRF.Service.SRServiceManager.RegisterService<System.Object>(service:  483251392);
            SRDebugger.Settings val_3 = SRDebugger.Settings.Instance;
            this._collapseEnabled = false;
            SRDebugger.Settings val_4 = SRDebugger.Settings.Instance;
            SRDebugger.CircularBuffer<System.String> val_5 = new SRDebugger.CircularBuffer<System.String>(capacity:  0);
            this._allConsoleEntries = null;
        }
        public int get_ErrorCount()
        {
            return (int)this.<ErrorCount>k__BackingField;
        }
        private void set_ErrorCount(int value)
        {
            this.<ErrorCount>k__BackingField = value;
        }
        public int get_WarningCount()
        {
            return (int)this.<WarningCount>k__BackingField;
        }
        private void set_WarningCount(int value)
        {
            this.<WarningCount>k__BackingField = value;
        }
        public int get_InfoCount()
        {
            return (int)this.<InfoCount>k__BackingField;
        }
        private void set_InfoCount(int value)
        {
            this.<InfoCount>k__BackingField = value;
        }
        public void add_Updated(SRDebugger.Services.ConsoleUpdatedEventHandler value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this.Updated, b:  value);
            if(this.Updated == 0)
            {
                goto label_1;
            }
            
            val_2 = this.Updated;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.Updated != 1152921513680825188)
            {
                goto label_3;
            }
        
        }
        public void remove_Updated(SRDebugger.Services.ConsoleUpdatedEventHandler value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this.Updated, value:  value);
            if(this.Updated == 0)
            {
                goto label_1;
            }
            
            val_2 = this.Updated;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.Updated != 1152921513680953572)
            {
                goto label_3;
            }
        
        }
        public SRDebugger.IReadOnlyList<SRDebugger.Services.ConsoleEntry> get_Entries()
        {
            if(this._hasCleared == false)
            {
                    16 = 12;
            }
        
        }
        public SRDebugger.IReadOnlyList<SRDebugger.Services.ConsoleEntry> get_AllEntries()
        {
        
        }
        public void Clear()
        {
            System.Threading.Monitor.Enter(obj:  this._threadLock, lockTaken: ref  bool val_1 = true);
            this._hasCleared = true;
            if(this._consoleEntries == 0)
            {
                    SRDebugger.Settings val_2 = SRDebugger.Settings.Instance;
                SRDebugger.CircularBuffer<System.String> val_3 = new SRDebugger.CircularBuffer<System.String>(capacity:  0);
                this._consoleEntries = null;
            }
            
            this.<ErrorCount>k__BackingField = 0;
            this.<WarningCount>k__BackingField = 0;
            this.<InfoCount>k__BackingField = 0;
            if(0 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this._threadLock);
            }
            
            this.OnUpdated();
        }
        protected void OnEntryAdded(SRDebugger.Services.ConsoleEntry entry)
        {
            var val_7;
            int val_8;
            SRDebugger.CircularBuffer<SRDebugger.Services.ConsoleEntry> val_9;
            int val_10;
            if(this._hasCleared == false)
            {
                goto label_1;
            }
            
            if(this._consoleEntries.IsFull == false)
            {
                goto label_3;
            }
            
            SRDebugger.Services.ConsoleEntry val_2 = this._consoleEntries.Front();
            if(this._consoleEntries > 4)
            {
                goto label_6;
            }
            
            val_7 = 11431360 + (11431360 + (this._consoleEntries) << 2);
            if(this._consoleEntries == 4)
            {
                    11431360 + (this._consoleEntries) << 2 = (11431360 + (this._consoleEntries) << 2) & (this << (11431360 + (this._consoleEntries) << 2));
                11431360 + (this._consoleEntries) << 2 = (11431360 + (this._consoleEntries) << 2) & (this << (11431360 + (this._consoleEntries) << 2));
                mem2[0] = ((11431360 + (this._consoleEntries) << 2 & (this) << 11431360 + (this._consoleEntries) << 2) & (this) << (11431360 + (this._consoleEntries) << 2 & (this) << 11431360 + (this._consoleEntries) << 2)) + this;
                mem2[0] = ((11431360 + (this._consoleEntries) << 2 & (this) << 11431360 + (this._consoleEntries) << 2) & (this) << (11431360 + (this._consoleEntries) << 2 & (this) << 11431360 + (this._consoleEntries) << 2)) + this + IP;
            }
            
            val_8 = this.<ErrorCount>k__BackingField;
            goto label_14;
            label_1:
            val_9 = this;
            if(this._allConsoleEntries.IsFull == false)
            {
                goto label_17;
            }
            
            SRDebugger.Services.ConsoleEntry val_4 = this._allConsoleEntries.Front();
            if(this._allConsoleEntries > 4)
            {
                goto label_12;
            }
            
            val_7 = 11431512 + (11431512 + (this._allConsoleEntries) << 2);
            if(this._allConsoleEntries == 4)
            {
                    11431512 + (this._allConsoleEntries) << 2 = (11431512 + (this._allConsoleEntries) << 2) & (this << (11431512 + (this._allConsoleEntries) << 2));
                11431512 + (this._allConsoleEntries) << 2 = (11431512 + (this._allConsoleEntries) << 2) & (this << (11431512 + (this._allConsoleEntries) << 2));
                11431512 + (this._allConsoleEntries) << 2 = (11431512 + (this._allConsoleEntries) << 2) & ((R8) << 1);
                11431512 + (this._allConsoleEntries) << 2 = (11431512 + (this._allConsoleEntries) << 2) * (11431512 + (this._allConsoleEntries) << 2);
                11431512 + (this._allConsoleEntries) << 2 = (11431512 + (this._allConsoleEntries) << 2) & (this << (11431512 + (this._allConsoleEntries) << 2));
            }
            
            val_10 = this.<ErrorCount>k__BackingField;
            goto label_18;
            label_14:
            int val_5 = ;
            val_5 = val_5 - 1;
            mem2[0] = val_5;
            label_6:
            this._consoleEntries.PopFront();
            label_3:
            this._consoleEntries.PushBack(item:  entry);
            val_9 = this._allConsoleEntries;
            goto label_17;
            label_18:
            int val_6 = ;
            val_6 = val_6 - 1;
            mem2[0] = val_6;
            label_12:
            this._allConsoleEntries._start.PopFront();
            label_17:
            this._allConsoleEntries._start.PushBack(item:  entry);
            this.OnUpdated();
        }
        protected void OnEntryDuplicated(SRDebugger.Services.ConsoleEntry entry)
        {
            var val_2;
            int val_3;
            if(entry != 0)
            {
                    val_2 = entry;
                val_3 = entry.Count;
            }
            else
            {
                    val_2 = 16;
                val_3 = 2621443;
            }
            
            mem[16] = 2621444;
            this.OnUpdated();
            if(this._hasCleared == false)
            {
                    return;
            }
            
            if(this._hasCleared == true)
            {
                    return;
            }
            
            SRDebugger.Services.ConsoleEntry val_1 = new SRDebugger.Services.ConsoleEntry(other:  R5);
            typeof(SRDebugger.Services.ConsoleEntry).__il2cppRuntimeField_10 = 1;
            R4.OnEntryAdded(entry:  419115008);
        }
        private void OnUpdated()
        {
            if(this.Updated == 0)
            {
                    return;
            }
            
            this.Updated.Invoke(console:  484958656);
        }
        private void UnityLogCallback(string condition, string stackTrace, UnityEngine.LogType type)
        {
            var val_7;
            SRDebugger.Services.ConsoleEntry val_8;
            System.Threading.Monitor.Enter(obj:  this._threadLock, lockTaken: ref  bool val_1 = true);
            if((this._collapseEnabled == false) || (this._collapseEnabled <= false))
            {
                goto label_9;
            }
            
            if(this._allConsoleEntries != 0)
            {
                
            }
            else
            {
                    val_7 = 2621443;
            }
            
            SRDebugger.Services.ConsoleEntry val_3 = this._allConsoleEntries.Item[val_7 - 1];
            val_8 = this._allConsoleEntries;
            if((this._allConsoleEntries == 0) || (this._allConsoleEntries != type))
            {
                goto label_9;
            }
            
            bool val_4 = System.String.op_Equality(a:  this._allConsoleEntries, b:  condition);
            if((val_4 == false) || ((System.String.op_Equality(a:  val_4, b:  stackTrace)) == false))
            {
                goto label_9;
            }
            
            this.OnEntryDuplicated(entry:  val_8);
            goto label_10;
            label_9:
            val_8 = null;
            typeof(SRDebugger.Services.ConsoleEntry).__il2cppRuntimeField_10 = 1;
            val_8 = new System.Object();
            typeof(SRDebugger.Services.ConsoleEntry).__il2cppRuntimeField_14 = type;
            typeof(SRDebugger.Services.ConsoleEntry).__il2cppRuntimeField_18 = condition;
            typeof(SRDebugger.Services.ConsoleEntry).__il2cppRuntimeField_1C = stackTrace;
            this.OnEntryAdded(entry:  419115008);
            label_10:
            if(type <= 4)
            {
                    var val_7 = 11432484 + (11432484 + (type) << 2);
                if(type == 4)
            {
                    11432484 = 11432484 & 0;
                11432484 = 11432484 & (0 << 11432484);
                11432484 = 11432484 & (0 >> 11432484);
                11432484 = 11432484 & 0;
                11432484 = 11432484 & (0 << 11432484);
            }
            
                int val_8 = this.<ErrorCount>k__BackingField;
                val_8 = val_8 + 1;
                this.<ErrorCount>k__BackingField = val_8;
            }
            
            if(0 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this._threadLock);
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        private void AdjustCounter(UnityEngine.LogType type, int amount)
        {
            int val_2;
            if(type > 4)
            {
                    return;
            }
            
            var val_1 = 11431820 + (11431820 + (type) << 2);
            if(type == 4)
            {
                    this = this & ((R4) << this);
                this = this & ((R4) << (this & (R4) << this));
                this = this & ((R4) >> 32);
                this = this & ((IP) << (((this & (R4) << this) & (R4) << (this & (R4) << this)) & (R4) >> 32));
                this = this & ((R4) << ((((this & (R4) << this) & (R4) << (this & (R4) << this)) & (R4) >> 32) & (IP) << (((this & (R4) << this) & (R4) << (this & (R4) << this)) & (R4) >> 32)));
            }
            
            val_2 = (((((this & (R4) << this) & (R4) << (this & (R4) << this)) & (R4) >> 32) & (IP) << (((this & (R4) << this) & (R4) << (this & (R4) << this)) & (R4) >> 32)) & (R4) << ((((this & (R4) << this) & (R4) << .<ErrorCount>k__BackingField;
            int val_2 = ;
            val_2 = val_2 + amount;
            mem2[0] = val_2;
        }
    
    }

}
