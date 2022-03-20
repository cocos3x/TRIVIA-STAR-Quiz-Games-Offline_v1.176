using UnityEngine;
private sealed class WPTGameUIController.<ProceedTutorial>d__125 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float delay;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WPTGameUIController.<ProceedTutorial>d__125(int <>1__state)
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
        var val_9;
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
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        object val_3 = GetWindow<System.Object>();
        if((public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance()) != 0)
        {
                val_9 = null;
            val_9 = null;
            if(((as. 
           
           
          
        
        
        
        .__il2cppRuntimeField_64 + (WordPetsFTUXDemoWindow.__il2cppRuntimeField_typeHierarchyDepth) << 2) + -4) != val_9)
        {
                public static WGWindowManager MonoSingleton<WGWindowManager>::get_Instance() = 0;
        }
        
        }
        
        val_7 = 0;
        bool val_6 = 0.Proceed(target:  0);
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
