using UnityEngine;
private sealed class WFOWildWeekendHandler.<DoLevelCompleteEventProgressAnimation>d__4 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WGEventButtonV2 eventButton;
    public WFOWildWeekendHandler <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WFOWildWeekendHandler.<DoLevelCompleteEventProgressAnimation>d__4(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_18;
        UnityEngine.UI.Text val_19;
        var val_20;
        object val_21;
        val_18 = 0;
        if((this.<>1__state) > 3)
        {
                return (bool);
        }
        
        var val_1 = 8395656 + (8395656 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                val_18 = val_18 & 0;
            val_18 = val_18 & 752741132;
            val_18 = val_18 & (this >> R3);
        }
        
        this.<>1__state = 0;
        this.eventButton.canvasGroup.alpha = null;
        val_19 = this.eventButton.buttonLabel;
        int val_2 = this.<>4__this.GetLevelsComplete();
        val_2 = val_2 - 1;
        string val_3 = val_2.ToString();
        val_20;
        string val_5 = this.<>4__this.GetLevelsTotal().ToString();
        string val_6 = System.String.Format(format:  1629069648, arg0:  -1284014804, arg1:  -1284014804);
        DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.eventButton.canvasGroup, endValue:  null, duration:  null);
        object val_8 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.eventButton.canvasGroup, delay:  null);
        UnityEngine.WaitForSeconds val_9 = null;
        val_21 = val_9;
        val_9 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_18 = 1;
        this.<>1__state = val_18;
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
