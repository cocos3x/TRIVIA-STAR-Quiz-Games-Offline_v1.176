using UnityEngine;
public class WGEventButtonProgressRaidMadness : WGEventButtonProgress
{
    // Properties
    private int PointsCollectedForCurrentLevel { get; }
    
    // Methods
    private int get_PointsCollectedForCurrentLevel()
    {
    
    }
    public override void Initialize(WGEventHandler handler)
    {
        mem[1152921512875758532] = handler;
        goto typeof(WGEventButtonProgressRaidMadness).__il2cppRuntimeField_EC;
    }
    public override void ShowIntroAnimation()
    {
        if(this.PointsCollectedForCurrentLevel < 1)
        {
                return;
        }
        
        this.ShowIntroAnimation();
    }
    public override void Refresh()
    {
        var val_6 = this;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((-1173831120) == 0)
        {
                if(WFOEventPointGainAnimationV2.IsActive == false)
        {
            goto label_6;
        }
        
        }
        
        label_13:
        alpha = null;
        if((public static WordForest.WFOMysteryChestDisplay MonoSingleton<WordForest.WFOMysteryChestDisplay>::get_Instance()) != 0)
        {
                float val_3 = alpha;
        }
        else
        {
                float val_4 = 0.alpha;
        }
        
        if((public static WordForest.WFOMysteryChestDisplay MonoSingleton<WordForest.WFOMysteryChestDisplay>::get_Instance()) >= 0)
        {
                0 = 1;
        }
        
        interactable = true;
        if((public static WordForest.WFOMysteryChestDisplay MonoSingleton<WordForest.WFOMysteryChestDisplay>::get_Instance()) != 0)
        {
            goto as. 
           
           
          
        
        
        
        .__il2cppRuntimeField_314;
        }
        
        goto as. 
           
           
          
        
        
        
        .__il2cppRuntimeField_314;
        label_6:
        if(R4.PointsCollectedForCurrentLevel > 0)
        {
                0f = 1f;
        }
        
        if((R4 + 12) != 0)
        {
            goto label_13;
        }
        
        goto label_13;
    }
    public WGEventButtonProgressRaidMadness()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
