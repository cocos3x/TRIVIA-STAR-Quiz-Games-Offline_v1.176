using UnityEngine;
public class WGAdvancedPlayerPopup : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Button CloseBtn;
    private UnityEngine.UI.Button SkipBtn;
    private UnityEngine.UI.Button DeclineBtn;
    
    // Methods
    private void Start()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -124713632, method:  new IntPtr(4170211232));
        this.CloseBtn.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -124713632, method:  new IntPtr(4170211232));
        this.DeclineBtn.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -124713632, method:  new IntPtr(4170228640));
        this.SkipBtn.m_OnClick.AddListener(call:  162246656);
    }
    public void Close()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        SLCWindow.CloseWindow(window:  -124577056, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public void SkipLevels()
    {
        this.SkipBtn.enabled = false;
        Player val_1 = App.Player;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        int val_3 = AdvancedPlayerLevelSkip;
        Player val_4 = App.Player;
        2621448.Save(writePrefs:  true);
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        SkipToLevel(level:  AdvancedPlayerLevelSkip);
        UnityEngine.GameObject val_8 = this.gameObject;
        SLCWindow.CloseWindow(window:  -124460960, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
    }
    public WGAdvancedPlayerPopup()
    {
    
    }

}
