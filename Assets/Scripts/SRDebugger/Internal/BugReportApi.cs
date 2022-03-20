using UnityEngine;

namespace SRDebugger.Internal
{
    public class BugReportApi
    {
        // Fields
        private readonly string _apiKey;
        private readonly SRDebugger.Services.BugReport _bugReport;
        private bool _isBusy;
        private UnityEngine.WWW _www;
        private bool <IsComplete>k__BackingField;
        private bool <WasSuccessful>k__BackingField;
        private string <ErrorMessage>k__BackingField;
        
        // Properties
        public bool IsComplete { get; set; }
        public bool WasSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public float Progress { get; }
        
        // Methods
        public BugReportApi(SRDebugger.Services.BugReport report, string apiKey)
        {
            val_1 = new System.Object();
            this._apiKey = val_1;
            this._bugReport = report;
        }
        public bool get_IsComplete()
        {
            return (bool)this.<IsComplete>k__BackingField;
        }
        private void set_IsComplete(bool value)
        {
            this.<IsComplete>k__BackingField = value;
        }
        public bool get_WasSuccessful()
        {
            return (bool)this.<WasSuccessful>k__BackingField;
        }
        private void set_WasSuccessful(bool value)
        {
            this.<WasSuccessful>k__BackingField = value;
        }
        public string get_ErrorMessage()
        {
        
        }
        private void set_ErrorMessage(string value)
        {
            this.<ErrorMessage>k__BackingField = value;
        }
        public float get_Progress()
        {
            if(this._www == 0)
            {
                    return (float)S0;
            }
            
            float val_1 = this._www.progress;
            float val_2 = this._www.uploadProgress;
            return UnityEngine.Mathf.Clamp01(value:  this._www + this._www);
        }
        public System.Collections.IEnumerator Submit()
        {
            object val_1 = new System.Object();
            typeof(BugReportApi.<Submit>d__19).__il2cppRuntimeField_8 = 0;
            typeof(BugReportApi.<Submit>d__19).__il2cppRuntimeField_10 = this;
        }
        private void SetCompletionState(bool wasSuccessful)
        {
            this._bugReport.ScreenshotData = 0;
            this.<IsComplete>k__BackingField = true;
            this.<WasSuccessful>k__BackingField = wasSuccessful;
            this._isBusy = 0;
            if(wasSuccessful != false)
            {
                    return;
            }
            
            string val_1 = 492044560 + this.<ErrorMessage>k__BackingField(this.<ErrorMessage>k__BackingField);
            UnityEngine.Debug.LogError(message:  492044560);
        }
        private static string BuildJsonRequest(SRDebugger.Services.BugReport report)
        {
            SRDebugger.Services.BugReport val_4 = report;
            System.Collections.Hashtable val_1 = new System.Collections.Hashtable();
            System.Collections.Generic.IList<System.Collections.Generic.IList<System.String>> val_2 = SRDebugger.Internal.BugReportApi.CreateConsoleDump();
            if(report.ScreenshotData == null)
            {
                    return SRF.Json.Serialize(obj:  75878400);
            }
            
            string val_3 = System.Convert.ToBase64String(inArray:  report.ScreenshotData);
            return SRF.Json.Serialize(obj:  75878400);
        }
        private static System.Collections.Generic.IList<System.Collections.Generic.IList<string>> CreateConsoleDump()
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            SRDebugger.Services.IConsoleService val_2 = SRDebugger.Internal.Service.Console;
            object val_10 = .ctor().SyncRoot;
            if((mem[.ctor().SyncRoot + 178]) == 0)
            {
                goto label_2;
            }
            
            val_10 = 0;
            label_4:
            if((mem[.ctor().SyncRoot + 88] + 0) == null)
            {
                goto label_3;
            }
            
            val_10 = val_10 + 1;
            if(((uint)val_10 & 65535) < (mem[.ctor().SyncRoot + 178]))
            {
                goto label_4;
            }
            
