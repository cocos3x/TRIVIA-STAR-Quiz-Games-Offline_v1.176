using UnityEngine;
public class TRVQuestionHistory
{
    // Fields
    private string _questionID;
    private int questionDifficulty;
    public int extraLivesUsed;
    public int hintsUsed;
    public int freehintsused;
    public bool rerollQuestionPowerUpUsed;
    public bool freererollQuestionPowerUpUsed;
    public int pointsGained;
    public bool ranOutOfTime;
    public bool extraLifePurchased;
    public bool expertAnswerUsed;
    public bool freeexpertAnswerUsed;
    private float questionMaxDuration;
    private System.DateTime questionStartTime;
    private System.DateTime questionEndTime;
    
    // Properties
    public string questionID { get; }
    public bool extraLifeUsed { get; }
    public bool hintUsed { get; }
    public bool freehintUsed { get; }
    public bool answeredCorrectly { get; }
    public float questionTimeTaken { get; }
    
    // Methods
    public TRVQuestionHistory(TRVGameplayState prevState, QuestionData qd)
    {
        var val_4;
        this.questionMaxDuration = 20f;
        val_4 = null;
        val_4 = null;
        this.questionStartTime = System.DateTime.MinValue;
        mem[1152921512717875108] = ???;
        this.questionEndTime = System.DateTime.MinValue;
        if(prevState != 0)
        {
                this.extraLivesUsed = prevState.extraLivesUsed;
            this.hintsUsed = prevState.hintsUsed;
            this.freehintsused = prevState.freehintsUsed;
        }
        else
        {
                this.extraLivesUsed = 2097204;
            this.hintsUsed = 35615780;
            this.freehintsused = 83886592;
        }
        
        this.pointsGained = prevState.pointsEarned;
        if(qd != 0)
        {
                this._questionID = qd.<questionID>k__BackingField;
        }
        else
        {
                this._questionID = 0;
        }
        
        this.questionDifficulty = qd.<difficulty>k__BackingField;
        this.extraLifePurchased = prevState.extraLifePurchased;
        this.rerollQuestionPowerUpUsed = prevState.rerollQuestionPowerupUsed;
        this.freererollQuestionPowerUpUsed = prevState.freererollQuestionPowerupUsed;
        this.questionMaxDuration = prevState.quizDuration;
        this.ranOutOfTime = System.String.op_Equality(a:  prevState.selectedAnswer, b:  1372269104);
        mem[1152921512717875104] = prevState.quizStartTime;
        System.DateTime val_2 = DateTimeCheat.UtcNow;
        mem2[0] = ???;
        if(prevState.expertHintedAnswers.Count > 0)
        {
                0 = 1;
        }
        
        this.expertAnswerUsed = true;
        this.freeexpertAnswerUsed = prevState.freeExpertAnswer;
    }
    public string get_questionID()
    {
    
    }
    public bool get_extraLifeUsed()
    {
        if(this.extraLivesUsed > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public bool get_hintUsed()
    {
        if(this.hintsUsed > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public bool get_freehintUsed()
    {
        if(this.freehintsused > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public bool get_answeredCorrectly()
    {
        if(this.pointsGained > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public float get_questionTimeTaken()
    {
        var val_2;
        System.TimeSpan val_1 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = 1152921512718563680}, d2:  new System.DateTime() {dateData = this.questionEndTime});
        double val_4 = val_2.TotalSeconds;
        return this.questionMaxDuration;
    }
    public System.Collections.Generic.Dictionary<string, object> GetTrackingData()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -478113744, value:  this._questionID);
        Add(key:  -1430007168, value:  13152256);
        if(this.pointsGained > 0)
        {
                0 = 1;
        }
        
        Add(key:  -478113648, value:  8945664);
        if(this.hintsUsed > 0)
        {
                0 = 1;
        }
        
        Add(key:  -478113552, value:  8945664);
        if(this.freehintsused > 0)
        {
                0 = 1;
        }
        
        Add(key:  -478113456, value:  8945664);
        Add(key:  -478113360, value:  8945664);
        Add(key:  -478113264, value:  8945664);
        if(this.extraLivesUsed > 0)
        {
                0 = 1;
        }
        
        Add(key:  -478113152, value:  8945664);
        Add(key:  -487709632, value:  13152256);
        Add(key:  -478113040, value:  8945664);
        Add(key:  -478112928, value:  8945664);
        Add(key:  -478112816, value:  8945664);
    }
    public override string ToString()
    {
        if(this.extraLivesUsed > 0)
        {
                0 = 1;
        }
        
        string val_2 = 1.ToString();
        string val_3 = -477996608(-477996608) + -477983265(-477983265);
        System.Text.StringBuilder val_4 = AppendLine(value:  -477996608);
        string val_5 = -477996496(-477996496) + 13152256;
        System.Text.StringBuilder val_6 = AppendLine(value:  -477996496);
        string val_7 = -477996400(-477996400) + 13152256;
        System.Text.StringBuilder val_8 = AppendLine(value:  -477996400);
        string val_9 = this.rerollQuestionPowerUpUsed.ToString();
        string val_10 = -477996288(-477996288) + this.rerollQuestionPowerUpUsed;
        System.Text.StringBuilder val_11 = AppendLine(value:  -477996288);
        string val_12 = this.freererollQuestionPowerUpUsed.ToString();
        string val_13 = -477996192(-477996192) + this.freererollQuestionPowerUpUsed;
        System.Text.StringBuilder val_14 = AppendLine(value:  -477996192);
        string val_15 = -477996080(-477996080) + 13152256;
        System.Text.StringBuilder val_16 = AppendLine(value:  -477996080);
        if(this.pointsGained > 0)
        {
                0 = 1;
        }
        
        string val_17 = 1.ToString();
        string val_18 = -477995968(-477995968) + -477983265(-477983265);
        System.Text.StringBuilder val_19 = AppendLine(value:  -477995968);
        string val_20 = -477995856(-477995856) + 15282176;
        System.Text.StringBuilder val_21 = AppendLine(value:  -477995856);
        string val_22 = -477995744(-477995744) + 9904128;
        System.Text.StringBuilder val_23 = AppendLine(value:  -477995744);
        string val_24 = -477995648(-477995648) + 9904128;
        System.Text.StringBuilder val_25 = AppendLine(value:  -477995648);
        float val_26 = this.questionTimeTaken;
        string val_27 = -477995552(-477995552) + 15282176;
        System.Text.StringBuilder val_28 = AppendLine(value:  -477995552);
        string val_29 = this.expertAnswerUsed.ToString();
        string val_30 = -477995456(-477995456) + this.expertAnswerUsed;
        System.Text.StringBuilder val_31 = AppendLine(value:  -477995456);
        string val_32 = this.freeexpertAnswerUsed.ToString();
        string val_33 = -477995344(-477995344) + this.freeexpertAnswerUsed;
        if(new System.Text.StringBuilder() != 0)
        {
                System.Text.StringBuilder val_34 = AppendLine(value:  -477995344);
            return;
        }
        
        System.Text.StringBuilder val_35 = AppendLine(value:  -477995344);
    }

}
