using UnityEngine;
public class DifficultySettingUIController_Leagues : MonoSingleton<DifficultySettingUIController_Leagues>
{
    // Fields
    public const string UPDATE_DIFFICULTY_SETTING_ICON = "UpdateDifficultySettingIcon_Leagues";
    private UnityEngine.GameObject difficultySettingGroup;
    private UnityEngine.UI.Image difficultyMeter;
    private UnityEngine.Sprite normalDifficultySp;
    private UnityEngine.Sprite challengingDifficultySp;
    
    // Methods
    public override void InitMonoSingleton()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.difficultySettingGroup)) != false)
        {
                this.difficultySettingGroup.SetActive(value:  false);
        }
        
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -1435230992, name:  -1435255136);
        this.UpdateDifficultySettingUI_Leagues();
    }
    private void UpdateDifficultySettingUI_Leagues()
    {
        Player val_1 = App.Player;
        GameEcon val_2 = App.getGameEcon;
        if(0 < 104)
        {
                return;
        }
        
        this.UpdateDifficultySettingIcon_Leagues();
        this.difficultySettingGroup.SetActive(value:  true);
    }
    private void UpdateDifficultySettingIcon_Leagues()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static DifficultySettingManager MonoSingleton<DifficultySettingManager>::get_Instance().__il2cppRuntimeField_10 + 8) == 0)
        {
                24 = 20;
        }
        
        this.difficultyMeter.sprite = this.normalDifficultySp;
    }
    public DifficultySettingUIController_Leagues()
    {
    
    }

}
