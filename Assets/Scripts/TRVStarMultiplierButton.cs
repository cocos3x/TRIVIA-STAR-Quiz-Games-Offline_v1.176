using UnityEngine;
public class TRVStarMultiplierButton : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button myButton;
    private UnityEngine.UI.Text displayText;
    private System.Action doOnTap;
    
    // Methods
    private void OnEnable()
    {
        this.myButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -447206752, method:  new IntPtr(3847735520));
        this.myButton.m_OnClick.AddListener(call:  162246656);
    }
    public void Setup(string myText, System.Action onClickAction)
    {
        this.doOnTap = onClickAction;
        if(this.displayText == 0)
        {
            
        }
    
    }
    public void SetSelectedUI(bool selected)
    {
        selected = selected ^ 1;
        this.myButton.interactable = selected;
    }
    private void OnClick()
    {
        if(this.doOnTap == 0)
        {
                return;
        }
        
        this.doOnTap.Invoke();
    }
    public TRVStarMultiplierButton()
    {
    
    }

}
