using UnityEngine;
public class TRVCategoryEarlyUnlockPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Image catImage;
    private UnityEngine.UI.Text catText;
    private UnityEngine.UI.Text unlockCost;
    private UnityEngine.UI.Button unlockButton;
    private UnityEngine.UI.Button closeButton;
    private GemsCollectAnimationInstantiator gca;
    
    // Methods
    public void Init(string cat)
    {
        if(new System.Object() != 0)
        {
                typeof(TRVCategoryEarlyUnlockPopup.<>c__DisplayClass6_0).__il2cppRuntimeField_8 = this;
        }
        else
        {
                mem[8] = this;
        }
        
        typeof(TRVCategoryEarlyUnlockPopup.<>c__DisplayClass6_0).__il2cppRuntimeField_C = cat;
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -557954688, method:  new IntPtr(3736966080));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  355856384, method:  new IntPtr(3736975296));
        this.unlockButton.m_OnClick.AddListener(call:  162246656);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Sprite val_5 = GetCategoryIcon(category:  typeof(TRVCategoryEarlyUnlockPopup.<>c__DisplayClass6_0).__il2cppRuntimeField_C);
        this.catImage.sprite = -612557856;
        WordForest.WFOGameEcon val_6 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        string val_7 = ToString();
        string val_8 = TRVCategorySelection.ToUpperCategory(category:  typeof(TRVCategoryEarlyUnlockPopup.<>c__DisplayClass6_0).__il2cppRuntimeField_C);
        if(this.catText == 0)
        {
            
        }
    
    }
    private void UnlockCat(string cat)
    {
        int val_23;
        int val_24;
        int val_25;
        int val_26;
        var val_28;
        var val_29;
        System.Action val_30;
        object val_1 = new System.Object();
        typeof(TRVCategoryEarlyUnlockPopup.<>c__DisplayClass7_0).__il2cppRuntimeField_8 = cat;
        Player val_2 = App.Player;
        WordForest.WFOGameEcon val_3 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if(0 >= mem[1152921512476916248])
        {
            goto label_6;
        }
        
        var val_28 = 23411977;
        val_28 = 12214084 + val_28;
        if(val_28 == 0)
        {
                mem2[0] = 1;
        }
        
        val_28 = null;
        val_28 = null;
        PurchaseProxy.currentPurchasePoint = 104;
        string val_4 = Localization.Localize(key:  -1687442544, defaultValue:  -1687442624, useSingularKey:  false);
        GameStoreManager.StoreCategoryFocus = "gems_upper";
        GameBehavior val_5 = App.getBehavior;
        val_29 = 0;
        val_30 = null;
        val_30 = new System.Action(object:  355909632, method:  new IntPtr(3737137472));
        val_29.Init(outOfCredits:  true, onCloseAction:  7454720);
        goto label_17;
        label_6:
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnlockCategoryEarly(euCat:  typeof(TRVCategoryEarlyUnlockPopup.<>c__DisplayClass7_0).__il2cppRuntimeField_8);
        Player val_9 = App.Player;
        WordForest.WFOGameEcon val_10 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        val_30 = mem[1152921512476916248];
        0.AddGems(amount:  0 - val_30, source:  -557828800, subsource:  null);
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_13 = GetWindow<System.Object>();
        val_29 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
        if(2119322896 != 0)
        {
            goto label_30;
        }
        
        UnityEngine.Debug.LogError(message:  -557828688);
        label_17:
        UnityEngine.GameObject val_15 = this.gameObject;
        SLCWindow.CloseWindow(window:  -557784112, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        return;
        label_30:
        UpdateCategoryUnlockButton(category:  typeof(TRVCategoryEarlyUnlockPopup.<>c__DisplayClass7_0).__il2cppRuntimeField_8);
        this.unlockButton.interactable = false;
        System.Action val_16 = new System.Action(object:  -557784112, method:  new IntPtr(3736966080));
        mem2[0] = null;
        Player val_17 = App.Player;
        WordForest.WFOGameEcon val_18 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        Player val_19 = App.Player;
        decimal val_20 = System.Decimal.op_Implicit(value:  -557796164);
        UnityEngine.GameObject val_21 = this.unlockButton.gameObject;
        UnityEngine.GameObject val_22 = this.gca.gameObject;
        this.gca.Play(fromValue:  mem[1152921512476916248] + 0, toValue:  new System.Decimal() {flags = val_25, hi = val_26, lo = val_24, mid = val_23}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -557647536, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public TRVCategoryEarlyUnlockPopup()
    {
    
    }

}
