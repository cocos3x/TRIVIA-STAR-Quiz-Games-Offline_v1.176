using UnityEngine;
public class SROptions_General : SuperLuckySROptionsParent<SROptions_General>, INotifyPropertyChanged
{
    // Properties
    public bool Tracking { get; set; }
    public bool SlowInternet { get; set; }
    public string SetLevel { get; set; }
    public string SetDeeplink { get; set; }
    
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
    public bool get_Tracking()
    {
        null = null;
        return (bool)CompanyDevices.TrackingAllowed;
    }
    public void set_Tracking(bool value)
    {
        CompanyDevices.SwitchDevice();
        SROptions_General.NotifyPropertyChanged(propertyName:  -858751360);
    }
    public void CRASH()
    {
        DebugMessageDisplay.DisplayMessage(msgTxt:  -858639264, displayTime:  null);
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        StartBloatTheMemory();
    }
    public void SendAllLocalNotifications()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        StartSendingAllNofis();
    }
    public void SendRemoteNotification()
    {
        var val_7;
        var val_8;
        float val_7 = 3.743967E-38f;
        val_7 = 13878528 + val_7;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_7 = null;
        val_7 = null;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  2112633200, value:  -1821882608);
        Player val_2 = App.Player;
        Add(key:  1618311216, value:  1835037);
        System.Action<System.Threading.Tasks.Task, System.Object> val_3 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -858390000, method:  new IntPtr(3436552128));
        App.networkManager.DoPost(path:  -858414144, postBody:  78753792, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false, serverType:  0);
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_8 = null;
        val_8 = null;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  2112633200, value:  -1821882608);
        Player val_5 = App.Player;
        Add(key:  -1931156816, value:  52);
        System.Action<System.Threading.Tasks.Task, System.Object> val_6 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -858390000, method:  new IntPtr(3436552128));
        App.networkManager.DoPost(path:  -858414144, postBody:  78753792, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false, serverType:  1);
    }
    public void LPNsLogHUD()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Func<TRVQuizProgress> val_2 = new System.Func<TRVQuizProgress>(object:  -902550112, method:  new IntPtr(3436665296));
        SLCHUDWindow.SetupHUD(name:  -858300976, callbackfunc:  7667712);
    }
    public bool get_SlowInternet()
    {
        null = null;
        return (bool)NetworkThreadingHandler.HackThrottle;
    }
    public void set_SlowInternet(bool value)
    {
        null = null;
        NetworkThreadingHandler.HackThrottle = value;
    }
    private void handleResponse(string method, System.Collections.Generic.Dictionary<string, object> data)
    {
        if(data != 0)
        {
                if((data.ContainsKey(key:  1616271776)) != false)
        {
                object val_2 = data.Item[1616271776];
            data.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if(null != 0)
        {
                return;
        }
        
        }
        
        }
        
        UnityEngine.Debug.LogWarning(message:  -857956688);
    }
    public void set_SetLevel(string value)
    {
        var val_2;
        var val_3;
        var val_4;
        val_2 = 13880248 + 21745539;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        if(App.game != 1)
        {
                return;
        }
        
        string val_1 = -857832256(-857832256) + value;
        DebugMessageDisplay.DisplayMessage(msgTxt:  -857832256, displayTime:  null);
        val_2 = 13880424 + 21760502;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        WADataParser.QAhackedWord = value;
    }
    public string get_SetLevel()
    {
        var val_1;
        var val_2;
        var val_3;
        var val_1 = 21745143;
        val_1 = 13880644 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        if(App.game == 1)
        {
                var val_2 = 21755974;
            val_2 = 13880780 + val_2;
            if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
            val_2 = null;
            val_2 = null;
            val_3 = 1152921504991141920;
            return;
        }
        
        val_3 = "";
    }
    public void set_SetDeeplink(string value)
    {
        null = null;
        DeeplinkComponent.HACK_actionString = value;
    }
    public string get_SetDeeplink()
    {
        null = null;
    }
    public void HackCreditsAward()
    {
        decimal val_1 = new System.Decimal(value:  200);
        float val_2 = UnityEngine.Random.value;
        string val_3 = 0.ToString();
        WGBonusRewardsHandler val_4 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        HackAGoddamnAward(awerd:  new Award() {id = -857359896, kind = 2129282688, amount = new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.flags}});
    }
    public void HackGemsAward()
    {
        decimal val_1 = new System.Decimal(value:  200);
        float val_2 = UnityEngine.Random.value;
        string val_3 = 0.ToString();
        WGBonusRewardsHandler val_4 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        HackAGoddamnAward(awerd:  new Award() {id = -857247896, kind = -1930648496, amount = new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.flags}});
    }
    public void HackLevelAward()
    {
        decimal val_1 = new System.Decimal(value:  200);
        float val_2 = UnityEngine.Random.value;
        string val_3 = 0.ToString();
        WGBonusRewardsHandler val_4 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        HackAGoddamnAward(awerd:  new Award() {id = -857135896, kind = -1988561632, amount = new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.flags}});
    }
    public void HackNoAdsAward()
    {
        decimal val_1 = new System.Decimal(value:  200);
        float val_2 = UnityEngine.Random.value;
        string val_3 = 0.ToString();
        WGBonusRewardsHandler val_4 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        HackAGoddamnAward(awerd:  new Award() {id = -857023896, kind = -1953369568, amount = new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.flags}});
    }
    public void HackPetsFoodAward()
    {
        decimal val_1 = new System.Decimal(value:  20);
        float val_2 = UnityEngine.Random.value;
        string val_3 = 0.ToString();
        WGBonusRewardsHandler val_4 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        HackAGoddamnAward(awerd:  new Award() {id = -856911896, kind = -1827757824, amount = new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.flags}});
    }
    public SROptions_General()
    {
    
    }

}
