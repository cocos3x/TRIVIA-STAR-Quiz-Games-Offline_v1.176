using UnityEngine;
private sealed class WordMemoryUIController.<FaceUpOnStart>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Minigames.WordMemory.WordMemoryUIController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WordMemoryUIController.<FaceUpOnStart>d__12(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_4 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
        this.<>1__state = 0;
        this.<>1__state = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
        return true;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.FaceDownAll();
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_4 = 0;
        public static SLC.Minigames.WordMemory.WordMemoryManager MonoSingleton<SLC.Minigames.WordMemory.WordMemoryManager>::get_Instance().__il2cppRuntimeField_45 = val_4;
        return (bool)val_4;
        label_2:
        this.<>1__state = 0;
        this.<>4__this.FaceUpAll();
        this.<>1__state = 2;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
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
