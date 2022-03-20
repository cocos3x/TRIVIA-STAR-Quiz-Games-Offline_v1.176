using UnityEngine;
public class BestBlocksPlayer : Player
{
    // Fields
    private const string PREFKEY_PLAYER_LIVES = "bbl_plives";
    private const string PREFKEY_PLAYER_LIVES_SERVER = "experience";
    private const string PREFKEY_LAST_LIFE_TOPUP_TIME = "bbl_life_topuptime";
    private const string PREFKEY_ZEN_SCORE_BEST = "bbl_zen_scr_best";
    private const string PREFKEY_ZEN_SCORE_CURRENT = "bbl_zen_scr_curr";
    private const string PREFKEY_ZEN_SCORE_LIFETIME = "bbl_zen_scr_lftm";
    private const string PREFKEY_ZEN_PIECES_PLACED_CURRENT = "bbl_zen_pipl_curr";
    private const string PREFKEY_POWERUPUSAGE_LIFETIME = "bbl_pwrup_ul";
    private const string PREFKEY_POWERUPUSAGE_CHAPTER = "bbl_pwrup_uc";
    private const string PREFKEY_POWERUPUSAGE_LEVEL = "bbl_pwrup_ulvl";
    private const string PREFKEY_POWERUPUSAGE_LEVEL_FREE = "bbl_pwrup_ulvlfree";
    private const string PREFKEY_CONSECUTIVE_FAILS = "bbl_consecutivefails";
    private const string PREFKEY_PIECEROTATION_LIFETIME = "bbl_prot_ul";
    private const string PREFKEY_PIECEROTATION_CURRENT = "bbl_prot_cur";
    private const string PREFKEY_PIECEROTATION_PROMPT = "bbl_prot_prmt";
    private const string PREFKEY_JELLYLEVEL_INCREMENTS = "bbl_jellylvl_incre";
    private const string PREFKEY_STONELEVEL_INCREMENTS = "bbl_stonelvl_incre";
    private const string PREFKEY_GOALREQUIREMENT_INCREMENTS = "bbl_goalreq_incre";
    private const string PREFKEY_GOALQUANTITY_INCREMENTS = "bbl_goalqty_incre";
    private const string PREFKEY_TUTORIAL_COMPLETED = "bbl_10ksu";
    private const string PREFKEY_TUTORIAL_COMPLETED_SERVER = "keys";
    private EasySaver<BestBlocksPlayer> mySaver;
    public int tutorialCompleted;
    public int livesBalance;
    public int zenModeScoreBest;
    public int zenModeScoreCurrent;
    public int zenModeScoreLifetime;
    public int zenModePiecesPlacedCurrent;
    public System.DateTime lastLifeTopupTime;
    public int lifetimePowerupUsed;
    public int chapterPowerupUsed;
    public System.Collections.Generic.Dictionary<BlockPuzzleMagic.PowerUpType, int> levelPowerupUsed;
    public int levelPowerupFreeUsed;
    public int lifetimeRotationsUsed;
    public System.Collections.Generic.Dictionary<BlockPuzzleMagic.GameMode, int> currentRotationsUsed;
    public System.Collections.Generic.Dictionary<BlockPuzzleMagic.GameMode, bool> rotationPrompted;
    public int consecutiveGameFails;
    public int levelGenJellyLevelsIncrementCount;
    public int levelGenStoneLevelsIncrementCount;
    public System.Collections.Generic.Dictionary<BlockPuzzleMagic.Goal.GoalType, int> goalRequirementIncrement;
    public System.Collections.Generic.List<int> computedGoalQuantity;
    
    // Properties
    public static BestBlocksPlayer Instance { get; }
    public string lastLifeTopupTimeJson { get; }
    public string levelPowerupUsedJson { get; }
    public string currentRotationsUsedJson { get; }
    public string rotationPromptedJson { get; }
    public string goalRequirementIncrementJson { get; }
    public string computedGoalQuantityJson { get; }
    public System.TimeSpan LivesMaxTimeLeft { get; }
    
