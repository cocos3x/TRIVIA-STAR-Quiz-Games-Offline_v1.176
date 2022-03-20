using UnityEngine;
private sealed class WPTGameUIController.<ClearCurrentGrid>d__112 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordPets.WPTGameUIController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WPTGameUIController.<ClearCurrentGrid>d__112(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        UnityEngine.Transform val_8;
        int val_9;
        val_7 = 0;
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
                return (bool)val_7;
        }
        
        this.<>1__state = 0;
        val_8 = this.<>4__this.columnParent;
        val_7 = 0;
        if(val_8.childCount > 0)
        {
            goto label_11;
        }
        
        return (bool)val_7;
        label_1:
        val_9 = 0;
        goto label_8;
        label_2:
        this.<>1__state = 0;
        if((this.<>4__this.columnParent.childCount) >= 1)
        {
                UnityEngine.Transform val_3 = this.<>4__this.columnParent.GetChild(index:  0);
            UnityEngine.GameObject val_4 = this.<>4__this.columnParent.gameObject;
            UnityEngine.Object.Destroy(obj:  this.<>4__this.columnParent);
        }
        
        label_11:
        UnityEngine.WaitForEndOfFrame val_6 = null;
        val_8 = val_6;
        val_6 = new UnityEngine.WaitForEndOfFrame();
        this.<>2__current = val_8;
        if((this.<>4__this.columnParent.childCount) > 0)
        {
                val_7 = 1;
            this.<>1__state = val_7;
            return (bool)val_7;
        }
        
        val_9 = 2;
        val_7 = 1;
        label_8:
        this.<>1__state = val_9;
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
