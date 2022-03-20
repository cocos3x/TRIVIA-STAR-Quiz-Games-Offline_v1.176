using UnityEngine;
public class SROptions_Player : SuperLuckySROptionsParent<SROptions_Player>, INotifyPropertyChanged
{
    // Properties
    public string SupportID { get; }
    public string Credits { get; }
    public string Gems { get; }
    public string Bucket { get; }
    public string Level { get; }
    public string SetLevel { get; set; }
    public string Chapter { get; }
    public string IsHacker { get; }
    public string HackerType { get; }
    public string IsTimeTraveler { get; }
    public string IsPurchaseHackUser { get; }
    public string Apples { get; }
    
    // Methods
    public static void NotifyPropertyChanged(string propertyName)
    {
        if((SuperLuckySROptionsParent<T>._Instance) == 0)
        {
                return;
        }
        
        goto typeof(T).__il2cppRuntimeField_EC;
    }
    public void Back()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        SRDebugger.Services.IDebugService val_1 = SRDebug.Instance;
        var val_6 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_2;
        }
        
        var val_5 = 0;
        label_4:
        val_5 = 0;
        val_6 = mem[mem[1179403735] + 0];
        val_6 = mem[1179403735] + 0;
        if(val_6 == null)
        {
            goto label_3;
        }
        
        val_5 = val_5 + 1;
        val_5 = (uint)val_5 & 65535;
        if(val_5 < mem[1179403825])
        {
            goto label_4;
        }
        
        label_2:
        val_7 = 0;
        goto label_5;
        label_3:
        var val_2 = mem[1179403735] + 0;
        val_6 = val_6 + (((mem[1179403735] + 0) + 4) << 3);
        val_7 = val_6 + 332;
        label_5:
        SRDebugger.Services.IDebugService val_3 = SRDebug.Instance;
        var val_7 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_7;
        }
        
        val_6 = 0;
        label_9:
        val_5 = 0;
        if((mem[1179403735] + 0) == null)
        {
            goto label_8;
        }
        
        val_6 = val_6 + 1;
        val_5 = (uint)val_6 & 65535;
        if(val_5 < mem[1179403825])
        {
            goto label_9;
        }
        
        label_7:
        val_8 = 0;
        goto label_10;
        label_8:
        var val_4 = mem[1179403735] + 0;
        val_7 = val_7 + (((mem[1179403735] + 0) + 4) << 3);
        val_8 = val_7 + 292;
        label_10:
        SuperLuckySROptionsController.OpenGameSpecificOptionsController();
    }
    private bool CreditsHackAvailable()
    {
        return true;
    }
    public string get_SupportID()
    {
        Player val_1 = App.Player;
        if(0 != 0)
        {
                return;
        }
    
    }
    public string get_Credits()
    {
        Player val_1 = App.Player;
        GameEcon val_2 = App.getGameEcon;
        string val_3 = ToString(format:  null);
    }
    public void CreditsMinus1Hint()
    {
        int val_4;
        int val_5;
        int val_6;
        int val_7;
        Player val_1 = App.Player;
        GameEcon val_2 = App.getGameEcon;
        decimal val_3 = System.Decimal.op_Subtraction(d1:  new System.Decimal() {flags = -847078900, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256, hi = 6, lo = 4, mid = 4});
        Player val_8 = App.Player;
        0.SetCredits(amount:  new System.Decimal() {flags = val_4, hi = val_5, lo = val_6, mid = val_7});
        Player val_9 = App.Player;
        0.SaveState();
        NotificationCenter val_10 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -847091056);
        CurrencyController.HandleBalanceChanged(type:  0);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -1930303344);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -847090944);
    }
    public void CreditsMinus50()
    {
        int val_6;
        int val_7;
        int val_8;
        int val_9;
        Player val_1 = App.Player;
        decimal val_2 = new System.Decimal(value:  2);
        decimal val_3 = System.Decimal.op_Division(d1:  new System.Decimal() {flags = -846966912, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {hi = val_2.flags, lo = val_2.hi, mid = val_2.lo});
        decimal val_5 = System.Math.Truncate(d:  new System.Decimal() {flags = -846966928});
        Player val_10 = App.Player;
        0.SetCredits(amount:  new System.Decimal() {flags = val_6, hi = val_7, lo = val_8, mid = val_9});
        Player val_11 = App.Player;
        0.SaveState();
        NotificationCenter val_12 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -847091056);
        CurrencyController.HandleBalanceChanged(type:  0);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -1930303344);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -847090944);
    }
    public void CreditsInitial()
    {
        Player val_1 = App.Player;
        GameEcon val_2 = App.getGameEcon;
        0.SetCredits(amount:  new System.Decimal() {flags = 2, hi = 34479860, lo = 34483956, mid = 34483956});
        Player val_3 = App.Player;
        0.SaveState();
        NotificationCenter val_4 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -847091056);
        CurrencyController.HandleBalanceChanged(type:  0);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -1930303344);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -847090944);
    }
    public void CreditsPlus50()
    {
        int val_6;
        int val_7;
        int val_8;
        int val_9;
        Player val_1 = App.Player;
        var val_13 = 0;
        val_13 = val_13 + 64;
        decimal val_2 = new System.Decimal(lo:  15, mid:  0, hi:  0, isNegative:  false, scale:  1);
        decimal val_3 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = -846742912, hi = 52, lo = mem[(0 + 64) + (0)], mid = mem[(0 + 64) + (4)]}, d2:  new System.Decimal() {flags = mem[(0 + 64) + (8)], hi = val_2.flags, lo = val_2.hi, mid = val_2.lo});
        decimal val_5 = System.Math.Truncate(d:  new System.Decimal() {flags = -846742928});
        Player val_10 = App.Player;
        0.SetCredits(amount:  new System.Decimal() {flags = val_6, hi = val_7, lo = val_8, mid = val_9});
        Player val_11 = App.Player;
        0.SaveState();
        NotificationCenter val_12 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -847091056);
        CurrencyController.HandleBalanceChanged(type:  0);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -1930303344);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -847090944);
    }
    public void CreditsPlus1Hint()
    {
        int val_4;
        int val_5;
        int val_6;
        int val_7;
        Player val_1 = App.Player;
        GameEcon val_2 = App.getGameEcon;
        decimal val_3 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -846630900, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256, hi = 6, lo = 4, mid = 4});
        Player val_8 = App.Player;
        0.SetCredits(amount:  new System.Decimal() {flags = val_4, hi = val_5, lo = val_6, mid = val_7});
        Player val_9 = App.Player;
        0.SaveState();
        NotificationCenter val_10 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -847091056);
        CurrencyController.HandleBalanceChanged(type:  0);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -1930303344);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -847090944);
    }
    public void CreditsPlus10Hint()
    {
        int val_6;
        int val_7;
        int val_8;
        int val_9;
        Player val_1 = App.Player;
        GameEcon val_2 = App.getGameEcon;
        decimal val_3 = new System.Decimal(value:  10);
        decimal val_4 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = -846518920, hi = 6, lo = 4, mid = 4}, d2:  new System.Decimal() {hi = val_3.flags, lo = val_3.hi, mid = val_3.lo});
        decimal val_5 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -846518936, hi = 52, lo = 52, mid = 256}, d2:  new System.Decimal() {flags = 256});
        Player val_10 = App.Player;
        0.SetCredits(amount:  new System.Decimal() {flags = val_6, hi = val_7, lo = val_8, mid = val_9});
        Player val_11 = App.Player;
        0.SaveState();
        NotificationCenter val_12 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -847091056);
        CurrencyController.HandleBalanceChanged(type:  0);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -1930303344);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -847090944);
    }
    public string get_Gems()
    {
        Player val_1 = App.Player;
        GameEcon val_2 = App.getGameEcon;
        string val_3 = 0.ToString(format:  null);
    }
    public void GemPlus10()
    {
        Player val_1 = App.Player;
        0.AddGems(amount:  10, source:  -1927262672, subsource:  null);
        Player val_2 = App.Player;
        0.SaveState();
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -847091056);
        CurrencyController.HandleBalanceChanged(type:  1);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -1668821072);
    }
    public void GemPlus100()
    {
        Player val_1 = App.Player;
        0.AddGems(amount:  100, source:  -1927262672, subsource:  null);
        Player val_2 = App.Player;
        0.SaveState();
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -847091056);
        CurrencyController.HandleBalanceChanged(type:  1);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -1668821072);
    }
    public void GemPlus10000()
    {
        Player val_1 = App.Player;
        0.AddGems(amount:  10000, source:  -1927262672, subsource:  null);
        Player val_2 = App.Player;
        0.SaveState();
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -847091056);
        CurrencyController.HandleBalanceChanged(type:  1);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -1668821072);
    }
    public void GemMinus100()
    {
        int val_6;
        Player val_1 = App.Player;
        val_6 = 99;
        if(0 <= 99)
        {
                Player val_2 = App.Player;
            val_6 = 0 - 0;
        }
        
        Player val_3 = App.Player;
        0.AddGems(amount:  val_6, source:  -1927262672, subsource:  null);
        Player val_4 = App.Player;
        0.SaveState();
        NotificationCenter val_5 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -847091056);
        CurrencyController.HandleBalanceChanged(type:  1);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -1668821072);
    }
    public void GemMinus1000()
    {
        Player val_1 = App.Player;
        if(0 < 1000)
        {
                Player val_2 = App.Player;
        }
        
        Player val_3 = App.Player;
        0.AddGems(amount:  -1000, source:  -1927262672, subsource:  null);
        Player val_4 = App.Player;
        0.SaveState();
        NotificationCenter val_5 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -847091056);
        CurrencyController.HandleBalanceChanged(type:  1);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -1668821072);
    }
    public string get_Bucket()
    {
        Player val_1 = App.Player;
        if(0 != 0)
        {
                return;
        }
    
    }
    public void SetBucketA()
    {
        var val_9;
        Player val_1 = App.Player;
        mem[120] = "A";
        SROptions_Player.NotifyPropertyChanged(propertyName:  -1988577776);
        GameBehavior val_2 = App.getBehavior;
        if(0 != 0)
        {
                val_9 = 1152921512351146720;
        }
        else
        {
                val_9 = 1152921512351147744;
        }
        
        if((MonoSingletonSelfGenerating<WordLevelGen>.InstanceExists) == false)
        {
                return;
        }
        
        GameBehavior val_4 = App.getBehavior;
        if(0 != 0)
        {
                WordPets.WPTDataParser val_5 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            ReInitialize();
        }
        else
        {
                WordPets.WPTDataParser val_6 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            ReInitialize();
        }
        
        if(SceneDictator.IsInGameScene() == false)
        {
                return;
        }
        
        GameBehavior val_8 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public void SetBucketB()
    {
        var val_9;
        Player val_1 = App.Player;
        mem[120] = "B";
        SROptions_Player.NotifyPropertyChanged(propertyName:  -1988577776);
        GameBehavior val_2 = App.getBehavior;
        if(0 != 0)
        {
                val_9 = 1152921512351146720;
        }
        else
        {
                val_9 = 1152921512351147744;
        }
        
        if((MonoSingletonSelfGenerating<WordLevelGen>.InstanceExists) == false)
        {
                return;
        }
        
        GameBehavior val_4 = App.getBehavior;
        if(0 != 0)
        {
                WordPets.WPTDataParser val_5 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            ReInitialize();
        }
        else
        {
                WordPets.WPTDataParser val_6 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            ReInitialize();
        }
        
        if(SceneDictator.IsInGameScene() == false)
        {
                return;
        }
        
        GameBehavior val_8 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public string get_Level()
    {
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.ToString();
    }
    public void PlayerLevelUp1()
    {
        GameBehavior val_1 = App.getBehavior;
        this.SetPlayerLevel(level:  1);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HackAddLevels(levelsHacked:  1);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -1987496192);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -847090944);
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -2037002944);
    }
    public void PlayerLevelUp10()
    {
        GameBehavior val_1 = App.getBehavior;
        this.SetPlayerLevel(level:  10);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HackAddLevels(levelsHacked:  10);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -1987496192);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -847090944);
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -2037002944);
    }
    public void PlayerLevelUp100()
    {
        GameBehavior val_1 = App.getBehavior;
        this.SetPlayerLevel(level:  100);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HackAddLevels(levelsHacked:  100);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -1987496192);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -847090944);
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -2037002944);
    }
    public void PlayerLevelDown1()
    {
        GameBehavior val_1 = App.getBehavior;
        this.SetPlayerLevel(level:  -1);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HackAddLevels(levelsHacked:  0);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -1987496192);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -847090944);
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -2037002944);
    }
    public void PlayerLevelDown10()
    {
        GameBehavior val_1 = App.getBehavior;
        this.SetPlayerLevel(level:  -10);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HackAddLevels(levelsHacked:  9);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -1987496192);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -847090944);
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -2037002944);
    }
    public void GrantAllExtraWords()
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((-2101079008) != 0)
        {
                WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            CompleteChallenge(id:  0);
            return;
        }
        
        GameEcon val_4 = App.getGameEcon;
        Prefs.extraProgress = 0.ExtraWordsTarget;
    }
    public void PlayerLevelDown100()
    {
        GameBehavior val_1 = App.getBehavior;
        this.SetPlayerLevel(level:  -100);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HackAddLevels(levelsHacked:  99);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -1987496192);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -847090944);
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -2037002944);
    }
    public void set_SetLevel(string value)
    {
        GameBehavior val_1 = App.getBehavior;
        if((System.Int32.TryParse(s:  value, result: out  int val_2 = -844496620)) == false)
        {
                return;
        }
        
        GameBehavior val_4 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        this.SetPlayerLevel(level:  0);
        string val_5 = -844508704(-844508704) + 13152256;
        DebugMessageDisplay.DisplayMessage(msgTxt:  -844508704, displayTime:  null);
        var val_7 = 21713883;
        val_7 = 13911904 + val_7;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        SROptions_Player.NotifyPropertyChanged(propertyName:  -1987496192);
        NotificationCenter val_6 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -2037002944);
    }
    public string get_SetLevel()
    {
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.ToString();
    }
    public string get_Chapter()
    {
        GameBehavior val_1 = App.getBehavior;
        if(2621443 == 0)
        {
            
        }
    
    }
    public void ResetPlayer()
    {
        this.ResetDailyChallenge();
        GameBehavior val_1 = App.getBehavior;
        UnityEngine.PlayerPrefs.DeleteAll();
        string val_2 = UnityEngine.Application.persistentDataPath;
        string val_3 = null + -844168496(-844168496);
        if((new System.IO.DirectoryInfo(path:  null)) != 0)
        {
                Delete(recursive:  true);
        }
        
        string val_5 = UnityEngine.Application.persistentDataPath;
        string val_6 = null + -844168400(-844168400);
        if((new System.IO.DirectoryInfo(path:  null)) != 0)
        {
                Delete(recursive:  true);
        }
        
        Player val_8 = App.Player;
        0.HardReset();
        WGBonusRewardsHandler val_9 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        RequestDataFlush(immediate:  false, reset:  true);
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        StartExitApp(waitSeconds:  3);
    }
    private void ResetDailyChallenge()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2116505760) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Hack_ResetDailyChallenge();
    }
    private void SetPlayerLevel(int level)
    {
        if(level <= 1)
        {
                level = 1;
        }
        
        GameBehavior val_1 = App.getBehavior;
        GameBehavior val_2 = App.getBehavior;
        Player val_3 = App.Player;
        0.SaveState();
        NotificationCenter val_4 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -843944304);
        NotificationCenter val_5 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -2037002944);
    }
    public string get_IsHacker()
    {
        Player val_1 = App.Player;
        string val_2 = 0.ToString();
    }
    public string get_HackerType()
    {
        Player val_1 = App.Player;
        if(0 != 0)
        {
                return;
        }
    
    }
    public string get_IsTimeTraveler()
    {
        var val_11;
        System.DateTime val_1 = System.DateTime.UtcNow;
        System.DateTime val_4 = ServerHandler.ServerTime;
        System.TimeSpan val_7 = Subtract(value:  new System.DateTime() {dateData = 1152921512353185336});
        System.TimeSpan val_10 = Duration();
        double val_13 = val_11.TotalHours;
        if(ServerHandler.__il2cppRuntimeField_cctor_finished > 0)
        {
                0 = 1;
        }
        
        string val_14 = 1.ToString();
    }
    public string get_IsPurchaseHackUser()
    {
        Player val_1 = App.Player;
        string val_2 = static_value_00280020.ToString();
    }
    public string get_Apples()
    {
        Player val_1 = App.Player;
        string val_2 = 4.ToString();
    }
    public void Credit10Apples()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-843272208) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            AwardStar(earnedAmount:  10, source:  -843271184, subSource:  null, additionalParam:  0);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2092883744) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        }
        
        NotificationCenter val_7 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -843271104);
        SLC.Social.Leagues.LeaguesManager.ContributePointsFromWinnings(goldenCurrencyWinnings:  10, machineName:  -843271184, applyLTO:  true, bypassCaching:  false);
        WordPets.WPTDataParser val_8 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((-2101079008) != 0)
        {
                WordPets.WPTDataParser val_10 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            OnSecondaryCurrencyGained(numGained:  10);
        }
        
        Player val_11 = App.Player;
        0.SaveState();
        NotificationCenter val_12 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -2092882624);
        CurrencyController.HandleBalanceChanged(type:  2);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -843271008);
    }
    public void Credit100Apples()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-843272208) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            AwardStar(earnedAmount:  100, source:  -843271184, subSource:  null, additionalParam:  0);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2092883744) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        }
        
        NotificationCenter val_7 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -843271104);
        SLC.Social.Leagues.LeaguesManager.ContributePointsFromWinnings(goldenCurrencyWinnings:  100, machineName:  -843271184, applyLTO:  true, bypassCaching:  false);
        WordPets.WPTDataParser val_8 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((-2101079008) != 0)
        {
                WordPets.WPTDataParser val_10 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            OnSecondaryCurrencyGained(numGained:  100);
        }
        
        Player val_11 = App.Player;
        0.SaveState();
        NotificationCenter val_12 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -2092882624);
        CurrencyController.HandleBalanceChanged(type:  2);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -843271008);
    }
    public void DoubleApples()
    {
        Player val_1 = App.Player;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-843272208) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            AwardStar(earnedAmount:  4, source:  -843271184, subSource:  null, additionalParam:  0);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2092883744) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        }
        
        NotificationCenter val_8 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -843271104);
        SLC.Social.Leagues.LeaguesManager.ContributePointsFromWinnings(goldenCurrencyWinnings:  4, machineName:  -843271184, applyLTO:  true, bypassCaching:  false);
        WordPets.WPTDataParser val_9 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((-2101079008) != 0)
        {
                WordPets.WPTDataParser val_11 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            OnSecondaryCurrencyGained(numGained:  4);
        }
        
        Player val_12 = App.Player;
        0.SaveState();
        NotificationCenter val_13 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -2092882624);
        CurrencyController.HandleBalanceChanged(type:  2);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -843271008);
    }
    public void HalfApples()
    {
        Player val_1 = App.Player;
        int val_14 = 4;
        val_14 = 1 - val_14;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_14 = val_14 >> 1;
        if((-843272208) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            AwardStar(earnedAmount:  val_14, source:  -843271184, subSource:  null, additionalParam:  0);
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2092883744) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        }
        
        NotificationCenter val_8 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -843271104);
        SLC.Social.Leagues.LeaguesManager.ContributePointsFromWinnings(goldenCurrencyWinnings:  val_14, machineName:  -843271184, applyLTO:  true, bypassCaching:  false);
        WordPets.WPTDataParser val_9 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((-2101079008) != 0)
        {
                WordPets.WPTDataParser val_11 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            OnSecondaryCurrencyGained(numGained:  val_14);
        }
        
        Player val_12 = App.Player;
        0.SaveState();
        NotificationCenter val_13 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -2092882624);
        CurrencyController.HandleBalanceChanged(type:  2);
        SROptions_Player.NotifyPropertyChanged(propertyName:  -843271008);
    }
    public SROptions_Player()
    {
    
    }

}
