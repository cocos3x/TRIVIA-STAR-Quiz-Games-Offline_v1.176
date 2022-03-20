using UnityEngine;
private sealed class WGAlphabetCollectionBoxPopup.<ShowTooltipBeforeAnimating>d__33 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGAlphabetCollectionBoxPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGAlphabetCollectionBoxPopup.<ShowTooltipBeforeAnimating>d__33(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        if((this.<>1__state) != 1)
        {
                val_4 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
            this.<>1__state = 0;
            val_4 = 1;
            this.<>4__this.ftuxTooltip.SetActive(value:  true);
            UnityEngine.WaitForSeconds val_1 = null;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            this.<>1__state = val_4;
            this.<>2__current = val_1;
            return (bool)val_4;
        }
        
        this.<>1__state = 0;
        val_4 = 0;
        this.<>4__this.ftuxTooltip.SetActive(value:  false);
        System.Collections.IEnumerator val_2 = this.<>4__this.AnimateCollecting();
        UnityEngine.Coroutine val_3 = this.<>4__this.StartCoroutine(routine:  this.<>4__this);
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
