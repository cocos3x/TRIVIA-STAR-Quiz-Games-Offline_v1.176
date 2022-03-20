using UnityEngine;
public class WGEventButtonProgressAttackMadness : WGEventButtonProgress
{
    // Properties
    private int PointsCollectedForCurrentLevel { get; }
    
    // Methods
    private int get_PointsCollectedForCurrentLevel()
    {
        GameplayMode val_1 = PlayingLevel.CurrentGameplayMode;
        return EnumerableExtentions.GetOrDefault<System.Int32Enum, System.Int32>(dic:  -322875104, key:  0, defaultValue:  0);
    }
    public override void ShowIntroAnimation()
    {
        if(this.PointsCollectedForCurrentLevel < 1)
        {
                return;
        }
        
        this.ShowIntroAnimation();
    }
    public override void Initialize(WGEventHandler handler)
    {
        mem[1152921512874134596] = handler;
        goto typeof(WGEventButtonProgressAttackMadness).__il2cppRuntimeField_EC;
    }
    public override void Refresh()
    {
        if(this.PointsCollectedForCurrentLevel > 0)
        {
                0f = 1f;
        }
        
        R4.alpha = 1f;
        if(R4 == 0)
        {
            
        }
    
    }
    public WGEventButtonProgressAttackMadness()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
