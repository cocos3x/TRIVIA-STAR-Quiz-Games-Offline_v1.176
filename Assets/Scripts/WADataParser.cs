using UnityEngine;
public class WADataParser : MonoSingletonSelfGenerating<WADataParser>
{
    // Fields
    private CrosswordCreator.Crossword.CrosswordGenerator this_generator;
    private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<string>> CommonWordsByLength;
    private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<string>> UncommonWordsByLength;
    private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<string>> RareWordsByLength;
    public static string debug_lastReqResult;
    public static string debug_lastReqDetermination;
    public static string debug_uncommonInAnswers;
    public static string debug_uncommonInRequiredExtra;
    public static System.Collections.Generic.List<string> debug_extraRequiredWords;
    private System.Collections.Generic.List<string> usedWordThisSession;
    private System.Collections.Generic.List<int> usedSpanishLevels;
    private int maxTries;
    private int minSpanishLevel;
    private static bool _QAHACK_NoExtraRequired;
    private int maxPredefinedLevels;
    private int builtInChapters;
    private const int levelsPerChapter = 20;
    private const string PP_Saved = "PP_SavedDataOnce";
    private string[] buckets;
    private string[] featureBuckets;
    private static string Debug_RanOutWhenTranslating;
    private static string Debug_FinishedContent;
    private static string QAhackedWord;
    private bool initialized;
    private bool initializing;
    private int version;
    private bool hasSynched;
    private const string PP_HasSynched = "PP_123j86_Sync";
    public const int LEVEL_GEN_VERSION = 1;
    public System.Action OnWADataParseInit;
    private const string pref_pl_vars_key = "wadwut_pl_vars";
    public const string pref_played_words_key = "wadwut_pw_vars";
    public const string pref_level_gen_version = "wadwut_lg_version";
    private System.Collections.Generic.List<int> plv_chapterWordLengths;
    private System.Collections.Generic.List<string> plv_playedWords;
    private const int CurrentLevelGenVersion = 3;
    private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<string>> _AllKnownWords;
    private int allPossibleWords;
    private System.Collections.Generic.List<WADataParser.LevelCurve> knownLevelCurves;
    private System.Collections.Generic.List<WADataParser.LevelCurve> featureLevelCurves;
    
    // Properties
    public System.Collections.Generic.List<GameLevel> CurrentLevelCurveGameLevels { get; set; }
    public static bool QAHACK_NoExtraRequired { get; set; }
    public int MaxPredefinedLevels { get; set; }
    public string PathToGameResources { get; }
    public static string QAHACK_RanOutReason { get; }
    public static string QAHACK_FinishedReason { get; }
    public static string QAHACK_SetDesiredLevelGenWord { get; set; }
    public bool HasInitialized { get; }
    private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<string>> AllKnownWords { get; }
    
