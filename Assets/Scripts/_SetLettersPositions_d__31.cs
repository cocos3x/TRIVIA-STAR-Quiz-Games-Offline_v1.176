using UnityEngine;
private sealed class WOLUIGrid.<SetLettersPositions>d__31 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Wordlicious.WOLUIGrid <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WOLUIGrid.<SetLettersPositions>d__31(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        var val_6;
        var val_7;
        if((this.<>1__state) != 1)
        {
                val_5 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_5;
        }
        
            this.<>1__state = 0;
            val_5 = 1;
            this.<>1__state = val_5;
            this.<>2__current = new UnityEngine.WaitForEndOfFrame();
            return (bool)val_5;
        }
        
        this.<>1__state = 0;
        val_6 = 4;
        val_7 = 0;
        goto label_4;
        label_22:
        if(0 <= SL)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Transform val_2 = 2621443.transform;
        if(2621443 <= SL)
        {
                var val_6 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_6 = val_6 + val_7;
        2621443.localPosition = new UnityEngine.Vector3() {x = (0 + val_7) + 16, y = (0 + val_7) + 20, z = (0 + val_7) + 24};
        if(2621443 <= SL)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Transform val_3 = 2621443.transform;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        2621443.localScale = new UnityEngine.Vector3();
        if(2621443 <= SL)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        2621443.UpdateTile();
        val_6 = val_6 + 1;
        val_7 = 12;
        label_4:
        if((val_6 - 4) < 2621443)
        {
            goto label_22;
        }
        
        val_5 = 0;
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
