using UnityEngine;
public class TRVGiftRewardPopup : WGGiftRewardPopup
{
    // Fields
    private UGUINetworkedButton doubleCoinButton;
    private UGUINetworkedButton extraExpertButton;
    private UnityEngine.UI.Button noThanksButton;
    private UnityEngine.UI.Text noThanksButtonText;
    private bool bonusCoinVideo;
    private decimal coinRewardAmount;
    private bool dailyBonus;
    private GiftRewardSource currentRewardSource;
    
    // Methods
    public override void Setup(System.Collections.Generic.List<GiftReward> rewards, GiftRewardSource rewardSource)
    {
        if(rewardSource < 2)
        {
                0 = 1;
        }
        
        this.currentRewardSource = rewardSource;
        this.dailyBonus = true;
        this.SetupUI(rewardCount:  rewards);
        UnityEngine.GameObject val_1 = this.noThanksButton.gameObject;
        this.noThanksButton.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.extraExpertButton.gameObject;
        this.extraExpertButton.SetActive(value:  false);
        UnityEngine.GameObject val_3 = this.doubleCoinButton.gameObject;
        this.doubleCoinButton.SetActive(value:  false);
    }
    protected override void SetupRewards(System.Collections.Generic.List<GiftReward> rewards, GiftRewardSource rewardSource, bool postCollectLogic = False)
    {
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        int val_20;
        int val_21;
        System.Delegate val_22;
        object val_1 = null;
        val_12 = val_1;
        val_1 = new System.Object();
        if(val_12 != 0)
        {
                val_13 = val_12;
            typeof(TRVGiftRewardPopup.<>c__DisplayClass9_0).__il2cppRuntimeField_8 = rewards;
        }
        else
        {
                val_13 = 8;
            mem[8] = rewards;
        }
        
        typeof(TRVGiftRewardPopup.<>c__DisplayClass9_0).__il2cppRuntimeField_C = this;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(val_12 != 0)
        {
                val_14 = val_12;
            typeof(TRVGiftRewardPopup.<>c__DisplayClass9_0).__il2cppRuntimeField_10 = null;
        }
        else
        {
                val_14 = 16;
            mem[16] = null;
        }
        
        List.Enumerator<T> val_3 = GetEnumerator();
        label_24:
        if(MoveNext() == false)
        {
            goto label_6;
        }
        
        GiftRewardUIParams val_6 = new GiftRewardUIParams();
        if(val_6 != 0)
        {
                val_15 = val_6;
            typeof(GiftRewardUIParams).__il2cppRuntimeField_8 = 0;
        }
        else
        {
                val_15 = 8;
            mem[8] = 0;
        }
        
        if(mem[8] == 0)
        {
                var val_7 = 0 + 20;
            Player val_8 = App.Player;
            Player val_9 = App.Player;
            var val_13 = 0;
            val_16 = 0;
            val_17 = 52;
            val_18 = 35615780;
            val_19 = 52;
            val_13 = val_13 + 64;
            val_16 = val_16;
            val_20 = mem[(0 + 64) + (0)];
            val_18 = val_18;
            val_17 = val_17;
            val_21 = mem[(0 + 64) + (4)];
            val_19 = val_19;
            decimal val_10 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -599170688, hi = 52, lo = val_20, mid = val_21}, d2:  new System.Decimal() {flags = mem[(0 + 64) + (8)], hi = 1, mid = 52});
            val_12 = val_12;
        }
        
        Add(item:  375664640);
        goto label_24;
        label_6:
        Dispose();
        System.Action val_11 = new System.Action(object:  353300480, method:  new IntPtr(3695783664));
        val_22 = mem[1152921512597622988];
        System.Delegate val_12 = System.Delegate.Combine(a:  val_22, b:  7454720);
        if(val_22 != 0)
        {
                if(val_22 == null)
        {
            goto label_27;
        }
        
        }
        
        val_22 = 0;
        label_27:
        mem[1152921512597622988] = val_22;
    }
    private void SetGiftRevealedState()
    {
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        System.Action<System.Boolean> val_23;
        var val_24;
        UnityEngine.GameObject val_1 = this.noThanksButton.gameObject;
        this.noThanksButton.SetActive(value:  true);
        UnityEngine.GameObject val_2 = this.extraExpertButton.gameObject;
        if(this.extraExpertButton != 0)
        {
                this.currentRewardSource - 12 = 1;
        }
        
        this.extraExpertButton.SetActive(value:  true);
        val_19 = 0;
        UnityEngine.GameObject val_4 = this.doubleCoinButton.gameObject;
        val_20 = null;
        val_20 = null;
        bool val_5 = System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = this.coinRewardAmount, hi = R6, lo = SB, mid = SL}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10});
        if(val_5 != false)
        {
                GiftRewardSource val_6 = this.currentRewardSource - 12;
            if(val_5 == true)
        {
                val_19 = 1;
        }
        
        }
        
        this.doubleCoinButton.SetActive(value:  true);
        UnityEngine.GameObject val_7 = this.extraExpertButton.gameObject;
        if(this.extraExpertButton.activeSelf == true)
        {
            goto label_12;
        }
        
        UnityEngine.GameObject val_9 = this.doubleCoinButton.gameObject;
        if(this.doubleCoinButton.activeSelf == false)
        {
            goto label_15;
        }
        
        label_12:
        val_21 = "NO THANKS";
        goto label_16;
        label_15:
        val_21 = "CONTINUE";
        label_16:
        this.noThanksButtonText.interactable = false;
        System.Action<System.Boolean> val_11 = new System.Action<System.Boolean>(object:  -598976880, method:  new IntPtr(3695941840));
        this.extraExpertButton.OnConnectionClick = null;
        System.Action<System.Boolean> val_12 = new System.Action<System.Boolean>(object:  -598976880, method:  new IntPtr(3695946960));
        this.doubleCoinButton.OnConnectionClick = null;
        UnityEngine.Events.UnityAction val_13 = new UnityEngine.Events.UnityAction(object:  -598976880, method:  new IntPtr(3695956176));
        this.noThanksButton.m_OnClick.AddListener(call:  162246656);
        val_22 = 1152921504901095424;
        val_23 = 1152921511451249552;
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(IsVideoAvailable() == true)
        {
                return;
        }
        
        this.extraExpertButton.WaitingStatus(waiting:  true);
        this.doubleCoinButton.WaitingStatus(waiting:  true);
        twelvegigs.Autopilot.AutopilotManager val_16 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_23 = null;
        val_23 = new System.Action<System.Boolean>(object:  -598976880, method:  new IntPtr(3695965392));
        System.Delegate val_18 = System.Delegate.Combine(a:  public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C, b:  7401472);
        val_24 = public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C;
        if(val_24 != 0)
        {
                if(val_24 == null)
        {
            goto label_34;
        }
        
        }
        
        val_24 = 0;
        label_34:
        public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C = val_24;
    }
    private void OnRewardedVideoLoaded(bool success)
    {
        bool val_5;
        UGUINetworkedButton val_6;
        var val_7;
        val_5 = success ^ 1;
        this.extraExpertButton.WaitingStatus(waiting:  val_5);
        val_6 = this.doubleCoinButton;
        val_6.WaitingStatus(waiting:  val_5);
        if(success == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_6 = null;
        val_6 = new System.Action<System.Boolean>(object:  -598799344, method:  new IntPtr(3695965392));
        System.Delegate val_3 = System.Delegate.Remove(source:  public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C, value:  7401472);
        val_7 = public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C;
        if(val_7 != 0)
        {
                if(val_7 == null)
        {
            goto label_9;
        }
        
        }
        
        val_7 = 0;
        label_9:
        public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C = val_7;
    }
    private void ShowVideoAd(bool isBonusCoinVideo)
    {
        var val_9;
        var val_10;
        this.bonusCoinVideo = isBonusCoinVideo;
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -598670960, name:  2128120864);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_9 = public static AdsUIController MonoSingleton<AdsUIController>::get_Instance();
        if(this.dailyBonus == false)
        {
                0 = 31;
        }
        
        if((ShowIncentivizedVideo(tag:  31, adCapExempt:  true)) == true)
        {
                return;
        }
        
        this.extraExpertButton.WaitingStatus(waiting:  true);
        this.doubleCoinButton.WaitingStatus(waiting:  true);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_5 = new System.Action<System.Boolean>(object:  -598670960, method:  new IntPtr(3695965392));
        System.Delegate val_6 = System.Delegate.Combine(a:  public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C, b:  7401472);
        val_10 = public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C;
        if(val_10 != 0)
        {
                if(val_10 == null)
        {
            goto label_15;
        }
        
        }
        
        val_10 = 0;
        label_15:
        public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C = val_10;
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_8 = IsVideoAvailable();
    }
    private void ExtraExpertClicked(bool connected)
    {
        var val_9;
        var val_10;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(IsVideoAvailable() != false)
        {
                this.ShowVideoAd(isBonusCoinVideo:  false);
            return;
        }
        
        System.Func<System.Boolean> val_3 = new System.Func<System.Boolean>(object:  -598549168, method:  new IntPtr(3696392528));
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = null;
        GameBehavior val_4 = App.getBehavior;
        string val_6 = Localization.Localize(key:  -598573744, defaultValue:  -598573648, useSingularKey:  false);
        string val_7 = Localization.Localize(key:  -598573536, defaultValue:  -598573408, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_8 = Localization.Localize(key:  -598573280, defaultValue:  -1663756496, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "try_again_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_9 = null;
        val_10 = 0;
        if( == 0)
        {
                val_10 = 0;
        }
        
        val_10.SetupMessage(titleTxt:  -598573744, messageTxt:  -598573536, shownButtons:  1054454320, buttonTexts:  null, showClose:  true, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
    }
    private void DoubleCoinClicked(bool connected)
    {
        var val_9;
        var val_10;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(IsVideoAvailable() != false)
        {
                this.ShowVideoAd(isBonusCoinVideo:  true);
            return;
        }
        
        GameBehavior val_3 = App.getBehavior;
        System.Func<System.Boolean> val_5 = new System.Func<System.Boolean>(object:  -598436144, method:  new IntPtr(3696506128));
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = null;
        string val_6 = Localization.Localize(key:  -598573744, defaultValue:  -598573648, useSingularKey:  false);
        string val_7 = Localization.Localize(key:  -598573536, defaultValue:  -598573408, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_8 = Localization.Localize(key:  -598573280, defaultValue:  -1663756496, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "try_again_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "NULL";
        val_9 = null;
        val_10 = 0;
        if( == 0)
        {
                val_10 = 0;
        }
        
        val_10.SetupMessage(titleTxt:  -598573744, messageTxt:  -598573536, shownButtons:  1054454320, buttonTexts:  null, showClose:  true, buttonCallbacks:  null, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
    }
    private void OnVideoResponse(Notification notif)
    {
        TRVGiftRewardPopup val_19;
        var val_20;
        float val_21;
        var val_22;
        var val_23;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        val_19 = this;
        string val_1 = notif.data.ToString();
        if((System.Boolean.Parse(value:  notif.data)) == false)
        {
                return;
        }
        
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.RemoveObserver(observer:  -598298544, name:  2128120864);
        UnityEngine.GameObject val_4 = this.extraExpertButton.gameObject;
        this.extraExpertButton.SetActive(value:  false);
        UnityEngine.GameObject val_5 = this.doubleCoinButton.gameObject;
        this.doubleCoinButton.SetActive(value:  false);
        UnityEngine.GameObject val_6 = this.noThanksButton.gameObject;
        this.noThanksButton.SetActive(value:  false);
        GiftRewardUIParams val_7 = null;
        val_20 = val_7;
        val_7 = new GiftRewardUIParams();
        val_21 = 1152921504959881216;
        TRVDailyBonusRewardContainer val_8 = new TRVDailyBonusRewardContainer();
        typeof(GiftRewardUIParams).__il2cppRuntimeField_8 = val_8;
        if(this.currentRewardSource == 3)
        {
                1 = 13;
        }
        
        if(this.bonusCoinVideo == false)
        {
            goto label_17;
        }
        
        typeof(TRVDailyBonusRewardContainer).__il2cppRuntimeField_8 = 0;
        Player val_9 = App.Player;
        if(this.currentRewardSource == 3)
        {
                "Daily Bonus Rewarded Video" = "Chapter Rewards Rewarded Video";
        }
        
        val_21 = "Chapter Rewards Rewarded Video";
        Player val_10 = App.Player;
        0.AddCredits(amount:  new System.Decimal() {flags = typeof(TRVDailyBonusRewardContainer).__il2cppRuntimeField_14, hi = TRVDailyBonusRewardContainer.__il2cppRuntimeField_this_arg, lo = typeof(TRVDailyBonusRewardContainer).__il2cppRuntimeField_1C, mid = TRVDailyBonusRewardContainer.__il2cppRuntimeField_element_class}, source:  val_21, subSource:  0, externalParams:  0, doTrack:  true);
        var val_19 = 0;
        Player val_11 = App.Player;
        val_19 = val_19;
        val_19 = val_19 + 60;
        val_22 = mem[1152921512598483048];
        if(val_22 == 0)
        {
            goto label_28;
        }
        
        val_23 = mem[mem[1152921512598483048] + 60];
        val_23 = mem[1152921512598483048] + 60;
        goto label_29;
        label_17:
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<TRVExpert> val_14 = DetermineExpertCards(source:  13, expertNowReadyToUpgrade: out  bool val_13 = true, cardsToPull:  1);
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        typeof(TRVDailyBonusRewardContainer).__il2cppRuntimeField_8 = 3;
        typeof(TRVDailyBonusRewardContainer).__il2cppRuntimeField_24 = public static TRVExpertsController MonoSingleton<TRVExpertsController>::get_Instance().__il2cppRuntimeField_8 + 16;
        if(val_8 == 0)
        {
            goto label_41;
        }
        
        goto label_42;
        label_28:
        val_23 = mem[mem[1152921512598483048] + 60];
        val_23 = mem[1152921512598483048] + 60;
        val_22 = mem[1152921512598483048];
        if(val_22 == 0)
        {
            goto label_60;
        }
        
        label_29:
        val_25 = val_22;
        val_26 = mem[mem[1152921512598483048] + 180];
        val_26 = mem[1152921512598483048] + 180;
        label_60:
        val_25 = 0;
        GiftRewardRevealInfo val_15 = val_25.AddCoinReward(param:  375664640);
        val_23.Add(item:  0);
        val_27 = 0;
        mem[1152921512598483048].OnClick_RevealReward(onAllRewardsRevealed:  0);
        goto label_50;
        label_41:
        if(val_8 == 0)
        {
            goto label_63;
        }
        
        label_42:
        val_28 = val_8;
        val_26 = mem[null + 180];
        label_63:
        val_28 = 0;
        GiftRewardRevealInfo val_16 = val_28.AddExpertReward(param:  375664640);
        Add(item:  0);
        val_28.OnClick_RevealReward(onAllRewardsRevealed:  0);
        if(0 != 0)
        {
                val_27 = 1;
        }
        
        label_50:
        System.Collections.IEnumerator val_17 = this.WaitThenClose(expertLeveledUp:  true);
        UnityEngine.Coroutine val_18 = val_19.StartCoroutine(routine:  -598298544);
    }
    private System.Collections.IEnumerator WaitThenClose(bool expertLeveledUp)
    {
        typeof(TRVGiftRewardPopup.<WaitThenClose>d__16).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(TRVGiftRewardPopup.<WaitThenClose>d__16).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        typeof(TRVGiftRewardPopup.<WaitThenClose>d__16).__il2cppRuntimeField_14 = expertLeveledUp;
    }
    private void Close(bool expertLeveledUp)
    {
        var val_9;
        if(expertLeveledUp != false)
        {
                GameBehavior val_1 = App.getBehavior;
        }
        
        if(this.dailyBonus != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ShowPostPopups();
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ResetReadyToCollectState();
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            RemoveVideoObserver();
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action<System.Boolean> val_7 = new System.Action<System.Boolean>(object:  -598049968, method:  new IntPtr(3695965392));
        System.Delegate val_8 = System.Delegate.Remove(source:  public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C, value:  7401472);
        val_9 = public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C;
        if(val_9 != 0)
        {
                if(val_9 == null)
        {
            goto label_17;
        }
        
        }
        
        val_9 = 0;
        label_17:
        public static ApplovinMaxPlugin MonoSingleton<ApplovinMaxPlugin>::get_Instance().__il2cppRuntimeField_1C = val_9;
        this.Close();
    }
    public TRVGiftRewardPopup()
    {
    
    }
    private void <SetGiftRevealedState>b__10_0()
    {
        this.Close(expertLeveledUp:  false);
    }
    private bool <ExtraExpertClicked>b__13_0()
    {
        this.ExtraExpertClicked(connected:  false);
        return true;
    }
    private bool <DoubleCoinClicked>b__14_0()
    {
        this.DoubleCoinClicked(connected:  false);
        return true;
    }

}
