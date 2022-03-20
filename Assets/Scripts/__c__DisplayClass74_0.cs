using UnityEngine;
private sealed class AttackMadnessEventHandler.<>c__DisplayClass74_0
{
    // Fields
    public bool isRewardShowing;
    
    // Methods
    public AttackMadnessEventHandler.<>c__DisplayClass74_0()
    {
    
    }
    internal void <RewardSequence>b__0()
    {
        this.isRewardShowing = false;
    }
    internal bool <RewardSequence>b__1()
    {
        bool val_1 = this.isRewardShowing;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }

}
