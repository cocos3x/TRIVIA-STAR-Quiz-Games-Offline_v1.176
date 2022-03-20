using UnityEngine;
public class WGIncentivizedPopup : WGFreeHintPopup
{
    // Fields
    private UnityEngine.GameObject videoOverlayImage;
    private UnityEngine.GameObject videoNotAvailableText;
    private FrameSkipper skipper;
    private UnityEngine.GameObject watchVideoPopup;
    private UnityEngine.GameObject allIncenvtivesPopup;
    private UGUINetworkedButton FreeHintVideoButton;
    
    // Methods
    protected override void SetUp()
    {
        UnityEngine.GameObject val_1 = this.watchVideoPopup.gameObject;
        this.watchVideoPopup.SetActive(value:  true);
        UnityEngine.GameObject val_2 = this.allIncenvtivesPopup.gameObject;
        this.allIncenvtivesPopup.SetActive(value:  false);
        mem[1152921513175654492] = this.FreeHintVideoButton;
        this.SetUp();
        UnityEngine.GameObject val_3 = this.gameObject;
        UnityEngine.UI.LayoutElement val_4 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  -21127104);
        this.skipper = this;
        mem[1152921513175654484] = 15;
        System.Action val_5 = new System.Action(object:  -21127104, method:  new IntPtr(4273815168));
        this.skipper.updateLogic = null;
    }
    private void CheckUI()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        this.ToggleVideoUI(state:  IsVideoAvailable());
    }
    private void ToggleVideoUI(bool state)
    {
        bool val_1 = state ^ 1;
        this.videoOverlayImage.SetActive(value:  val_1);
        UnityEngine.GameObject val_2 = this.videoOverlayImage.gameObject;
        this.videoOverlayImage.SetActive(value:  state);
        UnityEngine.GameObject val_3 = this.videoNotAvailableText.gameObject;
        this.videoNotAvailableText.SetActive(value:  val_1);
    }
    public override void OnDisable()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  2124183120)) != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            SawFreeHint();
        }
        
        UnityEngine.GameObject val_4 = this.gameObject;
        SLCWindow.CloseWindow(window:  -20758336, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        this.OnDisable();
    }
    public WGIncentivizedPopup()
    {
    
    }

}
