using UnityEngine;
private sealed class WFOWordChestDisplay.<BeginChestReadyFlowCoroutine>d__58 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WordForest.WFOWordChestDisplay <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WFOWordChestDisplay.<BeginChestReadyFlowCoroutine>d__58(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_17;
        System.Func<System.Boolean> val_19;
        object val_20;
        int val_21;
        if((this.<>1__state) <= 3)
        {
                var val_1 = 7531724 + (7531724 + (this.<>1__state) << 2);
            if((this.<>1__state) == 3)
        {
                7531724 + (this.<>1__state) << 2 = (7531724 + (this.<>1__state) << 2) & ((7531724 + (this.<>1__state) << 2) << (7531724 + (this.<>1__state) << 2));
            mem2[0] = (7531724 + (this.<>1__state) << 2 & (7531724 + (this.<>1__state) << 2) << 7531724 + (this.<>1__state) << 2) + R8;
            ((7531724 + (this.<>1__state) << 2 & (7531724 + (this.<>1__state) << 2) << 7531724 + (this.<>1__state) << 2) + R8) & (((7531724 + (this.<>1__state) << 2 & (7531724 + (this.<>1__state) << 2) << 7531724 + (this.<>1__state) << 2) + R8) >> 4) = (((7531724 + (this.<>1__state) << 2 & (7531724 + (this.<>1__state) << 2) << 7531724 + (this.<>1__state) << 2) + R8) & (((7531724 + (this.<>1__state) << 2 & (7531724 + (this.<>1__state) << 2) << 7531724 + (this.<>1__state) << 2) + R8) >> 4)) & (((IP) << (32-R2)) | ((IP) << R2));
        }
        
            this.<>1__state = 0;
            val_17 = null;
            val_17 = null;
            val_19 = WFOWordChestDisplay.<>c.<>9__58_0;
            if(val_19 == 0)
        {
                val_19 = null;
            val_19 = new System.Func<System.Boolean>(object:  WFOWordChestDisplay.<>c.__il2cppRuntimeField_static_fields, method:  new IntPtr(349189424));
            WFOWordChestDisplay.<>c.<>9__58_0 = val_19;
        }
        
            UnityEngine.WaitUntil val_3 = null;
            val_20 = val_3;
            val_3 = new UnityEngine.WaitUntil(predicate:  7667712);
            val_21 = 1;
            this.<>1__state = val_21;
            this.<>2__current = val_20;
            return (bool);
        }
        
        val_21 = 0;
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
