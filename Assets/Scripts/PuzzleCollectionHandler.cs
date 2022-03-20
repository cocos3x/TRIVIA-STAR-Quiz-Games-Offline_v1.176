using UnityEngine;
public class PuzzleCollectionHandler : WGEventHandler
{
    // Fields
    private static PuzzleCollectionHandler _Instance;
    public const string PUZZLE_COLLECTION_EVENT_ID = "PuzzleCollection";
    public const int DEFAULT_PIECES_TOTAL_COUNT = 16;
    public const string DEFAULT_PUZZLE_IMAGE_FILE_EXTENSION = "png";
    private const string LAST_COLLECTED_PIECES_COUNT_KEY = "pzl_pc_last_ct";
    private const string COLLECTED_PIECES_COUNT_KEY = "pzl_pc_ct";
    private const string PUZZLE_PROGRESS_KEY = "pzl_pc_rvld";
    private const string NEW_PUZZLE_PIECES_KEY = "pzl_pcs_new";
    private const string REWARD_TYPE_KEY = "pzl_rwdtype";
    private const string REWARD_VALUE_KEY = "pzl_rwd";
    private const string BASEURL_KEY = "pzl_base_url";
    private const string PUZZLE_COLLECTION_EVENT_SERVER_TIME_STAMP_KEY = "pzl_evt_svr_tmstmp";
    private const string PUZZLE_COLLECTION_EVENT_IS_NEW_CYCLE_KEY = "pzl_evt_nw_ccl";
    private const string PUZZLES_KEY = "pzl_pzls";
    private const string COMPLETED_PUZZLES_KEY = "pzl_cmpltd_pzls";
    private const string CURRENT_PUZZLE_NAME_KEY = "pzl_crt_nm";
    private const string NEXT_PUZZLE_NAME_KEY = "pzl_nxt_nm";
    private const string IS_FTUX_KEY = "pzl_ftux";
    private const string EARNED_PUZZLE_PIECE_KEY = "pzl_earned_pc";
    private const string LEVEL_RESET_KEY = "pzl_lvl_rst";
    private const string LIFETIME_PUZZLES_COMPLETED_KEY = "lftm_pzl_cmpltd";
    private const string LAST_PROGRESS_STAMP_KEY = "pzl_lst_prog_ts";
    private const string LAST_PUZZLE_NAME_KEY = "pzl_last_nm";
    private const string pref_is_ready_to_reward = "pzl_is_ready_rw";
    private const string ECONOMY = "economy";
    private const string REWARD = "reward_v2";
    private const string BASE_URL = "base_url";
    private const string PUZZLES = "puzzles";
    private const string REWARD_COINS = "coins";
    private const string REWARD_BONUS_WHEEL = "bonus_wheel";
    private const string REWARD_BONUS_SPIN = "bonus_spin";
    private const string INTERVALS = "intervals";
    private const string PUZZLE_TIME_UPPER = "PUZZLE TIME";
    private const GameEventRewardType DEFAULT_REWARD_TYPE = 1;
    private const int DEFAULT_REWARD_VALUE = 35;
    private const string DEFAULT_BASE_URL = "https://cdn.12gigs.com/guess_the_word_pngs/REPLACEME.png";
    private const string DEFAULT_EVENT_TIME_STAMP = "";
    private const bool DEFAULT_IS_NEW_CYCLE = True;
    private const string DEFAULT_INIT_PUZZLE_NAME = "";
    private const bool DEFAULT_IS_FTUX = True;
    private const bool DEFAULT_EARNED_PUZZLE_PIECE = False;
    private const bool DEFAULT_LEVEL_RESET = False;
    private const int DEFAULT_LIFETIME_PUZZLES_COMPLETED = 0;
    private bool shownCompletePopup;
    private PuzzleCollectionV2_EventProgress eventProgress;
    public System.Action OnPuzzlePieceCollected;
    public System.Action OnPuzzlePieceGivenAdditionalChance;
    
    // Properties
    public static PuzzleCollectionHandler Instance { get; }
    public static bool EarnedPuzzlePiece { get; set; }
    public static int CollectedPiecesCount { get; }
    public static int[] CurrentPuzzleProgress { get; set; }
    public static int[] NewPuzzlePieces { get; set; }
    public static GameEventRewardType RewardType { get; set; }
    public static int RewardValue { get; set; }
    public static bool IsNewCycle { get; set; }
    public static string CurrentPuzzleName { get; set; }
    public static string LastPuzzleName { get; set; }
    public static bool IsFTUX { get; set; }
    public static int LifetimePuzzlesCompleted { get; set; }
    public bool PlayingChallenge { get; }
    private string PuzzleCollectionEventServerTimeStamp { get; set; }
    private string BaseURL { get; set; }
    private string[] Puzzles { get; set; }
    private string[] CompletedPuzzles { get; set; }
    private string NextPuzzleName { get; set; }
    private bool LevelIsReset { get; set; }
    private static int LastProgressTimestampPref { get; set; }
    private bool isReadyToReward { get; set; }
    
