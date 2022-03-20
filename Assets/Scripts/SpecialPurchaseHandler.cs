using UnityEngine;
public abstract class SpecialPurchaseHandler : MonoBehaviour
{
    // Properties
    public abstract string PackageId { get; }
    
    // Methods
    public abstract string get_PackageId(); // 0
    public abstract void HandlePurchase(ref PurchaseModel purchased); // 0
    public virtual void HandlePurchaseFailed()
    {
    
    }
    public abstract bool CanHandlePurchase(string id); // 0
    protected SpecialPurchaseHandler()
    {
    
    }

}
