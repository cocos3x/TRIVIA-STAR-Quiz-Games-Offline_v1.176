using UnityEngine;
private sealed class AttackMadnessEventHandler.<RewardSequence>d__74 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGEventButtonV2_AttackMadness attackMadnessButton;
    public WGLevelClearPopup popup;
    public AttackMadnessEventHandler <>4__this;
    private AttackMadnessEventHandler.<>c__DisplayClass74_0 <>8__1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AttackMadnessEventHandler.<RewardSequence>d__74(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_40;
        object val_41;
        val_40 = 0;
        if((this.<>1__state) > 3)
        {
                return (bool);
        }
        
        var val_1 = 9348424 + (9348424 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                9348424 + (this.<>1__state) << 2 = (9348424 + (this.<>1__state) << 2) & ((9348424 + (this.<>1__state) << 2) << (9348424 + (this.<>1__state) << 2));
            9348424 + (this.<>1__state) << 2 = (9348424 + (this.<>1__state) << 2) & (((R8) << (32-(9348424 + (this.<>1__state) << 2 & (9348424 + (this.<>1__state) << 2) << 9348424 + (this.<>1__state) << 2))) | ((R8) << (9348424 + (this.<>1__state) << 2 & (9348424 + (this.<>1__state) << 2) << 9348424 + (this.<>1__state) << 2)));
            mem2[0] = ((9348424 + (this.<>1__state) << 2 & (9348424 + (this.<>1__state) << 2) << 9348424 + (this.<>1__state) << 2) & ((R8) << (32-(9348424 + (this.<>1__state) << 2 & (9348424 + (this.<>1__state) << 2) << 93 + IP;
        }
        
        this.<>1__state = 0;
        this.<>8__1 = new System.Object();
        val_40 = 1;
        typeof(AttackMadnessEventHandler.<>c__DisplayClass74_0).__il2cppRuntimeField_8 = val_40;
        UnityEngine.WaitForSeconds val_3 = null;
        val_41 = val_3;
        val_3 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>1__state = val_40;
        this.<>2__current = val_41;
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
