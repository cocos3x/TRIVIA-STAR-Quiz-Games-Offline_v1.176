using UnityEngine;
private sealed class ImageQuizUIController.<OnLevelCompleteCoroutine>d__31 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Minigames.ImageQuiz.ImageQuizUIController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ImageQuizUIController.<OnLevelCompleteCoroutine>d__31(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_10;
        SLC.Minigames.ImageQuiz.ImageQuizUIController val_11;
        val_10 = 0;
        val_11 = this.<>4__this;
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
                return (bool)val_10;
        }
        
        this.<>1__state = 0;
        this.<>4__this.clueImageDisplay.ToggleResultOverlay(isVisible:  true, isCorrect:  true);
        twelvegigs.Autopilot.AutopilotManager val_1 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        PlayGameSpecificSound(id:  -478113648, clipIndex:  0, volumeScale:  null);
        UnityEngine.WaitForSeconds val_2 = null;
        val_11 = val_2;
        val_2 = new UnityEngine.WaitForSeconds(seconds:  null);
        val_10 = 1;
        this.<>1__state = val_10;
        label_27:
        this.<>2__current = val_11;
        return (bool)val_10;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.loadingIndicator.Show(isVisible:  false);
        label_23:
        val_11.DisplayLevel();
        return (bool)val_10;
        label_2:
        this.<>1__state = 0;
        this.<>4__this.gameplayUIGroup.alpha = null;
        twelvegigs.Autopilot.AutopilotManager val_3 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(HandleLevelComplete() != false)
        {
                val_10 = 0;
            this.<>4__this.checkpointSlider.UpdateUI();
            return (bool)val_10;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_5 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        if(HasLevelData() == true)
        {
            goto label_23;
        }
        
        this.<>4__this.loadingIndicator.Show(isVisible:  true);
        twelvegigs.Autopilot.AutopilotManager val_7 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        System.Func<System.Boolean> val_8 = new System.Func<System.Boolean>(object:  1050323136, method:  new IntPtr(1080803008));
        UnityEngine.WaitUntil val_9 = new UnityEngine.WaitUntil(predicate:  7667712);
        this.<>1__state = 2;
        goto label_27;
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
