using UnityEngine;
private sealed class WordQuizFTUXManager.<ShowHand>d__6 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SLC.Minigames.WordQuiz.WordQuizFTUXManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WordQuizFTUXManager.<ShowHand>d__6(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_2;
        SLC.Minigames.WordQuiz.WordQuizFTUXManager val_3;
        SLC.Minigames.WordQuiz.WordQuizUIController val_4;
        val_2 = 0;
        val_3 = this.<>4__this;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_2;
        }
        
            this.<>1__state = 0;
            this.<>4__this.wordQuizUIController.HideFTUXHand();
            UnityEngine.WaitForSeconds val_1 = null;
            val_3 = val_1;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            val_2 = 1;
            this.<>1__state = val_2;
            this.<>2__current = val_3;
            return (bool)val_2;
        }
        
        this.<>1__state = 0;
        if(val_3 != 0)
        {
                val_4 = this.<>4__this.wordQuizUIController;
        }
        else
        {
                val_4 = 0;
        }
        
        val_3 = this.<>4__this.currentLetter;
        val_4.ShowFTUXHand(tile:  val_3);
        return (bool)val_2;
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
