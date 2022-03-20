using UnityEngine;
public class TRVExpertsController : MonoSingleton<TRVExpertsController>
{
    // Fields
    private const string expertsDataKey = "ExpertsData";
    private TRVExpertEcon myEcon;
    private bool initd;
    private System.Collections.Generic.Dictionary<string, TRVExpert> expertBaseData;
    private System.Collections.Generic.Dictionary<string, TRVExpertProgressData> myExperts;
    
    // Properties
    public TRVExpertEcon getEcon { get; }
    public System.Collections.Generic.Dictionary<string, TRVExpertProgressData> getProgress { get; }
    
    // Methods
    public TRVExpertEcon get_getEcon()
    {
    
    }
    public System.Collections.Generic.Dictionary<string, TRVExpertProgressData> get_getProgress()
    {
    
    }
    private void Start()
    {
        if(this.initd == true)
        {
                return;
        }
        
        R4.LoadData();
        mem2[0] = 1;
    }
    private void Init()
    {
        if(this.initd == true)
        {
                return;
        }
        
        R4.LoadData();
        mem2[0] = 1;
    }
    private void LoadData()
    {
        string val_8;
        string val_14;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.myExperts = null;
        if((CPlayerPrefs.HasKey(key:  -608402704)) == false)
        {
            goto label_32;
        }
        
        string val_3 = CPlayerPrefs.GetString(key:  -608402704);
        object val_4 = MiniJSON.Json.Deserialize(json:  -608402704);
        if("ExpertsData" != 0)
        {
                if(null == null)
        {
            goto label_21;
        }
        
        }
        
        label_21:
        Dictionary.KeyCollection<TKey, TValue> val_5 = 0.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_6 = GetEnumerator();
        label_14:
        if(MoveNext() == false)
        {
            goto label_10;
        }
        
        object val_9 = new System.Object();
        string val_10 = 0.Item[val_8];
        Deserialize(incData:  0);
        this.myExperts.Add(key:  val_8, value:  352768000);
        goto label_14;
        label_10:
        Dispose();
        label_32:
        if(this.myExperts != 0)
        {
                if(this.myExperts.Count != 0)
        {
                return;
        }
        
        }
        
        List.Enumerator<T> val_12 = GetEnumerator();
        label_20:
        if(MoveNext() == false)
        {
            goto label_19;
        }
        
        this.AddNewExpertProgress(name:  val_14, save:  false, autoUnlock:  true);
        goto label_20;
        label_19:
        Dispose();
        this.SaveData();
    }
    private void SaveData()
    {
        string val_5;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Dictionary.KeyCollection<TKey, TValue> val_2 = this.myExperts.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = GetEnumerator();
        label_7:
        if(MoveNext() == false)
        {
            goto label_3;
        }
        
        TRVExpertProgressData val_6 = this.myExperts.Item[val_5];
        string val_7 = this.myExperts.Serialize();
        Add(key:  val_5, value:  this.myExperts);
        goto label_7;
        label_3:
        Dispose();
        string val_8 = MiniJSON.Json.Serialize(obj:  78753792);
        CPlayerPrefs.SetString(key:  -608402704, val:  78753792);
        CPlayerPrefs.Save();
    }
    public void AddNewExpertCard(string name)
    {
        if((this.myExperts.ContainsKey(key:  name)) != true)
        {
                this.AddNewExpertProgress(name:  name, save:  true, autoUnlock:  true);
        }
        
        TRVExpertProgressData val_2 = this.myExperts.Item[name];
        mem2[0] = 0;
        this.SaveData();
    }
    public void AddNewExpertProgress(string name, bool save = True, bool autoUnlock = True)
    {
        var val_5;
        if((this.myExperts.ContainsKey(key:  name)) != false)
        {
                val_5 = "trying to unlock an expert that\'s already unlocked";
        }
        else
        {
                TRVExpert val_2 = this.getExpertBaseData(expertName:  name);
            if(this != 0)
        {
                object val_3 = new System.Object();
            SetupNewExpert(me:  -607951168, autoUnlock:  autoUnlock);
            this.myExperts.Add(key:  name, value:  352768000);
            if(save == false)
        {
                return;
        }
        
            this.SaveData();
            return;
        }
        
            string val_4 = -607975296(-607975296) + name;
            val_5 = "no expert data found for ";
        }
        
        UnityEngine.Debug.LogError(message:  -607975296);
    }
    public System.Collections.Generic.List<TRVExpert> DetermineExpertCards(GiftRewardSource source, out bool expertNowReadyToUpgrade, int cardsToPull = 0)
    {
        int val_3;
        System.Int32Enum val_14;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_48;
        var val_49;
        var val_50;
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        val_43 = cardsToPull;
        val_45;
        mem2[0] = 0;
        if(source <= 2)
        {
            goto label_1;
        }
        
        if(source == 3)
        {
            goto label_2;
        }
        
        if(source == 12)
        {
            goto label_3;
        }
        
        if(source != 13)
        {
            goto label_8;
        }
        
        val_46 = mem[1152921512588976604] + 24;
        val_47 = "Chapter Rewards Rewarded Video";
        goto label_16;
        label_1:
        if(source == 0)
        {
            goto label_7;
        }
        
        if(source != 1)
        {
            goto label_8;
        }
        
        val_46 = mem[1152921512588976604] + 20;
        val_47 = "Daily Bonus Rewarded Video";
        goto label_16;
        label_2:
        val_46 = mem[1152921512588976604] + 24;
        val_47 = "Chapter Rewards";
        goto label_16;
        label_3:
        val_46 = mem[1152921512588976604] + 24;
        val_47 = "Tournament Reward";
        goto label_16;
        label_7:
        val_46 = mem[1152921512588976604] + 20;
        val_47 = "Daily Bonus";
        goto label_16;
        label_8:
        val_46 = mem[1152921512588976604] + 24;
        val_47 = "Default";
        label_16:
        if(val_43 != 0)
        {
            goto label_32;
        }
        
        Dictionary.KeyCollection<TKey, TValue> val_1 = val_46.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = GetEnumerator();
        val_43 = 1152921512588941328;
        goto label_21;
        label_23:
        int val_5 = val_46.Item[val_3];
        if((UnityEngine.Random.Range(min:  0, max:  100)) < val_5)
        {
                val_5 = cardsToPull;
            val_5 = val_5 + 1;
        }
        
        label_21:
        if(MoveNext() == true)
        {
            goto label_23;
        }
        
        Dispose();
        label_32:
        val_48 = null;
        val_48 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.Dictionary<TRVExpertRarites, System.Int32> val_8 = mem[1152921512588976604].getCardRarityProbabilities;
        if(val_5 < 1)
        {
            goto label_25;
        }
        
        label_89:
        object val_9 = null;
        val_44 = val_9;
        val_9 = new System.Object();
        RandomSet val_10 = new RandomSet();
        Dictionary.KeyCollection<TKey, TValue> val_11 = mem[1152921512588976604].Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_12 = GetEnumerator();
        label_49:
        if(MoveNext() == false)
        {
            goto label_46;
        }
        
        add(item:  val_14, weight:  (float)mem[1152921512588976604].Item[val_14]);
        goto label_49;
        label_46:
        val_49 = 0 + 1;
        mem2[0] = 339;
        Dispose();
        if(val_49 != 1)
        {
                if(val_49 > 1)
        {
                0 = 1;
        }
        
            var val_38 = -607817136 + ((0 + 1)) << 2;
            val_38 = val_38 - 339;
            val_38 = val_38 >> 5;
            val_38 = 1 & val_38;
            val_50 = val_49 - val_38;
        }
        else
        {
                val_50 = 0;
        }
        
        typeof(TRVExpertsController.<>c__DisplayClass15_0).__il2cppRuntimeField_8 = roll(unweighted:  false);
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_17 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        List.Enumerator<T> val_18 = GetEnumerator();
        label_60:
        if(MoveNext() == false)
        {
            goto label_56;
        }
        
        val_51 = null;
        val_51 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  352448512, method:  new IntPtr(3687135248));
        typeof(TRVExpertsController.<>c__DisplayClass15_0).__il2cppRuntimeField_C = val_51;
        System.Collections.Generic.IEnumerable<TSource> val_22 = System.Linq.Enumerable.Where<System.Object>(source:  val_20 + 12, predicate:  7720960);
        AddRange(collection:  val_20 + 12);
        goto label_60;
        label_56:
        val_43 = val_50 + 1;
        mem2[0] = 470;
        Dispose();
        if(val_43 != 1)
        {
                if(val_43 > 1)
        {
                0 = 1;
        }
        
            var val_39 = -607817136 + ((val_50 + 1)) << 2;
            val_39 = val_39 - 470;
            val_39 = val_39 >> 5;
            val_39 = 1 & val_39;
            val_52 = val_43 - val_39;
        }
        else
        {
                val_52 = 0;
        }
        
