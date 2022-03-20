using UnityEngine;
public class LimitedTimeBundlesPackDisplayManager : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform itemContainer;
    private LimitedTimeBundlesPopup myPopup;
    private System.Collections.Generic.List<LimitedTimeBundlePackDisplay> packDisplays;
    private System.Collections.Generic.List<string> alphabetLetters;
    
    // Methods
    public void CreatePackItems(UnityEngine.Transform packItemContainer, LimitedTimeBundlesPopup popupContainer)
    {
        LimitedTimeBundlesPopup val_9;
        System.Collections.Generic.List<LimitedTimeBundlePackDisplay> val_10;
        val_9 = popupContainer;
        val_10 = 35632248;
        this.itemContainer = packItemContainer;
        this.myPopup = val_9;
        object val_1 = packItemContainer.GetComponent<System.Object>();
        packItemContainer.spacing = null;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>> val_3 = GetAllBundles();
        int val_4 = Count;
        if(val_4 >= 1)
        {
                var val_9 = val_4;
            do
        {
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            LimitedTimeBundlePackDisplay val_6 = prefab_limited_time_bundle;
            object val_7 = UnityEngine.Object.Instantiate<System.Object>(original:  -1566656096, parent:  this.itemContainer);
            val_10 = this.packDisplays;
            val_9 = public static LimitedTimeBundlesManager MonoSingleton<LimitedTimeBundlesManager>::get_Instance();
            val_10.Add(item:  -1566656096);
            val_9 = val_9 - 1;
        }
        while(val_10 != 0);
        
        }
        
        this.RefreshPackItems();
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static LimitedTimeBundlesManager MonoSingleton<LimitedTimeBundlesManager>::get_Instance().__il2cppRuntimeField_C = this;
    }
    public void RefreshPackItems()
    {
        LimitedTimeBundlesPackDisplayManager val_28;
        var val_29;
        var val_30;
        float val_31;
        val_28 = this;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_2 = HaveBundlesToShow();
        val_29 = 0;
        if(val_2 != false)
        {
                if(val_2 > false)
        {
                val_29 = 1;
        }
        
        }
        
        if(this.itemContainer != 0)
        {
                UnityEngine.GameObject val_4 = this.itemContainer.gameObject;
            this.itemContainer.SetActive(value:  true);
        }
        
        if(1 == 0)
        {
                return;
        }
        
        System.Collections.Generic.List<System.String> val_5 = LimitedTimeBundlesManager.BundlePackagesKeys;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.Dictionary<System.String, System.Object>> val_7 = GetAvailableBundles();
        val_30 = 0;
        val_31 = 1152921512034073056;
        if(this.myPopup == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_23 = this.itemContainer.transform;
        UnityEngine.Transform val_24 = this.itemContainer.parent;
        UnityEngine.GameObject val_25 = this.itemContainer.gameObject;
        this.itemContainer.SetActive(value:  false);
        System.Collections.IEnumerator val_26 = this.WaitAndActivateItemContainer();
        UnityEngine.Coroutine val_27 = val_28.StartCoroutine(routine:  -1158563552);
    }
    public void PrepareBundlePurchaseSuccess(System.Collections.Generic.List<string> alphabetLettersPurchased)
    {
        LimitedTimeBundlesPopup val_7;
        System.Action val_8;
        var val_9;
        System.Action val_10;
        var val_11;
        var val_12;
        GameBehavior val_1 = App.getBehavior;
        val_7 = 0;
        this.alphabetLetters = alphabetLettersPurchased;
        if(val_7 == 0)
        {
            goto label_5;
        }
        
        if(this.myPopup == 0)
        {
            goto label_8;
        }
        
        val_7 = this.myPopup;
        val_8 = null;
        val_9 = 1152921512038346976;
        goto label_9;
        label_5:
        if(this.myPopup == 0)
        {
            goto label_12;
        }
        
        val_7 = this.myPopup;
        val_8 = null;
        val_9 = 1152921512038352096;
        label_9:
        val_8 = new System.Action(object:  -1158404448, method:  new IntPtr(3136537824));
        val_10 = this.myPopup.OnAnimationsComplete;
        goto label_14;
        label_8:
        val_8 = null;
        val_11 = 1152921512038346976;
        goto label_15;
        label_12:
        val_8 = null;
        val_11 = 1152921512038352096;
        label_15:
        val_8 = new System.Action(object:  -1158404448, method:  new IntPtr(3136537824));
        val_12 = null;
        val_12 = null;
        val_10 = 1152921504929320972;
        label_14:
        GameStoreUI.OnRewardAnimationsComplete = val_8;
    }
    private System.Collections.IEnumerator WaitAndActivateItemContainer()
    {
        object val_1 = new System.Object();
        typeof(LimitedTimeBundlesPackDisplayManager.<WaitAndActivateItemContainer>d__7).__il2cppRuntimeField_8 = 0;
        typeof(LimitedTimeBundlesPackDisplayManager.<WaitAndActivateItemContainer>d__7).__il2cppRuntimeField_10 = this;
    }
    private void PostAnimationLogic()
    {
        var val_3;
        if(this.myPopup != 0)
        {
                this.myPopup.OnAnimationsComplete = 0;
            UnityEngine.GameObject val_2 = this.myPopup.gameObject;
            SLCWindow.CloseWindow(window:  this.myPopup, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            return;
        }
        
        val_3 = null;
        val_3 = null;
        GameStoreUI.OnRewardAnimationsComplete = 0;
    }
    private void OnStorePurchaseFinished()
    {
        var val_6;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1261410688) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Close();
        }
        
        if(this.myPopup != 0)
        {
                this.myPopup.OnAnimationsComplete = 0;
            UnityEngine.GameObject val_5 = this.myPopup.gameObject;
            SLCWindow.CloseWindow(window:  this.myPopup, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            return;
        }
        
        val_6 = null;
        val_6 = null;
        GameStoreUI.OnRewardAnimationsComplete = 0;
    }
    public LimitedTimeBundlesPackDisplayManager()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.packDisplays = null;
    }

}
