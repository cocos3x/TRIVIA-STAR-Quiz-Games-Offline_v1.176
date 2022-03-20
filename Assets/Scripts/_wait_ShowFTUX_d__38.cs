using UnityEngine;
private sealed class WGFTUXManager.<wait_ShowFTUX>d__38 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGFTUXManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGFTUXManager.<wait_ShowFTUX>d__38(int <>1__state)
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
        if((this.<>1__state) != 1)
        {
                val_10 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_10;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForEndOfFrame val_1 = null;
            val_11 = val_1;
            val_1 = new UnityEngine.WaitForEndOfFrame();
            val_10 = 1;
            this.<>1__state = val_10;
            this.<>2__current = val_11;
            return (bool)val_10;
        }
        
        val_11 = this.<>4__this;
        this.<>1__state = 0;
        WordRegion val_2 = WordRegion.instance;
        if(0 != 0)
        {
                WordRegion val_4 = WordRegion.instance;
            val_10 = 0;
            System.Collections.Generic.List<System.String> val_5 = 0.GetCompletedWords();
            if(0 != 0)
        {
                return (bool)val_10;
        }
        
        }
        
        twelvegigs.Autopilot.AutopilotManager val_6 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        CloseCurrentWindow();
        GameBehavior val_7 = App.getBehavior;
        twelvegigs.Autopilot.AutopilotManager val_8 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_9 = GetWindow<System.Object>();
        val_10 = 0;
        this.<>4__this.currDemoWindow = public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance();
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
