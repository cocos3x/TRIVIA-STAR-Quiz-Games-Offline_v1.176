using UnityEngine;
public static class DeviceProperties
{
    // Properties
    public static string LocaleFromDevice { get; }
    public static string FreeMemory { get; }
    public static string MaxMemory { get; }
    public static string LoadingTime { get; }
    public static bool isJailbroken { get; }
    public static string notificationToken { get; }
    public static bool timeTraveler { get; }
    public static string MacAddress { get; }
    public static string DeviceModel { get; }
    public static string SimpleOSVersion { get; }
    public static string SimpleDeviceModel { get; }
    public static string OSVersion { get; }
    public static string LanguageCode { get; }
    public static string Platform { get; }
    public static string Idfa { get; }
    
    // Methods
    public static string get_LocaleFromDevice()
    {
        var val_4;
        var val_5;
        System.Object[] val_6;
        var val_7;
        val_4 = "en-US";
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  -1860129840);
        val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_5 == 1)
        {
                val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92];
        val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92;
        UnityEngine.AndroidJavaObject val_2 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  val_6);
        if(null == 0)
        {
                return;
        }
        
        val_6 = public static T[] System.Array::Empty<System.Object>();
        val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_7 == 1)
        {
                val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_3 = Call<UnityEngine.AndroidJavaObject>(methodName:  -1860129680, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        val_4 = null;
    }
    public static string get_FreeMemory()
    {
        var val_4;
        var val_5;
        System.Object[] val_6;
        var val_7;
        val_4 = "";
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  -1860129840);
        val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_5 == 1)
        {
                val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92];
        val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92;
        UnityEngine.AndroidJavaObject val_2 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  val_6);
        if(null == 0)
        {
                return;
        }
        
        val_6 = public static T[] System.Array::Empty<System.Object>();
        val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_7 == 1)
        {
                val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_3 = Call<UnityEngine.AndroidJavaObject>(methodName:  -1860017568, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        val_4 = null;
    }
    public static string get_MaxMemory()
    {
        var val_4;
        var val_5;
        System.Object[] val_6;
        var val_7;
        val_4 = "";
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  -1860129840);
        val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_5 == 1)
        {
                val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92];
        val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92;
        UnityEngine.AndroidJavaObject val_2 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  val_6);
        if(null == 0)
        {
                return;
        }
        
        val_6 = public static T[] System.Array::Empty<System.Object>();
        val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_7 == 1)
        {
                val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_3 = Call<UnityEngine.AndroidJavaObject>(methodName:  -1859905472, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        val_4 = null;
    }
    public static string get_LoadingTime()
    {
    
    }
    public static bool get_isJailbroken()
    {
        var val_3;
        var val_4;
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  -1860129840);
        val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_3 == 1)
        {
                val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_2 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        if(null == 0)
        {
                return false;
        }
        
        val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_4 != 1)
        {
                return Call<System.Boolean>(methodName:  -1859681376, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        }
        
        val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        return Call<System.Boolean>(methodName:  -1859681376, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
    }
    public static string get_notificationToken()
    {
        var val_4;
        var val_5;
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  -1859569280);
        val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_4 == 1)
        {
                val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_2 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        if(null == 0)
        {
                return;
        }
        
        val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_5 == 1)
        {
                val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_3 = Call<UnityEngine.AndroidJavaObject>(methodName:  -1859569104, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
    }
    public static bool get_timeTraveler()
    {
        var val_13;
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() == true)
        {
                return true;
        }
        
        System.DateTime val_3 = System.DateTime.UtcNow;
        System.DateTime val_6 = ServerHandler.ServerTime;
        System.TimeSpan val_9 = Subtract(value:  new System.DateTime() {dateData = 1152921511337336552});
        System.TimeSpan val_12 = Duration();
        double val_15 = val_13.TotalHours;
        if(ServerHandler.__il2cppRuntimeField_cctor_finished > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public static string get_MacAddress()
    {
        return DeviceIdPlugin.GetMacAddress();
    }
    public static string get_DeviceModel()
    {
        return UnityEngine.SystemInfo.deviceModel;
    }
    public static string get_SimpleOSVersion()
    {
        var val_10 = 26830454;
        val_10 = 8800504 + val_10;
        if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
        if((System.String.op_Equality(a:  1726392512, b:  1726392512)) != true)
        {
                if((System.String.op_Equality(a:  1726392512, b:  -1859120992)) == false)
        {
            goto label_3;
        }
        
        }
        
        string val_3 = UnityEngine.SystemInfo.operatingSystem;
        typeof(System.Char[]).__il2cppRuntimeField_10 = 32;
        System.String[] val_4 = 0.Split(separator:  478563824);
        return;
        label_3:
        string val_6 = UnityEngine.SystemInfo.operatingSystem;
        if((System.String.op_Equality(a:  1726392512, b:  1726393632)) == false)
        {
                return;
        }
        
        typeof(System.Char[]).__il2cppRuntimeField_10 = 32;
        System.String[] val_7 = 0.Split(separator:  478563824);
        if(0 == 0)
        {
                return;
        }
        
        var val_8 = 0 + 0;
        typeof(System.Char[]).__il2cppRuntimeField_10 = 46;
        System.String[] val_9 = (0 + 0) + 12.Split(separator:  478563824);
        if(((0 + 0) + 12 + 12) != 0)
        {
                return;
        }
    
    }
    public static string get_SimpleDeviceModel()
    {
        var val_9 = 26829698;
        val_9 = 8801260 + val_9;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        if((System.String.op_Equality(a:  1726392512, b:  1726392512)) != true)
        {
                if((System.String.op_Equality(a:  1726392512, b:  -1859120992)) == false)
        {
            goto label_3;
        }
        
        }
        
        string val_3 = UnityEngine.SystemInfo.deviceModel;
        typeof(System.Char[]).__il2cppRuntimeField_10 = 32;
        System.String[] val_4 = 0.Split(separator:  478563824);
        var val_10 = 0;
        val_10 = 0 + ((val_10 - 1) << 2);
        return;
        label_3:
        string val_7 = UnityEngine.SystemInfo.deviceModel;
        if((System.String.op_Equality(a:  1726392512, b:  1726393632)) == false)
        {
                return;
        }
        
        if((0.Contains(value:  -1859008912)) == false)
        {
                return;
        }
    
    }
    public static string get_OSVersion()
    {
        return UnityEngine.SystemInfo.operatingSystem;
    }
    public static string get_LanguageCode()
    {
        return UnityEngine.PlayerPrefs.GetString(key:  1798542544);
    }
    public static string get_Platform()
    {
    
    }
    public static string get_Idfa()
    {
        return DeviceIdPlugin.GetIdfa();
    }

}
