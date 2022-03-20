using UnityEngine;
public class LevelCompleteGoldenApplesUI : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject goldenApplesGroup_difficulty;
    private UnityEngine.UI.Text goldenApplesBonus_difficulty;
    private UnityEngine.UI.Button difficultySettingButton;
    private UnityEngine.GameObject goldenApplesGroup_pets;
    private UnityEngine.UI.Text goldenApplesBonus_pets;
    private UnityEngine.GameObject petFtuxGroup;
    private UnityEngine.UI.Text petFtuxDescription;
    private UnityEngine.UI.Button petFtuxOkButton;
    
    // Methods
    public void Setup()
    {
        this.SetupDifficultySettingUI();
        this.SetupPetsUI();
    }
    private void SetupDifficultySettingUI()
    {
        var val_9;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_9 = 1152921504765685760;
        if((-2101084320) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1436585440) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static DifficultySettingManagerGameplay MonoSingleton<DifficultySettingManagerGameplay>::get_Instance().__il2cppRuntimeField_C) != 0)
        {
                public static DifficultySettingManagerGameplay MonoSingleton<DifficultySettingManagerGameplay>::get_Instance().__il2cppRuntimeField_C = 1;
        }
        
        this.goldenApplesGroup_difficulty.SetActive(value:  true);
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_7 = ToString();
        UnityEngine.Events.UnityAction val_8 = new UnityEngine.Events.UnityAction(object:  -249040544, method:  new IntPtr(4045901728));
        this.difficultySettingButton.m_OnClick.AddListener(call:  162246656);
    }
    private void SetupPetsUI()
    {
        this.goldenApplesGroup_pets.SetActive(value:  false);
        this.petFtuxGroup.SetActive(value:  false);
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1929661328) == 0)
        {
                return;
        }
        
        WADPets.WADPet val_3 = WADPetsManager.GetPetByAbility(ability:  2);
        if(2.IsActive() == false)
        {
                return;
        }
        
        string val_6 = 2 + 28.ToString();
        this.goldenApplesGroup_pets.SetActive(value:  true);
        if(0 != 0)
        {
                return;
        }
        
        mem2[0] = 1;
        System.Collections.IEnumerator val_7 = R4.StartShowingPetFtux(pet:  R5);
        UnityEngine.Coroutine val_8 = R4.StartCoroutine(routine:  R4);
    }
    private System.Collections.IEnumerator StartShowingPetFtux(WADPets.WADPet pet)
    {
        typeof(LevelCompleteGoldenApplesUI.<StartShowingPetFtux>d__11).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(LevelCompleteGoldenApplesUI.<StartShowingPetFtux>d__11).__il2cppRuntimeField_10 = this;
        }
        else
        {
                mem[16] = this;
        }
        
        typeof(LevelCompleteGoldenApplesUI.<StartShowingPetFtux>d__11).__il2cppRuntimeField_14 = pet;
    }
    private void OnClick_DifficultySettingButton()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public LevelCompleteGoldenApplesUI()
    {
    
    }
    private void <StartShowingPetFtux>b__11_0()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Action val_2 = new System.Action(object:  -248421152, method:  new IntPtr(4046521120));
        CloseOverlay(onClosed:  7454720);
    }
    private void <StartShowingPetFtux>b__11_1()
    {
        this.petFtuxGroup.SetActive(value:  false);
    }

}
