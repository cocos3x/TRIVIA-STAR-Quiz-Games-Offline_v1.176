using UnityEngine;
private sealed class WGLeaguesLoadingPopup.<OnDataUpdate>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGLeaguesLoadingPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGLeaguesLoadingPopup.<OnDataUpdate>d__12(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        var val_8;
        var val_9;
        val_7 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_7;
        }
        
            this.<>1__state = 0;
            val_7 = 0;
            if((this.<>4__this.enabled) == false)
        {
                return (bool)val_7;
        }
        
            val_7 = 0;
            UnityEngine.GameObject val_2 = this.<>4__this.gameObject;
            val_8 = this.<>4__this;
            if(val_8.activeInHierarchy == false)
        {
                return (bool)val_7;
        }
        
            val_8 = 1152921504905461760;
            val_9 = null;
            val_9 = null;
            if(WGLeaguesLoadingPopup.loadingLeagues == false)
        {
                return (bool)val_7;
        }
        
            NotificationCenter val_4 = NotificationCenter.DefaultCenter;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.RemoveObserver(observer:  this.<>4__this, name:  442544128);
            NotificationCenter val_5 = NotificationCenter.DefaultCenter;
            val_8 = null;
            UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            0.RemoveObserver(observer:  this.<>4__this, name:  442544128);
            System.Collections.IEnumerator val_6 = this.<>4__this.WaitLoadLeagues();
            val_7 = 1;
            this.<>1__state = val_7;
            this.<>2__current = this.<>4__this;
            return (bool)val_7;
        }
        
        this.<>1__state = 0;
        return (bool)val_7;
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
