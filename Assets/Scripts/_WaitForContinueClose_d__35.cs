using UnityEngine;
private sealed class WordPetsFTUXDemoWindow.<WaitForContinueClose>d__35 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordPetsFTUXDemoWindow <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WordPetsFTUXDemoWindow.<WaitForContinueClose>d__35(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
            this.<>1__state = 0;
            this.<>4__this.proceed = false;
            System.Func<System.Boolean> val_1 = new System.Func<System.Boolean>(object:  this.<>4__this, method:  new IntPtr(129805952));
            val_3 = 1;
            this.<>1__state = val_3;
            this.<>2__current = new UnityEngine.WaitUntil(predicate:  7667712);
            return (bool)val_3;
        }
        
        this.<>1__state = 0;
        this.<>4__this.CloseWindow();
        return (bool)val_3;
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
