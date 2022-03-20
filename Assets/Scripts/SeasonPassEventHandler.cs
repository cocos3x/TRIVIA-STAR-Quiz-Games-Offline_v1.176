using UnityEngine;
public class SeasonPassEventHandler : WGEventHandler
{
    // Fields
    public const string EVENT_ID = "SeasonPass";
    public const string EVENT_TRACKING_ID = "Season Event";
    public const string EVENT_TRACKING_SUBSOURCE_TIER = "Season Event Reward Tier ";
    public const string SEASON_PLUAS_PASS_ID = "id_season_plus_pass";
    private static SeasonPassEventHandler <Instance>k__BackingField;
    public System.Action<bool> OnPurchaseAttempt;
    private SeasonPassEcon <econ>k__BackingField;
    private SeasonPassProgression <progression>k__BackingField;
    private string _uniqueSeasonName;
    private System.Collections.Generic.List<System.Tuple<SeasonPassEcon.Item, System.Decimal>> claimedAwards;
    private System.Collections.Generic.List<System.Tuple<WADPets.WADPet, int>> petCardAwards;
    private System.Collections.Generic.Dictionary<WADPets.WADPet, int> petCardsDict;
    
    // Properties
    public static SeasonPassEventHandler Instance { get; set; }
    public static bool IsPlaying { get; }
    public SeasonPassEcon econ { get; set; }
    public SeasonPassProgression progression { get; set; }
    public string uniqueSeasonName { get; }
    public static int PassHintDiscount { get; }
    public static int PassPickHintDiscount { get; }
    public static bool IsPlusPassActive { get; }
    public override bool OverrideEventButton { get; }
    
