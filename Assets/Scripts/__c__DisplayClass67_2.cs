using UnityEngine;
private sealed class WordHuntEvent.<>c__DisplayClass67_2
{
    // Fields
    public WordHuntPopup rewardPopup;
    
    // Methods
    public WordHuntEvent.<>c__DisplayClass67_2()
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
