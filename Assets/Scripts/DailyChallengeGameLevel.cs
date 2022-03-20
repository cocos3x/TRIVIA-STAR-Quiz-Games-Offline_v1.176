using UnityEngine;
public class DailyChallengeGameLevel : Progression
{
    // Fields
    private const string pref_max_wd_strk = "dc_max_wd_strk";
    private const string pref_league_pts = "dc_lg_pts_erd";
    private const string pref_current_stars = "DailyChallengeCurrentStars";
    private const string pref_current_points = "DailyChallengeCurrentPoints";
    private const string pref_retry_level = "DailyChallengeRetried";
    private const string pref_ptr_gone = "DailyChallenge_PointerGG";
    private const string pref_ptr_word_index = "DailyChallenge_PointerWordIndex";
    private const string pref_ptr_letter_index = "DailyChallenge_PointerLetterIndex";
    private const string pref_current_word = "DailyChallengeCurrentWord";
    private const string pref_has_started = "DailyChallengeInProgress";
    private const string pref_progress_def_index = "DailyChallengeProgressDefinitionsIndex";
    private const string pref_regular_hints_used = "DailyChallengeHintsUsed";
    private const string pref_picker_hints_used = "DailyChallengePickerHintsUsed";
    private const string pref_time_spent = "DailyChallengeTimeSpent";
    private const string pref_session_stars_starting = "DailyChallengeSessionStarsStarting";
    private const string pref_stars_saved = "DailyChallengeStarsSavedByPet";
    private const string pref_current_tier = "dc_current_tier";
    public bool persistent;
    public GameLevel gameLevel;
    public System.Collections.Generic.List<string> found;
    public int stars;
    public int points;
    public string currentSunMoonWord;
    public int progressDefinitionsIndex;
    public bool isRetryLevel;
    public bool hasStartedPreviously;
    public bool pointerGone;
    public int pointerWordIndex;
    public int pointerLetterIndex;
    public int largestWordStreak;
    public int leaguePointsEarned;
    public int regularHintsUsed;
    public int pickerHintsUsed;
    public int timeSpent;
    public int sessionStarsStarting;
    public bool challengeResumed;
    public int challengeStartTime;
    public int timerBeginCheatSeconds;
    public int sessionLoseFocusStartTime;
    public int sessionLoseFocusTime;
    public int starsSaved;
    public StarTier tier;
    
