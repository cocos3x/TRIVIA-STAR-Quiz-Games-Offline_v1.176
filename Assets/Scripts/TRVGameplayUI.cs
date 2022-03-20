using UnityEngine;
public class TRVGameplayUI : MonoSingleton<TRVGameplayUI>
{
    // Fields
    private System.Collections.Generic.List<TRVQuestionButton> questionButtons;
    private TRVTimerDisplay timer;
    private TRVCountdownOverlay countDown;
    private UnityEngine.CanvasGroup gameplayCanvasGroup;
    private UnityEngine.UI.Text questionText;
    private UnityEngine.GameObject questionImageGroup;
    private UnityEngine.UI.Text questionImageText;
    private UnityEngine.UI.Image questionImage;
    private UnityEngine.UI.Text categoryNameText;
    private TRVHintButton hintButton;
    private TRVRerollQuestionButton rerollButton;
    private TRVAskExpertButton expertButton;
    private UnityEngine.UI.HorizontalLayoutGroup feedbackGroup;
    private TRVAnswerFeedbackDisplay answerFeedback;
    private TRVCategoryRankDisplay rankDisplay;
    private TRVFlyout myFlyout;
    private CurrencyStatViewInstantiator streakStatView;
    private TRVStreakParticle streakParticle;
    private int countdownTime;
    private int quizTime;
    private TRVQuizProgress currentLevelData;
    
    // Properties
    public TRVTimerDisplay getTimer { get; }
    public System.Collections.Generic.List<TRVPowerupButton> getPowerupButtons { get; }
    
