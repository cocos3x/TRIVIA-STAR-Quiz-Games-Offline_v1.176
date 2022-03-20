using UnityEngine;
public class DeviceIdPlugin
{
    // Fields
    public static string UNIDENTIFIABLE_ANDROID_DEVICE;
    private static string UNIDENTIFIABLE_IOS_MAC;
    public static string DEFAULT_DEVICE_ID;
    public static string DEFAULT_IOS_DEVICE_ID;
    private static UnityEngine.AndroidJavaObject plugin;
    private static System.Random random;
    private static string cachedCountry;
    private static string cachedCountryFromLocale;
    private static bool _cachedEmulator;
    private static bool _isEmulator;
    
    // Methods
    public static string GetDeviceId()
    {
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 == 8)
        {
                val_12 = null;
            val_12 = null;
            return;
        }
        
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 == 11)
        {
                UnityEngine.AndroidJavaClass val_3 = new UnityEngine.AndroidJavaClass(className:  -1861811696);
            val_13 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_13 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_13 == 1)
        {
                val_13 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_13 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
            UnityEngine.AndroidJavaObject val_4 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            val_14 = null;
            val_14 = null;
            DeviceIdPlugin.plugin = null;
            val_15 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_15 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_15 == 1)
        {
                val_15 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_15 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
            UnityEngine.AndroidJavaObject val_5 = Call<UnityEngine.AndroidJavaObject>(methodName:  -1887834480, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            if((System.String.op_Equality(a:  179232768, b:  -1861811552)) != true)
        {
                if((System.String.IsNullOrEmpty(value:  179232768)) == false)
        {
            goto label_22;
        }
        
        }
        
            string val_8 = DeviceIdPlugin.GenerateIDForUnidentifiableAndroid(size:  12);
            string val_9 = -1861811440(-1861811440) + 12;
            return;
        }
        
        val_16 = null;
        val_16 = null;
        return;
        label_22:
        string val_10 = -1861811360(-1861811360) + 179232768;
    }
    public static string GenerateIDForUnidentifiableAndroid(int size = 12)
    {
        var val_7;
        int val_7 = size;
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1861699280)) != false)
        {
                return UnityEngine.PlayerPrefs.GetString(key:  -1861699280);
        }
        
        if(val_7 >= 1)
        {
                do
        {
            val_7 = null;
            val_7 = null;
            System.Text.StringBuilder val_5 = Append(value:  System.Convert.ToChar(value:  System.Convert.ToInt32(value:  null)));
            val_7 = val_7 - 1;
        }
        while(new System.Text.StringBuilder() != 0);
        
        }
        
        UnityEngine.PlayerPrefs.SetString(key:  -1861699280, value:  24121344);
        bool val_6 = PrefsSerializationManager.SavePlayerPrefs();
        goto mem[null + 212];
    }
    public static string GetGoogleAdId()
    {
        var val_5;
        var val_6;
        UnityEngine.AndroidJavaObject val_7;
        var val_8;
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        UnityEngine.AndroidJavaClass val_2 = new UnityEngine.AndroidJavaClass(className:  -1861587168);
        if(null != 0)
        {
                val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_5 == 1)
        {
                val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
            UnityEngine.AndroidJavaObject val_3 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            val_6 = null;
            val_6 = null;
            DeviceIdPlugin.plugin = null;
        }
        else
        {
                val_6 = null;
        }
        
        val_6 = null;
        val_7 = DeviceIdPlugin.plugin;
        if(val_7 == 0)
        {
                return;
        }
        
        val_7 = DeviceIdPlugin.plugin;
        val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_8 == 1)
        {
                val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_4 = Call<UnityEngine.AndroidJavaObject>(methodName:  -1861587024, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
    }
    public static bool identifiableDevice()
    {
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return true;
        }
        
        string val_2 = UnityEngine.SystemInfo.deviceUniqueIdentifier;
        return System.String.op_Inequality(a:  null, b:  -1861811552);
    }
    public static string GetAndroidVersion()
    {
        var val_4;
        var val_5;
        UnityEngine.AndroidJavaObject val_6;
        var val_7;
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  -1861811696);
        val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_4 == 1)
        {
                val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_2 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        val_5 = null;
        val_5 = null;
        DeviceIdPlugin.plugin = null;
        val_6 = DeviceIdPlugin.plugin;
        if(val_6 == 0)
        {
                return;
        }
        
        val_6 = DeviceIdPlugin.plugin;
        val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_7 == 1)
        {
                val_7 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_7 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_3 = Call<UnityEngine.AndroidJavaObject>(methodName:  -1861362848, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
    }
    public static string GetClientVersion()
    {
        var val_5;
        var val_6;
        UnityEngine.AndroidJavaObject val_7;
        var val_8;
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        UnityEngine.AndroidJavaClass val_2 = new UnityEngine.AndroidJavaClass(className:  -1861811696);
        val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_5 == 1)
        {
                val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_3 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        val_6 = null;
        val_6 = null;
        DeviceIdPlugin.plugin = null;
        val_7 = DeviceIdPlugin.plugin;
        if(val_7 == 0)
        {
                return;
        }
        
        val_7 = DeviceIdPlugin.plugin;
        val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_8 == 1)
        {
                val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_4 = Call<UnityEngine.AndroidJavaObject>(methodName:  -1861250736, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
    }
    public static string GetIdfa()
    {
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 == 8)
        {
                "" = "dummyIosId";
        }
    
    }
    public static string GetMacAddress()
    {
        var val_5;
        var val_6;
        UnityEngine.AndroidJavaObject val_7;
        var val_8;
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        UnityEngine.AndroidJavaClass val_2 = new UnityEngine.AndroidJavaClass(className:  -1861811696);
        val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_5 == 1)
        {
                val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_3 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        val_6 = null;
        val_6 = null;
        DeviceIdPlugin.plugin = null;
        val_7 = DeviceIdPlugin.plugin;
        if(val_7 == 0)
        {
                return;
        }
        
        val_7 = DeviceIdPlugin.plugin;
        val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_8 == 1)
        {
                val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_4 = Call<UnityEngine.AndroidJavaObject>(methodName:  -1861026544, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
    }
    public static string GetCountry()
    {
        var val_4;
        var val_5;
        var val_6;
        UnityEngine.AndroidJavaObject val_8;
        var val_9;
        val_4 = null;
        val_4 = null;
        if(DeviceIdPlugin.cachedCountry != null)
        {
                return;
        }
        
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  -1861811696);
        val_5 = public static T[] System.Array::Empty<System.Object>();
        val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_6 == 1)
        {
                val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_2 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        val_4 = null;
        val_4 = null;
        DeviceIdPlugin.plugin = null;
        val_8 = DeviceIdPlugin.plugin;
        if(val_8 != 0)
        {
                val_8 = DeviceIdPlugin.plugin;
            val_5 = public static T[] System.Array::Empty<System.Object>();
            val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_9 == 1)
        {
                val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
            UnityEngine.AndroidJavaObject val_3 = Call<UnityEngine.AndroidJavaObject>(methodName:  -1860914448, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            val_4 = null;
            DeviceIdPlugin.cachedCountry = val_8;
            return;
        }
        
        val_4 = null;
        DeviceIdPlugin.cachedCountry = System.String.alignConst;
    }
    public static string GetCountryFromLocale()
    {
        var val_4;
        var val_5;
        var val_6;
        UnityEngine.AndroidJavaObject val_8;
        var val_9;
        val_4 = null;
        val_4 = null;
        if(DeviceIdPlugin.cachedCountryFromLocale != null)
        {
                return;
        }
        
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  -1861811696);
        val_5 = public static T[] System.Array::Empty<System.Object>();
        val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_6 == 1)
        {
                val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_2 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        val_4 = null;
        val_4 = null;
        DeviceIdPlugin.plugin = null;
        val_8 = DeviceIdPlugin.plugin;
        if(val_8 != 0)
        {
                val_8 = DeviceIdPlugin.plugin;
            val_5 = public static T[] System.Array::Empty<System.Object>();
            val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_9 == 1)
        {
                val_9 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_9 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
            UnityEngine.AndroidJavaObject val_3 = Call<UnityEngine.AndroidJavaObject>(methodName:  -1860802352, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            val_4 = null;
            DeviceIdPlugin.cachedCountryFromLocale = val_8;
            return;
        }
        
        val_4 = null;
        DeviceIdPlugin.cachedCountryFromLocale = System.String.alignConst;
    }
    public static int GetTimeZone()
    {
        var val_4;
        var val_7;
        var val_12;
        double val_13;
        var val_14;
        System.DateTime val_1 = DateTimeCheat.Now;
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        System.TimeSpan val_3 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921511336103272}, d2:  new System.DateTime());
        double val_6 = val_4.TotalHours;
        val_12 = val_7;
        val_13 = -1;
        double val_8 =  + ;
        if((0 & 1) != 0)
        {
                val_14 = ;
        }
        
        if(System.Math.__il2cppRuntimeField_cctor_finished == 0)
        {
                 = 0;
        }
        
        return (int)S0;
    }
    public static string GetBusinessToken()
    {
    
    }
    public static bool IsEmulator()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        UnityEngine.AndroidJavaObject val_10;
        var val_11;
        bool val_12;
        val_5 = null;
        val_5 = null;
        val_6 = val_5;
        if(DeviceIdPlugin._cachedEmulator != false)
        {
                val_6 = 1152921504896356444;
            return (bool)DeviceIdPlugin._isEmulator;
        }
        
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  -1861811696);
        val_7 = public static T[] System.Array::Empty<System.Object>();
        val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_8 == 1)
        {
                val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_2 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        val_6 = null;
        val_6 = null;
        DeviceIdPlugin.plugin = null;
        val_10 = DeviceIdPlugin.plugin;
        if(val_10 != 0)
        {
                val_10 = DeviceIdPlugin.plugin;
            val_7 = public static T[] System.Array::Empty<System.Object>();
            val_11 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_11 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_11 == 1)
        {
                val_11 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_11 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
            val_12 = Call<System.Boolean>(methodName:  -1860466240, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            val_6 = null;
        }
        else
        {
                val_12 = false;
        }
        
        DeviceIdPlugin._isEmulator = val_12;
        val_6 = null;
        DeviceIdPlugin._cachedEmulator = true;
        return (bool)DeviceIdPlugin._isEmulator;
    }
    public DeviceIdPlugin()
    {
    
    }
    private static DeviceIdPlugin()
    {
        DeviceIdPlugin.UNIDENTIFIABLE_ANDROID_DEVICE = "unidentifiableAndroid";
        DeviceIdPlugin.UNIDENTIFIABLE_IOS_MAC = "020000000000";
        DeviceIdPlugin.DEFAULT_DEVICE_ID = "dummyId";
        DeviceIdPlugin.DEFAULT_IOS_DEVICE_ID = "dummyIosId";
        System.DateTime val_1 = System.DateTime.Now;
        DeviceIdPlugin.random = new System.Random(Seed:  ???.Ticks);
        DeviceIdPlugin.cachedCountry = 0;
        DeviceIdPlugin.cachedCountryFromLocale = 0;
        DeviceIdPlugin._cachedEmulator = 0;
        DeviceIdPlugin._isEmulator = 0;
    }

}
