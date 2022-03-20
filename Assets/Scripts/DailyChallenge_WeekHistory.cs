using UnityEngine;
public class DailyChallenge_WeekHistory
{
    // Fields
    public int stars;
    public System.Collections.Generic.Dictionary<string, DailyChallenge_DayProgress> progress;
    
    // Methods
    public DailyChallenge_WeekHistory()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.progress = null;
    }

}
