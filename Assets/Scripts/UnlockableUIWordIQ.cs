using UnityEngine;
public class UnlockableUIWordIQ : WGUnlockableUIElement
{
    // Fields
    private UnityEngine.UI.Text wordIQText;
    private UnityEngine.UI.Button infoButton;
    
    // Properties
    protected override bool FeatureHidden { get; }
    protected override int UnlockLevel { get; }
    
    // Methods
    protected override void Start()
    {
        this.Start();
        UnityEngine.Events.UnityAction val_1 = new UnityEngine.Events.UnityAction(object:  -154615104, method:  new IntPtr(4140327168));
        this.infoButton.m_OnClick.AddListener(call:  162246656);
    }
    protected override bool get_FeatureHidden()
    {
        Player val_1 = App.Player;
        GameEcon val_2 = App.getGameEcon;
        if(0 < 0)
        {
                0 = 1;
        }
        
        return true;
    }
    protected override int get_UnlockLevel()
    {
        return 0;
    }
    protected override void SetNewState(WGUnlockableUIElement.UiLockedState newState)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        string val_3 = WordIQManagerUI.FormatPoints(iqPoints:  PlayerIQ);
        string val_4 = System.String.Format(format:  -154286720, arg0:  -933718832);
        if(this.wordIQText == 0)
        {
            
        }
    
    }
    protected override void OnClickUnlocked()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    private void InfoButtonClicked()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_2 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }
    public UnlockableUIWordIQ()
    {
    
    }

}
