using UnityEngine;
private sealed class TRVLevelComplete.<SetupReward>d__97 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVLevelComplete <>4__this;
    public TRVLevelReward reward;
    public UnityEngine.Transform parent;
    public bool anim;
    private TRVLevelCompleteReward <lcr>5__2;
    private UnityEngine.Vector3 <targetStatView>5__3;
    private CurrencyParticles <newCps>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVLevelComplete.<SetupReward>d__97(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Vector3 val_9;
        var val_10;
        var val_11;
        int val_14;
        System.Collections.Generic.Dictionary<System.String, TRVLevelCompleteReward> val_15;
        string val_16;
        GemsParticles val_17;
        CurrencyStatView val_18;
        UnityEngine.Vector3 val_19;
        float val_20;
        val_14 = 0;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_14;
        }
        
        this.<>1__state = 0;
        val_15 = this.<>4__this.spawnedRewards;
        if(val_15 == 0)
        {
                val_15 = null;
            val_15 = new System.Collections.Generic.Dictionary<WordPets.WPTLetterTile, WordPets.WPTPetTile>();
            this.<>4__this.spawnedRewards = val_15;
        }
        
        val_16 = this.reward.<desc>k__BackingField;
        if((ContainsKey(key:  val_16)) == true)
        {
                return (bool)val_14;
        }
        
        object val_3 = UnityEngine.Object.Instantiate<System.Object>(original:  this.<>4__this.levelCompleteRewardPrefab, parent:  this.parent);
        this.<lcr>5__2 = this.<>4__this.levelCompleteRewardPrefab;
        this.<>4__this.levelCompleteRewardPrefab.Init(myRew:  this.reward);
        if(this.anim == false)
        {
            goto label_22;
        }
        
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        if((this.reward.<rewardType>k__BackingField) == 0)
        {
            goto label_16;
        }
        
        if((this.reward.<rewardType>k__BackingField) == 1)
        {
            goto label_17;
        }
        
        if((this.reward.<rewardType>k__BackingField) != 2)
        {
            goto label_18;
        }
        
        val_17 = this.<>4__this.gp;
        val_18 = this.<>4__this.gemStatView;
        goto label_31;
        label_1:
        val_19 = this.<targetStatView>5__3;
        this.<>1__state = 0;
        if(this.reward == 0)
        {
                val_20 = ???;
            val_19 = val_19;
        }
        
        if((this.<newCps>5__4) == 0)
        {
                val_20 = val_20;
            val_19 = val_19;
        }
        
        this.<newCps>5__4.PlayParticles(destinationPosition:  new UnityEngine.Vector3() {x = val_19, y = val_20, z = SB}, particleCount:  429496729, animateStatView:  true);
        label_22:
        val_15 = this.<>4__this.spawnedRewards;
        val_16 = this.reward.<desc>k__BackingField;
        val_15.Add(key:  val_16, value:  this.<lcr>5__2);
        return (bool)val_14;
        label_2:
        this.<>1__state = 0;
        UnityEngine.Transform val_5 = this.<lcr>5__2.rewardCurrencyImage.transform;
        UnityEngine.GameObject val_6 = this.<lcr>5__2.rewardCurrencyImage.gameObject;
        val_15 = this.<lcr>5__2.rewardCurrencyImage;
        this.<newCps>5__4.SetOrigin(originObject:  val_15);
        val_14 = 1;
        this.<>1__state = 2;
        this.<>2__current = 0;
        return (bool)val_14;
        label_16:
        val_17 = this.<>4__this.ccp;
        val_18 = this.<>4__this.coinStatView;
        goto label_31;
        label_17:
        val_17 = this.<>4__this.sp;
        val_18 = this.<>4__this.starStatView;
        label_31:
        UnityEngine.Transform val_7 = this.<>4__this.starStatView.text.transform;
        UnityEngine.Vector3 val_8 = position;
        this.<targetStatView>5__3 = val_9;
        mem[1152921512696330616] = val_10;
        mem[1152921512696330620] = val_11;
        goto label_35;
        label_18:
        val_17 = 0;
        label_35:
        val_16 = 0;
        UnityEngine.Transform val_12 = this.<lcr>5__2.rewardCurrencyImage.transform;
        val_15 = this.<lcr>5__2.rewardCurrencyImage;
        object val_13 = UnityEngine.Object.Instantiate<System.Object>(original:  0, parent:  val_15);
        val_14 = 1;
        this.<newCps>5__4 = val_17;
        this.<>1__state = val_14;
        this.<>2__current = val_16;
        return (bool)val_14;
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
