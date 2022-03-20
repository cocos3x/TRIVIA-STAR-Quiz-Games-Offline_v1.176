using UnityEngine;
private sealed class SkeletonGhostRenderer.<Fade>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Spine.Unity.Modules.SkeletonGhostRenderer <>4__this;
    private int <t>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SkeletonGhostRenderer.<Fade>d__7(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        var val_7;
        var val_8;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_6 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
        this.<t>5__2 = 0;
        this.<>1__state = 0;
        goto label_4;
        label_1:
        int val_7 = this.<t>5__2;
        this.<>1__state = 0;
        val_7 = val_7 + 1;
        this.<t>5__2 = val_7;
        if(val_7 < 500)
        {
            goto label_4;
        }
        
        if((this.<>4__this) != 0)
        {
            goto label_6;
        }
        
        goto label_6;
        label_4:
        val_7 = 1;
        val_8 = 4;
        goto label_7;
        label_14:
        UnityEngine.Color32 val_8 = this.<>4__this.colors[0];
        float val_1 = UnityEngine.Time.deltaTime;
        float val_9 = this.<>4__this.fadeSpeed;
        val_9 = 0 * val_9;
        UnityEngine.Color32 val_2 = UnityEngine.Color32.Lerp(a:  new UnityEngine.Color32() {r = val_8, g = val_8, b = val_8, a = val_8}, b:  new UnityEngine.Color32() {r = this.<>4__this.black, g = this.<>4__this.black, b = this.<>4__this.black, a = this.<>4__this.black}, t:  val_9);
        if(val_8 < 16777216)
        {
                0 = 1;
        }
        
        this.<>4__this.colors[0] = val_2;
        val_7 = val_7 & 1;
        val_8 = 5;
        label_7:
        if((val_8 - 4) < val_2.r)
        {
            goto label_14;
        }
        
        UnityEngine.Mesh val_4 = this.<>4__this.meshFilter.sharedMesh;
        this.<>4__this.meshFilter.colors32 = this.<>4__this.colors;
        if((val_7 & 1) != 0)
        {
            goto label_17;
        }
        
        label_6:
        UnityEngine.Mesh val_5 = this.<>4__this.meshFilter.sharedMesh;
        val_6 = 0;
        UnityEngine.Object.Destroy(obj:  this.<>4__this.meshFilter);
        UnityEngine.GameObject val_6 = this.<>4__this.gameObject;
        this.<>4__this.SetActive(value:  false);
        return (bool)val_6;
        label_17:
        val_6 = 1;
        this.<>1__state = val_6;
        mem[1152921510926327948] = 0;
        return (bool)val_6;
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
