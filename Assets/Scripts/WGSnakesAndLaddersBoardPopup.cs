using UnityEngine;
public class WGSnakesAndLaddersBoardPopup : MonoBehaviour
{
    // Fields
    private WGSnakesAndLaddersBoardPopupHeader header;
    private UnityEngine.GameObject boardWindow;
    private UnityEngine.GameObject videoFeedbackWindow;
    private SnakesAndLaddersEvent.WGSnakesAndLaddersBoardUI boardUI;
    private SnakesAndLaddersSpaceRewardUI rewardGroup;
    private UnityEngine.UI.Text rewardAmount;
    private UnityEngine.UI.Image rewardIcon;
    private UnityEngine.Sprite coinSp;
    private UnityEngine.Sprite diceSp;
    private UnityEngine.Sprite goldenCurrencySp;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Button infoButton;
    private UnityEngine.UI.Button starterPackButton;
    private UGUINetworkedButton videoButton;
    private UnityEngine.UI.Button rollButton;
    private UnityEngine.UI.Text rollButtonText;
    private UnityEngine.UI.Text rollsLeftText;
    private UnityEngine.UI.Text timeLeftText;
    private UnityEngine.UI.Button diceRollCollectButton;
    private WGSnakesAndLaddersDiceRollAnim diceRollAnim;
    private UnityEngine.Transform diceRollTarget;
    private CoinCurrencyCollectAnimationInstantiator coinAnim;
    private DiceRollAnimationInstantiator diceAnim;
    private GoldenCurrencyCollectAnimationInstantiator goldenCurrencyAnim;
    private FrameSkipper frameSkipper;
    private UnityEngine.Coroutine showDiceRollResultCoroutine;
    
