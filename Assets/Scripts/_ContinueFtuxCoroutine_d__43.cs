using UnityEngine;
private sealed class RaidScreenMain.<ContinueFtuxCoroutine>d__43 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordForest.RaidScreenMain <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RaidScreenMain.<ContinueFtuxCoroutine>d__43(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        int val_6;
        System.Collections.Generic.List<UnityEngine.GameObject> val_7;
        var val_8;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_6 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
        this.<>1__state = 0;
        val_7 = this.<>4__this.ftuxCursors;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_7:
        if(MoveNext() == false)
        {
            goto label_5;
        }
        
        val_3.SetActive(value:  false);
        goto label_7;
        label_1:
        val_8 = 0;
        this.<>1__state = 0;
        val_7 = 1152921511098470640;
        goto label_8;
        label_17:
        bool val_4 = this.<>4__this.chosenRewardIndexes.Contains(item:  0);
        if(val_4 != true)
        {
                if(val_4 <= val_8)
        {
                var val_6 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_6 = val_6 + 0;
            (0 + 0) + 16.SetActive(value:  true);
        }
        
        val_8 = 1;
        label_8:
        if(val_8 < ((0 + 0) + 16))
        {
            goto label_17;
        }
        
        val_6 = 0;
        return (bool)val_6;
        label_5:
        Dispose();
        val_6 = 0;
        if((public System.Void List.Enumerator<UnityEngine.GameObject>::Dispose()) > 2)
        {
                return (bool)val_6;
        }
        
        UnityEngine.WaitForSeconds val_5 = null;
        val_5 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_6 = 1;
        this.<>1__state = val_6;
        this.<>2__current = val_5;
        return (bool)val_6;
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
