using UnityEngine;
private sealed class SkeletonRagdoll2D.<Start>d__32 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Spine.Unity.Modules.SkeletonRagdoll2D <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SkeletonRagdoll2D.<Start>d__32(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        Spine.Unity.ISkeletonAnimation val_8;
        Spine.Unity.ISkeletonAnimation val_9;
        var val_10;
        var val_11;
        val_7 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_7;
        }
        
        this.<>1__state = 0;
        if(Spine.Unity.Modules.SkeletonRagdoll2D.parentSpaceHelper == 0)
        {
                UnityEngine.GameObject val_2 = new UnityEngine.GameObject(name:  2029214272);
            UnityEngine.Transform val_3 = transform;
            Spine.Unity.Modules.SkeletonRagdoll2D.parentSpaceHelper = null;
        }
        
        if((this.<>4__this) == 0)
        {
            goto label_7;
        }
        
        object val_4 = this.<>4__this.GetComponent<System.Object>();
        val_8 = this.<>4__this;
        goto label_8;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.Apply();
        return (bool)val_7;
        label_7:
        object val_5 = 0.GetComponent<System.Object>();
        val_8 = 0;
        label_8:
        val_9 = val_8;
        val_10 = 1152921504873779200;
        this.<>4__this.targetSkeletonComponent = val_9;
        if((this.<>4__this) == 0)
        {
                val_9 = this.<>4__this.targetSkeletonComponent;
        }
        
        if(val_9 == 0)
        {
                UnityEngine.Debug.LogError(message:  2029218480);
        }
        
        val_10 = 0;
        val_10 = val_10 + 1;
        val_11 = this.<>4__this.targetSkeletonComponent;
        if((this.<>4__this) != 0)
        {
                this.<>4__this.skeleton = this.<>4__this.targetSkeletonComponent;
        }
        else
        {
                mem[56] = this.<>4__this.targetSkeletonComponent;
        }
        
        if((this.<>4__this.applyOnStart) != false)
        {
                val_7 = 1;
            this.<>1__state = val_7;
            this.<>2__current = 0;
            return (bool)val_7;
        }
        
        val_7 = 0;
        return (bool)val_7;
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