    // Methods
    private void Awake()
    {
        System.Action<System.Boolean> val_7;
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1026993904, method:  new IntPtr(3267911504));
        this.closeButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1026993904, method:  new IntPtr(3267920720));
        this.infoButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -1026993904, method:  new IntPtr(3267929936));
        this.starterPackButton.m_OnClick.AddListener(call:  162246656);
        System.Action<System.Boolean> val_4 = new System.Action<System.Boolean>(object:  -1026993904, method:  new IntPtr(3267939152));
        System.Delegate val_5 = System.Delegate.Combine(a:  this.videoButton.OnConnectionClick, b:  7401472);
        val_7 = this.videoButton.OnConnectionClick;
        if(val_7 != 0)
        {
                if(null == null)
        {
            goto label_10;
        }
        
        }
        
        val_7 = 0;
        label_10:
        this.videoButton.OnConnectionClick = val_7;
        UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  -1026993904, method:  new IntPtr(3267948368));
        this.rollButton.m_OnClick.AddListener(call:  162246656);
        this.HideSpaceRewardUI();
    }
    private void OnEnable()
    {
        this.SetupWindows();
        this.SetupHeader();
        this.SetupDescriptions();
        this.UpdateStarterPackAccess();
    }
    private void SetupWindows()
    {
        this.boardWindow.SetActive(value:  true);
        this.videoFeedbackWindow.SetActive(value:  false);
    }
    private void SetupHeader()
    {
        System.Collections.Generic.List<SnakesAndLaddersEvent.Board> val_1 = SnakesAndLaddersEventHandler.<Instance>k__BackingField.GetAllBoards();
        this.header.Setup(boards:  SnakesAndLaddersEventHandler.<Instance>k__BackingField);
    }
    private void SetupDescriptions()
    {
        SnakesAndLaddersEvent.WGSnakesAndLaddersBoardUI val_5;
        this.UpdateDiceRollsInfo();
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -1026475248);
        this.frameSkipper = this;
        System.Action val_3 = new System.Action(object:  -1026475248, method:  new IntPtr(3268467024));
        System.Delegate val_4 = System.Delegate.Combine(a:  this.boardUI, b:  7454720);
        val_5 = this.boardUI;
        if(val_5 != 0)
        {
                if(null == null)
        {
            goto label_4;
        }
        
        }
        
        val_5 = 0;
        label_4:
        this.boardUI = val_5;
    }
    private void UpdateDiceRollsInfo()
    {
        var val_6 = 28583620;
        val_6 = 7042172 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        int val_1 = SnakesAndLaddersEventHandler.<Instance>k__BackingField.GetDiceBalance();
        if(val_1 == 0)
        {
                "roll_upper" = "get_dice_exclamation";
        }
        
        if(val_1 == 0)
        {
                "ROLL" = "GET DICE!";
        }
        
        string val_2 = Localization.Localize(key:  -1026383152, defaultValue:  -1026382944, useSingularKey:  false);
        string val_3 = ToUpper();
        string val_4 = Localization.Localize(key:  -1026374480, defaultValue:  -1026374576, useSingularKey:  false);
        string val_5 = System.String.Format(format:  -1026374368, arg0:  -1026374480, arg1:  13152256);
        if(this.rollsLeftText != 0)
        {
                return;
        }
    
    }
    private void UpdateTimeLeft()
    {
        var val_13 = 28583124;
        val_13 = 7042668 + val_13;
        if(val_13 == 0)
        {
                mem2[0] = 1;
        }
        
        System.TimeSpan val_1 = GetTimeLeft();
        string val_2 = Localization.Localize(key:  -1026249984, defaultValue:  -1026249872, useSingularKey:  false);
        typeof(System.Object[]).__il2cppRuntimeField_10 = "time_left_upper";
        string val_4 = ???.Days.ToString(format:  1254115712);
        typeof(System.Object[]).__il2cppRuntimeField_14 = ;
        string val_6 = ???.Hours.ToString(format:  1254115712);
        typeof(System.Object[]).__il2cppRuntimeField_18 = ;
        string val_8 = ???.Minutes.ToString(format:  1254115712);
        typeof(System.Object[]).__il2cppRuntimeField_1C = ;
        string val_10 = ???.Seconds.ToString(format:  1254115712);
        typeof(System.Object[]).__il2cppRuntimeField_20 = ;
        string val_11 = System.String.Format(format:  -1026249776, args:  472754880);
        double val_12 = ???.TotalSeconds;
        if(this.timeLeftText > 0)
        {
                return;
        }
        
        this.frameSkipper.updateLogic = 0;
    }
    private void OnClick_Info()
    {
        var val_6;
        System.Action val_8;
        this.infoButton.interactable = false;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_3 = ShowUGUIMonolith<System.Object>(showNext:  true);
            object val_4 = GetComponent<System.Object>();
            val_6 = null;
            val_6 = null;
            val_8 = WGSnakesAndLaddersBoardPopup.<>c.<>9__33_0;
            if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new System.Action(object:  WGSnakesAndLaddersBoardPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3268847056));
            WGSnakesAndLaddersBoardPopup.<>c.<>9__33_0 = val_8;
        }
        
            public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_14 = val_8;
        }
        
        this.Close();
    }
    private void OnClick_StarterPack()
    {
        var val_6;
        System.Action val_8;
        this.starterPackButton.interactable = false;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_3 = ShowUGUIMonolith<System.Object>(showNext:  true);
            object val_4 = GetComponent<System.Object>();
            val_6 = null;
            val_6 = null;
            val_8 = WGSnakesAndLaddersBoardPopup.<>c.<>9__34_0;
            if(val_8 == 0)
        {
                val_8 = null;
            val_8 = new System.Action(object:  WGSnakesAndLaddersBoardPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3268969296));
            WGSnakesAndLaddersBoardPopup.<>c.<>9__34_0 = val_8;
        }
        
            public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_14 = val_8;
        }
        
        this.Close();
    }
    private void OnClick_Video(bool success)
    {
        this.videoButton.interactable = false;
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                if(success != false)
        {
                this.boardWindow.SetActive(value:  false);
            NotificationCenter val_2 = NotificationCenter.DefaultCenter;
            0.AddObserver(observer:  -1025848688, name:  2128120864);
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if(2124183120 == 0)
        {
                return;
        }
        
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_6 = ShowIncentivizedVideo(tag:  18, adCapExempt:  false);
            return;
        }
        
            this.ShowConnectionRequired();
        }
        
        this.Close();
    }
    private void OnClick_Roll()
    {
        var val_15;
        var val_16;
        var val_17;
        System.Action val_19;
        var val_20;
        this.rollButton.interactable = false;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            goto label_6;
        }
        
        val_15 = 35625792;
        if((SnakesAndLaddersEventHandler.<Instance>k__BackingField.IsOutOfDice()) == false)
        {
            goto label_11;
        }
        
        if((SnakesAndLaddersEventHandler.<Instance>k__BackingField.IsEligibleToShowStarterPack()) == false)
        {
            goto label_12;
        }
        
        this.UpdateStarterPackAccess();
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_5 = ShowUGUIMonolith<System.Object>(showNext:  true);
        object val_6 = GetComponent<System.Object>();
        val_16 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
        val_17 = null;
        val_17 = null;
        val_19 = WGSnakesAndLaddersBoardPopup.<>c.<>9__36_0;
        if(val_19 != 0)
        {
            goto label_31;
        }
        
        val_19 = null;
        val_19 = new System.Action(object:  WGSnakesAndLaddersBoardPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3269218896));
        WGSnakesAndLaddersBoardPopup.<>c.<>9__36_0 = val_19;
        goto label_31;
        label_11:
        SnakesAndLaddersEventHandler.<Instance>k__BackingField.OnDiceRollUsed();
        this.UpdateDiceRollsInfo();
        SnakesAndLaddersEvent.DiceRollResult val_8 = SnakesAndLaddersEventHandler.<Instance>k__BackingField.GetDiceRollResult();
        System.Collections.IEnumerator val_9 = this.ShowDiceRollResult(result:  SnakesAndLaddersEventHandler.<Instance>k__BackingField);
        UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  -1025722352);
        this.showDiceRollResultCoroutine = this;
        return;
        label_12:
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_12 = ShowUGUIMonolith<System.Object>(showNext:  true);
        object val_13 = GetComponent<System.Object>();
        val_16 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
        val_20 = null;
        val_20 = null;
        val_19 = WGSnakesAndLaddersBoardPopup.<>c.<>9__36_1;
        if(val_19 == 0)
        {
                val_19 = null;
            val_19 = new System.Action(object:  WGSnakesAndLaddersBoardPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3269219920));
            WGSnakesAndLaddersBoardPopup.<>c.<>9__36_1 = val_19;
        }
        
        label_31:
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_14 = val_19;
        label_6:
        this.Close();
    }
    private System.Collections.IEnumerator ShowDiceRollResult(SnakesAndLaddersEvent.DiceRollResult result)
    {
        typeof(WGSnakesAndLaddersBoardPopup.<ShowDiceRollResult>d__37).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(WGSnakesAndLaddersBoardPopup.<ShowDiceRollResult>d__37).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        typeof(WGSnakesAndLaddersBoardPopup.<ShowDiceRollResult>d__37).__il2cppRuntimeField_14 = result;
    }
    private void ShowSpaceRewardUI(int rewardValue, UnityEngine.Sprite icon, SnakesAndLaddersBoardSpace space)
    {
        UnityEngine.Transform val_1 = this.rewardGroup.transform;
        UnityEngine.Transform val_2 = this.rewardGroup.parent;
        UnityEngine.Transform val_3 = this.rewardGroup.transform;
        UnityEngine.Transform val_4 = space.transform;
        this.rewardGroup.parent = space;
        UnityEngine.Transform val_5 = this.rewardGroup.transform;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        this.rewardGroup.localPosition = new UnityEngine.Vector3();
        UnityEngine.Transform val_7 = this.rewardGroup.transform;
        this.rewardGroup.parent = this.rewardGroup;
        string val_8 = rewardValue.ToString();
        this.rewardIcon.sprite = icon;
        UnityEngine.GameObject val_9 = this.rewardGroup.gameObject;
        this.rewardGroup.SetActive(value:  true);
    }
    private void HideSpaceRewardUI()
    {
        UnityEngine.GameObject val_1 = this.rewardGroup.gameObject;
        this.rewardGroup.SetActive(value:  false);
    }
    private System.Collections.IEnumerator ShowRewardOnPawnLanded(SnakesAndLaddersEvent.BoardSpaceReward reward, SnakesAndLaddersBoardSpace space)
    {
        typeof(WGSnakesAndLaddersBoardPopup.<ShowRewardOnPawnLanded>d__40).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(WGSnakesAndLaddersBoardPopup.<ShowRewardOnPawnLanded>d__40).__il2cppRuntimeField_10 = reward;
            typeof(WGSnakesAndLaddersBoardPopup.<ShowRewardOnPawnLanded>d__40).__il2cppRuntimeField_14 = this;
        }
        else
        {
                mem[20] = this;
            mem[16] = reward;
        }
        
        typeof(WGSnakesAndLaddersBoardPopup.<ShowRewardOnPawnLanded>d__40).__il2cppRuntimeField_18 = space;
    }
    private void ValidateBoard(SnakesAndLaddersEvent.Board board)
    {
        this.boardUI.UpdateBoard(forceUpdateBoard:  board);
    }
    private void UpdateStarterPackAccess()
    {
        System.Action val_7;
        System.Action val_8;
        var val_7 = 28584568;
        val_7 = 7041224 + val_7;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        bool val_8 = SnakesAndLaddersEventHandler.<Instance>k__BackingField.IsStarterPackActive();
        UnityEngine.GameObject val_2 = this.starterPackButton.gameObject;
        this.starterPackButton.SetActive(value:  val_8);
        UnityEngine.GameObject val_3 = this.infoButton.gameObject;
        val_7 = this.infoButton;
        val_8 = val_8 ^ 1;
        val_7.SetActive(value:  val_8);
        if(val_8 == true)
        {
                return;
        }
        
        if(this.frameSkipper == 0)
        {
                return;
        }
        
        val_7 = null;
        val_7 = new System.Action(object:  -1024901872, method:  new IntPtr(3270040400));
        System.Delegate val_6 = System.Delegate.Combine(a:  this.frameSkipper.updateLogic, b:  7454720);
        val_8 = this.frameSkipper.updateLogic;
        if(val_8 != 0)
        {
                if(null == null)
        {
            goto label_14;
        }
        
        }
        
        val_8 = 0;
        label_14:
        this.frameSkipper.updateLogic = val_8;
    }
    private void UpdateStarterPackStatus()
    {
        System.Action val_4;
        var val_4 = 28577128;
        val_4 = 7048664 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        if((SnakesAndLaddersEventHandler.<Instance>k__BackingField.IsStarterPackActive()) == true)
        {
                return;
        }
        
        this.UpdateStarterPackAccess();
        System.Action val_2 = new System.Action(object:  -1024761200, method:  new IntPtr(3270040400));
        System.Delegate val_3 = System.Delegate.Remove(source:  this.frameSkipper.updateLogic, value:  7454720);
        val_4 = this.frameSkipper.updateLogic;
        if(val_4 != 0)
        {
                if(null == null)
        {
            goto label_7;
        }
        
        }
        
        val_4 = 0;
        label_7:
        this.frameSkipper.updateLogic = val_4;
    }
    private void OnVideoResponse(Notification notif)
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.RemoveObserver(observer:  -1024611312, name:  2128120864);
        string val_2 = notif.data.ToString();
        bool val_3 = System.Boolean.Parse(value:  notif.data);
        this.boardWindow.SetActive(value:  val_3 ^ 1);
        this.videoFeedbackWindow.SetActive(value:  val_3);
        if(val_3 == false)
        {
                return;
        }
        
        this.diceRollCollectButton.interactable = true;
        UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  -1024611312, method:  new IntPtr(3270330960));
        this.diceRollCollectButton.m_OnClick.AddListener(call:  162246656);
    }
    private void OnClick_Collect()
    {
        int val_4;
        int val_5;
        int val_6;
        int val_7;
        this.diceRollCollectButton.m_OnClick.RemoveAllListeners();
        this.diceRollCollectButton.interactable = false;
        SnakesAndLaddersEventHandler.<Instance>k__BackingField.RewardDiceRolls(amount:  1, source:  -1825935024);
        System.Action val_1 = new System.Action(object:  -1024449136, method:  new IntPtr(3270489040));
        mem2[0] = null;
        decimal val_3 = System.Decimal.op_Implicit(value:  -1024461184);
        this.diceAnim.Play(fromValue:  (SnakesAndLaddersEventHandler.<Instance>k__BackingField.GetDiceBalance()) - 1, toValue:  new System.Decimal() {flags = val_6, hi = val_7, lo = val_5, mid = val_4}, textTickTime:  null, delayBeforeComplete:  null, destinationObject:  3212836864, originObject:  3212836864);
    }
    private void ShowConnectionRequired()
    {
        var val_7;
        System.Func<System.Boolean> val_9;
        var val_10;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
        string val_3 = Localization.Localize(key:  -1725760224, defaultValue:  -1725760096, useSingularKey:  false);
        string val_4 = Localization.Localize(key:  -1725759984, defaultValue:  -1725759840, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_5 = Localization.Localize(key:  -1827175552, defaultValue:  -1827401456, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "ok_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_7 = null;
        val_7 = null;
        val_9 = WGSnakesAndLaddersBoardPopup.<>c.<>9__46_0;
        if(val_9 == 0)
        {
                val_9 = null;
            val_9 = new System.Func<System.Boolean>(object:  WGSnakesAndLaddersBoardPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3270626640));
            WGSnakesAndLaddersBoardPopup.<>c.<>9__46_0 = val_9;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_9;
        val_10 = null;
        val_10 = null;
        SetupMessage(titleTxt:  -1725760224, messageTxt:  -1725759984, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne, hi = System.Decimal.Powers10.__il2cppRuntimeField_28, lo = System.Decimal.Powers10.__il2cppRuntimeField_2C, mid = System.Decimal.Powers10.__il2cppRuntimeField_30}, collectType:  "credits");
    }
    private void Close()
    {
        if(this.showDiceRollResultCoroutine != 0)
        {
                this.StopCoroutine(routine:  this.showDiceRollResultCoroutine);
            this.showDiceRollResultCoroutine = 0;
        }
        
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1024199536, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGSnakesAndLaddersBoardPopup()
    {
    
    }
    private void <ShowRewardOnPawnLanded>b__40_0()
    {
        this.HideSpaceRewardUI();
        UnityEngine.GameObject val_1 = this.coinAnim.gameObject;
        this.coinAnim.SetActive(value:  false);
    }
    private void <ShowRewardOnPawnLanded>b__40_1()
    {
        this.HideSpaceRewardUI();
        UnityEngine.GameObject val_1 = this.diceAnim.gameObject;
        this.diceAnim.SetActive(value:  false);
    }
    private void <ShowRewardOnPawnLanded>b__40_2()
    {
        this.HideSpaceRewardUI();
        UnityEngine.GameObject val_1 = this.goldenCurrencyAnim.gameObject;
        this.goldenCurrencyAnim.SetActive(value:  false);
    }
    private void <OnClick_Collect>b__45_0()
    {
        this.UpdateDiceRollsInfo();
        this.videoFeedbackWindow.SetActive(value:  false);
        this.boardWindow.SetActive(value:  true);
        UnityEngine.GameObject val_1 = this.diceAnim.gameObject;
        this.diceAnim.SetActive(value:  false);
    }

}
