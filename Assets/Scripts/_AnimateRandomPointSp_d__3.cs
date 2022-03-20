using UnityEngine;
private sealed class WGSnakesAndLaddersDiceRollAnim.<AnimateRandomPointSp>d__3 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGSnakesAndLaddersDiceRollAnim <>4__this;
    public int result;
    private System.Collections.Generic.List<UnityEngine.Sprite> <sprites>5__2;
    private float <animationDuration>5__3;
    private System.DateTime <startTime>5__4;
    private int <i>5__5;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGSnakesAndLaddersDiceRollAnim.<AnimateRandomPointSp>d__3(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_19;
        System.Collections.Generic.List<UnityEngine.Sprite> val_20;
        val_19 = 0;
        if((this.<>1__state) > 6)
        {
                return (bool);
        }
        
        var val_1 = 7058340 + (7058340 + (this.<>1__state) << 2);
        if((this.<>1__state) == 6)
        {
                7058340 + (this.<>1__state) << 2 = (7058340 + (this.<>1__state) << 2) & ((IP) << 7058340 + (this.<>1__state) << 2);
            7058340 + (this.<>1__state) << 2 = (7058340 + (this.<>1__state) << 2) & ((IP) >> 32);
            7058340 + (this.<>1__state) << 2 = (7058340 + (this.<>1__state) << 2) & ((R8) >> 7058340);
            7058340 + (this.<>1__state) << 2 = (7058340 + (this.<>1__state) << 2) & (((int)IP) >> 2);
            7058340 + (this.<>1__state) << 2 = (7058340 + (this.<>1__state) << 2) & (((((((7058340 + (this.<>1__state) << 2 & (IP) << 7058340 + (this.<>1__state) << 2) & (IP) >> 32) & (R8) >> 7058340) & ((int)IP) >> 2)) << (32-3)) | ((((((7058340 + (this.<>1__state) << 2 & (IP) << 7058340 + (this.<>1__state) << 2) & (IP) >> 32) & (R8) >> 7058340) & ((int)IP) >> 2)) << 3));
            7058340 + (this.<>1__state) << 2 = (7058340 + (this.<>1__state) << 2) & ((7058340 + (this.<>1__state) << 2) >> 7);
        }
        
        val_19 = 1;
        val_20 = 0;
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
