using UnityEngine;
private sealed class WFOMysteryChestDisplay.<>c__DisplayClass91_0
{
    // Fields
    public WordForest.WFOMysteryChestDisplay <>4__this;
    public DG.Tweening.Sequence nestedLoopSeq;
    
    // Methods
    public WFOMysteryChestDisplay.<>c__DisplayClass91_0()
    {
    
    }
    internal void <DoAnimatedPointer>b__0()
    {
        UnityEngine.GameObject val_1 = this.<>4__this.pointerImage.gameObject;
        this.<>4__this.pointerImage.SetActive(value:  true);
        this.<>4__this.pointerSequence = this.nestedLoopSeq;
        object val_2 = DG.Tweening.TweenExtensions.Play<System.Object>(t:  this.<>4__this.pointerSequence);
    }

}
