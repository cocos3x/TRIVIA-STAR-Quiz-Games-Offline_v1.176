using UnityEngine;
public class SeasonPassEventPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject mainWindow;
    private UnityEngine.GameObject infoWindow;
    private UnityEngine.UI.Text titleText;
    private UnityEngine.UI.Button showPassButton;
    private UnityEngine.GameObject activePassGO;
    private UnityEngine.UI.Button infoButton;
    private UnityEngine.UI.Text lvlProgressionText;
    private UnityEngine.UI.Slider lvlProgressionBar;
    private UnityEngine.UI.Text currentTierText;
    private UnityEngine.UI.Image currentTierImg;
    private UnityEngine.UI.Button continueButton;
    private UnityEngine.UI.Button levelButton;
    private UnityEngine.UI.LoopVerticalScrollRect loopScrollRect;
    private UnityEngine.RectTransform maskTransform;
    private UnityEngine.RectTransform tiersScrollContainer;
    public UnityEngine.GameObject tierHeader;
    public UnityEngine.GameObject tierLockDivider;
    private SeasonPassTierUI tierRewardPrefab;
    private UnityEngine.Sprite freeTierIcon;
    public System.Collections.Generic.List<UnityEngine.Sprite> tierIconTextures;
    private UnityEngine.GameObject passWindow;
    private UGUINetworkedButton purchasePassButton;
    private UnityEngine.UI.Text passTimerText;
    private UnityEngine.UI.Text timerText;
    private GridCoinCollectAnimationInstantiator coinsAnimControl;
    private CurrencyCollectAnimationInstantiator gemAnimControl;
    private CurrencyCollectAnimationInstantiator goldCurrencyAnimControl;
    private WADPetFoodAnimationInstantiator foodAnimControl;
    private PetCardAnimationInstantiator petCardControl;
    private UnityEngine.Transform currencyAnimParent;
    private SeasonPassEventHandler eventHandler;
    private bool onLevelCompleted;
    private System.Collections.Generic.List<System.Tuple<SeasonPassEcon.Item, System.Decimal>> claimedAwards;
    
    // Methods
    public void Start()
    {
        System.Action<System.Boolean> val_10;
        var val_10 = 27846836;
        val_10 = 7782440 + val_10;
        if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
        this.eventHandler = SeasonPassEventHandler.<Instance>k__BackingField;
        mem2[0] = (this.eventHandler.<econ>k__BackingField.tiers) + 1;
        this.loopScrollRect.RefillCells(offset:  0);
        UnityEngine.GameObject val_2 = this.gameObject;
        UnityEngine.UI.LayoutElement val_3 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -1048952000);
        System.Action val_4 = new System.Action(object:  -1048952000, method:  new IntPtr(3245957504));
        this.showPassButton = null;
        UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  -1048952000, method:  new IntPtr(3245966720));
        this.levelButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  -1048952000, method:  new IntPtr(3245975936));
        this.continueButton.m_OnClick.AddListener(call:  162246656);
        System.Action<System.Boolean> val_7 = new System.Action<System.Boolean>(object:  -1048952000, method:  new IntPtr(3245981056));
        this.purchasePassButton.OnConnectionClick = null;
        System.Action<System.Boolean> val_8 = new System.Action<System.Boolean>(object:  -1048952000, method:  new IntPtr(3245990272));
        System.Delegate val_9 = System.Delegate.Combine(a:  this.eventHandler.OnPurchaseAttempt, b:  7401472);
        val_10 = this.eventHandler.OnPurchaseAttempt;
        if(val_10 != 0)
        {
                if(null == null)
        {
            goto label_17;
        }
        
        }
        
        val_10 = 0;
        label_17:
        this.eventHandler.OnPurchaseAttempt = val_10;
        this.RefreshUI();
    }
    private void OnDestroy()
    {
        System.Action<System.Boolean> val_3;
        System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  -1048782656, method:  new IntPtr(3245990272));
        System.Delegate val_2 = System.Delegate.Remove(source:  this.eventHandler.OnPurchaseAttempt, value:  7401472);
        val_3 = this.eventHandler.OnPurchaseAttempt;
        if(val_3 != 0)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        val_3 = 0;
        label_4:
        this.eventHandler.OnPurchaseAttempt = val_3;
    }
    public void UICompleteLevel()
    {
        this.onLevelCompleted = true;
    }
    public void RefreshUI()
    {
        this.mainWindow.SetActive(value:  true);
        this.infoWindow.SetActive(value:  false);
        this.passWindow.SetActive(value:  false);
        GameBehavior val_1 = App.getBehavior;
        UnityEngine.GameObject val_2 = this.continueButton.gameObject;
        this.continueButton.SetActive(value:  this.continueButton >> 5);
        UnityEngine.GameObject val_5 = this.levelButton.gameObject;
        if(0 != 2)
        {
                0 - 2 = 1;
        }
        
        this.levelButton.SetActive(value:  true);
        string val_6 = this.eventHandler.uniqueSeasonName;
        object val_7 = this.levelButton.GetComponentInChildren<System.Object>();
        string val_8 = Localization.Localize(key:  -2116031904, defaultValue:  1098586544, useSingularKey:  false);
        Player val_9 = App.Player;
        string val_10 = System.String.Format(format:  1592589744, arg0:  -2116031904, arg1:  13152256);
        int val_11 = this.eventHandler.CurrentTierProgression();
        int val_12 = this.eventHandler.NextTierTarget();
        int val_14 = UnityEngine.Mathf.Min(a:  (this.eventHandler.<progression>k__BackingField.currentTier) + 1, b:  30);
        float val_37 = (float)val_12;
        val_37 = (float)val_11 / val_37;
        int val_15 = System.Math.Min(val1:  val_11, val2:  val_12);
        string val_16 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        string val_17 = val_14.ToString();
        int val_18 = this.eventHandler.<progression>k__BackingField.CurrentChestTier;
        if(val_18 <= val_18)
        {
                var val_38 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_38 = val_38 + (val_18 << 2);
        this.currentTierImg.sprite = (0 + (val_18) << 2) + 16;
        UnityEngine.Transform val_19 = this.timerText.transform;
        UnityEngine.Transform val_20 = this.timerText.parent;
        UnityEngine.Transform val_21 = this.timerText.parent;
        UnityEngine.GameObject val_22 = this.timerText.gameObject;
        this.timerText.SetActive(value:  this.timerText >> 5);
        UnityEngine.GameObject val_24 = this.showPassButton.gameObject;
        this.showPassButton.SetActive(value:  this.showPassButton >> 5);
        if((this.eventHandler.<progression>k__BackingField.hasPass) == true)
        {
                this.eventHandler.<progression>k__BackingField.hasPass = 1;
        }
        
        this.activePassGO.SetActive(value:  true);
        object val_26 = this.purchasePassButton.GetComponentInChildren<System.Object>();
        string val_27 = this.eventHandler.GetPlusPackagePrice();
        UnityEngine.GameObject val_28 = this.coinsAnimControl.gameObject;
        this.coinsAnimControl.SetActive(value:  false);
        UnityEngine.GameObject val_29 = this.gemAnimControl.gameObject;
        this.gemAnimControl.SetActive(value:  false);
        UnityEngine.GameObject val_30 = this.goldCurrencyAnimControl.gameObject;
        this.goldCurrencyAnimControl.SetActive(value:  false);
        UnityEngine.GameObject val_31 = this.foodAnimControl.gameObject;
        this.foodAnimControl.SetActive(value:  false);
        UnityEngine.GameObject val_32 = this.petCardControl.gameObject;
        this.petCardControl.SetActive(value:  false);
        System.Collections.IEnumerator val_35 = this.ScrollToTier(tierIndex:  System.Math.Max(val1:  0, val2:  val_14 - 1));
        UnityEngine.Coroutine val_36 = this.StartCoroutine(routine:  -1048415296);
    }
    public void OnRewardClaim(int index, bool isPassReward)
    {
        System.Collections.Generic.List<System.Tuple<Item, System.Decimal>> val_1 = this.eventHandler.ClaimAward(tierIndex:  index, isPass:  isPassReward);
        this.claimedAwards = this.eventHandler;
        this.AnimateClaimedAward();
    }
    public void OnClickLevelButton()
    {
        this.Close();
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public void OnConnectPurchaseClick(bool connected)
    {
        var val_4;
        System.Func<System.Boolean> val_6;
        if(connected != false)
        {
                this.purchasePassButton.interactable = false;
            this.eventHandler.PurchasePlusPassPackage();
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
        val_4 = null;
        val_4 = null;
        val_6 = SeasonPassEventPopup.<>c.<>9__39_0;
        if(val_6 == 0)
        {
                val_6 = null;
            val_6 = new System.Func<System.Boolean>(object:  SeasonPassEventPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3247015552));
            SeasonPassEventPopup.<>c.<>9__39_0 = val_6;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_6;
        SetupInternetRequired(buttonCallbacks:  2129277568);
        this.Close();
    }
    public void OnPurchasePlusPass(bool success)
    {
        var val_4;
        System.Func<System.Boolean> val_6;
        if(success != false)
        {
                this.RefreshUI();
            this.loopScrollRect.RefreshCells();
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
        val_4 = null;
        val_4 = null;
        val_6 = SeasonPassEventPopup.<>c.<>9__40_0;
        if(val_6 == 0)
        {
                val_6 = null;
            val_6 = new System.Func<System.Boolean>(object:  SeasonPassEventPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3247140864));
            SeasonPassEventPopup.<>c.<>9__40_0 = val_6;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_6;
        SetupPurchaseFail(buttonCallbacks:  2129277568);
        this.Close();
    }
    public void Close()
    {
        this.CancelInvoke();
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1047685312, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void AnimateClaimedAward()
    {
        int val_12;
        var val_25;
        float val_26;
        var val_27;
        var val_28;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        UnityEngine.GameObject val_1 = this.coinsAnimControl.gameObject;
        this.coinsAnimControl.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.gemAnimControl.gameObject;
        this.gemAnimControl.SetActive(value:  false);
        UnityEngine.GameObject val_3 = this.goldCurrencyAnimControl.gameObject;
        this.goldCurrencyAnimControl.SetActive(value:  false);
        UnityEngine.GameObject val_4 = this.foodAnimControl.gameObject;
        this.foodAnimControl.SetActive(value:  false);
        UnityEngine.GameObject val_5 = this.petCardControl.gameObject;
        this.petCardControl.SetActive(value:  false);
        if(this.petCardControl != 0)
        {
                if(this.petCardControl == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_25 = 2621443;
            this.claimedAwards.RemoveAt(index:  0);
            if(406886400 <= 4)
        {
                var val_6 = 7786572 + mem[1635332172];
            if(406886400 == 4)
        {
                mem[1635332172] = mem[1635332172] & (this << mem[1635332172]);
            mem[1635332172] = mem[1635332172] & ((R8) >> 7786572);
            mem[1635332172] = -4552956416810571520;
            mem[1635332172] = 590080;
            mem[1635332172] = mem[1635332172] & (this >> R3);
        }
        
            Player val_7 = App.Player;
            val_26 = 2.489418E-24f;
            val_28 = val_28;
            val_27 = val_27;
            decimal val_8 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1047525972, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256, hi = static_value_0028000F, lo = 406887424, mid = 5890});
            Player val_9 = App.Player;
            var val_10 = 0 + 60;
            System.Action val_11 = new System.Action(object:  -1047513920, method:  new IntPtr(3247420160));
            this.AnimateCoins(fromAmount:  new System.Decimal() {mid = val_12}, toAmount:  new System.Decimal() {flags = mem[(0 + 60) + (0)], hi = mem[(0 + 60) + (4)], lo = mem[(0 + 60) + (8)], mid = mem[(0 + 60) + (12)]}, actionOnComplete:  null);
        }
        
        }
        
        var val_25 = FP - 28;
    }
    private void AnimatePetCards(System.Collections.Generic.List<System.Tuple<WADPets.WADPet, int>> petCards, System.Action actionOnComplete)
    {
        var val_4;
        int val_8;
        int val_9;
        int val_10;
        int val_11;
        int val_12;
        int val_13;
        int val_14;
        int val_15;
        var val_16;
        var val_17;
        var val_18;
        UnityEngine.GameObject val_1 = mem[1152921512149448380].gameObject;
        mem[1152921512149448380].SetActive(value:  true);
        mem2[0] = actionOnComplete;
        List.Enumerator<T> val_2 = GetEnumerator();
        label_14:
        if(MoveNext() == false)
        {
            goto label_5;
        }
        
        if(val_4 != 0)
        {
                val_16 = val_4;
            val_17 = mem[val_4 + 8];
            val_17 = val_4 + 8;
            val_18 = val_17;
        }
        else
        {
                val_18 = 0;
            val_16 = 8;
            val_17 = 0;
        }
        
        var val_5 = (1.401298E-45f) - (val_4 + 12);
        decimal val_6 = System.Decimal.op_Implicit(value:  -1047345384);
        decimal val_7 = System.Decimal.op_Implicit(value:  -1047345400);
        mem[1152921512149448380].AddCard(pet:  0, startBalance:  new System.Decimal() {flags = val_10, hi = val_11, lo = val_8, mid = val_9}, endBalance:  new System.Decimal() {flags = val_12, hi = val_13, lo = val_14, mid = val_15});
        goto label_14;
        label_5:
        Dispose();
        mem[1152921512149448380].Play();
    }
    private void AnimateCoins(decimal fromAmount, decimal toAmount, System.Action actionOnComplete)
    {
        int val_2;
        UnityEngine.GameObject val_1 = this.coinsAnimControl.gameObject;
        this.coinsAnimControl.SetActive(value:  true);
        this.coinsAnimControl.OnCompleteCallback = actionOnComplete;
        val_2 = toAmount.mid;
        if(this.coinsAnimControl == 0)
        {
                val_2 = val_2;
        }
        
        this.coinsAnimControl.Play(fromValue:  new System.Decimal() {flags = fromAmount.flags, hi = fromAmount.hi, lo = fromAmount.lo, mid = fromAmount.mid}, toValue:  new System.Decimal() {flags = toAmount.flags, hi = toAmount.hi, lo = toAmount.lo, mid = val_2}, textTickTime:  null, delayBeforeComplete:  null);
    }
    private void AnimateReward(CurrencyCollectAnimationInstantiator animControl, int fromAmount, int toAmount, System.Action actionOnComplete, float delay = 0)
    {
        UnityEngine.GameObject val_2 = animControl.gameObject;
        animControl.SetActive(value:  true);
        animControl.OnCompleteCallback = actionOnComplete;
        System.Collections.IEnumerator val_3 = animControl.StartAnimating(animControl:  animControl, fromAmount:  fromAmount, toAmount:  toAmount, delay:  delay);
        UnityEngine.Coroutine val_4 = animControl.StartCoroutine(routine:  animControl);
    }
    private System.Collections.IEnumerator StartAnimating(CurrencyCollectAnimationInstantiator animControl, int fromAmount, int toAmount, float delay)
    {
        float val_1;
        typeof(SeasonPassEventPopup.<StartAnimating>d__46).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(SeasonPassEventPopup.<StartAnimating>d__46).__il2cppRuntimeField_14 = animControl;
            typeof(SeasonPassEventPopup.<StartAnimating>d__46).__il2cppRuntimeField_18 = fromAmount;
            typeof(SeasonPassEventPopup.<StartAnimating>d__46).__il2cppRuntimeField_1C = toAmount;
        }
        else
        {
                mem[20] = animControl;
            mem[24] = fromAmount;
            mem[28] = toAmount;
        }
        
        typeof(SeasonPassEventPopup.<StartAnimating>d__46).__il2cppRuntimeField_10 = val_1;
    }
    private void UpdateTimerText()
    {
        int val_4;
        var val_16;
        UnityEngine.UI.Text val_17;
        System.DateTime val_1 = GetTimeEnd();
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        System.TimeSpan val_3 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512149966328}, d2:  new System.DateTime());
        double val_6 = val_4.TotalSeconds;
        int val_7 = val_4.Days;
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        int val_8 = val_4.Hours;
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        val_4 = val_4.Minutes;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        int val_10 = val_4.Seconds;
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        string val_11 = System.String.Format(format:  -1536980304, args:  472754880);
        val_16 = "{0}:{1:00}:{2:00}:{3:00}";
        if(this.passWindow.activeSelf != false)
        {
                val_17 = this.passTimerText;
            string val_13 = Localization.Localize(key:  -1046835488, defaultValue:  -1046835584, useSingularKey:  false);
            string val_14 = System.String.Format(format:  1592589744, arg0:  -1046835488, arg1:  -1536980304);
            val_16 = "{0} {1}";
            return;
        }
        
        val_17 = this.timerText;
    }
    private System.Collections.IEnumerator ScrollToTier(int tierIndex)
    {
        typeof(SeasonPassEventPopup.<ScrollToTier>d__48).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(SeasonPassEventPopup.<ScrollToTier>d__48).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        typeof(SeasonPassEventPopup.<ScrollToTier>d__48).__il2cppRuntimeField_14 = tierIndex;
    }
    public SeasonPassEventPopup()
    {
    
    }

}
