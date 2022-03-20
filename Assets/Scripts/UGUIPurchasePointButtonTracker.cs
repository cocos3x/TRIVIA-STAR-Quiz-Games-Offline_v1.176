using UnityEngine;
public class UGUIPurchasePointButtonTracker : MonoBehaviour
{
    // Fields
    private TrackerPurchasePoints purchasePoint;
    protected UnityEngine.UI.Button button;
    
    // Methods
    protected virtual void Start()
    {
        object val_1 = this.GetComponent<System.Object>();
        this.button = this;
        if((-174578192) == 0)
        {
                return;
        }
        
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -174578192, method:  new IntPtr(4120364080));
        this.button.m_OnClick.AddListener(call:  162246656);
    }
    public void OnButtonClick()
    {
        var val_1;
        var val_1 = 28207193;
        val_1 = 7418868 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        PurchaseProxy.currentPurchasePoint = this.purchasePoint;
    }
    public UGUIPurchasePointButtonTracker()
    {
    
    }

}
