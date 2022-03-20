using UnityEngine;
public class PlayingLevel
{
    // Fields
    private static System.Collections.Generic.Dictionary<GameplayMode, object> gameLevels;
    private static bool initialized;
    
    // Properties
    private static string PP_Data { get; }
    public static GameplayMode CurrentGameplayMode { get; }
    
    // Methods
    private static string get_PP_Data()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public static GameplayMode get_CurrentGameplayMode()
    {
        if(CategoryPacksManager.IsPlaying == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2116505760) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == false)
        {
                2 = 1;
        }
    
    }
    public static void CompleteLevel(GameplayMode mode, System.Collections.Generic.Dictionary<string, object> parameters)
    {
        GameLevel val_1 = PlayingLevel.GetLevel(currentMode:  mode, parameters:  parameters);
        if(mode != 0)
        {
                parameters = 1;
            mem2[0] = parameters;
        }
        
        PlayingLevel.Save();
    }
    public static GameLevel GetCurrentDailyChallengeLevel()
    {
        return PlayingLevel.GetLevel(currentMode:  2, parameters:  0);
    }
    public static GameLevel GetMissedDailyChallengeLevel()
    {
        return PlayingLevel.GetLevel(currentMode:  3, parameters:  0);
    }
    public static GameLevel GetCategoryLevel(int categoryPackId = -1)
    {
        var val_29;
        var val_30;
        bool val_31;
        var val_32;
        int val_33;
        float val_34;
        var val_35;
        bool val_36;
        if(categoryPackId <= 1)
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        string val_3 = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8.ToString();
        Add(key:  -267504928, value:  -267492888);
        GameLevel val_4 = PlayingLevel.GetLevel(currentMode:  4, parameters:  78753792);
        val_29 = 4;
        val_30 = 1152921504901095424;
        val_31 = 1152921511094568976;
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_33 = GetPackProgress(packId:  public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8);
        if(val_29 != 0)
        {
                if(2621443 == val_33)
        {
                return;
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_8 = GetWordFromPack(packId:  public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8);
        GameBehavior val_9 = App.getBehavior;
        if(0 == 0)
        {
            goto label_21;
        }
        
        WordPets.WPTDataParser val_10 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        GameEcon val_11 = App.getGameEcon;
        val_34 = 1152921504685600768;
        val_31 = 5735661;
        val_35 = public static WordLevelGen MonoSingletonSelfGenerating<WordLevelGen>::get_Instance();
        GameLevel val_12 = BuildLevelBasedOnWord(daWord:  -2102212592, maxWordCount:  5735661, keepWord:  null);
        goto label_28;
        label_21:
        val_30 = 1152921504901095424;
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2101084320) == 0)
        {
            goto label_33;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_36 = 1;
        if(IsPlayingChallengingLevels == true)
        {
            goto label_37;
        }
        
        label_33:
        WordPets.WPTDataParser val_17 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        val_36 = IsWordUncommon(wordToCheck:  -2102212592);
        label_37:
        if(new BuildLevelBasedOnWordParams() != 0)
        {
                typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_20 = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance();
        }
        else
        {
                mem[32] = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance();
        }
        
        typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_1C = 1;
        GameEcon val_20 = App.getGameEcon;
        val_34 = 1152921504685600768;
        typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_24 = val_36;
        typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_8 = 5735661;
        typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_1E = 0;
        twelvegigs.Autopilot.AutopilotManager val_21 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_31 = 0;
        if((-2101084320) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_23 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_31 = IsPlayingChallengingLevels;
        }
        
        typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_1D = val_31;
        WordPets.WPTDataParser val_25 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        val_33 = val_33;
        val_35 = public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance();
        GameLevel val_26 = BuildLevelBasedOnWord(param:  384237568);
        label_28:
        val_29 = val_35;
        public static WADataParser MonoSingletonSelfGenerating<WADataParser>::get_Instance().__il2cppRuntimeField_C = val_33;
        val_34 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        string val_28 = public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8.ToString();
        val_32;
        Add(key:  -267504928, value:  -267492888);
        PlayingLevel.SetLevel(currentMode:  4, level:  -2101986464, parameters:  78753792, skipSaving:  false);
    }
    public static GameLevel GetLevelForPlayerLevel(int levelIndex = -1, bool checkLevelSkip = False)
    {
        var val_10 = null;
        if(PlayingLevel.initialized != true)
        {
                PlayingLevel.Initialize();
            val_10 = null;
        }
        
        val_10 = null;
        if((PlayingLevel.gameLevels.ContainsKey(key:  1)) == false)
        {
            goto label_30;
        }
        
        GameLevel val_2 = PlayingLevel.GetLevel(currentMode:  1, parameters:  0);
        Player val_3 = App.Player;
        if(0 == 50331648)
        {
                50331648 = 0;
        }
        
        if(50331648 == 0)
        {
            goto label_16;
        }
        
        label_30:
        WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        GameLevel val_5 = GetGameLevelForPlayerLevelFromChapter(playerLevel:  0, checkLevelSkip:  checkLevelSkip);
        Player val_6 = App.Player;
        public static WADChapterManager MonoSingletonSelfGenerating<WADChapterManager>::get_Instance().__il2cppRuntimeField_C = 0;
        PlayingLevel.SetLevel(currentMode:  1, level:  -2101761440, parameters:  0, skipSaving:  false);
        return PlayingLevel.GetLevel(currentMode:  1, parameters:  0);
        label_16:
        GameBehavior val_7 = App.getBehavior;
        string val_8 = 0.GetCurrentLanguage();
        if((System.String.op_Equality(a:  1, b:  null)) == false)
        {
            goto label_30;
        }
    
    }
    public static GameLevel GetLevel(GameplayMode currentMode, System.Collections.Generic.Dictionary<string, object> parameters)
    {
        GameplayMode val_11;
        UnityEngine.Material val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        val_11 = currentMode;
        val_12 = 1152921504982192128;
        val_13 = null;
        val_13 = null;
        if(PlayingLevel.initialized != true)
        {
                PlayingLevel.Initialize();
            val_13 = null;
        }
        
        val_13 = null;
        val_14 = 0;
        if((PlayingLevel.gameLevels.ContainsKey(key:  val_11)) == false)
        {
                return;
        }
        
        if(val_11 == 4)
        {
                if(parameters == 0)
        {
                return;
        }
        
            if((parameters.ContainsKey(key:  -267504928)) == false)
        {
                return;
        }
        
            val_15 = null;
            val_15 = null;
            val_11 = PlayingLevel.gameLevels;
            object val_3 = val_11.Item[4];
            if(val_11 == 0)
        {
                return;
        }
        
            val_11 = val_11;
            val_14 = 0;
            if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_11 = val_14;
        }
        
            object val_4 = parameters.Item[-267504928];
            string val_5 = parameters.ToString();
            val_12 = parameters;
            if((val_11.ContainsKey(key:  val_12)) == false)
        {
                return;
        }
        
            object val_7 = parameters.Item[-267504928];
            string val_8 = parameters.ToString();
            val_16 = val_11;
            string val_9 = val_16.Item[parameters];
        }
        else
        {
                val_17 = null;
            val_17 = null;
            object val_10 = PlayingLevel.gameLevels.Item[val_11];
            if(PlayingLevel.gameLevels == 0)
        {
                return;
        }
        
            if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (GameLevel.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_16 = 0;
        }
        
        }
        
        val_14 = val_16;
    }
    public static void SetLevel(GameplayMode currentMode, GameLevel level, System.Collections.Generic.Dictionary<string, object> parameters, bool skipSaving = False)
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_8;
        string val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_8 = currentMode;
        val_9 = parameters;
        val_10 = null;
        val_10 = null;
        if(PlayingLevel.initialized != true)
        {
                PlayingLevel.Initialize();
        }
        
        if(val_8 != 4)
        {
            goto label_6;
        }
        
        if((val_9 == 0) || ((val_9.ContainsKey(key:  -267504928)) == false))
        {
            goto label_8;
        }
        
        val_11 = null;
        val_11 = null;
        if((PlayingLevel.gameLevels.ContainsKey(key:  4)) != true)
        {
                val_12 = null;
            val_12 = null;
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            EnumerableExtentions.SetOrAdd<System.Int32Enum, System.Object>(dic:  PlayingLevel.gameLevels, key:  4, newValue:  78753792);
        }
        
        val_13 = null;
        val_13 = null;
        object val_4 = PlayingLevel.gameLevels.Item[4];
        val_8 = PlayingLevel.gameLevels;
        val_8 = null;
        val_8 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        object val_6 = val_9.Item[-267504928];
        val_9 = val_9;
        string val_7 = val_9.ToString();
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  78753792, key:  val_9, newValue:  level);
        goto label_25;
        label_6:
        val_14 = null;
        val_14 = null;
        EnumerableExtentions.SetOrAdd<System.Int32Enum, System.Object>(dic:  PlayingLevel.gameLevels, key:  val_8, newValue:  level);
        goto label_25;
        label_8:
        UnityEngine.Debug.LogError(message:  -267133008);
        label_25:
        if(skipSaving != false)
        {
                return;
        }
        
        PlayingLevel.Save();
    }
    public static int GetCurrentPlayerLevelNumber()
    {
        GameplayMode val_1 = PlayingLevel.CurrentGameplayMode;
        return PlayingLevel.GetCurrentPlayerLevelNumber(mode:  375345152);
    }
    public static int GetCurrentPlayerLevelNumber(GameplayMode mode)
    {
        var val_6;
        if(mode == 4)
        {
                val_6 = 1152921504901095424;
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance()) != 0)
        {
                return GetPackProgress(packId:  public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8);
        }
        
            return GetPackProgress(packId:  public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8);
        }
        
        GameBehavior val_4 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public static void Save()
    {
        float val_3;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        val_15 = null;
        val_15 = null;
        if(PlayingLevel.initialized != true)
        {
                PlayingLevel.Initialize();
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        val_16 = null;
        val_16 = null;
        Dictionary.Enumerator<TKey, TValue> val_2 = GetEnumerator();
        label_31:
        label_16:
        if(0.MoveNext() == false)
        {
            goto label_9;
        }
        
        if(0 == 4)
        {
            goto label_10;
        }
        
        if(R4 == 0)
        {
            goto label_16;
        }
        
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        string val_5 = R4.ToJSON();
        Add(key:  375291904, value:  R4);
        goto label_16;
        label_10:
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_6 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        if(R4 != 0)
        {
                val_17 = null;
        }
        
        if(R4 != 0)
        {
                val_17 = null;
            val_18 = 0;
            val_18 = 0;
        }
        else
        {
                val_18 = 0;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_7 = GetEnumerator();
        label_25:
        if(val_3.MoveNext() == false)
        {
            goto label_23;
        }
        
        string val_9 = 0.ToJSON();
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  78753792, key:  R4, newValue:  0);
        goto label_25;
        label_23:
        var val_15 = 0;
        val_15 = val_15 + 1;
        mem2[0] = 138;
        val_3.Dispose();
        if(val_15 != 1)
        {
                if(val_15 > 1)
        {
                0 = 1;
        }
        
            var val_16 = -266757312 + ((0 + 1)) << 2;
            val_16 = val_16 - 138;
            val_16 = val_16 >> 5;
            val_16 = 1 & val_16;
            val_19 = val_15 - val_16;
        }
        else
        {
                val_19 = 0;
        }
        
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        string val_10 = MiniJSON.Json.Serialize(obj:  78753792);
        Add(key:  375291904, value:  78753792);
        goto label_31;
        label_9:
        0.Dispose();
        string val_11 = PlayingLevel.PP_Data;
        string val_12 = MiniJSON.Json.Serialize(obj:  78753792);
        UnityEngine.PlayerPrefs.SetString(key:  375345152, value:  78753792);
    }
    private static void Load()
    {
        float val_7;
        WordPets.WPTPetTile val_14;
        var val_18;
        var val_19;
        var val_20;
        string val_1 = PlayingLevel.PP_Data;
        if((UnityEngine.PlayerPrefs.HasKey(key:  375345152)) == false)
        {
                return;
        }
        
        string val_3 = PlayingLevel.PP_Data;
        string val_4 = UnityEngine.PlayerPrefs.GetString(key:  375345152, defaultValue:  -2040381152);
        object val_5 = MiniJSON.Json.Deserialize(json:  375345152);
        val_18 = 0;
        Dictionary.Enumerator<TKey, TValue> val_6 = GetEnumerator();
        label_41:
        if(0.MoveNext() == false)
        {
            goto label_12;
        }
        
        System.Type val_9 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(375291904)});
        object val_10 = System.Enum.Parse(enumType:  375291904, value:  null);
        val_19 = 0;
        if( != 4)
        {
            goto label_36;
        }
        
        object val_11 = MiniJSON.Json.Deserialize(json:  R7);
        if(R7 == 0)
        {
            goto label_41;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_12 = GetEnumerator();
        label_31:
        if(val_7.MoveNext() == false)
        {
            goto label_25;
        }
        
        GameLevel val_15 = new GameLevel();
        FromJSON(jsonString:  null);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_16 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -267504928, value:  val_14);
        PlayingLevel.SetLevel(currentMode:  4, level:  279339008, parameters:  78753792, skipSaving:  true);
        goto label_31;
        label_25:
        var val_18 = 0;
        val_18 = val_18 + 1;
        mem2[0] = 259;
        val_7.Dispose();
        val_20 = 4;
        if(val_18 == 1)
        {
            goto label_36;
        }
        
        if((-266645304 + ((0 + 1)) << 2) != 259)
        {
            goto label_34;
        }
        
        var val_19 = val_18 >> 31;
        val_18 = val_18 + (~(val_18 >> 31));
        goto label_41;
        label_34:
        label_36:
        FromJSON(jsonString:  R7);
        PlayingLevel.SetLevel(currentMode:  4, level:  279339008, parameters:  0, skipSaving:  true);
        goto label_41;
        label_12:
        var val_20 = -266645304;
        val_20 = val_20 + (val_18 << 2);
        mem2[0] = 287;
        0.Dispose();
    }
    private static void Initialize()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(PlayingLevel.initialized == true)
        {
                return;
        }
        
        val_4 = (R5 + 92) + 4;
        mem2[0] = 1;
        System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>> val_1 = new System.Collections.Generic.Dictionary<WordPets.WordPetRarity, System.Collections.Generic.List<WordPets.WordPet>>();
        mem2[0] = null;
        PlayingLevel.Load();
    }
    public PlayingLevel()
    {
    
    }
    private static PlayingLevel()
    {
    
    }

}
