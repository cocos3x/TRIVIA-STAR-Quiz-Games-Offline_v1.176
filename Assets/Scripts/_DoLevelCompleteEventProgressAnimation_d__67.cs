using UnityEngine;
private sealed class WordHuntEvent.<DoLevelCompleteEventProgressAnimation>d__67 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGEventButtonV2 eventProgressUI;
    public WordHuntEvent <>4__this;
    public WGEventButtonV2 eventButton;
    private WordHuntEvent.<>c__DisplayClass67_1 <>8__1;
    private WordHuntEvent.<>c__DisplayClass67_2 <>8__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WordHuntEvent.<DoLevelCompleteEventProgressAnimation>d__67(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        WordHuntEvent.<>c__DisplayClass67_1 val_60;
        WordHuntEvent val_61;
        val_60 = 0;
        if((this.<>1__state) > 6)
        {
                return (bool);
        }
        
        val_61 = this.<>4__this;
        var val_1 = 12599204 + (12599204 + (this.<>1__state) << 2);
        if((this.<>1__state) == 6)
        {
                mem2[0] = val_60 + R8;
            mem2[0] = (val_60 + R8 & (IP) << val_60 + R8) + IP;
            mem2[0] = ((val_60 + R8 & (IP) << val_60 + R8) + IP & (IP) >> (val_60 + R8 & (IP) << val_60 + R8) + IP) + this;
            val_60 = ((((val_60 + R8 & (IP) << val_60 + R8) + IP & (IP) >> (val_60 + R8 & (IP) << val_60 + R8) + IP) + this) & ((R8) >> 32)) & ((IP) << (((val_60 + R8 & (IP) << val_60 + R8) + IP & (IP) >> (val_60 + R8 & (IP) << val_60 + R8) + IP) + this & (R8) >> 32));
        }
        
        this.<>1__state = 0;
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
