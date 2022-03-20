using UnityEngine;
public class WGInvite : MonoBehaviour
{
    // Fields
    protected WGInvite.WGInviteStatus m_status;
    protected UnityEngine.GameObject m_inviteSection;
    protected UnityEngine.UI.Button m_emailBtn;
    protected UnityEngine.UI.Button m_textBtn;
    protected UnityEngine.UI.Button m_moreBtn;
    protected UnityEngine.UI.Text m_eachRewordTxt;
    protected UnityEngine.UI.Text m_text_info;
    private decimal m_eachReward;
    protected UnityEngine.GameObject m_sentSection;
    protected UnityEngine.UI.Button m_sentOKBtn;
    protected UnityEngine.UI.Text m_sentTextInfoTxt;
    protected UnityEngine.GameObject m_collectSection;
    protected UnityEngine.UI.Button m_collectBtn;
    protected UnityEngine.UI.Text m_collectCoinAmoutTxt;
    protected GridCoinCollectAnimationInstantiator coinsAnim;
    
    // Properties
    public WGInvite.WGInviteStatus Status { get; set; }
    
    // Methods
    public WGInvite.WGInviteStatus get_Status()
    {
    
    }
    public void set_Status(WGInvite.WGInviteStatus value)
    {
        goto typeof(WGInvite).__il2cppRuntimeField_DC;
    }
    private void Awake()
    {
        GameEcon val_1 = App.getGameEcon;
        decimal val_2 = System.Decimal.op_Implicit(value:  -20293248);
        string val_3 = this.m_eachReward.ToString();
        string val_4 = Localization.Localize(key:  -20309760, defaultValue:  1098586544, useSingularKey:  false);
        AppConfigs val_5 = App.Configuration;
        string val_6 = System.String.Format(format:  -20309760, arg0:  0);
        string val_7 = Localization.Localize(key:  -20305312, defaultValue:  -20305568, useSingularKey:  false);
        AppConfigs val_8 = App.Configuration;
        GameEcon val_9 = App.getGameEcon;
        string val_10 = System.String.Format(format:  -20305312, arg0:  0, arg1:  13152256);
        if(this.m_sentTextInfoTxt != 0)
        {
                return;
        }
    
    }
    private void Start()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -20113904, method:  typeof(WGInvite).__il2cppRuntimeField_E8);
        this.m_emailBtn.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -20113904, method:  typeof(WGInvite).__il2cppRuntimeField_F0);
        this.m_textBtn.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -20113904, method:  typeof(WGInvite).__il2cppRuntimeField_F8);
        this.m_moreBtn.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -20113904, method:  new IntPtr(4274819152));
        this.m_sentOKBtn.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  -20113904, method:  new IntPtr(4274828368));
        this.m_collectBtn.m_OnClick.AddListener(call:  162246656);
    }
    public virtual void SetStatus(WGInvite.WGInviteStatus status)
    {
        this.m_inviteSection.SetActive(value:  false);
        this.m_sentSection.SetActive(value:  false);
        this.m_collectSection.SetActive(value:  false);
        if(status <= 4)
        {
                var val_1 = 6868768 + (6868768 + (status) << 2);
            if(status == 4)
        {
                6868768 = 6868768 & (status << 6868768);
            6868768 = 6868768 & (status >> 32);
            6868768 = 6868768 & (status >> 6868768);
            6868768 = 6868768 & (status << 6868768);
            6868768 = 6868768 & (status << 6868768);
        }
        
        }
        
        this.m_status = status;
    }
    public virtual void OnEmailButtonClicked()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SendEmail();
        this.Invoke(methodName:  -19840176, time:  null);
    }
    public virtual void OnTextButtonClicked()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SendText();
        this.Invoke(methodName:  -19840176, time:  null);
    }
    public virtual void OnMoreButtonClicked()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ShareMore();
        this.Invoke(methodName:  -19840176, time:  null);
    }
    private void SetToSentStatus()
    {
        WGInviteManager.InviteSent = true;
    }
    protected virtual void OpenAndInitInviteSection()
    {
        this.m_inviteSection.SetActive(value:  true);
    }
    protected virtual void OpenAndInitSentInviteSection()
    {
        this.m_sentSection.SetActive(value:  true);
    }
    protected virtual void OpenAndInitCollectSection()
    {
        this.m_collectSection.SetActive(value:  true);
        if(this.coinsAnim != 0)
        {
                mem2[0] = 0;
        }
        
        this.m_collectBtn.interactable = true;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_4 = RewardCoinsCount.ToString();
        if(this.m_collectCoinAmoutTxt != 0)
        {
                return;
        }
    
    }
    public void OnSentOKButtonClicked()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -18974720, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnCollectButtonClicked()
    {
        int val_10;
        int val_11;
        int val_12;
        this.m_collectBtn.interactable = false;
        val_11 = 1152921511590430016;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_12 = RewardCoinsCount;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        RewardInviteSuccessfull();
        if(this.coinsAnim == 0)
        {
                return;
        }
        
        System.Action val_5 = new System.Action(object:  -18845312, method:  new IntPtr(4276092864));
        this.coinsAnim.OnCompleteCallback = null;
        Player val_6 = App.Player;
        decimal val_7 = System.Decimal.op_Implicit(value:  -18857364);
        decimal val_8 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -18857380, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
        Player val_9 = App.Player;
        this.coinsAnim.Play(fromValue:  new System.Decimal() {mid = val_10}, toValue:  new System.Decimal() {hi = val_11, mid = val_12}, textTickTime:  null, delayBeforeComplete:  null);
    }
    private void OnCoinsAnimFinished()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -18716928, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -18604928, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnDisable()
    {
        var val_8;
        this.StopAllCoroutines();
        val_8 = 1152921512050304720;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1146476848) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(CheckAvailable() == false)
        {
                return;
        }
        
        GameBehavior val_5 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        GameBehavior val_6 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    private void OnDestroy()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -18339968, method:  typeof(WGInvite).__il2cppRuntimeField_E8);
        this.m_emailBtn.m_OnClick.RemoveListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -18339968, method:  typeof(WGInvite).__il2cppRuntimeField_F0);
        this.m_textBtn.m_OnClick.RemoveListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -18339968, method:  typeof(WGInvite).__il2cppRuntimeField_F8);
        this.m_moreBtn.m_OnClick.RemoveListener(call:  162246656);
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -18339968, method:  new IntPtr(4274819152));
        this.m_sentOKBtn.m_OnClick.RemoveListener(call:  162246656);
        UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  -18339968, method:  new IntPtr(4274828368));
        this.m_collectBtn.m_OnClick.RemoveListener(call:  162246656);
    }
    public WGInvite()
    {
         = new System.Decimal(value:  300);
    }

}
