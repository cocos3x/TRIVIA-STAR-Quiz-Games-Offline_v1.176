using UnityEngine;
private sealed class WFOManagerGameplayUI.<PlayAcornParticles>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public int wordIndex;
    public WordForest.WFOManagerGameplayUI <>4__this;
    public System.Collections.Generic.List<int> slotIndices;
    private System.Collections.Generic.List<Cell> <cells>5__2;
    private int <q>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WFOManagerGameplayUI.<PlayAcornParticles>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_15;
        object val_16;
        int val_17;
        System.Collections.Generic.List<Cell> val_18;
        System.Collections.Generic.List<Cell> val_19;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_15 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_15;
        }
        
        this.<>1__state = 0;
        if(this.wordIndex < 1)
        {
                return (bool)val_15;
        }
        
        if(this.wordIndex >= 0)
        {
                return (bool)val_15;
        }
        
        val_17 = this.wordIndex;
        if(val_17 == 1)
        {
            goto label_8;
        }
        
        if((this.<>4__this.wordRegion) == 0)
        {
                val_17 = this.wordIndex;
        }
        
        if(0 <= val_17)
        {
                var val_15 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_15 = val_15 + (val_17 << 2);
        val_18 = mem[(0 + (this.wordIndex) << 2) + 16 + 20];
        val_18 = (0 + (this.wordIndex) << 2) + 16 + 20;
        val_19 = this;
        this.<cells>5__2 = val_18;
        val_16 = 0;
        mem[1152921513512822208] = val_16;
        goto label_13;
        label_1:
        val_19 = this.<cells>5__2;
        this.<>1__state = 0;
        goto label_14;
        label_8:
        UnityEngine.Transform val_1 = this.<>4__this.acornParticleSystem.transform;
        UnityEngine.Transform val_2 = this.<>4__this.extraWordGameplayIcon.transform;
        UnityEngine.Vector3 val_3 = position;
        this.<>4__this.acornParticleSystem.position = new UnityEngine.Vector3();
        UnityEngine.Transform val_4 = this.<>4__this.acornStatView.AppleIcon;
        UnityEngine.Transform val_5 = this.<>4__this.acornStatView.transform;
        val_16 = this.<>4__this.acornStatView;
        val_15 = 0;
        UnityEngine.Vector3 val_6 = position;
        this.<>4__this.acornParticleSystem.PlayParticles(destinationPosition:  new UnityEngine.Vector3(), particleCount:  1, animateStatView:  true);
        return (bool)val_15;
        label_27:
        if((this.slotIndices.Contains(item:  this.<q>5__3)) == true)
        {
            goto label_25;
        }
        
        label_14:
        mem2[0] = this.<q>5__3;
        val_18 = mem[R7];
        val_18 = R7;
        label_13:
        if((this.<q>5__3) < (R7 + 12))
        {
            goto label_27;
        }
        
        val_15 = 0;
        mem2[0] = val_15;
        return (bool)val_15;
        label_25:
        UnityEngine.Transform val_8 = this.<>4__this.acornParticleSystem.transform;
        if((R7 + 12) <= null)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_16 = R7 + 8;
        val_16 = val_16 + 1624276992;
        UnityEngine.Transform val_9 = (R7 + 8 + 1624276992) + 16.transform;
        UnityEngine.Vector3 val_10 = position;
        this.<>4__this.acornParticleSystem.position = new UnityEngine.Vector3();
        UnityEngine.Transform val_11 = this.<>4__this.acornStatView.AppleIcon;
        UnityEngine.Transform val_12 = this.<>4__this.acornStatView.transform;
        UnityEngine.Vector3 val_13 = position;
        val_15 = 1;
        this.<>4__this.acornParticleSystem.PlayParticles(destinationPosition:  new UnityEngine.Vector3(), particleCount:  val_15, animateStatView:  true);
        UnityEngine.WaitForSeconds val_14 = null;
        val_16 = val_14;
        val_14 = new UnityEngine.WaitForSeconds(seconds:  val_13.x);
        this.<>1__state = val_15;
        this.<>2__current = val_16;
        return (bool)val_15;
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
