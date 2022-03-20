using UnityEngine;
public class WordDropUIController : MonoSingleton<WordDropUIController>
{
    // Fields
    private UnityEngine.Canvas canvas;
    private UnityEngine.Canvas pauseCanvas;
    private UnityEngine.GameObject blur;
    private BlurCanvas blurCanvas;
    private UnityEngine.UI.Button pauseButton;
    private UnityEngine.UI.Button resumeButton;
    private UnityEngine.UI.Button quitButton;
    private SLC.Minigames.MinigameLivesDisplay minigameLivesDisplay;
    private UnityEngine.UI.Text scoopsDisplay;
    private InputEventsHandler inputEventsHandler;
    
    // Properties
    public InputEventsHandler GetInputEventsHandler { get; }
    
    // Methods
    public InputEventsHandler get_GetInputEventsHandler()
    {
    
    }
    private void Start()
    {
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -1735589488, method:  new IntPtr(2559330160));
        this.pauseButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  -1735589488, method:  new IntPtr(2559339376));
        this.resumeButton.m_OnClick.AddListener(call:  162246656);
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -1735589488, method:  new IntPtr(2559348592));
        this.quitButton.m_OnClick.AddListener(call:  162246656);
        if(this.scoopsDisplay == 0)
        {
            
        }
    
    }
    public void UpdateLivesDisplay(int updatedLives)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UpdateUI();
        this.minigameLivesDisplay.UpdateLivesDisplay(currentHearts:  updatedLives);
    }
    public void UpdateScoopsDisplay(int updatedScoops)
    {
        string val_1 = updatedScoops.ToString();
        string val_2 = -1735348528(-1735348528) + -1735336452(-1735336452);
        if(this.scoopsDisplay != 0)
        {
                return;
        }
    
    }
    private void OnClick_Pause()
    {
        this.blur.SetActive(value:  true);
        this.blurCanvas.DoBlur();
        this.pauseCanvas.enabled = true;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WordDropManager MonoSingleton<WordDropManager>::get_Instance().__il2cppRuntimeField_2D = (public static WordDropManager MonoSingleton<WordDropManager>::get_Instance().__il2cppRuntimeField_2D ^ 1);
    }
    private void OnClick_Resume()
    {
        this.blur.SetActive(value:  false);
        this.blurCanvas.StopBlur();
        this.pauseCanvas.enabled = false;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static WordDropManager MonoSingleton<WordDropManager>::get_Instance().__il2cppRuntimeField_2D = (public static WordDropManager MonoSingleton<WordDropManager>::get_Instance().__il2cppRuntimeField_2D ^ 1);
    }
    private void OnClick_Quit()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        HandleHomeClicked(redirectToGameplay:  false);
    }
    public void ToggleUI(bool show)
    {
        this.canvas.enabled = show;
    }
    public WordDropUIController()
    {
    
    }

}