        if(null != 0)
        {
                val_53 = null;
            val_54 = UnityEngine.Random.Range(min:  0, max:  1094062064);
        }
        else
        {
                val_53 = 12;
            val_54 = UnityEngine.Random.Range(min:  0, max:  0);
        }
        
        if(val_53 <= val_54)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((mem[1152921512588976616].ContainsKey(key:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_24) << 2) + 16 + 8)) == false)
        {
            goto label_68;
        }
        
        string val_26 = mem[1152921512588976616].Item[(System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_24) << 2) + 16 + 8];
        string val_28 = mem[1152921512588976616].Item[(System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_24) << 2) + 16 + 8];
        val_44 = 0;
        val_43 = 0;
        if(mem[1152921512588976616].level != mem[1152921512588976616].maxLevel)
        {
                val_44 = 0;
            val_43 = 0;
            if(expertNowReadyToUpgrade == 0)
        {
                string val_30 = mem[1152921512588976616].Item[(System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_24) << 2) + 16 + 8];
            ExpertLevelReq val_31 = mem[1152921512588976604].getReqFromExpert(exp:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_24) << 2) + 16, prog:  mem[1152921512588976616]);
            val_44 = mem[1152921512588976604];
            string val_32 = mem[1152921512588976616].Item[(System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_24) << 2) + 16 + 8];
            if((mem[1152921512588976616] + 12) >= (mem[1152921512588976604] + 12))
        {
                val_43 = 1;
        }
        
        }
        
        }
        
        string val_33 = mem[1152921512588976616].Item[(System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_24) << 2) + 16 + 8];
        if(mem[1152921512588976616] == 0)
        {
            goto label_81;
        }
        
        val_55 = mem[1152921512588976616];
        val_56 = mem[mem[1152921512588976616] + 12];
        val_56 = mem[1152921512588976616] + 12;
        goto label_82;
        label_68:
        this.AddNewExpertProgress(name:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_24) << 2) + 16 + 8, save:  false, autoUnlock:  true);
        goto label_85;
        label_81:
        val_55 = 12;
        val_56 = 0;
        label_82:
        mem[12] = val_56 + 1;
        if(val_44 != 0)
        {
                if(expertNowReadyToUpgrade != 0)
        {
                expertNowReadyToUpgrade = 1;
        }
        
            if(expertNowReadyToUpgrade == 0)
        {
                string val_35 = mem[1152921512588976616].Item[(System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_24) << 2) + 16 + 8];
            if((mem[1152921512588976616] + 12) >= (mem[1152921512588976604] + 12))
        {
                mem[1152921512588976604] + 12 = expertNowReadyToUpgrade;
            mem[1152921512588976616] + 12 = 1;
            mem2[0] = mem[1152921512588976616] + 12;
        }
        
        }
        
        }
        
        label_85:
        val_48 = val_48;
        Add(item:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_24) << 2) + 16);
        if(1 < val_5)
        {
            goto label_89;
        }
        
        label_25:
        this.SaveData();
        Player val_36 = App.Player;
        string val_37 = val_5.ToString();
        0.TrackNonCoinReward(source:  -607842384, subSource:  null, rewardType:  -1050421328, rewardAmount:  val_5, additionalParams:  0);
    }
    public bool UpgradeExpert(string name)
    {
        int val_14;
        TRVExpertEcon val_18;
        var val_19;
        TRVExpertEcon val_20;
        var val_21;
        var val_22;
        var val_23;
        object val_1 = null;
        val_18 = val_1;
        val_1 = new System.Object();
        TRVExpert val_2 = this.getExpertBaseData(expertName:  name);
        typeof(TRVExpertsController.<>c__DisplayClass16_0).__il2cppRuntimeField_8 = this;
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_3 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  352501760, method:  new IntPtr(3687270736));
        object val_4 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  this.myEcon.expertLevelUpEcon, predicate:  7720960);
        if((this.myExperts.ContainsKey(key:  name)) == false)
        {
            goto label_4;
        }
        
        TRVExpertProgressData val_6 = this.myExperts.Item[name];
        if(this.myEcon.expertLevelUpEcon == 0)
        {
            goto label_6;
        }
        
        ExpertLevelReq val_7 = this.myEcon.getReqFromExpert(exp:  -607654064, prog:  this.myExperts);
        val_18 = this.myEcon;
        val_19 = 0;
        Player val_8 = App.Player;
        val_18 = mem[this.myEcon + 16];
        val_18 = this.myEcon + 16;
        val_19 = 0;
        decimal val_9 = System.Decimal.op_Implicit(value:  -607666116);
        val_20 = val_18;
        if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = 52, hi = 52, lo = 256, mid = 256}, d2:  new System.Decimal())) == false)
        {
                return (bool)val_19;
        }
        
        var val_18 = this.myEcon + 12;
        val_18 = (this.myExperts + 12) - val_18;
        mem2[0] = val_18;
        if((this.myEcon + 16) >= 1)
        {
                Player val_11 = App.Player;
            var val_12 = 0 - (this.myEcon + 16);
            decimal val_13 = System.Decimal.op_Implicit(value:  -607666116);
            0.AddCredits(amount:  new System.Decimal() {mid = val_14}, source:  "ExpertUpgrade", subSource:  0, externalParams:  0, doTrack:  true);
            val_20 = val_18;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_15 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1988575600, value:  13152256);
        Add(key:  -607679056, value:  13152256);
        var val_19 = this.myEcon + 12;
        val_19 = val_19 + (this.myExperts + 12);
        if(null == 0)
        {
            goto label_25;
        }
        
        Add(key:  -607678944, value:  13152256);
        goto label_26;
        label_4:
        val_19 = 0;
        val_21 = "can\'t ugprade if we don\'t have data";
        goto label_29;
        label_6:
        typeof(System.Object[]).__il2cppRuntimeField_10 = "issue finding rarity econ for ";
        typeof(System.Object[]).__il2cppRuntimeField_14 = name;
        typeof(System.Object[]).__il2cppRuntimeField_18 = " rarity : ";
        typeof(System.Object[]).__il2cppRuntimeField_1C = null;
        val_19 = 0;
        string val_16 = +472754880;
        val_21 = null;
        label_29:
        UnityEngine.Debug.LogError(message:  472754880);
        return (bool)val_19;
        label_25:
        Add(key:  -607678944, value:  13152256);
        label_26:
        Add(key:  -607678464, value:  name);
        int val_17 = this.myExperts.level;
        val_17 = val_17 + 1;
        Add(key:  -607678384, value:  13152256);
        var val_20 = this.myExperts + 28;
        val_20 = val_20 ^ 1;
        Add(key:  -607678288, value:  8945664);
        Add(key:  -607678176, value:  8945664);
        var val_21 = 27600446;
        val_21 = 8025092 + val_21;
        if(val_21 == 0)
        {
                mem2[0] = 1;
        }
        
        val_22 = null;
        val_22 = null;
        val_23 = null;
        val_23 = null;
        App.trackerManager.track(eventName:  Events.CARDS_SPENT, data:  78753792);
        this.myExperts.UpgradeExpert();
        this.SaveData();
        return (bool)val_19;
    }
    public TRVExpert getExpertBaseData(string expertName)
    {
        TRVExpert val_7;
        string val_12;
        var val_13;
        val_12 = expertName;
        if(this.expertBaseData != 0)
        {
            goto label_18;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.expertBaseData = null;
        List.Enumerator<T> val_2 = GetEnumerator();
        label_13:
        if(MoveNext() == false)
        {
            goto label_4;
        }
        
        List.Enumerator<T> val_5 = GetEnumerator();
        label_10:
        if(MoveNext() == false)
        {
            goto label_7;
        }
        
        this.expertBaseData.Add(key:  val_7 + 8, value:  val_7);
        goto label_10;
        label_7:
        var val_8 = 0 + 1;
        mem2[0] = 109;
        Dispose();
        if(val_8 == 1)
        {
            goto label_13;
        }
        
        if((-607494672 + ((0 + 1)) << 2) == 109)
        {
                val_8 = val_8 >> 31;
            val_8 = ~(val_8 >> 31);
            val_8 = val_8 + val_8;
        }
        
        goto label_13;
        label_4:
        Dispose();
        val_12 = val_12;
        label_18:
        if((0.ContainsKey(key:  val_12)) != false)
        {
                TRVExpert val_11 = this.expertBaseData.Item[val_12];
            val_13 = this.expertBaseData;
            return;
        }
        
        val_13 = 0;
        string val_12 = -607506672(-607506672) + val_12;
        UnityEngine.Debug.LogError(message:  -607506672);
    }
    public bool AskExpert(TRVExpert exp, string subCat, out TRVExpertOutcomes result)
    {
        System.Int32Enum val_13;
        var val_23;
        TRVExpertsController val_25;
        float val_26;
        TRVExpert val_27;
        float val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        val_25 = this;
        val_26 = 1152921512589517136;
        val_27 = exp;
        object val_1 = null;
        val_29 = val_1;
        val_1 = new System.Object();
        typeof(TRVExpertsController.<>c__DisplayClass18_0).__il2cppRuntimeField_8 = subCat;
        result = 0;
        if((this.myExperts.ContainsKey(key:  exp.expertName)) == false)
        {
            goto label_4;
        }
        
        TRVExpertProgressData val_3 = this.myExperts.Item[exp.expertName];
        val_25 = 1152921504614567936;
        val_27 = null;
        val_26 = 1152921512569794864;
        val_27 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  352555008, method:  new IntPtr(3687630016));
        if((System.Linq.Enumerable.Any<MessageTypeSubscribers>(source:  this.myExperts, predicate:  7720960)) == false)
        {
            goto label_7;
        }
        
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_6 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  352555008, method:  new IntPtr(3687632064));
        object val_7 = System.Linq.Enumerable.First<System.Object>(source:  this.myExperts, predicate:  7720960);
        val_29 = mem[1152921512589476956];
        System.Collections.Generic.Dictionary<TRVExpertOutcomes, System.Int32> val_8 = val_29.getOutcomesByLevel(level:  7720960);
        if(val_29 == 0)
        {
            goto label_10;
        }
        
        RandomSet val_9 = null;
        val_29 = val_9;
        val_9 = new RandomSet();
        Dictionary.KeyCollection<TKey, TValue> val_10 = val_29.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_11 = GetEnumerator();
        val_26 = 1152921512589450432;
        label_14:
        if(MoveNext() == false)
        {
            goto label_12;
        }
        
        add(item:  val_13, weight:  (float)val_29.Item[val_13]);
        goto label_14;
        label_4:
        val_30 = 0;
        val_31 = "failing to get expert progress data, this should never happen";
        goto label_17;
        label_7:
        val_30 = 0;
        val_32 = "broken proficiency data for ";
        string val_15 = -607329920(-607329920) + exp + 8(exp + 8);
        goto label_18;
        label_12:
        Dispose();
        val_25 = val_25;
        val_27 = val_27;
        val_28 = val_26;
        result = roll(unweighted:  false);
        Player val_17 = App.Player;
        WordForest.WFOGameEcon val_18 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        object val_19 = mem[1152921512476916376].Item[2];
        if(0 == (mem[1152921512476916376] + 12))
        {
                mem[1152921512476916376] + 12 = 2;
            result = mem[1152921512476916376] + 12;
        }
        
        TRVExpertProgressData val_20 = this.myExperts.Item[exp + 8];
        System.DateTime val_21 = DateTimeCheat.UtcNow;
        mem2[0] = val_23;
        this.SaveData();
        val_30 = 1;
        return (bool)val_30;
        label_10:
        val_23 = null;
        val_30 = 0;
        val_32 = "no econ defined for prof level of ";
        string val_24 = -607328768(-607328768) + 13152256;
        label_18:
        val_31 = val_32;
        label_17:
        UnityEngine.Debug.LogError(message:  -607328768);
        return (bool)val_30;
    }
    public System.Collections.Generic.List<TRVExpert> GetExpertsWithProf(string subcat)
    {
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_8;
        object val_1 = new System.Object();
        typeof(TRVExpertsController.<>c__DisplayClass19_0).__il2cppRuntimeField_8 = subcat;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        List.Enumerator<T> val_3 = GetEnumerator();
        label_8:
        if(MoveNext() == false)
        {
            goto label_4;
        }
        
        val_8 = null;
        val_8 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  352608256, method:  new IntPtr(3687791568));
        typeof(TRVExpertsController.<>c__DisplayClass19_0).__il2cppRuntimeField_10 = val_8;
        System.Collections.Generic.IEnumerable<TSource> val_7 = System.Linq.Enumerable.Where<System.Object>(source:  val_5 + 12, predicate:  7720960);
        AddRange(collection:  val_5 + 12);
        goto label_8;
        label_4:
        Dispose();
    }
    public string GetOverridenCategoryName(string baseName)
    {
        var val_27;
        string val_28;
        System.Func<TRVCategoryProficiencies, System.Int32> val_30;
        var val_31;
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_32;
        var val_33;
        var val_35;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        val_27 = this;
        val_28 = baseName;
        object val_1 = null;
        val_30 = val_1;
        val_1 = new System.Object();
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_3 = GetExpertForSpecialCategory(subCategory:  val_28);
        val_31 = public static TRVSpecialCategoriesManager MonoSingleton<TRVSpecialCategoriesManager>::get_Instance();
        if(val_30 != 0)
        {
                typeof(TRVExpertsController.<>c__DisplayClass20_0).__il2cppRuntimeField_8 = val_31;
        }
        else
        {
                mem[8] = val_31;
            val_31 = mem[8];
        }
        
        if((System.String.IsNullOrEmpty(value:  -607046320)) == true)
        {
            goto label_6;
        }
        
        List.Enumerator<T> val_5 = GetEnumerator();
        val_27 = 1152921512589745488;
        label_13:
        if(MoveNext() == false)
        {
            goto label_9;
        }
        
        val_32 = null;
        val_32 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  352661504, method:  new IntPtr(3687930192));
        typeof(TRVExpertsController.<>c__DisplayClass20_0).__il2cppRuntimeField_C = val_32;
        object val_9 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  val_7 + 12, predicate:  7720960);
        if((val_7 + 12) == 0)
        {
            goto label_13;
        }
        
        val_28 = 1152921504959561728;
        val_33 = null;
        val_33 = null;
        val_30 = TRVExpertsController.<>c.<>9__20_1;
        if(val_30 == 0)
        {
                val_30 = null;
            val_30 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  TRVExpertsController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3687933264));
            TRVExpertsController.<>c.<>9__20_1 = val_30;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_11 = System.Linq.Enumerable.OrderByDescending<System.Object, System.Int32>(source:  val_7 + 12 + 28, keySelector:  7720960);
        System.Collections.Generic.List<TSource> val_12 = System.Linq.Enumerable.ToList<System.Object>(source:  val_7 + 12 + 28);
        if((val_7 + 12 + 28 + 12) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_35 = mem[val_7 + 12 + 28 + 8 + 16 + 8];
        val_35 = val_7 + 12 + 28 + 8 + 16 + 8;
        Dispose();
        return;
        label_9:
        Dispose();
        val_28 = val_28;
        label_6:
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_14 = GetEnglishIconNameForCategory(cat:  val_28);
        val_35 = public static TRVUtils MonoSingleton<TRVUtils>::get_Instance();
        string val_15 = ToLower();
        uint val_16 = _PrivateImplementationDetails_.ComputeStringHash(s:  -612557856);
        if(val_16 > 2399548189)
        {
            goto label_27;
        }
        
        if(val_16 > 914013912)
        {
            goto label_28;
        }
        
        if(val_16 > 307769103)
        {
            goto label_29;
        }
        
        if(val_16 == 263667913)
        {
            goto label_30;
        }
        
        if(val_16 != 307769103)
        {
                return;
        }
        
        bool val_17 = System.String.op_Equality(a:  -612557856, b:  -607030960);
        val_37 = "Brands";
        goto label_68;
        label_27:
        if(val_16 > 3124598252)
        {
            goto label_33;
        }
        
        if(val_16 > 2712618118)
        {
            goto label_34;
        }
        
        if(val_16 == 2463126185)
        {
            goto label_35;
        }
        
        if(val_16 != 2712618118)
        {
                return;
        }
        
        val_38 = "aussie celebrities";
        goto label_66;
        label_28:
        if(val_16 > 2310791828)
        {
            goto label_38;
        }
        
        if(val_16 == 2310791828)
        {
            goto label_39;
        }
        
        if(val_16 != 1452907016)
        {
                return;
        }
        
        val_39 = "premier league";
        goto label_41;
        label_33:
        if(val_16 > 3789706847)
        {
            goto label_42;
        }
        
        if(val_16 == 3194730279)
        {
            goto label_43;
        }
        
        if(val_16 != 3789706847)
        {
                return;
        }
        
        bool val_18 = System.String.op_Equality(a:  -612557856, b:  -607030576);
        val_37 = "Reality TV";
        goto label_68;
        label_29:
        if(val_16 == 707037262)
        {
            goto label_46;
        }
        
        if(val_16 != 914013912)
        {
                return;
        }
        
        val_38 = "uk celebrities";
        goto label_66;
        label_34:
        if(val_16 == 2752415586)
        {
            goto label_49;
        }
        
        if(val_16 != 3124598252)
        {
                return;
        }
        
        val_40 = "indian tv";
        goto label_61;
        label_38:
        if(val_16 == 2320420607)
        {
            goto label_52;
        }
        
        if(val_16 == 2329595421)
        {
            goto label_53;
        }
        
        if(val_16 != 2399548189)
        {
                return;
        }
        
        val_40 = "telenovelas";
        goto label_61;
        label_42:
        if(val_16 == 3828302141)
        {
            goto label_56;
        }
        
        if(val_16 == 3863069269)
        {
            goto label_57;
        }
        
        if(val_16 != 4288999512)
        {
                return;
        }
        
        bool val_19 = System.String.op_Equality(a:  -612557856, b:  -607030080);
        val_37 = "Animated Movies";
        goto label_68;
        label_30:
        bool val_20 = System.String.op_Equality(a:  -612557856, b:  -607029872);
        val_37 = "Rock Music";
        goto label_68;
        label_35:
        val_40 = "uk tv";
        goto label_61;
        label_39:
        bool val_21 = System.String.op_Equality(a:  -612557856, b:  -607029616);
        val_37 = "Football";
        goto label_68;
        label_43:
        val_41 = "musica latinoamericana";
        goto label_63;
        label_46:
        val_41 = "uk music";
        label_63:
        bool val_22 = System.String.op_Equality(a:  -612557856, b:  -607029328);
        val_37 = "Pop Music";
        goto label_68;
        label_49:
        bool val_23 = System.String.op_Equality(a:  -612557856, b:  -607029136);
        val_37 = "TV 10s";
        goto label_68;
        label_53:
        val_38 = "bollywood celebrities";
        goto label_66;
        label_57:
        val_39 = "futbol";
        label_41:
        bool val_24 = System.String.op_Equality(a:  -612557856, b:  -607028848);
        val_37 = "Soccer";
        goto label_68;
        label_52:
        val_40 = "aussie tv";
        label_61:
        bool val_25 = System.String.op_Equality(a:  -612557856, b:  -607028688);
        val_37 = "Sitcoms";
        goto label_68;
        label_56:
        val_38 = "Celebridades Latinoamericanos";
        label_66:
        val_37 = "Celebrities";
        label_68:
        if((System.String.op_Equality(a:  -612557856, b:  -607028496)) == true)
        {
                val_35 = val_37;
        }
    
    }
    public bool AnyExpertReadyToUpgrade()
    {
        string val_4;
        var val_10;
        Dictionary.KeyCollection<TKey, TValue> val_1 = this.myExperts.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_2 = GetEnumerator();
        label_12:
        if(MoveNext() == false)
        {
            goto label_3;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        TRVExpert val_6 = getExpertBaseData(expertName:  val_4);
        TRVExpertProgressData val_7 = this.myExperts.Item[val_4];
        ExpertLevelReq val_8 = this.myEcon.getReqFromExpert(exp:  -829531920, prog:  this.myExperts);
        if(this.myEcon == 0)
        {
            goto label_12;
        }
        
        TRVExpertProgressData val_9 = this.myExperts.Item[val_4];
        if(val_4 < this.myEcon.defaultUnlockedExperts)
        {
            goto label_12;
        }
        
        val_10 = 1;
        goto label_13;
        label_3:
        val_10 = 0;
        label_13:
        Dispose();
        return (bool)val_10;
    }
    public System.Collections.Generic.List<TRVExpert> GetAllExpertsReadyToUpgrade()
    {
        string val_5;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Dictionary.KeyCollection<TKey, TValue> val_2 = this.myExperts.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = GetEnumerator();
        label_14:
        if(MoveNext() == false)
        {
            goto label_3;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        TRVExpert val_7 = getExpertBaseData(expertName:  val_5);
        TRVExpertProgressData val_8 = this.myExperts.Item[val_5];
        ExpertLevelReq val_9 = this.myEcon.getReqFromExpert(exp:  -829531920, prog:  this.myExperts);
        if(this.myEcon == 0)
        {
            goto label_14;
        }
        
        TRVExpertProgressData val_10 = this.myExperts.Item[val_5];
        if(val_5 < this.myEcon.defaultUnlockedExperts)
        {
            goto label_14;
        }
        
        Add(item:  -829531920);
        goto label_14;
        label_3:
        Dispose();
    }
    public TRVExpertsController()
    {
    
    }

}
