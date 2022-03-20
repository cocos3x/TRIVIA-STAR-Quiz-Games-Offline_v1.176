using UnityEngine;
private sealed class AttackMadnessEventHandler.<PlayNextRewardSequence>d__72 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public AttackMadnessEventHandler <>4__this;
    public WGEventButtonV2 eventButton;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AttackMadnessEventHandler.<PlayNextRewardSequence>d__72(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        WGEventButtonV2 val_6;
        int val_7;
        object val_8;
        val_5 = 0;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_5;
        }
        
        this.<>1__state = 0;
        GameBehavior val_1 = App.getBehavior;
        .__il2cppRuntimeField_38 = this.<>4__this;
        val_6 = this.eventButton;
        goto label_9;
        label_1:
        val_7 = 0;
        goto label_10;
        label_2:
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_3 = null;
        val_8 = val_3;
        val_3 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_7 = 2;
        goto label_11;
        label_9:
        System.Collections.IEnumerator val_4 = PlayNextRewardSequence(eventButton:  null);
        val_8 = App.__il2cppRuntimeField_namespaze;
        val_7 = 1;
        label_11:
        val_5 = 1;
        this.<>2__current = val_8;
        label_10:
        this.<>1__state = val_7;
        return (bool)val_5;
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
