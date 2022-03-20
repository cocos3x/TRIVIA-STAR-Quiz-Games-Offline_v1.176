using UnityEngine;
public class KeyToRichesPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text keyBalance;
    private KeyToRichesChest treasureChestPrefab;
    private UnityEngine.Transform treasureChestParent;
    private UnityEngine.Transform keyPos;
    private UnityEngine.GameObject[] defaultModeObjects;
    private UnityEngine.UI.Text keyDesc;
    private UGUINetworkedButton purchaseButton;
    private UnityEngine.UI.Text keysAmount;
    private UnityEngine.UI.Text keysPrice;
    private UnityEngine.UI.Text timerText;
    private UnityEngine.GameObject[] rewardModeObjects;
    private GridCoinCollectAnimationInstantiator coinsAnimControl;
    private GoldenCurrencyCollectAnimationInstantiator goldenCurrencyAnimControl;
    private UnityEngine.GameObject prompt;
    private UGUINetworkedButton promptPurchaseButton;
    private UnityEngine.UI.Text promptKeysAmount;
    private UnityEngine.UI.Text promptKeysPrice;
    private UnityEngine.UI.Button promptCloseButton;
    private UnityEngine.GameObject messagePopup;
    private UnityEngine.UI.Text title;
    private UnityEngine.UI.Text message;
    private UnityEngine.UI.Button okayButton;
    private float delayBeforeReveal;
    private float delayAfterReveal;
    private float delayBeforePrompt;
    private UnityEngine.Sprite coin;
    private UnityEngine.Sprite apple;
    private UnityEngine.Sprite alph_common;
    private UnityEngine.Sprite alph_uncommon;
    private UnityEngine.Sprite alph_rare;
    private UnityEngine.Sprite alph_superRare;
    private KeyToRichesPopup.State state;
    private KeyToRichesChest[] chests;
    private System.Collections.Generic.List<KeyToRichesEventHandler.Reward> currentRewards;
    private System.Collections.Generic.HashSet<int> openedChests;
    private int keysToPurchase;
    
    // Properties
    public string RewardsContent { get; }
    
    // Methods
    public string get_RewardsContent()
    {
        if(this.currentRewards == 0)
        {
                return;
        }
        
        return Newtonsoft.Json.JsonConvert.SerializeObject(value:  this.currentRewards);
    }
    private void OnPurchase(bool connected)
    {
        var val_3;
        if(connected != false)
        {
                var val_3 = 24082281;
            val_3 = 11543780 + val_3;
            if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
            val_3 = null;
            val_3 = null;
            var val_4 = 24085682;
            val_4 = 11543868 + val_4;
            PurchaseProxy.currentPurchasePoint = 95;
            if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
            KeyToRichesEventHandler._Instance.PurchaseKeys(keysToPurchase:  this.keysToPurchase);
            return;
        }
        
        string val_1 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_2 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        this.ShowMessage(titleText:  -1725760224, messageText:  -1725759984);
    }
    private void OnPromptPurchase(bool connected)
    {
        var val_3;
        if(connected != false)
        {
                var val_3 = 24081557;
            val_3 = 11544504 + val_3;
            if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
            val_3 = null;
            val_3 = null;
            var val_4 = 24084958;
            val_4 = 11544592 + val_4;
            PurchaseProxy.currentPurchasePoint = 96;
            if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
            KeyToRichesEventHandler._Instance.PurchaseKeys(keysToPurchase:  this.keysToPurchase);
            return;
        }
        
        string val_1 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_2 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        this.ShowMessage(titleText:  -1725760224, messageText:  -1725759984);
    }
    private void OnPromptClose()
    {
        this.prompt.SetActive(value:  false);
        System.Collections.IEnumerator val_1 = this.CloseRewardSequence();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -1349557664);
    }
    private void OnPurchaseCompleted(PurchaseModel purchase)
    {
        var val_3;
        decimal val_1 = Keys;
        val_3 = null;
        val_3 = null;
        if((System.Decimal.op_Equality(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == true)
        {
                return;
        }
        
        if(this.state != 0)
        {
                this.prompt.SetActive(value:  false);
            return;
        }
        
        this.state = 1;
        this.SetupReward(isPurchase:  true);
    }
    private void OnPurchaseFailure(PurchaseModel purchase)
    {
        var val_5;
        decimal val_1 = Keys;
        val_5 = null;
        val_5 = null;
        if((System.Decimal.op_Equality(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero, lo = System.Decimal.Powers10.__il2cppRuntimeField_C, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) == true)
        {
                return;
        }
        
        string val_3 = Localization.Localize(key:  -1349324784, defaultValue:  -1349324896, useSingularKey:  false);
        string val_4 = Localization.Localize(key:  -1349324672, defaultValue:  -1349324544, useSingularKey:  false);
        this.ShowMessage(titleText:  -1349324784, messageText:  -1349324672);
    }
    private void OnClickMessage()
    {
        this.messagePopup.SetActive(value:  false);
    }
    private void Awake()
    {
        var val_12;
        System.Delegate val_13;
        var val_14;
        System.Action<twelvegigs.storage.JsonDictionary> val_15;
        System.Delegate val_16;
        System.Action val_17;
        val_12 = null;
        val_12 = null;
        System.Action<twelvegigs.storage.JsonDictionary> val_1 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1349032320, method:  new IntPtr(2945879232));
        val_13 = PurchasesHandler.OnPurchaseCompleted;
        System.Delegate val_2 = System.Delegate.Combine(a:  val_13, b:  7401472);
        val_14 = null;
        val_15 = null;
        if(val_13 == 0)
        {
            goto label_3;
        }
        
        if(null == val_15)
        {
            goto label_4;
        }
        
        val_15 = null;
        val_14 = 1152921504898486364;
        label_3:
        val_13 = 0;
        label_4:
        PurchasesHandler.OnPurchaseCompleted = val_13;
        val_15 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1349032320, method:  new IntPtr(2945880256));
        val_16 = PurchasesHandler.OnPurchaseFailure;
        System.Delegate val_4 = System.Delegate.Combine(a:  val_16, b:  7401472);
        if(val_16 != 0)
        {
                if(null == null)
        {
            goto label_6;
        }
        
        }
        
        val_16 = 0;
        label_6:
        var val_12 = 24082550;
        PurchasesHandler.OnPurchaseFailure = val_16;
        val_12 = 11547000 + val_12;
        if(val_12 == 0)
        {
                mem2[0] = 1;
        }
        
        System.Action val_5 = new System.Action(object:  -1349032320, method:  new IntPtr(2945881280));
        System.Delegate val_6 = System.Delegate.Combine(a:  7454720, b:  7454720);
        val_17 = KeyToRichesEventHandler._Instance.OnKeyBalanceChanged;
        if(val_17 != 0)
        {
                if(null == null)
        {
            goto label_11;
        }
        
        }
        
        val_17 = 0;
        label_11:
        KeyToRichesEventHandler._Instance.OnKeyBalanceChanged = val_17;
        NotificationCenter val_7 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1349032320, name:  -1352033200);
        System.Action<System.Boolean> val_8 = new System.Action<System.Boolean>(object:  -1349032320, method:  new IntPtr(2945886400));
        this.purchaseButton.OnConnectionClick = null;
        System.Action<System.Boolean> val_9 = new System.Action<System.Boolean>(object:  -1349032320, method:  new IntPtr(2945891520));
        this.promptPurchaseButton.OnConnectionClick = null;
        UnityEngine.Events.UnityAction val_10 = new UnityEngine.Events.UnityAction(object:  -1349032320, method:  new IntPtr(2945900736));
        this.promptCloseButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_11 = new UnityEngine.Events.UnityAction(object:  -1349032320, method:  new IntPtr(2945909952));
        this.okayButton.m_OnClick.AddListener(call:  162246656);
        this.InitObjects();
    }
    private void Start()
    {
        if((KeyToRichesEventHandler._Instance == 0) && (KeyToRichesEventHandler._Instance != 0))
        {
                this.SetupUI();
            return;
        }
        
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1348895744, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnDestroy()
    {
        var val_8;
        System.Delegate val_9;
        var val_10;
        System.Action<twelvegigs.storage.JsonDictionary> val_11;
        System.Delegate val_12;
        System.Action val_13;
        val_8 = null;
        val_8 = null;
        System.Action<twelvegigs.storage.JsonDictionary> val_1 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1348783744, method:  new IntPtr(2945879232));
        val_9 = PurchasesHandler.OnPurchaseCompleted;
        System.Delegate val_2 = System.Delegate.Remove(source:  val_9, value:  7401472);
        val_10 = null;
        val_11 = null;
        if(val_9 == 0)
        {
            goto label_3;
        }
        
        if(null == val_11)
        {
            goto label_4;
        }
        
        val_11 = null;
        val_10 = 1152921504898486364;
        label_3:
        val_9 = 0;
        label_4:
        PurchasesHandler.OnPurchaseCompleted = val_9;
        val_11 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1348783744, method:  new IntPtr(2945880256));
        val_12 = PurchasesHandler.OnPurchaseFailure;
        System.Delegate val_4 = System.Delegate.Remove(source:  val_12, value:  7401472);
        if(val_12 != 0)
        {
                if(null == null)
        {
            goto label_6;
        }
        
        }
        
        val_12 = 0;
        label_6:
        var val_8 = 24080306;
        PurchasesHandler.OnPurchaseFailure = val_12;
        val_8 = 11549244 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        System.Action val_5 = new System.Action(object:  -1348783744, method:  new IntPtr(2945881280));
        System.Delegate val_6 = System.Delegate.Remove(source:  7454720, value:  7454720);
        val_13 = KeyToRichesEventHandler._Instance.OnKeyBalanceChanged;
        if(val_13 != 0)
        {
                if(null == null)
        {
            goto label_11;
        }
        
        }
        
        val_13 = 0;
        label_11:
        KeyToRichesEventHandler._Instance.OnKeyBalanceChanged = val_13;
        NotificationCenter val_7 = NotificationCenter.DefaultCenter;
        0.RemoveObserver(observer:  -1348783744, name:  -1352033200);
    }
    public void OnCollect(int index)
    {
        bool val_1 = this.openedChests.Add(item:  index);
        if(KeyToRichesEventHandler.EventProgress.__il2cppRuntimeField_namespaze != 0)
        {
                return;
        }
        
        if((R4 + 148 + 16) <= 8)
        {
                R4.SetupPrompt();
            return;
        }
        
        System.Collections.IEnumerator val_2 = R4.CloseRewardSequence();
        UnityEngine.Coroutine val_3 = R4.StartCoroutine(routine:  R4);
    }
    public void AnimateReward(int index)
    {
        int val_5;
        int val_14;
        int val_15;
        int val_16;
        int val_17;
        System.Collections.Generic.List<Reward> val_21;
        int val_22;
        GridCoinCollectAnimationInstantiator val_23;
        var val_24;
        var val_25;
        var val_26;
        val_21 = this.currentRewards;
        if(true <= index)
        {
                var val_21 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_21 = val_21 + (index << 2);
        val_22 = mem[(0 + (index) << 2) + 16];
        val_22 = (0 + (index) << 2) + 16;
        if(val_22 == 0)
        {
                return;
        }
        
        if(((0 + (index) << 2) + 16 + 8) != 1)
        {
                if(((0 + (index) << 2) + 16 + 8) != 0)
        {
                return;
        }
        
            val_23 = this.coinsAnimControl;
            Player val_1 = App.Player;
            decimal val_2 = System.Decimal.op_Implicit(value:  -1348506260);
            decimal val_3 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -1348506276, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
            Player val_4 = App.Player;
            val_23.Play(fromValue:  new System.Decimal() {mid = val_5}, toValue:  new System.Decimal() {hi = val_21, lo = val_22}, textTickTime:  null, delayBeforeComplete:  null);
            NotificationCenter val_6 = NotificationCenter.DefaultCenter;
            val_24 = 0;
            twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_25 = public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance();
            val_26 = "CoinsStatViewUpdate";
        }
        else
        {
                UnityEngine.Transform val_8 = this.goldenCurrencyAnimControl.transform;
            UnityEngine.Transform val_9 = this.chests[index].transform;
            UnityEngine.Vector3 val_10 = position;
            this.goldenCurrencyAnimControl.position = new UnityEngine.Vector3();
            Player val_11 = App.Player;
            val_23 = mem[(0 + (index) << 2) + 16 + 12];
            val_23 = (0 + (index) << 2) + 16 + 12;
            val_22 = 4;
            Player val_12 = App.Player;
            val_21 = 0;
            decimal val_13 = System.Decimal.op_Implicit(value:  -1348506260);
            this.goldenCurrencyAnimControl.Play(fromValue:  val_22 - val_23, toValue:  new System.Decimal() {flags = val_16, hi = val_17, lo = val_15, mid = val_14}, textTickTime:  val_10.x, delayBeforeComplete:  val_10.y, destinationObject:  3212836864, originObject:  3212836864);
            NotificationCenter val_19 = NotificationCenter.DefaultCenter;
            val_24 = 0;
            twelvegigs.Autopilot.AutopilotManager val_20 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_25 = public static WordGameEventsController MonoSingleton<WordGameEventsController>::get_Instance();
            val_26 = "OnStarsUpdated";
        }
        
        val_24.PostNotification(aSender:  -2101040096, aName:  -2092882624);
    }
    public void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1348324864, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void UpdateTimerText()
    {
        var val_5;
        var val_14 = 24079418;
        val_14 = 11550132 + val_14;
        if(val_14 == 0)
        {
                mem2[0] = 1;
        }
        
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511848560744}, d2:  new System.DateTime() {dateData = KeyToRichesEventHandler._Instance + 8 + 32});
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
        if(this.timerText >= 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_13 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1348208768, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void InitObjects()
    {
        this.chests = null;
        var val_4 = 0;
        do
        {
            UnityEngine.GameObject val_1 = this.treasureChestPrefab.gameObject;
            object val_2 = UnityEngine.Object.Instantiate<System.Object>(original:  this.treasureChestPrefab, parent:  this.treasureChestParent);
            object val_3 = this.treasureChestPrefab.GetComponent<System.Object>();
            val_4 = val_4 + 1;
            this.chests[val_4] = this.treasureChestPrefab;
        }
        while(val_4 != 9);
    
    }
    private void SetupUI()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -1347880016);
        System.Action val_3 = new System.Action(object:  -1347880016, method:  new IntPtr(2947057856));
        this.keyPos = null;
        this.UpdateBalance();
        string val_4 = Localization.Localize(key:  -1347904128, defaultValue:  -1347904320, useSingularKey:  false);
        if(KeyToRichesEventHandler._Instance.econ == 0)
        {
                KeyToRichesEventHandler.Econ.__il2cppRuntimeField_name = 0;
        }
        
        string val_5 = System.String.Format(format:  -1347904128, arg0:  13152256);
        if(KeyToRichesEventHandler.EventProgress.__il2cppRuntimeField_namespaze > 2)
        {
                0 = 1;
        }
        
        this.state = 1;
        this.SetupDefault();
    }
    private void SetupDefault()
    {
        var val_3;
        var val_4;
        val_3 = 0;
        goto label_1;
        label_8:
        if((UnityEngine.Object.op_Implicit(exists:  -1692633120)) != false)
        {
                1152921507209181152.SetActive(value:  true);
        }
        
        val_3 = 1;
        label_1:
        if(val_3 < 1152921507209181152)
        {
            goto label_8;
        }
        
        val_4 = 0;
        goto label_9;
        label_16:
        if((UnityEngine.Object.op_Implicit(exists:  -1692633120)) != false)
        {
                1152921507209181152.SetActive(value:  false);
        }
        
        val_4 = 1;
        label_9:
        if(val_4 < 1152921507209181152)
        {
            goto label_16;
        }
        
        var val_4 = 0;
        do
        {
            this.chests[val_4].SetupDefault();
            val_4 = val_4 + 1;
        }
        while(val_4 != 9);
        
        this.SetupPurchase();
    }
    private void SetupReward(bool isPurchase = False)
    {
        var val_5;
        var val_6;
        UnityEngine.Sprite val_7;
        UnityEngine.Sprite val_8;
        this.openedChests.Clear();
        if(this.currentRewards == 0)
        {
                System.Collections.Generic.List<Reward> val_1 = KeyToRichesEventHandler._Instance.GenerateRewards(isPurchase:  isPurchase);
            this.currentRewards = KeyToRichesEventHandler._Instance;
        }
        
        val_5 = 0;
        goto label_5;
        label_12:
        if((UnityEngine.Object.op_Implicit(exists:  -1692633120)) != false)
        {
                1152921507209181152.SetActive(value:  false);
        }
        
        val_5 = 1;
        label_5:
        if(val_5 < 1152921507209181152)
        {
            goto label_12;
        }
        
        val_6 = 0;
        goto label_13;
        label_20:
        if((UnityEngine.Object.op_Implicit(exists:  -1692633120)) != false)
        {
                1152921507209181152.SetActive(value:  true);
        }
        
        val_6 = 1;
        label_13:
        if(val_6 < 1152921507209181152)
        {
            goto label_20;
        }
        
        var val_9 = 0;
        label_38:
        if(this.chests[val_9] <= val_9)
        {
                var val_6 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_6 = val_6 + 0;
        if(((0 + 0) + 16) <= val_9)
        {
                var val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_7 = val_7 + 0;
        if(((0 + 0) + 16 + 8) > 5)
        {
            goto label_28;
        }
        
        var val_4 = 11546052 + (11546052 + ((0 + 0) + 16 + 8) << 2);
        if(((0 + 0) + 16 + 8) == 5)
        {
                this.coin = this.coin & (((0 + 0) + 16) >> 32);
            this.coin = this.coin & (1152921504765685760 << this.coin);
            this.coin = this.coin & 36243216;
            this.coin = this.coin & (this.coin >> this.coin);
            this.coin = this.coin & (1152921504765685760 >> this.coin);
            this.coin = this.coin & (this.coin >> 32);
        }
        
        val_7 = this.apple;
        goto label_33;
        label_28:
        val_8 = 0;
        goto label_30;
        label_33:
        val_8 = mem[this.alph_superRare];
        val_8 = ;
        label_30:
        if( <= val_9)
        {
                var val_8 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_8 = val_8 + 0;
        this.chests[val_9].SetupReward(keyToRichesPopup:  -1347283280, i:  0, reward:  (0 + 0) + 16, rewardSprite:  val_8, rewardAmount:  (0 + 0) + 16 + 12, keyPos:  this.keyPos);
        val_9 = val_9 + 1;
        if(val_9 != 9)
        {
            goto label_38;
        }
    
    }
    private void SetupPurchase()
    {
        var val_5 = 24077810;
        val_5 = 11551740 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        this.keysToPurchase = (3 - KeyToRichesEventHandler.EventProgress.__il2cppRuntimeField_namespaze);
        UnityEngine.Debug.LogError(message:  -1347056016);
        UnityEngine.GameObject val_2 = this.purchaseButton.gameObject;
        this.purchaseButton.SetActive(value:  false);
    }
    private void SetupPrompt()
    {
        int val_2 = UnityEngine.Mathf.Min(a:  9 - this.openedChests, b:  3);
        this.keysToPurchase = val_2;
        val_2 = val_2 - 1;
        if(val_2 >= 3)
        {
                UnityEngine.Debug.LogError(message:  -1347056016);
            return;
        }
        
        string val_3 = this.keysToPurchase.ToString();
        string val_4 = KeyToRichesEventHandler._Instance.GetPackagePriceByKeyCount(keysToPurchase:  this.keysToPurchase);
        System.Collections.IEnumerator val_5 = this.OpenPromptSequence();
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  -1346882976);
    }
    private void ShowMessage(string titleText, string messageText)
    {
        GameEcon val_1 = App.getGameEcon;
        string val_2 = 0.titleFormat;
        string val_3 = System.String.Format(format:  null, arg0:  titleText);
        this.messagePopup.SetActive(value:  true);
    }
    private System.Collections.IEnumerator OpenPromptSequence()
    {
        object val_1 = new System.Object();
        typeof(KeyToRichesPopup.<OpenPromptSequence>d__59).__il2cppRuntimeField_8 = 0;
        typeof(KeyToRichesPopup.<OpenPromptSequence>d__59).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator CloseRewardSequence()
    {
        object val_1 = new System.Object();
        typeof(KeyToRichesPopup.<CloseRewardSequence>d__60).__il2cppRuntimeField_8 = 0;
        typeof(KeyToRichesPopup.<CloseRewardSequence>d__60).__il2cppRuntimeField_10 = this;
    }
    private UnityEngine.Sprite GetSpriteByType(KeyToRichesEventHandler.RewardType rewardType)
    {
        var val_2;
        if(rewardType > 5)
        {
                this = 0;
            return;
        }
        
        var val_1 = 11552204 + (11552204 + (rewardType) << 2);
        if(rewardType == 5)
        {
                this = this & ((R8) << this);
            this = this & (this >> 32);
            this = this & ((R8) >> 32);
            this = this & (this >> this);
            this = this & ((R8) >> ((((this & (R8) << this) & ((this & (R8) << this)) >> 32) & (R8) >> 32) & ((((this & (R8) << this) & ((this & (R8) << this)) >> 32) & (R8) >> 32)) >> (((this & (R8) << this) & ((this & (R8) << this)) );
            this = this & (this >> 32);
        }
        
        val_2 = this + 112;
    }
    private void UpdateBalance()
    {
        string val_1 = KeyToRichesEventHandler.EventProgress.__il2cppRuntimeField_namespaze.ToString();
        if(this.keyBalance != 0)
        {
                return;
        }
    
    }
    private void OnToggleKTRChestContent(Notification notification)
    {
        System.Collections.Hashtable val_1;
        var val_2;
        val_1 = notification.data;
        val_2 = 0;
        if(val_1 != 0)
        {
                val_1 = null;
            notification.data.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if(null != 0)
        {
                val_2 = 1;
        }
        
        }
        
        this.ToggleChestContent(show:  true);
    }
    private void ToggleChestContent(bool show)
    {
        if(this.chests == null)
        {
                return;
        }
        
        if(this < 1)
        {
                return;
        }
        
        var val_1 = 0;
        do
        {
            1152921507389145232.ToggleChestContent(show:  show);
            val_1 = val_1 + 1;
        }
        while(val_1 < 1152921507389145232);
    
    }
    public KeyToRichesPopup()
    {
        this.delayBeforeReveal = 3f;
        this.delayAfterReveal = 3f;
        this.delayBeforePrompt = 3f;
        System.Collections.Generic.HashSet<System.Int32> val_1 = new System.Collections.Generic.HashSet<System.Int32>();
        this.openedChests = null;
    }

}
