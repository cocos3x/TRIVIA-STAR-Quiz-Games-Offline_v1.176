using UnityEngine;
private sealed class TRVProgressiveIAPProgressPopup.<AnimateBarFill>d__16 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVProgressiveIAPProgressPopup <>4__this;
    public float targetFillAmount;
    public bool openPurchasePopup;
    public int req;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVProgressiveIAPProgressPopup.<AnimateBarFill>d__16(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_29;
        object val_30;
        val_29 = 0;
        if((this.<>1__state) > 7)
        {
                return (bool);
        }
        
        var val_1 = 11966136 + (11966136 + (this.<>1__state) << 2);
        if((this.<>1__state) == 7)
        {
                11966136 + (this.<>1__state) << 2 = (11966136 + (this.<>1__state) << 2) & ((11966136 + (this.<>1__state) << 2) >> 32);
            11966136 + (this.<>1__state) << 2 = (11966136 + (this.<>1__state) << 2) & (this >> (11966136 + (this.<>1__state) << 2));
            11966136 + (this.<>1__state) << 2 = (11966136 + (this.<>1__state) << 2) & 1854857608;
            11966136 + (this.<>1__state) << 2 = (11966136 + (this.<>1__state) << 2) & (((R8) << (32-2)) | ((R8) << 2));
            11966136 + (this.<>1__state) << 2 = (11966136 + (this.<>1__state) << 2) & ((11966136 + (this.<>1__state) << 2) >> 6);
            11966136 + (this.<>1__state) << 2 = (11966136 + (this.<>1__state) << 2) & (((IP) << (32-R3)) | ((IP) << R3));
            11966136 + (this.<>1__state) << 2 = (11966136 + (this.<>1__state) << 2) & ((R8) << 7);
            11966136 + (this.<>1__state) << 2 = (11966136 + (this.<>1__state) << 2) & 499322880;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_2 = null;
        val_30 = val_2;
        val_2 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_29 = 1;
        this.<>1__state = val_29;
        this.<>2__current = ;
        return (bool);
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
