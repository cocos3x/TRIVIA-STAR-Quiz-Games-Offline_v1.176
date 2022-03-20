using UnityEngine;
private sealed class CurrencyParticles.<UpdateStatView>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float statViewDelaySeconds;
    public CurrencyParticles <>4__this;
    public bool doStatViewAnimation;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CurrencyParticles.<UpdateStatView>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        object val_5;
        if((this.<>1__state) != 1)
        {
                val_4 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = null;
            val_5 = val_1;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_4 = 1;
            this.<>1__state = val_4;
            this.<>2__current = val_5;
            return (bool)val_4;
        }
        
        this.<>1__state = 0;
        NotificationCenter val_2 = NotificationCenter.DefaultCenter;
        val_5 = 0;
        if(this.doStatViewAnimation == true)
        {
                this.doStatViewAnimation = 1;
        }
        
        System.Collections.Hashtable val_3 = CurrencyStatView.GetAnimHT(shouldAnimate:  true);
        val_4 = 0;
        val_5.PostNotification(aSender:  this.<>4__this, aName:  this.<>4__this, aData:  1);
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
