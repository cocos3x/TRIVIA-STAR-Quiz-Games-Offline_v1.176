using UnityEngine;
private sealed class WGWindowBackgroundHandler.<>c__DisplayClass14_1
{
    // Fields
    public float fadeTime;
    public WGWindowBackgroundHandler.<>c__DisplayClass14_0 CS$<>8__locals1;
    
    // Methods
    public WGWindowBackgroundHandler.<>c__DisplayClass14_1()
    {
    
    }
    internal void <FadeOutOldDarkness>b__2()
    {
        if((this.CS$<>8__locals1) != 0)
        {
            goto label_0;
        }
        
        this.CS$<>8__locals1 = this.CS$<>8__locals1;
        if((this.CS$<>8__locals1) == 0)
        {
            goto label_1;
        }
        
        label_0:
        this.CS$<>8__locals1.<>4__this.FadeInNextDarkness(nextBackground:  this.CS$<>8__locals1.nextBackground, duration:  null);
        return;
        label_1:
    }

}
