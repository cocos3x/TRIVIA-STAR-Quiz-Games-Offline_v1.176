using UnityEngine;
private sealed class TRVLevelComplete.<PlayStreakAnimation>d__81 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TRVLevelComplete <>4__this;
    private TRVLevelComplete.<>c__DisplayClass81_0 <>8__1;
    private UnityEngine.CanvasGroup <cg>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TRVLevelComplete.<PlayStreakAnimation>d__81(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        TRVLevelComplete.<>c__DisplayClass81_0 val_42;
        int val_43;
        int val_44;
        if((this.<>1__state) <= 5)
        {
                var val_1 = 10784284 + (10784284 + (this.<>1__state) << 2);
            if((this.<>1__state) == 5)
        {
                10784284 + (this.<>1__state) << 2 = (10784284 + (this.<>1__state) << 2) & ((R8) << 10784284 + (this.<>1__state) << 2);
            10784284 + (this.<>1__state) << 2 = (10784284 + (this.<>1__state) << 2) & ((R8) >> 10784284);
            10784284 + (this.<>1__state) << 2 = (10784284 + (this.<>1__state) << 2) & 241109632;
            10784284 + (this.<>1__state) << 2 = (10784284 + (this.<>1__state) << 2) & ((10784284 + (this.<>1__state) << 2) >> 5);
            10784284 + (this.<>1__state) << 2 = (10784284 + (this.<>1__state) << 2) & (((IP) << (32-11)) | ((IP) << 11));
            10784284 + (this.<>1__state) << 2 = (10784284 + (this.<>1__state) << 2) & ((((((((10784284 + (this.<>1__state) << 2 & (R8) << 10784284 + (this.<>1__state) << 2) & (R8) >> 10784284) & 241109632) & ((((10784284 + (this.<>1__state) << 2 & (R8) << 10784284 + (this.<>1__state) << 2) << (32-12)) | (((((((10784284 + (this.<>1__state) << 2 & (R8) << 10784284 + (this.<>1__state) << 2) & (R8) >> 10784284) & 241109632) & ((((10784284 + (this.<>1__state) << 2 & (R8) << 10784284 + (this.<>1__state) << 2) << 12));
        }
        
            this.<>1__state = 0;
            this.<>8__1 = new System.Object();
            typeof(TRVLevelComplete.<>c__DisplayClass81_0).__il2cppRuntimeField_C = this.<>4__this;
            val_42 = 1152921511033624480;
            UnityEngine.UI.LayoutElement val_3 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  this.<>4__this.chestGroup);
            this.<>4__this.chestGroup.alpha = null;
            UnityEngine.GameObject val_4 = this.<>4__this.streakReward.gameObject;
            this.<>4__this.streakReward.SetActive(value:  false);
            UnityEngine.UI.LayoutElement val_5 = MethodExtensionForMonoBehaviourTransform.GetOrAddComponent<UnityEngine.UI.LayoutElement>(gameObject:  this.<>4__this.streakGroup);
            this.<cg>5__2 = this.<>4__this.streakGroup;
            this.<>4__this.streakGroup.alpha = null;
            UnityEngine.WaitForSeconds val_6 = null;
            val_43 = val_6;
            val_6 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_44 = 1;
            this.<>1__state = val_44;
        }
        else
        {
                val_44 = 0;
            return (bool);
        }
        
        this.<>2__current = ;
        return (bool);
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
