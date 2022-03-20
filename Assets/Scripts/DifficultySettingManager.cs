using UnityEngine;
public class DifficultySettingManager : MonoSingleton<DifficultySettingManager>
{
    // Fields
    public bool DifficultyChangedOnLevelComplete;
    private DifficultySetting <Setting>k__BackingField;
    
    // Properties
    public static float GetCurrentPointMultiplier { get; }
    public DifficultySetting Setting { get; set; }
    public bool IsPlayingChallengingLevels { get; }
    
    // Methods
    public static float get_GetCurrentPointMultiplier()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2101084320) == 0)
        {
                return (float)S0;
        }
        
        if(DifficultySettingManagerGameplay.IsPlayingDifficultLevel == true)
        {
                0f = 2f;
        }
        
        return 0f;
    }
    public DifficultySetting get_Setting()
    {
    
    }
    private void set_Setting(DifficultySetting value)
    {
        this.<Setting>k__BackingField = value;
    }
    public bool get_IsPlayingChallengingLevels()
    {
        DifficultySetting val_9;
        var val_10;
        GameBehavior val_1 = App.getBehavior;
        val_9 = 0;
        val_10 = 0;
        string val_2 = val_9.GetCurrentLanguage();
        if((System.String.op_Equality(a:  null, b:  1800251696)) == false)
        {
                return true;
        }
        
        val_9 = this.<Setting>k__BackingField;
        if((this.<Setting>k__BackingField.Mode) != 1)
        {
                return true;
        }
        
        val_10 = 1;
        if(CategoryPacksManager.IsPlaying == true)
        {
                return true;
        }
        
        val_10 = 0;
        GameplayMode val_5 = PlayingLevel.CurrentGameplayMode;
        if(0 != 1)
        {
                return true;
        }
        
        val_9 = this.<Setting>k__BackingField;
        if((this.<Setting>k__BackingField.StartingLevel) == 1)
        {
                return true;
        }
        
        Player val_6 = App.Player;
        val_9 = 0;
        val_10 = 0;
        if(val_9 < (this.<Setting>k__BackingField.StartingLevel))
        {
                return true;
        }
        
        Player val_7 = App.Player;
        GameEcon val_8 = App.getGameEcon;
        val_9 = 0;
        if(0 >= 104)
        {
                val_10 = 1;
        }
        
        return true;
    }
    public override void InitMonoSingleton()
    {
        this.<Setting>k__BackingField = new DifficultySetting();
        LoadFromJSON();
    }
    public DifficultyMode GetMode()
    {
        if((this.<Setting>k__BackingField) != 0)
        {
                return;
        }
    
    }
    public void UpdateSetting(DifficultyMode mode)
    {
        Player val_1 = App.Player;
        this.<Setting>k__BackingField.Mode = mode;
        this.<Setting>k__BackingField.StartingLevel = 1;
        this.<Setting>k__BackingField.SaveToJSON();
    }
    public void ShowOnPromptLevel()
    {
        if((this.<Setting>k__BackingField.FeatureStatus.Prompted) == true)
        {
                return;
        }
        
        mem2[0] = 1;
        R4 + 16.SaveToJSON();
        R4 + 16.ShowDifficultySettingPopup();
    }
    public void ShowDifficultySettingPopup_Leagues()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    private void ShowDifficultySettingPopup()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public DifficultySettingManager()
    {
    
    }

}
