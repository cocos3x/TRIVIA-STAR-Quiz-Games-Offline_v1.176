using UnityEngine;
private sealed class WPTGameUIController.<DoEndOfTurnGridResolution>d__127 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordPets.WPTGameUIController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WPTGameUIController.<DoEndOfTurnGridResolution>d__127(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        if((this.<>1__state) > 7)
        {
                return false;
        }
        
        var val_1 = 12954800 + (12954800 + (this.<>1__state) << 2);
        if((this.<>1__state) == 7)
        {
                12954800 + (this.<>1__state) << 2 = (12954800 + (this.<>1__state) << 2) & ((12954800 + (this.<>1__state) << 2) >> 32);
            12954800 + (this.<>1__state) << 2 = (12954800 + (this.<>1__state) << 2) & (((int)R8) >> (12954800 + (this.<>1__state) << 2 & (12954800 + (this.<>1__state) << 2) >> 32));
            12954800 + (this.<>1__state) << 2 = R8 * (12954800 + (this.<>1__state) << 2);
            12954800 + (this.<>1__state) << 2 = (12954800 + (this.<>1__state) << 2) & ((12954800 + (this.<>1__state) << 2) << 2);
            12954800 + (this.<>1__state) << 2 = (12954800 + (this.<>1__state) << 2) & ((this.<>4__this) >> 2);
            12954800 + (this.<>1__state) << 2 = (12954800 + (this.<>1__state) << 2) & (((int)R8) >> 2);
            mem2[0] = ((((R8 * ((12954800 + (this.<>1__state) << 2 & (12954800 + (this.<>1__state) << 2) >> 32) & ((int)R8) >> (12954800 + (this.<>1__state) << 2 & (12954800 + (this.<>1__state) << 2) >> 32))) & ((R8 * ((12 + IP;
        }
        
        this.<>1__state = 0;
        System.Collections.IEnumerator val_2 = this.<>4__this.CheckPetCapture();
        this.<>1__state = 1;
        this.<>2__current = this.<>4__this;
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
