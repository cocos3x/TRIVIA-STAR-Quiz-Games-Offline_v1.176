using UnityEngine;
private sealed class TRVTriviaPursuitCategoryDisplay.<AnimatingCategory>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Collections.Generic.List<string> incCats;
    public TRVTriviaPursuitCategoryDisplay <>4__this;
    public TRVTriviaPursuitCategoryDisplayInfo finalInfo;
    private System.Collections.Generic.List<string> <allCategories>5__2;
    private float <animationDuration>5__3;
    private System.DateTime <startTime>5__4;
    private int <cat>5__5;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVTriviaPursuitCategoryDisplay.<AnimatingCategory>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_21;
        var val_22;
        val_21 = 0;
        if((this.<>1__state) > 6)
        {
                return (bool);
        }
        
        var val_1 = 8291792 + (8291792 + (this.<>1__state) << 2);
        if((this.<>1__state) == 6)
        {
                8291792 + (this.<>1__state) << 2 = (8291792 + (this.<>1__state) << 2) & ((IP) << 8291792 + (this.<>1__state) << 2);
            8291792 + (this.<>1__state) << 2 = (8291792 + (this.<>1__state) << 2) & ((IP) >> 32);
            8291792 + (this.<>1__state) << 2 = (8291792 + (this.<>1__state) << 2) & (((int)IP) >> 8291792);
            8291792 + (this.<>1__state) << 2 = (8291792 + (this.<>1__state) << 2) & ((((((8291792 + (this.<>1__state) << 2 & (IP) << 8291792 + (this.<>1__state) << 2) & (IP) >> 32) & ((int)IP) >> 8291792)) << (32-8291792)) | (((((8291792 + (this.<>1__state) << 2 & (IP) << 8291792 + (this.<>1__state) << 2) & (IP) >> 32) & ((int)IP) >> 8291792)) << 8291792));
            mem2[0] = ((((8291792 + (this.<>1__state) << 2 & (IP) << 8291792 + (this.<>1__state) << 2) & (IP) >> 32) & ((int)IP) >> 8291792) & (((((8291792 + (this.<>1__state) << 2 & (IP) << 8291792 + (this.<>1__state) <<  + IP;
            (((((8291792 + (this.<>1__state) << 2 & (IP) << 8291792 + (this.<>1__state) << 2) & (IP) >> 32) & ((int)IP) >> 8291792) & (((((8291792 + (this.<>1__state) << 2 & (IP) << 8291792 + (this.<>1__state) <<  + IP) & ((IP) >> 7) = IP * this;
        }
        
        val_21 = 1;
        val_22 = 0;
        this.<>1__state = 1;
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
