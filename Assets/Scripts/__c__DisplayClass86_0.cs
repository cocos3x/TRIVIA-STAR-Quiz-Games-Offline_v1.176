using UnityEngine;
private sealed class WFOMysteryChestDisplay.<>c__DisplayClass86_0
{
    // Fields
    public WordForest.WFOMysteryChestDisplay <>4__this;
    public int completedItemSeq;
    public DG.Tweening.TweenCallback <>9__8;
    public DG.Tweening.TweenCallback <>9__9;
    public System.Func<bool> <>9__10;
    
    // Methods
    public WFOMysteryChestDisplay.<>c__DisplayClass86_0()
    {
    
    }
    internal void <DoOpenChestAnimationSequence>b__8()
    {
        this.<>4__this.ToggleTapToOpenLabel(isVisible:  true);
    }
    internal void <DoOpenChestAnimationSequence>b__9()
    {
        int val_1 = this.completedItemSeq;
        val_1 = val_1 + 1;
        this.completedItemSeq = val_1;
    }
    internal bool <DoOpenChestAnimationSequence>b__10()
    {
        bool val_1 = this.<>4__this.isAwaitingPlayerInputForItems;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    internal bool <DoOpenChestAnimationSequence>b__0()
    {
        if(this.completedItemSeq >= R1)
        {
                0 = 1;
        }
        
        return true;
    }

}
