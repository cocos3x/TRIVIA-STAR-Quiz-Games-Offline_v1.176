using UnityEngine;
private sealed class ApplovinMaxPlugin.<InitializeInterstitials>d__68 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public ApplovinMaxPlugin <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ApplovinMaxPlugin.<InitializeInterstitials>d__68(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_10;
        object val_11;
        val_10 = 0;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_10;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_1 = null;
        val_11 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_10 = 1;
        this.<>1__state = val_10;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        0.LoadInterstitial();
        return (bool)val_10;
        label_2:
        this.<>1__state = 0;
        System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  this.<>4__this, method:  new IntPtr(2430421472));
        MaxSdkCallbacks.add_OnInterstitialLoadedEvent(value:  7401472);
        System.Action<System.String, System.Int32> val_3 = new System.Action<System.String, System.Int32>(object:  this.<>4__this, method:  new IntPtr(2430422496));
        MaxSdkCallbacks.add_OnInterstitialLoadFailedEvent(value:  7507968);
        System.Action<System.String, System.Int32> val_4 = new System.Action<System.String, System.Int32>(object:  this.<>4__this, method:  new IntPtr(2430423520));
        MaxSdkCallbacks.add_OnInterstitialAdFailedToDisplayEvent(value:  7507968);
        System.Action<twelvegigs.storage.JsonDictionary> val_5 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  this.<>4__this, method:  new IntPtr(2430424544));
        MaxSdkCallbacks.add_OnInterstitialHiddenEvent(value:  7401472);
        System.Action<twelvegigs.storage.JsonDictionary> val_6 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  this.<>4__this, method:  new IntPtr(2430425568));
        MaxSdkCallbacks.add_OnInterstitialClickedEvent(value:  7401472);
        System.Action<twelvegigs.storage.JsonDictionary> val_7 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  this.<>4__this, method:  new IntPtr(2430426592));
        MaxSdkCallbacks.add_OnInterstitialDisplayedEvent(value:  7401472);
        System.Action<System.Threading.Tasks.Task, System.Object> val_8 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  this.<>4__this, method:  new IntPtr(2430427616));
        MaxSdkCallbacks.Interstitial.add_OnAdRevenuePaidEvent(value:  7507968);
        UnityEngine.WaitForSeconds val_9 = null;
        val_11 = val_9;
        val_9 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_10 = 1;
        this.<>1__state = 2;
        label_4:
        this.<>2__current = val_11;
        return (bool)val_10;
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
