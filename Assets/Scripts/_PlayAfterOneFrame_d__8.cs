using UnityEngine;
private sealed class DOTextAnimationAfterLocalization.<PlayAfterOneFrame>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public DG.Tweening.DOTextAnimationAfterLocalization <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DOTextAnimationAfterLocalization.<PlayAfterOneFrame>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        UnityEngine.UI.Text val_6;
        if((this.<>1__state) != 1)
        {
                val_5 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_5;
        }
        
            val_5 = 1;
            this.<>1__state = val_5;
            this.<>2__current = 0;
            return (bool)val_5;
        }
        
        this.<>1__state = 0;
        val_6 = this.<>4__this.text;
        val_5 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  val_6)) == false)
        {
                return (bool)val_5;
        }
        
        val_6 = this.<>4__this.customScramble;
        val_5 = 0;
        DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOText(target:  this.<>4__this.text, endValue:  this.<>4__this.text, duration:  null, richTextEnabled:  this.<>4__this.duration, scrambleMode:  this.<>4__this.richText, scrambleChars:  this.<>4__this.scrambleMode);
        object val_3 = DG.Tweening.TweenSettingsExtensions.SetDelay<System.Object>(t:  this.<>4__this.text, delay:  null);
        object val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<System.Object>(t:  this.<>4__this.text, ease:  this.<>4__this.ease);
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
