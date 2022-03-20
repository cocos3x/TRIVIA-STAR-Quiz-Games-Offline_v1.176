using UnityEngine;
public class Localization : MonoBehaviour
{
    // Fields
    public const string ON_LOCALIZE = "OnLocalize";
    private static Localization mInstance;
    private const string CURRENCY = "#currency";
    private const string CURRENCYS = "#currency_s";
    private const string CURRENCYL = "#currency_l";
    private const string CURRENCYU = "#currency_u";
    private const string GAME_NAME = "#game-name";
    private string <Currency>k__BackingField;
    private string <CurrencySingular>k__BackingField;
    private string <CurrencyLowerCase>k__BackingField;
    private string <CurrencyUpperCase>k__BackingField;
    private static string <GameName>k__BackingField;
    public string startingLanguage;
    private UnityEngine.TextAsset[] languages;
    private System.Collections.Generic.Dictionary<string, string> mDictionary;
    private string mLanguage;
    
    // Properties
    private string Currency { get; set; }
    private string CurrencySingular { get; set; }
    private string CurrencyLowerCase { get; set; }
    private string CurrencyUpperCase { get; set; }
    private static string GameName { get; set; }
    public static Localization instance { get; }
    public string currentLanguage { get; set; }
    
    // Methods
    private string get_Currency()
    {
    
    }
    private void set_Currency(string value)
    {
        this.<Currency>k__BackingField = value;
    }
    private string get_CurrencySingular()
    {
    
    }
    private void set_CurrencySingular(string value)
    {
        this.<CurrencySingular>k__BackingField = value;
    }
    private string get_CurrencyLowerCase()
    {
    
    }
    private void set_CurrencyLowerCase(string value)
    {
        this.<CurrencyLowerCase>k__BackingField = value;
    }
    private string get_CurrencyUpperCase()
    {
    
    }
    private void set_CurrencyUpperCase(string value)
    {
        this.<CurrencyUpperCase>k__BackingField = value;
    }
    private static string get_GameName()
    {
    
    }
    private static void set_GameName(string value)
    {
        Localization.<GameName>k__BackingField = value;
    }
    public static Localization get_instance()
    {
    
    }
    public string get_currentLanguage()
    {
    
    }
    public void set_currentLanguage(string value)
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_8 = 35653740;
        if((System.String.op_Inequality(a:  this.mLanguage, b:  value)) == false)
        {
                return;
        }
        
        this.startingLanguage = value;
        if((System.String.IsNullOrEmpty(value:  value)) == true)
        {
            goto label_13;
        }
        
        if(this.languages == null)
        {
            goto label_3;
        }
        
        UnityEngine.TextAsset val_3 = this.FindLanguageAsset(name:  value);
        val_9 = this;
        if(1798566640 != 0)
        {
            goto label_6;
        }
        
