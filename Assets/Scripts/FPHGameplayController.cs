using UnityEngine;
public class FPHGameplayController : MonoBehaviour
{
    // Fields
    private static FPHGameplayController _Instance;
    public static FPHGameplayMode currentGameplayMode;
    public static bool QAHACK_HURRY;
    public static bool QAHACK_CORRECT;
    protected FPHGameplayState currentGame;
    public System.Action<bool> OnAnswerSubmitted;
    public System.Action<bool> OnSolveModeToggled;
    public System.Action OnOutOfTokens;
    private System.Action<char> tutorialActionOnCorrectLetterGuessed;
    private bool <IsSolveModeOn>k__BackingField;
    private int <CaretIndex>k__BackingField;
    
    // Properties
    public static FPHGameplayController Instance { get; }
    public FPHGameplayState getCurrentGame { get; }
    public bool IsSolveModeOn { get; set; }
    public int CaretIndex { get; set; }
    
    // Methods
    public static FPHGameplayController get_Instance()
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        if(FPHGameplayController._Instance != 0)
        {
                return;
        }
        
        object val_2 = UnityEngine.Object.FindObjectOfType<System.Object>();
        if((-1647705168) == 0)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        FPHGameplayController._Instance = public static FPHGameplayController UnityEngine.Object::FindObjectOfType<FPHGameplayController>();
    }
    public FPHGameplayState get_getCurrentGame()
    {
    
    }
    public bool get_IsSolveModeOn()
    {
        return (bool)this.<IsSolveModeOn>k__BackingField;
    }
    private void set_IsSolveModeOn(bool value)
    {
        this.<IsSolveModeOn>k__BackingField = value;
    }
    public int get_CaretIndex()
    {
        return (int)this.<CaretIndex>k__BackingField;
    }
    private void set_CaretIndex(int value)
    {
        this.<CaretIndex>k__BackingField = value;
    }
    protected virtual void Start()
    {
        FPHGameplayController val_6;
        var val_7;
        var val_8;
        val_6 = this;
        val_7 = null;
        val_7 = null;
        if(FPHGameplayController.currentGameplayMode == 1)
        {
                UnityEngine.GameObject val_1 = this.gameObject;
            object val_2 = this.GetComponent<System.Object>();
            if((UnityEngine.Object.op_Implicit(exists:  -1646998928)) != false)
        {
                UnityEngine.GameObject val_4 = this.gameObject;
            object val_5 = this.GetComponent<System.Object>();
            val_6 = val_6;
        }
        
            val_7 = null;
        }
        
        val_7 = null;
        FPHGameplayController._Instance = val_6;
        val_8 = null;
        val_8 = null;
        if(FPHGameplayController._Instance == 0)
        {
            
        }
    
    }
    public virtual void Init()
    {
        var val_8;
        this.currentGame = new FPHGameplayState();
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SetupLevel(state: ref  FPHGameplayState val_3 = -1646885604);
        SetupEvents(currentGame: ref  FPHGameplayState val_4 = -1646885604);
        this.SetupTutorial();
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        StartGameplay(newState:  303194112);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_6 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1646909904, value:  8945664);
        Add(key:  -1646909808, value:  FPHGameplayState.__il2cppRuntimeField_8);
        if(Count >= 1)
        {
                Add(key:  -1646909712, value:  303206400);
        }
        
        var val_8 = 22400606;
        val_8 = 13224932 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        val_8 = null;
        val_8 = null;
        App.trackerManager.track(eventName:  -2100698896, data:  78753792);
    }
    private void SetupEvents(ref FPHGameplayState currentGame)
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        associatedEvents = null;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2101040096) == 0)
        {
                return;
        }
        
        if(WordGameEventsController.EventsEnabled == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(GetCurrentEventsCount < 1)
        {
                return;
        }
        
        WordGameEventsController.InjectEventsTrackingData(data:  currentGame.associatedEvents, onlyTrackEnabledEvents:  false);
    }
    public void OnLetterPressed(char letter)
    {
        var val_29;
        var val_30;
        System.Predicate<FPHLetterSlotState> val_32;
        FPHGameplayState val_34;
        var val_35;
        System.Predicate<FPHLetterSlotState> val_37;
        int val_38;
        FPHGameplayState val_41;
        var val_43;
        var val_44;
        var val_45;
        char val_46;
        var val_47;
        FPHGameplayState val_48;
        var val_49;
        FPHGameplayState val_50;
        if((this.<IsSolveModeOn>k__BackingField) == false)
        {
            goto label_1;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -1646677584, clipIndex:  0);
        if((FPHKeyboard.IsLetter(value:  letter)) == false)
        {
            goto label_8;
        }
        
        if((this.currentGame.phraseSlotState.Contains(item:  0)) == false)
        {
            goto label_115;
        }
        
        this.currentGame.phraseSlotDisplayValue.set_Item(index:  this.<CaretIndex>k__BackingField, value:  letter);
        this.currentGame.phraseSlotState.set_Item(index:  this.<CaretIndex>k__BackingField, value:  2);
        val_29 = 1152921504909934592;
        val_30 = null;
        val_30 = null;
        val_32 = FPHGameplayController.<>c.<>9__24_0;
        if(val_32 == 0)
        {
                val_32 = null;
            val_32 = new System.Predicate<System.Int32Enum>(object:  FPHGameplayController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2648325664));
            FPHGameplayController.<>c.<>9__24_0 = val_32;
        }
        
        this.<CaretIndex>k__BackingField = this.currentGame.phraseSlotState.FindIndex(match:  8040448);
        goto label_115;
        label_1:
        val_29 = 1152921504910573568;
        if((FPHKeyboard.IsLetter(value:  letter)) == false)
        {
            goto label_26;
        }
        
        WordForest.WFOGameEcon val_7 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((public System.Void System.Collections.Generic.List<FPHLetterSlotState>::.ctor().__il2cppRuntimeField_17C.Contains(item:  letter)) == true)
        {
                1360 = 1364;
        }
        
        val_34 = this.currentGame;
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -1646633440, clipIndex:  0);
        return;
        label_8:
        if(letter == '')
        {
            goto label_38;
        }
        
        if((letter != '') || ((this.currentGame.phraseSlotState.Contains(item:  2)) == false))
        {
            goto label_115;
        }
        
        val_29 = 1152921504909934592;
        val_35 = null;
        val_35 = null;
        val_37 = FPHGameplayController.<>c.<>9__24_1;
        if(val_37 == 0)
        {
                val_37 = null;
            val_37 = new System.Predicate<System.Int32Enum>(object:  FPHGameplayController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2648350352));
            FPHGameplayController.<>c.<>9__24_1 = val_37;
        }
        
        int val_12 = this.currentGame.phraseSlotState.FindLastIndex(match:  8040448);
        val_38 = val_12;
        this.<CaretIndex>k__BackingField = val_12;
        if(this.currentGame == 0)
        {
                val_38 = this.<CaretIndex>k__BackingField;
        }
        
        this.currentGame.phraseSlotDisplayValue.set_Item(index:  val_38, value:  ' ');
        this.currentGame.phraseSlotState.set_Item(index:  this.<CaretIndex>k__BackingField, value:  0);
        goto label_115;
        label_26:
        if(letter != '')
        {
            goto label_115;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -1646677584, clipIndex:  0);
        goto label_60;
        label_38:
        this.SolveModeExit(removePlayerEntries:  true);
        label_60:
        twelvegigs.Autopilot.AutopilotManager val_14 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        AbortLevel();
        label_115:
        twelvegigs.Autopilot.AutopilotManager val_15 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_34 = this.currentGame;
        UpdateGameplayState(updatedState:  val_34);
        return;
        label_97:
        val_41 = this.currentGame;
        if((this.currentGame.phraseSlotCorrectValue.Chars[0].Equals(obj:  letter)) == false)
        {
            goto label_82;
        }
        
        this.currentGame.phraseSlotState.set_Item(index:  0, value:  1);
        val_45 = ;
        val_46 = letter;
        val_47 = public System.Void System.Collections.Generic.List<System.Char>::set_Item(int index, System.Char value);
        goto label_86;
        label_82:
        string val_21 = val_41.phraseSlotCorrectValueNormalized;
        if((val_41.Chars[0].Equals(obj:  letter)) == false)
        {
            goto label_88;
        }
        
        this.currentGame.phraseSlotState.set_Item(index:  0, value:  1);
        val_41 = this.currentGame;
        val_48 = val_41;
        if(val_41 != 0)
        {
            goto label_91;
        }
        
        val_48 = this.currentGame;
        if(val_48 == 0)
        {
            goto label_111;
        }
        
        label_91:
        val_41 = this.currentGame.phraseSlotDisplayValue;
        val_45 = ;
        val_46 = this.currentGame.phraseSlotCorrectValue.Chars[0];
        val_47 = public System.Void System.Collections.Generic.List<System.Char>::set_Item(int index, System.Char value);
        label_86:
        val_41.set_Item(index:  0, value:  val_46);
        val_44 = 1;
        label_88:
        val_43 = 1;
        if(val_43 < val_41)
        {
            goto label_97;
        }
        
        if((val_44 & 1) != 0)
        {
            goto label_98;
        }
        
        val_49 = public static FPHEcon App::GetGameSepeciticEcon<FPHEcon>();
        twelvegigs.Autopilot.AutopilotManager val_26 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -1646677584, clipIndex:  0);
        if(this.tutorialActionOnCorrectLetterGuessed != 0)
        {
                this.tutorialActionOnCorrectLetterGuessed.Invoke(obj:  letter);
        }
        
        if(this != 0)
        {
            goto label_115;
        }
        
        goto label_105;
        label_98:
        val_49 = public static FPHEcon App::GetGameSepeciticEcon<FPHEcon>();
        twelvegigs.Autopilot.AutopilotManager val_27 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WGAudioController MonoSingleton<WGAudioController>::get_Instance().__il2cppRuntimeField_C.PlayGameSpecificSound(id:  -1646633440, clipIndex:  0);
        label_105:
        val_50 = this.currentGame;
        if(this.currentGame != 0)
        {
            goto label_110;
        }
        
        val_50 = this.currentGame;
        if(val_50 == 0)
        {
            goto label_111;
        }
        
        label_110:
        int val_28 = 21 - this.currentGame.consonantsPurchased;
        if(this.OnOutOfTokens == 0)
        {
            goto label_115;
        }
        
        this.OnOutOfTokens.Invoke();
        goto label_115;
        label_111:
    }
    public virtual bool CheckAnswer(bool triggerCallbackOnlyOnCorrect = False)
    {
        var val_5;
        int val_6;
        val_5 = triggerCallbackOnlyOnCorrect;
        string val_1 = this.currentGame.GetCurrentDisplayString();
        bool val_2 = System.String.op_Equality(a:  this.currentGame, b:  this.currentGame.phraseSlotCorrectValue);
        this.SolveModeExit(removePlayerEntries:  false);
        if(val_2 == false)
        {
            goto label_2;
        }
        
        if(this.currentGame == 0)
        {
            goto label_3;
        }
        
        val_6 = this.currentGame.<tokensRemaining>k__BackingField;
        goto label_4;
        label_2:
        bool val_3 = val_5 ^ 1;
        val_3 = val_2 | val_3;
        if(val_3 == true)
        {
            goto label_5;
        }
        
        return val_2;
        label_3:
        val_6 = 35615780;
        label_4:
        this.currentGame.starsEarned = 35615780;
        Player val_4 = App.Player;
        val_5 = 0;
        var val_5 = val_5 + 1;
        label_5:
        if(this.OnAnswerSubmitted == 0)
        {
                return val_2;
        }
        
        this.OnAnswerSubmitted.Invoke(obj:  val_2);
        return val_2;
    }
    public void SolveModeEnter(bool resetAnyUnconfirmedSlots = False)
    {
        var val_3;
        System.Predicate<FPHLetterSlotState> val_5;
        if((this.<IsSolveModeOn>k__BackingField) != false)
        {
                return;
        }
        
        this.<IsSolveModeOn>k__BackingField = true;
        if(resetAnyUnconfirmedSlots == true)
        {
                true = this;
            this.ResetAnyUnconfirmedLetters();
        }
        
        val_3 = null;
        val_3 = null;
        val_5 = FPHGameplayController.<>c.<>9__26_0;
        if(val_5 == 0)
        {
                val_5 = null;
            val_5 = new System.Predicate<System.Int32Enum>(object:  FPHGameplayController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2648901008));
            FPHGameplayController.<>c.<>9__26_0 = val_5;
        }
        
        this.<CaretIndex>k__BackingField = this.currentGame.phraseSlotState.FindIndex(match:  8040448);
        if(this.OnSolveModeToggled == 0)
        {
                return;
        }
        
        this.OnSolveModeToggled.Invoke(obj:  this.<IsSolveModeOn>k__BackingField);
    }
    public void SolveModeExit(bool removePlayerEntries)
    {
        if((this.<IsSolveModeOn>k__BackingField) == false)
        {
                return;
        }
        
        this.<CaretIndex>k__BackingField = 0;
        this.<IsSolveModeOn>k__BackingField = false;
        if(removePlayerEntries == true)
        {
                false = this;
            this.ResetAnyUnconfirmedLetters();
        }
        
        if(this.OnSolveModeToggled == 0)
        {
                return;
        }
        
        this.OnSolveModeToggled.Invoke(obj:  this.<IsSolveModeOn>k__BackingField);
    }
    public void ResetAnyUnconfirmedLetters()
    {
        var val_2 = 0;
        goto label_1;
        label_12:
        if((R6 + 76 + 12) <= val_2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_2 = R6 + 76 + 8;
        val_2 = val_2 + 0;
        if(((R6 + 76 + 8 + 0) + 16) != 1)
        {
                this.currentGame.phraseSlotState.set_Item(index:  0, value:  0);
            this.currentGame.phraseSlotDisplayValue.set_Item(index:  0, value:  ' ');
        }
        
        val_2 = 1;
        label_1:
        if(val_2 < this.currentGame.phraseSlotDisplayValue)
        {
            goto label_12;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UpdateGameplayState(updatedState:  this.currentGame);
    }
    public virtual void RevealAnswer()
    {
        var val_4;
        FPHGameplayState val_5;
        val_4 = 0;
        goto label_1;
        label_10:
        val_5 = this.currentGame;
        if(this.currentGame != 0)
        {
            goto label_2;
        }
        
        val_5 = this.currentGame;
        if(val_5 == 0)
        {
            goto label_3;
        }
        
        label_2:
        this.currentGame.phraseSlotDisplayValue.set_Item(index:  0, value:  this.currentGame.phraseSlotCorrectValue.Chars[0]);
        this.currentGame.phraseSlotState.set_Item(index:  0, value:  1);
        val_4 = 1;
        label_1:
        if(val_4 < this.currentGame.phraseSlotState)
        {
            goto label_10;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UpdateGameplayState(updatedState:  this.currentGame);
        this.currentGame.hasCollectedChest = true;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ShowLevelFail(failReason:  -1645598192);
        return;
        label_3:
    }
    public virtual bool DoPowerupRemove()
    {
        char val_7;
        float val_17;
        var val_18;
        float val_19;
        int val_20;
        FPHGameplayState val_21;
        System.Collections.Generic.List<System.Char> val_1 = new System.Collections.Generic.List<System.Char>();
        val_17 = 1152921504910573568;
        val_18 = null;
        val_18 = null;
        List.Enumerator<T> val_2 = GetEnumerator();
        val_19 = 1152921511551337472;
        label_24:
        if(MoveNext() == false)
        {
            goto label_4;
        }
        
        List.Enumerator<T> val_5 = GetEnumerator();
        label_21:
        if(MoveNext() == false)
        {
            goto label_6;
        }
        
        if((FPHKeyboard.IsLetter(value:  val_7)) == false)
        {
            goto label_21;
        }
        
        string val_9 = val_7.ToString();
        if((((this.currentGame.<levelData>k__BackingField.<phrase>k__BackingField.Contains(value:  -1645377898)) == true) || ((this.currentGame.lettersPurchased.Contains(item:  val_7)) == true)) || ((this.currentGame.lettersPowerupRemoved.Contains(item:  val_7)) == true))
        {
            goto label_21;
        }
        
        Add(item:  val_7);
        goto label_21;
        label_6:
        var val_13 = 0 + 1;
        mem2[0] = 158;
        Dispose();
        if(val_13 == 1)
        {
            goto label_24;
        }
        
        if((-1645377944 + ((0 + 1)) << 2) == 158)
        {
                -1645377944 + ((0 + 1)) << 2 = val_13 >> 31;
            -1645377944 + ((0 + 1)) << 2 = ~(val_13 >> 31);
            val_13 = val_13 + (-1645377944 + ((0 + 1)) << 2);
        }
        
        goto label_24;
        label_4:
        Dispose();
        val_20 = val_1;
        WordForest.WFOGameEcon val_14 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        int val_15 = UnityEngine.Mathf.Min(a:  public System.Void System.Collections.Generic.List<FPHLetterSlotState>::.ctor().__il2cppRuntimeField_178, b:  1094062064);
        if(val_15 >= 1)
        {
                var val_18 = val_15;
            val_19 = 1152921510000829152;
            do
        {
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_17 = mem[(System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_16) << 1) + 16];
            val_17 = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_16) << 1) + 16;
            this.currentGame.lettersPowerupRemoved.Add(item:  val_17);
            val_20 = val_1;
            RemoveAt(index:  UnityEngine.Random.Range(min:  0, max:  1094062064));
            val_18 = val_18 - 1;
        }
        while(this.currentGame.lettersPowerupRemoved != 0);
        
            if(val_15 >= 1)
        {
                val_21 = this.currentGame;
            if(val_21 != 0)
        {
                val_20 = this.currentGame.<removesUsed>k__BackingField;
        }
        else
        {
                val_21 = 16;
            val_20 = 2621443;
        }
        
            mem[16] = 2621444;
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_17 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UpdateGameplayState(updatedState:  this.currentGame);
        if(val_15 > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public System.Collections.Generic.List<int> DoPowerupHint()
    {
        var val_24;
        System.Collections.Generic.List<FPHLetterSlotState> val_25;
        FPHGameplayState val_26;
        FPHGameplayState val_27;
        char val_28;
        System.Collections.Generic.List<System.Char> val_29;
        System.Collections.Generic.List<System.Int32> val_30;
        FPHGameplayState val_31;
        FPHGameplayState val_32;
        int val_33;
        var val_34;
        var val_35;
        var val_36;
        val_24 = 4;
        goto label_1;
        label_15:
        if((new System.Collections.Generic.List<System.Char>()) <= R6)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(2621443 == 0)
        {
            goto label_5;
        }
        
        if(2621443 <= R6)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(2621443 != 2)
        {
            goto label_9;
        }
        
        label_5:
        Add(item:  this.currentGame.phraseSlotCorrectValue.Chars[R6]);
        label_9:
        val_24 = 5;
        label_1:
        val_25 = this.currentGame.phraseSlotState;
        val_26 = val_24 - 4;
        if(val_26 < null)
        {
            goto label_15;
        }
        
        int val_3 = UnityEngine.Random.Range(min:  0, max:  1094062064);
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_27 = this.currentGame;
        val_28 = mem[(System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_3) << 1) + 16];
        val_28 = (System.Collections.Generic.List<T>.__il2cppRuntimeField_name + (val_3) << 1) + 16;
        if(val_27 != 0)
        {
                val_29 = this.currentGame.lettersPurchased;
        }
        else
        {
                val_29 = this.currentGame.lettersPurchased;
            val_27 = this.currentGame;
            if(val_27 == 0)
        {
                val_27 = 0;
        }
        
        }
        
        string val_4 = val_27.phraseSlotCorrectValueNormalized;
        val_25 = 0;
        val_29.Add(item:  val_27.Chars[this.currentGame.phraseSlotCorrectValue.IndexOf(value:  val_28)]);
        val_30 = null;
        val_30 = new System.Collections.Generic.List<System.Int32>();
        goto label_27;
        label_50:
        if((this.currentGame.phraseSlotCorrectValue.Chars[0].Equals(obj:  val_28)) == true)
        {
            goto label_37;
        }
        
        string val_11 = this.currentGame.phraseSlotCorrectValueNormalized;
        if((this.currentGame.phraseSlotCorrectValue.Chars[0].Equals(obj:  this.currentGame.Chars[this.currentGame.phraseSlotCorrectValue.IndexOf(value:  val_28)])) == true)
        {
            goto label_37;
        }
        
        string val_15 = this.currentGame.phraseSlotCorrectValueNormalized;
        if((this.currentGame.Chars[0].Equals(obj:  val_28)) == false)
        {
            goto label_40;
        }
        
        label_37:
        this.currentGame.phraseSlotState.set_Item(index:  0, value:  1);
        val_31 = this.currentGame;
        if(this.currentGame != 0)
        {
            goto label_43;
        }
        
        val_31 = this.currentGame;
        if(val_31 == 0)
        {
            goto label_44;
        }
        
        label_43:
        this.currentGame.phraseSlotDisplayValue.set_Item(index:  0, value:  this.currentGame.phraseSlotCorrectValue.Chars[0]);
        Add(item:  0);
        label_40:
        val_25 = 1;
        label_27:
        if(val_25 < val_30)
        {
            goto label_50;
        }
        
        val_28 = 1152921504892043264;
        WordForest.WFOGameEcon val_19 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        GameBehavior val_20 = App.getBehavior;
        if(0 > (public System.Void System.Collections.Generic.List<FPHLetterSlotState>::.ctor().__il2cppRuntimeField_160))
        {
                0 = 1;
        }
        
        Prefs.UsedHint(free:  true);
        val_32 = this.currentGame;
        if(val_32 != 0)
        {
                val_33 = this.currentGame.<hintsUsed>k__BackingField;
        }
        else
        {
                val_32 = 28;
            val_33 = 52;
        }
        
        var val_25 = 22388634;
        mem[28] = val_33 + 1;
        val_25 = 13236904 + val_25;
        if(val_25 == 0)
        {
                mem2[0] = 1;
        }
        
        val_34 = null;
        val_34 = null;
        val_35 = null;
        val_35 = null;
        App.trackerManager.track(eventName:  Events.HINT_USED);
        if(val_25 == 0)
        {
                mem2[0] = 1;
        }
        
        val_36 = null;
        val_36 = null;
        val_25 = Events.HINT_USED;
        Player val_22 = App.Player;
        string val_23 = System.String.Format(format:  -1645101696, arg0:  val_25, arg1:  13152256);
        App.trackerManager.track(eventName:  -1645101696);
        twelvegigs.Autopilot.AutopilotManager val_24 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_26 = this.currentGame;
        UpdateGameplayState(updatedState:  val_26);
        return;
        label_44:
    }
    public virtual void SpendGems(int gems, string source)
    {
        Player val_1 = App.Player;
        0.AddGems(amount:  0 - gems, source:  source, subsource:  null);
    }
    public virtual void ProcessLevelComplete(bool success)
    {
        var val_8;
        var val_9;
        var val_10;
        val_8 = 35639247;
        val_9 = null;
        if(success != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnLevelComplete(levelsProgressed:  1);
            GameBehavior val_2 = App.getBehavior;
            val_9 = 0;
            val_10 = 0;
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnLevelComplete(levelsProgressed:  0);
            twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            OnIncorrectAnswerSubmitted();
        }
    
    }
    public void RewardMultiPicked(int multiplier)
    {
        int val_4;
        FPHGameplayState val_6;
        var val_7;
        val_6 = this.currentGame;
        this.currentGame.rewardMultiplier = multiplier;
        if(this.currentGame.hasCollectedChest != true)
        {
                val_6 = this.currentGame.GetTotalCoinReward();
            if(val_6 >= 1)
        {
                Player val_2 = App.Player;
            val_7 = 0;
            decimal val_3 = System.Decimal.op_Implicit(value:  -1644580496);
            val_6 = "Level Complete";
            val_7.AddCredits(amount:  new System.Decimal() {mid = val_4}, source:  val_6, subSource:  0, externalParams:  0, doTrack:  true);
        }
        
            if(R8 >= 1)
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_6 = public static GoldenApplesManager MonoSingleton<GoldenApplesManager>::get_Instance();
        }
        
        }
        
        this.currentGame.hasCollectedChest = true;
    }
    public virtual bool IsTutorialLevel()
    {
        if(this != 0)
        {
                return true;
        }
    
    }
    public virtual bool IsKeyboardTutorial()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                return false;
        }
        
        return false;
    }
    public virtual bool IsTokenFeatureTutorial()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 != 0)
        {
                return false;
        }
        
        return false;
    }
    public virtual void UpdateGameSave(FPHGameplayState updatedData)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UpdateSavedLevel(state:  updatedData);
    }
    private void SetupTutorial()
    {
        var val_3;
        System.Action<System.Char> val_5;
        if(this == 0)
        {
                return;
        }
        
        if(this == 0)
        {
            goto label_2;
        }
        
        val_3 = null;
        val_3 = null;
        val_5 = FPHGameplayController.<>c.<>9__39_0;
        if(val_5 != 0)
        {
            goto label_8;
        }
        
        val_5 = null;
        val_5 = new System.Action<System.Char>(object:  FPHGameplayController.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(2650963520));
        FPHGameplayController.<>c.<>9__39_0 = val_5;
        goto label_8;
        label_2:
        this.SetupKeyboardTutorial(letter:  ' ');
        val_5 = null;
        val_5 = new System.Action<System.Char>(object:  -1643976704, method:  new IntPtr(2650965568));
        label_8:
        this.tutorialActionOnCorrectLetterGuessed = val_5;
    }
    private void SetupKeyboardTutorial(char letter)
    {
        FPHGameplayState val_4;
        if(letter != ' ')
        {
                val_4 = this.currentGame;
            if(this.currentGame.currentTutorialLetter != letter)
        {
                return;
        }
        
        }
        
        string val_1 = this.currentGame.phraseSlotCorrectValueNormalized;
        val_4 = this.currentGame;
        System.Collections.Generic.IEnumerable<TSource> val_2 = System.Linq.Enumerable.Except<System.Char>(first:  this.currentGame, second:  this.currentGame.lettersPurchased);
        System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<System.Char>(source:  this.currentGame);
        if((this.currentGame.<levelIndex>k__BackingField) == 0)
        {
                return;
        }
        
        PluginExtension.Shuffle<System.Char>(list:  this.currentGame, seed:  new System.Nullable<System.Int32>() {HasValue = false});
        if((this.currentGame.<levelIndex>k__BackingField) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        this.currentGame.currentTutorialLetter = this.currentGame.<levelData>k__BackingField.<phrase>k__BackingField;
    }
    public void TrackLevelComplete(bool isSuccess, string failReason)
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_10 = this;
        if(isSuccess != true)
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((public static FPHDataParser MonoSingleton<FPHDataParser>::get_Instance()) != 0)
        {
                val_11 = InitialLevelOffset;
        }
        else
        {
                int val_3 = InitialLevelOffset;
            val_11 = val_3;
        }
        
            val_3.InitialLevelOffset = val_11 + 1;
        }
        
        float val_10 = 3.922717E-38f;
        val_10 = 13240208 + val_10;
        if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
        val_12 = null;
        val_12 = null;
        App.trackerManager.track(eventName:  -1942299264, data:  -1643688192);
        GameBehavior val_5 = App.getBehavior;
        if(0 >= 10)
        {
                GameBehavior val_6 = App.getBehavior;
            if((-4294967290) != 0)
        {
                return;
        }
        
        }
        
        if(val_10 == 0)
        {
                mem2[0] = 1;
        }
        
        val_13 = null;
        val_13 = null;
        val_14 = null;
        val_14 = null;
        GameBehavior val_7 = App.getBehavior;
        val_10 = 0;
        string val_8 = val_10.ToString();
        string val_9 = Events.LEVEL_REACHED + 2144339952 + -1643700232(-1643700232);
        App.trackerManager.track(eventName:  Events.LEVEL_REACHED);
    }
    public virtual System.Collections.Generic.Dictionary<string, object> GatherLevelCompleteTrackingData(bool isSuccess, string failReason)
    {
        var val_7;
        var val_8;
        string val_9;
        var val_10;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        val_7 = null;
        if(null == 0)
        {
                val_7 = null;
        }
        
        Add(key:  -1643587904, value:  13152256);
        Add(key:  -1643583696, value:  13152256);
        Add(key:  -1643579488, value:  13152256);
        Add(key:  -1643575280, value:  13152256);
        Add(key:  -2100067936, value:  13152256);
        Add(key:  -1643566976, value:  13152256);
        Add(key:  -1643554576, value:  this.currentGame.<levelData>k__BackingField.<id>k__BackingField);
        if(isSuccess != false)
        {
                val_8 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
            val_9 = null;
            val_10 = "Level Success";
        }
        else
        {
                val_8 = public System.Void System.Collections.Generic.Dictionary<System.String, System.Object>::Add(System.String key, System.Object value);
            val_10 = "Level Failed";
            val_9 = failReason;
        }
        
        Add(key:  -1643554384, value:  val_9);
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2101040096) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            AppendLevelCompleteData(curData: ref  System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = -1643517752);
        }
        
        if(this.currentGame.associatedEvents == 0)
        {
                return;
        }
        
        if(this.currentGame.associatedEvents.Count < 1)
        {
                return;
        }
        
        Add(key:  -1646909712, value:  this.currentGame.associatedEvents);
    }
    private void OnDisable()
    {
        null = null;
        FPHGameplayController._Instance = 0;
    }
    public void Hack_CompleteLevel()
    {
        var val_3;
        FPHGameplayState val_4;
        val_3 = 0;
        goto label_1;
        label_10:
        this.currentGame.phraseSlotState.set_Item(index:  0, value:  1);
        val_4 = this.currentGame;
        if(this.currentGame != 0)
        {
            goto label_4;
        }
        
        val_4 = this.currentGame;
        if(val_4 == 0)
        {
            goto label_5;
        }
        
        label_4:
        this.currentGame.phraseSlotDisplayValue.set_Item(index:  0, value:  this.currentGame.phraseSlotCorrectValue.Chars[0]);
        val_3 = 1;
        label_1:
        if(val_3 < this.currentGame.phraseSlotDisplayValue)
        {
            goto label_10;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UpdateGameplayState(updatedState:  this.currentGame);
        return;
        label_5:
    }
    public void Hack_CompleteChapter()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        Player val_2 = App.Player;
        Player val_3 = App.Player;
        this.Hack_CompleteLevel();
    }
    public FPHGameplayController()
    {
    
    }
    private static FPHGameplayController()
    {
    
    }

}
