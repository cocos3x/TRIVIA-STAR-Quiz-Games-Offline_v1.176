using UnityEngine;
private sealed class LineWord.<IEShowAnswer>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float waitBeforePlaying;
    public LineWord <>4__this;
    private System.Collections.Generic.List.Enumerator<Cell> <>7__wrap1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineWord.<IEShowAnswer>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
        if((this.<>1__state) != 3)
        {
                return;
        }
        
        this.<>m__Finally1();
    }
    private bool MoveNext()
    {
        int val_7;
        LineWord val_8;
        UnityEngine.Transform val_9;
        List.Enumerator<Cell> val_10;
        val_7 = 0;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        val_8 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_7;
        }
        
        this.<>1__state = 0;
        if((this.<>1__state) <= 0)
        {
            goto label_4;
        }
        
        UnityEngine.WaitForSeconds val_1 = null;
        val_8 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_7 = 1;
        this.<>1__state = val_7;
        goto label_5;
        label_2:
        this.<>1__state = 0;
        label_4:
        val_9;
        List.Enumerator<T> val_2 = GetEnumerator();
        this.<>1__state = 2;
        goto label_8;
        label_1:
        val_10 = this.<>7__wrap1;
        this.<>1__state = 2;
        label_8:
        if(val_10.MoveNext() == false)
        {
            goto label_9;
        }
        
        if(val_10 == 0)
        {
            goto label_10;
        }
        
        mem2[0] = 1;
        goto label_11;
        label_9:
        this.<>m__Finally1();
        return (bool)val_7;
        label_10:
        mem[36] = 1;
        label_11:
        val_9 = mem[this.<>7__wrap1 + 16];
        if(val_9.activeSelf != true)
        {
                UnityEngine.Transform val_5 = TextPreview.instance.transform;
            val_9 = TextPreview.instance;
            val_10.Animate(from:  val_9, fromParent:  160649216);
        }
        
        UnityEngine.WaitForSeconds val_6 = null;
        val_8 = val_6;
        val_6 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_7 = 1;
        this.<>1__state = 2;
        label_5:
        this.<>2__current = val_8;
        return (bool)val_7;
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        this.<>7__wrap1.Dispose();
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
