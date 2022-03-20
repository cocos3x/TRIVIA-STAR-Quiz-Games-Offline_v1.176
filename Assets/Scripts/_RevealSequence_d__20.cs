using UnityEngine;
private sealed class KeyToRichesChest.<RevealSequence>d__20 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public KeyToRichesChest <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public KeyToRichesChest.<RevealSequence>d__20(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        KeyToRichesChest val_2;
        int val_3;
        val_2 = this.<>4__this;
        if((this.<>1__state) != 1)
        {
                val_3 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
            this.<>1__state = 0;
            this.<>4__this.glowingKeyGO.SetActive(value:  false);
            UnityEngine.WaitForSeconds val_1 = null;
            val_2 = val_1;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_3 = 1;
            this.<>1__state = val_3;
            this.<>2__current = val_2;
            return (bool)val_3;
        }
        
        this.<>1__state = 0;
        val_3 = 0;
        this.<>4__this.animator.SetTrigger(name:  -1360385168);
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
