using UnityEngine;
private sealed class Coroutines.<WaitForSecondsRealTime>d__0 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float time;
    private float <endTime>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Coroutines.<WaitForSecondsRealTime>d__0(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        if((this.<>1__state) != 1)
        {
                val_3 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
            this.<>1__state = 0;
            float val_1 = UnityEngine.Time.realtimeSinceStartup;
            float val_3 = this.time;
            val_3 = 0 + val_3;
            this.<endTime>5__2 = val_3;
        }
        else
        {
                this.<>1__state = 0;
        }
        
        val_3 = 0;
        float val_2 = UnityEngine.Time.realtimeSinceStartup;
        if((this.<>1__state) >= 0)
        {
                return (bool)val_3;
        }
        
        val_3 = 1;
        this.<>1__state = val_3;
        this.<>2__current = 0;
        return (bool)val_3;
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
