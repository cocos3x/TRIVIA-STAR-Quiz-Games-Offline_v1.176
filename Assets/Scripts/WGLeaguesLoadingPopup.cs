using UnityEngine;
public class WGLeaguesLoadingPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Text hintText;
    public bool isFlyout;
    private static bool loadingLeagues;
    public System.Action onLeaguesExitAction;
    
    // Properties
    public static bool LoadingLeagues { get; }
    private System.Collections.Generic.List<string[]> hints { get; }
    
    // Methods
    public static bool get_LoadingLeagues()
    {
        null = null;
        return (bool)WGLeaguesLoadingPopup.loadingLeagues;
    }
    private System.Collections.Generic.List<string[]> get_hints()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    private void Start()
    {
        var val_5;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_2 = new System.Action<Result>(object:  -1724837504, method:  new IntPtr(2570104768));
        System.Delegate val_3 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10, b:  7401472);
        val_5 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10;
        if(val_5 != 0)
        {
                if(val_5 == null)
        {
            goto label_6;
        }
        
        }
        
        val_5 = 0;
        label_6:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10 = val_5;
        NotificationCenter val_4 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1724837504, name:  -1915250464);
    }
    private void OnSceneUnloaded(SceneType sceneType)
    {
        if(sceneType != 4)
        {
                return;
        }
        
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1724721408, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnEnable()
    {
        var val_10;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        TakeCameraStateSnapshot();
        System.Collections.Generic.List<System.String[]> val_2 = hints;
        System.Collections.Generic.List<System.String[]> val_3 = hints;
        int val_4 = UnityEngine.Random.Range(min:  0, max:  public static CameraManagerUGUI MonoSingletonSelfGenerating<CameraManagerUGUI>::get_Instance().__il2cppRuntimeField_C);
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_10 = mem[(public static CameraManagerUGUI MonoSingletonSelfGenerating<CameraManagerUGUI>::get_Instance().__il2cppRuntimeField_8 + (val_4) << 2) + 16 + 12];
        val_10 = (public static CameraManagerUGUI MonoSingletonSelfGenerating<CameraManagerUGUI>::get_Instance().__il2cppRuntimeField_8 + (val_4) << 2) + 16 + 12;
        if(val_10 == 0)
        {
                val_10 = mem[(public static CameraManagerUGUI MonoSingletonSelfGenerating<CameraManagerUGUI>::get_Instance().__il2cppRuntimeField_8 + (val_4) << 2) + 16 + 12];
            val_10 = (public static CameraManagerUGUI MonoSingletonSelfGenerating<CameraManagerUGUI>::get_Instance().__il2cppRuntimeField_8 + (val_4) << 2) + 16 + 12;
        }
        
        string val_6 = Localization.Localize(key:  (public static CameraManagerUGUI MonoSingletonSelfGenerating<CameraManagerUGUI>::get_Instance().__il2cppRuntimeField_8 + (val_4) << 2) + 16 + 16, defaultValue:  (public static CameraManagerUGUI MonoSingletonSelfGenerating<CameraManagerUGUI>::get_Instance().__il2cppRuntimeField_8 + (val_4) << 2) + 16 + 20, useSingularKey:  false);
        NotificationCenter val_7 = NotificationCenter.DefaultCenter;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        0.PostNotification(aSender:  -1724601216, aName:  442544128);
        this.StopAllCoroutines();
        System.Collections.IEnumerator val_8 = this.DelayLoadLeagues();
        UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  -1724601216);
    }
    private System.Collections.IEnumerator DelayLoadLeagues()
    {
        object val_1 = new System.Object();
        typeof(WGLeaguesLoadingPopup.<DelayLoadLeagues>d__11).__il2cppRuntimeField_8 = 0;
        typeof(WGLeaguesLoadingPopup.<DelayLoadLeagues>d__11).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator OnDataUpdate()
    {
        object val_1 = new System.Object();
        typeof(WGLeaguesLoadingPopup.<OnDataUpdate>d__12).__il2cppRuntimeField_8 = 0;
        typeof(WGLeaguesLoadingPopup.<OnDataUpdate>d__12).__il2cppRuntimeField_10 = this;
    }
    private void OnNetworkConnectivityResponse()
    {
        var val_1;
        var val_1 = 28704845;
        val_1 = 6922580 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        if(NetworkConnectivityPinger.NOTIF_NETWORK_CONNECT_RESPONSE != null)
        {
                return;
        }
        
        R4.OnError_Null_Response();
    }
    private void OnError_Null_Response()
    {
        var val_8;
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        0.RemoveObserver(observer:  -1724147392, name:  442544128);
        UnityEngine.GameObject val_2 = this.gameObject;
        SLCWindow.CloseWindow(window:  -1724147392, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = ShowUGUIMonolith<System.Object>(showNext:  true);
        string val_5 = Localization.Localize(key:  -1724172096, defaultValue:  -1724171984, useSingularKey:  false);
        string val_6 = Localization.Localize(key:  -1724171872, defaultValue:  -1724171744, useSingularKey:  false);
        typeof(System.Boolean[]).__il2cppRuntimeField_10 = 1;
        string val_7 = Localization.Localize(key:  -1724171600, defaultValue:  -1724171488, useSingularKey:  false);
        typeof(System.String[]).__il2cppRuntimeField_10 = "return_home_upper";
        typeof(System.String[]).__il2cppRuntimeField_14 = "";
        val_8 = null;
        val_8 = null;
        SetupMessage(titleTxt:  -1724172096, messageTxt:  -1724171872, shownButtons:  1054454320, buttonTexts:  null, showClose:  false, buttonCallbacks:  0, collectAmount:  new System.Decimal() {flags = System.Decimal.MinusOne}, collectType:  "credits");
    }
    private System.Collections.IEnumerator WaitLoadLeagues()
    {
        object val_1 = new System.Object();
        typeof(WGLeaguesLoadingPopup.<WaitLoadLeagues>d__15).__il2cppRuntimeField_8 = 0;
        typeof(WGLeaguesLoadingPopup.<WaitLoadLeagues>d__15).__il2cppRuntimeField_10 = this;
    }
    private void OnDisable()
    {
        var val_5;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_2 = new System.Action<Result>(object:  -1723914880, method:  new IntPtr(2570104768));
        System.Delegate val_3 = System.Delegate.Remove(source:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10, value:  7401472);
        val_5 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10;
        if(val_5 != 0)
        {
                if(val_5 == null)
        {
            goto label_6;
        }
        
        }
        
        val_5 = 0;
        label_6:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10 = val_5;
        NotificationCenter val_4 = NotificationCenter.DefaultCenter;
        0.RemoveObserver(observer:  -1723914880, name:  -1915250464);
        if(this.isFlyout == false)
        {
            goto label_10;
        }
        
        if(this.onLeaguesExitAction == 0)
        {
            goto label_14;
        }
        
        UnityEngine.Debug.LogError(message:  -1723943296);
        label_10:
        if(this.onLeaguesExitAction != 0)
        {
                this.onLeaguesExitAction.Invoke();
        }
        
        label_14:
        this.onLeaguesExitAction = 0;
    }
    public WGLeaguesLoadingPopup()
    {
    
    }
    private static WGLeaguesLoadingPopup()
    {
    
    }

}
