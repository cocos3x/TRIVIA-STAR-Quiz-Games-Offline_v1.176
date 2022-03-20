using UnityEngine;
public class PurchasesComponent : AppComponent
{
    // Properties
    public override bool RunInMainThread { get; }
    
    // Methods
    public override bool get_RunInMainThread()
    {
        return true;
    }
    public PurchasesComponent(string gameName, string gameObjectName)
    {
        mem[1152921511247662096] = "PurchasesComponent";
    }
    public override void initializeOnMainThread()
    {
        var val_6;
        var val_7;
        var val_8;
        this.Log(message:  -1949023296);
        string val_1 = this.getPurchaseKey();
        var val_6 = 25931089;
        val_6 = 9694968 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        App.inAppPurchasesManager.Init(key:  -1948998160);
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_7 = null;
        val_7 = null;
        App.inAppPurchasesManager.Logging = true;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_8 = null;
        val_8 = null;
        AppConfigs val_2 = App.Configuration;
        System.String[] val_3 = 0.GetSkus();
        App.inAppPurchasesManager.SetPurchaseables(packs:  null);
        WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action val_5 = new System.Action(object:  -1948998160, method:  new IntPtr(2345944112));
        Async(callback:  7454720, when:  null);
    }
    private void QueryInventory()
    {
        var val_17;
        var val_18;
        AppConfigs val_1 = App.Configuration;
        System.String[] val_2 = 0.GetSkus();
        string val_3 = PrettyPrint.printJSON(obj:  0, types:  false, singleLineOutput:  false);
        string val_4 = -1948910160(-1948910160) + null;
        UnityEngine.Debug.Log(message:  -1948910160);
        val_17 = null;
        val_17 = null;
        AppConfigs val_5 = App.Configuration;
        System.String[] val_6 = 0.GetSkusBy(cat:  0);
        AppConfigs val_7 = App.Configuration;
        System.String[] val_8 = 0.GetSkusBy(cat:  1);
        App.inAppPurchasesManager.QueryInventory(prodSkus:  null, subSkus:  null);
        val_18 = null;
        val_18 = null;
        if(Logger.Store != false)
        {
                AppConfigs val_9 = App.Configuration;
            System.String[] val_10 = 0.GetSkus();
            string val_11 = PrettyPrint.printJSON(obj:  0, types:  false, singleLineOutput:  false);
            string val_12 = -1948910160(-1948910160) + null;
            UnityEngine.Debug.Log(message:  -1948910160);
            val_18 = null;
        }
        
        val_18 = null;
        if(Logger.Store == false)
        {
                return;
        }
        
        AppConfigs val_13 = App.Configuration;
        System.String[] val_14 = 0.GetIds();
        string val_15 = PrettyPrint.printJSON(obj:  0, types:  false, singleLineOutput:  false);
        string val_16 = -1948910080(-1948910080) + null;
        UnityEngine.Debug.Log(message:  -1948910080);
    }
    private string getPurchaseKey()
    {
        AppConfigs val_1 = App.Configuration;
        if(0 != 0)
        {
                return 0.Key(key:  -1976771616);
        }
        
        return 0.Key(key:  -1976771616);
    }

}
