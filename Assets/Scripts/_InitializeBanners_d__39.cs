using UnityEngine;
private sealed class ApplovinMaxPlugin.<InitializeBanners>d__39 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public ApplovinMaxPlugin <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ApplovinMaxPlugin.<InitializeBanners>d__39(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        object val_8;
        if((this.<>1__state) != 1)
        {
                val_7 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_7;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = null;
            val_8 = val_1;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_7 = 1;
            this.<>1__state = val_7;
            this.<>2__current = val_8;
            return (bool)val_7;
        }
        
        this.<>1__state = 0;
        System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  this.<>4__this, method:  new IntPtr(2429011936));
        val_7 = 0;
        MaxSdkCallbacks.add_OnBannerAdClickedEvent(value:  7401472);
        System.Action<twelvegigs.storage.JsonDictionary> val_3 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  this.<>4__this, method:  new IntPtr(2429012960));
        MaxSdkCallbacks.add_OnBannerAdCollapsedEvent(value:  7401472);
        System.Action<twelvegigs.storage.JsonDictionary> val_4 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  this.<>4__this, method:  new IntPtr(2429013984));
        MaxSdkCallbacks.add_OnBannerAdExpandedEvent(value:  7401472);
        System.Action<twelvegigs.storage.JsonDictionary> val_5 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  this.<>4__this, method:  new IntPtr(2429015008));
        MaxSdkCallbacks.add_OnBannerAdLoadedEvent(value:  7401472);
        val_8 = null;
        val_8 = new System.Action<System.String, System.Int32>(object:  this.<>4__this, method:  new IntPtr(2429016032));
        MaxSdkCallbacks.add_OnBannerAdLoadFailedEvent(value:  7507968);
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
