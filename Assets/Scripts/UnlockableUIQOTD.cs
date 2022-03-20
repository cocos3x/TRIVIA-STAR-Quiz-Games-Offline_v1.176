using UnityEngine;
public class UnlockableUIQOTD : WGUnlockableUIElement
{
    // Fields
    private UnityEngine.GameObject indicatorBadge;
    private UGUINetworkedButton button;
    
    // Properties
    protected override int UnlockLevel { get; }
    protected override bool FeatureHidden { get; }
    
    // Methods
    protected override int get_UnlockLevel()
    {
        this.UpdateUI();
        WordForest.WFOGameEcon val_1 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        if(mem[1152921512476916308] != 0)
        {
                return (int)mem[1152921512476916308] + 8;
        }
        
        return (int)mem[1152921512476916308] + 8;
    }
    protected override bool get_FeatureHidden()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_2 = IsFeatureEnabled();
        val_2 = val_2 ^ 1;
        return (bool)val_2;
    }
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        object val_2 = this.GetComponent<System.Object>();
        this.button = this;
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  -440353360, method:  new IntPtr(3854588912));
        this.AddListener(call:  162246656);
    }
    private void OnClick()
    {
        this.Play();
    }
    private void Play()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    private void UpdateUI()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_2 = IsEligible();
        this.button.interactable = val_2;
        this.indicatorBadge.SetActive(value:  val_2);
    }
    public UnlockableUIQOTD()
    {
    
    }

}