    // Methods
    public static BestBlocksPlayer get_Instance()
    {
        var val_2 = 0;
        Player val_1 = App.Player;
        if(0 == 0)
        {
                return;
        }
    
    }
    public string get_lastLifeTopupTimeJson()
    {
        string val_1 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  9904128);
    }
    public string get_levelPowerupUsedJson()
    {
        return Newtonsoft.Json.JsonConvert.SerializeObject(value:  this.levelPowerupUsed);
    }
    public string get_currentRotationsUsedJson()
    {
        return Newtonsoft.Json.JsonConvert.SerializeObject(value:  this.currentRotationsUsed);
    }
    public string get_rotationPromptedJson()
    {
        return Newtonsoft.Json.JsonConvert.SerializeObject(value:  this.rotationPrompted);
    }
    public string get_goalRequirementIncrementJson()
    {
        return Newtonsoft.Json.JsonConvert.SerializeObject(value:  this.goalRequirementIncrement);
    }
    public string get_computedGoalQuantityJson()
    {
        return Newtonsoft.Json.JsonConvert.SerializeObject(value:  this.computedGoalQuantity);
    }
    public override void BuildReflectedLists()
    {
        var val_7;
        var val_8;
        System.Collections.Generic.List<System.Int32> val_9;
        val_7 = this;
        EasySaver<WordPlayer> val_1 = new EasySaver<WordPlayer>(incInstance:  -340681264);
        this.mySaver = null;
        if(this.goalRequirementIncrement != 0)
        {
                if(this.goalRequirementIncrement.Count > 0)
        {
            goto label_2;
        }
        
        }
        
        System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32> val_3 = new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>();
        if(null != 0)
        {
                val_8 = 1152921512856071184;
            Add(key:  1, value:  0);
            Add(key:  2, value:  0);
        }
        else
        {
                val_8 = 1152921512856071184;
            Add(key:  1, value:  0);
            Add(key:  2, value:  0);
        }
        
        Add(key:  3, value:  0);
        this.goalRequirementIncrement = null;
        label_2:
        val_9 = this.computedGoalQuantity;
        if(val_9 != 0)
        {
                if(val_9 > 0)
        {
                return;
        }
        
        }
        
        BlockPuzzleMagic.BestBlocksGameEcon val_4 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
        System.Collections.Generic.List<System.Int32> val_5 = new System.Collections.Generic.List<System.Int32>(collection:  val_9);
        mem2[0] = null;
    }
    public override void AddHardSaves(ref System.Collections.Generic.Dictionary<string, object> incDic)
    {
        this.mySaver.AddHardSavesToDictionary(refdic: ref  System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = -340519936);
    }
    protected override void TrustServerData(System.Collections.IDictionary diff)
    {
        var val_7;
        string val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_7 = 0;
        val_7 = 0;
        val_7 = val_7 + 1;
        val_7 = (uint)val_7 & 65535;
        val_9 = diff;
        if(diff != 0)
        {
                val_7 = 0;
            val_7 = val_7 + 1;
            val_10 = diff;
            val_8 = diff;
            this.livesBalance = System.Int32.Parse(s:  val_8);
        }
        
        val_11 = "keys";
        var val_8 = 0;
        val_7 = 0;
        val_8 = val_8 + 1;
        val_7 = (uint)val_8 & 65535;
        val_12 = diff;
        if(diff != 0)
        {
                val_11 = "keys";
            val_7 = 0;
            val_7 = val_7 + 1;
            val_13 = diff;
            val_8 = diff;
            this.tutorialCompleted = System.Int32.Parse(s:  val_8, style:  511);
        }
        
        this.TrustServerData(diff:  diff);
    }
    protected override void LoadFromLocal()
    {
        this.LoadFromLocal();
        this.livesBalance = UnityEngine.PlayerPrefs.GetInt(key:  -340335536, defaultValue:  0);
        this.lifetimePowerupUsed = UnityEngine.PlayerPrefs.GetInt(key:  -340335440, defaultValue:  0);
        this.chapterPowerupUsed = UnityEngine.PlayerPrefs.GetInt(key:  -340335344, defaultValue:  0);
        string val_4 = UnityEngine.PlayerPrefs.GetString(key:  -340335248);
        if((System.String.IsNullOrEmpty(value:  -340335248)) != true)
        {
                object val_6 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -340335248);
            this.levelPowerupUsed = "bbl_pwrup_ulvl";
            if("bbl_pwrup_ulvl" == 0)
        {
                System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32> val_7 = new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>();
            this.levelPowerupUsed = null;
        }
        
        }
        
        this.lifetimeRotationsUsed = UnityEngine.PlayerPrefs.GetInt(key:  -340333104, defaultValue:  0);
        string val_9 = UnityEngine.PlayerPrefs.GetString(key:  -340333008, defaultValue:  null);
        if((System.String.IsNullOrEmpty(value:  -340333008)) != true)
        {
                object val_11 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -340333008);
            this.currentRotationsUsed = "bbl_prot_cur";
            if("bbl_prot_cur" == 0)
        {
                System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32> val_12 = new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>();
            this.currentRotationsUsed = null;
        }
        
        }
        
        string val_13 = UnityEngine.PlayerPrefs.GetString(key:  -340330864, defaultValue:  null);
        if((System.String.IsNullOrEmpty(value:  -340330864)) != true)
        {
                object val_15 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -340330864);
            this.rotationPrompted = "bbl_prot_prmt";
            if("bbl_prot_prmt" == 0)
        {
                System.Collections.Generic.Dictionary<System.Int32Enum, System.Boolean> val_16 = new System.Collections.Generic.Dictionary<System.Int32Enum, System.Boolean>();
            this.rotationPrompted = null;
        }
        
        }
        
        this.consecutiveGameFails = UnityEngine.PlayerPrefs.GetInt(key:  -340328720, defaultValue:  0);
        this.levelGenJellyLevelsIncrementCount = UnityEngine.PlayerPrefs.GetInt(key:  -340328608, defaultValue:  0);
        this.levelGenStoneLevelsIncrementCount = UnityEngine.PlayerPrefs.GetInt(key:  -340328496, defaultValue:  0);
        string val_20 = UnityEngine.PlayerPrefs.GetString(key:  -340328384, defaultValue:  System.String.alignConst);
        object val_21 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -340328384);
        this.goalRequirementIncrement = "bbl_goalreq_incre";
        string val_22 = UnityEngine.PlayerPrefs.GetString(key:  -340327248, defaultValue:  System.String.alignConst);
        object val_23 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -340327248);
        this.computedGoalQuantity = "bbl_goalqty_incre";
        string val_24 = UnityEngine.PlayerPrefs.GetString(key:  -340327136);
        if((System.String.IsNullOrEmpty(value:  -340327136)) != true)
        {
                System.DateTime val_26 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.DateTime>(value:  -340314512);
            this.lastLifeTopupTime = new System.DateTime();
            mem[1152921512856479396] = ???;
        }
        
        this.tutorialCompleted = UnityEngine.PlayerPrefs.GetInt(key:  -340327024, defaultValue:  this.tutorialCompleted);
        this.zenModeScoreBest = UnityEngine.PlayerPrefs.GetInt(key:  -340326928, defaultValue:  0);
        this.zenModeScoreCurrent = UnityEngine.PlayerPrefs.GetInt(key:  -340326816, defaultValue:  0);
        this.zenModeScoreLifetime = UnityEngine.PlayerPrefs.GetInt(key:  -340326704, defaultValue:  0);
        this.zenModePiecesPlacedCurrent = UnityEngine.PlayerPrefs.GetInt(key:  -340326592, defaultValue:  0);
        bool val_32 = this.RefreshPlayerLives();
    }
    protected override void CreateNewPlayer(string id = " ")
    {
        this.CreateNewPlayer(id:  id);
        BlockPuzzleMagic.BestBlocksGameEcon val_1 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
        this.livesBalance = this;
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        this.lastLifeTopupTime = new System.DateTime();
        mem[1152921512856595492] = ???;
        this.tutorialCompleted = 0;
    }
    public bool IsFTUXGameLevels()
    {
        Player val_1 = App.Player;
        return false;
    }
    public bool GetFtuxStatus(BlockPuzzleMagic.FtuxId ftuxId)
    {
        if(ftuxId == 0)
        {
                this = 0;
            return (bool)this;
        }
        
        var val_1 = 33449456;
        ftuxId = ftuxId & 31;
        val_1 = val_1 & (1 << ftuxId);
        if(val_1 != 0)
        {
                val_1 = 1;
        }
        
        return true;
    }
    public void SetFtuxStatus(BlockPuzzleMagic.FtuxId ftuxId, bool completed)
    {
        if(ftuxId == 0)
        {
                return;
        }
        
        ftuxId = ftuxId & 31;
        if(completed == true)
        {
                this.tutorialCompleted & (~(1 << ftuxId)) = this.tutorialCompleted | (1 << ftuxId);
        }
        
        this.tutorialCompleted = this.tutorialCompleted & (~(1 << ftuxId));
    }
    public bool IsLivesMaxed()
    {
        BlockPuzzleMagic.BestBlocksGameEcon val_1 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
        if(this.livesBalance >= R1)
        {
                0 = 1;
        }
        
        return true;
    }
    public System.TimeSpan get_LivesMaxTimeLeft()
    {
        var val_12;
        var val_14;
        var val_15;
        var val_16;
        var val_18;
        var val_19;
        BlockPuzzleMagic.BestBlocksGameEcon val_1 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
        if(0 != 0)
        {
                val_14 = 0;
            val_15 = mem[R1 + 284];
            val_15 = R1 + 284;
            val_16 = val_14;
        }
        else
        {
                val_15 = mem[R1 + 284];
            val_15 = R1 + 284;
            val_16 = 0;
            val_14 = 0;
        }
        
        var val_4 = R1 + 304;
        System.DateTime val_5 = ToLocalTime();
        float val_15 = (float)UnityEngine.Mathf.Clamp(value:  val_16 - val_15, min:  1, max:  0);
        val_15 = (0 + 1404) * val_15;
        System.DateTime val_9 = AddMinutes(value:  null);
        System.DateTime val_10 = System.DateTime.Now;
        System.TimeSpan val_11 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512857163584}, d2:  new System.DateTime());
        val_18 = 0;
        double val_14 = val_12.TotalSeconds;
        val_19 = null;
        val_19 = null;
        this = System.TimeSpan.__il2cppRuntimeField_static_fields;
        return new System.TimeSpan() {_ticks = System.TimeSpan.__il2cppRuntimeField_static_fields};
    }
    public bool RefreshPlayerLives()
    {
        ulong val_3;
        var val_6;
        float val_10;
        var val_15;
        var val_16;
        System.DateTime val_17;
        val_15 = 0;
        if(this.IsLivesMaxed() == true)
        {
                return (bool)val_15;
        }
        
        val_16 = 0;
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        val_17 = this.lastLifeTopupTime;
        System.TimeSpan val_5 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512857275600}, d2:  new System.DateTime() {dateData = val_3});
        double val_8 = val_6.TotalMinutes;
        BlockPuzzleMagic.BestBlocksGameEcon val_9 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
        val_15 = 0;
        float val_15 = val_10;
        if((-339505952) < 0)
        {
                return (bool)val_15;
        }
        
        double val_11 = val_6.TotalMinutes;
        val_16;
        BlockPuzzleMagic.BestBlocksGameEcon val_12 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
        val_17;
        val_15 = val_15 / val_10;
        int val_14 = this.CreditLife(amount:  UnityEngine.Mathf.FloorToInt(f:  val_15), source:  null);
        val_15 = 1;
        return (bool)val_15;
    }
    public int DebitLife(int amount = 1)
    {
        System.DateTime val_3;
        var val_4;
        if(this.IsLivesMaxed() != false)
        {
                System.DateTime val_2 = DateTimeCheat.UtcNow;
            this.lastLifeTopupTime = val_3;
            mem[1152921512857399972] = val_4;
        }
        
        int val_5 = 0 - amount;
        this.SendLivesFullNotification(timeFromNow:  new System.Nullable<System.TimeSpan>() {HasValue = val_5});
        return (int)this.CreditLife(amount:  val_5, source:  null);
    }
    public void SendLivesFullNotification(System.Nullable<System.TimeSpan> timeFromNow)
    {
        var val_2;
        twelvegigs.plugins.NotificationInterval val_11;
        twelvegigs.plugins.LocalNotificationsPlugin.KillNotification(tipo:  21);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1953384384, value:  -339293904);
        if((val_2 & 255) == 0)
        {
                System.TimeSpan val_4 = Value;
        }
        else
        {
                System.TimeSpan val_5 = LivesMaxTimeLeft;
        }
        
        System.DateTime val_8 = System.DateTime.UtcNow;
        System.DateTime val_9 = Add(value:  new System.TimeSpan() {_ticks = 1152921512857500872});
        twelvegigs.plugins.LocalNotificationsPlugin.PostNotification(tipo:  21, when:  new System.DateTime() {dateData = 1}, interval:  val_11, optTitle:  0, optMessage:  0, extraData:  "Lives are full! Time to keep playing!", priority:  null, useTimeModifier:  false);
    }
    public int CreditLife(int amount = 1, string source)
    {
        var val_7;
        bool val_8;
        val_7 = amount;
        val_8 = static_value_021FBB36;
        if(val_8 != true)
        {
                val_8 = true;
        }
        
        BlockPuzzleMagic.BestBlocksGameEcon val_1 = BlockPuzzleMagic.BestBlocksGameEcon.Instance;
        this.livesBalance = UnityEngine.Mathf.Clamp(value:  this.livesBalance + val_7, min:  0, max:  301989888);
        if((System.String.IsNullOrEmpty(value:  source)) != true)
        {
                Player val_5 = App.Player;
            val_7 = 0;
            val_7.TrackNonCoinReward(source:  source, subSource:  null, rewardType:  null, rewardAmount:  0, additionalParams:  0);
        }
        
        WGBonusRewardsHandler val_6 = DefaultHandler<WGBonusRewardsHandler>.Instance;
        RequestDataFlush(immediate:  false, reset:  false);
        return (int)this.livesBalance;
    }
    public int GetPowerupAmountUsedThisLevel(BlockPuzzleMagic.PowerUpType powerupType)
    {
        if((this.levelPowerupUsed.ContainsKey(key:  powerupType)) == false)
        {
                return 0;
        }
        
        if(this.levelPowerupUsed != 0)
        {
                return this.levelPowerupUsed.Item[powerupType];
        }
        
        return this.levelPowerupUsed.Item[powerupType];
    }
    public bool IsFreePowerupAvailable(BlockPuzzleMagic.PowerUpType powerupType)
    {
        if(powerupType != 0)
        {
                return true;
        }
        
        if((this.GetPowerupAmountUsedThisLevel(powerupType:  0)) < 1)
        {
                0 = 1;
        }
        
        return true;
    }
    public void IncrementCurrentRotationsUsed(BlockPuzzleMagic.GameMode mode, int stepAmt)
    {
        EnumerableExtentions.SetOrAdd<System.Int32Enum, System.Int32>(dic:  this.currentRotationsUsed, key:  mode, newValue:  (EnumerableExtentions.GetOrDefault<System.Int32Enum, System.Int32>(dic:  this.currentRotationsUsed, key:  mode, defaultValue:  0)) + stepAmt);
        int val_3 = this.lifetimeRotationsUsed;
        val_3 = val_3 + 1;
        this.lifetimeRotationsUsed = val_3;
    }
    public override void SoftSave()
    {
        this.mySaver.SoftSaveLite();
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
    }
    protected override void Save()
    {
        this.mySaver.SoftSaveFull();
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public BestBlocksPlayer()
    {
        var val_6 = null;
        this.lastLifeTopupTime = System.DateTime.MinValue;
        mem[1152921512858377108] = System.DateTime.__il2cppRuntimeField_cctor_finished;
        System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32> val_1 = new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>();
        this.levelPowerupUsed = null;
        System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32> val_2 = new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>();
        this.currentRotationsUsed = null;
        System.Collections.Generic.Dictionary<System.Int32Enum, System.Boolean> val_3 = new System.Collections.Generic.Dictionary<System.Int32Enum, System.Boolean>();
        this.rotationPrompted = null;
        System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32> val_4 = new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>();
        this.goalRequirementIncrement = null;
        System.Collections.Generic.List<System.Int32> val_5 = new System.Collections.Generic.List<System.Int32>();
        this.computedGoalQuantity = null;
    }

}
