using UnityEngine;
public class WGInviteV2 : WGInvite
{
    // Fields
    protected UnityEngine.UI.Button m_whatsAppBtn;
    protected UnityEngine.UI.Button m_enterFriendCode;
    protected UnityEngine.UI.Text m_textRewardChest;
    protected UnityEngine.UI.Slider m_invitesProggression;
    private UnityEngine.GameObject m_enterCodeSection;
    private UnityEngine.UI.InputField m_enterCodeInput;
    private UnityEngine.UI.Button m_enterCodeButton;
    private UnityEngine.Vector3 m_inputOffset;
    private UnityEngine.GameObject m_MessageSection;
    private UnityEngine.UI.Text m_MessageTitleText;
    private UnityEngine.UI.Text m_ErrorTitleText;
    private UnityEngine.UI.Text m_MessageSectionText;
    private UnityEngine.UI.Button m_MessageSectionButton;
    private UnityEngine.GameObject m_MessageCloseButton;
    private UnityEngine.GameObject chestGO;
    private UnityEngine.GameObject closedChest;
    private UnityEngine.GameObject openedChest;
    private CurrencyCollectAnimationInstantiator chestCoinAnim;
    private System.Collections.Generic.List<UnityEngine.UI.RawImage> chestImages;
    private System.Collections.Generic.List<UnityEngine.Texture> bronzeChestTextures;
    private System.Collections.Generic.List<UnityEngine.Texture> silverChestTextures;
    private System.Collections.Generic.List<UnityEngine.Texture> goldChestTextures;
    private System.Collections.Generic.List<UnityEngine.GameObject> progressChestGO;
    private System.Collections.Generic.List<UnityEngine.UI.Text> progressChestText;
    private string InviteCode;
    private UnityEngine.Vector3 enterCodePosition;
    private const float CHEST_SCALE_0 = 0.25;
    private const float CHEST_SCALE_DURATION = 1;
    private const float CHEST_SCALE_DELAY = 2;
    