    // Methods
    public static SeasonPassEventHandler get_Instance()
    {
    
    }
    private static void set_Instance(SeasonPassEventHandler value)
    {
        SeasonPassEventHandler.<Instance>k__BackingField = value;
    }
    public static bool get_IsPlaying()
    {
        if((SeasonPassEventHandler.<Instance>k__BackingField) == 0)
        {
                return (bool)0;
        }
        
        if((SeasonPassEventHandler.<Instance>k__BackingField.InExpireInterval()) == true)
        {
                return (bool)0;
        }
        
        0 = (SeasonPassEventHandler.<Instance>k__BackingField) ^ 1;
        return (bool)0;
    }
    public SeasonPassEcon get_econ()
    {
    
    }
    private void set_econ(SeasonPassEcon value)
    {
        this.<econ>k__BackingField = value;
    }
    public SeasonPassProgression get_progression()
    {
    
    }
    private void set_progression(SeasonPassProgression value)
    {
        this.<progression>k__BackingField = value;
    }
    public string get_uniqueSeasonName()
    {
        if((System.String.IsNullOrEmpty(value:  this._uniqueSeasonName)) != false)
        {
                return;
        }
        
        if(this._uniqueSeasonName != null)
        {
                return this._uniqueSeasonName.ToUpper();
        }
        
        return this._uniqueSeasonName.ToUpper();
    }
    public static int get_PassHintDiscount()
    {
        var val_2;
        GameBehavior val_1 = App.getBehavior;
        val_2 = 0;
        if(0 == 0)
        {
                return (int)SeasonPassEcon.__il2cppRuntimeField_declaringType;
        }
        
        if((SeasonPassEventHandler.<Instance>k__BackingField) == 0)
        {
                return (int)SeasonPassEcon.__il2cppRuntimeField_declaringType;
        }
        
        if((SeasonPassEventHandler.<Instance>k__BackingField) != 0)
        {
                return (int)SeasonPassEcon.__il2cppRuntimeField_declaringType;
        }
        
        return (int)SeasonPassEcon.__il2cppRuntimeField_declaringType;
    }
    public static int get_PassPickHintDiscount()
    {
        var val_2;
        GameBehavior val_1 = App.getBehavior;
        val_2 = 0;
        if(0 == 0)
        {
                return (int)SeasonPassEcon.__il2cppRuntimeField_parent;
        }
        
        if((SeasonPassEventHandler.<Instance>k__BackingField) == 0)
        {
                return (int)SeasonPassEcon.__il2cppRuntimeField_parent;
        }
        
        if((SeasonPassEventHandler.<Instance>k__BackingField) != 0)
        {
                return (int)SeasonPassEcon.__il2cppRuntimeField_parent;
        }
        
        return (int)SeasonPassEcon.__il2cppRuntimeField_parent;
    }
    public static bool get_IsPlusPassActive()
    {
        var val_2;
        GameBehavior val_1 = App.getBehavior;
        val_2 = 0;
        if(0 == 0)
        {
                return true;
        }
        
        if((SeasonPassEventHandler.<Instance>k__BackingField) == 0)
        {
                return true;
        }
        
        if((SeasonPassEventHandler.<Instance>k__BackingField) != 0)
        {
                return true;
        }
        
        if(typeof(SeasonPassProgression).__il2cppRuntimeField_14 != 0)
        {
                val_2 = 1;
        }
        
        return true;
    }
    public override void Init(GameEventV2 eventV2)
    {
        SeasonPassProgression val_4;
        int val_5;
        var val_4 = 27863049;
        mem[1152921512142985976] = eventV2;
        val_4 = 7766228 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        SeasonPassEventHandler.<Instance>k__BackingField = this;
        UnityEngine.Texture val_1 = WGResources.Load<UnityEngine.Texture>(fileName:  -1053832032, extension:  -1053832112, errorLog:  true);
        this.<econ>k__BackingField = "Events/SeasonPass/SeasonPassEcon";
        this.<progression>k__BackingField = new SeasonPassProgression();
        val_4 = this.<progression>k__BackingField;
        val_5 = eventV2.id;
        if(val_5 != (this.<progression>k__BackingField.currentEventId))
        {
                val_4 = this.<progression>k__BackingField;
            Player val_3 = App.Player;
            val_5 = 0;
            val_4.InitEvent(eventId:  eventV2.id, playerLevel:  0);
        }
        
        this.ParseEventData(eventData:  eventV2.eventData);
    }
    public override void OnLevelComplete(int levelsProgressed = 1)
    {
        if(this != 0)
        {
                return;
        }
        
        if((this.<progression>k__BackingField.currentTier) == this.CurrentUnlockedTier())
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_3 = ShowUGUIMonolith<System.Object>(showNext:  false);
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_88 = 1;
    }
    public override void UpdateProgress()
    {
        this.<progression>k__BackingField.currentTier = this.CurrentUnlockedTier();
        this.UpdateProgress();
    }
    public int CurrentUnlockedTier()
    {
        int val_10;
        int val_11;
        SeasonPassEcon val_12;
        int val_13;
        val_10 = this.<progression>k__BackingField.initLevel;
        Player val_1 = App.Player;
        if(val_10 > 0)
        {
                val_10 = this.<progression>k__BackingField;
            Player val_2 = App.Player;
            this.<progression>k__BackingField.initLevel = 0;
        }
        
        Player val_3 = App.Player;
        var val_10 = 0;
        val_10 = val_10 - (this.<progression>k__BackingField.initLevel);
        if((this.<econ>k__BackingField) == 0)
        {
            goto label_14;
        }
        
        val_11 = this.<econ>k__BackingField.BronzeTierLevels;
        if(val_10 <= 10)
        {
                return UnityEngine.Mathf.FloorToInt(f:  (float)val_10);
        }
        
        label_22:
        int val_4 = val_11 + (val_11 << 2);
        val_12 = this.<econ>k__BackingField;
        val_4 = 0 - val_4;
        val_10 = val_10 + (val_4 << 1);
        if(val_12 == 0)
        {
            goto label_16;
        }
        
        val_13 = this.<econ>k__BackingField.SilverTierLevels;
        if(val_10 <= 10)
        {
            goto label_17;
        }
        
        label_26:
        int val_6 = 0 - (val_13 + (val_13 << 2));
        val_6 = val_10 + (val_6 << 1);
        return UnityEngine.Mathf.Min(a:  30, b:  (UnityEngine.Mathf.FloorToInt(f:  (float)val_6)) + 20);
        label_14:
        val_10 = val_10;
        val_11 = this.<econ>k__BackingField.BronzeTierLevels;
        if(val_10 > 10)
        {
            goto label_22;
        }
        
        return UnityEngine.Mathf.FloorToInt(f:  (float)val_10);
        label_16:
        val_12 = val_10;
        val_13 = this.<econ>k__BackingField.SilverTierLevels;
        if(val_12 > 10)
        {
            goto label_26;
        }
        
        label_17:
        int val_9 = UnityEngine.Mathf.FloorToInt(f:  (float)val_10);
        val_9 = val_9 + 10;
        return (int)val_9;
    }
    public int NextTierTarget()
    {
        return this.LevelsForTier(tier:  (this.<progression>k__BackingField.currentTier) + 1);
    }
    public int LevelsForTier(int tier)
    {
        if(tier < 1)
        {
                return 0;
        }
        
        typeof(System.Int32[]).__il2cppRuntimeField_10 = this.<econ>k__BackingField.BronzeTierLevels;
        typeof(System.Int32[]).__il2cppRuntimeField_14 = this.<econ>k__BackingField.SilverTierLevels;
        typeof(System.Int32[]).__il2cppRuntimeField_18 = this.<econ>k__BackingField.GoldTierLevels;
        int val_1 = tier - 1;
        val_1 = (val_1 >> 2) + (val_1 >> 31);
        var val_5 = null + ((UnityEngine.Mathf.Min(a:  UnityEngine.Mathf.FloorToInt(f:  (float)val_1), b:  (System.Int32[].__il2cppRuntimeField_namespaze - 1))) << 2);
        return (int)(null + (val_4) << 2) + 16;
    }
    public int TotalLevelsForTier(int tier)
    {
        var val_2;
        var val_3;
        if(tier >= 0)
        {
                val_2 = 0;
            do
        {
            val_3 = (this.LevelsForTier(tier:  0)) + 0;
            if(val_2 >= tier)
        {
                return (int)val_3;
        }
        
            val_2 = val_2 + 1;
        }
        while(val_2 < 30);
        
            return (int)val_3;
        }
        
        val_3 = 0;
        return (int)val_3;
    }
    public int CurrentTierProgression()
    {
        SeasonPassProgression val_4;
        var val_5;
        var val_6;
        Player val_1 = App.Player;
        val_4 = this.<progression>k__BackingField;
        if((this.<progression>k__BackingField) != 0)
        {
            goto label_4;
        }
        
        val_4 = this.<progression>k__BackingField;
        if(val_4 == 0)
        {
            goto label_5;
        }
        
        label_4:
        val_5 = 0;
        if((this.<progression>k__BackingField.currentTier) < 0)
        {
            goto label_7;
        }
        
        val_6 = 0;
        label_8:
        val_5 = (this.LevelsForTier(tier:  0)) + val_5;
        if(val_6 >= (this.<progression>k__BackingField.currentTier))
        {
            goto label_7;
        }
        
        val_6 = val_6 + 1;
        if(val_6 < 30)
        {
            goto label_8;
        }
        
        label_7:
        int val_4 = 0 - (this.<progression>k__BackingField.initLevel);
        val_4 = val_4 - val_5;
        return (int)val_4;
        label_5:
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public override bool get_OverrideEventButton()
    {
        return true;
    }
    public override void OnGameButtonPressed(bool connected)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public override bool EventCompleted()
    {
        ulong val_2;
        ulong val_5;
        var val_6;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        val_5 = mem[35629125];
        val_6 = 1;
        if((System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = val_5})) == true)
        {
                return true;
        }
        
