using UnityEngine;

namespace SRDebugger.UI.Other
{
    public class BugReportSheetController : SRMonoBehaviourEx
    {
        // Fields
        public UnityEngine.GameObject ButtonContainer;
        public UnityEngine.UI.Text ButtonText;
        public UnityEngine.UI.Button CancelButton;
        public System.Action CancelPressed;
        public UnityEngine.UI.InputField DescriptionField;
        public UnityEngine.UI.InputField EmailField;
        public UnityEngine.UI.Slider ProgressBar;
        public UnityEngine.UI.Text ResultMessageText;
        public System.Action ScreenshotComplete;
        public UnityEngine.UI.Button SubmitButton;
        public System.Action<bool, string> SubmitComplete;
        public System.Action TakingScreenshot;
        
        // Properties
        public bool IsCancelButtonEnabled { get; set; }
        
        // Methods
        public bool get_IsCancelButtonEnabled()
        {
            UnityEngine.GameObject val_1 = this.CancelButton.gameObject;
            if(this.CancelButton != 0)
            {
                    return this.CancelButton.activeSelf;
            }
            
            return this.CancelButton.activeSelf;
        }
        public void set_IsCancelButtonEnabled(bool value)
        {
            UnityEngine.GameObject val_1 = this.CancelButton.gameObject;
            this.CancelButton.SetActive(value:  value);
        }
        protected override void Start()
        {
            this.Start();
            this.SetLoadingSpinnerVisible(visible:  false);
            this.ClearErrorMessage();
            this.ClearForm();
        }
        public void Submit()
        {
            UnityEngine.EventSystems.EventSystem val_1 = UnityEngine.EventSystems.EventSystem.current;
            0.SetSelectedGameObject(selected:  0);
            this.ClearErrorMessage();
            this.SetLoadingSpinnerVisible(visible:  true);
            this.SetFormEnabled(e:  false);
            bool val_2 = System.String.IsNullOrEmpty(value:  this.EmailField.m_Text);
            if(val_2 != true)
            {
                    val_2.SetDefaultEmailFieldContents(value:  this.EmailField.m_Text);
            }
            
            System.Collections.IEnumerator val_3 = this.SubmitCo();
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  431994272);
        }
        public void Cancel()
        {
            if(this.CancelPressed == 0)
            {
                    return;
            }
            
            this.CancelPressed.Invoke();
        }
        private System.Collections.IEnumerator SubmitCo()
        {
            object val_1 = new System.Object();
            typeof(BugReportSheetController.<SubmitCo>d__18).__il2cppRuntimeField_8 = 0;
            typeof(BugReportSheetController.<SubmitCo>d__18).__il2cppRuntimeField_10 = this;
        }
        private void OnBugReportProgress(float progress)
        {
            if(this.ProgressBar == 0)
            {
                
            }
        
        }
        private void OnBugReportComplete(bool didSucceed, string errorMessage)
        {
            string val_1;
            var val_2;
            if(didSucceed != false)
            {
                    this.ClearForm();
                val_1 = 0;
                val_2 = "Bug report submitted successfully";
            }
            else
            {
                    val_1 = errorMessage;
                val_2 = "Error sending bug report";
            }
            
            this.ShowErrorMessage(userMessage:  432459376, serverMessage:  val_1);
            this.SetLoadingSpinnerVisible(visible:  false);
            this.SetFormEnabled(e:  true);
            if(this.SubmitComplete == 0)
            {
                    return;
            }
            
            this.SubmitComplete.Invoke(arg1:  didSucceed, arg2:  errorMessage);
        }
        protected void SetLoadingSpinnerVisible(bool visible)
        {
            UnityEngine.GameObject val_1 = this.ProgressBar.gameObject;
            this.ProgressBar.SetActive(value:  visible);
            this.ButtonContainer.SetActive(value:  visible ^ 1);
        }
        protected void ClearForm()
        {
            bool val_2 = static_value_021FB56C;
            if(val_2 != true)
            {
                    val_2 = true;
            }
            
            string val_1 = this.GetDefaultEmailFieldContents();
            this.EmailField.text = 1;
            this.DescriptionField.text = 1098586544;
        }
        protected void ShowErrorMessage(string userMessage, string serverMessage)
        {
            string val_5;
            var val_6;
            val_5 = userMessage;
            val_6 = 35632493;
            if((System.String.IsNullOrEmpty(value:  serverMessage)) != true)
            {
                    val_6 = null;
                typeof(System.Object[]).__il2cppRuntimeField_10 = serverMessage;
                string val_2 = SRF.SRFStringExtensions.Fmt(formatString:  432849776, args:  472754880);
                string val_3 = val_5 + 432849776;
                val_5 = val_5;
            }
            
            UnityEngine.GameObject val_4 = this.ResultMessageText.gameObject;
            this.ResultMessageText.SetActive(value:  true);
        }
        protected void ClearErrorMessage()
        {
            UnityEngine.GameObject val_1 = this.ResultMessageText.gameObject;
            this.ResultMessageText.SetActive(value:  false);
        }
        protected void SetFormEnabled(bool e)
        {
            this.SubmitButton.interactable = e;
            this.CancelButton.interactable = e;
            this.EmailField.interactable = e;
            this.DescriptionField.interactable = e;
        }
        private string GetDefaultEmailFieldContents()
        {
            return UnityEngine.PlayerPrefs.GetString(key:  433259600, defaultValue:  1098586544);
        }
        private void SetDefaultEmailFieldContents(string value)
        {
            UnityEngine.PlayerPrefs.SetString(key:  433259600, value:  value);
            bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
        }
        public BugReportSheetController()
        {
        
        }
    
    }

}
