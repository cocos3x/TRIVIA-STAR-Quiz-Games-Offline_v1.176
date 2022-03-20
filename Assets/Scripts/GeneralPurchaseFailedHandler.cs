using UnityEngine;
public class GeneralPurchaseFailedHandler : SpecialPurchaseHandler
{
    // Fields
    private UnityEngine.GameObject _purchaseFailedWindow;
    
    // Properties
    public override string PackageId { get; }
    
    // Methods
    public override string get_PackageId()
    {
        System.NotImplementedException val_1 = new System.NotImplementedException();
    }
    public override void HandlePurchase(ref PurchaseModel purchased)
    {
        System.NotImplementedException val_1 = new System.NotImplementedException();
    }
    public override void HandlePurchaseFailed()
    {
    
    }
    public override bool CanHandlePurchase(string id)
    {
        return false;
    }
    public GeneralPurchaseFailedHandler()
    {
    
    }

}
