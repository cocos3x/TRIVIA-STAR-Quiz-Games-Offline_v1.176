using UnityEngine;
public class TRVExpertsProfilePopup : MonoBehaviour
{
    // Fields
    private TRVExpertDisplay eDisplay;
    private UnityEngine.UI.Button upgradeButton;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Button storeButton;
    private UnityEngine.GameObject upgradeSection;
    private UnityEngine.UI.Text upgradeCostText;
    private UnityEngine.UI.Text upgradeCardText;
    public System.Action onClose;
    private TRVExpert displayingExpert;
    private TRVExpertProgressData progData;
    
    // Methods
    public void Init(TRVExpert expert, TRVExpertProgressData data)
    {
        this.displayingExpert = expert;
        this.progData = data;
        this.DisplayExpertData(expert:  expert, data:  data, fromUpgrade:  false);
        this.closeButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -602050624, method:  new IntPtr(3692874240));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        this.storeButton.m_OnClick.RemoveAllListeners();
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -602050624, method:  new IntPtr(3692891648));
        this.storeButton.m_OnClick.AddListener(call:  162246656);
    }
    private void DisplayExpertData(TRVExpert expert, TRVExpertProgressData data, bool fromUpgrade = False)
    {
        TRVExpertsProfilePopup val_12;
        bool val_13;
        TRVExpertProgressData val_14;
        var val_15;
        val_12 = this;
        val_13 = fromUpgrade;
        val_14 = data;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ExpertLevelReq val_2 = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_C.getReqFromExpert(exp:  expert, prog:  val_14);
        this.eDisplay.Init(me:  expert, progress:  val_14, upgraded:  val_13, showName:  true);
        string val_4 = (public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_C + 16).ToString();
        string val_5 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        Player val_6 = App.Player;
        val_14 = 52;
        val_13 = mem[(public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_C + 16)];
        val_13 = (public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_C + 16);
        decimal val_7 = System.Decimal.op_Implicit(value:  -601880024);
        val_12 = val_12;
        if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal() {flags = data.<cardsOwned>k__BackingField})) != false)
        {
                mem[1152921512594913616] + 172.RemoveAllListeners();
            UnityEngine.Events.UnityAction val_9 = new UnityEngine.Events.UnityAction(object:  -601867968, method:  new IntPtr(3693066112));
            mem[1152921512594913616] + 172.AddListener(call:  162246656);
            UnityEngine.GameObject val_10 = mem[1152921512594913616].gameObject;
            val_15 = 1;
        }
        else
        {
                UnityEngine.GameObject val_11 = this.upgradeButton.gameObject;
            val_15 = 0;
        }
        
        this.upgradeButton.SetActive(value:  false);
    }
    private void Upgrade()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((UpgradeExpert(name:  this.displayingExpert.expertName)) == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_4 = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_18.Item[this.displayingExpert.expertName];
        this.DisplayExpertData(expert:  this.displayingExpert, data:  public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_18, fromUpgrade:  true);
        NotificationCenter val_5 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -2144143840);
    }
    private void OpenStore()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CloseCurrentWindow();
        GameBehavior val_2 = App.getBehavior;
        System.Action val_4 = new System.Action(object:  -601573312, method:  new IntPtr(3693368960));
        0.Init(outOfCredits:  false, onCloseAction:  7454720);
        UnityEngine.GameObject val_5 = this.gameObject;
        SLCWindow.CloseWindow(window:  -601573312, setDestroyOnDisableState:  true, dontDestroyOnDisable:  true);
    }
    private void Close()
    {
        if(this.onClose != 0)
        {
                this.onClose.Invoke();
        }
        
        this.onClose = 0;
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -601457216, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public TRVExpertsProfilePopup()
    {
    
    }
    private void <OpenStore>b__13_0()
    {
        object val_1 = new System.Object();
        typeof(TRVExpertsProfilePopup.<>c__DisplayClass13_0).__il2cppRuntimeField_C = this;
        GameBehavior val_2 = App.getBehavior;
        typeof(TRVExpertsProfilePopup.<>c__DisplayClass13_0).__il2cppRuntimeField_8 = 0;
        System.Action val_4 = new System.Action(object:  352927744, method:  new IntPtr(3693714176));
        mem[64] = null;
    }

}
