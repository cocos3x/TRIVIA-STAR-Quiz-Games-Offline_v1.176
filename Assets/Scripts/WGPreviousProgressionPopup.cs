using UnityEngine;
public class WGPreviousProgressionPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text progressionText;
    private UnityEngine.UI.Button okButton;
    private UnityEngine.UI.Button noButton;
    private UnityEngine.UI.Button cancelButton;
    private System.Action<WGPreviousProgressionPopup.Result> OnClickButton;
    
    // Methods
    public void add_OnClickButton(System.Action<WGPreviousProgressionPopup.Result> value)
    {
        var val_2;
        label_3:
        System.Delegate val_1 = System.Delegate.Combine(a:  this.OnClickButton, b:  value);
        if(this.OnClickButton == 0)
        {
            goto label_1;
        }
        
        val_2 = this.OnClickButton;
        if(null == null)
        {
            goto label_2;
        }
        
        label_1:
        val_2 = 0;
        label_2:
        if(this.OnClickButton != 1152921512980354908)
        {
            goto label_3;
        }
    
    }
    public void remove_OnClickButton(System.Action<WGPreviousProgressionPopup.Result> value)
    {
        var val_2;
        label_3:
        System.Delegate val_1 = System.Delegate.Remove(source:  this.OnClickButton, value:  value);
        if(this.OnClickButton == 0)
        {
            goto label_1;
        }
        
        val_2 = this.OnClickButton;
        if(null == null)
        {
            goto label_2;
        }
        
        label_1:
        val_2 = 0;
        label_2:
        if(this.OnClickButton != 1152921512980483292)
        {
            goto label_3;
        }
    
    }
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -216150464, method:  new IntPtr(4078773376));
        this.okButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -216150464, method:  new IntPtr(4078782592));
        this.noButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -216150464, method:  new IntPtr(4078791808));
        this.cancelButton.m_OnClick.AddListener(call:  162246656);
    }
    public void LoadProgression(RestoreProgressManager.Progression progression)
    {
        string val_1 = Localization.Localize(key:  -216033792, defaultValue:  -216033680, useSingularKey:  false);
        string val_2 = progression.<lastPlayed>k__BackingField.ToString(format:  -216029392);
        typeof(System.Object[]).__il2cppRuntimeField_10 = ;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        string val_3 = System.String.Format(format:  -216033792, args:  472754880);
        if(this.progressionText != 0)
        {
                return;
        }
    
    }
    private void OnClickOk()
    {
        if(this.OnClickButton == 0)
        {
                return;
        }
        
        this.OnClickButton.Invoke(obj:  0);
    }
    private void OnClickNo()
    {
        if(this.OnClickButton == 0)
        {
                return;
        }
        
        this.OnClickButton.Invoke(obj:  1);
    }
    private void OnClickCancel()
    {
        if(this.OnClickButton == 0)
        {
                return;
        }
        
        this.OnClickButton.Invoke(obj:  2);
    }
    public WGPreviousProgressionPopup()
    {
    
    }

}
