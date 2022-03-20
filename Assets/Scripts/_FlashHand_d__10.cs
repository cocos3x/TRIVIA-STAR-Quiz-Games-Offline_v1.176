using UnityEngine;
private sealed class WordJumbleFTUX.<FlashHand>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Minigames.WordJumble.WordJumbleFTUX <>4__this;
    private float <progress>5__2;
    private float <dir>5__3;
    private UnityEngine.Color <curColor>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WordJumbleFTUX.<FlashHand>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_9;
        float val_10;
        float val_15;
        float val_16;
        SLC.Minigames.WordJumble.WordJumbleFTUX val_20;
        int val_21;
        float val_23;
        float val_24;
        var val_25;
        val_20 = this.<>4__this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_21 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_21;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForFixedUpdate val_1 = null;
        val_20 = val_1;
        val_1 = new UnityEngine.WaitForFixedUpdate();
        val_21 = 1;
        this.<>1__state = val_21;
        this.<>2__current = val_20;
        return (bool)val_21;
        label_1:
        float val_20 = this.<progress>5__2;
        this.<>1__state = 0;
        val_20 = val_20 + (this.<dir>5__3);
        this.<progress>5__2 = val_20;
        mem[1152921514114771256] = val_20;
        if((this.<>1__state) <= 2)
        {
                if((this.<>1__state) >= 0)
        {
            goto label_6;
        }
        
        }
        
        this.<dir>5__3 = -(this.<dir>5__3);
        label_6:
        if(val_20 == 0)
        {
            goto label_7;
        }
        
        val_23 = val_20;
        goto label_8;
        label_2:
        this.<>1__state = 0;
        val_24 = 0f;
        this.<progress>5__2 = val_24;
        this.<dir>5__3 = 0.02f;
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        if(val_20 != 0)
        {
            goto label_10;
        }
        
        val_24 = 1;
        goto label_10;
        label_7:
        label_8:
        if((this.<>4__this.handImage) == 0)
        {
                val_23 = R1;
        }
        
        this.<>4__this.handImage.color = new UnityEngine.Color() {r = this.<curColor>5__4, g = SL, b = R8, a = val_23};
        val_24 = 0;
        label_10:
        val_21 = 0;
        if(val_20.enabled == false)
        {
                return (bool)val_21;
        }
        
        UnityEngine.Transform val_4 = this.<>4__this.handImage.transform;
        val_25 = this.<>4__this.handImage;
        UnityEngine.Transform val_5 = this.<>4__this.curTile.transform;
        val_24 = 0;
        UnityEngine.Vector3 val_6 = position;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 5.460559E-06f}, d:  val_7.x);
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 5.460553E-06f}, b:  new UnityEngine.Vector3() {y = val_10, z = val_9});
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.right;
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 5.460543E-06f}, d:  val_13.x);
        val_20 = val_15;
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 5.460537E-06f}, b:  new UnityEngine.Vector3() {y = val_16, z = val_20});
        val_25.position = new UnityEngine.Vector3();
        this.<>1__state = 2;
        this.<>2__current = new UnityEngine.WaitForFixedUpdate();
        val_21 = 1;
        return (bool)val_21;
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
