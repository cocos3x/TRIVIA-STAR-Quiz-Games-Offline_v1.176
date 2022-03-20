using UnityEngine;
public class HintManiaEventPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject infoPopupParent;
    private UnityEngine.GameObject collectPopupParent;
    private UnityEngine.GameObject coinValueParent;
    private UnityEngine.GameObject appleValueParent;
    private UnityEngine.UI.Text eventDescirption;
    private UnityEngine.UI.Text eventTimerText;
    private UnityEngine.UI.Text coinValueText;
    private UnityEngine.UI.Text appleValueText;
    private UnityEngine.UI.Button continueButton;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Button collectButton;
    private UnityEngine.UI.Button playButton;
    private UnityEngine.UI.Text playButtonText;
    private GridCoinCollectAnimationInstantiator coinCollector;
    private GoldenCurrencyCollectAnimationInstantiator goldenCollector;
    
    // Methods
    private void OnEnable()
    {
        this.infoPopupParent.SetActive(value:  false);
        this.collectPopupParent.SetActive(value:  false);
        if(HintManiaEventHandler.HINT_MANIA_ID != null)
        {
                this.InitCollect();
            return;
        }
        
        this.InitInfo();
    }
    private void InitInfo()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1208454240, method:  new IntPtr(3086448768));
        this.playButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1208454240, method:  new IntPtr(3086448768));
        this.continueButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.GameObject val_3 = this.playButton.gameObject;
        GameBehavior val_4 = App.getBehavior;
        this.playButton.SetActive(value:  true);
        UnityEngine.GameObject val_5 = this.continueButton.gameObject;
        GameBehavior val_6 = App.getBehavior;
        if(this.continueButton != 0)
        {
                -1 = 1;
        }
        
        this.continueButton.SetActive(value:  true);
        UnityEngine.Events.UnityAction val_7 = new UnityEngine.Events.UnityAction(object:  -1208454240, method:  new IntPtr(3086474368));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        string val_8 = Localization.Localize(key:  -1208487568, defaultValue:  -1208487808, useSingularKey:  false);
        string val_9 = System.String.Format(format:  -1208487568, arg0:  13152256);
        string val_10 = Localization.Localize(key:  -1672741904, defaultValue:  2127161280, useSingularKey:  false);
        Player val_11 = App.Player;
        string val_12 = System.String.Format(format:  -1672741904, arg0:  13152256);
        this.infoPopupParent.SetActive(value:  true);
        UnityEngine.GameObject val_13 = this.gameObject;
        UnityEngine.UI.LayoutElement val_14 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -1208454240);
        System.Action val_15 = new System.Action(object:  -1208454240, method:  new IntPtr(3086488032));
        this.appleValueParent = null;
    }
    private void InitCollect()
    {
        this.collectPopupParent.SetActive(value:  true);
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1208283872, method:  new IntPtr(3086658400));
        this.collectButton.m_OnClick.AddListener(call:  162246656);
    }
    private void PlayButtonPressed()
    {
        var val_3;
        this.UpdateFeaturePoint();
        val_3 = 1152921504892043264;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 2)
        {
                GameBehavior val_2 = App.getBehavior;
        }
        
        this.Close();
    }
    private void UpdateTimerText()
    {
        var val_5;
        var val_13 = 21202697;
        val_13 = 14439124 + val_13;
        if(val_13 == 0)
        {
                mem2[0] = 1;
        }
        
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511988726024}, d2:  new System.DateTime() {dateData = HintManiaEventHandler.HINT_MANIA_ID.m_stringLength + 32});
        int val_7 = val_5.Days;
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        int val_8 = val_5.Hours;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        int val_9 = val_5.Minutes;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        int val_10 = val_5.Seconds;
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        string val_11 = System.String.Format(format:  -1536980304, args:  472754880);
        double val_12 = val_5.TotalSeconds;
    }
    private void CollectButtonPressed()
    {
        int val_9;
        int val_10;
        int val_11;
        int val_12;
        int val_16;
        int val_22;
        int val_23;
        int val_24;
        int val_25;
        GridCoinCollectAnimationInstantiator val_26;
        UnityEngine.GameObject val_27;
        float val_28;
        var val_29;
        var val_26 = 21201765;
        val_26 = 14440056 + val_26;
        if(val_26 == 0)
        {
                mem2[0] = 1;
        }
        
        val_26 = 1152921504931446784;
        val_27 = mem[HintManiaEventHandler.HINT_MANIA_ID + 16];
        val_27 = HintManiaEventHandler.HINT_MANIA_ID + 16;
        this.collectButton.interactable = false;
        if(val_27 == 2)
        {
            goto label_4;
        }
        
        if(val_27 != 1)
        {
            goto label_5;
        }
        
        Player val_1 = App.Player;
        this.coinValueParent.SetActive(value:  true);
        if(val_26 == 0)
        {
                mem2[0] = 1;
        }
        
        HintManiaEventHandler.HINT_MANIA_ID.CollectReward();
        Player val_2 = App.Player;
        val_28 = 7.286752E-44f;
        decimal val_3 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1207902600, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256, hi = 52, lo = 52, mid = 256});
        string val_4 = ToString();
        System.Action val_5 = new System.Action(object:  -1207890528, method:  new IntPtr(3086474368));
        this.coinCollector.OnCompleteCallback = null;
        val_26 = this.coinCollector;
        Player val_6 = App.Player;
        val_29 = 52;
        val_27 = 52;
        val_26.Play(fromValue:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, toValue:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, textTickTime:  null, delayBeforeComplete:  null);
        return;
        label_4:
        Player val_7 = App.Player;
        decimal val_8 = System.Decimal.op_Implicit(value:  -1207902600);
        val_28 = val_11;
        this.appleValueParent.SetActive(value:  true);
        if(val_26 == 0)
        {
                mem2[0] = 1;
        }
        
        HintManiaEventHandler.HINT_MANIA_ID.CollectReward();
        System.Action val_13 = new System.Action(object:  -1207890528, method:  new IntPtr(3086474368));
        mem2[0] = null;
        Player val_14 = App.Player;
        decimal val_15 = System.Decimal.op_Implicit(value:  -1207902616);
        val_26 = val_12;
        decimal val_17 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1207902632}, d2:  new System.Decimal() {flags = val_16, hi = val_9, lo = val_10, mid = val_28});
        string val_18 = ToString();
        Player val_20 = App.Player;
        val_29 = 0;
        decimal val_21 = System.Decimal.op_Implicit(value:  -1207902648);
        val_27 = 49024;
        val_27 = 3212836864;
        this.goldenCollector.Play(fromValue:  System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_9, hi = val_10, lo = val_28, mid = val_26}), toValue:  new System.Decimal() {flags = val_23, hi = val_24, lo = val_25, mid = val_22}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  val_27, originObject:  val_27);
        return;
        label_5:
        if(val_26 == 0)
        {
                mem2[0] = 1;
        }
        
        HintManiaEventHandler.HINT_MANIA_ID.CollectReward();
        this.Close();
    }
    private void UpdateFeaturePoint()
    {
        var val_4;
        var val_5;
        FeatureAccessPoints val_6;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 1)
        {
                val_4 = 1152921504895770624;
            var val_3 = 21187115;
            val_3 = 14438676 + val_3;
            if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
            val_5 = null;
            val_6 = 71;
        }
        else
        {
                GameBehavior val_2 = App.getBehavior;
            if(0 != 2)
        {
                return;
        }
        
            val_4 = 1152921504895770624;
            var val_4 = 21186919;
            val_4 = 14438872 + val_4;
            if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
            val_5 = null;
            val_6 = 72;
        }
        
        AmplitudePluginHelper.lastFeatureAccessPoint = val_6;
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    public HintManiaEventPopup()
    {
    
    }

}
