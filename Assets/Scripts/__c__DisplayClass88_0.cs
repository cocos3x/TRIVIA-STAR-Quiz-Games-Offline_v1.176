using UnityEngine;
private sealed class WFOMysteryChestDisplay.<>c__DisplayClass88_0
{
    // Fields
    public WordForest.WFOMysteryChestDisplay <>4__this;
    public int itemIndex;
    public DG.Tweening.Sequence seqSegment;
    
    // Methods
    public WFOMysteryChestDisplay.<>c__DisplayClass88_0()
    {
    
    }
    internal void <CreateMiniSeqSegmentShowItemIntro>b__0()
    {
        int val_17;
        int val_18;
        WordForest.WFOMysteryChestDisplay val_19;
        WordForest.WFOAcornMultiplierTrailParticle val_20;
        if(true <= this.itemIndex)
        {
                var val_17 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_17 = val_17 + (((this.itemIndex << 3) - this.itemIndex) << 2);
        var val_2 = val_17 + 24;
        val_17 = mem[(0 + (((this.itemIndex) << 3 - this.itemIndex)) << 2) + 16];
        val_17 = (0 + (((this.itemIndex) << 3 - this.itemIndex)) << 2) + 16;
        if((this.<>4__this) == 0)
        {
                val_18 = mem[((0 + (((this.itemIndex) << 3 - this.itemIndex)) << 2) + 24) + (0)];
            val_17 = val_17;
        }
        
        WordForest.WFOWordChestItemIcon val_3 = this.<>4__this.InstantiateObjectItem(rewardData:  new WordForest.WFORewardData() {id = val_17, rewardType = (0 + (((this.itemIndex) << 3 - this.itemIndex)) << 2) + 20, amount = new System.Decimal() {flags = val_18, hi = mem[((0 + (((this.itemIndex) << 3 - this.itemIndex)) << 2) + 24) + (4)], lo = mem[((0 + (((this.itemIndex) << 3 - this.itemIndex)) << 2) + 24) + (8)], mid = mem[((0 + (((this.itemIndex) << 3 - this.itemIndex)) << 2) + 24) + (12)]}, transformToId = (0 + (((this.itemIndex) << 3 - this.itemIndex)) << 2) + 40}, itemIndex:  this.itemIndex, forOutro:  false);
        UnityEngine.Transform val_4 = this.<>4__this.transform;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        this.<>4__this.localScale = new UnityEngine.Vector3();
        val_19 = this.<>4__this;
        if(val_19 != 0)
        {
                val_20 = this.<>4__this.prefabItemTrailEfx;
        }
        else
        {
                val_20 = this.<>4__this.prefabItemTrailEfx;
            val_19 = this.<>4__this;
            if(val_19 == 0)
        {
                val_19 = 0;
        }
        
        }
        
        UnityEngine.Transform val_6 = val_19.transform;
        object val_7 = UnityEngine.Object.Instantiate<System.Object>(original:  val_20, parent:  0);
        UnityEngine.Transform val_8 = val_20.transform;
        UnityEngine.Transform val_9 = this.<>4__this.transform;
        UnityEngine.Vector3 val_10 = position;
        val_20.position = new UnityEngine.Vector3();
        if(val_20 <= this.itemIndex)
        {
                var val_18 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_18 = val_18 + (this.itemIndex << 2);
        UnityEngine.Vector3 val_11 = position;
        val_20.PlayParticles(destinationPosition:  new UnityEngine.Vector3(), particleCount:  1, animateStatView:  true);
        UnityEngine.GameObject val_12 = this.<>4__this.gameObject;
        UnityEngine.Transform val_13 = this.<>4__this.transform;
        DG.Tweening.Tweener val_14 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this, endValue:  val_11.x, duration:  val_11.y);
        object val_15 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<>4__this, ease:  30);
        DG.Tweening.Sequence val_16 = DG.Tweening.TweenSettingsExtensions.Append(s:  mem[1152921513523364576], t:  this.<>4__this);
    }

}
