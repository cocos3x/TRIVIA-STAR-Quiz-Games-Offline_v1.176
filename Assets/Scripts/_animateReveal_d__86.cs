using UnityEngine;
private sealed class TRVLevelComplete.<animateReveal>d__86 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVPickerGameButton selected;
    public TRVLevelComplete <>4__this;
    public bool rerollAvailable;
    private System.Collections.Generic.Dictionary.KeyCollection.Enumerator<TRVPickerGameButton, int> <>7__wrap1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVLevelComplete.<animateReveal>d__86(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
        if((this.<>1__state) != 3)
        {
                return;
        }
        
        this.<>m__Finally1();
    }
    private bool MoveNext()
    {
        int val_18;
        object val_19;
        val_18 = 0;
        if((this.<>1__state) > 3)
        {
                return (bool);
        }
        
        var val_1 = 10804992 + (10804992 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                10804992 + (this.<>1__state) << 2 = (10804992 + (this.<>1__state) << 2) & ((10804992 + (this.<>1__state) << 2) << (10804992 + (this.<>1__state) << 2));
            10804992 + (this.<>1__state) << 2 = (10804992 + (this.<>1__state) << 2) & (((int)R8) >> 1);
            10804992 + (this.<>1__state) << 2 = (10804992 + (this.<>1__state) << 2) & (((((10804992 + (this.<>1__state) << 2 & (10804992 + (this.<>1__state) << 2) << 10804992 + (this.<>1__state) << 2) & ((int)R8) >> 1)) << (32-((10804992 + (this.<>1__state) << 2 & (10804992 + (this.<>1__state) << 2) << 10804992 + (this.<>1__state) << 2) & ((int)R8) >> 1))) | ((((10804992 + (this.<>1__state) << 2 & (10804992 + (this.<>1__state) << 2) << 10804992 + (this.<>1__state) << 2) & ((int)R8) >> 1)) << ((10804992 + (this.<>1__state) << 2 & (10804992 + (this.<>1__state) << 2) << 10804992 + (this.<>1__state) << 2) & ((int)R8) >> 1)));
            10804992 + (this.<>1__state) << 2 = (10804992 + (this.<>1__state) << 2) & ((10804992 + (this.<>1__state) << 2) << 1);
        }
        
        this.<>1__state = 0;
        System.Collections.IEnumerator val_2 = this.selected.doReveal(selected:  true);
        UnityEngine.Coroutine val_3 = this.selected.StartCoroutine(routine:  this.selected);
        UnityEngine.WaitForSeconds val_4 = null;
        val_19 = val_4;
        val_4 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_18 = 1;
        this.<>1__state = val_18;
        this.<>2__current = ;
        return (bool);
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        this.<>7__wrap1.Dispose();
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
