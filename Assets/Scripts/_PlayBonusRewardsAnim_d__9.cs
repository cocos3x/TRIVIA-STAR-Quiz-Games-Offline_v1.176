using UnityEngine;
private sealed class WGBonusRewardsStoreDisplay.<PlayBonusRewardsAnim>d__9 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGBonusRewardsStoreDisplay <>4__this;
    public int particleCount;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGBonusRewardsStoreDisplay.<PlayBonusRewardsAnim>d__9(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        BonusRewardCurrencyParticles val_5;
        if((this.<>1__state) != 1)
        {
                val_4 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = null;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_4 = 1;
            this.<>1__state = val_4;
            this.<>2__current = val_1;
            return (bool)val_4;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
                val_5 = this.<>4__this.brcParticles;
        }
        else
        {
                val_5 = 0;
        }
        
        UnityEngine.Transform val_2 = this.<>4__this.transform;
        val_4 = 0;
        UnityEngine.Vector3 val_3 = position;
        val_5.PlayParticles(destinationPosition:  new UnityEngine.Vector3(), particleCount:  429496729, animateStatView:  true);
        return (bool)val_4;
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
