using UnityEngine;
public class WGAdsControlPopupV2 : WGAdsControlPopup
{
    // Fields
    private UnityEngine.UI.Text coinRewardText;
    private UnityEngine.UI.Text gemsRewardText;
    private UnityEngine.UI.Text displayValueText;
    private UnityEngine.UI.Text startedPackPrice;
    
    // Methods
    private void OnEnable()
    {
        if(static_value_021FAD32 != 0)
        {
                System.Action<System.Boolean> val_2 = new System.Action<System.Boolean>(object:  -125229216, method:  new IntPtr(4165848976));
            mem2[0] = null;
        }
        
        this.FetchNoAdsPackage();
        this.UpdateUI();
        this.SetSubscriptionEntryPoint();
        this.SetPopupSeen();
    }
    private void UpdateUI()
    {
        UnityEngine.UI.Text val_13;
        decimal val_1 = Credits;
        string val_2 = ToString();
        val_13 = this.gemsRewardText;
        if((UnityEngine.Object.op_Implicit(exists:  val_13)) != false)
        {
                val_13 = this.gemsRewardText;
            decimal val_4 = Gems;
            string val_5 = ToString();
        }
        
        GameBehavior val_8 = App.getBehavior;
        float val_12 = (float)UnityEngine.Mathf.CeilToInt(f:  null);
        val_12 = 0 * val_12;
        float val_13 = (float)UnityEngine.Mathf.CeilToInt(f:  val_12);
        val_13 = val_13 + (-0.01f);
        string val_10 = val_13.ToString(format:  -1797462704);
        string val_11 = this.displayValueText.LocalPrice;
        if(this.startedPackPrice != 0)
        {
                return;
        }
    
    }
    protected override void OnPurchaseNoAdsPackSuccess()
    {
        int val_6;
        int val_7;
        int val_12;
        int val_13;
        int val_14;
        int val_15;
        int val_22;
        float val_26;
        var val_27;
        var val_29;
        var val_30;
        var val_33;
        decimal val_1 = Gems;
        val_26 = 1152921504617017344;
        val_27 = null;
        val_27 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                Player val_3 = App.Player;
            decimal val_4 = System.Decimal.op_Implicit(value:  -124976308);
            decimal val_5 = Gems;
            decimal val_8 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -124976340}, d2:  new System.Decimal() {flags = val_6, hi = val_7});
            Player val_10 = App.Player;
            decimal val_11 = System.Decimal.op_Implicit(value:  -124976356);
            val_26 = 1152921504617017344;
            0.Play(fromValue:  System.Decimal.op_Explicit(value:  new System.Decimal()), toValue:  new System.Decimal() {flags = val_13, hi = val_14, lo = val_15, mid = val_12}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
        }
        
        val_29 = 0;
        decimal val_16 = Credits;
        val_30 = null;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                Player val_18 = App.Player;
            decimal val_19 = Credits;
            decimal val_20 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -124976324, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
            Player val_21 = App.Player;
            val_29 = 52;
            System.Decimal.Powers10.__il2cppRuntimeField_C.Play(fromValue:  new System.Decimal() {mid = val_22}, toValue:  new System.Decimal() {flags = 52, mid = val_26}, textTickTime:  null, delayBeforeComplete:  null);
        }
        
        WordPets.WPTDataParser val_23 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<System.Threading.Tasks.Task, System.Object> val_24 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -124964256, method:  new IntPtr(4167633952));
        System.Delegate val_25 = System.Delegate.Remove(source:  public static WGStoreController MonoSingletonSelfGenerating<WGStoreController>::get_Instance().__il2cppRuntimeField_10, value:  7507968);
        val_33 = public static WGStoreController MonoSingletonSelfGenerating<WGStoreController>::get_Instance().__il2cppRuntimeField_10;
        if(val_33 != 0)
        {
                if(val_33 == null)
        {
            goto label_30;
        }
        
        }
        
        val_33 = 0;
        label_30:
        public static WGStoreController MonoSingletonSelfGenerating<WGStoreController>::get_Instance().__il2cppRuntimeField_10 = val_33;
    }
    public WGAdsControlPopupV2()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
