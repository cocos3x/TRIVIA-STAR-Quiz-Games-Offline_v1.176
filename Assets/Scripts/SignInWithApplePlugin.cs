using UnityEngine;
public class SignInWithApplePlugin : MonoSingletonSelfGenerating<SignInWithApplePlugin>
{
    // Fields
    public const string DefaultPlayerName = "Player";
    private static bool _knobEnabled;
    private static System.Action<bool> OnSignInComplete;
    public const string OnApplePluginUpdate = "OnApplePluginUpdate";
    private bool initialized;
    private string appleUserId;
    private static float _ios_version;
    
    // Properties
    public static bool IsLoggedIn { get; }
    public static bool KnobEnabled { get; }
    
    // Methods
    public static void add_OnSignInComplete(System.Action<bool> value)
    {
        var val_2;
        var val_3;
        var val_4;
        val_2 = null;
        val_2 = null;
        label_7:
        System.Delegate val_1 = System.Delegate.Combine(a:  SignInWithApplePlugin.OnSignInComplete, b:  value);
        if(SignInWithApplePlugin.OnSignInComplete == 0)
        {
            goto label_3;
        }
        
        val_3 = SignInWithApplePlugin.OnSignInComplete;
        if(null == null)
        {
            goto label_4;
        }
        
        label_3:
        val_3 = 0;
        label_4:
        val_4 = null;
        val_4 = null;
        if(SignInWithApplePlugin.OnSignInComplete != 1152921504897425412)
        {
            goto label_7;
        }
    
    }
    public static void remove_OnSignInComplete(System.Action<bool> value)
    {
        var val_2;
        var val_3;
        var val_4;
        val_2 = null;
        val_2 = null;
        label_7:
        System.Delegate val_1 = System.Delegate.Remove(source:  SignInWithApplePlugin.OnSignInComplete, value:  value);
        if(SignInWithApplePlugin.OnSignInComplete == 0)
        {
            goto label_3;
        }
        
        val_3 = SignInWithApplePlugin.OnSignInComplete;
        if(null == null)
        {
            goto label_4;
        }
        
        label_3:
        val_3 = 0;
        label_4:
        val_4 = null;
        val_4 = null;
        if(SignInWithApplePlugin.OnSignInComplete != 1152921504897425412)
        {
            goto label_7;
        }
    
    }
    public static bool get_IsLoggedIn()
    {
        var val_4;
        var val_5;
        var val_6;
        val_4 = null;
        val_4 = null;
        val_5 = 0;
        if((MonoSingletonSelfGenerating<T>._Instance) == 0)
        {
                return (bool)val_5;
        }
        
        val_6 = null;
        val_6 = null;
        val_5 = (System.String.IsNullOrEmpty(value:  MonoSingletonSelfGenerating<T>._Instance + 16)) ^ 1;
        return (bool)val_5;
    }
    public static bool get_KnobEnabled()
    {
        null = null;
        return (bool)SignInWithApplePlugin.OnApplePluginUpdate;
    }
    public static bool IsSupported()
    {
        return false;
    }
    public bool IsSignInAvailable()
    {
        return false;
    }
    private void Start()
    {
        if((SignInWithApplePlugin.__il2cppRuntimeField_BB & 2) != 0)
        {
                return;
        }
    
    }
    public void Init()
    {
        if(this.initialized == true)
        {
                return;
        }
        
        this.initialized = true;
        this.UpdateKnob();
        if((SignInWithApplePlugin.__il2cppRuntimeField_BB & 2) != 0)
        {
                return;
        }
    
    }
    public void OnServerResponded()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.RemoveObserver(observer:  -1843422624, name:  -1976323520);
        this.UpdateKnob();
    }
    public void UpdateCredentialStatus()
    {
    
    }
    public void LogIn()
    {
    
    }
    public void Logout()
    {
        var val_4;
        Player val_1 = App.Player;
        mem[160] = System.String.alignConst;
        Player val_2 = App.Player;
        Player val_3 = App.Player;
        val_4 = null;
        if(2621448 == 0)
        {
                val_4 = 1152921504622235740;
        }
        
        this.appleUserId = System.String.alignConst;
    }
    private static float iOSVersion()
    {
        return (float)S0;
    }
    private void UpdateKnob()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_5 = 27774967;
        val_5 = 7852448 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        twelvegigs.storage.JsonDictionary val_1 = getGameplayKnobs();
        if((Contains(key:  -1842886624)) == false)
        {
                return;
        }
        
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        twelvegigs.storage.JsonDictionary val_3 = getGameplayKnobs();
        val_7 = null;
        val_7 = null;
        SignInWithApplePlugin.OnApplePluginUpdate = getBool(key:  -1842886624);
    }
    public SignInWithApplePlugin()
    {
        this.appleUserId = System.String.alignConst;
    }
    private static SignInWithApplePlugin()
    {
        SignInWithApplePlugin.OnApplePluginUpdate = 1;
        SignInWithApplePlugin._ios_version = 0f;
    }

}
