using UnityEngine;
public class SROptions_Ads : SuperLuckySROptionsParent<SROptions_Ads>, INotifyPropertyChanged
{
    // Properties
    public string NoAdsCooldown { get; }
    public string GetHackedVideos { get; }
    public string AdSegment { get; }
    public string NetworkPurchaser { get; }
    
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
    public string get_NoAdsCooldown()
    {
        long val_5;
        long val_12;
        long val_14;
        var val_18;
        long val_20;
        var val_21;
        var val_22;
        var val_23;
        long val_25;
        var val_26;
        val_18 = null;
        val_18 = null;
        System.DateTime val_1 = AdsManager.LastPurchaseCooldownEnd;
        System.DateTime val_2 = ServerHandler.ServerTime;
        System.TimeSpan val_3 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512289637840}, d2:  new System.DateTime());
        val_20 = val_5;
        val_21 = null;
        if((System.TimeSpan.op_LessThan(t1:  new System.TimeSpan() {_ticks = val_20}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) != false)
        {
                val_21 = null;
            val_22 = 1152921504622821376;
            val_23 = 1152921504895397888;
            val_20 = System.TimeSpan.Zero;
        }
        else
        {
                val_22 = 1152921504622821376;
            val_23 = 1152921504895397888;
        }
        
        System.TimeSpan val_7 = System.TimeSpan.op_Addition(t1:  new System.TimeSpan() {_ticks = 1152921512289637856}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero});
        System.DateTime val_8 = AdsManager.AdsCooldownEnd;
        System.DateTime val_9 = ServerHandler.ServerTime;
        System.TimeSpan val_10 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512289637832}, d2:  new System.DateTime());
        val_25 = val_12;
        val_26 = null;
        if((System.TimeSpan.op_LessThan(t1:  new System.TimeSpan() {_ticks = val_25}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) != false)
        {
                val_26 = null;
            val_25 = System.TimeSpan.Zero;
        }
        
        System.TimeSpan val_16 = System.TimeSpan.op_Addition(t1:  new System.TimeSpan() {_ticks = 1152921512289637856}, t2:  new System.TimeSpan() {_ticks = val_14});
        string val_17 = GenericStringExtentions.ToString(span:  new System.TimeSpan() {_ticks = val_14}, formatted:  true);
    }
    public void ResetAds()
    {
        Player val_1 = App.Player;
        mem[196] = 0;
        Player val_2 = App.Player;
        System.DateTime val_3 = ServerHandler.ServerTime;
        WordPets.WPTDataParser val_6 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.DateTime val_7 = ServerHandler.ServerTime;
        AdsWatchedCooldownEnd = new System.DateTime();
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  2124183120)) == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ShowOrHideBanner();
    }
    public void HideAds()
    {
        Player val_1 = App.Player;
        mem[196] = 1065353216;
        Player val_2 = App.Player;
        System.DateTime val_3 = ServerHandler.ServerTime;
        System.TimeSpan val_6 = System.TimeSpan.FromDays(value:  null);
        System.DateTime val_9 = Add(value:  new System.TimeSpan() {_ticks = 1152921512289861872});
        WordPets.WPTDataParser val_12 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.DateTime val_13 = ServerHandler.ServerTime;
        System.TimeSpan val_16 = System.TimeSpan.FromDays(value:  null);
        System.DateTime val_19 = Add(value:  new System.TimeSpan() {_ticks = 1152921512289861872});
        AdsWatchedCooldownEnd = new System.DateTime() {dateData = 1152921512289861872};
        twelvegigs.Autopilot.AutopilotManager val_22 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  2124183120)) == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_24 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ShowOrHideBanner();
    }
    public void ResetNoAdsCooldown()
    {
        if(AdsManager.isInPurchaseCooldown == false)
        {
                return;
        }
        
        Player val_2 = App.Player;
        System.DateTime val_3 = ServerHandler.ServerTime;
        System.DateTime val_6 = AddMinutes(value:  null);
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  2124183120)) == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ShowOrHideBanner();
    }
    public void ResetNoAdsVideo()
    {
        if(AdsManager.isInVideoCooldown == false)
        {
                return;
        }
        
        WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        HackResetAdsWatchedCoolDown();
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  2124183120)) == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ShowOrHideBanner();
    }
    public void NoAdsAvailable()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1745532016) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Hack_NoVideoAdsAvailable();
    }
    public void ShowMediationTestSuite()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1745532016) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ShowAdMediationSuite();
    }
    public string get_GetHackedVideos()
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        string val_3 = HackAdsWatchedToday(increment:  0).ToString();
        WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        string val_5 = public static AdsManager MonoSingletonSelfGenerating<AdsManager>::get_Instance().__il2cppRuntimeField_3C.ToString();
        string val_6 = System.String.Format(format:  1629069648, arg0:  -906359684, arg1:  -906359684);
    }
    public void AddFiveHackedVideos()
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        int val_2 = HackAdsWatchedToday(increment:  5);
        SROptions_Ads.NotifyPropertyChanged(propertyName:  -906259664);
    }
    public void AddMinusFourHackedVideos()
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        int val_2 = HackAdsWatchedToday(increment:  3);
        SROptions_Ads.NotifyPropertyChanged(propertyName:  -906259664);
    }
    public string get_AdSegment()
    {
        return AdSegmentation.Segment;
    }
    public string get_NetworkPurchaser()
    {
        Player val_1 = App.Player;
        if(0 != 0)
        {
                return;
        }
    
    }
    public void AdsHighval()
    {
        Player val_1 = App.Player;
        SROptions_Ads.NotifyPropertyChanged(propertyName:  -905811472);
        WGBonusRewardsHandler val_2 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        RequestDataFlush(immediate:  false, reset:  false);
    }
    public void AdsMediumval()
    {
        Player val_1 = App.Player;
        SROptions_Ads.NotifyPropertyChanged(propertyName:  -905811472);
        WGBonusRewardsHandler val_2 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        RequestDataFlush(immediate:  false, reset:  false);
    }
    public void AdsLowval()
    {
        Player val_1 = App.Player;
        SROptions_Ads.NotifyPropertyChanged(propertyName:  -905811472);
        WGBonusRewardsHandler val_2 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        RequestDataFlush(immediate:  false, reset:  false);
    }
    public void AdsOrganic()
    {
        Player val_1 = App.Player;
        SROptions_Ads.NotifyPropertyChanged(propertyName:  -905811472);
        WGBonusRewardsHandler val_2 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        RequestDataFlush(immediate:  false, reset:  false);
    }
    public SROptions_Ads()
    {
    
    }

}
