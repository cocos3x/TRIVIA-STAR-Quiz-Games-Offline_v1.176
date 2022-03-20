using UnityEngine;
private sealed class WordGameEventsController.<UpdateLeaderboardData>d__44 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordGameEventsController <>4__this;
    public int seconds;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WordGameEventsController.<UpdateLeaderboardData>d__44(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        if((this.<>1__state) > 1)
        {
                return (bool)0;
        }
        
        this.<>1__state = 0;
        this.<>4__this.OnAppleAwarded(appleAwarded:  0);
        0 = 1;
        this.<>1__state = 0;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.seconds);
        return (bool)0;
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
