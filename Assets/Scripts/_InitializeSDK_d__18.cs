using UnityEngine;
private sealed class ApplovinMaxPlugin.<InitializeSDK>d__18 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public ApplovinMaxPlugin <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ApplovinMaxPlugin.<InitializeSDK>d__18(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        int val_6;
        var val_7;
        var val_8;
        val_5 = this;
        val_6 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = null;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_6 = 1;
            this.<>1__state = val_6;
            this.<>2__current = val_1;
            return (bool)val_6;
        }
        
        this.<>1__state = 0;
        val_5 = 1152921504895930368;
        val_7 = null;
        val_7 = null;
        if(ApplovinMaxPlugin.initialized == true)
        {
                return (bool)val_6;
        }
        
        val_6 = 0;
        if(DeviceIdPlugin.IsEmulator() == true)
        {
                return (bool)val_6;
        }
        
        System.Action<twelvegigs.storage.JsonDictionary> val_3 = new System.Action<twelvegigs.storage.JsonDictionary>(object:  this.<>4__this, method:  new IntPtr(2428313312));
        MaxSdkCallbacks.add_OnSdkInitializedEvent(value:  7401472);
        AppConfigs val_4 = App.Configuration;
        MaxSdkAndroid.SetSdkKey(sdkKey:  .__il2cppRuntimeField_58);
        .__il2cppRuntimeField_58.SetupAdUnits();
        val_6 = 0;
        MaxSdkAndroid.InitializeSdk(adUnitIds:  null);
        val_8 = null;
        val_8 = null;
        ApplovinMaxPlugin.initialized = true;
        return (bool)val_6;
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
