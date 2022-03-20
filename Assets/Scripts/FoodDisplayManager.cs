using UnityEngine;
public class FoodDisplayManager : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform itemContainer;
    private System.Collections.Generic.List<WGStoreItem_pet> packDisplays;
    
    // Methods
    public void CreatePackItems(UnityEngine.Transform packItemContainer)
    {
        this.itemContainer = packItemContainer;
        object val_1 = packItemContainer.GetComponent<System.Object>();
        packItemContainer.spacing = null;
        WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Collections.Generic.List<PurchaseModel> val_3 = RetrievePetsFoodPurchasePacks();
        do
        {
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            UnityEngine.GameObject val_5 = Prefab_storePetFoodItem;
            object val_6 = UnityEngine.Object.Instantiate<System.Object>(original:  -1261410688, parent:  this.itemContainer);
            object val_7 = GetComponent<System.Object>();
            35627916 = this.packDisplays;
            35627916.Add(item:  -1261410688);
        }
        while(35627916 != 0);
        
        this.RefreshPackItems();
    }
    public void RefreshPackItems()
    {
        var val_4;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Collections.Generic.List<PurchaseModel> val_2 = RetrievePetsFoodPurchasePacks();
        val_4 = 4;
        goto label_4;
        label_14:
        if((public static WGStoreController MonoSingletonSelfGenerating<WGStoreController>::get_Instance()) <= R6)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_4 = 5;
        label_4:
        if((val_4 - 4) < 2621443)
        {
            goto label_14;
        }
    
    }
    public FoodDisplayManager()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.packDisplays = null;
    }

}
