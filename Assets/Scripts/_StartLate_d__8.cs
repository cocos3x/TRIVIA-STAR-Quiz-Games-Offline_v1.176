using UnityEngine;
private sealed class AnimatedTransitionUIElement.<StartLate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public AnimatedTransitionUIElement <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AnimatedTransitionUIElement.<StartLate>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        int val_4;
        val_3 = this;
        if((this.<>1__state) != 1)
        {
                val_4 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
            this.<>1__state = 0;
            this.<>4__this.canvasGroup.alpha = null;
            val_4 = 1;
            this.<>1__state = val_4;
            this.<>2__current = 0;
            return (bool)val_4;
        }
        
        this.<>1__state = 0;
        val_4 = 0;
        UnityEngine.GameObject val_1 = this.<>4__this.gameObject;
        val_3 = this.<>4__this;
        if(val_3.activeInHierarchy == false)
        {
                return (bool)val_4;
        }
        
        val_4 = 0;
        this.<>4__this.FadeTo(duration:  null, from:  null, to:  null, doDelay:  false);
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
