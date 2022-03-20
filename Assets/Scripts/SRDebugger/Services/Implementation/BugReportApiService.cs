using UnityEngine;

namespace SRDebugger.Services.Implementation
{
    public class BugReportApiService : SRServiceBase<SRDebugger.Services.IBugReportService>, IBugReportService
    {
        // Fields
        public const float Timeout = 12;
        private SRDebugger.Services.BugReportCompleteCallback _completeCallback;
        private string _errorMessage;
        private bool _isBusy;
        private float _previousProgress;
        private SRDebugger.Services.BugReportProgressCallback _progressCallback;
        private SRDebugger.Internal.BugReportApi _reportApi;
        
        // Methods
        public void SendBugReport(SRDebugger.Services.BugReport report, SRDebugger.Services.BugReportCompleteCallback completeHandler, SRDebugger.Services.BugReportProgressCallback progressCallback)
        {
            System.ArgumentNullException val_7;
            var val_8;
            if(report == 0)
            {
                goto label_1;
            }
            
            if(completeHandler == 0)
            {
                goto label_2;
            }
            
            if(this._isBusy != false)
            {
                    label_7:
                completeHandler.Invoke(didSucceed:  false, errorMessage:  466653392);
                return;
            }
            
            UnityEngine.NetworkReachability val_1 = UnityEngine.Application.internetReachability;
            if(0 == 0)
            {
                goto label_7;
            }
            
            this._errorMessage = "";
            this.enabled = true;
            this._completeCallback = completeHandler;
            this._isBusy = true;
            this._progressCallback = progressCallback;
            SRDebugger.Settings val_2 = SRDebugger.Settings.Instance;
            typeof(SRDebugger.Internal.BugReportApi).__il2cppRuntimeField_8 = 256;
            typeof(SRDebugger.Internal.BugReportApi).__il2cppRuntimeField_C = report;
            this._reportApi = new System.Object();
            System.Collections.IEnumerator val_4 = Submit();
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  420978688);
            return;
            label_1:
            val_7 = null;
            val_8 = "report";
            goto label_8;
            label_2:
            val_7 = null;
            val_8 = "completeHandler";
            label_8:
            val_7 = new System.ArgumentNullException(paramName:  466653760);
        }
        protected override void Awake()
        {
            this.Awake();
            UnityEngine.Transform val_1 = this.CachedTransform;
            UnityEngine.Transform val_2 = SRF.Hierarchy.Get(key:  466780208);
            this.SetParent(p:  466780208);
        }
        private void OnProgress(float progress)
        {
            if(this._progressCallback == 0)
            {
                    return;
            }
            
            this._progressCallback.Invoke(progress:  progress);
        }
        private void OnComplete()
        {
            SRDebugger.Internal.BugReportApi val_2;
            string val_3;
            this._isBusy = false;
            this.enabled = false;
            val_2 = this._reportApi;
            if(this._reportApi != 0)
            {
                goto label_0;
            }
            
            val_2 = this._reportApi;
            if(val_2 == 0)
            {
                goto label_1;
            }
            
            label_0:
            if((System.String.IsNullOrEmpty(value:  this._reportApi.<ErrorMessage>k__BackingField)) != false)
            {
                    val_3 = this._errorMessage;
            }
            else
            {
                    val_3 = this._reportApi.<ErrorMessage>k__BackingField;
            }
            
            if((this._reportApi.<WasSuccessful>k__BackingField) == true)
            {
                    this._reportApi.<WasSuccessful>k__BackingField = 1;
            }
            
            this._completeCallback.Invoke(didSucceed:  true, errorMessage:  mem[this._reportApi.<ErrorMessage>k__BackingField]);
            this._completeCallback = 0;
            return;
            label_1:
        }
        protected override void Update()
        {
            this.Update();
            if(this._isBusy == false)
            {
                    return;
            }
            
            if(this._reportApi == 0)
            {
                    this._isBusy = false;
            }
            
            if((this._reportApi.<IsComplete>k__BackingField) != false)
            {
                    this.OnComplete();
                return;
            }
            
            float val_1 = this._reportApi.Progress;
            if(this._reportApi == 0)
            {
                    return;
            }
            
            if(this._progressCallback != 0)
            {
                    this._progressCallback.Invoke(progress:  this._reportApi.Progress);
            }
            
            float val_3 = this._reportApi.Progress;
            this._previousProgress = this._reportApi;
        }
        public BugReportApiService()
        {
        
        }
    
    }

}
