using UnityEngine;
public class PiggyBankRaidPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject inProgressGroup;
    private UnityEngine.GameObject fullGroup;
    private UnityEngine.UI.Text bannerText;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.Transform piggyImageTransform;
    private UnityEngine.GameObject piggyImageInProgress;
    private UnityEngine.GameObject piggyImageFull;
    private UnityEngine.GameObject piggyImageOverflow;
    private UnityEngine.UI.Slider progressBar;
    private UnityEngine.UI.Text progressBarText;
    private UnityEngine.GameObject ProgressBarCoinIcon;
    private UnityEngine.UI.Text piggyLevelText;
    private UnityEngine.Transform raidHistoryParent;
    private UnityEngine.UI.Text infoTextFull;
    private UGUINetworkedButton openButtonFull;
    private UnityEngine.UI.Text openButtonFullText;
    private UnityEngine.UI.Button discardButton;
    private UnityEngine.UI.Text discardButtonText;
    private UnityEngine.UI.Text discardButtonTextAmountOnly;
    private GridCoinCollectAnimationInstantiator coinAnimation;
    private PiggyBankRaidHistoryItem raidHistoryItemPrefab;
    private SLC.Social.AvatarConfig avatarConfig;
    private UnityEngine.Vector3 progressBarPositionInProgress;
    private UnityEngine.Vector3 progressBarPositionFull;
    private UnityEngine.Vector3 piggyImagePositionInProgress;
    private UnityEngine.Vector3 piggyImagePositionFull;
    private PiggyBankRaidEventHandler eventHandler;
    
    // Methods
    private void Start()
    {
        System.Action<System.Boolean> val_7;
        System.Action<System.Boolean, System.Decimal> val_8;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1102598928, method:  new IntPtr(3192315696));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1102598928, method:  new IntPtr(3192315696));
        this.discardButton.m_OnClick.AddListener(call:  162246656);
        System.Action<System.Boolean> val_3 = new System.Action<System.Boolean>(object:  -1102598928, method:  new IntPtr(3192333104));
        System.Delegate val_4 = System.Delegate.Combine(a:  this.openButtonFull.OnConnectionClick, b:  7401472);
        val_7 = this.openButtonFull.OnConnectionClick;
        if(val_7 != 0)
        {
                if(null == null)
        {
            goto label_8;
        }
        
        }
        
        val_7 = 0;
        label_8:
        this.openButtonFull.OnConnectionClick = val_7;
        System.Action<System.Boolean, System.Decimal> val_5 = new System.Action<System.Boolean, System.Decimal>(object:  -1102598928, method:  new IntPtr(3192342320));
        System.Delegate val_6 = System.Delegate.Combine(a:  this.eventHandler.OnPurchaseAttempt, b:  7507968);
        val_8 = this.eventHandler.OnPurchaseAttempt;
        if(val_8 != 0)
        {
                if(null == null)
        {
            goto label_12;
        }
        
        }
        
        val_8 = 0;
        label_12:
        this.eventHandler.OnPurchaseAttempt = val_8;
        this.RefreshState();
    }
    private void OnDestroy()
    {
        System.Action<System.Boolean, System.Decimal> val_3;
        System.Action<System.Boolean, System.Decimal> val_1 = new System.Action<System.Boolean, System.Decimal>(object:  -1102445968, method:  new IntPtr(3192342320));
        System.Delegate val_2 = System.Delegate.Remove(source:  this.eventHandler.OnPurchaseAttempt, value:  7507968);
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
    public void PlayAddCoinAnimation(decimal addedAmount)
    {
        int val_10;
        int val_11;
        int val_12;
        int val_13;
        int val_14;
        object val_1 = new System.Object();
        typeof(PiggyBankRaidPopup.<>c__DisplayClass29_0).__il2cppRuntimeField_C = this;
        decimal val_2 = PiggyBankCoins;
        float val_3 = System.Decimal.op_Explicit(value:  new System.Decimal());
        float val_4 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = addedAmount.flags, hi = addedAmount.hi, lo = addedAmount.lo, mid = addedAmount.mid});
        int val_21 = addedAmount.flags;
        val_21 = R0 - val_21;
        typeof(PiggyBankRaidPopup.<>c__DisplayClass29_0).__il2cppRuntimeField_8 = val_21;
        int val_5 = this.eventHandler.PiggyBankLevel;
        decimal val_6 = Item[this.eventHandler.econ.bankMaxCoins];
        float val_7 = System.Decimal.op_Explicit(value:  new System.Decimal());
        typeof(PiggyBankRaidPopup.<>c__DisplayClass29_0).__il2cppRuntimeField_10 = ???;
        decimal val_8 = System.Decimal.op_Explicit(value:  val_7);
        decimal val_9 = System.Decimal.op_Explicit(value:  val_7);
        string val_15 = val_10.GetProgressBarText(currentAmount:  new System.Decimal() {mid = val_10}, bankMaxAmount:  new System.Decimal() {flags = val_11, hi = val_12, lo = val_13, mid = val_14});
        float val_16 = (typeof(PiggyBankRaidPopup.<>c__DisplayClass29_0).__il2cppRuntimeField_8) / (typeof(PiggyBankRaidPopup.<>c__DisplayClass29_0).__il2cppRuntimeField_10);
        float val_22 = typeof(PiggyBankRaidPopup.<>c__DisplayClass29_0).__il2cppRuntimeField_10;
        val_22 = R0 / val_22;
        DG.Tweening.Tweener val_17 = DG.Tweening.ShortcutExtensions46.DOValue(target:  this.progressBar, endValue:  val_22, duration:  null, snapping:  val_22);
        DG.Tweening.Core.DOGetter<System.Single> val_18 = new DG.Tweening.Core.DOGetter<System.Single>(object:  329285632, method:  new IntPtr(3192650288));
        DG.Tweening.Core.DOSetter<System.Single> val_19 = new DG.Tweening.Core.DOSetter<System.Single>(object:  329285632, method:  new IntPtr(3192651312));
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_20 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  val_22, duration:  null);
    }
    private string GetCurrentProgressBarText()
    {
        int val_2;
        decimal val_1 = PiggyBankCoins;
        int val_3 = this.eventHandler.PiggyBankLevel;
        decimal val_4 = Item[this.eventHandler.econ.bankMaxCoins];
        string val_5 = GetProgressBarText(currentAmount:  new System.Decimal() {flags = R8, hi = SB, lo = SL, mid = val_2}, bankMaxAmount:  new System.Decimal());
    }
    private string GetProgressBarText(decimal currentAmount, decimal bankMaxAmount)
    {
        int val_17;
        int val_18;
        int val_19;
        int val_20;
        int val_21;
        var val_22;
        object val_23;
        var val_24;
        int val_25;
        val_17 = currentAmount.flags;
        val_20 = bankMaxAmount.mid;
        val_21 = 1152921504617017344;
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = val_17, hi = currentAmount.hi, lo = currentAmount.lo, mid = currentAmount.mid}, d2:  new System.Decimal() {flags = bankMaxAmount.flags, hi = val_18, lo = val_19, mid = val_20})) == false)
        {
            goto label_3;
        }
        
        GameEcon val_2 = App.getGameEcon;
        string val_3 = val_17.ToString(format:  null);
        GameEcon val_4 = App.getGameEcon;
        string val_5 = bankMaxAmount.flags.ToString(format:  null);
        val_22;
        val_23 = ;
        val_24 = "{0}/{1}";
        goto label_8;
        label_3:
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_17, hi = currentAmount.hi, lo = currentAmount.lo, mid = currentAmount.mid}, d2:  new System.Decimal() {flags = bankMaxAmount.flags, hi = val_18, lo = val_19, mid = val_20})) == false)
        {
            goto label_11;
        }
        
        GameEcon val_8 = App.getGameEcon;
        string val_9 = bankMaxAmount.flags.ToString(format:  null);
        val_20 = val_20;
        val_19 = val_17;
        val_25 = currentAmount.hi;
        val_17 = currentAmount.lo;
        val_21 = currentAmount.mid;
        val_25 = val_25;
        decimal val_10 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1102005240, hi = val_19, lo = val_25, mid = val_17}, d2:  new System.Decimal() {flags = val_21, hi = bankMaxAmount.flags, lo = val_18, mid = val_18});
        GameEcon val_11 = App.getGameEcon;
        string val_12 = ToString(format:  null);
        val_22;
        val_24 = "{0} + {1}";
        val_23 = bankMaxAmount.flags;
        label_8:
        string val_13 = System.String.Format(format:  -1102017232, arg0:  val_23, arg1:  -1102005224);
        return;
        label_11:
        GameEcon val_14 = App.getGameEcon;
        string val_15 = bankMaxAmount.flags.ToString(format:  null);
        string val_16 = System.String.Format(format:  -1225078832, arg0:  -1102005204);
    }
    private string GetPurchasePriceString(decimal price)
    {
        PurchaseModel val_1 = this.eventHandler.GetPiggyPurchaseModel();
        if(this.eventHandler != 0)
        {
                return this.eventHandler.LocalPrice;
        }
        
        return this.eventHandler.LocalPrice;
    }
    private void RefreshState()
    {
        if(this.eventHandler.progressData.isMaxPiggyPurchased != false)
        {
                UnityEngine.GameObject val_1 = this.gameObject;
            SLCWindow.CloseWindow(window:  -1101748656, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
            return;
        }
        
        if(this.eventHandler.IsPiggyBankFull() != false)
        {
                this.InitializeFull();
            return;
        }
        
        this.InitializeInProgress();
    }
    private void InitializeInProgress()
    {
        int val_4;
        int val_7;
        int val_14;
        int val_15;
        this.inProgressGroup.SetActive(value:  true);
        this.fullGroup.SetActive(value:  false);
        UnityEngine.Transform val_1 = this.progressBar.transform;
        this.progressBar.localPosition = new UnityEngine.Vector3() {x = mem[this.progressBarPositionInProgress + (0)], y = mem[this.progressBarPositionInProgress + (4)], z = mem[this.progressBarPositionInProgress + (8)]};
        this.piggyImageTransform.localPosition = new UnityEngine.Vector3() {x = mem[this.piggyImagePositionInProgress + (0)], y = mem[this.piggyImagePositionInProgress + (4)], z = mem[this.piggyImagePositionInProgress + (8)]};
        this.piggyImageInProgress.SetActive(value:  true);
        this.piggyImageFull.SetActive(value:  false);
        this.piggyImageOverflow.SetActive(value:  false);
        string val_2 = Localization.Localize(key:  -1128214688, defaultValue:  -1128214784, useSingularKey:  false);
        decimal val_3 = PiggyBankCoins;
        int val_5 = this.eventHandler.PiggyBankLevel;
        decimal val_6 = Item[this.eventHandler.econ.bankMaxCoins];
        val_15 = ???;
        val_14 = ???;
        decimal val_8 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = -1101562500, hi = R7, lo = R8, mid = SB}, d2:  new System.Decimal() {flags = val_4, hi = val_14, lo = val_15});
        float val_9 = System.Decimal.op_Explicit(value:  new System.Decimal());
        string val_10 = val_7.GetProgressBarText(currentAmount:  new System.Decimal() {flags = R7, hi = R8, lo = SB, mid = val_4}, bankMaxAmount:  new System.Decimal() {flags = ???, hi = ???, lo = ???, mid = val_7});
        this.ProgressBarCoinIcon.SetActive(value:  false);
        string val_11 = Localization.Localize(key:  -1101578624, defaultValue:  -1101578736, useSingularKey:  false);
        int val_12 = this.eventHandler.PiggyBankLevel;
        string val_13 = System.String.Format(format:  -1101578624, arg0:  13152256, arg1:  13152256);
        this.GenerateRaidHistory();
    }
    private void InitializeFull()
    {
        var val_24;
        var val_25;
        decimal val_27;
        var val_28;
        this.inProgressGroup.SetActive(value:  false);
        this.fullGroup.SetActive(value:  true);
        UnityEngine.Transform val_1 = this.progressBar.transform;
        this.progressBar.localPosition = new UnityEngine.Vector3() {x = this.progressBarPositionFull, y = R7, z = this.progressBar};
        this.piggyImageTransform.localPosition = new UnityEngine.Vector3() {x = mem[this.piggyImagePositionFull + (0)], y = mem[this.piggyImagePositionFull + (4)], z = mem[this.piggyImagePositionFull + (8)]};
        this.piggyImageInProgress.SetActive(value:  false);
        string val_2 = Localization.Localize(key:  -1101359920, defaultValue:  -1101360016, useSingularKey:  false);
        string val_3 = this.GetCurrentProgressBarText();
        string val_4 = Localization.Localize(key:  -1101351520, defaultValue:  -1101351616, useSingularKey:  false);
        int val_5 = this.eventHandler.PiggyBankLevel;
        decimal val_6 = Item[this.eventHandler.econ.bankPriceTier];
        string val_7 = this.GetPurchasePriceString(price:  new System.Decimal() {flags = val_6.hi, hi = val_6.lo, lo = val_6.mid});
        string val_8 = System.String.Format(format:  -1826949520, arg0:  -1101351520, arg1:  -1101265136);
        this.ProgressBarCoinIcon.SetActive(value:  true);
        decimal val_9 = GetPiggyBankOverflowAmount();
        val_25 = null;
        val_25 = null;
        val_27 = System.Decimal.Zero;
        bool val_10 = System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_27, hi = System.Decimal.Powers10.__il2cppRuntimeField_8, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10});
        if(val_10 != false)
        {
                decimal val_11 = GetPiggyBankOverflowAmount();
            val_24 = 1152921504765685760;
            if(this.discardButtonText != 0)
        {
                string val_13 = Localization.Localize(key:  -1101318544, defaultValue:  -1101318640, useSingularKey:  false);
            val_28 = "discard_upper";
            GameEcon val_14 = App.getGameEcon;
            string val_15 = ToString(format:  null);
            string val_16 = System.String.Format(format:  1592589744, arg0:  -1101318544, arg1:  -1101277192);
        }
        
            val_27 = this.discardButtonTextAmountOnly;
            if(val_27 != 0)
        {
                val_27 = this.discardButtonTextAmountOnly;
            GameEcon val_18 = App.getGameEcon;
            string val_19 = ToString(format:  null);
        }
        
        }
        
        this.piggyImageFull.SetActive(value:  val_10 ^ 1);
        this.piggyImageOverflow.SetActive(value:  val_10);
        UnityEngine.GameObject val_21 = this.discardButton.gameObject;
        this.discardButton.SetActive(value:  val_10);
        if(val_10 == true)
        {
                "Open your piggy bank to claim the coins before you get raided!" = "Piggy Bank is too full! Purchase now keep the overflowing coins.";
        }
        
        if(val_10 == true)
        {
                "piggy_raid_full_body" = "piggy_raid_overflow_body";
        }
        
        string val_22 = Localization.Localize(key:  -1101293472, defaultValue:  -1101293872, useSingularKey:  false);
        if(this.infoTextFull != 0)
        {
                return;
        }
    
    }
    private void GenerateRaidHistory()
    {
        PiggyBankRaidPopup val_3;
        var val_4;
        val_3 = this;
        var val_6 = 25816972;
        val_6 = 9816208 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        if(0 < 1)
        {
                return;
        }
        
        do
        {
            var val_1 = 4 - 4;
            object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  this.raidHistoryItemPrefab, parent:  this.raidHistoryParent);
            if(0 <= val_1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(0 <= val_1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(0 <= val_1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            UnityEngine.Sprite val_3 = this.avatarConfig.GetAvatarSpriteByID(id:  406887424);
            this.raidHistoryItemPrefab.InitialiseMessage(senderName:  406886400, stoleAmount:  new System.Decimal() {flags = 5890, hi = 406888448, lo = 5890, mid = static_value_00280023}, avatarSprite:  this.avatarConfig);
            var val_4 = 4 + 1;
            val_3 = val_3;
        }
        while((4 - 3) < 0);
    
    }
    private void OnOpenButtonClicked(bool connected)
    {
        var val_1;
        var val_1 = 25816352;
        val_1 = 9816828 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        PiggyBankRaidEventHandler.<Instance>k__BackingField.DoPurchasePiggyBank();
    }
    private void OnCloseButtonClicked()
    {
        var val_2;
        var val_2 = 25816124;
        val_2 = 9817056 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        PiggyBankRaidEventHandler.<Instance>k__BackingField.DiscardOverflowAmount();
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1100805232, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnPurchaseAttempt(bool isSuccess, decimal amount)
    {
        int val_5;
        int val_6;
        int val_7;
        int val_8;
        int val_9;
        val_6 = amount.hi;
        val_7 = 35633002;
        if(isSuccess == false)
        {
                return;
        }
        
        System.Action val_1 = new System.Action(object:  -1100684016, method:  new IntPtr(3194254160));
        this.coinAnimation.OnCompleteCallback = null;
        Player val_2 = App.Player;
        var val_6 = 0;
        val_8 = amount.mid;
        val_9 = amount.lo;
        val_6 = val_6 + 64;
        val_9 = amount.lo;
        val_8 = amount.mid;
        decimal val_3 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1100696068, hi = 52, lo = mem[(0 + 64) + (0)], mid = mem[(0 + 64) + (4)]}, d2:  new System.Decimal() {flags = mem[(0 + 64) + (8)], hi = amount.flags, lo = val_6, mid = val_9});
        Player val_4 = App.Player;
        this.coinAnimation.Play(fromValue:  new System.Decimal() {mid = val_5}, toValue:  new System.Decimal() {hi = val_7, mid = val_6}, textTickTime:  null, delayBeforeComplete:  null);
    }
    public PiggyBankRaidPopup()
    {
        var val_1;
        var val_1 = 25815416;
        val_1 = 9817764 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        this.eventHandler = PiggyBankRaidEventHandler.<Instance>k__BackingField;
    }

}
