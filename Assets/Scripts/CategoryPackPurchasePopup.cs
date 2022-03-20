using UnityEngine;
public class CategoryPackPurchasePopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text unlockBlurbLabel;
    private UnityEngine.UI.Text unlockCostLabel;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Button unlockButton;
    private UnityEngine.UI.Text unlockButtonLabel;
    private UnityEngine.UI.Image unlockWaitingIcon;
    private int currentActionedPackId;
    
    // Methods
    private void Start()
    {
        var val_5;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1501804496, method:  new IntPtr(2793136752));
        this.unlockButton.m_OnClick.AddListener(call:  162246656);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean, System.Int32> val_3 = new System.Action<System.Boolean, System.Int32>(object:  -1501804496, method:  new IntPtr(2793137776));
        System.Delegate val_4 = System.Delegate.Combine(a:  public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_18, b:  7507968);
        val_5 = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_18;
        if(val_5 != 0)
        {
                if(val_5 == null)
        {
            goto label_8;
        }
        
        }
        
        val_5 = 0;
        label_8:
        public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_18 = val_5;
    }
    private void OnDestroy()
    {
        var val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean, System.Int32> val_2 = new System.Action<System.Boolean, System.Int32>(object:  -1501684304, method:  new IntPtr(2793137776));
        System.Delegate val_3 = System.Delegate.Remove(source:  public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_18, value:  7507968);
        val_4 = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_18;
        if(val_4 != 0)
        {
                if(val_4 == null)
        {
            goto label_6;
        }
        
        }
        
        val_4 = 0;
        label_6:
        public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_18 = val_4;
    }
    public void Show(int packId)
    {
        this.currentActionedPackId = packId;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        decimal val_2 = GetPackUnlockCost(packId:  -2102212592);
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CategoryPackInfo val_4 = GetPackInfo(packId:  packId);
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CategoryColor val_6 = GetColor(colorCode:  public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_34);
        string val_7 = UnityEngine.ColorUtility.ToHtmlStringRGBA(color:  new UnityEngine.Color());
        string val_8 = Localization.Localize(key:  -1501592208, defaultValue:  -1501592112, useSingularKey:  false);
        string val_9 = FullTitle;
        string val_10 = System.String.Format(format:  -1501592032, arg0:  -1501592208, arg1:  R0, arg2:  -2102212592);
        string val_11 = ToString();
        string val_12 = Localization.Localize(key:  -1501583632, defaultValue:  -1501583712, useSingularKey:  false);
        UnityEngine.GameObject val_13 = this.gameObject;
        this.SetActive(value:  true);
    }
    private void SetLoadingUI(bool isVisible)
    {
        bool val_3 = isVisible;
        UnityEngine.GameObject val_1 = this.unlockWaitingIcon.gameObject;
        this.unlockWaitingIcon.SetActive(value:  val_3);
        UnityEngine.GameObject val_2 = this.unlockButtonLabel.gameObject;
        val_3 = val_3 ^ 1;
        this.unlockButtonLabel.SetActive(value:  val_3);
        this.unlockButton.interactable = val_3;
        this.closeButton.interactable = val_3;
    }
    private void OnPackUnlockConfirm()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PurchasePack(packToPurchase:  this.currentActionedPackId);
    }
    private void CloseWindow()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void OnPurchaseComplete(bool isSuccessful, int packId)
    {
        var val_3;
        var val_4;
        val_3 = 35626821;
        if(isSuccessful != true)
        {
                val_3 = 6659496 + 28966565;
            if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
            val_4 = null;
            val_4 = null;
            PurchaseProxy.currentPurchasePoint = 69;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
            Init(outOfCredits:  true, onCloseAction:  0);
        }
        
        this.CloseWindow();
    }
    public CategoryPackPurchasePopup()
    {
        this.currentActionedPackId = 0;
    }

}
