using UnityEngine;
public class ButtonPlayGame : MyButton
{
    // Fields
    protected UnityEngine.UI.Text buttonLabel;
    
    // Methods
    protected override void Start()
    {
        NotificationCenter val_1 = NotificationCenter.DefaultCenter;
        0.AddObserver(observer:  -2116240352, name:  1799422256);
        this.Start();
        this.SetupPlayText();
    }
    private void OnLocalize()
    {
        this.SetupPlayText();
    }
    private void SetupPlayText()
    {
        var val_14;
        UnityEngine.UI.Text val_15;
        if(this.buttonLabel == 0)
        {
            goto label_3;
        }
        
        GameBehavior val_2 = App.getBehavior;
        val_14 = 0;
        val_15 = this.buttonLabel;
        if(val_14 != 1)
        {
            goto label_8;
        }
        
        string val_3 = Localization.Localize(key:  -2116032080, defaultValue:  -2116032160, useSingularKey:  false);
        val_14 = val_15;
        goto typeof(UnityEngine.UI.Text).__il2cppRuntimeField_314;
        label_8:
        string val_4 = Localization.Localize(key:  -2116031904, defaultValue:  -2116031984, useSingularKey:  false);
        decimal val_6 = System.Decimal.op_Implicit(value:  FP - 44);
        decimal val_7 = new System.Decimal(value:  10000);
        var val_8 = FP - 44;
        string val_9 = MetricSystem.Abbreviate(number:  new System.Decimal() {flags = mem[(FP - 44) + (0)], hi = mem[(FP - 44) + (4)], lo = mem[(FP - 44) + (8)], mid = mem[(FP - 44) + (12)]}, maxSigFigs:  2, round:  false, useColor:  false, maxValueWithoutAbbr:  new System.Decimal() {flags = val_7.flags, hi = val_7.hi, lo = val_7.lo, mid = val_7.mid}, useRichText:  false, withSpaces:  false);
        string val_10 = System.String.Format(format:  1592589744, arg0:  -2116031904, arg1:  mem[(FP - 44) + (0)]);
        label_3:
        var val_11 = FP - 28;
    }
    public override void OnButtonClick()
    {
        var val_5;
        var val_6;
        this.OnButtonClick();
        var val_5 = 29039751;
        val_5 = 6587140 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        val_5 = null;
        val_5 = null;
        TRVMainController.noAnswerSelectedCharacter = 0;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2116505760) != 0)
        {
                twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            PlayingChallenge = false;
        }
        
        var val_6 = 29038323;
        val_6 = 6587468 + val_6;
        if(val_6 == 0)
        {
                mem2[0] = 1;
        }
        
        val_6 = null;
        val_6 = null;
        AmplitudePluginHelper.lastFeatureAccessPoint = 4;
        GameBehavior val_4 = App.getBehavior;
        if(0 == 0)
        {
            
        }
    
    }
    public ButtonPlayGame()
    {
    
    }

}
