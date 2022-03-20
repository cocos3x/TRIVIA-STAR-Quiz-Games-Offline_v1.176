using UnityEngine;
private sealed class GridCoinCollectAnimationInstantiator.<ConcludeAnimationDelay>d__35 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public GridCoinCollectAnimationInstantiator <>4__this;
    public bool textTickerOnly;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GridCoinCollectAnimationInstantiator.<ConcludeAnimationDelay>d__35(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        float val_3;
        val_2 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_2;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_3;
        }
        
        val_3 = this.<>4__this.textTweenTime;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        if(this.textTickerOnly == true)
        {
                this.textTickerOnly = 1;
        }
        
        this.<>4__this.ConcludeAnimation(textTickerOnly:  true);
        return (bool)val_2;
        label_3:
        val_3 = 7.286752E-44f;
        label_4:
        val_3 = val_3 + (this.<>4__this.delayBeforeAnimationConclusion);
        val_2 = 1;
        this.<>1__state = val_2;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.<>4__this.delayBeforeAnimationConclusion);
        return (bool)val_2;
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