    // Methods
    public System.Collections.Generic.List<bool> GetAllowedLetters(int level, int lettersSize, System.Collections.Generic.List<string> lettersArray, System.Collections.Generic.List<int> indexes)
    {
        int val_36;
        var val_37;
        System.Collections.Generic.List<System.Int32> val_38;
        System.Collections.Generic.List<System.String> val_39;
        var val_40;
        System.Collections.Generic.List<System.Int32> val_41;
        System.Collections.Generic.List<System.String> val_42;
        var val_43;
        System.Collections.Generic.List<System.Int32> val_44;
        System.Collections.Generic.List<System.String> val_45;
        var val_46;
        System.Collections.Generic.List<System.Int32> val_47;
        System.Collections.Generic.List<System.String> val_48;
        var val_49;
        var val_50;
        var val_51;
        System.Collections.Generic.List<System.Int32> val_52;
        System.Collections.Generic.List<System.String> val_53;
        var val_54;
        System.Collections.Generic.List<System.Int32> val_55;
        System.Collections.Generic.List<System.String> val_56;
        var val_57;
        System.Collections.Generic.List<System.Int32> val_58;
        System.Collections.Generic.List<System.String> val_59;
        val_36 = lettersSize;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1448559232) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            System.Collections.Generic.List<System.Boolean> val_5 = GetAllowedLettersForPan(level:  level, lettersSize:  val_36, lettersArray:  lettersArray, indexes:  indexes);
            return;
        }
        
        System.Collections.Generic.List<System.Boolean> val_6 = new System.Collections.Generic.List<System.Boolean>();
        if(val_6 != 0)
        {
                Add(item:  false);
            Add(item:  false);
        }
        else
        {
                Add(item:  false);
            Add(item:  false);
        }
        
        Add(item:  false);
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(ActivelyPlayingEventGameMode() == true)
        {
            goto label_133;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((PlayingChallenge == true) || (WGFTUXManager.CanShow == false))
        {
            goto label_133;
        }
        
        WordRegion val_12 = WordRegion.instance;
        System.Collections.Generic.List<System.String> val_13 = 0.GetCompletedWords();
        if(0 == 0)
        {
            goto label_28;
        }
        
        label_133:
        if(val_36 < 1)
        {
                return;
        }
        
        do
        {
            Add(item:  true);
            val_36 = val_36 - 1;
        }
        while((new System.Collections.Generic.List<System.Boolean>()) != 0);
        
        return;
        label_28:
        GameBehavior val_15 = App.getBehavior;
        string val_16 = 0.GetCurrentLanguage();
        bool val_17 = System.String.op_Equality(a:  null, b:  -2101987568);
        if(val_17 == false)
        {
            goto label_36;
        }
        
        if(level <= 1)
        {
            goto label_37;
        }
        
        if(level != 2)
        {
            goto label_133;
        }
        
        val_37 = 4;
        val_38 = indexes;
        goto label_39;
        label_51:
        if(val_17 <= val_36)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_39 = lettersArray;
        if(val_39 == 0)
        {
                val_39 = lettersArray;
        }
        
        if((lettersArray + 12) <= 2621443)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_43 = lettersArray + 8;
        val_43 = val_43 + 10485772;
        bool val_18 = (lettersArray + 8 + 10485772) + 16.Equals(value:  -1513226192);
        val_38 = indexes;
        if(val_18 == true)
        {
            goto label_44;
        }
        
        if(val_18 <= val_36)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((lettersArray + 12) <= 2621443)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_44 = lettersArray + 8;
        val_44 = val_44 + 10485772;
        val_38 = indexes;
        if(((lettersArray + 8 + 10485772) + 16.Equals(value:  -1439668112)) == false)
        {
            goto label_48;
        }
        
        label_44:
        set_Item(index:  val_36, value:  true);
        label_48:
        val_37 = 5;
        label_39:
        if((val_37 - 4) < val_6)
        {
            goto label_51;
        }
        
        return;
        label_36:
        bool val_21 = System.String.op_Equality(a:  null, b:  1800251696);
        if(val_21 == false)
        {
            goto label_53;
        }
        
        if(level <= 1)
        {
            goto label_54;
        }
        
        if(level != 2)
        {
            goto label_133;
        }
        
        val_40 = 4;
        val_41 = indexes;
        goto label_56;
        label_68:
        if(val_21 <= val_36)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_42 = lettersArray;
        if(val_42 == 0)
        {
                val_42 = lettersArray;
        }
        
        if((lettersArray + 12) <= 2621443)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_45 = lettersArray + 8;
        val_45 = val_45 + 10485772;
        bool val_22 = (lettersArray + 8 + 10485772) + 16.Equals(value:  -1930530848);
        val_41 = indexes;
        if(val_22 == true)
        {
            goto label_61;
        }
        
        if(val_22 <= val_36)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((lettersArray + 12) <= 2621443)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_46 = lettersArray + 8;
        val_46 = val_46 + 10485772;
        val_41 = indexes;
        if(((lettersArray + 8 + 10485772) + 16.Equals(value:  -1513226352)) == false)
        {
            goto label_65;
        }
        
        label_61:
        set_Item(index:  val_36, value:  true);
        label_65:
        val_40 = 5;
        label_56:
        if((val_40 - 4) < val_6)
        {
            goto label_68;
        }
        
        return;
        label_37:
        val_43 = 4;
        val_44 = indexes;
        goto label_70;
        label_82:
        if(val_17 <= val_36)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_45 = lettersArray;
        if(val_45 == 0)
        {
                val_45 = lettersArray;
        }
        
        if((lettersArray + 12) <= 2621443)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_47 = lettersArray + 8;
        val_47 = val_47 + 10485772;
        bool val_25 = (lettersArray + 8 + 10485772) + 16.Equals(value:  -140077968);
        val_44 = indexes;
        if(val_25 == true)
        {
            goto label_75;
        }
        
        if(val_25 <= val_36)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((lettersArray + 12) <= 2621443)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_48 = lettersArray + 8;
        val_48 = val_48 + 10485772;
        val_44 = indexes;
        if(((lettersArray + 8 + 10485772) + 16.Equals(value:  -1513226272)) == false)
        {
            goto label_79;
        }
        
        label_75:
        set_Item(index:  val_36, value:  true);
        label_79:
        val_43 = 5;
        label_70:
        if((val_43 - 4) < val_6)
        {
            goto label_82;
        }
        
        return;
        label_53:
        bool val_28 = System.String.op_Equality(a:  null, b:  -1655001248);
        if(val_28 == false)
        {
            goto label_84;
        }
        
        if(level <= 1)
        {
            goto label_85;
        }
        
        if(level != 2)
        {
            goto label_133;
        }
        
        val_46 = 4;
        val_47 = indexes;
        goto label_87;
        label_99:
        if(val_28 <= val_36)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_48 = lettersArray;
        if(val_48 == 0)
        {
                val_48 = lettersArray;
        }
        
        if((lettersArray + 12) <= 2621443)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_49 = lettersArray + 8;
        val_49 = val_49 + 10485772;
        bool val_29 = (lettersArray + 8 + 10485772) + 16.Equals(value:  -1513226272);
        val_47 = indexes;
        if(val_29 == true)
        {
            goto label_92;
        }
        
        if(val_29 <= val_36)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((lettersArray + 12) <= 2621443)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_50 = lettersArray + 8;
        val_50 = val_50 + 10485772;
        val_47 = indexes;
        if(((lettersArray + 8 + 10485772) + 16.Equals(value:  -1513226192)) == false)
        {
            goto label_96;
        }
        
        label_92:
        set_Item(index:  val_36, value:  true);
        label_96:
        val_46 = 5;
        label_87:
        if((val_46 - 4) < val_6)
        {
            goto label_99;
        }
        
        return;
        label_54:
        var val_51 = 22080659;
        val_51 = 13545128 + val_51;
        if(val_51 == 0)
        {
                mem2[0] = 1;
        }
        
        val_49 = null;
        val_49 = null;
        if(App.game == 18)
        {
            goto label_106;
        }
        
        if(val_51 == 0)
        {
                mem2[0] = 1;
        }
        
        val_50 = null;
        val_50 = null;
        if(App.game != 1)
        {
            goto label_162;
        }
        
        label_106:
        val_51 = 4;
        val_52 = indexes;
        goto label_113;
        label_129:
        if(App.game <= 1152921504892043264)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_53 = lettersArray;
        if(val_53 == 0)
        {
                val_53 = lettersArray;
        }
        
        if((lettersArray + 12) <= 2621443)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_52 = lettersArray + 8;
        val_52 = val_52 + 10485772;
        bool val_32 = (lettersArray + 8 + 10485772) + 16.Equals(value:  -1930531024);
        val_52 = indexes;
        if(val_32 == true)
        {
            goto label_122;
        }
        
        if(val_32 <= 1152921504892043264)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((lettersArray + 12) <= 2621443)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_53 = lettersArray + 8;
        val_53 = val_53 + 10485772;
        bool val_33 = (lettersArray + 8 + 10485772) + 16.Equals(value:  -1439668192);
        val_52 = indexes;
        if(val_33 == true)
        {
            goto label_122;
        }
        
        if(val_33 <= 1152921504892043264)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((lettersArray + 12) <= 2621443)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_54 = lettersArray + 8;
        val_54 = val_54 + 10485772;
        val_52 = indexes;
        if(((lettersArray + 8 + 10485772) + 16.Equals(value:  -366896400)) == false)
        {
            goto label_126;
        }
        
        label_122:
        set_Item(index:  1152921504892043264, value:  true);
        label_126:
        val_51 = 5;
        label_113:
        if((val_51 - 4) < val_6)
        {
            goto label_129;
        }
        
        return;
        label_84:
        bool val_36 = System.String.op_Equality(a:  null, b:  -1655001408);
        if(val_36 == false)
        {
            goto label_133;
        }
        
        if(level <= 1)
        {
            goto label_132;
        }
        
        if(level != 2)
        {
            goto label_133;
        }
        
        val_54 = 4;
        val_55 = indexes;
        goto label_134;
        label_146:
        if(val_36 <= val_36)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_56 = lettersArray;
        if(val_56 == 0)
        {
                val_56 = lettersArray;
        }
        
        if((lettersArray + 12) <= 2621443)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_55 = lettersArray + 8;
        val_55 = val_55 + 10485772;
        bool val_37 = (lettersArray + 8 + 10485772) + 16.Equals(value:  -1930531024);
        val_55 = indexes;
        if(val_37 == true)
        {
            goto label_139;
        }
        
        if(val_37 <= val_36)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((lettersArray + 12) <= 2621443)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_56 = lettersArray + 8;
        val_56 = val_56 + 10485772;
        val_55 = indexes;
        if(((lettersArray + 8 + 10485772) + 16.Equals(value:  -1930530848)) == false)
        {
            goto label_143;
        }
        
        label_139:
        set_Item(index:  val_36, value:  true);
        label_143:
        val_54 = 5;
        label_134:
        if((val_54 - 4) < val_6)
        {
            goto label_146;
        }
        
        return;
        label_85:
        val_57 = 4;
        val_58 = indexes;
        goto label_148;
        label_160:
        if(val_28 <= val_36)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_59 = lettersArray;
        if(val_59 == 0)
        {
                val_59 = lettersArray;
        }
        
        if((lettersArray + 12) <= 2621443)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_57 = lettersArray + 8;
        val_57 = val_57 + 10485772;
        bool val_40 = (lettersArray + 8 + 10485772) + 16.Equals(value:  -1640616320);
        val_58 = indexes;
        if(val_40 == true)
        {
            goto label_153;
        }
        
        if(val_40 <= val_36)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((lettersArray + 12) <= 2621443)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_58 = lettersArray + 8;
        val_58 = val_58 + 10485772;
        val_58 = indexes;
        if(((lettersArray + 8 + 10485772) + 16.Equals(value:  -1706786096)) == false)
        {
            goto label_157;
        }
        
        label_153:
        set_Item(index:  val_36, value:  true);
        label_157:
        val_57 = 5;
        label_148:
        if((val_57 - 4) < val_6)
        {
            goto label_160;
        }
    
    }
    public System.Collections.Generic.List<int> GetIndexesForTutorialLevel(int level, int lettersSize, System.Collections.Generic.List<string> lettersArray)
    {
        var val_26;
        System.Collections.Generic.List<System.Int32> val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        val_26 = level;
        val_27 = null;
        val_27 = new System.Collections.Generic.List<System.Int32>();
        if(val_27 != 0)
        {
                Add(item:  0);
            Add(item:  1);
        }
        else
        {
                Add(item:  0);
            Add(item:  1);
        }
        
        val_28 = 1152921510720759024;
        Add(item:  2);
        GameBehavior val_2 = App.getBehavior;
        string val_3 = 0.GetCurrentLanguage();
        if((System.String.op_Equality(a:  null, b:  -2101987568)) == false)
        {
            goto label_7;
        }
        
        if(val_26 <= 1)
        {
            goto label_8;
        }
        
        if(val_26 != 2)
        {
            goto label_56;
        }
        
        val_28 = 1152921513056828048;
        val_26 = 1152921511736958000;
        set_Item(index:  0, value:  lettersArray.IndexOf(item:  -1439668112));
        set_Item(index:  1, value:  lettersArray.IndexOf(item:  -1513226192));
        val_29 = public System.Int32 System.Collections.Generic.List<System.String>::IndexOf(System.String item);
        val_30 = "A";
        goto label_78;
        label_7:
        if((System.String.op_Equality(a:  null, b:  1800251696)) == false)
        {
            goto label_16;
        }
        
        if(val_26 <= 1)
        {
            goto label_17;
        }
        
        if(val_26 != 2)
        {
            goto label_56;
        }
        
        val_28 = 1152921513056828048;
        val_31 = public System.Int32 System.Collections.Generic.List<System.String>::IndexOf(System.String item);
        val_32 = "E";
        goto label_20;
        label_8:
        val_28 = 1152921513056828048;
        val_26 = 1152921511736958000;
        set_Item(index:  0, value:  lettersArray.IndexOf(item:  -1513226272));
        set_Item(index:  1, value:  lettersArray.IndexOf(item:  -140077968));
        val_29 = public System.Int32 System.Collections.Generic.List<System.String>::IndexOf(System.String item);
        val_30 = "S";
        goto label_78;
        label_16:
        if((System.String.op_Equality(a:  null, b:  -1655001408)) == false)
        {
            goto label_27;
        }
        
        if(val_26 <= 1)
        {
            goto label_28;
        }
        
        if(val_26 != 2)
        {
            goto label_56;
        }
        
        val_28 = 1152921513056828048;
        val_31 = public System.Int32 System.Collections.Generic.List<System.String>::IndexOf(System.String item);
        val_32 = "A";
        label_20:
        val_26 = 1152921511736958000;
        set_Item(index:  0, value:  lettersArray.IndexOf(item:  -1930531024));
        set_Item(index:  1, value:  lettersArray.IndexOf(item:  -1930530848));
        val_29 = public System.Int32 System.Collections.Generic.List<System.String>::IndexOf(System.String item);
        val_30 = "D";
        goto label_78;
        label_17:
        var val_26 = 22077299;
        val_26 = 13548488 + val_26;
        if(val_26 == 0)
        {
                mem2[0] = 1;
        }
        
        val_33 = null;
        val_33 = null;
        if(App.game == 18)
        {
            goto label_41;
        }
        
        if(val_26 == 0)
        {
                mem2[0] = 1;
        }
        
        val_34 = null;
        val_34 = null;
        if(App.game != 1)
        {
            goto label_47;
        }
        
        label_41:
        val_28 = 1152921513056828048;
        val_26 = 1152921511736958000;
        set_Item(index:  0, value:  lettersArray.IndexOf(item:  -1930531024));
        set_Item(index:  1, value:  lettersArray.IndexOf(item:  -1439668192));
        val_29 = public System.Int32 System.Collections.Generic.List<System.String>::IndexOf(System.String item);
        val_30 = "C";
        goto label_78;
        label_27:
        if((System.String.op_Equality(a:  null, b:  -1655001248)) == false)
        {
            goto label_56;
        }
        
        if(val_26 <= 1)
        {
            goto label_55;
        }
        
        if(val_26 != 2)
        {
            goto label_56;
        }
        
        val_28 = 1152921513056828048;
        val_26 = 1152921511736958000;
        set_Item(index:  0, value:  lettersArray.IndexOf(item:  -1513226272));
        set_Item(index:  1, value:  lettersArray.IndexOf(item:  -1513226192));
        val_29 = public System.Int32 System.Collections.Generic.List<System.String>::IndexOf(System.String item);
        val_30 = "P";
        goto label_78;
        label_56:
        val_27 = null;
        val_27 = new System.Collections.Generic.List<System.Int32>();
        if(lettersSize < 1)
        {
                return;
        }
        
        var val_27 = 0;
        do
        {
            Add(item:  0);
            val_27 = val_27 + 1;
        }
        while(lettersSize != val_27);
        
        return;
        label_28:
        val_28 = 1152921513056828048;
        val_26 = 1152921511736958000;
        set_Item(index:  0, value:  lettersArray.IndexOf(item:  -1930531024));
        set_Item(index:  1, value:  lettersArray.IndexOf(item:  -1439668112));
        val_29 = public System.Int32 System.Collections.Generic.List<System.String>::IndexOf(System.String item);
        val_30 = "F";
        goto label_78;
        label_47:
        val_28 = 1152921513056828048;
        val_26 = 1152921511736958000;
        set_Item(index:  0, value:  lettersArray.IndexOf(item:  -140077888));
        set_Item(index:  1, value:  lettersArray.IndexOf(item:  -233706528));
        val_29 = public System.Int32 System.Collections.Generic.List<System.String>::IndexOf(System.String item);
        val_30 = "G";
        goto label_78;
        label_55:
        val_28 = 1152921513056828048;
        val_26 = 1152921511736958000;
        set_Item(index:  0, value:  lettersArray.IndexOf(item:  -1706786096));
        set_Item(index:  1, value:  lettersArray.IndexOf(item:  -1640616320));
        val_29 = public System.Int32 System.Collections.Generic.List<System.String>::IndexOf(System.String item);
        val_30 = "R";
        label_78:
        set_Item(index:  2, value:  lettersArray.IndexOf(item:  1293130544));
    }
    public System.Collections.Generic.List<GameLevel> get_CurrentLevelCurveGameLevels()
    {
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        string val_3 = this.GetPlayerBucket();
        return this.GetLevels(language:  null, bucket:  null);
    }
    public void set_CurrentLevelCurveGameLevels(System.Collections.Generic.List<GameLevel> value)
    {
        var val_6;
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        val_6 = "A";
        Player val_3 = App.Player;
        if(0 != 0)
        {
                Player val_5 = App.Player;
            val_6 = 33449456;
        }
        
        this.SetLevels(language:  null, bucket:  33449456, levels:  value);
    }
    public System.Collections.Generic.List<GameLevel> GetFeatureLevelCurve(string bucket)
    {
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>> val_6;
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        LevelCurve val_3 = this.GetFeatureLevelCurve(lang:  null, bucket:  bucket);
        if(this != 0)
        {
                val_6 = this.CommonWordsByLength;
            return;
        }
        
        string val_4 = System.String.Format(format:  -139595856, arg0:  0, arg1:  bucket);
        UnityEngine.Debug.LogError(message:  -139595856);
        val_6 = null;
        val_6 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
    }
    private System.Collections.Generic.List<GameLevel> GetLevels(string language, string bucket)
    {
        object val_5;
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>> val_6;
        val_5 = bucket;
        goto label_0;
        label_6:
        string val_1 = System.String.Format(format:  -139466256, arg0:  language, arg1:  val_5);
        val_6 = 0;
        UnityEngine.Debug.LogError(message:  -139466256);
        if((System.String.op_Inequality(a:  language, b:  1800251696)) == false)
        {
                return;
        }
        
        val_6 = 0;
        if((System.String.op_Inequality(a:  val_5, b:  -1930531024)) == false)
        {
                return;
        }
        
        val_5 = "A";
        label_0:
        LevelCurve val_4 = this.GetLevelCurve(lang:  language, bucket:  -1930531024);
        if(this == 0)
        {
            goto label_6;
        }
        
        val_6 = this.CommonWordsByLength;
    }
    private void SetLevels(string language, string bucket, System.Collections.Generic.List<GameLevel> levels)
    {
        new WADataParser.LevelCurve(language:  language, bucket:  bucket, flattenedLevels:  levels).AddOrUpdateToLevelCurveList(curve:  384344064, levelCurves:  this.knownLevelCurves);
    }
    public bool IsWordUncommon(string wordToCheck)
    {
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>> val_5;
        var val_6;
        string val_1 = wordToCheck.Replace(oldValue:  -2100450224, newValue:  1098586544);
        val_5 = this.UncommonWordsByLength;
        Dictionary.Enumerator<TKey, TValue> val_2 = 0.GetEnumerator();
        label_5:
        if(0.MoveNext() == false)
        {
            goto label_3;
        }
        
        val_5 = 0;
        if((val_5.Contains(item:  wordToCheck)) == false)
        {
            goto label_5;
        }
        
        val_6 = 1;
        goto label_6;
        label_3:
        val_6 = 0;
        label_6:
        0.Dispose();
        return (bool)val_6;
    }
    public GameLevel BuildLevel(GameLevel inputLevel)
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1125090080, value:  inputLevel.word);
        Add(key:  1493058928, value:  inputLevel.answers);
        Add(key:  1368917616, value:  inputLevel.extraWords);
        Add(key:  -1386027600, value:  inputLevel.lvlName);
        Add(key:  -1125089760, value:  inputLevel.coords);
        Add(key:  -1968282976, value:  inputLevel.gridSize);
        return ParseLevel(thisLevel:  78753792);
    }
    public GameLevel ParseLevel(System.Collections.Generic.Dictionary<string, object> thisLevel)
    {
        string val_39;
        var val_40;
        System.Collections.Generic.IEnumerable<T> val_41;
        GameLevel val_1 = new GameLevel();
        object val_2 = thisLevel.Item[-1125090080];
        string val_3 = thisLevel.ToString();
        typeof(GameLevel).__il2cppRuntimeField_30 = thisLevel;
        object val_4 = thisLevel.Item[1493058928];
        string val_5 = thisLevel.ToString();
        typeof(GameLevel).__il2cppRuntimeField_34 = thisLevel;
        object val_6 = thisLevel.Item[1368917616];
        string val_7 = thisLevel.ToString();
        typeof(GameLevel).__il2cppRuntimeField_38 = thisLevel;
        object val_8 = thisLevel.Item[-1386027600];
        string val_9 = thisLevel.ToString();
        levelName = thisLevel;
        if((System.String.IsNullOrEmpty(value:  279339008)) != false)
        {
                string val_11 = typeof(GameLevel).__il2cppRuntimeField_30.Replace(oldValue:  -2100450224, newValue:  1098586544);
            levelName = typeof(GameLevel).__il2cppRuntimeField_30;
        }
        
        if((thisLevel.ContainsKey(key:  -1125089760)) != false)
        {
                object val_13 = thisLevel.Item[-1125089760];
            if(thisLevel != 0)
        {
                object val_14 = thisLevel.Item[-1968282976];
            if(thisLevel != 0)
        {
                object val_15 = thisLevel.Item[-1125089760];
            string val_16 = thisLevel.ToString();
            if((System.String.IsNullOrEmpty(value:  thisLevel)) != true)
        {
                object val_18 = thisLevel.Item[-1125089760];
            string val_19 = thisLevel.ToString();
            typeof(GameLevel).__il2cppRuntimeField_4C = thisLevel;
            object val_20 = thisLevel.Item[-1968282976];
            string val_21 = thisLevel.ToString();
            typeof(GameLevel).__il2cppRuntimeField_50 = thisLevel;
        }
        
        }
        
        }
        
        }
        
        val_39 = "d";
        if((thisLevel.ContainsKey(key:  -1605007504)) != false)
        {
                object val_23 = thisLevel.Item[-1605007504];
            string val_24 = thisLevel.ToString();
            if((System.String.IsNullOrEmpty(value:  thisLevel)) != true)
        {
                object val_26 = thisLevel.Item[-1605007504];
            val_39 = thisLevel;
            string val_27 = val_39.ToString();
            string val_28 = typeof(GameLevel).__il2cppRuntimeField_38 + -2100450224(-2100450224) + val_39;
            typeof(GameLevel).__il2cppRuntimeField_38 = typeof(GameLevel).__il2cppRuntimeField_38;
        }
        
        }
        
        if((thisLevel.ContainsKey(key:  -138891088)) == false)
        {
            goto label_33;
        }
        
        object val_30 = thisLevel.Item[-138891088];
        string val_31 = thisLevel.ToString();
        val_40 = 1152921504886186116;
        if((System.Single.TryParse(s:  thisLevel, result: out  float val_32 = 6.562416E-29f)) == false)
        {
            goto label_36;
        }
        
        goto label_37;
        label_33:
        val_40 = 1152921504886186116;
        label_36:
        GameLevel.__il2cppRuntimeField_actualSize.__il2cppRuntimeField_FFFFFFFFFFFFFFFF = 3212836864;
        label_37:
        typeof(GameLevel).__il2cppRuntimeField_54 = "";
        typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
        System.String[] val_34 = typeof(GameLevel).__il2cppRuntimeField_38.Split(separator:  478563824);
        val_41 = typeof(GameLevel).__il2cppRuntimeField_38;
        System.Collections.Generic.List<ZooTile> val_35 = new System.Collections.Generic.List<ZooTile>(collection:  val_41);
        typeof(GameLevel).__il2cppRuntimeField_54 = List<T>.__il2cppRuntimeField_10;
        val_39 = "|";
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        string val_36 = List<T>.__il2cppRuntimeField_10(List<T>.__il2cppRuntimeField_10) + -2100450224(-2100450224) + List<T>.__il2cppRuntimeField_14(List<T>.__il2cppRuntimeField_14);
        typeof(GameLevel).__il2cppRuntimeField_54 = List<T>.__il2cppRuntimeField_10;
        val_41 = List<T>.__il2cppRuntimeField_10;
        var val_37 = 5 + 1;
        var val_38 = 5 - 3;
        GameBehavior val_39 = App.getBehavior;
        string val_40 = 0.GetCurrentLanguage();
        typeof(GameLevel).__il2cppRuntimeField_44 = 0;
    }
    public void GenerateNewGrid(GameLevel gameLevel, int triesBeforeEasier = 100)
    {
        twelvegigs.sweepstakes.Distribution val_7;
        int val_36;
        var val_37;
        var val_38;
        var val_39;
        val_36 = this;
        typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
        System.String[] val_1 = gameLevel.answers.Split(separator:  478563824);
        System.Collections.Generic.List<ZooTile> val_2 = new System.Collections.Generic.List<ZooTile>(collection:  gameLevel.answers);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        List.Enumerator<T> val_5 = GetEnumerator();
        label_12:
        if(MoveNext() == false)
        {
            goto label_6;
        }
        
        if((val_7.StartsWith(value:  -2063697616)) == false)
        {
            goto label_8;
        }
        
        Add(item:  val_7);
        goto label_12;
        label_8:
        Add(item:  val_7);
        goto label_12;
        label_6:
        Dispose();
        System.Collections.Generic.List<ZooTile> val_9 = new System.Collections.Generic.List<ZooTile>(collection:  80883712);
        label_26:
        var val_36 = triesBeforeEasier - 1;
        label_16:
        this.this_generator.Generate(words:  80883712, maxWidth:  12, maxHeight:  12);
        val_36 = val_36 - 1;
        if(this.this_generator >= 0)
        {
                if(this.this_generator.usedAllWords == false)
        {
            goto label_16;
        }
        
        }
        
        if(this.this_generator.usedAllWords != true)
        {
                if(gameLevel != 0)
        {
                gameLevel.WordRemoval(maxCount:  1094062063, removePercent:  0, removePlurals:  false, rareWords:  0);
        }
        else
        {
                0.WordRemoval(maxCount:  1094062063, removePercent:  0, removePlurals:  false, rareWords:  0);
        }
        
            typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
            System.String[] val_13 = gameLevel + 52.Split(separator:  478563824);
            System.Collections.Generic.List<ZooTile> val_14 = new System.Collections.Generic.List<ZooTile>(collection:  gameLevel + 52);
            System.Collections.Generic.List<ZooTile> val_15 = new System.Collections.Generic.List<ZooTile>(collection:  80883712);
        }
        
        if(this.this_generator.usedAllWords == false)
        {
            goto label_26;
        }
        
        System.Text.StringBuilder val_17 = null;
        val_37 = val_17;
        val_17 = new System.Text.StringBuilder();
        val_38 = 4;
        val_39 = 1152921504619999232;
        goto label_31;
        label_49:
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        CrosswordCreator.Crossword.WordTuple val_18 = this.this_generator._board.WordTuples.Item[List<T>.__il2cppRuntimeField_10];
        val_39 = val_39;
        if(val_38 != 4)
        {
                System.Text.StringBuilder val_19 = Append(value:  -2100450224);
        }
        
        if(val_37 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            int val_20 = System.Math.Max(val1:  0, val2:  List<T>.__il2cppRuntimeField_10 + 8);
            val_39 = val_39;
        }
        
        string val_21 = System.String.Format(format:  -138720640, arg0:  13152256, arg1:  13152256, arg2:  13152256);
        val_37 = val_37;
        System.Text.StringBuilder val_22 = Append(value:  -138720640);
        val_38 = 5;
        label_31:
        if((val_38 - 4) < this.this_generator._board.WordTuples.Count)
        {
            goto label_49;
        }
        
        mem2[0] = val_37;
        string val_25 = this.this_generator._board.yWindow.ToString();
        string val_26 = this.this_generator._board.xWindow.ToString();
        string val_27 = -138662428(-138662428) + -2100450224(-2100450224) + -138662428(-138662428);
        mem2[0] = ;
        val_36 = this.this_generator._board.xWindow + 1;
        List.Enumerator<T> val_28 = List<T>.__il2cppRuntimeField_10 + 8.GetEnumerator();
        label_64:
        if(MoveNext() == false)
        {
            goto label_62;
        }
        
        if((val_7.StartsWith(value:  -2063697616)) == false)
        {
            goto label_64;
        }
        
        val_36 = 0;
        string val_31 = System.String.Format(format:  -138674464, arg0:  1254115712, arg1:  13152256, arg2:  1633189168);
        string val_32 = gameLevel + 76(gameLevel + 76) + -138674464(-138674464);
        mem2[0] = gameLevel + 76;
        var val_37 = val_7 + 8;
        val_37 = val_37 - 1;
        label_62:
        Dispose();
        string val_33 = val_37.ToString();
        int val_38 = this.this_generator._board.xWindow;
        val_38 = val_38 + 2;
        string val_34 = val_38.ToString();
        string val_35 = -138662408(-138662408) + -2100450224(-2100450224) + -138662428(-138662428);
        mem2[0] = ;
    }
    public GameLevel GetDynamicDailyChallengeLevel(DynamicLevelBuildParams param)
    {
        return this.BuildDynamicLevel(param:  param);
    }
    public GameLevel BuildDynamicLevel(DynamicLevelBuildParams param)
    {
        com.adjust.sdk.JSONNode val_16;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        System.Collections.Generic.List<ZooTile> val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        GameLevel val_1 = new GameLevel();
        typeof(GameLevel).__il2cppRuntimeField_34 = "";
        System.Collections.Generic.List<System.Boolean> val_2 = new System.Collections.Generic.List<System.Boolean>();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        CompanyDevices val_4 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                float val_42 = 3.83693E-38f;
            val_42 = 13557524 + val_42;
            if(val_42 == 0)
        {
                mem2[0] = 1;
        }
        
            val_42 = null;
            val_42 = null;
            if((System.String.op_Inequality(a:  WADataParser.QAhackedWord, b:  System.String.alignConst)) != false)
        {
                if(val_42 == 0)
        {
                mem2[0] = 1;
        }
        
            val_43 = null;
            val_43 = null;
            if(WADataParser.QAhackedWord.m_stringLength >= 5)
        {
                if(val_42 == 0)
        {
                mem2[0] = 1;
        }
        
            val_44 = null;
            val_44 = null;
            if(WADataParser.QAhackedWord.m_stringLength <= 9)
        {
                if(val_42 == 0)
        {
                mem2[0] = 1;
        }
        
            val_45 = null;
            val_45 = null;
            param.levelWordLength = WADataParser.QAhackedWord.m_stringLength;
            if(val_42 == 0)
        {
                mem2[0] = 1;
        }
        
            val_46 = null;
            val_46 = null;
            string val_7 = WADataParser.QAhackedWord.ToUpper();
            if((this.plv_playedWords.Contains(item:  WADataParser.QAhackedWord)) != false)
        {
                if(val_42 == 0)
        {
                mem2[0] = 1;
        }
        
            val_47 = null;
            val_47 = null;
            string val_9 = WADataParser.QAhackedWord.ToUpper();
            bool val_10 = this.plv_playedWords.Remove(item:  WADataParser.QAhackedWord);
        }
        
        }
        
        }
        
        }
        
        }
        
        label_123:
        typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
        System.String[] val_11 = Split(separator:  478563824);
        System.TimeType val_12 = mem[1152921513058469904].Item[param + 32];
        val_48 = null;
        val_48 = new System.Collections.Generic.List<ZooTile>(collection:  mem[1152921513058469904]);
        List.Enumerator<T> val_14 = GetEnumerator();
        var val_43 = 0;
        label_57:
        if(MoveNext() == false)
        {
            goto label_55;
        }
        
        bool val_17 = Remove(item:  val_16);
        goto label_57;
        label_55:
        val_43 = val_43 + 1;
        mem2[0] = 253;
        Dispose();
        if(val_43 != 1)
        {
                if(val_43 > 1)
        {
                0 = 1;
        }
        
            var val_44 = -138323792 + ((0 + 1)) << 2;
            val_44 = val_44 - 253;
            val_44 = val_44 >> 5;
            val_44 = 1 & val_44;
            val_49 = val_43 - val_44;
        }
        else
        {
                val_49 = 0;
        }
        
        System.TimeType val_18 = mem[1152921513058469908].Item[param + 32];
        val_48 = null;
        val_48 = new System.Collections.Generic.List<ZooTile>(collection:  mem[1152921513058469908]);
        List.Enumerator<T> val_20 = GetEnumerator();
        var val_45 = val_49;
        label_67:
        if(MoveNext() == false)
        {
            goto label_65;
        }
        
        bool val_22 = Remove(item:  val_16);
        goto label_67;
        label_65:
        val_45 = val_45 + 1;
        mem2[0] = 345;
        Dispose();
        if(val_45 != 1)
        {
                if(val_45 > 1)
        {
                0 = 1;
        }
        
            var val_46 = -138323792 + ((val_49 + 1)) << 2;
            val_46 = val_46 - 345;
            val_46 = val_46 >> 5;
            val_46 = 1 & val_46;
            val_50 = val_45 - val_46;
        }
        else
        {
                val_50 = 0;
        }
        
        System.TimeType val_23 = mem[1152921513058469904].Item[param + 32];
        List.Enumerator<T> val_24 = GetEnumerator();
        var val_47 = val_50;
        label_77:
        if(MoveNext() == false)
        {
            goto label_75;
        }
        
        bool val_26 = this.plv_playedWords.Remove(item:  val_16);
        goto label_77;
        label_75:
        val_47 = val_47 + 1;
        mem2[0] = 430;
        Dispose();
        if(val_47 != 1)
        {
                if(val_47 > 1)
        {
                0 = 1;
        }
        
            var val_48 = -138323792 + ((val_50 + 1)) << 2;
            val_48 = val_48 - 430;
            val_48 = val_48 >> 5;
            val_48 = 1 & val_48;
            val_51 = val_47 - val_48;
        }
        else
        {
                val_51 = 0;
        }
        
        System.TimeType val_27 = mem[1152921513058469908].Item[param + 32];
        List.Enumerator<T> val_28 = GetEnumerator();
        label_85:
        if(MoveNext() == false)
        {
            goto label_83;
        }
        
        bool val_30 = this.plv_playedWords.Remove(item:  val_16);
        goto label_85;
        label_83:
        val_51 = val_51 + 1;
        mem2[0] = 504;
        Dispose();
        if(val_51 != 1)
        {
                if(val_51 > 1)
        {
                0 = 1;
        }
        
            var val_49 = -138323792 + ((val_51 + 1)) << 2;
            val_49 = val_49 - 504;
            val_49 = val_49 >> 5;
            val_49 = 1 & val_49;
            val_51 = val_51 - val_49;
        }
        
        System.TimeType val_31 = mem[1152921513058469904].Item[param + 32];
        val_48 = null;
        val_48 = new System.Collections.Generic.List<ZooTile>(collection:  mem[1152921513058469904]);
        CompanyDevices val_33 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
            goto label_107;
        }
        
        var val_50 = 22076690;
        val_50 = 13560064 + val_50;
        val_52 = null;
        val_52 = null;
        if((System.String.op_Inequality(a:  WADataParser.QAhackedWord, b:  System.String.alignConst)) == false)
        {
            goto label_107;
        }
        
        var val_51 = 22076510;
        val_51 = 13560244 + val_51;
        val_53 = null;
        val_53 = null;
        string val_36 = WADataParser.QAhackedWord.ToUpper();
        if((Contains(item:  WADataParser.QAhackedWord)) == false)
        {
            goto label_107;
        }
        
        var val_52 = 22076294;
        val_52 = 13560460 + val_52;
        val_54 = null;
        val_54 = null;
        string val_38 = WADataParser.QAhackedWord.ToUpper();
        val_55 = WADataParser.QAhackedWord;
        goto label_114;
        label_107:
        int val_39 = RandomSet.singleInRange(lowest:  0, highest:  1094062063);
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_55 = mem[(System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_39) << 2) + 16];
        val_55 = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_39) << 2) + 16;
        label_114:
        if(new BuildLevelBasedOnWordParams() != 0)
        {
                typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_20 = val_55;
        }
        else
        {
                mem[32] = val_55;
        }
        
        typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_1C = 1;
        if(param != 0)
        {
                typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_8 = param + 8;
            typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_C = param + 12;
            typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_10 = param + 16;
            typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_1E = param + 30;
        }
        else
        {
                typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_8 = param + 8;
            typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_C = param + 12;
            typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_10 = param + 16;
            typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_1E = param + 30;
        }
        
        typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_14 = param + 20;
        GameLevel val_41 = this.BuildLevelBasedOnWord(param:  384237568);
        goto label_123;
    }
    public GameLevel BuildLevelBasedOnWord(BuildLevelBasedOnWordParams param)
    {
        var val_49;
        var val_50;
        WADataParser val_51;
        WADataParser val_52;
        var val_53;
        WADataParser val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        var val_60;
        string val_1 = param.levelWord.Replace(oldValue:  -2100450224, newValue:  1098586544);
        param.levelWord = param.levelWord;
        string val_4 = param.levelWord.Chars[0].ToString();
        typeof(GameLevel).__il2cppRuntimeField_30 = ;
        val_49 = 1;
        goto label_5;
        label_8:
        string val_6 = param.levelWord.Chars[1].ToString();
        string val_7 = -138149254(-138149254) + -2100450224(-2100450224) + -138149254(-138149254);
        val_49 = 2;
        typeof(GameLevel).__il2cppRuntimeField_30 = typeof(GameLevel).__il2cppRuntimeField_30;
        label_5:
        if(val_49 < param.levelWord.m_stringLength)
        {
            goto label_8;
        }
        
        if(param.levelWord.m_stringLength > 4)
        {
                val_50 = 3;
        }
        
        System.Collections.Generic.List<System.String> val_8 = this.GetAvailableWordsFromList(word:  param.levelWord, listToUse:  this.CommonWordsByLength, startingLength:  3, endingLength:  param.levelWord.m_stringLength);
        System.Collections.Generic.List<System.String> val_9 = this.GetAvailableWordsFromList(word:  param.levelWord, listToUse:  this.UncommonWordsByLength, startingLength:  3, endingLength:  param.levelWord.m_stringLength);
        if(this == 1)
        {
                this = 6;
        }
        
        if(param.levelWord == 1)
        {
                param.levelWord = 3;
        }
        
        System.Collections.Generic.List<System.String> val_11 = this.GetAvailableWordsFromList(word:  param.levelWord, listToUse:  this.RareWordsByLength, startingLength:  3, endingLength:  System.Math.Min(val1:  param.levelWord.m_stringLength, val2:  6));
        System.Collections.Generic.IEnumerable<TSource> val_12 = System.Linq.Enumerable.Distinct<System.Object>(source:  -138137216);
        System.Collections.Generic.List<TSource> val_13 = System.Linq.Enumerable.ToList<System.Object>(source:  -138137216);
        val_51 = this;
        System.Collections.Generic.IEnumerable<TSource> val_14 = System.Linq.Enumerable.Distinct<System.Object>(source:  -138137216);
        System.Collections.Generic.List<TSource> val_15 = System.Linq.Enumerable.ToList<System.Object>(source:  -138137216);
        System.Collections.Generic.IEnumerable<TSource> val_16 = System.Linq.Enumerable.Distinct<System.Object>(source:  -138137216);
        System.Collections.Generic.List<TSource> val_17 = System.Linq.Enumerable.ToList<System.Object>(source:  -138137216);
        typeof(GameLevel).__il2cppRuntimeField_54 = "";
        typeof(GameLevel).__il2cppRuntimeField_34 = "";
        typeof(GameLevel).__il2cppRuntimeField_38 = "";
        typeof(GameLevel).__il2cppRuntimeField_5C = "";
        val_52 = this;
        if(mem[1152921513058644364] >= 1)
        {
                typeof(GameLevel).__il2cppRuntimeField_34 = mem[1152921513058644360] + 16;
            if(mem[1152921513058644364] >= 2)
        {
                do
        {
            if(mem[1152921513058644364] <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if((System.String.IsNullOrEmpty(value:  mem[1152921513058644360] + 20)) != true)
        {
                if(mem[1152921513058644364] <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            string val_19 = typeof(GameLevel).__il2cppRuntimeField_34 + -2100450224(-2100450224) + mem[1152921513058644360] + 20(mem[1152921513058644360] + 20);
            typeof(GameLevel).__il2cppRuntimeField_34 = typeof(GameLevel).__il2cppRuntimeField_34;
        }
        
            var val_20 = 5 + 1;
        }
        while((5 - 3) < mem[1152921513058644364]);
        
        }
        
        }
        
        val_53 = mem[1152921513058644364];
        if(val_53 >= 1)
        {
                if(param == 0)
        {
                val_53 = mem[1152921513058644364];
        }
        
            if((param.includeUncommonAsRequiredWords != false) && (val_53 >= 1))
        {
                val_54 = val_51;
            do
        {
            if(val_53 <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if((System.String.IsNullOrEmpty(value:  mem[1152921513058644360] + 16)) != true)
        {
                if(mem[1152921513058644364] <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_52 = this;
            if((typeof(GameLevel).__il2cppRuntimeField_34.Contains(value:  mem[1152921513058644360] + 16)) != true)
        {
                val_55 = mem[1152921513058644364];
            if(val_55 <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_55 = mem[1152921513058644364];
        }
        
            if(val_55 <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            string val_24 = typeof(GameLevel).__il2cppRuntimeField_34 + -2100450224(-2100450224) + mem[1152921513058644360] + 16(mem[1152921513058644360] + 16);
            typeof(GameLevel).__il2cppRuntimeField_34 = typeof(GameLevel).__il2cppRuntimeField_34;
        }
        
        }
        
            val_53 = mem[1152921513058644364];
            var val_26 = 4 + 1;
        }
        while((4 - 3) < val_53);
        
        }
        else
        {
                val_54 = val_51;
        }
        
            if(val_53 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_51 = val_54;
            typeof(GameLevel).__il2cppRuntimeField_38 = mem[1152921513058644360] + 16;
            if(mem[1152921513058644364] >= 2)
        {
                do
        {
            if(mem[1152921513058644364] <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if((System.String.IsNullOrEmpty(value:  mem[1152921513058644360] + 20)) != true)
        {
                if(mem[1152921513058644364] <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_52 = this;
            if((typeof(GameLevel).__il2cppRuntimeField_38.Contains(value:  mem[1152921513058644360] + 20)) != true)
        {
                if(mem[1152921513058644364] <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            string val_29 = typeof(GameLevel).__il2cppRuntimeField_38 + -2100450224(-2100450224) + mem[1152921513058644360] + 20(mem[1152921513058644360] + 20);
            typeof(GameLevel).__il2cppRuntimeField_38 = typeof(GameLevel).__il2cppRuntimeField_38;
        }
        
        }
        
            var val_31 = 5 + 1;
        }
        while((5 - 3) < mem[1152921513058644364]);
        
        }
        
        }
        
        levelName = param.levelWord;
        if(new GameLevel() != 0)
        {
                if(val_52 <= 1)
        {
                GameEcon val_32 = App.getGameEcon;
            val_56 = 0;
        }
        
            if(param.includeUncommonAsRequiredWords != false)
        {
                GameEcon val_34 = App.getGameEcon;
            WordRemovalWithUncommonWords(maxCount:  0, removePercent:  0, removePlurals:  true, rareWords:  this, uncommonWords:  this);
        }
        else
        {
                GameEcon val_35 = App.getGameEcon;
            WordRemoval(maxCount:  0, removePercent:  0, removePlurals:  true, rareWords:  this);
        }
        
        }
        
        typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
        System.String[] val_36 = typeof(GameLevel).__il2cppRuntimeField_38.Split(separator:  478563824);
        typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
        System.String[] val_37 = typeof(GameLevel).__il2cppRuntimeField_34.Split(separator:  478563824);
        typeof(GameLevel).__il2cppRuntimeField_54 = "";
        var val_56 = 22062135;
        val_56 = 13563652 + val_56;
        if(val_56 == 0)
        {
                mem2[0] = 1;
        }
        
        val_57 = null;
        val_57 = null;
        val_58 = 4;
        if(App.game == 4)
        {
                this = val_51;
        }
        
        goto label_79;
        label_85:
        if(App.game <= param)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((System.Linq.Enumerable.Contains<System.Type>(source:  typeof(GameLevel).__il2cppRuntimeField_34, value:  mem[1152921513058644360] + 16)) != true)
        {
                if(mem[1152921513058644364] <= param)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            string val_39 = 1098586544 + mem[1152921513058644360] + 16(mem[1152921513058644360] + 16) + -2100450224(-2100450224);
            typeof(GameLevel).__il2cppRuntimeField_54 = typeof(GameLevel).__il2cppRuntimeField_54;
        }
        
        val_58 = 5;
        label_79:
        if((val_58 - 4) < mem[1152921513058644364])
        {
            goto label_85;
        }
        
        typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
        System.String[] val_41 = typeof(GameLevel).__il2cppRuntimeField_34.Split(separator:  478563824);
        System.Collections.Generic.List<TSource> val_42 = System.Linq.Enumerable.ToList<System.Object>(source:  typeof(GameLevel).__il2cppRuntimeField_34);
        typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
        System.String[] val_43 = typeof(GameLevel).__il2cppRuntimeField_38.Split(separator:  478563824);
        System.Collections.Generic.List<TSource> val_44 = System.Linq.Enumerable.ToList<System.Object>(source:  typeof(GameLevel).__il2cppRuntimeField_38);
        typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
        System.String[] val_45 = Split(separator:  478563824);
        System.Collections.Generic.List<TSource> val_46 = System.Linq.Enumerable.ToList<System.Object>(source:  1098586544);
        if((param + 30) != 0)
        {
                this.CalculateExtraRequiredWords(resultLevel:  279339008, answersList:  typeof(GameLevel).__il2cppRuntimeField_34, inWUT:  (App.game - 4) >> 5, requiredExtraWords:  param + 40);
        }
        
        if((typeof(GameLevel).__il2cppRuntimeField_34.EndsWith(value:  -2100450224)) != false)
        {
                val_59 = mem[mem[1152921513058644360] + 16 + 8];
            val_59 = mem[1152921513058644360] + 16 + 8;
            string val_51 = typeof(GameLevel).__il2cppRuntimeField_34.Substring(startIndex:  0, length:   - 1);
            typeof(GameLevel).__il2cppRuntimeField_34 = typeof(GameLevel).__il2cppRuntimeField_34;
        }
        
        if((typeof(GameLevel).__il2cppRuntimeField_38.EndsWith(value:  -2100450224)) != false)
        {
                val_60 = mem[mem[1152921513058644360] + 16 + 8];
            val_60 = mem[1152921513058644360] + 16 + 8;
            string val_54 = typeof(GameLevel).__il2cppRuntimeField_38.Substring(startIndex:  0, length:   - 1);
            typeof(GameLevel).__il2cppRuntimeField_38 = typeof(GameLevel).__il2cppRuntimeField_38;
        }
        
        if((EndsWith(value:  -2100450224)) != false)
        {
            
        }
    
    }
    private void CalculateExtraRequiredWords(GameLevel resultLevel, System.Collections.Generic.List<string> answersList, bool inWUT, int requiredExtraWords)
    {
        string val_22;
        bool val_59;
        float val_60;
        int val_61;
        var val_62;
        int val_63;
        var val_64;
        var val_65;
        var val_66;
        val_59 = inWUT;
        if(val_59 != false)
        {
                int val_1 = CalculateRequiredExtraWordsWUT();
        }
        
        val_61 = CalculateRequiredExtraWordsWAD();
        int val_3 = System.Math.Max(val1:  val_61, val2:  requiredExtraWords);
        if(val_3 < 1)
        {
                return;
        }
        
        Player val_4 = App.Player;
        GameEcon val_5 = App.getGameEcon;
        if(35143896 < 0)
        {
            goto label_11;
        }
        
        Player val_6 = App.Player;
        GameEcon val_7 = App.getGameEcon;
        if(35143896 <= 1)
        {
            goto label_17;
        }
        
        label_11:
        MainController val_8 = MainController.instance;
        mem[140] = 0;
        goto label_21;
        label_17:
        int val_9 = val_3 + 1;
        MainController val_10 = MainController.instance;
        mem[140] = 1;
        string val_11 = WADataParser.debug_lastReqDetermination + -137987776(-137987776);
        WADataParser.debug_lastReqDetermination = WADataParser.debug_lastReqDetermination;
        string val_12 = val_9.ToString();
        WADataParser.CurrentLevelGenVersion = val_9;
        label_21:
        if(WADataParser._QAHACK_NoExtraRequired != false)
        {
                WADataParser.debug_lastReqDetermination = "qa hack no extra";
        }
        
        GameBehavior val_13 = App.getBehavior;
        if(0 == 0)
        {
                WADataParser.debug_lastReqDetermination = "extra required words not supported";
        }
        
        if(resultLevel != 0)
        {
                resultLevel.extraWordsNeeded = 0;
        }
        else
        {
                mem[88] = 0;
        }
        
        typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
        System.String[] val_14 = resultLevel.availExtraReq.Split(separator:  478563824);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_15 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(0 >= resultLevel.availExtraReq.m_firstChar)
        {
            goto label_48;
        }
        
        if(0 < 1)
        {
            goto label_60;
        }
        
        var val_60 = 0;
        label_59:
        var val_59 = 99;
        label_55:
        int val_17 = UnityEngine.Random.Range(min:  0, max:  resultLevel.availExtraReq.m_firstChar);
        string val_18 = resultLevel.availExtraReq + (val_17 << 2);
        if((Contains(item:  val_17)) == true)
        {
            goto label_52;
        }
        
        bool val_20 = System.String.IsNullOrEmpty(value:  val_17);
        if(val_20 == false)
        {
            goto label_53;
        }
        
        label_52:
        val_59 = val_59 - 1;
        if(val_20 < false)
        {
            goto label_60;
        }
        
        if(val_60 < 0)
        {
            goto label_55;
        }
        
        goto label_60;
        label_53:
        Add(item:  val_17);
        if(val_59 < 1)
        {
            goto label_60;
        }
        
        val_60 = val_60 + 1;
        if(val_60 < 0)
        {
            goto label_59;
        }
        
        goto label_60;
        label_48:
        AddRange(collection:  resultLevel.availExtraReq);
        label_60:
        List.Enumerator<T> val_21 = GetEnumerator();
        goto label_70;
        label_72:
        if((answersList.Contains(item:  val_22)) != true)
        {
                string val_24 = -2063697616(-2063697616) + val_22;
            if((answersList.Contains(item:  -2063697616)) != true)
        {
                string val_26 = val_22.ToLower();
            if((System.String.op_Equality(a:  val_22, b:  -2059681344)) != true)
        {
                if((System.String.IsNullOrEmpty(value:  val_22)) != true)
        {
                string val_29 = System.String.Format(format:  -137979216, arg0:  val_22);
            string val_30 = resultLevel.extraRequiredWords + -137979216(-137979216);
            resultLevel.extraRequiredWords = resultLevel.extraRequiredWords;
            string val_31 = System.String.Format(format:  -1671354896, arg0:  -137975040, arg1:  val_22);
            string val_32 = resultLevel.answers + -1671354896(-1671354896);
            resultLevel.answers = resultLevel.answers;
        }
        
        }
        
        }
        
        }
        
        label_70:
        if(MoveNext() == true)
        {
            goto label_72;
        }
        
        Dispose();
        bool val_34 = resultLevel.answers.Contains(value:  -137975040);
        if(val_34 == false)
        {
                val_34 = val_59;
        }
        
        if(val_34 == true)
        {
            goto label_75;
        }
        
        typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
        System.String[] val_35 = resultLevel.answers.Split(separator:  478563824);
        System.Collections.Generic.List<TSource> val_36 = System.Linq.Enumerable.ToList<System.Object>(source:  resultLevel.answers);
        if(resultLevel.answers != null)
        {
                val_62 = resultLevel.answers;
            val_63 = UnityEngine.Random.Range(min:  0, max:  resultLevel.answers.m_firstChar);
        }
        else
        {
                val_62 = 12;
            val_63 = UnityEngine.Random.Range(min:  0, max:  0);
        }
        
        if(val_62 <= val_63)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        int val_61 = resultLevel.answers.m_stringLength;
        val_61 = val_61 + (val_63 << 2);
        string val_39 = -2063697616(-2063697616) + (resultLevel.answers.m_stringLength + (val_38) << 2) + 16((resultLevel.answers.m_stringLength + (val_38) << 2) + 16);
        if(resultLevel.answers != null)
        {
                resultLevel.answers.set_Item(index:  val_63, value:  -2063697616);
            resultLevel.answers = "";
        }
        else
        {
                0.set_Item(index:  val_63, value:  -2063697616);
            resultLevel.answers = "";
        }
        
        List.Enumerator<T> val_40 = GetEnumerator();
        goto label_84;
        label_85:
        string val_41 = System.String.Format(format:  -1671354896, arg0:  val_22, arg1:  -2100450224);
        string val_42 = resultLevel.answers + -1671354896(-1671354896);
        resultLevel.answers = resultLevel.answers;
        label_84:
        if(MoveNext() == true)
        {
            goto label_85;
        }
        
        Dispose();
        label_75:
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_44 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
        val_64 = 0;
        System.String[] val_45 = resultLevel.extraWords.Split(separator:  478563824);
        string val_46 = resultLevel.extraWords + 16;
        goto label_89;
        label_95:
        if((Contains(item:  15388672)) != true)
        {
                Add(item:  15388672);
        }
        
        val_64 = 1;
        label_89:
        if(val_64 < resultLevel.extraWords.m_firstChar)
        {
            goto label_95;
        }
        
        resultLevel.extraWords = "";
        List.Enumerator<T> val_48 = GetEnumerator();
        val_61 = "|";
        goto label_98;
        label_99:
        string val_49 = resultLevel.extraWords + val_22 + -2100450224(-2100450224);
        resultLevel.extraWords = resultLevel.extraWords;
        label_98:
        if(MoveNext() == true)
        {
            goto label_99;
        }
        
        Dispose();
        if(0 != 1)
        {
                if(0 > 1)
        {
                0 = 1;
        }
        
            val_65 = 0 - 0;
        }
        else
        {
                val_65 = 0;
        }
        
        List.Enumerator<T> val_51 = GetEnumerator();
        val_60 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        label_107:
        if(MoveNext() == false)
        {
            goto label_103;
        }
        
        if((Contains(item:  val_22)) == false)
        {
            goto label_107;
        }
        
        bool val_54 = Remove(item:  val_22);
        goto label_107;
        label_103:
        val_65 = val_65 + 1;
        mem2[0] = 905;
        Dispose();
        if(val_65 != 1)
        {
                if(val_65 > 1)
        {
                0 = 1;
        }
        
            var val_62 = -137934408 + ((val_65 + 1)) << 2;
            val_62 = val_62 - 905;
            val_62 = val_62 >> 5;
            val_62 = 1 & val_62;
            val_62 = val_65 - val_62;
            val_66 = val_62 + 1;
        }
        else
        {
                val_66 = 0;
        }
        
        bool val_55 = System.String.IsNullOrEmpty(value:  resultLevel.extraWords);
        if(val_55 == true)
        {
                val_55 = 21701140;
            val_55 = "";
            val_55 = "";
            resultLevel.extraWords = val_55;
        }
        
        List.Enumerator<T> val_56 = GetEnumerator();
        goto label_112;
        label_113:
        string val_57 = resultLevel.extraWords + val_22 + -2100450224(-2100450224);
        resultLevel.extraWords = resultLevel.extraWords;
        label_112:
        if(MoveNext() == true)
        {
            goto label_113;
        }
        
        Dispose();
    }
    protected int CalculateRequiredExtraWordsWAD()
    {
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge != false)
        {
                val_22 = null;
            val_22 = null;
            val_23 = 0;
            WADataParser.debug_lastReqDetermination = "playing challenge";
            return (int)val_23;
        }
        
        int val_3 = Prefs.currentLevel;
        GameEcon val_5 = App.getGameEcon;
        if(Prefs.currentChapter < 5590599)
        {
                string val_7 = Prefs.currentChapter.ToString();
            val_24 = 0;
            GameEcon val_8 = App.getGameEcon;
            string val_9 = 472.ToString();
            string val_10 = -137785024(-137785024) + -137772480(-137772480) + -137784928(-137784928) + 472;
            val_25 = null;
            val_25 = null;
            WADataParser.debug_lastReqDetermination = "chapter (";
            val_23 = 0;
            return (int)val_23;
        }
        
        val_24 = 1152921504885600256;
        val_23 = 0;
        MainController val_11 = MainController.instance;
        if(0 == 0)
        {
                return (int)val_23;
        }
        
        MainController val_13 = MainController.instance;
        typeof(System.String[]).__il2cppRuntimeField_10 = "chosen lvls:";
        string val_14 = MiniJSON.Json.Serialize(obj:  0);
        typeof(System.String[]).__il2cppRuntimeField_14 = 0;
        typeof(System.String[]).__il2cppRuntimeField_18 = " vs current: ";
        string val_15 = val_3.ToString();
        typeof(System.String[]).__il2cppRuntimeField_1C = ;
        typeof(System.String[]).__il2cppRuntimeField_20 = "\n";
        string val_16 = +477709520;
        val_24 = 1152921504991137792;
        val_26 = null;
        val_26 = null;
        WADataParser.debug_lastReqDetermination = null;
        val_27 = null;
        if((0.Contains(item:  val_3)) != false)
        {
                val_28 = null;
            string val_19 = 477709520 + -137784656(-137784656);
            WADataParser.debug_lastReqDetermination = WADataParser.debug_lastReqDetermination;
            GameEcon val_20 = App.getGameEcon;
            val_23 = 0;
            return (int)val_23;
        }
        
        val_29 = null;
        val_23 = 0;
        string val_21 = 477709520 + -137784544(-137784544);
        WADataParser.debug_lastReqDetermination = WADataParser.debug_lastReqDetermination;
        return (int)val_23;
    }
    protected int CalculateRequiredExtraWordsWUT()
    {
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        string val_29;
        var val_30;
        var val_31;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge != false)
        {
                val_22 = null;
            val_22 = null;
            val_23 = 0;
            WADataParser.debug_lastReqDetermination = "playing challenge";
            return (int)val_23;
        }
        
        GameEcon val_4 = App.getGameEcon;
        if(Prefs.currentChapter < 5590599)
        {
                string val_6 = Prefs.currentChapter.ToString();
            val_24 = 0;
            GameEcon val_7 = App.getGameEcon;
            string val_8 = 472.ToString();
            string val_9 = -137785024(-137785024) + -137660476(-137660476) + -137784928(-137784928) + 472;
            val_25 = null;
            val_25 = null;
            WADataParser.debug_lastReqDetermination = "chapter (";
            val_23 = 0;
            return (int)val_23;
        }
        
        val_24 = 1152921504885600256;
        val_23 = 0;
        MainController val_10 = MainController.instance;
        if(0 == 0)
        {
                return (int)val_23;
        }
        
        MainController val_12 = MainController.instance;
        typeof(System.String[]).__il2cppRuntimeField_10 = "chosen lvls:";
        string val_13 = MiniJSON.Json.Serialize(obj:  0);
        typeof(System.String[]).__il2cppRuntimeField_14 = 0;
        typeof(System.String[]).__il2cppRuntimeField_18 = " vs current: ";
        string val_15 = Prefs.currentLevel.ToString();
        typeof(System.String[]).__il2cppRuntimeField_1C = ;
        typeof(System.String[]).__il2cppRuntimeField_20 = "\n";
        string val_16 = +477709520;
        val_24 = 1152921504991137792;
        val_26 = null;
        val_26 = null;
        WADataParser.debug_lastReqDetermination = null;
        val_27 = null;
        if((0.Contains(item:  Prefs.currentLevel)) != false)
        {
                val_28 = null;
            val_29 = WADataParser.debug_lastReqDetermination;
            string val_20 = 477709520 + -137784656(-137784656);
            val_30 = null;
            val_23 = 1;
        }
        else
        {
                val_31 = null;
            val_23 = 0;
            val_29 = WADataParser.debug_lastReqDetermination;
            string val_21 = 477709520 + -137784544(-137784544);
            val_30 = null;
        }
        
        WADataParser.debug_lastReqDetermination = val_29;
        return (int)val_23;
    }
    public GameLevel BuildChallengingLevelForNormalProgression(int retries = 0)
    {
        var val_9;
        var val_10;
        do
        {
            do
        {
            int val_1 = UnityEngine.Random.Range(min:  3, max:  8);
            System.Collections.Generic.List<System.String> val_2 = this.CommonWordsByLength.Item[val_1];
            System.Collections.Generic.List<ZooTile> val_3 = new System.Collections.Generic.List<ZooTile>(collection:  this.CommonWordsByLength);
            System.Collections.Generic.List<System.String> val_4 = this.UncommonWordsByLength.Item[val_1];
            if(null != 0)
        {
                AddRange(collection:  this.UncommonWordsByLength);
            val_9 = null;
            val_10 = UnityEngine.Random.Range(min:  0, max:  1094062064);
        }
        else
        {
                AddRange(collection:  this.UncommonWordsByLength);
            val_9 = 12;
            val_10 = UnityEngine.Random.Range(min:  0, max:  0);
        }
        
            if(val_9 <= val_10)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(new BuildLevelBasedOnWordParams() != 0)
        {
                typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_20 = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_6) << 2) + 16;
            typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_24 = true;
            typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_1E = true;
            typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_1C = 257;
        }
        else
        {
                mem[32] = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_6) << 2) + 16;
            mem[28] = true;
            mem[36] = true;
            mem[30] = true;
            mem[29] = true;
        }
        
            typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_28 = true;
            GameLevel val_8 = this.BuildLevelBasedOnWord(param:  384237568);
        }
        while(this == 0);
        
            if(retries <= 9)
        {
                0 = this.OnWADataParseInit;
            retries = retries + 1;
        }
        
        }
        while(0 < 5);
    
    }
    public GameLevel BuildLevelOfWordLength(int desiredLength)
    {
        var val_9;
        var val_10;
        var val_10 = 0;
        label_13:
        if((this.CommonWordsByLength.ContainsKey(key:  desiredLength)) == false)
        {
            goto label_9;
        }
        
        System.Collections.Generic.List<System.String> val_3 = this.CommonWordsByLength.Item[desiredLength];
        int val_4 = UnityEngine.Random.Range(min:  1, max:  desiredLength);
        System.Collections.Generic.List<System.String> val_5 = this.CommonWordsByLength.Item[desiredLength];
        if(this.CommonWordsByLength <= val_4)
        {
                var val_9 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_9 = val_9 + (val_4 << 2);
        if((this.usedWordThisSession.Contains(item:  (0 + (val_4) << 2) + 16)) == true)
        {
            goto label_9;
        }
        
        if(new BuildLevelBasedOnWordParams() != 0)
        {
                val_9 = 1;
            typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_1C = val_9;
            typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_20 = (0 + (val_4) << 2) + 16;
            typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_8 = 18;
            typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_24 = val_9;
        }
        else
        {
                typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_20 = (0 + (val_4) << 2) + 16;
            val_9 = 1;
            typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_1C = val_9;
            typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_8 = 18;
            typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_24 = val_9;
        }
        
        typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_2C = val_9;
        GameLevel val_7 = this.BuildLevelBasedOnWord(param:  384237568);
        if(this != 0)
        {
            goto label_12;
        }
        
        label_9:
        val_10 = val_10 + 1;
        if(val_10 < 99)
        {
            goto label_13;
        }
        
        val_10 = 0;
        goto label_14;
        label_12:
        val_10 = this;
        label_14:
        if((this.usedWordThisSession.Contains(item:  typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_20)) == true)
        {
                return;
        }
        
        this.usedWordThisSession.Add(item:  typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_20);
    }
    public GameLevel BuildLevelContainingWordOfLength(BuildLevelBasedOnWordParams parametros)
    {
        string val_2;
        var val_3;
        var val_4;
        if(parametros != 0)
        {
                val_2 = parametros.levelWord;
            val_3 = val_2;
        }
        else
        {
                val_3 = 35615780;
            val_2 = 35615780;
        }
        
        if(parametros != 0)
        {
            
        }
        else
        {
                val_4 = 0;
        }
        
        GameLevel val_1 = this.BuildLevelContainingWordOfLength(word:  35615780, desiredLength:  3553932, desiredAnswers:  0, runWordRemoval:  true, lengthFlexibility:  0);
    }
    public GameLevel BuildLevelContainingWordOfLength(string word, int desiredLength, int desiredAnswers, bool runWordRemoval, int lengthFlexibility = 0)
    {
        var val_7;
        int val_14;
        int val_15;
        string val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        val_14 = desiredLength;
        val_15 = lengthFlexibility;
        val_16 = word;
        val_17 = 0;
        null = new BuildLevelBasedOnWordParams();
        if(val_15 < 0)
        {
                return;
        }
        
        val_17 = 0;
        val_18 = 0;
        label_44:
        if((mem[1152921513059675344].ContainsKey(key:  val_14)) == false)
        {
            goto label_19;
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.List<System.String> val_4 = this.FindLargerWordContainingWord(smallWord:  val_16, desiredLevelLength:  val_14);
        if(this == 0)
        {
            goto label_42;
        }
        
        if(mem[1152921513059675340] == 0)
        {
            goto label_21;
        }
        
        List.Enumerator<T> val_5 = GetEnumerator();
        label_35:
        val_19 = val_17;
        if(MoveNext() == false)
        {
            goto label_22;
        }
        
        if(new BuildLevelBasedOnWordParams() != 0)
        {
                typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_1C = runWordRemoval;
            typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_20 = val_7;
        }
        else
        {
                mem[32] = val_7;
            mem[28] = runWordRemoval;
        }
        
        typeof(BuildLevelBasedOnWordParams).__il2cppRuntimeField_8 = desiredAnswers;
        GameLevel val_9 = this.BuildLevelBasedOnWord(param:  384237568);
        if(val_19 == 0)
        {
            goto label_35;
        }
        
        System.Collections.Generic.List<T> val_10 = CUtils.BuildListFromString<System.String>(values:  mem[1152921513059675380], split:  '|');
        System.Collections.Generic.List<T> val_11 = CUtils.BuildListFromString<System.String>(values:  6, split:  '|');
        if((mem[1152921513059675380] + 12) > 65576)
        {
                val_19 = this;
        }
        
        System.Collections.Generic.List<T> val_12 = CUtils.BuildListFromString<System.String>(values:  mem[1152921513059675380], split:  '|');
        if((mem[1152921513059675380] + 12) < desiredAnswers)
        {
            goto label_35;
        }
        
        label_22:
        val_20 = 0 + 1;
        mem2[0] = 222;
        Dispose();
        if(val_20 != 1)
        {
                if(val_20 > 1)
        {
                0 = 1;
        }
        
            var val_14 = -137118344 + ((0 + 1)) << 2;
            val_14 = val_14 - 222;
            val_14 = val_14 >> 5;
            val_14 = 1 & val_14;
            val_20 = val_20 - val_14;
        }
        
        val_17 = val_19;
        val_14 = val_14;
        val_16 = val_16;
        val_15 = lengthFlexibility;
        label_21:
        if(val_17 == 0)
        {
            goto label_38;
        }
        
        System.Collections.Generic.List<T> val_13 = CUtils.BuildListFromString<System.String>(values:  mem[1152921513059675380], split:  '|');
        if((mem[1152921513059675380] + 12) < desiredAnswers)
        {
            goto label_42;
        }
        
        return;
        label_38:
        val_17 = 0;
        label_42:
        val_14 = val_14 + 1;
        label_19:
        val_18 = val_18 + 1;
        if(val_18 <= val_15)
        {
            goto label_44;
        }
    
    }
    public System.Collections.Generic.List<string> FindLargerWordContainingWord(string smallWord, int desiredLevelLength)
    {
        string val_7;
        WADataParser val_19;
        int val_20;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_22;
        val_19 = this;
        val_20 = desiredLevelLength;
        val_22 = 0;
        if(smallWord.m_stringLength >= val_20)
        {
                return;
        }
        
        val_19 = this.CommonWordsByLength;
        if((val_19.ContainsKey(key:  val_20)) == false)
        {
                return;
        }
        
        System.Collections.Generic.List<System.Boolean> val_2 = new System.Collections.Generic.List<System.Boolean>();
        if(smallWord.m_stringLength >= 1)
        {
                var val_19 = 0;
            do
        {
            Add(item:  false);
            val_19 = val_19 + 1;
        }
        while(val_19 < smallWord.m_stringLength);
        
        }
        
        val_22 = null;
        val_22 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.List<System.String> val_4 = val_19.Item[val_20];
        List.Enumerator<T> val_5 = GetEnumerator();
        label_13:
        bool val_6 = MoveNext();
        if(val_6 == false)
        {
            goto label_10;
        }
        
        if((val_6.CanSpell(letters:  val_7, word:  smallWord, letterused:  null)) == false)
        {
            goto label_13;
        }
        
        Add(item:  val_7);
        goto label_13;
        label_10:
        Dispose();
        if((mem[1152921513059799636].ContainsKey(key:  val_20)) == false)
        {
            goto label_15;
        }
        
        System.TimeType val_10 = mem[1152921513059799636].Item[val_20];
        List.Enumerator<T> val_11 = GetEnumerator();
        label_21:
        bool val_12 = MoveNext();
        if(val_12 == false)
        {
            goto label_18;
        }
        
        if((val_12.CanSpell(letters:  val_7, word:  smallWord, letterused:  null)) == false)
        {
            goto label_21;
        }
        
        Add(item:  val_7);
        goto label_21;
        label_18:
        Dispose();
        label_15:
        val_19 = mem[1152921513059799640];
        if((val_19.ContainsKey(key:  val_20)) == false)
        {
                return;
        }
        
        System.TimeType val_15 = mem[1152921513059799640].Item[val_20];
        val_19 = mem[1152921513059799640];
        List.Enumerator<T> val_16 = GetEnumerator();
        label_29:
        bool val_17 = MoveNext();
        if(val_17 == false)
        {
            goto label_26;
        }
        
        if((val_17.CanSpell(letters:  val_7, word:  smallWord, letterused:  null)) == false)
        {
            goto label_29;
        }
        
        Add(item:  val_7);
        goto label_29;
        label_26:
        Dispose();
    }
    public System.Collections.Generic.List<string> GetAvailableWordsFromList(string word, System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<string>> listToUse, int startingLength, int endingLength)
    {
        string val_8;
        int val_11;
        var val_13;
        var val_14;
        var val_15;
        val_11 = startingLength;
        val_13 = 0;
        string val_1 = word.Replace(oldValue:  -2100450224, newValue:  1098586544);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.List<System.Boolean> val_3 = new System.Collections.Generic.List<System.Boolean>();
        val_14 = 1152921511757112352;
        goto label_2;
        label_5:
        Add(item:  false);
        val_13 = 1;
        label_2:
        if(val_13 < word.m_stringLength)
        {
            goto label_5;
        }
        
        if(val_11 > endingLength)
        {
                return;
        }
        
        val_14 = 1152921510891363008;
        label_27:
        if((listToUse.ContainsKey(key:  val_11)) == false)
        {
            goto label_26;
        }
        
        System.TimeType val_5 = listToUse.Item[val_11];
        List.Enumerator<T> val_6 = GetEnumerator();
        val_13 = 1152921510929906144;
        label_24:
        bool val_7 = MoveNext();
        if(val_7 == false)
        {
            goto label_19;
        }
        
        if(((val_7.CanSpell(letters:  word, word:  val_8, letterused:  0)) == false) || ((Contains(item:  val_8)) == true))
        {
            goto label_24;
        }
        
        Add(item:  val_8);
        goto label_24;
        label_19:
        Dispose();
        val_15 = 1;
        if(val_15 != 1)
        {
            
        }
        
        label_26:
        val_11 = val_11 + 1;
        if(val_11 <= endingLength)
        {
            goto label_27;
        }
    
    }
    private bool CanSpell(string letters, string word, System.Collections.Generic.List<bool> letterused)
    {
        var val_4;
        var val_5;
        var val_6;
        System.Collections.Generic.List<System.Boolean> val_1 = new System.Collections.Generic.List<System.Boolean>();
        val_4 = 0;
        goto label_1;
        label_4:
        Add(item:  false);
        val_4 = 1;
        label_1:
        if(val_4 < letters.m_stringLength)
        {
            goto label_4;
        }
        
        val_5 = 0;
        goto label_5;
        label_14:
        val_6 = 0;
        if(letters.m_stringLength < 1)
        {
                return (bool)val_6;
        }
        
        var val_4 = 0;
        label_11:
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        if(letters.Chars[0] == word.Chars[0])
        {
            goto label_10;
        }
        
        val_4 = val_4 + 1;
        if(val_4 < letters.m_stringLength)
        {
            goto label_11;
        }
        
        goto label_12;
        label_10:
        set_Item(index:  0, value:  true);
        val_5 = 1;
        label_5:
        if(val_5 < word.m_stringLength)
        {
            goto label_14;
        }
        
        val_6 = 1;
        return (bool)val_6;
        label_12:
        val_6 = 0;
        return (bool)val_6;
    }
    public void SaveWorldData(System.Collections.Generic.List<object> data)
    {
    
    }
    private LevelDefinition TranslateLevel(int playerLevel = -1)
    {
        float val_19;
        var val_20;
        var val_21;
        int val_22;
        System.Collections.Generic.List<System.Int32> val_23;
        val_19 = playerLevel;
        if(val_19 <= 0)
        {
                GameBehavior val_1 = App.getBehavior;
            val_19 = 0;
        }
        
        LevelDefinition val_2 = null;
        val_20 = val_2;
        val_2 = new LevelDefinition();
        typeof(LevelDefinition).__il2cppRuntimeField_C = val_19;
        GameBehavior val_3 = App.getBehavior;
        val_21 = 0;
        string val_4 = val_21.GetCurrentLanguage();
        if(0 <= this.MaxPredefinedLevels)
        {
            goto label_11;
        }
        
        val_21 = 0;
        if((val_21.Equals(value:  1800251696)) == false)
        {
            goto label_13;
        }
        
        label_11:
        if(0 <= this.MaxPredefinedLevels)
        {
            goto label_14;
        }
        
        int val_19 = ~this.MaxPredefinedLevels;
        val_19 = val_19 + val_19;
        int val_21 = this.builtInChapters;
        val_19 = (val_19 >> 3) + (val_19 >> 31);
        val_19 = val_21 + val_19;
        val_19 = val_19 + 1;
        typeof(LevelDefinition).__il2cppRuntimeField_8 = val_19;
        var val_20 = ~this.MaxPredefinedLevels;
        val_20 = val_19 + val_20;
        val_21 = (val_21 >> 3) + (val_21 >> 31);
        val_21 = val_21 + (val_21 << 2);
        val_20 = val_20 - (val_21 << 2);
        val_20 = val_20 + 1;
        typeof(LevelDefinition).__il2cppRuntimeField_10 = val_20;
        return;
        label_13:
        val_22 = UnityEngine.Random.Range(min:  this.minSpanishLevel, max:  this.MaxPredefinedLevels);
        val_19 = 1152921511098470640;
        goto label_16;
        label_19:
        val_21 = 1;
        val_22 = UnityEngine.Random.Range(min:  this.minSpanishLevel, max:  this.MaxPredefinedLevels);
        label_16:
        if((this.usedSpanishLevels.Contains(item:  val_22)) != false)
        {
                if(val_21 < this.maxTries)
        {
            goto label_19;
        }
        
        }
        
        if(val_21 < this.maxTries)
        {
                val_23 = this.usedSpanishLevels;
        }
        else
        {
                val_23 = null;
            val_23 = new System.Collections.Generic.List<System.Int32>();
            this.usedSpanishLevels = val_23;
        }
        
        Add(item:  val_22);
        label_14:
        LevelDefinition val_18 = null;
        val_20 = val_18;
        val_18 = new LevelDefinition();
    }
    public static bool get_QAHACK_NoExtraRequired()
    {
        null = null;
        return (bool)WADataParser._QAHACK_NoExtraRequired;
    }
    public static void set_QAHACK_NoExtraRequired(bool value)
    {
        null = null;
        WADataParser._QAHACK_NoExtraRequired = value;
    }
    public int get_MaxPredefinedLevels()
    {
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        if((0.Equals(value:  1800251696)) == true)
        {
                1000 = this.maxPredefinedLevels;
        }
        
        return 1000;
    }
    public void set_MaxPredefinedLevels(int value)
    {
        this.maxPredefinedLevels = value;
    }
    public string get_PathToGameResources()
    {
        string val_1 = WordApp.GamePathName;
        return -1655690384(-1655690384) + null + 1115175264;
    }
    private void LoadDataIntoMemoryFromResources()
    {
        string val_3;
        System.String[] val_9;
        var val_10;
        var val_11;
        var val_12;
        GameBehavior val_1 = App.getBehavior;
        List.Enumerator<T> val_2 = GetEnumerator();
        val_10 = 1152921504758390784;
        goto label_6;
        label_21:
        string val_4 = -135812224(-135812224) + val_3;
        UnityEngine.Debug.Log(message:  -135812224);
        val_9 = this.buckets;
        val_11 = 0;
        goto label_9;
        label_12:
        LevelCurve val_5 = this.LoadBucketDataIntoMemoryFromResources(lang:  val_3, bucket:  668685824);
        this.AddOrUpdateToLevelCurveList(curve:  -135706000, levelCurves:  this.knownLevelCurves);
        val_11 = 1;
        label_9:
        if(val_11 < this)
        {
            goto label_12;
        }
        
        val_12 = 0;
        val_10 = 1152921504758390784;
        goto label_13;
        label_20:
        LevelCurve val_6 = this.LoadBucketDataIntoMemoryFromResources(lang:  val_3, bucket:  668685824);
        if(this != 0)
        {
                this.AddOrUpdateToLevelCurveList(curve:  -135706000, levelCurves:  this.featureLevelCurves);
        }
        else
        {
                string val_7 = -135730160(-135730160) + 668685824;
            val_9 = "Level Curve failed to load for feature bucket ";
            UnityEngine.Debug.LogError(message:  -135730160);
        }
        
        val_12 = 1;
        label_13:
        if(val_12 < val_9)
        {
            goto label_20;
        }
        
        label_6:
        if(MoveNext() == true)
        {
            goto label_21;
        }
        
        Dispose();
    }
    private void LoadDataIntoMemoryFromResourcesRegularCurve(string lang, string bucket)
    {
        typeof(System.Object[]).__il2cppRuntimeField_10 = lang;
        typeof(System.Object[]).__il2cppRuntimeField_14 = bucket;
        UnityEngine.Debug.LogErrorFormat(format:  -135527888, args:  472754880);
        LevelCurve val_1 = this.LoadBucketDataIntoMemoryFromResources(lang:  lang, bucket:  bucket);
        if(this != 0)
        {
                this.AddOrUpdateToLevelCurveList(curve:  -135499376, levelCurves:  this.knownLevelCurves);
            return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = lang;
        typeof(System.Object[]).__il2cppRuntimeField_14 = bucket;
        UnityEngine.Debug.LogErrorFormat(format:  -135523584, args:  472754880);
    }
    private void LoadDataIntoMemoryFromResourcesFeatureCurve(string lang, string featureBucket)
    {
        typeof(System.Object[]).__il2cppRuntimeField_10 = lang;
        typeof(System.Object[]).__il2cppRuntimeField_14 = featureBucket;
        UnityEngine.Debug.LogErrorFormat(format:  -135390896, args:  472754880);
        LevelCurve val_1 = this.LoadBucketDataIntoMemoryFromResources(lang:  lang, bucket:  featureBucket);
        if(this != 0)
        {
                this.AddOrUpdateToLevelCurveList(curve:  -135362384, levelCurves:  this.featureLevelCurves);
            return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = lang;
        typeof(System.Object[]).__il2cppRuntimeField_14 = featureBucket;
        UnityEngine.Debug.LogErrorFormat(format:  -135386592, args:  472754880);
    }
    private WADataParser.LevelCurve LoadBucketDataIntoMemoryFromResources(string lang, string bucket)
    {
        var val_12;
        UnityEngine.Object val_13;
        string val_14;
        var val_15;
        string val_2 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>().PathToGameResources;
        string val_3 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>().GetLevelCurveSubPath(lang:  lang, bucket:  bucket);
        val_12 = 0;
        string val_4 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>()(new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>()) + -539755392(-539755392) + new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>()(new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>());
        string val_5 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>()(new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>()) + -135252880(-135252880);
        object val_6 = UnityEngine.Resources.Load<System.Object>(path:  new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>() = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>());
        val_13 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
        if(val_13 == 0)
        {
                return;
        }
        
        val_14 = val_13;
        val_15 = 0;
        string val_8 = val_14.text;
        object val_9 = MiniJSON.Json.Deserialize(json:  val_14);
        if(val_14 != 0)
        {
                if(((mem[.ctor().SyncRoot + 100] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_14 = 0;
        }
        
            val_15 = val_14;
        }
        
        System.Collections.Generic.List<GameLevel> val_10 = this.ParseFlatLevels(flatLevelsDef:  0);
        val_13 = val_14;
        WADataParser.LevelCurve val_11 = null;
        val_12 = val_11;
        val_11 = new WADataParser.LevelCurve(language:  lang, bucket:  bucket, flattenedLevels:  0);
    }
    private void LoadLengthsInMemoryFromResources()
    {
        var val_14;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        val_43 = "";
        var val_43 = 22039907;
        val_43 = 13585880 + val_43;
        if(val_43 == 0)
        {
                mem2[0] = 1;
        }
        
        val_44 = null;
        val_44 = null;
        if(App.game == 1)
        {
                string val_1 = App.game.GetPlayerBucket();
            string val_2 = System.String.Format(format:  -135132576, arg0:  App.game);
            val_43 = "WordGroups/{0}/";
        }
        
        System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_3 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
        mem[1152921513061673408] = null;
        string val_4 = this.PathToGameResources;
        string val_5 = System.String.Format(format:  -1183154368, arg0:  -135108176, arg1:  -135132576, arg2:  -135132464);
        T[] val_6 = UnityEngine.Resources.LoadAll<System.Object>(path:  -1183154368);
        var val_44 = 0;
        label_26:
        string val_7 = "{0}{1}{2}".__il2cppRuntimeField_10.name;
        val_45 = "{0}{1}{2}".__il2cppRuntimeField_10;
        string val_9 = "{0}{1}{2}".__il2cppRuntimeField_10.text;
        object val_10 = MiniJSON.Json.Deserialize(json:  "{0}{1}{2}".__il2cppRuntimeField_10);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_11 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_46 = null;
        val_46 = null;
        val_47 = 0;
        if((("{0}{1}{2}".__il2cppRuntimeField_10 + 100 + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_46)
        {
                "{0}{1}{2}".__il2cppRuntimeField_10 = 0;
        }
        
        val_47 = "{0}{1}{2}".__il2cppRuntimeField_10;
        List.Enumerator<T> val_12 = GetEnumerator();
        label_22:
        if(MoveNext() == false)
        {
            goto label_18;
        }
        
        val_48 = val_14;
        if(val_48 != 0)
        {
                if(val_48 == null)
        {
            goto label_20;
        }
        
        }
        
        val_48 = 0;
        label_20:
        string val_15 = val_48.ToUpper();
        Add(item:  0);
        goto label_22;
        label_18:
        val_44 = val_44 + 1;
        mem2[0] = 168;
        Dispose();
        if(val_44 != 1)
        {
                if(val_44 > 1)
        {
                0 = 1;
        }
        
            var val_45 = -135120288 + ((0 + 1)) << 2;
            val_45 = val_45 - 168;
            val_45 = val_45 >> 5;
            val_45 = 1 & val_45;
            val_44 = val_44 - val_45;
            val_49 = val_44;
        }
        else
        {
                val_49 = 0;
        }
        
        Add(key:  System.Int32.Parse(s:  null), value:  80883712);
        goto label_26;
        label_52:
        string val_21 = "{0}{1}{2}".__il2cppRuntimeField_10.name;
        val_50 = "{0}{1}{2}".__il2cppRuntimeField_10;
        string val_23 = "{0}{1}{2}".__il2cppRuntimeField_10.text;
        object val_24 = MiniJSON.Json.Deserialize(json:  "{0}{1}{2}".__il2cppRuntimeField_10);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_25 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_51 = null;
        val_51 = null;
        val_52 = 0;
        if((("{0}{1}{2}".__il2cppRuntimeField_10 + 100 + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_51)
        {
                "{0}{1}{2}".__il2cppRuntimeField_10 = 0;
        }
        
        val_52 = "{0}{1}{2}".__il2cppRuntimeField_10;
        List.Enumerator<T> val_26 = GetEnumerator();
        label_48:
        if(MoveNext() == false)
        {
            goto label_44;
        }
        
        val_53 = val_14;
        if(val_53 != 0)
        {
                if(val_53 == null)
        {
            goto label_46;
        }
        
        }
        
        val_53 = 0;
        label_46:
        string val_28 = val_53.ToUpper();
        Add(item:  0);
        goto label_48;
        label_44:
        var val_46 = val_44;
        val_46 = val_46 + 1;
        mem2[0] = 335;
        Dispose();
        if(val_46 != 1)
        {
                if(val_46 > 1)
        {
                0 = 1;
        }
        
            var val_47 = -135120288 + ((0 + 1)) << 2;
            val_47 = val_47 - 335;
            val_47 = val_47 >> 5;
            val_47 = 1 & val_47;
            val_46 = val_46 - val_47;
        }
        
        Add(key:  System.Int32.Parse(s:  null), value:  80883712);
         =  + 1;
        goto label_52;
        label_78:
        string val_34 = "{0}{1}{2}".__il2cppRuntimeField_10.name;
        val_54 = "{0}{1}{2}".__il2cppRuntimeField_10;
        string val_36 = "{0}{1}{2}".__il2cppRuntimeField_10.text;
        object val_37 = MiniJSON.Json.Deserialize(json:  "{0}{1}{2}".__il2cppRuntimeField_10);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_38 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_55 = null;
        val_55 = null;
        val_56 = 0;
        if((("{0}{1}{2}".__il2cppRuntimeField_10 + 100 + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_55)
        {
                "{0}{1}{2}".__il2cppRuntimeField_10 = 0;
        }
        
        val_56 = "{0}{1}{2}".__il2cppRuntimeField_10;
        List.Enumerator<T> val_39 = GetEnumerator();
        label_74:
        if(MoveNext() == false)
        {
            goto label_70;
        }
        
        val_57 = val_14;
        if(val_57 != 0)
        {
                if(val_57 == null)
        {
            goto label_72;
        }
        
        }
        
        val_57 = 0;
        label_72:
        string val_41 = val_57.ToUpper();
        Add(item:  0);
        goto label_74;
        label_70:
        var val_49 = 0;
        val_49 = val_49 + 1;
        mem2[0] = 503;
        Dispose();
        if(val_49 != 1)
        {
                if(val_49 > 1)
        {
                0 = 1;
        }
        
            var val_50 = -135120288 + ((0 + 1)) << 2;
            val_50 = val_50 - 503;
            val_50 = val_50 >> 5;
            val_50 = 1 & val_50;
            val_49 = val_49 - val_50;
        }
        
        Add(key:  System.Int32.Parse(s:  null), value:  80883712);
         =  + 1;
        goto label_78;
    }
    public void SaveLevelsFromChaptersDict(System.Collections.Generic.List<object> fromLoadedData, string language)
    {
        this.Initialize();
        string val_1 = UnityEngine.Application.persistentDataPath;
        if(((System.String.IsNullOrEmpty(value:  language)) != true) && ((System.String.op_Equality(a:  language, b:  -135011984)) != true))
        {
                if((System.String.op_Equality(a:  language, b:  1800251696)) != true)
        {
                string val_5 = null + 1115175264 + language;
        }
        
        }
        
        List.Enumerator<T> val_6 = GetEnumerator();
        label_16:
        if(MoveNext() == false)
        {
            goto label_5;
        }
        
        string val_9 = 0.Item[-135011904];
        int val_10 = System.Int32.Parse(s:  null, style:  511);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_11 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        string val_12 = 0.Item[-1386027600];
        Add(key:  1679334848, value:  0);
        Add(key:  1348647200, value:  13152256);
        string val_13 = 0.Item[-1125090080];
        Add(key:  -1630882544, value:  0);
        goto label_16;
        label_5:
        Dispose();
    }
    public static string get_QAHACK_RanOutReason()
    {
        null = null;
    }
    public static string get_QAHACK_FinishedReason()
    {
        null = null;
    }
    public static string get_QAHACK_SetDesiredLevelGenWord()
    {
        null = null;
    }
    public static void set_QAHACK_SetDesiredLevelGenWord(string value)
    {
        null = null;
        WADataParser.QAhackedWord = value;
    }
    public void CallEmptyMethod()
    {
    
    }
    public bool get_HasInitialized()
    {
        return (bool)this.initialized;
    }
    private void Start()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -134187344, name:  -2037002944);
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -134187344, name:  -134211440);
        this.Initialize();
    }
    private void OnWordData()
    {
    
    }
    public void ReInitialize()
    {
        if(this.initialized == false)
        {
                return;
        }
        
        if(this.initializing != false)
        {
                return;
        }
        
        this.initialized = false;
        this.Initialize();
    }
    private void Initialize()
    {
        var val_4;
        if(this.initialized == false)
        {
                this.initialized = this.initializing;
            goto label_1;
        }
        
        return;
        label_1:
        this.initializing = true;
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        this.LoadDataIntoMemoryFromResourcesRegularCurve(lang:  null, bucket:  -1930531024);
        Player val_3 = App.Player;
        this.LoadDataIntoMemoryFromResourcesFeatureCurve(lang:  null, featureBucket:  33449456);
        this.LoadLengthsInMemoryFromResources();
        this.LoadPlayerVars();
        this.initialized = true;
        this.initializing = false;
        val_4 = null;
        val_4 = null;
        WordApp.CurrentlyLoadedLevelGenVersion = true;
        if(this.OnWADataParseInit == 0)
        {
                return;
        }
        
        this.OnWADataParseInit.Invoke();
    }
    public void Unload()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  -133731152);
    }
    private void LoadPlayerVars()
    {
        string val_15;
        var val_16;
        System.Collections.Generic.List<System.Int32> val_18;
        int val_19;
        var val_20;
        val_16 = 1152921504882458624;
        if(((CPlayerPrefs.HasKey(key:  -133643152)) == false) || ((UnityEngine.PlayerPrefs.GetInt(key:  -133643056, defaultValue:  1)) != 3))
        {
            goto label_4;
        }
        
        string val_3 = CPlayerPrefs.GetString(key:  -133643152, defaultValue:  1098586544);
        if("wadwut_pl_vars" == 0)
        {
            goto label_9;
        }
        
        val_18 = "wadwut_pl_vars";
        if((System.String.op_Inequality(a:  -133643152, b:  1098586544)) == false)
        {
            goto label_9;
        }
        
        this.DeserializePlayerVars(data:  -133643152);
        goto label_9;
        label_4:
        val_18 = null;
        val_18 = new System.Collections.Generic.List<System.Int32>();
        if(val_18 != 0)
        {
                val_19 = 1152921510720759024;
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
        }
        else
        {
                val_19 = 1152921510720759024;
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
        }
        
        Add(item:  7);
        this.plv_chapterWordLengths = val_18;
        goto label_12;
        label_15:
        val_19 = System.Linq.Enumerable.LastOrDefault<System.Int32>(source:  this.plv_chapterWordLengths);
        this.plv_chapterWordLengths.Add(item:  val_19);
        val_18 = this.plv_chapterWordLengths;
        label_12:
        if(this.plv_chapterWordLengths < 20)
        {
            goto label_15;
        }
        
        UnityEngine.PlayerPrefs.SetInt(key:  -133643056, value:  3);
        bool val_7 = PrefsSerializationManager.SavePlayerPrefs();
        label_9:
        if((CPlayerPrefs.HasKey(key:  -925895984)) == false)
        {
            goto label_20;
        }
        
        string val_9 = CPlayerPrefs.GetString(key:  -925895984, defaultValue:  1098586544);
        val_16 = 1152921504687730688;
        val_19 = null;
        val_19 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.plv_playedWords = val_19;
        object val_11 = MiniJSON.Json.Deserialize(json:  -925895984);
        if("wadwut_pw_vars" != 0)
        {
                if(null == null)
        {
            goto label_25;
        }
        
        }
        
        if("wadwut_pw_vars" == 0)
        {
            goto label_26;
        }
        
        label_35:
        label_26:
        val_18 = 0;
        goto label_28;
        label_20:
        label_47:
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_12 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.plv_playedWords = null;
        return;
        label_28:
        List.Enumerator<T> val_13 = GetEnumerator();
        label_33:
        if(MoveNext() == false)
        {
            goto label_30;
        }
        
        this.plv_playedWords.Add(item:  val_15);
        goto label_33;
        label_30:
        Dispose();
        if(0 == 0)
        {
                return;
        }
        
        return;
        label_25:
        goto label_35;
        label_48:
        val_20 = null;
        if(null != 1)
        {
            goto label_45;
        }
        
        if(null == 0)
        {
            goto label_46;
        }
        
        goto label_47;
        label_46:
        mem[4] = null;
        goto label_48;
        label_45:
    }
    private void StorePlayerVars()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 >= this.MaxPredefinedLevels)
        {
                string val_3 = this.SerializePlayerVars();
            CPlayerPrefs.SetString(key:  -133643152, val:  -133477248);
        }
        
        string val_4 = MiniJSON.Json.Serialize(obj:  this.plv_playedWords);
        CPlayerPrefs.SetString(key:  -925895984, val:  this.plv_playedWords);
    }
    private string SerializePlayerVars()
    {
        var val_6 = 0;
        System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
        do
        {
            if(val_6 != 0)
        {
                System.Text.StringBuilder val_2 = Append(value:  -2100450224);
        }
        
            if(val_1 <= val_6)
        {
                var val_5 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_5 = val_5 + 0;
            string val_3 = (0 + 0) + 16.ToString();
            System.Text.StringBuilder val_4 = Append(value:  -133369092);
            val_6 = val_6 + 1;
        }
        while(val_6 != 20);
        
        if(val_1 != 0)
        {
                return;
        }
    
    }
    private void DeserializePlayerVars(string data)
    {
        typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
        var val_4 = 0;
        System.String[] val_1 = data.Split(separator:  478563824);
        string val_2 = data + 16;
        do
        {
            this.plv_chapterWordLengths.set_Item(index:  0, value:  System.Int32.Parse(s:  15388672));
            val_4 = val_4 + 1;
        }
        while(val_4 != 20);
    
    }
    private void PrepPlayerVarsForNewChapter()
    {
        PluginExtension.Shuffle<System.Int32>(list:  this.plv_chapterWordLengths, seed:  new System.Nullable<System.Int32>() {HasValue = false});
    }
    public void Debug_PrintPlayerVars()
    {
        string val_1 = PrettyPrint.printJSON(obj:  this.plv_chapterWordLengths, types:  false, singleLineOutput:  true);
        string val_2 = -133012288(-133012288) + this.plv_chapterWordLengths;
        UnityEngine.Debug.LogError(message:  -133012288);
    }
    private string GetLevelCurveSubPath(string lang, string bucket)
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_5 = 22041859;
        val_5 = 13583928 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        if(App.game != 1)
        {
                if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
            val_6 = null;
            val_6 = null;
            if(App.game != 10)
        {
                if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
            val_7 = null;
            val_7 = null;
            if(App.game != 7)
        {
                if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
            val_8 = null;
            val_8 = null;
            if(App.game != 4)
        {
                if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
            val_9 = null;
            val_9 = null;
            if(App.game != 18)
        {
                if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
            val_10 = null;
            val_10 = null;
            if(App.game != 9)
        {
                return;
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        if((System.String.op_Inequality(a:  lang, b:  1800251696)) != false)
        {
                return System.String.Format(format:  1629069648, arg0:  1726392512, arg1:  lang);
        }
        
        if((System.String.op_Equality(a:  bucket, b:  -1930531024)) != false)
        {
                val_11 = "";
        }
        else
        {
                string val_3 = System.String.Format(format:  -132887888, arg0:  bucket);
            val_11 = "_{0}";
        }
        
        string val_4 = System.String.Format(format:  -132887808, arg0:  1726392512, arg1:  lang, arg2:  -132887888);
    }
    private string GetPlayerBucket()
    {
        Player val_1 = App.Player;
        if(0 != 0)
        {
                return;
        }
    
    }
    private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<string>> get_AllKnownWords()
    {
        var val_22;
        System.Func<System.String, System.Int32> val_24;
        var val_25;
        System.Func<System.Linq.IGrouping<System.Int32, System.String>, System.Int32> val_27;
        System.Func<System.Linq.IGrouping<System.Int32, System.String>, System.Collections.Generic.List<System.String>> val_29;
        if(this._AllKnownWords != 0)
        {
                return;
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(this.MaxPredefinedLevels >= 2)
        {
                do
        {
            System.Collections.Generic.List<GameLevel> val_3 = this.CurrentLevelCurveGameLevels;
            if(this.this_generator <= (5 - 4))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            typeof(System.Char[]).__il2cppRuntimeField_10 = 124;
            System.String[] val_5 = 872415232.Split(separator:  478563824);
            System.Collections.Generic.List<ZooTile> val_6 = new System.Collections.Generic.List<ZooTile>(collection:  872415232);
            AddRange(collection:  80883712);
            var val_8 = 5 + 1;
        }
        while((5 - 3) < this.MaxPredefinedLevels);
        
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_10 = System.Linq.Enumerable.Distinct<System.Object>(source:  80883712);
        val_22 = null;
        val_22 = null;
        val_24 = WADataParser.<>c.<>9__102_0;
        if(val_24 == 0)
        {
                val_24 = null;
            val_24 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  WADataParser.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4162319968));
            WADataParser.<>c.<>9__102_0 = val_24;
        }
        
        System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey, TSource>> val_12 = System.Linq.Enumerable.GroupBy<System.Object, System.Int32>(source:  80883712, keySelector:  7720960);
        val_25 = null;
        val_25 = null;
        val_27 = WADataParser.<>c.<>9__102_1;
        if(val_27 == 0)
        {
                val_27 = null;
            val_27 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  WADataParser.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4162320992));
            val_25 = null;
            WADataParser.<>c.<>9__102_1 = val_27;
        }
        
        val_25 = null;
        val_29 = WADataParser.<>c.<>9__102_2;
        if(val_29 == 0)
        {
                val_29 = null;
            val_29 = new System.Func<ZooTile, System.String>(object:  WADataParser.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4162322016));
            WADataParser.<>c.<>9__102_2 = val_29;
        }
        
        System.Collections.Generic.Dictionary<TKey, TElement> val_15 = System.Linq.Enumerable.ToDictionary<System.Object, System.Int32, System.Object>(source:  80883712, keySelector:  7720960, elementSelector:  7720960);
        this._AllKnownWords = null;
        Dictionary.Enumerator<TKey, TValue> val_16 = GetEnumerator();
        label_37:
        if(0.MoveNext() == false)
        {
            goto label_28;
        }
        
        if((this._AllKnownWords.ContainsKey(key:  0)) == false)
        {
            goto label_30;
        }
        
        System.Collections.Generic.List<System.String> val_20 = this._AllKnownWords.Item[0];
        this._AllKnownWords.AddRange(collection:  R7);
        System.Collections.Generic.List<System.String> val_21 = this._AllKnownWords.Item[0];
        System.Collections.Generic.IEnumerable<TSource> val_22 = System.Linq.Enumerable.Distinct<System.Object>(source:  this._AllKnownWords);
        System.Collections.Generic.List<TSource> val_23 = System.Linq.Enumerable.ToList<System.Object>(source:  this._AllKnownWords);
        this._AllKnownWords.set_Item(key:  0, value:  this._AllKnownWords);
        goto label_37;
        label_30:
        System.Collections.Generic.List<ZooTile> val_24 = new System.Collections.Generic.List<ZooTile>(collection:  R7);
        this._AllKnownWords.Add(key:  0, value:  80883712);
        goto label_37;
        label_28:
        0.Dispose();
    }
    public int GetAllPossibleWordsCount()
    {
        int val_4;
        val_4 = this.allPossibleWords;
        if(val_4 > 0)
        {
                return val_4;
        }
        
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>> val_1 = this.AllKnownWords;
        Dictionary.Enumerator<TKey, TValue> val_2 = 0.GetEnumerator();
        val_4 = 0;
        goto label_3;
        label_5:
        val_4 = 0 + val_4;
        label_3:
        if(0.MoveNext() == true)
        {
            goto label_5;
        }
        
        0.Dispose();
        this.allPossibleWords = val_4;
        return val_4;
    }
    public int GetPossibleWordsCount(int numLetters)
    {
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<System.String>> val_1 = this.AllKnownWords;
        System.TimeType val_2 = this.Item[numLetters];
        if(this != 0)
        {
                return (int)this.this_generator;
        }
        
        return (int)this.this_generator;
    }
    private System.Collections.Generic.List<GameLevel> FlattenLevels(System.Collections.Generic.Dictionary<int, System.Collections.Generic.Dictionary<string, object>> chaptersToUse)
    {
        var val_6;
        var val_10;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        System.Func<GameLevel, System.Int32> val_22;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_2 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
        Dictionary.ValueCollection<TKey, TValue> val_3 = chaptersToUse.Values;
        Dictionary.ValueCollection.Enumerator<TKey, TValue> val_4 = GetEnumerator();
        label_18:
        if(MoveNext() == false)
        {
            goto label_3;
        }
        
        string val_7 = val_6.Item[-1630882544];
        if(val_6 != 0)
        {
                val_16 = null;
        }
        
        if(val_6 != 0)
        {
                val_16 = null;
            val_17 = 0;
            if(((val_6 + 100 + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_16)
        {
                val_6 = 0;
        }
        
            val_17 = val_6;
        }
        else
        {
                val_17 = 0;
        }
        
        List.Enumerator<T> val_8 = GetEnumerator();
        label_15:
        if(MoveNext() == false)
        {
            goto label_11;
        }
        
        val_18 = val_10;
        val_19 = 0;
        if(val_18 != 0)
        {
                if(((val_10 + 100 + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_18 = 0;
        }
        
            val_19 = val_18;
        }
        
        GameLevel val_11 = this.ParseLevel(thisLevel:  0);
        Add(item:  0);
        goto label_15;
        label_11:
        var val_12 = 0 + 1;
        mem2[0] = 111;
        Dispose();
        if(val_12 == 1)
        {
            goto label_18;
        }
        
        if((-132223656 + ((0 + 1)) << 2) == 111)
        {
                -132223656 + ((0 + 1)) << 2 = val_12 >> 31;
            -132223656 + ((0 + 1)) << 2 = ~(val_12 >> 31);
            val_12 = val_12 + (-132223656 + ((0 + 1)) << 2);
        }
        
        goto label_18;
        label_3:
        Dispose();
        val_20 = null;
        val_20 = null;
        val_22 = WADataParser.<>c.<>9__106_0;
        if(val_22 == 0)
        {
                val_22 = null;
            val_22 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  WADataParser.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4162727648));
            WADataParser.<>c.<>9__106_0 = val_22;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_14 = System.Linq.Enumerable.OrderBy<System.Object, System.Int32>(source:  80883712, keySelector:  7720960);
        System.Collections.Generic.List<TSource> val_15 = System.Linq.Enumerable.ToList<System.Object>(source:  80883712);
    }
    private System.Collections.Generic.List<GameLevel> ParseFlatLevels(System.Collections.Generic.Dictionary<string, object> flatLevelsDef)
    {
        var val_5;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        System.Func<GameLevel, System.Int32> val_15;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        object val_2 = flatLevelsDef.Item[-1630882544];
        val_10 = 0;
        List.Enumerator<T> val_3 = GetEnumerator();
        label_12:
        if(MoveNext() == false)
        {
            goto label_8;
        }
        
        val_11 = val_5;
        val_12 = 0;
        if(val_11 != 0)
        {
                if(((val_5 + 100 + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_11 = 0;
        }
        
            val_12 = val_11;
        }
        
        GameLevel val_6 = this.ParseLevel(thisLevel:  0);
        Add(item:  0);
        goto label_12;
        label_8:
        Dispose();
        val_13 = null;
        val_13 = null;
        val_15 = WADataParser.<>c.<>9__107_0;
        if(val_15 == 0)
        {
                val_15 = null;
            val_15 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  WADataParser.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(4162851936));
            WADataParser.<>c.<>9__107_0 = val_15;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_8 = System.Linq.Enumerable.OrderBy<System.Object, System.Int32>(source:  80883712, keySelector:  7720960);
        System.Collections.Generic.List<TSource> val_9 = System.Linq.Enumerable.ToList<System.Object>(source:  80883712);
    }
    private void AddOrUpdateKnownLevelCurve(WADataParser.LevelCurve curve)
    {
        this.AddOrUpdateToLevelCurveList(curve:  curve, levelCurves:  this.knownLevelCurves);
    }
    private void AddOrUpdateFeatureLevelCurve(WADataParser.LevelCurve curve)
    {
        this.AddOrUpdateToLevelCurveList(curve:  curve, levelCurves:  this.featureLevelCurves);
    }
    private void AddOrUpdateToLevelCurveList(WADataParser.LevelCurve curve, System.Collections.Generic.List<WADataParser.LevelCurve> levelCurves)
    {
        var val_3;
        if(curve == 0)
        {
                return;
        }
        
        val_3 = 4;
        goto label_2;
        label_10:
        if(true <= 35639961)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        bool val_1 = System.String.op_Equality(a:  static_value_0028000F, b:  curve.Language);
        if(val_1 == false)
        {
            goto label_5;
        }
        
        if(val_1 <= 35639961)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        bool val_2 = System.String.op_Equality(a:  406886400, b:  curve.Bucket);
        if(val_2 == true)
        {
            goto label_8;
        }
        
        label_5:
        val_3 = 5;
        label_2:
        if((val_3 - 4) < val_2)
        {
            goto label_10;
        }
        
        label_11:
        levelCurves.Add(item:  curve);
        return;
        label_8:
        if(35639961 < 0)
        {
            goto label_11;
        }
        
        levelCurves.set_Item(index:  35639961, value:  curve);
    }
    public WADataParser.LevelCurve GetLevelCurve(string lang, string bucket)
    {
        LevelCurve val_1 = this.GetLevelCurveFromList(lang:  lang, bucket:  bucket, levelCurves:  this.knownLevelCurves);
        if(this == 0)
        {
                this.LoadDataIntoMemoryFromResourcesRegularCurve(lang:  lang, bucket:  bucket);
        }
        
        LevelCurve val_2 = this.GetLevelCurveFromList(lang:  lang, bucket:  bucket, levelCurves:  this.knownLevelCurves);
    }
    public WADataParser.LevelCurve GetFeatureLevelCurve(string lang, string bucket)
    {
        LevelCurve val_1 = this.GetLevelCurveFromList(lang:  lang, bucket:  bucket, levelCurves:  this.featureLevelCurves);
        if(this == 0)
        {
                this.LoadDataIntoMemoryFromResourcesFeatureCurve(lang:  lang, featureBucket:  bucket);
        }
        
        LevelCurve val_2 = this.GetLevelCurveFromList(lang:  lang, bucket:  bucket, levelCurves:  this.featureLevelCurves);
    }
    private WADataParser.LevelCurve GetLevelCurveFromList(string lang, string bucket, System.Collections.Generic.List<WADataParser.LevelCurve> levelCurves)
    {
        if(new System.Object() != 0)
        {
                typeof(WADataParser.<>c__DisplayClass116_0).__il2cppRuntimeField_8 = lang;
        }
        else
        {
                mem[8] = lang;
        }
        
        typeof(WADataParser.<>c__DisplayClass116_0).__il2cppRuntimeField_C = bucket;
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_2 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  384450560, method:  new IntPtr(4163674464));
        return System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  levelCurves, predicate:  7720960);
    }
    public WADataParser()
    {
        this.this_generator = new CrosswordCreator.Crossword.CrosswordGenerator();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.usedWordThisSession = null;
        this.usedSpanishLevels = new System.Collections.Generic.List<System.Int32>();
        typeof(System.String[]).__il2cppRuntimeField_10 = "A";
        typeof(System.String[]).__il2cppRuntimeField_14 = "B";
        this.buckets = null;
        typeof(System.String[]).__il2cppRuntimeField_10 = "D";
        typeof(System.String[]).__il2cppRuntimeField_14 = "E";
        this.featureBuckets = null;
        System.Collections.Generic.List<System.Int32> val_4 = new System.Collections.Generic.List<System.Int32>();
        if(val_4 != 0)
        {
                Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
        }
        else
        {
                Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  6);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
            Add(item:  7);
        }
        
        Add(item:  7);
        this.plv_chapterWordLengths = val_4;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_5 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.plv_playedWords = null;
        this.knownLevelCurves = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.featureLevelCurves = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
    }
    private static WADataParser()
    {
        WADataParser.CurrentLevelGenVersion = "n/a";
        WADataParser.debug_lastReqDetermination = "n/a";
        WADataParser.debug_uncommonInAnswers = "n/a";
        WADataParser.debug_uncommonInRequiredExtra = "n/a";
        WADataParser._QAHACK_NoExtraRequired = false;
        WADataParser.Debug_RanOutWhenTranslating = "False. Has not parsed any level data yet.";
        WADataParser.Debug_FinishedContent = "False. Has not checked for finished content yet.";
        WADataParser.QAhackedWord = System.String.alignConst;
    }

}
