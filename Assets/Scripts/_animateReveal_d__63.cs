using UnityEngine;
private sealed class FPHLevelCompletePopup.<animateReveal>d__63 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public FPHPickerGameButton selected;
    public FPHLevelCompletePopup <>4__this;
    private System.Collections.Generic.List.Enumerator<FPHPickerGameButton> <>7__wrap1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public FPHLevelCompletePopup.<animateReveal>d__63(int <>1__state)
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
        int val_16;
        object val_17;
        val_16 = 0;
        if((this.<>1__state) > 5)
        {
                return (bool);
        }
        
        var val_1 = 7085580 + (7085580 + (this.<>1__state) << 2);
        if((this.<>1__state) == 5)
        {
                7085580 + (this.<>1__state) << 2 = (7085580 + (this.<>1__state) << 2) & ((R8) << 7085580 + (this.<>1__state) << 2);
            7085580 + (this.<>1__state) << 2 = (7085580 + (this.<>1__state) << 2) & (((int)R8) >> 7085580);
            7085580 + (this.<>1__state) << 2 = (7085580 + (this.<>1__state) << 2) & (((((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) >> 7085580)) << (32-1)) | ((((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) >> 7085580)) << 1));
            mem2[0] = (((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) >> 7085580) & ((((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) > + (((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) >> 7085580) & ((((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) >;
            ((((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) >> 7085580) & ((((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) > + (((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) >> 7085580) & ((((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) >) & (((R8) << (32-(((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) >> 7085580) & ((((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) > + (((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) >> 7085580) & ((((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) >)) | ((R8) << (((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) >> 7085580) & ((((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) > + (((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) >> 7085580) & ((((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) >)) = (((((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) >> 7085580) & ((((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) > + (((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) >> 7085580) & ((((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) >) & (((R8) << (32-(((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) >> 7085580) & ((((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) > + (((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) >> 7085580) & ((((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) >)) | ((R8) << (((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) >> 7085580) & ((((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) > + (((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) >> 7085580) & ((((7085580 + (this.<>1__state) << 2 & (R8) << 7085580 + (this.<>1__state) << 2) & ((int)R8) >))) & 166821123;
        }
        
        this.<>1__state = 0;
        System.Collections.IEnumerator val_2 = this.selected.doReveal(selected:  true);
        UnityEngine.Coroutine val_3 = this.selected.StartCoroutine(routine:  this.selected);
        UnityEngine.WaitForSeconds val_4 = null;
        val_17 = val_4;
        val_4 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_16 = 1;
        this.<>1__state = val_16;
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
