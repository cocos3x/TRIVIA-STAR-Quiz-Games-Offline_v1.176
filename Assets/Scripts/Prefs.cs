using UnityEngine;
public static class Prefs
{
    // Properties
    public static int currentWorld { get; }
    public static int currentChapter { get; }
    public static int currentLevel { get; }
    public static int extraProgress { get; set; }
    public static int extraTarget { get; set; }
    public static int totalExtraAdded { get; set; }
    public static bool HasUsedHintPicker { get; set; }
    public static bool HasUsedHintMega { get; set; }
    public static bool HasUsedHintCheck { get; set; }
    public static GameMode currentGameMode { get; set; }
    public static int freePlayLevel { get; set; }
    
    // Methods
    public static int get_currentWorld()
    {
        return 0;
    }
    public static int get_currentChapter()
    {
        return WADChapterManager.GetCurrentChapter();
    }
    public static int get_currentLevel()
    {
        return WADChapterManager.GetCurrentLevelWithinChapter(level:  0);
    }
    public static bool IsCurrentLevel()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_2 = PlayingChallenge;
        val_2 = val_2 ^ 1;
        return (bool)val_2;
    }
    public static void SetExtraWords(int world, int subWorld, int level, string[] extraWords)
    {
        typeof(System.Object[]).__il2cppRuntimeField_10 = "extra_words_";
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = "_";
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        typeof(System.Object[]).__il2cppRuntimeField_20 = "_";
        typeof(System.Object[]).__il2cppRuntimeField_24 = null;
        string val_1 = +472754880;
        bool val_2 = CryptoPlayerPrefsX.SetStringArray(key:  472754880, stringArray:  extraWords);
    }
    public static string[] GetExtraWords(int world, int subWorld, int level)
    {
        typeof(System.Object[]).__il2cppRuntimeField_10 = "extra_words_";
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = "_";
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        typeof(System.Object[]).__il2cppRuntimeField_20 = "_";
        typeof(System.Object[]).__il2cppRuntimeField_24 = null;
        string val_1 = +472754880;
        System.String[] val_2 = CryptoPlayerPrefsX.GetStringArray(key:  472754880);
    }
    public static void SetExtraWordsEvents(string gameType, string[] extraWords)
    {
        string val_1 = -2048115776(-2048115776) + gameType;
        bool val_2 = CryptoPlayerPrefsX.SetStringArray(key:  -2048115776, stringArray:  extraWords);
    }
    public static string[] GetExtraWordsEvents(string gameType)
    {
        string val_1 = -2048115776(-2048115776) + gameType;
        return CryptoPlayerPrefsX.GetStringArray(key:  -2048115776);
    }
    public static int get_extraProgress()
    {
        return CPlayerPrefs.GetInt(key:  -2047540704, defaultValue:  0);
    }
    public static void set_extraProgress(int value)
    {
        CPlayerPrefs.SetInt(key:  -2047540704, val:  value);
    }
    public static int get_extraTarget()
    {
        return CPlayerPrefs.GetInt(key:  -2047316608, defaultValue:  0);
    }
    public static void set_extraTarget(int value)
    {
        CPlayerPrefs.SetInt(key:  -2047316608, val:  value);
    }
    public static int get_totalExtraAdded()
    {
        return CPlayerPrefs.GetInt(key:  -2047092512, defaultValue:  0);
    }
    public static void set_totalExtraAdded(int value)
    {
        CPlayerPrefs.SetInt(key:  -2047092512, val:  value);
    }
    public static void AddToNumHint(int world, int subWorld, int level)
    {
        WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        if((-2101079008) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            WordPets.WPTDataParser val_5 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
            OnAnyHintUsed();
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = "numhint_used_";
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = "_";
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        typeof(System.Object[]).__il2cppRuntimeField_20 = "_";
        typeof(System.Object[]).__il2cppRuntimeField_24 = null;
        string val_6 = +472754880;
        UnityEngine.PlayerPrefs.SetInt(key:  472754880, value:  (Prefs.GetNumHint(world:  world, subWorld:  subWorld, level:  level)) + 1);
    }
    public static int GetNumHint(int world, int subWorld, int level)
    {
        typeof(System.Object[]).__il2cppRuntimeField_10 = "numhint_used_";
        typeof(System.Object[]).__il2cppRuntimeField_14 = null;
        typeof(System.Object[]).__il2cppRuntimeField_18 = "_";
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        typeof(System.Object[]).__il2cppRuntimeField_20 = "_";
        typeof(System.Object[]).__il2cppRuntimeField_24 = null;
        string val_1 = +472754880;
        return (int)UnityEngine.PlayerPrefs.GetInt(key:  472754880);
    }
    public static void UsedHint(bool free = False)
    {
        var val_4;
        var val_5;
        if(free == false)
        {
            goto label_1;
        }
        
        Player val_2 = App.Player;
        val_4 = 2621448;
        if(val_4 == 0)
        {
            goto label_5;
        }
        
        val_5 = 35143860;
        goto label_11;
        label_1:
        Player val_3 = App.Player;
        val_4 = 2621448;
        if(val_4 == 0)
        {
            goto label_10;
        }
        
        val_5 = 23;
        goto label_11;
        label_5:
        val_4 = 60;
        goto label_12;
        label_10:
        val_4 = 56;
        label_12:
        label_11:
        mem[56] = val_4 + 1;
    }
    public static bool HasUsedHint()
    {
        Player val_1 = App.Player;
        if(23 > 0)
        {
                return true;
        }
        
        Player val_2 = App.Player;
        if(35143860 > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public static bool get_HasUsedHintPicker()
    {
        Player val_1 = App.Player;
        if(23 > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public static void set_HasUsedHintPicker(bool value)
    {
        Player val_1 = App.Player;
        if(value != false)
        {
                Player val_2 = App.Player;
            0 = static_value_00280050 + 1;
        }
        
        if(2621448 != 0)
        {
                return;
        }
    
    }
    public static bool get_HasUsedHintMega()
    {
        Player val_1 = App.Player;
        if(35143868 > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public static void set_HasUsedHintMega(bool value)
    {
        Player val_1 = App.Player;
        if(value != false)
        {
                Player val_2 = App.Player;
            0 = static_value_00280054 + 1;
        }
        
        if(2621448 != 0)
        {
                return;
        }
    
    }
    public static bool get_HasUsedHintCheck()
    {
        Player val_1 = App.Player;
        if(23 > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public static void set_HasUsedHintCheck(bool value)
    {
        Player val_1 = App.Player;
        if(value != false)
        {
                Player val_2 = App.Player;
            0 = static_value_00280058 + 1;
        }
        
        if(2621448 != 0)
        {
                return;
        }
    
    }
    public static GameMode get_currentGameMode()
    {
        return CPlayerPrefs.GetInt(key:  -2045748304, defaultValue:  0);
    }
    public static void set_currentGameMode(GameMode value)
    {
        CPlayerPrefs.SetInt(key:  -2045748304, val:  value);
    }
    public static int get_freePlayLevel()
    {
        return CPlayerPrefs.GetInt(key:  -2045516000, defaultValue:  0);
    }
    public static void set_freePlayLevel(int value)
    {
        CPlayerPrefs.SetInt(key:  -2045516000, val:  value);
    }

}
