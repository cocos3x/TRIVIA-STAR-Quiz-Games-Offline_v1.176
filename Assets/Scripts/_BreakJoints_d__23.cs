using UnityEngine;
private sealed class IceCreamController.<BreakJoints>d__23 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Minigames.WordDrop.IceCreamController <>4__this;
    private System.Collections.Generic.List<UnityEngine.HingeJoint2D> <hingeJoints>5__2;
    private float <delay>5__3;
    private int <i>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public IceCreamController.<BreakJoints>d__23(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Collections.Generic.List<UnityEngine.HingeJoint2D> val_18;
        UnityEngine.Rigidbody2D val_19;
        int val_20;
        int val_21;
        var val_22;
        System.Collections.Generic.List<UnityEngine.HingeJoint2D> val_23;
        if((this.<>1__state) > 3)
        {
            goto label_1;
        }
        
        var val_1 = 13362904 + (13362904 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                13362904 + (this.<>1__state) << 2 = (13362904 + (this.<>1__state) << 2) & ((13362904 + (this.<>1__state) << 2) << (13362904 + (this.<>1__state) << 2));
            13362904 + (this.<>1__state) << 2 = (13362904 + (this.<>1__state) << 2) & 142557972;
            13362904 + (this.<>1__state) << 2 = (13362904 + (this.<>1__state) << 2) & 120372922;
            13362904 + (this.<>1__state) << 2 = (13362904 + (this.<>1__state) << 2) & 2522832128;
        }
        
        this.<>1__state = 0;
        T[] val_2 = this.<>4__this.tailparent.GetComponentsInChildren<System.Object>();
        System.Collections.Generic.IEnumerable<TSource> val_3 = System.Linq.Enumerable.Reverse<System.Object>(source:  this.<>4__this.tailparent);
        System.Collections.Generic.List<TSource> val_4 = System.Linq.Enumerable.ToList<System.Object>(source:  this.<>4__this.tailparent);
        val_18 = this;
        this.<hingeJoints>5__2 = this.<>4__this.tailparent;
        if((this.<>4__this.tailparent) > 0)
        {
            goto label_5;
        }
        
        object val_5 = this.<>4__this.coneObject.GetComponent<System.Object>();
        this.<>4__this.coneObject.enabled = false;
        UnityEngine.WaitForSeconds val_6 = null;
        val_19 = val_6;
        val_6 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_20 = 1;
        this.<>1__state = val_20;
        goto label_8;
        label_1:
        val_20 = 0;
        return (bool)val_20;
        label_5:
        val_21 = 0;
        val_22 = this;
        float val_17 = (float)mem[this.<hingeJoints>5__2.SyncRoot + 12];
        this.<i>5__4 = val_21;
        val_17 = 1f / val_17;
        mem[1152921514159764968] = val_17;
        var val_18 = mem[this.<>4__this.tailparent + 12];
        val_18 = val_18 - 1;
        if( > val_18)
        {
                object val_10 = SB + 48.GetComponent<System.Object>();
            object val_11 = SB.GetComponent<System.Object>();
            val_19 = SB;
            val_20 = 0;
            SB + 48.connectedBody = val_19;
            return (bool)val_20;
        }
        
        if((mem[this.<>4__this.tailparent + 12]) <= )
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_19 = mem[this.<>4__this.tailparent + 8];
        val_19 = val_19 + ( << 2);
        (mem[this.<>4__this.tailparent + 8] + ((this.<i>5__4 + 1)) << 2) + 16.enabled = false;
        if((mem[this.<>4__this.tailparent + 12]) <= )
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_20 = mem[this.<>4__this.tailparent + 8];
        val_20 = val_20 + ( << 2);
        UnityEngine.GameObject val_12 = (mem[this.<>4__this.tailparent + 8] + ((this.<i>5__4 + 1)) << 2) + 16.gameObject;
        bool val_13 = SB + 12.Remove(item:  (mem[this.<>4__this.tailparent + 8] + ((this.<i>5__4 + 1)) << 2) + 16);
        if((mem[this.<>4__this.tailparent + 12]) <= )
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_21 = mem[this.<>4__this.tailparent + 8];
        val_21 = val_21 + ( << 2);
        UnityEngine.Object.Destroy(obj:  (mem[this.<>4__this.tailparent + 8] + ((this.<i>5__4 + 1)) << 2) + 16, t:  val_17);
        val_23 = this.<hingeJoints>5__2;
        if(( + 1) < (mem[this.<>4__this.tailparent + 12]))
        {
                int val_22 = ;
            val_22 = val_22 + 1;
            if((mem[this.<>4__this.tailparent + 12]) <= val_22)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_23 = mem[this.<>4__this.tailparent + 8];
            val_23 = val_23 + (val_22 << 2);
            object val_15 = SB.GetComponent<System.Object>();
            (mem[this.<>4__this.tailparent + 8] + (((this.<i>5__4 + 1) + 1)) << 2) + 16.connectedBody = SB;
        }
        
        UnityEngine.WaitForSeconds val_16 = null;
        val_19 = val_16;
        val_16 = new UnityEngine.WaitForSeconds(seconds:  val_17);
        val_20 = 1;
        this.<>1__state = 3;
        label_8:
        this.<>2__current = val_19;
        return (bool)val_20;
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
