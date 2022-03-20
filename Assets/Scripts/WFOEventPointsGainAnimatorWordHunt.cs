using UnityEngine;
public class WFOEventPointsGainAnimatorWordHunt : WFOEventPointsGainAnimator
{
    // Properties
    protected override float AdditionalFlyoutLingerTime { get; }
    
    // Methods
    protected override float get_AdditionalFlyoutLingerTime()
    {
        return (float)S0;
    }
    public WFOEventPointsGainAnimatorWordHunt()
    {
    
    }

}