        val_6 = 0;
        if((this.<progression>k__BackingField.hasPass) == false)
        {
                return true;
        }
        
        if((this.<progression>k__BackingField.hasPass) < (this.<econ>k__BackingField.tiers))
        {
                return true;
        }
        
        if((this.<progression>k__BackingField.hasPass) >= (this.<econ>k__BackingField.tiers))
        {
                val_6 = 1;
        }
        
        return true;
    }
    public override string GetEventDisplayName()
    {
        return this.uniqueSeasonName;
    }
    public override void AppendLevelCompleteData(ref System.Collections.Generic.Dictionary<string, object> currentData)
    {
        if((this.CurrentTierProgression() + 1) != this.NextTierTarget())
        {
                return;
        }
        
        int val_4 = this.<progression>k__BackingField.currentTier;
        val_4 = val_4 + 1;
        currentData.Add(key:  -1052141472, value:  13152256);
    }
    public override string GetMainMenuButtonText()
    {
        string val_1 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        string val_2 = Localization.Localize(key:  -1052008928, defaultValue:  -1052008816, useSingularKey:  false);
        string val_3 = System.String.Format(format:  -1826949520, arg0:  -1052008928, arg1:  1629069648);
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        bool val_3 = true;
        val_3 = val_3 - 1;
        float val_4 = (float)this.<progression>k__BackingField.currentTier;
        string val_1 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
        val_4 = val_4 / (float)val_3;
        TheLibraryMainScreen val_2 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        if(loader != 0)
        {
                return;
        }
    
    }
    public override string GetGameButtonText()
    {
        int val_1 = this.CurrentTierProgression();
        int val_2 = this.NextTierTarget();
        string val_3 = System.String.Format(format:  1629069648, arg0:  13152256, arg1:  13152256);
    }
    public string GetPlusPackagePrice()
    {
        twelvegigs.storage.JsonDictionary val_1 = PackagesManager.GetPackageById(packageId:  -1051602064);
        string val_2 = getString(key:  -1816221600, defaultValue:  1098586544);
        if((System.String.IsNullOrEmpty(value:  -1051602064)) == false)
        {
                return;
        }
        
        string val_4 = getString(key:  -1816221696, defaultValue:  1098586544);
        return -1802497744(-1802497744) + -1051602064(-1051602064);
    }
    public void PurchasePlusPassPackage()
    {
        var val_4;
        if((this.<progression>k__BackingField.hasPass) != false)
        {
                if(this.OnPurchaseAttempt == 0)
        {
                return;
        }
        
            this.OnPurchaseAttempt.Invoke(obj:  false);
            return;
        }
        
        twelvegigs.storage.JsonDictionary val_1 = PackagesManager.GetPackageById(packageId:  -1051602064);
        PurchaseModel val_2 = new PurchaseModel(json:  -1051602064);
        var val_4 = 27853081;
        val_4 = 7772980 + val_4;
        if(val_4 == 0)
        {
                mem2[0] = 1;
        }
        
        val_4 = null;
        val_4 = null;
        PurchaseProxy.currentPurchasePoint = 115;
        bool val_3 = PurchaseProxy.Purchase(purchase:  292597760);
    }
    public override void OnProcessPurchase(ref PurchaseModel purchase)
    {
        this.OnProcessPurchase(purchase: ref  PurchaseModel val_1 = -1051301552);
    }
    public override void OnPurchaseFailure(PurchaseModel purchase)
    {
        bool val_1 = purchase.id.Contains(value:  -1051602064);
        if(val_1 == true)
        {
                val_1 = this.OnPurchaseAttempt;
        }
        
        if(val_1 == 0)
        {
                return;
        }
        
        val_1.Invoke(obj:  false);
    }
    public override void OnPurchaseCompleted(PurchaseModel purchase)
    {
        if((purchase.id.Contains(value:  -1051602064)) == false)
        {
                return;
        }
        
        this.<progression>k__BackingField.hasPass = true;
        this.UpdateProgressToServer();
        this.UpdateHintDiscounts();
        if(this.OnPurchaseAttempt == 0)
        {
                return;
        }
        
        this.OnPurchaseAttempt.Invoke(obj:  true);
    }
    public override void OnEventEnded()
    {
        SeasonPassEventHandler.<Instance>k__BackingField = 0;
        if((this.<progression>k__BackingField) == 0)
        {
            
        }
    
    }
    public override string GetHackPanelEventData()
    {
        string val_2 = System.String.Format(format:  -1050835904, arg0:  8945664);
        System.Text.StringBuilder val_3 = AppendLine(value:  -1050835904);
        string val_4 = System.String.Format(format:  -1050827616, arg0:  13152256);
        System.Text.StringBuilder val_5 = AppendLine(value:  -1050827616);
        string val_6 = System.String.Format(format:  -1050819296, arg0:  13152256);
        System.Text.StringBuilder val_7 = AppendLine(value:  -1050819296);
        string val_8 = System.String.Format(format:  -1050810976, arg0:  13152256);
        System.Text.StringBuilder val_9 = AppendLine(value:  -1050810976);
        string val_10 = System.String.Format(format:  -1050810864, arg0:  8945664);
        if(new System.Text.StringBuilder() != 0)
        {
                System.Text.StringBuilder val_11 = AppendLine(value:  -1050810864);
            return;
        }
        
        System.Text.StringBuilder val_12 = AppendLine(value:  -1050810864);
    }
    public bool InExpireInterval()
    {
        ulong val_4;
        var val_11;
        ulong val_12;
        var val_14;
        val_11 = R6;
        if(R6 == 0)
        {
                if(val_11 == 0)
        {
            goto label_2;
        }
        
        }
        
        val_12 = mem[R6 + 40];
        val_12 = R6 + 40;
        if((System.DateTime.op_Equality(d1:  new System.DateTime() {dateData = R6 + 32}, d2:  new System.DateTime() {dateData = val_12})) != false)
        {
                System.DateTime val_3 = DateTimeCheat.UtcNow;
            bool val_6 = System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_4}, t2:  new System.DateTime() {dateData = this.claimedAwards});
        }
        else
        {
                System.DateTime val_7 = DateTimeCheat.UtcNow;
            val_12 = mem[R6 + 44 + 32];
            val_12 = R6 + 44 + 32;
            val_14 = 0;
            if((System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_4}, t2:  new System.DateTime() {dateData = val_12})) == false)
        {
                return (bool)val_14;
        }
        
            System.DateTime val_9 = DateTimeCheat.UtcNow;
        }
        
        val_14 = System.DateTime.op_LessThanOrEqual(t1:  new System.DateTime() {dateData = val_4}, t2:  new System.DateTime() {dateData = this.petCardsDict});
        return (bool)val_14;
        label_2:
    }
    public SeasonPassEventHandler.TierData GetTierData(int tierIndex)
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        val_5 = tierIndex;
        val_6 = mem[tierIndex + 20 + 48];
        val_6 = tierIndex + 20 + 48;
        val_7 = mem[tierIndex + 20 + 48 + 12];
        val_7 = tierIndex + 20 + 48 + 12;
        if(val_7 < R2)
        {
                return new TierData() {lvlUnlocked = true, passActive = true, freeCollected = true, passCollected = true, currentTier = false};
        }
        
        if((tierIndex + 20 + 48 + 12) <= R2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_4 = tierIndex + 20 + 48 + 8;
        val_8 = mem[tierIndex + 24];
        val_8 = tierIndex + 24;
        val_4 = val_4 + (R2 << 2);
        if(val_8 == 0)
        {
            goto label_8;
        }
        
        val_9 = mem[tierIndex + 24 + 20];
        val_9 = tierIndex + 24 + 20;
        goto label_9;
        label_8:
        val_9 = mem[tierIndex + 24 + 20];
        val_9 = tierIndex + 24 + 20;
        val_8 = mem[tierIndex + 24];
        val_8 = tierIndex + 24;
        if(val_8 == 0)
        {
            goto label_10;
        }
        
        label_9:
        if((tierIndex + 24 + 16) >= R2)
        {
                0 = 1;
        }
        
        label_14:
        label_15:
        val_5 = ((tierIndex + 24 + 16) - R2) >> 5;
        val_6 = mem[tierIndex + 24 + 28];
        val_6 = tierIndex + 24 + 28;
        this = R2;
        mem[1152921512146263876] = (tierIndex + 20 + 48 + 8 + (R2) << 2) + 16;
        mem[1152921512146263880] = 1;
        mem[1152921512146263881] = val_9;
        mem[1152921512146263882] = tierIndex + 24 + 24.Contains(item:  R2);
        mem[1152921512146263883] = val_6.Contains(item:  R2);
        val_7 = 0;
        mem[1152921512146263884] = val_5;
        mem[1152921512146263887] = val_7;
        mem[1152921512146263885] = 0;
        return new TierData() {lvlUnlocked = true, passActive = true, freeCollected = true, passCollected = true, currentTier = false};
        label_10:
        if((tierIndex + 24 + 16) >= R2)
        {
                0 = 1;
        }
        
        if((tierIndex + 24) != 0)
        {
            goto label_14;
        }
        
        if((tierIndex + 24) != 0)
        {
            goto label_15;
        }
    
    }
    public string GetChestContent(int itemAward)
    {
        int val_1 = (this.<econ>k__BackingField.ChestCoins) * itemAward;
        typeof(System.Object[]).__il2cppRuntimeField_10 = null;
        string val_2 = Localization.Localize(key:  -1050425520, defaultValue:  -1050425600, useSingularKey:  false);
        typeof(System.Object[]).__il2cppRuntimeField_14 = "coins_meta";
        int val_3 = (this.<econ>k__BackingField.ChestCards) * itemAward;
        typeof(System.Object[]).__il2cppRuntimeField_18 = null;
        if(itemAward == 1)
        {
                "Cards" = "Card";
        }
        
        string val_4 = Localization.Localize(key:  -1050421120, defaultValue:  -1050421328, useSingularKey:  true);
        typeof(System.Object[]).__il2cppRuntimeField_1C = "cards_meta";
        int val_5 = (this.<econ>k__BackingField.ChestApples) * itemAward;
        typeof(System.Object[]).__il2cppRuntimeField_20 = null;
        string val_6 = Localization.Localize(key:  -1050416848, defaultValue:  1098586544, useSingularKey:  false);
        typeof(System.Object[]).__il2cppRuntimeField_24 = "golden_apples_cap_first";
        string val_7 = System.String.Format(format:  -1050421248, args:  472754880);
    }
    public System.Collections.Generic.List<System.Tuple<SeasonPassEcon.Item, System.Decimal>> ClaimAward(int tierIndex, bool isPass)
    {
        int val_7;
        int val_10;
        var val_13;
        System.Collections.Generic.List<System.Int32> val_17;
        int val_18;
        Item val_19;
        var val_20;
        int val_21;
        int val_22;
        Item val_23;
        val_17 = isPass;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.claimedAwards = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.petCardAwards = null;
        this.petCardsDict = null;
        if((new System.Collections.Generic.Dictionary<WADPets.WADPet, System.Int32>()) <= tierIndex)
        {
                var val_15 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_15 = val_15 + (tierIndex << 2);
        val_18 = mem[(0 + (tierIndex) << 2) + 16];
        val_18 = (0 + (tierIndex) << 2) + 16;
        if(val_17 == false)
        {
            goto label_4;
        }
        
        if((this.<progression>k__BackingField.hasPass) == false)
        {
            goto label_6;
        }
        
        val_19 = val_18 + 8;
        goto label_8;
        label_4:
        val_19 = val_18 + 16;
        label_8:
        if(val_17 == true)
        {
                20 = 12;
        }
        
        if(val_17 == true)
        {
                24 = 28;
        }
        
        val_17 = this.<progression>k__BackingField.passAwardsCollected;
        if((val_17.Contains(item:  tierIndex)) == false)
        {
            goto label_13;
        }
        
        val_20 = "SeasonPassEventHandler: Reward already collected";
        goto label_16;
        label_13:
        val_17.Add(item:  tierIndex);
        if(val_19 == 5)
        {
                val_18 = this.<econ>k__BackingField.ChestCoins;
            int val_5 = val_18 * ((0 + (tierIndex) << 2) + 16 + 12);
            decimal val_6 = System.Decimal.op_Implicit(value:  -1050240164);
            this.RewardPlayer(tierIndex:  tierIndex, item:  0, amount:  new System.Decimal() {flags = val_7});
            int val_8 = (this.<econ>k__BackingField.ChestApples) * ((0 + (tierIndex) << 2) + 16 + 12);
            decimal val_9 = System.Decimal.op_Implicit(value:  -1050240180);
            this.RewardPlayer(tierIndex:  tierIndex, item:  4, amount:  new System.Decimal() {flags = val_10});
            int val_11 = (this.<econ>k__BackingField.ChestCards) * ((0 + (tierIndex) << 2) + 16 + 12);
            decimal val_12 = System.Decimal.op_Implicit(value:  -1050240196);
            val_21 = val_13;
            val_22 = tierIndex;
            val_23 = 1;
        }
        else
        {
                decimal val_14 = System.Decimal.op_Implicit(value:  -1050240164);
            val_21 = val_7;
            val_22 = tierIndex;
            val_23 = val_19;
        }
        
        this.RewardPlayer(tierIndex:  val_22, item:  val_23, amount:  new System.Decimal() {flags = val_21});
        this.UpdateProgressToServer();
        return;
        label_6:
        val_20 = "SeasonPassEventHandler: Pass is not active, cannot collect reward";
        label_16:
        UnityEngine.Debug.LogError(message:  -1050256416);
    }
    public System.Collections.Generic.List<System.Tuple<WADPets.WADPet, int>> GetRewardedPetCards()
    {
    
    }
    public void Hack_ResetProgress()
    {
        this.<progression>k__BackingField = new SeasonPassProgression();
        Player val_2 = App.Player;
        InitEvent(eventId:  R6 + 48, playerLevel:  0);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_3 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1049978960, value:  8945664);
        Player val_4 = App.Player;
        if(null != 0)
        {
                Add(key:  -1049978864, value:  13152256);
        }
        else
        {
                Add(key:  -1049978864, value:  13152256);
        }
        
        Add(key:  -1049978768, value:  1254115712);
        Add(key:  -1049978688, value:  1254115712);
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PutUpdate(eventID:  -1049954608, data:  78753792);
    }
    private void UpdateHintDiscounts()
    {
        if(SceneDictator.IsInGameScene() == false)
        {
                return;
        }
        
        if((this.<progression>k__BackingField.hasPass) == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2060922896) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            public static HintFeatureManager MonoSingleton<HintFeatureManager>::get_Instance().__il2cppRuntimeField_18.UpdateDisplay();
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2080453920) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static HintPickerController MonoSingleton<HintPickerController>::get_Instance().__il2cppRuntimeField_1C) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_11 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_12 = public static HintPickerController MonoSingleton<HintPickerController>::get_Instance().__il2cppRuntimeField_1C.GetComponent<System.Object>();
        if((public static HintPickerController MonoSingleton<HintPickerController>::get_Instance().__il2cppRuntimeField_1C) == 0)
        {
                return;
        }
        
        public static HintPickerController MonoSingleton<HintPickerController>::get_Instance().__il2cppRuntimeField_1C.UpdateDisplay();
    }
    private void UpdateProgressToServer()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1049978960, value:  8945664);
        Add(key:  -1049978864, value:  13152256);
        long val_2 = this.<progression>k__BackingField.EncodeProgression(pass:  true);
        Add(key:  -1049978768, value:  13205504);
        long val_3 = this.<progression>k__BackingField.EncodeProgression(pass:  false);
        Add(key:  -1049978688, value:  13205504);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PutUpdate(eventID:  -1049700912, data:  78753792);
    }
    private void ParseEventData(System.Collections.Generic.Dictionary<string, object> eventData)
    {
        SeasonPassEcon val_28;
        float val_29;
        SeasonPassProgression val_30;
        if(eventData == 0)
        {
                return;
        }
        
        if(eventData.Count == 0)
        {
                return;
        }
        
        if((eventData.ContainsKey(key:  -1545439648)) != false)
        {
                object val_3 = eventData.Item[-1545439648];
            val_28 = 0;
            val_29 = 1;
            if((val_28.ContainsKey(key:  -1049978960)) != false)
        {
                string val_5 = val_28.Item[-1049978960];
            val_30 = val_28;
            bool val_7 = System.Boolean.TryParse(value:  null, result: out  this.<progression>k__BackingField.hasPass);
        }
        
            if((val_28.ContainsKey(key:  -1049978864)) != false)
        {
                string val_9 = val_28.Item[-1049978864];
            val_30 = this.<progression>k__BackingField;
            bool val_11 = System.Int32.TryParse(s:  null, result: out  this.<progression>k__BackingField.initLevel);
        }
        
            if((val_28.ContainsKey(key:  -1049978768)) != false)
        {
                val_30 = this.<progression>k__BackingField;
            string val_13 = val_28.Item[-1049978768];
            val_30.DecodeProgression(pass:  true, progression:  null);
        }
        
            if((val_28.ContainsKey(key:  -1049978688)) != false)
        {
                val_30 = this.<progression>k__BackingField;
            string val_15 = val_28.Item[-1049978688];
            val_30.DecodeProgression(pass:  false, progression:  null);
        }
        
        }
        
        if((eventData.ContainsKey(key:  -1554533760)) == false)
        {
                return;
        }
        
        val_29 = 1152921510385703632;
        object val_17 = eventData.Item[-1554533760];
        val_30 = 1;
        if((0.ContainsKey(key:  -1049576048)) != false)
        {
                string val_19 = 0.Item[-1049576048];
            val_28 = this.<econ>k__BackingField;
            bool val_21 = System.Int32.TryParse(s:  null, result: out  this.<econ>k__BackingField.PassPickerHintDiscount);
        }
        
        if((0.ContainsKey(key:  -1049571872)) != false)
        {
                string val_23 = 0.Item[-1049571872];
            val_28 = this.<econ>k__BackingField;
            bool val_25 = System.Int32.TryParse(s:  null, result: out  this.<econ>k__BackingField.PassHintDiscount);
        }
        
        if((0.ContainsKey(key:  -1049567696)) == false)
        {
                return;
        }
        
        string val_27 = 0.Item[-1049567696];
        this._uniqueSeasonName = 0;
    }
    private void RewardPlayer(int tierIndex, SeasonPassEcon.Item item, decimal amount)
    {
        int val_14;
        int val_15;
        SeasonPassEventHandler val_16;
        string val_1 = -1049422848(-1049422848) + 13152256;
        if(item <= 4)
        {
                var val_2 = 7778556 + (7778556 + (item) << 2);
            if(item == 4)
        {
                7778556 = 7778556 & (amount.hi << 7778556);
            7778556 = 7778556 & (tierIndex >> 1);
            7778556 = 7778556 & (amount.hi >> 2);
            7778556 = 7778556 & (((IP) << (32-3)) | ((IP) << 3));
            mem2[0] = ((((7778556 & (amount.hi) << 7778556) & ((int)tierIndex) >> 1) & (amount.hi) >> 2) & ((IP) << (32-3)) | ((IP) << 3)) + IP;
        }
        
            Player val_3 = App.Player;
            if(tierIndex > 0)
        {
                "Season Event Free Reward" = "Season Event Reward Tier ";
        }
        
            if(0 == 0)
        {
                val_14 = val_14;
            val_15 = val_15;
        }
        
            0.AddCredits(amount:  new System.Decimal() {flags = amount.flags, hi = val_14, lo = val_15, mid = amount.mid}, source:  "Season Event", subSource:  "Season Event Free Reward", externalParams:  0, doTrack:  true);
        }
        
        val_16 = this;
        System.Tuple<Item, System.Decimal> val_13 = new System.Tuple<Item, System.Decimal>(item1:  item, item2:  new System.Decimal() {flags = amount.flags, hi = amount.hi, lo = amount.lo, mid = amount.mid});
        mem[1152921512147385056].Add(item:  6656000);
    }
    private void RewardPetCards(int amount, string subSource)
    {
        WADPets.WADPet val_8;
        int val_11 = amount;
        if(val_11 >= 1)
        {
                do
        {
            twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            WADPets.WADPet val_2 = GetRandomPet();
            bool val_3 = this.petCardsDict.ContainsKey(key:  -1929661328);
            if(val_3 != false)
        {
                this.petCardsDict.set_Item(key:  -1929661328, value:  (this.petCardsDict.Item[-1929661328]) + 1);
        }
        else
        {
                this.petCardsDict.Add(key:  -1929661328, value:  1);
        }
        
            val_11 = val_11 - 1;
        }
        while(val_3 == true);
        
        }
        
        Dictionary.Enumerator<TKey, TValue> val_6 = 0.GetEnumerator();
        label_17:
        if(0.MoveNext() == false)
        {
            goto label_12;
        }
        
        System.Tuple<WADPets.WADPet, System.Int32> val_9 = new System.Tuple<WADPets.WADPet, System.Int32>(item1:  val_8, item2:  0);
        this.petCardAwards.Add(item:  6656000);
        twelvegigs.Autopilot.AutopilotManager val_10 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        RewardPetCards(amount:  0, pet:  val_8, source:  -1298908720, subsource:  subSource, additionalParam:  0);
        goto label_17;
        label_12:
        0.Dispose();
    }
    public SeasonPassEventHandler()
    {
    
    }

}
