using UnityEngine;
private sealed class ImageQuizDataManager.<>c__DisplayClass29_0
{
    // Fields
    public string word;
    
    // Methods
    public ImageQuizDataManager.<>c__DisplayClass29_0()
    {
    
    }
    internal bool <FindLevelIndexOfWord>b__0(SLC.Minigames.ImageQuiz.QuizLevelData data)
    {
        string val_1 = data.word.ToLowerInvariant();
        string val_2 = this.word.ToLowerInvariant();
        return System.String.op_Equality(a:  data.word, b:  this.word);
    }

}
