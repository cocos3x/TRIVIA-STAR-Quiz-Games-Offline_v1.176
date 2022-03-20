using UnityEngine;
public class TRVGameplayState
{
    // Fields
    public System.Collections.Generic.List<string> activeButtons;
    public float quizDuration;
    public string selectedAnswer;
    public System.DateTime quizStartTime;
    public int hintsUsed;
    public int freehintsUsed;
    public int extraLivesUsed;
    public int pointsEarned;
    public bool extraLifePurchased;
    public bool rerollQuestionPowerupUsed;
    public bool freererollQuestionPowerupUsed;
    public System.Collections.Generic.Dictionary<string, TRVExpert> expertHintedAnswers;
    public bool freeExpertAnswer;
    
    // Properties
    public bool hasSelectedAnswer { get; }
    
    // Methods
    public bool get_hasSelectedAnswer()
    {
        bool val_1 = System.String.IsNullOrEmpty(value:  this.selectedAnswer);
        val_1 = val_1 ^ 1;
        return (bool)val_1;
    }
    public TRVGameplayState()
    {
        var val_3;
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.activeButtons = null;
        this.selectedAnswer = System.String.alignConst;
        val_3 = null;
        val_3 = null;
        this.quizStartTime = System.DateTime.MinValue;
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_2 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.expertHintedAnswers = null;
    }

}
