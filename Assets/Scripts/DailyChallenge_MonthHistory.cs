using UnityEngine;
public class DailyChallenge_MonthHistory
{
    // Fields
    public int stars;
    public string tile;
    public System.Collections.Generic.Dictionary<string, DailyChallenge_DayProgress> progress;
    
    // Methods
    public DailyChallenge_MonthHistory()
    {
        this.tile = "";
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        this.progress = null;
    }

}
