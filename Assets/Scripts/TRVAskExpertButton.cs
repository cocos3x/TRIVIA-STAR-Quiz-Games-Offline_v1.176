using UnityEngine;
public class TRVAskExpertButton : TRVPowerupButton
{
    // Fields
    private TRVPowerup _powerup;
    
    // Properties
    public override TRVPowerup powerup { get; }
    
    // Methods
    public override TRVPowerup get_powerup()
    {
        if(this._powerup != 0)
        {
                return;
        }
        
        this._powerup = new TRVPowerup();
        typeof(TRVPowerup).__il2cppRuntimeField_8 = 2;
        WordForest.WFOGameEcon val_2 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        object val_3 = mem[1152921512476916376].Item[this._powerup.type];
        this._powerup.econ = mem[1152921512476916376];
        WordForest.WFOGameEcon val_4 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        this._powerup.econ.cost = mem[1152921512476916240];
        WordForest.WFOGameEcon val_5 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        float val_6 = -1f;
        val_6 = mem[1152921512476916168] + val_6;
        this._powerup.remainingTime = val_6;
    }
    protected override bool IsEligibleToShowInQOTD()
    {
        return false;
    }
    protected override void OnPowerupFailed()
    {
        this.OnPowerupFailed();
    }
    protected override void OnPowerupSuccess()
    {
        GameBehavior val_1 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    protected override bool IsPowerupAvailable()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_2 = IsPlayingChallenge;
        val_2 = val_2 ^ 1;
        return (bool)val_2;
    }
    protected override string GetFtuxText()
    {
        return Localization.Localize(key:  -627257920, defaultValue:  -627258096, useSingularKey:  false);
    }
    public TRVAskExpertButton()
    {
    
    }

}
