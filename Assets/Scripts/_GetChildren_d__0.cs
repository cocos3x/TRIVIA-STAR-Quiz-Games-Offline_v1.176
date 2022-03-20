using UnityEngine;
private sealed class SRFTransformExtensions.<GetChildren>d__0 : IEnumerable<UnityEngine.Transform>, IEnumerable, IEnumerator<UnityEngine.Transform>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private UnityEngine.Transform <>2__current;
    private int <>l__initialThreadId;
    private UnityEngine.Transform t;
    public UnityEngine.Transform <>3__t;
    private int <i>5__2;
    
    // Properties
    private UnityEngine.Transform System.Collections.Generic.IEnumerator<UnityEngine.Transform>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SRFTransformExtensions.<GetChildren>d__0(int <>1__state)
    {
        this.<>1__state = <>1__state;
        this.<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        int val_5;
        UnityEngine.Transform val_6;
        if((this.<>1__state) != 1)
        {
                val_4 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
            val_5 = 0;
            this.<i>5__2 = val_5;
            this.<>1__state = 0;
        }
        else
        {
                this.<>1__state = 0;
            val_5 = (this.<i>5__2) + 1;
            this.<i>5__2 = val_5;
        }
        
        val_6 = this.t;
        val_4 = 0;
        if(val_5 >= val_6.childCount)
        {
                return (bool)val_4;
        }
        
        val_6 = this.<i>5__2;
        UnityEngine.Transform val_2 = this.t.GetChild(index:  val_6);
        val_4 = 1;
        this.<>1__state = val_4;
        this.<>2__current = this.t;
        return (bool)val_4;
    }
    private UnityEngine.Transform System.Collections.Generic.IEnumerator<UnityEngine.Transform>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }
    private System.Collections.Generic.IEnumerator<UnityEngine.Transform> System.Collections.Generic.IEnumerable<UnityEngine.Transform>.GetEnumerator()
    {
        int val_4;
        var val_5;
        if((this.<>1__state) != 2)
        {
            goto label_2;
        }
        
        val_4 = this.<>l__initialThreadId;
        if(val_4 != System.Environment.CurrentManagedThreadId)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_5 = this;
        goto label_3;
        label_2:
        object val_2 = null;
        val_5 = val_2;
        val_4 = 0;
        val_2 = new System.Object();
        typeof(SRFTransformExtensions.<GetChildren>d__0).__il2cppRuntimeField_8 = val_4;
        typeof(SRFTransformExtensions.<GetChildren>d__0).__il2cppRuntimeField_10 = System.Environment.CurrentManagedThreadId;
        if(val_5 == 0)
        {
            goto label_4;
        }
        
        label_3:
        typeof(SRFTransformExtensions.<GetChildren>d__0).__il2cppRuntimeField_14 = this.<>3__t;
        return;
        label_4:
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<UnityEngine.Transform>.GetEnumerator();
    }

}
