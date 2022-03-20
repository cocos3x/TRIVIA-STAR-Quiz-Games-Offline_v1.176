using UnityEngine;
public class OnTheTrailDayProgress
{
    // Fields
    private const string KEY_DAY_INDEX = "day";
    private const string KEY_COMPLETED_LEVELS = "completed_levels";
    public int DayIndex;
    public int CompletedLevels;
    
    // Methods
    public void FromJSON(System.Collections.Generic.Dictionary<string, object> json)
    {
        if((json.ContainsKey(key:  -1144798864)) != false)
        {
                object val_2 = json.Item[-1144798864];
            string val_3 = json.ToString();
            this.DayIndex = System.Int32.Parse(s:  json);
        }
        
        if((json.ContainsKey(key:  -1176570832)) == false)
        {
                return;
        }
        
        object val_6 = json.Item[-1176570832];
        string val_7 = json.ToString();
        this.CompletedLevels = System.Int32.Parse(s:  json);
    }
    public System.Collections.Generic.Dictionary<string, object> ToJSON()
    {
        System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile> val_1 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
        Add(key:  -1144798864, value:  13152256);
        Add(key:  -1176570832, value:  13152256);
    }
    public void UpdateDayProgress(int dayIndex, int completedLevels)
    {
        this.DayIndex = dayIndex;
        this.CompletedLevels = completedLevels;
    }
    public OnTheTrailDayProgress()
    {
    
    }

}
