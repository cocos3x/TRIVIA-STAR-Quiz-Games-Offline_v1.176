using UnityEngine;
public class TRVQuizProgress
{
    // Fields
    public string quizCategory;
    public int quizLength;
    public TRVGameplayState currentGameplayState;
    public QuestionData currentQuestionData;
    public System.Collections.Generic.List<TRVQuestionHistory> previousQuestions;
    public int correctAnswerRequirement;
    public int quizProgressIndex;
    private TRVSubCategoryData <myData>k__BackingField;
    public bool quizCompleted;
    public int quizLevel;
    public bool removeTwoHintUsed;
    public bool rerollQuestionUsed;
    public ChestType myChest;
    public bool hasCollectedChest;
    public bool hasRerolledChest;
    public int starMultiplierIndex;
    public int finalStarReward;
    public int finalCoinReward;
    public int selectedMulitplier;
    public TRVCategoryRankProgress categoryRankProgress;
    public string associatedEventID;
    public bool justCompletedDifficulty;
    private int[] <myArrayIndex>k__BackingField;
    private System.Collections.Generic.Dictionary<string, object> injectedTrackingInfo;
    
    // Properties
    public TRVSubCategoryData myData { get; set; }
    public virtual bool quizLevelsPlayer { get; }
    public int[] myArrayIndex { get; set; }
    public int correctAnswers { get; }
    public int countedAnswers { get; }
    public System.Collections.Generic.List<TRVQuestionHistory> countedAnswerData { get; }
    public int incorrecctAnswers { get; }
    public int totalPointsGained { get; }
    public int hintsUsedThisQuiz { get; }
    public bool freeHintWasUsedThisQuiz { get; }
    public int rerollsUsedThisQuiz { get; }
    public bool freeRerollWasUsedThisQuiz { get; }
    public int extraLivesUsedThisQuiz { get; }
    public int expertHintWasUsed { get; }
    public bool freeexpertHintWasUsed { get; }
    public bool successfullyCompletedQuiz { get; }
    
