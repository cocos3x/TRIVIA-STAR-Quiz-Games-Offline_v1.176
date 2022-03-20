using UnityEngine;
public class KeyToRichesEventHandler : WGEventHandler
{
    // Fields
    public const string EVENT_ID = "KeyToRiches";
    public const string PURCHASE_ID_BASE = "id_keyPack";
    public const string KEY_TO_RICHES_EVENT_REWARD = "Key to Riches Event Reward";
    public System.Action OnKeyBalanceChanged;
    private static KeyToRichesEventHandler _Instance;
    private KeyToRichesEventHandler.Econ econ;
    private KeyToRichesEventHandler.EventProgress eventProgress;
    private System.Collections.Generic.List<string> lettersToReward;
    private System.Collections.Generic.Dictionary<Alphabet2Manager.Rarity, int> lettersInfo;
    private KeyToRichesTile currentKey;
    private UnityEngine.GameObject eventButtonGO;
    private bool <HackShowKeyEveryLevel>k__BackingField;
    private bool showChestContent;
    
    // Properties
    public static KeyToRichesEventHandler Instance { get; }
    public GameEventV2 getEvent { get; }
    public bool KeyShowing { get; }
    public int KeyCount { get; set; }
    public int LevelsPerKey { get; }
    public bool IsKeyLevel { get; }
    public int KeyWordIndex { get; }
    public UnityEngine.GameObject EventButtonGO { get; }
    private UnityEngine.GameObject KeyTileObjectPrefab { get; }
    public int HackLevelsCounter { get; set; }
    public string KeyWord { get; }
    public int HackKeyCount { get; set; }
    public bool HackShowKeyEveryLevel { get; set; }
    public bool ShowChestContent { get; set; }
    
