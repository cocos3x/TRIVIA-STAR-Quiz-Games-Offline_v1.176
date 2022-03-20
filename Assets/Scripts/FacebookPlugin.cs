using UnityEngine;
public class FacebookPlugin
{
    // Fields
    private const int MAX_PER_INVITE = 50;
    private static UnityEngine.AndroidJavaObject plugin;
    private static bool initialized;
    private static string gameObjectName;
    private static string gameName;
    private static string _userFbid;
    private static string _userAccessToken;
    private static bool accessTokenRefreshed;
    private static string _userFbName;
    private static string[] appFriendsIdsArray;
    private static string nextInvitableFriends;
    private static int nextInvitableFriendsCount;
    public const string OnFacebookPluginUpdate = "OnFacebookPluginUpdate";
    public const string OnSDKError = "OnSDKError";
    public static System.Collections.Generic.List<string> loginReadPermissions;
    private static System.Collections.Generic.List<FacebookPlugin.FBTasks> AvailableTasks;
    private static System.Collections.Generic.List<FacebookPlugin.FBTasks> CompletedTasks;
    
    // Properties
    public static string UserAccessToken { get; set; }
    public static bool AccessTokenRefreshed { get; set; }
    public static string[] userFriendsIds { get; }
    public static bool PluginInitialized { get; }
    public static bool IsLoggedIn { get; }
    public static string AppPageID { get; }
    public static string userFbid { get; }
    
    // Methods
    public static string get_UserAccessToken()
    {
        null = null;
    }
    private static void set_UserAccessToken(string value)
    {
        bool val_5;
        var val_6;
        var val_7;
        val_5 = 1152921504892043264;
        Player val_1 = App.Player;
        if((System.String.op_Equality(a:  static_value_00280018, b:  value)) == true)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        FacebookPlugin._userAccessToken = value;
        Player val_3 = App.Player;
        Player val_4 = App.Player;
        val_5 = true;
        2621448.Save(writePrefs:  true);
        val_7 = null;
        val_7 = null;
        FacebookPlugin.accessTokenRefreshed = true;
    }
    public static bool get_AccessTokenRefreshed()
    {
        null = null;
        return (bool)FacebookPlugin.accessTokenRefreshed;
    }
    private static void set_AccessTokenRefreshed(bool value)
    {
        null = null;
        FacebookPlugin.accessTokenRefreshed = value;
    }
    public static string[] get_userFriendsIds()
    {
        null = null;
    }
    public static bool get_PluginInitialized()
    {
        null = null;
        return (bool)FacebookPlugin.initialized;
    }
    public static bool get_IsLoggedIn()
    {
        return Facebook.Unity.FB.IsLoggedIn;
    }
    public static string get_AppPageID()
    {
        AppConfigs val_1 = App.Configuration;
        if(0 != 0)
        {
                return;
        }
    
    }
    public static void MakeTaskAvailable(FacebookPlugin.FBTasks newlyAvailableTask)
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        if((FacebookPlugin.CompletedTasks.Contains(item:  newlyAvailableTask)) != false)
        {
                val_5 = null;
            val_5 = null;
            bool val_2 = FacebookPlugin.CompletedTasks.Remove(item:  newlyAvailableTask);
        }
        
