using UnityEngine;
public class PurchasesBridge
{
    // Fields
    protected InAppPurchasesManager manager;
    protected bool isLogging;
    
    // Methods
    public PurchasesBridge(InAppPurchasesManager manager)
    {
        InAppPurchasesManager val_1 = manager;
        val_1 = new System.Object();
        this.Log(message:  -1829840848);
        this.manager = val_1;
    }
    public virtual void init(string key)
    {
    
    }
    public virtual void queryInventory(string[] productSkus, string[] subSkus)
    {
        this.manager.Initialized = true;
    }
    public virtual void queryHistory()
    {
    
    }
    public virtual void Purchase(string sku)
    {
        goto typeof(PurchasesBridge).__il2cppRuntimeField_10C;
    }
    public virtual void Subscribe(string sku)
    {
        goto typeof(PurchasesBridge).__il2cppRuntimeField_10C;
    }
    public virtual void RestorePreviousTransactions()
    {
    
    }
    public virtual void Consume(NativePurchase nativePurchase)
    {
        if(nativePurchase.isSubscription != false)
        {
                this.manager.notifySubscription(success:  true, purchaseInfo:  nativePurchase);
            return;
        }
        
        this.manager.notify(success:  true, purchaseInfo:  nativePurchase);
    }
    protected virtual NativePurchase BuildPurchase(object parameters)
    {
        var val_2;
        if(parameters != 0)
        {
                if(null != null)
        {
                val_2 = 0;
        }
        
        }
        else
        {
                val_2 = 0;
        }
        
        NativePurchase val_1 = new NativePurchase(sku:  null);
    }
    public virtual void setLogging(bool isLogging)
    {
        this.isLogging = isLogging;
    }
    public virtual void setPurchasePackages(string[] purchasePackages)
    {
    
    }
    protected void Log(string message)
    {
        if(this.isLogging == false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  message);
    }

}
