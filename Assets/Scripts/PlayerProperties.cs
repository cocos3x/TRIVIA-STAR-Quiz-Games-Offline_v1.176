using UnityEngine;
[Serializable]
public class PlayerProperties
{
    // Fields
    private EasySaver<PlayerProperties> mySaver;
    public const string DefaultProfileLocation = "Slotsville, USA";
    public string offline_fb_id;
    public string fb_access_token;
    public string online_fb_id;
    private bool <PurchaseHackUser>k__BackingField;
    private const string install_from_mg_deeplink_key = "inst_mg_deeplink";
    public bool InstalledFromMGDeeplink;
    private const string mg_play_count_key = "mg_play_ct";
    public int MGPlaysCount;
    private const string mg_coins_earned_key = "mg_coins_rwd";
    public decimal MGCoinsRewarded;
    private const string mg_ads_watched_key = "mg_ads_ct";
    public int MGAdsCount;
    private const string mg_hints_used_key = "mg_hnts_ct";
    public int MGHintsCount;
    private const string lifetime_hints_key = "total_hnts";
    public int LifetimeHints;
    private const string lifetime_fr_hints_key = "free_hnts";
    public int LifetimeFreeHints;
    private const string lifetime_sr_hints_key = "str_hints";
    public int LifetimeStruggleHints;
    private const string lifetime_dc_hints_key = "dc_hnts";
    public int LifetimeDCHints;
    private const string lifetime_hintpickers_key = "total_hntpck";
    public int LifetimeHintPickers;
    private const string lifetime_megahint_key = "total_mga_hnt";
    public int LifetimeMegaHints;
    private const string lifetime_checkhint_key = "total_chk_hnt";
    public int LifetimeCheckHints;
    private const string chapters_played_key = "ch_no_hnts";
    public int ChaptersPlayedWithoutHints;
    private const string hints_used_chapter_key = "hnts_used_ch";
    public int HintsUsedOnCurrentChapter;
    private const string incentivised_vids_key = "total_ivds";
    public int incentivisedVideosWatched;
    private const string prize_balloon_tapped_key = "balloon_tapped";
    public int prizeBalloonTapped;
    private const string prize_balloon_appeared_key = "balloon_appeared";
    public int prizeBalloonAppeared;
    private const string grid_size_key = "pp_grid_size";
    public float gridSize;
    public bool SkippedTutorial;
    public int AdvancedSkipLevel;
    private const string www_timestamp_key = "www_ts";
    public int WWWServerTimestamp;
    private const string www_progress_key = "www_prg";
    public int WWWEventProgress;
    private const string www_collected_key = "www_col";
    public int wWWEventCollected;
    private const string ads_not_clicked_key = "ads_not_clicked";
    public int adsNotClicked;
    private const string lvls_post_purchase_key = "lvls_post_purch";
    public int LevelsPlayedPostPurchase;
    private const string last_seen_date_string = "last_seen_date";
    public string LastSeenDateString;
    private const string noAdsEndTimeKey = "no_ads_end";
    public System.DateTime NoAdsEndTime;
    private string _profile_name;
    public int profile_avatar_id;
    public string profile_location;
    private decimal credits_purchased;
    private int gems_spent;
    public string story_mode_vote;
    public bool gdprConsent;
    private System.Collections.Generic.List<string> gdprCountries;
    public string WHDPlayerVarsTokenized;
    private const string ads_last_clicked_time_key = "ads_last_clicked_time";
    public System.DateTime AdsLastClickedTime;
    private const string gotd_last_shown_time_key = "gotd_last_shown_time";
    public System.DateTime GOTDLastShownTime;
    private const string gotd_days_seen_wo_installation_key = "gotd_days_seen_wo_installation";
    public int GOTDDaysSeenWoInstallation;
    private const string gotd_dont_show_until_key = "gotd_dont_show_until";
    public System.DateTime GOTDDontShowUntil;
    private const string lifetime_definitions_viewed = "defs_seen";
    public int LifetimeDefinitionsViewed;
    private const string ag_goal_extra_words_key = "goal_extra_words";
    public int GoalExtraWords;
    private const string ag_goal_use_hints_key = "goal_use_hints";
    public int GoalUseHints;
    private const string ag_goal_golden_currency_key = "goal_golden_curr";
    public int GoalGoldenCurrency;
    private const string ag_goal_daily_challenge_key = "goal_daily_chal";
    public int GoalDailyChallenge;
    private const string ag_goal_twitter_post_key = "goal_twitter_post";
    public int GoalTwitterPosts;
    private const string ag_goal_friend_invited_key = "goal_friend_invite";
    public int GoalFriendInvites;
    public bool MysteryGiftReceived;
    private const string ab_currentCollectionIndex_key = "ab_curr_coll_ind";
    public int ab_currentCollectionIndex;
    private const string ab_totalCollectionsComplete_key = "ab_tot_coll_com";
    public int ab_totalCollectionsComplete;
    private const string ab_currentCollectionBonus_key = "ab_curr_coll_bns";
    public decimal ab_currentCollectionBonus;
    private const string ab_currentCollectionBox_key = "ab_curr_coll_box";
    public System.Collections.Generic.List<string> ab_currentCollectionBox;
    private const string ab_currentCollectionProgress_key = "ab_curr_coll_prg";
    public System.Collections.Generic.List<string> ab_currentCollectionProgress;
    private const string ab_nextLevel_key = "ab_next_lvl";
    public int ab_nextLevel;
    private const string ab_currentLanguage_key = "ab_curr_lng";
    public string ab_currentLanguage;
    private const string ab_lifetime_redraws_key = "ab_tot_red";
    public int ab_lifeftime_redraws;
    public bool has_Active_Subscription;
    public int numSubscriptionsPurchased;
    public int numTrialSubs;
    public bool has_Active_Subscription_Silver;
    public int numSubscriptionsPurchased_Silver;
    public int numTrialSubs_Silver;
    private const string lifetime_apples_extrawords = "lt_extra_word_apples";
    public int LifetimeApplesEarnedFromExtraWords;
    private const string last_coin_spent_key = "LastCoinSpent";
    public System.DateTime LastCoinSpent;
    private const string last_gem_spent_key = "LastGemSpent";
    public System.DateTime LastGemSpent;
    public const string pp_player_iq_key = "word_player_iq";
    public float PlayerIQ;
    private const string vip_party_lifetime_purchases_key = "vip_party_lifetime_purchases";
    public int LifetimeVipPartyPurchases;
    public const string pp_lifetime_streak_key = "largest_word_streak";
    public int LifetimeLargestStreak;
    public const string pp_lifetime_profile_avatar_change = "profile_avatar_changes";
    public int LifetimeProfileAvatarChanges;
    public const string pp_lifetime_profile_name_change = "profile_name_changes";
    public int LifetimeProfileNameChanges;
    public const string ftux_tracking_key = "ftux_tracking";
    public bool FTUXWasBlockedByKnob;
    public const string pp_apple_user_id = "apple_user_id";
    public string appleUserId;
    public const string pp_verified_email = "verified_email";
    public bool verifiedEmail;
    public string ads_segment;
    public bool imported;
    public string oldSupportId;
    public const string treasure_chest_key = "treasure_chest";
    public string treasure_chest;
    public const string cp_categories = "categories";
    public const string cp_pack_progress = "ctpk_lvls";
    private System.Collections.Generic.Dictionary<int, int> cpPackProgress;
    public const string cp_pack_rewtar = "ctpk_rewtar";
    private int cpRewardTargetPacks;
    public const string cp_pack_rewcur = "ctpk_rewcur";
    private int cpRewardCurrentPacks;
    public const string golden_multiplier_key = "g_mult";
    public float GoldenMultiplier;
    public const string daily_challenge_tutorial_seen_key = "dct_seen";
    public int DailyChallengeTutorialStatus;
    public System.Collections.Generic.Dictionary<string, object> releaseEventMachineRanks;
    
