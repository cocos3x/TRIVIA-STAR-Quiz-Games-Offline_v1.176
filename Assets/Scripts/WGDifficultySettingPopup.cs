using UnityEngine;
public class WGDifficultySettingPopup : MonoBehaviour
{
    // Fields
    private DifficultyTapToSelectButton normalModeButton;
    private DifficultyTapToSelectButton difficultModeButton;
    private UnityEngine.UI.Button normalModeSelectButton;
    private UnityEngine.UI.Button difficultModeSelectButton;
    
    // Methods
    private void Awake()
    {
        object val_1 = this.normalModeButton.GetComponent<System.Object>();
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1434438784, method:  new IntPtr(2860479936));
        this.normalModeButton.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -1434438784, method:  new IntPtr(2860489152));
        this.normalModeSelectButton.m_OnClick.AddListener(call:  162246656);
        object val_4 = this.difficultModeButton.GetComponent<System.Object>();
        UnityEngine.Events.UnityAction val_5 = new UnityEngine.Events.UnityAction(object:  -1434438784, method:  new IntPtr(2860494272));
        this.difficultModeButton.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_6 = new UnityEngine.Events.UnityAction(object:  -1434438784, method:  new IntPtr(2860503488));
        this.difficultModeSelectButton.m_OnClick.AddListener(call:  162246656);
    }
    private void OnEnable()
    {
        this.UpdateModeButtons();
    }
    private void OnClick_DifficultyMode(DifficultyMode mode)
    {
        var val_11;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_11 = public static DifficultySettingManager MonoSingleton<DifficultySettingManager>::get_Instance();
        DifficultyMode val_2 = GetMode();
        if(val_11 == mode)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UpdateSetting(mode:  mode);
        this.UpdateModeButtons();
        val_11 = 1152921504885600256;
        MainController val_4 = MainController.instance;
        if(0 != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            MainController val_7 = MainController.instance;
            val_11 = 0;
            public static DifficultySettingManager MonoSingleton<DifficultySettingManager>::get_Instance().__il2cppRuntimeField_C = 3;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1434210112) == 0)
        {
                return;
        }
        
        NotificationCenter val_10 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -1434185088, aName:  -1435255136);
    }
    private void UpdateModeButtons()
    {
        this.normalModeButton.Setup();
        this.difficultModeButton.Setup();
    }
    public WGDifficultySettingPopup()
    {
    
    }
    private void <Awake>b__4_0()
    {
        this.OnClick_DifficultyMode(mode:  0);
    }
    private void <Awake>b__4_1()
    {
        this.OnClick_DifficultyMode(mode:  0);
    }
    private void <Awake>b__4_2()
    {
        this.OnClick_DifficultyMode(mode:  1);
    }
    private void <Awake>b__4_3()
    {
        this.OnClick_DifficultyMode(mode:  1);
    }

}
