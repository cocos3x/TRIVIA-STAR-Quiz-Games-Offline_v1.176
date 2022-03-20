using UnityEngine;
public class DifficultyTapToSelectButton : MonoBehaviour
{
    // Fields
    private DifficultyMode mode;
    private UnityEngine.UI.Button selectButton;
    private UnityEngine.UI.Text selectButtonText;
    private UnityEngine.UI.Image overlayImg;
    private UnityEngine.Sprite selectedSp;
    private UnityEngine.Sprite unselectedSp;
    
    // Methods
    public void Setup()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(this.mode == (public static DifficultySettingManager MonoSingleton<DifficultySettingManager>::get_Instance().__il2cppRuntimeField_10 + 8))
        {
                32 = 28;
        }
        
        this.overlayImg.sprite = this.selectedSp;
        UnityEngine.Color val_2 = new UnityEngine.Color(r:  0.2f = 1f, g:  null, b:  1f, a:  null);
        this.overlayImg.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        this.overlayImg.raycastTarget = true;
        this.selectButton.interactable = true;
        if(this.mode == (public static DifficultySettingManager MonoSingleton<DifficultySettingManager>::get_Instance().__il2cppRuntimeField_10 + 8))
        {
                "TAP TO SELECT" = "SELECTED";
        }
        
        if(this.mode == (public static DifficultySettingManager MonoSingleton<DifficultySettingManager>::get_Instance().__il2cppRuntimeField_10 + 8))
        {
                "tap_to_select_upper" = "selected_upper";
        }
        
        string val_4 = Localization.Localize(key:  -1434744336, defaultValue:  -1434748624, useSingularKey:  false);
        if(this.selectButtonText != 0)
        {
                return;
        }
    
    }
    public DifficultyTapToSelectButton()
    {
    
    }

}
