using UnityEngine;
private sealed class WordMemoryUIController.<DelayHidePair>d__17 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Minigames.WordMemory.WordMemoryUIController <>4__this;
    public int card1;
    public int card2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WordMemoryUIController.<DelayHidePair>d__17(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        if((this.<>1__state) != 1)
        {
                val_3 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
            this.<>1__state = 0;
            this.<>1__state = 1;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
            return true;
        }
        
        this.<>1__state = 0;
        if(0 <= this.card1)
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + (this.card1 << 2);
        (0 + (this.card1) << 2) + 16.Hide();
        if(((0 + (this.card1) << 2) + 16) <= this.card2)
        {
                var val_4 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = val_4 + (this.card2 << 2);
        (0 + (this.card2) << 2) + 16.Hide();
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_3 = 0;
        public static SLC.Minigames.WordMemory.WordMemoryManager MonoSingleton<SLC.Minigames.WordMemory.WordMemoryManager>::get_Instance().__il2cppRuntimeField_45 = val_3;
        return (bool)val_3;
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
