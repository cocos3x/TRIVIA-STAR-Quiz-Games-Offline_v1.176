using UnityEngine;
public class LimitedTimeBundlePackDisplay : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text text_pack_title;
    private UnityEngine.UI.Text text_amount_coins;
    private UnityEngine.UI.Text text_amount_food;
    private UnityEngine.UI.Text text_amount_card;
    private UnityEngine.UI.Text text_current_price;
    private UnityEngine.UI.Text text_price_value;
    private UnityEngine.UI.Text text_gem_amount;
    private UnityEngine.UI.Text text_goldenCurrency_amount;
    private UnityEngine.UI.Text text_amount_dice;
    private UnityEngine.GameObject[] objs_tile_amounts;
    private UnityEngine.UI.Text[] texts_tile_amounts;
    private UnityEngine.UI.Text text_limited_purchase;
    private UGUINetworkedButton networked_button_purchase;
    private UnityEngine.GameObject obj_percent_more;
    private UnityEngine.UI.Text text_percent_more;
    private UnityEngine.GameObject obj_hot_border;
    private UnityEngine.GameObject obj_best_border;
    private UnityEngine.GameObject gem_group;
    private UnityEngine.GameObject dice_group;
    private PurchaseModel purchaseModel;
    
    // Methods
    protected virtual void HandleConnectionClick(bool result)
    {
        var val_16;
        var val_18;
        var val_19;
        decimal val_1 = DiceRolls;
        val_16 = null;
        val_16 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == false)
        {
            goto label_4;
        }
        
        GameBehavior val_3 = App.getBehavior;
        if(0 == 0)
        {
            goto label_9;
        }
        
        label_4:
        val_19 = 1152921504901095424;
        if(result == false)
        {
            goto label_10;
        }
        
        val_18 = 1152921511935370880;
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1261410688) == 0)
        {
            goto label_15;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static GameStoreUI MonoSingleton<GameStoreUI>::get_Instance()) != 0)
        {
                return;
        }
        
        return;
        label_10:
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1261410688) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ShowConnectionRequired();
        return;
        label_9:
        val_19 = 1152921511935370880;
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1261410688) == 0)
        {
            goto label_33;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        RefreshPackItemDisplays();
        return;
        label_15:
        bool val_14 = PurchaseProxy.Purchase(purchase:  this.purchaseModel);
        return;
        label_33:
        twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SLCWindow.CloseWindow(window:  public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_1C, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void Awake()
    {
        System.Delegate val_3;
        System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  -1166434544, method:  typeof(LimitedTimeBundlePackDisplay).__il2cppRuntimeField_E0);
        val_3 = this.networked_button_purchase.OnConnectionClick;
        System.Delegate val_2 = System.Delegate.Combine(a:  val_3, b:  7401472);
        if(val_3 != 0)
        {
                if(null == null)
        {
            goto label_3;
        }
        
        }
        
        val_3 = 0;
        label_3:
        this.networked_button_purchase.OnConnectionClick = val_3;
    }
    public void Setup(PurchaseModel purchase, PurchaseModel valueModel, System.Collections.Generic.Dictionary<string, object> bundlePack, int timesPurchased, bool isHot, bool isBest)
    {
        var val_52;
        UnityEngine.GameObject[] val_53;
        var val_54;
        var val_55;
        var val_56;
        this.purchaseModel = purchase;
        decimal val_1 = Credits;
        decimal val_2 = new System.Decimal(value:  999);
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid})) != false)
        {
                decimal val_4 = Credits;
            string val_5 = ToString(format:  -1166321968);
        }
        else
        {
                decimal val_6 = Credits;
            string val_7 = ToString();
        }
        
        val_52;
        string val_8 = purchase.LocalPrice;
        string val_9 = valueModel.LocalPrice;
        if((bundlePack.ContainsKey(key:  -1827757824)) != false)
        {
                if(this.text_amount_food != 0)
        {
                decimal val_12 = PetsFood;
            string val_13 = ToString();
        }
        
        }
        
        if((bundlePack.ContainsKey(key:  -1825935216)) != false)
        {
                if(this.text_amount_card != 0)
        {
                decimal val_16 = PetCards;
            string val_17 = ToString();
        }
        
        }
        
        if((this.text_gem_amount != 0) && ((bundlePack.ContainsKey(key:  -1930648496)) != false))
        {
                string val_20 = bundlePack.Item[-1930648496];
            if(this.gem_group != 0)
        {
                this.gem_group.SetActive(value:  true);
        }
        
            if(this.dice_group != 0)
        {
                this.dice_group.SetActive(value:  false);
        }
        
        }
        
        if((this.text_amount_dice != 0) && ((bundlePack.ContainsKey(key:  -1825935120)) != false))
        {
                string val_25 = bundlePack.Item[-1825935120];
            if(this.gem_group != 0)
        {
                this.gem_group.SetActive(value:  false);
        }
        
            if(this.dice_group != 0)
        {
                this.dice_group.SetActive(value:  true);
        }
        
        }
        
        if(this.text_goldenCurrency_amount != 0)
        {
                if((bundlePack.ContainsKey(key:  -1825935328)) != false)
        {
                string val_30 = bundlePack.Item[-1825935328];
        }
        
        }
        
        val_53 = this.objs_tile_amounts;
        if(val_53 == null)
        {
            goto label_66;
        }
        
        val_54 = 4;
        goto label_67;
        label_86:
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        bool val_31 = bundlePack.ContainsKey(key:  306335744);
        if(this.objs_tile_amounts[0] != 0)
        {
                this.objs_tile_amounts[0].SetActive(value:  val_31);
        }
        
        if(val_31 != false)
        {
                string val_33 = bundlePack.Item[306335744];
        }
        
        val_53 = this.objs_tile_amounts;
        val_54 = 5;
        label_67:
        val_52 = 1;
        if(val_52 < this.texts_tile_amounts[0])
        {
            goto label_86;
        }
        
        label_66:
        string val_34 = bundlePack.Item[-1166039264];
        bundlePack.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        if(bundlePack == (-2147483647))
        {
                val_55 = "";
        }
        else
        {
                string val_35 = Localization.Localize(key:  -1166039072, defaultValue:  -1166039184, useSingularKey:  false);
            string val_36 = timesPurchased.ToString();
            string val_37 = bundlePack.Item[-1166039264];
            string val_38 = System.String.Format(format:  -1694782544, arg0:  -1166039072, arg1:  -1165998208, arg2:  bundlePack);
            val_55 = "{0} {1}/{2}";
        }
        
        this.obj_percent_more.SetActive(value:  isHot | isBest);
        string val_40 = bundlePack.Item[-1166030768];
        string val_41 = bundlePack + 1472028528;
        if(this.obj_hot_border != 0)
        {
                this.obj_hot_border.SetActive(value:  isHot);
        }
        
        if(this.obj_best_border != 0)
        {
                this.obj_best_border.SetActive(value:  isBest);
        }
        
        val_56 = null;
        val_56 = null;
        string val_44 = bundlePack.Item[1624646480];
        string val_45 = LimitedTimeBundlesManager.BundleLocKeys.Item[bundlePack];
        string val_46 = bundlePack.Item[1624646480];
        string val_47 = LimitedTimeBundlesManager.BundleTitles.Item[bundlePack];
        string val_48 = LimitedTimeBundlesManager.BundleTitles.ToUpper();
        string val_49 = Localization.Localize(key:  LimitedTimeBundlesManager.BundleLocKeys, defaultValue:  LimitedTimeBundlesManager.BundleTitles, useSingularKey:  false);
        if(this.text_pack_title != 0)
        {
                return;
        }
    
    }
    private void ShowConnectionRequired()
    {
        var val_7;
        System.Func<System.Boolean> val_9;
        var val_10;
        GameBehavior val_1 = App.getBehavior;
        string val_3 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_4 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_5 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_7 = null;
        val_7 = null;
        val_9 = LimitedTimeBundlePackDisplay.<>c.<>9__23_0;
        if(val_9 == 0)
        {
                val_9 = null;
            val_9 = new System.Func<System.Boolean>(object:  LimitedTimeBundlePackDisplay.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3129396768));
            LimitedTimeBundlePackDisplay.<>c.<>9__23_0 = val_9;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_9;
        val_10 = null;
        val_10 = null;
        0.SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
    }
    public LimitedTimeBundlePackDisplay()
    {
    
    }

}
