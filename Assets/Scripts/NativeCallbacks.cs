using UnityEngine;
public class NativeCallbacks : MonoSingleton<NativeCallbacks>
{
    // Fields
    private static bool created;
    private static bool tokenReceived;
    private static int remoteCount;
    private static UnityEngine.GameObject objectContainer;
    private static bool sentLowMemoryWarning;
    
    // Methods
    public override void InitMonoSingleton()
    {
        null = null;
        NativeCallbacks.created = true;
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  -1994013296);
        UnityEngine.GameObject val_2 = this.gameObject;
        NativeCallbacks.objectContainer = this;
        NotificationCenter val_3 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1994013296, name:  -2037002944);
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_4 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  -1994013296, method:  new IntPtr(2300928976));
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  162459648);
        LoadingDialogPlugin.RemoveView();
    }
    private void OnDestroy()
    {
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  -1993901296, method:  new IntPtr(2300928976));
        UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  162459648);
    }
    private void Update()
    {
        null = null;
        if(NativeCallbacks.tokenReceived == true)
        {
                return;
        }
        
        NativeCallbacks.tokenReceived.updateDeviceToken();
    }
    private void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode)
    {
        null = null;
        UnityEngine.GameObject val_1 = this.gameObject;
        if(NativeCallbacks.objectContainer != (-1993673200))
        {
                UnityEngine.GameObject val_3 = this.gameObject;
            UnityEngine.Object.Destroy(obj:  -1993673200);
        }
        
        this.CancelInvoke();
    }
    private void OnDeferredReady()
    {
        FacebookPlugin.SendAccessToken();
    }
    private int tapMultiplier(int taps)
    {
        return (int)taps;
    }
    private void OnAdxReferral(string referral)
    {
        var val_3;
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1993352928, defaultValue:  -1993353008);
        if((System.String.op_Inequality(a:  -1993352928, b:  -1993353008)) != false)
        {
                return;
        }
        
        var val_3 = 27633586;
        val_3 = 7991952 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        App.trackerManager.superProperty(propertyName:  -1993352832, propertyValue:  referral);
        UnityEngine.PlayerPrefs.SetString(key:  -1993352928, value:  referral);
    }
    public void OnAppRated(string message)
    {
    
    }
    private void OnFacebookRequestAppUserId(string message)
    {
        bool val_1 = System.String.IsNullOrEmpty(value:  message);
        bool val_2 = System.String.op_Equality(a:  message, b:  -1993112352);
        UnityEngine.PlayerPrefs.SetString(key:  -1993112272, value:  "sent" = message);
    }
    private static void setVideoWatcher()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1992995984)) == true)
        {
                return;
        }
        
        UnityEngine.PlayerPrefs.SetInt(key:  R4, value:  1);
    }
    public static void OnLowMemory(string usageRatio)
    {
    
    }
    private void updateMetaData(string message)
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        UpdateMetadata();
    }
    private void handleRemoteNotification(string issueId)
    {
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        handleRemoteNotification(issueId:  issueId);
    }
    private void updateDeviceToken()
    {
        var val_3;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        val_3 = null;
        val_3 = null;
        NativeCallbacks.tokenReceived = UpdateDeviceToken();
    }
    private void ReceivedLowMemWarning(string fromNative)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(NativeCallbacks.sentLowMemoryWarning == true)
        {
                return;
        }
        
        string val_1 = -1992406192(-1992406192) + R4;
        UnityEngine.Debug.LogError(message:  -1992406192);
        val_3 = mem[R5];
        val_3 = R5;
        if((((R5 + 187) & 2) == 0) && ((R5 + 116) == 0))
        {
                val_3 = mem[R5];
            val_3 = R5;
        }
        
        mem2[0] = 1;
    }
    private void IOSDidRegisterForNotifications(string message)
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -1992261712, aName:  -1992285840);
    }
    public NativeCallbacks()
    {
    
    }
    private static NativeCallbacks()
    {
    
    }

}
