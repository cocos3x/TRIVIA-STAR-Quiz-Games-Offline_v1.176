using UnityEngine;
public class PurchaseProxy
{
    // Fields
    private static TrackerPurchasePoints currentPurchasePoint;
    
    // Properties
    public static TrackerPurchasePoints CurrentPurchasePoint { get; set; }
    
    // Methods
    public static TrackerPurchasePoints get_CurrentPurchasePoint()
    {
        null = null;
    }
    public static void set_CurrentPurchasePoint(TrackerPurchasePoints value)
    {
        null = null;
        PurchaseProxy.currentPurchasePoint = value;
    }
    public static bool Purchase(PurchaseModel purchase)
    {
        var val_5;
        var val_6;
        InAppPurchasesManager val_7;
        var val_8;
        var val_9;
        var val_10;
        AppConfigs val_1 = App.Configuration;
        ProductDetails val_2 = 0.GetProductByInternalId(internalId:  purchase.id);
        if(0 != 0)
        {
                purchase.<Sku>k__BackingField = 0;
        }
        else
        {
                purchase.<Sku>k__BackingField = 0;
        }
        
        bool val_5 = true;
        val_5 = val_5 - 2;
        val_5 = val_5 >> 5;
        purchase.isSubscription = val_5;
        if(purchase.trackerPurchasePoint == 0)
        {
                val_5 = null;
            val_5 = null;
            purchase.trackerPurchasePoint = PurchaseProxy.currentPurchasePoint;
        }
        
        TrackingComponent.CurrentIntent = 2;
        var val_6 = 25932717;
        val_6 = 9693340 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        val_7 = App.inAppPurchasesManager;
        val_8 = 0;
        if((val_7.Purchase(purchase:  purchase)) == false)
        {
                return (bool)val_8;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1792403808, value:  purchase.id);
        var val_7 = 25931946;
        val_7 = 9693592 + val_7;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = null;
        val_9 = null;
        val_10 = null;
        val_10 = null;
        val_7 = Events.PURCHASE_INTENT;
        App.trackerManager.track(eventName:  val_7, data:  78753792);
        val_8 = 1;
        return (bool)val_8;
    }
    public PurchaseProxy()
    {
    
    }
    private static PurchaseProxy()
    {
    
    }

}
