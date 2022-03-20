using UnityEngine;
public class Alphabet2Manager : MonoSingleton<Alphabet2Manager>
{
    // Fields
    private static System.Collections.Generic.List<string> supportLangs;
    private int tilesPerCollectionBox;
    private float uncommonThreshold;
    private float rareThreshold;
    private float superThreshold;
    private decimal commonReward;
    private decimal uncommonReward;
    private decimal rareReward;
    private decimal superReward;
    private string currentVideoRewardLetter;
    private bool QAHACK_alwaysPostLevelTile;
    private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<string>> AlphabetCollections;
    private System.Collections.Generic.Dictionary<string, float> AlphabetLetterData;
    private UnityEngine.GameObject currentAlphabetTileObject;
    private bool isLevelCompleteListenerAdded;
    public System.Action OnAlphabetTileCollected;
    public System.Action OnAlphabetCollectionCompleted;
    public System.Action OnPetAlphabetTileSpawned;
    public System.Action OnTileClickAction;
    
    // Properties
    public static bool IsAvailable { get; }
    private decimal completeCollectionReward { get; }
    private int minLevelsPerTile { get; }
    private int maxLevelsPerTile { get; }
    private int postLevelTileFreq_Modulo { get; }
    private int unlockLevel { get; }
    private decimal redrawCoinCost { get; }
    private int currentCollectionIndex { get; set; }
    private int totalCollectionsComplete { get; set; }
    private decimal currentCollectionRewardBonus { get; set; }
    private System.Collections.Generic.List<string> currentCollectionBox { get; set; }
    private System.Collections.Generic.List<string> currentCollectionProgress { get; set; }
    private int nextLevelWithTile { get; set; }
    private string currentLanguage { get; set; }
    private bool inFTUX { get; }
    private int lifetimeRedraws { get; set; }
    private string currentCollectionLetter { get; set; }
    private int currentLineWord { get; set; }
    private int currentCell { get; set; }
    private int lastLevelWithTile { get; set; }
    private string lastTileType { get; set; }
    private bool collectedLastLevel { get; set; }
    private string lastLevelWithTileRarity { get; set; }
    private int levelsLapsedSinceTileSpawned { get; set; }
    private GameplayMode lastGameModeWithTile { get; set; }
    private string lastGameModeSecondayId { get; set; }
    private UnityEngine.GameObject AlphabetTileObjectPrefab { get; }
    private UnityEngine.GameObject AlphabetTileTooltipPrefab { get; }
    public int TilesPerCollectionBox { get; }
    public bool isAvailable { get; }
    public bool hasDataLoaded { get; }
    public bool canAddGameplayTile { get; }
    public string GetCurrentCollectionLetter { get; }
    public System.Collections.Generic.List<string> GetCurrentCollection { get; }
    public System.Collections.Generic.List<string> GetCurrentCollectionProgress { get; }
    public System.Collections.Generic.List<string> GetCurrentCollectionBox { get; }
    public decimal GetCurrentRewardAmount { get; }
    public UnityEngine.GameObject CurrentAlphabetTileObject { get; set; }
    public string GetCurrentVideoRewardLetter { get; }
    public bool QAHACK_AlwaysPostLevelTile { get; set; }
    public int GetAbWordIndex { get; }
    public decimal GetRedrawCost { get; }
    public int LifetimeRedrawsUsed { get; set; }
    public bool IsCurrentLevelWithTile { get; }
    
    // Methods
    public static bool get_IsAvailable()
    {
        var val_8;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
                return false;
        }
        
