using UnityEngine;
public class DifficultySettingUIController_Game : MonoSingleton<DifficultySettingUIController_Game>
{
    // Fields
    private UnityEngine.GameObject tooltip;
    
    // Methods
    public void ShowTooltip()
    {
        this.tooltip.SetActive(value:  true);
    }
    public DifficultySettingUIController_Game()
    {
    
    }

}
