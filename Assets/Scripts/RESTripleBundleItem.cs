using UnityEngine;
public class RESTripleBundleItem : MonoBehaviour
{
    // Fields
    private UGUINetworkedButtonMultiGraphic purchaseButton;
    private UnityEngine.UI.Text priceTxt;
    private UnityEngine.UI.Text rewardTxt;
    private int packageIndex;
    private System.Action<bool, int> onPurchaseClick;
    
    // Methods
    public void Setup(int packageIndex, string price, string reward, System.Action<bool, int> onPurchaseClick)
    {
        string val_1 = -1467947360(-1467947360) + reward;
        this.packageIndex = packageIndex;
        this.onPurchaseClick = onPurchaseClick;
        System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -654141680, method:  new IntPtr(3640800592));
        mem2[0] = null;
    }
    private void OnConnectionClick(bool result)
    {
        if(this.onPurchaseClick == 0)
        {
                return;
        }
        
        this.onPurchaseClick.Invoke(arg1:  result, arg2:  this.packageIndex);
    }
    public RESTripleBundleItem()
    {
    
    }

}
