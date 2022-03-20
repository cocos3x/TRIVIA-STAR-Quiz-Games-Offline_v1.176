using UnityEngine;

namespace SRDebugger.Services.Implementation
{
    public class BugReportPopoverService : SRServiceBase<SRDebugger.Services.Implementation.BugReportPopoverService>
    {
        // Fields
        private SRDebugger.Services.BugReportCompleteCallback _callback;
        private bool _isVisible;
        private SRDebugger.UI.Other.BugReportPopoverRoot _popover;
        private SRDebugger.UI.Other.BugReportSheetController _sheet;
        
        // Properties
        public bool IsShowingPopover { get; }
        
        // Methods
        public bool get_IsShowingPopover()
        {
            return (bool)this._isVisible;
        }
        public void ShowBugReporter(SRDebugger.Services.BugReportCompleteCallback callback, bool takeScreenshotFirst = True, string descriptionText)
        {
            if(this._isVisible != true)
            {
                    bool val_1 = UnityEngine.Object.op_Equality(x:  this._popover, y:  0);
                if(val_1 == true)
            {
                    val_1 = this;
                this.Load();
            }
            
                if(this._popover == 0)
            {
                    UnityEngine.Debug.LogWarning(message:  467559824);
                callback.Invoke(didSucceed:  false, errorMessage:  467560064);
                return;
            }
            
                this._isVisible = true;
                this._callback = callback;
                bool val_3 = SRDebugger.Internal.SRDebuggerUtil.EnsureEventSystemExists();
                System.Collections.IEnumerator val_4 = this.OpenCo(takeScreenshot:  takeScreenshotFirst, descriptionText:  descriptionText);
                UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  467585344);
                return;
            }
            
            System.InvalidOperationException val_6 = new System.InvalidOperationException(message:  467560176);
        }
        private System.Collections.IEnumerator OpenCo(bool takeScreenshot, string descriptionText)
        {
            typeof(BugReportPopoverService.<OpenCo>d__7).__il2cppRuntimeField_8 = 0;
            if(new System.Object() != 0)
            {
                    typeof(BugReportPopoverService.<OpenCo>d__7).__il2cppRuntimeField_10 = takeScreenshot;
                typeof(BugReportPopoverService.<OpenCo>d__7).__il2cppRuntimeField_14 = this;
            }
            else
            {
                    mem[20] = this;
                mem[16] = takeScreenshot;
            }
            
            typeof(BugReportPopoverService.<OpenCo>d__7).__il2cppRuntimeField_18 = descriptionText;
        }
        private void SubmitComplete(bool didSucceed, string errorMessage)
        {
            this.OnComplete(success:  didSucceed, errorMessage:  errorMessage, close:  false);
        }
        private void CancelPressed()
        {
            this.OnComplete(success:  false, errorMessage:  467930112, close:  true);
        }
        private void OnComplete(bool success, string errorMessage, bool close)
        {
            if(this._isVisible != false)
            {
                    if(close == false)
            {
                    return;
            }
            
                this._isVisible = false;
                UnityEngine.GameObject val_1 = this._popover.gameObject;
                this._popover.SetActive(value:  false);
                UnityEngine.GameObject val_2 = this._popover.gameObject;
                UnityEngine.Object.Destroy(obj:  this._popover);
                this._popover = 0;
                this._sheet = 0;
                SRDebugger.Internal.BugReportScreenshotUtil.ScreenshotData = 0;
                this._callback.Invoke(didSucceed:  success, errorMessage:  errorMessage);
                return;
            }
            
            UnityEngine.Debug.LogWarning(message:  468058592);
        }
        private void TakingScreenshot()
        {
            if(this._isVisible != false)
            {
                    this._popover.CanvasGroup.alpha = null;
                return;
            }
            
            UnityEngine.Debug.LogWarning(message:  468058592);
        }
        private void ScreenshotComplete()
        {
            if(this._isVisible != false)
            {
                    this._popover.CanvasGroup.alpha = null;
                return;
            }
            
            UnityEngine.Debug.LogWarning(message:  468058592);
        }
        protected override void Awake()
        {
            this.Awake();
            UnityEngine.Transform val_1 = this.CachedTransform;
            UnityEngine.Transform val_2 = SRF.Hierarchy.Get(key:  466780208);
            this.SetParent(p:  466780208);
        }
        private void Load()
        {
            var val_15;
            object val_1 = UnityEngine.Resources.Load<System.Object>(path:  468557968);
            object val_2 = UnityEngine.Resources.Load<System.Object>(path:  468558112);
            if(468557968 != 0)
            {
                goto label_3;
            }
            
            val_15 = "[SRDebugger] Unable to load bug report popover prefab";
            goto label_6;
            label_3:
            if(468558112 != 0)
            {
                goto label_9;
            }
            
            val_15 = "[SRDebugger] Unable to load bug report sheet prefab";
            label_6:
            UnityEngine.Debug.LogError(message:  468559456);
            return;
            label_9:
            UnityEngine.RectTransform val_5 = SRInstantiate.Instantiate<UnityEngine.RectTransform>(prefab:  468557968);
            this._popover = "SRDebugger/UI/Prefabs/BugReportPopover";
            UnityEngine.Transform val_6 = CachedTransform;
            UnityEngine.Transform val_7 = this.CachedTransform;
            SetParent(parent:  468618448, worldPositionStays:  false);
            UnityEngine.RectTransform val_8 = SRInstantiate.Instantiate<UnityEngine.RectTransform>(prefab:  468558112);
            this._sheet = "SRDebugger/UI/Prefabs/BugReportSheet";
            UnityEngine.Transform val_9 = CachedTransform;
            SetParent(parent:  this._popover.Container, worldPositionStays:  false);
            System.Action<System.Boolean, TRVQuizProgress> val_10 = new System.Action<System.Boolean, TRVQuizProgress>(object:  468618448, method:  new IntPtr(468572944));
            this._sheet.SubmitComplete = null;
            System.Action val_11 = new System.Action(object:  468618448, method:  new IntPtr(468579088));
            this._sheet.CancelPressed = null;
            System.Action val_12 = new System.Action(object:  468618448, method:  new IntPtr(468584208));
            this._sheet.TakingScreenshot = null;
            System.Action val_13 = new System.Action(object:  468618448, method:  new IntPtr(468589328));
            this._sheet.ScreenshotComplete = null;
            UnityEngine.GameObject val_14 = this._popover.CachedGameObject;
            this._popover.SetActive(value:  false);
        }
        public BugReportPopoverService()
        {
        
        }
    
    }

}
