using UnityEngine;
public class ThemesHandler : MonoSingleton<ThemesHandler>
{
    // Fields
    private const string pref_theme_key = "chosen_theme";
    public const string Notification_OnThemeChanged = "Notification_OnThemeChanged";
    private static string[] excludedNames;
    private bool initialized;
    private UITheme theme;
    private static ThemeAssetTable assetsTable;
    
    // Properties
    public string CurrentThemeName { get; }
    public UITheme CurrentTheme { get; }
    
    // Methods
    public string get_CurrentThemeName()
    {
        var val_1;
        if(this.theme.themeType != 0)
        {
                val_1 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem2[0] = ;
            return;
        }
        
        val_1 = "";
    }
    public UITheme get_CurrentTheme()
    {
    
    }
    public void SwapTheme(Themes swapTo)
    {
        object val_1 = new System.Object();
        typeof(ThemesHandler.<>c__DisplayClass10_0).__il2cppRuntimeField_8 = swapTo;
        AppConfigs val_2 = App.Configuration;
        System.Predicate<ZooTile> val_3 = new System.Predicate<ZooTile>(object:  346058752, method:  new IntPtr(3615758528));
        object val_4 = static_value_00280014.Find(match:  8040448);
        if(static_value_00280014 == 0)
        {
                UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            ThemesHandler.<>c__DisplayClass10_0.__il2cppRuntimeField_name.__il2cppRuntimeField_FFFFFFFFFFFFFFFF = ;
            string val_6 = -679205696(-679205696) + 346484736;
            UnityEngine.Debug.LogError(message:  -679205696);
            return;
        }
        
        this.theme = static_value_00280014;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        ThemesHandler.<>c__DisplayClass10_0.__il2cppRuntimeField_name.__il2cppRuntimeField_FFFFFFFFFFFFFFFF = ;
        UnityEngine.PlayerPrefs.SetString(key:  -679205520, value:  346484736);
        GameBehavior val_7 = App.getBehavior;
        NotificationCenter val_8 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -679181424, aName:  -2016812608);
    }
    private void Start()
    {
        this.Initialize();
    }
    private void Initialize()
    {
        System.Predicate<ZooTile> val_13;
        var val_14;
        var val_15;
        if(this.initialized == true)
        {
                return;
        }
        
        val_13 = "chosen_theme";
        if((UnityEngine.PlayerPrefs.HasKey(key:  -679205520)) == false)
        {
            goto label_1;
        }
        
        object val_2 = new System.Object();
        System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(346484736)});
        string val_4 = UnityEngine.PlayerPrefs.GetString(key:  -679205520);
        object val_5 = System.Enum.Parse(enumType:  346484736, value:  -679205520);
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        typeof(ThemesHandler.<>c__DisplayClass12_0).__il2cppRuntimeField_8 = ;
        AppConfigs val_6 = App.Configuration;
        val_14 = static_value_00280014;
        val_13 = null;
        val_13 = new System.Predicate<ZooTile>(object:  346112000, method:  new IntPtr(3615989968));
        val_15 = val_14;
        object val_8 = val_15.Find(match:  8040448);
        goto label_14;
        label_1:
        val_14 = 1152921504892043264;
        AppConfigs val_9 = App.Configuration;
        if((UnityEngine.Object.op_Implicit(exists:  2621448)) == false)
        {
            goto label_20;
        }
        
        AppConfigs val_11 = App.Configuration;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_15 = mem[static_value_00280014 + 8 + 16];
        val_15 = static_value_00280014 + 8 + 16;
        label_14:
        mem2[0] = val_15;
        goto label_27;
        label_20:
        mem2[0] = new UITheme();
        label_27:
        mem2[0] = 1;
    }
    public ThemesHandler()
    {
    
    }
    private static ThemesHandler()
    {
        typeof(System.String[]).__il2cppRuntimeField_10 = "managers";
        typeof(System.String[]).__il2cppRuntimeField_14 = "background";
        typeof(System.String[]).__il2cppRuntimeField_18 = "leagues";
        ThemesHandler.excludedNames = null;
    }

}
