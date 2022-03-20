using UnityEngine;
public class WGStoreController : MonoSingletonSelfGenerating<WGStoreController>
{
    // Fields
    public System.Action<PurchaseModel> OnStorePurchaseSuccess;
    public System.Action<string, string> OnStorePurchaseFailed;
    
    // Methods
    private void Start()
    {
        var val_5;
        System.Delegate val_6;
        var val_7;
        System.Action<twelvegigs.storage.JsonDictionary> val_8;
        System.Delegate val_9;
        val_5 = null;
        val_5 = null;
        System.Action<twelvegigs.storage.JsonDictionary> val_1 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  66274928, method:  new IntPtr(66248880));
        val_6 = PurchasesHandler.OnPurchaseCompleted;
        System.Delegate val_2 = System.Delegate.Combine(a:  val_6, b:  7401472);
        val_7 = null;
        val_8 = null;
        if(val_6 == 0)
        {
            goto label_3;
        }
        
        if(null == val_8)
        {
            goto label_4;
        }
        
        val_8 = null;
        val_7 = 1152921504898486364;
        label_3:
        val_6 = 0;
        label_4:
        PurchasesHandler.OnPurchaseCompleted = val_6;
        val_8 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  66274928, method:  new IntPtr(66249904));
        val_9 = PurchasesHandler.OnPurchaseFailure;
        System.Delegate val_4 = System.Delegate.Combine(a:  val_9, b:  7401472);
        if(val_9 != 0)
        {
                if(null == null)
        {
            goto label_6;
        }
        
        }
        
        val_9 = 0;
        label_6:
        PurchasesHandler.OnPurchaseFailure = val_9;
    }
    private void PurchasesHandler_OnPurchaseCompleted(PurchaseModel obj)
    {
        if((obj.ContainsInstruction(instruction:  2)) == false)
        {
                return;
        }
        
        string val_2 = R4.ToShortString();
        string val_3 = System.String.Format(format:  66367024, arg0:  R4);
        SLCDebug.Log(logMessage:  66367024, colorHash:  66367216, isError:  false);
        HandlePurchaseSuccess(purchase:  R4);
    }
    private void PurchasesHandler_OnPurchaseFailure(PurchaseModel obj)
    {
        var val_7;
        var val_8;
        var val_9;
        val_7 = 35633513;
        if((obj.ContainsInstruction(instruction:  2)) == false)
        {
                return;
        }
        
        string val_2 = obj.ToShortString();
        string val_3 = System.String.Format(format:  66487504, arg0:  obj);
        SLCDebug.Log(logMessage:  66487504, colorHash:  66487696, isError:  false);
        string val_4 = Localization.Localize(key:  -1349324784, defaultValue:  -1349324896, useSingularKey:  false);
        val_8 = 0;
        string val_5 = Localization.Localize(key:  -1349324672, defaultValue:  -1349324544, useSingularKey:  false);
        val_7 = "purchase_failed_explanation";
        val_9 = null;
        val_9 = null;
        if((WGStoreController.<>c.<>9__2_0) == 0)
        {
                val_8 = 0;
            System.Action val_6 = new System.Action(object:  WGStoreController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(66487792));
            WGStoreController.<>c.<>9__2_0 = null;
        }
        
        this.HandlePurchaseFailed(title:  -1349324784, message:  -1349324672, onCloseMessageAction:  0);
    }
    public System.Collections.Generic.List<PurchaseModel> RetrievePurchasePacks()
    {
        string val_5 = "credits";
        System.Collections.IList val_1 = PackagesManager.GetPackages(packageType:  2129282688);
        if(val_5 == 0)
        {
                val_5 = "No packages found in PackagesManager.GetPackages()... PROBABLY NOT THE RIGHT GAME OR SOMETHING.";
            UnityEngine.Debug.LogError(message:  66604912);
        }
        
        System.Collections.Generic.List<PurchaseModel> val_2 = PurchaseModelsFromPacks(packs:  2129282688);
        GameBehavior val_3 = App.getBehavior;
        float val_4 = PackagesManager.GetBestValuePackPrice(unfiltered:  0);
    }
    public System.Collections.Generic.List<PurchaseModel> RetrieveGemPurchasePacks()
    {
        System.Collections.IList val_1 = PackagesManager.GetPackages(packageType:  -1930648496);
        if("gems" != 0)
        {
                return PurchaseModelsFromPacks(packs:  -1930648496);
        }
        
        UnityEngine.Debug.LogError(message:  66604912);
        return PurchaseModelsFromPacks(packs:  -1930648496);
    }
    public System.Collections.Generic.List<PurchaseModel> RetrievePetsFoodPurchasePacks()
    {
        System.Collections.IList val_1 = PackagesManager.GetPackages(packageType:  -1827757824);
        if("pets_food" != 0)
        {
                return PurchaseModelsFromPacks(packs:  -1827757824);
        }
        
        UnityEngine.Debug.LogError(message:  66604912);
        return PurchaseModelsFromPacks(packs:  -1827757824);
    }
    public System.Collections.Generic.List<PurchaseModel> RetrieveSpinPurchasePacks()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        System.Collections.IList val_2 = PackagesManager.GetPackages(packageType:  -1987367328);
        if("spins" != 0)
        {
                return PurchaseModelsFromPacks(packs:  -1987367328);
        }
        
        UnityEngine.Debug.LogError(message:  66604912);
        return PurchaseModelsFromPacks(packs:  -1987367328);
    }
    public System.Collections.Generic.List<PurchaseModel> RetrieveDiceRollsPurchasePacks()
    {
        System.Collections.IList val_1 = PackagesManager.GetPackages(packageType:  -1825935120);
        if("dice_rolls" != 0)
        {
                return PurchaseModelsFromPacks(packs:  -1825935120);
        }
        
        UnityEngine.Debug.LogError(message:  66604912);
        return PurchaseModelsFromPacks(packs:  -1825935120);
    }
    private System.Collections.Generic.List<PurchaseModel> PurchaseModelsFromPacks(System.Collections.IList packs)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_7 = 0;
        val_8 = 0;
        val_7 = val_7 + 1;
        val_8 = (uint)val_7 & 65535;
        val_9 = packs;
        label_21:
        val_7 = 0;
        val_8 = 0;
        val_7 = val_7 + 1;
        val_8 = (uint)val_7 & 65535;
        val_10 = packs;
        if(packs == 0)
        {
            goto label_11;
        }
        
        var val_7 = 0;
        val_7 = val_7 + 1;
        val_11 = packs;
        PurchaseModel val_5 = new PurchaseModel(json:  0);
        Add(item:  292597760);
        goto label_21;
        label_11:
        if(packs != 0)
        {
                val_7 = 0;
            val_7 = val_7 + 1;
            val_12 = packs;
        }
        
        if(0 == 0)
        {
                return;
        }
    
    }
    public void Purchase(PurchaseModel purchase)
    {
        var val_6;
        var val_7;
        purchase.AddInstruction(instruction:  2);
        if((PurchaseProxy.Purchase(purchase:  purchase)) != false)
        {
                NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            0.PostNotification(aSender:  67316832, aName:  -1175043120);
            return;
        }
        
        string val_3 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        val_6 = 0;
        string val_4 = Localization.Localize(key:  -1725759984, defaultValue:  67291520, useSingularKey:  false);
        val_7 = null;
        val_7 = null;
        if((WGStoreController.<>c.<>9__9_0) == 0)
        {
                val_6 = 0;
            System.Action val_5 = new System.Action(object:  WGStoreController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(67291808));
            WGStoreController.<>c.<>9__9_0 = null;
        }
        
        this.HandlePurchaseFailed(title:  -1725760224, message:  -1725759984, onCloseMessageAction:  0);
    }
    public void HandlePurchaseSuccess(PurchaseModel purchase)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1261410688) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        DisplayPurchaseSuccess(purchase:  purchase);
    }
    public void HandlePurchaseFailed(string title, string message, System.Action onCloseMessageAction)
    {
        if(this.OnStorePurchaseFailed != 0)
        {
                this.OnStorePurchaseFailed.Invoke(arg1:  title, arg2:  message);
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1261410688) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        DisplayPurchaseFail(title:  title, message:  message);
    }
    public bool OpenStore(bool forceShowNext = False)
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                return true;
        }
        
        return true;
    }
    public WGStoreController()
    {
    
    }

}
