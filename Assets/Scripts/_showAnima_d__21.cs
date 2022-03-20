using UnityEngine;
private sealed class WGExtraWordsPopup.<showAnima>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnityEngine.CanvasGroup cg;
    public WGExtraWordsPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGExtraWordsPopup.<showAnima>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_9;
        object val_10;
        var val_11;
        if((this.<>1__state) != 1)
        {
                val_9 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_9;
        }
        
            this.<>1__state = 0;
            this.cg.alpha = UnityEngine.Mathf.Lerp(a:  this.cg.alpha, b:  null, t:  null);
            UnityEngine.WaitForSeconds val_4 = null;
            val_10 = val_4;
            val_4 = new UnityEngine.WaitForSeconds(seconds:  UnityEngine.Time.deltaTime);
            val_9 = 1;
            this.<>1__state = val_9;
            this.<>2__current = val_10;
            return (bool)val_9;
        }
        
        val_10 = this.cg;
        this.<>1__state = 0;
        val_9 = 0;
        float val_5 = val_10.alpha;
        float val_9 = System.Math.Abs(val_10);
        if((this.<>4__this) != 0)
        {
                System.Collections.IEnumerator val_6 = this.<>4__this.showAnima(cg:  this.cg);
            val_11 = this.<>4__this;
        }
        else
        {
                System.Collections.IEnumerator val_7 = 0.showAnima(cg:  this.cg);
            val_11 = 0;
        }
        
        val_9 = 0;
        UnityEngine.Coroutine val_8 = this.<>4__this.StartCoroutine(routine:  0);
        return (bool)val_9;
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
