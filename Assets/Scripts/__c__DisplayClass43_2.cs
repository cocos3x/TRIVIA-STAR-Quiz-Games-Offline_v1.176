using UnityEngine;
private sealed class LightningLevelsEventHandler.<>c__DisplayClass43_2
{
    // Fields
    public WGLightningLevelsPopup rewardPopup;
    
    // Methods
    public LightningLevelsEventHandler.<>c__DisplayClass43_2()
    {
    
    }
    internal bool <DoLevelCompleteEventProgressAnimation>b__3()
    {
        if(this.rewardPopup == 0)
        {
                return (bool)1;
        }
        
        UnityEngine.GameObject val_2 = this.rewardPopup.gameObject;
        1 = this.rewardPopup.activeSelf ^ 1;
        return (bool)1;
    }

}
