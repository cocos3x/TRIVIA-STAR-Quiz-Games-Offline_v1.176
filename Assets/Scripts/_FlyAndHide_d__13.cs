using UnityEngine;
private sealed class GenericMovingObject.<FlyAndHide>d__13 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public GenericMovingObject <>4__this;
    private UnityEngine.Vector3 <endPos>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GenericMovingObject.<FlyAndHide>d__13(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_17;
        int val_18;
        if((this.<>1__state) <= 3)
        {
                var val_1 = 6496216 + (6496216 + (this.<>1__state) << 2);
            if((this.<>1__state) == 3)
        {
                6496216 + (this.<>1__state) << 2 = (6496216 + (this.<>1__state) << 2) & ((6496216 + (this.<>1__state) << 2) << (6496216 + (this.<>1__state) << 2));
            6496216 + (this.<>1__state) << 2 = (6496216 + (this.<>1__state) << 2) & 3068492352;
            6496216 + (this.<>1__state) << 2 = (6496216 + (this.<>1__state) << 2) & (((int)R8) >> 3);
            6496216 + (this.<>1__state) << 2 = (6496216 + (this.<>1__state) << 2) & (((IP) << (32-4)) | ((IP) << 4));
        }
        
            this.<>1__state = 0;
            UnityEngine.Transform val_2 = this.<>4__this.itemGroup.transform;
            UnityEngine.Transform val_3 = this.<>4__this.eventButton.transform;
            this.<>4__this.itemGroup.SetParent(p:  this.<>4__this.eventButton);
            UnityEngine.Transform val_4 = this.<>4__this.eventButton.transform;
            UnityEngine.Vector3 val_5 = position;
            UnityEngine.WaitForSeconds val_6 = null;
            val_17 = val_6;
            val_6 = new UnityEngine.WaitForSeconds(seconds:  val_5.x);
            val_18 = 1;
            this.<>1__state = val_18;
            this.<>2__current = val_17;
            return (bool);
        }
        
        val_18 = 0;
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
