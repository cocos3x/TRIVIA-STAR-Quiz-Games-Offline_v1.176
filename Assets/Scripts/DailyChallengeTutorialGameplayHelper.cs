using UnityEngine;
public class DailyChallengeTutorialGameplayHelper : MonoSingleton<DailyChallengeTutorialGameplayHelper>
{
    // Fields
    private WGDailyChallengeWordRegion _DCWordRegion;
    private WGDailyChallengeMainController _DCMainController;
    
    // Properties
    private WGDailyChallengeWordRegion DCWordRegion { get; }
    public WGDailyChallengeMainController DCMainController { get; }
    
    // Methods
    private WGDailyChallengeWordRegion get_DCWordRegion()
    {
        WGDailyChallengeWordRegion val_3;
        if(this._DCWordRegion == 0)
        {
                val_3 = 0;
            WordRegion val_2 = WordRegion.instance;
            if(0 != 0)
        {
                if(((mem[1179403747] + (WGDailyChallengeWordRegion.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                0 = 0;
        }
        
            val_3 = 0;
        }
        
            this._DCWordRegion = val_3;
            return;
        }
        
        val_3 = this._DCWordRegion;
    }
    public WGDailyChallengeMainController get_DCMainController()
    {
        WGDailyChallengeMainController val_3;
        if(this._DCMainController == 0)
        {
                val_3 = 0;
            MainController val_2 = MainController.instance;
            if(0 != 0)
        {
                if(((mem[1179403747] + (WGDailyChallengeMainController.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != null)
        {
                0 = 0;
        }
        
            val_3 = 0;
        }
        
            this._DCMainController = val_3;
            return;
        }
        
        val_3 = this._DCMainController;
    }
    public void ShowFirstWord()
    {
        System.Collections.IEnumerator val_1 = this.wait_ShowFTUX();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  -1447381216);
    }
    public void HandleGameplayTutorialComplete()
    {
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        public static DailyChallengeTutorialManager MonoSingleton<DailyChallengeTutorialManager>::get_Instance().__il2cppRuntimeField_D = 0;
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        0.PostNotification(aSender:  -1447269104, aName:  -1447293216);
    }
    private System.Collections.IEnumerator wait_ShowFTUX()
    {
        object val_1 = new System.Object();
        typeof(DailyChallengeTutorialGameplayHelper.<wait_ShowFTUX>d__8).__il2cppRuntimeField_8 = 0;
    }
    public DailyChallengeTutorialGameplayHelper()
    {
    
    }

}
