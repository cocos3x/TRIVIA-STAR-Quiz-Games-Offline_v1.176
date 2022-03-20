using UnityEngine;
public class WordIQFeedbackWord : MonoSingleton<WordIQFeedbackWord>
{
    // Fields
    public UnityEngine.GameObject displayGroup;
    private UnityEngine.UI.Text wordText;
    private System.Collections.Generic.Queue<string> queuedWords;
    
    // Methods
    public void ShowIQWord(string word)
    {
        this.queuedWords.Enqueue(item:  word);
    }
    public bool WantsToShow()
    {
        if(R1 > 0)
        {
                0 = 1;
        }
        
        return true;
    }
    public void UpdateDisplay()
    {
        string val_1 = this.queuedWords.Dequeue();
        if(this.wordText == 0)
        {
            
        }
    
    }
    public WordIQFeedbackWord()
    {
        System.Collections.Generic.Queue<twelvegigs.net.JsonRequest> val_1 = new System.Collections.Generic.Queue<twelvegigs.net.JsonRequest>();
        this.queuedWords = null;
    }

}
