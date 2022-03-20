using UnityEngine;
private sealed class RESFTUXManager.<ShowPopup>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public System.Action onComplete;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RESFTUXManager.<ShowPopup>d__7(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        var val_6;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_5 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_5;
        }
        
        this.<>1__state = 0;
        this.<>1__state = 1;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        return true;
        label_1:
        this.<>1__state = 0;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_3 = ShowUGUIMonolith<System.Object>(showNext:  false);
        val_6 = null;
        val_6 = null;
        RestaurantRivals.RESFTUXManager.slotPlayDemoPopup = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
        val_5 = 0;
        public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance().__il2cppRuntimeField_98 = this.onComplete;
        return (bool)val_5;
        label_2:
        this.<>1__state = 0;
        this.<>1__state = 2;
        this.<>2__current = new UnityEngine.WaitForEndOfFrame();
        return true;
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
