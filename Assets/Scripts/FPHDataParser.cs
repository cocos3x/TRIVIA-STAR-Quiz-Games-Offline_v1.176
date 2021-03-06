using UnityEngine;
public class FPHDataParser : MonoSingleton<FPHDataParser>
{
    // Fields
    private string currentLevelListLanguage;
    private System.Collections.Generic.List<FPHLevelObject> standardLevelList;
    private string QAHACK_currentHackedLocale;
    
    // Properties
    private string PERSISTANT_LEVEL_DATA_KEY { get; }
    public string PathToGameResources { get; }
    public int InitialLevelOffset { get; set; }
    private int QuizLevelOffest { get; set; }
    public string QAHACK_getCurrentCagetoryEconLocale { get; }
    
    // Methods
    private string get_PERSISTANT_LEVEL_DATA_KEY()
    {
        var val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  -1655803488)) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_4 = 1152921511540978092;
            return -1655802464(-1655802464) + 1800251696;
        }
        
        val_4 = "en";
        return -1655802464(-1655802464) + 1800251696;
    }
    public string get_PathToGameResources()
    {
        string val_1 = WordApp.GamePathName;
        return -1655690384(-1655690384) + null + 1115175264;
    }
    public int get_InitialLevelOffset()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1655578304, defaultValue:  0);
    }
    public void set_InitialLevelOffset(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1655578304, value:  value);
    }
    private int get_QuizLevelOffest()
    {
        return CPlayerPrefs.GetInt(key:  -1655354192, defaultValue:  0);
    }
    private void set_QuizLevelOffest(int value)
    {
        CPlayerPrefs.SetInt(key:  -1655354192, val:  value);
    }
    private void OnLocalize()
    {
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        if((this.currentLevelListLanguage.StartsWith(value:  null)) == true)
        {
                return;
        }
        
        string val_4 = this.GetFormattedLangaugeAndLocale();
        this.currentLevelListLanguage = this;
        System.Collections.Generic.List<FPHLevelObject> val_5 = this.LoadStandardLevelData();
        this.standardLevelList = this;
    }
    private string GetFormattedLangaugeAndLocale()
    {
        var val_14;
        string val_15;
        var val_16;
        var val_17;
        if((System.String.IsNullOrEmpty(value:  this.QAHACK_currentHackedLocale)) == false)
        {
            goto label_1;
        }
        
        if(Localization.GAME_NAME == 0)
        {
            goto label_5;
        }
        
        if(Localization.GAME_NAME != null)
        {
            goto label_8;
        }
        
        goto label_8;
        label_1:
        val_15 = this.QAHACK_currentHackedLocale;
        return;
        label_5:
        val_14 = "en";
        label_8:
        string val_3 = DeviceProperties.LocaleFromDevice;
        if((0.Contains(value:  1359327184)) != false)
        {
                typeof(System.Char[]).__il2cppRuntimeField_10 = 45;
            System.String[] val_5 = 0.Split(separator:  478563824);
            val_16 = 0 + 20;
        }
        else
        {
                val_16 = "US";
        }
        
        string val_6 = System.String.Format(format:  -1655001648, arg0:  1800251696, arg1:  -1655001728);
        string val_7 = ToLower();
        val_15 = "{0}-{1}";
        System.Type val_8 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(302714880)});
        string val_9 = Replace(oldValue:  1359327184, newValue:  2144339952);
        if((System.Enum.IsDefined(enumType:  302714880, value:  -1655001648)) == true)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = val_15;
        UnityEngine.Debug.LogErrorFormat(format:  -1655001552, args:  472754880);
        if((StartsWith(value:  -1655001408)) != false)
        {
                val_17 = "de-de";
            return;
        }
        
        if((StartsWith(value:  -1655001248)) != false)
        {
                val_17 = "fr-fr";
            return;
        }
        
        if((StartsWith(value:  -2101987568)) != false)
        {
                val_17 = "es-419";
            return;
        }
        
        val_17 = "en-us";
    }
    private string ParseLanguageFromLocale(string currentLocale)
    {
        typeof(System.Char[]).__il2cppRuntimeField_10 = 45;
        System.String[] val_1 = currentLocale.Split(separator:  478563824);
        if(currentLocale.m_firstChar != ' ')
        {
                return;
        }
    
    }
    public string get_QAHACK_getCurrentCagetoryEconLocale()
    {
        if((System.String.IsNullOrEmpty(value:  this.currentLevelListLanguage)) == false)
        {
                "not set" = 1152921511542049228;
        }
    
    }
    public void QAHACK_setCurrentCategoryEcon(string formattedLanguageAndLocale)
    {
        this.standardLevelList = 0;
        this.QAHACK_currentHackedLocale = formattedLanguageAndLocale;
        typeof(System.Object[]).__il2cppRuntimeField_10 = this.QAHACK_currentHackedLocale;
        UnityEngine.Debug.LogErrorFormat(format:  -1654632064, args:  472754880);
        string val_1 = this.GetFormattedLangaugeAndLocale();
        this.currentLevelListLanguage = this;
        System.Collections.Generic.List<FPHLevelObject> val_2 = this.LoadStandardLevelData();
        this.standardLevelList = this;
    }
    public override void InitMonoSingleton()
    {
        string val_4;
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1654487712, name:  1799422256);
        if(Localization.GAME_NAME != 0)
        {
                if(Localization.GAME_NAME != null)
        {
            goto label_10;
        }
        
        }
        else
        {
                val_4 = "en";
        }
        
        label_10:
        this.currentLevelListLanguage = val_4;
        System.Collections.Generic.List<FPHLevelObject> val_3 = this.LoadStandardLevelData();
        this.standardLevelList = this;
    }
    private System.Collections.Generic.List<FPHLevelObject> ParseRawText(UnityEngine.TextAsset levelData)
    {
        string val_1 = levelData.text;
        if((System.String.IsNullOrEmpty(value:  levelData)) == true)
        {
                return;
        }
        
        0 = 0;
        string val_3 = levelData.text;
        System.String[] val_4 = System.Text.RegularExpressions.Regex.Split(input:  levelData, pattern:  -1654395616);
        if(levelData != 0)
        {
                levelData = levelData;
            goto label_6;
        }
        
        return;
        label_6:
        if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) < 2)
        {
                return;
        }
        
        do
        {
            if((System.String.IsNullOrEmpty(value:  new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>() = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>())) != true)
        {
                FPHLevelObject val_7 = new FPHLevelObject(unparsedString:  R7);
            Add(item:  302768128);
        }
        
            var val_8 = 5 + 1;
        }
        while((5 - 3) < null);
    
    }
    private System.Collections.Generic.List<FPHLevelObject> LoadStandardLevelData()
    {
        bool val_1 = System.String.IsNullOrEmpty(value:  this.currentLevelListLanguage);
        if(val_1 == false)
        {
                "en-us" = 1152921511542532668;
        }
        
        string val_2 = val_1.ParseLanguageFromLocale(currentLocale:  this.currentLevelListLanguage);
        string val_3 = val_1.PathToGameResources;
        string val_4 = System.String.Format(format:  -1654273280, arg0:  val_1, arg1:  -1654273184, arg2:  val_1);
        typeof(System.Object[]).__il2cppRuntimeField_10 = "{0}{1}_{2}";
        UnityEngine.Debug.LogErrorFormat(format:  -1654273056, args:  472754880);
        UnityEngine.TextAsset val_5 = LoadAssetFromFolder(path:  -1654273280);
        bool val_6 = UnityEngine.Object.op_Equality(x:  -1654273056, y:  0);
        if(val_6 == false)
        {
                return val_6.ParseRawText(levelData:  -1654273056);
        }
    
    }
    public System.Collections.Generic.List<FPHLevelObject> LoadQOTDLevelData()
    {
        bool val_5 = static_value_021FCFAC;
        if(val_5 != true)
        {
                val_5 = true;
        }
        
        string val_1 = this.PathToGameResources;
        string val_2 = 1 + -1654156816(-1654156816);
        UnityEngine.TextAsset val_3 = this.LoadAssetFromFolder(path:  1);
        bool val_4 = UnityEngine.Object.op_Equality(x:  1, y:  0);
        if(val_4 == false)
        {
                return val_4.ParseRawText(levelData:  1);
        }
    
    }
    private FPHLevelObject GetLevelObject(out int index)
    {
        Player val_1 = App.Player;
        int val_2 = this.InitialLevelOffset;
        val_2 = 0 + val_2;
        val_2 = val_2 - 1;
        index = mem[1179403871];
        if(val_2 <= mem[1179403871])
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + (mem[1179403871] << 2);
    }
    private FPHLevelObject GetSpecificLevelObject(int index)
    {
        if(true <= index)
        {
                var val_1 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_1 = val_1 + (index << 2);
    }
    public bool CanResumeGame()
    {
        var val_11;
        string val_2 = new FPHGameplayState().PERSISTANT_LEVEL_DATA_KEY;
        val_11 = 0;
        bool val_3 = CPlayerPrefs.HasKey(key:  new FPHGameplayState() = new FPHGameplayState());
        if(val_3 == false)
        {
                return (bool)val_11;
        }
        
        string val_4 = val_3.PERSISTANT_LEVEL_DATA_KEY;
        val_11 = 0;
        string val_5 = CPlayerPrefs.GetString(key:  val_3);
        bool val_6 = System.String.IsNullOrEmpty(value:  val_3);
        if(val_6 == true)
        {
                return (bool)val_11;
        }
        
        string val_7 = val_6.PERSISTANT_LEVEL_DATA_KEY;
        string val_8 = CPlayerPrefs.GetString(key:  val_6);
        val_11 = FPHGameplayState.Deserialize(dataString:  val_6, stateToLoad: ref  FPHGameplayState val_9 = -1653776108);
        return (bool)val_11;
    }
    public void SetupLevel(ref FPHGameplayState state)
    {
        var val_29;
        FPHGameplayState val_30;
        int val_31;
        FPHLevelObject val_32;
        var val_33;
        FPHGameplayState val_34;
        string val_35;
        float val_36;
        float val_37;
        string val_38;
        var val_39;
        var val_40;
        char val_41;
        var val_42;
        FPHGameplayState val_43;
        string val_1 = this.PERSISTANT_LEVEL_DATA_KEY;
        val_29 = 1152921504882458624;
        bool val_2 = CPlayerPrefs.HasKey(key:  null);
        if(val_2 == false)
        {
            goto label_6;
        }
        
        string val_3 = val_2.PERSISTANT_LEVEL_DATA_KEY;
        string val_4 = CPlayerPrefs.GetString(key:  val_2);
        bool val_5 = System.String.IsNullOrEmpty(value:  val_2);
        if(val_5 == true)
        {
            goto label_6;
        }
        
        string val_6 = val_5.PERSISTANT_LEVEL_DATA_KEY;
        string val_7 = CPlayerPrefs.GetString(key:  val_5);
        if((FPHGameplayState.Deserialize(dataString:  val_5, stateToLoad: ref  FPHGameplayState val_8 = -1653612800)) == false)
        {
            goto label_9;
        }
        
        if(state != 0)
        {
                val_31 = mem[state + 12];
            val_31 = state.<levelIndex>k__BackingField;
            FPHLevelObject val_10 = this.GetSpecificLevelObject(index:  val_31);
            val_32 = this;
        }
        else
        {
                val_31 = 0;
            FPHLevelObject val_11 = this.GetSpecificLevelObject(index:  0);
            val_32 = this;
        }
        
        <levelData>k__BackingField = val_32;
        val_33 = state;
        if(state != 0)
        {
            goto label_12;
        }
        
        val_34 = state;
        if(val_34 == 0)
        {
            goto label_56;
        }
        
        label_12:
        val_35 = mem[state + 84];
        val_35 = state.phraseSlotCorrectValue;
        val_36 = "";
        val_37 = " ";
        string val_12 = state.<levelData>k__BackingField.<phrase>k__BackingField.Replace(oldValue:  1297836560, newValue:  1098586544);
        val_38 = state.<levelData>k__BackingField.<phrase>k__BackingField;
        if((val_35.Equals(value:  val_38)) == true)
        {
                return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = state.phraseSlotCorrectValue;
        string val_14 = state.<levelData>k__BackingField.<phrase>k__BackingField.Replace(oldValue:  1297836560, newValue:  1098586544);
        typeof(System.Object[]).__il2cppRuntimeField_14 = state.<levelData>k__BackingField.<phrase>k__BackingField;
        UnityEngine.Debug.LogErrorFormat(format:  -1653672064, args:  472754880);
        val_30 = null;
        val_30 = new FPHGameplayState();
        state = val_30;
        label_9:
        string val_15 = val_30.PERSISTANT_LEVEL_DATA_KEY;
        CPlayerPrefs.DeleteKey(key:  val_30);
        label_6:
        Player val_16 = App.Player;
        typeof(FPHGameplayState).__il2cppRuntimeField_3C = 0;
        FPHLevelObject val_18 = this.GetLevelObject(index: out  int val_17 = -1653656840);
        typeof(FPHGameplayState).__il2cppRuntimeField_8 = this;
        typeof(FPHGameplayState).__il2cppRuntimeField_C = 0;
        WordForest.WFOGameEcon val_19 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        typeof(FPHGameplayState).__il2cppRuntimeField_20 = public System.Void System.Collections.Generic.List<FPHLetterSlotState>::.ctor().__il2cppRuntimeField_14C;
        System.Collections.Generic.List<WordPets.WordPetType> val_20 = new System.Collections.Generic.List<WordPets.WordPetType>();
        typeof(FPHGameplayState).__il2cppRuntimeField_4C = null;
        val_39 = 0;
        val_29 = 1152921511543111744;
        val_36 = 1152921510000828128;
        goto label_42;
        label_66:
        if(Chars[0] == ' ')
        {
            goto label_43;
        }
        
        if((FPHKeyboard.IsLetter(value:  mem[1152921511543136784].Chars[0])) == false)
        {
            goto label_51;
        }
        
        Add(item:  0);
        val_40 = public System.Void System.Collections.Generic.List<System.Char>::Add(System.Char item);
        val_41 = 32;
        goto label_54;
        label_51:
        val_31 = 1;
        Add(item:  1);
        val_42 = state;
        if(state != 0)
        {
            goto label_55;
        }
        
        val_43 = state;
        if(val_43 == 0)
        {
            goto label_56;
        }
        
        label_55:
        val_40 = public System.Void System.Collections.Generic.List<System.Char>::Add(System.Char item);
        val_41 = mem[1152921511543136784].Chars[0];
        label_54:
        FPHGameplayState.__il2cppRuntimeField_nestedTypes.Add(item:  val_41);
        label_43:
        val_39 = 1;
        label_42:
        val_38 = state;
        val_37 = mem[mem[1152921511543136784] + 8];
        val_37 = mem[1152921511543136784] + 8;
        val_35 = mem[1152921511543136784];
        if(val_39 < val_37)
        {
            goto label_66;
        }
        
        string val_25 = val_35.Replace(oldValue:  1297836560, newValue:  1098586544);
        typeof(FPHGameplayState).__il2cppRuntimeField_54 = val_35;
        WordForest.WFOGameEcon val_26 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        FPHChestType val_27 = GetChestType();
        typeof(FPHGameplayState).__il2cppRuntimeField_5C = public static FPHEcon App::GetGameSepeciticEcon<FPHEcon>();
        return;
        label_56:
    }
    public void UpdateSavedLevel(FPHGameplayState state)
    {
        bool val_4 = static_value_021FCFB1;
        if(val_4 != true)
        {
                val_4 = true;
        }
        
        string val_1 = this.PERSISTANT_LEVEL_DATA_KEY;
        if(state != 0)
        {
                string val_2 = state.Serialize();
            string val_3 = MiniJSON.Json.Serialize(obj:  state);
            CPlayerPrefs.SetString(key:  1, val:  state);
            CPlayerPrefs.Save();
            return;
        }
        
        CPlayerPrefs.DeleteKey(key:  1);
    }
    private UnityEngine.TextAsset[] LoadAssetsFromFolder(string path)
    {
        return UnityEngine.Resources.LoadAll<System.Object>(path:  path);
    }
    private UnityEngine.TextAsset LoadAssetFromFolder(string path)
    {
        return UnityEngine.Resources.Load<System.Object>(path:  path);
    }
    public FPHDataParser()
    {
        this.currentLevelListLanguage = "";
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.standardLevelList = null;
        this.QAHACK_currentHackedLocale = "";
    }

}