    // Properties
    public EasySaver<PlayerProperties> getSaver { get; }
    public bool PurchaseHackUser { get; set; }
    private long noAdsEndTimestamp { get; }
    private long adsWatchedCooldown { get; }
    public int SetLifetimeLargestStreak { set; }
    public string CategoriesJson { get; }
    public System.Collections.Generic.Dictionary<int, int> CategoryPacksProgress { get; }
    public int CategoryRewardTargetPacks { get; set; }
    public int CategoryRewardCurrentPacks { get; set; }
    public bool nonClicker { get; }
    public bool WWWEventCollected { get; set; }
    public string profile_name { get; set; }
    public decimal CreditsPurchased { get; set; }
    public int GemsSpent { get; set; }
    
    // Methods
    public EasySaver<PlayerProperties> get_getSaver()
    {
    
    }
    public PlayerProperties(bool isPlayerNew)
    {
        var val_8;
        this.offline_fb_id = System.String.alignConst;
        this.fb_access_token = System.String.alignConst;
        this.gridSize = 10f;
        this.online_fb_id = System.String.alignConst;
        this.WWWServerTimestamp = 0;
        this.WWWEventProgress = 0;
        this.LevelsPlayedPostPurchase = 0;
        this.LastSeenDateString = "unknown";
        val_8 = 1152921504616751104;
        mem[1152921511269781652] = System.DateTime.DateDataField.__il2cppRuntimeField_C;
        this.NoAdsEndTime = System.DateTime.MinValue;
        this.profile_avatar_id = 0;
        this._profile_name = "Player";
        this.profile_location = System.String.alignConst;
        this.story_mode_vote = "None";
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if(val_1 != 0)
        {
                Add(item:  -1927030128);
        }
        else
        {
                Add(item:  -1927030128);
        }
        
        Add(item:  -1927030048);
        if(val_1 != 0)
        {
                Add(item:  -1927029968);
        }
        else
        {
                Add(item:  -1927029968);
        }
        
        Add(item:  -1927029888);
        if(val_1 != 0)
        {
                Add(item:  -1927029808);
        }
        else
        {
                Add(item:  -1927029808);
        }
        
        Add(item:  -1927029728);
        if(val_1 != 0)
        {
                Add(item:  -1927029648);
        }
        else
        {
                Add(item:  -1927029648);
        }
        
        Add(item:  -1927029568);
        if(val_1 != 0)
        {
                Add(item:  -1927029488);
        }
        else
        {
                Add(item:  -1927029488);
        }
        
        Add(item:  -1927029408);
        if(val_1 != 0)
        {
                Add(item:  -1927029328);
        }
        else
        {
                Add(item:  -1927029328);
        }
        
        Add(item:  -1927029248);
        if(val_1 != 0)
        {
                Add(item:  -1927029168);
        }
        else
        {
                Add(item:  -1927029168);
        }
        
        Add(item:  -1927029088);
        if(val_1 != 0)
        {
                Add(item:  -1927029008);
        }
        else
        {
                Add(item:  -1927029008);
        }
        
        Add(item:  -1927028928);
        if(val_1 != 0)
        {
                Add(item:  -1927028848);
        }
        else
        {
                Add(item:  -1927028848);
        }
        
        Add(item:  -1927028768);
        if(val_1 != 0)
        {
                Add(item:  -1927028688);
        }
        else
        {
                Add(item:  -1927028688);
        }
        
        Add(item:  -1927028608);
        if(val_1 != 0)
        {
                Add(item:  -1927028528);
        }
        else
        {
                Add(item:  -1927028528);
        }
        
        Add(item:  -1927028448);
        if(val_1 != 0)
        {
                Add(item:  -1927028368);
        }
        else
        {
                Add(item:  -1927028368);
        }
        
        Add(item:  -1927028288);
        if(val_1 != 0)
        {
                Add(item:  -1927028208);
        }
        else
        {
                Add(item:  -1927028208);
        }
        
        Add(item:  -1927028128);
        if(val_1 != 0)
        {
                Add(item:  -1927028048);
        }
        else
        {
                Add(item:  -1927028048);
        }
        
        Add(item:  -1927027968);
        if(val_1 != 0)
        {
                Add(item:  -1927027888);
        }
        else
        {
                Add(item:  -1927027888);
        }
        
        Add(item:  -1927027808);
        if(val_1 != 0)
        {
                Add(item:  -1927027728);
        }
        else
        {
                Add(item:  -1927027728);
        }
        
        Add(item:  -1927027648);
        if(val_1 != 0)
        {
                Add(item:  -1927027568);
        }
        else
        {
                Add(item:  -1927027568);
        }
        
        Add(item:  -1927027488);
        if(val_1 != 0)
        {
                Add(item:  -1927027408);
        }
        else
        {
                Add(item:  -1927027408);
        }
        
        Add(item:  -1927027328);
        if(val_1 != 0)
        {
                Add(item:  -1927027248);
        }
        else
        {
                Add(item:  -1927027248);
        }
        
        Add(item:  -1927027168);
        if(val_1 != 0)
        {
                Add(item:  -1927027088);
        }
        else
        {
                Add(item:  -1927027088);
        }
        
        Add(item:  -1927027008);
        if(val_1 != 0)
        {
                Add(item:  -1927026928);
        }
        else
        {
                Add(item:  -1927026928);
        }
        
        Add(item:  -1927026848);
        if(val_1 != 0)
        {
                Add(item:  -1927026768);
        }
        else
        {
                Add(item:  -1927026768);
        }
        
        Add(item:  -1927026688);
        if(val_1 != 0)
        {
                Add(item:  -1927026608);
        }
        else
        {
                Add(item:  -1927026608);
        }
        
        Add(item:  -1927026528);
        if(val_1 != 0)
        {
                Add(item:  -1927026448);
        }
        else
        {
                Add(item:  -1927026448);
        }
        
        Add(item:  -1927026368);
        if(val_1 != 0)
        {
                Add(item:  -1927026288);
        }
        else
        {
                Add(item:  -1927026288);
        }
        
        Add(item:  -1927026208);
        if(val_1 != 0)
        {
                Add(item:  -1927026128);
        }
        else
        {
                Add(item:  -1927026128);
        }
        
        Add(item:  -1927026048);
        if(val_1 != 0)
        {
                Add(item:  -1927025968);
        }
        else
        {
                Add(item:  -1927025968);
        }
        
        Add(item:  -1927025888);
        if(val_1 != 0)
        {
                Add(item:  -1927025808);
        }
        else
        {
                Add(item:  -1927025808);
        }
        
        Add(item:  -1927025728);
        if(val_1 != 0)
        {
                Add(item:  -1927025648);
        }
        else
        {
                Add(item:  -1927025648);
        }
        
        Add(item:  -1927025568);
        if(val_1 != 0)
        {
                Add(item:  -1927025488);
        }
        else
        {
                Add(item:  -1927025488);
        }
        
        Add(item:  -1927025408);
        if(val_1 != 0)
        {
                Add(item:  -1927025328);
        }
        else
        {
                Add(item:  -1927025328);
        }
        
        Add(item:  -1927025248);
        if(val_1 != 0)
        {
                Add(item:  -1927025168);
        }
        else
        {
                Add(item:  -1927025168);
        }
        
        Add(item:  1657992256);
        Add(item:  -1927027408);
        this.gdprCountries = val_1;
        this.WHDPlayerVarsTokenized = System.String.alignConst;
        this.AdsLastClickedTime = System.DateTime.MinValue;
        mem[1152921511269781708] = System.DateTime.DateDataField.__il2cppRuntimeField_C;
        this.GOTDLastShownTime = System.DateTime.MinValue;
        this.GOTDDontShowUntil = System.DateTime.MinValue;
        this.ab_currentCollectionBox = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.ab_currentCollectionProgress = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.ab_currentLanguage = "";
        this.appleUserId = System.String.alignConst;
        this.ads_segment = System.String.alignConst;
        this.oldSupportId = System.String.alignConst;
        this.treasure_chest = "{}";
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_4 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        this.cpPackProgress = null;
        GameEcon val_5 = App.getGameEcon;
        this.GoldenMultiplier = -1f;
        this.cpRewardTargetPacks = 4;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_6 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.releaseEventMachineRanks = null;
        if(isPlayerNew != false)
        {
                this.CreateNew();
        }
        else
        {
                this.LoadFromLocal();
        }
        
        EasySaver<WordPlayer> val_7 = new EasySaver<WordPlayer>(incInstance:  -1927000064);
        this.mySaver = null;
    }
    private void CreateNew()
    {
        var val_1;
        this._profile_name = "Player";
        this.offline_fb_id = System.String.alignConst;
        this.fb_access_token = System.String.alignConst;
        this.<PurchaseHackUser>k__BackingField = false;
        this.online_fb_id = System.String.alignConst;
        val_1 = null;
        val_1 = null;
        this.NoAdsEndTime = System.DateTime.MinValue;
        this.gems_spent = false;
    }
    public bool get_PurchaseHackUser()
    {
        return (bool)this.<PurchaseHackUser>k__BackingField;
    }
    public void set_PurchaseHackUser(bool value)
    {
        this.<PurchaseHackUser>k__BackingField = value;
    }
    private long get_noAdsEndTimestamp()
    {
        return twelvegigs.storage.JsonDictionary.TotalSeconds(dateTime:  new System.DateTime() {dateData = this.NoAdsEndTime});
    }
    private long get_adsWatchedCooldown()
    {
        System.DateTime val_1 = AdsManager.AdsCooldownEnd;
        return (long)twelvegigs.storage.JsonDictionary.TotalSeconds(dateTime:  new System.DateTime());
    }
    public bool ShouldShowGdprConsent()
    {
        var val_4;
        System.Collections.Generic.List<System.String> val_5;
        var val_6;
        val_4 = 0;
        string val_1 = DeviceIdPlugin.GetCountryFromLocale();
        val_5 = this.gdprCountries;
        val_6 = 0;
        if((val_5.Contains(item:  null)) == false)
        {
                return (bool)val_4;
        }
        
        val_5 = 1152921504615792640;
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        bool val_3 = this.gdprConsent;
        val_3 = val_3 ^ 1;
        val_6 = null;
        typeof(System.Object[]).__il2cppRuntimeField_14 = val_6;
        UnityEngine.Debug.LogFormat(format:  -1926347968, args:  472754880);
        val_4 = this.gdprConsent >> 5;
        return (bool)val_4;
    }
    public void set_SetLifetimeLargestStreak(int value)
    {
        this.LifetimeLargestStreak = System.Math.Max(val1:  value, val2:  this.LifetimeLargestStreak);
    }
    public string get_CategoriesJson()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1926115568, value:  this.cpPackProgress);
        int val_2 = this.CategoryRewardTargetPacks;
        Add(key:  -1926115472, value:  13152256);
        Add(key:  -1926115376, value:  13152256);
        string val_3 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  78753792);
    }
    public System.Collections.Generic.Dictionary<int, int> get_CategoryPacksProgress()
    {
    
    }
    public int get_CategoryRewardTargetPacks()
    {
        GameEcon val_1 = App.getGameEcon;
        GameEcon val_2 = App.getGameEcon;
        return UnityEngine.Mathf.Clamp(value:  this.cpRewardTargetPacks, min:  4, max:  1079);
    }
    public void set_CategoryRewardTargetPacks(int value)
    {
        this.cpRewardTargetPacks = value;
    }
    public int get_CategoryRewardCurrentPacks()
    {
        return (int)this.cpRewardCurrentPacks;
    }
    public void set_CategoryRewardCurrentPacks(int value)
    {
        this.cpRewardCurrentPacks = value;
    }
    public bool get_nonClicker()
    {
        if(this.adsNotClicked > AdsManager.getNonClickerThreshold)
        {
                0 = 1;
        }
        
        return true;
    }
    public bool get_WWWEventCollected()
    {
        int val_1 = this.wWWEventCollected;
        val_1 = val_1 - 1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public void set_WWWEventCollected(bool value)
    {
        this.wWWEventCollected = value;
    }
    public string get_profile_name()
    {
    
    }
    public void set_profile_name(string value)
    {
        this._profile_name = value;
    }
    public decimal get_CreditsPurchased()
    {
        return new System.Decimal() {flags = -1924830608, hi = R1 + 164};
    }
    public void set_CreditsPurchased(decimal value)
    {
        var val_2;
        int val_3;
        val_2 = null;
        val_2 = null;
        val_3 = value.mid;
        val_3 = value.mid;
        decimal val_1 = System.Math.Max(val1:  new System.Decimal() {flags = -1924730672, hi = value.flags, lo = value.hi, mid = value.lo}, val2:  new System.Decimal() {flags = val_3, hi = System.Decimal.Zero});
    }
    public int get_GemsSpent()
    {
        return (int)this.gems_spent;
    }
    public void set_GemsSpent(int value)
    {
        this.gems_spent = System.Math.Max(val1:  value, val2:  0);
    }
    public void UpdateData(System.Collections.IDictionary diff)
    {
        var val_9;
        var val_12;
        var val_13;
        System.Collections.IDictionary val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        val_12 = 35632631;
        val_13 = 0;
        val_12 = 0;
        val_13 = val_13 + 1;
        val_12 = (uint)val_13 & 65535;
        val_15 = diff;
        if(diff != 0)
        {
                val_13 = 0;
            val_12 = 0;
            val_13 = val_13 + 1;
            val_12 = (uint)val_13 & 65535;
            val_16 = diff;
            val_14 = diff;
            mem[1152921511272403268] = val_14;
        }
        
        val_13 = 0;
        val_12 = 0;
        val_13 = val_13 + 1;
        val_12 = (uint)val_13 & 65535;
        val_17 = diff;
        if(diff != 0)
        {
                val_13 = 0;
            val_13 = val_13 + 1;
            val_18 = diff;
            val_14 = diff;
            val_12 = 0;
            decimal val_5 = System.Decimal.Parse(s:  -1924390372);
            System.DateTime val_7 = twelvegigs.storage.JsonDictionary.ConvertToUTC(timestamp:  new System.Decimal() {flags = -1924390384});
            mem[1152921511272403392] = val_9;
        }
        
        val_19 = "total_ivds";
        val_13 = 0;
        val_12 = 0;
        val_13 = val_13 + 1;
        val_12 = (uint)val_13 & 65535;
        val_20 = diff;
        if(diff == 0)
        {
                return;
        }
        
        val_19 = "total_ivds";
        val_13 = 0;
        val_12 = 0;
        val_13 = val_13 + 1;
        val_12 = (uint)val_13 & 65535;
        val_21 = diff;
        val_14 = null;
        diff.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        mem[1152921511272403340] = null;
    }
    public void TrustServerData(System.Collections.IDictionary diff)
    {
        var val_43;
        System.Collections.IDictionary val_44;
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
        var val_58;
        var val_59;
        var val_60;
        val_44 = diff;
        if(val_44 != 0)
        {
                mem[1152921511272525108] = val_44;
        }
        
        if(val_44 != 0)
        {
                mem[1152921511272525113] = System.Boolean.Parse(value:  val_44);
        }
        
        if(val_44 != 0)
        {
                val_44.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem[1152921511272525116] = null;
        }
        
        if(val_44 != 0)
        {
                decimal val_10 = System.Decimal.Parse(s:  -1924268544);
        }
        
        if(val_44 != 0)
        {
                val_44.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem[1152921511272525136] = null;
        }
        
        if(val_44 != 0)
        {
                val_44.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem[1152921511272525140] = null;
        }
        
        if(val_44 != 0)
        {
                val_44.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem[1152921511272525144] = null;
        }
        
        if(val_44 != 0)
        {
                val_44.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem[1152921511272525148] = null;
        }
        
        if(val_44 != 0)
        {
                val_44.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem[1152921511272525152] = null;
        }
        
        if(val_44 != 0)
        {
                val_44.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem[1152921511272525156] = null;
        }
        
        if(val_44 != 0)
        {
                val_44.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem[1152921511272525160] = null;
        }
        
        if(val_44 != 0)
        {
                val_45 = "total_mga_hnt";
            var val_44 = 0;
            val_44 = val_44 + 1;
            val_46 = val_44;
            val_44.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem[1152921511272525164] = null;
        }
        
        var val_45 = 0;
        val_45 = val_45 + 1;
        val_47 = val_44;
        if(val_44 != 0)
        {
                var val_46 = 0;
            val_46 = val_46 + 1;
            val_48 = val_44;
            val_44.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem[1152921511272525172] = null;
        }
        
        var val_47 = 0;
        val_47 = val_47 + 1;
        val_49 = val_44;
        if(val_44 != 0)
        {
                var val_48 = 0;
            val_48 = val_48 + 1;
            val_50 = val_44;
            val_44.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem[1152921511272525176] = null;
        }
        
        var val_49 = 0;
        val_49 = val_49 + 1;
        val_51 = val_44;
        if(val_44 != 0)
        {
                var val_50 = 0;
            val_50 = val_50 + 1;
            val_52 = val_44;
            val_44.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem[1152921511272525204] = null;
        }
        
        var val_51 = 0;
        val_51 = val_51 + 1;
        val_53 = val_44;
        if(val_44 != 0)
        {
                var val_52 = 0;
            val_52 = val_52 + 1;
            val_54 = val_44;
            val_44.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem[1152921511272525208] = null;
        }
        
        var val_53 = 0;
        val_53 = val_53 + 1;
        val_55 = val_44;
        if(val_44 != 0)
        {
                var val_54 = 0;
            val_56 = 0;
            val_54 = val_54 + 1;
            val_57 = val_44;
            val_44.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem[1152921511272525212] = 0;
        }
        
        var val_55 = 0;
        val_58 = 0;
        val_55 = val_55 + 1;
        val_59 = val_44;
        if(val_44 != 0)
        {
                var val_56 = 0;
            val_56 = val_56 + 1;
            val_60 = val_44;
            decimal val_39 = System.Decimal.Parse(s:  -1924268544);
            System.DateTime val_41 = twelvegigs.storage.JsonDictionary.ConvertToUTC(timestamp:  new System.Decimal() {flags = -1924268552});
            mem[1152921511272525232] = val_43;
        }
        
        var val_57 = 0;
        val_57 = val_57 + 1;
        goto label_242;
    }
    public void Encode(ref System.Collections.Generic.Dictionary<string, object> jsonPlayer)
    {
    
    }
    private void LoadFromLocal()
    {
        System.DateTime val_33;
        System.DateTime val_38;
        System.DateTime val_44;
        System.DateTime val_54;
        System.DateTime val_94;
        var val_95;
        var val_114;
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  -1924044352, defaultValue:  -1927030288);
        this._profile_name = "player_profile_name";
        this.profile_avatar_id = UnityEngine.PlayerPrefs.GetInt(key:  -1924044240, defaultValue:  0);
        string val_3 = UnityEngine.PlayerPrefs.GetString(key:  -1924044112, defaultValue:  System.String.alignConst);
        this.profile_location = "player_profile_location";
        string val_4 = UnityEngine.PlayerPrefs.GetString(key:  -1924043984, defaultValue:  1295406272);
        this.<PurchaseHackUser>k__BackingField = System.Boolean.Parse(value:  -1924043984);
        string val_6 = UnityEngine.PlayerPrefs.GetString(key:  -1924043872, defaultValue:  System.String.alignConst);
        this.offline_fb_id = "player_offline_fb_id";
        string val_7 = UnityEngine.PlayerPrefs.GetString(key:  -1924043760, defaultValue:  System.String.alignConst);
        this.fb_access_token = "fb_access_token";
        string val_8 = UnityEngine.PlayerPrefs.GetString(key:  -1924043648, defaultValue:  System.String.alignConst);
        this.online_fb_id = "player_online_fb_id";
        string val_9 = UnityEngine.PlayerPrefs.GetString(key:  -1924043536, defaultValue:  -1930528128);
        this.gdprConsent = System.Boolean.Parse(value:  -1924043536);
        string val_11 = UnityEngine.PlayerPrefs.GetString(key:  -1924043424, defaultValue:  System.String.alignConst);
        this.WHDPlayerVarsTokenized = "whd_pl_vars";
        string val_12 = UnityEngine.PlayerPrefs.GetString(key:  -1924282128, defaultValue:  1295406272);
        this.InstalledFromMGDeeplink = System.Boolean.Parse(value:  -1924282128);
        this.MGPlaysCount = UnityEngine.PlayerPrefs.GetInt(key:  -1924282016, defaultValue:  0);
        string val_15 = UnityEngine.PlayerPrefs.GetString(key:  -1924281920, defaultValue:  1254115712);
        decimal val_16 = System.Decimal.Parse(s:  -1924024864, style:  -1924281920);
        this.MGAdsCount = UnityEngine.PlayerPrefs.GetInt(key:  -1924281824, defaultValue:  0);
        this.MGHintsCount = UnityEngine.PlayerPrefs.GetInt(key:  -1924281728, defaultValue:  0);
        this.LifetimeHints = UnityEngine.PlayerPrefs.GetInt(key:  -1924281632, defaultValue:  0);
        this.LifetimeFreeHints = UnityEngine.PlayerPrefs.GetInt(key:  -1924281536, defaultValue:  0);
        this.LifetimeStruggleHints = UnityEngine.PlayerPrefs.GetInt(key:  -1924281440, defaultValue:  0);
        this.LifetimeDCHints = UnityEngine.PlayerPrefs.GetInt(key:  -1924281344, defaultValue:  0);
        this.LifetimeHintPickers = UnityEngine.PlayerPrefs.GetInt(key:  -1924281248, defaultValue:  0);
        this.LifetimeMegaHints = UnityEngine.PlayerPrefs.GetInt(key:  -1924281152, defaultValue:  0);
        this.LifetimeCheckHints = UnityEngine.PlayerPrefs.GetInt(key:  -1924043328, defaultValue:  0);
        this.ChaptersPlayedWithoutHints = UnityEngine.PlayerPrefs.GetInt(key:  -1924281056, defaultValue:  0);
        this.HintsUsedOnCurrentChapter = UnityEngine.PlayerPrefs.GetInt(key:  -1924280960, defaultValue:  0);
        this.adsNotClicked = UnityEngine.PlayerPrefs.GetInt(key:  -1924043232, defaultValue:  0);
        string val_29 = System.DateTime.MinValue.ToString();
        string val_30 = UnityEngine.PlayerPrefs.GetString(key:  -1924043120, defaultValue:  -1924024848);
        System.DateTime val_31 = SLCDateTime.Parse(dateTime:  -1924024872);
        this.AdsLastClickedTime = val_33;
        string val_34 = System.DateTime.MinValue.ToString();
        string val_35 = UnityEngine.PlayerPrefs.GetString(key:  -1924043008, defaultValue:  -1924024848);
        System.DateTime val_36 = SLCDateTime.Parse(dateTime:  -1924024880);
        this.GOTDLastShownTime = val_38;
        this.GOTDDaysSeenWoInstallation = UnityEngine.PlayerPrefs.GetInt(key:  -1924042896, defaultValue:  0);
        string val_40 = System.DateTime.MinValue.ToString();
        string val_41 = UnityEngine.PlayerPrefs.GetString(key:  -1924042768, defaultValue:  -1924024848);
        System.DateTime val_42 = SLCDateTime.Parse(dateTime:  -1924024888);
        this.GOTDDontShowUntil = val_44;
        this.incentivisedVideosWatched = UnityEngine.PlayerPrefs.GetInt(key:  -1924402416, defaultValue:  0);
        this.WWWServerTimestamp = UnityEngine.PlayerPrefs.GetInt(key:  -1924280864, defaultValue:  0);
        this.WWWEventProgress = UnityEngine.PlayerPrefs.GetInt(key:  -1924280784, defaultValue:  0);
        int val_48 = UnityEngine.PlayerPrefs.GetInt(key:  -1924280688, defaultValue:  0);
        val_48 = val_48 - 1;
        val_48 = val_48 >> 5;
        this.wWWEventCollected = val_48;
        this.gridSize = "pp_grid_size";
        string val_50 = System.DateTime.MinValue.ToString();
        string val_51 = UnityEngine.PlayerPrefs.GetString(key:  -1953365392, defaultValue:  -1924024848);
        System.DateTime val_52 = SLCDateTime.Parse(dateTime:  -1924024896);
        this.NoAdsEndTime = val_54;
        this.LevelsPlayedPostPurchase = UnityEngine.PlayerPrefs.GetInt(key:  -1924280592, defaultValue:  0);
        string val_56 = UnityEngine.PlayerPrefs.GetString(key:  -1924042560, defaultValue:  1254115712);
        decimal val_57 = System.Decimal.Parse(s:  -1924024912, style:  -1924042560);
        string val_58 = UnityEngine.PlayerPrefs.GetString(key:  -1924042448, defaultValue:  -1927030384);
        this.LastSeenDateString = "last_seen_date";
        string val_59 = UnityEngine.PlayerPrefs.GetString(key:  -1924042352, defaultValue:  1295406272);
        this.SkippedTutorial = System.Boolean.Parse(value:  -1924042352);
        this.AdvancedSkipLevel = UnityEngine.PlayerPrefs.GetInt(key:  -1924042256, defaultValue:  0);
        this.LifetimeDefinitionsViewed = UnityEngine.PlayerPrefs.GetInt(key:  -1924042160, defaultValue:  0);
        this.GoalExtraWords = UnityEngine.PlayerPrefs.GetInt(key:  -1924042064, defaultValue:  0);
        this.GoalUseHints = UnityEngine.PlayerPrefs.GetInt(key:  -1924041952, defaultValue:  0);
        this.GoalGoldenCurrency = UnityEngine.PlayerPrefs.GetInt(key:  -1924041856, defaultValue:  0);
        this.GoalDailyChallenge = UnityEngine.PlayerPrefs.GetInt(key:  -1924041744, defaultValue:  0);
        this.GoalTwitterPosts = UnityEngine.PlayerPrefs.GetInt(key:  -1924041632, defaultValue:  0);
        this.GoalFriendInvites = UnityEngine.PlayerPrefs.GetInt(key:  -1924041520, defaultValue:  0);
        string val_69 = UnityEngine.PlayerPrefs.GetString(key:  -1924041408, defaultValue:  1295406272);
        this.MysteryGiftReceived = System.Boolean.Parse(value:  -1924041408);
        string val_71 = UnityEngine.PlayerPrefs.GetString(key:  -1924041296, defaultValue:  -1927030208);
        this.story_mode_vote = "story_mode_vote";
        this.ab_nextLevel = UnityEngine.PlayerPrefs.GetInt(key:  -1924041184, defaultValue:  0);
        string val_73 = UnityEngine.PlayerPrefs.GetString(key:  -1924041088, defaultValue:  -2141227328);
        object val_74 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -1924041088);
        this.ab_currentCollectionBox = "ab_curr_coll_box";
        string val_75 = UnityEngine.PlayerPrefs.GetString(key:  -1924039952, defaultValue:  -2141227328);
        object val_76 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -1924039952);
        this.ab_currentCollectionProgress = "ab_curr_coll_prg";
        string val_77 = UnityEngine.PlayerPrefs.GetString(key:  -1924039840, defaultValue:  1254115712);
        decimal val_78 = System.Decimal.Parse(s:  -1924024864);
        this.ab_currentCollectionIndex = UnityEngine.PlayerPrefs.GetInt(key:  -1924039728, defaultValue:  0);
        string val_80 = UnityEngine.PlayerPrefs.GetString(key:  -1924039616, defaultValue:  1098586544);
        this.ab_currentLanguage = "ab_curr_lng";
        this.ab_totalCollectionsComplete = UnityEngine.PlayerPrefs.GetInt(key:  -1924039520, defaultValue:  0);
        this.ab_lifeftime_redraws = UnityEngine.PlayerPrefs.GetInt(key:  -1924039408, defaultValue:  0);
        this.numSubscriptionsPurchased = UnityEngine.PlayerPrefs.GetInt(key:  -1924039312, defaultValue:  0);
        this.numTrialSubs = UnityEngine.PlayerPrefs.GetInt(key:  -1924039184, defaultValue:  0);
        string val_85 = UnityEngine.PlayerPrefs.GetString(key:  -1924039088, defaultValue:  1295406272);
        this.has_Active_Subscription = System.Boolean.Parse(value:  -1924039088);
        this.numSubscriptionsPurchased_Silver = UnityEngine.PlayerPrefs.GetInt(key:  -1924038976, defaultValue:  0);
        this.numTrialSubs_Silver = UnityEngine.PlayerPrefs.GetInt(key:  -1924038848, defaultValue:  0);
        string val_89 = UnityEngine.PlayerPrefs.GetString(key:  -1924038736, defaultValue:  1295406272);
        this.has_Active_Subscription_Silver = System.Boolean.Parse(value:  -1924038736);
        this.LifetimeApplesEarnedFromExtraWords = UnityEngine.PlayerPrefs.GetInt(key:  -1924038624, defaultValue:  0);
        string val_92 = UnityEngine.PlayerPrefs.GetString(key:  -1924038512);
        val_114 = null;
        val_114 = null;
        System.DateTime val_93 = SLCDateTime.Parse(dateTime:  -1924024912, defaultValue:  new System.DateTime() {dateData = 1152921511272743056});
        mem[1152921511272769108] = val_95;
        this.LastCoinSpent = val_94;
        this.LifetimeLargestStreak = UnityEngine.PlayerPrefs.GetInt(key:  -1924038416, defaultValue:  0);
        this.PlayerIQ = "word_player_iq";
        this.LifetimeVipPartyPurchases = UnityEngine.PlayerPrefs.GetInt(key:  -1924038208, defaultValue:  0);
        this.LifetimeProfileAvatarChanges = UnityEngine.PlayerPrefs.GetInt(key:  -1924038080, defaultValue:  0);
        this.LifetimeProfileNameChanges = UnityEngine.PlayerPrefs.GetInt(key:  -1924037968, defaultValue:  0);
        string val_101 = UnityEngine.PlayerPrefs.GetString(key:  -1924037856, defaultValue:  System.String.alignConst);
        this.ads_segment = "ads_segment";
        string val_102 = UnityEngine.PlayerPrefs.GetString(key:  -1924037760, defaultValue:  1295406272);
        this.imported = System.Boolean.Parse(value:  -1924037760);
        string val_104 = UnityEngine.PlayerPrefs.GetString(key:  -1924037664, defaultValue:  System.String.alignConst);
        this.oldSupportId = "old_support_id";
        string val_105 = UnityEngine.PlayerPrefs.GetString(key:  -1924037568, defaultValue:  System.String.alignConst);
        this.appleUserId = "apple_user_id";
        string val_106 = UnityEngine.PlayerPrefs.GetString(key:  -1924037472, defaultValue:  -2040381152);
        this.ParseCategoryPacksPlayerData(json:  -1924037472);
        string val_107 = UnityEngine.PlayerPrefs.GetString(key:  -1924037376, defaultValue:  -2040381152);
        this.treasure_chest = "treasure_chest";
        float val_108 = UnityEngine.PlayerPrefs.GetFloat(key:  -1924037280, defaultValue:  UnityEngine.PlayerPrefs.GetFloat(key:  -1924038304, defaultValue:  UnityEngine.PlayerPrefs.GetFloat(key:  -1924042656, defaultValue:  null)));
        this.GoldenMultiplier = "g_mult";
        string val_109 = UnityEngine.PlayerPrefs.GetString(key:  -1924037200, defaultValue:  1295406272);
        this.verifiedEmail = System.Boolean.Parse(value:  -1924037200);
        this.DailyChallengeTutorialStatus = UnityEngine.PlayerPrefs.GetInt(key:  -1924037104, defaultValue:  0);
        this.prizeBalloonTapped = UnityEngine.PlayerPrefs.GetInt(key:  -1924037008, defaultValue:  0);
        this.prizeBalloonAppeared = UnityEngine.PlayerPrefs.GetInt(key:  -1924036912, defaultValue:  0);
    }
    public void Save(bool writePrefs = True)
    {
        this.mySaver.SoftSaveFull();
        if(writePrefs == false)
        {
                return;
        }
        
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
    }
    private void ParseCategoryPacksPlayerData(string json)
    {
        PlayerProperties val_20;
        var val_21;
        var val_22;
        bool val_23;
        val_20 = this;
        object val_1 = MiniJSON.Json.Deserialize(json:  json);
        val_21 = 1152921504685600768;
        val_22 = 1152921510392296080;
        val_23 = "ctpk_lvls";
        if((0.ContainsKey(key:  -1926115568)) == false)
        {
            goto label_8;
        }
        
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_3 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        this.cpPackProgress = null;
        string val_4 = 0.Item[-1926115568];
        if(0 == 0)
        {
            goto label_8;
        }
        
        val_23 = mem[1179403827];
        Dictionary.Enumerator<TKey, TValue> val_5 = GetEnumerator();
        val_21 = 0;
        label_13:
        if(0.MoveNext() == false)
        {
            goto label_9;
        }
        
        if(((System.Int32.TryParse(s:  null, result: out  int val_8 = -1923786532)) == false) || ((System.Int32.TryParse(s:  R4, result: out  int val_10 = -1923786536)) == false))
        {
            goto label_13;
        }
        
        EnumerableExtentions.SetOrAdd<System.Int32, System.Int32>(dic:  78753792, key:  0, newValue:  0);
        goto label_13;
        label_9:
        0.Dispose();
        val_20 = val_20;
        val_22 = 1152921510392296080;
        label_8:
        if((0.ContainsKey(key:  -1926115376)) != false)
        {
                string val_13 = 0.Item[-1926115376];
            bool val_15 = System.Int32.TryParse(s:  null, result: out  int val_14 = -1923774056);
        }
        
        if((0.ContainsKey(key:  -1926115472)) == false)
        {
                return;
        }
        
        string val_17 = 0.Item[-1926115472];
        bool val_19 = System.Int32.TryParse(s:  null, result: out  int val_18 = -1923774060);
    }
    private void UpdateReleaseEvent(System.Collections.IDictionary diff)
    {
        var val_6;
        var val_7;
        float val_8;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_6 = diff;
        val_7 = "machine_ranks";
        val_8 = 1152921504683257856;
        var val_6 = 0;
        val_6 = val_6 + 1;
        val_10 = val_6;
        if(val_6 == 0)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.releaseEventMachineRanks = null;
        var val_7 = 0;
        val_7 = val_7 + 1;
        val_11 = val_6;
        if(val_6 != 0)
        {
                val_6 = val_6;
            val_12 = null;
            val_12 = null;
            val_13 = 0;
            if(((System.Collections.IDictionary.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_12)
        {
                val_6 = 0;
        }
        
            val_13 = val_6;
        }
        else
        {
                val_13 = 0;
        }
        
        Dictionary.Enumerator<TKey, TValue> val_4 = 0.GetEnumerator();
        val_8 = 1152921510367989680;
        val_7 = 1152921510535002416;
        label_19:
        if(0.MoveNext() == false)
        {
            goto label_17;
        }
        
        this.releaseEventMachineRanks.Add(key:  R6, value:  0);
        goto label_19;
        label_17:
        0.Dispose();
    }

}
