using UnityEngine;
private sealed class WPTAnimationTester.<AnimateFallSquash>d__13 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WPTAnimationTester <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WPTAnimationTester.<AnimateFallSquash>d__13(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        var val_8;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_7 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_7;
        }
        
        this.<>1__state = 0;
        this.<>4__this.wordPet.AnimateFall();
        val_7 = 1;
        this.<>1__state = val_7;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
        return (bool)val_7;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_7;
        }
        
        System.Collections.IEnumerator val_2 = this.<>4__this.AnimateFallSquash();
        val_8 = this.<>4__this;
        goto label_8;
        label_2:
        this.<>1__state = 0;
        this.<>4__this.wordPet.AnimateSquash();
        this.<>1__state = 2;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.<>4__this.LandingDelay);
        val_7 = 1;
        return (bool)val_7;
        label_7:
        System.Collections.IEnumerator val_5 = 0.AnimateFallSquash();
        val_8 = 0;
        label_8:
        val_7 = 0;
        UnityEngine.Coroutine val_6 = this.<>4__this.StartCoroutine(routine:  0);
        return (bool)val_7;
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
