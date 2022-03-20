using UnityEngine;
public class WGRewardedVideoUI : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject group_start;
    private UnityEngine.UI.Text desc_text;
    private UGUINetworkedButton Button_FreeHint;
    private UnityEngine.GameObject group_sorry;
    private UGUINetworkedButton Button_WatchAnother;
    private UnityEngine.UI.Button Button_Close_Sorry;
    private UnityEngine.GameObject group_success;
    private UnityEngine.UI.Button Button_CollectHint;
    private bool hideTextWhileCollecting;
    private UnityEngine.UI.Text message_thankYou;
    private GridCoinCollectAnimationInstantiator coinsAnim;
    private UnityEngine.UI.Text coin_amount;
    private WGMessagePopup localPopup;
    private decimal reward;
    private HeyZapAdTag initTag;
    private string freeCoinEventName;
    public System.Action completeCallback;
    
    // Methods
    private void DoCompleteCallback()
    {
        this.SetUp();
        if(this.completeCallback == 0)
        {
                return;
        }
        
        this.completeCallback.Invoke();
    }
    private void Awake()
    {
        this.Button_FreeHint.OnConnectionClick = new System.Action<System.Boolean>(object:  41329440, method:  new IntPtr(41281888));
        this.Button_WatchAnother.OnConnectionClick = new System.Action<System.Boolean>(object:  41329440, method:  new IntPtr(41281888));
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  41329440, method:  new IntPtr(41295200));
        this.Button_Close_Sorry.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  41329440, method:  new IntPtr(41304416));
        this.Button_CollectHint.m_OnClick.AddListener(call:  162246656);
    }
    private void OnEnable()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  41466016, name:  2128120864);
        this.SetUp();
    }
    public void InitWithTag(HeyZapAdTag tag, string eventName)
    {
        this.initTag = tag;
        this.freeCoinEventName = eventName;
    }
    private void SetUp()
    {
        var val_16;
        var val_17;
        var val_18;
        decimal val_19;
        UnityEngine.Transform val_1 = this.localPopup.transform;
        UnityEngine.Transform val_2 = this.localPopup.parent;
        UnityEngine.GameObject val_3 = this.localPopup.gameObject;
        this.localPopup.SetActive(value:  false);
        this.Button_FreeHint.interactable = true;
        this.group_start.SetActive(value:  true);
        this.group_success.SetActive(value:  false);
        this.group_sorry.SetActive(value:  false);
        UnityEngine.CanvasRenderer val_4 = this.message_thankYou.canvasRenderer;
        this.message_thankYou.SetAlpha(alpha:  null);
        Player val_5 = App.Player;
        if(188 < 1)
        {
            goto label_14;
        }
        
        if(188 != 1)
        {
            goto label_15;
        }
        
        GameEcon val_7 = App.getGameEcon;
        val_16 = 312;
        val_17 = 0 + 308;
        val_18 = 0 + 304;
        val_19 = 0 + 300;
        goto label_23;
        label_14:
        GameEcon val_8 = App.getGameEcon;
        val_16 = 296;
        val_17 = 0 + 292;
        val_18 = 0 + 288;
        val_19 = 0 + 284;
        goto label_23;
        label_15:
        GameEcon val_9 = App.getGameEcon;
        val_16 = 328;
        val_17 = 0 + 324;
        val_18 = 0 + 320;
        val_19 = 0 + 316;
        label_23:
        this.reward = val_19;
        mem[1152921513238520916] = val_18;
        mem[1152921513238520920] = val_17;
        mem[1152921513238520924] = val_16;
        string val_10 = Localization.Localize(key:  41711072, defaultValue:  2128510224, useSingularKey:  false);
        GameEcon val_11 = App.getGameEcon;
        string val_12 = this.reward.ToString(format:  null);
        string val_13 = System.String.Format(format:  41711072, arg0:  41739344);
        GameEcon val_14 = App.getGameEcon;
        string val_15 = this.reward.ToString(format:  null);
        if(this.coin_amount == 0)
        {
            
        }
    
    }
    public void OnFreeHintClick(bool result)
    {
        HeyZapAdTag val_21;
        WGMessagePopup val_22;
        System.String[] val_23;
        System.Func<System.Boolean>[] val_24;
        var val_25;
        var val_26;
        if(result != false)
        {
                this.Button_FreeHint.interactable = false;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_21 = this.initTag;
            if((ShowIncentivizedVideo(tag:  val_21, adCapExempt:  false)) == true)
        {
                return;
        }
        
            this.Button_FreeHint.interactable = true;
            UnityEngine.Transform val_3 = this.localPopup.transform;
            UnityEngine.Transform val_4 = this.localPopup.parent;
            UnityEngine.GameObject val_5 = this.localPopup.gameObject;
            this.localPopup.SetActive(value:  true);
            UnityEngine.Transform val_6 = this.localPopup.transform;
            UnityEngine.GameObject val_7 = this.localPopup.gameObject;
            this.localPopup.SetActive(value:  true);
            val_22 = this.localPopup;
            string val_8 = Localization.Localize(key:  2129276784, defaultValue:  2129276896, useSingularKey:  false);
            string val_9 = Localization.Localize(key:  2129276992, defaultValue:  2129277104, useSingularKey:  false);
            typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
            val_23 = null;
            string val_10 = Localization.Localize(key:  2129277264, defaultValue:  2129277376, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_10 = "try_again_later_upper";
            typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
            val_24 = null;
            System.Func<System.Boolean> val_11 = new System.Func<System.Boolean>(object:  41922960, method:  new IntPtr(41884624));
            typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = null;
            val_25 = null;
            val_26 = val_22;
            val_25 = null;
        }
        else
        {
                UnityEngine.Transform val_12 = this.localPopup.transform;
            UnityEngine.Transform val_13 = this.localPopup.parent;
            UnityEngine.GameObject val_14 = this.localPopup.gameObject;
            this.localPopup.SetActive(value:  true);
            UnityEngine.Transform val_15 = this.localPopup.transform;
            UnityEngine.GameObject val_16 = this.localPopup.gameObject;
            this.localPopup.SetActive(value:  true);
            val_22 = this.localPopup;
            string val_17 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
            string val_18 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
            typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
            val_23 = null;
            string val_19 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
            typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
            typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
            val_24 = null;
            System.Func<System.Boolean> val_20 = new System.Func<System.Boolean>(object:  41922960, method:  new IntPtr(41897936));
            typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = null;
            val_25 = null;
            val_25 = null;
            val_26 = val_22;
        }
        
        val_26.SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  val_23, showClose:  false, buttonCallbacks:  val_24, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
    }
    public void OnVideoResponse(Notification notif)
    {
        string val_1 = notif.data.ToString();
        bool val_2 = System.Boolean.Parse(value:  notif.data);
        this.group_start.SetActive(value:  false);
        this.group_success.SetActive(value:  val_2);
        this.Button_CollectHint.interactable = val_2;
        this.group_sorry.SetActive(value:  val_2 ^ 1);
    }
    public void OnCollectClicked()
    {
        int val_6;
        int val_7;
        int val_8;
        int val_9;
        this.Button_CollectHint.interactable = false;
        if(this.coinsAnim != 0)
        {
                System.Action val_2 = new System.Action(object:  42258576, method:  new IntPtr(42221264));
            this.coinsAnim.OnCompleteCallback = null;
            CurrencyController.CreditBalance(value:  new System.Decimal() {flags = mem[this.reward + (0)], hi = mem[this.reward + (4)], lo = mem[this.reward + (8)], mid = mem[this.reward + (12)]}, source:  this.freeCoinEventName, externalParams:  0, animated:  false);
            Player val_3 = App.Player;
            var val_7 = 0;
            val_7 = val_7 + 64;
            val_8 = mem[(0 + 64) + (4)];
            val_7 = mem[(0 + 64) + (0)];
            decimal val_4 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 42246524, hi = 52, lo = val_7, mid = val_8}, d2:  new System.Decimal() {flags = mem[(0 + 64) + (8)], hi = this.reward, mid = this.freeCoinEventName});
            Player val_5 = App.Player;
            this.coinsAnim.Play(fromValue:  new System.Decimal() {mid = val_6}, toValue:  new System.Decimal() {flags = 52, hi = val_9}, textTickTime:  null, delayBeforeComplete:  null);
            if(this.hideTextWhileCollecting == false)
        {
                return;
        }
        
            this.message_thankYou.CrossFadeAlpha(alpha:  null, duration:  null, ignoreTimeScale:  false);
            return;
        }
        
        this.DoCompleteCallback();
    }
    private void CloseSorry()
    {
        this.group_start.SetActive(value:  true);
        this.Button_FreeHint.interactable = true;
        this.group_success.SetActive(value:  false);
        this.group_sorry.SetActive(value:  false);
        UnityEngine.Transform val_1 = this.localPopup.transform;
        UnityEngine.Transform val_2 = this.localPopup.parent;
        UnityEngine.GameObject val_3 = this.localPopup.gameObject;
        this.localPopup.SetActive(value:  false);
    }
    private void OnDisable()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.RemoveObserver(observer:  42548112, name:  2128120864);
    }
    public WGRewardedVideoUI()
    {
        this.freeCoinEventName = "Default:WGRewardedVideoUI";
    }
    private bool <OnFreeHintClick>b__22_0()
    {
        this.CloseSorry();
        return true;
    }
    private bool <OnFreeHintClick>b__22_1()
    {
        this.CloseSorry();
        return true;
    }

}
