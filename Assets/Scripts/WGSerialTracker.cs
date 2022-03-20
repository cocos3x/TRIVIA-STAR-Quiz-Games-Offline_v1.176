using UnityEngine;
public class WGSerialTracker : MonoSingleton<WGSerialTracker>
{
    // Fields
    private bool initialized;
    private string prefkeyBalance;
    private string prefkeyLoginFirst;
    private string prefkeyLoginStart;
    private string prefkeyLoginNext;
    public decimal recordWinAmount;
    public decimal recordCreditBalance;
    public System.DateTime loginStreakFirst;
    public System.DateTime loginStreakStart;
    public System.DateTime loginStreakNext;
    
    // Properties
    public bool Initialized { get; }
    
    // Methods
    public bool get_Initialized()
    {
        return (bool)this.initialized;
    }
    public override void InitMonoSingleton()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  46819824, name:  -2037002944);
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_2 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  46819824, method:  new IntPtr(46794800));
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  162459648);
        this.init();
    }
    private void OnApplicationPause(bool paused)
    {
        if(paused == true)
        {
                return;
        }
        
        this.storeData();
    }
    private void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
    {
        this.storeData();
    }
    private void init()
    {
        System.DateTime val_11;
        var val_20;
        if(this.initialized == true)
        {
                return;
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  this.prefkeyBalance)) != false)
        {
                string val_2 = UnityEngine.PlayerPrefs.GetString(key:  this.prefkeyBalance);
            decimal val_3 = System.Decimal.Parse(s:  47184736);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  this.prefkeyLoginFirst)) != false)
        {
                val_20 = 0;
            string val_5 = UnityEngine.PlayerPrefs.GetString(key:  this.prefkeyLoginFirst);
            System.DateTime val_6 = System.DateTime.UtcNow;
            System.DateTime val_9 = SLCDateTime.Parse(dateTime:  47184728, defaultValue:  new System.DateTime() {dateData = this.prefkeyLoginFirst});
            this.loginStreakFirst = val_11;
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  this.prefkeyLoginStart)) != false)
        {
                val_20 = 0;
            string val_13 = UnityEngine.PlayerPrefs.GetString(key:  this.prefkeyLoginStart);
            System.DateTime val_14 = System.DateTime.UtcNow;
            System.DateTime val_15 = SLCDateTime.Parse(dateTime:  47184728, defaultValue:  new System.DateTime() {dateData = this.prefkeyLoginStart});
            this.loginStreakStart = val_11;
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  this.prefkeyLoginNext)) != false)
        {
                val_20 = 0;
            string val_17 = UnityEngine.PlayerPrefs.GetString(key:  this.prefkeyLoginNext);
            System.DateTime val_18 = System.DateTime.UtcNow;
            System.DateTime val_19 = SLCDateTime.Parse(dateTime:  47184728, defaultValue:  new System.DateTime() {dateData = this.prefkeyLoginNext});
            this.loginStreakNext = val_11;
        }
        
        this.initialized = true;
    }
    public void resetData()
    {
        UnityEngine.PlayerPrefs.DeleteKey(key:  this.prefkeyBalance);
        UnityEngine.PlayerPrefs.DeleteKey(key:  this.prefkeyLoginFirst);
        UnityEngine.PlayerPrefs.DeleteKey(key:  this.prefkeyLoginStart);
        UnityEngine.PlayerPrefs.DeleteKey(key:  this.prefkeyLoginNext);
        this.initialized = false;
        this.init();
    }
    public void storeData()
    {
        if(this.initialized == false)
        {
                return;
        }
        
        string val_1 = this.recordCreditBalance.ToString();
        UnityEngine.PlayerPrefs.SetString(key:  this.prefkeyBalance, value:  this.recordCreditBalance);
        string val_2 = this.loginStreakFirst.ToString();
        UnityEngine.PlayerPrefs.SetString(key:  this.prefkeyLoginFirst, value:  this.loginStreakFirst);
        string val_3 = this.loginStreakStart.ToString();
        UnityEngine.PlayerPrefs.SetString(key:  this.prefkeyLoginStart, value:  this.loginStreakStart);
        string val_4 = this.loginStreakNext.ToString();
        UnityEngine.PlayerPrefs.SetString(key:  this.prefkeyLoginNext, value:  this.loginStreakNext);
    }
    public void OnDeferredReady()
    {
        if(this.initialized == false)
        {
                return;
        }
        
        this.PlayerReturned();
    }
    public void PlayerReturned()
    {
        System.DateTime val_2;
        var val_3;
        var val_5;
        var val_6;
        var val_14;
        var val_25;
        System.DateTime val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_62;
        var val_63;
        var val_64;
        var val_65;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        System.TimeSpan val_4 = Subtract(value:  new System.DateTime() {dateData = 1152921513244513104});
        System.DateTime val_8 = DateTimeCheat.UtcNow;
        this.loginStreakStart = val_2;
        mem[1152921513244525228] = val_3;
        System.DateTime val_9 = AddDays(value:  val_5.TotalDays);
        val_38 = val_5;
        val_39 = val_6;
        this.loginStreakNext = ;
        Player val_11 = App.Player;
        System.DateTime val_12 = DateTimeCheat.UtcNow;
        System.TimeSpan val_13 = Subtract(value:  new System.DateTime() {dateData = 1152921513244513104});
        double val_16 = val_14.TotalDays;
        val_40 = val_2;
        val_41 = 0;
        double val_17 = val_40 + (-1);
        if(( & 1) != 0)
        {
                 = ;
        }
        
        System.DateTime val_21 = DateTimeCheat.UtcNow;
        System.TimeSpan val_24 = Subtract(value:  new System.DateTime() {dateData = 1152921513244513104});
        double val_27 = val_25.TotalDays;
        if(0 >= 0)
        {
            goto label_21;
        }
        
        if(0 != 0)
        {
            goto label_22;
        }
        
        val_43 = val_2;
        val_44 = 0;
        double val_28 = val_43 + (-1);
        goto label_23;
        label_21:
        if(0 != 0)
        {
            goto label_24;
        }
        
        val_43 = val_2;
        val_44 = 0;
        label_23:
        if((val_44 & 1) != 0)
        {
                val_43 + 1 = val_43;
        }
        
        goto label_25;
        label_22:
        double val_30 = 47731528 + (-0.5);
        val_45 = 0;
        goto label_26;
        label_24:
        double val_31 = 47731528 + 0.5;
        val_45 = 0;
        label_26:
        label_25:
        bool val_32 = UnityEngine.PlayerPrefs.HasKey(key:  47719088);
        if(val_32 != true)
        {
                if(val_32 != true)
        {
                var val_38 = 28623074;
            val_38 = 7002464 + val_38;
            if(val_38 == 0)
        {
                mem2[0] = 1;
        }
        
            val_46 = null;
            val_46 = null;
            val_47 = null;
            val_47 = null;
            App.trackerManager.track(eventName:  Events.RETENTION_D1);
        }
        
            UnityEngine.PlayerPrefs.SetInt(key:  47719088, value:  1);
        }
        
        bool val_33 = UnityEngine.PlayerPrefs.HasKey(key:  47719168);
        if(val_33 != true)
        {
                if(val_33 != true)
        {
                var val_39 = 28622802;
            val_39 = 7002736 + val_39;
            if(val_39 == 0)
        {
                mem2[0] = 1;
        }
        
            val_48 = null;
            val_48 = null;
            val_49 = null;
            val_49 = null;
            App.trackerManager.track(eventName:  Events.RETENTION_D2_CONSECUTIVE);
        }
        
            var val_40 = 28622598;
            val_40 = 7002940 + val_40;
            if(val_40 == 0)
        {
                mem2[0] = 1;
        }
        
            val_50 = null;
            val_50 = null;
            val_51 = null;
            val_51 = null;
            App.trackerManager.track(eventName:  Events.RETENTION_D2);
            UnityEngine.PlayerPrefs.SetInt(key:  47719168, value:  1);
        }
        
        bool val_34 = UnityEngine.PlayerPrefs.HasKey(key:  47719248);
        if(val_34 != true)
        {
                if(val_34 != true)
        {
                var val_41 = 28622326;
            val_41 = 7003212 + val_41;
            if(val_41 == 0)
        {
                mem2[0] = 1;
        }
        
            val_52 = null;
            val_52 = null;
            val_53 = null;
            val_53 = null;
            App.trackerManager.track(eventName:  Events.RETENTION_D3_CONSECUTIVE);
        }
        
            var val_42 = 28622122;
            val_42 = 7003416 + val_42;
            if(val_42 == 0)
        {
                mem2[0] = 1;
        }
        
            val_54 = null;
            val_54 = null;
            val_55 = null;
            val_55 = null;
            App.trackerManager.track(eventName:  Events.RETENTION_D3);
            UnityEngine.PlayerPrefs.SetInt(key:  47719248, value:  1);
        }
        
        bool val_35 = UnityEngine.PlayerPrefs.HasKey(key:  47719328);
        if(val_35 != true)
        {
                if(val_35 != true)
        {
                var val_43 = 28621850;
            val_43 = 7003688 + val_43;
            if(val_43 == 0)
        {
                mem2[0] = 1;
        }
        
            val_56 = null;
            val_56 = null;
            val_57 = null;
            val_57 = null;
            App.trackerManager.track(eventName:  Events.RETENTION_D6_CONSECUTIVE);
        }
        
            var val_44 = 28621646;
            val_44 = 7003892 + val_44;
            if(val_44 == 0)
        {
                mem2[0] = 1;
        }
        
            val_58 = null;
            val_58 = null;
            val_59 = null;
            val_59 = null;
            App.trackerManager.track(eventName:  Events.RETENTION_D6);
            UnityEngine.PlayerPrefs.SetInt(key:  47719328, value:  1);
        }
        
        bool val_36 = UnityEngine.PlayerPrefs.HasKey(key:  47719408);
        if(val_36 != true)
        {
                if(val_36 != true)
        {
                var val_45 = 28621374;
            val_45 = 7004164 + val_45;
            if(val_45 == 0)
        {
                mem2[0] = 1;
        }
        
            val_60 = null;
            val_60 = null;
            val_61 = null;
            val_61 = null;
            App.trackerManager.track(eventName:  Events.RETENTION_D7_CONSECUTIVE);
        }
        
            var val_46 = 28621170;
            val_46 = 7004368 + val_46;
            if(val_46 == 0)
        {
                mem2[0] = 1;
        }
        
            val_62 = null;
            val_62 = null;
            val_63 = null;
            val_63 = null;
            App.trackerManager.track(eventName:  Events.RETENTION_D7);
            UnityEngine.PlayerPrefs.SetInt(key:  47719408, value:  1);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  47719488)) != true)
        {
                var val_47 = 28620910;
            val_47 = 7004628 + val_47;
            if(val_47 == 0)
        {
                mem2[0] = 1;
        }
        
            val_64 = null;
            val_64 = null;
            val_65 = null;
            val_65 = null;
            App.trackerManager.track(eventName:  Events.RETENTION_D30);
            UnityEngine.PlayerPrefs.SetInt(key:  47719488, value:  1);
        }
        
        PurchaseAndRetention();
        PlayerLevelAndRetention();
        AdsAndRetention();
    }
    public void debugLoginDayAdvance()
    {
        System.DateTime val_3;
        System.DateTime val_6;
        System.DateTime val_1 = AddDays(value:  null);
        this.loginStreakStart = val_3;
        System.DateTime val_4 = AddDays(value:  null);
        this.loginStreakNext = val_6;
    }
    public void PurchaseTrackHour()
    {
        var val_6;
        Player val_1 = App.Player;
        if(188 > 1)
        {
                return;
        }
        
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        System.TimeSpan val_5 = Subtract(value:  new System.DateTime() {dateData = 1152921513244737128});
        double val_8 = val_6.TotalHours;
    }
    public void PurchaseAndRetention()
    {
        var val_6;
        var val_9;
        var val_23;
        double val_24;
        var val_26;
        var val_27;
        var val_28;
        TrackerManager val_29;
        string val_30;
        Player val_1 = App.Player;
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        System.TimeSpan val_5 = Subtract(value:  new System.DateTime() {dateData = 1152921513244849496});
        double val_8 = val_6.TotalDays;
        val_23 = val_9;
        val_24 = -1;
        if((0 & 1) != 0)
        {
                 +  = ;
        }
        
        Player val_13 = App.Player;
        if(188 < 10)
        {
                return;
        }
        
        val_26 = "pur_ret_1007";
        if((UnityEngine.PlayerPrefs.HasKey(key:  48055584)) == true)
        {
                return;
        }
        
        var val_23 = 28619934;
        val_23 = 7005604 + val_23;
        if(val_23 == 0)
        {
                mem2[0] = 1;
        }
        
        val_27 = null;
        val_27 = null;
        val_28 = null;
        val_29 = App.trackerManager;
        val_28 = null;
        val_30 = Events.PUR_RET_1007;
        track(eventName:  null);
        UnityEngine.PlayerPrefs.SetInt(key:  48055872, value:  1);
    }
    public void PlayerLevelAndRetention()
    {
        var val_6;
        var val_9;
        var val_17;
        double val_18;
        var val_20;
        var val_21;
        var val_22;
        TrackerManager val_23;
        string val_24;
        Player val_1 = App.Player;
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        System.TimeSpan val_5 = Subtract(value:  new System.DateTime() {dateData = 1152921513244961496});
        double val_8 = val_6.TotalDays;
        val_17 = val_9;
        val_18 = -1;
        if((0 & 1) != 0)
        {
                 +  = ;
        }
        
        val_20 = "d3_lvl_100";
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1988561456)) == true)
        {
                return;
        }
        
        GameBehavior val_14 = App.getBehavior;
        if(0 < 100)
        {
                return;
        }
        
        var val_17 = 28617990;
        val_17 = 7007548 + val_17;
        if(val_17 == 0)
        {
                mem2[0] = 1;
        }
        
        val_21 = null;
        val_21 = null;
        val_22 = null;
        val_23 = App.trackerManager;
        val_22 = null;
        val_24 = Events.D3_LEVEL_100;
        track(eventName:  null);
        UnityEngine.PlayerPrefs.SetInt(key:  -1988561552, value:  1);
    }
    public void AdsAndRetention()
    {
        var val_6;
        var val_9;
        var val_21;
        double val_22;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        TrackerManager val_29;
        string val_30;
        Player val_1 = App.Player;
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        System.TimeSpan val_5 = Subtract(value:  new System.DateTime() {dateData = 1152921513245073880});
        double val_8 = val_6.TotalDays;
        val_21 = val_9;
        val_22 = -1;
        if((0 & 1) != 0)
        {
                 +  = ;
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  48279968)) != true)
        {
                Player val_14 = App.Player;
            if(4 >= 10)
        {
                var val_21 = 28616814;
            val_21 = 7008724 + val_21;
            if(val_21 == 0)
        {
                mem2[0] = 1;
        }
        
            val_24 = null;
            val_24 = null;
            val_25 = null;
            val_25 = null;
            App.trackerManager.track(eventName:  Events.D3_AD_CLICKED_10);
            UnityEngine.PlayerPrefs.SetInt(key:  48279968, value:  1);
        }
        
        }
        
        val_26 = "d3_vid_5";
        if((UnityEngine.PlayerPrefs.HasKey(key:  48280064)) == true)
        {
                return;
        }
        
        Player val_16 = App.Player;
        if(35143876 < 5)
        {
                return;
        }
        
        var val_22 = 28616482;
        val_22 = 7009056 + val_22;
        if(val_22 == 0)
        {
                mem2[0] = 1;
        }
        
        val_27 = null;
        val_27 = null;
        val_28 = null;
        val_29 = App.trackerManager;
        val_28 = null;
        val_30 = Events.D3_REW_VID_05;
        track(eventName:  null);
        UnityEngine.PlayerPrefs.SetInt(key:  48280256, value:  1);
    }
    public WGSerialTracker()
    {
    
    }

}
