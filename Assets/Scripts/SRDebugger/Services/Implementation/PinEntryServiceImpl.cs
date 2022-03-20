using UnityEngine;

namespace SRDebugger.Services.Implementation
{
    public class PinEntryServiceImpl : SRServiceBase<SRDebugger.Services.IPinEntryService>, IPinEntryService
    {
        // Fields
        private SRDebugger.Services.PinEntryCompleteCallback _callback;
        private bool _isVisible;
        private SRDebugger.UI.Controls.PinEntryControl _pinControl;
        private System.Collections.Generic.List<int> _requiredPin;
        
        // Properties
        public bool IsShowingKeypad { get; }
        
        // Methods
        public bool get_IsShowingKeypad()
        {
            return (bool)this._isVisible;
        }
        public void ShowPinEntry(System.Collections.Generic.IList<int> requiredPin, string message, SRDebugger.Services.PinEntryCompleteCallback callback, bool allowCancel = True)
        {
            if(this._isVisible != true)
            {
                    this._isVisible.VerifyPin(pin:  requiredPin);
                bool val_1 = UnityEngine.Object.op_Equality(x:  this._pinControl, y:  0);
                if(val_1 == true)
            {
                    val_1 = this;
                this.Load();
            }
            
                if(this._pinControl == 0)
            {
                    UnityEngine.Debug.LogWarning(message:  476131872);
                callback.Invoke(validPinEntered:  false);
                return;
            }
            
                this._pinControl.Clear();
                this._pinControl.CanCancel = allowCancel;
                this._callback = callback;
                this._requiredPin.Clear();
                this._requiredPin.AddRange(collection:  requiredPin);
                this._pinControl.Show();
                this._isVisible = true;
                bool val_3 = SRDebugger.Internal.SRDebuggerUtil.EnsureEventSystemExists();
                return;
            }
            
            System.InvalidOperationException val_4 = new System.InvalidOperationException(message:  476160768);
        }
        public void ShowPinEntry(System.Collections.Generic.IList<int> requiredPin, string message, SRDebugger.Services.PinEntryCompleteCallback callback, bool blockInput, bool allowCancel)
        {
            this.ShowPinEntry(requiredPin:  requiredPin, message:  message, callback:  callback, allowCancel:  allowCancel);
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
            object val_1 = UnityEngine.Resources.Load<System.Object>(path:  476573712);
            if(476573712 == 0)
            {
                    UnityEngine.Debug.LogError(message:  476573840);
                return;
            }
            
            UnityEngine.RectTransform val_3 = SRInstantiate.Instantiate<UnityEngine.RectTransform>(prefab:  476573712);
            this._pinControl = "SRDebugger/UI/Prefabs/PinEntry";
            UnityEngine.Transform val_4 = CachedTransform;
            UnityEngine.Transform val_5 = this.CachedTransform;
            SetParent(parent:  476608240, worldPositionStays:  false);
            this._pinControl.Hide();
            SRDebugger.UI.Controls.PinEntryControlCallback val_6 = new SRDebugger.UI.Controls.PinEntryControlCallback(object:  476608240, method:  new IntPtr(476583216));
            this._pinControl.add_Complete(value:  417837056);
        }
        private void PinControlOnComplete(System.Collections.Generic.IList<int> result, bool didCancel)
        {
            if(didCancel != false)
            {
                    this._isVisible = false;
                this._pinControl.Hide();
                if(didCancel == true)
            {
                    false = false;
            }
            
                this._callback.Invoke(validPinEntered:  false = System.Linq.Enumerable.SequenceEqual<System.Int32>(first:  this._requiredPin, second:  result));
                return;
            }
            
            this._pinControl.Clear();
            this._pinControl.PlayInvalidCodeAnimation();
        }
        private void VerifyPin(System.Collections.Generic.IList<int> pin)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_6 = 0;
            val_7 = 0;
            val_6 = val_6 + 1;
            val_7 = (uint)val_6 & 65535;
            val_8 = pin;
            if(pin != 4)
            {
                goto label_25;
            }
            
            var val_6 = 0;
            label_24:
            val_7 = 0;
            val_6 = 0;
            val_7 = val_7 + 1;
            val_6 = (uint)val_7 & 65535;
            val_9 = pin;
            if(val_6 >= pin)
            {
                    return;
            }
            
            val_7 = 0;
            val_6 = 0;
            val_7 = val_7 + 1;
            val_6 = (uint)val_7 & 65535;
            val_10 = pin;
            if(pin < 0)
            {
                goto label_18;
            }
            
            val_7 = 0;
            val_6 = 0;
            val_7 = val_7 + 1;
            val_6 = (uint)val_7 & 65535;
            val_11 = pin;
            val_6 = val_6 + 1;
            if(pin < 10)
            {
                goto label_24;
            }
            
            label_18:
            label_25:
            System.ArgumentException val_5 = new System.ArgumentException(message:  476869680);
        }
        public PinEntryServiceImpl()
        {
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>(capacity:  4);
            this._requiredPin = null;
        }
    
    }

}
