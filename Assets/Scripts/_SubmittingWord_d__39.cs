using UnityEngine;
private sealed class ImageQuizDisplayWord.<SubmittingWord>d__39 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Minigames.ImageQuiz.ImageQuizDisplayWord <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ImageQuizDisplayWord.<SubmittingWord>d__39(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_4;
        int val_5;
        val_4 = this;
        val_5 = 0;
        if((this.<>1__state) >= 2)
        {
                return (bool)val_5;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this.IsTilesAnimating()) != false)
        {
                val_5 = 1;
            this.<>1__state = val_5;
            this.<>2__current = 0;
            return (bool)val_5;
        }
        
        twelvegigs.Autopilot.AutopilotManager val_2 = MonoSingleton<twelvegigs.Autopilot.AutopilotManager>.Instance;
        val_4 = public static SLC.Minigames.ImageQuiz.ImageQuizMinigameManager MonoSingleton<SLC.Minigames.ImageQuiz.ImageQuizMinigameManager>::get_Instance();
        string val_3 = this.<>4__this.GetCurrentInput();
        SubmitWord(word:  this.<>4__this);
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
