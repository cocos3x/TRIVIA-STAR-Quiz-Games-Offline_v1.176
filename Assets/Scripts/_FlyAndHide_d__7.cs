using UnityEngine;
private sealed class DiceRollTile.<FlyAndHide>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public DiceRollTile <>4__this;
    private UnityEngine.Vector3 <endPos>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DiceRollTile.<FlyAndHide>d__7(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Transform val_15;
        object val_16;
        int val_17;
        if((this.<>1__state) <= 3)
        {
                var val_1 = 8803712 + (8803712 + (this.<>1__state) << 2);
            if((this.<>1__state) == 3)
        {
                8803712 + (this.<>1__state) << 2 = (8803712 + (this.<>1__state) << 2) & ((8803712 + (this.<>1__state) << 2) << (8803712 + (this.<>1__state) << 2));
            8803712 + (this.<>1__state) << 2 = (8803712 + (this.<>1__state) << 2) & ((8803712 + (this.<>1__state) << 2) >> 2);
            8803712 + (this.<>1__state) << 2 = (8803712 + (this.<>1__state) << 2) & 407193188;
            8803712 + (this.<>1__state) << 2 = (8803712 + (this.<>1__state) << 2) & (((R8) << (32-4)) | ((R8) << 4));
        }
        
            this.<>1__state = 0;
            UnityEngine.GameObject val_2 = this.<>4__this.gameObject;
            UnityEngine.Transform val_3 = this.<>4__this.transform;
            UnityEngine.Transform val_4 = this.<>4__this.eventButtonGO.transform;
            val_15 = this.<>4__this.eventButtonGO;
            this.<>4__this.SetParent(p:  val_15);
            UnityEngine.Transform val_5 = this.<>4__this.eventButtonGO.transform;
            UnityEngine.Vector3 val_6 = position;
            UnityEngine.WaitForSeconds val_7 = null;
            val_16 = val_7;
            val_7 = new UnityEngine.WaitForSeconds(seconds:  val_6.x);
            val_17 = 1;
            this.<>1__state = val_17;
            this.<>2__current = val_16;
            return (bool);
        }
        
        val_17 = 0;
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
