using UnityEngine;
private sealed class ImageQuizUIController.<>c__DisplayClass46_0
{
    // Fields
    public SLC.Minigames.ImageQuiz.ImageQuizUIController <>4__this;
    public SLC.Minigames.ImageQuiz.ImageQuizLetterButton buttonToHighlight;
    
    // Methods
    public ImageQuizUIController.<>c__DisplayClass46_0()
    {
    
    }
    internal void <FtuxHighlightAction>b__0()
    {
        UnityEngine.GameObject val_1 = this.<>4__this.ftuxPointer.gameObject;
        this.<>4__this.ftuxPointer.SetActive(value:  true);
        UnityEngine.GameObject val_2 = this.buttonToHighlight.gameObject;
        this.<>4__this.ftuxPointer.PointAt(targetObj:  this.buttonToHighlight, flipPointerX:  false, flipPointerY:  false);
    }

}
