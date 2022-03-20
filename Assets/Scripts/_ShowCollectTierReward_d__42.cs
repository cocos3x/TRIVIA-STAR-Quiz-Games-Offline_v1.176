using UnityEngine;
private sealed class WGInviteV2.<ShowCollectTierReward>d__42 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGInviteV2 <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGInviteV2.<ShowCollectTierReward>d__42(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        WGInviteV2 val_26;
        var val_27;
        int val_28;
        object val_29;
        var val_31;
        var val_32;
        if((this.<>1__state) > 3)
        {
            goto label_1;
        }
        
        val_26 = this.<>4__this;
        var val_1 = 6902888 + (6902888 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                6902888 + (this.<>1__state) << 2 = (6902888 + (this.<>1__state) << 2) & ((6902888 + (this.<>1__state) << 2) << (6902888 + (this.<>1__state) << 2));
            6902888 + (this.<>1__state) << 2 = (6902888 + (this.<>1__state) << 2) & ((6902888 + (this.<>1__state) << 2) << 6902888);
            6902888 + (this.<>1__state) << 2 = (6902888 + (this.<>1__state) << 2) * 6902888;
            6902888 + (this.<>1__state) << 2 = (6902888 + (this.<>1__state) << 2) & (35627334 >> R3);
        }
        
        this.<>1__state = 0;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        TierReward val_3 = NextTier();
        val_27 = public static WGInviteManager MonoSingleton<WGInviteManager>::get_Instance();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_4 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        Add(item:  this.<>4__this.bronzeChestTextures);
        Add(item:  this.<>4__this.silverChestTextures);
        if(null == 0)
        {
            goto label_8;
        }
        
        Add(item:  this.<>4__this.goldChestTextures);
        goto label_9;
        label_1:
        val_28 = 0;
        return (bool)val_28;
        label_8:
        Add(item:  this.<>4__this.goldChestTextures);
        label_9:
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_32 = 4;
        goto label_31;
        label_38:
        if(1152921507865433328 <= (this.<>4__this.goldChestTextures))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((mem[1152921507865433344] + 12) <= (this.<>4__this.goldChestTextures))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        2621443.texture = mem[1152921507865433344] + 8 + 16;
        val_32 = 5;
        label_31:
        if((val_32 - 4) < 2621443)
        {
            goto label_38;
        }
        
        if(2621443 <= val_27)
        {
                var val_28 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_28 = val_28 + 2164528384;
        if(val_28 <= val_27)
        {
                var val_29 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_29 = val_29 + 2164528384;
        (0 + 2164528384) + 16.SetActive(value:  false);
        this.<>4__this.chestGO.SetActive(value:  true);
        this.<>4__this.closedChest.SetActive(value:  true);
        this.<>4__this.openedChest.SetActive(value:  false);
        UnityEngine.Transform val_16 = this.<>4__this.chestGO.transform;
        UnityEngine.Transform val_17 = (0 + 2164528384) + 16.transform;
        UnityEngine.Vector3 val_18 = position;
        this.<>4__this.chestGO.position = new UnityEngine.Vector3();
        UnityEngine.Transform val_19 = this.<>4__this.chestGO.transform;
        UnityEngine.Vector3 val_20 = new UnityEngine.Vector3(x:  val_18.x, y:  val_18.y);
        this.<>4__this.chestGO.localScale = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
        UnityEngine.Transform val_21 = this.<>4__this.chestGO.transform;
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.one;
        val_31 = 1065353216;
        DG.Tweening.Tweener val_23 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.chestGO, endValue:  new UnityEngine.Vector3(), duration:  val_22.x);
        UnityEngine.Transform val_24 = this.<>4__this.chestGO.transform;
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_26 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.<>4__this.chestGO, endValue:  new UnityEngine.Vector3(), duration:  val_25.x, snapping:  false);
        UnityEngine.WaitForSeconds val_27 = null;
        val_29 = val_27;
        val_27 = new UnityEngine.WaitForSeconds(seconds:  val_25.x);
        val_28 = 1;
        this.<>1__state = val_28;
        this.<>2__current = val_29;
        return (bool)val_28;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
