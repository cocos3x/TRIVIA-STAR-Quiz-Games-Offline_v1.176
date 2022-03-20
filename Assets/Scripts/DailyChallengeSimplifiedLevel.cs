using UnityEngine;
public class DailyChallengeSimplifiedLevel : DailyChallengeBasicLevel
{
    // Fields
    private const string pref_morning_finished = "DailyChallengeMorningFinished";
    private const string pref_evening_finished = "DailyChallengeEveningFinished";
    private const string pref_morning_stars = "DailyChallengemMorningStars";
    private const string pref_evening_stars = "DailyChallengeEveningStars";
    public bool done;
    
    // Methods
    public DailyChallengeSimplifiedLevel(bool isMorning)
    {
        this = new Progression();
        this.done = false;
        mem[1152921512848342108] = isMorning;
    }
    public override void Load()
    {
        if(true == 0)
        {
                "DailyChallengemMorningStars" = "DailyChallengeEveningStars";
        }
        
        int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  -348351472, defaultValue:  0);
        mem[1152921512848454616] = val_1;
        if(val_1 == 0)
        {
                "DailyChallengeMorningFinished" = "DailyChallengeEveningFinished";
        }
        
        int val_2 = UnityEngine.PlayerPrefs.GetInt(key:  -348351216, defaultValue:  0);
        val_2 = val_2 - 1;
        val_2 = val_2 >> 5;
        this.done = val_2;
    }
    public override void Save()
    {
        if(true == 0)
        {
                "DailyChallengemMorningStars" = "DailyChallengeEveningStars";
        }
        
        UnityEngine.PlayerPrefs.SetInt(key:  -348351472, value:  0);
        if("DailyChallengeEveningStars" == 0)
        {
                "DailyChallengeMorningFinished" = "DailyChallengeEveningFinished";
        }
        
        UnityEngine.PlayerPrefs.SetInt(key:  -348351216, value:  this.done);
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public override void Delete()
    {
        this.DeleteKey(key:  -348351088);
        this.DeleteKey(key:  -348351216);
        this.DeleteKey(key:  -348351344);
        this.DeleteKey(key:  -348351472);
    }

}