    // Methods
    public DailyChallengeGameLevel()
    {
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_1 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.found = null;
        this.persistent = true;
        this.starsSaved = 0;
        this.gameLevel = new GameLevel();
        this.stars = 0;
        this.points = 0;
        this.pointerGone = 0;
        this.isRetryLevel = 0;
        this.hasStartedPreviously = false;
        this.progressDefinitionsIndex = 0;
        this.pointerWordIndex = 0;
        this.pointerLetterIndex = 0;
        this.tier = new StarTier();
    }
    public void ResetPointer()
    {
        this.pointerGone = false;
        this.pointerWordIndex = 0;
        this.pointerLetterIndex = 0;
        goto typeof(DailyChallengeGameLevel).__il2cppRuntimeField_E4;
    }
    public override void Load()
    {
        if(this.persistent == false)
        {
                return;
        }
        
        this.stars = UnityEngine.PlayerPrefs.GetInt(key:  -347790960, defaultValue:  0);
        this.points = UnityEngine.PlayerPrefs.GetInt(key:  -347790832, defaultValue:  0);
        this.progressDefinitionsIndex = UnityEngine.PlayerPrefs.GetInt(key:  -347790704, defaultValue:  0);
        int val_4 = UnityEngine.PlayerPrefs.GetInt(key:  -347790560, defaultValue:  0);
        val_4 = val_4 - 1;
        val_4 = val_4 >> 5;
        this.isRetryLevel = val_4;
        int val_5 = UnityEngine.PlayerPrefs.GetInt(key:  -347790448, defaultValue:  0);
        val_5 = val_5 - 1;
        val_5 = val_5 >> 5;
        this.hasStartedPreviously = val_5;
        int val_6 = UnityEngine.PlayerPrefs.GetInt(key:  -347790320, defaultValue:  0);
        val_6 = val_6 - 1;
        val_6 = val_6 >> 5;
        this.pointerGone = val_6;
        this.pointerWordIndex = UnityEngine.PlayerPrefs.GetInt(key:  -347790192, defaultValue:  0);
        this.pointerLetterIndex = UnityEngine.PlayerPrefs.GetInt(key:  -347790048, defaultValue:  0);
        this.largestWordStreak = UnityEngine.PlayerPrefs.GetInt(key:  -347789904, defaultValue:  0);
        this.leaguePointsEarned = UnityEngine.PlayerPrefs.GetInt(key:  -347789808, defaultValue:  0);
        this.regularHintsUsed = UnityEngine.PlayerPrefs.GetInt(key:  -347789712, defaultValue:  0);
        this.pickerHintsUsed = UnityEngine.PlayerPrefs.GetInt(key:  -347789584, defaultValue:  0);
        this.timeSpent = UnityEngine.PlayerPrefs.GetInt(key:  -347789456, defaultValue:  0);
        this.sessionStarsStarting = UnityEngine.PlayerPrefs.GetInt(key:  -347789328, defaultValue:  0);
        this.starsSaved = UnityEngine.PlayerPrefs.GetInt(key:  -347789184, defaultValue:  0);
    }
    public override void Save()
    {
        if(this.persistent == false)
        {
                return;
        }
        
        UnityEngine.PlayerPrefs.SetInt(key:  -347790960, value:  this.stars);
        UnityEngine.PlayerPrefs.SetInt(key:  -347790832, value:  this.points);
        UnityEngine.PlayerPrefs.SetInt(key:  -347790704, value:  this.progressDefinitionsIndex);
        UnityEngine.PlayerPrefs.SetInt(key:  -347790560, value:  this.isRetryLevel);
        UnityEngine.PlayerPrefs.SetInt(key:  -347790448, value:  this.hasStartedPreviously);
        UnityEngine.PlayerPrefs.SetInt(key:  -347790320, value:  this.pointerGone);
        UnityEngine.PlayerPrefs.SetInt(key:  -347790192, value:  this.pointerWordIndex);
        UnityEngine.PlayerPrefs.SetInt(key:  -347790048, value:  this.pointerLetterIndex);
        UnityEngine.PlayerPrefs.SetInt(key:  -347789904, value:  this.largestWordStreak);
        UnityEngine.PlayerPrefs.SetInt(key:  -347789808, value:  this.leaguePointsEarned);
        UnityEngine.PlayerPrefs.SetInt(key:  -347789712, value:  this.regularHintsUsed);
        UnityEngine.PlayerPrefs.SetInt(key:  -347789584, value:  this.pickerHintsUsed);
        UnityEngine.PlayerPrefs.SetInt(key:  -347789456, value:  this.timeSpent);
        UnityEngine.PlayerPrefs.SetInt(key:  -347789328, value:  this.sessionStarsStarting);
        UnityEngine.PlayerPrefs.SetInt(key:  -347789184, value:  this.starsSaved);
        if((System.String.IsNullOrEmpty(value:  this.gameLevel.word)) != true)
        {
                PlayingLevel.SetLevel(currentMode:  2, level:  this.gameLevel, parameters:  0, skipSaving:  false);
        }
        
        bool val_2 = PrefsSerializationManager.SavePlayerPrefs();
    }
    public override void Delete()
    {
        if(this.persistent == false)
        {
                return;
        }
        
        this.DeleteKey(key:  -347790960);
        this.DeleteKey(key:  -347790832);
        this.DeleteKey(key:  -347790704);
        this.DeleteKey(key:  -347790560);
        this.DeleteKey(key:  -347790448);
        this.DeleteKey(key:  -347789904);
        this.DeleteKey(key:  -347789808);
        this.DeleteKey(key:  -347789712);
        this.DeleteKey(key:  -347789584);
        this.DeleteKey(key:  -347789456);
        this.DeleteKey(key:  -347789328);
        this.DeleteKey(key:  -347790320);
        this.DeleteKey(key:  -347790192);
        this.DeleteKey(key:  -347790048);
        this.DeleteKey(key:  -347789184);
    }

}
