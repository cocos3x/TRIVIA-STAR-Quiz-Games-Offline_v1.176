using UnityEngine;
private sealed class KeyToRichesPopup.<CloseRewardSequence>d__60 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public KeyToRichesPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public KeyToRichesPopup.<CloseRewardSequence>d__60(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        object val_8;
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
        UnityEngine.WaitForSeconds val_1 = null;
        val_8 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_7 = 1;
        this.<>1__state = val_7;
        this.<>2__current = val_8;
        return (bool)val_7;
        label_1:
        this.<>1__state = 0;
        val_7 = 0;
        UnityEngine.GameObject val_2 = this.<>4__this.gameObject;
        SLCWindow.CloseWindow(window:  this.<>4__this, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        return (bool)val_7;
        label_2:
        var val_7 = 0;
        this.<>1__state = 0;
        do
        {
            val_8 = this.<>4__this.openedChests;
            if((val_8.Contains(item:  0)) != true)
        {
                val_8 = this.<>4__this.chests[val_7];
            System.Collections.IEnumerator val_4 = val_8.RevealSequence();
            UnityEngine.Coroutine val_5 = val_8.StartCoroutine(routine:  val_8);
        }
        
            val_7 = val_7 + 1;
        }
        while(val_7 != 9);
        
        KeyToRichesEventHandler._Instance.OnRewardComplete();
        this.<>1__state = 2;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
        val_7 = 1;
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