            label_2:
            val_11 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            goto label_5;
            label_3:
            var val_3 = (mem[.ctor().SyncRoot + 88]) + 0;
            val_10 = val_10 + (((mem[.ctor().SyncRoot + 88] + 0) + 4) << 3);
            label_5:
            object val_11 = .ctor().SyncRoot;
            if((mem[.ctor().SyncRoot + 178]) == 0)
            {
                goto label_7;
            }
            
            val_10 = 0;
            label_9:
            if((mem[.ctor().SyncRoot + 88] + 0) == null)
            {
                goto label_8;
            }
            
            val_10 = val_10 + 1;
            if(((uint)val_10 & 65535) < (mem[.ctor().SyncRoot + 178]))
            {
                goto label_9;
            }
            
            label_7:
            val_12 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            goto label_10;
            label_8:
            var val_4 = (mem[.ctor().SyncRoot + 88]) + 0;
            val_11 = val_11 + (((mem[.ctor().SyncRoot + 88] + 0) + 4) << 3);
            label_10:
            label_30:
            object val_12 = .ctor().SyncRoot;
            if((mem[.ctor().SyncRoot + 178]) == 0)
            {
                goto label_12;
            }
            
            val_10 = 0;
            label_14:
            if((mem[.ctor().SyncRoot + 88] + 0) == null)
            {
                goto label_13;
            }
            
            val_10 = val_10 + 1;
            if(((uint)val_10 & 65535) < (mem[.ctor().SyncRoot + 178]))
            {
                goto label_14;
            }
            
            label_12:
            val_13 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            goto label_15;
            label_13:
            var val_5 = (mem[.ctor().SyncRoot + 88]) + 0;
            val_12 = val_12 + (((mem[.ctor().SyncRoot + 88] + 0) + 4) << 3);
            label_15:
            if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) == 0)
            {
                goto label_16;
            }
            
            object val_14 = .ctor().SyncRoot;
            if((mem[.ctor().SyncRoot + 178]) == 0)
            {
                goto label_18;
            }
            
            var val_13 = 0;
            label_20:
            if((mem[.ctor().SyncRoot + 88] + 0) == null)
            {
                goto label_19;
            }
            
            val_13 = val_13 + 1;
            if(((uint)val_13 & 65535) < (mem[.ctor().SyncRoot + 178]))
            {
                goto label_20;
            }
            
            label_18:
            val_14 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            goto label_21;
            label_19:
            var val_6 = (mem[.ctor().SyncRoot + 88]) + 0;
            val_14 = val_14 + (((mem[.ctor().SyncRoot + 88] + 0) + 4) << 3);
            label_21:
            System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_7 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem2[0] = ;
            Add(item:  150212608);
            Add(item:  mem[.ctor() + 24]);
            Add(item:  mem[.ctor() + 28]);
            if((mem[.ctor() + 16]) >= 2)
            {
                    string val_8 = .ctor() + 16.ToString();
                Add(item:  .ctor() + 16);
            }
            
            Add(item:  80883712);
            goto label_30;
            label_16:
            if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) == 0)
            {
                goto label_31;
            }
            
            object val_15 = .ctor().SyncRoot;
            if((mem[.ctor().SyncRoot + 178]) == 0)
            {
                goto label_32;
            }
            
            val_10 = 0;
            label_34:
            if((mem[.ctor().SyncRoot + 88] + 0) == null)
            {
                goto label_33;
            }
            
            val_10 = val_10 + 1;
            if(((uint)val_10 & 65535) < (mem[.ctor().SyncRoot + 178]))
            {
                goto label_34;
            }
            
            label_32:
            val_15 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            goto label_35;
            label_33:
            var val_9 = (mem[.ctor().SyncRoot + 88]) + 0;
            val_15 = val_15 + (((mem[.ctor().SyncRoot + 88] + 0) + 4) << 3);
            label_35:
            label_31:
            if(0 == 0)
            {
                    return;
            }
        
        }
    
    }

}
