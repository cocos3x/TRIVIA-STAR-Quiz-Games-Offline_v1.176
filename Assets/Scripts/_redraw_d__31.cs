using UnityEngine;
private sealed class TRVQuestionComplete.<redraw>d__31 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVQuestionComplete <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVQuestionComplete.<redraw>d__31(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        if((this.<>1__state) <= 3)
        {
                var val_1 = 12041296 + (12041296 + (this.<>1__state) << 2);
            if((this.<>1__state) == 3)
        {
                12041296 + (this.<>1__state) << 2 = (12041296 + (this.<>1__state) << 2) & ((12041296 + (this.<>1__state) << 2) << (12041296 + (this.<>1__state) << 2));
            12041296 + (this.<>1__state) << 2 = (12041296 + (this.<>1__state) << 2) & ((IP) >> 32);
            12041296 + (this.<>1__state) << 2 = (12041296 + (this.<>1__state) << 2) & (((R8) << (32-((12041296 + (this.<>1__state) << 2 & (12041296 + (this.<>1__state) << 2) << 12041296 + (this.<>1__state) << 2) & (IP) >> 32))) | ((R8) << ((12041296 + (this.<>1__state) << 2 & (12041296 + (this.<>1__state) << 2) << 12041296 + (this.<>1__state) << 2) & (IP) >> 32)));
            12041296 + (this.<>1__state) << 2 = (12041296 + (this.<>1__state) << 2) & (-225791944);
        }
        
            val_4 = 1;
            this.<>1__state = val_4;
            this.<>2__current = 0;
            return (bool);
        }
        
        val_4 = 0;
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
