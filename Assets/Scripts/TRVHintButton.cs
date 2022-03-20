using UnityEngine;
public class TRVHintButton : TRVPowerupButton
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
        
        this._powerup = new TRVPowerup();
        typeof(TRVPowerup).__il2cppRuntimeField_8 = 0;
        WordForest.WFOGameEcon val_2 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        object val_3 = mem[1152921512476916376].Item[this._powerup.type];
        this._powerup.econ = mem[1152921512476916376];
        WordForest.WFOGameEcon val_4 = App.GetGameSepeciticEcon<WordForest.WFOGameEcon>();
        float val_5 = -1f;
        val_5 = mem[1152921512476916168] + val_5;
        this._powerup.remainingTime = val_5;
    }
    private void Awake()
    {
        if(this._powerup != 0)
        {
                return;
        }
        
        this._powerup = new TRVPowerup();
        typeof(TRVPowerup).__il2cppRuntimeField_8 = 0;
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
    protected override void OnPowerupFailed()
    {
        this.OnPowerupFailed();
    }
    protected override void OnPowerupSuccess()
    {
        var val_3;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_3 = 0;
        bool val_2 = this.IsFreeCost();
        RemoveTwo(cost:  -518168400, remainingTime:  null);
    }
    protected override string GetFtuxText()
    {
        return Localization.Localize(key:  -518080240, defaultValue:  -518080400, useSingularKey:  false);
    }
    protected override void SetupButtonUI()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        bool val_2 = IsPlaying();
        if(val_2 == true)
        {
                val_2 = this;
            this.AdjustButtonPosition();
        }
        
        this.SetupButtonUI();
    }
    private void AdjustButtonPosition()
    {
        UnityEngine.Transform val_1 = this.transform;
        object val_2 = this.GetComponent<System.Object>();
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        this.localPosition = new UnityEngine.Vector3();
    }
    public TRVHintButton()
    {
    
    }

}
