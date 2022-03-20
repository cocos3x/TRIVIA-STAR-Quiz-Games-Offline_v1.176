using UnityEngine;
public class WGRestoreProgressionPopup : MonoBehaviour
{
    // Fields
    private WGPreviousProgressionPopup progressionPopup;
    private WGEmailLoginPopup emailLoginPopup;
    private UnityEngine.GameObject initLoginGroup;
    private UGUINetworkedButton appleSignInButton;
    private UGUINetworkedButton emailLogInButton;
    private UnityEngine.UI.Text versionText;
    private UnityEngine.UI.Text supportIDText;
    private UnityEngine.GameObject loggedGroup;
    private UnityEngine.UI.Button logoutButton;
    private UnityEngine.UI.Button continueButton;
    private UnityEngine.UI.Text loggedText;
    private UnityEngine.UI.Text l_versionText;
    private UnityEngine.UI.Text l_supportIDText;
    private UnityEngine.GameObject confirmLogoutGroup;
    private UnityEngine.UI.Button confirmLogoutButton;
    private UnityEngine.UI.Button cancelLogoutButton;
    private UnityEngine.GameObject loadingGroup;
    private UnityEngine.UI.Text titleLoading;
    private UnityEngine.UI.Text textLoading;
    private UnityEngine.GameObject reminderGroup;
    private UnityEngine.UI.Button signInButton;
    private System.Collections.Generic.List<UnityEngine.GameObject> loginGroups;
    private WGRestoreProgressionPopup.State currentState;
    private bool <showReminder>k__BackingField;
    
    // Properties
    public bool showReminder { get; set; }
    
    // Methods
    public bool get_showReminder()
    {
        return (bool)this.<showReminder>k__BackingField;
    }
    public void set_showReminder(bool value)
    {
        this.<showReminder>k__BackingField = value;
    }
    private void Awake()
    {
        System.Action<System.Boolean> val_19;
        System.Action<System.Boolean> val_20;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  this.loadingGroup);
        Add(item:  this.initLoginGroup);
        Add(item:  this.loggedGroup);
        Add(item:  this.confirmLogoutGroup);
        UnityEngine.GameObject val_2 = this.emailLoginPopup.gameObject;
        Add(item:  this.emailLoginPopup);
        UnityEngine.GameObject val_3 = this.progressionPopup.gameObject;
        Add(item:  this.progressionPopup);
        Add(item:  this.reminderGroup);
        this.loginGroups = null;
        System.Action<System.Boolean> val_4 = new System.Action<System.Boolean>(object:  -215075888, method:  new IntPtr(4079792656));
        System.Delegate val_5 = System.Delegate.Combine(a:  this.appleSignInButton.OnConnectionClick, b:  7401472);
        val_19 = this.appleSignInButton.OnConnectionClick;
        if(val_19 != 0)
        {
                if(null == null)
        {
            goto label_13;
        }
        
        }
        
        val_19 = 0;
        label_13:
        this.appleSignInButton.OnConnectionClick = val_19;
        System.Action<System.Boolean> val_6 = new System.Action<System.Boolean>(object:  -215075888, method:  new IntPtr(4079801872));
        System.Delegate val_7 = System.Delegate.Combine(a:  this.emailLogInButton.OnConnectionClick, b:  7401472);
        val_20 = this.emailLogInButton.OnConnectionClick;
        if(val_20 != 0)
        {
                if(null == null)
        {
            goto label_17;
        }
        
        }
        
