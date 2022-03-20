using UnityEngine;
public class RestoreProgressManager : MonoSingleton<RestoreProgressManager>
{
    // Fields
    public const string PREVIOUS_PROGRESSION = "rpm_previous_progression";
    public const string SIGNIN_REMINDER_SHOWN = "rpm_sign_in_reminder_shown";
    private const int REQUEST_TIMEOUT = 20;
    private static System.Action<bool> OnServerError;
    private static System.Action<RestoreProgressManager.ServerResponse> OnImportResponded;
    private RestoreProgressManager.Progression <previousProgression>k__BackingField;
    private RestoreProgressManager.LoginMethod <loginMethod>k__BackingField;
    
    // Properties
    public static bool HasPreviousProgression { get; }
    public RestoreProgressManager.Progression previousProgression { get; set; }
    public RestoreProgressManager.LoginMethod loginMethod { get; set; }
    public bool IsLoggedIn { get; }
    public bool ReminderPopupShown { get; set; }
    
    // Methods
    public static void add_OnServerError(System.Action<bool> value)
    {
        var val_2;
        System.Delegate val_1 = System.Delegate.Combine(a:  RestoreProgressManager.OnServerError, b:  value);
        if(RestoreProgressManager.OnServerError != 0)
        {
                val_2 = RestoreProgressManager.OnServerError;
            if(null == null)
        {
                return;
        }
        
        }
        
        val_2 = 0;
    }
    public static void remove_OnServerError(System.Action<bool> value)
    {
        var val_2;
        System.Delegate val_1 = System.Delegate.Remove(source:  RestoreProgressManager.OnServerError, value:  value);
        if(RestoreProgressManager.OnServerError != 0)
        {
                val_2 = RestoreProgressManager.OnServerError;
            if(null == null)
        {
                return;
        }
        
        }
        
        val_2 = 0;
    }
    public static void add_OnImportResponded(System.Action<RestoreProgressManager.ServerResponse> value)
    {
        var val_2;
        label_3:
        System.Delegate val_1 = System.Delegate.Combine(a:  RestoreProgressManager.OnImportResponded, b:  value);
        if(RestoreProgressManager.OnImportResponded == 0)
        {
            goto label_1;
        }
        
        val_2 = RestoreProgressManager.OnImportResponded;
        if(null == null)
        {
            goto label_2;
        }
        
        label_1:
        val_2 = 0;
        label_2:
        if(RestoreProgressManager.OnImportResponded != 1152921504985071620)
        {
            goto label_3;
        }
    
    }
    public static void remove_OnImportResponded(System.Action<RestoreProgressManager.ServerResponse> value)
    {
        var val_2;
        label_3:
        System.Delegate val_1 = System.Delegate.Remove(source:  RestoreProgressManager.OnImportResponded, value:  value);
        if(RestoreProgressManager.OnImportResponded == 0)
        {
            goto label_1;
        }
        
        val_2 = RestoreProgressManager.OnImportResponded;
        if(null == null)
        {
            goto label_2;
        }
        
        label_1:
        val_2 = 0;
        label_2:
        if(RestoreProgressManager.OnImportResponded != 1152921504985071620)
        {
            goto label_3;
        }
    
    }
    public static bool get_HasPreviousProgression()
    {
        return UnityEngine.PlayerPrefs.HasKey(key:  -222606512);
    }
    public RestoreProgressManager.Progression get_previousProgression()
    {
    
    }
    private void set_previousProgression(RestoreProgressManager.Progression value)
    {
        this.<previousProgression>k__BackingField = value;
    }
    public RestoreProgressManager.LoginMethod get_loginMethod()
    {
    
    }
    private void set_loginMethod(RestoreProgressManager.LoginMethod value)
    {
        this.<loginMethod>k__BackingField = value;
    }
    public bool get_IsLoggedIn()
    {
        if((this.<loginMethod>k__BackingField) != 0)
        {
                this.<loginMethod>k__BackingField = 1;
        }
        
        return true;
    }
    public bool get_ReminderPopupShown()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  -221893424)) == false)
        {
                return true;
        }
        
        if((UnityEngine.PlayerPrefs.GetInt(key:  -221893424, defaultValue:  0)) > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public void set_ReminderPopupShown(bool value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -221893424, value:  value);
    }
    private void Start()
    {
        this.UpdateLoginStatus();
    }
    public override void InitMonoSingleton()
    {
        this.InitMonoSingleton();
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -221531248, name:  -1976323520);
        if((UnityEngine.PlayerPrefs.HasKey(key:  -222606512)) == false)
        {
                return;
        }
        
        string val_3 = UnityEngine.PlayerPrefs.GetString(key:  R5, defaultValue:  -2040381152);
        object val_4 = JsonSerializable<System.Object>.Deserialize(serialized:  R5);
        mem2[0] = R5;
    }
    public void OnServerResponded()
    {
        this.UpdateLoginStatus();
    }
    public void OnEmailLogin(string email)
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1931027184, value:  email);
        this.LoginRequest(loginData:  78753792);
    }
    public void OnAppleLogin(string appleUserId)
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1924037568, value:  appleUserId);
        this.LoginRequest(loginData:  78753792);
    }
    public void ConfirmVerificationCode(string code)
    {
        var val_6;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  1495693168, value:  code);
        Player val_2 = App.Player;
        Add(key:  -1931027184, value:  34483956);
        Player val_3 = App.Player;
        string val_4 = System.String.Format(format:  -221086768, arg0:  1835037);
        val_6 = null;
        val_6 = null;
        System.Action<System.Threading.Tasks.Task, System.Object> val_5 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -221061616, method:  new IntPtr(4073880656));
        App.networkManager.DoPut(path:  -221086768, postBody:  78753792, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false);
    }
    public void ConfirmImport(bool importProgression)
    {
        var val_5;
        if(importProgression != true)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -222606512);
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -220969520, value:  13152256);
        Player val_2 = App.Player;
        string val_3 = System.String.Format(format:  -220969440, arg0:  1835037);
        val_5 = null;
        val_5 = null;
        System.Action<System.Threading.Tasks.Task, System.Object> val_4 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -220945328, method:  new IntPtr(4073880656));
        App.networkManager.DoPut(path:  -220969440, postBody:  78753792, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false);
    }
    public void LogoutRequest()
    {
        var val_8;
        Player val_1 = App.Player;
        mem[160] = System.String.alignConst;
        Player val_2 = App.Player;
        if((this.<loginMethod>k__BackingField) == 2)
        {
                WordPets.WPTDataParser val_3 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            Logout();
        }
        
        UnityEngine.PlayerPrefs.DeleteKey(key:  -222606512);
        Player val_4 = App.Player;
        0.SaveState();
        Player val_5 = App.Player;
        string val_6 = System.String.Format(format:  -220969440, arg0:  1835037);
        val_8 = null;
        val_8 = null;
        System.Action<System.Threading.Tasks.Task, System.Object> val_7 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -220829232, method:  new IntPtr(4073880656));
        App.networkManager.DoDelete(path:  -220969440, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false, deleteParams:  0);
    }
    public bool ShouldShowReminder()
    {
        if((this.<loginMethod>k__BackingField) != 0)
        {
                return false;
        }
        
        Player val_1 = App.Player;
        if(0 < 85)
        {
                return false;
        }
        
        bool val_2 = this.ReminderPopupShown;
        val_2 = val_2 ^ 1;
        return (bool)val_2;
    }
    public void ShowSignInReminder()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_68 = 1;
        this.ReminderPopupShown = true;
        bool val_3 = PrefsSerializationManager.SavePlayerPrefs();
    }
    private void UpdateLoginStatus()
    {
        var val_11;
        if((this.<loginMethod>k__BackingField) != 0)
        {
                this.<loginMethod>k__BackingField = 1;
        }
        
        typeof(System.String[]).__il2cppRuntimeField_10 = "verifiedEmail: ";
        Player val_1 = App.Player;
        var val_2 = 2621448 + 380;
        string val_3 = val_2.ToString();
        typeof(System.String[]).__il2cppRuntimeField_14 = val_2;
        typeof(System.String[]).__il2cppRuntimeField_18 = " Email: ";
        Player val_4 = App.Player;
        typeof(System.String[]).__il2cppRuntimeField_1C = 34483956;
        typeof(System.String[]).__il2cppRuntimeField_20 = " wasLoggedIn: ";
        string val_5 = 1.ToString();
        typeof(System.String[]).__il2cppRuntimeField_24 = ;
        string val_6 = +477709520;
        val_11 = 1152921504758390784;
        UnityEngine.Debug.Log(message:  477709520);
        this.<loginMethod>k__BackingField = 0;
        Player val_7 = App.Player;
        Player val_8 = App.Player;
        if((System.String.IsNullOrEmpty(value:  34483956)) != false)
        {
                if(SignInWithApplePlugin.IsLoggedIn == true)
        {
                this.<loginMethod>k__BackingField = 2;
        }
        
        }
        else
        {
                this.<loginMethod>k__BackingField = 1;
        }
        
        if(1 == 0)
        {
                return;
        }
        
        if((this.<loginMethod>k__BackingField) != 0)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  -220496448);
        val_11 = 0;
        NotificationCenter val_11 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -220472336, aName:  -1821752928, aData:  0);
    }
    private void LoginRequest(System.Collections.Generic.Dictionary<string, object> loginData)
    {
        var val_4;
        Player val_1 = App.Player;
        string val_2 = System.String.Format(format:  -220969440, arg0:  1835037);
        val_4 = null;
        val_4 = null;
        System.Action<System.Threading.Tasks.Task, System.Object> val_3 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  -220348048, method:  new IntPtr(4073880656));
        App.networkManager.DoPost(path:  -220969440, postBody:  loginData, onCompleteFunction:  7507968, timeout:  20, destroy:  false, immediate:  false, serverType:  0);
    }
    private void OnServerResponse(string request, System.Collections.Generic.Dictionary<string, object> response)
    {
        var val_18;
        string val_19;
        var val_20;
        if((this.IsRequestFail(response:  response)) != false)
        {
                string val_2 = MiniJSON.Json.Serialize(obj:  response);
            string val_3 = -220247760(-220247760) + response;
            UnityEngine.Debug.LogError(message:  -220247760);
            if(RestoreProgressManager.OnServerError == 0)
        {
                return;
        }
        
            RestoreProgressManager.OnServerError.Invoke(obj:  response.ContainsKey(key:  -220247616));
            return;
        }
        
        if((response.ContainsKey(key:  -220247520)) != false)
        {
                object val_6 = response.Item[-220247520];
            response.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            if(null != 0)
        {
                Player val_7 = App.Player;
            Player val_8 = App.Player;
            2621448.Save(writePrefs:  true);
            this.UpdateLoginStatus();
        }
        
        }
        
        val_18 = 1152921510385703632;
        object val_9 = response.Item[1658601040];
        string val_10 = response.ToString();
        val_19 = response;
        if((System.String.op_Equality(a:  val_19, b:  -220247424)) != false)
        {
                if((response.ContainsKey(key:  -1824276416)) != false)
        {
                this.ImportUser(response:  response);
            this.CallbackResponse(response:  2);
            return;
        }
        
        }
        
        if((System.String.op_Equality(a:  val_19, b:  -220247328)) != false)
        {
                object val_14 = response.Item[-220247328];
            val_20 = 0;
            if(response != 0)
        {
                if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                response = 0;
        }
        
            val_20 = response;
        }
        
            this.ParseProgression(obj:  0);
            this.CallbackResponse(response:  4);
            return;
        }
        
        bool val_15 = System.String.op_Equality(a:  val_19, b:  -220247232);
        if(val_15 != false)
        {
                val_15.CallbackResponse(response:  0);
            return;
        }
        
        if((System.String.op_Equality(a:  val_19, b:  -220247120)) != false)
        {
                this.UpdateLoginStatus();
            this.CallbackResponse(response:  3);
            return;
        }
        
        if((System.String.op_Equality(a:  val_19, b:  -270417152)) == false)
        {
                return;
        }
        
        this.UpdateLoginStatus();
        this.CallbackResponse(response:  1);
    }
    private void ImportUser(System.Collections.Generic.Dictionary<string, object> response)
    {
        int val_9;
        UnityEngine.PlayerPrefs.DeleteKey(key:  -222606512);
        Player val_1 = App.Player;
        Player val_2 = App.Player;
        if((response.ContainsKey(key:  -1924037664)) != false)
        {
                object val_4 = response.Item[-1924037664];
            string val_5 = response.ToString();
            val_9 = response;
        }
        else
        {
                val_9 = System.String.alignConst;
        }
        
        WGBonusRewardsHandler val_6 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        UpdatedFromServer(serverResponse:  response, forceUpdate:  true);
        NotificationCenter val_7 = NotificationCenter.DefaultCenter;
        System.Collections.Hashtable val_8 = new System.Collections.Hashtable();
        0.PostNotification(aSender:  -220098752, aName:  -1821752928, aData:  75878400);
    }
    private void CallbackResponse(RestoreProgressManager.ServerResponse response)
    {
        if(RestoreProgressManager.OnImportResponded == 0)
        {
                return;
        }
        
        RestoreProgressManager.OnImportResponded.Invoke(obj:  response);
    }
    private void ParseProgression(System.Collections.Generic.Dictionary<string, object> obj)
    {
        this.<previousProgression>k__BackingField = new RestoreProgressManager.Progression();
        ParseDic(obj:  obj);
        string val_2 = this.<previousProgression>k__BackingField.Serialize(format:  0);
        UnityEngine.PlayerPrefs.SetString(key:  -222606512, value:  this.<previousProgression>k__BackingField);
        bool val_3 = PrefsSerializationManager.SavePlayerPrefs();
    }
    private bool IsRequestFail(System.Collections.Generic.Dictionary<string, object> response)
    {
        if(response == 0)
        {
                return (bool)1;
        }
        
        if((response.ContainsKey(key:  1616271776)) == false)
        {
                return (bool)1;
        }
        
        object val_2 = response.Item[1616271776];
        response.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        1 = 0;
        return (bool)1;
    }
    public RestoreProgressManager()
    {
    
    }

}
