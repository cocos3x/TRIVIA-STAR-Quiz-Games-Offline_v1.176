using UnityEngine;
private sealed class ImageQuizUIController.<OnMinigameEndCoroutine>d__33 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Minigames.ImageQuiz.ImageQuizUIController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ImageQuizUIController.<OnMinigameEndCoroutine>d__33(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        SLC.Minigames.ImageQuiz.ImageQuizUIController val_6;
        int val_7;
        val_6 = this.<>4__this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_7 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_7;
        }
        
        this.<>1__state = 0;
        this.<>4__this.clueImageDisplay.ToggleResultOverlay(isVisible:  true, isCorrect:  false);
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PlayGameSpecificSound(id:  1081526208, clipIndex:  0, volumeScale:  null);
        UnityEngine.WaitForSeconds val_2 = null;
        val_6 = val_2;
        val_2 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_7 = 1;
        this.<>1__state = val_7;
        this.<>2__current = val_6;
        return (bool)val_7;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.gameplayUIGroup.alpha = null;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_7 = 0;
        bool val_4 = HandleLevelFailed();
        return (bool)val_7;
        label_2:
        this.<>1__state = 0;
        this.<>4__this.clueImageDisplay.ToggleResultOverlay(isVisible:  false, isCorrect:  false);
        this.<>4__this.wordInputDisplay.ShowAnswer();
        this.<>1__state = 2;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  null);
        val_7 = 1;
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
