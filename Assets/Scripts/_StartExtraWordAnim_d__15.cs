using UnityEngine;
private sealed class WOLExtraWordFtuxWindow.<StartExtraWordAnim>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Wordlicious.WOLExtraWordFtuxWindow <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WOLExtraWordFtuxWindow.<StartExtraWordAnim>d__15(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        object val_8;
        val_7 = 0;
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
                return (bool)val_7;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_1 = null;
        val_8 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_7 = 1;
        this.<>1__state = val_7;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.ShowFtuxOutro();
        return (bool)val_7;
        label_2:
        this.<>1__state = 0;
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.GameObject val_3 = gameObject;
        UnityEngine.Transform val_4 = transform;
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if((this.<>4__this) != 0)
        {
                PlayAnimation(origin:  -1759400800, target:  SLC.Wordlicious.WOLExtraWordFtuxWindow.TargetLetter, OnAnimFinished:  public static SLC.Wordlicious.WOLFtuxController MonoSingleton<SLC.Wordlicious.WOLFtuxController>::get_Instance().__il2cppRuntimeField_14);
        }
        else
        {
                PlayAnimation(origin:  -1759400800, target:  SLC.Wordlicious.WOLExtraWordFtuxWindow.TargetLetter, OnAnimFinished:  public static SLC.Wordlicious.WOLFtuxController MonoSingleton<SLC.Wordlicious.WOLFtuxController>::get_Instance().__il2cppRuntimeField_14);
        }
        
        this.<>4__this.ftuxIntro.SetActive(value:  false);
        UnityEngine.WaitForSeconds val_6 = null;
        val_8 = val_6;
        val_6 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_7 = 1;
        this.<>1__state = 2;
        label_4:
        this.<>2__current = val_8;
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
