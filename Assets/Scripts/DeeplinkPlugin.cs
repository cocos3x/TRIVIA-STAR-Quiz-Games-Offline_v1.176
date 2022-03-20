using UnityEngine;
public class DeeplinkPlugin
{
    // Fields
    private static UnityEngine.AndroidJavaObject plugin;
    
    // Methods
    public static DeeplinkAction GetAction()
    {
        bool val_3 = static_value_021FAF39;
        if(val_3 != true)
        {
                val_3 = true;
        }
        
        string val_1 = DeeplinkPlugin.GetAndroidAction();
        DeeplinkAction val_2 = new DeeplinkAction(maybeJson:  1);
    }
    public static void NotifyActionConsumed(string identifier)
    {
        typeof(System.Object[]).__il2cppRuntimeField_10 = identifier;
        UnityEngine.Debug.LogWarningFormat(format:  -1863953056, args:  472754880);
        DeeplinkPlugin.AndroidNotifyConsumed(identifier:  identifier);
    }
    public static System.Collections.Generic.Dictionary<string, string> GetActionParameters()
    {
        return DeeplinkPlugin.GetAndroidActionParameters();
    }
    private static string GetIosAction()
    {
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
    }
    public static string GetNotificationData()
    {
        return DeeplinkPlugin.GetAndroidNotificationData();
    }
    public static void SendDeferredLinkToAdjust()
    {
        DeeplinkPlugin.CaptureDeeplinkWithAdjust();
    }
    public static string GetSwipedNotification()
    {
        return DeeplinkPlugin.GetAndroidSwipedNotification();
    }
    public static string GetMoreGamesReferal()
    {
        return DeeplinkPlugin.GetAndroidMoreGamesReferal();
    }
    public static void RateApp()
    {
    
    }
    private static System.Collections.Generic.Dictionary<string, string> GetIosActionParameters()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
    }
    private static void CaptureDeeplinkWithAdjust()
    {
        var val_3;
        var val_4;
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  -1862940784);
        val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_3 == 1)
        {
                val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_2 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        DeeplinkPlugin.plugin = null;
        if(DeeplinkPlugin.plugin == 0)
        {
                return;
        }
        
        val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_4 == 1)
        {
                val_4 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_4 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        Call(methodName:  -1862940640, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
    }
    private static string GetIOsNotificationData()
    {
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
    }
    private static string GetAndroidAction()
    {
        var val_5;
        var val_6;
        var val_7;
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        UnityEngine.AndroidJavaClass val_2 = new UnityEngine.AndroidJavaClass(className:  -1862940784);
        val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_5 == 1)
        {
                val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_3 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        DeeplinkPlugin.plugin = null;
        if(DeeplinkPlugin.plugin != 0)
        {
                val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_6 == 1)
        {
                val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
            UnityEngine.AndroidJavaObject val_4 = Call<UnityEngine.AndroidJavaObject>(methodName:  -1862716512, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            return;
        }
        
        val_7 = "";
    }
    private static void AndroidNotifyConsumed(string identifier)
    {
        var val_3;
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  -1862940784);
        val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_3 == 1)
        {
                val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_2 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        DeeplinkPlugin.plugin = null;
        if(DeeplinkPlugin.plugin == 0)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = identifier;
        Call(methodName:  -1862600320, args:  472754880);
    }
    private static string GetAndroidNotificationData()
    {
        var val_5;
        var val_6;
        var val_7;
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        UnityEngine.AndroidJavaClass val_2 = new UnityEngine.AndroidJavaClass(className:  -1862940784);
        val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_5 == 1)
        {
                val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_3 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        DeeplinkPlugin.plugin = null;
        if(DeeplinkPlugin.plugin != 0)
        {
                val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_6 == 1)
        {
                val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
            UnityEngine.AndroidJavaObject val_4 = Call<UnityEngine.AndroidJavaObject>(methodName:  -1862484128, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            return;
        }
        
        val_7 = "";
    }
    private static string GetAndroidSwipedNotification()
    {
        var val_5;
        var val_6;
        var val_7;
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        UnityEngine.AndroidJavaClass val_2 = new UnityEngine.AndroidJavaClass(className:  -1862940784);
        val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_5 == 1)
        {
                val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_3 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        DeeplinkPlugin.plugin = null;
        if(DeeplinkPlugin.plugin != 0)
        {
                val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_6 == 1)
        {
                val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
            UnityEngine.AndroidJavaObject val_4 = Call<UnityEngine.AndroidJavaObject>(methodName:  -1862372016, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            return;
        }
        
        val_7 = "";
    }
    private static string GetAndroidMoreGamesReferal()
    {
        var val_5;
        var val_6;
        var val_7;
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return;
        }
        
        UnityEngine.AndroidJavaClass val_2 = new UnityEngine.AndroidJavaClass(className:  -1862940784);
        val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_5 == 1)
        {
                val_5 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_5 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_3 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        DeeplinkPlugin.plugin = null;
        if(DeeplinkPlugin.plugin != 0)
        {
                val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_6 == 1)
        {
                val_6 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_6 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
            UnityEngine.AndroidJavaObject val_4 = Call<UnityEngine.AndroidJavaObject>(methodName:  -1862259904, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            return;
        }
        
        val_7 = "";
    }
    private static string GetIOSSwipedNotification()
    {
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
    }
    private static System.Collections.Generic.Dictionary<string, string> GetAndroidActionParameters()
    {
        WordPets.WPTPetTile val_9;
        WordPets.WPTLetterTile val_10;
        var val_11;
        var val_12;
        var val_13;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_14;
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 == 11)
        {
                UnityEngine.AndroidJavaClass val_2 = new UnityEngine.AndroidJavaClass(className:  -1862940784);
            val_9 = 1152921510190316432;
            val_10 = public static T[] System.Array::Empty<System.Object>();
            val_11 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_11 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_11 == 1)
        {
                val_11 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_11 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
            UnityEngine.AndroidJavaObject val_3 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            DeeplinkPlugin.plugin = null;
            if(DeeplinkPlugin.plugin != 0)
        {
                val_12 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_12 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
            if(val_12 == 1)
        {
                val_12 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_12 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
            UnityEngine.AndroidJavaObject val_4 = Call<UnityEngine.AndroidJavaObject>(methodName:  -1862035808, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
            val_9 = DeeplinkPlugin.plugin;
            typeof(System.Char[]).__il2cppRuntimeField_10 = 44;
            val_13 = 0;
            System.String[] val_5 = Split(separator:  478563824);
            val_14 = null;
            val_14 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            if(val_9 != 0)
        {
                return;
        }
        
            return;
        }
        
        }
        
        val_14 = null;
        val_14 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
    }
    public DeeplinkPlugin()
    {
    
    }

}
