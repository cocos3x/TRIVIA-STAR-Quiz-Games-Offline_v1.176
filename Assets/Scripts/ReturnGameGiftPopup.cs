using UnityEngine;
public class ReturnGameGiftPopup : MonoBehaviour
{
    // Fields
    protected UGUINetworkedButtonMultiGraphic collectButton;
    
    // Methods
    protected void Awake()
    {
        System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  -208776400, method:  typeof(ReturnGameGiftPopup).__il2cppRuntimeField_E8);
        mem2[0] = null;
    }
    protected void Start()
    {
        goto typeof(ReturnGameGiftPopup).__il2cppRuntimeField_DC;
    }
    public virtual void Setup(ReturnGameGiftReward reward)
    {
    
    }
    protected virtual void OnConnectionClick(bool connected)
    {
    
    }
    protected virtual void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -208316112, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public ReturnGameGiftPopup()
    {
    
    }

}
