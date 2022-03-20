using UnityEngine;
private sealed class WPTGameUIController.<GenerateNewGrid>d__113 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordPets.WPTGameUIController <>4__this;
    private System.Collections.Generic.List<char> <characters>5__2;
    private int <col>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WPTGameUIController.<GenerateNewGrid>d__113(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_17;
        int val_18;
        if((this.<>1__state) > 3)
        {
            goto label_1;
        }
        
        var val_1 = 12956428 + (12956428 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                12956428 + (this.<>1__state) << 2 = (12956428 + (this.<>1__state) << 2) & ((12956428 + (this.<>1__state) << 2) << (12956428 + (this.<>1__state) << 2));
            12956428 + (this.<>1__state) << 2 = (12956428 + (this.<>1__state) << 2) & 142555292;
            12956428 + (this.<>1__state) << 2 = -4498088762876128960;
            12956428 + (this.<>1__state) << 2 = 164160;
        }
        
        this.<>1__state = 0;
        this.<>4__this.<currentColumns>k__BackingField = null;
        val_17 = 0;
        goto label_3;
        label_9:
        if((new System.Collections.Generic.List<twelvegigs.sweepstakes.Distribution>()) <= val_17)
        {
                var val_16 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_16 = val_16 + 0;
        WordPets.WPTGameColumn val_3 = this.<>4__this.AddNewCol(data:  (0 + 0) + 16);
        val_17 = 1;
        label_3:
        if(val_17 < (this.<>4__this))
        {
            goto label_9;
        }
        
        val_18 = 1;
        this.<>1__state = val_18;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        return (bool);
        label_1:
        val_18 = 0;
        return (bool);
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
