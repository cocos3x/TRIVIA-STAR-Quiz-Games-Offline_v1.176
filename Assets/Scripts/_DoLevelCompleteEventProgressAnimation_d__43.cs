using UnityEngine;
private sealed class LightningLevelsEventHandler.<DoLevelCompleteEventProgressAnimation>d__43 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGEventButtonV2 eventProgressUI;
    public LightningLevelsEventHandler <>4__this;
    public WGEventButtonV2 eventButton;
    private LightningLevelsEventHandler.<>c__DisplayClass43_1 <>8__1;
    private LightningLevelsEventHandler.<>c__DisplayClass43_2 <>8__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LightningLevelsEventHandler.<DoLevelCompleteEventProgressAnimation>d__43(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        LightningLevelsEventHandler.<>c__DisplayClass43_1 val_60;
        WGEventButtonV2 val_61;
        System.Func<System.Boolean> val_62;
        object val_63;
        int val_64;
        LightningLevelsEventPrgress val_76;
        val_60 = 0;
        if((this.<>1__state) > 5)
        {
                return (bool)val_60;
        }
        
        var val_1 = 11934496 + (11934496 + (this.<>1__state) << 2);
        if((this.<>1__state) == 5)
        {
                val_60 = val_60 & ((R8) << val_60);
            mem2[0] = (val_60 & (R8) << val_60) + IP;
            mem2[0] = ((val_60 & (R8) << val_60) + IP & (((val_60 & (R8) << val_60) + IP) << (32-(val_60 & (R8) << val_60) + IP)) | (((val_60 & (R8) << val_60) + IP) << (val_60 & (R8) << val_60) + IP)) + R8;
            (((val_60 & (R8) << val_60) + IP & (((val_60 & (R8) << val_60) + IP) << (32-(val_60 & (R8) << val_60) + IP)) | (((val_60 & (R8) << val_60) + IP) << (val_60 & (R8) << val_60) + IP)) + R8) & (((int)IP) >> ((val_60 & (R8) << val_60) + IP & (((val_60 & (R8) << val_60) + IP) << (32-(val_60 & (R8) << val_60) + IP)) | (((val_60 & (R8) << val_60) + IP) << (val_60 & (R8) << val_60) + IP)) + R8) = ((((val_60 & (R8) << val_60) + IP & (((val_60 & (R8) << val_60) + IP) << (32-(val_60 & (R8) << val_60) + IP)) | (((val_60 & (R8) << val_60) + IP) << (val_60 & (R8) << val_60) + IP)) + R8) & (((int)IP) >> ((val_60 & (R8) << val_60) + IP & (((val_60 & (R8) << val_60) + IP) << (32-(val_60 & (R8) << val_60) + IP)) | (((val_60 & (R8) << val_60) + IP) << (val_60 & (R8) << val_60) + IP)) + R8)) & (this >> SB);
        }
        
        this.<>1__state = 0;
        object val_2 = new System.Object();
        if(val_2 != 0)
        {
                typeof(LightningLevelsEventHandler.<>c__DisplayClass43_0).__il2cppRuntimeField_8 = this.eventProgressUI;
            typeof(LightningLevelsEventHandler.<>c__DisplayClass43_0).__il2cppRuntimeField_C = this.<>4__this;
            val_61 = this.eventButton;
        }
        else
        {
                mem[8] = this.eventProgressUI;
            mem[12] = this.<>4__this;
            val_61 = this.eventButton;
        }
        
        typeof(LightningLevelsEventHandler.<>c__DisplayClass43_0).__il2cppRuntimeField_10 = val_61;
        val_76 = this.<>4__this.eventProgress;
        int val_60 = this.<>4__this.<CacheOverallEventProgress>k__BackingField;
        val_60 = 0 - val_60;
        if(val_60 >= 1)
        {
                object val_54 = null;
            val_62 = val_54;
            val_54 = new System.Object();
            this.<>8__1 = val_62;
            typeof(LightningLevelsEventHandler.<>c__DisplayClass43_1).__il2cppRuntimeField_10 = val_2;
            this.<>8__1.CS$<>8__locals1.eventButton.canvasGroup.alpha = null;
            DG.Tweening.Tweener val_55 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>8__1.CS$<>8__locals1.eventButton.canvasGroup, endValue:  null, duration:  null);
            object val_56 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.<>8__1.CS$<>8__locals1.eventButton.canvasGroup, delay:  null);
            UnityEngine.WaitForSeconds val_57 = null;
            val_63 = val_57;
            val_57 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_60 = 1;
            this.<>1__state = val_60;
        }
        else
        {
                val_62 = mem[this.eventButton + 12];
            val_62 = this.eventButton + 12;
            val_62.alpha = null;
            DG.Tweening.Tweener val_58 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.eventButton + 12, endValue:  null, duration:  null);
            UnityEngine.WaitForSeconds val_59 = null;
            val_63 = val_59;
            val_59 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_64 = 5;
            this.<>1__state = val_64;
            val_60 = 1;
        }
        
        this.<>2__current = val_63;
        return (bool)val_60;
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
