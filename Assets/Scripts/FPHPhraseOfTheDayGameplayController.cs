using UnityEngine;
public class FPHPhraseOfTheDayGameplayController : FPHGameplayController
{
    // Methods
    protected override void Start()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1612446032, name:  1799422256);
    }
    public override void Init()
    {
        var val_6;
        mem[1152921511584447548] = new FPHGameplayState();
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SetupLevel(newGame: ref  FPHGameplayState val_3 = -1612334020);
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        StartGameplay(newState:  303194112);
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_5 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1646909904, value:  8945664);
        Add(key:  -1646909808, value:  FPHGameplayState.__il2cppRuntimeField_8);
        var val_6 = 28500994;
        val_6 = 7124544 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        App.trackerManager.track(eventName:  -2100698896, data:  78753792);
    }
    public override bool CheckAnswer(bool triggerCallbackOnlyOnCorrect = False)
    {
        bool val_1 = static_value_021FA2E1.IsCurrentDisplayCorrectAnswer();
        this.SolveModeExit(removePlayerEntries:  false);
        if(val_1 != true)
        {
                if(triggerCallbackOnlyOnCorrect == true)
        {
                return val_1;
        }
        
        }
        
        if(this == 0)
        {
                return val_1;
        }
        
        this.Invoke(obj:  val_1);
        return val_1;
    }
    public override void SpendGems(int gems, string source)
    {
        Player val_1 = App.Player;
        0.AddGems(amount:  0 - gems, source:  -1646909904, subsource:  null);
    }
    public override void ProcessLevelComplete(bool success)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CompleteQuestion(correctAnswer:  success);
    }
    public override void UpdateGameSave(FPHGameplayState updatedData)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UpdateSavedGame(state:  updatedData);
    }
    public override void RevealAnswer()
    {
        var val_4;
        var val_5;
        val_4 = 0;
        goto label_1;
        label_10:
        val_5 = R6;
        if(R6 == 0)
        {
                if(val_5 == 0)
        {
            goto label_3;
        }
        
        }
        
        R6 + 80.set_Item(index:  0, value:  R6 + 84.Chars[0]);
        R6 + 80 + 76.set_Item(index:  0, value:  1);
        val_4 = 1;
        label_1:
        if(val_4 < (R6 + 80 + 76 + 76 + 12))
        {
            goto label_10;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UpdateGameplayState(updatedState:  R6 + 80 + 76 + 76);
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CompleteQuestion(correctAnswer:  false);
        return;
        label_3:
    }
    public void OnLocalize()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public override bool IsTutorialLevel()
    {
        return false;
    }
    public override bool IsKeyboardTutorial()
    {
        return false;
    }
    public override bool IsTokenFeatureTutorial()
    {
        return false;
    }
    public override System.Collections.Generic.Dictionary<string, object> GatherLevelCompleteTrackingData(bool isSuccess, string failReason)
    {
        return this.GatherLevelCompleteTrackingData(isSuccess:  isSuccess, failReason:  failReason);
    }
    private void OnDisable()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.RemoveObserver(observer:  -1611077456, name:  1799422256);
    }
    public FPHPhraseOfTheDayGameplayController()
    {
    
    }

}