    // Methods
    public TRVTimerDisplay get_getTimer()
    {
    
    }
    public System.Collections.Generic.List<TRVPowerupButton> get_getPowerupButtons()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  this.hintButton);
        Add(item:  this.rerollButton);
        Add(item:  this.expertButton);
    }
    private void Start()
    {
        this.gameplayCanvasGroup.alpha = null;
    }
    public void StartGameplay(TRVQuizProgress incData)
    {
        QuestionData val_10;
        UnityEngine.UI.Text val_11;
        string val_12;
        UnityEngine.UI.Text val_13;
        var val_14;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.currentLevelData = incData;
        bool val_2 = UnityEngine.Object.op_Inequality(x:  incData.currentQuestionData.imageSp, y:  0);
        if(val_2 != false)
        {
                this.questionImage.sprite = incData.currentQuestionData.imageSp;
            val_10 = incData.currentQuestionData;
            val_11 = this.questionImageText;
        }
        else
        {
                val_10 = incData.currentQuestionData;
            val_11 = this.questionText;
        }
        
        this.questionImageGroup.SetActive(value:  val_2);
        UnityEngine.GameObject val_3 = this.questionText.gameObject;
        this.questionText.SetActive(value:  val_2 ^ 1);
        AddRange(collection:  incData.currentQuestionData.<incorrectAnswers>k__BackingField);
        Add(item:  incData.currentQuestionData.<answer>k__BackingField);
        PluginExtension.Shuffle<UnityEngine.Sprite>(list:  80883712, seed:  new System.Nullable<System.Int32>() {HasValue = false});
        this.answerFeedback.Hide();
        this.rankDisplay.Hide();
        val_12 = incData.quizCategory;
        if((val_12.Contains(value:  -559222368)) != false)
        {
                string val_6 = val_12.Replace(oldValue:  -559222368, newValue:  1098586544);
            val_12 = val_12;
        }
        
        val_13 = this.categoryNameText;
        val_14 = 4;
        goto label_24;
        label_35:
        if(val_13 <= R6)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_13 = 2621443;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_13.SetupButton(answerToDisplay:  List<T>.__il2cppRuntimeField_10);
        if(val_13 <= R6)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        2621443.SetButtonState(state:  false, immediate:  true);
        val_14 = 5;
        label_24:
        if((val_14 - 4) < 2621443)
        {
            goto label_35;
        }
        
        this.timer.enabled = false;
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SetActive(active:  true);
        System.Collections.IEnumerator val_9 = this.StartGame(incData:  1);
        UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  -522188640);
    }
    private System.Collections.IEnumerator StartGame(TRVQuizProgress incData)
    {
        object val_1 = new System.Object();
        typeof(TRVGameplayUI.<StartGame>d__27).__il2cppRuntimeField_8 = 0;
        typeof(TRVGameplayUI.<StartGame>d__27).__il2cppRuntimeField_10 = this;
    }
    private System.Collections.IEnumerator checkLevelFlyout()
    {
        object val_1 = new System.Object();
        typeof(TRVGameplayUI.<checkLevelFlyout>d__28).__il2cppRuntimeField_8 = 0;
        typeof(TRVGameplayUI.<checkLevelFlyout>d__28).__il2cppRuntimeField_10 = this;
    }
    public void UpdateGameState(TRVQuizProgress incData)
    {
        var val_20;
        var val_21;
        TRVCategoryRankDisplay val_22;
        System.Func<twelvegigs.storage.JsonDictionary, System.Boolean> val_23;
        bool val_24;
        val_20 = this;
        typeof(TRVGameplayUI.<>c__DisplayClass29_0).__il2cppRuntimeField_8 = incData;
        val_21 = 4;
        goto label_2;
        label_37:
        if(new System.Object() <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(R7 != 0)
        {
                if(0 <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            2621443.SetButtonState(state:  incData + 16 + 8.Contains(item:  static_value_00280013), immediate:  false);
        }
        else
        {
                val_20 = val_20;
            2621443.SetAnswerSelectedState(correctAnswer:  incData + 20 + 24, selectedAnswer:  incData + 16 + 16);
        }
        
        if(2621443 <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        bool val_3 = incData + 16 + 52.ContainsKey(key:  static_value_00280013);
        if(val_3 != false)
        {
                if(val_3 <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(0 <= R8)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            string val_4 = incData + 16 + 52.Item[static_value_00280013];
            2621443.DisplayExpert(exp:  incData + 16 + 52);
        }
        
        val_21 = val_21 + 1;
        label_2:
        val_22 = val_21 - 4;
        val_23 = System.String.IsNullOrEmpty(value:  incData + 16 + 16);
        if(val_22 < this.questionButtons)
        {
            goto label_37;
        }
        
        if(val_23 != false)
        {
                val_24 = mem[incData + 16 + 24];
            val_24 = incData + 16 + 24;
            val_23 = mem[incData + 16];
            val_23 = incData + 16;
            this.timer.UpdateTime(incStartTime:  new System.DateTime(), secondsToCompleteQuiz:  null);
            return;
        }
        
        this.FadeOutPowerups();
        bool val_6 = System.String.op_Equality(a:  incData + 16 + 16, b:  incData + 20 + 24);
        val_24 = val_6;
        if((val_6 == false) || ((TRVCategoryRankController.CanRankUpCategory(subCategory:  incData + 8)) == false))
        {
            goto label_51;
        }
        
        val_22 = this.rankDisplay;
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.Sprite val_9 = GetCategoryIcon(category:  incData + 8);
        val_22.DisplayCategoryRank(categorySp:  -612557856, startProgress:  null, endProgress:  null);
        val_23 = null;
        val_23 = new System.Func<twelvegigs.storage.JsonDictionary, System.Boolean>(object:  358944768, method:  new IntPtr(3773246304));
        object val_11 = System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  this.questionButtons, predicate:  7720960);
        if(this.questionButtons == 0)
        {
            goto label_73;
        }
        
        UnityEngine.Transform val_13 = this.streakParticle.transform;
        UnityEngine.Transform val_14 = this.questionButtons.transform;
        UnityEngine.Vector3 val_15 = position;
        this.streakParticle.position = new UnityEngine.Vector3();
        UnityEngine.Transform val_16 = this.streakStatView.AppleIcon;
        UnityEngine.Transform val_17 = this.streakStatView.transform;
        val_23 = this.streakStatView;
        UnityEngine.Vector3 val_18 = position;
        this.streakParticle.PlayParticles(destinationPosition:  new UnityEngine.Vector3(), particleCount:  1, animateStatView:  true);
        goto label_73;
        label_51:
        this.rankDisplay.Hide();
        label_73:
        this.answerFeedback.DisplayResult(correct:  val_24);
        twelvegigs.Autopilot.AutopilotManager val_19 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SetActive(active:  true);
        this.StopTimer();
    }
    public void HideQuestionButtons()
    {
        var val_3;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_4:
        if(MoveNext() == false)
        {
            goto label_2;
        }
        
        val_3.SetButtonState(state:  false, immediate:  false);
        goto label_4;
        label_2:
        Dispose();
    }
    public void HideTimer()
    {
        this.timer.Setup();
    }
    public void StopTimer()
    {
        this.timer.OnTick = 0;
        this.timer.StopTimer();
    }
    public void ContinueTimer(float duration)
    {
        System.DateTime val_10;
        System.Delegate val_14;
        System.Delegate val_15;
        System.Delegate val_16;
        if(this.timer == 0)
        {
                return;
        }
        
        if(this.currentLevelData == 0)
        {
                return;
        }
        
        System.Action<System.Int32> val_2 = new System.Action<System.Int32>(object:  this.hintButton, method:  typeof(TRVHintButton).__il2cppRuntimeField_130);
        val_14 = this.timer.OnTick;
        System.Delegate val_3 = System.Delegate.Combine(a:  val_14, b:  7401472);
        if(val_14 != 0)
        {
                if(null == null)
        {
            goto label_8;
        }
        
        }
        
        val_14 = 0;
        label_8:
        this.timer.OnTick = val_14;
        System.Action<System.Int32> val_4 = new System.Action<System.Int32>(object:  this.rerollButton, method:  public System.Void TRVPowerupButton::PlayReminderAnim(int remainingTime));
        val_15 = this.timer.OnTick;
        System.Delegate val_5 = System.Delegate.Combine(a:  val_15, b:  7401472);
        if(val_15 != 0)
        {
                if(null == null)
        {
            goto label_12;
        }
        
        }
        
        val_15 = 0;
        label_12:
        this.timer.OnTick = val_15;
        System.Action<System.Int32> val_6 = new System.Action<System.Int32>(object:  this.expertButton, method:  typeof(TRVAskExpertButton).__il2cppRuntimeField_130);
        val_16 = this.timer.OnTick;
        System.Delegate val_7 = System.Delegate.Combine(a:  val_16, b:  7401472);
        if(val_16 != 0)
        {
                if(null == null)
        {
            goto label_16;
        }
        
        }
        
        val_16 = 0;
        label_16:
        this.timer.OnTick = val_16;
        System.DateTime val_8 = DateTimeCheat.UtcNow;
        this.currentLevelData.currentGameplayState.quizStartTime = val_10;
        System.DateTime val_11 = DateTimeCheat.UtcNow;
        this.timer.UpdateTime(incStartTime:  new System.DateTime(), secondsToCompleteQuiz:  duration);
    }
    public void SetGameplayAlpha(bool visible)
    {
        if(visible == true)
        {
                0f = 1f;
        }
        
        this.gameplayCanvasGroup.alpha = 1f;
    }
    public void FadeOutPowerups()
    {
        UnityEngine.GameObject val_1 = this.hintButton.gameObject;
        if(this.hintButton.activeInHierarchy != false)
        {
                this.hintButton.FadeOut();
        }
        
        UnityEngine.GameObject val_3 = this.rerollButton.gameObject;
        if(this.rerollButton.activeInHierarchy != false)
        {
                this.rerollButton.FadeOut();
        }
        
        UnityEngine.GameObject val_5 = this.expertButton.gameObject;
        if(this.expertButton.activeInHierarchy == false)
        {
                return;
        }
        
        R4 + 56.FadeOut();
    }
    public TRVGameplayUI()
    {
        this.countdownTime = 3;
        this.quizTime = 7;
    }

}
