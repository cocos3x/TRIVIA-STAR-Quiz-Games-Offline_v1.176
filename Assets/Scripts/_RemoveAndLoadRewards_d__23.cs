using UnityEngine;
private sealed class MPIGiftRewardUI.<RemoveAndLoadRewards>d__23 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public MPIGiftRewardUI <>4__this;
    private System.Collections.Generic.List<UnityEngine.CanvasGroup> <cgList>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MPIGiftRewardUI.<RemoveAndLoadRewards>d__23(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Object val_7;
        MPIGiftRewardUI.<RemoveAndLoadRewards>d__23 val_16;
        System.Action val_17;
        MPIGiftRewardUI val_18;
        int val_19;
        System.Collections.Generic.List<GiftRewardUIParams> val_20;
        val_16 = this;
        val_18 = this.<>4__this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_19 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_19;
        }
        
        this.<>1__state = 0;
        this.<>4__this.tapArea.m_OnClick.RemoveAllListeners();
        T[] val_1 = this.<>4__this.upperLayout.GetComponentsInChildren<System.Object>();
        T[] val_2 = this.<>4__this.lowerLayout.GetComponentsInChildren<System.Object>();
        System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution> val_3 = new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>();
        this.<cgList>5__2 = null;
        AddRange(collection:  this.<>4__this.upperLayout);
        this.<cgList>5__2.AddRange(collection:  this.<>4__this.lowerLayout);
        List.Enumerator<T> val_4 = GetEnumerator();
        val_18 = 16153;
        val_18 = 1058642330;
        val_16 = 1152921504797741056;
        label_16:
        if(MoveNext() == false)
        {
            goto label_12;
        }
        
        object val_6 = new System.Object();
        typeof(MPIGiftRewardUI.<>c__DisplayClass23_0).__il2cppRuntimeField_8 = val_7;
        DG.Tweening.Core.DOGetter<System.Single> val_8 = new DG.Tweening.Core.DOGetter<System.Single>(object:  347123712, method:  new IntPtr(3628199936));
        DG.Tweening.Core.DOSetter<System.Single> val_9 = new DG.Tweening.Core.DOSetter<System.Single>(object:  347123712, method:  new IntPtr(3628197888));
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_10 = DG.Tweening.DOTween.To(getter:  198828032, setter:  198881280, endValue:  null, duration:  null);
        goto label_16;
        label_2:
        this.<>1__state = 0;
        List.Enumerator<T> val_11 = GetEnumerator();
        val_18 = 1152921504765685760;
        label_22:
        if(MoveNext() == false)
        {
            goto label_18;
        }
        
        UnityEngine.GameObject val_13 = val_7.gameObject;
        UnityEngine.Object.Destroy(obj:  val_7);
        goto label_22;
        label_1:
        this.<>1__state = 0;
        if(val_18 == 0)
        {
            goto label_23;
        }
        
        val_20 = this.<>4__this.pendingRewards;
        val_17 = this.<>4__this.onAllRewardsRevealed;
        goto label_24;
        label_18:
        Dispose();
        this.<>1__state = 2;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        val_19 = 1;
        return (bool)val_19;
        label_12:
        Dispose();
        UnityEngine.WaitForSeconds val_15 = null;
        val_15 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_19 = 1;
        this.<>1__state = val_19;
        mem[1152921512530052556] = val_15;
        return (bool)val_19;
        label_23:
        val_20 = 1835037;
        val_17 = 52;
        label_24:
        val_19 = 0;
        val_18.Setup(rewardsParams:  1835037, onAllRewardsRevealed:  52);
        return (bool)val_19;
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
