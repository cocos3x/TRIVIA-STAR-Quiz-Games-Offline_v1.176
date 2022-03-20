using UnityEngine;
public class WGEmailLoginPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject emailGroup;
    private UnityEngine.UI.InputField emailInput;
    private UnityEngine.UI.Button submitEmail;
    private UnityEngine.UI.Text emailValidError;
    private UnityEngine.GameObject confirmGroup;
    private UnityEngine.UI.InputField codeInput;
    private UnityEngine.UI.Button submitCode;
    private UnityEngine.UI.Button resendCode;
    private UnityEngine.UI.Text alertMessage;
    private UnityEngine.GameObject loadingImage;
    private System.Action<bool> OnLoginAction;
    private string userEmail;
    private string verificationCode;
    private bool resendCodeRequest;
    
    // Methods
    public void add_OnLoginAction(System.Action<bool> value)
    {
        var val_2;
        label_3:
        System.Delegate val_1 = System.Delegate.Combine(a:  this.OnLoginAction, b:  value);
        if(this.OnLoginAction == 0)
        {
            goto label_1;
        }
        
        val_2 = this.OnLoginAction;
        if(null == null)
        {
            goto label_2;
        }
        
        label_1:
        val_2 = 0;
        label_2:
        if(this.OnLoginAction != 1152921512978420308)
        {
            goto label_3;
        }
    
    }
    public void remove_OnLoginAction(System.Action<bool> value)
    {
        var val_2;
        label_3:
        System.Delegate val_1 = System.Delegate.Remove(source:  this.OnLoginAction, value:  value);
        if(this.OnLoginAction == 0)
        {
            goto label_1;
        }
        
        val_2 = this.OnLoginAction;
        if(null == null)
        {
            goto label_2;
        }
        
        label_1:
        val_2 = 0;
        label_2:
        if(this.OnLoginAction != 1152921512978548692)
        {
            goto label_3;
        }
    
    }
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -218066656, method:  new IntPtr(4076838752));
        this.submitEmail.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -218066656, method:  new IntPtr(4076847968));
        this.submitCode.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -218066656, method:  new IntPtr(4076857184));
        this.resendCode.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder> val_4 = new UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder>(object:  -218066656, method:  new IntPtr(4076866400));
        this.emailInput.m_OnEndEdit.AddListener(call:  162353152);
        UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder> val_5 = new UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder>(object:  -218066656, method:  new IntPtr(4076875616));
        this.codeInput.m_OnEndEdit.AddListener(call:  162353152);
    }
    public void UpdateUI(WGEmailLoginPopup.State state)
    {
        this.emailGroup.SetActive(value:  true);
        this.confirmGroup.SetActive(value:  (state - 1) >> 5);
        UnityEngine.GameObject val_3 = this.emailValidError.gameObject;
        this.emailValidError.SetActive(value:  false);
        UnityEngine.GameObject val_4 = this.alertMessage.gameObject;
        this.alertMessage.SetActive(value:  false);
        this.loadingImage.SetActive(value:  false);
        this.resendCode.interactable = true;
        if(this.resendCodeRequest == false)
        {
                return;
        }
        
        if(state != 1)
        {
                return;
        }
        
        this.ShowAlertMessage(errorCode:  false);
        this.resendCodeRequest = false;
    }
    public void Close()
    {
        if(this.OnLoginAction == 0)
        {
                return;
        }
        
        this.OnLoginAction.Invoke(obj:  false);
    }
    public void ShowAlertMessage(bool errorCode)
    {
        UnityEngine.GameObject val_1 = this.alertMessage.gameObject;
        this.alertMessage.SetActive(value:  true);
        if(errorCode == true)
        {
                "Code Sent! Check your Inbox!" = "We\'re Sorry, the code didn\'t match. Input the right code or try resending another one.";
        }
        
        if(errorCode == true)
        {
                "code_sent" = "email_code_error";
        }
        
        string val_2 = Localization.Localize(key:  -217643680, defaultValue:  -217644064, useSingularKey:  false);
        if(this.alertMessage == 0)
        {
            
        }
    
    }
    private void OnClickSubmitEmail()
    {
        if((System.String.IsNullOrEmpty(value:  this.userEmail)) == true)
        {
                return;
        }
        
        Player val_2 = App.Player;
        mem[160] = this.userEmail;
        Player val_3 = App.Player;
        0.SaveState();
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        OnEmailLogin(email:  this.userEmail);
        if(this.OnLoginAction == 0)
        {
                return;
        }
        
        this.OnLoginAction.Invoke(obj:  true);
    }
    private void OnClickSubmitCode()
    {
        if((System.String.IsNullOrEmpty(value:  this.verificationCode)) == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ConfirmVerificationCode(code:  this.verificationCode);
        if(this.OnLoginAction == 0)
        {
                return;
        }
        
        this.OnLoginAction.Invoke(obj:  true);
    }
    private void OnClickResendCode()
    {
        this.resendCodeRequest = true;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Player val_2 = App.Player;
        OnEmailLogin(email:  34483956);
        UnityEngine.GameObject val_3 = this.alertMessage.gameObject;
        this.alertMessage.SetActive(value:  false);
        this.resendCode.interactable = false;
        this.submitCode.interactable = false;
        this.loadingImage.SetActive(value:  true);
    }
    private void OnValueChanged_Email(string value)
    {
        UnityEngine.UI.Button val_3 = this.submitEmail;
        val_3.interactable = false;
        if(value.m_stringLength == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = this.emailValidError.gameObject;
        if((value.m_stringLength.isValidEmail(email:  value)) != false)
        {
                this.emailValidError.SetActive(value:  false);
            val_3 = this.submitEmail;
            val_3.interactable = true;
            this.userEmail = value;
            return;
        }
        
        this.emailValidError.SetActive(value:  true);
    }
    private void OnValueChanged_Code(string value)
    {
        UnityEngine.UI.Button val_2 = this.submitCode;
        val_2.interactable = false;
        if(value.m_stringLength == 0)
        {
                return;
        }
        
        if((value.m_stringLength.isNumber(value:  value)) == false)
        {
                return;
        }
        
        val_2 = this.submitCode;
        val_2.interactable = true;
        this.verificationCode = value;
    }
    private bool isValidEmail(string email)
    {
        System.Text.RegularExpressions.Regex val_1 = new System.Text.RegularExpressions.Regex(pattern:  -216807632, options:  1);
        if(null != 0)
        {
                return IsMatch(input:  email);
        }
        
        return IsMatch(input:  email);
    }
    private bool isNumber(string value)
    {
        System.Text.RegularExpressions.Regex val_1 = new System.Text.RegularExpressions.Regex(pattern:  -216687072, options:  1);
        if(null != 0)
        {
                return IsMatch(input:  value);
        }
        
        return IsMatch(input:  value);
    }
    public WGEmailLoginPopup()
    {
    
    }

}
