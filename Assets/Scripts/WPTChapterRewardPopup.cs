using UnityEngine;
public class WPTChapterRewardPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button buttonReward1;
    private UnityEngine.UI.Button buttonReward2;
    private UnityEngine.UI.Button buttonReward3;
    private UnityEngine.GameObject containerRewardDisplay;
    private UnityEngine.UI.Text labelRewardAmount;
    private UnityEngine.UI.Button buttonClose;
    private UnityEngine.UI.Text labelCallToAction;
    private GridCoinCollectAnimationInstantiator coinCollector;
    private System.Action onPopupClosed;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  118660960, method:  new IntPtr(118596000));
        this.buttonReward1.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  118660960, method:  new IntPtr(118605216));
        this.buttonReward2.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  118660960, method:  new IntPtr(118614432));
        this.buttonReward3.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  118660960, method:  new IntPtr(118623648));
        this.buttonClose.m_OnClick.AddListener(call:  162246656);
        UnityEngine.GameObject val_5 = this.buttonClose.gameObject;
        this.buttonClose.SetActive(value:  false);
        UnityEngine.GameObject val_6 = this.buttonClose.gameObject;
        this.buttonClose.SetActive(value:  false);
        UnityEngine.GameObject val_7 = this.labelCallToAction.gameObject;
        this.labelCallToAction.SetActive(value:  true);
    }
    private void OnButtonRewardClicked1()
    {
        this.OpenReward(buttonIndex:  1, buttonClicked:  this.buttonReward1);
    }
    private void OnButtonRewardClicked2()
    {
        this.OpenReward(buttonIndex:  2, buttonClicked:  this.buttonReward2);
    }
    private void OnButtonRewardClicked3()
    {
        this.OpenReward(buttonIndex:  3, buttonClicked:  this.buttonReward3);
    }
    private void OpenReward(int buttonIndex, UnityEngine.UI.Button buttonClicked)
    {
        int val_12;
        float val_17;
        float val_18;
        var val_25;
        var val_30;
        var val_31;
        var val_32;
        mem[this.buttonReward1 + (8)].interactable = false;
        mem[this.buttonReward1 + (4)].interactable = false;
        mem[this.buttonReward1 + (0)].interactable = false;
        Player val_1 = App.Player;
        val_25 = 0;
        decimal val_2 = new System.Decimal(value:  60);
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid})) != true)
        {
                decimal val_4 = new System.Decimal(value:  120);
            val_25 = 1;
            if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal() {flags = val_4.flags, hi = val_4.hi, lo = val_4.lo, mid = val_4.mid})) != true)
        {
                decimal val_6 = new System.Decimal(value:  240);
            val_25 = 2;
            if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal() {flags = val_6.flags, hi = val_6.hi, lo = val_6.lo, mid = val_6.mid})) != true)
        {
                decimal val_8 = new System.Decimal(value:  480);
            if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal() {flags = val_8.flags, hi = val_8.hi, lo = val_8.lo, mid = val_8.mid})) == true)
        {
                val_25 = 3;
        }
        
        }
        
        }
        
        }
        
        WordPets.WPTGameEcon val_10 = WordPets.WPTGameEcon.Instance;
        if(1507844 <= 3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_25 = -684982272;
        val_25 = val_25 + 12;
        int val_11 = buttonIndex - 1;
        if(val_11 < 3)
        {
                if(((-684982272 + 12) + 16 + 12) <= val_11)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_30 = ((-684982272 + 12) + 16 + 8) + (val_11 << 4);
        }
        else
        {
                if(((-684982272 + 12) + 16 + 12) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_30 = mem[(-684982272 + 12) + 16 + 8];
            val_30 = (-684982272 + 12) + 16 + 8;
        }
        
        val_30 = val_30 + 16;
        CurrencyController.CreditBalance(value:  new System.Decimal() {mid = val_12}, source:  "Chapter Complete Reward", externalParams:  0, animated:  false);
        string val_13 = ToString();
        UnityEngine.Transform val_14 = this.containerRewardDisplay.transform;
        if(this.containerRewardDisplay == 0)
        {
            goto label_28;
        }
        
        val_31 = this.containerRewardDisplay;
        if(null == null)
        {
            goto label_29;
        }
        
        label_28:
        val_31 = 0;
        label_29:
        UnityEngine.Transform val_15 = buttonClicked.transform;
        val_31.SetParent(p:  buttonClicked);
        UnityEngine.Vector2 val_16 = UnityEngine.Vector2.zero;
        val_31.anchoredPosition = new UnityEngine.Vector2() {x = val_17, y = val_18};
        this.containerRewardDisplay.SetActive(value:  true);
        UnityEngine.GameObject val_19 = this.buttonClose.gameObject;
        this.buttonClose.SetActive(value:  true);
        UnityEngine.GameObject val_20 = this.labelCallToAction.gameObject;
        this.labelCallToAction.SetActive(value:  false);
        Player val_21 = App.Player;
        val_32 = 256;
        val_32 = val_32;
        decimal val_23 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 119195304, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
        Player val_24 = App.Player;
        this.coinCollector.Play(fromValue:  new System.Decimal() {flags = val_8.flags, hi = val_8.hi, lo = val_8.lo, mid = val_8.mid}, toValue:  new System.Decimal() {flags = 52}, textTickTime:  val_16.x, delayBeforeComplete:  val_16.y);
    }
    private void OnCloseClicked()
    {
        if(this.onPopupClosed != 0)
        {
                this.onPopupClosed.Invoke();
        }
        
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  false);
    }
    public void SetOnCloseCallback(System.Action popupClosed)
    {
        System.Action val_2 = this.onPopupClosed;
        System.Delegate val_1 = System.Delegate.Combine(a:  val_2 = this.onPopupClosed, b:  popupClosed);
        if(val_2 != 0)
        {
                if(null == null)
        {
            goto label_2;
        }
        
        }
        
        val_2 = 0;
        label_2:
        this.onPopupClosed = val_2;
    }
    public WPTChapterRewardPopup()
    {
    
    }

}
