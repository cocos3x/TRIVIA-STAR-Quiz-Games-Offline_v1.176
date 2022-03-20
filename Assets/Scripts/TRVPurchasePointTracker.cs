using UnityEngine;
public class TRVPurchasePointTracker : MonoBehaviour
{
    // Methods
    private void OnEnable()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        object val_2 = this.GetComponent<System.Object>();
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -460017184, method:  new IntPtr(3834925088));
        this.AddListener(call:  162246656);
    }
    private void OnClick()
    {
        var val_2;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 1)
        {
                return;
        }
        
        var val_2 = 23612317;
        val_2 = 12013744 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        PurchaseProxy.currentPurchasePoint = 1;
    }
    public TRVPurchasePointTracker()
    {
    
    }

}