        val_8 = null;
        val_8 = null;
        GameBehavior val_2 = App.getBehavior;
        string val_3 = 0.GetCurrentLanguage();
        if((Alphabet2Manager.supportLangs.Contains(item:  null)) == false)
        {
                return false;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2100700048) == 0)
        {
                return false;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static Alphabet2Manager MonoSingleton<Alphabet2Manager>::get_Instance()) != 0)
        {
                return isAvailable;
        }
        
        return isAvailable;
    }
    private static void onTileClicked()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  true);
        SetupWithInfo();
    }
    private decimal get_completeCollectionReward()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return new System.Decimal() {flags = 880, hi = App.__il2cppRuntimeField_cctor_finished};
        }
        
        return new System.Decimal() {flags = 880, hi = App.__il2cppRuntimeField_cctor_finished};
    }
    private int get_minLevelsPerTile()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return 621;
        }
        
        return 621;
    }
    private int get_maxLevelsPerTile()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return 5767777;
        }
        
        return 5767777;
    }
    private int get_postLevelTileFreq_Modulo()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return 4;
        }
        
        return 4;
    }
    private int get_unlockLevel()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return 786450;
        }
        
        return 786450;
    }
    private decimal get_redrawCoinCost()
    {
        GameEcon val_1 = App.getGameEcon;
        if(0 != 0)
        {
                return new System.Decimal() {flags = 912, hi = App.__il2cppRuntimeField_cctor_finished};
        }
        
        return new System.Decimal() {flags = 912, hi = App.__il2cppRuntimeField_cctor_finished};
    }
    private int get_currentCollectionIndex()
    {
        Player val_1 = App.Player;
        if(2621448 != 0)
        {
                return 23;
        }
        
        return 23;
    }
    private void set_currentCollectionIndex(int value)
    {
        Player val_1 = App.Player;
        if(2621448 != 0)
        {
                return;
        }
    
    }
    private int get_totalCollectionsComplete()
    {
        Player val_1 = App.Player;
        if(2621448 != 0)
        {
                return 35143964;
        }
        
        return 35143964;
    }
    private void set_totalCollectionsComplete(int value)
    {
        Player val_1 = App.Player;
        if(2621448 != 0)
        {
                return;
        }
    
    }
    private decimal get_currentCollectionRewardBonus()
    {
        Player val_1 = App.Player;
        return new System.Decimal() {flags = 2621448 + 272, hi = App.__il2cppRuntimeField_cctor_finished};
    }
    private void set_currentCollectionRewardBonus(decimal value)
    {
        Player val_1 = App.Player;
        if(2621448 != 0)
        {
                return;
        }
    
    }
    private System.Collections.Generic.List<string> get_currentCollectionBox()
    {
        Player val_1 = App.Player;
        if(2621448 != 0)
        {
                return;
        }
    
    }
    private void set_currentCollectionBox(System.Collections.Generic.List<string> value)
    {
        Player val_1 = App.Player;
        if(2621448 != 0)
        {
                return;
        }
    
    }
    private System.Collections.Generic.List<string> get_currentCollectionProgress()
    {
        Player val_1 = App.Player;
        if(2621448 != 0)
        {
                return;
        }
    
    }
    private void set_currentCollectionProgress(System.Collections.Generic.List<string> value)
    {
        Player val_1 = App.Player;
        if(2621448 != 0)
        {
                return;
        }
    
    }
    private int get_nextLevelWithTile()
    {
        Player val_1 = App.Player;
        if(2621448 != 0)
        {
                return 23;
        }
        
        return 23;
    }
    private void set_nextLevelWithTile(int value)
    {
        Player val_1 = App.Player;
        if(2621448 != 0)
        {
                return;
        }
    
    }
    private string get_currentLanguage()
    {
        Player val_1 = App.Player;
        if(2621448 != 0)
        {
                return;
        }
    
    }
    private void set_currentLanguage(string value)
    {
        Player val_1 = App.Player;
        if(2621448 != 0)
        {
                return;
        }
    
    }
    private bool get_inFTUX()
    {
        if(this.nextLevelWithTile != 0)
        {
                return false;
        }
        
        GameBehavior val_3 = App.getBehavior;
        if(this.nextLevelWithTile <= 0)
        {
                0 = 1;
        }
        
        return true;
    }
    private int get_lifetimeRedraws()
    {
        Player val_1 = App.Player;
        if(2621448 != 0)
        {
                return 23;
        }
        
        return 23;
    }
    private void set_lifetimeRedraws(int value)
    {
        Player val_1 = App.Player;
        if(2621448 != 0)
        {
                return;
        }
    
    }
    private string get_currentCollectionLetter()
    {
        return UnityEngine.PlayerPrefs.GetString(key:  -1589566640, defaultValue:  1098586544);
    }
    private void set_currentCollectionLetter(string value)
    {
        UnityEngine.PlayerPrefs.SetString(key:  -1589566640, value:  value);
    }
    private int get_currentLineWord()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1589334336, defaultValue:  0);
    }
    private void set_currentLineWord(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1589334336, value:  value);
    }
    private int get_currentCell()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1589110224, defaultValue:  0);
    }
    private void set_currentCell(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1589110224, value:  value);
    }
    private int get_lastLevelWithTile()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1588886128, defaultValue:  0);
    }
    private void set_lastLevelWithTile(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1588886128, value:  value);
    }
    private string get_lastTileType()
    {
        return UnityEngine.PlayerPrefs.GetString(key:  -1588661936, defaultValue:  -1588662032);
    }
    private void set_lastTileType(string value)
    {
        UnityEngine.PlayerPrefs.SetString(key:  -1588661936, value:  value);
    }
    private bool get_collectedLastLevel()
    {
        string val_1 = 0.ToString();
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -1588429648, defaultValue:  -1588417553);
        return (bool)System.Boolean.Parse(value:  -1588429648);
    }
    private void set_collectedLastLevel(bool value)
    {
        string val_1 = value.ToString();
        UnityEngine.PlayerPrefs.SetString(key:  -1588429648, value:  -1588305553);
    }
    private string get_lastLevelWithTileRarity()
    {
        return UnityEngine.PlayerPrefs.GetString(key:  -1588205536, defaultValue:  1098586544);
    }
    private void set_lastLevelWithTileRarity(string value)
    {
        UnityEngine.PlayerPrefs.SetString(key:  -1588205536, value:  value);
    }
    private int get_levelsLapsedSinceTileSpawned()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1587973248, defaultValue:  0);
    }
    private void set_levelsLapsedSinceTileSpawned(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1587973248, value:  value);
    }
    private GameplayMode get_lastGameModeWithTile()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1587749152, defaultValue:  1);
    }
    private void set_lastGameModeWithTile(GameplayMode value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1587749152, value:  value);
    }
    private string get_lastGameModeSecondayId()
    {
        return UnityEngine.PlayerPrefs.GetString(key:  -1587516864, defaultValue:  null);
    }
    private void set_lastGameModeSecondayId(string value)
    {
        UnityEngine.PlayerPrefs.SetString(key:  -1587516864, value:  value);
    }
    private UnityEngine.GameObject get_AlphabetTileObjectPrefab()
    {
        return PrefabLoader.LoadPrefab(featureName:  -1587284464, prefabName:  -1587284560);
    }
    private UnityEngine.GameObject get_AlphabetTileTooltipPrefab()
    {
        return PrefabLoader.LoadPrefab(featureName:  -1587284464, prefabName:  -1587172368);
    }
    public int get_TilesPerCollectionBox()
    {
        return (int)this.tilesPerCollectionBox;
    }
    public bool get_isAvailable()
    {
        GameBehavior val_1 = App.getBehavior;
        return GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  this.unlockLevel);
    }
    public bool get_hasDataLoaded()
    {
        if(this.AlphabetCollections.Count < 1)
        {
                return false;
        }
        
        if(this.AlphabetLetterData.Count > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public bool get_canAddGameplayTile()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_2 = PlayingChallenge;
        val_2 = val_2 ^ 1;
        return (bool)val_2;
    }
    public string get_GetCurrentCollectionLetter()
    {
        return this.currentCollectionLetter;
    }
    public System.Collections.Generic.List<string> get_GetCurrentCollection()
    {
        if(this.AlphabetCollections != 0)
        {
                return this.AlphabetCollections.Item[this.currentCollectionIndex];
        }
        
        return this.AlphabetCollections.Item[this.currentCollectionIndex];
    }
    public System.Collections.Generic.List<string> get_GetCurrentCollectionProgress()
    {
        return this.currentCollectionProgress;
    }
    public System.Collections.Generic.List<string> get_GetCurrentCollectionBox()
    {
        return this.currentCollectionBox;
    }
    public decimal get_GetCurrentRewardAmount()
    {
        int val_3;
        int val_4;
        decimal val_1 = completeCollectionReward;
        decimal val_2 = currentCollectionRewardBonus;
        decimal val_5 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -1586112608}, d2:  new System.Decimal() {flags = val_3, hi = val_4});
        return new System.Decimal() {flags = val_5.flags, hi = val_5.hi, lo = val_5.lo, mid = val_5.mid};
    }
    public UnityEngine.GameObject get_CurrentAlphabetTileObject()
    {
    
    }
    public void set_CurrentAlphabetTileObject(UnityEngine.GameObject value)
    {
        this.currentAlphabetTileObject = value;
    }
    public string get_GetCurrentVideoRewardLetter()
    {
        if((System.String.IsNullOrEmpty(value:  this.currentVideoRewardLetter)) == false)
        {
                return;
        }
        
        string val_2 = this.PickNextCollectionLetter();
        this.currentVideoRewardLetter = this;
    }
    public bool get_QAHACK_AlwaysPostLevelTile()
    {
        return (bool)this.QAHACK_alwaysPostLevelTile;
    }
    public void set_QAHACK_AlwaysPostLevelTile(bool value)
    {
        this.QAHACK_alwaysPostLevelTile = value;
    }
    public int get_GetAbWordIndex()
    {
        string val_1 = this.currentCollectionLetter;
        bool val_2 = System.String.IsNullOrEmpty(value:  -1585407840);
        if(val_2 == true)
        {
                val_2 = 0;
            return (int)val_2;
        }
        
        return this.currentLineWord;
    }
    public decimal get_GetRedrawCost()
    {
        decimal val_1 = this.redrawCoinCost;
        return new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid};
    }
    public int get_LifetimeRedrawsUsed()
    {
        return this.lifetimeRedraws;
    }
    public void set_LifetimeRedrawsUsed(int value)
    {
        this.lifetimeRedraws = value;
    }
    public bool get_IsCurrentLevelWithTile()
    {
        if(this.IsCurrentModeEqualsModeWithTile() == false)
        {
                return (bool)0;
        }
        
        int val_3 = PlayingLevel.GetCurrentPlayerLevelNumber();
        val_3 = this.lastLevelWithTile - val_3;
        0 = val_3 >> 5;
        return (bool)0;
    }
    public bool IsCurrentModeEqualsModeWithTile()
    {
        var val_9 = 0;
        GameplayMode val_1 = PlayingLevel.CurrentGameplayMode;
        GameplayMode val_2 = this.lastGameModeWithTile;
        if(0 != 0)
        {
                return (bool)val_9;
        }
        
        GameplayMode val_3 = PlayingLevel.CurrentGameplayMode;
        val_9 = 1;
        if(0 != 4)
        {
                return (bool)val_9;
        }
        
        string val_4 = this.lastGameModeSecondayId;
        val_9 = 0;
        if((System.Int32.TryParse(s:  null, result: out  int val_5 = -1584859868)) == false)
        {
                return (bool)val_9;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_9 = ((public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8 - 0)) >> 5;
        return (bool)val_9;
    }
    public System.Collections.Generic.Dictionary<string, object> GetLevelTracking()
    {
        int val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>().lastLevelWithTile;
        Add(key:  -1988561632, value:  13152256);
        string val_3 = lastLevelWithTileRarity;
        Add(key:  -1584759840, value:  78753792);
        bool val_4 = collectedLastLevel;
        Add(key:  -1584759760, value:  8945664);
    }
    public System.Collections.Generic.List<string> RollLettersForRarity(Alphabet2Manager.Rarity rarity, int count)
    {
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Single>, System.Boolean> val_10;
        System.Collections.Generic.IEnumerable<TSource> val_11;
        var val_12;
        System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Single>, System.String> val_14;
        var val_15;
        int val_11 = count;
        if(new System.Object() != 0)
        {
                typeof(Alphabet2Manager.<>c__DisplayClass132_0).__il2cppRuntimeField_8 = this;
        }
        else
        {
                mem[8] = this;
        }
        
        typeof(Alphabet2Manager.<>c__DisplayClass132_0).__il2cppRuntimeField_C = rarity;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_10 = null;
        val_10 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Single>, System.Boolean>(object:  306388992, method:  new IntPtr(2710327824));
        System.Collections.Generic.IEnumerable<TSource> val_4 = System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.Object, System.Single>>(source:  this.AlphabetLetterData, predicate:  7720960);
        val_11 = this.AlphabetLetterData;
        val_12 = null;
        val_12 = null;
        val_14 = Alphabet2Manager.<>c.<>9__132_1;
        if(val_14 == 0)
        {
                val_14 = null;
            val_14 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Single>, System.String>(object:  Alphabet2Manager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2710330896));
            Alphabet2Manager.<>c.<>9__132_1 = val_14;
        }
        
        System.Collections.Generic.IEnumerable<TResult> val_6 = System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.Object, System.Single>, System.Object>(source:  val_11, selector:  7720960);
        System.Collections.Generic.List<TSource> val_7 = System.Linq.Enumerable.ToList<System.Object>(source:  val_11);
        if(val_11 < 1)
        {
                return;
        }
        
        val_10 = val_11;
        val_11 = 1152921510046813136;
        do
        {
            if(val_10 != 0)
        {
                val_15 = UnityEngine.Random.Range(min:  0, max:  1629937040);
        }
        else
        {
                int val_9 = UnityEngine.Random.Range(min:  0, max:  1629937040);
            val_15 = val_9;
        }
        
            if(val_9 <= val_15)
        {
                var val_10 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_10 = val_10 + (val_15 << 2);
            val_14 = mem[(0 + (val_9) << 2) + 16];
            val_14 = (0 + (val_9) << 2) + 16;
            Add(item:  val_14);
            val_11 = val_11 - 1;
        }
        while(null != 0);
    
    }
    public Alphabet2Manager.Rarity GetCurrentRarity()
    {
        bool val_6;
        string val_7;
        var val_8;
        val_6 = static_value_021FC0E3;
        if(val_6 != true)
        {
                val_6 = true;
        }
        
        string val_1 = this.currentCollectionLetter;
        val_7 = val_6;
        bool val_2 = this.AlphabetLetterData.ContainsKey(key:  1);
        if(val_2 != false)
        {
                string val_3 = val_2.currentCollectionLetter;
            val_7 = val_2;
            float val_4 = this.AlphabetLetterData.Item[val_7];
            val_8 = 0;
            if(this.AlphabetLetterData < 0)
        {
                return;
        }
        
            val_8 = 1;
            if(this.AlphabetLetterData < 0)
        {
                return;
        }
        
            if(this.AlphabetLetterData < 0)
        {
                val_8 = 2;
        }
        
            return;
        }
        
        string val_5 = currentCollectionLetter;
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        val_8 = 0;
        UnityEngine.Debug.LogErrorFormat(format:  -1584502896, args:  472754880);
    }
    public Alphabet2Manager.Rarity GetRarity(string letter)
    {
        System.Collections.Generic.Dictionary<System.String, System.Single> val_3;
        var val_4;
        val_3 = this.AlphabetLetterData;
        if((val_3.ContainsKey(key:  letter)) != false)
        {
                val_3 = this.AlphabetLetterData;
            float val_2 = val_3.Item[letter];
            val_4 = 0;
            if(val_3 < 0)
        {
                return;
        }
        
            val_4 = 1;
            if(val_3 < 0)
        {
                return;
        }
        
            if(val_3 < 0)
        {
                val_4 = 2;
        }
        
            return;
        }
        
        typeof(System.Object[]).__il2cppRuntimeField_10 = letter;
        val_4 = 0;
        UnityEngine.Debug.LogErrorFormat(format:  -1584502896, args:  472754880);
    }
    public decimal GetRewardForLetter(string letter)
    {
        Rarity val_1 = letter.GetRarity(letter:  R2);
        decimal val_2 = this.GetRewardByRarity(rarity:  letter);
        return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
    }
    public bool ShouldShowPostLevelAd()
    {
        if(this.nextLevelWithTile == 0)
        {
                return false;
        }
        
        if(this.QAHACK_alwaysPostLevelTile == true)
        {
                return true;
        }
        
        int val_3 = UnityEngine.Random.Range(min:  0, max:  this.postLevelTileFreq_Modulo);
        int val_4 = val_3.postLevelTileFreq_Modulo;
        var val_5 = val_3;
        val_5 = val_5 >> 5;
        return (bool)val_5;
    }
    public bool IsCurrentCollectionComplete()
    {
        bool val_7;
        var val_8;
        var val_9;
        System.Predicate<System.String> val_11;
        val_7 = static_value_021FC0E5;
        if(val_7 != true)
        {
                val_7 = true;
        }
        
        System.Collections.Generic.List<System.String> val_1 = this.currentCollectionProgress;
        val_8 = 50331648;
        System.Collections.Generic.List<System.String> val_3 = this.AlphabetCollections.Item[this.currentCollectionIndex];
        if(val_8 != this.AlphabetCollections)
        {
                return false;
        }
        
        System.Collections.Generic.List<System.String> val_4 = this.AlphabetCollections.currentCollectionProgress;
        val_9 = null;
        val_9 = null;
        val_11 = Alphabet2Manager.<>c.<>9__137_0;
        if(val_11 == 0)
        {
                val_11 = null;
            val_11 = new System.Predicate<ZooTile>(object:  Alphabet2Manager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2710957616));
            Alphabet2Manager.<>c.<>9__137_0 = val_11;
        }
        
        if((this.AlphabetCollections.Exists(match:  8040448)) == true)
        {
                1 = 0;
        }
        
        return (bool)1;
    }
    public bool ShouldShowFTUX()
    {
        return false;
    }
    public void ClearAndFillCollectionBox(int tileCount)
    {
        this.FillCollectionBoxRandomly(lettersToCollect:  tileCount);
    }
    public bool IsCollectionBoxFull()
    {
        bool val_2 = static_value_021FC0E6;
        if(val_2 != true)
        {
                val_2 = true;
        }
        
        System.Collections.Generic.List<System.String> val_1 = this.currentCollectionBox;
        if(50331648 >= this.tilesPerCollectionBox)
        {
                0 = 1;
        }
        
        return true;
    }
    public void CollectFTUXBox()
    {
        int val_1 = this.nextLevelWithTile;
        if(val_1 != 0)
        {
                return;
        }
        
        val_1.nextLevelWithTile = 1;
    }
    public bool HasCollectedWordAtIndex(string word, int letterIndex)
    {
        object val_4 = null;
        val_4 = new System.Object();
        if(val_4 != 0)
        {
                typeof(Alphabet2Manager.<>c__DisplayClass142_0).__il2cppRuntimeField_8 = word;
        }
        else
        {
                val_4 = 8;
            mem[8] = word;
        }
        
        typeof(Alphabet2Manager.<>c__DisplayClass142_0).__il2cppRuntimeField_C = letterIndex;
        System.Collections.Generic.List<System.String> val_1 = mem[8].currentCollectionProgress;
        System.Predicate<ZooTile> val_2 = new System.Predicate<ZooTile>(object:  306548736, method:  new IntPtr(2711528880));
        if(val_4 != 0)
        {
                return mem[8].Exists(match:  8040448);
        }
        
        return mem[8].Exists(match:  8040448);
    }
    public void CollectTileFromBox(string word, int letterIndex)
    {
        int val_27;
        int val_28;
        int val_30;
        int val_31;
        int val_33;
        System.Collections.Generic.IEnumerable<TSource> val_34;
        int val_35;
        var val_36;
        string val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        typeof(Alphabet2Manager.<>c__DisplayClass143_0).__il2cppRuntimeField_8 = word;
        System.Collections.Generic.List<System.String> val_2 = new System.Object().currentCollectionProgress;
        System.Predicate<ZooTile> val_3 = new System.Predicate<ZooTile>(object:  306601984, method:  new IntPtr(2711650096));
        object val_4 = new System.Object().Find(match:  8040448);
        val_34 = new System.Object();
        if((System.String.IsNullOrEmpty(value:  new System.Object() = new System.Object())) == false)
        {
            goto label_3;
        }
        
        val_35 = 0;
        string val_6 = 0.CreateString(c:  '0', count:  word + 8);
        string val_7 = typeof(Alphabet2Manager.<>c__DisplayClass143_0).__il2cppRuntimeField_8(typeof(Alphabet2Manager.<>c__DisplayClass143_0).__il2cppRuntimeField_8) + null;
        val_34 = "";
        goto label_5;
        label_10:
        val_37 = typeof(Alphabet2Manager.<>c__DisplayClass143_0).__il2cppRuntimeField_8;
        var val_34 = word + 8;
        val_34 = val_34 + letterIndex;
        if(val_35 == val_34)
        {
                val_38 = "1";
        }
        else
        {
                string val_9 = typeof(Alphabet2Manager.<>c__DisplayClass143_0).__il2cppRuntimeField_8.Chars[0].ToString();
            val_38 = ;
        }
        
        string val_10 = 1098586544 + -1583301142(-1583301142);
        val_35 = 1;
        val_34 = val_34;
        label_5:
        if(val_35 < (word + 8))
        {
            goto label_10;
        }
        
        System.Collections.Generic.List<System.String> val_11 = word + 8.currentCollectionProgress;
        val_39 = word + 8;
        val_40 = val_34;
        val_41 = 1152921510046813136;
        goto label_12;
        label_3:
        System.Collections.Generic.IEnumerable<TSource> val_12 = System.Linq.Enumerable.Skip<System.Char>(source:  val_34, count:  word + 8);
        TSource[] val_13 = System.Linq.Enumerable.ToArray<System.Char>(source:  val_34);
        val_42 = 0;
        if((val_34 + (letterIndex << 1).Equals(obj:  '0')) == false)
        {
            goto label_16;
        }
        
        val_35 = "";
        goto label_17;
        label_22:
        val_37 = typeof(Alphabet2Manager.<>c__DisplayClass143_0).__il2cppRuntimeField_8;
        var val_35 = word + 8;
        val_35 = val_35 + letterIndex;
        if(val_42 == val_35)
        {
                val_43 = "1";
        }
        else
        {
                string val_17 = val_34.Chars[0].ToString();
            val_43 = ;
        }
        
        string val_18 = 1098586544 + -1583301142(-1583301142);
        val_42 = 1;
        val_35 = val_35;
        label_17:
        if(val_42 < (mem[.ctor() + 8]))
        {
            goto label_22;
        }
        
        System.Collections.Generic.List<System.String> val_19 = mem[.ctor() + 8].currentCollectionProgress;
        bool val_20 = mem[.ctor() + 8].Remove(item:  val_34);
        System.Collections.Generic.List<System.String> val_21 = val_20.currentCollectionProgress;
        val_39 = val_20;
        val_40 = val_35;
        val_41 = 1152921510046813136;
        label_12:
        val_39.Add(item:  1098586544);
        return;
        label_16:
        decimal val_22 = currentCollectionRewardBonus;
        val_36 = 0;
        string val_24 = typeof(Alphabet2Manager.<>c__DisplayClass143_0).__il2cppRuntimeField_8.Chars[letterIndex].ToString();
        Rarity val_25 = this.GetRarity(letter:  -1583301142);
        decimal val_26 = GetRewardByRarity(rarity:  -1583289104);
        val_34 = val_27;
        val_35 = val_31;
        decimal val_32 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -1583301192}, d2:  new System.Decimal() {flags = val_28, hi = val_34, lo = val_35, mid = val_30});
        val_33.currentCollectionRewardBonus = new System.Decimal() {mid = val_33};
    }
    public void CompleteCurrentCollection()
    {
        bool val_13;
        var val_14;
        val_13 = static_value_021FC0E9;
        if(val_13 != true)
        {
                val_13 = true;
        }
        
        System.Collections.Generic.List<System.String> val_1 = this.currentCollectionBox;
        val_13.Clear();
        System.Collections.Generic.List<System.String> val_2 = this.currentCollectionProgress;
        val_13.Clear();
        val_14 = null;
        val_14 = null;
        System.Decimal.Powers10.__il2cppRuntimeField_10.currentCollectionRewardBonus = new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10};
        string val_3 = System.Decimal.Powers10.__il2cppRuntimeField_10.currentLanguage;
        GameBehavior val_4 = App.getBehavior;
        string val_5 = 0.GetCurrentLanguage();
        bool val_6 = System.Decimal.Powers10.__il2cppRuntimeField_10.Equals(value:  null);
        if(val_6 == false)
        {
                val_6 = this;
            this.ParseAlphabetData();
        }
        
        currentCollectionLetter = 1098586544;
        currentLineWord = 0;
        currentCell = 0;
        int val_9 = currentCollectionIndex + 1;
        val_9.currentCollectionIndex = this.AlphabetCollections.Count;
        int val_10 = val_9.totalCollectionsComplete;
        val_10.totalCollectionsComplete = val_10 + 1;
        Player val_12 = App.Player;
        0.SaveState();
    }
    public void CollectCurrentVideoRewardTile()
    {
        var val_4;
        this.currentCollectionLetter = this.currentVideoRewardLetter;
        this.currentVideoRewardLetter = "";
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Rarity val_2 = this.GetCurrentRarity();
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        Add(key:  -1583072720, value:  306335744);
        Player val_3 = App.Player;
        val_4 = null;
        val_4 = null;
        0.AddCredits(amount:  new System.Decimal() {flags = System.Decimal.Zero, hi = R4, lo = R5, mid = ???}, source:  "Video_Ad_Alphabet_Tile", subSource:  0, externalParams:  null, doTrack:  true);
        this.CollectCurrentLetter();
    }
    public UnityEngine.Transform GetLetterTransform()
    {
        WordRegion val_1 = WordRegion.instance;
        int val_2 = this.currentLineWord;
        if(0 <= val_2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_4 = 0;
        val_4 = val_4 + (val_2 << 2);
        int val_3 = val_4.currentCell;
        if(((0 + (val_2) << 2) + 16 + 20 + 12) <= val_3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_5 = (0 + (val_2) << 2) + 16 + 20 + 8;
        val_5 = val_5 + (val_3 << 2);
        if((((0 + (val_2) << 2) + 16 + 20 + 8 + (val_3) << 2) + 16) != 0)
        {
                return ((0 + (val_2) << 2) + 16 + 20 + 8 + (val_3) << 2) + 16.transform;
        }
        
        return ((0 + (val_2) << 2) + 16 + 20 + 8 + (val_3) << 2) + 16.transform;
    }
    public System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, int>> GetRandomSeededPositionsForCollection(System.Collections.Generic.List<string> collectionBox)
    {
        var val_2;
        System.Collections.Generic.IEnumerable<TSource> val_21;
        int val_22;
        var val_23;
        var val_24;
        System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, System.Int32>> val_25;
        var val_26;
        System.Collections.Generic.List<System.String> val_27;
        System.Collections.Generic.List<System.String> val_28;
        var val_29;
        var val_30;
        System.Collections.Generic.List<System.String> val_31;
        var val_32;
        val_21 = collectionBox;
        List.Enumerator<T> val_1 = GetEnumerator();
        val_22 = 0;
        val_23 = 1152921510891363008;
        goto label_2;
        label_4:
        val_24 = val_2;
        val_22 = val_22 - val_24.Chars[0];
        label_2:
        if(MoveNext() == true)
        {
            goto label_4;
        }
        
        Dispose();
        UnityEngine.Random.InitState(seed:  val_22);
        val_25 = null;
        val_25 = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.String, System.Int32>>();
        System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32> val_6 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  -1582810160, method:  new IntPtr(2712128016));
        System.Linq.IOrderedEnumerable<TSource> val_7 = System.Linq.Enumerable.OrderBy<System.Object, System.Int32>(source:  val_21, keySelector:  7720960);
        val_24 = 0;
        val_23 = 0;
        val_24 = val_24 + 1;
        val_23 = (uint)val_24 & 65535;
        val_26 = val_21;
        val_27 = val_21;
        goto label_10;
        label_33:
        object val_9 = new System.Object();
        var val_21 = 0;
        val_21 = val_21 + 1;
        val_28 = val_21;
        typeof(Alphabet2Manager.<>c__DisplayClass147_0).__il2cppRuntimeField_8 = val_21;
        System.Collections.Generic.List<System.String> val_11 = this.GetCurrentCollection;
        System.Predicate<ZooTile> val_12 = new System.Predicate<ZooTile>(object:  306655232, method:  new IntPtr(2712129040));
        System.Collections.Generic.List<T> val_13 = val_21.FindAll(match:  8040448);
        int val_14 = UnityEngine.Random.Range(min:  0, max:  mem[1152921511613971420]);
        if(mem[1152921511613971420] <= val_14)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_22 = mem[1152921511613971416];
        val_23 = val_25;
        val_22 = val_22 + (val_14 << 2);
        System.Collections.Generic.List<System.Int32> val_15 = new System.Collections.Generic.List<System.Int32>();
        val_29 = 0;
        goto label_20;
        label_24:
        int val_16 = (mem[1152921511613971416] + (val_14) << 2) + 16.IndexOf(value:  typeof(Alphabet2Manager.<>c__DisplayClass147_0).__il2cppRuntimeField_8, startIndex:  0);
        val_21 = val_16;
        if(val_16 >= 0)
        {
                Add(item:  val_21);
        }
        
        val_29 = val_21 + 1;
        label_20:
        if(val_29 < ((mem[1152921511613971416] + (val_14) << 2) + 16 + 8))
        {
            goto label_24;
        }
        
        val_25 = val_23;
        val_24 = UnityEngine.Random.Range(min:  0, max:  1094062064);
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        System.Collections.Generic.KeyValuePair<System.String, System.Int32> val_18 = new System.Collections.Generic.KeyValuePair<System.String, System.Int32>(key:  (mem[1152921511613971416] + (val_14) << 2) + 16, value:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_17) << 2) + 16);
        Add(item:  new System.Collections.Generic.KeyValuePair<System.String, System.Int32>() {Value = val_18.Value});
        val_27 = val_21;
        label_10:
        var val_23 = val_27;
        if((collectionBox + 178) == 0)
        {
            goto label_29;
        }
        
        val_24 = 0;
        label_31:
        val_23 = mem[collectionBox + 88 + 0];
        val_23 = collectionBox + 88 + 0;
        if(val_23 == null)
        {
            goto label_30;
        }
        
        val_24 = val_24 + 1;
        val_23 = (uint)val_24 & 65535;
        if(val_23 < (collectionBox + 178))
        {
            goto label_31;
        }
        
        label_29:
        val_30 = val_27;
        goto label_32;
        label_30:
        var val_19 = (collectionBox + 88) + 0;
        val_23 = val_23 + (((collectionBox + 88 + 0) + 4) << 3);
        val_30 = val_23 + 188;
        label_32:
        if(val_27 != 0)
        {
            goto label_33;
        }
        
        if(val_21 == 0)
        {
            goto label_34;
        }
        
        var val_24 = val_21;
        if((collectionBox + 178) == 0)
        {
            goto label_35;
        }
        
        val_24 = 0;
        label_37:
        val_23 = mem[collectionBox + 88 + 0];
        val_23 = collectionBox + 88 + 0;
        if(val_23 == null)
        {
            goto label_36;
        }
        
        val_24 = val_24 + 1;
        val_23 = (uint)val_24 & 65535;
        if(val_23 < (collectionBox + 178))
        {
            goto label_37;
        }
        
        label_35:
        val_31 = val_21;
        val_32 = val_31;
        goto label_38;
        label_36:
        var val_20 = (collectionBox + 88) + 0;
        val_31 = val_21;
        val_24 = val_24 + (((collectionBox + 88 + 0) + 4) << 3);
        val_32 = val_24 + 188;
        label_38:
        label_34:
        if(0 == 0)
        {
                return;
        }
    
    }
    public void QAHACK_GetTile()
    {
        WordRegion val_1 = WordRegion.instance;
        int val_2 = this.currentLineWord;
        if(0 <= val_2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_3 = 0;
        val_3 = val_3 + (val_2 << 2);
        this.onWordRegionWordFound(wordCompleted:  (0 + (val_2) << 2) + 16 + 12);
    }
    public void QAHACK_AddTile()
    {
        this.nextLevelWithTile = 0;
        this.onWordRegionLoaded();
    }
    public void QAHACK_FillBoxAndCollect()
    {
        this.FillCollectionBoxAndShow();
    }
    public void QAHACK_CompleteCurrentCollection()
    {
        string val_4;
        string val_6;
        var val_7;
        System.Collections.Generic.List<System.String> val_2 = this.AlphabetCollections.Item[currentCollectionIndex];
        val_6 = this.AlphabetCollections;
        List.Enumerator<T> val_3 = GetEnumerator();
        goto label_3;
        label_7:
        val_6 = val_4;
        val_7 = 0;
        goto label_4;
        label_6:
        this.CollectTileFromBox(word:  val_6, letterIndex:  0);
        val_7 = 1;
        label_4:
        if(val_7 < (val_4 + 8))
        {
            goto label_6;
        }
        
        label_3:
        if(MoveNext() == true)
        {
            goto label_7;
        }
        
        Dispose();
    }
    public void QAHACK_SampleTileCollection()
    {
        bool val_5;
        var val_6;
        val_5 = static_value_021FC0EF;
        if(val_5 != true)
        {
                val_5 = true;
        }
        
        System.Collections.Generic.List<System.String> val_1 = this.currentCollectionBox;
        val_5.Clear();
        System.Collections.Generic.List<System.String> val_2 = this.currentCollectionProgress;
        val_5.Clear();
        val_6 = null;
        val_6 = null;
        System.Decimal.Powers10.__il2cppRuntimeField_10.currentCollectionRewardBonus = new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10};
        System.Collections.IEnumerator val_3 = this.QAHACK_SampleLoop();
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  -1582237872);
    }
    private System.Collections.IEnumerator QAHACK_SampleLoop()
    {
        object val_1 = new System.Object();
        typeof(Alphabet2Manager.<QAHACK_SampleLoop>d__153).__il2cppRuntimeField_8 = 0;
        typeof(Alphabet2Manager.<QAHACK_SampleLoop>d__153).__il2cppRuntimeField_10 = this;
    }
    private void Start()
    {
        var val_11;
        var val_12;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_2 = new System.Action<Result>(object:  -1582011824, method:  new IntPtr(2712929424));
        System.Delegate val_3 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_11 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_11 != 0)
        {
                if(val_11 == null)
        {
            goto label_6;
        }
        
        }
        
        val_11 = 0;
        label_6:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_11;
        WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_5 = new System.Action<Result>(object:  -1582011824, method:  new IntPtr(2712930448));
        System.Delegate val_6 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10, b:  7401472);
        val_12 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10;
        if(val_12 != 0)
        {
                if(val_12 == null)
        {
            goto label_10;
        }
        
        }
        
        val_12 = 0;
        label_10:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10 = val_12;
        NotificationCenter val_7 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1582011824, name:  1799422256);
        GameBehavior val_8 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2100700048) == 0)
        {
                return;
        }
        
        this.ParseAlphabetData();
    }
    private void OnDestroy()
    {
        var val_8;
        var val_9;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_2 = new System.Action<Result>(object:  -1581899824, method:  new IntPtr(2712929424));
        System.Delegate val_3 = System.Delegate.Remove(source:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, value:  7401472);
        val_8 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_8 != 0)
        {
                if(val_8 == null)
        {
            goto label_6;
        }
        
        }
        
        val_8 = 0;
        label_6:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_8;
        WordPets.WPTDataParser val_4 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_5 = new System.Action<Result>(object:  -1581899824, method:  new IntPtr(2712930448));
        System.Delegate val_6 = System.Delegate.Remove(source:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10, value:  7401472);
        val_9 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10;
        if(val_9 != 0)
        {
                if(val_9 == null)
        {
            goto label_10;
        }
        
        }
        
        val_9 = 0;
        label_10:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_10 = val_9;
        NotificationCenter val_7 = NotificationCenter.DefaultCenter;
        0.RemoveObserver(observer:  -1581899824, name:  1799422256);
    }
    private void OnLocalize()
    {
        bool val_8 = static_value_021FC0F3;
        if(val_8 != true)
        {
                val_8 = true;
        }
        
        string val_1 = this.currentLanguage;
        GameBehavior val_2 = App.getBehavior;
        string val_3 = 0.GetCurrentLanguage();
        if((val_8.Equals(value:  null)) == true)
        {
                return;
        }
        
        GameBehavior val_5 = App.getBehavior;
        if(0 == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2100700048) == 0)
        {
                return;
        }
        
        this.ParseAlphabetData();
    }
    private void ParseAlphabetData()
    {
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        string val_42;
        var val_43;
        val_38 = null;
        val_38 = null;
        val_39 = 1152921504892043264;
        GameBehavior val_1 = App.getBehavior;
        string val_2 = 0.GetCurrentLanguage();
        bool val_3 = Alphabet2Manager.supportLangs.Contains(item:  null);
        if(val_3 != false)
        {
                System.Collections.Generic.List<System.String> val_4 = val_3.currentCollectionBox;
            val_40 = mem[val_3 + 12];
            val_40 = val_3 + 12;
            if(val_40 == 0)
        {
                System.Collections.Generic.List<System.String> val_5 = val_40.currentCollectionProgress;
            val_40 = mem[val_3 + 12 + 12];
            val_40 = val_3 + 12 + 12;
            if(val_40 == 0)
        {
                GameBehavior val_6 = App.getBehavior;
            val_40 = 0;
            string val_7 = val_40.GetCurrentLanguage();
            this.currentLanguage = null;
        }
        
        }
        
            string val_8 = this.currentLanguage;
            if((System.String.IsNullOrEmpty(value:  null)) != false)
        {
                val_41 = "en";
            currentLanguage = 1800251696;
        }
        
            string val_10 = currentLanguage;
            string val_11 = -1581699824(-1581699824) + "en";
            UnityEngine.Debug.LogWarning(message:  -1581699824);
            this.AlphabetCollections.Clear();
            this.AlphabetLetterData.Clear();
            string val_12 = WordApp.GamePathName;
            string val_13 = this.currentLanguage;
            string val_14 = -1581689424(-1581689424) + null + -1581689328(-1581689328) + null;
            object val_15 = UnityEngine.Resources.Load<System.Object>(path:  -1581689424);
            val_42 = 0;
            string val_16 = text;
            object val_17 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -1581689424);
            this.AlphabetCollections = "data/umbrella/";
            string val_18 = WordApp.GamePathName;
            string val_19 = this.currentLanguage;
            string val_20 = -1581689424(-1581689424) + null + -1581688192(-1581688192) + null;
            object val_21 = UnityEngine.Resources.Load<System.Object>(path:  -1581689424);
            string val_22 = text;
            typeof(System.Char[]).__il2cppRuntimeField_10 = 10;
            val_43 = 0;
            System.String[] val_23 = Split(separator:  478563824);
            val_39 = 1152921511609949408;
            if(("data/umbrella/".__il2cppRuntimeField_C.currentCollectionIndex) < this.AlphabetCollections.Count)
        {
                return;
        }
        
            int val_30 = this.AlphabetCollections.Count;
            if(val_30 < 1)
        {
                return;
        }
        
            int val_31 = val_30.currentCollectionIndex;
            val_31.currentCollectionIndex = this.AlphabetCollections.Count;
            string val_34 = val_31.currentCollectionIndex.ToString();
            string val_35 = -1581670672(-1581670672) + -1581658376(-1581658376);
            UnityEngine.Debug.LogWarning(message:  -1581670672);
            return;
        }
        
        GameBehavior val_36 = App.getBehavior;
        string val_37 = 0.GetCurrentLanguage();
        typeof(System.Object[]).__il2cppRuntimeField_10 = 0;
        UnityEngine.Debug.LogErrorFormat(format:  -1581670496, args:  472754880);
    }
    private void Instance_OnSceneLoaded(SceneType obj)
    {
        UnityEngine.Events.UnityAction val_16 = 35635445;
        if(obj != 2)
        {
                return;
        }
        
        val_16 = 1152921504886931456;
        WordRegion val_1 = WordRegion.instance;
        if(0 == 0)
        {
                return;
        }
        
        if(this.isAvailable == false)
        {
                return;
        }
        
        bool val_4 = this.hasDataLoaded;
        if(val_4 == false)
        {
                return;
        }
        
        if(val_4.canAddGameplayTile == false)
        {
                return;
        }
        
        WordRegion val_6 = WordRegion.instance;
        System.Action val_7 = new System.Action(object:  -1581499520, method:  new IntPtr(2713437632));
        0.addOnLevelLoadCompleteAction(callback:  7454720);
        WordRegion val_8 = WordRegion.instance;
        System.Action<System.Boolean, System.String, LineWord, Cell> val_9 = new System.Action<System.Boolean, System.String, LineWord, Cell>(object:  -1581499520, method:  new IntPtr(2713438656));
        0.addOnPreprocessPlayerTurnAction(callback:  7614464);
        WordRegion val_10 = WordRegion.instance;
        System.Action<twelvegigs.storage.JsonDictionary> val_11 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  -1581499520, method:  new IntPtr(2713439680));
        0.addOnWordFoundAction(callback:  7401472);
        WordRegion val_12 = WordRegion.instance;
        System.Action<UnityEngine.Vector3> val_13 = new System.Action<UnityEngine.Vector3>(object:  -1581499520, method:  new IntPtr(2713440704));
        0.addOnHintUsedAtLocation(callback:  7401472);
        MainController val_14 = MainController.instance;
        val_16 = null;
        val_16 = new UnityEngine.Events.UnityAction(object:  -1581499520, method:  new IntPtr(2713442752));
        1.AddListener(call:  162246656);
        this.isLevelCompleteListenerAdded = true;
    }
    private void Instance_OnSceneUnloaded(SceneType obj)
    {
        UnityEngine.Events.UnityAction val_5;
        if(this.isLevelCompleteListenerAdded == false)
        {
                return;
        }
        
        val_5 = 1152921504885600256;
        MainController val_1 = MainController.instance;
        if(0 != 0)
        {
                MainController val_3 = MainController.instance;
            val_5 = null;
            val_5 = new UnityEngine.Events.UnityAction(object:  -1581379328, method:  new IntPtr(2713442752));
            1.RemoveListener(call:  162246656);
        }
        
        this.isLevelCompleteListenerAdded = false;
    }
    private void FillCollectionBoxRandomly(int lettersToCollect)
    {
        bool val_4;
        var val_5;
        int val_4 = lettersToCollect;
        val_4 = static_value_021FC0F7;
        if(val_4 != true)
        {
                val_4 = true;
        }
        
        System.Collections.Generic.List<System.String> val_1 = this.currentCollectionBox;
        val_5 = val_4;
        val_5.Clear();
        if(val_4 < 1)
        {
                return;
        }
        
        do
        {
            System.Collections.Generic.List<System.String> val_2 = this.currentCollectionBox;
            val_5 = val_5;
            string val_3 = this.PickNextCollectionLetter();
            val_5.Add(item:  -1581263232);
            val_4 = val_4 - 1;
        }
        while(val_5 != 0);
    
    }
    private void FillCollectionBoxAndShow()
    {
        this.FillCollectionBoxRandomly(lettersToCollect:  this.tilesPerCollectionBox);
        GameBehavior val_1 = App.getBehavior;
        mem[36] = 0;
    }
    private bool IsAlphabetTileReady()
    {
        int val_1 = this.nextLevelWithTile;
        int val_7 = val_1;
        int val_2 = val_1.lastLevelWithTile;
        int val_3 = val_2.minLevelsPerTile;
        val_7 = val_7 - val_2;
        int val_5 = UnityEngine.Mathf.Clamp(value:  val_7, min:  val_3, max:  val_3.maxLevelsPerTile);
        int val_6 = val_5.levelsLapsedSinceTileSpawned;
        if(val_6 >= val_5)
        {
                return true;
        }
        
        return val_6.inFTUX;
    }
    private bool IsPetAlphabetTileReady()
    {
        var val_10;
        GameBehavior val_1 = App.getBehavior;
        val_10 = 0;
        if(0 == 0)
        {
                return (bool)val_10;
        }
        
        val_10 = 0;
        float val_2 = WADPetsManager.GetLevelCurveModifier(ability:  3);
        if(0 <= 0)
        {
                return (bool)val_10;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_10 = 1;
        if((-1929661328) == 0)
        {
                return (bool)val_10;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Tracking_HasAlphabetTile();
        if((3 * 100f.Equals(obj:  (float)UnityEngine.Random.Range(min:  0, max:  100))) == true)
        {
                return (bool)val_10;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Tracking_HasBonusAlphabetTile();
        return (bool)val_10;
    }
    private void OnLevelComplete()
    {
        int val_1 = this.levelsLapsedSinceTileSpawned;
        val_1.levelsLapsedSinceTileSpawned = val_1 + 1;
    }
    private void onWordRegionLoaded()
    {
        int val_35;
        Alphabet2Manager val_69;
        bool val_70;
        var val_71;
        bool val_72;
        var val_73;
        float val_74;
        var val_75;
        System.Predicate<LineWord> val_77;
        string val_78;
        val_69 = this;
        string val_1 = this.currentCollectionLetter;
        bool val_2 = System.String.IsNullOrEmpty(value:  null);
        if(val_2 == true)
        {
            goto label_2;
        }
        
        bool val_3 = this.IsCurrentLevelWithTile;
        if(val_3 == false)
        {
            goto label_2;
        }
        
        val_70 = 1152921504886931456;
        WordRegion val_5 = WordRegion.instance;
        if(val_3.currentLineWord >= 0)
        {
            goto label_15;
        }
        
        WordRegion val_7 = WordRegion.instance;
        val_71 = 0;
        int val_8 = this.currentLineWord;
        if(0 <= val_8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_69 = 0;
        val_69 = val_69 + (val_8 << 2);
        if(this.currentCell >= ((0 + (val_8) << 2) + 16 + 20 + 12))
        {
            goto label_15;
        }
        
        UnityEngine.GameObject val_9 = (0 + (val_8) << 2) + 16 + 20 + 12.AlphabetTileObjectPrefab;
        WordRegion val_10 = WordRegion.instance;
        int val_11 = this.currentLineWord;
        if(0 <= val_11)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_70 = 0;
        val_70 = val_70 + (val_11 << 2);
        int val_12 = val_70.currentCell;
        if(((0 + (val_11) << 2) + 16 + 20 + 12) <= val_12)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_71 = (0 + (val_11) << 2) + 16 + 20 + 8;
        val_71 = val_71 + (val_12 << 2);
        val_70 = 0;
        UnityEngine.Transform val_13 = ((0 + (val_11) << 2) + 16 + 20 + 8 + (val_12) << 2) + 16.transform;
        object val_14 = UnityEngine.Object.Instantiate<System.Object>(original:  (0 + (val_8) << 2) + 16 + 20 + 12, parent:  ((0 + (val_11) << 2) + 16 + 20 + 8 + (val_12) << 2) + 16);
        this.currentAlphabetTileObject = (0 + (val_8) << 2) + 16 + 20 + 12;
        string val_15 = (0 + (val_8) << 2) + 16 + 20 + 12.lastTileType;
        if((System.String.op_Equality(a:  (0 + (val_8) << 2) + 16 + 20 + 12, b:  -1580726208)) != false)
        {
                WADPets.WADPet val_17 = WADPetsManager.GetPetByAbility(ability:  3);
            val_70 = 3.IsActive();
        }
        
        object val_19 = this.currentAlphabetTileObject.GetComponent<System.Object>();
        this.currentAlphabetTileObject.Init(showPet:  val_70);
        goto label_56;
        label_2:
        bool val_20 = val_2.IsAlphabetTileReady();
        val_72 = val_20;
        if(val_20.IsPetAlphabetTileReady() == false)
        {
                return;
        }
        
        val_73 = 1152921504886931456;
        WordRegion val_22 = WordRegion.instance;
        val_74 = 1152921504913342464;
        val_71 = 0;
        val_75 = null;
        val_75 = null;
        val_77 = Alphabet2Manager.<>c.<>9__165_0;
        if(val_77 == 0)
        {
                val_77 = null;
            val_77 = new System.Predicate<ZooTile>(object:  Alphabet2Manager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2714246288));
            val_73 = val_73;
            val_69 = val_69;
            val_72 = val_72;
            Alphabet2Manager.<>c.<>9__165_0 = val_77;
        }
        
        if((val_71.Exists(match:  8040448)) == true)
        {
                return;
        }
        
        string val_25 = this.PickNextCollectionLetter();
        this.currentCollectionLetter = -1580686768;
        string val_26 = this.currentCollectionLetter;
        if((System.String.IsNullOrEmpty(value:  -1580686768)) == true)
        {
                return;
        }
        
        WordRegion val_28 = WordRegion.instance;
        System.Collections.Generic.List<System.Int32> val_29 = 0.getAvailableLineIndices;
        if(0 == 0)
        {
                return;
        }
        
        RandomSet val_30 = null;
        val_71 = val_30;
        val_30 = new RandomSet();
        WordRegion val_31 = WordRegion.instance;
        val_74 = val_73;
        System.Collections.Generic.List<System.Int32> val_32 = 0.getAvailableLineIndices;
        List.Enumerator<T> val_33 = GetEnumerator();
        label_55:
        if(MoveNext() == false)
        {
            goto label_53;
        }
        
        add(item:  val_35, weight:  null);
        goto label_55;
        label_15:
        currentCollectionLetter = 1098586544;
        goto label_56;
        label_53:
        Dispose();
        int val_36 = roll(unweighted:  false);
        val_36.currentLineWord = val_36;
        val_36.currentCell = 0;
        UnityEngine.GameObject val_37 = val_36.AlphabetTileObjectPrefab;
        val_70 = val_36;
        WordRegion val_38 = WordRegion.instance;
        int val_39 = this.currentLineWord;
        if(0 <= val_39)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_72 = 0;
        val_72 = val_72 + (val_39 << 2);
        int val_40 = val_72.currentCell;
        if(((0 + (val_39) << 2) + 16 + 20 + 12) <= val_40)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_73 = (0 + (val_39) << 2) + 16 + 20 + 8;
        val_73 = val_73 + (val_40 << 2);
        UnityEngine.Transform val_41 = ((0 + (val_39) << 2) + 16 + 20 + 8 + (val_40) << 2) + 16.transform;
        object val_42 = UnityEngine.Object.Instantiate<System.Object>(original:  val_70, parent:  ((0 + (val_39) << 2) + 16 + 20 + 8 + (val_40) << 2) + 16);
        this.currentAlphabetTileObject = val_70;
        if(val_72 == true)
        {
                "pet" = "regular";
        }
        
        lastTileType = -1588662032;
        object val_43 = this.currentAlphabetTileObject.GetComponent<System.Object>();
        this.currentAlphabetTileObject.Init(showPet:  val_72 ^ 1);
        if((val_72 != true) && (this.OnPetAlphabetTileSpawned != 0))
        {
                this.OnPetAlphabetTileSpawned.Invoke();
            this.OnPetAlphabetTileSpawned = 0;
        }
        
        if(this.OnPetAlphabetTileSpawned.inFTUX != false)
        {
                if(val_72 != false)
        {
                WordRegion val_46 = WordRegion.instance;
            int val_47 = this.currentLineWord;
            if(0 <= val_47)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_74 = 0;
            val_74 = val_74 + (val_47 << 2);
            WordRegion val_48 = WordRegion.instance;
            int val_49 = this.currentLineWord;
            if(0 <= val_49)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_75 = 0;
            val_75 = val_75 + (val_49 << 2);
            val_70 = mem[(0 + (val_49) << 2) + 16 + 20];
            val_70 = (0 + (val_49) << 2) + 16 + 20;
            int val_50 = val_75.currentCell;
            if(((0 + (val_49) << 2) + 16 + 20 + 12) <= val_50)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_76 = (0 + (val_49) << 2) + 16 + 20 + 8;
            val_76 = val_76 + (val_50 << 2);
            UnityEngine.Transform val_51 = ((0 + (val_49) << 2) + 16 + 20 + 8 + (val_50) << 2) + 16.transform;
            System.Collections.IEnumerator val_52 = this.ShowTooltip(word:  (0 + (val_47) << 2) + 16, letterTransform:  ((0 + (val_49) << 2) + 16 + 20 + 8 + (val_50) << 2) + 16);
            UnityEngine.Coroutine val_53 = this.StartCoroutine(routine:  -1580686768);
        }
        
            this.FillCollectionBoxRandomly(lettersToCollect:  this.tilesPerCollectionBox - 1);
        }
        
        int val_55 = PlayingLevel.GetCurrentPlayerLevelNumber();
        val_55.lastLevelWithTile = val_55;
        val_55.collectedLastLevel = false;
        string val_56 = val_55.currentCollectionLetter;
        Rarity val_57 = this.GetRarity(letter:  val_55);
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        lastLevelWithTileRarity = 306335744;
        val_78 = 0;
        levelsLapsedSinceTileSpawned = 0;
        GameplayMode val_58 = PlayingLevel.CurrentGameplayMode;
        this.lastGameModeWithTile = 0;
        GameplayMode val_59 = this.lastGameModeWithTile;
        if(0 == 4)
        {
                twelvegigs.Autopilot.AutopilotManager val_60 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            string val_62 = (public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8).ToString();
            val_78 = (public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8);
        }
        
        (public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8).lastGameModeSecondayId = val_78;
        int val_63 = (public static CategoryPacksManager MonoSingleton<CategoryPacksManager>::get_Instance().__il2cppRuntimeField_28 + 8).lastLevelWithTile;
        int val_64 = val_63.minLevelsPerTile;
        int val_66 = val_64.maxLevelsPerTile + 1;
        int val_67 = UnityEngine.Random.Range(min:  val_64, max:  val_66);
        val_66 = val_67 + val_63;
        val_67.nextLevelWithTile = val_66;
        label_56:
        Player val_68 = App.Player;
        0.SaveState();
    }
    private System.Collections.IEnumerator ShowTooltip(LineWord word, UnityEngine.Transform letterTransform)
    {
        typeof(Alphabet2Manager.<ShowTooltip>d__166).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(Alphabet2Manager.<ShowTooltip>d__166).__il2cppRuntimeField_10 = word;
            typeof(Alphabet2Manager.<ShowTooltip>d__166).__il2cppRuntimeField_14 = this;
        }
        else
        {
                mem[20] = this;
            mem[16] = word;
        }
        
        typeof(Alphabet2Manager.<ShowTooltip>d__166).__il2cppRuntimeField_18 = letterTransform;
    }
    private string PickNextCollectionLetter()
    {
        var val_15;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        RandomSet val_2 = new RandomSet();
        Dictionary.Enumerator<TKey, TValue> val_3 = GetEnumerator();
        goto label_6;
        label_11:
        object val_5 = new System.Object();
        typeof(Alphabet2Manager.<>c__DisplayClass167_0).__il2cppRuntimeField_8 = 0;
        typeof(Alphabet2Manager.<>c__DisplayClass167_0).__il2cppRuntimeField_C = ???;
        System.TimeType val_7 = mem[1152921511616351780].Item[this.currentCollectionIndex];
        System.Predicate<ZooTile> val_8 = new System.Predicate<ZooTile>(object:  306814976, method:  new IntPtr(2714510224));
        if((mem[1152921511616351780].Exists(match:  8040448)) != false)
        {
                add(item:  0, weight:  (float)UnityEngine.Mathf.RoundToInt(f:  (typeof(Alphabet2Manager.<>c__DisplayClass167_0).__il2cppRuntimeField_C) * 100f));
            Add(item:  0);
        }
        
        label_6:
        if(0.MoveNext() == true)
        {
            goto label_11;
        }
        
        0.Dispose();
        val_15 = "";
        int val_13 = roll(unweighted:  false);
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_15 = mem[(System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_13) << 2) + 16];
        val_15 = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_13) << 2) + 16;
        clear();
    }
    private void OnPreprocessPlayerTurnAction(bool hintUsage, string wordEntered, LineWord lineWord, Cell cell)
    {
        var val_10;
        bool val_11;
        var val_12;
        val_10 = 35635454;
        val_11 = static_value_021FC0FE;
        if(val_11 != true)
        {
                val_11 = true;
        }
        
        string val_1 = this.currentCollectionLetter;
        if((System.String.IsNullOrEmpty(value:  1)) == true)
        {
                return;
        }
        
        if(this.IsCurrentLevelWithTile == false)
        {
                return;
        }
        
        WordRegion val_4 = WordRegion.instance;
        int val_5 = this.currentLineWord;
        if(val_5 < 0)
        {
                return;
        }
        
        val_10 = val_5.currentLineWord;
        val_12 = 0;
        if(val_10 >= 0)
        {
                return;
        }
        
        bool val_7 = System.String.IsNullOrEmpty(value:  wordEntered);
        if(val_7 == true)
        {
                return;
        }
        
        val_12 = 0;
        int val_8 = val_7.currentLineWord;
        if(0 <= val_8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_10 = 0;
        val_10 = val_10 + (val_8 << 2);
        val_10 = mem[(0 + (val_8) << 2) + 16 + 12];
        val_10 = (0 + (val_8) << 2) + 16 + 12;
        bool val_9 = val_10.Equals(value:  wordEntered);
        if(val_9 == true)
        {
                val_9 = 1;
            mem[20] = val_9;
        }
    
    }
    private void onWordRegionWordFound(string wordCompleted)
    {
        var val_10;
        bool val_11;
        val_10 = 35635455;
        val_11 = static_value_021FC0FF;
        if(val_11 != true)
        {
                val_11 = true;
        }
        
        string val_1 = this.currentCollectionLetter;
        if((System.String.IsNullOrEmpty(value:  1)) == true)
        {
                return;
        }
        
        bool val_3 = this.IsCurrentLevelWithTile;
        if(val_3 == false)
        {
                return;
        }
        
        int val_4 = val_3.currentLineWord;
        if(val_4 < 0)
        {
                return;
        }
        
        val_10 = val_4.currentLineWord;
        WordRegion val_6 = WordRegion.instance;
        if(val_10 >= 0)
        {
                return;
        }
        
        WordRegion val_7 = WordRegion.instance;
        int val_8 = this.currentLineWord;
        if(0 <= val_8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_10 = 0;
        val_10 = val_10 + (val_8 << 2);
        if(((0 + (val_8) << 2) + 16 + 12.Equals(value:  wordCompleted)) != false)
        {
                this.CollectCurrentLetter();
            return;
        }
        
        this.ShiftCurrentLetter();
    }
    private void onWordRegionHintUsed(UnityEngine.Vector3 location)
    {
        float val_12;
        float val_13;
        bool val_14;
        var val_16;
        val_12 = location.z;
        val_13 = location.y;
        val_14 = static_value_021FC100;
        if(val_14 != true)
        {
                val_14 = true;
        }
        
        string val_1 = this.currentCollectionLetter;
        if((System.String.IsNullOrEmpty(value:  1)) == true)
        {
                return;
        }
        
        if(this.IsCurrentLevelWithTile == false)
        {
                return;
        }
        
        if(this.currentAlphabetTileObject == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_5 = this.currentAlphabetTileObject.transform;
        UnityEngine.Vector3 val_6 = position;
        if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3(), rhs:  new UnityEngine.Vector3() {x = location.x, y = val_13, z = val_12})) == false)
        {
                return;
        }
        
        WordRegion val_8 = WordRegion.instance;
        int val_9 = this.currentLineWord;
        if(0 <= val_9)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_12 = 0;
        val_12 = val_12 + (val_9 << 2);
        val_13 = 1152921504913342464;
        val_16 = null;
        val_16 = null;
        val_12 = Alphabet2Manager.<>c.<>9__170_0;
        if(val_12 == 0)
        {
                val_12 = null;
            val_12 = new System.Predicate<ZooTile>(object:  Alphabet2Manager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2714890368));
            Alphabet2Manager.<>c.<>9__170_0 = val_12;
        }
        
        if(((0 + (val_9) << 2) + 16 + 20.Exists(match:  8040448)) != false)
        {
                this.ShiftCurrentLetter();
            return;
        }
        
        this.CollectCurrentLetter();
    }
    private void CollectCurrentLetter()
    {
        System.Collections.Generic.List<System.String> val_1 = this.currentCollectionBox;
        string val_2 = this.currentCollectionLetter;
        0.Add(item:  0);
        bool val_3 = this.IsCollectionBoxFull();
        if(val_3 == true)
        {
                val_3 = this.OnAlphabetCollectionCompleted;
        }
        
        if(val_3 != 0)
        {
            goto label_2;
        }
        
        label_13:
        if(this.OnAlphabetTileCollected != 0)
        {
                this.OnAlphabetTileCollected.Invoke();
        }
        
        GameBehavior val_4 = App.getBehavior;
        int val_6 = PlayingLevel.GetCurrentPlayerLevelNumber();
        val_6.lastLevelWithTile = val_6;
        val_6.collectedLastLevel = true;
        string val_7 = val_6.currentCollectionLetter;
        Rarity val_8 = this.GetRarity(letter:  val_6);
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        lastLevelWithTileRarity = 306335744;
        lastTileType = -1588662032;
        currentCollectionLetter = 1098586544;
        Player val_9 = App.Player;
        0.SaveState();
        return;
        label_2:
        val_3.Invoke();
        goto label_13;
    }
    private void ShiftCurrentLetter()
    {
        var val_17;
        System.Predicate<ZooTile> val_18;
        val_17 = 1152921504886931456;
        WordRegion val_1 = WordRegion.instance;
        if(1 != 0)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  this.currentAlphabetTileObject);
        this.currentAlphabetTileObject = 0;
        WordRegion val_2 = WordRegion.instance;
        int val_3 = this.currentLineWord;
        if(0 <= val_3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_17 = 0;
        val_17 = val_17 + (val_3 << 2);
        val_18 = null;
        val_18 = new System.Predicate<ZooTile>(object:  -1579795136, method:  new IntPtr(2715146112));
        int val_5 = (0 + (val_3) << 2) + 16 + 20.FindIndex(match:  8040448);
        val_5.currentCell = val_5;
        int val_6 = val_5.currentCell;
        if(val_6 > 1)
        {
                UnityEngine.GameObject val_7 = val_6.AlphabetTileObjectPrefab;
            WordRegion val_8 = WordRegion.instance;
            int val_9 = this.currentLineWord;
            if(0 <= val_9)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_18 = 0;
            val_18 = val_18 + (val_9 << 2);
            val_17 = mem[(0 + (val_9) << 2) + 16 + 20];
            val_17 = (0 + (val_9) << 2) + 16 + 20;
            int val_10 = val_18.currentCell;
            if(((0 + (val_9) << 2) + 16 + 20 + 12) <= val_10)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_19 = (0 + (val_9) << 2) + 16 + 20 + 8;
            val_19 = val_19 + (val_10 << 2);
            UnityEngine.Transform val_11 = ((0 + (val_9) << 2) + 16 + 20 + 8 + (val_10) << 2) + 16.transform;
            val_18 = ((0 + (val_9) << 2) + 16 + 20 + 8 + (val_10) << 2) + 16;
            object val_12 = UnityEngine.Object.Instantiate<System.Object>(original:  val_6, parent:  val_18);
            this.currentAlphabetTileObject = val_6;
            object val_13 = val_6.GetComponent<System.Object>();
            string val_14 = val_6.lastTileType;
            val_6.Init(showPet:  System.String.op_Equality(a:  val_6, b:  -1580726208));
        }
        else
        {
                currentCollectionLetter = 1098586544;
        }
        
        Player val_16 = App.Player;
        0.SaveState();
    }
    private Alphabet2Manager.Rarity GetRarity(float rarityValue)
    {
        if(<0)
        {
                return;
        }
        
        0 = 1;
        if(<0)
        {
                return;
        }
        
        if(<0)
        {
                3 = 2;
        }
    
    }
    private decimal GetRewardByRarity(Alphabet2Manager.Rarity rarity)
    {
        var val_3;
        var val_4;
        if(R2 <= 3)
        {
                val_3 = mem[10974072 + (R2) << 2];
            val_3 = 10974072 + (R2) << 2;
            var val_1 = 10974072 + val_3;
            if(R2 == 3)
        {
                10974072 = 10974072;
            10974072 = 10974072;
            10974072 = 10974072 & (((int)R8) >> 10974072);
            10974072 = 10974072 & ((((10974072 & ((int)R8) >> 10974072)) << (32-as. 
            
        
        
        
        
        
           
        )) | (((10974072 & ((int)R8) >> 10974072)) << as. 
            
        
        
        
        
        
           
        ));
        }
        
            Rarity val_2 = rarity + 28;
            return new System.Decimal() {flags = 1152921511617194624, hi = System.Decimal.__il2cppRuntimeField_cctor_finished};
        }
        
        val_4 = null;
        val_4 = null;
        return new System.Decimal() {flags = 1152921511617194624, hi = System.Decimal.__il2cppRuntimeField_cctor_finished};
    }
    public Alphabet2Manager()
    {
        var val_7;
        this.tilesPerCollectionBox = 5;
        val_7 = null;
        val_7 = null;
        decimal val_1 = new System.Decimal(value:  3);
        decimal val_2 = new System.Decimal(value:  5);
         = new System.Decimal(value:  15);
        this.currentVideoRewardLetter = "";
        System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile> val_4 = new System.Collections.Generic.Dictionary<System.Int32, WordPets.WPTLetterTile>();
        this.AlphabetCollections = null;
        System.Collections.Generic.Dictionary<System.String, System.Single> val_5 = new System.Collections.Generic.Dictionary<System.String, System.Single>();
        this.AlphabetLetterData = null;
        System.Action val_6 = new System.Action(object:  0, method:  new IntPtr(2715499520));
        this.OnTileClickAction = null;
    }
    private static Alphabet2Manager()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(null != 0)
        {
                Add(item:  1800251696);
        }
        else
        {
                Add(item:  1800251696);
        }
        
        Add(item:  -2101987568);
        Alphabet2Manager.supportLangs = null;
    }
    private int <GetRandomSeededPositionsForCollection>b__147_0(string x)
    {
        return this.GetRarity(letter:  x);
    }
    private bool <ShiftCurrentLetter>b__172_0(Cell x)
    {
        if(x.isShown != false)
        {
                return false;
        }
        
        WordRegion val_1 = WordRegion.instance;
        int val_2 = this.currentLineWord;
        if(0 <= val_2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_5 = 0;
        val_5 = val_5 + (val_2 << 2);
        int val_3 = (0 + (val_2) << 2) + 16 + 20.IndexOf(item:  x);
        if(val_3 > val_3.currentCell)
        {
                0 = 1;
        }
        
        return true;
    }

}
