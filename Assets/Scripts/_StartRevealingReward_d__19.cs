using UnityEngine;
private sealed class GiftRewardUI.<StartRevealingReward>d__19 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public GiftRewardUI <>4__this;
    public GiftRewardRevealInfo reward;
    public System.Action onAllRewardsRevealed;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GiftRewardUI.<StartRevealingReward>d__19(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        var val_15;
        GiftRewardUI val_16;
        object val_17;
        int val_18;
        var val_19;
        val_15 = 0;
        if((this.<>1__state) > 4)
        {
                return (bool)val_15;
        }
        
        val_16 = this.<>4__this;
        var val_1 = 6516936 + (6516936 + (this.<>1__state) << 2);
        if((this.<>1__state) == 4)
        {
                val_15 = 0;
            val_15 = val_15 & 35626453;
            val_15 = val_15 & (35626453 << val_15);
            val_15 = val_15 & (((int)R8) >> ((val_15 & 35626453) & (35626453) << (val_15 & 35626453)));
            mem2[0] = (((val_15 & 35626453) & (35626453) << (val_15 & 35626453)) & ((int)R8) >> ((val_15 & 35626453) & (35626453) << (val_15 & 35626453))) + (((val_15 & 35626453) & (35626453) << (val_15 & 35626453)) & ((int)R8) >> ((val_15 & 35626453) & (35626453) << (val_15 & 35626453)));
        }
        
        this.<>1__state = 0;
        if((this.<>4__this.waitingForCollectAnim) == false)
        {
            goto label_3;
        }
        
        UnityEngine.WaitForEndOfFrame val_2 = null;
        val_17 = val_2;
        val_2 = new UnityEngine.WaitForEndOfFrame();
        val_18 = 2;
        goto label_18;
        label_17:
        if(MoveNext() == false)
        {
            goto label_15;
        }
        
        val_6.SetActive(value:  false);
        goto label_17;
        label_3:
        UnityEngine.WaitForSeconds val_7 = null;
        val_17 = val_7;
        val_7 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_18 = 3;
        goto label_18;
        label_15:
        Dispose();
        this.<>4__this.revealedRewardObjects.Clear();
        this.<>4__this.revealedRewardObjects.Add(item:  this.reward.rewardObject);
        val_16 = (this.<>4__this.revealedRewardObjects) + (this.<>4__this.rewardsToReveal);
        UnityEngine.Transform val_8 = this.<>4__this.upperLayout.transform;
        if(val_16 < (this.<>4__this.maxRevealedRewards))
        {
                val_19 = 16268;
            val_19 = 1066192077;
        }
        else
        {
                val_19 = 16230;
            val_19 = 1063675494;
        }
        
        UnityEngine.Vector3 val_9 = new UnityEngine.Vector3(x:  null, y:  null, z:  null);
        this.<>4__this.upperLayout.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        if(this.reward.rewardObject != 0)
        {
                UnityEngine.UI.LayoutElement val_11 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  this.reward.rewardObject);
            DG.Tweening.Tweener val_12 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.reward.rewardObject, endValue:  null, duration:  null);
        }
        
        if(this.reward.rewardAction != 0)
        {
                this.reward.rewardAction.Invoke();
        }
        
        UnityEngine.WaitForSeconds val_13 = null;
        val_17 = val_13;
        val_13 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_18 = 1;
        label_18:
        val_15 = 1;
        this.<>2__current = val_17;
        this.<>1__state = val_18;
        return (bool)val_15;
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
