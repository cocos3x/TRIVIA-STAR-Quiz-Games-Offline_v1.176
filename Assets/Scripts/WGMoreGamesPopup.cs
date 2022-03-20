using UnityEngine;
public class WGMoreGamesPopup : FrameSkipper
{
    // Fields
    private UnityEngine.UI.Text text_description;
    private UnityEngine.UI.Text text_current_bonus;
    private UnityEngine.UI.Button collectButton;
    private UnityEngine.UI.Button button_close;
    private UnityEngine.GameObject object_bonus_reward_box;
    private UnityEngine.UI.Text text_countdown_timer;
    private UnityEngine.GameObject object_collect_text;
    private CurrencyCollectAnimationInstantiator coinsAnim;
    private UnityEngine.UI.ScrollRect scrollRect;
    private UnityEngine.Transform more_games_items_parent;
    private WGMoreGamesItem prefab_more_games_item;
    private System.Collections.Generic.List<WGMoreGamesItem> moreGamesItems;
    private decimal curr_reward;
    
    // Methods
    private void Start()
    {
        var val_5;
        System.Delegate val_6;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  24004976, method:  new IntPtr(23969712));
        this.button_close.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  24004976, method:  new IntPtr(23978928));
        this.collectButton.m_OnClick.AddListener(call:  162246656);
        val_5 = null;
        val_5 = null;
        System.Action val_3 = new System.Action(object:  24004976, method:  new IntPtr(23979952));
        val_6 = WGMoreGamesManager.RefreshUI;
        System.Delegate val_4 = System.Delegate.Combine(a:  val_6, b:  7454720);
        if(val_6 != 0)
        {
                if(null == null)
        {
            goto label_8;
        }
        
        }
        
        val_6 = 0;
        label_8:
        WGMoreGamesManager.RefreshUI = val_6;
    }
    private void OnEnable()
    {
        this.InstantiateMoreGamesItems();
        this.UpdateUI();
    }
    private void InstantiateMoreGamesItems()
    {
        GameApp[] val_1 = twelvegigs.plugins.InstalledAppsPlugin.PackagesToCheck;
        var val_2 = 0 - 0;
        if(val_2 >= 1)
        {
                do
        {
            object val_3 = UnityEngine.Object.Instantiate<System.Object>(original:  this.prefab_more_games_item, parent:  this.more_games_items_parent);
            this.moreGamesItems.Add(item:  this.prefab_more_games_item);
            val_2 = val_2 - 1;
        }
        while(this.moreGamesItems != 0);
        
        }
        
        System.Collections.IEnumerator val_4 = this.ScrollToTop();
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  24263792);
    }
    private System.Collections.IEnumerator ScrollToTop()
    {
        object val_1 = new System.Object();
        typeof(WGMoreGamesPopup.<ScrollToTop>d__16).__il2cppRuntimeField_8 = 0;
        typeof(WGMoreGamesPopup.<ScrollToTop>d__16).__il2cppRuntimeField_10 = this;
    }
    private void UpdateUI()
    {
        var val_22;
        float val_23;
        var val_24;
        var val_26;
        System.Collections.Generic.List<WGMoreGamesItem> val_27;
        var val_28;
        var val_29;
        var val_30;
        val_22 = this;
        val_23 = 1152921504980062208;
        var val_24 = 27088294;
        val_24 = 8539892 + val_24;
        if(val_24 == 0)
        {
                mem2[0] = 1;
        }
        
        val_24 = null;
        val_24 = null;
        decimal val_1 = System.Decimal.op_Implicit(value:  24533256);
        bool val_2 = System.Decimal.op_GreaterThan(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = System.Decimal.Zero});
        this.object_bonus_reward_box.SetActive(value:  val_2);
        bool val_25 = WGMoreGamesManager.CanCollect();
        this.collectButton.interactable = val_25;
        this.object_collect_text.SetActive(value:  val_25);
        UnityEngine.GameObject val_4 = this.text_countdown_timer.gameObject;
        this.text_countdown_timer.SetActive(value:  val_25 ^ 1);
        System.DateTime val_6 = WGMoreGamesManager.NextMoreGamesCollectTime;
        System.DateTime val_7 = DateTimeCheat.UtcNow;
        System.TimeSpan val_8 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513221314800}, d2:  new System.DateTime());
        string val_11 = val_8._ticks.FormatTimeRemaining(timeSpan:  new System.TimeSpan());
        UnityEngine.GameObject val_12 = this.button_close.gameObject;
        val_25 = (val_2 & val_25) ^ 1;
        this.button_close.SetActive(value:  val_25);
        GameEcon val_14 = App.getGameEcon;
        string val_15 = this.curr_reward.ToString(format:  null);
        string val_16 = Localization.Localize(key:  1098586544, defaultValue:  24512944, useSingularKey:  false);
        var val_26 = 27090009;
        val_26 = 8540712 + val_26;
        if(val_26 == 0)
        {
                mem2[0] = 1;
        }
        
        val_26 = null;
        val_26 = null;
        GameEcon val_17 = App.getGameEcon;
        val_27 = 0;
        string val_18 = WGMoreGamesManager.amountPerInstall.ToString(format:  null);
        string val_19 = System.String.Format(format:  1098586544, arg0:  24533272);
        val_28 = "";
        val_29 = 0;
        val_30 = 1152921505065738240;
        goto label_31;
        label_46:
        GameApp[] val_20 = twelvegigs.plugins.InstalledAppsPlugin.PackagesToCheck;
        val_27 = this.moreGamesItems;
        val_28 = 0;
        if(0 <= val_29)
        {
                var val_27 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_27 = val_27 + 0;
        if(val_29 < val_28)
        {
                GameApp[] val_21 = twelvegigs.plugins.InstalledAppsPlugin.PackagesToCheck;
            val_23 = val_22;
            var val_23 = (0 + 0) + 16;
            (0 + 0) + 16.SetParams(state:  true, gameApp:  new GameApp() {uniqueName = mem[((0 + 0) + 16) + (0)], packageName = mem[((0 + 0) + 16) + (4)], assetName = mem[((0 + 0) + 16) + (8)], isInstalled = mem[((0 + 0) + 16) + (12)]});
            val_22 = val_23;
            val_30 = 1152921505065738240;
        }
        else
        {
                (0 + 0) + 16.SetParams(state:  false, gameApp:  new GameApp() {isInstalled = false});
        }
        
        val_29 = 1;
        label_31:
        if(val_29 < ((0 + 0) + 16))
        {
            goto label_46;
        }
    
    }
    public string FormatTimeRemaining(System.TimeSpan timeSpan)
    {
        int val_1 = ???.Days;
        int val_2 = ???.Hours;
        val_2 = val_2 + ((val_1 + (val_1 << 1)) << 3);
        int val_4 = ???.Minutes;
        int val_5 = ???.Seconds;
        string val_6 = System.String.Format(format:  -1662255760, arg0:  13152256, arg1:  13152256, arg2:  13152256);
    }
    protected override void UpdateLogic()
    {
        var val_14;
        this.UpdateLogic();
        val_14 = null;
        val_14 = null;
        bool val_1 = System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = mem[this.curr_reward + (0)], hi = mem[this.curr_reward + (4)], lo = mem[this.curr_reward + (8)], mid = mem[this.curr_reward + (12)]}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10});
        this.object_bonus_reward_box.SetActive(value:  val_1);
        bool val_2 = WGMoreGamesManager.CanCollect();
        this.collectButton.interactable = val_2;
        this.object_collect_text.SetActive(value:  val_2);
        UnityEngine.GameObject val_3 = this.text_countdown_timer.gameObject;
        this.text_countdown_timer.SetActive(value:  val_2 ^ 1);
        System.DateTime val_5 = WGMoreGamesManager.NextMoreGamesCollectTime;
        System.DateTime val_6 = DateTimeCheat.UtcNow;
        System.TimeSpan val_7 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921513221604352}, d2:  new System.DateTime());
        string val_10 = val_7._ticks.FormatTimeRemaining(timeSpan:  new System.TimeSpan());
        UnityEngine.GameObject val_11 = this.button_close.gameObject;
        this.button_close.SetActive(value:  (val_1 & val_2) ^ 1);
    }
    private void OnDisable()
    {
        var val_3;
        System.Delegate val_4;
        val_3 = null;
        val_3 = null;
        System.Action val_1 = new System.Action(object:  System.Void Json.Serializer::serializeDictionary(System.Collections.Generic.Dictionary<string, object> dict), method:  new IntPtr(23979952));
        val_4 = WGMoreGamesManager.RefreshUI;
        System.Delegate val_2 = System.Delegate.Remove(source:  val_4, value:  7454720);
        if(val_4 != 0)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        val_4 = 0;
        label_4:
        WGMoreGamesManager.RefreshUI = val_4;
        WGMoreGamesManager.HandlePopupClosed();
    }
    private void onClick_CollectButton()
    {
        string val_9;
        CurrencyCollectAnimationInstantiator val_10;
        int val_11;
        float val_12;
        CurrencyCollectAnimationInstantiator val_13;
        int val_14;
        this.collectButton.interactable = false;
        val_9 = 0;
        Player val_1 = App.Player;
        0.AddCredits(amount:  new System.Decimal() {flags = mem[this.curr_reward + (0)], hi = mem[this.curr_reward + (4)], lo = mem[this.curr_reward + (8)], mid = mem[this.curr_reward + (12)]}, source:  "MoreGamesBonus", subSource:  val_9, externalParams:  val_9, doTrack:  true);
        WGMoreGamesManager.HandlePopupCollected();
        val_13 = 1152921504765685760;
        if(this.coinsAnim != 0)
        {
                val_10 = this.coinsAnim;
            System.Action val_3 = new System.Action(object:  25105024, method:  new IntPtr(25071808));
            this.coinsAnim.OnCompleteCallback = null;
        }
        
        if(this.coinsAnim == 0)
        {
                return;
        }
        
        Player val_5 = App.Player;
        var val_6 = 0 + 60;
        val_14 = mem[(0 + 60) + (0)];
        decimal val_7 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = 25092972, hi = val_14, lo = mem[(0 + 60) + (4)], mid = mem[(0 + 60) + (8)]}, d2:  new System.Decimal() {flags = 256, hi = mem[this.curr_reward + (0)], lo = mem[this.curr_reward + (4)], mid = mem[this.curr_reward + (8)]});
        val_11 = System.Decimal.op_Explicit(value:  new System.Decimal());
        Player val_9 = App.Player;
        val_13 = this.coinsAnim;
        val_12 = 7.286752E-44f;
        val_10 = 52;
        val_13.Play(fromValue:  val_11, toValue:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
    }
    private void OnCoinsAnimFinished()
    {
    
    }
    public WGMoreGamesPopup()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.moreGamesItems = null;
    }
    private void <Start>b__13_0()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  25462528, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }

}