    // Methods
    private void Awake()
    {
        var val_20;
        GameEcon val_1 = App.getGameEcon;
        string val_2 = 548.ToString();
        string val_3 = Localization.Localize(key:  -8951808, defaultValue:  -8951984, useSingularKey:  false);
        GameEcon val_4 = App.getGameEcon;
        string val_5 = System.String.Format(format:  -8951808, arg0:  13152256);
        string val_6 = Localization.Localize(key:  -8951376, defaultValue:  -8951680, useSingularKey:  false);
        AppConfigs val_7 = App.Configuration;
        GameEcon val_8 = App.getGameEcon;
        string val_9 = System.String.Format(format:  -8951376, arg0:  0, arg1:  13152256);
        UnityEngine.Transform val_10 = this.m_enterCodeSection.transform;
        UnityEngine.Vector3 val_11 = localPosition;
        UnityEngine.Events.UnityAction val_12 = new UnityEngine.Events.UnityAction(object:  -8871968, method:  new IntPtr(4286028320));
        this.m_enterFriendCode.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_13 = new UnityEngine.Events.UnityAction(object:  -8871968, method:  new IntPtr(4286037536));
        this.m_whatsAppBtn.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_14 = new UnityEngine.Events.UnityAction(object:  -8871968, method:  new IntPtr(4286046752));
        this.m_enterCodeButton.m_OnClick.AddListener(call:  162246656);
        object val_15 = this.m_enterCodeSection.AddComponent<System.Object>();
        System.Action val_16 = new System.Action(object:  -8871968, method:  new IntPtr(4286051872));
        System.Delegate val_17 = System.Delegate.Combine(a:  162246656, b:  7454720);
        val_20 = null;
        if(val_20 != 0)
        {
                if(null == null)
        {
            goto label_23;
        }
        
        }
        
        val_20 = 0;
        label_23:
        mem2[0] = val_20;
        UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder> val_18 = new UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder>(object:  -8871968, method:  new IntPtr(4286061088));
        this.m_enterCodeInput.m_OnEndEdit.AddListener(call:  162353152);
        UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder> val_19 = new UnityEngine.Events.UnityAction<UnityEngine.UI.LayoutRebuilder>(object:  -8871968, method:  new IntPtr(4286070304));
        this.m_enterCodeInput.m_OnValueChanged.AddListener(call:  162353152);
    }
    public override void SetStatus(WGInvite.WGInviteStatus status)
    {
        UnityEngine.GameObject val_2;
        R6.SetActive(value:  false);
        R6.SetActive(value:  false);
        R6.SetActive(value:  false);
        this.m_enterCodeSection.SetActive(value:  false);
        val_2 = this.m_MessageSection;
        val_2.SetActive(value:  false);
        if(status <= 4)
        {
                var val_1 = 6898068 + (6898068 + (status) << 2);
            if(status == 4)
        {
                6898068 = 6898068 & (status << 6898068);
            6898068 = 6898068 & (status >> 32);
            6898068 = 6898068 & (status >> 6898068);
            6898068 = 6898068 & (((int)IP) >> 32);
            6898068 = 6898068 & (((int)R8) >> ((((6898068 & (status) << 6898068) & (status) >> 32) & (status) >> ((6898068 & (status) << 6898068) & (status) >> 32)) & ((int)IP) >> 32));
        }
        
            this.OpenAndInitCollectSection();
        }
        
        mem[1152921513188087148] = status;
    }
    public override void OnMoreButtonClicked()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CopyToClipboard();
    }
    public void OnEnterInviteCodeClick()
    {
        goto typeof(WGInviteV2).__il2cppRuntimeField_DC;
    }
    public void ShowInvite()
    {
        goto typeof(WGInviteV2).__il2cppRuntimeField_DC;
    }
    public void OnCodeValueInputChanged(string value)
    {
        if((System.String.IsNullOrEmpty(value:  value)) == true)
        {
                return;
        }
        
        string val_2 = R5.ToUpper();
        R4 + 104.text = R5;
    }
    public void OnCodeInputEndEdit(string value)
    {
        UnityEngine.UI.Button val_3 = this.m_enterCodeButton;
        val_3.interactable = false;
        if((System.String.IsNullOrEmpty(value:  value)) == true)
        {
                return;
        }
        
        val_3 = this.m_enterCodeButton;
        val_3.interactable = true;
        string val_2 = value.ToUpper();
        this.InviteCode = value;
    }
    private void UpdateInputPos()
    {
        if(this.m_enterCodeSection.activeSelf == false)
        {
                return;
        }
        
        UnityEngine.Transform val_2 = this.m_enterCodeSection.transform;
        if(this.m_enterCodeInput.m_AllowInput != false)
        {
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0f, y = mem[this.enterCodePosition + (0)], z = mem[this.enterCodePosition + (4)]}, b:  new UnityEngine.Vector3() {x = mem[this.enterCodePosition + (8)], y = this.m_inputOffset});
        }
        
        this.m_enterCodeSection.localPosition = new UnityEngine.Vector3() {x = R6, y = R7, z = SB};
    }
    public void OnEnterCodeButtonClicked()
    {
        if((System.String.IsNullOrEmpty(value:  this.InviteCode)) != false)
        {
                return;
        }
        
        this.m_enterCodeButton.interactable = false;
        if(WGInviteManager.isInvited != false)
        {
                this.OnEnterCodeResponse(response:  -7852512);
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_4 = this.InviteCode.ToUpper();
        System.Action<twelvegigs.storage.JsonDictionary> val_5 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -7823312, method:  new IntPtr(4287118960));
        SentInviteCode(inviteCode:  this.InviteCode, codeResponse:  7401472);
    }
    public void OnEnterCodeResponse(string response)
    {
        UnityEngine.UI.Text val_22;
        var val_23;
        var val_24;
        this.m_enterCodeButton.interactable = true;
        if((response.Contains(value:  1616271776)) != false)
        {
                UnityEngine.GameObject val_2 = this.m_ErrorTitleText.gameObject;
            this.m_ErrorTitleText.SetActive(value:  false);
            UnityEngine.Transform val_3 = this.m_MessageTitleText.transform;
            UnityEngine.Transform val_4 = this.m_MessageTitleText.parent;
            UnityEngine.GameObject val_5 = this.m_MessageTitleText.gameObject;
            this.m_MessageTitleText.SetActive(value:  true);
            this.m_MessageCloseButton.SetActive(value:  true);
            string val_6 = Localization.Localize(key:  -7698336, defaultValue:  -7698448, useSingularKey:  false);
            string val_7 = Localization.Localize(key:  -7693920, defaultValue:  -7694144, useSingularKey:  false);
            GameEcon val_8 = App.getGameEcon;
            string val_9 = System.String.Format(format:  -7693920, arg0:  13152256);
            object val_10 = this.m_MessageSectionButton.GetComponentInChildren<System.Object>();
            string val_11 = Localization.Localize(key:  -1468908784, defaultValue:  1098586544, useSingularKey:  false);
            if(this.m_MessageSectionButton != 0)
        {
                return;
        }
        
            return;
        }
        
        UnityEngine.GameObject val_13 = this.m_ErrorTitleText.gameObject;
        this.m_ErrorTitleText.SetActive(value:  true);
        UnityEngine.Transform val_14 = this.m_MessageTitleText.transform;
        UnityEngine.Transform val_15 = this.m_MessageTitleText.parent;
        UnityEngine.GameObject val_16 = this.m_MessageTitleText.gameObject;
        this.m_MessageTitleText.SetActive(value:  false);
        this.m_MessageCloseButton.SetActive(value:  false);
        if((response.Contains(value:  -7852512)) != false)
        {
                string val_17 = Localization.Localize(key:  -7673216, defaultValue:  -7673328, useSingularKey:  false);
            val_22 = this.m_MessageSectionText;
            val_23 = "A valid friend code has already been entered. Only one friend code can be entered.";
            val_24 = "inviter_v2_duplicate_code_text";
        }
        else
        {
                string val_18 = Localization.Localize(key:  -7668528, defaultValue:  -7668624, useSingularKey:  false);
            val_22 = this.m_MessageSectionText;
            val_23 = "Seems like the friend code you entered is invalid. Please check and try again.";
            val_24 = "inviter_v2_invalid_text";
        }
        
        string val_19 = Localization.Localize(key:  -7664080, defaultValue:  -7664304, useSingularKey:  false);
        object val_20 = this.m_MessageSectionButton.GetComponentInChildren<System.Object>();
        string val_21 = Localization.Localize(key:  -1827175552, defaultValue:  1098586544, useSingularKey:  false);
        if(this.m_MessageSectionButton == 0)
        {
            
        }
    
    }
    protected override void OpenAndInitInviteSection()
    {
        var val_25;
        this.OpenAndInitInviteSection();
        this.chestGO.SetActive(value:  false);
        UnityEngine.GameObject val_1 = this.m_whatsAppBtn.gameObject;
        if((WGInviteManager.<IsWhatsAppInstalled>k__BackingField) == true)
        {
                WGInviteManager.<IsWhatsAppInstalled>k__BackingField = 1;
        }
        
        this.m_whatsAppBtn.SetActive(value:  true);
        UnityEngine.GameObject val_2 = this.m_whatsAppBtn.gameObject;
        this.m_whatsAppBtn.SetActive(value:  true);
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        GameEcon val_5 = App.getGameEcon;
        float val_25 = 18f;
        val_25 = (float)InvitesCollected / val_25;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_8 = Localization.Localize(key:  -7470032, defaultValue:  -7469904, useSingularKey:  false);
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_12 = UnityEngine.Mathf.Max(a:  0, b:  NextTargetTierInvites() - InvitesCollected);
        string val_13 = System.String.Format(format:  -7470032, arg0:  13152256);
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        TierReward val_15 = NextTier();
        if((public static WGInviteManager MonoSingleton<WGInviteManager>::get_Instance()) <= (public static WGInviteManager MonoSingleton<WGInviteManager>::get_Instance()))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_17 = InvitesCollected;
        val_25 = 0;
        string val_18 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        if(mem[1152921515353839936] != 0)
        {
            goto label_25;
        }
        
        goto label_25;
        label_34:
        if(mem[1152921515353839936] <= val_25)
        {
                var val_26 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_26 = val_26 + 0;
        if(val_25 >= (public static WGInviteManager MonoSingleton<WGInviteManager>::get_Instance()))
        {
                0 = 1;
        }
        
        (0 + 0) + 16.SetActive(value:  true);
        if(((0 + 0) + 16) <= val_25)
        {
                var val_27 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_27 = val_27 + 0;
        UnityEngine.GameObject val_19 = (0 + 0) + 16.gameObject;
        (0 + 0) + 16.SetActive(value:  true);
        val_25 = 1;
        label_25:
        if(val_25 < ((0 + 0) + 16))
        {
            goto label_34;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(InvitesCollected < NextTargetTierInvites())
        {
                return;
        }
        
        System.Collections.IEnumerator val_23 = this.ShowCollectTierReward();
        UnityEngine.Coroutine val_24 = this.StartCoroutine(routine:  -7429344);
    }
    protected void OpenAndInitEnterSection()
    {
        this.InviteCode = System.String.alignConst;
        this.m_enterCodeInput.text = System.String.alignConst;
        this.m_enterCodeSection.SetActive(value:  true);
    }
    protected void OnWhatsAppClick()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SendWhatsApp();
        this.Invoke(methodName:  -19840176, time:  null);
    }
    private System.Collections.IEnumerator ShowCollectTierReward()
    {
        object val_1 = new System.Object();
        typeof(WGInviteV2.<ShowCollectTierReward>d__42).__il2cppRuntimeField_8 = 0;
        typeof(WGInviteV2.<ShowCollectTierReward>d__42).__il2cppRuntimeField_10 = this;
    }
    public WGInviteV2()
    {
    
    }

}
