using UnityEngine;
private sealed class WordRegion.<>c__DisplayClass98_0
{
    // Fields
    public bool removeGroup;
    public UnityEngine.Canvas cg;
    public UnityEngine.ParticleSystem ps;
    
    // Methods
    public WordRegion.<>c__DisplayClass98_0()
    {
    
    }
    internal void <DoHintAnimation>b__0()
    {
        if(this.removeGroup != false)
        {
                this.cg.overrideSorting = false;
            UnityEngine.Object.Destroy(obj:  this.cg);
        }
        
        if(this.ps == 0)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  this.ps);
    }

}
