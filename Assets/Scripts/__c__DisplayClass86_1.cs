using UnityEngine;
private sealed class WFOMysteryChestDisplay.<>c__DisplayClass86_1
{
    // Fields
    public int currItemIndex;
    public WordForest.WFOMysteryChestDisplay.<>c__DisplayClass86_0 CS$<>8__locals1;
    
    // Methods
    public WFOMysteryChestDisplay.<>c__DisplayClass86_1()
    {
    
    }
    internal void <DoOpenChestAnimationSequence>b__1()
    {
        System.Collections.Generic.List<WordForest.WFORewardData> val_10 = this.CS$<>8__locals1.<>4__this.rewardItems;
        if(true <= this.currItemIndex)
        {
                var val_10 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_10 = val_10 + (((this.currItemIndex << 3) - this.currItemIndex) << 2);
        if(((0 + (((this.currItemIndex) << 3 - this.currItemIndex)) << 2) + 20) != 5)
        {
            goto label_5;
        }
        
        WordForest.WFOPlayer val_2 = WordForest.WFOPlayer.Instance;
        bool val_3 = MonoExtensions.IsBitSet(value:  132, bit:  9);
        if(val_3 == false)
        {
            goto label_21;
        }
        
        label_5:
        val_10 = this.CS$<>8__locals1.<>4__this.rewardItems;
        if(val_3 <= this.currItemIndex)
        {
                var val_11 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_11 = val_11 + (((this.currItemIndex << 3) - this.currItemIndex) << 2);
        if(((0 + (((this.currItemIndex) << 3 - this.currItemIndex)) << 2) + 20) != 6)
        {
            goto label_12;
        }
        
        WordForest.WFOPlayer val_5 = WordForest.WFOPlayer.Instance;
        bool val_6 = MonoExtensions.IsBitSet(value:  132, bit:  10);
        if(val_6 == false)
        {
            goto label_21;
        }
        
        label_12:
        val_10 = this.CS$<>8__locals1.<>4__this.rewardItems;
        if(val_6 <= this.currItemIndex)
        {
                var val_12 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_12 = val_12 + (((this.currItemIndex << 3) - this.currItemIndex) << 2);
        if(((0 + (((this.currItemIndex) << 3 - this.currItemIndex)) << 2) + 20) != 4)
        {
                return;
        }
        
        WordForest.WFOPlayer val_8 = WordForest.WFOPlayer.Instance;
        if((MonoExtensions.IsBitSet(value:  132, bit:  8)) != false)
        {
                return;
        }
        
        label_21:
        this.CS$<>8__locals1.<>4__this.button.interactable = false;
    }
    internal void <DoOpenChestAnimationSequence>b__2()
    {
        this.CS$<>8__locals1.<>4__this.PauseAllOpenChestSequences(triggerItemIndex:  this.currItemIndex);
        this.CS$<>8__locals1.<>4__this.ToggleTapToOpenLabel(isVisible:  false);
        this.CS$<>8__locals1.<>4__this.ShowFtux(ftuxId:  8);
    }
    internal void <DoOpenChestAnimationSequence>b__3()
    {
        this.CS$<>8__locals1.<>4__this.PauseAllOpenChestSequences(triggerItemIndex:  this.currItemIndex);
        this.CS$<>8__locals1.<>4__this.ToggleTapToOpenLabel(isVisible:  false);
        this.CS$<>8__locals1.<>4__this.ShowFtux(ftuxId:  10);
    }
    internal void <DoOpenChestAnimationSequence>b__4()
    {
        this.CS$<>8__locals1.<>4__this.PauseAllOpenChestSequences(triggerItemIndex:  this.currItemIndex);
        this.CS$<>8__locals1.<>4__this.ToggleTapToOpenLabel(isVisible:  false);
        this.CS$<>8__locals1.<>4__this.ShowFtux(ftuxId:  11);
    }
    internal void <DoOpenChestAnimationSequence>b__5()
    {
        this.CS$<>8__locals1.<>4__this.PauseAllOpenChestSequences(triggerItemIndex:  this.currItemIndex);
        RaidAttackScreenUI.ShowAttackScreen();
    }
    internal void <DoOpenChestAnimationSequence>b__6()
    {
        this.CS$<>8__locals1.<>4__this.PauseAllOpenChestSequences(triggerItemIndex:  this.currItemIndex);
        this.CS$<>8__locals1.<>4__this.ShowFtux(ftuxId:  9);
    }
    internal void <DoOpenChestAnimationSequence>b__7()
    {
        this.CS$<>8__locals1.<>4__this.PauseAllOpenChestSequences(triggerItemIndex:  this.currItemIndex);
        RaidAttackScreenUI.ShowRaidScreen();
    }

}
