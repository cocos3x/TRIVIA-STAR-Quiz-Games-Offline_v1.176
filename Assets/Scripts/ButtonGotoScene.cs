using UnityEngine;
public class ButtonGotoScene : MyButton
{
    // Fields
    public SceneType sceneIndex;
    public AmplitudePluginHelper.FeatureAccessPoints accessPoint;
    public bool abortDailyChallenge;
    
    // Methods
    public override void OnButtonClick()
    {
        var val_5;
        this.OnButtonClick();
        if(this.abortDailyChallenge != false)
        {
                twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            if((-2116505760) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayingChallenge = false;
        }
        
        }
        
        var val_5 = 29040543;
        val_5 = 6585248 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = this.accessPoint;
        GameBehavior val_4 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public ButtonGotoScene()
    {
        this.accessPoint = 4;
    }

}
