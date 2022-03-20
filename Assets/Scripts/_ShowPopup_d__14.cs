using UnityEngine;
private sealed class WGLevelChallengeProgressPopup.<ShowPopup>d__14 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float delay;
    public WGLevelChallengeProgressPopup <>4__this;
    public float duration;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGLevelChallengeProgressPopup.<ShowPopup>d__14(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_8;
        if((this.<>1__state) <= 4)
        {
                var val_1 = 6934360 + (6934360 + (this.<>1__state) << 2);
            if((this.<>1__state) == 4)
        {
                6934360 + (this.<>1__state) << 2 = (6934360 + (this.<>1__state) << 2) & (this << (6934360 + (this.<>1__state) << 2));
            6934360 + (this.<>1__state) << 2 = (6934360 + (this.<>1__state) << 2) & (((int)R8) >> (6934360 + (this.<>1__state) << 2 & (this) << 6934360 + (this.<>1__state) << 2));
            mem2[0] = ((6934360 + (this.<>1__state) << 2 & (this) << 6934360 + (this.<>1__state) << 2) & ((int)R8) >> (6934360 + (this.<>1__state) << 2 & (this) << 6934360 + (this.<>1__state) << 2)) + ((6934360 + (this.<>1__state) << 2 & (this) << 6934360 + (this.<>1__state) << 2) & ((int)R8) >> (6934360 + (this.<>1__state) << 2 & (this) << 6934360 + (this.<>1__state) << 2));
            mem2[0] = ((6934360 + (this.<>1__state) << 2 & (this) << 6934360 + (this.<>1__state) << 2) & ((int)R8) >> (6934360 + (this.<>1__state) << 2 & (this) << 6934360 + (this.<>1__state) << 2)) + ((6934360 + (this.<>1__state) << 2 & (this) << 6934360 + (this.<>1__state) << 2) & ((int)R8) >> (6934360 + (this.<>1__state) << 2 & (this) << 6934360 + (this.<>1__state) << 2)) + ((6934360 + (this.<>1__state) << 2 & (this) << 6934360 + (this.<>1__state) << 2) & ((int)R8) >> (6934360 + (this.<>1__state) << 2 & (this) << 6934360 + (this.<>1__state) << 2)) + ((6934360 + (this.<>1__state) << 2 & (this) << 6934360 + (this.<>1__state) << 2) & ((int)R8) >> (6934360 + (this.<>1__state) << 2 & (this) << 6934360 + (this.<>1__state) << 2));
        }
        
            this.<>1__state = 0;
            val_8 = 1;
            this.<>1__state = val_8;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
            return (bool);
        }
        
        val_8 = 0;
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
