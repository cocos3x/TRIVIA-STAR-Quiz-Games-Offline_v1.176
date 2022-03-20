using UnityEngine;
public class DateTimeCheat : FrameSkipper
{
    // Fields
    private static bool initialized;
    private static int _mSeconds;
    
    // Properties
    public static int Seconds { get; }
    private static int mSeconds { get; set; }
    public static int AdjustedSeconds { get; }
    public static System.DateTime Now { get; }
    public static System.DateTime UtcNow { get; }
    public static System.DateTime ServerNow { get; }
    public static System.DateTime Today { get; }
    
    // Methods
    public static int get_Seconds()
    {
        int val_3;
        var val_4;
        var val_5;
        val_3 = 0;
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
                return val_3;
        }
        
        val_4 = null;
        val_4 = null;
        if(DateTimeCheat.initialized != true)
        {
                DateTimeCheat.LoadSeconds();
            val_4 = null;
        }
        
        var val_3 = 21438229;
        val_3 = 14203128 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        val_3 = DateTimeCheat._mSeconds;
        return val_3;
    }
    private static int get_mSeconds()
    {
        null = null;
        return (int)DateTimeCheat._mSeconds;
    }
    private static void set_mSeconds(int value)
    {
        null = null;
        DateTimeCheat._mSeconds = value;
        SROptions_DateTime.NotifyPropertyChanged(propertyName:  -2037903248);
    }
    public static int get_AdjustedSeconds()
    {
        null = null;
        return (int)DateTimeCheat._mSeconds;
    }
    public static System.DateTime get_Now()
    {
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                System.DateTime val_4 = System.DateTime.Now;
            int val_7 = DateTimeCheat.Seconds;
            System.DateTime val_8 = 0.AddSeconds(value:  null);
            return new System.DateTime() {dateData = val_9.dateData};
        }
        
        System.DateTime val_9 = System.DateTime.Now;
        return new System.DateTime() {dateData = val_9.dateData};
    }
    public static System.DateTime get_UtcNow()
    {
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                System.DateTime val_4 = System.DateTime.UtcNow;
            int val_7 = DateTimeCheat.Seconds;
            System.DateTime val_8 = 0.AddSeconds(value:  null);
            return new System.DateTime() {dateData = val_9.dateData};
        }
        
        System.DateTime val_9 = System.DateTime.UtcNow;
        return new System.DateTime() {dateData = val_9.dateData};
    }
    public static System.DateTime get_ServerNow()
    {
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                System.DateTime val_3 = System.DateTime.UtcNow;
            int val_6 = DateTimeCheat.Seconds;
            System.DateTime val_7 = 0.AddSeconds(value:  null);
            return new System.DateTime() {dateData = val_8.dateData};
        }
        
        System.DateTime val_8 = ServerHandler.ServerTime;
        return new System.DateTime() {dateData = val_8.dateData};
    }
    public static System.DateTime get_Today()
    {
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                System.DateTime val_4 = System.DateTime.Now;
            int val_7 = DateTimeCheat.Seconds;
            System.DateTime val_8 = AddSeconds(value:  null);
            System.DateTime val_11 = 0.Date;
            return new System.DateTime() {dateData = val_12.dateData};
        }
        
        System.DateTime val_12 = System.DateTime.Today;
        return new System.DateTime() {dateData = val_12.dateData};
    }
    public static void LoadSeconds()
    {
        var val_2 = null;
        DateTimeCheat._mSeconds = UnityEngine.PlayerPrefs.GetInt(key:  -2037231152, defaultValue:  0);
        DateTimeCheat.initialized = true;
    }
    private void Start()
    {
        null = null;
        if(DateTimeCheat.initialized == true)
        {
                return;
        }
        
        DateTimeCheat.LoadSeconds();
    }
    public void ResetDate(UnityEngine.GameObject sender)
    {
        DateTimeCheat.mSeconds = 0;
        UnityEngine.PlayerPrefs.DeleteKey(key:  -2037231152);
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -2036978832, aName:  -2037002944);
    }
    public static void ResetDateStatic()
    {
        DateTimeCheat.mSeconds = 0;
        UnityEngine.PlayerPrefs.DeleteKey(key:  -2037231152);
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -2037002944);
    }
    public void AddSeconds(int secondsCount, bool postNotification = True)
    {
        var val_3;
        var val_4;
        var val_3 = 21435525;
        val_3 = 14205832 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        int val_4 = DateTimeCheat._mSeconds;
        val_4 = val_4 + secondsCount;
        DateTimeCheat.mSeconds = val_4;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        UnityEngine.PlayerPrefs.SetInt(key:  -2037231152, value:  DateTimeCheat._mSeconds);
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
        if(postNotification == false)
        {
                return;
        }
        
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -2036750736, aName:  -2037002944);
    }
    public static void AddSecondsStatic(int secondsCount, bool postNotification = True)
    {
        var val_3;
        var val_4;
        var val_3 = 21435033;
        val_3 = 14206324 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        int val_4 = DateTimeCheat._mSeconds;
        val_4 = val_4 + secondsCount;
        DateTimeCheat.mSeconds = val_4;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        UnityEngine.PlayerPrefs.SetInt(key:  -2037231152, value:  DateTimeCheat._mSeconds);
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
        if(postNotification == false)
        {
                return;
        }
        
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -2037002944);
    }
    public void AddDays(int daysCount, bool postNotification = True)
    {
        var val_4;
        var val_5;
        var val_4 = 21434537;
        val_4 = 14206820 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        int val_5 = DateTimeCheat._mSeconds;
        val_5 = val_5 + ((daysCount * 675) << 7);
        DateTimeCheat.mSeconds = val_5;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        UnityEngine.PlayerPrefs.SetInt(key:  -2037231152, value:  DateTimeCheat._mSeconds);
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
        if(postNotification == false)
        {
                return;
        }
        
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -2036526736, aName:  -2037002944);
    }
    public static void AddDaysStatic(int daysCount, bool postNotification = True)
    {
        var val_4;
        var val_5;
        var val_4 = 21434037;
        val_4 = 14207320 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        int val_5 = DateTimeCheat._mSeconds;
        val_5 = val_5 + ((daysCount * 675) << 7);
        DateTimeCheat.mSeconds = val_5;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        UnityEngine.PlayerPrefs.SetInt(key:  -2037231152, value:  DateTimeCheat._mSeconds);
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
        if(postNotification == false)
        {
                return;
        }
        
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  0, aName:  -2037002944);
    }
    private void UpdateLabels()
    {
    
    }
    public static string GetSimulatedDate()
    {
        var val_5;
        var val_12;
        var val_16;
        var val_17;
        System.DateTime val_1 = System.DateTime.Now;
        var val_16 = 21433461;
        val_16 = 14207896 + val_16;
        if(val_16 == 0)
        {
                mem2[0] = 1;
        }
        
        val_16 = null;
        val_16 = null;
        System.DateTime val_4 = AddSeconds(value:  null);
        string val_7 = val_5.ToShortDateString();
        System.DateTime val_8 = System.DateTime.Now;
        if(val_16 == 0)
        {
                mem2[0] = 1;
        }
        
        val_17 = null;
        val_17 = null;
        System.DateTime val_11 = AddSeconds(value:  null);
        string val_14 = val_12.ToShortTimeString();
        string val_15 = -2036202768(-2036202768) + 1297836560 + -2036202768(-2036202768);
    }
    public static System.DateTime GetSimulatedDateTime()
    {
        var val_5;
        System.DateTime val_1 = System.DateTime.Now;
        var val_5 = 21432893;
        val_5 = 14208464 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        System.DateTime val_4 = 0.AddSeconds(value:  null);
        return new System.DateTime() {dateData = val_4.dateData};
    }
    public static System.DateTime GetSimulatedUTCDateTime()
    {
        var val_5;
        System.DateTime val_1 = System.DateTime.UtcNow;
        var val_5 = 21432565;
        val_5 = 14208792 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        System.DateTime val_4 = 0.AddSeconds(value:  null);
        return new System.DateTime() {dateData = val_4.dateData};
    }
    private void ShowCheatIndicator(bool state)
    {
    
    }
    protected override void UpdateLogic()
    {
    
    }
    public DateTimeCheat()
    {
    
    }
    private static DateTimeCheat()
    {
    
    }

}
