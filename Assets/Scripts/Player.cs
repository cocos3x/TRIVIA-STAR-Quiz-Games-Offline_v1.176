using UnityEngine;
public class Player : ScriptableObject
{
    // Fields
    public bool isNew;
    private bool <forceUpdateFromServer>k__BackingField;
    private decimal prevBalance;
    private bool playerCreated;
    private bool playerLoaded;
    public bool adExcludedNetworkPurchaser;
    public int totalRevenue;
    protected string country;
    protected PlayerProperties properties;
    public string id;
    public string uuid;
    public string support;
    protected decimal _credits;
    protected int _stars;
    protected int _bonusRewardPoints;
    protected int _food;
    private bool synchedGoldenCurrency;
    protected int _gems;
    protected decimal _experience;
    public System.DateTime created_at;
    public string playerBucket;
    private const string key_created = "player_client_created";
    public int clientCreated;
    protected int _level;
    public int dcStars;
    public System.DateTime last_daily_credits;
    public int last_daily_amount;
    public int no_ads;
    protected int restoredTransactions;
    protected int lifetimePlays;
    protected string email;
    public System.DateTime last_purchase;
    public string max_item_purchased;
    public string last_item_purchased;
    public float lastItemPrice;
    protected int levelsRemoved;
    public string network_purchaser;
    protected float total_purchased;
    protected int num_purchase;
    protected int num_ad_clicks;
    protected float transactionsAverageAmount;
    protected decimal totalFreeCreditsCollected;
    protected float _avg_hours_played;
    protected string _challengeData;
    protected float lastPurchasePrice;
    protected bool samePurchases;
    protected bool isHacker;
    protected string hackerType;
    protected bool isTroll;
    protected System.Collections.Generic.Dictionary<string, string> promotedGames;
    protected System.Collections.Generic.Dictionary<string, System.Decimal> playerStats;
    public bool IsLapsingPurchaser;
    public bool IsLapsingNonPurchaser;
    public System.Action<int> OnCreditsGained;
    public const string hacker_purchase = "Purchase Fraud";
    public const string hacker_time_traveler = "Time Traveler";
    public System.Collections.Generic.List<string> QAHACK_FreeCoinsTrace;
    public System.Collections.Generic.List<string> QAHACK_NonCoinsAwardTrace;
    private static System.Collections.Generic.List<string> NotFreeCreditSources;
    
    // Properties
    public bool forceUpdateFromServer { get; set; }
    public bool networkPurchaserExcludedFromAds { get; }
    public int TotalRevenue { get; set; }
    public string Country { get; set; }
    public PlayerProperties Properties { get; set; }
    public decimal credits { get; }
    public int stars { get; set; }
    public int bonusRewardPoints { get; set; }
    public int food { get; }
    public bool SynchedGoldenCurrency { get; set; }
    public int gems { get; }
    public decimal experience { get; set; }
    public virtual int level { get; set; }
    public bool RemovedAds { get; set; }
    public bool RestoredTransactions { get; set; }
    public int LifetimePlays { get; set; }
    public string Email { get; set; }
    public string MaxItemPurchased { get; set; }
    public string LastItemPurchased { get; set; }
    public float LastItemPrice { get; set; }
    public int LevelsRemoved { get; set; }
    public bool NetworkPurchaser { get; }
    public float TotalPurchase { get; set; }
    public int NumPurchase { get; set; }
    public int NumAdClicks { get; set; }
    public float TransactionsAverageAmount { get; set; }
    public decimal TotalFreeCreditsCollected { get; set; }
    public float avg_hours_btween_played { get; set; }
    public string challengeData { get; set; }
    public float MaxPurchasePrice { get; set; }
    public bool SamePurchases { get; set; }
    public bool IsHacker { get; }
    public string HackerType { get; }
    public bool IsTroll { get; }
    protected string network_promo_json { get; }
    public System.Collections.Generic.Dictionary<string, string> PromotedGames { get; }
    protected string playerStats_json { get; }
    public System.Collections.Generic.Dictionary<string, System.Decimal> PLAYER_STATS { get; set; }
    
