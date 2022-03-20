using UnityEngine;
public class WGSubscriptionButton : MonoBehaviour
{
    // Fields
    private WGSubscriptionButton.SubButtonLocation location;
    private SubscriptionHandler.SubScriptionType subPackage;
    public UGUINetworkedButton targetButton;
    private UnityEngine.GameObject targetParentObject;
    private UnityEngine.GameObject noSubGroup;
    private UnityEngine.UI.Text costText;
    private UnityEngine.GameObject hasSubGroup;
    private UnityEngine.GameObject purchaseSubscriptionWindow;
    private System.Action<bool> OnConnectionClick;
    private bool awaitingPing;
    
    // Methods
    private void Start()
    {
        object val_1 = this.hasSubGroup.GetComponent<System.Object>();
        string val_2 = Localization.Localize(key:  -1222659216, defaultValue:  -1222659120, useSingularKey:  false);
        if(this.hasSubGroup == 0)
        {
            
        }
    
    }
    private void OnEnable()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                if(this.location == 2)
        {
                if(this.subPackage == 0)
        {
                59 = 35;
        }
        
            WGSubscriptionManager._subEntryPoint = 35;
        }
        
            this.UpdateUI();
            System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -1222505632, method:  new IntPtr(3072436640));
            this.targetButton.OnConnectionClick = null;
            return;
        }
        
        UnityEngine.GameObject val_3 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void UpdateUI()
    {
        float val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        bool val_27;
        UnityEngine.GameObject val_28;
        float val_30;
        var val_31;
        var val_32;
        val_22 = 1152921504892043264;
        val_23 = 10095736 + 25530051;
        if(val_23 == 0)
        {
                mem2[0] = 1;
        }
        
        val_24 = null;
        val_24 = null;
        if(App.game == 17)
        {
            goto label_6;
        }
        
        if(val_23 == 0)
        {
                mem2[0] = 1;
        }
        
        val_25 = null;
        val_25 = null;
        if(App.game != 19)
        {
            goto label_12;
        }
        
        label_6:
        val_26 = 1152921504765685760;
        if(this.hasSubGroup != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_27 = hasAnySubscription();
            this.hasSubGroup.SetActive(value:  val_27);
        }
        
        if(this.noSubGroup == 0)
        {
            goto label_36;
        }
        
        val_28 = this.noSubGroup;
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_6 = hasAnySubscription();
        goto label_26;
        label_12:
        val_30 = 1152921504765685760;
        if(this.hasSubGroup != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_27 = hasSubscription(subPackage:  this.subPackage);
            this.hasSubGroup.SetActive(value:  val_27);
        }
        
        if(this.noSubGroup == 0)
        {
            goto label_36;
        }
        
        val_28 = this.noSubGroup;
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SubscriptionHandler.SubScriptionType val_21 = this.subPackage;
        label_26:
        val_27 = hasSubscription(subPackage:  val_21);
        val_21 = val_27 ^ 1;
        val_28.SetActive(value:  val_21);
        label_36:
        if(this.costText == 0)
        {
            goto label_43;
        }
        
        if(val_23 == 0)
        {
                mem2[0] = 1;
        }
        
        val_31 = null;
        val_31 = null;
        if(App.game == 17)
        {
            goto label_49;
        }
        
        if(val_23 == 0)
        {
                mem2[0] = 1;
        }
        
        val_32 = null;
        val_32 = null;
        if(App.game != 19)
        {
            goto label_55;
        }
        
        label_49:
        label_57:
        string val_15 = Localization.Localize(key:  -1222356096, defaultValue:  -1222356192, useSingularKey:  false);
        label_61:
        if(this.costText != 0)
        {
            goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_314;
        }
        
        goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_314;
        label_43:
        var val_16 = FP - 28;
        return;
        label_55:
        if(WGSubscriptionManager.WillGetFreeTrial == true)
        {
            goto label_57;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_18 = GetPromoCostForPackage(subPack:  this.subPackage);
        string val_19 = Localization.Localize(key:  -1222347792, defaultValue:  -1222347696, useSingularKey:  false);
        string val_20 = System.String.Format(format:  -1222347616, arg0:  -1897280256, arg1:  -1222347792);
        goto label_61;
    }
    public void onClickButton(bool result)
    {
        var val_12;
        var val_13;
        System.Action val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        if(result == false)
        {
            goto label_1;
        }
        
        if(this.location == 2)
        {
            goto label_10;
        }
        
        if(this.location == 1)
        {
            goto label_3;
        }
        
        val_12 = 0;
        if(this.location != 0)
        {
            goto label_34;
        }
        
        val_12 = 0;
        if(this.targetParentObject == 0)
        {
            goto label_34;
        }
        
        val_12 = 0;
        this.targetParentObject.SetActive(value:  false);
        goto label_34;
        label_1:
        if(this.location == 2)
        {
            goto label_10;
        }
        
        if(this.location != 1)
        {
            goto label_11;
        }
        
        SLC.Social.Leagues.LeaguesNotifyController val_2 = SLC.Social.Leagues.LeaguesManager.NOTIFY_API;
        0.Notify(note:  9);
        return;
        label_10:
        var val_12 = 25528792;
        val_12 = 10098332 + val_12;
        if(this.subPackage == 0)
        {
                58 = 34;
        }
        
        if(val_12 == 0)
        {
                mem2[0] = 1;
        }
        
        WGSubscriptionManager._subEntryPoint = 34;
        val_13 = 1152921504614301696;
        val_14 = null;
        val_15 = 1152921511974619776;
        goto label_16;
        label_11:
        GameBehavior val_3 = App.getBehavior;
        string val_5 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_6 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_7 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_16 = null;
        val_17 = "connection_required_explanation";
        val_18 = 0;
        goto label_41;
        label_3:
        var val_13 = 25528136;
        val_13 = 10098988 + val_13;
        if(val_13 == 0)
        {
                mem2[0] = 1;
        }
        
        WGSubscriptionManager._subEntryPoint = 31;
        val_13 = 1152921504614301696;
        val_14 = null;
        val_15 = 1152921511974620800;
        label_16:
        val_14 = new System.Action(object:  -1222130624, method:  new IntPtr(3072806528));
        System.Delegate val_9 = System.Delegate.Combine(a:  0, b:  7454720);
        if(0 == 0)
        {
            goto label_33;
        }
        
        val_12 = 0;
        if(1179403647 == val_13)
        {
            goto label_34;
        }
        
        label_33:
        val_12 = 0;
        label_34:
        GameBehavior val_10 = App.getBehavior;
        if(0 != 0)
        {
                mem[212] = this.subPackage;
        }
        else
        {
                mem[212] = this.subPackage;
        }
        
        mem[204] = val_12;
        return;
        label_41:
        if( == 0)
        {
                val_18 = 0;
        }
        
        val_18.SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
    }
    private void OnStoreClosed()
    {
        this.UpdateUI();
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1261410688) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            RefreshPackItemDisplays();
        }
        
        var val_4 = 25527260;
        val_4 = 10099864 + val_4;
        if(this.subPackage == 0)
        {
                59 = 35;
        }
        
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        WGSubscriptionManager._subEntryPoint = 35;
    }
    public void ClickButton()
    {
        this.targetButton.OnOtherButtonClick();
    }
    public WGSubscriptionButton()
    {
    
    }

}