    // Methods
    public static KeyToRichesEventHandler get_Instance()
    {
    
    }
    public GameEventV2 get_getEvent()
    {
    
    }
    public bool get_KeyShowing()
    {
        return UnityEngine.Object.op_Inequality(x:  this.currentKey, y:  0);
    }
    public int get_KeyCount()
    {
        if(this.eventProgress != 0)
        {
                return (int)this.eventProgress.keyCount;
        }
        
        return (int)this.eventProgress.keyCount;
    }
    private void set_KeyCount(int value)
    {
        this.eventProgress.keyCount = value;
        if(this.OnKeyBalanceChanged == 0)
        {
                return;
        }
        
        this.OnKeyBalanceChanged.Invoke();
    }
    public int get_LevelsPerKey()
    {
        if(this.econ != 0)
        {
                this.econ = this.econ.levelsPerKey;
        }
        
        if(this.econ == 0)
        {
                this.econ = 0;
        }
        
        return (int)this.econ;
    }
    public bool get_IsKeyLevel()
    {
        int val_1 = this.eventProgress.levelsCounter;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public int get_KeyWordIndex()
    {
        if(this.eventProgress != 0)
        {
                return (int)this.eventProgress.keyWordIndex;
        }
        
        return (int)this.eventProgress.keyWordIndex;
    }
    public UnityEngine.GameObject get_EventButtonGO()
    {
    
    }
    private UnityEngine.GameObject get_KeyTileObjectPrefab()
    {
        return PrefabLoader.LoadPrefab(featureName:  -1535358816, prefabName:  -1358833856);
    }
    public override void OnPreprocessPlayerTurn(bool hintUsage, string wordEntered, LineWord lineWord, Cell cell)
    {
        var val_6;
        EventProgress val_7;
        val_6 = 35636459;
        if(CategoryPacksManager.IsPlaying == true)
        {
                return;
        }
        
        if(this.KeyShowing == false)
        {
                return;
        }
        
        WordRegion val_3 = WordRegion.instance;
        val_7 = this.eventProgress;
        if(this.eventProgress.keyWordIndex < 0)
        {
                return;
        }
        
        val_7 = this.eventProgress.keyWordIndex;
        val_6 = 0;
        if(val_7 >= 0)
        {
                return;
        }
        
        if((System.String.IsNullOrEmpty(value:  wordEntered)) == true)
        {
                return;
        }
        
        val_7 = this.eventProgress.keyWordIndex;
        if(0 <= val_7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_6 = 0;
        val_6 = val_6 + (val_7 << 2);
        bool val_5 = (0 + (this.eventProgress.keyWordIndex) << 2) + 16 + 12.Equals(value:  wordEntered);
        if(val_5 == true)
        {
                val_5 = 1;
            mem[20] = val_5;
        }
    
    }
    private void OnWordSubmitted(string wordCompleted)
    {
        WordRegion val_1 = WordRegion.instance;
        if(0 <= this.eventProgress.keyWordIndex)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_3 = 0;
        val_3 = val_3 + (this.eventProgress.keyWordIndex << 2);
        if(((0 + (this.eventProgress.keyWordIndex) << 2) + 16 + 12.Equals(value:  wordCompleted)) != false)
        {
                this.CollectCurrentKey();
            return;
        }
        
        this.MoveOrRemoveKey();
    }
    public override void OnValidWordSubmitted(string word)
    {
        if(CategoryPacksManager.IsPlaying == true)
        {
                return;
        }
        
        if(this.KeyShowing == false)
        {
                return;
        }
        
        this.OnWordSubmitted(wordCompleted:  word);
    }
    public override void OnHintIncompleteWord(string word, Cell hintedCell)
    {
        string val_6;
        int val_7;
        val_6 = word;
        if(CategoryPacksManager.IsPlaying == true)
        {
                return;
        }
        
        if(this.KeyShowing == false)
        {
                return;
        }
        
        WordRegion val_3 = WordRegion.instance;
        if(0 <= this.eventProgress.keyWordIndex)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_6 = 0;
        val_6 = val_6 + (this.eventProgress.keyWordIndex << 2);
        val_7 = mem[(0 + (this.eventProgress.keyWordIndex) << 2) + 16];
        val_7 = (0 + (this.eventProgress.keyWordIndex) << 2) + 16;
        if((System.String.op_Inequality(a:  val_6, b:  (0 + (this.eventProgress.keyWordIndex) << 2) + 16 + 12)) == true)
        {
                return;
        }
        
        val_7 = this.eventProgress.cellIndex;
        if(((0 + (this.eventProgress.keyWordIndex) << 2) + 16 + 20 + 12) <= val_7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_7 = (0 + (this.eventProgress.keyWordIndex) << 2) + 16 + 20 + 8;
        val_7 = val_7 + (val_7 << 2);
        val_6 = mem[((0 + (this.eventProgress.keyWordIndex) << 2) + 16 + 20 + 8 + (this.eventProgress.cellIndex) << 2) + 16];
        val_6 = ((0 + (this.eventProgress.keyWordIndex) << 2) + 16 + 20 + 8 + (this.eventProgress.cellIndex) << 2) + 16;
        if(hintedCell != val_6)
        {
                return;
        }
        
        this.MoveOrRemoveKey();
    }
    public override void Init(GameEventV2 eventV2)
    {
        var val_5;
        var val_6;
        mem[1152921511838650616] = eventV2;
        KeyToRichesEventHandler._Instance = this;
        this.LoadOrGenerateNewData();
        if(eventV2.eventData != 0)
        {
                this.ParseEventData(eventData:  eventV2.eventData);
        }
        
        val_5 = 1152921504892043264;
        Player val_1 = App.Player;
        GameEcon val_2 = App.getGameEcon;
        val_6 = 0;
        if(0 < 983057)
        {
                return;
        }
        
        GameBehavior val_3 = App.getBehavior;
        if(0 != 2)
        {
                return;
        }
        
        goto typeof(KeyToRichesEventHandler).__il2cppRuntimeField_12C;
    }
    public override void OnPurchaseCompleted(PurchaseModel purchase)
    {
        var val_6;
        var val_8;
        decimal val_9;
        decimal val_1 = Keys;
        val_6 = null;
        val_6 = null;
        val_8 = 1152921504617017344;
        val_9 = System.Decimal.Zero;
        if((System.Decimal.op_Equality(d1:  new System.Decimal(), d2:  new System.Decimal() {flags = val_9})) == true)
        {
                return;
        }
        
        val_9 = this.eventProgress.keyCount;
        val_8 = 0;
        decimal val_3 = Keys;
        this.KeyCount = (System.Decimal.op_Explicit(value:  new System.Decimal())) + val_9;
        this.SaveData();
    }
    public override void OnMainMenuButtonPressed(bool connected)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public override void OnGameButtonPressed(bool connected)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public override void OnMenuLoaded()
    {
        this.SaveData();
    }
    public override void OnGameSceneInit()
    {
        if(CategoryPacksManager.IsPlaying == true)
        {
                return;
        }
        
        if((R4 + 24 + 12) >= 3)
        {
                twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_3 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        
        object val_4 = UnityEngine.Object.FindObjectOfType<System.Object>();
        UnityEngine.GameObject val_5 = public static WGEventButton_Game UnityEngine.Object::FindObjectOfType<WGEventButton_Game>().__il2cppRuntimeField_14.gameObject;
        mem2[0] = public static WGEventButton_Game UnityEngine.Object::FindObjectOfType<WGEventButton_Game>().__il2cppRuntimeField_14;
        R4.TryPlaceKey();
    }
    public override bool EventCompleted()
    {
        ulong val_2;
        System.DateTime val_1 = DateTimeCheat.UtcNow;
        return (bool)System.DateTime.op_GreaterThanOrEqual(t1:  new System.DateTime() {dateData = val_2}, t2:  new System.DateTime() {dateData = this.lettersInfo});
    }
    public override string GetEventDisplayName()
    {
        return Localization.Localize(key:  -1357332976, defaultValue:  -1357333072, useSingularKey:  false);
    }
    public override string GetMainMenuButtonText()
    {
        string val_1 = Localization.Localize(key:  -1357332976, defaultValue:  -1357333072, useSingularKey:  false);
        string val_2 = System.String.Format(format:  -1357216768, arg0:  13152256);
        string val_3 = -1357332976(-1357332976) + -1357216768(-1357216768);
    }
    public override string GetGameButtonText()
    {
        string val_1 = System.String.Format(format:  -1357096496, arg0:  13152256);
    }
    public override void LoadEventListItemContent(PrefabsFromFolder loader)
    {
        string val_1 = System.String.Format(format:  -1357096496, arg0:  13152256);
        float val_3 = 3f;
        val_3 = (float)this.eventProgress.keyCount / val_3;
        TheLibraryMainScreen val_2 = loader.LoadStrictlyTypeNamedPrefab<TheLibraryMainScreen>(allowMultiple:  false);
        if(loader != 0)
        {
                return;
        }
    
    }
    public override void AppendLevelCompleteData(ref System.Collections.Generic.Dictionary<string, object> currentData)
    {
        if(this.eventProgress.levelsCounter != 0)
        {
                return;
        }
        
        EnumerableExtentions.SetOrAdd<System.String, WordForest.WFOMiniEventButton>(dic:  currentData, key:  -1356830512, newValue:  8945664);
    }
    public override void OnLevelComplete(int levelsProgressed = 1)
    {
        EventProgress val_3;
        int val_4;
        this.CloseFtux();
        this.lettersToReward.Clear();
        this.lettersInfo.Clear();
        this.currentKey = 0;
        this.eventButtonGO = 0;
        if(CategoryPacksManager.IsPlaying != false)
        {
                return;
        }
        
        val_3 = this.eventProgress;
        if(val_3 != 0)
        {
                val_4 = this.eventProgress.levelsCounter;
        }
        else
        {
                val_3 = 16;
            val_4 = 2621443;
        }
        
        mem[16] = val_4 + levelsProgressed;
        this.eventProgress.collected = false;
        this.eventProgress.skipped = false;
        this.eventProgress.keyWordIndex = 0;
        this.eventProgress.cellIndex = 0;
        this.SaveData();
    }
    public void PurchaseKeys(int keysToPurchase)
    {
        int val_1 = keysToPurchase - 1;
        if(val_1 > 2)
        {
                return;
        }
        
        twelvegigs.storage.JsonDictionary val_2 = val_1.GetPackageByKeyCount(keysToPurchase:  R4);
        PurchaseModel val_3 = new PurchaseModel(json:  val_1);
        bool val_4 = PurchaseProxy.Purchase(purchase:  292597760);
    }
    public twelvegigs.storage.JsonDictionary GetPackageByKeyCount(int keysToPurchase)
    {
        keysToPurchase = keysToPurchase - 1;
        if(keysToPurchase > 2)
        {
                return;
        }
        
        string val_1 = -1356423840(-1356423840) + 13152256;
        twelvegigs.storage.JsonDictionary val_2 = PackagesManager.GetPackageById(packageId:  -1356423840);
    }
    public string GetPackagePriceByKeyCount(int keysToPurchase)
    {
        bool val_5;
        var val_6;
        val_5 = static_value_021FC4FD;
        if(val_5 != true)
        {
                val_5 = true;
        }
        
        twelvegigs.storage.JsonDictionary val_1 = this.GetPackageByKeyCount(keysToPurchase:  keysToPurchase);
        if(val_5 != 0)
        {
                string val_2 = val_5.getString(key:  -1816221600, defaultValue:  1098586544);
            val_6 = val_5;
            if((System.String.op_Equality(a:  1, b:  1098586544)) == false)
        {
                return;
        }
        
            string val_4 = val_5.getString(key:  -1816221696, defaultValue:  1098586544);
            return -1802497744(-1802497744) + 1;
        }
        
        val_6 = "";
    }
    public System.Collections.Generic.List<KeyToRichesEventHandler.Reward> GenerateRewards(bool isPurchase = False)
    {
        int val_15;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_16;
        var val_17;
        val_15 = 35636478;
        if(this.econ == 0)
        {
            goto label_1;
        }
        
        this.lettersToReward.Clear();
        this.lettersInfo.Clear();
        if(isPurchase == true)
        {
            goto label_4;
        }
        
        Player val_1 = App.Player;
        if(0 < 150)
        {
            goto label_8;
        }
        
        label_4:
        label_8:
        val_16 = null;
        val_16 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        var val_15 = 0;
        label_19:
        val_17 = 0;
        goto label_9;
        label_18:
        System.Collections.Generic.List<Reward> val_3 = this.econ.tierRewards.Item[0];
        System.Collections.Generic.List<Reward> val_4 = this.econ.tierRewards.Item[0];
        object val_6 = System.Linq.Enumerable.ElementAt<System.Object>(source:  this.econ.tierRewards, index:  UnityEngine.Random.Range(min:  0, max:  0));
        Add(item:  this.econ.tierRewards);
        val_17 = 1;
        label_9:
        if(val_17 < this.econ.tierQuantity.Item[0])
        {
            goto label_18;
        }
        
        val_15 = val_15 + 1;
        if(val_15 != 3)
        {
            goto label_19;
        }
        
        var val_16 = 0;
        val_15 = UnityEngine.Random.Range(min:  0, max:  1094062064);
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        set_Item(index:  0, value:  (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_13) << 2) + 16);
        set_Item(index:  val_15, value:  List<T>.__il2cppRuntimeField_10);
        val_16 = val_16 + 1;
        return;
        label_1:
        val_16 = 0;
    }
    public bool OpenChest(KeyToRichesEventHandler.Reward reward)
    {
        int val_3;
        int val_4;
        int val_5;
        int val_6;
        EventProgress val_7;
        var val_8;
        val_7 = this.eventProgress;
        if(this.eventProgress.keyCount < 1)
        {
            goto label_2;
        }
        
        this.KeyCount = this.eventProgress.keyCount - 1;
        if(reward == 0)
        {
            goto label_4;
        }
        
        val_7 = reward.<rewardType>k__BackingField;
        goto label_5;
        label_2:
        val_8 = 0;
        return (bool)val_8;
        label_4:
        val_7 = 0;
        label_5:
        decimal val_2 = System.Decimal.op_Implicit(value:  -1355946760);
        this.RewardPlayer(rewardType:  0, amount:  new System.Decimal() {flags = val_4, hi = val_5, lo = val_6, mid = val_3});
        val_8 = 1;
        return (bool)val_8;
    }
    public void RewardKeys(int amount)
    {
        amount = this.eventProgress.keyCount + amount;
        this.KeyCount = amount;
        this.SaveData();
    }
    public void OnRewardComplete()
    {
        this.CheckFtuxKey();
        this.RewardAlphabets();
        this.SaveData();
    }
    public void OnFlyToComplete()
    {
        if(this.eventProgress.keyCount < 3)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public System.Collections.Generic.List<string> RerollLetters()
    {
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        Rarity val_16;
        var val_17;
        if(this.lettersInfo.Count == 0)
        {
                return;
        }
        
        this.lettersToReward.Clear();
        System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(306335744)});
        System.Array val_3 = System.Enum.GetValues(enumType:  306335744);
        System.Collections.IEnumerator val_4 = GetEnumerator();
        label_30:
        Alphabet2Manager.Rarity val_12 = ;
        if(( + 178) == 0)
        {
            goto label_10;
        }
        
        val_12 = 0;
        label_12:
        val_13 = 0;
        if(( + 88 + 0) == null)
        {
            goto label_11;
        }
        
        val_12 = val_12 + 1;
        val_13 = (uint)val_12 & 65535;
        if(val_13 < ( + 178))
        {
            goto label_12;
        }
        
        label_10:
        val_14 = null;
        goto label_13;
        label_11:
        var val_5 = ( + 88) + 0;
        val_12 = val_12 + ((( + 88 + 0) + 4) << 3);
        label_13:
        if(null == 0)
        {
            goto label_14;
        }
        
        Alphabet2Manager.Rarity val_14 = ;
        if(( + 178) == 0)
        {
            goto label_16;
        }
        
        var val_13 = 0;
        label_18:
        if(( + 88 + 0) == null)
        {
            goto label_17;
        }
        
        val_13 = val_13 + 1;
        if(((uint)val_13 & 65535) < ( + 178))
        {
            goto label_18;
        }
        
        label_16:
        val_15 = null;
        goto label_19;
        label_17:
        var val_6 = ( + 88) + 0;
        val_14 = val_14 + ((( + 88 + 0) + 4) << 3);
        label_19:
        val_16 = 0;
        if((this.lettersInfo.ContainsKey(key:  null)) == false)
        {
            goto label_30;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<System.String> val_10 = RollLettersForRarity(rarity:  null, count:  this.lettersInfo.Item[null]);
        this.lettersToReward.AddRange(collection:  -2100700048);
        goto label_30;
        label_14:
        if(null == 0)
        {
                return;
        }
        
        Alphabet2Manager.Rarity val_15 = ;
        if(( + 178) == 0)
        {
            goto label_32;
        }
        
        val_12 = 0;
        label_34:
        val_13 = mem[ + 88 + 0];
        val_13 =  + 88 + 0;
        if(val_13 == null)
        {
            goto label_33;
        }
        
        val_12 = val_12 + 1;
        if(((uint)val_12 & 65535) < ( + 178))
        {
            goto label_34;
        }
        
        label_32:
        val_17 = null;
        goto label_35;
        label_33:
        var val_11 = ( + 88) + 0;
        val_15 = val_15 + ((( + 88 + 0) + 4) << 3);
        label_35:
    }
    public override int GetMovingWordIndex()
    {
        if(this.eventProgress.levelsCounter != 0)
        {
                return this.GetMovingWordIndex();
        }
        
        if(this.eventProgress != 0)
        {
                return (int)this.eventProgress.keyWordIndex;
        }
        
        return (int)this.eventProgress.keyWordIndex;
    }
    private void GenerateNewData()
    {
        typeof(KeyToRichesEventHandler.EventProgress).__il2cppRuntimeField_18 = 0;
        typeof(KeyToRichesEventHandler.EventProgress).__il2cppRuntimeField_1C = 0;
        object val_1 = new System.Object();
        this.eventProgress = null;
        typeof(KeyToRichesEventHandler.EventProgress).__il2cppRuntimeField_8 = R6 + 48;
        this.SaveData();
    }
    private void LoadOrGenerateNewData()
    {
        string val_1 = CPlayerPrefs.GetString(key:  -1355073344, defaultValue:  1098586544);
        if((System.String.IsNullOrEmpty(value:  -1355073344)) != true)
        {
                object val_3 = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Object>(value:  -1355073344);
            this.eventProgress = "keyToRichesData";
            if(R6 != 0)
        {
                return;
        }
        
            return;
        }
        
        this.GenerateNewData();
    }
    private void SaveData()
    {
        string val_1 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  this.eventProgress);
        CPlayerPrefs.SetString(key:  -1355073344, val:  this.eventProgress);
        CPlayerPrefs.Save();
    }
    private void CheckFtuxKey()
    {
        if(this.KeyShowing == false)
        {
                return;
        }
        
        if(this.eventProgress.keyFtuxShown != false)
        {
                this.currentKey.SetupAndShowFlyout(isFtux:  false);
            return;
        }
        
        this.currentKey.SetupAndShowFlyout(isFtux:  true);
        this.eventProgress.keyFtuxShown = true;
    }
    private void CheckFtuxEventButton()
    {
        UnityEngine.GameObject val_8;
        if(this.eventProgress.eventButtonFtuxShown == true)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = PlaceGameObject<System.Object>(loc:  0);
        val_8 = this.eventButtonGO;
        if(val_8 != 0)
        {
                string val_4 = Localization.Localize(key:  -1354695120, defaultValue:  -1354695248, useSingularKey:  false);
            ShowToolTip(objToToolTip:  this.eventButtonGO, text:  -1354695120, topToolTip:  true, displayDuration:  null, width:  null, height:  null, tooltipOffsetX:  null, tooltipOffsetY:  null, viewportSettings:  1082130432, showGotItButton:  false, gotItCallback:  0, showPick:  false, maxFontSize:  0);
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            object val_6 = ShowUGUIMonolith<System.Object>(showNext:  false);
            val_8 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
            System.Action val_7 = new System.Action(object:  -2009104640, method:  new IntPtr(2940277424));
            public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_10 = null;
        }
        
        this.eventProgress.eventButtonFtuxShown = true;
    }
    private void CloseFtux()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = GetWindow<System.Object>();
        Close();
    }
    private void TryPlaceKey()
    {
        EventProgress val_34;
        UnityEngine.Timeline.SignalAsset val_35;
        int val_36;
        UnityEngine.Transform val_37;
        var val_38;
        System.Predicate<LineWord> val_40;
        var val_41;
        System.Func<LineWord, System.Int32> val_43;
        var val_44;
        System.Func<System.Linq.IGrouping<System.Int32, LineWord>, System.Int32> val_46;
        var val_47;
        System.Func<System.Linq.IGrouping<System.Int32, LineWord>, System.Int32> val_49;
        var val_50;
        int val_51;
        object val_1 = new System.Object();
        val_34 = this.eventProgress;
        if(this.eventProgress.collected == true)
        {
                return;
        }
        
        val_34 = this.eventProgress;
        if(this.eventProgress.skipped != false)
        {
                return;
        }
        
        if((this.<HackShowKeyEveryLevel>k__BackingField) == false)
        {
            goto label_5;
        }
        
        label_70:
        this.eventProgress.levelsCounter = 0;
        val_35 = 1152921504765685760;
        if(((this.currentKey != 0) || (this.eventProgress.keyWordIndex == 1)) || (this.eventProgress.cellIndex == 1))
        {
            goto label_13;
        }
        
        UnityEngine.GameObject val_3 = this.eventProgress.cellIndex.KeyTileObjectPrefab;
        WordRegion val_4 = WordRegion.instance;
        if(0 <= this.eventProgress.keyWordIndex)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_32 = 0;
        val_32 = val_32 + (this.eventProgress.keyWordIndex << 2);
        val_36 = this.eventProgress.cellIndex;
        if(((0 + (this.eventProgress.keyWordIndex) << 2) + 16 + 20 + 12) <= val_36)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_33 = (0 + (this.eventProgress.keyWordIndex) << 2) + 16 + 20 + 8;
        val_33 = val_33 + (val_36 << 2);
        UnityEngine.Transform val_5 = ((0 + (this.eventProgress.keyWordIndex) << 2) + 16 + 20 + 8 + (this.eventProgress.cellIndex) << 2) + 16.transform;
        val_37 = ((0 + (this.eventProgress.keyWordIndex) << 2) + 16 + 20 + 8 + (this.eventProgress.cellIndex) << 2) + 16;
        object val_6 = UnityEngine.Object.Instantiate<System.Object>(original:  this.eventProgress.cellIndex, parent:  val_37);
        object val_7 = this.eventProgress.cellIndex.GetComponent<System.Object>();
        this.currentKey = this.eventProgress.cellIndex;
        goto label_28;
        label_13:
        WordRegion val_8 = WordRegion.instance;
        val_38 = null;
        val_38 = null;
        val_40 = KeyToRichesEventHandler.<>c.<>9__68_0;
        if(val_40 == 0)
        {
                val_40 = null;
            val_40 = new System.Predicate<ZooTile>(object:  KeyToRichesEventHandler.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2940557744));
            KeyToRichesEventHandler.<>c.<>9__68_0 = val_40;
        }
        
        if((0.Exists(match:  8040448)) == true)
        {
                return;
        }
        
        WordRegion val_11 = WordRegion.instance;
        System.Collections.Generic.List<LineWord> val_12 = 0.getAvailableLineWords;
        val_41 = null;
        val_41 = null;
        val_43 = KeyToRichesEventHandler.<>c.<>9__68_1;
        if(val_43 == 0)
        {
                val_43 = null;
            val_43 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  KeyToRichesEventHandler.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2940558768));
            KeyToRichesEventHandler.<>c.<>9__68_1 = val_43;
        }
        
        System.Collections.Generic.IEnumerable<System.Linq.IGrouping<TKey, TSource>> val_14 = System.Linq.Enumerable.GroupBy<System.Object, System.Int32>(source:  0, keySelector:  7720960);
        val_44 = null;
        val_44 = null;
        val_46 = KeyToRichesEventHandler.<>c.<>9__68_2;
        if(val_46 == 0)
        {
                val_46 = null;
            val_46 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  KeyToRichesEventHandler.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2940560816));
            KeyToRichesEventHandler.<>c.<>9__68_2 = val_46;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_16 = System.Linq.Enumerable.OrderByDescending<System.Object, System.Int32>(source:  0, keySelector:  7720960);
        System.Collections.Generic.List<TSource> val_17 = System.Linq.Enumerable.ToList<System.Object>(source:  0);
        if(0 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        typeof(KeyToRichesEventHandler.<>c__DisplayClass68_0).__il2cppRuntimeField_8 = System.Linq.Enumerable.Count<WGEventHandler>(source:  2621443);
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_19 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  319381504, method:  new IntPtr(2940565936));
        System.Collections.Generic.IEnumerable<TSource> val_20 = System.Linq.Enumerable.Where<System.Object>(source:  0, predicate:  7720960);
        val_47 = null;
        val_47 = null;
        val_49 = KeyToRichesEventHandler.<>c.<>9__68_4;
        if(val_49 == 0)
        {
                val_49 = null;
            val_49 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  KeyToRichesEventHandler.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2940569008));
            KeyToRichesEventHandler.<>c.<>9__68_4 = val_49;
        }
        
        object val_22 = MoreLinq.MaxBy<System.Object, System.Int32>(source:  0, selector:  7720960);
        System.Collections.Generic.List<TSource> val_23 = System.Linq.Enumerable.ToList<System.Object>(source:  0);
        int val_34 = System.Linq.Enumerable.Count<WGEventHandler>(source:  0);
        int val_25 = val_34 - 1;
        val_25 = val_25 + (val_25 >> 31);
        val_34 = val_25 >> 1;
        if(0 <= (val_25 >> 1))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_35 = 0;
        val_35 = val_35 + (val_34 << 2);
        val_35 = mem[(0 + ((((val_24 - 1) + ((val_24 - 1)) >> 31) >> 1)) << 2) + 16];
        val_35 = (0 + ((((val_24 - 1) + ((val_24 - 1)) >> 31) >> 1)) << 2) + 16;
        val_50 = mem[(0 + ((((val_24 - 1) + ((val_24 - 1)) >> 31) >> 1)) << 2) + 16 + 20];
        val_50 = (0 + ((((val_24 - 1) + ((val_24 - 1)) >> 31) >> 1)) << 2) + 16 + 20;
        if(val_50 == 0)
        {
            goto label_63;
        }
        
        var val_36 = (0 + ((((val_24 - 1) + ((val_24 - 1)) >> 31) >> 1)) << 2) + 16 + 20 + 12;
        val_36 = val_36 - 1;
        val_36 = val_36 + (val_36 >> 31);
        val_51 = val_36 >> 1;
        goto label_71;
        label_5:
        if(this.eventProgress.levelsCounter == 0)
        {
            goto label_70;
        }
        
        if(this.eventProgress.levelsCounter < this.econ.levelsPerKey)
        {
                return;
        }
        
        goto label_70;
        label_63:
        var val_37 = (0 + ((((val_24 - 1) + ((val_24 - 1)) >> 31) >> 1)) << 2) + 16 + 20 + 12;
        val_50 = mem[(0 + ((((val_24 - 1) + ((val_24 - 1)) >> 31) >> 1)) << 2) + 16 + 20];
        val_50 = (0 + ((((val_24 - 1) + ((val_24 - 1)) >> 31) >> 1)) << 2) + 16 + 20;
        val_37 = val_37 - 1;
        val_37 = val_37 + (val_37 >> 31);
        val_51 = val_37 >> 1;
        if(val_50 == 0)
        {
                val_50 = 0;
        }
        
        label_71:
        if(0 <= val_51)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        object val_38 = 0;
        val_38 = val_38 + (val_51 << 2);
        UnityEngine.GameObject val_26 = val_38.KeyTileObjectPrefab;
        UnityEngine.Transform val_27 = (0 + (((((0 + ((((val_24 - 1) + ((val_24 - 1)) >> 31) >> 1)) << 2) + 16 + 20 + 12 - 1) + (((0 + ((((val_24 - 1) + ((val_24 - 1)) >> 31) >> 1)) << 2) + 16 + 20 + 12 - 1)) >> 31) >> 1)) << 2) + 16.transform;
        object val_28 = UnityEngine.Object.Instantiate<System.Object>(original:  val_38, parent:  (0 + (((((0 + ((((val_24 - 1) + ((val_24 - 1)) >> 31) >> 1)) << 2) + 16 + 20 + 12 - 1) + (((0 + ((((val_24 - 1) + ((val_24 - 1)) >> 31) >> 1)) << 2) + 16 + 20 + 12 - 1)) >> 31) >> 1)) << 2) + 16);
        object val_29 = val_38.GetComponent<System.Object>();
        this.currentKey = val_38;
        this.eventProgress.cellIndex = val_51;
        val_36 = this.eventProgress;
        WordRegion val_30 = WordRegion.instance;
        val_37 = 0;
        this.eventProgress.keyWordIndex = val_37.IndexOf(item:  val_35);
        this.SaveData();
        label_28:
        this.CheckFtuxKey();
    }
    private void CollectCurrentKey()
    {
        this.KeyCount = this.eventProgress.keyCount + 1;
        System.Collections.IEnumerator val_2 = this.currentKey.FlyAndHide();
        UnityEngine.Coroutine val_3 = this.currentKey.StartCoroutine(routine:  this.currentKey);
        this.eventProgress.collected = true;
        this.CheckFtuxEventButton();
        this.SaveData();
    }
    private void MoveOrRemoveKey()
    {
        var val_5;
        WordRegion val_1 = WordRegion.instance;
        if(1 != 0)
        {
                return;
        }
        
        WordRegion val_2 = WordRegion.instance;
        if(0 <= (R4 + 24 + 24))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_5 = 0;
        val_5 = val_5 + ((R4 + 24 + 24) << 2);
        var val_3 = (R4 + 24 + 28) + 1;
        if(val_3 >= ((0 + (R4 + 24 + 24) << 2) + 16 + 20 + 12))
        {
            goto label_13;
        }
        
        if(((0 + (R4 + 24 + 24) << 2) + 16 + 20 + 12) <= val_3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_6 = (0 + (R4 + 24 + 24) << 2) + 16 + 20 + 8;
        val_6 = val_6 + (val_3 << 2);
        if((R4 + 36) != 0)
        {
            goto label_18;
        }
        
        return;
        label_13:
        R4 + 36.Remove();
        mem2[0] = 0;
        mem2[0] = 1;
        mem2[0] = 0;
        val_5 = mem[R4 + 24];
        val_5 = R4 + 24;
        mem2[0] = 0;
        goto label_23;
        label_18:
        val_5 = mem[R4 + 36];
        val_5 = R4 + 36;
        val_5.ShiftToCell(newParent:  ((0 + (R4 + 24 + 24) << 2) + 16 + 20 + 8 + ((R4 + 24 + 28 + 1)) << 2) + 16);
        mem2[0] = val_3;
        label_23:
        R4.SaveData();
    }
    private void RewardPlayer(KeyToRichesEventHandler.RewardType rewardType, decimal amount)
    {
        var val_5;
        int val_6;
        val_5 = 35636489;
        val_6 = amount.flags;
        if(rewardType > 5)
        {
                return;
        }
        
        var val_1 = 11533800 + (11533800 + (rewardType) << 2);
        if(rewardType == 5)
        {
                11533800 = 11533800 & (amount.hi << 11533800);
            11533800 = amount.hi * 11533800;
            11533800 = 11533800 & (((amount.hi) << (32-2)) | ((amount.hi) << 2));
            mem2[0] = ((amount.hi * (11533800 & (amount.hi) << 11533800)) & ((amount.hi) << (32-2)) | ((amount.hi) << 2)) + IP;
            (((amount.hi * (11533800 & (amount.hi) << 11533800)) & ((amount.hi) << (32-2)) | ((amount.hi) << 2)) + IP) & ((((amount.hi * (11533800 & (amount.hi) << 11533800)) & ((amount.hi) << (32-2)) | ((amount.hi) << 2)) + IP) << amount.flags) = ((((amount.hi * (11533800 & (amount.hi) << 11533800)) & ((amount.hi) << (32-2)) | ((amount.hi) << 2)) + IP) & ((((amount.hi * (11533800 & (amount.hi) << 11533800)) & ((amount.hi) << (32-2)) | ((amount.hi) << 2)) + IP) << amount.flags)) & 183814663;
        }
        
        Player val_2 = App.Player;
        0.AddCredits(amount:  new System.Decimal() {flags = val_6, hi = amount.hi, lo = amount.lo, mid = amount.mid}, source:  "Key to Riches Event Reward", subSource:  0, externalParams:  0, doTrack:  true);
    }
    private void RewardLetters(Alphabet2Manager.Rarity rarity, int count)
    {
        System.Collections.Generic.Dictionary<Rarity, System.Int32> val_10;
        var val_11;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<System.String> val_2 = RollLettersForRarity(rarity:  rarity, count:  count);
        this.lettersToReward.AddRange(collection:  -2100700048);
        if((this.lettersInfo.ContainsKey(key:  rarity)) != true)
        {
                this.lettersInfo.Add(key:  rarity, value:  0);
        }
        
        val_10 = this.lettersInfo;
        if(val_10 != 0)
        {
                val_11 = val_10.Item[rarity];
        }
        else
        {
                val_10 = 0;
            val_11 = 0.Item[rarity];
        }
        
        val_10.set_Item(key:  rarity, value:  val_11 + count);
        Player val_7 = App.Player;
        string val_8 = this.GetAlphabetTypeString(rarity:  rarity);
        string val_9 = count.ToString();
        0.TrackNonCoinReward(source:  -1353956816, subSource:  null, rewardType:  null, rewardAmount:  count, additionalParams:  0);
    }
    private void RewardAlphabets()
    {
        if(true == 0)
        {
                return;
        }
        
        GameBehavior val_1 = App.getBehavior;
        0.SetupUIForKeyToRiches(rewardedTiles:  this.lettersToReward);
    }
    private void ParseEventData(System.Collections.Generic.Dictionary<string, object> eventData)
    {
        var val_39;
        var val_40;
        float val_41;
        var val_42;
        int val_43;
        int val_44;
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
        var val_61;
        var val_62;
        var val_63;
        var val_64;
        if((eventData.ContainsKey(key:  -1554533760)) == false)
        {
            goto label_26;
        }
        
        object val_2 = eventData.Item[-1554533760];
        if((0.ContainsKey(key:  -1353552080)) != false)
        {
                string val_4 = 0.Item[-1353552080];
            val_39 = 0;
            val_40 = null;
            val_39.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem2[0] = 1179403647;
        }
        
        if((0.ContainsKey(key:  -1353551984)) != false)
        {
                string val_6 = 0.Item[-1353551984];
            val_40 = 0;
            if(0 != 0)
        {
                if(((mem[1179403747] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                0 = 0;
        }
        
            val_40 = 0;
        }
        
            TRVExpertRarites val_41 = 0;
            do
        {
            var val_7 = val_41 + 2;
            string val_8 = 1383185776 + 13152256;
            val_41 = val_41 + 1;
            if((val_40.ContainsKey(key:  1383185776)) != false)
        {
                string val_10 = 1383185776 + 13152256;
            string val_11 = val_40.Item[1383185776];
            val_39 = null;
            val_40.UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            mem[1152921511843254868] + 12.set_Item(key:  val_41, value:  1179403647);
        }
        
        }
        while(val_41 < 2);
        
        }
        
        val_41 = 1152921510392296080;
        if((0.ContainsKey(key:  -1353550880)) == false)
        {
            goto label_26;
        }
        
        string val_13 = 0.Item[-1353550880];
        val_42 = 0;
        if(0 != 0)
        {
                val_42 = 0;
            if(((mem[1179403747] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                0 = 0;
        }
        
            val_42 = 0;
        }
        
        var val_14 = 0 + 1;
        string val_15 = 1383185776 + 13152256;
        if((val_42.ContainsKey(key:  1383185776)) == false)
        {
            goto label_69;
        }
        
        string val_17 = 1383185776 + 13152256;
        string val_18 = val_42.Item[1383185776];
        val_45 = 0;
        val_46 = 1152921504683364352;
        if(val_42 != 0)
        {
                if(((mem[1179403747] + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                val_42 = 0;
        }
        
            val_45 = val_42;
        }
        
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_19 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        val_47 = val_45;
        if(val_47 == 0)
        {
                val_47 = val_45;
        }
        
        if((val_47.ContainsKey(key:  -1785508240)) == false)
        {
            goto label_74;
        }
        
        val_48 = val_47;
        if(val_47 == 0)
        {
                val_48 = val_45;
        }
        
        string val_21 = val_48.Item[-1785508240];
        float val_48 = 0f;
        var val_43 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_77;
        }
        
        var val_42 = 0;
        label_79:
        if((mem[1179403735] + 0) == null)
        {
            goto label_78;
        }
        
        val_42 = val_42 + 1;
        if(((uint)val_42 & 65535) < mem[1179403825])
        {
            goto label_79;
        }
        
        label_77:
        val_49 = val_48;
        goto label_80;
        label_74:
        val_50 = val_47;
        goto label_81;
        label_78:
        var val_22 = mem[1179403735] + 0;
        val_43 = val_43 + (((mem[1179403735] + 0) + 4) << 3);
        val_49 = val_43 + 188;
        label_80:
        label_97:
        var val_45 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_83;
        }
        
        var val_44 = 0;
        label_85:
        if((mem[1179403735] + 0) == null)
        {
            goto label_84;
        }
        
        val_44 = val_44 + 1;
        if(((uint)val_44 & 65535) < mem[1179403825])
        {
            goto label_85;
        }
        
        label_83:
        val_51 = val_48;
        goto label_86;
        label_84:
        var val_23 = mem[1179403735] + 0;
        val_45 = val_45 + (((mem[1179403735] + 0) + 4) << 3);
        val_51 = val_45 + 188;
        label_86:
        if(val_48 == 0)
        {
            goto label_87;
        }
        
        var val_47 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_89;
        }
        
        var val_46 = 0;
        label_91:
        if((mem[1179403735] + 0) == null)
        {
            goto label_90;
        }
        
        val_46 = val_46 + 1;
        if(((uint)val_46 & 65535) < mem[1179403825])
        {
            goto label_91;
        }
        
        label_89:
        val_52 = val_48;
        goto label_92;
        label_90:
        var val_24 = mem[1179403735] + 0;
        val_47 = val_47 + (((mem[1179403735] + 0) + 4) << 3);
        val_52 = val_47 + 196;
        label_92:
        val_53 = 0;
        object val_25 = new System.Object();
        typeof(KeyToRichesEventHandler.Reward).__il2cppRuntimeField_8 = 0;
        typeof(KeyToRichesEventHandler.Reward).__il2cppRuntimeField_C = ;
        Add(item:  319221760);
        goto label_97;
        label_87:
        val_48 = val_48 + 1;
        val_44 = 0;
        mem2[0] = 396;
        if(val_48 == 0)
        {
            goto label_98;
        }
        
        var val_50 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_99;
        }
        
        var val_49 = 0;
        label_101:
        if((mem[1179403735] + 0) == null)
        {
            goto label_100;
        }
        
        val_49 = val_49 + 1;
        if(((uint)val_49 & 65535) < mem[1179403825])
        {
            goto label_101;
        }
        
        label_99:
        val_54 = val_48;
        goto label_102;
        label_100:
        var val_26 = mem[1179403735] + 0;
        val_50 = val_50 + (((mem[1179403735] + 0) + 4) << 3);
        val_54 = val_50 + 188;
        label_102:
        label_98:
        if(val_48 != 1)
        {
                if(val_48 > 1)
        {
                0 = 1;
        }
        
            var val_51 = -1353538824 + ((0 + 1)) << 2;
            val_51 = val_51 - 396;
            val_51 = val_51 >> 5;
            val_51 = 1 & val_51;
            val_48 = val_48 - val_51;
        }
        
        val_41 = 1152921510392296080;
        val_46 = 1152921504683364352;
        val_50 = val_45;
        label_81:
        if(val_50 == 0)
        {
                val_50 = val_45;
        }
        
        if((val_50.ContainsKey(key:  -1968282976)) == false)
        {
            goto label_107;
        }
        
        val_55 = val_50;
        if(val_50 == 0)
        {
                val_55 = val_45;
        }
        
        string val_28 = val_55.Item[-1968282976];
        float val_58 = 0f;
        var val_53 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_110;
        }
        
        var val_52 = 0;
        label_112:
        if((mem[1179403735] + 0) == null)
        {
            goto label_111;
        }
        
        val_52 = val_52 + 1;
        if(((uint)val_52 & 65535) < mem[1179403825])
        {
            goto label_112;
        }
        
        label_110:
        val_56 = val_55;
        goto label_113;
        label_107:
        val_57 = val_50;
        goto label_114;
        label_111:
        var val_29 = mem[1179403735] + 0;
        val_53 = val_53 + (((mem[1179403735] + 0) + 4) << 3);
        val_56 = val_53 + 188;
        label_113:
        label_130:
        var val_55 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_116;
        }
        
        var val_54 = 0;
        label_118:
        if((mem[1179403735] + 0) == null)
        {
            goto label_117;
        }
        
        val_54 = val_54 + 1;
        if(((uint)val_54 & 65535) < mem[1179403825])
        {
            goto label_118;
        }
        
        label_116:
        val_58 = val_55;
        goto label_119;
        label_117:
        var val_30 = mem[1179403735] + 0;
        val_55 = val_55 + (((mem[1179403735] + 0) + 4) << 3);
        val_58 = val_55 + 188;
        label_119:
        if(val_55 == 0)
        {
            goto label_120;
        }
        
        var val_57 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_122;
        }
        
        var val_56 = 0;
        label_124:
        if((mem[1179403735] + 0) == null)
        {
            goto label_123;
        }
        
        val_56 = val_56 + 1;
        if(((uint)val_56 & 65535) < mem[1179403825])
        {
            goto label_124;
        }
        
        label_122:
        val_59 = val_55;
        goto label_125;
        label_123:
        var val_31 = mem[1179403735] + 0;
        val_57 = val_57 + (((mem[1179403735] + 0) + 4) << 3);
        val_59 = val_57 + 196;
        label_125:
        val_60 = 0;
        object val_32 = new System.Object();
        typeof(KeyToRichesEventHandler.Reward).__il2cppRuntimeField_8 = 1;
        typeof(KeyToRichesEventHandler.Reward).__il2cppRuntimeField_C = ;
        Add(item:  319221760);
        goto label_130;
        label_120:
        val_58 = val_58 + 1;
        val_43 = 0;
        mem2[0] = 497;
        if(val_55 == 0)
        {
            goto label_131;
        }
        
        var val_60 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_132;
        }
        
        var val_59 = 0;
        label_134:
        if((mem[1179403735] + 0) == null)
        {
            goto label_133;
        }
        
        val_59 = val_59 + 1;
        if(((uint)val_59 & 65535) < mem[1179403825])
        {
            goto label_134;
        }
        
        label_132:
        val_61 = val_55;
        goto label_135;
        label_133:
        var val_33 = mem[1179403735] + 0;
        val_60 = val_60 + (((mem[1179403735] + 0) + 4) << 3);
        val_61 = val_60 + 188;
        label_135:
        label_131:
        if(val_58 != 1)
        {
                if(val_58 > 1)
        {
                0 = 1;
        }
        
            var val_61 = -1353538824 + ((0 + 1)) << 2;
            val_61 = val_61 - 497;
            val_61 = val_61 >> 5;
            val_61 = 1 & val_61;
            val_58 = val_58 - val_61;
        }
        
        val_41 = 1152921510392296080;
        val_46 = 1152921504683364352;
        val_57 = val_45;
        label_114:
        if(val_57 == 0)
        {
                val_57 = val_45;
        }
        
        if((val_57.ContainsKey(key:  -1353550800)) == false)
        {
            goto label_145;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_35 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2100700048) == 0)
        {
            goto label_145;
        }
        
        val_62 = val_45;
        if(val_62 == 0)
        {
                val_62 = val_45;
        }
        
        string val_37 = val_62.Item[-1353550800];
        if((0.ContainsKey(key:  -1785508240)) == false)
        {
            goto label_150;
        }
        
        string val_39 = 0.Item[-1785508240];
        val_63 = 1179403647;
        if(mem[1179403825] == 0)
        {
            goto label_153;
        }
        
        var val_62 = 0;
        label_155:
        if((mem[1179403735] + 0) == null)
        {
            goto label_154;
        }
        
        val_62 = val_62 + 1;
        if(((uint)val_62 & 65535) < mem[1179403825])
        {
            goto label_155;
        }
        
        label_153:
        val_64 = 0;
        goto label_156;
        label_154:
        var val_40 = mem[1179403735] + 0;
        val_63 = val_63 + (((mem[1179403735] + 0) + 4) << 3);
        val_64 = val_63 + 188;
        label_156:
        if(mem[1179403825] == 0)
        {
            goto label_161;
        }
        
        var val_63 = 0;
        label_160:
        if((mem[1179403735] + 0) == null)
        {
            goto label_159;
        }
        
        val_63 = val_63 + 1;
        if(((uint)val_63 & 65535) < mem[1179403825])
        {
            goto label_160;
        }
        
        goto label_161;
    }
    private string GetAlphabetTypeString(Alphabet2Manager.Rarity rarity)
    {
        var val_1;
        if(rarity <= 3)
        {
                val_1 = mem[34443588 + (rarity) << 2];
            val_1 = 34443588 + (rarity) << 2;
            return;
        }
        
        val_1 = "";
    }
    public int get_HackLevelsCounter()
    {
        if(KeyToRichesEventHandler._Instance.eventProgress != 0)
        {
                return (int)KeyToRichesEventHandler.EventProgress.__il2cppRuntimeField_byval_arg;
        }
        
        return (int)KeyToRichesEventHandler.EventProgress.__il2cppRuntimeField_byval_arg;
    }
    public void set_HackLevelsCounter(int value)
    {
        typeof(KeyToRichesEventHandler.EventProgress).__il2cppRuntimeField_10 = value;
    }
    public string get_KeyWord()
    {
        var val_4;
        if(this.KeyShowing != false)
        {
                WordRegion val_2 = WordRegion.instance;
            if(0 <= this.eventProgress.keyWordIndex)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_3 = 0;
            val_3 = val_3 + (this.eventProgress.keyWordIndex << 2);
            val_4 = ((0 + (this.eventProgress.keyWordIndex) << 2) + 16) + 12;
            return;
        }
        
        val_4 = "";
    }
    public int get_HackKeyCount()
    {
        if(this.eventProgress != 0)
        {
                return (int)this.eventProgress.keyCount;
        }
        
        return (int)this.eventProgress.keyCount;
    }
    public void set_HackKeyCount(int value)
    {
        this.KeyCount = value;
        this.SaveData();
    }
    public bool get_HackShowKeyEveryLevel()
    {
        return (bool)this.<HackShowKeyEveryLevel>k__BackingField;
    }
    public void set_HackShowKeyEveryLevel(bool value)
    {
        this.<HackShowKeyEveryLevel>k__BackingField = value;
    }
    public void LevelsCounterMinus10()
    {
        EventProgress val_1;
        int val_2;
        val_1 = this.eventProgress;
        if(val_1 == 0)
        {
            goto label_0;
        }
        
        val_2 = this.eventProgress.levelsCounter;
        goto label_1;
        label_0:
        if(this.eventProgress == 0)
        {
            goto label_2;
        }
        
        val_2 = this.eventProgress.levelsCounter;
        val_1 = this.eventProgress;
        label_1:
        val_2 = val_2 - 10;
        val_2 = val_2 & (~(val_2 >> 31));
        this.eventProgress.levelsCounter = val_2;
        return;
        label_2:
    }
    public void LevelsCounterPlus10()
    {
        EventProgress val_1;
        int val_2;
        val_1 = this.eventProgress;
        if(val_1 != 0)
        {
                val_2 = this.eventProgress.levelsCounter;
        }
        else
        {
                val_1 = 16;
            val_2 = 2621443;
        }
        
        mem[16] = 2621453;
    }
    public void GrantKeyWord()
    {
        var val_7 = 1152921504886931456;
        WordRegion val_1 = WordRegion.instance;
        if(0 == 0)
        {
                return;
        }
        
        if(this.KeyShowing == false)
        {
                return;
        }
        
        WordRegion val_4 = WordRegion.instance;
        WordRegion val_5 = WordRegion.instance;
        if(0 <= this.eventProgress.keyWordIndex)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_6 = 0;
        val_6 = val_6 + (this.eventProgress.keyWordIndex << 2);
        if(0 == 0)
        {
            
        }
    
    }
    public bool get_ShowChestContent()
    {
        return (bool)this.showChestContent;
    }
    public void set_ShowChestContent(bool value)
    {
        this.showChestContent = value;
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Hashtable val_3 = new System.Collections.Hashtable();
        0.PostNotification(aSender:  -2101040096, aName:  -1352033200, aData:  75878400);
    }
    public KeyToRichesEventHandler()
    {
        this.econ = new KeyToRichesEventHandler.Econ();
        typeof(KeyToRichesEventHandler.EventProgress).__il2cppRuntimeField_18 = 0;
        typeof(KeyToRichesEventHandler.EventProgress).__il2cppRuntimeField_1C = 0;
        object val_2 = new System.Object();
        this.eventProgress = null;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.lettersToReward = null;
        System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32> val_4 = new System.Collections.Generic.Dictionary<WordForest.WFOWordChestType, System.Int32>();
        this.lettersInfo = null;
    }

}
