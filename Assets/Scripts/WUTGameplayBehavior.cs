using UnityEngine;
public class WUTGameplayBehavior : GameplayBehavior
{
    // Methods
    public override bool SupportsHintTutorials()
    {
        return true;
    }
    public override void OnClick_UseHint()
    {
        bool val_1 = WGHintButtonDemoPopup.IsShowing;
        WordRegion val_2 = WordRegion.instance;
        if(this.DemoPopupEnabled() == false)
        {
                return;
        }
        
        WordRegion val_4 = WordRegion.instance;
        0.OnHintDemoDisable();
    }
    public override void OnClick_UseMegaHint()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        OnMegaHintPressed(freeHint:  true);
        WordRegion val_2 = WordRegion.instance;
        0.OnHintDemoDisable();
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        ToggleDarkener(state:  true, animated:  false, duration:  null);
        Player val_4 = App.Player;
        2621448.Save(writePrefs:  true);
    }
    public override void OnClick_UsePickerHint()
    {
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        OnHintPickButtonClicked(free:  WGHintPickerDemoPopup.IsShowing);
        if(this.DemoPopupEnabled() == false)
        {
                return;
        }
        
        WordRegion val_4 = WordRegion.instance;
        0.OnHintDemoDisable();
    }
    public override bool SupportsPickerHint()
    {
        return true;
    }
    public override bool SupportsMegaHint()
    {
        return false;
    }
    public override bool IsPickerHintActivated()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-2080453920) == 0)
        {
                return false;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        return public static HintPickerController MonoSingleton<HintPickerController>::get_Instance().__il2cppRuntimeField_C.activeInHierarchy;
    }
    public override int GetWordPanRadius(int numTile = 0)
    {
        if(numTile < 4)
        {
                return 250;
        }
        
        int val_1 = this.GetWordPanRadius(numTile:  0);
        float val_3 = ((float)numTile - 3) * 0.25f;
        return UnityEngine.Mathf.FloorToInt(f:  UnityEngine.Mathf.Lerp(a:  0.25f, b:  null, t:  (float)numTile - 3));
    }
    public override float LineWordCellGap()
    {
        return (float)S0;
    }
    public override string StoreBonusAmountText(decimal rawPercent)
    {
        string val_1 = Localization.Localize(key:  -714485424, defaultValue:  -714485520, useSingularKey:  false);
        decimal val_2 = new System.Decimal(value:  100);
        decimal val_3 = System.Decimal.op_Multiply(d1:  new System.Decimal() {flags = -697984904, hi = rawPercent.flags, lo = rawPercent.hi, mid = rawPercent.lo}, d2:  new System.Decimal() {flags = rawPercent.mid, hi = val_2.flags, lo = val_2.hi, mid = val_2.lo});
        decimal val_5 = System.Math.Round(d:  new System.Decimal() {flags = -697984920});
        string val_6 = val_2.flags.ToString();
        string val_7 = System.String.Format(format:  -714485424, arg0:  -697984888);
    }
    public override string InfinityText()
    {
        string val_1 = Localization.Localize(key:  -2101083296, defaultValue:  -2101083200, useSingularKey:  false);
        return System.String.Format(format:  -2101083296, arg0:  -697884816);
    }
    public override string GetExtraReqWordsInfo()
    {
        return WordRegion.Debug_GetExtraRequiredWordsInfo();
    }
    public override string GetCurrentLevelPlayerPrefKey()
    {
    
    }
    public override string GetExtraRequiredWordsPrefKey_NormalGameplay()
    {
    
    }
    public WUTGameplayBehavior()
    {
    
    }

}
