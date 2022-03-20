using UnityEngine;
public class PurchasePointTracker : MonoBehaviour
{
    // Fields
    private TrackerPurchasePoints currentPoint;
    
    // Methods
    private void Awake()
    {
        object val_1 = this.GetComponent<System.Object>();
        if((-1792968480) != 0)
        {
                UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -1792968480, method:  new IntPtr(2501973632));
            this.AddListener(call:  162246656);
            return;
        }
        
        UnityEngine.Debug.LogWarning(message:  -1792992640, context:  -1792968480);
    }
    public void OnClick()
    {
        var val_1;
        var val_1 = 25933469;
        val_1 = 9692592 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        PurchaseProxy.currentPurchasePoint = this.currentPoint;
    }
    public PurchasePointTracker()
    {
    
    }

}
