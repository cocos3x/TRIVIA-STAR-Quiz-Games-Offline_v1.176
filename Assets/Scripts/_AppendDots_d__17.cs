using UnityEngine;
private sealed class DisplayWordDefinition.<AppendDots>d__17 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public DisplayWordDefinition <>4__this;
    private int <dots>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DisplayWordDefinition.<AppendDots>d__17(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        int val_6;
        if((this.<>1__state) != 1)
        {
                val_5 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_5;
        }
        
            this.<dots>5__2 = 0;
        }
        
        this.<>1__state = 0;
        val_5 = 0;
        UnityEngine.GameObject val_1 = this.<>4__this.gameObject;
        if((this.<>4__this.activeInHierarchy) == false)
        {
                return (bool)val_5;
        }
        
        if((this.<dots>5__2) > 2)
        {
                val_6 = 0;
        }
        else
        {
                string val_3 = this.<>4__this.definitionText(this.<>4__this.definitionText) + -954584368(-954584368);
            val_6 = (this.<dots>5__2) + 1;
        }
        
        this.<dots>5__2 = val_6;
        UnityEngine.WaitForSeconds val_4 = null;
        val_4 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_5 = 1;
        this.<>1__state = val_5;
        this.<>2__current = val_4;
        return (bool)val_5;
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
