using UnityEngine;
public class GoldenTicketStoreItem : WGStoreItem
{
    // Fields
    private UnityEngine.UI.Text coinsPerDayText;
    private UnityEngine.UI.Text applesText;
    private UGUINetworkedButton itemButton;
    private WGSubscriptionButton subButtonComponent;
    private SubscriptionHandler.SubScriptionType subPackage;
    
    // Methods
    private void OnEnable()
    {
        var val_13;
        string val_1 = Localization.Localize(key:  -1223411488, defaultValue:  -1223411376, useSingularKey:  false);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_13 = public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance();
        GameEcon val_4 = App.getGameEcon;
        string val_5 = promoDailyCoinsAmount(subPackage:  this.subPackage).ToString(format:  null);
        string val_6 = System.String.Format(format:  -1223411488, arg0:  -1223377624);
        if(this.applesText != 0)
        {
                string val_8 = Localization.Localize(key:  -1223398896, defaultValue:  -1223398992, useSingularKey:  false);
            twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_13 = public static WGSubscriptionManager MonoSingleton<WGSubscriptionManager>::get_Instance();
            string val_10 = pointMultiplier;
            string val_11 = System.String.Format(format:  -1223398896, arg0:  -1897280256);
        }
        
        System.Action<System.Boolean> val_12 = new System.Action<System.Boolean>(object:  -1223365584, method:  new IntPtr(3071576688));
        this.itemButton.OnConnectionClick = null;
    }
    public override void Awake()
    {
        var val_3;
        System.Delegate val_4;
        val_3 = null;
        val_3 = null;
        System.Action val_1 = new System.Action(object:  -1223232080, method:  new IntPtr(3071710192));
        val_4 = GameStoreUI.OnRefreshDisplay;
        System.Delegate val_2 = System.Delegate.Combine(a:  val_4, b:  7454720);
        if(val_4 != 0)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        val_4 = 0;
        label_4:
        GameStoreUI.OnRefreshDisplay = val_4;
    }
    private void OnStoreRefreshDisplay()
    {
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        SubscriptionHandler.SubScriptionType val_23;
        val_19 = 1152921504892043264;
        var val_19 = 29076203;
        val_19 = 6549584 + val_19;
        if(val_19 == 0)
        {
                mem2[0] = 1;
        }
        
        val_20 = null;
        val_20 = null;
        if(App.game == 17)
        {
            goto label_6;
        }
        
        if(val_19 == 0)
        {
                mem2[0] = 1;
        }
        
        val_21 = null;
        val_21 = null;
        if(App.game != 19)
        {
            goto label_12;
        }
        
        label_6:
        val_19 = 1152921504901095424;
        val_22 = 1152921511299501312;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1897280256) == 0)
        {
            goto label_50;
        }
        
        UnityEngine.GameObject val_3 = this.gameObject;
        if((-1223111888) == 0)
        {
            goto label_50;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((hasSubscription(subPackage:  1)) == true)
        {
            goto label_50;
        }
        
        label_54:
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((hasSubscription(subPackage:  0)) == true)
        {
            goto label_50;
        }
        
        return;
        label_12:
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_22 = 1152921504765685760;
        if((-1897280256) == 0)
        {
            goto label_50;
        }
        
        UnityEngine.GameObject val_11 = this.gameObject;
        if((-1223111888) == 0)
        {
            goto label_50;
        }
        
        GameBehavior val_13 = App.getBehavior;
        if(0 == 0)
        {
            goto label_50;
        }
        
        val_23 = this.subPackage;
        if(val_23 != 1)
        {
            goto label_42;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((hasSubscription(subPackage:  1)) == true)
        {
            goto label_50;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(silverTicketUnlocked == false)
        {
            goto label_50;
        }
        
        val_23 = this.subPackage;
        label_42:
        if(val_23 != 0)
        {
                return;
        }
        
        goto label_54;
        label_50:
        UnityEngine.GameObject val_18 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void ClickSubButton(bool result = False)
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if((-1222987600) == 0)
        {
                return;
        }
        
        this.subButtonComponent.onClickButton(result:  result);
    }
    private void OnDisable()
    {
        var val_3;
        System.Delegate val_4;
        val_3 = null;
        val_3 = null;
        System.Action val_1 = new System.Action(object:  -1222867408, method:  new IntPtr(3071710192));
        val_4 = GameStoreUI.OnRefreshDisplay;
        System.Delegate val_2 = System.Delegate.Remove(source:  val_4, value:  7454720);
        if(val_4 != 0)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        val_4 = 0;
        label_4:
        GameStoreUI.OnRefreshDisplay = val_4;
        this.itemButton.OnConnectionClick = 0;
    }
    public GoldenTicketStoreItem()
    {
    
    }

}
