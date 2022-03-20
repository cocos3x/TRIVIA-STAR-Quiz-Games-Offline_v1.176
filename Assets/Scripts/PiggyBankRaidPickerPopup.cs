using UnityEngine;
public class PiggyBankRaidPickerPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject introGroup;
    private UnityEngine.UI.Button continueButton;
    private UnityEngine.GameObject raidGroup;
    private UnityEngine.UI.Image profileImage;
    private UnityEngine.UI.Text profileNameText;
    private UnityEngine.UI.Text profileCoinAmountText;
    private UnityEngine.UI.Text youStoleAmountText;
    private UnityEngine.UI.Button[] raidButtons;
    private UnityEngine.UI.Image[] raidPiggyImages;
    private UnityEngine.GameObject[] raidAmountGroups;
    private UnityEngine.UI.Text[] raidAmountTexts;
    private UnityEngine.ParticleSystem[] raidParticles;
    private UnityEngine.ParticleSystem coinBurstParticle;
    private UnityEngine.UI.Text pickAmountText;
    private UnityEngine.GameObject addToPiggyGroup;
    private UnityEngine.UI.Text addToPiggyAmountText;
    private UnityEngine.UI.Button addToPiggyButton;
    private SLC.Social.AvatarConfig avatarConfig;
    private decimal stoleAmount;
    private System.Action onCloseCallback;
    private int pickAmount;
    private UnityEngine.CanvasGroup introCanvasGroup;
    private UnityEngine.CanvasGroup raidCanvasGroup;
    private System.Collections.Generic.List<System.Decimal> pickerCoinOptions;
    
    // Methods
    public void Initialize(PiggyBankRaidPlayerProfile opponent, System.Action onClose)
    {
        var val_9;
        UnityEngine.UI.Text val_10;
        System.Collections.Generic.List<System.Decimal> val_12;
        var val_13;
        System.Action val_14;
        UnityEngine.Sprite val_1 = this.avatarConfig.GetAvatarSpriteByID(id:  opponent.avatarId);
        this.profileImage.sprite = this.avatarConfig;
        GameEcon val_2 = App.getGameEcon;
        string val_3 = opponent.coins.ToString(format:  null);
        int val_8 = 25831136;
        val_8 = 9802044 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = null;
        val_9 = null;
        System.Collections.Generic.List<System.Decimal> val_4 = PiggyBankRaidEventHandler.<Instance>k__BackingField.GeneratePickerOptionsFromCoins(coins:  new System.Decimal() {flags = opponent.coins, hi = opponent.coins, lo = typeof(UnityEngine.UI.Text).__il2cppRuntimeField_314, mid = val_8});
        val_12 = PiggyBankRaidEventHandler.<Instance>k__BackingField;
        this.pickerCoinOptions = PiggyBankRaidEventHandler.<Instance>k__BackingField;
        val_13 = 0;
        goto label_15;
        label_25:
        if((PiggyBankRaidEventHandler.<Instance>k__BackingField) <= val_13)
        {
                var val_9 = 0;
        }
        
        val_10 = this.raidAmountTexts[val_13];
        if(this.raidAmountTexts[val_13] <= val_13)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_9 = val_9 + 0;
        val_9 = val_9 + 16;
        GameEcon val_5 = App.getGameEcon;
        string val_6 = ToString(format:  null);
        val_12 = this.pickerCoinOptions;
        val_13 = 1;
        label_15:
        if(val_13 < val_10)
        {
            goto label_25;
        }
        
        val_14 = this.onCloseCallback;
        System.Delegate val_7 = System.Delegate.Combine(a:  val_14, b:  onClose);
        if(val_14 != 0)
        {
                if(null == null)
        {
            goto label_27;
        }
        
        }
        
        val_14 = 0;
        label_27:
        this.onCloseCallback = val_14;
    }
    private void Start()
    {
        float val_15;
        float val_16;
        float val_17;
        var val_18;
        var val_19;
        UnityEngine.UI.Button val_17 = this.raidButtons[0];
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1105253136, method:  new IntPtr(3189511984));
        this.raidButtons[0].m_OnClick.AddListener(call:  162246656);
        UnityEngine.UI.Button val_18 = this.raidButtons[1];
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1105253136, method:  new IntPtr(3189558064));
        this.raidButtons[1].m_OnClick.AddListener(call:  162246656);
        UnityEngine.UI.Button val_19 = this.raidButtons[2];
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -1105253136, method:  new IntPtr(3189604144));
        this.raidButtons[2].m_OnClick.AddListener(call:  162246656);
        UnityEngine.UI.Button val_20 = this.raidButtons[3];
        UnityEngine.Events.UnityAction val_4 = new UnityEngine.Events.UnityAction(object:  -1105253136, method:  new IntPtr(3189650224));
        this.raidButtons[3].m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  -1105253136, method:  new IntPtr(3189659440));
        this.continueButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  -1105253136, method:  new IntPtr(3189668656));
        this.addToPiggyButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.UI.LayoutElement val_7 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  this.introGroup);
        this.introCanvasGroup = this.introGroup;
        UnityEngine.UI.LayoutElement val_8 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  this.raidGroup);
        this.raidCanvasGroup = this.raidGroup;
        this.introGroup.SetActive(value:  true);
        this.raidGroup.SetActive(value:  false);
        this.UpdateText();
        this.TweenInIntroGroup();
        val_17 = 1152921504901095424;
        val_18 = 1152921511025997392;
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(2124183120 == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_11 = this.raidGroup.transform;
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_19 = 0;
        float val_13 = GetBannerAdHeight();
        if(this.raidGroup != 0)
        {
                if(null == null)
        {
            goto label_33;
        }
        
        }
        
        val_18 = 1;
        goto label_34;
        label_33:
        val_18 = 0;
        val_19 = this.raidGroup;
        label_34:
        UnityEngine.Vector2 val_14 = offsetMin;
        float val_21 = val_15;
        val_17 = val_16;
        val_21 = 2124183120 + val_21;
        val_19.offsetMin = new UnityEngine.Vector2() {x = val_17, y = val_21};
    }
    private void OnDisable()
    {
        if(this.onCloseCallback == 0)
        {
                return;
        }
        
        this.onCloseCallback.Invoke();
    }
    private void TweenInIntroGroup()
    {
        this.introCanvasGroup.alpha = null;
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.introCanvasGroup, endValue:  null, duration:  null);
    }
    private void TweenInRaidGroup()
    {
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.introCanvasGroup, endValue:  null, duration:  null);
        DG.Tweening.TweenCallback val_2 = new DG.Tweening.TweenCallback(object:  -1104658064, method:  new IntPtr(3190271920));
        object val_3 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.introCanvasGroup, action:  190734336);
        this.raidGroup.SetActive(value:  true);
        this.raidCanvasGroup.alpha = null;
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.raidCanvasGroup, endValue:  null, duration:  null);
        object val_5 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.raidCanvasGroup, delay:  null);
    }
    private void PickRaidOptions(int optionIndex)
    {
        int val_1 = this.pickAmount;
        if(val_1 < 1)
        {
                return;
        }
        
        val_1 = val_1 - 1;
        this.pickAmount = val_1;
        this.ShowRaidOptionResult(optionIndex:  optionIndex);
        this.UpdateText();
        if(this.pickAmount > 0)
        {
                return;
        }
        
        R4.OnRaidFinished();
    }
    private void UpdateText()
    {
        string val_1 = Localization.Localize(key:  -1104441600, defaultValue:  -1104441680, useSingularKey:  false);
        GameEcon val_2 = App.getGameEcon;
        string val_3 = this.pickAmount.ToString(format:  null);
        string val_4 = System.String.Format(format:  1592589744, arg0:  -1104441600, arg1:  this.pickAmount);
        string val_5 = Localization.Localize(key:  -1104433216, defaultValue:  -1104433312, useSingularKey:  false);
        GameEcon val_6 = App.getGameEcon;
        string val_7 = this.stoleAmount.ToString(format:  null);
        string val_8 = System.String.Format(format:  -1104433216, arg0:  this.stoleAmount);
        if(this.youStoleAmountText == 0)
        {
            
        }
    
    }
    private void OnRaidFinished()
    {
        var val_5 = 0;
        goto label_1;
        label_6:
        UnityEngine.UI.Button val_5 = this.raidButtons[val_5];
        val_5.interactable = false;
        val_5 = 1;
        label_1:
        if(val_5 < val_5)
        {
            goto label_6;
        }
        
        this.addToPiggyGroup.SetActive(value:  true);
        string val_1 = Localization.Localize(key:  -1104226768, defaultValue:  -1104226896, useSingularKey:  false);
        GameEcon val_2 = App.getGameEcon;
        string val_3 = this.stoleAmount.ToString(format:  null);
        string val_4 = System.String.Format(format:  -1104226768, arg0:  this.stoleAmount, arg1:  this.profileNameText);
        if(this.addToPiggyAmountText == 0)
        {
            
        }
    
    }
    private void ShowRaidOptionResult(int optionIndex)
    {
        var val_10;
        this.raidButtons[optionIndex].interactable = false;
        UnityEngine.UI.Image val_11 = this.raidPiggyImages[optionIndex];
        UnityEngine.Transform val_1 = val_11.transform;
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOScale(target:  val_11, endValue:  null, duration:  null);
        UnityEngine.GameObject val_12 = this.raidAmountGroups[optionIndex];
        UnityEngine.Transform val_3 = val_12.transform;
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions.DOScale(target:  val_12, endValue:  null, duration:  null);
        var val_13 = 1045220557;
        object val_5 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  val_12, delay:  null);
        if(val_12 <= optionIndex)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_10 = null;
        val_13 = val_13 + (optionIndex << 4);
        var val_6 = val_13 + 16;
        val_10 = null;
        int val_14 = mem[((1045220557 + (optionIndex) << 4) + 16) + (4)];
        if((System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = mem[((1045220557 + (optionIndex) << 4) + 16) + (0)], hi = val_14, lo = mem[((1045220557 + (optionIndex) << 4) + 16) + (8)], mid = (1045220557 + (optionIndex) << 4) + 28}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == true)
        {
                return;
        }
        
        if(this.stoleAmount <= optionIndex)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_14 = val_14 + (optionIndex << 4);
        var val_8 = val_14 + 16;
        decimal val_9 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -1103836480, hi = this.stoleAmount, lo = this.stoleAmount, mid = this.stoleAmount}, d2:  new System.Decimal() {flags = this.stoleAmount, hi = mem[((mem[((1045220557 + (optionIndex) << 4) + 16) + (4)] + (optionIndex) << 4) + 16) + (0)], lo = mem[((mem[((1045220557 + (optionIndex) << 4) + 16) + (4)] + (optionIndex) << 4) + 16) + (4)], mid = mem[((mem[((1045220557 + (optionIndex) << 4) + 16) + (4)] + (optionIndex) << 4) + 16) + (8)]});
        this.raidParticles[optionIndex].Play();
        this.coinBurstParticle.Play();
    }
    private void OnRaidButton1Clicked()
    {
        this.PickRaidOptions(optionIndex:  0);
    }
    private void OnRaidButton2Clicked()
    {
        this.PickRaidOptions(optionIndex:  1);
    }
    private void OnRaidButton3Clicked()
    {
        this.PickRaidOptions(optionIndex:  2);
    }
    private void OnRaidButton4Clicked()
    {
        this.PickRaidOptions(optionIndex:  3);
    }
    private void OnContinueClicked()
    {
        this.TweenInRaidGroup();
    }
    private void OnAddToPiggyClicked()
    {
        int val_6;
        int val_7;
        int val_13;
        int val_14;
        int val_15;
        PiggyBankRaidPickerPopup val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        val_21 = this;
        var val_21 = 25825500;
        val_21 = 9807680 + val_21;
        if(val_21 == 0)
        {
                mem2[0] = 1;
        }
        
        val_22 = null;
        val_22 = null;
        PiggyBankRaidEventHandler.<Instance>k__BackingField.SendRaidResultToServer(amountStolen:  new System.Decimal() {flags = this.stoleAmount, hi = R5, lo = R6, mid = 1152921504935813120});
        CompanyDevices val_1 = CompanyDevices.Instance;
        val_23 = 1152921504935813120;
        val_24 = 35633180;
        if(0.CompanyDevice() != false)
        {
                val_25 = null;
            val_25 = null;
            if((PiggyBankRaidEventHandler.<Instance>k__BackingField.<QA_NextPiggyCreditFillExactlyMax>k__BackingField) != false)
        {
                int val_3 = PiggyBankRaidEventHandler.<Instance>k__BackingField.PiggyBankLevel;
            decimal val_4 = Item[-1406235440];
            decimal val_5 = PiggyBankCoins;
            decimal val_8 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1102992080}, d2:  new System.Decimal() {flags = val_6, hi = val_7});
            PiggyBankRaidEventHandler.<Instance>k__BackingField.<QA_NextPiggyCreditFillExactlyMax>k__BackingField = false;
            val_21 = val_21;
            string val_9 = -1103004384(-1103004384) + 10170368;
            UnityEngine.Debug.LogWarning(message:  -1103004384);
            val_23 = 1152921504935813120;
            val_24 = 35633180;
        }
        
        }
        
        val_26 = null;
        val_26 = null;
        decimal val_10 = PiggyBankCoins;
        val_27 = null;
        val_27 = null;
        decimal val_11 = PiggyBankCoins;
        decimal val_12 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -1102992052}, d2:  new System.Decimal() {flags = val_6, hi = mem[this.stoleAmount + (0)], lo = mem[this.stoleAmount + (4)], mid = mem[this.stoleAmount + (8)]});
        PiggyBankRaidEventHandler.<Instance>k__BackingField.PiggyBankCoins = new System.Decimal() {flags = val_7, hi = val_13, lo = val_14, mid = val_15};
        val_28 = null;
        val_28 = null;
        PiggyBankRaidEventHandler.<Instance>k__BackingField.UpdateProgressToServer();
        val_29 = null;
        val_29 = null;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_16 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1928141856, value:  10170368);
        Add(key:  -1108687504, value:  10170368);
        var val_22 = 25816274;
        val_22 = 9809264 + val_22;
        if(val_22 == 0)
        {
                mem2[0] = 1;
        }
        
        val_30 = null;
        val_30 = null;
        App.trackerManager.track(eventName:  -1103004192, data:  78753792);
        val_31 = null;
        val_31 = null;
        PiggyBankRaidEventHandler.<Instance>k__BackingField.currPurchasePoint = 103;
        GameBehavior val_17 = App.getBehavior;
        0.PlayAddCoinAnimation(addedAmount:  new System.Decimal() {flags = this.stoleAmount, hi = mem[1152921512093801672], lo = mem[1152921512093801676], mid = mem[1152921512093801680]});
        UnityEngine.GameObject val_19 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1102979984, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public PiggyBankRaidPickerPopup()
    {
        this.pickAmount = 3;
    }
    private void <TweenInRaidGroup>b__28_0()
    {
        this.introGroup.SetActive(value:  false);
    }

}
