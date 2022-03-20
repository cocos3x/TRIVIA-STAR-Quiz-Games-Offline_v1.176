using UnityEngine;
private sealed class SkeletonRagdoll.<SmoothMixCoroutine>d__40 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Spine.Unity.Modules.SkeletonRagdoll <>4__this;
    public float target;
    public float duration;
    private float <startTime>5__2;
    private float <startMix>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SkeletonRagdoll.<SmoothMixCoroutine>d__40(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)0;
        }
        
            this.<>1__state = 0;
            float val_1 = UnityEngine.Time.time;
            this.<startTime>5__2 = 0f;
            this.<startMix>5__3 = this.<>4__this.mix;
        }
        else
        {
                this.<>1__state = 0;
        }
        
        if((this.<>4__this) <= 0)
        {
                return (bool)0;
        }
        
        this.<>4__this.skeleton.SetBonesToSetupPose();
        float val_2 = UnityEngine.Time.time;
        float val_3 = 0 - (this.<startTime>5__2);
        val_3 = val_3 / this.duration;
        float val_4 = UnityEngine.Mathf.SmoothStep(from:  val_3, to:  null, t:  null);
        0 = 1;
        this.<>4__this.mix = this.<startMix>5__3;
        this.<>1__state = 0;
        this.<>2__current = 0;
        return (bool)0;
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
