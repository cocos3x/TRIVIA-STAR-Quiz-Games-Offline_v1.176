using UnityEngine;
private sealed class ETFXLoopScript.<EffectLoop>d__6 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public EpicToonFX.ETFXLoopScript <>4__this;
    private UnityEngine.GameObject <effectPlayer>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ETFXLoopScript.<EffectLoop>d__6(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_5;
        float val_6;
        float val_7;
        float val_8;
        int val_17;
        UnityEngine.GameObject val_18;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_17 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_17;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_3;
        }
        
        val_18 = this.<>4__this.chosenEffect;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        val_17 = 0;
        UnityEngine.Object.Destroy(obj:  this.<effectPlayer>5__2);
        this.<>4__this.PlayEffect();
        return (bool)val_17;
        label_3:
        val_18 = 0f;
        label_4:
        UnityEngine.Transform val_1 = this.<>4__this.transform;
        UnityEngine.Vector3 val_2 = position;
        UnityEngine.Transform val_3 = this.<>4__this.transform;
        UnityEngine.Quaternion val_4 = rotation;
        UnityEngine.GameObject val_9 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  0, position:  new UnityEngine.Vector3(), rotation:  new UnityEngine.Quaternion() {x = val_5, y = val_6, z = val_7, w = val_8});
        this.<effectPlayer>5__2 = val_18;
        object val_10 = val_18.GetComponent<System.Object>();
        bool val_11 = UnityEngine.Object.op_Implicit(exists:  0);
        this.<>4__this.spawnWithoutLight = val_11;
        if(val_11 != false)
        {
                object val_12 = this.<effectPlayer>5__2.GetComponent<System.Object>();
            this.<effectPlayer>5__2.enabled = false;
        }
        
        object val_13 = this.<effectPlayer>5__2.GetComponent<System.Object>();
        bool val_14 = UnityEngine.Object.op_Implicit(exists:  this.<effectPlayer>5__2);
        this.<>4__this.spawnWithoutSound = val_14;
        if(val_14 != false)
        {
                object val_15 = this.<effectPlayer>5__2.GetComponent<System.Object>();
            this.<effectPlayer>5__2.enabled = false;
        }
        
        val_17 = 1;
        this.<>1__state = val_17;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  val_4.x);
        return (bool)val_17;
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