        val_6 = null;
        val_6 = null;
        if((FacebookPlugin.AvailableTasks.Contains(item:  newlyAvailableTask)) != false)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        FacebookPlugin.AvailableTasks.Add(item:  newlyAvailableTask);
    }
    public static void MakeTaskComplete(FacebookPlugin.FBTasks newlyCompletedTask)
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        val_4 = null;
        val_4 = null;
        if((FacebookPlugin.AvailableTasks.Contains(item:  newlyCompletedTask)) != false)
        {
                val_5 = null;
            val_5 = null;
            bool val_2 = FacebookPlugin.AvailableTasks.Remove(item:  newlyCompletedTask);
        }
        
        val_6 = null;
        val_6 = null;
        if((FacebookPlugin.CompletedTasks.Contains(item:  newlyCompletedTask)) != false)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        FacebookPlugin.CompletedTasks.Add(item:  newlyCompletedTask);
    }
    public static bool TaskAvailable(FacebookPlugin.FBTasks taskToCheck)
    {
        null = null;
        if(FacebookPlugin.AvailableTasks != 0)
        {
                return FacebookPlugin.AvailableTasks.Contains(item:  taskToCheck);
        }
        
        return FacebookPlugin.AvailableTasks.Contains(item:  taskToCheck);
    }
    public static bool TaskComplete(FacebookPlugin.FBTasks taskToCheck)
    {
        null = null;
        if(FacebookPlugin.CompletedTasks != 0)
        {
                return FacebookPlugin.CompletedTasks.Contains(item:  taskToCheck);
        }
        
        return FacebookPlugin.CompletedTasks.Contains(item:  taskToCheck);
    }
    public static string get_userFbid()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        if((System.String.IsNullOrEmpty(value:  FacebookPlugin._userFbid)) != false)
        {
                Player val_2 = App.Player;
            val_6 = 0;
            if((System.String.IsNullOrEmpty(value:  35143836)) == true)
        {
                return;
        }
        
            Player val_4 = App.Player;
            val_7 = 2621448 + 12;
            return;
        }
        
        val_8 = null;
        val_8 = null;
        val_7 = 1152921504896679952;
    }
    public static void init(string gameObjectName, string gameName)
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_9 = null;
        val_9 = null;
        val_10 = val_9;
        if(FacebookPlugin.initialized == true)
        {
                return;
        }
        
        val_10 = mem[R6];
        val_10 = R6;
        val_11 = mem[R6 + 92];
        val_11 = R6 + 92;
        mem2[0] = ???;
        mem2[0] = ???;
        UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  -1853808496);
        val_12 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
        val_12 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        if(val_12 == 1)
        {
                val_12 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186];
            val_12 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 186;
        }
        
        UnityEngine.AndroidJavaObject val_2 = CallStatic<UnityEngine.AndroidJavaObject>(methodName:  -1874064976, args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_18 + 92);
        mem2[0] = null;
        if((R6 + 92) == 0)
        {
                return;
        }
        
        AppConfigs val_3 = App.Configuration;
        if((System.String.IsNullOrEmpty(value:  2097204)) != true)
        {
                AppConfigs val_5 = App.Configuration;
            typeof(System.Char[]).__il2cppRuntimeField_10 = 44;
            System.String[] val_6 = 2097204.Split(separator:  478563824);
            System.Collections.Generic.List<ZooTile> val_7 = new System.Collections.Generic.List<ZooTile>(collection:  2097204);
            val_13 = mem[R6];
            val_13 = R6;
            if((((R6 + 187) & 2) == 0) && ((R6 + 116) == 0))
        {
                val_13 = mem[R6];
            val_13 = R6;
        }
        
            mem2[0] = null;
        }
        
        Facebook.Unity.InitDelegate val_8 = new Facebook.Unity.InitDelegate(object:  0, method:  new IntPtr(2441158944));
        Facebook.Unity.FB.Init(onInitComplete:  240414720, onHideUnity:  0, authResponse:  null);
        val_14 = mem[R6];
        val_14 = R6;
        if((((R6 + 187) & 2) == 0) && ((R6 + 116) == 0))
        {
                val_14 = mem[R6];
            val_14 = R6;
        }
        
        mem2[0] = 1;
    }
    public static void SendAccessToken()
    {
        var val_4;
        var val_5;
        var val_6;
        var val_4 = 28470934;
        val_4 = 7157020 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        if(FacebookPlugin.accessTokenRefreshed == false)
        {
                return;
        }
        
        var val_5 = 28470809;
        val_5 = 7157144 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        FacebookPlugin.accessTokenRefreshed = false;
        var val_6 = 28468782;
        val_6 = 7157276 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Player val_2 = App.Player;
        Add(key:  1618311216, value:  1835037);
        Player val_3 = App.Player;
        Add(key:  1603356976, value:  static_value_00280018);
        App.networkManager.DoPost(path:  -1853687136, postBody:  78753792, onCompleteFunction:  0, timeout:  20, destroy:  false, immediate:  false, serverType:  0);
    }
    private static void InitComplete()
    {
        var val_7;
        Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> val_9;
        var val_10;
        Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> val_12;
        var val_13;
        var val_14;
        if(Facebook.Unity.FB.IsInitialized == false)
        {
            goto label_3;
        }
        
        val_7 = null;
        val_7 = null;
        val_9 = FacebookPlugin.<>c.<>9__41_0;
        if(val_9 == 0)
        {
                val_9 = null;
            val_9 = new Facebook.Unity.FacebookDelegate<System.Object>(object:  FacebookPlugin.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2441392272));
            FacebookPlugin.<>c.<>9__41_0 = val_9;
        }
        
        FB.Mobile.FetchDeferredAppLinkData(callback:  240467968);
        val_10 = null;
        val_10 = null;
        val_12 = FacebookPlugin.<>c.<>9__41_1;
        if(val_12 == 0)
        {
                val_12 = null;
            val_12 = new Facebook.Unity.FacebookDelegate<System.Object>(object:  FacebookPlugin.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2441394320));
            FacebookPlugin.<>c.<>9__41_1 = val_12;
        }
        
        Facebook.Unity.FB.GetAppLink(callback:  240467968);
        if(Facebook.Unity.FB.IsLoggedIn == false)
        {
            goto label_16;
        }
        
        FacebookPlugin.OnLoginActions();
        goto label_19;
        label_3:
        UnityEngine.Debug.LogError(message:  -1853571952);
        return;
        label_16:
        FacebookPlugin.MakeTaskAvailable(newlyAvailableTask:  1);
        label_19:
        var val_7 = 28467134;
        val_7 = 7158404 + val_7;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_13 = null;
        val_13 = null;
        val_14 = null;
        val_14 = null;
        string val_6 = -1987246624(-1987246624) + Events.APP_LAUNCHED;
        App.trackerManager.track(eventName:  -1987246624);
    }
    private static void GetAppLink(Facebook.Unity.IAppLinkResult result)
    {
        Facebook.Unity.IAppLinkResult val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        val_13 = 0;
        val_13 = val_13 + 1;
        val_14 = (uint)val_13 & 65535;
        val_15 = result;
        if((System.String.IsNullOrEmpty(value:  result)) != false)
        {
                val_13 = 0;
            val_13 = val_13 + 1;
            val_14 = (uint)val_13 & 65535;
            val_16 = result;
            if((System.String.IsNullOrEmpty(value:  result)) == true)
        {
                return;
        }
        
        }
        
        var val_13 = 0;
        val_14 = 0;
        val_13 = val_13 + 1;
        val_14 = (uint)val_13 & 65535;
        val_17 = result;
        typeof(System.Object[]).__il2cppRuntimeField_10 = result;
        var val_14 = 0;
        val_14 = 0;
        val_14 = val_14 + 1;
        val_14 = (uint)val_14 & 65535;
        val_18 = result;
        val_13 = result;
        typeof(System.Object[]).__il2cppRuntimeField_14 = val_13;
        UnityEngine.Debug.LogFormat(format:  -1853455712, args:  472754880);
        val_13 = 0;
        val_14 = 0;
        val_13 = val_13 + 1;
        val_14 = (uint)val_13 & 65535;
        val_19 = result;
        if((System.String.IsNullOrEmpty(value:  result)) != false)
        {
                val_14 = 0 + 1;
            val_13 = (uint)val_14 & 65535;
            val_20 = result;
        }
        else
        {
                val_14 = 0 + 1;
            val_13 = (uint)val_14 & 65535;
            val_20 = result;
        }
        
        System.Type val_9 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(285622272)});
        AppComponent val_10 = App.GetComponent(tipo:  285622272);
        if(null == 0)
        {
                return;
        }
        
        if(((mem[null + 100] + (DeeplinkComponent.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                null = 0;
        }
    
    }
    private static void LoginComplete(Facebook.Unity.ILoginResult result)
    {
        if(Facebook.Unity.FB.IsLoggedIn != false)
        {
                FacebookPlugin.OnLoginActions();
        }
        
        FacebookPlugin.NotifyRequestCompleted(request:  0, success:  Facebook.Unity.FB.IsLoggedIn);
    }
    private static void OnLoginActions()
    {
        var val_3;
        var val_4;
        var val_5;
        var val_3 = 28469227;
        val_3 = 7158728 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        FacebookPlugin._userFbid = Facebook.Unity.AccessToken.<CurrentAccessToken>k__BackingField.<UserId>k__BackingField;
        Player val_1 = App.Player;
        FacebookPlugin.MakeTaskComplete(newlyCompletedTask:  1);
        FacebookPlugin.GetUserFriends();
        FacebookPlugin.RetrieveBasicInfo();
        Player val_2 = App.Player;
        2621448.Save(writePrefs:  true);
        val_4 = null;
        val_4 = null;
        val_5 = null;
        val_5 = null;
        App.trackerManager.track(eventName:  Events.FB_LOGIN);
    }
    public static void PerformFirstAvailableTask()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        if((FacebookPlugin.AvailableTasks + 12) < 1)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        FacebookPlugin.AvailableTasks.Sort();
        if((FacebookPlugin.AvailableTasks + 12) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        FacebookPlugin.PerformTask(task:  FacebookPlugin.AvailableTasks + 8 + 16);
    }
    public static void PerformTask(FacebookPlugin.FBTasks task)
    {
        var val_2;
        if(task != 1)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        Facebook.Unity.FacebookDelegate<System.Object> val_1 = new Facebook.Unity.FacebookDelegate<System.Object>(object:  0, method:  new IntPtr(2441977168));
        Facebook.Unity.FB.LogInWithReadPermissions(permissions:  FacebookPlugin.loginReadPermissions, callback:  240467968);
    }
    public static void RetrieveBasicInfo()
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        if((System.String.IsNullOrEmpty(value:  FacebookPlugin._userFbid)) == true)
        {
                return;
        }
        
        string val_3 = System.Uri.EscapeUriString(stringToEscape:  -1852873008);
        val_6 = "/me?fields=first_name,last_name,picture";
        if(new System.Object() != 0)
        {
                typeof(FacebookPlugin.<>c__DisplayClass47_0).__il2cppRuntimeField_8 = val_6;
        }
        else
        {
                mem[8] = val_6;
            val_6 = mem[8];
        }
        
        Facebook.Unity.FacebookDelegate<System.Object> val_4 = new Facebook.Unity.FacebookDelegate<System.Object>(object:  290041856, method:  new IntPtr(2442094448));
        Facebook.Unity.FB.API(query:  -1852873008, method:  0, callback:  240467968, formData:  0);
    }
    public static void GetUserFriends()
    {
        var val_2;
        Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> val_4;
        val_2 = null;
        val_2 = null;
        val_4 = FacebookPlugin.<>c.<>9__48_0;
        if(val_4 == 0)
        {
                val_4 = null;
            val_4 = new Facebook.Unity.FacebookDelegate<System.Object>(object:  FacebookPlugin.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2442207568));
            FacebookPlugin.<>c.<>9__48_0 = val_4;
        }
        
        Facebook.Unity.FB.API(query:  -1852759824, method:  0, callback:  240467968, formData:  0);
    }
    private static void NotifyRequestCompleted(FacebookPlugin.FBRequest request, bool success)
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        System.Collections.Hashtable val_2 = new System.Collections.Hashtable();
        0.PostNotification(aSender:  0, aName:  -2005054624, aData:  75878400);
    }
    public static void requestAppUserId()
    {
        if((FacebookPlugin.__il2cppRuntimeField_BB & 2) != 0)
        {
                return;
        }
    
    }
    public static void ShareDialog(string url, System.Action<bool> successCallback, string message = "Play this awesome game with me!")
    {
        var val_5;
        System.Action<System.Boolean> val_6;
        var val_7;
        var val_8;
        Facebook.Unity.FacebookDelegate<System.Object> val_9;
        val_5 = url;
        val_6 = successCallback;
        object val_1 = new System.Object();
        typeof(FacebookPlugin.<>c__DisplayClass51_0).__il2cppRuntimeField_8 = val_6;
        val_7 = null;
        val_7 = null;
        if(FacebookPlugin.initialized == false)
        {
                return;
        }
        
        if(val_5 == null)
        {
                AppConfigs val_2 = App.Configuration;
            val_8 = 872415232;
        }
        
        System.Uri val_3 = null;
        val_6 = val_3;
        val_3 = new System.Uri(uriString:  872415232);
        val_9 = null;
        val_9 = new Facebook.Unity.FacebookDelegate<System.Object>(object:  290095104, method:  new IntPtr(2442565072));
        Facebook.Unity.FB.ShareLink(contentURL:  103514112, contentTitle:  message, contentDescription:  null, photoURL:  0, callback:  val_9);
    }
    public static void FeedDialog(string toId = "", string linkToShare, System.Action<bool> successCallback)
    {
        object val_1 = new System.Object();
        typeof(FacebookPlugin.<>c__DisplayClass52_0).__il2cppRuntimeField_8 = successCallback;
        System.Uri val_2 = new System.Uri(uriString:  linkToShare);
        Facebook.Unity.FacebookDelegate<System.Object> val_3 = new Facebook.Unity.FacebookDelegate<System.Object>(object:  290148352, method:  new IntPtr(2442703696));
        Facebook.Unity.FB.FeedShare(toId:  toId, link:  103514112, linkName:  1098586544, linkCaption:  1098586544, linkDescription:  "", picture:  0, mediaSource:  "", callback:  null);
    }
    public static void PostScreenshot(byte[] screenshot)
    {
        var val_3;
        var val_4;
        Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> val_6;
        val_3 = null;
        val_3 = null;
        if(FacebookPlugin.initialized == false)
        {
                return;
        }
        
        UnityEngine.WWWForm val_1 = new UnityEngine.WWWForm();
        AddBinaryData(fieldName:  -1852101328, contents:  screenshot, fileName:  -1852101424);
        val_4 = null;
        val_4 = null;
        val_6 = FacebookPlugin.<>c.<>9__53_0;
        if(val_6 == 0)
        {
                val_6 = null;
            val_6 = new Facebook.Unity.FacebookDelegate<System.Object>(object:  FacebookPlugin.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2442866144));
            FacebookPlugin.<>c.<>9__53_0 = val_6;
        }
        
        Facebook.Unity.FB.API(query:  -1852101248, method:  1, callback:  240467968, formData:  175824896);
    }
    public static void AppInvite()
    {
        UnityEngine.Debug.LogError(message:  -1851951264);
    }
    public FacebookPlugin()
    {
    
    }
    private static FacebookPlugin()
    {
        FacebookPlugin.initialized = false;
        FacebookPlugin._userFbid = System.String.alignConst;
        FacebookPlugin._userAccessToken = System.String.alignConst;
        FacebookPlugin.accessTokenRefreshed = false;
        FacebookPlugin._userFbName = System.String.alignConst;
        FacebookPlugin.appFriendsIdsArray = false;
        FacebookPlugin.nextInvitableFriends = System.String.alignConst;
        FacebookPlugin.nextInvitableFriendsCount = false;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        FacebookPlugin.loginReadPermissions = null;
        FacebookPlugin.AvailableTasks = new System.Collections.Generic.List<WordPets.WordPetType>();
        FacebookPlugin.CompletedTasks = new System.Collections.Generic.List<WordPets.WordPetType>();
    }

}
