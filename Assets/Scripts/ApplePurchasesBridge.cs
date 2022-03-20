using UnityEngine;
public class ApplePurchasesBridge : PurchasesBridge, PluginObserver
{
    // Fields
    private bool initialized;
    
    // Methods
    public PluginObserverManager.ObserverType getType()
    {
    
    }
    public string pluginName()
    {
    
    }
    public string errorMessage()
    {
        var val_1;
        if(this.initialized != false)
        {
                if(R1 == 0)
        {
                val_1 = "Failed to query the inventory, service not working.";
        }
        
            return;
        }
        
        val_1 = "Not initialized!";
    }
    public bool isWorking()
    {
        if(R4 != 0)
        {
                return (bool)R4 + 12;
        }
        
        return (bool)R4 + 12;
    }
    public bool isInitialized()
    {
        return (bool)this.initialized;
    }
    public ApplePurchasesBridge(InAppPurchasesManager manager)
    {
    
    }

}
