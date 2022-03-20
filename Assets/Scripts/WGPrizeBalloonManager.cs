using UnityEngine;
public class WGPrizeBalloonManager : MonoSingleton<WGPrizeBalloonManager>
{
    // Fields
    public bool hack_setNonPurchaser;
    public bool hack_forceToShow;
    private PrizeBalloon.Progress progress;
    
    // Methods
    private void Start()
    {
        var val_7;
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.UI.LayoutElement val_2 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -1082046976);
        mem[1152921512114734612] = 1000;
        System.Action val_3 = new System.Action(object:  -1082046976, method:  new IntPtr(3212894272));
        mem[1152921512114734616] = null;
        WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_5 = new System.Action<Result>(object:  -1082046976, method:  new IntPtr(3212895296));
        System.Delegate val_6 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_7 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_7 != 0)
        {
                if(val_7 == null)
        {
            goto label_8;
        }
        
        }
        
        val_7 = 0;
        label_8:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_7;
    }
    private void OnApplicationQuit()
    {
        this.progress.levelsCompletedThisSession = 0;
        if(this.progress == 0)
        {
            
        }
    
    }
    public override void InitMonoSingleton()
    {
        PrizeBalloon.Progress val_1 = new PrizeBalloon.Progress();
        this.progress = val_1;
        if(val_1 == 0)
        {
            
        }
    
    }
    public string GetEligibilityInfo()
    {
        System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
        GameEcon val_2 = App.getGameEcon;
        System.Text.StringBuilder val_3 = AppendFormat(format:  -1081718592, arg0:  8945664);
        bool val_4 = SceneDictator.IsInGameScene();
        System.Text.StringBuilder val_5 = AppendFormat(format:  -1081718480, arg0:  8945664);
        bool val_6 = IsGameModeEligible();
        System.Text.StringBuilder val_7 = AppendFormat(format:  -1081718352, arg0:  8945664);
        Player val_8 = App.Player;
        GameEcon val_9 = App.getGameEcon;
        if(0 >= 586541126)
        {
                0 = 1;
        }
        
        System.Text.StringBuilder val_10 = AppendFormat(format:  -1081718144, arg0:  8945664);
        GameEcon val_11 = App.getGameEcon;
        if(this.progress.dailyShownTimes < 860493547)
        {
                0 = 1;
        }
        
        System.Text.StringBuilder val_12 = AppendFormat(format:  -1081709840, arg0:  13152256, arg1:  8945664);
        Player val_13 = App.Player;
        GameEcon val_14 = App.getGameEcon;
        decimal val_15 = System.Decimal.op_Implicit(value:  -1081696644);
        bool val_16 = System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal());
        System.Text.StringBuilder val_17 = AppendFormat(format:  -1081709696, arg0:  8945664);
        GameEcon val_18 = App.getGameEcon;
        if(this.progress.levelsCompletedThisSession >= 1495406058)
        {
                0 = 1;
        }
        
        System.Text.StringBuilder val_19 = AppendFormat(format:  -1081709552, arg0:  13152256, arg1:  8945664);
        PrizeBalloon.PayerType val_20 = this.GetPayerType();
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        PrizeBalloon.PayerType val_21 = this.GetPayerType();
        if(this != 0)
        {
                this = 1;
        }
        
        System.Text.StringBuilder val_22 = AppendFormat(format:  -1081709376, arg0:  433065984, arg1:  8945664, arg2:  "Undefined Payer Type means that the payer is a purchaser but not a lapsed purchaser");
        int val_23 = this.GetSecondsSinceLastBalloon();
        GameEcon val_25 = App.getGameEcon;
        if(this.GetSecondsSinceLastBalloon() >= 302065905)
        {
                0 = 1;
        }
        
        System.Text.StringBuilder val_26 = AppendFormat(format:  -1081708992, arg0:  13152256, arg1:  8945664);
        twelvegigs.Autopilot.AutopilotManager val_27 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_28 = HasQueuedWindows();
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_29 = AppendFormat(format:  -1081708832, arg0:  8945664);
        }
        else
        {
                System.Text.StringBuilder val_30 = AppendFormat(format:  -1081708832, arg0:  8945664);
        }
        
        System.Text.StringBuilder val_31 = AppendLine();
        bool val_32 = this.IsEligibleToTrigger();
        if(val_1 != 0)
        {
                System.Text.StringBuilder val_33 = AppendFormat(format:  -1081708704, arg0:  8945664);
            return;
        }
        
        System.Text.StringBuilder val_34 = AppendFormat(format:  -1081708704, arg0:  8945664);
    }
    public bool IsEligibleToTrigger()
    {
        var val_19;
        int val_20;
        if(this.hack_forceToShow != false)
        {
                bool val_1 = SceneDictator.IsInGameScene();
            if(val_1 != false)
        {
                val_19 = 1;
            if(val_1.IsGameModeEligible() == true)
        {
                return (bool)val_19;
        }
        
        }
        
        }
        
        GameEcon val_3 = App.getGameEcon;
        if(233 != 0)
        {
                val_19 = 0;
            bool val_4 = SceneDictator.IsInGameScene();
            if(val_4 == false)
        {
                return (bool)val_19;
        }
        
            if(val_4.IsGameModeEligible() == false)
        {
                return (bool)val_19;
        }
        
            Player val_6 = App.Player;
            val_20 = 0;
            GameEcon val_7 = App.getGameEcon;
            val_19 = 0;
            if(val_20 < 586541126)
        {
                return (bool)val_19;
        }
        
            val_20 = this.progress.dailyShownTimes;
            GameEcon val_8 = App.getGameEcon;
            val_19 = 0;
            if(val_20 >= 860493547)
        {
                return (bool)val_19;
        }
        
            Player val_9 = App.Player;
            GameEcon val_10 = App.getGameEcon;
            val_20 = 1128862730;
            val_19 = 0;
            decimal val_11 = System.Decimal.op_Implicit(value:  -1081568244);
            if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal())) == true)
        {
                return (bool)val_19;
        }
        
            val_20 = this.progress.levelsCompletedThisSession;
            GameEcon val_13 = App.getGameEcon;
            val_19 = 0;
            if(val_20 < 1495406058)
        {
                return (bool)val_19;
        }
        
            PrizeBalloon.PayerType val_14 = this.GetPayerType();
            if(this == 0)
        {
                return (bool)val_19;
        }
        
            GameEcon val_16 = App.getGameEcon;
            val_19 = 0;
            if(this.GetSecondsSinceLastBalloon() < 302065905)
        {
                return (bool)val_19;
        }
        
            twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            bool val_18 = HasQueuedWindows();
            val_18 = val_18 ^ 1;
            return (bool)val_18;
        }
        
        val_19 = 0;
        return (bool)val_19;
    }
    public bool IsGameModeEligible()
    {
        var val_7;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2116505760) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_7 = 0;
            if(PlayingChallenge == true)
        {
                return (bool)val_7;
        }
        
        }
        
        val_7 = CategoryPacksManager.IsPlaying ^ 1;
        return (bool)val_7;
    }
    public int GetCoinReward()
    {
        var val_6;
        var val_8;
        var val_9;
        val_8 = null;
        val_8 = null;
        PrizeBalloon.PayerType val_1 = this.GetPayerType();
        System.Collections.Generic.List<PrizeBalloon.CoinRewardChance> val_2 = PrizeBalloon.Econ.CoinRewardsData.Item[-1081319904];
        RandomSet val_3 = new RandomSet();
        List.Enumerator<T> val_4 = GetEnumerator();
        label_9:
        if(MoveNext() == false)
        {
            goto label_5;
        }
        
        if(val_6 != 0)
        {
                val_9 = mem[val_6 + 8];
            val_9 = val_6 + 8;
        }
        else
        {
                val_9 = 0;
        }
        
        add(item:  0, weight:  (float)val_6 + 12);
        goto label_9;
        label_5:
        Dispose();
        return (int)roll(unweighted:  false);
    }
    public void ShowBalloon()
    {
        var val_4;
        System.Action val_6;
        this.MarkProgress();
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_4 = null;
        val_4 = null;
        val_6 = WGPrizeBalloonManager.<>c.<>9__10_0;
        if(val_6 == 0)
        {
                val_6 = null;
            val_6 = new System.Action(object:  WGPrizeBalloonManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3213736416));
            WGPrizeBalloonManager.<>c.<>9__10_0 = val_6;
        }
        
        Setup(amount:  this.GetCoinReward(), onClose:  7454720);
    }
    public void CollectReward(int amount)
    {
        int val_5;
        var val_6;
        var val_7;
        Player val_1 = App.Player;
        val_6 = 2621448;
        if(val_6 != 0)
        {
                val_7 = 23;
        }
        else
        {
                val_6 = 96;
            val_7 = 0;
        }
        
        mem[96] = 1;
        Player val_2 = App.Player;
        2621448.Save(writePrefs:  true);
        Player val_3 = App.Player;
        decimal val_4 = System.Decimal.op_Implicit(value:  -1081105800);
        0.AddCredits(amount:  new System.Decimal() {mid = val_5}, source:  "Prize Balloon", subSource:  0, externalParams:  0, doTrack:  true);
    }
    public void ValidateProgress()
    {
        ulong val_6;
        ulong val_8;
        System.DateTime val_1 = Date;
        System.DateTime val_2 = DateTimeCheat.Now;
        System.DateTime val_5 = Date;
        if((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_8}, t2:  new System.DateTime() {dateData = val_6})) == false)
        {
                return;
        }
        
        this.progress.dailyShownTimes = 0;
    }
    public int GetTracking_BalloonsAppearedInLevel()
    {
        if(this.progress != 0)
        {
                return (int)this.progress.balloonAppearedWithinLevel;
        }
        
        return (int)this.progress.balloonAppearedWithinLevel;
    }
    private void CheckEligibility()
    {
        this.ValidateProgress();
        if(this.IsEligibleToTrigger() == false)
        {
                return;
        }
        
        R4.ShowBalloon();
    }
    private void Instance_OnSceneLoaded(SceneType obj)
    {
        if(obj != 2)
        {
                return;
        }
        
        if(this.IsGameModeEligible() == false)
        {
                return;
        }
        
        WordRegion val_2 = WordRegion.instance;
        if(0 == 0)
        {
                return;
        }
        
        MainController val_4 = MainController.instance;
        UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  -1080607872, method:  new IntPtr(3214334400));
        1.AddListener(call:  162246656);
    }
    private void OnLevelComplete()
    {
        PrizeBalloon.Progress val_1;
        int val_2;
        this.progress.balloonAppearedWithinLevel = 0;
        val_1 = this.progress;
        if(val_1 != 0)
        {
                val_2 = this.progress.levelsCompletedThisSession;
        }
        else
        {
                val_1 = 8;
            val_2 = 0;
        }
        
        mem[8] = 1;
        if(this.progress == 0)
        {
            
        }
    
    }
    private void MarkProgress()
    {
        var val_4;
        var val_5;
        PrizeBalloon.Progress val_6;
        int val_7;
        PrizeBalloon.Progress val_8;
        int val_9;
        Player val_1 = App.Player;
        val_4 = 2621448;
        if(val_4 != 0)
        {
                val_5 = 35143880;
        }
        else
        {
                val_4 = 100;
            val_5 = 33446072;
        }
        
        mem[100] = 33446073;
        Player val_2 = App.Player;
        2621448.Save(writePrefs:  true);
        val_6 = this.progress;
        if(val_6 != 0)
        {
                val_7 = this.progress.balloonAppearedWithinLevel;
        }
        else
        {
                val_6 = 28;
            val_7 = 52;
        }
        
        mem[28] = 53;
        System.DateTime val_3 = DateTimeCheat.Now;
        this.progress.lastBalloonShownTime = new System.DateTime();
        val_8 = this.progress;
        if(val_8 != 0)
        {
                val_9 = this.progress.dailyShownTimes;
        }
        else
        {
                val_8 = 24;
            val_9 = 0;
        }
        
        mem[24] = 1;
        if(this.progress != 0)
        {
                return;
        }
    
    }
    private PrizeBalloon.PayerType GetPayerType()
    {
        var val_5;
        if(this.hack_setNonPurchaser == false)
        {
                this.hack_setNonPurchaser = this.hack_forceToShow;
            goto label_1;
        }
        
        return;
        label_1:
        Player val_1 = App.Player;
        val_5 = null;
        val_5 = null;
        if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = 264}, d2:  new System.DateTime() {dateData = System.DateTime.MinValue})) != false)
        {
                Player val_3 = App.Player;
            if(0 == 0)
        {
                return;
        }
        
        }
        
        bool val_4 = this.IsLapsedPayer();
        if(val_4 == true)
        {
                val_4 = 2;
        }
    
    }
    private bool IsLapsedPayer()
    {
        ulong val_3;
        var val_6;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        Player val_2 = App.Player;
        System.TimeSpan val_5 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512116671088}, d2:  new System.DateTime() {dateData = val_3});
        double val_8 = val_6.TotalDays;
        GameEcon val_9 = App.getGameEcon;
        if(5759945 == 0)
        {
                3214856832 = 3214856832;
        }
        
        if((-2107439638) <= S0)
        {
                0 = 1;
        }
        
        return true;
    }
    private int GetSecondsSinceLastBalloon()
    {
        ulong val_2;
        var val_5;
        System.DateTime val_1 = DateTimeCheat.Now;
        System.TimeSpan val_4 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512116787192}, d2:  new System.DateTime() {dateData = val_2});
        double val_7 = val_5.TotalSeconds;
        if(System.DateTime.__il2cppRuntimeField_cctor_finished == 0)
        {
                3214972936 = 3214972936;
        }
        
        return (int)S0;
    }
    public WGPrizeBalloonManager()
    {
    
    }

}
