using UnityEngine;

namespace SRDebugger.UI.Controls
{
    public class PinEntryControl : SRMonoBehaviourEx
    {
        // Fields
        private bool _isVisible;
        private System.Collections.Generic.List<int> _numbers;
        public UnityEngine.UI.Image Background;
        public bool CanCancel;
        public UnityEngine.UI.Button CancelButton;
        public UnityEngine.UI.Text CancelButtonText;
        public UnityEngine.CanvasGroup CanvasGroup;
        public UnityEngine.Animator DotAnimator;
        public UnityEngine.UI.Button[] NumberButtons;
        public UnityEngine.UI.Toggle[] NumberDots;
        public UnityEngine.UI.Text PromptText;
        private SRDebugger.UI.Controls.PinEntryControlCallback Complete;
        
        // Methods
        public void add_Complete(SRDebugger.UI.Controls.PinEntryControlCallback value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  this.Complete, b:  value);
            if(this.Complete == 0)
            {
                goto label_1;
            }
            
            val_2 = this.Complete;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.Complete != 1152921513647110896)
            {
                goto label_3;
            }
        
        }
        public void remove_Complete(SRDebugger.UI.Controls.PinEntryControlCallback value)
        {
            var val_2;
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  this.Complete, value:  value);
            if(this.Complete == 0)
            {
                goto label_1;
            }
            
            val_2 = this.Complete;
            if(null == null)
            {
                goto label_2;
            }
            
            label_1:
            val_2 = 0;
            label_2:
            if(this.Complete != 1152921513647239280)
            {
                goto label_3;
            }
        
        }
        protected override void Awake()
        {
            var val_4 = 0;
            this.Awake();
            goto label_1;
            label_9:
            if(new System.Object() != 0)
            {
                    typeof(PinEntryControl.<>c__DisplayClass14_0).__il2cppRuntimeField_C = this;
            }
            else
            {
                    mem[12] = this;
            }
            
            typeof(PinEntryControl.<>c__DisplayClass14_0).__il2cppRuntimeField_8 = val_4;
            UnityEngine.UI.Button val_4 = this.NumberButtons[val_4];
            UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  417943552, method:  new IntPtr(450553824));
            this.NumberButtons[0x0][0].m_OnClick.AddListener(call:  162246656);
            val_4 = 1;
            label_1:
            if(val_4 < this.NumberButtons[0x0][0].m_OnClick)
            {
                goto label_9;
            }
            
            UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  450669984, method:  new IntPtr(450644960));
            this.CancelButton.m_OnClick.AddListener(call:  162246656);
            this.RefreshState();
        }
        protected override void Update()
        {
            var val_7;
            this.Update();
            if(this._isVisible == false)
            {
                    return;
            }
            
            if(this._isVisible >= true)
            {
                    if((UnityEngine.Input.GetKeyDown(key:  8)) != true)
            {
                    if((UnityEngine.Input.GetKeyDown(key:  127)) == false)
            {
                goto label_5;
            }
            
            }
            
                int val_3 = SRF.SRFIListExtensions.PopLast<System.Int32>(list:  this._numbers);
                this.RefreshState();
            }
            
            label_5:
            val_7 = 0;
            string val_4 = UnityEngine.Input.inputString;
            goto label_6;
            label_13:
            if((System.Char.IsNumber(s:  null, index:  0)) != false)
            {
                    double val_6 = System.Char.GetNumericValue(s:  null, index:  0);
                if(System.Char.__il2cppRuntimeField_cctor_finished == 0)
            {
                    0 = 0;
            }
            
                if(S0 <= 9)
            {
                    0 = this;
                this.PushNumber(number:  S0);
            }
            
            }
            
            val_7 = 1;
            label_6:
            if(val_7 < 0)
            {
                goto label_13;
            }
        
        }
        public void Show()
        {
            this.CanvasGroup.alpha = null;
            if(this.CanvasGroup != 0)
            {
                    this.CanvasGroup.interactable = true;
            }
            else
            {
                    0.interactable = true;
            }
            
            this.CanvasGroup.blocksRaycasts = true;
            this._isVisible = true;
        }
        public void Hide()
        {
            this.CanvasGroup.alpha = null;
            if(this.CanvasGroup != 0)
            {
                    this.CanvasGroup.interactable = false;
            }
            else
            {
                    0.interactable = false;
            }
            
            this.CanvasGroup.blocksRaycasts = false;
            this._isVisible = false;
        }
        public void Clear()
        {
            this._numbers.Clear();
            this.RefreshState();
        }
        public void PlayInvalidCodeAnimation()
        {
            this.DotAnimator.SetTrigger(name:  451358560);
        }
        protected void OnComplete()
        {
            if(this.Complete == 0)
            {
                    return;
            }
            
            System.Collections.ObjectModel.ReadOnlyCollection<System.Int32> val_1 = new System.Collections.ObjectModel.ReadOnlyCollection<System.Int32>(list:  this._numbers);
            this.Complete.Invoke(result:  77955072, didCancel:  false);
        }
        protected void OnCancel()
        {
            if(this.Complete == 0)
            {
                    return;
            }
            
            this.Complete.Invoke(result:  478302960, didCancel:  true);
        }
        private void CancelButtonPressed()
        {
            if(true >= 1)
            {
                    int val_1 = SRF.SRFIListExtensions.PopLast<System.Int32>(list:  this._numbers);
            }
            else
            {
                    this.OnCancel();
            }
            
            this.RefreshState();
        }
        public void PushNumber(int number)
        {
            if(true >= 4)
            {
                    UnityEngine.Debug.LogWarning(message:  451855808);
                return;
            }
            
            this._numbers.Add(item:  number);
            if(this._numbers >= 4)
            {
                    this._numbers = this;
                this.OnComplete();
            }
            
            this.RefreshState();
        }
        private void RefreshState()
        {
            var val_2;
            var val_3;
            System.Collections.Generic.List<System.Int32> val_5;
            UnityEngine.UI.Text val_6;
            val_2 = this;
            val_3 = 0;
            goto label_1;
            label_7:
            UnityEngine.UI.Toggle val_1 = this.NumberDots[val_3];
            if(val_3 < this._numbers)
            {
                    0 = 1;
            }
            
            val_1.isOn = true;
            val_3 = 1;
            label_1:
            if(val_3 < val_1)
            {
                goto label_7;
            }
            
            val_5 = this._numbers;
            val_6 = this.CancelButtonText;
            if(val_1 >= 1)
            {
                    if(val_6 != 0)
            {
                goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_314;
            }
            
            }
            else
            {
                    if((R4 + 48) == 0)
            {
                    "Cancel" = "";
            }
            
                if(R5 != 0)
            {
                goto R5 + 788;
            }
            
            }
        
        }
        public PinEntryControl()
        {
            this._isVisible = true;
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>(capacity:  4);
            this.CanCancel = true;
            this._numbers = null;
        }
    
    }

}
