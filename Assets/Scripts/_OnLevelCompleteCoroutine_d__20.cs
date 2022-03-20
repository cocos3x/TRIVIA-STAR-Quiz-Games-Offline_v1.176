using UnityEngine;
private sealed class WordBalloonUIController.<OnLevelCompleteCoroutine>d__20 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Minigames.WordBalloon.WordBalloonUIController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WordBalloonUIController.<OnLevelCompleteCoroutine>d__20(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
            this.<>1__state = 0;
            this.<>4__this.levelCompleteOverlay.alpha = null;
            UnityEngine.GameObject val_1 = this.<>4__this.levelCompleteOverlay.gameObject;
            val_4 = 1;
            this.<>4__this.levelCompleteOverlay.SetActive(value:  true);
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions46.DOFade(target:  this.<>4__this.levelCompleteOverlay, endValue:  null, duration:  null);
            this.<>1__state = val_4;
            this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
            return (bool)val_4;
        }
        
        this.<>1__state = 0;
        0.ProceedToNewLevel();
        return (bool)val_4;
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
