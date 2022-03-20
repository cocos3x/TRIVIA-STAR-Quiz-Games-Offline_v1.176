using UnityEngine;
private sealed class MysteryGiftFlyoutMessage.<AnimateMessage>d__5 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public MysteryGiftFlyoutMessage <>4__this;
    private UnityEngine.RectTransform <rt>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MysteryGiftFlyoutMessage.<AnimateMessage>d__5(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_11;
        object val_12;
        int val_13;
        val_11 = 0;
        if((this.<>1__state) > 3)
        {
                return (bool)val_11;
        }
        
        var val_1 = 7989108 + (7989108 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                val_11 = 0;
            val_11 = val_11 & (-1151083424);
            val_11 = val_11 & ((((val_11 & -1151083424)) << (32-0)) | (((val_11 & -1151083424)) << 0));
        }
        
        this.<>1__state = 0;
        object val_2 = this.<>4__this.message_group.GetComponent<System.Object>();
        this.<rt>5__2 = this.<>4__this.message_group;
        UnityEngine.WaitForSeconds val_3 = null;
        val_12 = val_3;
        val_3 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_13 = 1;
        val_11 = 1;
        this.<>2__current = ;
        this.<>1__state = ;
        return (bool)val_11;
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
