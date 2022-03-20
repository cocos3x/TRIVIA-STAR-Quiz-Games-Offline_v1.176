using UnityEngine;
public class FPHPhraseOfTheDayController : MonoSingleton<FPHPhraseOfTheDayController>
{
    // Fields
    private FPHQotdStatus <Status>k__BackingField;
    private const string LEVEL_PROGRESS_KEY = "qotdLvlProg";
    private int maxPOTDLevels;
    
    // Properties
    public FPHQotdStatus Status { get; set; }
    
    // Methods
    public FPHQotdStatus get_Status()
    {
    
    }
    public void set_Status(FPHQotdStatus value)
    {
        this.<Status>k__BackingField = value;
    }
    public override void InitMonoSingleton()
    {
        var val_5;
        this.InitMonoSingleton();
        this.<Status>k__BackingField = new EventProgression();
        WordPets.WPTDataParser val_2 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_3 = new System.Action<Result>(object:  -1615267456, method:  new IntPtr(2679674816));
        System.Delegate val_4 = System.Delegate.Combine(a:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, b:  7401472);
        val_5 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_5 != 0)
        {
                if(val_5 == null)
        {
            goto label_7;
        }
        
        }
        
        val_5 = 0;
        label_7:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_5;
    }
    public FPHQOTDPhrase GetReward()
    {
        var val_4;
        var val_5;
        if((this.<Status>k__BackingField.qotdProgress) <= 1)
        {
                WordForest.WFOGameEcon val_2 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
            val_4 = public static FPHEcon App::GetGameSepeciticEcon<FPHEcon>();
            val_5 = 1412;
            return;
        }
        
        WordForest.WFOGameEcon val_3 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        val_4 = public static FPHEcon App::GetGameSepeciticEcon<FPHEcon>();
        val_5 = 1416;
    }
    public void CheckQOTD()
    {
        this.CheckLPN();
    }
    public void Play()
    {
        System.DateTime val_3;
        ulong val_6;
        ulong val_8;
        var val_14;
        this.<Status>k__BackingField.IsPlaying = true;
        val_14 = null;
        val_14 = null;
        FPHGameplayController.currentGameplayMode = true;
        if((this.<Status>k__BackingField) != 0)
        {
                System.DateTime val_1 = Date;
            System.DateTime val_2 = DateTimeCheat.Now;
            System.DateTime val_5 = Date;
            if((System.DateTime.op_Inequality(d1:  new System.DateTime() {dateData = val_8}, d2:  new System.DateTime() {dateData = val_6})) != false)
        {
                System.DateTime val_11 = DateTimeCheat.Now;
            System.DateTime val_12 = Date;
            this.<Status>k__BackingField.LastPlayedTime = val_3;
            this.<Status>k__BackingField.qotdProgress = 0;
            this.<Status>k__BackingField.savedLevelData = System.String.alignConst;
        }
        
            if((this.<Status>k__BackingField) != 0)
        {
                GameBehavior val_13 = App.getBehavior;
            if(0 != 0)
        {
                return;
        }
        
            return;
        }
        
        }
    
    }
    public void OnSceneLoaded(SceneType scene)
    {
        if(scene != 1)
        {
                return;
        }
        
        this.<Status>k__BackingField.IsPlaying = false;
    }
    public void Complete()
    {
        this.<Status>k__BackingField.IsPlaying = false;
        this.<Status>k__BackingField.qotdProgress = this.maxPOTDLevels;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public void CompleteQuestion(bool correctAnswer)
    {
        FPHQotdStatus val_7;
        int val_8;
        var val_9;
        var val_10;
        val_7 = this.<Status>k__BackingField;
        if(correctAnswer == false)
        {
            goto label_1;
        }
        
        if(val_7 == 0)
        {
            goto label_2;
        }
        
        val_8 = this.<Status>k__BackingField.qotdProgress;
        goto label_3;
        label_1:
        this.<Status>k__BackingField.qotdProgress = this.maxPOTDLevels;
        GameBehavior val_1 = App.getBehavior;
        FPHGameplayController val_3 = FPHGameplayController.Instance;
        val_9 = 0;
        val_10 = "Incorrect Guess";
        goto label_13;
        label_2:
        val_7 = 32;
        val_8 = 35615780;
        label_3:
        mem[32] = 35615781;
        GameBehavior val_4 = App.getBehavior;
        FPHGameplayController val_6 = FPHGameplayController.Instance;
        val_9 = 1;
        val_10 = 0;
        label_13:
        0.TrackLevelComplete(isSuccess:  true, failReason:  null);
    }
    public void CollectReward()
    {
        int val_4;
        var val_8;
        string val_9;
        FPHQOTDPhrase val_1 = this.GetReward();
        if(this != 1)
        {
                if(this != 0)
        {
                return;
        }
        
            Player val_2 = App.Player;
            val_8 = 0;
            val_9 = 0;
            decimal val_3 = System.Decimal.op_Implicit(value:  -1614362384);
            val_8.AddCredits(amount:  new System.Decimal() {mid = val_4}, source:  "Daily Phrases", subSource:  val_9, externalParams:  val_9, doTrack:  true);
            return;
        }
        
        Player val_5 = App.Player;
        val_9 = this.<Status>k__BackingField;
        val_8 = 0;
        val_8.AddGems(amount:  val_9, source:  -1646909904, subsource:  null);
        Player val_6 = App.Player;
        string val_7 = this.<Status>k__BackingField.ToString();
        0.TrackNonCoinReward(source:  -1646909904, subSource:  null, rewardType:  -1668821072, rewardAmount:  this.<Status>k__BackingField, additionalParams:  0);
    }
    public bool IsPlaying()
    {
        if((this.<Status>k__BackingField) == 0)
        {
                this.<Status>k__BackingField = 0;
            return (bool)this.<Status>k__BackingField;
        }
        
        if(0 != 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public bool IsEligible()
    {
        ulong val_9;
        ulong val_11;
        var val_14;
        FPHQotdStatus val_15;
        val_14 = 0;
        if(this.IsFeatureEnabled() == false)
        {
                return true;
        }
        
        Player val_2 = App.Player;
        WordForest.WFOGameEcon val_3 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        val_14 = 0;
        val_15 = this.<Status>k__BackingField;
        if(val_15 == 0)
        {
                val_15 = this.<Status>k__BackingField;
        }
        
        System.DateTime val_4 = Date;
        System.DateTime val_5 = DateTimeCheat.Now;
        System.DateTime val_8 = Date;
        val_14 = 1;
        if((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_11}, t2:  new System.DateTime() {dateData = val_9})) == true)
        {
                return true;
        }
        
        if((this.<Status>k__BackingField.qotdProgress) < this.maxPOTDLevels)
        {
                val_14 = 1;
        }
        
        return true;
    }
    public bool IsFeatureEnabled()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        GameBehavior val_2 = App.getBehavior;
        string val_3 = 0.GetCurrentLanguage();
        return System.String.op_Equality(a:  null, b:  1800251696);
    }
    public void SetupLevel(ref FPHGameplayState newGame)
    {
        FPHGameplayState val_21;
        var val_23;
        var val_24;
        char val_25;
        FPHGameplayState val_26;
        if(((this.<Status>k__BackingField) != 0) && ((System.String.IsNullOrEmpty(value:  this.<Status>k__BackingField.savedLevelData)) != true))
        {
                if((FPHGameplayState.Deserialize(dataString:  this.<Status>k__BackingField.savedLevelData, stateToLoad: ref  FPHGameplayState val_2 = -1613792592)) != false)
        {
                val_21 = newGame;
            if(newGame == 0)
        {
                val_21 = newGame;
        }
        
            FPHLevelObject val_5 = newGame.<levelIndex>k__BackingField.GetNextFPHQOTDLevel(definedIndex: ref  int val_4 = -1613836636);
            <levelData>k__BackingField = newGame.<levelIndex>k__BackingField;
            <levelIndex>k__BackingField = newGame.<levelIndex>k__BackingField;
            return;
        }
        
            this.<Status>k__BackingField.savedLevelData = System.String.alignConst;
        }
        
        Player val_6 = App.Player;
        trackingLevel = 0;
        bool val_7 = System.String.IsNullOrEmpty(value:  this.<Status>k__BackingField.savedLevelData);
        FPHLevelObject val_9 = this.GetNextFPHQOTDLevel(definedIndex: ref  int val_8 = -1613836632);
        <levelData>k__BackingField = 0;
        <levelIndex>k__BackingField = 0;
        if((this.<Status>k__BackingField.qotdProgress) > 0)
        {
                WordForest.WFOGameEcon val_11 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
            if((public static FPHEcon App::GetGameSepeciticEcon<FPHEcon>()) != 0)
        {
            goto label_23;
        }
        
        }
        else
        {
                WordForest.WFOGameEcon val_12 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        }
        
        label_23:
        <tokensRemaining>k__BackingField = public System.Void System.Collections.Generic.List<FPHLetterSlotState>::.ctor().__il2cppRuntimeField_184 + 16;
        System.Collections.Generic.List<WordPets.WordPetType> val_13 = new System.Collections.Generic.List<WordPets.WordPetType>();
        phraseSlotState = null;
        val_23 = 0;
        goto label_30;
        label_54:
        if(newGame.Chars[0] == ' ')
        {
            goto label_31;
        }
        
        if((FPHKeyboard.IsLetter(value:  newGame.<levelData>k__BackingField.<phrase>k__BackingField.Chars[0])) == false)
        {
            goto label_39;
        }
        
        newGame.phraseSlotState.Add(item:  0);
        val_24 = public System.Void System.Collections.Generic.List<System.Char>::Add(System.Char item);
        val_25 = 32;
        goto label_42;
        label_39:
        newGame.phraseSlotState.Add(item:  1);
        val_26 = newGame;
        if(newGame != 0)
        {
            goto label_43;
        }
        
        val_26 = newGame;
        if(val_26 == 0)
        {
            goto label_44;
        }
        
        label_43:
        val_24 = public System.Void System.Collections.Generic.List<System.Char>::Add(System.Char item);
        val_25 = newGame.<levelData>k__BackingField.<phrase>k__BackingField.Chars[0];
        label_42:
        newGame.phraseSlotDisplayValue.Add(item:  val_25);
        label_31:
        val_23 = 1;
        label_30:
        val_21 = mem[newGame.<levelData>k__BackingField + 16];
        val_21 = newGame.<levelData>k__BackingField.<phrase>k__BackingField;
        if(val_23 < (newGame.<levelData>k__BackingField.<phrase>k__BackingField.m_stringLength))
        {
            goto label_54;
        }
        
        string val_18 = val_21.Replace(oldValue:  1297836560, newValue:  1098586544);
        phraseSlotCorrectValue = val_21;
        WordForest.WFOGameEcon val_19 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        FPHChestType val_20 = GetChestType();
        chestType = public static FPHEcon App::GetGameSepeciticEcon<FPHEcon>();
        return;
        label_44:
    }
    private FPHLevelObject GetNextFPHQOTDLevel(ref int definedIndex)
    {
        int val_16;
        var val_26;
        int val_28;
        System.Collections.Generic.List<System.Int32> val_29;
        int val_30;
        var val_31;
        System.Collections.Generic.List<System.Int32> val_33;
        var val_34;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.List<FPHLevelObject> val_2 = LoadQOTDLevelData();
        val_26 = public static FPHDataParser MonoSingleton<FPHDataParser>::get_Instance();
        if(definedIndex < 0)
        {
            goto label_6;
        }
        
        val_28 = definedIndex;
        goto label_7;
        label_6:
        val_29 = 1152921504687730688;
        System.Collections.Generic.List<System.Int32> val_3 = new System.Collections.Generic.List<System.Int32>();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        bool val_5 = CPlayerPrefs.HasKey(key:  -1613695792);
        string val_6 = CPlayerPrefs.GetString(key:  -1613695792, defaultValue:  -2141227328);
        object val_7 = MiniJSON.Json.Deserialize(json:  -1613695792);
        if(("qotdLvlProg" == 0) || (null != null))
        {
            goto label_47;
        }
        
        List.Enumerator<T> val_8 = GetEnumerator();
        label_18:
        if(MoveNext() == false)
        {
            goto label_13;
        }
        
        val_30 = 0;
        Add(item:  null);
        goto label_18;
        label_13:
        Dispose();
        val_31 = val_26;
        val_29 = 1152921504687730688;
        label_47:
        Clear();
        System.Collections.Generic.IEnumerable<System.Int32> val_12 = System.Linq.Enumerable.Range(start:  0, count:  (public static FPHDataParser MonoSingleton<FPHDataParser>::get_Instance().__il2cppRuntimeField_C - 1));
        val_33 = val_29;
        val_33 = new System.Collections.Generic.List<System.Int32>(collection:  0);
        List.Enumerator<T> val_14 = GetEnumerator();
        label_26:
        if(MoveNext() == false)
        {
            goto label_22;
        }
        
        if((Contains(item:  val_16)) == false)
        {
            goto label_26;
        }
        
        bool val_18 = Remove(item:  val_16);
        goto label_26;
        label_22:
        Dispose();
        val_34 = val_26;
        UnityEngine.Debug.LogError(message:  -1613694672);
        Clear();
        System.Collections.Generic.IEnumerable<System.Int32> val_20 = System.Linq.Enumerable.Range(start:  0, count:  (public static FPHDataParser MonoSingleton<FPHDataParser>::get_Instance().__il2cppRuntimeField_C - 1));
        val_33 = null;
        val_33 = new System.Collections.Generic.List<System.Int32>(collection:  0);
        if(val_33 != 0)
        {
                int val_22 = UnityEngine.Random.Range(min:  0, max:  1094062064);
        }
        
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_28 = mem[(System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_22) << 2) + 16];
        val_28 = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_22) << 2) + 16;
        val_28 = 0;
        UnityEngine.Debug.LogError(message:  -1613694496);
        val_28 = 0;
        goto label_40;
        label_7:
        label_40:
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
    }
    public void StartNextQOTDQuestion()
    {
        this.<Status>k__BackingField.savedLevelData = System.String.alignConst;
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public void UpdateSavedGame(FPHGameplayState state)
    {
        FPHQotdStatus val_3 = this.<Status>k__BackingField;
        if(state != 0)
        {
                string val_1 = state.Serialize();
            this.<Status>k__BackingField.savedLevelData = state;
            if((this.<Status>k__BackingField) != 0)
        {
            goto typeof(FPHQotdStatus).__il2cppRuntimeField_E4;
        }
        
        }
        else
        {
                mem2[0] = System.String.alignConst;
        }
    
    }
    private void CheckLPN()
    {
        twelvegigs.plugins.NotificationInterval val_4;
        ulong val_6;
        ulong val_8;
        FPHQotdStatus val_20;
        string val_21;
        FPHQotdStatus val_22;
        val_20 = this.<Status>k__BackingField;
        if(val_20 == 0)
        {
                val_20 = this.<Status>k__BackingField;
        }
        
        System.DateTime val_1 = Date;
        val_21 = 1152921504888102912;
        System.DateTime val_2 = DateTimeCheat.Now;
        System.DateTime val_5 = Date;
        if((System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_8}, t2:  new System.DateTime() {dateData = val_6})) == false)
        {
            goto label_7;
        }
        
        System.DateTime val_11 = DateTimeCheat.Now;
        if(val_8.Hour < 16)
        {
            goto label_10;
        }
        
        label_7:
        val_22 = this.<Status>k__BackingField;
        if(val_22 == 0)
        {
                val_22 = this.<Status>k__BackingField;
        }
        
        if((this.<Status>k__BackingField.LastPlayedTime.Hour) > (this.<Status>k__BackingField.LastPlayedTime))
        {
                return;
        }
        
        CompanyDevices val_14 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                UnityEngine.Debug.LogError(message:  -1613305168);
        }
        
        twelvegigs.plugins.LocalNotificationsPlugin.KillNotification(tipo:  26);
        return;
        label_10:
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_16 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1953384384, value:  -1613304976);
        val_21 = 0;
        System.DateTime val_17 = DateTimeCheat.Today;
        System.DateTime val_18 = AddHours(value:  null);
        twelvegigs.plugins.LocalNotificationsPlugin.PostNotification(tipo:  26, when:  new System.DateTime() {dateData = 1152921511583476688}, interval:  val_4, optTitle:  val_21, optMessage:  "Daily Phrases", extraData:  "Daily Phrases are now available!", priority:  null, useTimeModifier:  false);
        System.DateTime val_19 = System.DateTime.Today;
        this.<Status>k__BackingField.LastLPNSetupTime = val_6;
    }
    private void OnDisable()
    {
        var val_4;
        WordPets.WPTDataParser val_1 = MonoSingletonSelfGenerating<WordPets.WPTDataParser>.Instance;
        System.Action<Result> val_2 = new System.Action<Result>(object:  -1613135968, method:  new IntPtr(2679674816));
        System.Delegate val_3 = System.Delegate.Remove(source:  public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C, value:  7401472);
        val_4 = public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C;
        if(val_4 != 0)
        {
                if(val_4 == null)
        {
            goto label_6;
        }
        
        }
        
        val_4 = 0;
        label_6:
        public static SceneDictator MonoSingletonSelfGenerating<SceneDictator>::get_Instance().__il2cppRuntimeField_C = val_4;
    }
    public FPHPhraseOfTheDayController()
    {
        this.maxPOTDLevels = 2;
    }

}
