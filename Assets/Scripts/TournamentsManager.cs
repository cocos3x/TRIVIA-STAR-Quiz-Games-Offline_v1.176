using UnityEngine;
public class TournamentsManager : MonoSingleton<TournamentsManager>
{
    // Fields
    public const string tracked_reward_source = "Tournament Reward";
    private TournamentInfo currentTournamentInfo;
    private static bool _IsEnabled;
    private const string pp_last_tournament = "lst_tnmt";
    private TournamentInfo lastTournamentInfo;
    public System.Action OnTournamentUpdate;
    
    // Properties
    public TournamentInfo CurrentTournamentInfo { get; }
    public static bool IsEnabled { get; }
    private TournamentInfo LastTournamentInfo { get; }
    
    // Methods
    public TournamentInfo get_CurrentTournamentInfo()
    {
    
    }
    public static bool get_IsEnabled()
    {
        null = null;
        return (bool)TournamentsManager.pp_last_tournament;
    }
    private TournamentInfo get_LastTournamentInfo()
    {
        if(this.lastTournamentInfo != 0)
        {
                return;
        }
        
        if((UnityEngine.PlayerPrefs.HasKey(key:  -1669393872)) == false)
        {
                return;
        }
        
        string val_2 = UnityEngine.PlayerPrefs.GetString(key:  -1669393872, defaultValue:  -2040381152);
        object val_3 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -1669393872);
        mem2[0] = "lst_tnmt";
    }
    private void OnApplicationPause(bool pause)
    {
        var val_9;
        TournamentInfo val_10;
        var val_11;
        var val_9 = 25378698;
        val_9 = 10250256 + val_9;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        val_9 = null;
        val_9 = null;
        if(TournamentsManager.pp_last_tournament == null)
        {
                return;
        }
        
        val_10 = this.currentTournamentInfo;
        if(pause != true)
        {
                return;
        }
        
        val_11 = null;
        val_10 = this.currentTournamentInfo;
        if(val_10 != 0)
        {
                val_11 = null;
            System.Int32[] val_1 = TournamentsEconomy.rewardIndexByRank + (this.currentTournamentInfo.myRank << 2);
            System.Int32[][] val_2 = TournamentsEconomy.coinRewardsByTier + (this.currentTournamentInfo.tierIndex << 2);
            System.Int32[][] val_4 = TournamentsEconomy.gemOrPetFoodRewardsByTier;
            var val_5 = (((TournamentsEconomy.coinRewardsByTier + (this.currentTournamentInfo.tierIndex) << 2) + 16) + (((TournamentsEconomy.rewardIndexByRank + (this.currentTournamentInfo.myRank) << 2) + 16) << 2)) + (this.currentTournamentInfo.tierIndex << 2);
            var val_6 = ((((TournamentsEconomy.coinRewardsByTier + (this.currentTournamentInfo.tierIndex) << 2) + 16 + ((TournamentsEconomy.rewardIndexByRank + (this.currentTournamentInfo.myRank) << 2) + 16) << 2) + (this.cur + 16) + (((TournamentsEconomy.rewardIndexByRank + (this.currentTournamentInfo.myRank) << 2) + 16) << 2);
            System.Int32[][] val_7 = TournamentsEconomy.giftRewardsByTier + (this.currentTournamentInfo.tierIndex << 2);
            var val_10 = (TournamentsEconomy.giftRewardsByTier + (this.currentTournamentInfo.tierIndex) << 2) + 16;
            val_10 = val_10 + (((TournamentsEconomy.rewardIndexByRank + (this.currentTournamentInfo.myRank) << 2) + 16) << 2);
            if((((((TournamentsEconomy.coinRewardsByTier + (this.currentTournamentInfo.tierIndex) << 2) + 16 + ((TournamentsEconomy.rewardIndexByRank + (this.currentTournamentInfo.myRank) << 2) + 16) << 2) + (this.cu + 16) > 0)
        {
                0 = 1;
        }
        
            if((((TournamentsEconomy.coinRewardsByTier + (this.currentTournamentInfo.tierIndex) << 2) + 16 + ((TournamentsEconomy.rewardIndexByRank + (this.currentTournamentInfo.myRank) << 2) + 16) << 2) + 16) > 0)
        {
                0 = 1;
        }
        
            if((((TournamentsEconomy.giftRewardsByTier + (this.currentTournamentInfo.tierIndex) << 2) + 16 + ((TournamentsEconomy.rewardIndexByRank + (this.currentTournamentInfo.myRank) << 2) + 16) << 2) + 16) > 0)
        {
                0 = 1;
        }
        
            twelvegigs.plugins.LocalNotificationsPlugin.KillNotification(tipo:  28);
            if(1 == 0)
        {
                return;
        }
        
            System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_8 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  -1953384384, value:  -1669256176);
            twelvegigs.plugins.LocalNotificationsPlugin.PostNotification(tipo:  28, when:  new System.DateTime(), optMessage:  ((TournamentsEconomy.giftRewardsByTier + (this.currentTournamentInfo.tierIndex) << 2) + 16 + ((TournamentsEconomy.rewardIndexByRank + (this.currentTournamentInfo.myRank) << 2) + 16) << 2) + 16, extraData:  "Tournament Over! Collect your reward now!");
            return;
        }
    
    }
    public override void InitMonoSingleton()
    {
        this.InitMonoSingleton();
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = R4.gameObject;
        UnityEngine.Object.Destroy(obj:  R4);
    }
    public void OnTournamentDataResponse(System.Collections.Generic.Dictionary<string, object> responseData)
    {
        System.DateTime val_12;
        TournamentsManager val_41;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_42;
        string val_43;
        bool val_44;
        var val_45;
        float val_46;
        var val_47;
        val_41 = this;
        val_42 = responseData;
        val_43 = 1152921510392296080;
        if((val_42.ContainsKey(key:  -1987367680)) == false)
        {
            goto label_2;
        }
        
        object val_2 = val_42.Item[-1987367680];
        string val_3 = val_42.ToString();
        val_44 = System.Boolean.Parse(value:  val_42);
        val_45 = null;
        val_45 = null;
        val_42 = val_42;
        TournamentsManager.pp_last_tournament = val_44;
        if(TournamentsManager.pp_last_tournament == false)
        {
            goto label_54;
        }
        
        label_2:
        if((val_42.ContainsKey(key:  -1668998128)) == false)
        {
            goto label_54;
        }
        
        val_43 = val_42;
        this.currentTournamentInfo = new TournamentInfo();
        string val_7 = val_43.Item[-1668998128];
        int val_8 = System.Int32.Parse(s:  val_43);
        val_8 = val_8 - 1;
        typeof(TournamentInfo).__il2cppRuntimeField_8 = val_8;
        string val_9 = val_43.Item[-1668993936];
        System.DateTime val_10 = SLCDateTime.Parse(dateTime:  -1668979888);
        this.currentTournamentInfo.endTime = val_12;
        string val_13 = val_43.Item[-1668993840];
        val_46 = 0;
        val_47 = 0;
        if(val_43 != 0)
        {
                val_47 = 0;
            if(((responseData + 100 + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_43 = 0;
        }
        
            val_47 = val_43;
        }
        
        label_31:
        if(val_46 >= 0)
        {
            goto label_22;
        }
        
        if(0 <= val_46)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_41 = 0;
        val_41 = val_41 + 0;
        string val_15 = PrettyPrint.printJSON(obj:  val_43, types:  false, singleLineOutput:  false);
        string val_16 = -1668993744(-1668993744) + val_43;
        UnityEngine.Debug.LogError(message:  -1668993744);
        val_46 = val_46 + 1;
        goto label_31;
        label_22:
        val_41 = val_41;
        val_44 = 1152921510392296080;
        if((val_43.ContainsKey(key:  -1668992144)) != false)
        {
                val_46 = "last_rank";
            if((val_43.ContainsKey(key:  -1668992032)) != false)
        {
                val_43 = "last_score";
            if((val_43.ContainsKey(key:  -1668991936)) != false)
        {
                TournamentInfo val_32 = null;
            val_44 = val_32;
            val_32 = new TournamentInfo();
            string val_33 = val_43.Item[-1668992144];
            int val_34 = System.Int32.Parse(s:  val_43);
            val_34 = val_34 - 1;
            typeof(TournamentInfo).__il2cppRuntimeField_8 = val_34;
            string val_35 = val_42.Item[-1668992032];
            int val_36 = System.Int32.Parse(s:  val_42);
            val_36 = val_36 - 1;
            typeof(TournamentInfo).__il2cppRuntimeField_20 = val_36;
            string val_37 = val_42.Item[-1668991936];
            typeof(TournamentInfo).__il2cppRuntimeField_24 = System.Int32.Parse(s:  val_42);
            mem[1152921511527813744] = val_44;
            string val_39 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  301916160);
            UnityEngine.PlayerPrefs.SetString(key:  -1669393872, value:  301916160);
            bool val_40 = PrefsSerializationManager.SavePlayerPrefs();
            this.TrackTournamentRollover();
        }
        
        }
        
        }
        
        if(mem[1152921511527813748] == 0)
        {
                return;
        }
        
        mem[1152921511527813748].Invoke();
        return;
        label_54:
        this.currentTournamentInfo = 0;
    }
    public bool ShowTournamentResults()
    {
        int val_20;
        var val_40;
        var val_41;
        var val_42;
        object val_43;
        var val_44;
        var val_45;
        int val_46;
        var val_47;
        var val_48;
        int val_49;
        var val_50;
        var val_51;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_52;
        var val_53;
        TournamentInfo val_54;
        var val_55;
        val_40 = 0;
        TournamentInfo val_1 = this.LastTournamentInfo;
        if(this == 0)
        {
                return (bool)val_40;
        }
        
        val_41 = null;
        val_41 = null;
        if(this.lastTournamentInfo.myRank <= (TournamentsEconomy.rewardIndexByRank + 12))
        {
            goto label_6;
        }
        
        string val_2 = System.String.Format(format:  -1668863456, arg0:  13152256);
        val_42 = "TournamentsManager.ShowTournamentResults() - bad rank! {0} is not in range.";
        val_40 = 0;
        UnityEngine.Debug.LogError(message:  -1668863456);
        string val_3 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  this.lastTournamentInfo, formatting:  1);
        val_43 = this.lastTournamentInfo;
        val_44 = "TournamentsManager.ShowTournamentresults() bad rank:\n{0}";
        goto label_26;
        label_6:
        val_45 = null;
        val_45 = null;
        val_46 = this.lastTournamentInfo.myRank;
        System.Int32[] val_4 = TournamentsEconomy.rewardIndexByRank + (val_46 << 2);
        if(this.lastTournamentInfo.tierIndex <= (TournamentsEconomy.coinRewardsByTier + 12))
        {
            goto label_20;
        }
        
        string val_5 = System.String.Format(format:  -1668846656, arg0:  13152256);
        val_42 = "TournamentsManager.ShowTournamentResults() - bad tier index! {0} is not in range.";
        val_40 = 0;
        UnityEngine.Debug.LogError(message:  -1668846656);
        string val_6 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  this.lastTournamentInfo, formatting:  1);
        val_43 = this.lastTournamentInfo;
        val_44 = "TournamentsManager.ShowTournamentresults() bad tier index:\n{0}";
        goto label_26;
        label_20:
        val_47 = null;
        val_47 = null;
        val_46 = this.lastTournamentInfo.tierIndex;
        System.Int32[][] val_7 = TournamentsEconomy.coinRewardsByTier + (val_46 << 2);
        if(((TournamentsEconomy.rewardIndexByRank + (this.lastTournamentInfo.myRank) << 2) + 16) <= ((TournamentsEconomy.coinRewardsByTier + (this.lastTournamentInfo.tierIndex) << 2) + 16 + 12))
        {
            goto label_33;
        }
        
        string val_8 = System.String.Format(format:  -1668838016, arg0:  13152256);
        val_42 = "TournamentsManager.ShowTournamentResults() - bad reward index! {0} is not in range.";
        val_40 = 0;
        UnityEngine.Debug.LogError(message:  -1668838016);
        string val_9 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  this.lastTournamentInfo, formatting:  1);
        val_43 = this.lastTournamentInfo;
        val_44 = "TournamentsManager.ShowTournamentresults() bad reward index:\n{0}";
        label_26:
        string val_10 = System.String.Format(format:  -1668833680, arg0:  val_43);
        UnityEngine.Debug.LogError(message:  -1668833680);
        return (bool)val_40;
        label_33:
        val_48 = null;
        val_48 = null;
        System.Int32[][] val_11 = TournamentsEconomy.coinRewardsByTier + (this.lastTournamentInfo.tierIndex << 2);
        System.Int32[][] val_13 = TournamentsEconomy.gemOrPetFoodRewardsByTier;
        var val_14 = (((TournamentsEconomy.coinRewardsByTier + (this.lastTournamentInfo.tierIndex) << 2) + 16) + (((TournamentsEconomy.rewardIndexByRank + (this.lastTournamentInfo.myRank) << 2) + 16) << 2)) + (this.lastTournamentInfo.tierIndex << 2);
        var val_15 = ((((TournamentsEconomy.coinRewardsByTier + (this.lastTournamentInfo.tierIndex) << 2) + 16 + ((TournamentsEconomy.rewardIndexByRank + (this.lastTournamentInfo.myRank) << 2) + 16) << 2) + (this.lastTourn + 16) + (((TournamentsEconomy.rewardIndexByRank + (this.lastTournamentInfo.myRank) << 2) + 16) << 2);
        val_49 = mem[((((TournamentsEconomy.coinRewardsByTier + (this.lastTournamentInfo.tierIndex) << 2) + 16 + ((TournamentsEconomy.rewardIndexByRank + (this.lastTournamentInfo.myRank) << 2) + 16) << 2) + (this.lastTour + 16];
        val_49 = ((((TournamentsEconomy.coinRewardsByTier + (this.lastTournamentInfo.tierIndex) << 2) + 16 + ((TournamentsEconomy.rewardIndexByRank + (this.lastTournamentInfo.myRank) << 2) + 16) << 2) + (this.lastTour + 16;
        System.Int32[][] val_16 = TournamentsEconomy.giftRewardsByTier + (this.lastTournamentInfo.tierIndex << 2);
        var val_17 = ((TournamentsEconomy.giftRewardsByTier + (this.lastTournamentInfo.tierIndex) << 2) + 16) + (((TournamentsEconomy.rewardIndexByRank + (this.lastTournamentInfo.myRank) << 2) + 16) << 2);
        if((((TournamentsEconomy.coinRewardsByTier + (this.lastTournamentInfo.tierIndex) << 2) + 16 + ((TournamentsEconomy.rewardIndexByRank + (this.lastTournamentInfo.myRank) << 2) + 16) << 2) + 16) >= 1)
        {
                Player val_18 = App.Player;
            decimal val_19 = System.Decimal.op_Implicit(value:  -1668793692);
            0.AddCredits(amount:  new System.Decimal() {flags = (TournamentsEconomy.rewardIndexByRank + (this.lastTournamentInfo.myRank) << 2) + 16, mid = val_20}, source:  "Tournament Reward", subSource:  "Tournament Reward", externalParams:  0, doTrack:  true);
            val_49 = val_49;
        }
        
        if(val_49 >= 1)
        {
                var val_39 = 25369043;
            val_39 = 10256744 + val_39;
            if(val_39 == 0)
        {
                mem2[0] = 1;
        }
        
            val_50 = null;
            val_51 = 0;
            if(val_39 != 0)
        {
                val_51 = (App.__il2cppRuntimeField_BA & 512);
        }
        
            if(App.game == 17)
        {
                Player val_22 = App.Player;
            0.AddGems(amount:  val_49, source:  -1668821184, subsource:  -1668821184);
            Player val_23 = App.Player;
            string val_24 = val_49.ToString();
            0.TrackNonCoinReward(source:  -1668821184, subSource:  null, rewardType:  -1668821072, rewardAmount:  val_49, additionalParams:  0);
        }
        else
        {
                Player val_25 = App.Player;
            0.AddPetsFood(amount:  val_49, source:  -1668821184, subSource:  -1668821184, FoodSpentParams:  0, additionalParam:  0);
        }
        
        }
        
        val_52 = null;
        val_52 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        if((((TournamentsEconomy.giftRewardsByTier + (this.lastTournamentInfo.tierIndex) << 2) + 16 + ((TournamentsEconomy.rewardIndexByRank + (this.lastTournamentInfo.myRank) << 2) + 16) << 2) + 16) >= 1)
        {
                var val_40 = 25368559;
            val_40 = 10257228 + val_40;
            if(val_40 == 0)
        {
                mem2[0] = 1;
        }
        
            val_53 = null;
            val_53 = null;
            if(App.game == 17)
        {
                WADGiftRewardManager val_27 = WGGiftRewardManager<WADGiftRewardManager>.Instance;
            System.Collections.Generic.List<GiftReward> val_29 = GetRewards(rewardsSource:  12, expertLeveledUp: out  bool val_28 = true, cardsGranted:  ((TournamentsEconomy.giftRewardsByTier + (this.lastTournamentInfo.tierIndex) << 2) + 16 + ((TournamentsEconomy.rewardIndexByRank + (this.lastTournamentInfo.myRank) << 2) + 16) << 2) + 16);
            System.Collections.Generic.IEnumerable<TResult> val_30 = System.Linq.Enumerable.Cast<System.Object>(source:  -1668819968);
            System.Collections.Generic.List<TSource> val_31 = System.Linq.Enumerable.ToList<System.Object>(source:  -1668819968);
            val_52 = public static TRVGiftRewardManager WGGiftRewardManager<TRVGiftRewardManager>::get_Instance();
        }
        else
        {
                WADGiftRewardManager val_32 = WGGiftRewardManager<WADGiftRewardManager>.Instance;
            System.Collections.Generic.List<GiftReward> val_33 = MakeRewards(rewardType:  3, rewardAmount:  ((TournamentsEconomy.giftRewardsByTier + (this.lastTournamentInfo.tierIndex) << 2) + 16 + ((TournamentsEconomy.rewardIndexByRank + (this.lastTournamentInfo.myRank) << 2) + 16) << 2) + 16);
            val_52 = public static WADGiftRewardManager WGGiftRewardManager<WADGiftRewardManager>::get_Instance();
            WADGiftRewardManager val_34 = WGGiftRewardManager<WADGiftRewardManager>.Instance;
            CollectRewards(rewards:  -1668816896, rewardSource:  12);
        }
        
        }
        
        GameBehavior val_35 = App.getBehavior;
        val_54 = this.lastTournamentInfo;
        if(this.lastTournamentInfo != 0)
        {
            goto label_96;
        }
        
        val_54 = this.lastTournamentInfo;
        if(val_54 == 0)
        {
            goto label_97;
        }
        
        label_96:
        0.ShowResults(coinReward:  ((TournamentsEconomy.coinRewardsByTier + (this.lastTournamentInfo.tierIndex) << 2) + 16 + ((TournamentsEconomy.rewardIndexByRank + (this.lastTournamentInfo.myRank) << 2) + 16) << 2) + 16, gemsOrPetFoodReward:  val_49, giftRewards:  -1668816896, rankIndex:  this.lastTournamentInfo.myRank, lastTournamentTier:  this.lastTournamentInfo.tierIndex);
        val_55 = null;
        val_55 = null;
        GameNames val_41 = App.game;
        val_41 = val_41 - 17;
        val_41 = val_41 >> 5;
        if((val_41 & 0) != 0)
        {
                return (bool)val_40;
        }
        
        GameBehavior val_37 = App.getBehavior;
        if(0 != 0)
        {
                return (bool)val_40;
        }
        
        return (bool)val_40;
        label_97:
    }
    public void HandleTournamentResultsCollected()
    {
        this.lastTournamentInfo = 0;
        UnityEngine.PlayerPrefs.DeleteKey(key:  -1669393872);
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public void Hack_1_thru_3()
    {
        int val_8;
        int val_1 = UnityEngine.Random.Range(min:  0, max:  3);
        TournamentInfo val_2 = new TournamentInfo();
        if(val_2 != 0)
        {
                typeof(TournamentInfo).__il2cppRuntimeField_20 = val_1;
            typeof(TournamentInfo).__il2cppRuntimeField_8 = UnityEngine.Random.Range(min:  0, max:  20);
            val_8 = UnityEngine.Random.Range(min:  1, max:  1000);
        }
        else
        {
                mem[32] = val_1;
            mem[8] = UnityEngine.Random.Range(min:  0, max:  20);
            val_8 = UnityEngine.Random.Range(min:  1, max:  1000);
        }
        
        typeof(TournamentInfo).__il2cppRuntimeField_24 = val_8;
        this.lastTournamentInfo = val_2;
        bool val_7 = this.ShowTournamentResults();
    }
    public void Hack_4_thru_10()
    {
        int val_8;
        int val_1 = UnityEngine.Random.Range(min:  3, max:  10);
        TournamentInfo val_2 = new TournamentInfo();
        if(val_2 != 0)
        {
                typeof(TournamentInfo).__il2cppRuntimeField_20 = val_1;
            typeof(TournamentInfo).__il2cppRuntimeField_8 = UnityEngine.Random.Range(min:  0, max:  20);
            val_8 = UnityEngine.Random.Range(min:  1, max:  1000);
        }
        else
        {
                mem[32] = val_1;
            mem[8] = UnityEngine.Random.Range(min:  0, max:  20);
            val_8 = UnityEngine.Random.Range(min:  1, max:  1000);
        }
        
        typeof(TournamentInfo).__il2cppRuntimeField_24 = val_8;
        this.lastTournamentInfo = val_2;
        bool val_7 = this.ShowTournamentResults();
    }
    public void Hack_11_thru_30()
    {
        int val_8;
        int val_1 = UnityEngine.Random.Range(min:  10, max:  30);
        TournamentInfo val_2 = new TournamentInfo();
        if(val_2 != 0)
        {
                typeof(TournamentInfo).__il2cppRuntimeField_20 = val_1;
            typeof(TournamentInfo).__il2cppRuntimeField_8 = UnityEngine.Random.Range(min:  0, max:  20);
            val_8 = UnityEngine.Random.Range(min:  1, max:  1000);
        }
        else
        {
                mem[32] = val_1;
            mem[8] = UnityEngine.Random.Range(min:  0, max:  20);
            val_8 = UnityEngine.Random.Range(min:  1, max:  1000);
        }
        
        typeof(TournamentInfo).__il2cppRuntimeField_24 = val_8;
        this.lastTournamentInfo = val_2;
        bool val_7 = this.ShowTournamentResults();
    }
    public void Hack_31_thru_50()
    {
        int val_8;
        int val_1 = UnityEngine.Random.Range(min:  30, max:  49);
        TournamentInfo val_2 = new TournamentInfo();
        if(val_2 != 0)
        {
                typeof(TournamentInfo).__il2cppRuntimeField_20 = val_1;
            typeof(TournamentInfo).__il2cppRuntimeField_8 = UnityEngine.Random.Range(min:  0, max:  20);
            val_8 = UnityEngine.Random.Range(min:  1, max:  1000);
        }
        else
        {
                mem[32] = val_1;
            mem[8] = UnityEngine.Random.Range(min:  0, max:  20);
            val_8 = UnityEngine.Random.Range(min:  1, max:  1000);
        }
        
        typeof(TournamentInfo).__il2cppRuntimeField_24 = val_8;
        this.lastTournamentInfo = val_2;
        bool val_7 = this.ShowTournamentResults();
    }
    public void Hack_Master_Promoted()
    {
        int val_6;
        int val_1 = UnityEngine.Random.Range(min:  0, max:  10);
        TournamentInfo val_2 = new TournamentInfo();
        if(val_2 != 0)
        {
                typeof(TournamentInfo).__il2cppRuntimeField_8 = 0;
            typeof(TournamentInfo).__il2cppRuntimeField_20 = val_1;
            val_6 = UnityEngine.Random.Range(min:  1, max:  1000);
        }
        else
        {
                mem[32] = val_1;
            mem[8] = 0;
            val_6 = UnityEngine.Random.Range(min:  1, max:  1000);
        }
        
        typeof(TournamentInfo).__il2cppRuntimeField_24 = val_6;
        this.lastTournamentInfo = val_2;
        bool val_5 = this.ShowTournamentResults();
    }
    public void Hack_BronzeVII_Demoted()
    {
        int val_6;
        int val_1 = UnityEngine.Random.Range(min:  30, max:  49);
        TournamentInfo val_2 = new TournamentInfo();
        if(val_2 != 0)
        {
                typeof(TournamentInfo).__il2cppRuntimeField_8 = 19;
            typeof(TournamentInfo).__il2cppRuntimeField_20 = val_1;
            val_6 = UnityEngine.Random.Range(min:  1, max:  1000);
        }
        else
        {
                mem[32] = val_1;
            mem[8] = 19;
            val_6 = UnityEngine.Random.Range(min:  1, max:  1000);
        }
        
        typeof(TournamentInfo).__il2cppRuntimeField_24 = val_6;
        this.lastTournamentInfo = val_2;
        bool val_5 = this.ShowTournamentResults();
    }
    private void TrackTournamentRollover()
    {
        var val_6;
        if(this.lastTournamentInfo == 0)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        bool val_3 = TournamentsEconomy.RankIndexIsDemotion(rankIndex:  this.lastTournamentInfo.myRank - 1);
        Add(key:  -1667844096, value:  8945664);
        Add(key:  -1667839904, value:  13152256);
        int val_6 = this.lastTournamentInfo.myRank;
        val_6 = val_6 - 1;
        bool val_4 = TournamentsEconomy.RankIndexIsPromotion(rankIndex:  val_6);
        Add(key:  -1667835696, value:  8945664);
        Add(key:  -1667831488, value:  13152256);
        System.String[] val_5 = TournamentsEconomy.TierNames + (this.lastTournamentInfo.tierIndex << 2);
        Add(key:  -1667827280, value:  (TournamentsEconomy.TierNames + (this.lastTournamentInfo.tierIndex) << 2) + 16);
        var val_7 = 25370730;
        val_7 = 10254808 + val_7;
        if(val_7 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        App.trackerManager.track(eventName:  -1667827168, data:  78753792);
    }
    public TournamentsManager()
    {
    
    }
    private static TournamentsManager()
    {
    
    }

}
