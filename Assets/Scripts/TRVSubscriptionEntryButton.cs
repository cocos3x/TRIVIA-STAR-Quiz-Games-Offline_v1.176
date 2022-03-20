using UnityEngine;
public class TRVSubscriptionEntryButton : MonoBehaviour
{
    // Fields
    public UGUINetworkedButton targetButton;
    private System.Action<bool> OnConnectionClick;
    private bool awaitingPing;
    private UnityEngine.CanvasGroup cg;
    private UnityEngine.UI.LayoutElement layoutElement;
    
    // Methods
    private void OnEnable()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -445401552);
        this.layoutElement = this;
        UnityEngine.GameObject val_3 = this.gameObject;
        UnityEngine.UI.LayoutElement val_4 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -445401552);
        this.cg = this;
        System.Action<System.Boolean> val_5 = new System.Action<System.Boolean>(object:  -445401552, method:  new IntPtr(3849539696));
        this.targetButton.OnConnectionClick = null;
        UnityEngine.GameObject val_6 = this.gameObject;
        UnityEngine.UI.LayoutElement val_7 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -445401552);
        System.Action val_8 = new System.Action(object:  -445401552, method:  new IntPtr(3849540720));
        this.cg = null;
    }
    public void onClickButton(bool result)
    {
        var val_9;
        if(result != false)
        {
                WGSubscriptionManager._subEntryPoint = 89;
            GameBehavior val_1 = App.getBehavior;
            mem[212] = 0;
            System.Action val_3 = new System.Action(object:  -445284432, method:  new IntPtr(3849657840));
            mem[204] = null;
            return;
        }
        
        GameBehavior val_4 = App.getBehavior;
        string val_6 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_7 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_8 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_9 = null;
        val_9 = null;
        0.SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
    }
    private void UpdateButtonStatus()
    {
    
    }
    public TRVSubscriptionEntryButton()
    {
    
    }

}
