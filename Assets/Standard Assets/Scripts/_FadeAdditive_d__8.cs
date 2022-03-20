using UnityEngine;
private sealed class SkeletonGhostRenderer.<FadeAdditive>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Spine.Unity.Modules.SkeletonGhostRenderer <>4__this;
    private UnityEngine.Color32 <black>5__2;
    private int <t>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SkeletonGhostRenderer.<FadeAdditive>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_8;
        var val_9;
        var val_10;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_8 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_8;
        }
        
        this.<>1__state = 0;
        this.<black>5__2 = this.<>4__this.black;
        this.<t>5__3 = 0;
        goto label_5;
        label_1:
        int val_9 = this.<t>5__3;
        this.<>1__state = 0;
        val_9 = val_9 + 1;
        this.<t>5__3 = val_9;
        if(val_9 < 500)
        {
            goto label_5;
        }
        
        if((this.<>4__this) != 0)
        {
            goto label_7;
        }
        
        goto label_7;
        label_5:
        val_9 = 1;
        val_10 = 4;
        goto label_8;
        label_15:
        UnityEngine.Color32 val_10 = this.<>4__this.colors[0];
        mem[1152921510927336855] = val_10 >> 24;
        float val_2 = UnityEngine.Time.deltaTime;
        float val_11 = this.<>4__this.fadeSpeed;
        val_11 = 0 * val_11;
        UnityEngine.Color32 val_3 = UnityEngine.Color32.Lerp(a:  new UnityEngine.Color32() {r = val_10, g = val_10, b = val_10, a = val_10}, b:  new UnityEngine.Color32() {r = this.<black>5__2, g = this.<black>5__2, b = this.<black>5__2, a = this.<black>5__2}, t:  val_11);
        val_10 = val_10 >> 5;
        this.<>4__this.colors[0] = val_3;
        val_9 = val_10 & val_9;
        val_10 = 5;
        label_8:
        if((val_10 - 4) < (val_10 & (~4278190080)))
        {
            goto label_15;
        }
        
        UnityEngine.Mesh val_6 = this.<>4__this.meshFilter.sharedMesh;
        this.<>4__this.meshFilter.colors32 = this.<>4__this.colors;
        if((val_9 & 1) != 0)
        {
            goto label_18;
        }
        
        label_7:
        UnityEngine.Mesh val_7 = this.<>4__this.meshFilter.sharedMesh;
        val_8 = 0;
        UnityEngine.Object.Destroy(obj:  this.<>4__this.meshFilter);
        UnityEngine.GameObject val_8 = this.<>4__this.gameObject;
        this.<>4__this.SetActive(value:  false);
        return (bool)val_8;
        label_18:
        val_8 = 1;
        this.<>1__state = val_8;
        mem[1152921510927336844] = 0;
        return (bool)val_8;
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
