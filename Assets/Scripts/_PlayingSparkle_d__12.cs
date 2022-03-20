using UnityEngine;
private sealed class AnimatedCoin.<PlayingSparkle>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float delay;
    public AnimatedCoin <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AnimatedCoin.<PlayingSparkle>d__12(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        object val_6;
        var val_7;
        var val_8;
        var val_9;
        if((this.<>1__state) != 1)
        {
                val_5 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_5;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = null;
            val_6 = val_1;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_5 = 1;
            this.<>1__state = val_5;
            this.<>2__current = val_6;
            return (bool)val_5;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
                val_7 = 0;
            this.<>4__this.particlesMainModule.startLifetimeMultiplier = null;
        }
        else
        {
                val_7 = 0;
            16.startLifetimeMultiplier = null;
        }
        
        this.<>4__this.particlesStartColor.color = new UnityEngine.Color() {r = mem[this.<>4__this.originalParticleColor + (0)], g = mem[this.<>4__this.originalParticleColor + (4)], b = mem[this.<>4__this.originalParticleColor + (8)], a = 2.242078E-44f};
        AnimatedCoin val_2 = (this.<>4__this) + 32;
        AnimatedCoin val_3 = (this.<>4__this) + 44;
        16.startColor = new MinMaxGradient() {m_Mode = mem[this.<>4__this.particlesStartColor + (0)], m_GradientMin = mem[this.<>4__this.particlesStartColor + (4)], m_GradientMax = mem[this.<>4__this.particlesStartColor + (8)], m_ColorMin = new UnityEngine.Color() {r = mem[(this.<>4__this + 32) + (0)], g = mem[(this.<>4__this + 32) + (4)], b = mem[(this.<>4__this + 32) + (8)], a = mem[(this.<>4__this + 44) + (0)]}, m_ColorMax = new UnityEngine.Color() {r = mem[(this.<>4__this + 44) + (4)], g = mem[(this.<>4__this + 44) + (8)], b = ???, a = ???}};
        this.<>4__this.particleSystem.Play();
        val_6 = 0;
        val_6 = val_6 + 1;
        val_8 = (uint)val_6 & 65535;
        val_9 = this.<>4__this.gridCoinCollectAnimation;
        val_5 = 0;
        return (bool)val_5;
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
