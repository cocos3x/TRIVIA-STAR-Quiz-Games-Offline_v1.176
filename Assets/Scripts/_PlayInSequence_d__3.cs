using UnityEngine;
private sealed class LineDrawerParticles.<PlayInSequence>d__3 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LineDrawerParticles <>4__this;
    public System.Collections.Generic.List<UnityEngine.Vector3> selectedPositions;
    private int <i>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineDrawerParticles.<PlayInSequence>d__3(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        int val_5;
        System.Collections.Generic.List<UnityEngine.Vector3> val_6;
        val_4 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
            val_5 = 0;
            this.<i>5__2 = val_5;
            this.<>1__state = 0;
        }
        else
        {
                this.<>1__state = 0;
            val_5 = (this.<i>5__2) + 1;
            this.<i>5__2 = val_5;
        }
        
        val_6 = this.selectedPositions;
        if(val_5 >= (this.<i>5__2))
        {
                return (bool)val_4;
        }
        
        UnityEngine.Transform val_1 = this.<>4__this.particleSystem.transform;
        if((this.<>4__this.particleSystem) <= (this.<i>5__2))
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + (((this.<i>5__2) + ((this.<i>5__2) << 1)) << 2);
        val_5 = mem[(0 + ((this.<i>5__2 + (this.<i>5__2) << 1)) << 2) + 16];
        val_5 = (0 + ((this.<i>5__2 + (this.<i>5__2) << 1)) << 2) + 16;
        val_6 = mem[(0 + ((this.<i>5__2 + (this.<i>5__2) << 1)) << 2) + 20];
        val_6 = (0 + ((this.<i>5__2 + (this.<i>5__2) << 1)) << 2) + 20;
        this.<>4__this.particleSystem.position = new UnityEngine.Vector3() {x = val_5, y = val_6, z = (0 + ((this.<i>5__2 + (this.<i>5__2) << 1)) << 2) + 24};
        this.<>4__this.particleSystem.Play();
        val_4 = 1;
        this.<>1__state = val_4;
        this.<>2__current = 0;
        return (bool)val_4;
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
