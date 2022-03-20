using UnityEngine;
private sealed class SnakeBlockController.<Continue>d__41 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Minigames.SnackBlock.SnakeBlockController <>4__this;
    private System.Collections.Generic.List.Enumerator<UnityEngine.GameObject> <>7__wrap1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SnakeBlockController.<Continue>d__41(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
        if((this.<>1__state) != 3)
        {
                return;
        }
        
        this.<>m__Finally1();
    }
    private bool MoveNext()
    {
        bool val_14;
        SLC.Minigames.SnackBlock.SnakeBlockController val_15;
        List.Enumerator<UnityEngine.GameObject> val_16;
        UnityEngine.SpriteRenderer val_17;
        object val_18;
        val_14 = 0;
        val_15 = this.<>4__this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_14;
        }
        
        this.<>1__state = 0;
        if(val_15 == 0)
        {
            goto label_4;
        }
        
        this.<>4__this.resetting = true;
        goto label_5;
        label_2:
        val_16 = this.<>7__wrap1;
        this.<>1__state = 2;
        goto label_6;
        label_1:
        this.<>1__state = 0;
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        float val_2 = getSpeedForLevel;
        if(val_15 == 0)
        {
            goto label_10;
        }
        
        this.<>4__this.speed = 1022897152;
        this.<>4__this.cachedSpeed = 1022897152;
        goto label_11;
        label_4:
        mem[100] = 1;
        label_5:
        val_15.enabled = true;
        float val_3 = val_15.liveDeductionInterval;
        this.<>4__this.removeTailProgress = val_15;
        if((this.<>4__this.startingLifes) >= 1)
        {
                var val_14 = 0;
            do
        {
            val_15.AddTail();
            val_14 = val_14 + 1;
        }
        while(val_14 < (this.<>4__this.startingLifes));
        
        }
        
        this.<>4__this.speed = 0f;
        List.Enumerator<T> val_4 = GetEnumerator();
        this.<>1__state = 2;
        label_6:
        if((this.<>7__wrap1.MoveNext()) == false)
        {
            goto label_17;
        }
        
        object val_6 = null;
        val_15 = val_6;
        val_6 = new System.Object();
        if(val_15 == 0)
        {
            goto label_18;
        }
        
        val_17 = val_15;
        typeof(SnakeBlockController.<>c__DisplayClass41_0).__il2cppRuntimeField_8 = this.<>4__this.myTails;
        goto label_19;
        label_17:
        this.<>m__Finally1();
        UnityEngine.WaitForSeconds val_7 = null;
        val_18 = val_7;
        val_7 = new UnityEngine.WaitForSeconds(seconds:  val_15);
        val_14 = 1;
        this.<>1__state = 2;
        goto label_20;
        label_10:
        mem[36] = 1022897152;
        mem[40] = mem[36];
        label_11:
        val_14 = false;
        this.<>4__this.resetting = val_14;
        return (bool)val_14;
        label_18:
        val_17 = 8;
        mem[8] = this.<>4__this.myTails;
        label_19:
        object val_8 = val_17.GetComponent<System.Object>();
        DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions43.DOFade(target:  val_17, endValue:  val_15, duration:  null);
        DG.Tweening.TweenCallback val_10 = new DG.Tweening.TweenCallback(object:  453939200, method:  new IntPtr(1026452112));
        object val_11 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  val_17, action:  190734336);
        object val_12 = DG.Tweening.TweenSettingsExtensions.SetLoops<System.Object>(t:  val_17, loops:  3);
        UnityEngine.WaitForSeconds val_13 = null;
        val_18 = val_13;
        val_13 = new UnityEngine.WaitForSeconds(seconds:  val_15);
        val_14 = 1;
        this.<>1__state = val_14;
        label_20:
        this.<>2__current = val_18;
        return (bool)val_14;
    }
    private void <>m__Finally1()
    {
        this.<>1__state = 0;
        this.<>7__wrap1.Dispose();
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
