using UnityEngine;
private sealed class WFOMysteryChestDisplay.<BeginChestReadyFlowCoroutine>d__79 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordForest.WFOMysteryChestDisplay <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WFOMysteryChestDisplay.<BeginChestReadyFlowCoroutine>d__79(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_41;
        if((this.<>1__state) <= 3)
        {
                var val_1 = 14113012 + (14113012 + (this.<>1__state) << 2);
            if((this.<>1__state) == 3)
        {
                14113012 + (this.<>1__state) << 2 = (14113012 + (this.<>1__state) << 2) & ((14113012 + (this.<>1__state) << 2) << (14113012 + (this.<>1__state) << 2));
            14113012 + (this.<>1__state) << 2 = (14113012 + (this.<>1__state) << 2) & ((R8) >> 4);
            14113012 + (this.<>1__state) << 2 = (14113012 + (this.<>1__state) << 2) & (((int)R8) >> 5);
        }
        
            this.<>1__state = 0;
            UnityEngine.GameObject val_2 = this.<>4__this.button.gameObject;
            this.<>4__this.button.SetActive(value:  false);
            System.Func<System.Boolean> val_3 = new System.Func<System.Boolean>(object:  this.<>4__this, method:  new IntPtr(322424384));
            val_41 = 1;
            this.<>1__state = val_41;
            this.<>2__current = new UnityEngine.WaitUntil(predicate:  7667712);
            return (bool);
        }
        
        val_41 = 0;
        return (bool);
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
