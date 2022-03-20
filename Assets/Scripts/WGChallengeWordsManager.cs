using UnityEngine;
public class WGChallengeWordsManager : MonoSingleton<WGChallengeWordsManager>
{
    // Fields
    private const string HAS_SHOW_CHALLEHGE_FTU_KEY = "Has_Show_Challenge_FTUX_Key";
    public WGChallengeWordsManager.ChallengeWordsProgress progress;
    private bool <hasShowChallengeFTUX>k__BackingField;
    private bool <QAHACK_forceThisLevel>k__BackingField;
    public string QAHACK_lastLoadedLevelChallengeword;
    private bool <IsChallengeLevel>k__BackingField;
    
    // Properties
    public bool hasShowChallengeFTUX { get; set; }
    public bool QAHACK_forceThisLevel { get; set; }
    public int QAHACK_getProgressLevel { get; }
    public static bool IsFeatureUnlocked { get; }
    public bool IsPlaying { get; }
    public bool IsChallengeLevel { get; set; }
    
    // Methods
    public bool get_hasShowChallengeFTUX()
    {
        return (bool)this.<hasShowChallengeFTUX>k__BackingField;
    }
    private void set_hasShowChallengeFTUX(bool value)
    {
        this.<hasShowChallengeFTUX>k__BackingField = value;
    }
    public bool get_QAHACK_forceThisLevel()
    {
        return (bool)this.<QAHACK_forceThisLevel>k__BackingField;
    }
    public void set_QAHACK_forceThisLevel(bool value)
    {
        this.<QAHACK_forceThisLevel>k__BackingField = value;
    }
    public int get_QAHACK_getProgressLevel()
    {
        if(this.progress.inited == false)
        {
                this.progress.inited = this.progress;
            this.progress.inited.InitProgress();
        }
        
        return (int)this.progress._level;
    }
    public static bool get_IsFeatureUnlocked()
    {
        Player val_1 = App.Player;
        GameEcon val_2 = App.getGameEcon;
        return GameEcon.IsEnabledAndLevelMet(playerLevel:  0, knobValue:  796);
    }
    public bool get_IsPlaying()
    {
        if(this.progress.inited == false)
        {
                this.progress.inited = this.progress;
            this.progress.inited.InitProgress();
        }
        
        Player val_1 = App.Player;
        if(this.progress._level != 0)
        {
                if((this.<QAHACK_forceThisLevel>k__BackingField) == false)
        {
                return false;
        }
        
        }
        
        if(this.progress.inited == false)
        {
                this.progress.inited = this.progress;
            this.progress.inited.InitProgress();
        }
        
        if(this.progress._wordIndex != 1)
        {
                this.progress._wordIndex + 1 = 1;
        }
        
        return true;
    }
    public bool get_IsChallengeLevel()
    {
        return (bool)this.<IsChallengeLevel>k__BackingField;
    }
    private void set_IsChallengeLevel(bool value)
    {
        this.<IsChallengeLevel>k__BackingField = value;
    }
    public override void InitMonoSingleton()
    {
        this.<IsChallengeLevel>k__BackingField = false;
        int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  -1478987008, defaultValue:  0);
        if(val_1 != 0)
        {
                val_1 = 1;
        }
        
