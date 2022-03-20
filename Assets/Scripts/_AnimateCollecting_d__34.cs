using UnityEngine;
private sealed class WGAlphabetCollectionBoxPopup.<AnimateCollecting>d__34 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGAlphabetCollectionBoxPopup <>4__this;
    private System.Collections.Generic.List.Enumerator<System.Collections.Generic.KeyValuePair<string, int>> <>7__wrap1;
    private int <letterIndex>5__3;
    private LineWord <matchingWord>5__4;
    private UnityEngine.GameObject <newOne>5__5;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGAlphabetCollectionBoxPopup.<AnimateCollecting>d__34(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
        if(((this.<>1__state) - 2) < 8)
        {
                this.<>m__Finally1();
            return;
        }
        
        if((this.<>1__state) != 3)
        {
                return;
        }
        
        this.<>m__Finally1();
    }
    private bool MoveNext()
    {
        if((this.<>1__state) <= 9)
        {
                var val_1 = 8431908 + (8431908 + (this.<>1__state) << 2);
            if((this.<>1__state) == 9)
        {
                8431908 + (this.<>1__state) << 2 = (8431908 + (this.<>1__state) << 2) & ((R8) >> 32);
            8431908 + (this.<>1__state) << 2 = (8431908 + (this.<>1__state) << 2) & ((((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this));
            mem2[0] = ((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP;
            (((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP) & ((((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP) << 9) = ((((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP) & ((((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP) << 9)) & (((int)IP) >> (((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP & (((8431908 + );
            (((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP) & ((((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP) << 9) = ((((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP) & ((((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP) << 9)) & 2743074816;
            (((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP) & ((((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP) << 9) = ((((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP) & ((((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP) << 9)) & (((((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP) & ((((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP) << 9)) >> 25);
            (((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP) & ((((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP) << 9) = ((((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP) & ((((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP) << 9)) & (-173481917);
            (((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP) & ((((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP) << 9) = ((((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP) & ((((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP) << 9)) & (((((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP) & ((((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP) << 9)) >> 26);
            (((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP) & ((((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP) << 9) = ((((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP) & ((((8431908 + (this.<>1__state) << 2 & (R8) >> 32) & (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << (32-this)) | (((8431908 + (this.<>1__state) << 2 & (R8) >> 32)) << this)) + IP) << 9)) & ((IP) >> 7);
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_2 = new UnityEngine.WaitForSeconds(seconds:  null);
            this.<>1__state = 1;
        }
    
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
