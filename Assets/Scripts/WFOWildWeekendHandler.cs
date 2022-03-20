using UnityEngine;
public class WFOWildWeekendHandler : WildWeekendHandler
{
    // Properties
    public override bool IsAvailable { get; }
    
    // Methods
    public override bool get_IsAvailable()
    {
        var val_7 = 0;
        if(true == 0)
        {
                return true;
        }
        
        val_7 = 0;
        bool val_1 = this.HasCollected();
        if(val_1 == true)
        {
                return true;
        }
        
        if(val_1 == false)
        {
                return true;
        }
        
        val_1 = val_1 + 32;
        val_7 = 0;
        double val_2 = val_1.ToOADate();
        System.DateTime val_3 = DateTimeCheat.UtcNow;
        double val_4 = ???.ToOADate();
        Player val_5 = App.Player;
        WordForest.WFOGameEcon val_6 = WordForest.WFOGameEcon.Instance;
        if(0 >= 786450)
        {
                val_7 = 1;
        }
        
        return true;
    }
    public override string GetMainMenuButtonText()
    {
        if(this.CheckComplete() != false)
        {
                string val_2 = Localization.Localize(key:  -1285036736, defaultValue:  -1285036816, useSingularKey:  false);
            return;
        }
        
        if(this.GetLevelsComplete() == 0)
        {
                return;
        }
        
        string val_5 = this.GetLevelsComplete().ToString();
        string val_7 = this.GetLevelsTotal().ToString();
        string val_8 = System.String.Format(format:  1629069648, arg0:  -1285024572, arg1:  -1285024572);
    }
    public override bool ShowEventUI(EventButtonPanel.LayoutType layoutType, EventButtonPanel.DisplayContext context)
    {
        if(layoutType == 1)
        {
                return (bool)0;
        }
        
        0 = 1152921511911889217;
        return (bool)0;
    }
    public override System.Collections.IEnumerator DoLevelCompleteEventProgressAnimation(WGEventButtonV2 eventButton, WGEventButtonV2 eventProgressUI, WGLevelClearPopup popup)
    {
        typeof(WFOWildWeekendHandler.<DoLevelCompleteEventProgressAnimation>d__4).__il2cppRuntimeField_8 = 0;
        if(new System.Object() != 0)
        {
                typeof(WFOWildWeekendHandler.<DoLevelCompleteEventProgressAnimation>d__4).__il2cppRuntimeField_14 = this;
        }
        else
        {
                mem[20] = this;
        }
        
        typeof(WFOWildWeekendHandler.<DoLevelCompleteEventProgressAnimation>d__4).__il2cppRuntimeField_10 = eventButton;
    }
    public void ShowWildWordProgressInGamePopup()
    {
        GameBehavior val_1 = App.getBehavior;
        0.SetUp(handler:  -1284634560, onCLoseCallback:  0);
    }
    protected override void SetupAndShowPopup()
    {
        var val_16;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_1C) != 0)
        {
                GameBehavior val_3 = App.getBehavior;
            val_16 = 0;
        }
        else
        {
                twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
            val_16 = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
            object val_6 = ShowUGUIMonolith<System.Object>(showNext:  false);
        }
        
        int val_7 = this.GetLevelsComplete();
        int val_8 = this.GetLevelsTotal();
        bool val_9 = this.HasCollected();
        GameEventRewardType val_10 = this.getRewardType();
        System.DateTime val_11 = GetEndDate();
        System.Action val_12 = new System.Action(object:  -1284520512, method:  typeof(WFOWildWeekendHandler).__il2cppRuntimeField_248);
        System.Action val_13 = new System.Action(object:  -1284520512, method:  typeof(WFOWildWeekendHandler).__il2cppRuntimeField_250);
        if(val_16 != 0)
        {
                return;
        }
    
    }
    public WFOWildWeekendHandler()
    {
    
    }

}
