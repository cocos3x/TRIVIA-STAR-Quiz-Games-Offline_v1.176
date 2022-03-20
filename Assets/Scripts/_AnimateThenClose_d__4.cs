using UnityEngine;
private sealed class WGBonusRewardsLevelUpPopup.<AnimateThenClose>d__4 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGBonusRewardsLevelUpPopup <>4__this;
    public int newLevel;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WGBonusRewardsLevelUpPopup.<AnimateThenClose>d__4(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_8;
        object val_9;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_8 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_8;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_1 = null;
        val_9 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_8 = 1;
        this.<>1__state = val_8;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        val_8 = 0;
        UnityEngine.GameObject val_2 = this.<>4__this.gameObject;
        SLCWindow.CloseWindow(window:  this.<>4__this, setDestroyOnDisableState:  false, dontDestroyOnDisable:  false);
        return (bool)val_8;
        label_2:
        this.<>1__state = 0;
        string val_3 = this.newLevel.ToString();
        twelvegigs.Autopilot.AutopilotManager val_4 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        UnityEngine.RectTransform val_5 = this.<>4__this.bonusLevelText.rectTransform;
        val_8 = 1;
        UnityEngine.ParticleSystem val_6 = PlaySFX(reqType:  1, parent:  this.<>4__this.bonusLevelText, playImmediate:  true);
        UnityEngine.WaitForSeconds val_7 = null;
        val_9 = val_7;
        val_7 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>1__state = 2;
        label_4:
        this.<>2__current = val_9;
        return (bool)val_8;
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