        val_20 = 0;
        label_17:
        this.emailLogInButton.OnConnectionClick = val_20;
        UnityEngine.Events.UnityAction val_8 = new UnityEngine.Events.UnityAction(object:  -215075888, method:  new IntPtr(4079811088));
        this.logoutButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_9 = new UnityEngine.Events.UnityAction(object:  -215075888, method:  new IntPtr(4079820304));
        this.continueButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_10 = new UnityEngine.Events.UnityAction(object:  -215075888, method:  new IntPtr(4079829520));
        this.confirmLogoutButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_11 = new UnityEngine.Events.UnityAction(object:  -215075888, method:  new IntPtr(4079838736));
        this.cancelLogoutButton.m_OnClick.AddListener(call:  162246656);
        System.Action<Result> val_12 = new System.Action<Result>(object:  -215075888, method:  new IntPtr(4079843856));
        this.progressionPopup.add_OnClickButton(value:  7401472);
        System.Action<System.Boolean> val_13 = new System.Action<System.Boolean>(object:  -215075888, method:  new IntPtr(4079850000));
        this.emailLoginPopup.add_OnLoginAction(value:  7401472);
        UnityEngine.Events.UnityAction val_14 = new UnityEngine.Events.UnityAction(object:  -215075888, method:  new IntPtr(4079859216));
        this.signInButton.m_OnClick.AddListener(call:  162246656);
        System.Action<System.Boolean> val_15 = new System.Action<System.Boolean>(object:  -215075888, method:  new IntPtr(4079860240));
        RestoreProgressManager.add_OnServerError(value:  7401472);
        System.Action<Result> val_16 = new System.Action<Result>(object:  -215075888, method:  new IntPtr(4079861264));
        RestoreProgressManager.add_OnImportResponded(value:  7401472);
        UnityEngine.GameObject val_17 = this.appleSignInButton.gameObject;
        this.appleSignInButton.SetActive(value:  SignInWithApplePlugin.IsSupported());
    }
    private void OnEnable()
    {
        var val_8;
        string val_1 = DeviceIdPlugin.GetClientVersion();
        Player val_2 = App.Player;
        val_8 = null;
        val_8 = null;
        if(App.networkManager.Reachable() != false)
        {
                WGBonusRewardsHandler val_4 = DefaultHandler<WGBonusRewardsHandler>.Instance;
            RequestDataFlush(immediate:  false, reset:  false);
        }
        
        if(RestoreProgressManager.HasPreviousProgression != false)
        {
                this.UpdateState(state:  3);
            return;
        }
        
        if((this.<showReminder>k__BackingField) != false)
        {
                this.UpdateState(state:  6);
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_7 = IsLoggedIn;
        if(val_7 == false)
        {
                0 = 0;
        }
        
        if(val_7 == true)
        {
                0 = 4;
        }
        
        this.UpdateState(state:  4);
    }
    private void OnDestroy()
    {
        System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  -214720816, method:  new IntPtr(4079860240));
        RestoreProgressManager.remove_OnServerError(value:  7401472);
        System.Action<Result> val_2 = new System.Action<Result>(object:  -214720816, method:  new IntPtr(4079861264));
        RestoreProgressManager.remove_OnImportResponded(value:  7401472);
    }
    public void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -214608816, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    private void OnClickAppleSignin(bool connected)
    {
        if(connected != false)
        {
                System.Action<System.Boolean> val_1 = new System.Action<System.Boolean>(object:  -214495792, method:  new IntPtr(4080446480));
            SignInWithApplePlugin.add_OnSignInComplete(value:  7401472);
            WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            LogIn();
            return;
        }
        
        this.ShowInternetError(isWebException:  true);
    }
    private void OnAppleSignin(bool success)
    {
        System.Action<System.Boolean> val_6 = null;
        val_6 = new System.Action<System.Boolean>(object:  -214383792, method:  new IntPtr(4080446480));
        SignInWithApplePlugin.remove_OnSignInComplete(value:  7401472);
        if(success == false)
        {
            goto label_3;
        }
        
        val_6 = 1152921504892043264;
        Player val_2 = App.Player;
        if((System.String.IsNullOrEmpty(value:  static_value_00280180)) == false)
        {
            goto label_8;
        }
        
        label_3:
        this.UpdateState(state:  0);
        return;
        label_8:
        this.ShowLoadingView();
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Player val_5 = App.Player;
        OnAppleLogin(appleUserId:  static_value_00280180);
    }
    private void OnClickLogout()
    {
        this.UpdateState(state:  5);
    }
    private void OnClickEmailLogin(bool connected)
    {
        if(connected != false)
        {
                this.UpdateState(state:  1);
            return;
        }
        
        this.ShowInternetError(isWebException:  true);
    }
    private void OnClickConfirmLogout()
    {
        this.ShowLoadingView();
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        LogoutRequest();
    }
    private void OnClickCancelLogout()
    {
        this.UpdateState(state:  4);
    }
    private void OnClickClose()
    {
    
    }
    private void OnLoginAction(bool waitRequest)
    {
        if(waitRequest != false)
        {
                this.ShowLoadingView();
            return;
        }
        
        this.UpdateState(state:  0);
    }
    private void OnClickProgressionPopup(WGPreviousProgressionPopup.Result result)
    {
        var val_4;
        this.ShowLoadingView();
        if(result == 2)
        {
            goto label_1;
        }
        
        if(result == 1)
        {
            goto label_2;
        }
        
        if(result != 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_4 = 1;
        goto label_7;
        label_1:
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        LogoutRequest();
        return;
        label_2:
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_4 = 0;
        label_7:
        ConfirmImport(importProgression:  false);
    }
    private void OnServerResponded(RestoreProgressManager.ServerResponse response)
    {
        if(response > 4)
        {
                return;
        }
        
        var val_1 = 6955876 + (6955876 + (response) << 2);
        if(response == 4)
        {
                this = this & ((IP) << this);
            this = this & ((R4) << (this & (IP) << this));
            this = this & ((R4) << ((this & (IP) << this) & (R4) << (this & (IP) << this)));
            this = this & ((IP) >> 32);
            this = this & ((R4) >> 32);
        }
        
        this.UpdateState(state:  4);
    }
    private void UpdateState(WGRestoreProgressionPopup.State state)
    {
        var val_3;
        UnityEngine.GameObject val_11;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_4:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        val_3.SetActive(value:  false);
        goto label_4;
        label_2:
        Dispose();
        this.currentState = state;
        if(state > 6)
        {
                return;
        }
        
        var val_4 = 6952076 + (6952076 + (state) << 2);
        if(state == 6)
        {
                6952076 = 6952076 & ((IP) << 6952076);
            6952076 = 6952076 & (6952076 << 3);
            mem2[0] = ((6952076 & (IP) << 6952076) & ((6952076 & (IP) << 6952076)) << 3) + ((6952076 & (IP) << 6952076) & ((6952076 & (IP) << 6952076)) << 3);
            (((6952076 & (IP) << 6952076) & ((6952076 & (IP) << 6952076)) << 3) + ((6952076 & (IP) << 6952076) & ((6952076 & (IP) << 6952076)) << 3)) & ((IP) << 2) = ((((6952076 & (IP) << 6952076) & ((6952076 & (IP) << 6952076)) << 3) + ((6952076 & (IP) << 6952076) & ((6952076 & (IP) << 6952076)) << 3)) & ((IP) << 2)) & 36203048;
            (((6952076 & (IP) << 6952076) & ((6952076 & (IP) << 6952076)) << 3) + ((6952076 & (IP) << 6952076) & ((6952076 & (IP) << 6952076)) << 3)) & ((IP) << 2) = ((((6952076 & (IP) << 6952076) & ((6952076 & (IP) << 6952076)) << 3) + ((6952076 & (IP) << 6952076) & ((6952076 & (IP) << 6952076)) << 3)) & ((IP) << 2)) & 4525381;
            mem2[0] = (((((6952076 & (IP) << 6952076) & ((6952076 & (IP) << 6952076)) << 3) + ((6952076 & (IP) << 6952076) & ((6952076 & (IP) << 6952076)) << 3) & (IP) << 2) & 36203048) & 4525381) + 1152921512022411200;
        }
        
        val_11 = this.initLoginGroup;
        goto label_11;
        label_23:
        label_22:
        SetActive(value:  true);
        return;
        label_11:
        if( != 0)
        {
            goto label_22;
        }
        
        goto label_23;
    }
    private void ShowLoadingView()
    {
        var val_3;
        var val_9;
        UnityEngine.UI.Text val_10;
        var val_11;
        var val_12;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_4:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        val_3.SetActive(value:  false);
        goto label_4;
        label_2:
        Dispose();
        this.loadingGroup.SetActive(value:  true);
        if((this.currentState - 2) < 2)
        {
                string val_5 = Localization.Localize(key:  -213176576, defaultValue:  -213176688, useSingularKey:  false);
            val_9 = "updating_progress_upper";
            val_10 = this.textLoading;
            val_11 = "Please wait while we update your progress. It may take a while.";
            val_12 = "updating_loading_text";
        }
        else
        {
                if(this.currentState == 5)
        {
                string val_6 = Localization.Localize(key:  -213167856, defaultValue:  -213167936, useSingularKey:  false);
            val_9 = "logout_upper";
            val_10 = this.textLoading;
            val_11 = "Please wait while we update your saved progress. It may take a while.";
            val_12 = "logout_loading_text";
        }
        else
        {
                string val_7 = Localization.Localize(key:  -213159136, defaultValue:  -213159248, useSingularKey:  false);
            val_9 = "checking_progress_upper";
            val_10 = this.textLoading;
            val_11 = "Please wait while we check your saved progress. It may take a while.";
            val_12 = "loading_text";
        }
        
        }
        
        string val_8 = Localization.Localize(key:  -213150608, defaultValue:  -213150816, useSingularKey:  false);
        if(val_10 != 0)
        {
                return;
        }
    
    }
    private void ShowInternetError(bool isWebException)
    {
        var val_5;
        System.Func<System.Boolean> val_7;
        if((this.currentState == 3) && (isWebException != true))
        {
                this.UpdateState(state:  this.currentState);
            if(this.currentState != 2)
        {
                return;
        }
        
            this.emailLoginPopup.ShowAlertMessage(errorCode:  true);
            return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
        val_5 = null;
        val_5 = null;
        val_7 = WGRestoreProgressionPopup.<>c.<>9__44_0;
        if(val_7 == 0)
        {
                val_7 = null;
            val_7 = new System.Func<System.Boolean>(object:  WGRestoreProgressionPopup.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4081977936));
            WGRestoreProgressionPopup.<>c.<>9__44_0 = val_7;
        }
        
        typeof(System.Func<System.Boolean>[]).__il2cppRuntimeField_10 = val_7;
        SetupInternetRequired(buttonCallbacks:  2129277568);
        UnityEngine.GameObject val_4 = this.gameObject;
        SLCWindow.CloseWindow(window:  -212964336, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGRestoreProgressionPopup()
    {
    
    }
    private void <Awake>b__28_0()
    {
        this.UpdateState(state:  0);
    }

}
