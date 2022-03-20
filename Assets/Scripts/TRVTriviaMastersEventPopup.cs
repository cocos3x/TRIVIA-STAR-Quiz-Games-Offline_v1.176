using UnityEngine;
public class TRVTriviaMastersEventPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button continueButton;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Text progressText;
    private UnityEngine.UI.Image progressBar;
    
    // Methods
    public void SetupUI(string progressText, float progressValue)
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -408331584, method:  new IntPtr(3886594304));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -408331584, method:  new IntPtr(3886594304));
        this.continueButton.m_OnClick.AddListener(call:  162246656);
        this.progressBar.fillAmount = progressValue;
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void OnDisable()
    {
        if((TriviaMastersEventHandler.<Instance>k__BackingField) == 0)
        {
                return;
        }
        
        TriviaMastersEventHandler.<Instance>k__BackingField.OnMyEventPopupClosed();
    }
    public TRVTriviaMastersEventPopup()
    {
    
    }

}
