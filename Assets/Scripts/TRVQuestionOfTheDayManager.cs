using UnityEngine;
public class TRVQuestionOfTheDayManager : MonoSingleton<TRVQuestionOfTheDayManager>
{
    // Fields
    public const string QOTD_QUESTION_SET_CATEGORY = "QOTD";
    private TRVQotdStatus <Status>k__BackingField;
    
    // Properties
    private TRVQotdStatus Status { get; set; }
    
    // Methods
    private TRVQotdStatus get_Status()
    {
    
    }
    private void set_Status(TRVQotdStatus value)
    {
        this.<Status>k__BackingField = value;
    }
    public override void InitMonoSingleton()
    {
        this.InitMonoSingleton();
        EventProgression val_1 = new EventProgression();
        this.<Status>k__BackingField = val_1;
        if(val_1 == 0)
        {
            
        }
    
    }
    public TRVReward GetReward(bool isBonus)
    {
        var val_6;
        if(isBonus != false)
        {
                WordForest.WFOGameEcon val_2 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
            val_6 = mem[1152921512476916308] + 16;
            return;
        }
        
        WordForest.WFOGameEcon val_3 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        val_6 = mem[1152921512476916308] + 12;
    }
    public void CheckQOTD()
    {
        this.CheckLPN();
    }
    public void Play()
    {
        var val_6;
        var val_6 = 23611543;
        val_6 = 12015348 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        TRVMainController.noAnswerSelectedCharacter = 1;
        System.DateTime val_1 = DateTimeCheat.Now;
        System.DateTime val_4 = Date;
        this.<Status>k__BackingField.LastFinishedTime = new System.DateTime();
        this.<Status>k__BackingField.playing = true;
        GameBehavior val_5 = App.getBehavior;
        if(0 != 0)
        {
                return;
        }
    
    }
    public void Complete()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CheckShouldShowLowGems();
        this.<Status>k__BackingField.playing = false;
        GameBehavior val_2 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public void CollectReward(TRVReward reward)
    {
        int val_3;
        var val_7;
        string val_8;
        if(reward.rewardType != 1)
        {
                if(reward.rewardType != 0)
        {
                return;
        }
        
            Player val_1 = App.Player;
            val_7 = 0;
            val_8 = 0;
            decimal val_2 = System.Decimal.op_Implicit(value:  -450283936);
            val_7.AddCredits(amount:  new System.Decimal() {mid = val_3}, source:  "Question of the Day Event", subSource:  val_8, externalParams:  val_8, doTrack:  true);
            return;
        }
        
        Player val_4 = App.Player;
        val_8 = reward.rewardAmount;
        val_7 = 0;
        val_7.AddGems(amount:  val_8, source:  -450300112, subsource:  null);
        Player val_5 = App.Player;
        string val_6 = reward + 12.ToString();
        0.TrackNonCoinReward(source:  -450300112, subSource:  null, rewardType:  -1668821072, rewardAmount:  reward + 12, additionalParams:  0);
    }
    public bool IsPlaying()
    {
        if((this.<Status>k__BackingField) != 0)
        {
                return (bool)this.<Status>k__BackingField.playing;
        }
        
        return (bool)this.<Status>k__BackingField.playing;
    }
    public bool IsEligible()
    {
        ulong val_9;
        ulong val_11;
        var val_14;
        TRVQotdStatus val_15;
        val_14 = 0;
        if(this.IsFeatureEnabled() == false)
        {
                return (bool)val_14;
        }
        
        Player val_2 = App.Player;
        WordForest.WFOGameEcon val_3 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        val_14 = 0;
        if(0 < (mem[1152921512476916308] + 8))
        {
                return (bool)val_14;
        }
        
        val_15 = this.<Status>k__BackingField;
        if(val_15 == 0)
        {
                val_15 = this.<Status>k__BackingField;
        }
        
        System.DateTime val_4 = Date;
        System.DateTime val_5 = DateTimeCheat.Now;
        System.DateTime val_8 = Date;
        val_14 = System.DateTime.op_LessThan(t1:  new System.DateTime() {dateData = val_11}, t2:  new System.DateTime() {dateData = val_9});
        return (bool)val_14;
    }
    public bool IsFeatureEnabled()
    {
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if((mem[1152921512476916308] + 8) < 0)
        {
                return false;
        }
        
        GameBehavior val_2 = App.getBehavior;
        string val_3 = 0.GetCurrentLanguage();
        return System.String.op_Equality(a:  null, b:  1800251696);
    }
    public TRVCategorySelectionInfo GetRandomSubCategory()
    {
        TRVCategorySelectionInfo val_1 = new TRVCategorySelectionInfo();
        typeof(TRVCategorySelectionInfo).__il2cppRuntimeField_8 = "QOTD_AllQuestions";
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_2 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        typeof(TRVCategorySelectionInfo).__il2cppRuntimeField_C = null;
    }
    private void CheckLPN()
    {
        ulong val_5;
        twelvegigs.plugins.NotificationInterval val_6;
        ulong val_8;
        ulong val_14;
        twelvegigs.plugins.NotificationInterval val_15;
        twelvegigs.plugins.LocalNotificationsPlugin.KillNotification(tipo:  26);
        System.DateTime val_1 = DateTimeCheat.Today;
        System.DateTime val_4 = AddHours(value:  null);
        val_14 = val_5;
        val_15 = val_6;
        System.DateTime val_7 = DateTimeCheat.Now;
        if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_8}, t2:  new System.DateTime() {dateData = val_14})) != false)
        {
                System.DateTime val_11 = DateTimeCheat.Today;
            System.DateTime val_12 = AddHours(value:  null);
            val_14 = val_5;
            val_15 = val_6;
        }
        
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_13 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1953384384, value:  -718510176);
        twelvegigs.plugins.LocalNotificationsPlugin.PostNotification(tipo:  26, when:  new System.DateTime() {dateData = 1152921512747078448}, interval:  val_15, optTitle:  0, optMessage:  "Question of the Day", extraData:  "Question of the Day is now available!", priority:  null, useTimeModifier:  false);
        if((this.<Status>k__BackingField) != 0)
        {
                return;
        }
    
    }
    private void CheckQOTDGameplayStatus()
    {
        bool val_1 = this.IsEligible();
        if(val_1 == false)
        {
                return;
        }
        
        val_1.ShowQOTDPopup();
    }
    private void ShowQOTDPopup()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public TRVQuestionOfTheDayManager()
    {
    
    }

}
