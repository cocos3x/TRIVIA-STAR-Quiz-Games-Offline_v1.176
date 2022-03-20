using UnityEngine;
private sealed class PrefsSerializationManager.<SaveAtEndOfFrame>d__4 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public PrefsSerializationManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PrefsSerializationManager.<SaveAtEndOfFrame>d__4(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        var val_3;
        if((this.<>1__state) != 1)
        {
                val_2 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_2;
        }
        
            this.<>1__state = 0;
            val_2 = 1;
            this.<>1__state = val_2;
            this.<>2__current = new UnityEngine.WaitForEndOfFrame();
            return (bool)val_2;
        }
        
        this.<>1__state = 0;
        UnityEngine.PlayerPrefs.Save();
        this.<>4__this.shouldSaveThisFrame = false;
        val_3 = null;
        val_3 = null;
        if(PrefsSerializationManager.LOGGING != false)
        {
                val_2 = 0;
            UnityEngine.Debug.LogError(message:  -2013748688, context:  this.<>4__this);
            return (bool)val_2;
        }
        
        val_2 = 0;
        return (bool)val_2;
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
