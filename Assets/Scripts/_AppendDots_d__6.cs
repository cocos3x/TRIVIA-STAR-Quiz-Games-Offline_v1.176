using UnityEngine;
private sealed class LoadingText.<AppendDots>d__6 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public RestaurantRivals.LoadingText <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LoadingText.<AppendDots>d__6(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        UnityEngine.UI.Text val_5;
        string val_6;
        int val_7;
        object val_8;
        val_4 = 0;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_4;
        }
        
        val_5 = this.<>4__this.text;
        val_6 = this.<>4__this.currentText;
        goto label_5;
        label_1:
        val_7 = 0;
        goto label_6;
        label_2:
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_7;
        }
        
        this.<>4__this.LoopDots();
        goto label_8;
        label_4:
        val_5 = 2621443;
        val_6 = 1;
        label_5:
        string val_1 = 1 + this.<>4__this.dots(this.<>4__this.dots);
        UnityEngine.WaitForSeconds val_2 = null;
        val_8 = val_2;
        val_2 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_7 = 1;
        goto label_10;
        label_7:
        0.LoopDots();
        label_8:
        System.Collections.IEnumerator val_3 = this.<>4__this.AppendDots();
        val_8 = this.<>4__this;
        val_7 = 2;
        label_10:
        val_4 = 1;
        this.<>2__current = val_8;
        label_6:
        this.<>1__state = val_7;
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
