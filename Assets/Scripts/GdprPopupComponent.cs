using UnityEngine;
public class GdprPopupComponent : AppComponent
{
    // Properties
    public override bool RunInMainThread { get; }
    
    // Methods
    public override bool get_RunInMainThread()
    {
        return true;
    }
    public GdprPopupComponent(string gameName, string gameObjectName)
    {
        mem[1152921511245442720] = "GdprPopupComponent";
    }
    public override void initializeOnMainThread()
    {
    
    }
    public override void onInitialServerUpdate()
    {
        this.ShowGdprPopup();
    }
    public override void onServerUpdate()
    {
        this.ShowGdprPopup();
    }
    private void ShowGdprPopup()
    {
        Player val_1 = App.Player;
        if(2621448.ShouldShowGdprConsent() == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_4 = ShowUGUIMonolith<System.Object>(showNext:  false);
    }

}
