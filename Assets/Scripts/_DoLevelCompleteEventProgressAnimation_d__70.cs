using UnityEngine;
private sealed class RaidMadnessEventHandler.<DoLevelCompleteEventProgressAnimation>d__70 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public RaidMadnessEventHandler <>4__this;
    public WGEventButtonV2 eventProgressUI;
    public WGEventButtonV2 eventButton;
    private RaidMadnessEventHandler.<>c__DisplayClass70_1 <>8__1;
    public WGLevelClearPopup popup;
    private RaidMadnessEventHandler.<>c__DisplayClass70_2 <>8__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RaidMadnessEventHandler.<DoLevelCompleteEventProgressAnimation>d__70(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        RaidMadnessEventHandler.<>c__DisplayClass70_1 val_61;
        System.Func<System.Boolean> val_62;
        WGEventButtonV2 val_63;
        object val_64;
        int val_65;
        val_61 = 0;
        if((this.<>1__state) > 7)
        {
                return (bool)val_61;
        }
        
        var val_1 = 8188780 + (8188780 + (this.<>1__state) << 2);
        if((this.<>1__state) == 7)
        {
                val_61 = 0;
            val_61 = val_61 & ((IP) >> 3);
            val_61 = val_61 & ((R8) << 2);
            val_61 = val_61 & ((R8) >> 2);
            val_61 = val_61 & (((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        ));
            val_61 = val_61 & (-1031749529);
            val_61 = val_61 & ((((((((val_61 & (IP) >> 3) & (R8) << 2) & (R8) >> 2) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) & -1031749529)) << (32-18)) | (((((((val_61 & (IP) >> 3) & (R8) << 2) & (R8) >> 2) & ((this) << (32-as. 
            
        
        
        
        
        
           
        )) | ((this) << as. 
            
        
        
        
        
        
           
        )) & -1031749529)) << 18));
            val_61 = val_61 & (val_61 >> 3);
        }
        
        this.<>1__state = 0;
        object val_2 = null;
        val_62 = val_2;
        val_2 = new System.Object();
        if(val_62 != 0)
        {
                typeof(RaidMadnessEventHandler.<>c__DisplayClass70_0).__il2cppRuntimeField_8 = this.<>4__this;
            typeof(RaidMadnessEventHandler.<>c__DisplayClass70_0).__il2cppRuntimeField_C = this.eventProgressUI;
            val_63 = this.eventButton;
        }
        else
        {
                mem[8] = this.<>4__this;
            mem[12] = this.eventProgressUI;
            val_63 = this.eventButton;
        }
        
        typeof(RaidMadnessEventHandler.<>c__DisplayClass70_0).__il2cppRuntimeField_10 = val_63;
        if((this.<>4__this.<ProgressDisplayPoints>k__BackingField) >= 1)
        {
                this.<>8__1 = new System.Object();
            typeof(RaidMadnessEventHandler.<>c__DisplayClass70_1).__il2cppRuntimeField_10 = val_62;
            this.<>8__1.CS$<>8__locals1.eventButton.canvasGroup.alpha = null;
            DG.Tweening.Tweener val_56 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>8__1.CS$<>8__locals1.eventButton.canvasGroup, endValue:  null, duration:  null);
            object val_57 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.<>8__1.CS$<>8__locals1.eventButton.canvasGroup, delay:  null);
            UnityEngine.WaitForSeconds val_58 = null;
            val_64 = val_58;
            val_58 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_61 = 1;
            this.<>1__state = val_61;
        }
        else
        {
                this.eventButton + 12.alpha = null;
            DG.Tweening.Tweener val_59 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.eventButton + 12, endValue:  null, duration:  null);
            UnityEngine.WaitForSeconds val_60 = null;
            val_64 = val_60;
            val_60 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_65 = 7;
            this.<>1__state = val_65;
            val_61 = 1;
        }
        
        this.<>2__current = val_64;
        return (bool)val_61;
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