        label_3:
        val_10 = null;
        val_11 = 0;
        System.Type val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(158519296)});
        UnityEngine.Object val_6 = UnityEngine.Resources.Load(path:  value, systemTypeInstance:  158519296);
        if(value != null)
        {
                if(((System.String.__il2cppRuntimeField_typeHierarchy + (UnityEngine.TextAsset.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                value = 0;
        }
        
            val_11 = value;
        }
        
        if(0 == 0)
        {
            goto label_13;
        }
        
        label_6:
        this.Load(asset:  0);
        return;
        label_13:
        this.mDictionary.Clear();
        UnityEngine.PlayerPrefs.DeleteKey(key:  1798542544);
    }
    private void Awake()
    {
        if(Localization.GAME_NAME != 0)
        {
            goto label_3;
        }
        
        Localization.GAME_NAME = this;
        UnityEngine.GameObject val_2 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  1798776944);
        string val_3 = UnityEngine.PlayerPrefs.GetString(key:  1798542544, defaultValue:  this.startingLanguage);
        this.currentLanguage = 1798542544;
        if((System.String.IsNullOrEmpty(value:  this.mLanguage)) == false)
        {
                return;
        }
        
        if(0 != 0)
        {
            goto label_7;
        }
        
        return;
        label_3:
        UnityEngine.GameObject val_5 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  1798776944);
        return;
        label_7:
        UnityEngine.TextAsset val_7 = this.languages[0];
        string val_6 = val_7.name;
        this.currentLanguage = val_7;
    }
    private void OnEnable()
    {
        bool val_1 = UnityEngine.Object.op_Equality(x:  Localization.GAME_NAME, y:  0);
        if(val_1 == true)
        {
                val_1 = null;
            Localization.GAME_NAME = this;
        }
    
    }
    private void OnDestroy()
    {
        bool val_1 = UnityEngine.Object.op_Equality(x:  Localization.GAME_NAME, y:  1799050096);
        if(val_1 == true)
        {
                val_1 = null;
            Localization.GAME_NAME = 0;
        }
    
    }
    private UnityEngine.TextAsset FindLanguageAsset(string name)
    {
        UnityEngine.TextAsset val_4;
        if(R7 >= 1)
        {
                var val_4 = 0;
            do
        {
            val_4 = this.languages[val_4];
            if(val_4 != 0)
        {
                string val_2 = val_4.name;
            if((System.String.op_Equality(a:  val_4, b:  name)) == true)
        {
                return;
        }
        
        }
        
            val_4 = val_4 + 1;
        }
        while(val_4 < R7);
        
        }
        
        val_4 = 0;
    }
    private void Load(UnityEngine.TextAsset asset)
    {
        string val_1 = asset.name;
        this.mLanguage = asset;
        System.Collections.Generic.Dictionary<System.String, System.String> val_3 = ReadDictionary();
        this.mDictionary = new ByteReader(asset:  asset);
        if(UnityEngine.Application.isPlaying == false)
        {
                return;
        }
        
        if(UnityEngine.Application.isEditor != false)
        {
                string val_6 = UnityEngine.StackTraceUtility.ExtractStackTrace();
            if((0.Contains(value:  1799418032)) == true)
        {
                return;
        }
        
        }
        
        UnityEngine.PlayerPrefs.SetString(key:  1798542544, value:  this.mLanguage);
        NotificationCenter val_8 = NotificationCenter.DefaultCenter;
        PostNotification(aSender:  1799446352, aName:  1799422256, aData:  0);
    }
    public string GetForLanguage(string language, string key, string defaultValue = "", bool useSingularKey = False)
    {
        UnityEngine.TextAsset val_1 = this.FindLanguageAsset(name:  language);
        if(1799578832 != 0)
        {
                this.Load(asset:  1799578832);
        }
        
        string val_3 = this.Get(key:  key, defaultValue:  defaultValue, useSingularKey:  useSingularKey);
    }
    public string Get(string key, string defaultValue = "", bool useSingularKey = False)
    {
        string val_18;
        System.Collections.Generic.Dictionary<System.String, System.String> val_19;
        var val_20;
        val_18 = key;
        val_19 = this.mDictionary;
        string val_1 = val_18 + 1799687312;
        if((val_19.TryGetValue(key:  val_18, value: out  string val_2 = 1799725544)) != false)
        {
                val_20 = 0;
            return;
        }
        
        if(useSingularKey != false)
        {
                string val_4 = val_18 + 1799692528;
            val_18 = val_18;
        }
        
        if((this.mDictionary.TryGetValue(key:  val_18, value: out  string val_5 = 1799725544)) != false)
        {
                val_20 = 0;
        }
        else
        {
                if((System.String.op_Inequality(a:  defaultValue, b:  1098586544)) == true)
        {
                val_20 = defaultValue;
        }
        
        }
        
        if((val_20.Contains(value:  1799696720)) != false)
        {
                string val_9 = val_20.Replace(oldValue:  1799696720, newValue:  this.<CurrencySingular>k__BackingField);
            val_20 = val_20;
        }
        
        if((val_20.Contains(value:  1799700912)) != false)
        {
                string val_11 = val_20.Replace(oldValue:  1799700912, newValue:  this.<CurrencyLowerCase>k__BackingField);
            val_20 = val_20;
        }
        
        if((val_20.Contains(value:  1799705104)) != false)
        {
                string val_13 = val_20.Replace(oldValue:  1799705104, newValue:  this.<CurrencyUpperCase>k__BackingField);
            val_20 = val_20;
        }
        
        if((val_20.Contains(value:  1799709296)) != false)
        {
                string val_15 = val_20.Replace(oldValue:  1799709296, newValue:  this.<Currency>k__BackingField);
            val_20 = val_20;
        }
        
        val_19 = "#game-name";
        if((val_20.Contains(value:  1799713488)) == false)
        {
                return;
        }
        
        string val_17 = val_20.Replace(oldValue:  1799713488, newValue:  Localization.<GameName>k__BackingField);
        val_20 = val_20;
    }
    public void setLocalizedCurrency(string currencyKey)
    {
        string val_1 = this.Get(key:  currencyKey, defaultValue:  currencyKey, useSingularKey:  false);
        this.<Currency>k__BackingField = this;
        string val_2 = currencyKey + 1799692528;
        string val_3 = this.Get(key:  currencyKey, defaultValue:  this.<Currency>k__BackingField, useSingularKey:  false);
        this.<CurrencySingular>k__BackingField = this;
        string val_4 = this.<Currency>k__BackingField.ToLower();
        this.<CurrencyLowerCase>k__BackingField = this.<Currency>k__BackingField;
        string val_5 = this.<Currency>k__BackingField.ToUpper();
        this.<CurrencyUpperCase>k__BackingField = this.<Currency>k__BackingField;
    }
    public static void SetGameName(string gameName)
    {
        Localization.<GameName>k__BackingField = gameName;
    }
    public static string Localize(string key, string defaultValue = "", bool useSingularKey = False)
    {
        var val_4 = 15280891;
        val_4 = 20346532 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        if(Localization.GAME_NAME != 0)
        {
                if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
            string val_2 = Localization.GAME_NAME.Get(key:  key, defaultValue:  defaultValue, useSingularKey:  useSingularKey);
            return;
        }
        
        if((System.String.IsNullOrEmpty(value:  defaultValue)) == false)
        {
                key = defaultValue;
        }
    
    }
    public static System.Collections.Generic.List<string> GetLanguageNames()
    {
        var val_5;
        var val_6;
        var val_5 = 15280559;
        val_5 = 20346864 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = 0;
        val_6 = UnityEngine.Object.op_Equality(x:  Localization.GAME_NAME, y:  0);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(val_6 == false)
        {
            goto label_7;
        }
        
        Add(item:  1800251696);
        return;
        label_17:
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        var val_3 = (Localization.GAME_NAME + 32) + 0;
        string val_4 = (Localization.GAME_NAME + 32 + 0) + 16.name;
        Add(item:  (Localization.GAME_NAME + 32 + 0) + 16);
        val_5 = 1;
        label_7:
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = mem[Localization.GAME_NAME + 32];
        val_6 = Localization.GAME_NAME + 32;
        if(val_5 < (Localization.GAME_NAME + 32 + 12))
        {
            goto label_17;
        }
    
    }
    public Localization()
    {
        this.startingLanguage = "English";
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.mDictionary = null;
    }

}