    // Methods
    public void Initialize()
    {
        this.Load();
    }
    public bool get_forceUpdateFromServer()
    {
        return (bool)this.<forceUpdateFromServer>k__BackingField;
    }
    public void set_forceUpdateFromServer(bool value)
    {
        this.<forceUpdateFromServer>k__BackingField = value;
    }
    public bool get_networkPurchaserExcludedFromAds()
    {
        if(this.NetworkPurchaser == false)
        {
                return true;
        }
        
        if(this.adExcludedNetworkPurchaser == true)
        {
                0 = 1;
        }
        
        return true;
    }
    public int get_TotalRevenue()
    {
        return (int)this.totalRevenue;
    }
    public void set_TotalRevenue(int value)
    {
        this.totalRevenue = value;
    }
    public string get_Country()
    {
        if((System.String.IsNullOrEmpty(value:  this.country)) == false)
        {
                return;
        }
        
        string val_2 = DeviceIdPlugin.GetCountry();
        if((System.String.IsNullOrEmpty(value:  null)) == true)
        {
                return;
        }
        
        string val_4 = DeviceIdPlugin.GetCountry();
        this.country = 0;
    }
    public void set_Country(string value)
    {
        this.country = value;
    }
    public PlayerProperties get_Properties()
    {
    
    }
    public void set_Properties(PlayerProperties value)
    {
        this.properties = value;
    }
    private decimal ParseCredits()
    {
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1938503680);
        decimal val_2 = System.Decimal.Parse(s:  -1938491656);
        return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
    }
    private decimal ParseExperience()
    {
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1938391584);
        decimal val_2 = System.Decimal.Parse(s:  -1938379544);
        return new System.Decimal() {flags = val_2.flags, hi = val_2.hi, lo = val_2.lo, mid = val_2.mid};
    }
    private void ParsePlayerStats(System.Collections.IDictionary definition)
    {
        string val_4;
        int val_6;
        int val_7;
        int val_8;
        int val_9;
        var val_10;
        var val_11;
        var val_12;
        val_10 = definition;
        if(val_10 == 0)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Decimal> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Decimal>();
        this.playerStats = null;
        val_11 = null;
        val_11 = null;
        val_12 = 0;
        if(((System.Collections.IDictionary.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_11)
        {
                val_10 = 0;
        }
        
        val_12 = val_10;
        Dictionary.Enumerator<TKey, TValue> val_2 = 0.GetEnumerator();
        label_10:
        if(0.MoveNext() == false)
        {
            goto label_5;
        }
        
        decimal val_5 = System.Decimal.Parse(s:  -1938258336);
        this.playerStats.Add(key:  val_4, value:  new System.Decimal() {flags = val_8, hi = val_9, lo = val_6, mid = val_7});
        goto label_10;
        label_5:
        0.Dispose();
    }
    private void ParseNetworkPromo(System.Collections.IDictionary objects)
    {
        string val_4;
        var val_5;
        var val_6;
        var val_7;
        val_5 = objects;
        if(val_5 == 0)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.promotedGames = null;
        val_6 = null;
        val_6 = null;
        val_7 = 0;
        if(((System.Collections.IDictionary.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_6)
        {
                val_5 = 0;
        }
        
        val_7 = val_5;
        Dictionary.Enumerator<TKey, TValue> val_2 = 0.GetEnumerator();
        label_8:
        if(0.MoveNext() == false)
        {
            goto label_5;
        }
        
        this.promotedGames.Add(key:  val_4, value:  null);
        goto label_8;
        label_5:
        0.Dispose();
    }
    public decimal get_credits()
    {
        return new System.Decimal() {flags = -1937997680, hi = R1 + 60};
    }
    public int get_stars()
    {
        return (int)this._stars;
    }
    public void set_stars(int value)
    {
        var val_9;
        this._stars = value;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_9 = public static SLC.Social.Leagues.LeaguesManager MonoSingleton<SLC.Social.Leagues.LeaguesManager>::get_Instance();
        if((-1937797680) != 0)
        {
                SLC.Social.Leagues.LeaguesDataController val_3 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_9 = 0;
            if(0 != 0)
        {
                SLC.Social.Leagues.LeaguesDataController val_5 = SLC.Social.Leagues.LeaguesManager.DAO;
            val_9 = 0;
            SLC.Social.Profile val_6 = val_9.MyProfile;
            if(val_9 != 0)
        {
                SLC.Social.Leagues.LeaguesDataController val_7 = SLC.Social.Leagues.LeaguesManager.DAO;
            SLC.Social.Profile val_8 = 0.MyProfile;
            val_9 = 0;
            mem[112] = value;
        }
        
        }
        
        }
    
    }
    public int get_bonusRewardPoints()
    {
        return (int)this._bonusRewardPoints;
    }
    public void set_bonusRewardPoints(int value)
    {
        this._bonusRewardPoints = value;
    }
    public int get_food()
    {
        return (int)this._food;
    }
    public bool get_SynchedGoldenCurrency()
    {
        return (bool)this.synchedGoldenCurrency;
    }
    public void set_SynchedGoldenCurrency(bool value)
    {
        this.synchedGoldenCurrency = value;
        if(value == false)
        {
                return;
        }
        
        UnityEngine.PlayerPrefs.SetInt(key:  -1937236656, value:  10);
    }
    public int get_gems()
    {
        return (int)this._gems;
    }
    public decimal get_experience()
    {
        return new System.Decimal() {flags = -1936988544, hi = R1 + 96};
    }
    public void set_experience(decimal value)
    {
    
    }
    public virtual int get_level()
    {
        return (int)this._level;
    }
    public virtual void set_level(int value)
    {
        this._level = value;
        SROptions_Player.NotifyPropertyChanged(propertyName:  -1987496192);
    }
    public bool get_RemovedAds()
    {
        int val_1 = this.no_ads;
        val_1 = val_1 - 2;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public void set_RemovedAds(bool value)
    {
        if(value == true)
        {
                1 = 2;
        }
        
        this.no_ads = 2;
    }
    public bool get_RestoredTransactions()
    {
        int val_1 = this.restoredTransactions;
        val_1 = val_1 - 1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public void set_RestoredTransactions(bool value)
    {
        this.restoredTransactions = value;
    }
    public int get_LifetimePlays()
    {
        return (int)this.lifetimePlays;
    }
    public void set_LifetimePlays(int value)
    {
        this.lifetimePlays = value;
    }
    public string get_Email()
    {
    
    }
    public void set_Email(string value)
    {
        this.email = value;
    }
    public string get_MaxItemPurchased()
    {
    
    }
    public void set_MaxItemPurchased(string value)
    {
        this.max_item_purchased = value;
    }
    public string get_LastItemPurchased()
    {
    
    }
    public void set_LastItemPurchased(string value)
    {
        this.last_item_purchased = value;
    }
    public float get_LastItemPrice()
    {
        return (float)S0;
    }
    public void set_LastItemPrice(float value)
    {
        this.lastItemPrice = ;
    }
    public int get_LevelsRemoved()
    {
        return (int)this.levelsRemoved;
    }
    public void set_LevelsRemoved(int value)
    {
        this.levelsRemoved = value;
    }
    public bool get_NetworkPurchaser()
    {
        if(this.network_purchaser != null)
        {
                return this.network_purchaser.Equals(value:  1295406192);
        }
        
        return this.network_purchaser.Equals(value:  1295406192);
    }
    public float get_TotalPurchase()
    {
        return (float)S0;
    }
    public void set_TotalPurchase(float value)
    {
        this.total_purchased = ;
    }
    public int get_NumPurchase()
    {
        return (int)this.num_purchase;
    }
    public void set_NumPurchase(int value)
    {
        this.num_purchase = value;
    }
    public int get_NumAdClicks()
    {
        return (int)this.num_ad_clicks;
    }
    public void set_NumAdClicks(int value)
    {
        this.num_ad_clicks = value;
    }
    public float get_TransactionsAverageAmount()
    {
        return (float)S0;
    }
    public void set_TransactionsAverageAmount(float value)
    {
        this.transactionsAverageAmount = ;
    }
    public decimal get_TotalFreeCreditsCollected()
    {
        return new System.Decimal() {flags = -1933683200, hi = R1 + 212};
    }
    public void set_TotalFreeCreditsCollected(decimal value)
    {
    
    }
    public float get_avg_hours_btween_played()
    {
        return (float)S0;
    }
    public void set_avg_hours_btween_played(float value)
    {
        this._avg_hours_played = ;
    }
    public string get_challengeData()
    {
    
    }
    public void set_challengeData(string value)
    {
        this._challengeData = value;
    }
    public float get_MaxPurchasePrice()
    {
        return (float)S0;
    }
    public void set_MaxPurchasePrice(float value)
    {
        this.lastPurchasePrice = ;
    }
    public bool get_SamePurchases()
    {
        return (bool)this.samePurchases;
    }
    public void set_SamePurchases(bool value)
    {
        this.samePurchases = value;
    }
    public bool get_IsHacker()
    {
        return (bool)this.isHacker;
    }
    public string get_HackerType()
    {
    
    }
    public bool get_IsTroll()
    {
        return (bool)this.isTroll;
    }
    protected string get_network_promo_json()
    {
        return MiniJSON.Json.Serialize(obj:  this.promotedGames);
    }
    public System.Collections.Generic.Dictionary<string, string> get_PromotedGames()
    {
        System.Collections.Generic.Dictionary<System.String, System.String> val_2 = this.promotedGames;
        if(val_2 != 0)
        {
                return;
        }
        
        val_2 = null;
        val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.promotedGames = val_2;
    }
    protected string get_playerStats_json()
    {
        return MiniJSON.Json.Serialize(obj:  this.playerStats);
    }
    public System.Collections.Generic.Dictionary<string, System.Decimal> get_PLAYER_STATS()
    {
    
    }
    public void set_PLAYER_STATS(System.Collections.Generic.Dictionary<string, System.Decimal> value)
    {
        this.playerStats = value;
    }
    public virtual void SoftSave()
    {
        UnityEngine.Debug.LogError(message:  -1931625664);
    }
    protected virtual void Save()
    {
        UnityEngine.Debug.LogError(message:  -1931513504);
    }
    public virtual void AddHardSaves(ref System.Collections.Generic.Dictionary<string, object> incDic)
    {
        UnityEngine.Debug.LogError(message:  -1931397328);
    }
    public void SaveState()
    {
        this.properties.Save(writePrefs:  false);
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public void UpdateData(System.Collections.IDictionary diff)
    {
        Player val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        val_25 = 0;
        val_25 = val_25 + 1;
        val_26 = diff;
        if(diff != 0)
        {
                if((System.String.op_Equality(a:  mem[1152921511265653744], b:  1297836560)) != false)
        {
                val_25 = 0;
            val_25 = val_25 + 1;
            val_27 = diff;
            mem[1152921511265653744] = diff;
        }
        
        }
        
        val_25 = 0;
        val_25 = val_25 + 1;
        val_28 = diff;
        if(diff != 0)
        {
                val_25 = 0;
            val_25 = val_25 + 1;
            val_29 = diff;
            mem[1152921511265653752] = diff;
        }
        
        val_25 = 0;
        val_25 = val_25 + 1;
        val_30 = diff;
        if(diff != 0)
        {
                val_25 = 0;
            val_25 = val_25 + 1;
            val_31 = diff;
            mem[1152921511265653937] = System.Boolean.Parse(value:  diff);
        }
        
        val_25 = 0;
        val_25 = val_25 + 1;
        val_32 = diff;
        if(diff != 0)
        {
                val_25 = 0;
            val_25 = val_25 + 1;
            val_33 = diff;
            if(diff != 0)
        {
                val_25 = 0;
            val_25 = val_25 + 1;
            val_34 = diff;
            mem[1152921511265653940] = diff;
        }
        
        }
        
        val_25 = 0;
        val_25 = val_25 + 1;
        val_35 = diff;
        if(diff != 0)
        {
                val_25 = 0;
            val_25 = val_25 + 1;
            val_36 = diff;
            mem[1152921511265653944] = System.Boolean.Parse(value:  diff);
        }
        
        val_25 = 0;
        val_25 = val_25 + 1;
        val_37 = diff;
        if(diff != 0)
        {
                val_25 = 0;
            val_25 = val_25 + 1;
            val_38 = diff;
            string val_17 = diff.ToLower();
            mem[1152921511265653888] = diff;
        }
        
        val_39 = "client_upgrade";
        val_25 = 0;
        val_25 = val_25 + 1;
        val_40 = diff;
        if(diff != 0)
        {
                val_39 = "client_upgrade";
            val_25 = 0;
            val_25 = val_25 + 1;
            val_41 = diff;
            if((System.Boolean.Parse(value:  diff)) != false)
        {
                UnityEngine.Debug.Log(message:  -1931156256);
            string val_21 = DeviceIdPlugin.GetClientVersion();
            val_25 = this;
            bool val_22 = 0.Equals(value:  -1931156128);
            if((val_22 != false) && (val_22 > false))
        {
                AdsManager.AddAdsWatchedFromVersionUpdate();
        }
        else
        {
                string val_23 = DeviceIdPlugin.GetClientVersion();
            bool val_24 = 0.Equals(value:  -1931156048);
            if((val_24 != false) && (val_24 > false))
        {
                AdsManager.AddPurchaseCooldownFromVersionUpdate();
        }
        
        }
        
        }
        
        }
        
        mem[1152921511265653740].UpdateData(diff:  diff);
        goto this.IsLapsingPurchaser;
    }
    public System.Collections.Generic.Dictionary<string, object> Encode()
    {
        var val_11;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        string val_2 = ToString(format:  1254115712);
        Add(key:  -1931031680, value:  -1931001632);
        string val_3 = DeviceIdPlugin.GetGoogleAdId();
        Add(key:  -1931031568, value:  0);
        string val_4 = DeviceIdPlugin.GetClientVersion();
        Add(key:  -1931031472, value:  0);
        string val_5 = this.Country;
        if((System.String.IsNullOrEmpty(value:  -1930989584)) != true)
        {
                string val_7 = this.Country;
            Add(key:  -1931031376, value:  -1930989584);
        }
        
        val_11 = null;
        Add(key:  -1931027184, value:  this.email);
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1931027104)) != false)
        {
                val_11 = null;
            Add(key:  -1931026992, value:  13152256);
        }
        
        this.properties.mySaver.AddHardSavesToDictionary(refdic: ref  System.Collections.Generic.Dictionary<System.String, System.Object> val_9 = -1931001612);
        this.properties.Encode(jsonPlayer: ref  System.Collections.Generic.Dictionary<System.String, System.Object> val_10 = -1931001612);
    }
    private void Load()
    {
        if((UnityEngine.PlayerPrefs.GetInt(key:  -1930885200, defaultValue:  0)) >= 1)
        {
            
        }
        else
        {
                0 = 1;
        }
        
        this.CreateCustomProperties(isPlayerNew:  true);
        this.SaveState();
        goto typeof(Player).__il2cppRuntimeField_EC;
    }
    protected virtual void ProcessRemainingAttributes(System.Collections.IDictionary diff)
    {
        var val_9;
        string val_10;
        var val_11;
        float val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_9 = this;
        val_10 = 35633089;
        val_11 = "level";
        val_12 = 1152921504683257856;
        val_13 = 0;
        val_13 = val_13 + 1;
        val_14 = diff;
        if(diff == 0)
        {
            goto label_24;
        }
        
        val_11 = "override_user_data";
        val_13 = 0;
        val_13 = val_13 + 1;
        val_15 = diff;
        if(diff == 0)
        {
            goto label_21;
        }
        
        val_11 = "override_user_data";
        val_13 = 0;
        val_13 = val_13 + 1;
        val_16 = diff;
        val_10 = diff;
        if((System.Boolean.Parse(value:  val_10)) == false)
        {
            goto label_21;
        }
        
        goto typeof(Player).__il2cppRuntimeField_10C;
        label_21:
        if((this.<forceUpdateFromServer>k__BackingField) == false)
        {
            goto label_23;
        }
        
        this.<forceUpdateFromServer>k__BackingField = false;
        goto typeof(Player).__il2cppRuntimeField_10C;
        label_23:
        label_24:
        var val_6 = FP - 28;
    }
    protected virtual void TrustServerData(System.Collections.IDictionary diff)
    {
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        int val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        if(diff != 0)
        {
                diff = this;
        }
        
        if(diff != 0)
        {
                int val_3 = System.Int32.Parse(s:  diff);
            if(diff != 0)
        {
            
        }
        
        }
        
        if(diff != 0)
        {
                diff = this;
        }
        
        if(diff == 0)
        {
            goto label_27;
        }
        
        decimal val_6 = System.Decimal.Parse(s:  -1930636096, style:  diff);
        if(diff == 0)
        {
            goto label_107;
        }
        
        label_27:
        if(diff != 0)
        {
                if((System.Int32.Parse(s:  diff)) > this._stars)
        {
                this._stars = System.Int32.Parse(s:  diff);
        }
        
        }
        
        if(diff != 0)
        {
                if((System.Int32.Parse(s:  diff)) > this._bonusRewardPoints)
        {
                var val_40 = 0;
            val_40 = val_40 + 1;
            val_40 = diff;
            this._bonusRewardPoints = System.Int32.Parse(s:  diff);
        }
        
        }
        
        var val_41 = 0;
        val_41 = val_41 + 1;
        val_41 = diff;
        if(diff != 0)
        {
                var val_42 = 0;
            val_42 = val_42 + 1;
            val_42 = diff;
            this._gems = System.Int32.Parse(s:  diff);
        }
        
        var val_43 = 0;
        val_43 = val_43 + 1;
        val_43 = diff;
        if(diff != 0)
        {
                var val_44 = 0;
            val_44 = val_44 + 1;
            val_44 = diff;
            this._food = System.Int32.Parse(s:  diff);
        }
        
        var val_45 = 0;
        val_45 = val_45 + 1;
        val_45 = diff;
        if(diff != 0)
        {
                val_46 = this;
        }
        
        if(diff == 0)
        {
            goto label_99;
        }
        
        var val_46 = 0;
        val_46 = val_46 + 1;
        val_47 = diff;
        goto label_104;
        label_99:
        val_48 = this.dcStars;
        val_46 = this;
        goto label_105;
        label_104:
        if(val_46 == 0)
        {
            goto label_107;
        }
        
        label_105:
        this.dcStars = System.Int32.Parse(s:  diff);
        var val_47 = 0;
        val_47 = val_47 + 1;
        val_49 = diff;
        if(diff != 0)
        {
                var val_48 = 0;
            val_48 = val_48 + 1;
            val_50 = diff;
            decimal val_28 = System.Decimal.Parse(s:  -1930636096, style:  diff);
        }
        
        var val_49 = 0;
        val_49 = val_49 + 1;
        val_51 = diff;
        if(diff != 0)
        {
                var val_50 = 0;
            val_50 = val_50 + 1;
            val_52 = diff;
            System.Globalization.CultureInfo val_31 = System.Globalization.CultureInfo.InvariantCulture;
            float val_32 = System.Single.Parse(s:  diff, provider:  0);
            if(System.Globalization.CultureInfo.__il2cppRuntimeField_cctor_finished > 0)
        {
                this.total_purchased = diff;
        }
        
        }
        
        var val_51 = 0;
        val_51 = val_51 + 1;
        val_53 = diff;
        val_54 = 0;
        if(diff != 0)
        {
                var val_52 = 0;
            val_55 = 0;
            val_52 = val_52 + 1;
            val_56 = diff;
            val_54 = System.Int32.Parse(s:  diff);
        }
        
        if(val_54 > this.lifetimePlays)
        {
                this.lifetimePlays = System.Math.Min(val1:  val_54 + 1, val2:  -2147483647);
        }
        
        var val_53 = 0;
        val_53 = val_53 + 1;
        val_57 = diff;
        if(diff != 0)
        {
                UnityEngine.PlayerPrefs.SetInt(key:  -1931027104, value:  1);
        }
        
        var val_54 = 0;
        val_54 = val_54 + 1;
        val_58 = diff;
        if(diff != 0)
        {
                var val_55 = 0;
            val_55 = val_55 + 1;
        }
    
    }
    protected virtual void LoadFromLocal()
    {
        System.DateTime val_13;
        System.DateTime val_17;
        var val_68;
        var val_74;
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1930531936);
        this.id = "player_id";
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -1930531840);
        this.uuid = "player_uuid";
        string val_3 = UnityEngine.PlayerPrefs.GetString(key:  -1930531744, defaultValue:  -1930531648);
        this.support = "player_support";
        decimal val_4 = ParseCredits();
        this._stars = UnityEngine.PlayerPrefs.GetInt(key:  -1930531552, defaultValue:  0);
        GameEcon val_6 = App.getGameEcon;
        this._gems = UnityEngine.PlayerPrefs.GetInt(key:  -1930531456, defaultValue:  264);
        this._food = UnityEngine.PlayerPrefs.GetInt(key:  -1930531360, defaultValue:  10);
        this._bonusRewardPoints = UnityEngine.PlayerPrefs.GetInt(key:  -1930531248, defaultValue:  0);
        decimal val_10 = ParseExperience();
        string val_11 = UnityEngine.PlayerPrefs.GetString(key:  -1930531136);
        System.DateTime val_12 = System.DateTime.UtcNow;
        System.DateTime val_15 = SLCDateTime.Parse(dateTime:  -1930515448, defaultValue:  new System.DateTime() {dateData = 1152921511266250432});
        this.created_at = val_17;
        if((UnityEngine.Random.Range(min:  1, max:  11)) < 6)
        {
                "B" = "A";
        }
        
        string val_19 = UnityEngine.PlayerPrefs.GetString(key:  -1930530944, defaultValue:  -1930531024);
        this.playerBucket = "player_bucket";
        string val_20 = UnityEngine.PlayerPrefs.GetString(key:  -1930530768);
        System.DateTime val_21 = System.DateTime.UtcNow;
        System.DateTime val_24 = AddDays(value:  null);
        System.DateTime val_27 = SLCDateTime.Parse(dateTime:  -1930515440, defaultValue:  new System.DateTime() {dateData = 1152921511266250800});
        this.last_daily_credits = val_13;
        this.clientCreated = UnityEngine.PlayerPrefs.GetInt(key:  -1930885200);
        int val_29 = UnityEngine.PlayerPrefs.GetInt(key:  -1930530640, defaultValue:  1);
        this.dcStars = UnityEngine.PlayerPrefs.GetInt(key:  -1930648320);
        this.no_ads = UnityEngine.PlayerPrefs.GetInt(key:  -1930530544, defaultValue:  1);
        this.restoredTransactions = UnityEngine.PlayerPrefs.GetInt(key:  -1930530448, defaultValue:  0);
        this.lifetimePlays = System.Math.Min(val1:  (UnityEngine.PlayerPrefs.GetInt(key:  -1930530320, defaultValue:  0)) + 1, val2:  -2147483647);
        this.last_daily_amount = UnityEngine.PlayerPrefs.GetInt(key:  -1930530208, defaultValue:  0);
        string val_37 = UnityEngine.PlayerPrefs.GetString(key:  -1930530080, defaultValue:  1098586544);
        this.email = "player_email";
        string val_38 = UnityEngine.PlayerPrefs.GetString(key:  -1930529984);
        System.DateTime val_39 = SLCDateTime.Parse(dateTime:  -1930515448, defaultValue:  new System.DateTime() {dateData = 1152921511266251584});
        this.last_purchase = val_17;
        string val_40 = UnityEngine.PlayerPrefs.GetString(key:  -1930529872);
        this.max_item_purchased = "player_max_item_purchased";
        string val_41 = UnityEngine.PlayerPrefs.GetString(key:  -1930529744);
        this.last_item_purchased = "player_last_item_purchased";
        this.lastItemPrice = "player_last_item_price";
        this.levelsRemoved = UnityEngine.PlayerPrefs.GetInt(key:  -1930529504, defaultValue:  0);
        string val_44 = UnityEngine.PlayerPrefs.GetString(key:  -1931156464, defaultValue:  1295406272);
        this.network_purchaser = "network_purchaser";
        this.total_purchased = "player_total_purchased";
        this.num_purchase = UnityEngine.PlayerPrefs.GetInt(key:  -1930529280, defaultValue:  0);
        this.num_ad_clicks = UnityEngine.PlayerPrefs.GetInt(key:  -1930529168, defaultValue:  0);
        this.lastPurchasePrice = "player_last_purchase_price";
        this.transactionsAverageAmount = "player_transactions_average_amount";
        string val_50 = UnityEngine.PlayerPrefs.GetString(key:  -1930528784, defaultValue:  1098586544);
        this._challengeData = "ChallengeData";
        string val_51 = UnityEngine.PlayerPrefs.GetString(key:  -1930528688, defaultValue:  -2040381152);
        object val_52 = MiniJSON.Json.Deserialize(json:  -1930528688);
        this.ParsePlayerStats(definition:  -1930528688);
        string val_53 = UnityEngine.PlayerPrefs.GetString(key:  -1930528592, defaultValue:  -2040381152);
        object val_54 = MiniJSON.Json.Deserialize(json:  -1930528592);
        this.ParseNetworkPromo(objects:  -1930528592);
        string val_55 = UnityEngine.PlayerPrefs.GetString(key:  -1930528480, defaultValue:  1295406192);
        this.samePurchases = System.Boolean.Parse(value:  -1930528480);
        string val_57 = UnityEngine.PlayerPrefs.GetString(key:  -1930528368);
        System.DateTime val_58 = System.DateTime.UtcNow;
        System.DateTime val_61 = SLCDateTime.Parse(dateTime:  -1930515464, defaultValue:  new System.DateTime() {dateData = 1152921511266253200});
        System.DateTime val_64 = System.DateTime.UtcNow;
        System.TimeSpan val_67 = Subtract(value:  new System.DateTime() {dateData = 1152921511266266176});
        AverageEventCalculator val_70 = new AverageEventCalculator(name:  -1930528256);
        double val_71 = val_68.TotalHours;
        float val_72 = CalculateCurrent(valueToAdd:  UnityEngine.PlayerPrefs.GetFloat(key:  -1930528928, defaultValue:  UnityEngine.PlayerPrefs.GetFloat(key:  -1930529056, defaultValue:  UnityEngine.PlayerPrefs.GetFloat(key:  -1930529392, defaultValue:  UnityEngine.PlayerPrefs.GetFloat(key:  -1930529616, defaultValue:  null)))));
        this._avg_hours_played = null;
        System.DateTime val_73 = System.DateTime.UtcNow;
        string val_76 = val_74.ToString();
        UnityEngine.PlayerPrefs.SetString(key:  -1930528368, value:  -1930515392);
        string val_77 = UnityEngine.PlayerPrefs.GetString(key:  -1930528048, defaultValue:  -1930528128);
        this.isHacker = System.Boolean.Parse(value:  -1930528048);
        string val_79 = UnityEngine.PlayerPrefs.GetString(key:  -1930527936, defaultValue:  -1930528128);
        this.isTroll = System.Boolean.Parse(value:  -1930527936);
        string val_81 = UnityEngine.PlayerPrefs.GetString(key:  -1930527824, defaultValue:  -1930527712);
        this.hackerType = "player_hacker_type";
        string val_82 = UnityEngine.PlayerPrefs.GetString(key:  -1930527616, defaultValue:  -1930528128);
        this.IsLapsingPurchaser = System.Boolean.Parse(value:  -1930527616);
        string val_84 = UnityEngine.PlayerPrefs.GetString(key:  -1930527488, defaultValue:  -1930528128);
        this.IsLapsingNonPurchaser = System.Boolean.Parse(value:  -1930527488);
        this.synchedGoldenCurrency = UnityEngine.PlayerPrefs.HasKey(key:  -1937236656);
        this.playerLoaded = true;
    }
    public virtual void BuildReflectedLists()
    {
    
    }
    public void SetCredits(decimal amount)
    {
        var val_2;
        int val_3;
        val_2 = null;
        val_2 = null;
        val_3 = amount.mid;
        val_3 = amount.mid;
        decimal val_1 = System.Math.Max(val1:  new System.Decimal() {flags = -1930291312, hi = System.Decimal.Zero, lo = R5, mid = R6}, val2:  new System.Decimal() {flags = ???, hi = amount.flags, lo = amount.hi, mid = amount.lo});
        SROptions_Player.NotifyPropertyChanged(propertyName:  -1930303344);
    }
    public void AddCredits(decimal amount, string source, string subSource, System.Collections.Generic.Dictionary<string, object> externalParams, bool doTrack = True)
    {
        int val_2;
        int val_3;
        int val_4;
        int val_5;
        var val_10;
        var val_11;
        int val_15;
        int val_16;
        int val_17;
        int val_18;
        int val_19;
        int val_20;
        int val_21;
        int val_22;
        var val_23;
        int val_24;
        int val_25;
        var val_26;
        mem[1152921511266626636] = 35633093;
        decimal val_1 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -1930167012, hi = this._credits, lo = R6, mid = R8}, d2:  new System.Decimal() {flags = 35633093, hi = amount.flags, lo = amount.hi, mid = amount.lo});
        val_17 = ???;
        val_15 = val_15;
        val_16 = ???;
        decimal val_6 = System.Math.Max(val1:  new System.Decimal() {flags = -1930167040, hi = val_15, lo = val_16, mid = val_17}, val2:  new System.Decimal() {hi = val_2, lo = val_3, mid = val_4});
        val_18 = amount.mid;
        val_19 = amount.hi;
        val_20 = amount.lo;
        val_21 = amount.flags;
        val_22 = val_20;
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = val_21, hi = val_19, lo = val_22, mid = val_18}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                decimal val_8 = System.Decimal.op_Addition(d1:  new System.Decimal() {flags = -1930167012, hi = mem[1152921511266626652] + 164, lo = mem[1152921511266626652] + 168, mid = mem[1152921511266626652] + 172}, d2:  new System.Decimal() {flags = mem[1152921511266626652] + 176, hi = amount.flags, lo = amount.hi, mid = amount.lo});
            mem[1152921511266626652].CreditsPurchased = new System.Decimal() {mid = val_5};
            System.DateTime val_9 = DateTimeCheat.UtcNow;
            mem2[0] = val_10;
            mem2[0] = val_11;
            val_20 = amount.lo;
            val_19 = amount.hi;
            val_21 = amount.flags;
            val_18 = amount.mid;
            val_22 = 0;
            mem[1152921511266626652].Save(writePrefs:  true);
            if(doTrack != false)
        {
                val_22 = val_19;
            externalParams.TrackCreditsSpent(amount:  new System.Decimal() {flags = val_21, hi = val_22, lo = val_20, mid = val_18}, source:  source, previousBalance:  new System.Decimal() {flags = this._credits, mid = mem[1152921511266626636]}, externalParams:  externalParams);
        }
        
        }
        
        val_23 = null;
        val_23 = null;
        val_24 = val_19;
        val_25 = val_20;
        if((System.Decimal.op_GreaterThan(d1:  new System.Decimal() {flags = val_21, hi = val_24, lo = val_25, mid = val_18}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10})) != false)
        {
                if(mem[1152921511266626872] != 0)
        {
                val_24 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = val_21, hi = val_19, lo = val_20, mid = val_18});
            val_25 = public System.Void System.Action<System.Int32>::Invoke(System.Int32 obj);
            mem[1152921511266626872].Invoke(obj:  val_24);
        }
        
            if(doTrack != false)
        {
                val_25 = val_19;
            this.TrackCreditsGained(amount:  new System.Decimal() {flags = val_21, hi = val_25, lo = val_20, mid = val_18}, source:  source, previousBalance:  new System.Decimal() {flags = this._credits, mid = mem[1152921511266626636]}, subSource:  subSource, extraParams:  externalParams);
        }
        
        }
        
        val_26 = null;
        val_26 = null;
        bool val_14 = System.Decimal.op_Equality(d1:  new System.Decimal() {flags = val_21, hi = val_19, lo = val_20, mid = val_18}, d2:  new System.Decimal() {flags = System.Decimal.Zero, mid = System.Decimal.Powers10.__il2cppRuntimeField_10});
        if(val_14 == true)
        {
                val_14 = doTrack;
        }
        
        if(val_14 == false)
        {
                return;
        }
        
        this.TrackNonCoinReward(source:  source, subSource:  subSource, rewardType:  null, rewardAmount:  0, additionalParams:  externalParams);
    }
    public void ResetPlayerCredits()
    {
        GameBehavior val_1 = App.getBehavior;
    }
    public void AddGems(int amount, string source, string subsource)
    {
        System.DateTime val_5;
        var val_6;
        int val_7;
        this._gems = System.Math.Max(val1:  0, val2:  this._gems + amount);
        if(amount > 1)
        {
                return;
        }
        
        if(this.properties != 0)
        {
                val_7 = this.properties.gems_spent;
        }
        else
        {
                val_7 = 4;
        }
        
        this.properties.GemsSpent = val_7 + amount;
        System.DateTime val_4 = DateTimeCheat.UtcNow;
        this.properties.LastGemSpent = val_5;
        mem2[0] = val_6;
        this.properties.Save(writePrefs:  true);
        this.properties.TrackGemsSpent(amount:  amount, source:  source, previousBalance:  this._gems);
    }
    public void SetPetsFood(int amount)
    {
        this._food = UnityEngine.Mathf.Max(a:  0, b:  amount);
    }
    public void AddPetsFood(int amount, string source, string subSource, WADPets.Tracking_FoodSpent FoodSpentParams, System.Collections.Generic.Dictionary<string, object> additionalParam)
    {
        string val_11;
        Player val_14;
        string val_15;
        string val_16;
        int val_17;
        int val_18;
        val_14 = this;
        val_15 = subSource;
        val_16 = source;
        val_17 = amount;
        val_18 = this._food;
        this._food = UnityEngine.Mathf.Max(a:  0, b:  val_18 + val_17);
        if(val_17 < 1)
        {
            goto label_3;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        Tracking_LifetimeFoodIncreased(amount:  val_17);
        if((System.String.IsNullOrEmpty(value:  val_16)) == true)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        val_18 = 1152921510535002416;
        Add(key:  -1929660304, value:  13152256);
        Add(key:  -1929660208, value:  13152256);
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_7 = PlayingChallenge;
        Add(key:  -2100705808, value:  8945664);
        if(additionalParam == 0)
        {
            goto label_14;
        }
        
        Dictionary.KeyCollection<TKey, TValue> val_8 = additionalParam.Keys;
        val_18 = additionalParam;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_9 = GetEnumerator();
        label_18:
        if(MoveNext() == false)
        {
            goto label_16;
        }
        
        object val_12 = additionalParam.Item[val_11];
        Add(key:  val_11, value:  additionalParam);
        goto label_18;
        label_16:
        Dispose();
        val_15 = val_15;
        val_16 = val_16;
        val_14 = val_14;
        label_14:
        string val_13 = amount.ToString();
        this.TrackNonCoinReward(source:  val_16, subSource:  val_15, rewardType:  -1929660112, rewardAmount:  amount, additionalParams:  null);
        val_17 = amount;
        label_3:
        if(FoodSpentParams == 0)
        {
                return;
        }
        
        if(val_17 <= 1)
        {
                this.TrackFoodSpent(FoodSpentParams:  FoodSpentParams);
        }
    
    }
    private void ValidateCurrentPlayer()
    {
        if((UnityEngine.PlayerPrefs.GetInt(key:  -1930885200, defaultValue:  0)) < 1)
        {
                return;
        }
        
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -1930531840);
        string val_3 = DeviceIdPlugin.GetDeviceId();
        if((System.String.op_Inequality(a:  -1930531840, b:  null)) == false)
        {
                return;
        }
        
        UnityEngine.PlayerPrefs.DeleteAll();
    }
    protected virtual bool ShouldTakeServerData(ref System.Collections.IDictionary _diff)
    {
        float val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        System.Collections.IDictionary val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_9 = mem[_diff];
        val_8 = "level";
        if((mem[_diff] + 178) == 0)
        {
            goto label_2;
        }
        
        var val_8 = 0;
        label_4:
        val_9 = mem[mem[_diff] + 88 + 0];
        val_9 = mem[_diff] + 88 + 0;
        if(val_9 == null)
        {
            goto label_3;
        }
        
        val_8 = val_8 + 1;
        if(((uint)val_8 & 65535) < (mem[_diff] + 178))
        {
            goto label_4;
        }
        
        label_2:
        val_10 = _diff;
        goto label_5;
        label_3:
        var val_1 = (mem[_diff] + 88) + 0;
        val_9 = val_9 + (((mem[_diff] + 88 + 0) + 4) << 3);
        val_10 = val_9 + 220;
        label_5:
        if(_diff == 0)
        {
            goto label_6;
        }
        
        var val_11 = mem[_diff];
        val_11 = "level";
        if((mem[_diff] + 178) == 0)
        {
            goto label_8;
        }
        
        var val_10 = 0;
        label_10:
        val_9 = mem[mem[_diff] + 88 + 0];
        val_9 = mem[_diff] + 88 + 0;
        if(val_9 == null)
        {
            goto label_9;
        }
        
        val_10 = val_10 + 1;
        if(((uint)val_10 & 65535) < (mem[_diff] + 178))
        {
            goto label_10;
        }
        
        label_8:
        val_12 = _diff;
        goto label_11;
        label_9:
        var val_2 = (mem[_diff] + 88) + 0;
        val_11 = val_11 + (((mem[_diff] + 88 + 0) + 4) << 3);
        val_12 = val_11 + 188;
        label_11:
        val_13 = System.Int32.Parse(s:  _diff);
        val_14 = 1;
        if(this < val_13)
        {
                return (bool)val_14;
        }
        
        label_6:
        val_13 = _diff;
        var val_13 = mem[_diff];
        val_11 = "total_purchase";
        val_8 = "total_purchase";
        if((mem[_diff] + 178) == 0)
        {
            goto label_15;
        }
        
        var val_12 = 0;
        label_17:
        val_9 = mem[mem[_diff] + 88 + 0];
        val_9 = mem[_diff] + 88 + 0;
        if(val_9 == null)
        {
            goto label_16;
        }
        
        val_12 = val_12 + 1;
        if(((uint)val_12 & 65535) < (mem[_diff] + 178))
        {
            goto label_17;
        }
        
        label_15:
        val_15 = val_13;
        goto label_18;
        label_16:
        var val_4 = (mem[_diff] + 88) + 0;
        val_13 = val_13 + (((mem[_diff] + 88 + 0) + 4) << 3);
        val_15 = val_13 + 220;
        label_18:
        if(val_13 == 0)
        {
            goto label_19;
        }
        
        var val_14 = mem[_diff];
        val_11 = "total_purchase";
        if((mem[_diff] + 178) == 0)
        {
            goto label_21;
        }
        
        val_9 = 0;
        label_23:
        val_13 = mem[mem[_diff] + 88 + 0];
        val_13 = mem[_diff] + 88 + 0;
        if(val_13 == null)
        {
            goto label_22;
        }
        
        val_9 = val_9 + 1;
        if(((uint)val_9 & 65535) < (mem[_diff] + 178))
        {
            goto label_23;
        }
        
        label_21:
        val_16 = _diff;
        goto label_24;
        label_19:
        val_14 = 0;
        return (bool)val_14;
        label_22:
        var val_5 = (mem[_diff] + 88) + 0;
        val_14 = val_14 + (((mem[_diff] + 88 + 0) + 4) << 3);
        val_16 = val_14 + 188;
        label_24:
        System.Globalization.CultureInfo val_6 = System.Globalization.CultureInfo.InvariantCulture;
        float val_7 = System.Single.Parse(s:  _diff, provider:  0);
        if(System.Globalization.CultureInfo.__il2cppRuntimeField_cctor_finished >= 0)
        {
                val_14 = 0;
        }
        
        return (bool)val_14;
    }
    protected virtual void CreateNewPlayer(string id = " ")
    {
        System.DateTime val_6;
        var val_10;
        var val_11;
        var val_12;
        this.id = id;
        string val_1 = DeviceIdPlugin.GetDeviceId();
        this.uuid = 0;
        this.support = "00-00-00";
        GameBehavior val_2 = App.getBehavior;
        this._bonusRewardPoints = 0;
        GameBehavior val_3 = App.getBehavior;
        this._gems = 0;
        this._stars = 0;
        val_10 = null;
        val_10 = null;
        this._food = WADPets.WADPetsEcon.DefaultFoodQuantity;
        val_11 = null;
        val_11 = null;
        System.DateTime val_4 = System.DateTime.UtcNow;
        this.created_at = val_6;
        if((UnityEngine.Random.Range(min:  1, max:  11)) < 6)
        {
                "B" = "A";
        }
        
        this.playerBucket = "A";
        val_12 = null;
        val_12 = null;
        this.clientCreated = 1;
        this.dcStars = 0;
        this.no_ads = 1;
        this.restoredTransactions = 0;
        this.lifetimePlays = 0;
        this.email = "";
        this.last_purchase = System.DateTime.MinValue;
        mem[1152921511267510220] = typeof(Player).__il2cppRuntimeField_E4;
        this.max_item_purchased = " ";
        this.last_item_purchased = " ";
        this.lastItemPrice = 0;
        this.network_purchaser = "false";
        this.total_purchased = 0;
        this.num_purchase = 0;
        this.num_ad_clicks = 0;
        this.transactionsAverageAmount = 0;
        this._avg_hours_played = 0;
        this._challengeData = "";
        this.lastPurchasePrice = 0;
        System.Collections.Generic.Dictionary<System.String, System.Decimal> val_8 = new System.Collections.Generic.Dictionary<System.String, System.Decimal>();
        this.samePurchases = 1;
        this.playerStats = null;
        this.isNew = 1;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_9 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.isHacker = 0;
        this.promotedGames = null;
        this.isTroll = 0;
        this.hackerType = "Unknown";
        this.IsLapsingPurchaser = 0;
        this.IsLapsingNonPurchaser = false;
        this.country = "";
        this.playerCreated = 1;
    }
    private void CreateCustomProperties(bool isPlayerNew)
    {
        this.properties = new PlayerProperties(isPlayerNew:  isPlayerNew);
    }
    public void HardReset()
    {
        this.CreateCustomProperties(isPlayerNew:  true);
    }
    public object GetDeviceProperties()
    {
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        string val_2 = DeviceProperties.MacAddress;
        Add(key:  -1928947232, value:  0);
        string val_3 = DeviceProperties.DeviceModel;
        Add(key:  -1928947152, value:  0);
        string val_4 = DeviceProperties.OSVersion;
        Add(key:  -1928947072, value:  0);
        string val_5 = DeviceProperties.LanguageCode;
        Add(key:  -2085433328, value:  0);
        string val_6 = DeviceProperties.Platform;
        Add(key:  -1928946992, value:  0);
        string val_7 = DeviceProperties.Idfa;
        Add(key:  -1928946896, value:  0);
        bool val_8 = DeviceProperties.timeTraveler;
        Add(key:  -1928946816, value:  8945664);
        string val_9 = DeviceIdPlugin.GetClientVersion();
        Add(key:  -1931031472, value:  0);
        int val_10 = DeviceIdPlugin.GetTimeZone();
        Add(key:  -1928946720, value:  13152256);
        string val_11 = DeviceProperties.notificationToken;
        if((System.String.IsNullOrEmpty(value:  null)) == true)
        {
                return;
        }
        
        val_14 = 9876416 + 25756765;
        if(val_14 == 0)
        {
                mem2[0] = 1;
        }
        
        val_15 = null;
        val_15 = null;
        if(twelvegigs.plugins.LocalNotificationsPlugin.initialized == false)
        {
                return;
        }
        
        val_14 = twelvegigs.plugins.LocalNotificationsPlugin.IsNotificationEnabled();
        if(val_14 != false)
        {
                val_16 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
            val_17 = 0;
        }
        else
        {
                val_16 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
            val_17 = "-";
        }
        
        Add(key:  -1928946624, value:  1359327184);
    }
    private void TrackOOC()
    {
        var val_1;
        var val_2;
        var val_1 = 25748722;
        val_1 = 9876816 + val_1;
        if(val_1 == 0)
        {
                mem2[0] = 1;
        }
        
        val_1 = null;
        val_1 = null;
        val_2 = null;
        val_2 = null;
        App.trackerManager.track(eventName:  Events.OUT_OF_CREDITS);
    }
    public static string GetLevelForTracking()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public static string GetLevelNameForTracking()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public static string GetDifficultyForTracking()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public static string GetProgressForTracking()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public static string GetProgressTypeForTracking()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public void TrackNonCoinReward(string source, string subSource, string rewardType, string rewardAmount, System.Collections.Generic.Dictionary<string, object> additionalParams)
    {
        string val_15;
        string val_16;
        WordPets.WPTPetTile val_17;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_18;
        string val_19;
        var val_20;
        val_15 = rewardType;
        val_16 = subSource;
        val_17 = source;
        val_18 = null;
        val_18 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        val_19 = rewardAmount;
        Add(key:  -1928142032, value:  val_17);
        if((System.String.IsNullOrEmpty(value:  val_16)) != true)
        {
                Add(key:  -1928141952, value:  val_16);
        }
        
        if((System.String.IsNullOrEmpty(value:  val_19)) != true)
        {
                Add(key:  -1928141856, value:  val_19);
        }
        
        if((System.String.IsNullOrEmpty(value:  val_15)) != true)
        {
                Add(key:  1297334992, value:  val_15);
        }
        
        if(additionalParams == 0)
        {
            goto label_8;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_5 = GetEnumerator();
        label_13:
        if(0.MoveNext() == false)
        {
            goto label_9;
        }
        
        if((ContainsKey(key:  0)) == true)
        {
            goto label_13;
        }
        
        Add(key:  0, value:  SB);
        goto label_13;
        label_9:
        0.Dispose();
        val_16 = val_16;
        val_17 = val_17;
        val_15 = val_15;
        val_19 = rewardAmount;
        label_8:
        GameBehavior val_9 = App.getBehavior;
        val_20 = null;
        val_20 = null;
        App.trackerManager.track(eventName:  -1928141776, data:  78753792);
        CompanyDevices val_10 = CompanyDevices.Instance;
        if(0 == 0)
        {
                return;
        }
        
        CompanyDevices val_12 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
                return;
        }
        
        val_18 = null;
        typeof(System.Object[]).__il2cppRuntimeField_10 = val_15;
        typeof(System.Object[]).__il2cppRuntimeField_14 = val_19;
        typeof(System.Object[]).__il2cppRuntimeField_18 = val_17;
        typeof(System.Object[]).__il2cppRuntimeField_1C = val_16;
        string val_14 = System.String.Format(format:  -1928141680, args:  472754880);
        mem[1152921511268664288].Add(item:  -1928141680);
    }
    public void TrackFoodSpent(WADPets.Tracking_FoodSpent FoodSpentParams)
    {
        var val_2;
        var val_3;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1928004976, value:  13152256);
        Add(key:  -1929660304, value:  13152256);
        Add(key:  -1929660208, value:  13152256);
        var val_2 = 25752286;
        val_2 = 9873252 + val_2;
        if(val_2 == 0)
        {
                mem2[0] = 1;
        }
        
        val_2 = null;
        val_2 = null;
        val_3 = null;
        val_3 = null;
        App.trackerManager.track(eventName:  Events.FOOD_SPENT, data:  78753792);
    }
    public void TrackGoldenCurrencySpent(int amount, string source, System.Collections.Generic.Dictionary<string, object> additionalParams)
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                return;
        }
    
    }
    private void TrackCreditsGained(decimal amount, string source, decimal previousBalance, string subSource, System.Collections.Generic.Dictionary<string, object> extraParams)
    {
        string val_19;
        int val_20;
        var val_21;
        string val_22;
        Player val_23;
        var val_24;
        val_19 = this;
        val_20 = previousBalance.hi;
        val_21 = null;
        val_21 = null;
        val_22 = source;
        if((Player.NotFreeCreditSources.Contains(item:  val_22)) == true)
        {
                return;
        }
        
        val_20 = null;
        val_20 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1928142032, value:  val_22);
        if((System.String.IsNullOrEmpty(value:  subSource)) != true)
        {
                Add(key:  -1928141952, value:  subSource);
        }
        
        Add(key:  -1927748112, value:  10170368);
        Add(key:  -1927748000, value:  10170368);
        Add(key:  -1927747904, value:  10170368);
        GameBehavior val_4 = App.getBehavior;
        val_23 = val_19;
        val_19 = source;
        if(0 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            Add(key:  -2100705808, value:  8945664);
            val_19 = source;
        }
        
        val_22 = subSource;
        if(extraParams == 0)
        {
            goto label_20;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_7 = PlayingChallenge.GetEnumerator();
        label_25:
        if(0.MoveNext() == false)
        {
            goto label_21;
        }
        
        if((ContainsKey(key:  0)) == true)
        {
            goto label_25;
        }
        
        Add(key:  0, value:  R6);
        goto label_25;
        label_21:
        0.Dispose();
        val_19 = source;
        val_22 = subSource;
        val_23 = val_23;
        label_20:
        string val_10 = PrettyPrint.printJSON(obj:  78753792, types:  false, singleLineOutput:  false);
        string val_11 = -1927747792(-1927747792) + 78753792;
        UnityEngine.Debug.Log(message:  -1927747792);
        var val_19 = 25757294;
        val_19 = 9868244 + val_19;
        if(val_19 == 0)
        {
                mem2[0] = 1;
        }
        
        val_24 = null;
        val_24 = null;
        App.trackerManager.track(eventName:  -1942319936, data:  78753792);
        CompanyDevices val_12 = CompanyDevices.Instance;
        if(0 == 0)
        {
                return;
        }
        
        CompanyDevices val_14 = CompanyDevices.Instance;
        if(0.CompanyDevice() == false)
        {
                return;
        }
        
        val_20 = val_22;
        string val_16 = previousBalance.flags.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_10 = ;
        string val_17 = amount.flags.ToString();
        typeof(System.Object[]).__il2cppRuntimeField_14 = ;
        val_22 = val_20;
        typeof(System.Object[]).__il2cppRuntimeField_18 = val_19;
        typeof(System.Object[]).__il2cppRuntimeField_1C = val_22;
        string val_18 = System.String.Format(format:  -1928141680, args:  472754880);
        mem[1152921511269058188].Add(item:  -1928141680);
    }
    private void TrackCreditsSpent(decimal amount, string source, decimal previousBalance, System.Collections.Generic.Dictionary<string, object> externalParams)
    {
        int val_2;
        int val_3;
        GameBehavior val_1 = App.getBehavior;
        val_2 = previousBalance.mid;
        val_3 = previousBalance.lo;
        if(0 != 0)
        {
                return;
        }
        
        val_2 = previousBalance.mid;
        val_3 = val_3;
    }
    private void TrackGemsSpent(int amount, string source, int previousBalance)
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                return;
        }
    
    }
    public Player()
    {
        var val_5;
        this.isNew = true;
        val_5 = null;
        val_5 = null;
        this._food = WADPets.WADPetsEcon.DefaultFoodQuantity;
        System.DateTime val_1 = System.DateTime.UtcNow;
        this.created_at = new System.DateTime();
        this._level = 1;
        this.last_daily_credits = System.DateTime.MinValue;
        this.no_ads = 1;
        this.last_purchase = System.DateTime.MinValue;
        mem[1152921511269430956] = ???;
        this.max_item_purchased = " ";
        this.last_item_purchased = " ";
        this.network_purchaser = "false";
        this.samePurchases = 1;
        this._challengeData = "";
        this.hackerType = "Unknown";
        System.Collections.Generic.Dictionary<System.String, System.Decimal> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Decimal>();
        this.playerStats = null;
        this.QAHACK_FreeCoinsTrace = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.QAHACK_NonCoinsAwardTrace = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
    }
    private static Player()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(null != 0)
        {
                Add(item:  -1927262784);
        }
        else
        {
                Add(item:  -1927262784);
        }
        
        Add(item:  -1927262672);
        Player.NotFreeCreditSources = null;
    }

}
