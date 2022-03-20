using UnityEngine;
public class WFOLightningLevelsEventHandler : LightningLevelsEventHandler
{
    // Methods
    public override bool ShouldShowInDailyChallenge(bool dailyChallengeState)
    {
        return (bool)dailyChallengeState ^ 1;
    }
    protected override void ShowLightningUI()
    {
        var val_4;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((R6 + 8) != 0)
        {
                val_4 = 1;
        }
        
        public static LightningLevelsUIController MonoSingleton<LightningLevelsUIController>::get_Instance().__il2cppRuntimeField_8 = 0;
        bool val_2 = this.SupportsGoldenApples;
    }
    public override void OnBeforeLevelComplete(int levelsProgressed = 1)
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(PlayingChallenge == true)
        {
                return;
        }
        
        if(this.IsLightningValidAndSuccess() == false)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1181199456) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WGEventButtonProgressLightningLevels val_7 = EventProgressUI;
        if((-1181199456) == 0)
        {
                return;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_9 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        WGEventButtonProgressLightningLevels val_10 = EventProgressUI;
        DoCompleteAnimation();
    }
    protected override void ExecuteLevelCompleteSuccessAction()
    {
    
    }
    public string GetNextLightningEventProgress(bool spaced = False)
    {
        LightingEventProgress val_1 = this.EventProgress;
        if(spaced == true)
        {
                "/" = " / ";
        }
        
        string val_2 = System.String.Format(format:  -1183154368, arg0:  13152256, arg1:  -1316508080, arg2:  13152256);
    }
    public float GetNextEventProgressValue()
    {
        LightingEventProgress val_1 = this.EventProgress;
        float val_2 = (float)R6 + 16;
        val_2 = (-1.172331E+09f) / val_2;
        return (float)val_2;
    }
    public override string GetMainMenuButtonText()
    {
        var val_4;
        var val_6;
        val_4 = this;
        if(35630303 == (R6 + 12))
        {
                if(val_4.IsRewardReadyToCollect() != false)
        {
                return Localization.Localize(key:  -1172243376, defaultValue:  -1172243456, useSingularKey:  false);
        }
        
        }
        
        float val_2 = val_4.GetEventProgressValue();
        if(35630303 > (R6 + 12))
        {
                val_6 = val_4;
        }
    
    }
    public override string GetGameButtonText()
    {
        var val_2;
        System.TimeSpan val_1 = GetLightningElapsed();
        int val_4 = val_2.Minutes;
        int val_5 = val_2.Seconds;
        string val_6 = System.String.Format(format:  -1173714000, arg0:  13152256, arg1:  13152256);
    }
    public override string GetEventDisplayName()
    {
    
    }
    public override string GetLightningEventProgress(bool spaced = False)
    {
        if(spaced == true)
        {
                "/" = " / ";
        }
        
        string val_1 = System.String.Format(format:  -1183154368, arg0:  13152256, arg1:  -1316508080, arg2:  13152256);
    }
    public WFOLightningLevelsEventHandler()
    {
    
    }

}