    // Methods
    public static PuzzleCollectionHandler get_Instance()
    {
    
    }
    public static bool get_EarnedPuzzlePiece()
    {
        return PlayerPrefsX.GetBool(name:  -1311391248, defaultValue:  false);
    }
    public static void set_EarnedPuzzlePiece(bool value)
    {
        bool val_1 = PlayerPrefsX.SetBool(name:  -1311391248, value:  value);
    }
    public static int get_CollectedPiecesCount()
    {
        bool val_3;
        var val_4;
        System.Func<System.Int32, System.Boolean> val_6;
        val_3 = static_value_021FB684;
        if(val_3 != true)
        {
                val_3 = true;
        }
        
        System.Int32[] val_1 = PuzzleCollectionHandler.CurrentPuzzleProgress;
        val_4 = null;
        val_4 = null;
        val_6 = PuzzleCollectionHandler.<>c.<>9__10_0;
        if(val_6 != 0)
        {
                return System.Linq.Enumerable.Count<System.Int32>(source:  1, predicate:  7720960);
        }
        
        val_6 = null;
        val_6 = new System.Func<System.Int32, System.Boolean>(object:  PuzzleCollectionHandler.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2983800144));
        PuzzleCollectionHandler.<>c.<>9__10_0 = val_6;
        return System.Linq.Enumerable.Count<System.Int32>(source:  1, predicate:  7720960);
    }
    public static int[] get_CurrentPuzzleProgress()
    {
        return PlayerPrefsX.GetIntArray(key:  -1311054128, defaultValue:  0, defaultSize:  16);
    }
    public static void set_CurrentPuzzleProgress(int[] value)
    {
        bool val_1 = PlayerPrefsX.SetIntArray(key:  -1311054128, intArray:  value);
    }
    public static int[] get_NewPuzzlePieces()
    {
        return PlayerPrefsX.GetIntArray(key:  -1310756304, defaultValue:  0, defaultSize:  0);
    }
    public static void set_NewPuzzlePieces(int[] value)
    {
        bool val_1 = PlayerPrefsX.SetIntArray(key:  -1310756304, intArray:  value);
    }
    public static GameEventRewardType get_RewardType()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1310458480)) == false)
        {
                return;
        }
        
        return UnityEngine.PlayerPrefs.GetInt(key:  -1310458480);
    }
    public static void set_RewardType(GameEventRewardType value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1310458480, value:  value);
    }
    public static int get_RewardValue()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1310226192, defaultValue:  35);
    }
    public static void set_RewardValue(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1310226192, value:  value);
    }
    public static bool get_IsNewCycle()
    {
        return PlayerPrefsX.GetBool(name:  -1310002096, defaultValue:  true);
    }
    public static void set_IsNewCycle(bool value)
    {
        bool val_1 = PlayerPrefsX.SetBool(name:  -1310002096, value:  value);
    }
    public static string get_CurrentPuzzleName()
    {
        return UnityEngine.PlayerPrefs.GetString(key:  -1309778000, defaultValue:  1098586544);
    }
    public static void set_CurrentPuzzleName(string value)
    {
        UnityEngine.PlayerPrefs.SetString(key:  -1309778000, value:  value);
    }
    public static string get_LastPuzzleName()
    {
        return UnityEngine.PlayerPrefs.GetString(key:  -1309545712, defaultValue:  1098586544);
    }
    public static void set_LastPuzzleName(string value)
    {
        UnityEngine.PlayerPrefs.SetString(key:  -1309545712, value:  value);
    }
    public static bool get_IsFTUX()
    {
        return PlayerPrefsX.GetBool(name:  -1309313424, defaultValue:  true);
    }
    public static void set_IsFTUX(bool value)
    {
        bool val_1 = PlayerPrefsX.SetBool(name:  -1309313424, value:  value);
    }
    public static int get_LifetimePuzzlesCompleted()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1309089328, defaultValue:  0);
    }
    public static void set_LifetimePuzzlesCompleted(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1309089328, value:  value);
    }
    public bool get_PlayingChallenge()
    {
        var val_5;
        var val_6;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_5 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
        val_6 = 0;
        if(PlayingChallenge == true)
        {
                return (bool)val_6;
        }
        
        val_5 = 35629547;
        if(PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED == 0)
        {
                return (bool)val_6;
        }
        
        if(PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED != 0)
        {
                return (bool)val_6;
        }
        
        val_6 = 0;
        if(SceneDictator.IsInGameScene() == false)
        {
                return (bool)val_6;
        }
        
        val_6 = 1;
        if(this.IsNewPuzzlePieceReady() == false)
        {
                return this.IsSolvingInProgress();
        }
        
        return (bool)val_6;
    }
    private string get_PuzzleCollectionEventServerTimeStamp()
    {
        return UnityEngine.PlayerPrefs.GetString(key:  -1308753216, defaultValue:  1098586544);
    }
    private void set_PuzzleCollectionEventServerTimeStamp(string value)
    {
        UnityEngine.PlayerPrefs.SetString(key:  -1308753216, value:  value);
    }
    private string get_BaseURL()
    {
        return UnityEngine.PlayerPrefs.GetString(key:  -1308520720, defaultValue:  -1308520912);
    }
    private void set_BaseURL(string value)
    {
        UnityEngine.PlayerPrefs.SetString(key:  -1308520720, value:  value);
    }
    private string[] get_Puzzles()
    {
        return PlayerPrefsX.GetStringArray(key:  -1308288432);
    }
    private void set_Puzzles(string[] value)
    {
        bool val_1 = PlayerPrefsX.SetStringArray(key:  -1308288432, stringArray:  value);
    }
    private string[] get_CompletedPuzzles()
    {
        return PlayerPrefsX.GetStringArray(key:  -1307990608);
    }
    private void set_CompletedPuzzles(string[] value)
    {
        bool val_1 = PlayerPrefsX.SetStringArray(key:  -1307990608, stringArray:  value);
    }
    private string get_NextPuzzleName()
    {
        return UnityEngine.PlayerPrefs.GetString(key:  -1307692768, defaultValue:  1098586544);
    }
    private void set_NextPuzzleName(string value)
    {
        UnityEngine.PlayerPrefs.SetString(key:  -1307692768, value:  value);
    }
    private bool get_LevelIsReset()
    {
        return PlayerPrefsX.GetBool(name:  -1307460480, defaultValue:  false);
    }
    private void set_LevelIsReset(bool value)
    {
        bool val_1 = PlayerPrefsX.SetBool(name:  -1307460480, value:  value);
    }
    private static int get_LastProgressTimestampPref()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1307236384, defaultValue:  0);
    }
    private static void set_LastProgressTimestampPref(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1307236384, value:  value);
    }
    private bool get_isReadyToReward()
    {
        int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  -1307012272, defaultValue:  0);
        val_1 = val_1 - 1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    private void set_isReadyToReward(bool value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1307012272, value:  value);
    }
    private void RefreshPuzzleCollectionInfo(GameEventV2 eventV2)
    {
        mem[1152921511890034936] = eventV2;
        if(eventV2 == 0)
        {
                return;
        }
        
        if((System.String.op_Inequality(a:  eventV2.type, b:  -1306784064)) != false)
        {
                string val_2 = eventV2.ToString();
            string val_3 = -1322383584(-1322383584) + eventV2;
            UnityEngine.Debug.LogError(message:  -1322383584);
            return;
        }
        
        bool val_4 = this.IsEventNewCycle();
        if(val_4 != false)
        {
                this.ClearEventProgress();
            this.SetupServerTimestamp();
        }
        else
        {
                if(val_4.isReadyToReward != false)
        {
                if(this.shownCompletePopup == false)
        {
                this.shownCompletePopup.ShowPuzzleCompletePopup();
        }
        
        }
        
        }
        
        this.InitPuzzleCollectionInfo(data:  eventV2.eventData);
        this.RefreshCurrentPuzzleInfo(data:  eventV2.eventData);
        35632808 = 1152921511890009904;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1306771664) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UpdatePuzzleCollectionUI();
    }
    private void CheckIfCurrentPuzzleImageExists()
    {
        string val_1 = UnityEngine.Application.temporaryCachePath;
        string val_2 = PuzzleCollectionHandler.CurrentPuzzleName;
        string val_3 = null + 1115175264 + null + 1975550080;
        UnityEngine.Sprite val_4 = ImageLoadingController.GetSprite(path:  null);
        bool val_5 = UnityEngine.Object.op_Equality(x:  0, y:  0);
        if(val_5 == false)
        {
                return;
        }
        
        string val_6 = val_5.BaseURL;
        string val_7 = PuzzleCollectionHandler.CurrentPuzzleName;
        string val_8 = val_5.Replace(oldValue:  -1306642256, newValue:  val_5);
        string val_9 = PuzzleCollectionHandler.CurrentPuzzleName;
        string val_10 = UnityEngine.Application.temporaryCachePath;
        System.Action<System.Boolean, TRVQuizProgress> val_11 = new System.Action<System.Boolean, TRVQuizProgress>(object:  -1306616032, method:  new IntPtr(2988325136));
        RemoteResourcesLoadingController.DownloadItem(uri:  val_5, fileName:  val_5, fileExtention:  -1306640112, localDirectory:  null, callback:  null);
    }
    private void SetupServerTimestamp()
    {
        string val_1 = R4 + 8;
        string val_2 = val_1.ToString();
        val_1.PuzzleCollectionEventServerTimeStamp = val_1;
    }
    private void InitPuzzleCollectionInfo(System.Collections.Generic.Dictionary<string, object> data)
    {
        PuzzleCollectionHandler val_31;
        var val_32;
        float val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        System.Func<System.Object, System.String> val_42;
        var val_43;
        var val_44;
        val_31 = this;
        val_33 = 1152921510392296080;
        if((data.ContainsKey(key:  -1554533760)) == false)
        {
            goto label_2;
        }
        
        object val_2 = data.Item[-1554533760];
        val_34 = 0;
        val_35 = 0;
        if(data != 0)
        {
                val_35 = 0;
            if(((System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                data = 0;
        }
        
            val_35 = data;
        }
        
        if(val_35 != 0)
        {
            goto label_6;
        }
        
        label_2:
        val_35 = 0;
        val_34 = 1;
        label_6:
        if((val_35.ContainsKey(key:  -1306411936)) == false)
        {
            goto label_7;
        }
        
        string val_4 = val_35.Item[-1306411936];
        val_37 = 0;
        Dictionary.Enumerator<TKey, TValue> val_5 = GetEnumerator();
        val_31 = 1152921510367989680;
        label_23:
        if(0.MoveNext() == false)
        {
            goto label_15;
        }
        
        bool val_9 = System.Int32.TryParse(s:  R5, result: out  int val_8 = -1306397492);
        if((0 < 1) || (0 != 1))
        {
            goto label_23;
        }
        
        string val_10 = 0.Trim();
        string val_11 = 0.ToLower();
        if((System.String.Compare(strA:  null, strB:  -1987496016)) == 0)
        {
            goto label_21;
        }
        
        if((System.String.Compare(strA:  null, strB:  -1318762160)) == 0)
        {
            goto label_22;
        }
        
        if((System.String.Compare(strA:  null, strB:  -1318762064)) != 0)
        {
            goto label_23;
        }
        
        val_38 = 4;
        goto label_26;
        label_15:
        0.Dispose();
        PuzzleCollectionHandler.RewardType = 1;
        val_39 = 35;
        goto label_25;
        label_21:
        val_38 = 1;
        goto label_26;
        label_22:
        val_38 = 3;
        label_26:
        0.Dispose();
        PuzzleCollectionHandler.RewardType = 3;
        val_39 = 0;
        label_25:
        PuzzleCollectionHandler.RewardValue = 0;
        val_33 = 1152921510392296080;
        val_34 = val_34;
        val_35 = val_35;
        label_7:
        if((val_35.ContainsKey(key:  -1306411840)) != false)
        {
                string val_16 = val_35.Item[-1306411840];
            this.BaseURL = null;
        }
        
        if((val_35.ContainsKey(key:  -1306411744)) != false)
        {
                val_32 = val_35;
            string val_18 = val_35.Item[-1306411744];
            System.Collections.Generic.IEnumerable<TResult> val_19 = System.Linq.Enumerable.Cast<System.Object>(source:  0);
            val_36 = val_35;
            val_31 = 1152921504927772672;
            val_40 = null;
            val_40 = null;
            val_42 = PuzzleCollectionHandler.<>c.<>9__110_0;
            if(val_42 == 0)
        {
                val_42 = null;
            val_42 = new System.Func<ZooTile, System.String>(object:  PuzzleCollectionHandler.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2988556672));
            PuzzleCollectionHandler.<>c.<>9__110_0 = val_42;
        }
        
            System.Collections.Generic.IEnumerable<TResult> val_21 = System.Linq.Enumerable.Select<System.Object, System.Object>(source:  0, selector:  7720960);
            TSource[] val_22 = System.Linq.Enumerable.ToArray<System.Object>(source:  0);
            this.Puzzles = null;
            val_34 = val_34;
            val_35 = val_32;
        }
        
        if((val_35.ContainsKey(key:  -1306409600)) == false)
        {
                return;
        }
        
        val_36 = 1152921510385703632;
        string val_24 = val_35.Item[-1306409600];
        if(val_35 == 0)
        {
                return;
        }
        
        if(((mem[1179403747] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_35 = 0;
        }
        
        if((val_35.ContainsKey(key:  -1306409504)) != false)
        {
                string val_26 = val_35.Item[-1306409504];
            val_31 = 1152921504927932416;
            val_43 = null;
            val_43 = null;
            PuzzleCollectionEcon.min_lvl_interval = System.Int32.Parse(s:  null);
        }
        
        if((val_35.ContainsKey(key:  -1605531600)) == false)
        {
                return;
        }
        
        string val_29 = val_35.Item[-1605531600];
        val_44 = null;
        val_44 = null;
        PuzzleCollectionEcon.max_lvl_interval = System.Int32.Parse(s:  null);
    }
    private void RefreshCurrentPuzzleInfo(System.Collections.Generic.Dictionary<string, object> data)
    {
        string val_5;
        if((data.ContainsKey(key:  -1306411744)) != false)
        {
                val_5 = data;
            object val_2 = val_5.Item[-1306411744];
        }
        
        string val_3 = PuzzleCollectionHandler.CurrentPuzzleName;
        if((System.String.IsNullOrEmpty(value:  val_5)) != false)
        {
                this.DownloadNewPuzzleImage();
            this.ResetPuzzleProgress();
            return;
        }
        
        this.CheckIfCurrentPuzzleImageExists();
    }
    private bool IsEventNewCycle()
    {
        string val_1 = this.PuzzleCollectionEventServerTimeStamp;
        string val_2 = ToString();
        return System.String.op_Inequality(a:  -1306149136, b:  -1306149128);
    }
    private bool IsPuzzlePoolDepleted()
    {
        System.String[] val_1 = this.CompletedPuzzles;
        System.String[] val_2 = this.Puzzles;
        this = R1 - this;
        this = this >> 5;
        return (bool)this;
    }
    private string GetNewPuzzleName()
    {
        bool val_11;
        System.Collections.Generic.List<ZooTile> val_12;
        object val_13;
        char* val_14;
        val_11 = static_value_021FB6AC;
        if(val_11 != true)
        {
                val_11 = true;
        }
        
        System.String[] val_1 = this.Puzzles;
        val_12 = null;
        val_12 = new System.Collections.Generic.List<ZooTile>(collection:  1);
        if(val_12.IsPuzzlePoolDepleted() != true)
        {
                val_13 = null;
            val_13 = new System.Object();
            if(val_13 != 0)
        {
                typeof(PuzzleCollectionHandler.<>c__DisplayClass114_0).__il2cppRuntimeField_C = this;
        }
        else
        {
                val_13 = 12;
            mem[12] = this;
        }
        
            val_14 = 0;
            typeof(PuzzleCollectionHandler.<>c__DisplayClass114_0).__il2cppRuntimeField_8 = ;
            System.String[] val_7 = CompletedPuzzles;
        }
        
        if(new RandomSet() != 0)
        {
                addIntRange(lowest:  0, highest:  1094062063);
        }
        else
        {
                addIntRange(lowest:  0, highest:  1094062063);
        }
        
        int val_9 = roll(unweighted:  false);
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
    }
    private void DownloadNewPuzzleImage()
    {
        string val_1 = this.GetNewPuzzleName();
        this.NextPuzzleName = -1305811088;
        string val_2 = this.BaseURL;
        string val_3 = this.NextPuzzleName;
        string val_4 = this.Replace(oldValue:  -1306642256, newValue:  -1305811088);
        string val_5 = this.NextPuzzleName;
        string val_6 = UnityEngine.Application.temporaryCachePath;
        System.Action<System.Boolean, TRVQuizProgress> val_7 = new System.Action<System.Boolean, TRVQuizProgress>(object:  -1305811088, method:  new IntPtr(2988325136));
        RemoteResourcesLoadingController.DownloadItem(uri:  -1305811088, fileName:  -1305811088, fileExtention:  -1306640112, localDirectory:  null, callback:  null);
    }
    private void ImageDownloadCallback(bool isRequestSuccess, byte[] data)
    {
        if(isRequestSuccess == false)
        {
                return;
        }
        
        if(true == 0)
        {
                return;
        }
        
        if(PuzzleCollectionHandler.IsNewCycle == false)
        {
                return;
        }
        
        GameBehavior val_2 = App.getBehavior;
        if(0 != 2)
        {
                return;
        }
        
        this.ShowPuzzleProgressPopup();
    }
    private void ShowPuzzleProgressPopup()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(2119322896 == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    private void ShowPuzzleCompletePopup()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
    }
    private void ResetPuzzleProgress()
    {
        PuzzleCollectionHandler.CurrentPuzzleProgress = 478302960;
        string val_1 = NextPuzzleName;
        PuzzleCollectionHandler.CurrentPuzzleName = 478302960;
    }
    private void ClearEventProgress()
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1305199312)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1305199312);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1305199216)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1305199216);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1311054128)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1311054128);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1310458480)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1310458480);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1310226192)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1310226192);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1308520720)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1308520720);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1308753216)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1308753216);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1310002096)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1310002096);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1308288432)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1308288432);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1307990608)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1307990608);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1309778000)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1309778000);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1307692768)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1307692768);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1309313424)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1309313424);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1311391248)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1311391248);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1307460480)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1307460480);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1307236384)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1307236384);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1309545712)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1309545712);
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1307012272)) != false)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  -1307012272);
        }
        
        this.eventProgress.Delete();
    }
    private void DeletePlayerpref(string key)
    {
        if((UnityEngine.PlayerPrefs.HasKey(key:  key)) == false)
        {
                return;
        }
        
        UnityEngine.PlayerPrefs.DeleteKey(key:  R4);
    }
    private bool IsNewPuzzlePieceReady()
    {
        PuzzleCollectionV2_EventProgress val_1;
        if(this.eventProgress.levelsLapsed < 0)
        {
                return true;
        }
        
        val_1 = this.eventProgress;
        if(this.eventProgress != 0)
        {
            goto label_2;
        }
        
        val_1 = this.eventProgress;
        if(val_1 == 0)
        {
            goto label_3;
        }
        
        label_2:
        if(this.eventProgress.levelsLapsed > this.eventProgress.levelInterval)
        {
                0 = 1;
        }
        
        return true;
        label_3:
    }
    public bool IsCurrentGameModeEqualsPuzzleLastMode()
    {
        var val_6;
        GameplayMode val_1 = PlayingLevel.CurrentGameplayMode;
        val_6 = 0;
        if(this.eventProgress.lastMode != null)
        {
                return (bool)val_6;
        }
        
        GameplayMode val_2 = PlayingLevel.CurrentGameplayMode;
        if(null == 4)
        {
                bool val_4 = System.Int32.TryParse(s:  this.eventProgress.lastModeSecondaryId, result: out  int val_3 = -1304793804);
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8) == 0)
        {
                val_6 = 1;
        }
        
            return (bool)val_6;
        }
        
        val_6 = 1;
        return (bool)val_6;
    }
    public bool IsSolvingInProgress()
    {
        if(this.IsCurrentGameModeEqualsPuzzleLastMode() == false)
        {
                return (bool)0;
        }
        
        int val_2 = PlayingLevel.GetCurrentPlayerLevelNumber();
        val_2 = this.eventProgress.lastLevel - val_2;
        0 = val_2 >> 5;
        return (bool)0;
    }
    private int GetLevelInterval()
    {
        null = null;
        val_1 = val_1 + 1;
        return UnityEngine.Random.Range(min:  PuzzleCollectionEcon.min_lvl_interval, max:  val_1);
    }
    public override void Init(GameEventV2 eventV2)
    {
        CompanyDevices val_1 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                Player val_3 = App.Player;
            string val_4 = -1304441104(-1304441104) + 1835037;
            UnityEngine.Debug.LogWarning(message:  -1304441104);
        }
        
        PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED = this;
        this.eventProgress.Load();
        this.RefreshPuzzleCollectionInfo(eventV2:  eventV2);
    }
    public override void OnGameSceneBegan()
    {
        bool val_1 = this.LevelIsReset;
        if(val_1 == true)
        {
                return;
        }
        
        val_1.LevelIsReset = true;
        if(R4 == 0)
        {
                return;
        }
        
        R4.ResetPuzzleProgress();
    }
    public override void OnWordRegionLoaded()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static PuzzleCollectionUIController MonoSingleton<PuzzleCollectionUIController>::get_Instance().__il2cppRuntimeField_54 = 1;
        UpdatePuzzleCollectionUI();
    }
    public override void OnEventEnded()
    {
        this.ClearEventProgress();
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1306771664) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ResetUIProgress();
    }
    public override string GetMainMenuButtonText()
    {
        var val_9;
        System.Func<System.Int32, System.Boolean> val_11;
        System.Int32[] val_1 = PuzzleCollectionHandler.CurrentPuzzleProgress;
        System.Collections.Generic.List<System.Int32> val_2 = new System.Collections.Generic.List<System.Int32>(collection:  0);
        string val_3 = Localization.Localize(key:  -1303980720, defaultValue:  -1303980608, useSingularKey:  false);
        typeof(System.Object[]).__il2cppRuntimeField_10 = "puzzle_time_upper";
        typeof(System.Object[]).__il2cppRuntimeField_14 = " ";
        val_9 = null;
        val_9 = null;
        val_11 = PuzzleCollectionHandler.<>c.<>9__130_0;
        if(val_11 == 0)
        {
                val_11 = null;
            val_11 = new System.Func<System.Int32, System.Boolean>(object:  PuzzleCollectionHandler.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2990986784));
            PuzzleCollectionHandler.<>c.<>9__130_0 = val_11;
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_5 = System.Linq.Enumerable.Where<System.Int32>(source:  80883712, predicate:  7720960);
        string val_7 = System.Linq.Enumerable.Count<System.Int32>(source:  80883712).ToString();
        typeof(System.Object[]).__il2cppRuntimeField_18 = ;
        typeof(System.Object[]).__il2cppRuntimeField_1C = "/";
        typeof(System.Object[]).__il2cppRuntimeField_20 = null;
        string val_8 = +472754880;
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -1303980720, defaultValue:  -1303980608, useSingularKey:  false);
    }
    public override string GetGameButtonText()
    {
        var val_8;
        System.Func<System.Int32, System.Boolean> val_10;
        System.Int32[] val_1 = PuzzleCollectionHandler.CurrentPuzzleProgress;
        System.Collections.Generic.List<System.Int32> val_2 = new System.Collections.Generic.List<System.Int32>(collection:  0);
        val_8 = null;
        val_8 = null;
        val_10 = PuzzleCollectionHandler.<>c.<>9__132_0;
        if(val_10 == 0)
        {
                val_10 = null;
            val_10 = new System.Func<System.Int32, System.Boolean>(object:  PuzzleCollectionHandler.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2991213856));
            PuzzleCollectionHandler.<>c.<>9__132_0 = val_10;
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_4 = System.Linq.Enumerable.Where<System.Int32>(source:  80883712, predicate:  7720960);
        string val_6 = System.Linq.Enumerable.Count<System.Int32>(source:  80883712).ToString();
        string val_7 = -1303740444(-1303740444) + 1115175264 + 13152256;
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        var val_1;
        var val_1 = 25906347;
        val_1 = 9719444 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 19;
        AmplitudePluginHelper.lastFeatureAccessPoint.ShowPuzzleProgressPopup();
    }
    public override void OnGameButtonPressed(bool connected)
    {
        var val_3;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                20 = 21;
        }
        
        var val_3 = 25906035;
        val_3 = 9719756 + val_3;
        if(val_3 == 0)
        {
                mem2[0] = 1;
        }
        
        val_3 = null;
        val_3 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 21;
        AmplitudePluginHelper.lastFeatureAccessPoint.ShowPuzzleProgressPopup();
    }
    public override void OnLevelComplete(int levelsProgressed = 1)
    {
        PuzzleCollectionV2_EventProgress val_2;
        int val_3;
        this.LevelIsReset = false;
        val_2 = this.eventProgress;
        if(val_2 != 0)
        {
                val_3 = this.eventProgress.levelsLapsed;
        }
        else
        {
                val_2 = 12;
            val_3 = 0;
        }
        
        mem[12] = val_3 + levelsProgressed;
        this.eventProgress.Save();
    }
    public override int LastProgressTimestamp()
    {
        return PuzzleCollectionHandler.LastProgressTimestampPref;
    }
    public override void UpdateProgress()
    {
        PuzzleCollectionHandler.LastProgressTimestampPref = ServerHandler.UnixServerTime;
        this.UpdateProgress();
    }
    public override bool IsRewardReadyToCollect()
    {
        int val_1 = PuzzleCollectionHandler.CollectedPiecesCount;
        val_1 = val_1 - 16;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public override void AppendLevelCompleteData(ref System.Collections.Generic.Dictionary<string, object> currentData)
    {
        bool val_1 = PuzzleCollectionHandler.EarnedPuzzlePiece;
        currentData.Add(key:  -1302948016, value:  8945664);
        System.String[] val_2 = PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED.CompletedPuzzles;
        currentData.Add(key:  -1302947904, value:  13152256);
    }
    public override bool EventCompleted()
    {
        return this.IsEventExpired();
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        var val_8;
        System.Func<System.Int32, System.Boolean> val_10;
        System.Int32[] val_1 = PuzzleCollectionHandler.CurrentPuzzleProgress;
        val_8 = null;
        val_8 = null;
        val_10 = PuzzleCollectionHandler.<>c.<>9__141_0;
        if(val_10 == 0)
        {
                val_10 = null;
            val_10 = new System.Func<System.Int32, System.Boolean>(object:  PuzzleCollectionHandler.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2992251616));
            PuzzleCollectionHandler.<>c.<>9__141_0 = val_10;
        }
        
        int val_3 = System.Linq.Enumerable.Count<System.Int32>(source:  0, predicate:  7720960);
        string val_4 = val_3.ToString();
        string val_5 = 16.ToString();
        string val_6 = System.String.Format(format:  1629069648, arg0:  -1302701668, arg1:  -1302701672);
        float val_8 = (float)val_3;
        val_8 = val_8 * 0.0625f;
        TheLibraryMainScreen val_7 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        if(loader != 0)
        {
                return;
        }
    
    }
    public System.TimeSpan GetRemainingTime()
    {
        ulong val_2;
        System.TimeSpan val_8;
        var val_9;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = R1 + 8 + 32}, t2:  new System.DateTime() {dateData = val_2})) != false)
        {
                System.DateTime val_6 = DateTimeCheat.UtcNow;
            System.TimeSpan val_7 = this.Subtract(value:  new System.DateTime() {dateData = (R1 + 8) + 32});
            return new System.TimeSpan() {_ticks = val_8};
        }
        
        val_9 = null;
        val_9 = null;
        val_8 = System.TimeSpan.Zero;
        this = val_8;
        return new System.TimeSpan() {_ticks = val_8};
    }
    public string GetEventExpireTime()
    {
        var val_8;
        System.DateTime val_1 = DateTimeCheat.Now;
        System.TimeSpan val_4 = GetRemainingTime();
        System.DateTime val_7 = Add(value:  new System.TimeSpan() {_ticks = 1152921511894308080});
        string val_10 = val_8.ToString(format:  -1302485536);
    }
    public string GetEventExpireDayOfWeek()
    {
        var val_8;
        System.DateTime val_1 = DateTimeCheat.Now;
        System.TimeSpan val_4 = GetRemainingTime();
        System.DateTime val_7 = Add(value:  new System.TimeSpan() {_ticks = 1152921511894420080});
        System.DayOfWeek val_10 = val_8.DayOfWeek;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
    }
    private void SetupNextPuzzle()
    {
        bool val_8 = static_value_021FB6C4;
        if(val_8 != true)
        {
                val_8 = true;
        }
        
        System.String[] val_1 = this.CompletedPuzzles;
        string val_3 = PuzzleCollectionHandler.CurrentPuzzleName;
        if(null != 0)
        {
                Add(item:  new System.Collections.Generic.List<ZooTile>(collection:  1) = new System.Collections.Generic.List<ZooTile>(collection:  1));
        }
        else
        {
                Add(item:  new System.Collections.Generic.List<ZooTile>(collection:  1));
        }
        
        T[] val_4 = ToArray();
        CompletedPuzzles = 80883712;
        if(IsPuzzlePoolDepleted() != false)
        {
                System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_6 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
            T[] val_7 = ToArray();
            CompletedPuzzles = 80883712;
        }
        
        this.DownloadNewPuzzleImage();
        this.ResetPuzzleProgress();
    }
    public bool HandleCurrentPuzzleProgression()
    {
        bool val_8;
        var val_9;
        val_8 = static_value_021FB6C5;
        if(val_8 != true)
        {
                val_8 = true;
        }
        
        System.Int32[] val_1 = PuzzleCollectionHandler.CurrentPuzzleProgress;
        val_9 = 0;
        null = new RandomSet();
        goto label_1;
        label_6:
        if(16787456 != 1)
        {
                add(item:  0, weight:  null);
        }
        
        val_9 = 1;
        label_1:
        if(val_9 < 50331648)
        {
            goto label_6;
        }
        
        int val_3 = roll(unweighted:  false);
        var val_4 = val_8 + (val_3 << 2);
        mem2[0] = 1;
        PuzzleCollectionHandler.CurrentPuzzleProgress = 1;
        System.Int32[] val_5 = PuzzleCollectionHandler.NewPuzzlePieces;
        System.Collections.Generic.List<System.Int32> val_6 = new System.Collections.Generic.List<System.Int32>(collection:  1);
        if(null != 0)
        {
                Add(item:  val_3);
        }
        else
        {
                Add(item:  val_3);
        }
        
        T[] val_7 = ToArray();
        PuzzleCollectionHandler.NewPuzzlePieces = 80883712;
        goto typeof(PuzzleCollectionHandler).__il2cppRuntimeField_164;
    }
    public void HandleCurrentPuzzleSolved()
    {
        System.Collections.Generic.IEnumerable<TResult> val_1 = System.Linq.Enumerable.Repeat<System.Int32>(element:  1, count:  16);
        TSource[] val_2 = System.Linq.Enumerable.ToArray<System.Int32>(source:  1);
        PuzzleCollectionHandler.CurrentPuzzleProgress = 1;
        string val_3 = PuzzleCollectionHandler.CurrentPuzzleName;
        PuzzleCollectionHandler.LastPuzzleName = 1;
        this.isReadyToReward = true;
        this.shownCompletePopup = true;
        this.SetupNextPuzzle();
        PuzzleCollectionHandler.CurrentPuzzleProgress = 478302960;
        int val_4 = PuzzleCollectionHandler.LifetimePuzzlesCompleted;
        val_4 = val_4 + 1;
        PuzzleCollectionHandler.LifetimePuzzlesCompleted = val_4;
        System.Int32[] val_5 = PuzzleCollectionHandler.NewPuzzlePieces;
        System.Collections.Generic.List<System.Int32> val_6 = new System.Collections.Generic.List<System.Int32>(collection:  val_4);
        if(null != 0)
        {
                Clear();
        }
        else
        {
                Clear();
        }
        
        T[] val_7 = ToArray();
        PuzzleCollectionHandler.NewPuzzlePieces = 80883712;
    }
    public void HackPuzzleSolution()
    {
        PuzzleCollectionHandler.EarnedPuzzlePiece = true;
        if((PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED + 24) != 0)
        {
                PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED + 24.Invoke();
        }
        
        if(PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED.HandleCurrentPuzzleProgression() != false)
        {
                PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED.HandleCurrentPuzzleSolved();
        }
        
        PuzzleCollectionHandler.DEFAULT_LIFETIME_PUZZLES_COMPLETED.PuzzlePieceAnimationComplete();
    }
    public string GetAllPuzzles()
    {
        bool val_5 = static_value_021FB6C7;
        if(val_5 != true)
        {
                val_5 = true;
        }
        
        System.String[] val_1 = this.Puzzles;
        System.String[] val_2 = Puzzles;
        string val_3 = System.String.Join(separator:  1370307136, value:  13152256);
        string val_4 = 13152256 + 1269544832 + 1370307136;
    }
    public string GetCompletedPuzzles()
    {
        bool val_5 = static_value_021FB6C8;
        if(val_5 != true)
        {
                val_5 = true;
        }
        
        System.String[] val_1 = this.CompletedPuzzles;
        System.String[] val_2 = CompletedPuzzles;
        string val_3 = System.String.Join(separator:  1370307136, value:  13152256);
        string val_4 = 13152256 + 1269544832 + 1370307136;
    }
    public int GetCompletedPuzzlesCount()
    {
        System.String[] val_1 = this.CompletedPuzzles;
        if(this != 0)
        {
                return (int)this;
        }
        
        return (int)this;
    }
    public bool IsNextPuzzleDifferent()
    {
        string val_1 = PuzzleCollectionHandler.CurrentPuzzleName;
        string val_2 = this.NextPuzzleName;
        return System.String.op_Inequality(a:  -1301452432, b:  -1301452432);
    }
    public bool IsEventExpired()
    {
        ulong val_2;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        return (bool)System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = 1152921511895441136});
    }
    public void MarkRewarded()
    {
        this.isReadyToReward = false;
        this.shownCompletePopup = false;
    }
    public void SaveEventProgress()
    {
        string val_7;
        GameplayMode val_1 = PlayingLevel.CurrentGameplayMode;
        val_7 = 0;
        if(null == 4)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_4 = (public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8).ToString();
            val_7 = (public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8);
        }
        
        this.eventProgress.lastLevel = PlayingLevel.GetCurrentPlayerLevelNumber();
        this.eventProgress.levelsLapsed = 0;
        this.eventProgress.levelInterval = this.GetLevelInterval();
        this.eventProgress.lastMode = null;
        this.eventProgress.lastModeSecondaryId = val_7;
        this.eventProgress.Save();
    }
    public void PuzzlePieceAnimationComplete()
    {
        bool val_1 = this.isReadyToReward;
        if(val_1 == false)
        {
                return;
        }
        
        val_1.ShowPuzzleCompletePopup();
    }
    public override int GetMovingWordIndex()
    {
        if(this.PlayingChallenge == false)
        {
                return 0;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1306771664) == 0)
        {
                return 0;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static PuzzleCollectionUIController MonoSingleton<PuzzleCollectionUIController>::get_Instance()) != 0)
        {
                return PuzzleWordIndex;
        }
        
        return PuzzleWordIndex;
    }
    public PuzzleCollectionHandler()
    {
        typeof(PuzzleCollectionV2_EventProgress).__il2cppRuntimeField_C = 0;
        typeof(PuzzleCollectionV2_EventProgress).__il2cppRuntimeField_14 = 1;
        object val_1 = new System.Object();
        this.eventProgress = null;
    }

}
