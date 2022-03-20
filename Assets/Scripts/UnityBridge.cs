using UnityEngine;
public static class UnityBridge
{
    // Fields
    private const string SEND = "window.UnityBridge.Send";
    private const string PURCHASE = "window.UnityBridge.Purchase";
    private const string OPENURL = "window.UnityBridge.OpenNewTab";
    private const string HIDE_LOADING = "window.UnityBridge.HideLoadingScreen";
    private const string FB_REQUEST = "window.Facebook.request";
    private const string FB_FEED = "window.Facebook.fbFeed";
    private const string FB_SHARE = "window.Facebook.fbShare";
    private const string FB_PERMISSIONS_REQUEST = "window.Facebook.requestForPermission";
    private const string EASY_BUY_MODULE_INIT = "window.EasyBuyModule.OnGameLoad";
    private const string COPY_TO_CLIPBOARD = "window.UnityBridge.CopyToClipboard";
    
    // Methods
    public static void Send(string url, string requestType, object data, NetworkThreadingHandler threadHandler)
    {
        string val_1 = MiniJSON.Json.Serialize(obj:  data);
        string val_2 = UnityBridge.generateThreadName(length:  16);
        UnityEngine.GameObject val_3 = threadHandler.gameObject;
        threadHandler.name = 16;
        if(threadHandler.Request.logging != false)
        {
                string val_4 = -1907144256(-1907144256) + requestType + -1907144368(-1907144368) + data;
            UnityEngine.Debug.Log(message:  -1907144256);
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = url;
        typeof(System.Object[]).__il2cppRuntimeField_14 = requestType;
        typeof(System.Object[]).__il2cppRuntimeField_18 = data;
        typeof(System.Object[]).__il2cppRuntimeField_1C = 16;
        UnityEngine.Application.ExternalCall(functionName:  -1907144176, args:  472754880);
    }
    public static void Receive(string data, NetworkThreadingHandler threadHandler)
    {
        if(threadHandler.Request.logging != false)
        {
                string val_1 = -1906999280(-1906999280) + data;
            UnityEngine.Debug.Log(message:  -1906999280);
        }
        
        threadHandler.Request.responseString = data;
        threadHandler.Request.finalize();
    }
    public static void FbRequest(object data)
    {
        string val_1 = MiniJSON.Json.Serialize(obj:  data);
        typeof(System.Object[]).__il2cppRuntimeField_10 = data;
        string val_2 = UnityBridge.CreateThreadingHandler();
        typeof(System.Object[]).__il2cppRuntimeField_14 = System.Object[].__il2cppRuntimeField_namespaze;
        UnityEngine.Application.ExternalCall(functionName:  -1906854384, args:  472754880);
    }
    public static void FbFeed(string url, string to = "")
    {
        typeof(System.Object[]).__il2cppRuntimeField_10 = url;
        typeof(System.Object[]).__il2cppRuntimeField_14 = to;
        string val_1 = UnityBridge.CreateThreadingHandler();
        typeof(System.Object[]).__il2cppRuntimeField_18 = System.Object[].__il2cppRuntimeField_namespaze;
        UnityEngine.Application.ExternalCall(functionName:  -1906729968, args:  472754880);
    }
    public static void FBShare(string url)
    {
        typeof(System.Object[]).__il2cppRuntimeField_10 = url;
        typeof(System.Object[]).__il2cppRuntimeField_14 = url;
        string val_1 = UnityBridge.CreateThreadingHandler();
        typeof(System.Object[]).__il2cppRuntimeField_18 = System.Object[].__il2cppRuntimeField_namespaze;
        UnityEngine.Application.ExternalCall(functionName:  -1906605568, args:  472754880);
    }
    public static void InitEasyBuyBar(string packageData, string gameObjectName)
    {
        typeof(System.Object[]).__il2cppRuntimeField_10 = packageData;
        typeof(System.Object[]).__il2cppRuntimeField_14 = gameObjectName;
        UnityEngine.Application.ExternalCall(functionName:  -1906481152, args:  472754880);
    }
    public static string generateThreadName(int length = 16)
    {
        var val_7;
        var val_8;
        var val_9;
        int val_7 = length;
        val_7 = "0123456789abcdefghijklmnopqrstuvwxyz";
        if(val_7 == 0)
        {
                val_7 = "0123456789abcdefghijklmnopqrstuvwxyz";
        }
        
        System.Char[] val_1 = ToCharArray();
        val_8 = "";
        if(val_7 < 1)
        {
                return -1906360672(-1906360672) + 1098586544;
        }
        
        if(val_7 != 0)
        {
                val_9 = UnityEngine.Random.Range(min:  0, max:  "0123456789abcdefghijklmnopqrstuvwxyz".__il2cppRuntimeField_C);
        }
        else
        {
                val_9 = UnityEngine.Random.Range(min:  0, max:  "0123456789abcdefghijklmnopqrstuvwxyz".__il2cppRuntimeField_C);
        }
        
        string val_4 = val_7 + (val_9 << 1);
        val_4 = val_4 + 16;
        string val_5 = val_4.ToString();
        string val_6 = 1098586544 + val_4;
        val_7 = val_7 - 1;
        val_8 = val_8;
        return -1906360672(-1906360672) + 1098586544;
    }
    private static string CreateThreadingHandler()
    {
        string val_2 = UnityBridge.generateThreadName(length:  16);
        if(new UnityEngine.GameObject() != 0)
        {
                name = 16;
        }
        else
        {
                0.name = 16;
        }
        
        object val_3 = AddComponent<System.Object>();
    }
    public static void OpenUrl(string url, string text, string title)
    {
        typeof(System.Object[]).__il2cppRuntimeField_10 = url;
        typeof(System.Object[]).__il2cppRuntimeField_14 = text;
        typeof(System.Object[]).__il2cppRuntimeField_18 = title;
        UnityEngine.Application.ExternalCall(functionName:  -1906123264, args:  472754880);
    }
    public static void HideLoadingScreen()
    {
        var val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_1 == 1)
        {
                val_1 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_1 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.Application.ExternalCall(functionName:  -1905998848, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
    }
    public static void CopyToClipboard(string text)
    {
        typeof(System.Object[]).__il2cppRuntimeField_10 = text;
        UnityEngine.Application.ExternalCall(functionName:  -1905882608, args:  472754880);
    }

}
