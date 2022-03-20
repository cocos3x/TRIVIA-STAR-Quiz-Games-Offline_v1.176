using UnityEngine;
private sealed class ApplovinMaxPlugin.<InitializeRewardedVideos>d__53 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public ApplovinMaxPlugin <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ApplovinMaxPlugin.<InitializeRewardedVideos>d__53(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Action<System.Threading.Tasks.Task, System.Object> val_10;
        int val_11;
        val_10 = this;
        if((this.<>1__state) != 1)
        {
                val_11 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_11;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = null;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_11 = 1;
            this.<>1__state = val_11;
            this.<>2__current = val_1;
            return (bool)val_11;
        }
        
        this.<>1__state = 0;
        System.Action<twelvegigs.storage.JsonDictionary> val_2 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  this.<>4__this, method:  new IntPtr(2429714656));
        val_11 = 0;
        MaxSdkCallbacks.add_OnRewardedAdLoadedEvent(value:  7401472);
        System.Action<twelvegigs.storage.JsonDictionary> val_3 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  this.<>4__this, method:  new IntPtr(2429715680));
        MaxSdkCallbacks.add_OnRewardedAdHiddenEvent(value:  7401472);
        System.Action<System.String, System.Int32> val_4 = new System.Action<System.String, System.Int32>(object:  this.<>4__this, method:  new IntPtr(2429716704));
        MaxSdkCallbacks.add_OnRewardedAdLoadFailedEvent(value:  7507968);
        System.Action<System.String, System.Int32> val_5 = new System.Action<System.String, System.Int32>(object:  this.<>4__this, method:  new IntPtr(2429717728));
        MaxSdkCallbacks.add_OnRewardedAdFailedToDisplayEvent(value:  7507968);
        System.Action<twelvegigs.storage.JsonDictionary> val_6 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  this.<>4__this, method:  new IntPtr(2429718752));
        MaxSdkCallbacks.add_OnRewardedAdClickedEvent(value:  7401472);
        System.Action<System.String, Reward> val_7 = new System.Action<System.String, Reward>(object:  this.<>4__this, method:  new IntPtr(2429719776));
        MaxSdkCallbacks.add_OnRewardedAdReceivedRewardEvent(value:  7507968);
        System.Action<twelvegigs.storage.JsonDictionary> val_8 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  this.<>4__this, method:  new IntPtr(2429720800));
        MaxSdkCallbacks.add_OnRewardedAdDisplayedEvent(value:  7401472);
        val_10 = null;
        val_10 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  this.<>4__this, method:  new IntPtr(2429721824));
        MaxSdkCallbacks.Rewarded.add_OnAdRevenuePaidEvent(value:  7507968);
        LoadRewardedVideo();
        return (bool)val_11;
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
