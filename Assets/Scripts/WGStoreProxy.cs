using UnityEngine;
public class WGStoreProxy : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject packItemPrefab;
    private UnityEngine.Transform packItemsParent;
    private GridCoinCollectAnimationInstantiator coinsAnimControl;
    private bool oocFlow;
    private TrackerPurchasePoints originalEntryPoint;
    private System.Action onClose;
    
    // Methods
    public void Init(bool outOfCredits = False, System.Action onCloseAction)
    {
        this.oocFlow = outOfCredits;
        this.onClose = onCloseAction;
    }
    private System.Collections.IEnumerator WaitForInit()
    {
        object val_1 = new System.Object();
        typeof(WGStoreProxy.<WaitForInit>d__7).__il2cppRuntimeField_8 = 0;
        typeof(WGStoreProxy.<WaitForInit>d__7).__il2cppRuntimeField_10 = this;
    }
    private void OnEnable()
    {
        System.Collections.IEnumerator val_1 = this.WaitForInit();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  70122848);
        if((CPlayerPrefs.GetInt(key:  -1055927136, defaultValue:  0)) != 1)
        {
                return;
        }
        
        CPlayerPrefs.SetInt(key:  R5, val:  2);
        CPlayerPrefs.Save();
    }
    private void ShowContent()
    {
        var val_10;
        var val_11;
        var val_12;
        var val_10 = 25555592;
        val_10 = 10070468 + val_10;
        if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
        val_10 = null;
        val_10 = null;
        this.originalEntryPoint = PurchaseProxy.currentPurchasePoint;
        if(this.oocFlow != false)
        {
                if((SuperBundleEventHandler._Instance != 0) && (SuperBundleEventHandler._Instance.CanShowSuperBundleOnStoreOOCFlow() != false))
        {
                val_11 = 10070696 + 25555365;
            if(val_11 == 0)
        {
                mem2[0] = 1;
        }
        
            val_12 = null;
            val_12 = null;
            PurchaseProxy.currentPurchasePoint = this.originalEntryPoint;
        }
        else
        {
                if(this.oocFlow != false)
        {
                val_11 = 1152921512364436848;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-832344720) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((CanDisplayWaterfallSale(oocFlow:  true)) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Action<System.Boolean> val_7 = new System.Action<System.Boolean>(object:  70242016, method:  new IntPtr(70214944));
            ShowPopup(oocFlow:  true, storeCloseCallback:  7401472);
            return;
        }
        
        }
        
        }
        
        }
        
        }
        
        WordPets.WPTDataParser val_8 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<System.Boolean, System.Boolean> val_9 = new System.Action<System.Boolean, System.Boolean>(object:  70242016, method:  new IntPtr(70215968));
        ShowStore(categoryFocus:  1098586544, storeCloseCallback:  7507968);
    }
    private void OnCloseCallback(bool purchased, bool forcedClose)
    {
        System.Action val_4;
        var val_5;
        var val_6;
        val_4 = this;
        val_5 = forcedClose;
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  70362320, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        val_6 = 0;
        val_6.PostNotification(aSender:  70362320, aName:  70334112);
        if(val_5 != false)
        {
                val_4 = this.onClose;
        }
        else
        {
                GameBehavior val_3 = App.getBehavior;
            val_6 = 0;
            if(this.oocFlow == true)
        {
                val_5 = 1;
        }
        
            if(this.onClose != 0)
        {
                this.onClose.Invoke();
        }
        
        }
        
        this.onClose = 0;
    }
    private void OnDisable()
    {
    
    }
    public WGStoreProxy()
    {
    
    }
    private void <ShowContent>b__9_0(bool purchased)
    {
        var val_3;
        if(purchased != false)
        {
                this.OnCloseCallback(purchased:  true, forcedClose:  true);
            return;
        }
        
        var val_3 = 25551473;
        val_3 = 10074588 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        PurchaseProxy.currentPurchasePoint = this.originalEntryPoint;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<System.Boolean, System.Boolean> val_2 = new System.Action<System.Boolean, System.Boolean>(object:  70706512, method:  new IntPtr(70215968));
        ShowStore(categoryFocus:  1098586544, storeCloseCallback:  7507968);
    }

}
