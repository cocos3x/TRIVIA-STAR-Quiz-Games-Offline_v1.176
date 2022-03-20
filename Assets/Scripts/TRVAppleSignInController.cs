using UnityEngine;
public class TRVAppleSignInController : MonoBehaviour
{
    // Fields
    private UGUINetworkedButton appleSignInButton;
    
    // Methods
    private void Awake()
    {
        System.Action<System.Boolean> val_10;
        System.Action<System.Boolean> val_11;
        bool val_12;
        System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  -560836000, method:  new IntPtr(3734101152));
        System.Delegate val_2 = System.Delegate.Combine(a:  this.appleSignInButton.OnConnectionClick, b:  7401472);
        val_10 = this.appleSignInButton.OnConnectionClick;
        val_11 = null;
        if(val_10 == 0)
        {
            goto label_3;
        }
        
        if(null == val_11)
        {
            goto label_4;
        }
        
        val_11 = null;
        label_3:
        val_10 = 0;
        label_4:
        this.appleSignInButton.OnConnectionClick = val_10;
        val_11 = new System.Action<System.Boolean>(object:  -560836000, method:  new IntPtr(3734102176));
        RestoreProgressManager.add_OnServerError(value:  7401472);
        val_12 = 0;
        UnityEngine.GameObject val_4 = this.appleSignInButton.gameObject;
        if(SignInWithApplePlugin.IsSupported() != false)
        {
                val_12 = FacebookPlugin.IsLoggedIn ^ 1;
        }
        
        this.appleSignInButton.SetActive(value:  val_12);
        if(SignInWithApplePlugin.IsSupported() == false)
        {
                return;
        }
        
        if(SignInWithApplePlugin.IsLoggedIn == false)
        {
                return;
        }
        
        this.SetButtonSignedIn();
    }
    private void OnEnable()
    {
        var val_3;
        var val_3 = 29344930;
        val_3 = 6281128 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        if(App.networkManager.Reachable() == false)
        {
                return;
        }
        
        WGBonusRewardsHandler val_2 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        RequestDataFlush(immediate:  false, reset:  false);
    }
    private void OnClickAppleSignin(bool connected)
    {
        if(connected != false)
        {
                System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  -560598688, method:  new IntPtr(3734343584));
            SignInWithApplePlugin.add_OnSignInComplete(value:  7401472);
            WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            LogIn();
            return;
        }
        
        this.ShowInternetError(isWebException:  false);
    }
    private void OnAppleSignin(bool success)
    {
        System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  -560484640, method:  new IntPtr(3734343584));
        SignInWithApplePlugin.remove_OnSignInComplete(value:  7401472);
        if(success != false)
        {
                Player val_2 = App.Player;
            if((System.String.IsNullOrEmpty(value:  static_value_00280180)) != true)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Player val_5 = App.Player;
            OnAppleLogin(appleUserId:  static_value_00280180);
        }
        
        }
        
        this.SetButtonSignedIn();
        UnityEngine.GameObject val_6 = this.gameObject;
        object val_7 = this.GetComponent<System.Object>();
        if((-560484640) == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_9 = this.gameObject;
        object val_10 = this.GetComponent<System.Object>();
        this.SetFacebookButtons();
    }
    private void SetButtonSignedIn()
    {
        this.appleSignInButton.interactable = false;
    }
    private void ShowInternetError(bool isWebException)
    {
        var val_5;
        System.Func<System.Boolean> val_7;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
        val_5 = null;
        val_5 = null;
        val_7 = TRVAppleSignInController.<>c.<>9__6_0;
        if(val_7 == 0)
        {
                val_7 = null;
            val_7 = new System.Func<System.Boolean>(object:  TRVAppleSignInController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3734690848));
            TRVAppleSignInController.<>c.<>9__6_0 = val_7;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_7;
        SetupInternetRequired(buttonCallbacks:  2129277568);
        UnityEngine.GameObject val_4 = this.gameObject;
        SLCWindow.CloseWindow(window:  -560251424, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnDestroy()
    {
        System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  -560139424, method:  new IntPtr(3734102176));
        RestoreProgressManager.remove_OnServerError(value:  7401472);
    }
    public void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -560027424, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public TRVAppleSignInController()
    {
    
    }

}
