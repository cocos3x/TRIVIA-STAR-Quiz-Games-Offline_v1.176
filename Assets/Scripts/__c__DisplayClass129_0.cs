using UnityEngine;
private sealed class WPTGameUIController.<>c__DisplayClass129_0
{
    // Fields
    public string foundHintWord;
    
    // Methods
    public WPTGameUIController.<>c__DisplayClass129_0()
    {
    
    }
    internal bool <DoLevelAnswerNotification>b__2(WordPets.WPTLetterTile x)
    {
        string val_1 = this.foundHintWord.ToLower();
        return System.Linq.Enumerable.Contains<System.Char>(source:  this.foundHintWord, value:  x.myCharacter);
    }

}
