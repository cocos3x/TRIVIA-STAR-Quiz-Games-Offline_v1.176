using UnityEngine;
public class TRVRerollQuestionButton : TRVPowerupButton
{
    // Fields
    private TRVPowerup _powerup;
    
    // Properties
    public override TRVPowerup powerup { get; }
    protected override string pref_ftux_shown_key { get; }
    
    // Methods
    public override TRVPowerup get_powerup()
    {
        if(this._powerup != 0)
        {
                return;
        }
        
        this._powerup = new System.Object();
        typeof(TRVPowerup).__il2cppRuntimeField_8 = 1;
        WordForest.WFOGameEcon val_2 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        object val_3 = mem[1152921512476916376].Item[this._powerup.type];
        this._powerup.econ = mem[1152921512476916376];
        WordForest.WFOGameEcon val_4 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        float val_5 = -1f;
        val_5 = mem[1152921512476916168] + val_5;
        this._powerup.remainingTime = val_5;
    }
    protected override string get_pref_ftux_shown_key()
    {
    
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
        var val_3;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_2 = this.IsFreeCost();
        val_3 = 0;
        RerollQuestion(cost:  -447897472, remainingTime:  null);
    }
    protected override bool IsPowerupAvailable()
    {
        var val_5;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_5 = 0;
        if(IsPlayingChallenge == true)
        {
                return (bool)val_5;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_5 = (public static TRVMainController MonoSingleton<TRVMainController>::get_Instance().__il2cppRuntimeField_C + 16 + 49) >> 5;
        return (bool)val_5;
    }
    protected override string GetFtuxText()
    {
        return Localization.Localize(key:  -447697296, defaultValue:  -447697472, useSingularKey:  false);
    }
    public TRVRerollQuestionButton()
    {
        val_1 = new MyButton();
    }

}
