using UnityEngine;
public class WADPetsManager : MonoSingleton<WADPetsManager>
{
    // Fields
    public bool QHACK_UseMinutes;
    private WADPets.WADPetsUtils petsUtils;
    private static WADPets.WADPetsUtils notreally_staticPetsUtils;
    private WADPets.WADPetsStatus petsStatus;
    private WADPets.LevelTracking levelTrackingInfo;
    private WADPets.LevelTracking savedLevelTrackingInfo;
    private WADPets.LifetimeTracking <LifetimeTrackingInfo>k__BackingField;
    private bool <IsDataInitialized>k__BackingField;
    private GameStoreCategory foodStoreCategory;
    private bool packagesAdded;
    
    // Properties
    public WADPets.LifetimeTracking LifetimeTrackingInfo { get; set; }
    public bool IsDataInitialized { get; set; }
    private static System.Collections.Generic.List<WADPets.WADPet> AllPetsCollection { get; }
    
    // Methods
    public WADPets.LifetimeTracking get_LifetimeTrackingInfo()
    {
    
    }
    private void set_LifetimeTrackingInfo(WADPets.LifetimeTracking value)
    {
        this.<LifetimeTrackingInfo>k__BackingField = value;
    }
    public bool get_IsDataInitialized()
    {
        return (bool)this.<IsDataInitialized>k__BackingField;
    }
    private void set_IsDataInitialized(bool value)
    {
        this.<IsDataInitialized>k__BackingField = value;
    }
    private static System.Collections.Generic.List<WADPets.WADPet> get_AllPetsCollection()
    {
        if(WADPetsManager.notreally_staticPetsUtils != 0)
        {
                return WADPetsManager.notreally_staticPetsUtils.AllPetsInfo;
        }
        
        return WADPetsManager.notreally_staticPetsUtils.AllPetsInfo;
    }
    private void TrustingServerData(Notification notif)
    {
        float val_15;
        var val_16;
        if(notif == 0)
        {
                return;
        }
        
        if(notif.data == 0)
        {
                return;
        }
        
        if(((System.Collections.Hashtable.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                notif.data = 0;
        }
        
        if((notif.data.ContainsKey(key:  -1824160224)) == false)
        {
                return;
        }
        
        val_15 = 1152921510385703632;
        string val_2 = notif.data.Item[-1824160224];
        if((System.String.IsNullOrEmpty(value:  null)) == true)
        {
                return;
        }
        
        string val_4 = notif.data.Item[-1824160224];
        object val_5 = MiniJSON.Json.Deserialize(json:  null);
        val_16 = 0;
        Dictionary.Enumerator<TKey, TValue> val_6 = GetEnumerator();
        label_24:
        if(0.MoveNext() == false)
        {
            goto label_19;
        }
        
        object val_9 = new System.Object();
        typeof(WADPetsManager.<>c__DisplayClass16_0).__il2cppRuntimeField_8 = 0;
        int val_10 = System.Int32.Parse(s:  R6, style:  511);
        System.Collections.Generic.List<WADPets.WADPet> val_11 = WADPetsManager.AllPetsCollection;
        System.Predicate<ZooTile> val_12 = new System.Predicate<ZooTile>(object:  335515648, method:  new IntPtr(3323350704));
        object val_13 = val_10.Find(match:  8040448);
        if(val_10 == 0)
        {
            goto label_24;
        }
        
        val_10.Upgrade(hackLevel:  val_10 + 1);
        goto label_24;
        label_19:
        0.Dispose();
    }
    public override void InitMonoSingleton()
    {
        this.Initialize();
    }
    public System.Collections.Generic.Dictionary<string, int> SerializeUnlockedPets()
    {
        System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32> val_1 = new System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32>();
        System.Collections.Generic.List<WADPets.WADPet> val_2 = WADPetsManager.GetUnlockedPets();
        List.Enumerator<T> val_3 = GetEnumerator();
        label_7:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        var val_6 = (val_5 + 8) + 8;
        UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        mem2[0] = ;
        Add(key:  431575040, value:  (val_5 + 12) - 1);
        goto label_7;
        label_2:
        Dispose();
    }
    public bool IsPetMaxLevel(WADPets.WADPet pet)
    {
        int val_1 = this.GetMaxLevel();
        val_1 = pet.LevelIndex - val_1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public void ShowPetUnlockedPopup(WADPets.WADPet pet)
    {
        var val_9;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = GetWindow<System.Object>();
        if(isActiveAndEnabled != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_9 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
            object val_6 = GetWindow<System.Object>();
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_9 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
            object val_8 = ShowUGUIMonolith<System.Object>(showNext:  true);
        }
        
        Setup(pet:  pet);
    }
    public void ShowFeedYourPetsPopup()
    {
        if(WADPetsManager.IsAnyPetHungry() == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_3 = ShowUGUIMonolith<System.Object>(showNext:  true);
    }
    public void ResetPetStats()
    {
        var val_4;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        List.Enumerator<T> val_2 = GetEnumerator();
        label_4:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        if(val_4 != 0)
        {
                public System.Boolean List.Enumerator<WADPets.WADPet>::MoveNext() = mem[val_4 + 16];
            public System.Boolean List.Enumerator<WADPets.WADPet>::MoveNext() = val_4 + 16;
        }
        
        if((public System.Boolean List.Enumerator<WADPets.WADPet>::MoveNext()) == 0)
        {
            goto label_4;
        }
        
        goto label_4;
        label_2:
        Dispose();
    }
    public bool FeedAllPets()
    {
        System.DateTime val_11;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        val_16 = 1152921504892043264;
        Player val_1 = App.Player;
        val_17 = 1152921505038209024;
        val_18 = null;
        val_18 = null;
        val_19 = 0;
        if(1 < WADPets.WADPetsEcon.FeedCost)
        {
                return (bool)val_19;
        }
        
        val_20 = null;
        val_20 = null;
        typeof(WADPets.Tracking_FoodSpent).__il2cppRuntimeField_8 = WADPets.WADPetsEcon.FeedCost;
        Player val_3 = App.Player;
        typeof(WADPets.Tracking_FoodSpent).__il2cppRuntimeField_C = 1;
        Player val_4 = App.Player;
        int val_16 = WADPets.WADPetsEcon.FeedCost;
        val_16 = 1 - val_16;
        typeof(WADPets.Tracking_FoodSpent).__il2cppRuntimeField_10 = val_16;
        Player val_5 = App.Player;
        0.AddPetsFood(amount:  0 - WADPets.WADPetsEcon.FeedCost, source:  -970802896, subSource:  null, FoodSpentParams:  new WADPets.Tracking_FoodSpent(), additionalParam:  0);
        Player val_7 = App.Player;
        0.SaveState();
        NotificationCenter val_8 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -970770496, aName:  -973115712);
        System.DateTime val_9 = DateTimeCheat.UtcNow;
        this.petsStatus.LastFedUtcTime = val_11;
        this.SchedulePetHungryLPN();
        val_17 = 1152921504901095424;
        val_16 = 1152921511025997392;
        twelvegigs.Autopilot.AutopilotManager val_12 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  2124183120)) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            ToggleIncentivizedButton();
        }
        
        NotificationCenter val_15 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -970770496, aName:  -970794608);
        val_19 = 1;
        return (bool)val_19;
    }
    public System.TimeSpan GetTimeCountdownToNextFeed()
    {
        ulong val_2;
        ulong val_13;
        WADPetsManager val_14;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        val_13 = mem[R1 + 20 + 8];
        val_13 = R1 + 20 + 8;
        val_14 = 0;
        if((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = val_13})) != false)
        {
                this = val_14;
            mem[1152921512226131268] = val_14;
            return new System.TimeSpan() {_ticks = val_12._ticks};
        }
        
        val_14 = mem[R1 + 12];
        val_14 = R1 + 12;
        var val_5 = (R1 + 20) + 8;
        val_13 = 1152921505038209024;
        val_16 = null;
        if(val_14 != 0)
        {
                val_17 = null;
            val_18 = 1152921504616751104;
            System.DateTime val_7 = AddMinutes(value:  null);
            val_19 = null;
        }
        else
        {
                val_20 = null;
            System.DateTime val_8 = AddHours(value:  null);
            val_19 = null;
            val_18 = 1152921504616751104;
        }
        
        System.DateTime val_9 = DateTimeCheat.UtcNow;
        System.TimeSpan val_12 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512226131264}, d2:  new System.DateTime() {dateData = val_2});
        return new System.TimeSpan() {_ticks = val_12._ticks};
    }
    public void UpgradePet(WADPets.WADPet pet)
    {
        WADPetsManager val_9;
        var val_10;
        val_9 = this;
        if(pet != 0)
        {
                WADPets.WADPetUpgradeRequirement val_1 = WADPetsManager.GetUpgradeRequirement(levelIndex:  pet.LevelIndex);
            val_10 = pet.LevelIndex;
        }
        else
        {
                WADPets.WADPetUpgradeRequirement val_2 = WADPetsManager.GetUpgradeRequirement(levelIndex:  0);
            val_10 = 0;
        }
        
        if(pet.Cards < 0)
        {
                return;
        }
        
        Player val_3 = App.Player;
        var val_4 = 0 + 60;
        val_10 = 0;
        decimal val_5 = System.Decimal.op_Implicit(value:  -970546260);
        if((System.Decimal.op_LessThan(d1:  new System.Decimal() {flags = mem[(0 + 60) + (0)], hi = mem[(0 + 60) + (4)], lo = mem[(0 + 60) + (8)], mid = mem[(0 + 60) + (12)]}, d2:  new System.Decimal())) != false)
        {
                GameBehavior val_7 = App.getBehavior;
            0.Init(outOfCredits:  true, onCloseAction:  0);
            return;
        }
        
        pet.Upgrade(hackLevel:  0);
        NotificationCenter val_9 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -970534208, aName:  -970794608);
    }
    public bool IsAnyUpgradeAvailable()
    {
        bool val_4;
        var val_5;
        System.Predicate<WADPets.WADPet> val_7;
        val_4 = static_value_021FD232;
        if(val_4 != true)
        {
                val_4 = true;
        }
        
        System.Collections.Generic.List<WADPets.WADPet> val_1 = WADPetsManager.AllPetsCollection;
        val_5 = null;
        val_5 = null;
        val_7 = WADPetsManager.<>c.<>9__26_0;
        if(val_7 == 0)
        {
                val_7 = null;
            val_7 = new System.Predicate<ZooTile>(object:  WADPetsManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3324525184));
            WADPetsManager.<>c.<>9__26_0 = val_7;
        }
        
        object val_3 = val_4.Find(match:  8040448);
        if(val_4 != 0)
        {
                val_4 = 1;
        }
        
        return true;
    }
    public WADPets.WADPet GetAnyUpgradeablePet(bool onlyUnlockable = False)
    {
        twelvegigs.sweepstakes.Distribution val_5;
        int val_8;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.List<WADPets.WADPet> val_2 = WADPetsManager.AllPetsCollection;
        List.Enumerator<T> val_3 = GetEnumerator();
        label_11:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        if(onlyUnlockable == false)
        {
            goto label_3;
        }
        
        val_8 = 0;
        if((val_5 + 16) != 0)
        {
            goto label_11;
        }
        
        goto label_6;
        label_3:
        val_8 = mem[val_5 + 12];
        val_8 = val_5 + 12;
        label_6:
        WADPets.WADPetUpgradeRequirement val_6 = WADPetsManager.GetUpgradeRequirement(levelIndex:  val_8);
        if((val_5 + 20) < (val_5 + 12 + 8))
        {
            goto label_11;
        }
        
        Add(item:  val_5);
        goto label_11;
        label_2:
        Dispose();
        int val_7 = UnityEngine.Random.Range(min:  0, max:  1094062064);
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
    }
    public WADPets.WADPet GetRandomPet()
    {
        bool val_8;
        var val_9;
        System.Predicate<WADPets.WADPet> val_11;
        var val_12;
        var val_13;
        val_8 = static_value_021FD234;
        if(val_8 != true)
        {
                val_8 = true;
        }
        
        System.Collections.Generic.List<WADPets.WADPet> val_1 = WADPetsManager.AllPetsCollection;
        System.Collections.Generic.List<ZooTile> val_2 = new System.Collections.Generic.List<ZooTile>(collection:  1);
        if(Alphabet2Manager.IsAvailable != true)
        {
                val_9 = null;
            val_9 = null;
            val_11 = WADPetsManager.<>c.<>9__28_0;
            if(val_11 == 0)
        {
                val_11 = null;
            val_11 = new System.Predicate<ZooTile>(object:  WADPetsManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3324752256));
            WADPetsManager.<>c.<>9__28_0 = val_11;
        }
        
            int val_5 = RemoveAll(match:  8040448);
        }
        
        if(null != 0)
        {
                val_12 = null;
            val_13 = UnityEngine.Random.Range(min:  0, max:  1094062064);
        }
        else
        {
                val_12 = 12;
            val_13 = UnityEngine.Random.Range(min:  0, max:  0);
        }
        
        if(val_12 > val_13)
        {
                return;
        }
        
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
    }
    public void RewardPetCards(int amount, WADPets.WADPet pet, string source, string subsource, System.Collections.Generic.Dictionary<string, object> additionalParam)
    {
        int val_2;
        string val_9;
        string val_14;
        var val_15;
        var val_16;
        val_14 = source;
        val_15 = pet;
        val_16 = amount;
        if(val_15 != 0)
        {
            goto label_1;
        }
        
        WADPets.WADPet val_1 = GetRandomPet();
        val_15;
        if((-970072568) == 0)
        {
            goto label_2;
        }
        
        label_1:
        int val_14 = val_2;
        val_14 = val_14 + val_16;
        val_2 = val_14;
        label_13:
        if(val_14 == null)
        {
                return;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        int val_5 = WADPetsManager.GetCardsBalance();
        Add(key:  -970084608, value:  13152256);
        if(additionalParam == 0)
        {
            goto label_17;
        }
        
        Dictionary.KeyCollection<TKey, TValue> val_6 = additionalParam.Keys;
        Dictionary.KeyCollection.Enumerator<TKey, TValue> val_7 = GetEnumerator();
        label_9:
        if(MoveNext() == false)
        {
            goto label_7;
        }
        
        object val_10 = additionalParam.Item[val_9];
        Add(key:  val_9, value:  additionalParam);
        goto label_9;
        label_7:
        Dispose();
        val_14 = val_14;
        label_17:
        val_16 = 0;
        Player val_11 = App.Player;
        string val_12 = amount.ToString();
        0.TrackNonCoinReward(source:  val_14, subSource:  subsource, rewardType:  -1050421024, rewardAmount:  amount, additionalParams:  null);
        return;
        label_2:
        mem[20] = 1 + val_16;
        goto label_13;
    }
    public bool CheckFTUX()
    {
        twelvegigs.sweepstakes.Distribution val_6;
        if(SceneDictator.IsInGameScene() == false)
        {
                return (bool);
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        System.Collections.Generic.List<WADPets.WADPet> val_3 = WADPetsManager.AllPetsCollection;
        List.Enumerator<T> val_4 = GetEnumerator();
        label_27:
        if(MoveNext() == false)
        {
            goto label_5;
        }
        
        if(((((val_6 + 24) != 0) || ((val_6 + 8 + 12) == 5)) || ((val_6 + 8 + 12) == 3)) || ((val_6 + 8 + 12) == 2))
        {
            goto label_27;
        }
        
        if((val_6 + 8 + 12) != 4)
        {
            goto label_15;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(VideoAdsAllowed == false)
        {
            goto label_27;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.GameObject val_10 = FreeHintButtonGroup;
        if(activeSelf == false)
        {
            goto label_27;
        }
        
        label_15:
        if(val_6.IsActive() == false)
        {
            goto label_27;
        }
        
        mem2[0] = 1;
        Add(item:  val_6);
        goto label_27;
        label_5:
        Dispose();
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ShowFTUX(pets:  80883712);
        0 = 1;
        return (bool);
    }
    public static System.Collections.Generic.List<WADPets.WADPet> GetHungryPets()
    {
        bool val_4;
        var val_5;
        System.Predicate<WADPets.WADPet> val_7;
        val_4 = static_value_021FD237;
        if(val_4 != true)
        {
                val_4 = true;
        }
        
        System.Collections.Generic.List<WADPets.WADPet> val_1 = WADPetsManager.AllPetsCollection;
        val_5 = null;
        val_5 = null;
        val_7 = WADPetsManager.<>c.<>9__31_0;
        if(val_7 == 0)
        {
                val_7 = null;
            val_7 = new System.Predicate<ZooTile>(object:  WADPetsManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3325124192));
            WADPetsManager.<>c.<>9__31_0 = val_7;
        }
        
        System.Collections.Generic.List<T> val_3 = val_4.FindAll(match:  8040448);
        return System.Linq.Enumerable.ToList<System.Object>(source:  1);
    }
    public static System.Collections.Generic.List<WADPets.WADPet> GetUnlockedPets()
    {
        bool val_4;
        var val_5;
        System.Predicate<WADPets.WADPet> val_7;
        val_4 = static_value_021FD238;
        if(val_4 != true)
        {
                val_4 = true;
        }
        
        System.Collections.Generic.List<WADPets.WADPet> val_1 = WADPetsManager.AllPetsCollection;
        val_5 = null;
        val_5 = null;
        val_7 = WADPetsManager.<>c.<>9__32_0;
        if(val_7 == 0)
        {
                val_7 = null;
            val_7 = new System.Predicate<ZooTile>(object:  WADPetsManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3325239264));
            WADPetsManager.<>c.<>9__32_0 = val_7;
        }
        
        System.Collections.Generic.List<T> val_3 = val_4.FindAll(match:  8040448);
        return System.Linq.Enumerable.ToList<System.Object>(source:  1);
    }
    public static System.Collections.Generic.List<WADPets.WADPet> GetAllPetsCollection()
    {
        return WADPetsManager.AllPetsCollection;
    }
    public static int GetCardsBalance()
    {
        bool val_3;
        var val_4;
        System.Func<WADPets.WADPet, System.Int32> val_6;
        val_3 = static_value_021FD239;
        if(val_3 != true)
        {
                val_3 = true;
        }
        
        System.Collections.Generic.List<WADPets.WADPet> val_1 = WADPetsManager.AllPetsCollection;
        val_4 = null;
        val_4 = null;
        val_6 = WADPetsManager.<>c.<>9__34_0;
        if(val_6 != 0)
        {
                return System.Linq.Enumerable.Sum<WADPets.WADPet>(source:  1, selector:  7720960);
        }
        
        val_6 = null;
        val_6 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  WADPetsManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3325464288));
        WADPetsManager.<>c.<>9__34_0 = val_6;
        return System.Linq.Enumerable.Sum<WADPets.WADPet>(source:  1, selector:  7720960);
    }
    public static bool IsFeatureUnlocked()
    {
        if(WADPetsManager.notreally_staticPetsUtils == 0)
        {
                return (bool)0;
        }
        
        0 = 1;
        if(WADPetsManager.GetCardsBalance() <= 0)
        {
                return WADPetsManager.IsAnyPetUnlocked();
        }
        
        return (bool)0;
    }
    public static bool IsAnyPetUnlocked()
    {
        bool val_4;
        var val_5;
        System.Predicate<WADPets.WADPet> val_7;
        val_4 = static_value_021FD23B;
        if(val_4 != true)
        {
                val_4 = true;
        }
        
        System.Collections.Generic.List<WADPets.WADPet> val_1 = WADPetsManager.AllPetsCollection;
        val_5 = null;
        val_5 = null;
        val_7 = WADPetsManager.<>c.<>9__36_0;
        if(val_7 == 0)
        {
                val_7 = null;
            val_7 = new System.Predicate<ZooTile>(object:  WADPetsManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3325691360));
            WADPetsManager.<>c.<>9__36_0 = val_7;
        }
        
        object val_3 = val_4.Find(match:  8040448);
        if(val_4 != 0)
        {
                val_4 = 1;
        }
        
        return true;
    }
    public static bool IsAnyPetHungry()
    {
        bool val_4;
        var val_5;
        System.Predicate<WADPets.WADPet> val_7;
        val_4 = static_value_021FD23C;
        if(val_4 != true)
        {
                val_4 = true;
        }
        
        System.Collections.Generic.List<WADPets.WADPet> val_1 = WADPetsManager.AllPetsCollection;
        val_5 = null;
        val_5 = null;
        val_7 = WADPetsManager.<>c.<>9__37_0;
        if(val_7 == 0)
        {
                val_7 = null;
            val_7 = new System.Predicate<ZooTile>(object:  WADPetsManager.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3325804384));
            WADPetsManager.<>c.<>9__37_0 = val_7;
        }
        
        object val_3 = val_4.Find(match:  8040448);
        if(val_4 != 0)
        {
                val_4 = 1;
        }
        
        return true;
    }
    public static WADPets.WADPet GetPetByAbility(WADPets.WADPetAbility ability)
    {
        typeof(WADPetsManager.<>c__DisplayClass38_0).__il2cppRuntimeField_8 = ability;
        System.Collections.Generic.List<WADPets.WADPet> val_2 = WADPetsManager.AllPetsCollection;
        System.Predicate<ZooTile> val_3 = new System.Predicate<ZooTile>(object:  335622144, method:  new IntPtr(3325921504));
        if(new System.Object() != 0)
        {
                return new System.Object().Find(match:  8040448);
        }
        
        return new System.Object().Find(match:  8040448);
    }
    public static bool GetUnlockedPetByAbility(WADPets.WADPetAbility ability)
    {
        var val_3 = 0;
        if(WADPetsManager.notreally_staticPetsUtils == 0)
        {
                return true;
        }
        
        WADPets.WADPet val_2 = WADPetsManager.GetPetByAbility(ability:  ability);
        if(val_3 != 0)
        {
                val_3 = 1;
        }
        
        return true;
    }
    public static WADPets.WADPetUpgradeRequirement GetUpgradeRequirement(int levelIndex)
    {
        var val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(GetMaxLevel() != levelIndex)
        {
            goto label_4;
        }
        
        object val_3 = null;
        val_4 = val_3;
        val_3 = new System.Object();
        if(val_4 == 0)
        {
            goto label_5;
        }
        
        typeof(WADPets.WADPetUpgradeRequirement).__il2cppRuntimeField_8 = 2147483648;
        goto label_6;
        label_4:
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_4 = mem[(System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (levelIndex) << 2) + 16];
        val_4 = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (levelIndex) << 2) + 16;
        return;
        label_5:
        mem[8] = 2147483648;
        label_6:
        typeof(WADPets.WADPetUpgradeRequirement).__il2cppRuntimeField_C = 2147483648;
    }
    public static float GetLevelCurveModifier(WADPets.WADPetAbility ability)
    {
        float val_6;
        float val_7;
        var val_8;
        WADPets.WADPet val_1 = WADPetsManager.GetPetByAbility(ability:  ability);
        val_6 = 0f;
        if(ability == 0)
        {
                return val_7;
        }
        
        if(ability.IsActive() == false)
        {
                return val_7;
        }
        
        if((mem[35639892] + 12) >= 1)
        {
                int val_3 = R6 - 1;
            if((mem[35639892] + 16 + 12) <= val_3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_6 = mem[35639892] + 16 + 8;
            val_6 = val_6 + (val_3 << 2);
            if((mem[35639892] + 16 + 12) == val_3)
        {
                val_8 = mem[35639892] + 16;
            if((mem[35639892] + 16) == 0)
        {
                if(val_8 == 0)
        {
            goto label_11;
        }
        
        }
        
            val_3 = val_3 - 1;
            if((mem[35639892] + 16 + 20 + 12) <= val_3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_7 = mem[35639892] + 16 + 20 + 8;
            val_7 = val_7 + (val_3 << 2);
            var val_8 = (mem[35639892] + 16 + 20 + 8 + (((R6 - 1) - 1)) << 2) + 16;
            val_8 = val_8 - 1;
            if((mem[35639892] + 16 + 20 + 12) <= val_8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_9 = mem[35639892] + 16 + 20 + 8;
            val_9 = val_9 + (val_8 << 2);
            var val_10 = (mem[35639892] + 16 + 20 + 8 + (((mem[35639892] + 16 + 20 + 8 + (((R6 - 1) - 1)) << 2) + 16 - 1)) << 2) + 16;
            val_7 = (float)UnityEngine.Random.Range(min:  (mem[35639892] + 16 + 20 + 8 + (((R6 - 1) - 1)) << 2) + 16 + 8, max:  ((mem[35639892] + 16 + 20 + 8 + (((mem[35639892] + 16 + 20 + 8 + (((R6 - 1) - 1)) << 2) + 16 - 1)) << 2) + 16 + 12) + 1);
            mem[35639892] + 16 + 16.set_Item(index:  val_3, value:  val_7);
        }
        
        }
        
        val_10 = val_10 - 1;
        if((((R6 - 1) - 1) + 16 + 12) <= val_10)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_11 = ((R6 - 1) - 1) + 16 + 8;
        val_11 = val_11 + (val_10 << 2);
        val_6 = mem[(((R6 - 1) - 1) + 16 + 8 + (((mem[35639892] + 16 + 20 + 8 + (((mem[35639892] + 16 + 20 + 8 + (((R6 - 1) - 1)) << 2) + 16 - 1)) << 2) + 16 - 1)) << 2) + 16];
        val_6 = (((R6 - 1) - 1) + 16 + 8 + (((mem[35639892] + 16 + 20 + 8 + (((mem[35639892] + 16 + 20 + 8 + (((R6 - 1) - 1)) << 2) + 16 - 1)) << 2) + 16 - 1)) << 2) + 16;
        return val_7;
        label_11:
    }
    public string GetFoodBalanceText()
    {
        Player val_1 = App.Player;
        decimal val_2 = System.Decimal.op_Implicit(value:  -968563296);
        string val_3 = NumberAbbreviation.GetNumber(num:  new System.Decimal());
    }
    public static string GetFormattedTimeText(System.TimeSpan time)
    {
        int val_2 = UnityEngine.Mathf.Max(a:  time._ticks.Hours, b:  0);
        string val_5 = UnityEngine.Mathf.Max(a:  time._ticks.Minutes, b:  0).ToString(format:  -1827641632);
        string val_8 = UnityEngine.Mathf.Max(a:  time._ticks.Seconds, b:  0).ToString(format:  -1827641632);
        string val_9 = System.String.Format(format:  -1687058320, arg0:  13152256, arg1:  -968451308, arg2:  -968451308);
    }
    public static string GetAbilityDescription(WADPets.WADPet pet)
    {
        string val_2;
        string val_3;
        var val_8;
        string val_9;
        string val_10;
        float val_11;
        val_8 = null;
        val_8 = null;
        System.Collections.Generic.KeyValuePair<System.Object, System.Object> val_1 = Item[WADPets.LocTexts.AbilityDescription];
        val_9 = val_2;
        val_10 = val_3;
        if(pet.IsUnlocked == true)
        {
                pet.IsUnlocked = pet.LevelIndex;
        }
        
        if(pet.IsUnlocked == false)
        {
                pet.IsUnlocked - 1 = 0;
        }
        
        if(pet.IsUnlocked >= 1)
        {
                string val_4 = Localization.Localize(key:  val_9, defaultValue:  val_10, useSingularKey:  false);
            val_10 = val_9;
            if(val_9 <= (pet.IsUnlocked - 1))
        {
                var val_8 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_8 = val_8 + 0;
            val_2 = (0 + 0) + 16 + 8;
            val_9 = null;
            if(null <= (pet.IsUnlocked - 1))
        {
                var val_9 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_9 = val_9 + 0;
            string val_5 = System.String.Format(format:  val_10, arg0:  13152256, arg1:  13152256);
            return;
        }
        
        if(pet.IsUnlocked <= (pet.IsUnlocked - 1))
        {
                var val_10 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_10 = val_10 + 0;
        val_11 = mem[(0 + 0) + 16];
        val_11 = (0 + 0) + 16;
        if(pet.Info.Ability != 2)
        {
                if(pet.Info.Ability != 3)
        {
            goto label_24;
        }
        
        }
        
        val_11 = val_11 * 100f;
        label_24:
        string val_6 = Localization.Localize(key:  val_9, defaultValue:  val_10, useSingularKey:  false);
        val_2 = val_11;
        string val_7 = System.String.Format(format:  val_9, arg0:  15282176);
    }
    private void Initialize()
    {
        var val_9;
        System.Delegate val_10;
        var val_11;
        System.Action val_12;
        System.Delegate val_13;
        var val_9 = 22117670;
        val_9 = 13522208 + val_9;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        WADPetsManager.notreally_staticPetsUtils = this.petsUtils;
        WADPetsManager.notreally_staticPetsUtils.InitializePets();
        this.petsStatus = new EventProgression();
        this.levelTrackingInfo = new WADPets.LevelTracking();
        this.<LifetimeTrackingInfo>k__BackingField = new WADPets.LifetimeTracking();
        this.<IsDataInitialized>k__BackingField = true;
        val_9 = null;
        val_9 = null;
        System.Action val_4 = new System.Action(object:  -968085104, method:  new IntPtr(3326856032));
        val_10 = GameStoreUI.OnCreatePackItems;
        System.Delegate val_5 = System.Delegate.Combine(a:  val_10, b:  7454720);
        val_11 = null;
        val_12 = null;
        if(val_10 == 0)
        {
            goto label_7;
        }
        
        if(null == val_12)
        {
            goto label_8;
        }
        
        val_12 = null;
        val_11 = 1152921504929316956;
        label_7:
        val_10 = 0;
        label_8:
        GameStoreUI.OnCreatePackItems = val_10;
        val_12 = new System.Action(object:  -968085104, method:  new IntPtr(3326857056));
        val_13 = GameStoreUI.OnRefreshDisplay;
        System.Delegate val_7 = System.Delegate.Combine(a:  val_13, b:  7454720);
        if(val_13 != 0)
        {
                if(null == null)
        {
            goto label_10;
        }
        
        }
        
        val_13 = 0;
        label_10:
        GameStoreUI.OnRefreshDisplay = val_13;
        NotificationCenter val_8 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -968085104, name:  -968109216);
    }
    private void OnStoreCreatePackItems()
    {
    
    }
    private void OnStoreRefreshDisplay()
    {
    
    }
    private int GetMaxLevel()
    {
        if(WADPetsManager.notreally_staticPetsUtils.UpgradeRequirements != 0)
        {
                return (int)System.Collections.Generic.List<T>.__il2cppRuntimeField_namespaze;
        }
        
        return (int)System.Collections.Generic.List<T>.__il2cppRuntimeField_namespaze;
    }
    private void InitializePetsCollection()
    {
        WADPetsManager.notreally_staticPetsUtils = this.petsUtils;
    }
    private void InitializePets()
    {
        var val_4;
        System.Collections.Generic.List<WADPets.WADPet> val_1 = WADPetsManager.AllPetsCollection;
        List.Enumerator<T> val_2 = GetEnumerator();
        label_4:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        if(val_4 != 0)
        {
            goto label_4;
        }
        
        goto label_4;
        label_2:
        Dispose();
    }
    private void SchedulePetHungryLPN()
    {
        var val_5;
        var val_6;
        var val_9;
        var val_13;
        string val_14;
        var val_15;
        string val_16;
        twelvegigs.plugins.LocalNotificationsPlugin.KillNotification(tipo:  24);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1953384384, value:  -967424816);
        if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = this.petsStatus.LastFedUtcTime}, d2:  new System.DateTime())) != false)
        {
                System.DateTime val_4 = DateTimeCheat.UtcNow;
            val_15 = val_5;
            val_16 = val_6;
        }
        else
        {
                System.DateTime val_7 = DateTimeCheat.UtcNow;
            System.TimeSpan val_8 = GetTimeCountdownToNextFeed();
            System.DateTime val_12 = AddSeconds(value:  val_9.TotalSeconds);
            val_15 = val_13;
            val_16 = val_14;
        }
        
        twelvegigs.plugins.LocalNotificationsPlugin.PostNotification(tipo:  24, when:  new System.DateTime(), optMessage:  val_16, extraData:  "Feed your Pets to activate benefits!");
    }
    private static int GetPetIndexInCollection(WADPets.WADPet pet)
    {
        typeof(WADPetsManager.<>c__DisplayClass54_0).__il2cppRuntimeField_8 = pet;
        System.Collections.Generic.List<WADPets.WADPet> val_2 = WADPetsManager.AllPetsCollection;
        System.Predicate<ZooTile> val_3 = new System.Predicate<ZooTile>(object:  335675392, method:  new IntPtr(3327667008));
        if(new System.Object() != 0)
        {
                return new System.Object().FindIndex(match:  8040448);
        }
        
        return new System.Object().FindIndex(match:  8040448);
    }
    public void Tracking_HasBonusAlphabetTile()
    {
        this.levelTrackingInfo.HasBonusAlphabetTile = true;
        if(this.levelTrackingInfo == 0)
        {
            
        }
    
    }
    public void Tracking_GainedBonusAlphabetTile()
    {
        if(this.levelTrackingInfo.HasBonusAlphabetTile == false)
        {
                return;
        }
        
        this.levelTrackingInfo.GainedBonusAlphabetTile = true;
        if(this.levelTrackingInfo == 0)
        {
            
        }
    
    }
    public void Tracking_HasAlphabetTile()
    {
        this.levelTrackingInfo.HasAlphabetTileInLevel = true;
        if(this.levelTrackingInfo == 0)
        {
            
        }
    
    }
    public System.Collections.Generic.Dictionary<string, object> GetBonusGoldenApplesRewardTrackingParameters(GameLevel level)
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_6;
        WADPets.WADPet val_1 = WADPetsManager.GetPetByAbility(ability:  2);
        if(2 != 0)
        {
                val_6 = 0;
            if(2.IsActive() == false)
        {
                return;
        }
        
            float val_3 = WADPetsManager.GetLevelCurveModifier(ability:  2);
            val_6 = 0;
            float val_6 = (float)level.goldenApplesStreaks;
            val_6 = 2 * val_6;
            int val_4 = UnityEngine.Mathf.RoundToInt(f:  val_6);
            mem[30] = (float)val_4;
            if(val_4 < 1)
        {
                return;
        }
        
            val_6 = null;
            val_6 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            Add(key:  -966784704, value:  15282176);
            return;
        }
        
        val_6 = 0;
    }
    public void SaveLevelTrackingInfo()
    {
        WADPets.LevelTracking val_1 = new WADPets.LevelTracking();
        this.savedLevelTrackingInfo = this.levelTrackingInfo;
    }
    public void AppendLevelCompleteData(ref System.Collections.Generic.Dictionary<string, object> curData)
    {
        WADPets.LevelTracking val_3;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_3 = public static WGDailyChallengeManager MonoSingleton<WGDailyChallengeManager>::get_Instance();
        if(PlayingChallenge == true)
        {
                return;
        }
        
        val_3 = this.savedLevelTrackingInfo;
        if(this.savedLevelTrackingInfo.HasBonusAlphabetTile != false)
        {
                val_3 = null;
            curData.Add(key:  -966536080, value:  8945664);
        }
        
        this.levelTrackingInfo.ResetLevelCompleteEvent();
    }
    public void ResetLevelCompleteEventTracking()
    {
        this.levelTrackingInfo.ResetLevelCompleteEvent();
    }
    public void Tracking_LifetimeFoodIncreased(int amount)
    {
        WADPets.LifetimeTracking val_2;
        int val_3;
        val_2 = this.<LifetimeTrackingInfo>k__BackingField;
        if(val_2 != 0)
        {
                val_3 = this.<LifetimeTrackingInfo>k__BackingField.Food;
        }
        else
        {
                val_2 = 8;
            val_3 = 0;
        }
        
        mem[8] = val_3 + amount;
        if((this.<LifetimeTrackingInfo>k__BackingField) == 0)
        {
            
        }
    
    }
    public WADPetsManager()
    {
    
    }

}
