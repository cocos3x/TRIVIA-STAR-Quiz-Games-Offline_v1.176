using UnityEngine;
public class DailyChallengeProgress : Progression
{
    // Fields
    public double oa_date;
    public DailyChallengeGameLevel currentLevel;
    public DailyChallengeSimplifiedLevel morningChallenge;
    public DailyChallengeSimplifiedLevel eveningChallenge;
    
    // Methods
    public DailyChallengeProgress()
    {
        this.currentLevel = new DailyChallengeGameLevel();
        typeof(DailyChallengeSimplifiedLevel).__il2cppRuntimeField_C = 1;
        this.morningChallenge = new Progression();
        typeof(DailyChallengeSimplifiedLevel).__il2cppRuntimeField_C = 0;
        this.eveningChallenge = new Progression();
        this.currentLevel = new DailyChallengeGameLevel();
    }
    public override void Load()
    {
        if(this.currentLevel == 0)
        {
            
        }
    
    }
    public override void Save()
    {
        bool val_1 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public override void Delete()
    {
        if(this.currentLevel == 0)
        {
            
        }
    
    }

}