    // Methods
    public TRVSubCategoryData get_myData()
    {
    
    }
    protected void set_myData(TRVSubCategoryData value)
    {
        this.<myData>k__BackingField = value;
    }
    public virtual bool get_quizLevelsPlayer()
    {
        return true;
    }
    public int[] get_myArrayIndex()
    {
    
    }
    protected void set_myArrayIndex(int[] value)
    {
        this.<myArrayIndex>k__BackingField = value;
    }
    public TRVQuizProgress(TRVSubCategoryData quizCategoryData)
    {
        var val_19;
        System.Int32[] val_20;
        System.Int32[] val_21;
        var val_22;
        this.quizLength = 7;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.previousQuestions = null;
        this.correctAnswerRequirement = 7;
        this.quizProgressIndex = 0;
        this.<myData>k__BackingField = quizCategoryData;
        this.quizCategory = quizCategoryData.subCategory;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.quizLength = GetQuizLength();
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ChestType val_5 = GetChestType();
        this.myChest = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance();
        this.correctAnswerRequirement = this.quizLength;
        this.currentGameplayState = new TRVGameplayState();
        Player val_7 = App.Player;
        this.quizLevel = 0;
        val_19 = 1152921504967548928;
        this.starMultiplierIndex = TRVMainController.currentMultiplier;
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.Dictionary<System.Int32, System.Int32[]> val_10 = getQuizDifficultyOrders;
        val_20 = 1152921512617817248;
        System.TimeType val_12 = Item[UnityEngine.Mathf.Min(a:  this.quizLength, b:  7)];
        this.<myArrayIndex>k__BackingField = null;
        twelvegigs.Autopilot.AutopilotManager val_13 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Collections.Generic.Dictionary<System.Int32, System.Int32[]> val_14 = getQuizDifficultyOrders;
        System.TimeType val_16 = Item[UnityEngine.Mathf.Min(a:  this.quizLength, b:  7)];
        val_21 = this.<myArrayIndex>k__BackingField;
        System.Array.Copy(sourceArray:  -1484293744, destinationArray:  val_21, length:  -578964320);
        if(this.starMultiplierIndex < 1)
        {
                return;
        }
        
        var val_19 = 23617598;
        val_19 = 12012140 + val_19;
        if(val_19 == 0)
        {
                mem2[0] = 1;
        }
        
        val_22 = null;
        val_22 = null;
        if(TRVMainController.noAnswerSelectedCharacter != null)
        {
                return;
        }
        
        System.Collections.Generic.List<System.Int32> val_17 = new System.Collections.Generic.List<System.Int32>();
        val_21 = 0;
        val_19 = 1152921510720759024;
        goto label_26;
        label_32:
        if((this.<myArrayIndex>k__BackingField[val_21]) == 0)
        {
                Add(item:  0);
        }
        
        val_21 = 1;
        label_26:
        val_20 = this.<myArrayIndex>k__BackingField;
        if(val_21 < null)
        {
            goto label_32;
        }
        
        this.<myArrayIndex>k__BackingField[UnityEngine.Random.Range(min:  0, max:  1094062064)] = 1;
    }
    public int get_correctAnswers()
    {
        var val_2;
        System.Func<TRVQuestionHistory, System.Boolean> val_4;
        if(true == 0)
        {
                return 0;
        }
        
        val_2 = null;
        val_2 = null;
        val_4 = TRVQuizProgress.<>c.<>9__34_0;
        if(val_4 != 0)
        {
                return System.Linq.Enumerable.Count<twelvegigs.storage.JsonDictionary>(source:  this.previousQuestions, predicate:  7720960);
        }
        
        val_4 = null;
        val_4 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  TRVQuizProgress.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3811115312));
        TRVQuizProgress.<>c.<>9__34_0 = val_4;
        return System.Linq.Enumerable.Count<twelvegigs.storage.JsonDictionary>(source:  this.previousQuestions, predicate:  7720960);
    }
    public int get_countedAnswers()
    {
        var val_2;
        System.Func<TRVQuestionHistory, System.Boolean> val_4;
        if(true == 0)
        {
                return 0;
        }
        
        val_2 = null;
        val_2 = null;
        val_4 = TRVQuizProgress.<>c.<>9__36_0;
        if(val_4 != 0)
        {
                return System.Linq.Enumerable.Count<twelvegigs.storage.JsonDictionary>(source:  this.previousQuestions, predicate:  7720960);
        }
        
        val_4 = null;
        val_4 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  TRVQuizProgress.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3811246768));
        TRVQuizProgress.<>c.<>9__36_0 = val_4;
        return System.Linq.Enumerable.Count<twelvegigs.storage.JsonDictionary>(source:  this.previousQuestions, predicate:  7720960);
    }
    public System.Collections.Generic.List<TRVQuestionHistory> get_countedAnswerData()
    {
        var val_4;
        System.Func<TRVQuestionHistory, System.Boolean> val_6;
        if(true == 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        val_6 = TRVQuizProgress.<>c.<>9__38_0;
        if(val_6 == 0)
        {
                val_6 = null;
            val_6 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  TRVQuizProgress.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3811376176));
            TRVQuizProgress.<>c.<>9__38_0 = val_6;
        }
        
        System.Collections.Generic.IEnumerable<TSource> val_2 = System.Linq.Enumerable.Where<System.Object>(source:  this.previousQuestions, predicate:  7720960);
        System.Collections.Generic.List<TSource> val_3 = System.Linq.Enumerable.ToList<System.Object>(source:  this.previousQuestions);
    }
    public int get_incorrecctAnswers()
    {
        var val_2;
        System.Func<TRVQuestionHistory, System.Boolean> val_4;
        if(true == 0)
        {
                return 0;
        }
        
        val_2 = null;
        val_2 = null;
        val_4 = TRVQuizProgress.<>c.<>9__40_0;
        if(val_4 != 0)
        {
                return System.Linq.Enumerable.Count<twelvegigs.storage.JsonDictionary>(source:  this.previousQuestions, predicate:  7720960);
        }
        
        val_4 = null;
        val_4 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  TRVQuizProgress.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3811507632));
        TRVQuizProgress.<>c.<>9__40_0 = val_4;
        return System.Linq.Enumerable.Count<twelvegigs.storage.JsonDictionary>(source:  this.previousQuestions, predicate:  7720960);
    }
    public int get_totalPointsGained()
    {
        var val_2;
        System.Func<TRVQuestionHistory, System.Int32> val_4;
        if(true == 0)
        {
                return 0;
        }
        
        val_2 = null;
        val_2 = null;
        val_4 = TRVQuizProgress.<>c.<>9__42_0;
        if(val_4 != 0)
        {
                return System.Linq.Enumerable.Sum<WADPets.WADPet>(source:  this.previousQuestions, selector:  7720960);
        }
        
        val_4 = null;
        val_4 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  TRVQuizProgress.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3811637040));
        TRVQuizProgress.<>c.<>9__42_0 = val_4;
        return System.Linq.Enumerable.Sum<WADPets.WADPet>(source:  this.previousQuestions, selector:  7720960);
    }
    public int get_hintsUsedThisQuiz()
    {
        var val_2;
        System.Func<TRVQuestionHistory, System.Int32> val_4;
        if(true == 0)
        {
                return 0;
        }
        
        val_2 = null;
        val_2 = null;
        val_4 = TRVQuizProgress.<>c.<>9__44_0;
        if(val_4 != 0)
        {
                return System.Linq.Enumerable.Sum<WADPets.WADPet>(source:  this.previousQuestions, selector:  7720960);
        }
        
        val_4 = null;
        val_4 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  TRVQuizProgress.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3811768496));
        TRVQuizProgress.<>c.<>9__44_0 = val_4;
        return System.Linq.Enumerable.Sum<WADPets.WADPet>(source:  this.previousQuestions, selector:  7720960);
    }
    public bool get_freeHintWasUsedThisQuiz()
    {
        var val_3;
        System.Func<TRVQuestionHistory, System.Int32> val_5;
        if(true == 0)
        {
                return false;
        }
        
        val_3 = null;
        val_3 = null;
        val_5 = TRVQuizProgress.<>c.<>9__46_0;
        if(val_5 == 0)
        {
                val_5 = null;
            val_5 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  TRVQuizProgress.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3811897904));
            TRVQuizProgress.<>c.<>9__46_0 = val_5;
        }
        
        if((System.Linq.Enumerable.Sum<WADPets.WADPet>(source:  this.previousQuestions, selector:  7720960)) > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public int get_rerollsUsedThisQuiz()
    {
        var val_2;
        System.Func<TRVQuestionHistory, System.Boolean> val_4;
        if(true == 0)
        {
                return 0;
        }
        
        val_2 = null;
        val_2 = null;
        val_4 = TRVQuizProgress.<>c.<>9__48_0;
        if(val_4 != 0)
        {
                return System.Linq.Enumerable.Count<twelvegigs.storage.JsonDictionary>(source:  this.previousQuestions, predicate:  7720960);
        }
        
        val_4 = null;
        val_4 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  TRVQuizProgress.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3812027312));
        TRVQuizProgress.<>c.<>9__48_0 = val_4;
        return System.Linq.Enumerable.Count<twelvegigs.storage.JsonDictionary>(source:  this.previousQuestions, predicate:  7720960);
    }
    public bool get_freeRerollWasUsedThisQuiz()
    {
        var val_2;
        System.Predicate<TRVQuestionHistory> val_4;
        if(true == 0)
        {
                return false;
        }
        
        val_2 = null;
        val_2 = null;
        val_4 = TRVQuizProgress.<>c.<>9__50_0;
        if(val_4 == 0)
        {
                val_4 = null;
            val_4 = new System.Predicate<ZooTile>(object:  TRVQuizProgress.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3812156720));
            TRVQuizProgress.<>c.<>9__50_0 = val_4;
        }
        
        if(this.previousQuestions != 0)
        {
                return this.previousQuestions.Exists(match:  8040448);
        }
        
        return this.previousQuestions.Exists(match:  8040448);
    }
    public int get_extraLivesUsedThisQuiz()
    {
        var val_2;
        System.Func<TRVQuestionHistory, System.Int32> val_4;
        if(true == 0)
        {
                return 0;
        }
        
        val_2 = null;
        val_2 = null;
        val_4 = TRVQuizProgress.<>c.<>9__52_0;
        if(val_4 != 0)
        {
                return System.Linq.Enumerable.Sum<WADPets.WADPet>(source:  this.previousQuestions, selector:  7720960);
        }
        
        val_4 = null;
        val_4 = new System.Func<twelvegigs.Autopilot.AutopilotButton, System.Int32>(object:  TRVQuizProgress.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3812288176));
        TRVQuizProgress.<>c.<>9__52_0 = val_4;
        return System.Linq.Enumerable.Sum<WADPets.WADPet>(source:  this.previousQuestions, selector:  7720960);
    }
    public int get_expertHintWasUsed()
    {
        var val_2;
        System.Func<TRVQuestionHistory, System.Boolean> val_4;
        if(true == 0)
        {
                return 0;
        }
        
        val_2 = null;
        val_2 = null;
        val_4 = TRVQuizProgress.<>c.<>9__54_0;
        if(val_4 != 0)
        {
                return System.Linq.Enumerable.Count<twelvegigs.storage.JsonDictionary>(source:  this.previousQuestions, predicate:  7720960);
        }
        
        val_4 = null;
        val_4 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  TRVQuizProgress.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3812417584));
        TRVQuizProgress.<>c.<>9__54_0 = val_4;
        return System.Linq.Enumerable.Count<twelvegigs.storage.JsonDictionary>(source:  this.previousQuestions, predicate:  7720960);
    }
    public bool get_freeexpertHintWasUsed()
    {
        var val_2;
        System.Predicate<TRVQuestionHistory> val_4;
        if(true == 0)
        {
                return false;
        }
        
        val_2 = null;
        val_2 = null;
        val_4 = TRVQuizProgress.<>c.<>9__56_0;
        if(val_4 == 0)
        {
                val_4 = null;
            val_4 = new System.Predicate<ZooTile>(object:  TRVQuizProgress.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(3812546992));
            TRVQuizProgress.<>c.<>9__56_0 = val_4;
        }
        
        if(this.previousQuestions != 0)
        {
                return this.previousQuestions.Exists(match:  8040448);
        }
        
        return this.previousQuestions.Exists(match:  8040448);
    }
    public bool get_successfullyCompletedQuiz()
    {
        if(this.countedAnswers >= this.quizLength)
        {
                0 = 1;
        }
        
        return true;
    }
    public void AdvanceQuiz(bool extraLifeQuestion)
    {
        this.currentGameplayState = new TRVGameplayState();
        goto typeof(TRVQuizProgress).__il2cppRuntimeField_E4;
    }
    protected virtual void GetNextQuestion(bool extraLifeQuestion)
    {
        int val_9;
        var val_10;
        if(extraLifeQuestion == false)
        {
                this.quizProgressIndex = this.quizProgressIndex + 1;
            this.quizProgressIndex = this.quizProgressIndex;
        }
        
        if(this.quizProgressIndex < true)
        {
                val_9 = this.quizProgressIndex;
        }
        else
        {
                val_9 = true - 1;
            this.quizProgressIndex = val_9;
        }
        
        int val_9 = this.<myArrayIndex>k__BackingField[val_9];
        Player val_1 = App.Player;
        WordForest.WFOGameEcon val_2 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if(0 < mem[1152921512476916184])
        {
                val_10 = 0;
        }
        
        goto label_11;
        label_29:
        CompanyDevices val_3 = CompanyDevices.Instance;
        if(0.CompanyDevice() != false)
        {
                typeof(System.Object[]).__il2cppRuntimeField_10 = this.<myData>k__BackingField.subCategory;
            typeof(System.Object[]).__il2cppRuntimeField_14 = null;
            UnityEngine.Debug.LogErrorFormat(format:  -481956304, args:  472754880);
        }
        
        val_10 = -1;
        label_11:
        if(val_10 >= 1)
        {
                if((this.<myData>k__BackingField.questionData.ContainsKey(key:  -1)) == false)
        {
            goto label_29;
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        QuestionData val_8 = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28.GetQuestion(myData:  this.<myData>k__BackingField, subCat:  this.quizCategory, desiredDifficulty:  -1, completedThisDifficulty: ref  this.justCompletedDifficulty);
        this.currentQuestionData = public static TRVDataParser MonoSingleton<TRVDataParser>::get_Instance().__il2cppRuntimeField_28;
    }
    public int GetQuizBaseReward()
    {
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_13 = 1152921504892043264;
        val_14 = 1152921512476914864;
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if(mem[1152921512476916264] != false)
        {
                WordForest.WFOGameEcon val_3 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
            val_15 = dynamicQuizEntryCost;
        }
        else
        {
                WordForest.WFOGameEcon val_5 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
            val_15 = mem[1152921512476916200];
        }
        
        WordForest.WFOGameEcon val_6 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        float val_13 = (float)val_15;
        val_13 = mem[1152921512476916204] * val_13;
        if((UnityEngine.Mathf.FloorToInt(f:  val_13)) != 0)
        {
                return (int)val_16;
        }
        
        WordForest.WFOGameEcon val_8 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        WordForest.WFOGameEcon val_9 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        val_13 = 0;
        int val_10 = dynamicQuizEntryCost;
        WordForest.WFOGameEcon val_11 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        val_14 = public static TRVEcon App::GetGameSepeciticEcon<TRVEcon>();
        string val_12 = System.String.Format(format:  -481692544, arg0:  8945664, arg1:  13152256, arg2:  15282176);
        UnityEngine.Debug.LogError(message:  -481692544);
        val_16 = 50;
        return (int)val_16;
    }
    public int GetQuizBaseStarReward()
    {
        return this.totalPointsGained;
    }
    public void InjectTrackingInfo(string key, object value)
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_4 = this.injectedTrackingInfo;
        if(val_4 == 0)
        {
                val_4 = null;
            val_4 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.injectedTrackingInfo = val_4;
            if(val_4 == 0)
        {
                val_4 = 0;
        }
        
        }
        
        if((val_4.ContainsKey(key:  key)) != false)
        {
                string val_3 = -481455712(-481455712) + key + -481455840(-481455840);
            UnityEngine.Debug.LogError(message:  -481455712);
            return;
        }
        
        this.injectedTrackingInfo.Add(key:  key, value:  value);
    }
    public System.Collections.Generic.Dictionary<string, object> GetAdditionalTrackingInfo()
    {
        System.Collections.Generic.Dictionary<System.String, System.Type> val_2;
        if(this.injectedTrackingInfo != 0)
        {
                val_2 = null;
            val_2 = new System.Collections.Generic.Dictionary<System.String, System.Type>(dictionary:  this.injectedTrackingInfo);
            return;
        }
        
        val_2 = 0;
    }

}
