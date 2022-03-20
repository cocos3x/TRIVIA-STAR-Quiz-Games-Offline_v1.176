using UnityEngine;
public class FreeHintTrialHandler : HintFeatureHandler
{
    // Properties
    public override bool freeHintEligable { get; }
    public override bool hasFreeHintsRemaining { get; }
    
    // Methods
    public override bool get_freeHintEligable()
    {
        var val_9;
        var val_10;
        GameBehavior val_1 = App.getBehavior;
        val_9 = 0;
        if(0 == 0)
        {
                return true;
        }
        
        val_10 = 1152921511080275808;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_9 = 0;
        if((-2116505760) == 0)
        {
                return true;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_9 = 0;
        if(PlayingChallenge == true)
        {
                return true;
        }
        
        val_9 = 0;
        GameEcon val_6 = App.getGameEcon;
        if(812 < 0)
        {
                return true;
        }
        
        Player val_7 = App.Player;
        GameEcon val_8 = App.getGameEcon;
        val_10 = 0;
        if(0 < 812)
        {
                val_9 = 1;
        }
        
        return true;
    }
    public override void DoButtonStartBehavior(WGHintButton hButton)
    {
        System.Collections.IEnumerator val_1 = this.WaitThenShowPopup(hButton:  hButton);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -1416542432);
    }
    private System.Collections.IEnumerator WaitThenShowPopup(WGHintButton hButton)
    {
        object val_1 = new System.Object();
        typeof(FreeHintTrialHandler.<WaitThenShowPopup>d__3).__il2cppRuntimeField_8 = 0;
        typeof(FreeHintTrialHandler.<WaitThenShowPopup>d__3).__il2cppRuntimeField_10 = hButton;
    }
    public override bool get_hasFreeHintsRemaining()
    {
        return true;
    }
    public override void OnMyFreeHintUsed()
    {
        MainController val_1 = MainController.instance;
        var val_2 = 0 + 1;
        goto mem[1179403955];
    }
    public override void OnHintUsed(bool freeHint)
    {
    
    }
    public FreeHintTrialHandler()
    {
    
    }

}
