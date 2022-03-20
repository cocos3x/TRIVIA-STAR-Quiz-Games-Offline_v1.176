using UnityEngine;
private sealed class IslandParadiseEventHandler.<RewardSequence>d__81 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public IslandParadiseEventHandler <>4__this;
    public WGEventButtonV2_IslandParadise islandParadiseButton;
    public WGLevelClearPopup popup;
    private IslandParadiseEventHandler.<>c__DisplayClass81_0 <>8__1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public IslandParadiseEventHandler.<RewardSequence>d__81(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_43;
        object val_44;
        val_43 = 0;
        if((this.<>1__state) > 3)
        {
                return (bool);
        }
        
        var val_1 = 11483428 + (11483428 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                11483428 + (this.<>1__state) << 2 = (11483428 + (this.<>1__state) << 2) & ((11483428 + (this.<>1__state) << 2) << (11483428 + (this.<>1__state) << 2));
            11483428 + (this.<>1__state) << 2 = (11483428 + (this.<>1__state) << 2) * (11483428 + (this.<>1__state) << 2);
            11483428 + (this.<>1__state) << 2 = (11483428 + (this.<>1__state) << 2) & (((IP) << (32-12)) | ((IP) << 12));
        }
        
        this.<>1__state = 0;
        this.<>8__1 = new System.Object();
        typeof(IslandParadiseEventHandler.<>c__DisplayClass81_0).__il2cppRuntimeField_8 = this.<>4__this;
        val_43 = true;
        this.<>8__1.isRewardShowing = val_43;
        UnityEngine.WaitForSeconds val_3 = null;
        val_44 = val_3;
        val_3 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>1__state = val_43;
        this.<>2__current = val_44;
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