        this.<hasShowChallengeFTUX>k__BackingField = true;
        this.CheckProgressLevel();
    }
    public void OnLevelLoaded(GameLevel gameLevel)
    {
        this.CheckIfChallengeLevel();
        if((this.<IsChallengeLevel>k__BackingField) == false)
        {
                return;
        }
        
        this.SetProgressWordIndex(challengeWord:  gameLevel.challengeWord);
    }
    public void ProgressLevelToNext()
    {
        if(this.progress.inited == false)
        {
                this.progress.inited = this.progress;
            this.progress.inited.InitProgress();
        }
        
        int val_1 = this.progress._level;
        val_1 = val_1 + 1;
        this.progress._level = val_1;
        this.progress.SaveProgress();
        this.progress._wordIndex = 0;
        this.progress.SaveProgress();
    }
    public void CompleteChallenge()
    {
        Player val_1 = App.Player;
        GameEcon val_2 = App.getGameEcon;
        this.progress._level = 32290913 + 0;
        this.progress.SaveProgress();
        this.progress._wordIndex = 0;
        this.progress.SaveProgress();
    }
    public void FinishFTUX()
    {
        this.<hasShowChallengeFTUX>k__BackingField = true;
        UnityEngine.PlayerPrefs.SetInt(key:  -1478987008, value:  1);
    }
    public void OnLevelComplete()
    {
        this.<IsChallengeLevel>k__BackingField = false;
    }
    private void CheckProgressLevel()
    {
        if(WGChallengeWordsManager.IsFeatureUnlocked == false)
        {
                return;
        }
        
        Player val_2 = App.Player;
        if(this.progress.inited == false)
        {
                this.progress.inited = this.progress;
            this.progress.inited.InitProgress();
        }
        
        if(0 <= this.progress._level)
        {
                return;
        }
        
        Player val_3 = App.Player;
        this.progress._level = 0;
        this.progress.SaveProgress();
        this.progress._wordIndex = 0;
        this.progress.SaveProgress();
    }
    private void CheckIfChallengeLevel()
    {
        this.CheckProgressLevel();
        this.<IsChallengeLevel>k__BackingField = false;
        if((this.<QAHACK_forceThisLevel>k__BackingField) == false)
        {
            goto label_1;
        }
        
        label_9:
        this.<IsChallengeLevel>k__BackingField = true;
        return;
        label_1:
        if(this.progress.inited == false)
        {
                this.progress.inited = this.progress;
            this.progress.inited.InitProgress();
        }
        
        Player val_1 = App.Player;
        if(this.progress._level != 0)
        {
                return;
        }
        
        if(this.progress.inited == false)
        {
                this.progress.inited = this.progress;
            this.progress.inited.InitProgress();
        }
        
        if((this.progress._wordIndex != 1) || ((this.<hasShowChallengeFTUX>k__BackingField) == false))
        {
            goto label_9;
        }
        
        int val_2 = UnityEngine.Random.Range(min:  0, max:  100);
        GameEcon val_3 = App.getGameEcon;
        if(val_2 <= 12)
        {
                0 = 1;
        }
        
        this.<IsChallengeLevel>k__BackingField = true;
        if(val_2 <= 12)
        {
                return;
        }
        
        this.ProgressLevelToNext();
    }
    private void SetProgressWordIndex(string challengeWord)
    {
        string val_4;
        int val_5;
        val_4 = challengeWord;
        this.progress._wordIndex = 0;
        this.progress.SaveProgress();
        val_5 = 0;
        WordRegion val_1 = WordRegion.instance;
        if(0 != 0)
        {
            goto label_5;
        }
        
        goto label_5;
        label_11:
        if(0 <= val_5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_4 = 0;
        val_4 = val_4 + 0;
        if((System.String.op_Equality(a:  (0 + 0) + 16 + 12, b:  val_4)) != false)
        {
                this.progress._wordIndex = val_5;
            this.progress.SaveProgress();
        }
        
        val_5 = 1;
        label_5:
        if(val_5 < 0)
        {
            goto label_11;
        }
        
        if(this.progress.inited == false)
        {
                this.progress.inited = this.progress;
            this.progress.inited.InitProgress();
        }
        
        if(this.progress._wordIndex == 1)
        {
                this.<IsChallengeLevel>k__BackingField = false;
            string val_3 = System.String.Format(format:  -1477984384, arg0:  val_4);
            val_4 = "level does not contain: {0}";
        }
        
        this.QAHACK_lastLoadedLevelChallengeword = val_4;
    }
    public void Hack_OnLevelChanged()
    {
        this.progress._level = 0;
        this.progress.SaveProgress();
    }
    public WGChallengeWordsManager()
    {
        typeof(WGChallengeWordsManager.ChallengeWordsProgress).__il2cppRuntimeField_C = 0;
        object val_1 = new System.Object();
        this.progress = null;
        this.QAHACK_lastLoadedLevelChallengeword = "";
    }

}
